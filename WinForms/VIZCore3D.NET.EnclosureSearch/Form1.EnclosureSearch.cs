using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.EnclosureSearch
{
    /// <summary>
    /// 공간 기준 개체 검색 : vizcore3d.EnclosureSearch (EnclosureSearchManager) 사용 예제
    /// <br/>선택한 노드(구획 등)가 둘러싼 공간을 기준으로, Part 가 내부 / 걸침 / 외부 / 판정 불가 인지 검색한다.
    /// <br/>VIZCore3D.NET 2.8.26.1116 부터 지원.
    /// </summary>
    public partial class Form1
    {
        private Panel panelSide;
        private Button btnSearch, btnResetView, btnCancel;
        private ProgressBar progressBar;
        private Label lblProgress;
        private int lastProgressTick;
        private NumericUpDown numPrecision, numTol, numGap;
        private CheckBox chkTouching, chkColor, chkGroup;
        private ListView lvResult;
        private TextBox txtLog;

        private void InitializeEnclosureSearchUi()
        {
            panelSide = new Panel { Dock = DockStyle.Right, Width = 400, Padding = new Padding(8), Enabled = false };

            var grid = new TableLayoutPanel { Dock = DockStyle.Top, ColumnCount = 2, RowCount = 3, Height = 90 };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            numPrecision = new NumericUpDown { Minimum = 0, Maximum = 1000000, DecimalPlaces = 1, Value = 0, Dock = DockStyle.Fill };
            numTol = new NumericUpDown { Minimum = 0, Maximum = 1000, DecimalPlaces = 2, Value = 1, Dock = DockStyle.Fill };
            grid.Controls.Add(new Label { Text = "판정 정밀도 (0 = 자동)", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
            grid.Controls.Add(numPrecision, 1, 0);
            grid.Controls.Add(new Label { Text = "접촉 허용 거리 (모델 단위)", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 1);
            grid.Controls.Add(numTol, 1, 1);
            numGap = new NumericUpDown { Minimum = 0, Maximum = 1000000, DecimalPlaces = 1, Value = 0, Dock = DockStyle.Fill };
            grid.Controls.Add(new Label { Text = "개구부 메움 크기 (0 = 사용 안 함)", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft }, 0, 2);
            grid.Controls.Add(numGap, 1, 2);

            chkTouching = new CheckBox { Text = "외부에서 경계에 닿은 Part 도 표시", Dock = DockStyle.Top, Height = 22 };
            chkColor = new CheckBox { Text = "결과 색상 표시 (내부=파랑, 걸침=노랑, 이외=흰색)", Dock = DockStyle.Top, Height = 22, Checked = true };
            chkGroup = new CheckBox { Text = "선택한 패널이 속한 구역 전체를 공간으로", Dock = DockStyle.Top, Height = 22, Checked = true };

            btnSearch = new Button { Text = "공간 검색 (선택한 노드 = 공간)", Dock = DockStyle.Top, Height = 32 };
            btnSearch.Click += btnSearch_Click;
            btnResetView = new Button { Text = "표시 초기화", Dock = DockStyle.Top, Height = 26 };
            btnResetView.Click += btnResetView_Click;

            progressBar = new ProgressBar { Dock = DockStyle.Top, Height = 16, Minimum = 0, Maximum = 100 };
            lblProgress = new Label { Dock = DockStyle.Top, Height = 34, Text = "대기 중", TextAlign = ContentAlignment.MiddleLeft };
            btnCancel = new Button { Text = "중지", Dock = DockStyle.Top, Height = 26, Enabled = false };
            btnCancel.Click += btnCancel_Click;

            lvResult = new ListView { Dock = DockStyle.Fill, View = View.Details, FullRowSelect = true, HideSelection = false, MultiSelect = false };
            lvResult.Columns.Add("공간", 150);
            lvResult.Columns.Add("Part", 170);
            lvResult.Columns.Add("위치 관계", 80);
            lvResult.Columns.Add("접촉", 45);
            lvResult.SelectedIndexChanged += lvResult_SelectedIndexChanged;
            lvResult.DoubleClick += lvResult_DoubleClick;

            txtLog = new TextBox { Dock = DockStyle.Bottom, Height = 150, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical };

            // Dock 순서 : 나중에 추가한 컨트롤이 먼저 배치되므로 Fill → Bottom → Top(아래에서 위 순) 으로 추가
            panelSide.Controls.Add(lvResult);
            panelSide.Controls.Add(new Splitter { Dock = DockStyle.Bottom, Height = 6, MinSize = 40, MinExtra = 80, BackColor = SystemColors.ControlDark });   // 목록 ↔ 요약 높이 조절
            panelSide.Controls.Add(txtLog);
            panelSide.Controls.Add(btnResetView);
            panelSide.Controls.Add(btnCancel);
            panelSide.Controls.Add(lblProgress);
            panelSide.Controls.Add(progressBar);
            panelSide.Controls.Add(btnSearch);
            panelSide.Controls.Add(chkGroup);
            panelSide.Controls.Add(chkColor);
            panelSide.Controls.Add(chkTouching);
            panelSide.Controls.Add(grid);

            // 3D 화면 ↔ 사이드 패널 너비 조절
            var splitSide = new Splitter { Dock = DockStyle.Right, Width = 6, MinSize = 260, MinExtra = 300, BackColor = SystemColors.ControlDark };
            Controls.Add(panelSide);
            Controls.Add(splitSide);
            splitSide.SendToBack();
            panelSide.SendToBack();   // 사이드 패널이 오른쪽을 먼저 차지하고, 분할선이 그 왼쪽에 붙는다
        }

        private void OnEnclosureSearchReady()
        {
            // 검색 진행 이벤트
            vizcore3d.EnclosureSearch.OnEnclosureSearchProgressChangedEvent += EnclosureSearch_OnEnclosureSearchProgressChangedEvent;

            panelSide.Enabled = true;
        }

        // ================================================================
        // 버튼 : 검색 / 중지
        // ================================================================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 1. 공간으로 사용할 노드 : 현재 선택된 노드
            List<VIZCore3D.NET.Data.Node> spaces = GetSpaceNodes();
            if (spaces.Count == 0)
            {
                MessageBox.Show(this, "공간으로 쓸 노드(닫힌 형상)를 먼저 선택하세요.", "공간 검색", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. 검색 옵션
            VIZCore3D.NET.Data.EnclosureSearchOption option = new VIZCore3D.NET.Data.EnclosureSearchOption();
            option.Precision = (float)numPrecision.Value;   // 판정 정밀도 (0 = 자동)
            option.Tolerance = (float)numTol.Value;         // 접촉 허용 거리
            option.GapSize = (float)numGap.Value;           // 문 등 열린 부분의 폭 이상으로 지정하면 열린 부분을 막고 공간을 찾음 (0 = 사용 안 함)
            option.IncludeOutside = chkTouching.Checked;    // 외부 개체 포함 여부

            // 3. 검색 : 공간(노드)마다 하나의 결과
            SetSearching(true);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<VIZCore3D.NET.Data.EnclosureSearchResult> results;
            try
            {
                results = vizcore3d.EnclosureSearch.Search(spaces, option);
            }
            finally
            {
                SetSearching(false);
            }

            bool canceled = results.Exists(r => r.Status == VIZCore3D.NET.Data.EnclosureSearchStatus.Canceled);
            if (canceled == false) progressBar.Value = 100;
            lblProgress.Text = string.Format(canceled ? "중지됨 ({0:0.0}초) - 여기까지의 결과만 표시" : "완료 ({0:0.0}초)", watch.Elapsed.TotalSeconds);

            // 4. 결과 표시
            ShowResults(results);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 진행 중인 검색 중지 (그때까지 끝난 공간의 결과는 유지)
            vizcore3d.EnclosureSearch.Cancel();

            btnCancel.Enabled = false;
            lblProgress.Text = "중지하는 중...";
        }

        /// <summary>
        /// 검색 진행 이벤트
        /// </summary>
        private void EnclosureSearch_OnEnclosureSearchProgressChangedEvent(object sender, VIZCore3D.NET.Event.EventManager.EnclosureSearchProgressEventArgs e)
        {
            // 화면 갱신은 0.1초에 한 번만 (갱신 자체가 느려지지 않도록)
            int now = Environment.TickCount;
            if (now - lastProgressTick < 100 && e.Progress < 100) return;
            lastProgressTick = now;

            progressBar.Value = e.Progress;
            lblProgress.Text = string.Format("{0}%  공간 {1}/{2} [{3}]", e.Progress, e.Current, e.Total, e.Enclosure != null ? e.Enclosure.NodeName : "");

            Application.DoEvents();   // [중지] 클릭을 받기 위해
        }

        /// <summary>
        /// 선택된 노드를 공간 노드 목록으로 변환
        /// </summary>
        private List<VIZCore3D.NET.Data.Node> GetSpaceNodes()
        {
            var spaces = new List<VIZCore3D.NET.Data.Node>();
            var seen = new HashSet<int>();

            foreach (VIZCore3D.NET.Data.Node selected in vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.SELECTED_TOP))
            {
                VIZCore3D.NET.Data.Node node = chkGroup.Checked ? GetGroupNode(selected) : selected;
                if (node != null && seen.Add(node.Index)) spaces.Add(node);
            }

            return spaces;
        }

        /// <summary>
        /// 선택한 Part(패널)가 속한 구역 노드 : Part → 부모 → 부모가 자식을 하나만 가진 동안 계속 위로
        /// <br/>(예: PANEL → FRMWORK → ... → CAREA_xxx.rvm)
        /// </summary>
        private VIZCore3D.NET.Data.Node GetGroupNode(VIZCore3D.NET.Data.Node node)
        {
            // BODY → PART → 부모 그룹
            for (int k = 0; k < 2 && node != null && node.Kind != VIZCore3D.NET.Data.NodeKind.ASSEMBLY; k++)
                node = GetParent(node);

            // 외동 사슬을 따라 위로
            while (node != null)
            {
                VIZCore3D.NET.Data.Node parent = GetParent(node);
                if (parent == null || parent.ChildCount != 1) break;
                node = parent;
            }

            return node;
        }

        private VIZCore3D.NET.Data.Node GetParent(VIZCore3D.NET.Data.Node node)
        {
            if (node == null || node.Depth <= 0 || node.ParentIndex < 0) return null;
            return vizcore3d.Object3D.FromIndex(node.ParentIndex);
        }

        private void SetSearching(bool searching)
        {
            // 검색 중에는 [중지] 만 누를 수 있게 한다 (화면 갱신 중 다른 버튼이 눌리는 것을 막음)
            btnSearch.Enabled = btnResetView.Enabled = numPrecision.Enabled = numTol.Enabled = numGap.Enabled = !searching;
            chkTouching.Enabled = chkColor.Enabled = chkGroup.Enabled = lvResult.Enabled = !searching;
            panelLeft.Enabled = !searching;
            panelView.Enabled = !searching;
            btnCancel.Enabled = searching;
            Cursor = searching ? Cursors.AppStarting : Cursors.Default;

            if (searching)
            {
                progressBar.Value = 0;
                lastProgressTick = 0;
            }
        }

        private void btnResetView_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();
            vizcore3d.Object3D.Color.RestoreColorAll();
            RestoreResultTransparency();
            vizcore3d.EndUpdate();
            lvResult.Items.Clear();
            txtLog.Clear();
        }

        /// <summary>결과 표시를 위해 투명도를 0% 로 바꿨던 Part (초기화할 때 원래 투명도로 되돌린다)</summary>
        private readonly List<int> opaqueParts = new List<int>();

        private void RestoreResultTransparency()
        {
            if (opaqueParts.Count > 0) vizcore3d.Object3D.Color.RestoreTransparency(opaqueParts);
            opaqueParts.Clear();
        }

        // ================================================================
        // 결과 표시
        // ================================================================
        private void ShowResults(List<VIZCore3D.NET.Data.EnclosureSearchResult> results)
        {
            var inside = new List<int>();
            var crossing = new List<int>();
            var sb = new StringBuilder();

            lvResult.BeginUpdate();
            lvResult.Items.Clear();
            foreach (VIZCore3D.NET.Data.EnclosureSearchResult result in results)
            {
                string space = result.Enclosure != null ? result.Enclosure.NodeName : "";

                // 검색 실패 : 원인 표시
                if (result.Status != VIZCore3D.NET.Data.EnclosureSearchStatus.Success)
                {
                    sb.AppendFormat("[{0}] {1}\r\n", space, GetStatusText(result.Status));
                    continue;
                }

                int touching = 0;
                foreach (VIZCore3D.NET.Data.EnclosureSearchItem item in result.Items)
                {
                    // 외부 개체는 경계에 닿은 것만 표시
                    if (item.Relation == VIZCore3D.NET.Data.EnclosureRelation.Outside)
                    {
                        if (item.Touching == false) continue;
                        touching++;
                    }

                    var lvi = new ListViewItem(new[] { space, item.Node.NodeName, GetRelationText(item.Relation), item.Touching ? "Y" : "" });
                    lvi.Tag = item.Node.Index;
                    lvResult.Items.Add(lvi);
                }

                inside.AddRange(result.GetNodeIndex(VIZCore3D.NET.Data.EnclosureRelation.Inside));
                crossing.AddRange(result.GetNodeIndex(VIZCore3D.NET.Data.EnclosureRelation.Crossing));

                sb.AppendFormat("[{0}] 내부 {1} / 걸침 {2} / 판정 불가 {3}{4}{5}\r\n", space,
                    result.GetCount(VIZCore3D.NET.Data.EnclosureRelation.Inside),
                    result.GetCount(VIZCore3D.NET.Data.EnclosureRelation.Crossing),
                    result.GetCount(VIZCore3D.NET.Data.EnclosureRelation.Undetermined),
                    chkTouching.Checked ? string.Format(" / 외부 접촉 {0}", touching) : "",
                    result.GapClosed ? " (개구부 메움 적용)" : "");
            }
            lvResult.EndUpdate();
            txtLog.Text = sb.ToString();

            if (chkColor.Checked == false) return;

            // 열려 있는 모델 전체를 흰색으로 바꾼 뒤, 내부 = 파랑 / 걸침 = 노랑 (둘 다 투명도 0% = 불투명)
            // 한 Part 가 어떤 공간에서는 걸침, 다른 공간에서는 내부이면 내부(파랑)로 표시한다.
            vizcore3d.BeginUpdate();
            RestoreResultTransparency();
            List<VIZCore3D.NET.Data.Node> allParts = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.PART);
            var allIndex = new List<int>(allParts.Count);
            foreach (VIZCore3D.NET.Data.Node n in allParts) allIndex.Add(n.Index);
            if (allIndex.Count > 0) vizcore3d.Object3D.Color.SetColor(allIndex, Color.White);
            if (crossing.Count > 0) vizcore3d.Object3D.Color.SetColorAndTransparency(crossing, Color.Yellow, 0);
            if (inside.Count > 0) vizcore3d.Object3D.Color.SetColorAndTransparency(inside, Color.Blue, 0);
            opaqueParts.AddRange(crossing);
            opaqueParts.AddRange(inside);
            vizcore3d.EndUpdate();
        }

        private static string GetRelationText(VIZCore3D.NET.Data.EnclosureRelation relation)
        {
            switch (relation)
            {
                case VIZCore3D.NET.Data.EnclosureRelation.Inside: return "내부";
                case VIZCore3D.NET.Data.EnclosureRelation.Crossing: return "걸침";
                case VIZCore3D.NET.Data.EnclosureRelation.Outside: return "외부(접촉)";
                default: return "판정 불가";
            }
        }

        private static string GetStatusText(VIZCore3D.NET.Data.EnclosureSearchStatus status)
        {
            switch (status)
            {
                case VIZCore3D.NET.Data.EnclosureSearchStatus.NoEnclosedSpace: return "둘러싸인 공간을 찾지 못했습니다. 형상이 닫혀 있는지 확인하거나 판정 정밀도를 바꿔 보세요. 문 등 열린 부분이 있으면 개구부 메움 크기를 열린 부분의 폭 이상으로 지정하세요.";
                case VIZCore3D.NET.Data.EnclosureSearchStatus.InvalidShape: return "형상을 확인할 수 없습니다.";
                case VIZCore3D.NET.Data.EnclosureSearchStatus.Canceled: return "중지됨 : 검사하지 않았습니다.";
                default: return status.ToString();
            }
        }

        /// <summary>결과 행 클릭 : 해당 Part 만 선택. 다른 부재에 가려져 있어도 보이도록 "경계로 선택" 표시를 쓴다.</summary>
        private void lvResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems.Count == 0) return;
            int index = (int)lvResult.SelectedItems[0].Tag;

            vizcore3d.BeginUpdate();
            vizcore3d.View.SelectionMode = VIZCore3D.NET.Data.Object3DSelectionOptions.INDIVIDUAL_BOUNDARIES;   // 경계로 선택 (개체)
            vizcore3d.Object3D.Select(VIZCore3D.NET.Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.Object3D.Select(new List<int> { index }, true, true);
            vizcore3d.EndUpdate();
        }

        /// <summary>결과 행 더블 클릭 : 해당 Part 로 비행</summary>
        private void lvResult_DoubleClick(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems.Count == 0) return;
            int index = (int)lvResult.SelectedItems[0].Tag;
            vizcore3d.View.FlyToObject3d(new List<int> { index }, 1.2f);
        }
    }
}
