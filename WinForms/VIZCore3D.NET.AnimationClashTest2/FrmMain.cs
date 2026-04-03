using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using VIZCore3D.NET.Data;

namespace VIZCore3D.NET.AnimationClashTest2
{
    public partial class FrmMain : Form
    {
        // ================================================
        // Attribute & Property
        // ================================================
        /// <summary>
        /// VIZCore3D.NET
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        /// <summary>
        /// 애니메이션 총 재생 시간(초)
        /// </summary>
        private float AnimationDuration = 0.0f;

        /// <summary>
        /// 애니메이션 재생 위치(시간, 초)
        /// </summary>
        private float PlaybackTime = 0.0f;

        /// <summary>
        /// 한 프레임의 지속시간(초)
        /// </summary>
        private float OneFrameDuration = 0.03f;

        private VIZCore3D.NET.Data.ClashTest clash;

        List<VIZCore3D.NET.Data.Node> groupA = new List<Node>();
        List<VIZCore3D.NET.Data.Node> groupB = new List<Node>();
        List<VIZCore3D.NET.Data.ClashTestResultItem> resultItems = new List<ClashTestResultItem>();

        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            // Construction
            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(vizcore3d);

            // Event
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;

            clash = new Data.ClashTest();
        }

        // ================================================
        // Event - VIZCore3D.NET
        // ================================================
        #region Event - OnInitializedVIZCore3D
        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            //MessageBox.Show("OnInitializedVIZCore3D", "VIZCore3D.NET");

