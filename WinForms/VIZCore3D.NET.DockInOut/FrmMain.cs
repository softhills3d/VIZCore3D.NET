using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.DockInOut
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
        /// VIZCore3D.NET : SUPPORTER
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d_supporter;

        /// <summary>
        /// 3D Model BoundBox
        /// </summary>
        public VIZCore3D.NET.Data.BoundBox3D SHIP_BOUNDBOX { get; set; }
        public List<VIZCore3D.NET.Data.Node> SHIP_NODE { get; set; }

        public Dictionary<string, VIZCore3D.NET.Data.Vertex3D> SUPPORTER_POSITION { get; set; }

        public Dictionary<string, List<VIZCore3D.NET.Data.Vertex3D>> COLLISION_MAP { get; set; }


        /// <summary>
        /// Dock BoundBox
        /// </summary>
        public VIZCore3D.NET.Data.BoundBox3D DOCK_BOUNDBOX { get; set; }

        /// <summary>
        /// Water BoundBox
        /// </summary>
        public VIZCore3D.NET.Data.BoundBox3D WATER_BOUNDBOX { get; set; }

        public float LastWaterZHeight { get; set; }

        /// <summary>
        /// Water Box ID
        /// </summary>
        public int WATER_BOX_ID { get; set; }


        public VIZCore3D.NET.Data.ClashTest CLASH_ITEM { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            // Construction
            string backgroudImagePath = System.IO.Path.Combine(Application.StartupPath, "BACKGROUND_CUSTOMER.jpg");
            if (System.IO.File.Exists(backgroudImagePath) == true)
            {
                Image background = Image.FromFile(backgroudImagePath);
                vizcore3d = new VIZCore3D.NET.VIZCore3DControl(background, Data.ImageMode.CENTER, Color.Gray);
            }
            else
            {
                vizcore3d = new VIZCore3D.NET.VIZCore3DControl(VIZCore3D.NET.BackgroundImage.VIZZARD);
            }

            vizcore3d.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(vizcore3d);

            vizcore3d_supporter = new VIZCore3DControl(VIZCore3D.NET.BackgroundImage.VIZZARD);
            vizcore3d_supporter.Dock = DockStyle.Fill;
            gbPreviewSupporter.Controls.Add(vizcore3d_supporter);

            // Event
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
            vizcore3d_supporter.OnInitializedVIZCore3D += VIZCore3D_Supporter_OnInitializedVIZCore3D;
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
            InitializeVIZCore3DToolbar();
        }

        private void VIZCore3D_Supporter_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
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
                licenseResult = vizcore3d_supporter.License.LicenseServer(
                    licenseInfo.ContainsKey("LICENSE_IP") == true ? licenseInfo["LICENSE_IP"] : String.Empty
                    , licenseInfo.ContainsKey("LICENSE_PORT") == true ? Convert.ToInt32(licenseInfo["LICENSE_PORT"]) : 8901
                    );
            }
            // 라이선스 파일
            else if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.FILE)
            {
                licenseResult = vizcore3d_supporter.License.LicenseFile(
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
            vizcore3d_supporter.Statusbar.Visible = false;
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
            vizcore3d.View.SelectionObject3DType = VIZCore3D.NET.Data.SelectionObject3DTypes.OPAQUE_OBJECT3D;

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

            // 핸들 : 축 기준으로 이동
            vizcore3d.Object3D.Transform.HandleMode = Manager.TransformManager.HandleModes.MoveByAxis;

            // 상위 모델 선택 금지
            vizcore3d.View.EnableParentSelection = false;
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

            vizcore3d.View.PhongShading = true;
            vizcore3d.View.SilhouetteEdge = true;
            vizcore3d.View.RealtimeShadow = true;
            vizcore3d.View.ShadingEffect = true;
            vizcore3d.View.EnvironmentLight = true;
            vizcore3d.View.AntiAliasing = true;
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
            measureStyle.Prefix = false;
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
            measureStyle.LineColor = Color.Blue;
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
            vizcore3d.Section.ShowSectionLineColor = true;
            // 단면 단일색
            vizcore3d.Section.SectionLineColor = Color.Black;
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
            vizcore3d.ToolbarNote.Visible = true;
            vizcore3d.ToolbarMeasure.Visible = true;
            vizcore3d.ToolbarSection.Visible = true;
            vizcore3d.ToolbarClash.Visible = false;
            vizcore3d.ToolbarAnimation.Visible = false;
            vizcore3d.ToolbarSimulation.Visible = false;
            vizcore3d.ToolbarPrimitive.Visible = true;
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

        #region Function - VIZCore3D.NET : Custom Event
        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            vizcore3d.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;
            vizcore3d.Clash.OnClashTestFinishedEvent += Clash_OnClashTestFinishedEvent;
        }
        #endregion

        #region Function - VIZCore3D.NET : Customize Toolbar
        private void InitializeVIZCore3DToolbar()
        {
            {
                // Main Toolbar Item Count
                int maxIndex = vizcore3d.ToolbarMain.Items.Count;

                // Add Separator Control
                vizcore3d.ToolbarMain.Items.Add(new ToolStripSeparator());
                maxIndex++;

                // Note Toolbar Item Count
                int count = vizcore3d.ToolbarNote.Items.Count;

                // Insert Item
                for (int i = count; i > 0; i--)
                {
                    // Insert : Moved Item
                    vizcore3d.ToolbarMain.Items.Insert(
                        maxIndex // Index to be inserted
                        , vizcore3d.ToolbarNote.Items[i - 1] // Item Index
                        );
                }

                // Hide Toolbar : Empty Item
                vizcore3d.ToolbarNote.Visible = false;
            }

            {
                // Section Toolbar Item Count
                int maxIndex = vizcore3d.ToolbarSection.Items.Count;

                // Add Separator Control
                vizcore3d.ToolbarSection.Items.Add(new ToolStripSeparator());
                maxIndex++;

                // Measure Toolbar Item Count
                int count = vizcore3d.ToolbarMeasure.Items.Count;

                // Insert Item
                for (int i = count; i > 0; i--)
                {
                    // Insert : Moved Item
                    vizcore3d.ToolbarSection.Items.Insert(
                        maxIndex // Index to be inserted
                        , vizcore3d.ToolbarMeasure.Items[i - 1] // Item Index
                        );
                }

                // Hide Toolbar : Empty Item
                vizcore3d.ToolbarMeasure.Visible = false;
            }

            {
                // Section Toolbar Item Count
                int maxIndex = vizcore3d.ToolbarSection.Items.Count;

                // Add Separator Control
                vizcore3d.ToolbarSection.Items.Add(new ToolStripSeparator());
                maxIndex++;

                // Primitive Toolbar Item Count
                int count = vizcore3d.ToolbarPrimitive.Items.Count;

                // Insert Item
                for (int i = count; i > 0; i--)
                {
                    // Insert : Moved Item
                    vizcore3d.ToolbarSection.Items.Insert(
                        maxIndex // Index to be inserted
                        , vizcore3d.ToolbarPrimitive.Items[i - 1] // Item Index
                        );
                }

                // Hide Toolbar : Empty Item
                vizcore3d.ToolbarPrimitive.Visible = false;
            }
        }
        #endregion

        // ================================================
        // EVENT - OBJECT3D SELECTED
        // ================================================
        private void Object3D_OnObject3DSelected(object sender, Event.EventManager.Object3DSelectedEventArgs e)
        {

        }


        // ================================================
        // Function - DOCK
        // ================================================
        private void btnDockGenerate_Click(object sender, EventArgs e)
        {   
            float thickness = 300.0f;

            bool dockSideAll = ckDockSideAll.Checked;

            List<float> dockSize = GetDockSize();

            // New Empty Model
            int rootIndex = vizcore3d.Model.NewEmptyModel("MODEL");

            vizcore3d.BeginUpdate();

            VIZCore3D.NET.Data.Node dockAssy = vizcore3d.Structure.CreateNode(
                rootIndex
                , VIZCore3D.NET.Data.NodeKind.ASSEMBLY
                , "DOCK_ASSY"
                );

            // 바닥면
            {
                VIZCore3D.NET.Data.Node dockPart = vizcore3d.Structure.CreateNode(
                    dockAssy.Index
                    , VIZCore3D.NET.Data.NodeKind.PART
                    , "DOCK_PART_BOTTOM"
                    );

                int bodyId = vizcore3d.Structure.CreateBody(dockPart.Index, "BODY");
                int bodyIndex = vizcore3d.Structure.GetBodyIndex(bodyId);

                List<float> length = new List<float>();
                length.Add(dockSize[0]);
                length.Add(dockSize[1]);
                length.Add(thickness);

                VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                matrix.SetTranslate(0, 0, -dockSize[2]);

                Color dockColor = Color.FromArgb(50, 128, 128, 128);

                vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
            }

            // 뒷면
            if (dockSideAll == true)
            {
                VIZCore3D.NET.Data.Node dockPart = vizcore3d.Structure.CreateNode(
                    dockAssy.Index
                    , VIZCore3D.NET.Data.NodeKind.PART
                    , "DOCK_PART_LEFT"
                    );

                int bodyId = vizcore3d.Structure.CreateBody(dockPart.Index, "BODY");
                int bodyIndex = vizcore3d.Structure.GetBodyIndex(bodyId);

                List<float> length = new List<float>();
                length.Add(thickness);
                length.Add(dockSize[1]);
                length.Add(dockSize[2]);

                VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                matrix.SetTranslate(-dockSize[0] / 2, 0, -dockSize[2] / 2);

                Color dockColor = Color.FromArgb(50, 128, 128, 128);

                vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
            }

            // 앞면
            if (dockSideAll == true)
            {
                VIZCore3D.NET.Data.Node dockPart = vizcore3d.Structure.CreateNode(
                    dockAssy.Index
                    , VIZCore3D.NET.Data.NodeKind.PART
                    , "DOCK_PART_RIGHT"
                    );

                int bodyId = vizcore3d.Structure.CreateBody(dockPart.Index, "BODY");
                int bodyIndex = vizcore3d.Structure.GetBodyIndex(bodyId);

                List<float> length = new List<float>();
                length.Add(thickness);
                length.Add(dockSize[1]);
                length.Add(dockSize[2]);

                VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                matrix.SetTranslate(dockSize[0] / 2, 0, -dockSize[2] / 2);

                Color dockColor = Color.FromArgb(50, 128, 128, 128);

                vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
            }

            // 왼쪽면
            if (dockSideAll == true)
            {
                VIZCore3D.NET.Data.Node dockPart = vizcore3d.Structure.CreateNode(
                    dockAssy.Index
                    , VIZCore3D.NET.Data.NodeKind.PART
                    , "DOCK_PART_BACK"
                    );

                int bodyId = vizcore3d.Structure.CreateBody(dockPart.Index, "BODY");
                int bodyIndex = vizcore3d.Structure.GetBodyIndex(bodyId);

                List<float> length = new List<float>();
                length.Add(dockSize[0]);
                length.Add(thickness);
                length.Add(dockSize[2]);

                VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                matrix.SetTranslate(0, dockSize[1] / 2, -dockSize[2] / 2);

                Color dockColor = Color.FromArgb(50, 128, 128, 128);

                vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
            }

            // 오른쪽면
            if (dockSideAll == true)
            {
                VIZCore3D.NET.Data.Node dockPart = vizcore3d.Structure.CreateNode(
                    dockAssy.Index
                    , VIZCore3D.NET.Data.NodeKind.PART
                    , "DOCK_PART_FRONT"
                    );

                int bodyId = vizcore3d.Structure.CreateBody(dockPart.Index, "BODY");
                int bodyIndex = vizcore3d.Structure.GetBodyIndex(bodyId);

                List<float> length = new List<float>();
                length.Add(dockSize[0]);
                length.Add(thickness);
                length.Add(dockSize[2]);

                VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                matrix.SetTranslate(0, -dockSize[1] / 2, -dockSize[2] / 2);

                Color dockColor = Color.FromArgb(50, 128, 128, 128);

                vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
            }

            // 데이터 재구성
            vizcore3d.Structure.RebuildData();

            vizcore3d.EndUpdate();
        }

        private void btnDockDelete_Click(object sender, EventArgs e)
        {
            ExistDockModel(true);
        }

        private bool ExistDockModel(bool remove)
        {
            List<VIZCore3D.NET.Data.Node> dock =
                vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "DOCK_ASSY" }, false, true, false, false, true, false);

            if (dock.Count == 0) return false;

            if (remove == true)
            {
                vizcore3d.Object3D.Delete(dock);
            }

            return true;
        }

        private List<float> GetDockSize()
        {
            string strDockLength = txtDockLength.Text; // m
            string strDockBreadth = txtDockBreadth.Text; // m
            string strDockDepth = txtDockDepth.Text; // m

            float fDockLength = Convert.ToSingle(strDockLength) * 1000.0f;
            float fDockBreadth = Convert.ToSingle(strDockBreadth) * 1000.0f;
            float fDockDepth = Convert.ToSingle(strDockDepth) * 1000.0f;

            List<float> items = new List<float>();
            items.Add(fDockLength);
            items.Add(fDockBreadth);
            items.Add(fDockDepth);

            return items;
        }

        private void ckDockSideShow_CheckedChanged(object sender, EventArgs e)
        {
            ShowDockSide();
        }

        private void ShowDockSide()
        {
            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "DOCK_PART_LEFT", "DOCK_PART_RIGHT", "DOCK_PART_BACK", "DOCK_PART_FRONT" }, false, false, false, false, true, false);
            if (nodes.Count == 0) return;

            vizcore3d.Object3D.Show(nodes, ckDockSideShow.Checked);
        }



        // ================================================
        // Function - SHIP
        // ================================================
        private void btnOpenSHIP_Click(object sender, EventArgs e)
        {
            string name = System.Environment.MachineName.ToUpper();
            if (name == "GJKIM-ADELL")
            {
                string path = "E:\\MODELS\\SHOWCASE\\DDH.V6.viz";
                vizcore3d.Model.AddStream(new VIZCore3D.NET.Data.StreamData(System.IO.File.ReadAllBytes(path), "SHIP_MODEL"));
            }
            else
            {
                vizcore3d.Model.AddFileDialog();
            }

            UpdateShipNodeBoundBox();

            ArrangeDock();
        }

        private void UpdateShipNodeBoundBox()
        {
            // SHIP - NODE
            SHIP_NODE = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "SHIP_MODEL" }, false, true, false, false, true, false);
            if (SHIP_NODE.Count == 0) return;

            // SHIP - BOUNDBOX
            SHIP_BOUNDBOX = vizcore3d.Object3D.GeometryProperty.FromNode(SHIP_NODE).GetBoundBox();
        }

        private void ArrangeDock()
        {
            List<VIZCore3D.NET.Data.Node> dock = vizcore3d.Object3D.Find.QuickSearch("DOCK_ASSY", true);
            if (dock.Count == 0) return;

            string strDockFrontOffset = txtDockFrontOffset.Text;    // mm
            string strDockSideOffset = txtDockSideOffset.Text;      // mm
            string strDockBaseline = txtDockBaseline.Text;          // mm

            float fDockFrontOffset = Convert.ToSingle(strDockFrontOffset);
            float fDockSideOffset = Convert.ToSingle(strDockSideOffset);
            float fDockBaseline = Convert.ToSingle(strDockBaseline);

            VIZCore3D.NET.Data.BoundBox3D dockBoundBox = vizcore3d.Object3D.GeometryProperty.FromNode(dock).GetBoundBox();
            List<float> dockSize = GetDockSize();

            vizcore3d.Object3D.Transform.Move(
                dock
                , -(dockBoundBox.LengthX / 2) + (SHIP_BOUNDBOX.LengthX / 2) + fDockFrontOffset
                , (dockBoundBox.LengthY / 2) - (SHIP_BOUNDBOX.LengthY / 2) - fDockSideOffset
                , SHIP_BOUNDBOX.MinZ - dockBoundBox.MinZ - fDockBaseline
                );
        }


        private void btnShipShow_Click(object sender, EventArgs e)
        {
            if (SHIP_NODE.Count == 0) return;
            vizcore3d.Object3D.Show(SHIP_NODE, true);
        }

        private void btnShipHide_Click(object sender, EventArgs e)
        {
            if (SHIP_NODE.Count == 0) return;
            vizcore3d.Object3D.Show(SHIP_NODE, false);
        }


        // ================================================
        // Function - FRAME
        // ================================================
        private void btnShipFrame_Click(object sender, EventArgs e)
        {
            //vizcore3d.Frame.OpenFileDialog();

            if(SHIP_BOUNDBOX == null)
                UpdateShipNodeBoundBox();

            vizcore3d.BeginUpdate();
            vizcore3d.Frame.BeginUpdate(); // 갱신 시작

            #region X축
            vizcore3d.Frame.UpdateGridAxisName(Data.Axis.X, "FR"); // X 축명 변경

            cbFrameStart.BeginUpdate();
            cbFrameStart.Items.Clear();

            cbFrameEnd.BeginUpdate();
            cbFrameEnd.Items.Clear();

            int xCount = Convert.ToInt32((SHIP_BOUNDBOX.LengthX / 1000.0f));
            for (int i = 0; i < xCount; i++)
            {
                vizcore3d.Frame.AddGridLine(Data.Axis.X, i, SHIP_BOUNDBOX.MaxX - (i * 1000.0f));

                cbFrameStart.Items.Add(i.ToString());
                cbFrameEnd.Items.Add(i.ToString());
            }

            cbFrameStart.EndUpdate();
            cbFrameEnd.EndUpdate();
            #endregion

            #region Y축
            vizcore3d.Frame.UpdateGridAxisName(Data.Axis.Y, "LP"); // Y축명 변경

            int yCount = Convert.ToInt32((SHIP_BOUNDBOX.LengthY / 4000.0f));

            for (int i = 0; i < yCount; i++)
            {
                vizcore3d.Frame.AddGridLine(Data.Axis.Y, i, SHIP_BOUNDBOX.CenterY + (i * 2000.0f));
            }

            for (int i = 1; i < yCount; i++)
            {
                vizcore3d.Frame.AddGridLine(Data.Axis.Y, i, SHIP_BOUNDBOX.CenterY - (i * 2000.0f));
            }
            #endregion

            #region Z축
            vizcore3d.Frame.UpdateGridAxisName(Data.Axis.Z, "LP"); //Z 축명 변경

            int zCount = Convert.ToInt32((SHIP_BOUNDBOX.LengthZ / 2000.0f));
            for (int i = 0; i < zCount; i++)
            {
                vizcore3d.Frame.AddGridLine(Data.Axis.Z, i, SHIP_BOUNDBOX.MinZ + (i * 2000.0f));
            } 
            #endregion

            vizcore3d.Frame.EndUpdate(); // 갱신 종료
            vizcore3d.EndUpdate();

            vizcore3d.Frame.Visible = true; // 화면 표시
        }

        private void ckFrameVisible_CheckedChanged(object sender, EventArgs e)
        {
            vizcore3d.Frame.Visible = ckFrameVisible.Checked;
        }

        // ================================================
        // Function - GRID
        // ================================================
        private void btnGridGenerate_Click(object sender, EventArgs e)
        {
            List<float> dockSize = GetDockSize();

            float intervalX = Convert.ToSingle(txtGridIntervalX.Text); // mm
            float intervalY = Convert.ToSingle(txtGridIntervalY.Text); // mm

            float fTimesX = dockSize[0] / intervalX;
            float fTimesY = dockSize[1] / intervalY;

            int nTimesX = Convert.ToInt32(fTimesX);
            int nTimesY = Convert.ToInt32(fTimesY);

            List<VIZCore3D.NET.Data.Node> dockNode = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "DOCK_ASSY" }, false, true, false, false, true, false);
            if (dockNode.Count == 0) return;

            VIZCore3D.NET.Data.BoundBox3D dockBoundBox = vizcore3d.Object3D.GeometryProperty.FromNode(dockNode).GetBoundBox();


            float startX = dockBoundBox.CenterX - (dockSize[0] / 2);
            float startY = dockBoundBox.CenterY + (dockSize[1] / 2);
            float depth = dockBoundBox.MinZ + 300.0f;

            VIZCore3D.NET.Manager.PrimitiveObject gridAssy = vizcore3d.Primitive.AddNode("GRID_ASSY_ROOT", 4 /* Yellow Color*/);

            for (int i = 0; i < nTimesX; i++)
            {
                for (int j = 0; j < nTimesY; j++)
                {
                    VIZCore3D.NET.Manager.PrimitiveObject gridPart = gridAssy.AddNode(string.Format("GRID_PART_{0}_{1}", i + 1, j + 1), 1 /* Gray */);

                    List<float> length = new List<float>();
                    length.Add(intervalX - 2.0f);
                    length.Add(intervalY - 2.0f);
                    length.Add(10.0f);

                    VIZCore3D.NET.Manager.PrimitiveBox box1 =
                        new VIZCore3D.NET.Manager.PrimitiveBox();

                    VIZCore3D.NET.Data.Vertex3D min = new VIZCore3D.NET.Data.Vertex3D(
                        startX + (i * intervalX) 
                        , startY - (j * intervalY)
                        , depth - 5.0f
                        );

                    VIZCore3D.NET.Data.Vertex3D max = new VIZCore3D.NET.Data.Vertex3D(
                        startX + ((i + 1) * intervalX)
                        , startY - ((j + 1) * intervalY)
                        , depth + 5.0f
                        );

                    box1.SetMinMaxPoints(new VIZCore3D.NET.Data.BoundBox3D(min, max));

                    gridPart.AddPrimitive(box1);

                    //GridSpaceItem gs = new GridSpaceItem();
                    //gs.Name = string.Format("GRID_PART_{0}_{1}", i + 1, j + 1);
                    //gs.NoX = i + 1;
                    //gs.NoY = j + 1;
                    //gs.GridBoundBox = new VIZCore3D.NET.Data.BoundBox3D(min, max);
                    //CollisionManager.Add(gs);
                }
            }

            byte[] buffer = vizcore3d.Primitive.GetStream("GRID_MODOEL");

            vizcore3d.Model.AddStream(new List<VIZCore3D.NET.Data.StreamData>() { new VIZCore3D.NET.Data.StreamData(buffer, "GRID_MODEL") });
        }


        // ================================================
        // Function - SUPPORTER
        // ================================================
        private void btnSuppPreview_Click(object sender, EventArgs e)
        {
            int index = vizcore3d_supporter.Model.NewEmptyModel("SUPPORTER");

            VIZCore3D.NET.Data.Node supporterAssy = vizcore3d_supporter.Structure.CreateNode(
                index
                , VIZCore3D.NET.Data.NodeKind.ASSEMBLY
                , "SUPPORTER_ASSY"
                );

            VIZCore3D.NET.Data.Node supporterPart = vizcore3d_supporter.Structure.CreateNode(
                supporterAssy.Index
                , VIZCore3D.NET.Data.NodeKind.PART
                , "SUPPORTER_PART"
                );

            int bodyId = vizcore3d_supporter.Structure.CreateBody(supporterPart.Index, "BODY");
            int bodyIndex = vizcore3d_supporter.Structure.GetBodyIndex(bodyId);

            VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
            matrix.SetTranslate(
                0
                , 0
                , SHIP_BOUNDBOX.MinZ
                    - Convert.ToSingle(txtDockBaseline.Text)
                    + (Convert.ToSingle(txtSuppHeight.Text) / 2)
                    + 300.0f
                );

            vizcore3d_supporter.MeshEdit.AddPrimitivePyramid(
                bodyIndex
                , new SizeF(Convert.ToSingle(txtSuppBottomX.Text), Convert.ToSingle(txtSuppBottomY.Text))
                , new SizeF(Convert.ToSingle(txtSuppTopX.Text), Convert.ToSingle(txtSuppTopY.Text))
                , new SizeF(Convert.ToSingle(txtSuppOffsetX.Text), Convert.ToSingle(txtSuppOffsetY.Text))
                , Convert.ToSingle(txtSuppHeight.Text)
                , matrix
                , Color.LightBlue
                , false
                );

            vizcore3d_supporter.Structure.RebuildData();

            string path = string.Format("{0}\\{1}", Application.StartupPath, "SUPPORTER.viz");
            if (System.IO.File.Exists(path) == true)
                System.IO.File.Delete(path);

            vizcore3d_supporter.Model.SaveAsVIZ(path);
        }

        private void btnSuppAdd_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> prevNodes = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "SUPPORTER_NO_" }, false, true, false, false, false, false);
            if(prevNodes.Count > 0)
            {
                vizcore3d.Object3D.Delete(prevNodes);
            }

            string start = cbFrameStart.Text;
            string end = cbFrameEnd.Text;

            if (String.IsNullOrEmpty(start) == true) return;
            if (String.IsNullOrEmpty(end) == true) return;

            int idx1 = Convert.ToInt32(start);
            int idx2 = Convert.ToInt32(end);

            string path = string.Format("{0}\\{1}", Application.StartupPath, "SUPPORTER.viz");
            if (System.IO.File.Exists(path) == false) return;

            byte[] buffer = System.IO.File.ReadAllBytes(path);
            List<VIZCore3D.NET.Data.StreamData> stream = new List<VIZCore3D.NET.Data.StreamData>();

            lvSupporter.BeginUpdate();
            lvSupporter.Items.Clear();

            for (int i = idx1; i < idx2; i+=2)
            {
                for (int j = 0; j < 5; j++)
                {
                    byte[] model = new byte[buffer.Length];
                    buffer.CopyTo(model, 0);

                    string nodeName = string.Format("SUPPORTER_NO_{0}_{1}", i, j);

                    VIZCore3D.NET.Data.StreamData supporterModel = new VIZCore3D.NET.Data.StreamData(model, nodeName);
                    stream.Add(supporterModel);

                    lvSupporter.Items.Add(nodeName);
                }
            }

            lvSupporter.EndUpdate();

            if (stream.Count == 0) return;
            vizcore3d.Model.AddStream(stream);

            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "SUPPORTER_NO_" }, false, true, false, false, false, false);
            if (nodes.Count == 0) return;

            SUPPORTER_POSITION = new Dictionary<string, VIZCore3D.NET.Data.Vertex3D>();

            vizcore3d.BeginUpdate();
            foreach (VIZCore3D.NET.Data.Node item in nodes)
            {
                string name = item.NodeName;
                string name_id = name.Replace("SUPPORTER_NO_", "");
                string[] ids = name_id.Split(new char[] { '_' });

                if (ids.Length != 2) continue;
                int yNo = Convert.ToInt32(ids[1]);

                VIZCore3D.NET.Data.FramePosition fpt = vizcore3d.Frame.GetPosition(VIZCore3D.NET.Data.Axis.X, string.Format("FR{0}", ids[0]));

                float y = 0.0f;
                if (yNo != 0)
                {
                    switch (yNo)
                    {
                        case 1:
                            y = 2000.0f;
                            break;
                        case 2:
                            y = -2000.0f;
                            break;
                        case 3:
                            y = 4000.0f;
                            break;
                        case 4:
                            y = -4000.0f;
                            break;
                        default:
                            break;
                    }
                }


                item.Move(
                    fpt.Position
                    , y
                    , 0
                    );

                if(SUPPORTER_POSITION.ContainsKey(name) == false)
                {
                    SUPPORTER_POSITION.Add(name, new VIZCore3D.NET.Data.Vertex3D(fpt.Position, y, 0));
                }
            }
            vizcore3d.EndUpdate();
        }

        private void lvSupporter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSupporter.SelectedItems.Count == 0) return;

            ListViewItem lvi = lvSupporter.SelectedItems[0];
            string name = lvi.SubItems[0].Text;

            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { name }, false, true, false, false, false, false);
            if (nodes.Count == 0) return;

            vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.Object3D.Select(nodes, true, true);
        }

        private void btnSupporterShowAll_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();

            for (int i = 0; i < lvSupporter.Items.Count; i++)
            {
                ListViewItem lvi = lvSupporter.Items[i];
                string name = lvi.SubItems[0].Text;

                items.Add(name);

                // SUPPORTER_NO_20_2
                // SUPPORTER_VARIABLE_NO_20_2

                string name_link = string.Format("SUPPORTER_VARIABLE_NO_{0}", name.Replace("SUPPORTER_NO_", ""));

                items.Add(name_link);
            }

            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(items, false, false, false, false, true, false);

            if (nodes.Count == 0) return;

            vizcore3d.Object3D.Show(nodes, true);
        }

        private void btnSupporterHide_Click(object sender, EventArgs e)
        {
            if (lvSupporter.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSupporter.SelectedItems[0];
            List<string> items = new List<string>();

            string name = lvi.SubItems[0].Text;
            items.Add(name);

            // SUPPORTER_NO_20_2
            // SUPPORTER_VARIABLE_NO_20_2

            string name_link = string.Format("SUPPORTER_VARIABLE_NO_{0}", name.Replace("SUPPORTER_NO_", ""));

            items.Add(name_link);


            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(items, false, false, false, false, true, false);

            if (nodes.Count == 0) return;

            vizcore3d.Object3D.Show(nodes, false);
        }


        // ================================================
        // Function - ANALYSIS
        // ================================================
        private void btnBaseline_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Frame.HasFrame == false) return;

            VIZCore3D.NET.Data.FramePosition fp = vizcore3d.Frame.GetPosition(VIZCore3D.NET.Data.Axis.Z, "LP", 0, 0);
            txtAnalysisBaseline.Text = fp.Position.ToString();
        }

        private void btnAnalysisMeasure_Click(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.MeasureStyle style = vizcore3d.Review.Measure.GetStyle();
            style.Frame = false;
            vizcore3d.Review.Measure.SetStyle(style);

            COLLISION_MAP = new Dictionary<string, List<VIZCore3D.NET.Data.Vertex3D>>();

            float baseAxisZ = Convert.ToSingle(txtAnalysisBaseline.Text);

            if (ckBaselineToSHIP.Checked == false)
            {
                baseAxisZ =
                    SHIP_BOUNDBOX.MinZ
                    - Convert.ToSingle(txtDockBaseline.Text)
                    + 300.0f;
            }

            if (SUPPORTER_POSITION.Count == 0) return;

            vizcore3d.BeginUpdate();

            vizcore3d.Object3D.Show(Data.Object3DKind.ALL, false);
            vizcore3d.Object3D.Show(SHIP_NODE, true);

            float supp_breadth = Convert.ToSingle(txtSuppTopY.Text);

            foreach (KeyValuePair<string, VIZCore3D.NET.Data.Vertex3D> item in SUPPORTER_POSITION)
            {
                List<VIZCore3D.NET.Data.Vertex3D> points = new List<VIZCore3D.NET.Data.Vertex3D>();

                VIZCore3D.NET.Data.Vertex3D measure = new VIZCore3D.NET.Data.Vertex3D(item.Value.X, item.Value.Y, baseAxisZ);
                VIZCore3D.NET.Data.Vertex3D measure_left = new VIZCore3D.NET.Data.Vertex3D(item.Value.X, item.Value.Y + (supp_breadth / 2), baseAxisZ + 1.0f);
                VIZCore3D.NET.Data.Vertex3D measure_right = new VIZCore3D.NET.Data.Vertex3D(item.Value.X, item.Value.Y - (supp_breadth / 2), baseAxisZ + 1.0f);

                VIZCore3D.NET.Data.NearestObjectByAxisPoint collision
                = vizcore3d.GeometryUtility.GetNearestObject(VIZCore3D.NET.Data.AxisDirection.Z_PLUS, measure);

                if (collision.Index == -1) continue;

                vizcore3d.Review.Measure.AddCustomAxisDistance(VIZCore3D.NET.Data.Axis.Z, measure, collision.CollisionPoint);

                points.Add(measure);
                points.Add(collision.CollisionPoint);

                if (ckAnalysisSide.Checked == true)
                {
                    VIZCore3D.NET.Data.NearestObjectByAxisPoint collision_left = vizcore3d.GeometryUtility.GetNearestObject(VIZCore3D.NET.Data.AxisDirection.Z_PLUS, measure_left);
                    VIZCore3D.NET.Data.NearestObjectByAxisPoint collision_right = vizcore3d.GeometryUtility.GetNearestObject(VIZCore3D.NET.Data.AxisDirection.Z_PLUS, measure_right);

                    points.Add(collision_left.CollisionPoint);
                    points.Add(collision_right.CollisionPoint);

                    vizcore3d.Review.Measure.AddCustomAxisDistance(
                        VIZCore3D.NET.Data.Axis.Z
                        , new VIZCore3D.NET.Data.Vertex3D(collision.CollisionPoint.X, collision.CollisionPoint.Y + (supp_breadth / 2), collision.CollisionPoint.Z)
                        , collision_left.CollisionPoint
                        );

                    vizcore3d.Review.Measure.AddCustomAxisDistance(
                        VIZCore3D.NET.Data.Axis.Z
                        , new VIZCore3D.NET.Data.Vertex3D(collision.CollisionPoint.X, collision.CollisionPoint.Y - (supp_breadth / 2), collision.CollisionPoint.Z)
                        , collision_right.CollisionPoint
                        );
                }

                if (COLLISION_MAP.ContainsKey(item.Key) == false)
                {
                    COLLISION_MAP.Add(item.Key, points);
                }
            }

            vizcore3d.Object3D.Show(Data.Object3DKind.ALL, true);
            ShowDockSide();

            vizcore3d.EndUpdate();
        }

        private void ckAnalysisMeasureVisible_CheckedChanged(object sender, EventArgs e)
        {
            vizcore3d.Review.Measure.Show(ckAnalysisMeasureVisible.Checked);
        }

        private void btnGenerateSupporterShape_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "SUPPORTER_VARIABLE_ITEM" }, false, true, false, false, true, false);
            if (nodes.Count != 0) return;

            float xLength = Convert.ToSingle(txtSuppTopX.Text);
            float yLength = Convert.ToSingle(txtSuppTopY.Text);
            float offset = Convert.ToSingle(txtSuppHeight.Text);
            //float baseline = Convert.ToSingle(txtBaseline.Text);

            vizcore3d.BeginUpdate();

            VIZCore3D.NET.Data.Node vAssy = vizcore3d.Structure.CreateNode(0, VIZCore3D.NET.Data.NodeKind.ASSEMBLY, "SUPPORTER_VARIABLE_ITEM");

            foreach (KeyValuePair<string, List<VIZCore3D.NET.Data.Vertex3D>> item in COLLISION_MAP)
            {
                // SUPPORTER_NO_22_2 --> SUPPORTER_VARIABLE_NO_22_2
                VIZCore3D.NET.Data.Node vPart = vizcore3d.Structure.CreateNode(vAssy.Index, VIZCore3D.NET.Data.NodeKind.PART, string.Format("SUPPORTER_VARIABLE_NO_{0}", item.Key.Replace("SUPPORTER_NO_", "")));
                int bodyId = vizcore3d.Structure.CreateBody(vPart.Index, "BODY");
                int bodyIndex = vizcore3d.Structure.GetBodyIndex(bodyId);

                if (item.Value[2].Z > item.Value[1].Z && item.Value[3].Z > item.Value[1].Z)
                {
                    // Create Cube :: Top
                    {
                        List<float> length = new List<float>();
                        length.Add(xLength);
                        length.Add(yLength);
                        length.Add(item.Value[1].Z - item.Value[0].Z);

                        VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                        matrix.SetTranslate(item.Value[0].X, item.Value[0].Y, item.Value[0].Z + length[2] / 2);

                        vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, Color.Yellow, false);
                    }
                }
                else
                {
                    float fLength = Convert.ToSingle(txtSuppTopX.Text);
                    float fBreadth = Convert.ToSingle(txtSuppTopY.Text);

                    float fLengthHalf = fLength / 2;
                    float fBreadthHalf = fBreadth / 2;

                    List<VIZCore3D.NET.Data.Vertex3D> mesh = new List<VIZCore3D.NET.Data.Vertex3D>();

                    // Bottom
                    {
                        mesh.Add(new VIZCore3D.NET.Data.Vertex3D(item.Value[1].X - fLengthHalf, item.Value[1].Y - fBreadthHalf, item.Value[0].Z));
                        mesh.Add(new VIZCore3D.NET.Data.Vertex3D(item.Value[1].X - fLengthHalf, item.Value[1].Y + fBreadthHalf, item.Value[0].Z));
                        mesh.Add(new VIZCore3D.NET.Data.Vertex3D(item.Value[1].X + fLengthHalf, item.Value[1].Y + fBreadthHalf, item.Value[0].Z));
                        mesh.Add(new VIZCore3D.NET.Data.Vertex3D(item.Value[1].X + fLengthHalf, item.Value[1].Y - fBreadthHalf, item.Value[0].Z));
                    }

                    // Top
                    {
                        mesh.Add(new VIZCore3D.NET.Data.Vertex3D(item.Value[1].X - fLengthHalf, item.Value[1].Y - fBreadthHalf, item.Value[3].Z));
                        mesh.Add(new VIZCore3D.NET.Data.Vertex3D(item.Value[1].X - fLengthHalf, item.Value[1].Y + fBreadthHalf, item.Value[2].Z));
                        mesh.Add(new VIZCore3D.NET.Data.Vertex3D(item.Value[1].X + fLengthHalf, item.Value[1].Y + fBreadthHalf, item.Value[2].Z));
                        mesh.Add(new VIZCore3D.NET.Data.Vertex3D(item.Value[1].X + fLengthHalf, item.Value[1].Y - fBreadthHalf, item.Value[3].Z));
                    }

                    vizcore3d.MeshEdit.CreateBodyWithMesh(vPart.Index, "BODY", mesh, Color.Yellow);
                }

                // Create Cube :: Bottom
                {
                    List<float> length = new List<float>();
                    length.Add(xLength);
                    length.Add(yLength);
                    length.Add(item.Value[0].Z -
                        (SHIP_BOUNDBOX.MinZ
                        - Convert.ToSingle(txtDockBaseline.Text)
                        + Convert.ToSingle(txtSuppHeight.Text)));

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.SetTranslate(item.Value[0].X, item.Value[0].Y, item.Value[0].Z - (length[2] / 2));

                    vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, Color.Orange, false);
                }
            }

            vizcore3d.Structure.RebuildData();

            vizcore3d.EndUpdate();
        }


        // ================================================
        // Function - FLOODING
        // ================================================
        private void btnFloodingEnable_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> dock = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "DOCK_PART_BOTTOM" }, false, false, false, false, true, false);
            if (dock.Count == 0) return;

            SHIP_NODE = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "DDH" }, false, true, false, false, true, false);
            if (SHIP_NODE.Count == 0) return;

            DOCK_BOUNDBOX = vizcore3d.Object3D.GeometryProperty.FromNode(dock, false).GetBoundBox();
            WATER_BOUNDBOX = vizcore3d.Object3D.GeometryProperty.FromNode(dock, false).GetBoundBox();

            WATER_BOX_ID = vizcore3d.SelectionBox.Add(DOCK_BOUNDBOX, Color.FromArgb(10, Color.Blue), Color.Gray, "WATER");

            EnableWaterBoxScroll(true);

            vizcore3d.View.Message.TextSize = Data.FontSize.Size_26_Bold;
            vizcore3d.View.Message.Color = Color.Red;

            vizcore3d.View.RotateCamera(Data.ShipbuildingCameraDirection.STARBOARD);
        }

        private void btnFloodingDisable_Click(object sender, EventArgs e)
        {
            vizcore3d.View.Message.Hide(Data.MessageId.ID_01);
            vizcore3d.SelectionBox.Clear();
            WATER_BOX_ID = -1;

            EnableWaterBoxScroll(false);

            vizcore3d.Object3D.Transform.RestoreTransform(SHIP_NODE);
        }

        private void EnableWaterBoxScroll(bool enable)
        {
            tbWaterHeight.Scroll -= new System.EventHandler(this.tbWaterHeight_Scroll);
            tbWaterHeight.Enabled = enable;
            tbWaterHeight.Value = 0;
            tbWaterHeight.Scroll += new System.EventHandler(this.tbWaterHeight_Scroll);
        }

        private void tbWaterHeight_Scroll(object sender, EventArgs e)
        {
            if (WATER_BOX_ID == -1) return;

            float maxHeight = Convert.ToSingle(txtMaxHeight.Text);
            float floatingHeight = Convert.ToSingle(txtFloatingHeight.Text);
            float ratio = maxHeight / 100;

            float vals = tbWaterHeight.Value * ratio;
            WATER_BOUNDBOX.MaxZ = DOCK_BOUNDBOX.MaxZ + vals;

            vizcore3d.View.Message.Show(Data.MessageId.ID_01, string.Format("{0:#,0} mm.", vals), 10, 10);

            if (vals > floatingHeight)
            {
                vizcore3d.Object3D.Transform.Move(SHIP_NODE, new VIZCore3D.NET.Data.Vector3D(0, 0, vals - floatingHeight), true);

                LastWaterZHeight = vals - floatingHeight;
            }

            vizcore3d.SelectionBox.SetSize(WATER_BOX_ID, WATER_BOUNDBOX);
        }



        // ================================================
        // Function - OUTPATH
        // ================================================
        private void btnOutPathAuto_Click(object sender, EventArgs e)
        {
            lvPaths.BeginUpdate();
            lvPaths.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                ListViewItem lvi = new ListViewItem(new string[] { Convert.ToString(i + 1), "0", "1000", "0" });
                lvPaths.Items.Add(lvi);
            }

            for (int i = 0; i < 260; i++)
            {
                ListViewItem lvi = new ListViewItem(new string[] { Convert.ToString(i + 1), "-1000", "0", "0" });
                lvPaths.Items.Add(lvi);
            }

            lvPaths.EndUpdate();
        }
        private int DockOutAnimationIndex = 0;
        private VIZCore3D.NET.Data.Vertex3D SHIP_CENTER { get; set; }
        private void btnDockOutSimulation_Click(object sender, EventArgs e)
        {
            SHIP_CENTER = vizcore3d.Object3D.GeometryProperty.FromNode(SHIP_NODE).GetBoundBox().GetCenter();
            timerDockOutAnimation.Enabled = true;
        }

        private void timerDockOutAnimation_Tick(object sender, EventArgs e)
        {
            timerDockOutAnimation.Enabled = false;

            int count = lvPaths.Items.Count;
            if (DockOutAnimationIndex > count - 1)
            {
                DockOutAnimationIndex = 0;

                vizcore3d.Object3D.Transform.MoveTo(SHIP_NODE, SHIP_CENTER);

                return;
            }

            ListViewItem lvi = lvPaths.Items[DockOutAnimationIndex];

            float x = Convert.ToSingle(lvi.SubItems[1].Text);
            float y = Convert.ToSingle(lvi.SubItems[2].Text);
            float z = Convert.ToSingle(lvi.SubItems[3].Text);

            this.Invoke(new EventHandler(delegate
            {
                vizcore3d.Object3D.Transform.Move(SHIP_NODE, x, y, z, false);
            }));

            DockOutAnimationIndex++;

            timerDockOutAnimation.Enabled = true;
        }

        // ================================================
        // Function - CLASH
        // ================================================
        private void btnInspect_Click(object sender, EventArgs e)
        {
            if (SHIP_NODE.Count == 0) return;

            List<VIZCore3D.NET.Data.Node> CHILD = vizcore3d.Object3D.FromIndex(0).GetChildObject3d(VIZCore3D.NET.Data.Object3DChildOption.CHILD_ONLY);
            List<VIZCore3D.NET.Data.Node> ETC_NODE = new List<VIZCore3D.NET.Data.Node>();
            foreach (VIZCore3D.NET.Data.Node item in CHILD)
            {
                if (item.NodeName == "SHIP_MODEL") continue;
                ETC_NODE.Add(item);
            }
            if (ETC_NODE.Count == 0) return;

            CLASH_ITEM = new VIZCore3D.NET.Data.ClashTest();

            CLASH_ITEM.Name = "CLASH TEST #1";
            CLASH_ITEM.TestKind = VIZCore3D.NET.Data.ClashTest.ClashTestKind.GROUP_VS_MOVING_GROUP;


            CLASH_ITEM.UseClearanceValue = false;
            CLASH_ITEM.ClearanceValue = 3.0f;
            CLASH_ITEM.UseRangeValue = false;
            CLASH_ITEM.RangeValue = 2.0f;
            CLASH_ITEM.UsePenetrationTolerance = true;
            CLASH_ITEM.PenetrationTolerance = 1.0f;

            CLASH_ITEM.VisibleOnly = ckClashVisibleOnly.Checked;
            CLASH_ITEM.BottomLevel = 1;

            CLASH_ITEM.GroupA = ETC_NODE;
            CLASH_ITEM.GroupB = SHIP_NODE;

            SHIP_NODE = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "SHIP_MODEL" }, false, true, false, false, true, false);
            SHIP_CENTER = vizcore3d.Object3D.GeometryProperty.FromNode(SHIP_NODE).GetBoundBox().GetCenter();
            //VIZCore3D.NET.Data.Vertex3D CurrentCenter = new VIZCore3D.NET.Data.Vertex3D(SHIP_CENTER.X, SHIP_CENTER.Y, SHIP_CENTER.Z);
            VIZCore3D.NET.Data.Vertex3D CurrentCenter = new VIZCore3D.NET.Data.Vertex3D(0, 0, 0);

            for (int i = 0; i < lvPaths.Items.Count; i++)
            {
                ListViewItem lvi = lvPaths.Items[i];

                float x = Convert.ToSingle(lvi.SubItems[1].Text);
                float y = Convert.ToSingle(lvi.SubItems[2].Text);
                float z = Convert.ToSingle(lvi.SubItems[3].Text);

                CurrentCenter = new VIZCore3D.NET.Data.Vertex3D(CurrentCenter.X + x, CurrentCenter.Y + y, CurrentCenter.Z- z);

                CLASH_ITEM.Path.Add(new VIZCore3D.NET.Data.ClashTestPathItem(CurrentCenter.X, CurrentCenter.Y, CurrentCenter.Z));
            }

            int moving_point_group = 200;
            List<VIZCore3D.NET.Data.Vertex3D> MOVING_POINTS = CLASH_ITEM.GetTranslationVertex();
            vizcore3d.ShapeDrawing.DeleteGroup(moving_point_group);
            vizcore3d.ShapeDrawing.AddVertex(MOVING_POINTS, moving_point_group, Color.Black, 3, 3, true);

            vizcore3d.Clash.Add(CLASH_ITEM);

            int clashID = CLASH_ITEM.ID;

            vizcore3d.Clash.PerformInterferenceCheck(clashID);
        }

        private void Clash_OnClashTestFinishedEvent(object sender, Event.EventManager.ClashEventArgs e)
        {
            if (CLASH_ITEM == null) return;
            if (CLASH_ITEM.ID == -1) return;

            List<VIZCore3D.NET.Data.ClashTestResultItem> items = vizcore3d.Clash.GetResultAllSubItem(
            CLASH_ITEM
            , VIZCore3D.NET.Manager.ClashManager.ResultGroupingOptions.PART
            );

            this.Invoke(new EventHandler(delegate
            {
                AddClashResultItems(items);
            }));

            this.Invoke(new EventHandler(delegate
            {
                vizcore3d.Object3D.Transform.RestoreTransform(SHIP_NODE);
            }));
        }

        private void AddClashResultItems(List<VIZCore3D.NET.Data.ClashTestResultItem> items)
        {
            Dictionary<string, VIZCore3D.NET.Data.ClashTestResultItem> RESULT_ITEMS = new Dictionary<string, VIZCore3D.NET.Data.ClashTestResultItem>();

            foreach (VIZCore3D.NET.Data.ClashTestResultItem item in items)
            {
                if (RESULT_ITEMS.ContainsKey(item.NodeNameA) == false)
                    RESULT_ITEMS.Add(item.NodeNameA, item);
            }

            lvClash.BeginUpdate();
            lvClash.Items.Clear();
            foreach (KeyValuePair<string, VIZCore3D.NET.Data.ClashTestResultItem> item in RESULT_ITEMS)
            {
                ListViewItem lvi = new ListViewItem(new string[] { item.Key });
                lvi.Tag = item.Value;
                lvClash.Items.Add(lvi);
            }
            lvClash.EndUpdate();
        }

        private void btnClashResultShowAll_Click(object sender, EventArgs e)
        {
            ShowClashResultItems(true);
        }

        private void btnClashResultHideAll_Click(object sender, EventArgs e)
        {
            ShowClashResultItems(false);
        }

        private void ShowClashResultItems(bool visible)
        {
            List<string> items = new List<string>();

            for (int i = 0; i < lvClash.Items.Count; i++)
            {
                ListViewItem lvi = lvClash.Items[i];
                string name = lvi.SubItems[0].Text;

                items.Add(name);

                // SUPPORTER_NO_20_2
                // SUPPORTER_VARIABLE_NO_20_2

                string name_link = string.Format("SUPPORTER_NO_{0}", name.Replace("SUPPORTER_VARIABLE_NO_", ""));

                items.Add(name_link);
            }

            List<VIZCore3D.NET.Data.Node> node = vizcore3d.Object3D.Find.QuickSearch(items, false, false, false, false, true, false);
            if (node.Count == 0) return;

            vizcore3d.Object3D.Select(node, visible, true);
        }

        private void lvClash_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvClash.SelectedItems.Count == 0) return;

            List<string> items = new List<string>();

            ListViewItem lvi = lvClash.SelectedItems[0];
            string name = lvi.SubItems[0].Text;

            items.Add(name);

            // SUPPORTER_NO_20_2
            // SUPPORTER_VARIABLE_NO_20_2

            string name_link = string.Format("SUPPORTER_NO_{0}", name.Replace("SUPPORTER_VARIABLE_NO_", ""));

            items.Add(name_link);

            List<VIZCore3D.NET.Data.Node> node = vizcore3d.Object3D.Find.QuickSearch(items, false, false, false, false, true, false);
            if (node.Count == 0) return;

            vizcore3d.BeginUpdate();
            vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.Object3D.Select(node, true, true);
            vizcore3d.EndUpdate();
        }

        // ================================================
        // Function - RELOCATION
        // ================================================
        private void btnRelocationEnable_Click(object sender, EventArgs e)
        {
            vizcore3d.View.MouseBasedObjectMove.EnableMode(true, VIZCore3D.NET.Manager.MouseBasedObjectMoveManager.MovingOptions.MOVE);

            for (int i = 0; i < lvSupporter.Items.Count; i++)
            {
                List<string> items = new List<string>();

                ListViewItem lvi = lvSupporter.Items[i];
                string name = lvi.SubItems[0].Text;

                items.Add(name);

                // SUPPORTER_NO_20_2
                // SUPPORTER_VARIABLE_NO_20_2

                string name_link = string.Format("SUPPORTER_VARIABLE_NO_{0}", name.Replace("SUPPORTER_NO_", ""));

                items.Add(name_link);

                List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(items, false, false, false, false, true, false);

                if (nodes.Count == 0) continue;

                foreach (VIZCore3D.NET.Data.Node item in nodes)
                {
                    vizcore3d.View.MouseBasedObjectMove.Add(i, item.Index);
                }
            }
        }

        private void btnRelocationDisable_Click(object sender, EventArgs e)
        {
            vizcore3d.View.MouseBasedObjectMove.EnableMode(false, VIZCore3D.NET.Manager.MouseBasedObjectMoveManager.MovingOptions.MOVE);
        }



        // ================================================
        // Function - ANIMATION
        // ================================================
        /// <summary>
        /// 애니메이션 키 시간
        /// </summary>
        private float Time = 0.0f;

        /// <summary>
        /// 애니메이션 키 간격
        /// </summary>
        private float TimeInterval = 1.0f;

        private void btnAnimationGenerate_Click(object sender, EventArgs e)
        {
            Time = 0.0f;

            List<VIZCore3D.NET.Data.Node> nodes_HELICOPTER = vizcore3d.Object3D.Find.QuickSearch("UH_80_HELICOPTER_BLADE", true);

            List<VIZCore3D.NET.Data.Node> nodes_RADAR1 = vizcore3d.Object3D.Find.QuickSearch("RADAR #1", true);
            List<VIZCore3D.NET.Data.Node> nodes_RADAR2 = vizcore3d.Object3D.Find.QuickSearch("RADAR #2", true);
            List<VIZCore3D.NET.Data.Node> nodes_RADAR3 = vizcore3d.Object3D.Find.QuickSearch("RADAR #3", true);
            List<VIZCore3D.NET.Data.Node> nodes_RADAR4 = vizcore3d.Object3D.Find.QuickSearch("RADAR #4", true);

            if (nodes_HELICOPTER.Count == 0) return;

            vizcore3d.Animation.UseEffect = false;      /* 기본 효과 사용안함 설정 */

            vizcore3d.Animation.Clear();
            vizcore3d.Animation.Add("Animation");

            vizcore3d.BeginUpdate();

            for (int i = 0; i < 600; i++)
            {
                vizcore3d.Object3D.Transform.Rotate(nodes_HELICOPTER, 0, 0, 90, false, false);

                vizcore3d.Object3D.Transform.Rotate(nodes_RADAR1, 0, 0, 10, false, false);
                vizcore3d.Object3D.Transform.Rotate(nodes_RADAR2, 0, 0, 25, false, false);

                vizcore3d.Object3D.Transform.Rotate(nodes_RADAR3, 0, 0, 10, false, false);
                vizcore3d.Object3D.Transform.Rotate(nodes_RADAR4, 0, 0, 25, false, false);

                AddKey(true, false, TimeInterval * 0.1f);
            }

            vizcore3d.EndUpdate();

            MessageBox.Show("Animation Created.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 애니메이션 키 추가
        /// </summary>
        public void AddKey(bool modelKey, bool cameraKey, float internval)
        {
            Time += internval;

            if (cameraKey)
                vizcore3d.Animation.AddKey(Time, VIZCore3D.NET.Manager.AnimationManager.AnimationKeyType.CAMERA);

            if (modelKey)
                vizcore3d.Animation.AddKey(Time, VIZCore3D.NET.Manager.AnimationManager.AnimationKeyType.MODEL);
        }

        private void btnAnimationPlay_Click(object sender, EventArgs e)
        {
            AnimationScrew(true);

            vizcore3d.Animation.PlayingTime = Time;

            vizcore3d.View.RealtimeShadow = true;
            vizcore3d.View.EnvironmentLight = true;
            vizcore3d.View.AntiAliasing = true;

            if (vizcore3d.View.Projection == Data.Projections.Orthographic)
                vizcore3d.View.Projection = VIZCore3D.NET.Data.Projections.Perspective;  /* 원근 뷰 설정 */

            vizcore3d.Animation.Play(false, 0);
        }

        private void btnAnimationPause_Click(object sender, EventArgs e)
        {
            vizcore3d.Animation.Pause();

            AnimationScrew(false);
        }

        private List<VIZCore3D.NET.Data.Node> NODES_SCREW1 { get; set; }
        private List<VIZCore3D.NET.Data.Node> NODES_SCREW2 { get; set; }
        private float Screw_Rotate_Angle = 0;
        private void btnAnimationScrewStart_Click(object sender, EventArgs e)
        {
            AnimationScrew(true);
        }

        private void AnimationScrew(bool enable)
        {
            if (enable == true)
            {
                NODES_SCREW1 = vizcore3d.Object3D.Find.QuickSearch("SHIP_PROPELLERS #1", true);
                NODES_SCREW2 = vizcore3d.Object3D.Find.QuickSearch("SHIP_PROPELLERS #2", true);

                timerScrew.Enabled = true;
            }
            else
            {
                timerScrew.Enabled = false;
            }
        }

        private void btnAnimationScrewStop_Click(object sender, EventArgs e)
        {
            AnimationScrew(false);
        }

        private void timerScrew_Tick(object sender, EventArgs e)
        {
            timerScrew.Enabled = false;

            this.Invoke(new EventHandler(delegate
            {
                RotateScrew();
            }));

            timerScrew.Enabled = true;
        }

        private void RotateScrew()
        {
            vizcore3d.BeginUpdate();

            vizcore3d.Object3D.Transform.Rotate(NODES_SCREW1, new VIZCore3D.NET.Data.Vertex3D(-40144.21, 2159.66, -15277.70), new VIZCore3D.NET.Data.Vertex3D(-38685.59, 2170.91, -15204.43), Screw_Rotate_Angle % 360, VIZCore3D.NET.Data.AngleFormat.DEGREE);
            vizcore3d.Object3D.Transform.Rotate(NODES_SCREW2, new VIZCore3D.NET.Data.Vertex3D(-40110.58, -2575.70, -15209.66), new VIZCore3D.NET.Data.Vertex3D(-38651.92, -2564.30, -15135.98), Screw_Rotate_Angle % 360, VIZCore3D.NET.Data.AngleFormat.DEGREE);

            Screw_Rotate_Angle += 30;

            vizcore3d.EndUpdate();
        }

        
    }
}
