using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.DockBuild
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
        /// VIZCore3D.NET
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d_preview;

        /// <summary>
        /// SHIP 3D Model BoundBox
        /// </summary>
        public VIZCore3D.NET.Data.BoundBox3D SHIP_BOUNDBOX { get; set; }
        /// <summary>
        /// Grid Cross Point
        /// </summary>
        public Dictionary<Point, VIZCore3D.NET.Data.Vertex3D> GRID_CROSS_MAP { get; set; }

        /// <summary>
        /// Measure Point
        /// </summary>
        public Dictionary<Point, VIZCore3D.NET.Data.Vertex3D> SPACE_MEASURE_MAP { get; set; }

        /// <summary>
        /// Section
        /// </summary>
        public VIZCore3D.NET.Data.Section SectionView { get; set; }

        /// <summary>
        /// Collision Map
        /// </summary>
        public Dictionary<Point, List<VIZCore3D.NET.Data.Vertex3D>>  COLLISION_MAP { get; set; }

        private const int GRID_ITEM_GROUP_ID = 0;
        private const int GRID_CROSS_POINT_GROUP_ID = 1;
        private int SPACE_SELECTION_BOX_ID { get; set; }
        private const int SPACE_MEASURE_GROUP_ID = 2;
        private const int COLLISION_LINE_GROUP_ID = 3;
        private const int COLLISION_POINT_GROUP_ID = 3;


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
            splitContainer2.Panel1.Controls.Add(vizcore3d);

            // Event
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;


            vizcore3d_preview = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d_preview.Dock = DockStyle.Fill;
            gbPreviewSupporter.Controls.Add(vizcore3d_preview);
            vizcore3d_preview.OnInitializedVIZCore3D += VIZCore3DPreview_OnInitializedVIZCore3D;


            // Value
            SPACE_SELECTION_BOX_ID = -1;
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

        private void VIZCore3DPreview_OnInitializedVIZCore3D(object sender, EventArgs e)
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
                licenseResult = vizcore3d_preview.License.LicenseServer(
                    licenseInfo.ContainsKey("LICENSE_IP") == true ? licenseInfo["LICENSE_IP"] : String.Empty
                    , licenseInfo.ContainsKey("LICENSE_PORT") == true ? Convert.ToInt32(licenseInfo["LICENSE_PORT"]) : 8901
                    );
            }
            // 라이선스 파일
            else if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.FILE)
            {
                licenseResult = vizcore3d_preview.License.LicenseFile(
                    licenseInfo.ContainsKey("LICENSE_FILE") == true ? licenseInfo["LICENSE_FILE"] : String.Empty
                    );
            }

            // 인증 결과
            if (licenseResult != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            {
                MessageBox.Show(string.Format("LICENSE CODE : {0}", licenseResult.ToString()), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            vizcore3d_preview.Statusbar.Visible = false;
            vizcore3d_preview.View.MarineAxis.Visible = false;
            #endregion
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
            vizcore3d.Model.OnModelOpenedEvent += Model_OnModelOpenedEvent;
            vizcore3d.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;
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
        // Event
        // ================================================
        private void Model_OnModelOpenedEvent(object sender, EventArgs e)
        {
        }

        private void Object3D_OnObject3DSelected(object sender, Event.EventManager.Object3DSelectedEventArgs e)
        {
            if (e.Node.Count == 0) return;
            if (ckAnalysisItem.Checked == false) return;

            string nodeName = e.Node[0].NodeName;
            if (nodeName.Contains("SUPPORTER_PART") == false) return;

            float baseline = Convert.ToSingle(txtBaseline.Text);

            VIZCore3D.NET.Data.Node node = e.Node[0].GetParent().GetParent();
            string name = node.NodeName;
            string name_no = name.Replace("SUPPORTER_NO_", "");

            string[] no = name_no.Split(new char[] { '_' });
            if (no == null || no.Length != 2) return;

            int x = Convert.ToInt32(no[0]);
            int y = Convert.ToInt32(no[1]);

            VIZCore3D.NET.Data.Vertex3D bottom = null;
            foreach (KeyValuePair<Point, VIZCore3D.NET.Data.Vertex3D> item in SPACE_MEASURE_MAP)
            {
                if (item.Key.X != x) continue;
                if (item.Key.Y != y) continue;

                bottom = item.Value;
                break;
            }

            if (bottom == null) return;

            VIZCore3D.NET.Data.Vertex3D v = new VIZCore3D.NET.Data.Vertex3D(bottom.X, bottom.Y, baseline);

            if (COLLISION_MAP == null)
                COLLISION_MAP = new Dictionary<Point, List<VIZCore3D.NET.Data.Vertex3D>>();

            bool exist = false;
            foreach (KeyValuePair<Point, List<VIZCore3D.NET.Data.Vertex3D>> item in COLLISION_MAP)
            {
                if (item.Key.X != x) continue;
                if (item.Key.Y != y) continue;

                exist = true;
                break;
            }

            if (exist == true) return;

            float supp_breadth = Convert.ToSingle(txtSuppTopY.Text);

            VIZCore3D.NET.Data.Vertex3D measure = new VIZCore3D.NET.Data.Vertex3D(v.X, v.Y, v.Z + 1.0f);
            VIZCore3D.NET.Data.Vertex3D measure_left = new VIZCore3D.NET.Data.Vertex3D(v.X, v.Y + (supp_breadth / 2), v.Z + 1.0f);
            VIZCore3D.NET.Data.Vertex3D measure_right = new VIZCore3D.NET.Data.Vertex3D(v.X, v.Y - (supp_breadth / 2), v.Z + 1.0f);

            vizcore3d.BeginUpdate();
            vizcore3d.Object3D.Show(new List<VIZCore3D.NET.Data.Node>() { node }, false);
            VIZCore3D.NET.Data.NearestObjectByAxisPoint collision 
                = vizcore3d.GeometryUtility.GetNearestObject(VIZCore3D.NET.Data.AxisDirection.Z_PLUS, measure);
            vizcore3d.Object3D.Show(new List<VIZCore3D.NET.Data.Node>() { node }, true);

            if (collision.Index == -1)
            {
                vizcore3d.EndUpdate();
                return;
            }

            VIZCore3D.NET.Data.NearestObjectByAxisPoint collision_left
                = vizcore3d.GeometryUtility.GetNearestObject(VIZCore3D.NET.Data.AxisDirection.Z_PLUS, measure_left);
            VIZCore3D.NET.Data.NearestObjectByAxisPoint collision_right
                = vizcore3d.GeometryUtility.GetNearestObject(VIZCore3D.NET.Data.AxisDirection.Z_PLUS, measure_right);

            List<VIZCore3D.NET.Data.Vertex3DItemCollection> lines = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();
            VIZCore3D.NET.Data.Vertex3DItemCollection line = new VIZCore3D.NET.Data.Vertex3DItemCollection();
            line.Add(v);
            line.Add(collision.CollisionPoint);
            lines.Add(line);

            COLLISION_MAP.Add(new Point(x, y), new List<VIZCore3D.NET.Data.Vertex3D>() { v, collision.CollisionPoint, collision_left.CollisionPoint, collision_right.CollisionPoint });

            List<int> lineIds = vizcore3d.ShapeDrawing.AddDashLine(lines, COLLISION_LINE_GROUP_ID, Color.Blue, 2, true, 100.0f);

            if (ckAnalysisMeasure.Checked == true)
            {
                vizcore3d.Review.Measure.AddCustomAxisDistance(VIZCore3D.NET.Data.Axis.Z, v, collision.CollisionPoint);

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

            vizcore3d.EndUpdate();
        }


        // ================================================
        // Function - MODEL
        // ================================================
        private void btnOpenModel_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\Models\\VIZCore3D.NET.DockBuild\\SHIP.viz", vizcore3d.GetEntryAssemblyPath());

            if(System.IO.File.Exists(path) == true)
            {                
                vizcore3d.Model.Open(path);
            }
            else
            {
                vizcore3d.Model.OpenFileDialog();
            }

            SHIP_BOUNDBOX = vizcore3d.Model.BoundBox;

            GRID_CROSS_MAP = new Dictionary<Point, Data.Vertex3D>();
            SPACE_MEASURE_MAP = new Dictionary<Point, Data.Vertex3D>();
            COLLISION_MAP = new Dictionary<Point, List<Data.Vertex3D>>();
            SectionView = null;
        }


        // ================================================
        // Function - DOCK
        // ================================================
        private void btnDockGenerate_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();

            // Remove Dock Model
            ExistDockModel(true);

            string strDockLength = txtDockLength.Text; // m
            string strDockBreadth = txtDockBreadth.Text; // m
            string strDockDepth = txtDockDepth.Text; // m
            string strDockOffset = txtDockOffset.Text; // mm
            float thickness = 300.0f;

            float fDockLength = Convert.ToSingle(strDockLength) * 1000.0f;
            float fDockBreadth = Convert.ToSingle(strDockBreadth) * 1000.0f;
            float fDockDepth = Convert.ToSingle(strDockDepth) * 1000.0f;

            float fOffset = Convert.ToSingle(strDockOffset);

            bool dockSingleModel = ckDockSingle.Checked;
            bool dockSideAll = ckDockSideAll.Checked;

            VIZCore3D.NET.Data.Node dockAssy = vizcore3d.Structure.CreateNode(
                0
                , VIZCore3D.NET.Data.NodeKind.ASSEMBLY
                , "DOCK_ASSY"
                );

            if(dockSingleModel == true)
            {
                VIZCore3D.NET.Data.Node dockPart = vizcore3d.Structure.CreateNode(
                dockAssy.Index
                , VIZCore3D.NET.Data.NodeKind.PART
                , "DOCK_PART"
                );

                int bodyId = vizcore3d.Structure.CreateBody(dockPart.Index, "BODY");
                int bodyIndex = vizcore3d.Structure.GetBodyIndex(bodyId);

                // 바닥면
                {
                    List<float> length = new List<float>();
                    length.Add(fDockLength);
                    length.Add(fDockBreadth);
                    length.Add(thickness);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        SHIP_BOUNDBOX.CenterX
                        , SHIP_BOUNDBOX.CenterY
                        , SHIP_BOUNDBOX.MinZ - fOffset - (thickness / 2.0f)
                        );

                    Color dockColor = Color.FromArgb(50, 128, 128, 128);

                    vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
                }

                // 뒷면
                if(dockSideAll == true)
                {
                    List<float> length = new List<float>();
                    length.Add(fDockLength);
                    length.Add(thickness);
                    length.Add(fDockDepth);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        SHIP_BOUNDBOX.CenterX
                        , SHIP_BOUNDBOX.CenterY + (fDockBreadth / 2)
                        , SHIP_BOUNDBOX.MinZ + (fDockDepth / 2) - fOffset
                        );

                    Color dockColor = Color.FromArgb(50, 128, 128, 128);

                    vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
                }

                // 앞면
                if (dockSideAll == true)
                {
                    List<float> length = new List<float>();
                    length.Add(fDockLength);
                    length.Add(thickness);
                    length.Add(fDockDepth);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        SHIP_BOUNDBOX.CenterX
                        , SHIP_BOUNDBOX.CenterY - (fDockBreadth / 2)
                        , SHIP_BOUNDBOX.MinZ + (fDockDepth / 2) - fOffset
                        );

                    Color dockColor = Color.FromArgb(50, 128, 128, 128);

                    vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
                }

                // 왼쪽면
                if (dockSideAll == true)
                {
                    List<float> length = new List<float>();
                    length.Add(thickness);
                    length.Add(fDockBreadth);
                    length.Add(fDockDepth);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        SHIP_BOUNDBOX.CenterX - (fDockLength / 2)
                        , SHIP_BOUNDBOX.CenterY
                        , SHIP_BOUNDBOX.MinZ + (fDockDepth / 2) - fOffset
                        );

                    Color dockColor = Color.FromArgb(50, 128, 128, 128);

                    vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
                }

                // 오른쪽면
                if (dockSideAll == true)
                {
                    List<float> length = new List<float>();
                    length.Add(thickness);
                    length.Add(fDockBreadth);
                    length.Add(fDockDepth);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        SHIP_BOUNDBOX.CenterX + (fDockLength / 2)
                        , SHIP_BOUNDBOX.CenterY
                        , SHIP_BOUNDBOX.MinZ + (fDockDepth / 2) - fOffset
                        );

                    Color dockColor = Color.FromArgb(50, 128, 128, 128);

                    vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
                }
            }
            else
            {
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
                    length.Add(fDockLength);
                    length.Add(fDockBreadth);
                    length.Add(thickness);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        SHIP_BOUNDBOX.CenterX
                        , SHIP_BOUNDBOX.CenterY
                        , SHIP_BOUNDBOX.MinZ - fOffset - (thickness / 2.0f)
                        );

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
                    length.Add(fDockLength);
                    length.Add(thickness);
                    length.Add(fDockDepth);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        SHIP_BOUNDBOX.CenterX
                        , SHIP_BOUNDBOX.CenterY + (fDockBreadth / 2)
                        , SHIP_BOUNDBOX.MinZ + (fDockDepth / 2) - fOffset
                        );

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
                    length.Add(fDockLength);
                    length.Add(thickness);
                    length.Add(fDockDepth);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        SHIP_BOUNDBOX.CenterX
                        , SHIP_BOUNDBOX.CenterY - (fDockBreadth / 2)
                        , SHIP_BOUNDBOX.MinZ + (fDockDepth / 2) - fOffset
                        );

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
                    length.Add(thickness);
                    length.Add(fDockBreadth);
                    length.Add(fDockDepth);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        SHIP_BOUNDBOX.CenterX - (fDockLength / 2)
                        , SHIP_BOUNDBOX.CenterY
                        , SHIP_BOUNDBOX.MinZ + (fDockDepth / 2) - fOffset
                        );

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
                    length.Add(thickness);
                    length.Add(fDockBreadth);
                    length.Add(fDockDepth);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        SHIP_BOUNDBOX.CenterX + (fDockLength / 2)
                        , SHIP_BOUNDBOX.CenterY
                        , SHIP_BOUNDBOX.MinZ + (fDockDepth / 2) - fOffset
                        );

                    Color dockColor = Color.FromArgb(50, 128, 128, 128);

                    vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
                }
            }

            // 데이터 재구성
            vizcore3d.Structure.RebuildData();

            vizcore3d.EndUpdate();
        }

        private bool ExistDockModel(bool remove)
        {
            List<VIZCore3D.NET.Data.Node> dock =
                vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "DOCK_ASSY" }, false, true, false, false, true, false);

            if (dock.Count == 0) return false;

            if(remove == true)
            {
                vizcore3d.Object3D.Delete(dock);
            }

            return true;
        }

        private void btnDockDelete_Click(object sender, EventArgs e)
        {
            ExistDockModel(true);
        }


        // ================================================
        // Function - GRID
        // ================================================
        private void btnGridDraw_Click(object sender, EventArgs e)
        {
            vizcore3d.ShapeDrawing.DepthTest = true;

            vizcore3d.BeginUpdate();

            string strDockLength = txtDockLength.Text; // m
            string strDockBreadth = txtDockBreadth.Text; // m
            string strDockDepth = txtDockDepth.Text; // m
            string strDockOffset = txtDockOffset.Text; // mm

            float fDockLength = Convert.ToSingle(strDockLength) * 1000.0f;
            float fDockBreadth = Convert.ToSingle(strDockBreadth) * 1000.0f;
            float fDockDepth = Convert.ToSingle(strDockDepth) * 1000.0f;

            float fOffset = Convert.ToSingle(strDockOffset);

            float startX = SHIP_BOUNDBOX.CenterX - (fDockLength / 2);
            float startY = SHIP_BOUNDBOX.CenterY + (fDockBreadth / 2);
            float depth = SHIP_BOUNDBOX.MinZ - fOffset;

            float intervalX = Convert.ToSingle(txtGridIntervalX.Text); // mm
            float intervalY = Convert.ToSingle(txtGridIntervalY.Text); // mm

            float fTimesX = fDockLength / intervalX;
            float fTimesY = fDockBreadth / intervalY;

            int nTimesX = Convert.ToInt32(fTimesX);
            int nTimesY = Convert.ToInt32(fTimesY);

            List<VIZCore3D.NET.Data.Vertex3DItemCollection> gridLines = new List<Data.Vertex3DItemCollection>();

            for (int i = 1; i < nTimesX; i++)
            {
                VIZCore3D.NET.Data.Vertex3DItemCollection coll = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                coll.Add(new VIZCore3D.NET.Data.Vertex3D(startX + (i * intervalX), startY, depth));
                coll.Add(new VIZCore3D.NET.Data.Vertex3D(startX + (i * intervalX), startY - fDockBreadth, depth));
                gridLines.Add(coll);
            }

            for (int i = 1; i < nTimesY; i++)
            {
                VIZCore3D.NET.Data.Vertex3DItemCollection coll = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                coll.Add(new VIZCore3D.NET.Data.Vertex3D(startX, startY - (i * intervalY), depth));
                coll.Add(new VIZCore3D.NET.Data.Vertex3D(startX + fDockLength, startY - (i * intervalY), depth));
                gridLines.Add(coll);
            }

            // Cross Point
            GRID_CROSS_MAP = new Dictionary<Point, VIZCore3D.NET.Data.Vertex3D>();
            List<VIZCore3D.NET.Data.Vertex3D> crossPoints = new List<Data.Vertex3D>();
            for (int i = 1; i < nTimesX; i++)
            {
                for (int j = 1; j < nTimesY; j++)
                {
                    VIZCore3D.NET.Data.Vertex3D crossPoint = new VIZCore3D.NET.Data.Vertex3D(
                        startX + (i * intervalX)
                        , startY - (j * intervalY)
                        , depth
                        );

                    crossPoints.Add(crossPoint);
                    GRID_CROSS_MAP.Add(new Point(i, j), crossPoint);
                }
            }

            vizcore3d.ShapeDrawing.AddLine(gridLines, GRID_ITEM_GROUP_ID, Color.DarkGray, 0.5f, true);

            if(ckGridHighlightCrossPoint.Checked == true)
                vizcore3d.ShapeDrawing.AddVertex(crossPoints, GRID_CROSS_POINT_GROUP_ID, Color.Yellow, 1, 2, true);

            vizcore3d.EndUpdate();
        }

        private void btnGridClear_Click(object sender, EventArgs e)
        {
            vizcore3d.ShapeDrawing.DeleteGroup(GRID_ITEM_GROUP_ID);
        }

        private void btnGridClearCross_Click(object sender, EventArgs e)
        {
            vizcore3d.ShapeDrawing.DeleteGroup(GRID_CROSS_POINT_GROUP_ID);
        }

        
        // ================================================
        // Function - SPACE
        // ================================================
        private void btnSpaceCheck_Click(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.Vertex3D min = new VIZCore3D.NET.Data.Vertex3D(
                SHIP_BOUNDBOX.MinX
                , SHIP_BOUNDBOX.MinY
                , SHIP_BOUNDBOX.MinZ - Convert.ToSingle(txtDockOffset.Text) - 100.0f
                );
            VIZCore3D.NET.Data.Vertex3D max = new VIZCore3D.NET.Data.Vertex3D(
                SHIP_BOUNDBOX.MaxX
                , SHIP_BOUNDBOX.MaxY
                , min.Z + Convert.ToSingle(txtSpaceOffset.Text)
                );

            VIZCore3D.NET.Data.BoundBox3D space = new VIZCore3D.NET.Data.BoundBox3D(
                min
                , max
                );

            Color face = Color.FromArgb(10, Color.Red);
            if (SPACE_SELECTION_BOX_ID != -1)
            {
                vizcore3d.SelectionBox.Delete(new List<int>() { SPACE_SELECTION_BOX_ID });
                SPACE_SELECTION_BOX_ID = -1;
            }

            if(ckSpaceBox.Checked == true)
                SPACE_SELECTION_BOX_ID = vizcore3d.SelectionBox.Add(space, face, Color.Black, "SPACE");


            SPACE_MEASURE_MAP = new Dictionary<Point, VIZCore3D.NET.Data.Vertex3D>();
            List<VIZCore3D.NET.Data.Vertex3D> measurePoint = new List<VIZCore3D.NET.Data.Vertex3D>();  
            foreach (KeyValuePair<Point, VIZCore3D.NET.Data.Vertex3D> item in GRID_CROSS_MAP)
            {
                if (space.Contains(item.Value) == false) continue;
                SPACE_MEASURE_MAP.Add(item.Key, item.Value);
                measurePoint.Add(item.Value);
            }

            if(measurePoint.Count != 0 && ckSpacePoint.Checked == true)
            {
                vizcore3d.ShapeDrawing.AddVertex(measurePoint, SPACE_MEASURE_GROUP_ID, Color.Blue, 2, 2, true);
            }
        }

        private void btnSpaceClear_Click(object sender, EventArgs e)
        {
            if (SPACE_SELECTION_BOX_ID == -1) return;
            vizcore3d.SelectionBox.Delete(new List<int>() { SPACE_SELECTION_BOX_ID });
            SPACE_SELECTION_BOX_ID = -1;
        }

        private void btnSpaceClearPoint_Click(object sender, EventArgs e)
        {
            vizcore3d.ShapeDrawing.DeleteGroup(SPACE_MEASURE_GROUP_ID);
        }


        // ================================================
        // Function - SUPPORTER
        // ================================================
        private void btnSuppPreview_Click(object sender, EventArgs e)
        {
            int index = vizcore3d_preview.Model.NewEmptyModel("SUPPORTER");

            VIZCore3D.NET.Data.Node supporterAssy = vizcore3d_preview.Structure.CreateNode(
                index
                , VIZCore3D.NET.Data.NodeKind.ASSEMBLY
                , "SUPPORTER_ASSY"
                );

            VIZCore3D.NET.Data.Node supporterPart = vizcore3d_preview.Structure.CreateNode(
                supporterAssy.Index
                , VIZCore3D.NET.Data.NodeKind.PART
                , "SUPPORTER_PART"
                );

            int bodyId = vizcore3d_preview.Structure.CreateBody(supporterPart.Index, "BODY");
            int bodyIndex = vizcore3d_preview.Structure.GetBodyIndex(bodyId);

            VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
            matrix.SetTranslate(
                0
                , 0
                , SHIP_BOUNDBOX.MinZ 
                    - Convert.ToSingle(txtDockOffset.Text) 
                    + (Convert.ToSingle(txtSuppHeight.Text) / 2)
                );

            vizcore3d_preview.MeshEdit.AddPrimitivePyramid(
                bodyIndex
                , new SizeF(Convert.ToSingle(txtSuppBottomX.Text), Convert.ToSingle(txtSuppBottomY.Text))
                , new SizeF(Convert.ToSingle(txtSuppTopX.Text), Convert.ToSingle(txtSuppTopY.Text))
                , new SizeF(Convert.ToSingle(txtSuppOffsetX.Text), Convert.ToSingle(txtSuppOffsetY.Text))
                , Convert.ToSingle(txtSuppHeight.Text)
                , matrix
                , Color.LightBlue
                , false
                );

            vizcore3d_preview.Structure.RebuildData();

            string path = string.Format("{0}\\{1}", Application.StartupPath, "SUPPORTER.viz");
            if (System.IO.File.Exists(path) == true)
                System.IO.File.Delete(path);

            vizcore3d_preview.Model.SaveAsVIZ(path);
        }

        private void btnSuppAdd_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\{1}", Application.StartupPath, "SUPPORTER.viz");
            if (System.IO.File.Exists(path) == false) return;

            byte[] buffer = System.IO.File.ReadAllBytes(path);
            List<VIZCore3D.NET.Data.StreamData> stream = new List<VIZCore3D.NET.Data.StreamData>();

            foreach (KeyValuePair<Point, VIZCore3D.NET.Data.Vertex3D> item in SPACE_MEASURE_MAP)
            {
                byte[] model = new byte[buffer.Length];
                buffer.CopyTo(model, 0);

                VIZCore3D.NET.Data.StreamData supporterModel = new VIZCore3D.NET.Data.StreamData(model, string.Format("SUPPORTER_NO_{0}_{1}", item.Key.X, item.Key.Y));
                stream.Add(supporterModel);
            }

            if (stream.Count == 0) return;
            vizcore3d.Model.AddStream(stream);

            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "SUPPORTER_NO_" }, false, true, false, false, false, false);
            if (nodes.Count == 0) return;

            Dictionary<string, VIZCore3D.NET.Data.Vertex3D> suppMap = new Dictionary<string, VIZCore3D.NET.Data.Vertex3D>();
            foreach (KeyValuePair<Point, VIZCore3D.NET.Data.Vertex3D> item in SPACE_MEASURE_MAP)
            {
                string name = string.Format("{0}_{1}", item.Key.X, item.Key.Y);
                if(suppMap.ContainsKey(name) == false)
                    suppMap.Add(name, item.Value);
            }

            vizcore3d.BeginUpdate();
            foreach (VIZCore3D.NET.Data.Node item in nodes)
            {
                string name = item.NodeName;
                string name_id = name.Replace("SUPPORTER_NO_", "");

                if (suppMap.ContainsKey(name_id) == false) continue;

                VIZCore3D.NET.Data.Vertex3D v = suppMap[name_id];

                item.Move(v.X, v.Y, 0);
            }
            vizcore3d.EndUpdate();
        }


        // ================================================
        // Function - SECTION
        // ================================================
        private void btnSectionAdd_Click(object sender, EventArgs e)
        {
            SectionView = vizcore3d.Section.AddBox(false);

            Dictionary<int, VIZCore3D.NET.Data.Vertex3D> lines = new Dictionary<int, VIZCore3D.NET.Data.Vertex3D>();

            foreach (KeyValuePair<Point, VIZCore3D.NET.Data.Vertex3D> item in SPACE_MEASURE_MAP)
            {
                if (lines.ContainsKey(item.Key.X) == false)
                    lines.Add(item.Key.X, item.Value);
            }

            List<int> lineNo = lines.Keys.ToList();

            tbSection.Maximum = lineNo.Count;
            tbSection.Minimum = 0;
            tbSection.Enabled = true;

            tbSection.ValueChanged -= TbSection_ValueChanged;
            tbSection.Value = lineNo.Count / 2;
            tbSection.ValueChanged += TbSection_ValueChanged;

            MoveSectionBox(lineNo.Count / 2);
        }

        private void MoveSectionBox(int index)
        {
            Dictionary<int, VIZCore3D.NET.Data.Vertex3D> lines = new Dictionary<int, VIZCore3D.NET.Data.Vertex3D>();

            foreach (KeyValuePair<Point, VIZCore3D.NET.Data.Vertex3D> item in SPACE_MEASURE_MAP)
            {
                if (lines.ContainsKey(item.Key.X) == false)
                    lines.Add(item.Key.X, item.Value);
            }

            List<int> lineNo = lines.Keys.ToList();

            if (lineNo.Count <= index) return;
            int xNo = lineNo[index];

            if (lines.ContainsKey(xNo) == false) return;
            VIZCore3D.NET.Data.Vertex3D v = lines[xNo];

            VIZCore3D.NET.Data.Vertex3D min = new VIZCore3D.NET.Data.Vertex3D(
                v.X - (Convert.ToSingle(txtGridIntervalX.Text) / 2.0f)
                , SHIP_BOUNDBOX.CenterY + (Convert.ToSingle(txtDockBreadth.Text) * 1000.0f / 2.0f)
                , SHIP_BOUNDBOX.MinZ - Convert.ToSingle(txtDockOffset.Text) - 300.0f
                );
            VIZCore3D.NET.Data.Vertex3D max = new VIZCore3D.NET.Data.Vertex3D(
                v.X + (Convert.ToSingle(txtGridIntervalX.Text) / 2.0f)
                , SHIP_BOUNDBOX.CenterY - (Convert.ToSingle(txtDockBreadth.Text) * 1000.0f / 2.0f)
                , SHIP_BOUNDBOX.MaxZ
                );

            VIZCore3D.NET.Data.Section section = vizcore3d.Section.SelectedItem;
            if (section == null) return;

            vizcore3d.BeginUpdate();
            vizcore3d.Section.SetBoxSize(section.ID, min, max);

            vizcore3d.ShapeDrawing.DeleteGroup(COLLISION_LINE_GROUP_ID);
            vizcore3d.Review.Measure.Clear();

            foreach (KeyValuePair<Point, List<VIZCore3D.NET.Data.Vertex3D>> item in COLLISION_MAP)
            {
                if (xNo != item.Key.X) continue;

                List<VIZCore3D.NET.Data.Vertex3DItemCollection> collisionLines = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();
                VIZCore3D.NET.Data.Vertex3DItemCollection collisionLine = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                collisionLine.Add(item.Value[0]);
                collisionLine.Add(item.Value[1]);
                collisionLines.Add(collisionLine);

                List<int> lineIds = vizcore3d.ShapeDrawing.AddDashLine(collisionLines, COLLISION_LINE_GROUP_ID, Color.Blue, 2, true, 100.0f);
                int measureId = vizcore3d.Review.Measure.AddCustomAxisDistance(VIZCore3D.NET.Data.Axis.Z, item.Value[0], item.Value[1]);
            }

            vizcore3d.EndUpdate();
        }

        private void TbSection_ValueChanged(object sender, EventArgs e)
        {
            MoveSectionBox(tbSection.Value);
        }

        private void ckSectionPlane_CheckedChanged(object sender, EventArgs e)
        {
            vizcore3d.Section.ShowSectionPlane = ckSectionPlane.Checked;
        }

        private void ckSectionLine_CheckedChanged(object sender, EventArgs e)
        {
            vizcore3d.Section.SectionLineColor = Color.Black;
            vizcore3d.Section.ShowSectionLineColor = true;
            vizcore3d.Section.ShowSectionLine = ckSectionPlane.Checked;
        }

        private void btnSectionClear_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();
            vizcore3d.Section.Clear();

            vizcore3d.ShapeDrawing.DeleteGroup(COLLISION_LINE_GROUP_ID);
            vizcore3d.Review.Measure.Clear();

            foreach (KeyValuePair<Point, List<VIZCore3D.NET.Data.Vertex3D>> item in COLLISION_MAP)
            {
                List<VIZCore3D.NET.Data.Vertex3DItemCollection> collisionLines = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();
                VIZCore3D.NET.Data.Vertex3DItemCollection collisionLine = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                collisionLine.Add(item.Value[0]);
                collisionLine.Add(item.Value[1]);
                collisionLines.Add(collisionLine);

                List<int> lineIds = vizcore3d.ShapeDrawing.AddDashLine(collisionLines, COLLISION_LINE_GROUP_ID, Color.Blue, 2, true, 100.0f);
                int measureId = vizcore3d.Review.Measure.AddCustomAxisDistance(VIZCore3D.NET.Data.Axis.Z, item.Value[0], item.Value[1]);
            }

            vizcore3d.EndUpdate();

            tbSection.ValueChanged -= TbSection_ValueChanged;
            tbSection.Value = 0;
            tbSection.Enabled = false;
            tbSection.ValueChanged += TbSection_ValueChanged;
        }


        // ================================================
        // Function - ANALYSIS
        // ================================================
        private void btnAnalysisModel_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "SUPPORTER_VARIABLE_ITEM" }, false, true, false, false, true, false);
            if (nodes.Count != 0) return;

            float xLength = Convert.ToSingle(txtSuppTopX.Text);
            float yLength = Convert.ToSingle(txtSuppTopY.Text);
            float offset = Convert.ToSingle(txtSuppHeight.Text);
            float baseline = Convert.ToSingle(txtBaseline.Text);

            vizcore3d.BeginUpdate();

            VIZCore3D.NET.Data.Node vAssy = vizcore3d.Structure.CreateNode(0, VIZCore3D.NET.Data.NodeKind.ASSEMBLY, "SUPPORTER_VARIABLE_ITEM");

            foreach (KeyValuePair<Point, List<VIZCore3D.NET.Data.Vertex3D>> item in COLLISION_MAP)
            {
                VIZCore3D.NET.Data.Node vPart = vizcore3d.Structure.CreateNode(vAssy.Index, VIZCore3D.NET.Data.NodeKind.PART, string.Format("SUPPORTER_VARIABLE_NO_{0}_{1}", item.Key.X, item.Key.Y));
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
                        - Convert.ToSingle(txtDockOffset.Text)
                        + Convert.ToSingle(txtSuppHeight.Text)));

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.SetTranslate(item.Value[0].X, item.Value[0].Y, item.Value[0].Z - (length[2] / 2));

                    vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, Color.Orange, false);
                }
            }

            vizcore3d.Structure.RebuildData();

            vizcore3d.EndUpdate();
        }

        private void btnAnalysisModelClear_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "SUPPORTER_VARIABLE_ITEM" }, false, true, false, false, true, false);
            if (nodes.Count == 0) return;

            vizcore3d.Object3D.Delete(nodes);
        }

        private void btnAnalysisMeasureClear_Click(object sender, EventArgs e)
        {
            vizcore3d.Review.Measure.Clear();
        }

        private void btnAnalysisMeasureXaxis_Click(object sender, EventArgs e)
        {
            Dictionary<int, List<VIZCore3D.NET.Data.Vertex3D>> xAxisMap = new Dictionary<int, List<VIZCore3D.NET.Data.Vertex3D>>();
            List<VIZCore3D.NET.Data.Vertex3D> items = new List<VIZCore3D.NET.Data.Vertex3D>();

            foreach (KeyValuePair<Point, List<VIZCore3D.NET.Data.Vertex3D>> item in COLLISION_MAP)
            {
                if (xAxisMap.ContainsKey(item.Key.X) == true) continue;
                xAxisMap.Add(item.Key.X, item.Value);
                items.Add(item.Value[0]);
            }

            vizcore3d.Review.Measure.AddCustomLinkedDistanceAxis(VIZCore3D.NET.Data.Axis.X, items);
        }

        private void btnAnalysisModelShow_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> nodes = GetVesselModel();
            vizcore3d.Object3D.Show(VIZCore3D.NET.Data.Object3DKind.ALL, true);
        }

        private void btnAnalysisModelHide_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> nodes = GetVesselModel();
            vizcore3d.Object3D.Show(nodes, false);
        }

        private List<VIZCore3D.NET.Data.Node> GetVesselModel()
        {
            string name = "DDH.V4";
            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(name, true);
            if (nodes.Count == 0) return new List<VIZCore3D.NET.Data.Node>();

            List<VIZCore3D.NET.Data.Node> children = nodes[0].GetChildObject3d(VIZCore3D.NET.Data.Object3DChildOption.CHILD_ONLY);
            List<VIZCore3D.NET.Data.Node> filter = new List<VIZCore3D.NET.Data.Node>();
            foreach (VIZCore3D.NET.Data.Node item in children)
            {
                if (item.NodeName == "DOCK_ASSY") continue;
                filter.Add(item);
            }

            return filter;
        }



        // ================================================
        // Function - FLOODING
        // ================================================
        private void btnFloodingInit_Click(object sender, EventArgs e)
        {
            string name = System.Environment.MachineName.ToUpper();
            if (name == "GJKIM-ADELL")
            {
                string path = "E:\\MODELS\\SHOWCASE\\DDH.V4.FLOODING.V2.viz";
                vizcore3d.Model.Open(path);
            }
            else
            {
                vizcore3d.Model.OpenFileDialog();
            }
        }
    }
}
