using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using VIZCore3D.NET.EdgeView.Drawing;
using VIZCore3D.NET;
using VIZCore3D.NET.Data;

namespace VIZCore3D.NET.EdgeView
{
    public class MainForm : Form
    {
        VIZCore3DControl vizcore3d;
        DrawingCanvas canvas;
        SplitContainer split;
        ToolStripStatusLabel lblStatus;

        ToolStripComboBox cboView, cboDock;
        ToolStripButton btnEditPoint, btnContourOnly, btnComputeHidden, btnShowHidden, btnSilhouette, btnClassify, btnHoles, btnDims, btnDark, btn3DEdge;

        // 투영 뷰 목록 (마지막 항목 = 3면도)
        static readonly string[] ViewNames =
        {
            "정면도 (Front)", "배면도 (Back)", "평면도 (Top)", "저면도 (Bottom)",
            "우측면도 (Right)", "좌측면도 (Left)", "자동 - 판 법선 (Auto)", "현재 카메라 방향", "3면도 (제3각법)"
        };
        static readonly ProjectionViewKind[] ViewKinds =
        {
            ProjectionViewKind.FRONT, ProjectionViewKind.BACK, ProjectionViewKind.TOP, ProjectionViewKind.BOTTOM,
            ProjectionViewKind.RIGHT, ProjectionViewKind.LEFT, ProjectionViewKind.AUTO_PLATE, ProjectionViewKind.CAMERA
        };
        const int ThreeView = 8;

        List<int> selection = new List<int>();
        List<KeyValuePair<int, EdgeProjectionGeometry>> parts;   // 파트별 형상 (뷰/옵션 변경 시 재사용)
        readonly Timer selectTimer = new Timer { Interval = 150 };
        bool licensed;

        public MainForm()
        {
            Text = "EdgeView - VIZCore3D.NET 모서리 기반 2D 도면";
            Size = new Size(1500, 950);
            StartPosition = FormStartPosition.CenterScreen;

            BuildUi();

            vizcore3d = new VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            split.Panel1.Controls.Add(vizcore3d);
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;

            selectTimer.Tick += (s, e) => { selectTimer.Stop(); Rebuild(true, true); };
        }

        // ==============================================================
        // UI 구성
        // ==============================================================
        void BuildUi()
        {
            split = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Horizontal, SplitterWidth = 6, BackColor = SystemColors.ControlDark };
            split.Panel1.BackColor = SystemColors.Control;
            split.Panel2.BackColor = SystemColors.Control;

            canvas = new DrawingCanvas { Dock = DockStyle.Fill };
            split.Panel2.Controls.Add(canvas);

            var menu = new ContextMenuStrip();
            menu.Items.Add("화면 맞춤", null, (s, e) => canvas.FitToView());
            menu.Items.Add("DXF 저장...", null, (s, e) => ExportDxf());
            menu.Items.Add("PNG 저장...", null, (s, e) => ExportPng());
            menu.Items.Add("클립보드 복사", null, (s, e) => { using (var b = canvas.RenderToBitmap()) Clipboard.SetImage(b); });
            canvas.ContextMenuStrip = menu;

            // ---- 상단 툴바 1 : 모델 / 뷰
            var tb1 = new ToolStrip { GripStyle = ToolStripGripStyle.Hidden };
            tb1.Items.Add(new ToolStripButton("모델 열기", null, (s, e) => OpenModel()));
            tb1.Items.Add(new ToolStripSeparator());

            tb1.Items.Add(new ToolStripLabel("투영 뷰"));
            cboView = new ToolStripComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 170 };
            cboView.Items.AddRange(ViewNames);
            cboView.SelectedIndex = Array.IndexOf(ViewKinds, ProjectionViewKind.AUTO_PLATE);
            cboView.SelectedIndexChanged += (s, e) => Rebuild(false, true);
            tb1.Items.Add(cboView);
            tb1.Items.Add(new ToolStripButton("카메라 방향 갱신", null, (s, e) => { cboView.SelectedIndex = Array.IndexOf(ViewKinds, ProjectionViewKind.CAMERA); Rebuild(false, true); }));
            tb1.Items.Add(new ToolStripSeparator());

