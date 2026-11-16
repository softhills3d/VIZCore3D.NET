using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace VIZCore3D.NET.EnclosureSearch
{
    public partial class Form1 : Form
    {
        // ================================================================
        // 라이선스 설정 (환경에 맞게 수정)
        //  - 실행 폴더에 LicenseFileName 파일이 있으면 파일 인증
        //  - 없으면 라이선스 서버 인증
        // ================================================================
        private const string LicenseFileName = "VIZCore3D.NET.lic";
        //private const string LicenseServerIP = "127.0.0.1";
        private const string LicenseServerIP = "192.168.100.252";
        private const int LicenseServerPort = 8901;

        /// <summary>
        /// VIZCore3D.NET 컨트롤
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        public Form1()
        {
            InitializeComponent();
            InitializeEnclosureSearchUi();

            // 모듈 초기화 : 실행 환경에 맞는 Unmanaged 라이브러리를 실행 경로에 생성
            VIZCore3D.NET.ModuleInitializer.Run();

            // 컨트롤 생성 및 배치
            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            panelView.Controls.Add(vizcore3d);

            // 필수 이벤트 : 컨트롤 초기화 완료
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;

            Text = string.Format("VIZCore3D.NET.EnclosureSearch - {0}", Environment.Is64BitProcess ? "x64" : "x86");
        }

        // ================================================================
        // 초기화
        // ================================================================
        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            // 라이선스 인증은 초기화 완료 이벤트에서 수행
            VIZCore3D.NET.Data.LicenseResults result = AuthenticateLicense();

            if (result != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            {
                lblStatus.Text = string.Format("License failed : {0}", result);
                MessageBox.Show(
                    string.Format("LICENSE CODE : {0}", result),
                    "VIZCore3D.NET",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            InitializeVIZCore3D();
            InitializeVIZCore3DEvent();

            btnOpen.Enabled = true;
            EnableStepButtons();
            lblStatus.Text = "Ready";

            OnEnclosureSearchReady();
        }

        private VIZCore3D.NET.Data.LicenseResults AuthenticateLicense()
        {
            string licenseFile = Path.Combine(Application.StartupPath, LicenseFileName);

            if (File.Exists(licenseFile))
                return vizcore3d.License.LicenseFile(licenseFile);

            return vizcore3d.License.LicenseServer(LicenseServerIP, LicenseServerPort);
        }

        private void InitializeVIZCore3D()
        {
            // 설정 변경 중 3D 화면 Rendering 차단
            vizcore3d.BeginUpdate();

            // 모델 열기 시, Edge 정보 로드
            vizcore3d.Model.LoadEdgeData = true;
            // 하드웨어 가속
            vizcore3d.View.EnableHardwareAcceleration = true;
            // 개체 선택 색상
            vizcore3d.View.SelectionColor = System.Drawing.Color.Red;

            // 툴바 : 기본 툴바만 표시
            vizcore3d.ToolbarNote.Visible = false;
            vizcore3d.ToolbarMeasure.Visible = false;
            vizcore3d.ToolbarSection.Visible = false;
            vizcore3d.ToolbarClash.Visible = false;
            vizcore3d.ToolbarAnimation.Visible = false;

            // 상태바
            vizcore3d.Statusbar.Visible = true;

            // Rendering 재시작
            vizcore3d.EndUpdate();
        }

        private void InitializeVIZCore3DEvent()
        {
            vizcore3d.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;
        }

        // ================================================================
        // 이벤트 : 개체 선택
        // ================================================================
        private void Object3D_OnObject3DSelected(object sender, VIZCore3D.NET.Event.EventManager.Object3DSelectedEventArgs e)
        {
            if (e.Node.Count == 0)
            {
                lblStatus.Text = "Selection cleared";
                return;
            }

            lblStatus.Text = string.Format(
                "Selected : {0} (Index {1}) / Total {2}",
                e.Node[0].NodeName,
                e.Node[0].Index,
                e.Node.Count);
        }

        // ================================================================
        // 버튼 : 모델 열기 / 닫기 / 화면 맞춤
        // ================================================================
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = vizcore3d.Model.OpenFilter;
                dlg.Multiselect = true;   // 여러 파일을 한 번에 연다
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                Cursor = Cursors.WaitCursor;
                bool opened;
                try { opened = OpenModels(dlg.FileNames); }
                finally { Cursor = Cursors.Default; }

                btnClose.Enabled = opened;
                btnFit.Enabled = opened;
                lblStatus.Text = opened
                    ? string.Format("Opened : {0} file(s)", dlg.FileNames.Length)
                    : "Open failed";
            }
        }

        /// <summary>
        /// 기존 모델을 닫고 지정한 파일을 연다. 1개면 Open, 여러 개면 Add 로 한 번에 연다.
        /// </summary>
        private bool OpenModels(string[] files)
        {
            vizcore3d.Model.OnModelProgressChangedEvent += Model_OnModelProgressChangedEvent;
            try
            {
                if (files.Length == 1) return vizcore3d.Model.Open(files[0]);

                if (vizcore3d.Model.IsOpen()) vizcore3d.Model.Close();
                return vizcore3d.Model.Add(files);
            }
            finally
            {
                vizcore3d.Model.OnModelProgressChangedEvent -= Model_OnModelProgressChangedEvent;
            }
        }

        private void Model_OnModelProgressChangedEvent(object sender, VIZCore3D.NET.Event.EventManager.ModelProgressEventArgs e)
        {
            lblStatus.Text = string.Format("Loading... {0}%", e.Progress);
            statusStrip1.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            vizcore3d.Model.Close();

            btnClose.Enabled = false;
            btnFit.Enabled = false;
            lblStatus.Text = "Closed";
        }

        private void btnFit_Click(object sender, EventArgs e)
        {
            vizcore3d.View.FitToView();
        }

        // ================================================================
        // 사용 방법 단계 버튼 (좌측 패널의 1 ~ 6 단계)
        // ================================================================
        #region 사용 방법 단계
        private void EnableStepButtons()
        {
            btnStepOpenSpace.Enabled = true;
            btnStepAddTarget.Enabled = true;
            btnStepSelectSpace.Enabled = true;
            btnStepSearch.Enabled = true;
            btnStepHideSpace.Enabled = true;
            btnStepTransparency.Enabled = true;
            btnStepSilhouette.Enabled = true;
        }

        /// <summary>
        /// 1-1. 공간 모델 열기 (기존 모델은 닫힘)
        /// </summary>
        private void btnStepOpenSpace_Click(object sender, EventArgs e)
        {
            string[] files = SelectFiles(false);
            if (files == null) return;

            OpenSpaceModel(files[0]);
        }

        /// <summary>
        /// 1-2. 검색 대상 모델 추가
        /// </summary>
        private void btnStepAddTarget_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false)
            {
                MessageBox.Show(this, "먼저 공간 모델을 여세요.", "1. 모델 열기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] files = SelectFiles(true);
            if (files == null) return;

            AddTargetModel(files);
        }

        private string[] SelectFiles(bool multiselect)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = vizcore3d.Model.OpenFilter;
                dlg.Multiselect = multiselect;
                if (dlg.ShowDialog(this) != DialogResult.OK) return null;
                return dlg.FileNames;
            }
        }

        private void OpenSpaceModel(string file)
        {
            Cursor = Cursors.WaitCursor;
            bool opened;
            try { opened = OpenModels(new[] { file }); }
            finally { Cursor = Cursors.Default; }

            btnClose.Enabled = opened;
            btnFit.Enabled = opened;
            btnStepHideSpace.Text = "공간 모델 끄기";
            lblStatus.Text = opened ? string.Format("공간 모델 : {0}", Path.GetFileName(file)) : "Open failed";
        }

        private void AddTargetModel(string[] files)
        {
            Cursor = Cursors.WaitCursor;
            bool added;
            vizcore3d.Model.OnModelProgressChangedEvent += Model_OnModelProgressChangedEvent;
            try { added = vizcore3d.Model.Add(files); }
            finally
            {
                vizcore3d.Model.OnModelProgressChangedEvent -= Model_OnModelProgressChangedEvent;
                Cursor = Cursors.Default;
            }

            lblStatus.Text = added ? string.Format("검색 대상 모델 : {0} file(s)", files.Length) : "Add failed";
        }

        /// <summary>
        /// 2. 모델 트리를 열고, 공간 모델의 루트 노드를 선택
        /// </summary>
        private void btnStepSelectSpace_Click(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.Node space = GetSpaceModelNode();
            if (space == null) return;

            vizcore3d.ModelTreeVisible = true;
            vizcore3d.Object3D.Select(VIZCore3D.NET.Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.Object3D.Select(new List<VIZCore3D.NET.Data.Node> { space }, true, false);
        }

        /// <summary>
        /// 3. 공간 검색 (우측 패널의 [공간 검색] 버튼과 동일)
        /// </summary>
        private void btnStepSearch_Click(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        /// <summary>
        /// 4. 공간 모델 끄기 / 켜기
        /// </summary>
        private void btnStepHideSpace_Click(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.Node space = GetSpaceModelNode();
            if (space == null) return;

            bool visible = !space.Visible;
            vizcore3d.Object3D.Show(new List<int> { space.Index }, visible);

            btnStepHideSpace.Text = visible ? "공간 모델 끄기" : "공간 모델 켜기";
        }

        /// <summary>
        /// 5. 검색 대상 모델의 투명도를 90% 로 변경 (검색 결과 Part 는 불투명하게 유지)
        /// </summary>
        private void btnStepTransparency_Click(object sender, EventArgs e)
        {
            List<int> targets = GetTargetModelIndex();
            if (targets.Count == 0)
            {
                MessageBox.Show(this, "먼저 검색 대상 모델을 추가하세요.", "5. 투명도", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 검색 대상 모델의 Part 중, 검색 결과(내부 / 걸침)를 제외한 Part
            var results = new HashSet<int>(opaqueParts);
            var parts = new List<int>();
            foreach (int part in vizcore3d.Object3D.GetPartIndices(targets))
            {
                if (results.Contains(part) == false) parts.Add(part);
            }
            if (parts.Count == 0) return;

            vizcore3d.Object3D.Color.SetTransparency(parts, 90);
        }

        /// <summary>
        /// 6. 윤곽 켜기 / 끄기 (렌더링 효과)
        /// </summary>
        private void btnStepSilhouette_Click(object sender, EventArgs e)
        {
            vizcore3d.View.SilhouetteEdge = !vizcore3d.View.SilhouetteEdge;

            btnStepSilhouette.Text = vizcore3d.View.SilhouetteEdge ? "윤곽 끄기" : "윤곽 켜기";
        }

        /// <summary>
        /// 열린 파일 노드 목록 : 첫 번째 = 공간 모델, 나머지 = 검색 대상 모델
        /// </summary>
        private List<VIZCore3D.NET.Data.Node> GetFileNodes()
        {
            if (vizcore3d.Model.IsOpen() == false) return new List<VIZCore3D.NET.Data.Node>();

            return vizcore3d.Object3D.FromIndex(0).GetChildObject3d(VIZCore3D.NET.Data.Object3DChildOption.CHILD_ONLY);
        }

        private VIZCore3D.NET.Data.Node GetSpaceModelNode()
        {
            List<VIZCore3D.NET.Data.Node> files = GetFileNodes();
            if (files.Count == 0)
            {
                MessageBox.Show(this, "1번 단계에서 모델을 먼저 여세요.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            // 노드 상태(보이기 등)를 최신 값으로 조회
            return vizcore3d.Object3D.FromIndex(files[0].Index);
        }

        private List<int> GetTargetModelIndex()
        {
            var index = new List<int>();
            List<VIZCore3D.NET.Data.Node> files = GetFileNodes();
            for (int i = 1; i < files.Count; i++) index.Add(files[i].Index);
            return index;
        }
        #endregion
    }
}