            // ================================================================
            // Example
            // ================================================================
            //vizcore3d.License.LicenseFile("C:\\Temp\\VIZCore3D.NET.lic");                         // 라이선스 파일
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901);                                   // 라이선스 서버 - 제품 오토 선택
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901, Data.Products.AUTO);               // 라이선스 서버 - 제품 오토 선택
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901, Data.Products.VIZZARD_MANAGER);    // 라이선스 서버 - 지정된 제품으로 인증
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901, Data.Products.VIZZARD_STANDARD);   // 라이선스 서버 - 지정된 제품으로 인증
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901, Data.Products.VIZCORE3D_MANAGER);  // 라이선스 서버 - 지정된 제품으로 인증
            //vizcore3d.License.LicenseServer("127.0.0.1", 8901, Data.Products.VIZCORE3D_STANDARD); // 라이선스 서버 - 지정된 제품으로 인증


            // ================================================================
            // TEST
            // ================================================================
            //VIZCore3D.NET.Data.LicenseResults result = vizcore3d.License.LicenseFile("C:\\License\\VIZCore3D.NET.lic");
            //VIZCore3D.NET.Data.LicenseResults result = vizcore3d.License.LicenseServer("127.0.0.1", 8901);
            //VIZCore3D.NET.Data.LicenseResults result = vizcore3d.License.LicenseServer("192.168.0.215", 8901);
            //if (result != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            //{
            //    MessageBox.Show(string.Format("LICENSE CODE : {0}", result.ToString()), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            // ================================================================
            // License Helper
            // ================================================================
            #region 라이선스
            // 라이선스 정보 조회
            VIZCore3D.NET.Utility.LicenseHelper.LicenseData licenseData = VIZCore3D.NET.Utility.LicenseHelper.GetLicenseDataKind();

            // 등록된 정보 없는 경우, 설정 다이얼로그 실행
            if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.NONE)
            {
                VIZCore3D.NET.Dialogs.LicenseDialog dlg = new VIZCore3D.NET.Dialogs.LicenseDialog();
                if (dlg.ShowDialog() != DialogResult.OK) return;
            }

            // 라이선스 정보 재조회
            licenseData = VIZCore3D.NET.Utility.LicenseHelper.GetLicenseDataKind();

            // 등록된 정보 조회
            Dictionary<string, string> licenseInfo = VIZCore3D.NET.Utility.LicenseHelper.GetLicenseInformation();
            VIZCore3D.NET.Data.LicenseResults licenseResult = VIZCore3D.NET.Data.LicenseResults.NONE;

            // 라이선스 서버
            if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.SERVER)
            {
                licenseResult = vizcore3d.License.LicenseServer(
                    licenseInfo.ContainsKey("LICENSE_IP") == true ? licenseInfo["LICENSE_IP"] : String.Empty
                    , licenseInfo.ContainsKey("LICENSE_PORT") == true ? Convert.ToInt32(licenseInfo["LICENSE_PORT"]) : 8901
                    );
            }
            // 라이선스 파일
            else if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.FILE)
            {
                licenseResult = vizcore3d.License.LicenseFile(
                    licenseInfo.ContainsKey("LICENSE_FILE") == true ? licenseInfo["LICENSE_FILE"] : String.Empty
                    );
            }

            // 인증 결과
            if (licenseResult != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            {
                MessageBox.Show(string.Format("LICENSE CODE : {0}", licenseResult.ToString()), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            // Init. VIZCore3D.NET
            InitializeVIZCore3D();
            InitializeVIZCore3DEvent();
        }
        #endregion

        // ================================================
        // Function - VIZCore3D.NET : Initialize
        // ================================================
        #region Function - VIZCore3D.NET : Initialize
        private void InitializeVIZCore3D()
        {
            // ================================================================
            // 모델 열기 시, 3D 화면 Rendering 차단
            // ================================================================
            vizcore3d.BeginUpdate();


            // ================================================================
            // 설정 - 기본
            // ================================================================
            #region 설정 - 기본
            // 모델 자동 언로드 (파일 노드 언체크 시, 언로드)
            vizcore3d.Model.UncheckToUnload = true;

            // 모델 열기 시, Edge 정보 로드 활성화
            vizcore3d.Model.LoadEdgeData = true;

            // 모델 열기 시, Edge 정보 생성 활성화
            vizcore3d.Model.GenerateEdgeData = true;

            // 모델 조회 시, 하드웨어 가속
            vizcore3d.View.EnableHardwareAcceleration = true;

            // Undo/Redo (비)활성화
            vizcore3d.Model.EnableUndoRedo = false;

            // 모델 열기 시, 스트럭처 병합 설정
            vizcore3d.Model.OpenMergeStructureMode = VIZCore3D.NET.Data.MergeStructureModes.NONE;

            // 모델 저장 시, 스트럭처 병합 설정
            vizcore3d.Model.SaveMergeStructureMode = VIZCore3D.NET.Data.MergeStructureModes.NONE;

            // 실린더 원형 품질 개수 : Nomal(12~36), Small(6~36)
            vizcore3d.Model.ReadNormalCylinderSide = 12;
            vizcore3d.Model.ReadSmallCylinderSide = 6;

            // 보이는 모델만 저장

            // VIZXML to VIZ 옵션
            vizcore3d.Model.VIZXMLtoVIZOption = VIZCore3D.NET.Data.ExportVIZXMLToVIZOptions.LOAD_UNLOADED_NODE;

            // 선택 가능 개체 : 전체, 불투명한 개체
            vizcore3d.View.SelectionObject3DType = VIZCore3D.NET.Data.SelectionObject3DTypes.ALL;

            // 개체 선택 유형 : 색상, 경계로 선택 (개체), 경계로 선택 (전체)
            vizcore3d.View.SelectionMode = VIZCore3D.NET.Data.Object3DSelectionOptions.HIGHLIGHT_COLOR;

            // 개체 선택 색상
            vizcore3d.View.SelectionColor = Color.Red;

            // 모델 조회 시, Pre-Select 설정
            vizcore3d.View.PreSelect.Enable = false;

            // 모델 조회 시, Pre-Select 색상 설정
            vizcore3d.View.PreSelect.HighlightColor = Color.Lime;

            // 모델 조회 시, Pre-Select Label
            vizcore3d.View.PreSelect.Label = VIZCore3D.NET.Data.PreSelectStyle.LabelKind.HIERACHY_BOTTOM_UP;

            // 모델 조회 시, Pre-Select Font
            vizcore3d.View.PreSelect.LabelFont = new Font("Arial", 10.0f);
            #endregion


            // ================================================================
            // 설정 - 보기
            // ================================================================
            #region 설정 - 보기
            // 자동 애니메이션 : 박스줌, 개체로 비행 등 기능에서 애니메이션 활성화/비활성화
            vizcore3d.View.EnableAnimation = true;

            // 자동화면맞춤
            vizcore3d.View.EnableAutoFit = false;

            // 연속회전모드
            vizcore3d.View.EnableInertiaRotate = false;

            // 확대/축소 비율 : 5.0f ~ 50.0f
            vizcore3d.View.ZoomRatio = 30.0f;

            // 회전각도
            vizcore3d.View.RotationAngle = 90.0f;

            // 회전 축
            vizcore3d.View.RotationAxis = VIZCore3D.NET.Data.Axis.X;
            #endregion


            // ================================================================
            // 설정 - 탐색
            // ================================================================
            #region 설정 - 탐색
            // Z축 고정
            vizcore3d.Walkthrough.LockZAxis = true;
            // 선속도 : m/s
            vizcore3d.Walkthrough.Speed = 2.0f;
            // 각속도
            vizcore3d.Walkthrough.AngularSpeed = 30.0f;
            // 높이
            vizcore3d.Walkthrough.AvatarHeight = 1800.0f;
            // 반지름
            vizcore3d.Walkthrough.AvatarCollisionRadius = 400.0f;
            // 숙임높이
            vizcore3d.Walkthrough.AvatarBowWalkHeight = 1300.0f;
            // 충돌
            vizcore3d.Walkthrough.UseAvatarCollision = false;
            // 중력
            vizcore3d.Walkthrough.UseAvatarGravity = false;
            // 숙임
            vizcore3d.Walkthrough.UseAvatarBowWalk = false;
            // 모델
            vizcore3d.Walkthrough.AvatarModel = (int)VIZCore3D.NET.Data.AvatarModels.MAN1;
            // 자동줌
            vizcore3d.Walkthrough.EnableAvatarAutoZoom = false;
            // 충돌상자보기
            vizcore3d.Walkthrough.ShowAvatarCollisionCylinder = false;
            #endregion


            // ================================================================
            // 설정 - 조작
            // ================================================================
            #region 설정 - 조작
            // 시야각
            vizcore3d.View.FOV = 60.0f;
            // 광원 세기
            vizcore3d.View.SpecularGamma = 30.0f;
            // 모서리 굵기
            vizcore3d.View.EdgeWidthRatio = 0.0f;
            // X-Ray 모델 조회 시, 개체 색상 - 선택색상, 모델색상
            vizcore3d.View.XRay.ColorType = VIZCore3D.NET.Data.XRayColorTypes.SELECTION_COLOR;
            // 배경유형
            //vizcore3d.View.BackgroundMode = VIZCore3D.NET.Data.BackgroundModes.COLOR_ONE;
            // 배경색1
            //vizcore3d.View.BackgroundColor1 = Color.Gray;
            // 배경색2
            //vizcore3d.View.BackgroundColor2 = Color.Gray; 
            #endregion


            // ================================================================
            // 설정 - 노트
            // ================================================================
            #region 설정 - 노트
            // 배경색
            vizcore3d.Review.Note.BackgroundColor = Color.Yellow;
            // 배경 투명
            vizcore3d.Review.Note.BackgroudTransparent = false;
            // 글자색
            vizcore3d.Review.Note.FontColor = Color.Black;
            // 글자 크기
            vizcore3d.Review.Note.FontSize = VIZCore3D.NET.Data.FontSizeKind.SIZE16;
            // 글자 굵게
            vizcore3d.Review.Note.FontBold = true;
            // 지시선(라인) 색상
            vizcore3d.Review.Note.LineColor = Color.White;
            // 지시선(라인) 두께
            vizcore3d.Review.Note.LineWidth = 2;
            // 지시선 중앙 연결
            vizcore3d.Review.Note.LinkArrowTailToText = VIZCore3D.NET.Manager.NoteManager.LinkArrowTailToTextKind.OUTLINE;
            // 화살표 색상
            vizcore3d.Review.Note.ArrowColor = Color.Red;
            // 화살표 두께
            vizcore3d.Review.Note.ArrowWidth = 10;
            // 텍스트상자 라인 색상
            vizcore3d.Review.Note.TextBoxLineColor = Color.Black;

            // 심볼 배경색
            vizcore3d.Review.Note.SymbolBackgroundColor = Color.Red;
            // 심볼 글자색
            vizcore3d.Review.Note.SymbolFontColor = Color.White;
            // 심볼 크기
            vizcore3d.Review.Note.SymbolSize = 10;
            // 심볼 글자 크기
            vizcore3d.Review.Note.SymbolFontSize = VIZCore3D.NET.Data.FontSizeKind.SIZE16;
            // 심볼 글자 굵게
            vizcore3d.Review.Note.SymbolFontBold = false;
            #endregion


            // ================================================================
            // 설정 - 측정
            // ================================================================
            #region 설정 - 측정
            // 반복 모드
            vizcore3d.Review.Measure.RepeatMode = false;

            // 기본 스타일
            VIZCore3D.NET.Data.MeasureStyle measureStyle = vizcore3d.Review.Measure.GetStyle();

            // Prefix 조회
            measureStyle.Prefix = true;
            // Frame(좌표계)로 표시
            measureStyle.Frame = true;
            // DX, DY, DZ 표시
            measureStyle.DX_DY_DZ = true;
            // 측정 단위 표시
            measureStyle.Unit = true;
            // 측정 단위 유형
            measureStyle.UnitKind = VIZCore3D.NET.Data.MeasureUnitKind.RUT_MILLIMETER;
            // 소수점 이하 자리수
            measureStyle.NumberOfDecimalPlaces = 2;
            // 연속거리 표시
            measureStyle.ContinuousDistance = true;

            // 배경 투명
            measureStyle.BackgroundTransparent = false;
            // 배경색
            measureStyle.BackgroundColor = Color.Blue;
            // 글자색
            measureStyle.FontColor = Color.White;
            // 글자크기
            measureStyle.FontSize = VIZCore3D.NET.Data.FontSizeKind.SIZE14;
            // 글자 두껍게
            measureStyle.FontBold = false;
            // 지시선 색
            measureStyle.LineColor = Color.White;
            // 지시선 두께
            measureStyle.LineWidth = 2;
            // 화살표 색
            measureStyle.ArrowColor = Color.Red;
            // 화살표 크기
            measureStyle.ArrowSize = 10;
            // 보조 지시선 표시
            measureStyle.AssistantLine = true;
            // 보조 지시선 표시 개수
            measureStyle.AssistantLineCount = -1;
            // 보조 지시선 라인 스타일
            measureStyle.AssistantLineStyle = VIZCore3D.NET.Data.MeasureStyle.AssistantLineType.DOTTEDLINE;
            // 선택 위치 표시
            measureStyle.PickPosition = true;
            // 거리 측정 텍스트 정렬
            measureStyle.AlignDistanceText = true;
            // 거리 측정 텍스트 위치
            measureStyle.AlignDistanceTextPosition = 2;
            // 거리 측정 텍스트 오프셋
            measureStyle.AlignDistanceTextMargine = 5;

            // 측정 스타일 설정
            vizcore3d.Review.Measure.SetStyle(measureStyle);
            #endregion


            // ================================================================
            // 설정 - 단면
            // ================================================================
            #region 설정 - 단면
            // 단면 좌표간격으로 이동
            vizcore3d.Section.MoveSectionByFrameGrid = true;
            // 단면 보기
            vizcore3d.Section.ShowSectionPlane = true;
            // 단면선 표시
            vizcore3d.Section.ShowSectionLine = true;
            // 단면 단일색 표시
            vizcore3d.Section.ShowSectionLineColor = false;
            // 단면 단일색
            vizcore3d.Section.SectionLineColor = Color.Red;
            #endregion


            // ================================================================
            // 설정 - 간섭검사
            // ================================================================
            // 다중간섭검사
            vizcore3d.Clash.EnableMultiThread = true;

            // ================================================================
            // 설정 - 프레임(SHIP GRID)
            // ================================================================
            #region 설정 - 프레임
            // 프레임 평면 설정
            vizcore3d.Frame.XYPlane = true;
            vizcore3d.Frame.YZPlane = true;
            vizcore3d.Frame.ZXPlane = true;
            vizcore3d.Frame.PlanLine = true;
            vizcore3d.Frame.SectionLine = true;
            vizcore3d.Frame.ElevationLine = true;

            // 좌표값 표기
            vizcore3d.Frame.ShowNumber = true;

            // 모델 앞에 표기
            vizcore3d.Frame.BringToFront = false;

            // Frame(좌표계, SHIP GRID) 색상
            vizcore3d.Frame.ForeColor = Color.Black;

            // 홀수번째 표시
            vizcore3d.Frame.ShowOddNumber = true;
            // 짝수번째 표시
            vizcore3d.Frame.ShowEvenNumber = true;
            // 단면상자에 자동 맞춤
            vizcore3d.Frame.AutoFitSectionBox = true;
            #endregion


            // ================================================================
            // 설정 - 툴바
            // ================================================================
            #region 설정 - 툴바
            vizcore3d.ToolbarMain.Visible = true;
            vizcore3d.ToolbarNote.Visible = false;
            vizcore3d.ToolbarMeasure.Visible = false;
            vizcore3d.ToolbarSection.Visible = false;
            vizcore3d.ToolbarClash.Visible = false;
            vizcore3d.ToolbarAnimation.Visible = false;
            vizcore3d.ToolbarPrimitive.Visible = false;
            #endregion


            // ================================================================
            // 설정 - 상태바
            // ================================================================
            vizcore3d.Statusbar.Visible = false;


            // ================================================================
            // 모델 열기 시, 3D 화면 Rendering 재시작
            // ================================================================
            vizcore3d.EndUpdate();
        }
        #endregion

        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            vizcore3d.Clash.OnClashProgressEvent += Clash_OnClashProgressEvent;
            vizcore3d.Clash.OnClashTestFinishedEvent += Clash_OnClashTestFinishedEvent;
        }

        private void Clash_OnClashProgressEvent(object sender, Event.EventManager.ClashProgressEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(string.Format("{0}% - {1:N0} EA", e.Progress, e.Count));
        }

        private void Clash_OnClashTestFinishedEvent(object sender, VIZCore3D.NET.Event.EventManager.ClashEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(string.Format("{0}% - {1:N0} EA", "", ""));
            this.Invoke(new EventHandler(delegate
            {
                ShowResultList();

                PlayFrame();
            }));
            this.Activate();
        }

        /// <summary>
        /// "1. 샘플 모델 열기" 버튼 클릭
        /// </summary>
        private void btnOpenSampleModel_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen()) return;

            bool result = vizcore3d.Model.Open("sample_model.viz");
            if (result == false)
            {
                MessageBox.Show("sample_model.viz 파일을 열지 못했습니다.", "VIZCore3D.NET.ClashTest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// "Add Group A" 버튼 클릭
        /// </summary>
        private void btnAddGroupA_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "BOX" }, false, false, false, false, true, false);
            if (items.Count == 0)
            {
                MessageBox.Show("BOX 노드가 없습니다.", "VIZCore3D.NET.ClashTest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupA = items;

            MessageBox.Show("BOX 노드를 A 그룹에 설정 하였습니다.", "VIZCore3D.NET.ClashTest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// "Add Group B" 버튼 클릭
        /// </summary>
        private void btnAddGroupB_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "BOX2", "BOX3", "BOX4" }, false, false, false, false, true, false);
            if (items.Count == 0)
            {
                MessageBox.Show("BOX2, BOX3, SPHERE 노드가 없습니다.", "VIZCore3D.NET.ClashTest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupB = items;

            MessageBox.Show("BOX2, BOX3, SPHERE 노드를 B 그룹에 설정 하였습니다.", "VIZCore3D.NET.ClashTest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// "3. 애니메이션 생성" 버튼 클릭
        /// </summary>
        private void btnGenerateAnimation_Click(object sender, EventArgs e)
        {
            if (GenerateAnimation())
            {
                MessageBox.Show("Animation 생성 성공.", "VIZCore3D.NET.ClashTest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool GenerateAnimation()
        {
            vizcore3d.View.EnableAutoFit = false;                                       /* 자동 화면맞춤 비활성 */
            //vizcore3d.View.Projection = VIZCore3D.NET.Data.Projections.Perspective;   /* 원근 뷰 설정 */
            vizcore3d.Animation.UseEffect = false;                                      /* 기본 효과 사용안함 설정 */

            vizcore3d.Animation.Clear();
            vizcore3d.Animation.Add("Animation");

            AnimationDuration = 0.0f;

            vizcore3d.BeginUpdate();

            if (groupA == null || groupA.Count <= 0)
            {
                MessageBox.Show("그룹 A 를 먼저 추가해주세요.", "VIZCore3D.NET.ClashTest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // Init. Key
            AddKey(true, false, 0.0f);

            // X축 방향으로 12미터 이동
            vizcore3d.Object3D.Transform.Move(groupA, 12000.0f, 0.0f, 0.0f, false);
            AddKey(true, false, 5.0f);

            // Z축으로 45도 회전
            vizcore3d.Object3D.Transform.Rotate(groupA, 0.0f, 0.0f, 45.0f, false, false);
            AddKey(true, false, 1.0f);

            vizcore3d.Object3D.Transform.RestoreTransformAll();

            vizcore3d.EndUpdate();

            return true;
        }

        /// <summary>
        /// 애니메이션 키 추가
        /// </summary>
        public void AddKey(bool modelKey, bool cameraKey, float internval)
        {
            AnimationDuration += internval;

            if (cameraKey)
                vizcore3d.Animation.AddKey(AnimationDuration, VIZCore3D.NET.Manager.AnimationManager.AnimationKeyType.CAMERA);

            if (modelKey)
                vizcore3d.Animation.AddKey(AnimationDuration, VIZCore3D.NET.Manager.AnimationManager.AnimationKeyType.MODEL);
        }

        /// <summary>
        /// "4. 간섭검사 시작" 버튼 클릭
        /// </summary>
        private void btnPerformTest_Click(object sender, EventArgs e)
        {
            if (groupA.Count == 0)
            {
                MessageBox.Show("Group A 를 설정 하십시오.", "VIZCore3D.NET.ClashTest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (groupB.Count == 0)
            {
                MessageBox.Show("Group B 를 설정 하십시오.", "VIZCore3D.NET.ClashTest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            resultItems = new List<ClashTestResultItem>();
            vizcore3d.Clash.Clear();
            clash = new Data.ClashTest();

            //vizcore3d.ShowProgressForm();

            vizcore3d.Object3D.Transform.RestoreTransformAll();

            vizcore3d.Animation.PlayingTime = AnimationDuration;

            vizcore3d.View.RealtimeShadow = true;
            vizcore3d.View.EnvironmentLight = true;
            vizcore3d.View.AntiAliasing = true;

            if (vizcore3d.View.Projection == Data.Projections.Orthographic)
                vizcore3d.View.Projection = VIZCore3D.NET.Data.Projections.Perspective;  /* 원근 뷰 설정 */

            PlaybackTime = 0.0f;

            PlayFrame();
        }

        private void PlayFrame()
        {
            if (PlaybackTime >= AnimationDuration)
            {
                MessageBox.Show("간섭검사 완료.", "VIZCore3D.NET.ClashTest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            vizcore3d.Animation.Play(false, PlaybackTime);
            vizcore3d.Animation.Pause();

            PlaybackTime = Math.Min(AnimationDuration, PlaybackTime + OneFrameDuration);

            Thread thread = new Thread(() => DoClashTest());
            thread.Start();
        }

        private void DoClashTest()
        {
            clash.Name = "CLASH TEST #1";
            clash.TestKind = VIZCore3D.NET.Data.ClashTest.ClashTestKind.GROUP_VS_GROUP;

            clash.GroupA = groupA;
            clash.GroupB = groupB;
            clash.Path.Clear();
            //clash.Path.Add(new ClashTestPathItem());

            clash.UseClearanceValue = false;    // 여유허용범위
            clash.ClearanceValue = 0.0f;        // 여유허용범위
            clash.UseRangeValue = ckUseRangeValue.Checked;          // 근접허용범위
            clash.RangeValue = Convert.ToSingle(txtRangeValue.Text);// 근접허용범위
            clash.UsePenetrationTolerance = ckUsePenetrationTolerance.Checked;          // 접촉허용오차
            clash.PenetrationTolerance = Convert.ToSingle(txtPenetrationTolerance.Text);// 접촉허용오차

            clash.VisibleOnly = ckVisibleOnly.Checked;
            clash.BottomLevel = Convert.ToInt32(txtBottomLevel.Text) + 1;

            vizcore3d.Clash.Clear();
            bool result = vizcore3d.Clash.Add(clash);

            vizcore3d.Clash.EnableMultiThread = false;
            vizcore3d.Clash.PerformInterferenceCheck(clash.ID, false);
        }

        private void ShowResultList()
        {
            if (resultItems.Count == 0) lvResult.Items.Clear();

            // 침투만 조회
            bool PenetrationOnly = ckPenetration.Checked;

            List<VIZCore3D.NET.Data.ClashTestResultItem> items = null;

            items = vizcore3d.Clash.GetResultItem(
                clash
                , ckResultAssembly.Checked == true
                ? VIZCore3D.NET.Manager.ClashManager.ResultGroupingOptions.ASSEMBLY
                : VIZCore3D.NET.Manager.ClashManager.ResultGroupingOptions.PART
                );

            // 인접면 법선벡터 구하기
            bool checkConnectedSurfaceNormalVector = ckConnectedSurfaceNormalVector.Checked;

            for (int i = 0; i < items.Count; i++)
            {
                VIZCore3D.NET.Data.ClashTestResultItem item = items[i];

                //ClashTestPathItem path = new ClashTestPathItem();
                //ClashTestPathItem oldPath = pathItems[progressIndex];
                //path.X = oldPath.X;
                //path.Y = oldPath.Y;
                //path.Z = oldPath.Z;

                string normal = String.Empty;
                string projection1 = String.Empty;
                string projection2 = String.Empty;

                if (checkConnectedSurfaceNormalVector == true)
                {
                    VIZCore3D.NET.Data.ConnectedSurfaceNormalVectorItem normalVector =
                        vizcore3d.GeometryUtility.GetConnectedSurfaceNormalVector(
                            item.NodeIndexA
                            , item.NodeIndexB
                            , item.HotPoint
                            , 10.0f
                            );

                    normal = normalVector.Normal.ToString();
                    projection1 = normalVector.Projection1.ToString();
                    projection2 = normalVector.Projection2.ToString();
                }


                ListViewItem lvi = new ListViewItem(
                    new string[]
                        {
                            Convert.ToString(i + 1)
                            , item.ID.ToString()
                            , item.SUBID.ToString()
                            , "-" //item.Path != null ? item.Path.ToString() : path.ToString()
                            , item.GetResultKindString()
                            , item.NodeIndexA.ToString()
                            , item.NodeIndexB.ToString()
                            , item.NodeNameA
                            , item.NodeNameB
                            , item.Distance.ToString()
                            , item.HotPoint.ToString()
                            , item.FrameStringX
                            , item.FrameStringY
                            , item.FrameStringZ
                            , item.Flag.ToString()
                            , item.NodeIdA.ToString()
                            , item.NodeIdB.ToString()
                            , item.Comment1
                            , item.Comment2
                            , item.ParentNodeNameA
                            , item.ParentNodeNameB
                            , item.NodePathA
                            , item.NodePathB
                            , normal
                            , projection1
                            , projection2
                            , PlaybackTime.ToString()
                        }
                    );
                lvi.Tag = item;

                if (PenetrationOnly == true && item.ResultKind == Data.ClashTestResultItem.ClashResultKind.PENETRATION)
                    lvResult.Items.Add(lvi);
                else if (PenetrationOnly == false)
                    lvResult.Items.Add(lvi);
            }

            resultItems.AddRange(items);

            gbResult.Text = string.Format("Result : {0:N0} EA", lvResult.Items.Count);
            lvResult.Update();
        }

        private void lvResult_DoubleClick(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems.Count == 0) return;
            if (lvResult.SelectedItems[0].Tag == null) return;

            VIZCore3D.NET.Data.ClashTestResultItem item = (VIZCore3D.NET.Data.ClashTestResultItem)lvResult.SelectedItems[0].Tag;

            vizcore3d.BeginUpdate();

            float playbackTime = float.Parse(lvResult.SelectedItems[0].SubItems[26].Text);

            // 해당 시점으로 모델 이동
            vizcore3d.Animation.Play(false, playbackTime);
            vizcore3d.Animation.Pause();

            // Xray Mode
            if (vizcore3d.View.XRay.Enable == false)
                vizcore3d.View.XRay.Enable = true;

            // Xray Mode Option
            vizcore3d.View.XRay.ColorType = Data.XRayColorTypes.OBJECT_COLOR;
            vizcore3d.View.XRay.SelectionObject3DType = Data.SelectionObject3DTypes.OPAQUE_OBJECT3D;

            // Clear Selection
            vizcore3d.View.XRay.Clear();

            // Select
            vizcore3d.View.XRay.Select(new List<int>() { item.NodeIndexA, item.NodeIndexB }, true);

            // Fly
            vizcore3d.View.FlyToObject3d(new List<int>() { item.NodeIndexA, item.NodeIndexB }, 2);
            
            // Add Vertex :: HOT POINT
            //vizcore3d.ShapeDrawing.Clear();
            //vizcore3d.ShapeDrawing.AddVertex(new List<Data.Vertex3D>() { item.HotPoint }, 0, Color.Red, 10.0f, 10.0f, true);

            // Set Pivot :: Rotation
            //vizcore3d.View.SetPivotPosition(item.HotPoint);

            // Add Note :: Result Item
            VIZCore3D.NET.Data.Vertex3D v1 = vizcore3d.Object3D.GetSurfaceVertexClosestToModelCenter(new List<int>() { item.NodeIndexA });
            VIZCore3D.NET.Data.Vertex3D v2 = vizcore3d.Object3D.GetSurfaceVertexClosestToModelCenter(new List<int>() { item.NodeIndexB });

            vizcore3d.Review.Note.Clear();

            string text = string.Format("{0}\r\n{1} : {2}mm", item.HotPoint.ToString(), item.ResultKind.ToString(), item.Distance.ToString());
            vizcore3d.Review.Note.AddNoteSurface(text, item.HotPoint, item.HotPoint);

            //vizcore3d.Review.Note.AddNoteSurface(item.NodeNameA, v1.Clone().AddValue(Data.Axis.Y, 1000.0f), v1);
            //vizcore3d.Review.Note.AddNoteSurface(item.NodeNameB, v2.Clone().AddValue(Data.Axis.Y, 1000.0f), v2);

            //// Add Result Symbol
            //vizcore3d.Clash.ShowResultSymbol(
            //    new List<VIZCore3D.NET.Data.Vertex3D>() { item.HotPoint }
            //    , new List<VIZCore3D.NET.Data.ClashResultSymbols>() { VIZCore3D.NET.Data.ClashResultSymbols.Triangle }
            //    , 10.0f
            //    , true
            //    , Color.Yellow
            //    , false
            //    );

            vizcore3d.EndUpdate();
        }
    }
}