            tb1.Items.Add(new ToolStripLabel("도면 위치"));
            cboDock = new ToolStripComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 70 };
            cboDock.Items.AddRange(new object[] { "하단", "오른쪽" });
            cboDock.SelectedIndex = 0;
            cboDock.SelectedIndexChanged += (s, e) => ApplyDock();
            tb1.Items.Add(cboDock);
            tb1.Items.Add(new ToolStripSeparator());
            btn3DEdge = Toggle("3D Edge 표시", false, (s, e) => vizcore3d.View.ShowEdge(btn3DEdge.Checked));
            tb1.Items.Add(btn3DEdge);

            // ---- 상단 툴바 2 : 도면 옵션 (EdgeProjectionOption)
            var tb2 = new ToolStrip { GripStyle = ToolStripGripStyle.Hidden };
            btnClassify = Toggle("Inner/Outer 분류", true, (s, e) => Rebuild(false, false));
            btnContourOnly = Toggle("Contour만", false, (s, e) => Rebuild(false, false));
            btnComputeHidden = Toggle("은선 판정", true, (s, e) => Rebuild(false, false));
            btnShowHidden = Toggle("은선 표시", true, (s, e) => Rebuild(false, false));
            btnSilhouette = Toggle("곡면 실루엣", false, (s, e) => Rebuild(false, false));
            btnHoles = Toggle("홀 중심선/Ø", true, (s, e) => Rebuild(true, false));
            btnDims = Toggle("전체 치수", true, (s, e) => Rebuild(false, false));
            tb2.Items.AddRange(new ToolStripItem[] { btnClassify, btnContourOnly, btnComputeHidden, btnShowHidden, btnSilhouette, btnHoles, btnDims, new ToolStripSeparator() });

            tb2.Items.Add(new ToolStripButton("다시 그리기", null, (s, e) => Rebuild(true, true)));
            tb2.Items.Add(new ToolStripButton("맞춤", null, (s, e) => canvas.FitToView()));
            tb2.Items.Add(new ToolStripButton("DXF 저장", null, (s, e) => ExportDxf()));
            tb2.Items.Add(new ToolStripButton("PNG 저장", null, (s, e) => ExportPng()));
            btnDark = Toggle("어두운 배경", false, (s, e) => { canvas.DarkTheme = btnDark.Checked; canvas.Invalidate(); });
            tb2.Items.Add(btnDark);
            tb2.Items.Add(new ToolStripSeparator());

            // 포인트 편집 : 중요 포인트 표시 + 드래그 변형 (2D 도면만 변경, 3D 모델은 그대로)
            btnEditPoint = Toggle("포인트 편집", false, (s, e) => canvas.EditMode = btnEditPoint.Checked);
            tb2.Items.Add(btnEditPoint);
            tb2.Items.Add(new ToolStripButton("원래대로", null, (s, e) => Rebuild(false, false)));
            canvas.DrawingEdited += (s, e) => lblStatus.Text = "포인트 이동 : " + ViewStats();

            var status = new StatusStrip();
            lblStatus = new ToolStripStatusLabel("준비") { Spring = true, TextAlign = ContentAlignment.MiddleLeft };
            status.Items.Add(lblStatus);

            Controls.Add(split);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(status);
        }

        static ToolStripButton Toggle(string text, bool on, EventHandler click)
        {
            var b = new ToolStripButton(text) { CheckOnClick = true, Checked = on, DisplayStyle = ToolStripItemDisplayStyle.Text };
            b.CheckedChanged += click;
            return b;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ApplyDock();
        }

        void ApplyDock()
        {
            bool right = cboDock.SelectedIndex == 1;
            split.Orientation = right ? Orientation.Vertical : Orientation.Horizontal;
            int total = right ? split.ClientSize.Width : split.ClientSize.Height;
            if (total > 100) split.SplitterDistance = (int)(total * (right ? 0.55 : 0.58));
            canvas.FitToView();
        }

        // ==============================================================
        // VIZCore3D.NET 초기화 / 라이선스
        // ==============================================================
        void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            if (!ConnectLicense()) return;

            vizcore3d.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;
            vizcore3d.Model.OnModelOpenedEvent += (s, ev) => ClearDrawing("모델이 열렸습니다. 개체를 선택하세요.");
            vizcore3d.Model.OnModelClosedEvent += (s, ev) => ClearDrawing("모델이 닫혔습니다.");
        }

        // 실행 폴더의 License.ini 로 인증 (없거나 비어 있으면 License Dialog 표시) - VIZCore3D.NET.Demo 와 동일
        bool ConnectLicense()
        {
            string path = string.Format("{0}\\License.ini", Application.StartupPath);
            LicenseResults result;

            if (System.IO.File.Exists(path) == false)
            {
                if (LicenseFromDialog(out result) == false) return false;
            }
            else
            {
                Utility.IniFile ini = new Utility.IniFile();
                ini.Load(path);

                if (ini.ContainsSection("License") == false) return false;

                Utility.IniSection section = new Utility.IniSection();
                if (ini.TryGetSection("License", out section) == false) return false;

                string licenseFile = section["File"].ToString();
                string licenseServerIp = section["IP"].ToString();
                string licenseServerPort = section["PORT"].ToString();

                if (String.IsNullOrEmpty(licenseFile) == false && System.IO.File.Exists(licenseFile) == true)
                {
                    result = vizcore3d.License.LicenseFile(licenseFile);
                }
                else if (String.IsNullOrEmpty(licenseServerIp) == false && String.IsNullOrEmpty(licenseServerPort) == false)
                {
                    result = vizcore3d.License.LicenseServer(licenseServerIp, Convert.ToInt32(licenseServerPort));
                }
                else
                {
                    if (LicenseFromDialog(out result) == false) return false;
                }
            }

            if (result != LicenseResults.SUCCESS)
            {
                MessageBox.Show(string.Format("LICENSE CODE : {0}", result.ToString()), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            licensed = true;
            return true;
        }

        bool LicenseFromDialog(out LicenseResults result)
        {
            result = LicenseResults.NONE;

            Dialogs.LicenseDialog dlg = new Dialogs.LicenseDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return false;

            if (String.IsNullOrEmpty(dlg.LicenseFile) == false)
                result = vizcore3d.License.LicenseFile(dlg.LicenseFile);
            else if (String.IsNullOrEmpty(dlg.LicenseIp) == false && String.IsNullOrEmpty(dlg.LicensePort) == false)
                result = vizcore3d.License.LicenseServer(dlg.LicenseIp, Convert.ToInt32(dlg.LicensePort));
            else
                return false;

            return true;
        }

        void OpenModel()
        {
            if (!licensed) { MessageBox.Show("라이선스 인증 후 사용하세요.", "EdgeView"); return; }
            vizcore3d.Model.OpenFileDialog();
        }

        void Object3D_OnObject3DSelected(object sender, VIZCore3D.NET.Event.EventManager.Object3DSelectedEventArgs e)
        {
            selection = new List<int>();
            if (e.Node != null) foreach (var n in e.Node) selection.Add(n.Index);
            selectTimer.Stop();
            selectTimer.Start();
        }

        void ClearDrawing(string msg)
        {
            parts = null;
            selection = new List<int>();
            canvas.Message = msg;
            canvas.SetViews(null, false);
            lblStatus.Text = msg;
        }

        // ==============================================================
        // 도면 생성 : 형상 조회 → 뷰 방향별 투영 (모든 3D 연산은 vizcore3d.Projection API)
        // ==============================================================
        EdgeProjectionOption CurrentOption()
        {
            // 모서리 소스 : Facet 메쉬 윤곽 (EdgeProjectionOption 기본값 MESH_OUTLINE)
            return new EdgeProjectionOption
            {
                ClassifyContour = btnClassify.Checked,
                ContourOnly = btnContourOnly.Checked,
                ComputeHidden = btnComputeHidden.Checked,
                ShowHidden = btnShowHidden.Checked,
                Silhouette = btnSilhouette.Checked,
                HoleMark = btnHoles.Checked,
                Dimension = btnDims.Checked
            };
        }

        void Rebuild(bool reload, bool fit)
        {
            if (vizcore3d == null || !licensed) return;
            if (selection.Count == 0) { ClearDrawing("선택된 개체가 없습니다."); return; }

            var sw = System.Diagnostics.Stopwatch.StartNew();
            Cursor = Cursors.WaitCursor;
            try
            {
                var option = CurrentOption();

                // 1. 파트별 형상 조회 (뷰/옵션 변경 시 재사용)
                if (reload || parts == null)
                {
                    parts = new List<KeyValuePair<int, EdgeProjectionGeometry>>();
                    foreach (int part in vizcore3d.Object3D.GetPartIndices(selection))
                    {
                        var g = vizcore3d.Projection.GetEdgeProjectionGeometry(new List<int> { part }, option);
                        if (!g.IsEmpty) parts.Add(new KeyValuePair<int, EdgeProjectionGeometry>(part, g));
                    }
                }
                if (parts.Count == 0)
                {
                    canvas.Message = "선택 개체에서 형상 정보를 얻지 못했습니다.";
                    canvas.SetViews(null, false);
                    lblStatus.Text = "Part 0";
                    return;
                }

                // 2. 모든 파트에 같은 문자 높이 (가장 큰 파트 기준)
                float maxSize = 0;
                foreach (var p in parts) maxSize = Math.Max(maxSize, vizcore3d.Object3D.GetBoundBox(new List<int> { p.Key }).MaxLength);
                option.TextHeight = maxSize * 0.025f;

                // 3. 파트별 투영 (3면도는 파트별 정면 / 평면 / 우측면 묶음)
                var groups = new List<List<EdgeProjectionResult>>();
                foreach (var p in parts)
                {
                    var group = new List<EdgeProjectionResult>();
                    if (cboView.SelectedIndex == ThreeView)
                    {
                        // 제3각법 : 평면도는 정면도 위, 우측면도는 정면도 오른쪽
                        var front = vizcore3d.Projection.GetEdgeProjection(p.Value, ProjectionViewKind.FRONT, option);
                        var top = vizcore3d.Projection.GetEdgeProjection(p.Value, ProjectionViewKind.TOP, option);
                        var right = vizcore3d.Projection.GetEdgeProjection(p.Value, ProjectionViewKind.RIGHT, option);
                        RectangleF fb = front.GetBounds(), tb = top.GetBounds(), rb = right.GetBounds();
                        float gap = Math.Max(fb.Width, fb.Height) * 0.15f;
                        top.Translate(0, fb.Bottom + gap - tb.Top);
                        right.Translate(fb.Right + gap - rb.Left, 0);
                        group.Add(front); group.Add(top); group.Add(right);
                    }
                    else
                    {
                        group.Add(vizcore3d.Projection.GetEdgeProjection(p.Value, ViewKinds[cboView.SelectedIndex], option));
                    }
                    AddPartLabel(group, p.Value, option.TextHeight);
                    groups.Add(group);
                }

                // 4. 겹치지 않게 나란히 배치 (그리기 영역 비율 기준)
                vizcore3d.Projection.ArrangeEdgeProjections(groups, 0.0f, canvas.Height > 0 ? (float)canvas.Width / canvas.Height : 0.0f);

                var views = new List<EdgeProjectionResult>();
                foreach (var g in groups) views.AddRange(g);
                canvas.Title = string.Format("Part {0}", parts.Count);
                canvas.SetViews(views, fit);

                lblStatus.Text = string.Format("{0} | {1} ms", ViewStats(), sw.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "오류: " + ex.Message;
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally { Cursor = Cursors.Default; }
        }

        /// <summary>파트 이름을 그룹 아래에 표시</summary>
        static void AddPartLabel(List<EdgeProjectionResult> group, EdgeProjectionGeometry g, float textHeight)
        {
            if (g.Names.Count == 0) return;
            RectangleF b = RectangleF.Empty;
            foreach (var r in group)
            {
                var rb = r.GetBounds();
                b = b == RectangleF.Empty ? rb : RectangleF.Union(b, rb);
            }
            group[0].Texts.Add(new ProjectionText2D
            {
                Position = new PointF(b.X + b.Width / 2, b.Top - textHeight * 2.0f),
                Text = g.Names[0],
                Height = textHeight * 1.2f,
                Kind = ProjectionLineKind.OUTER
            });
        }

        string ViewStats()
        {
            int outer = 0, inner = 0, hidden = 0, holes = 0, keys = 0;
            foreach (var v in canvas.Views)
            {
                outer += v.GetLineCount(ProjectionLineKind.OUTER);
                inner += v.GetLineCount(ProjectionLineKind.INNER);
                hidden += v.GetLineCount(ProjectionLineKind.HIDDEN);
                holes += v.Holes.Count;
                keys += v.KeyPoints.Count;
            }
            string s = string.Format("Part {0} / View {1} | Outer {2} / Inner {3} / Hidden {4} / Hole {5}",
                parts != null ? parts.Count : 0, canvas.Views.Count, outer, inner, hidden, holes);
            if (canvas.EditMode) s += " / KeyPoint " + keys;
            return s;
        }
        // ==============================================================
        // 내보내기
        // ==============================================================
        void ExportDxf()
        {
            if (canvas.Views.Count == 0) return;
            using (var dlg = new SaveFileDialog { Filter = "DXF (*.dxf)|*.dxf", FileName = "EdgeView.dxf" })
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                DxfExporter.Export(canvas.Views, dlg.FileName);
                lblStatus.Text = "DXF 저장: " + dlg.FileName;
            }
        }

        void ExportPng()
        {
            if (canvas.Views.Count == 0) return;
            using (var dlg = new SaveFileDialog { Filter = "PNG (*.png)|*.png", FileName = "EdgeView.png" })
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                using (var b = canvas.RenderToBitmap()) b.Save(dlg.FileName, ImageFormat.Png);
                lblStatus.Text = "PNG 저장: " + dlg.FileName;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try { if (licensed) vizcore3d.License.DisconnectServer(); } catch { }
            base.OnFormClosing(e);
        }
    }
}
