using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.DockOut
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
        /// 3D Model BoundBox
        /// </summary>
        public VIZCore3D.NET.Data.BoundBox3D MODEL_BOUNDBOX { get; set; }

        /// <summary>
        /// Grid Cross Point
        /// </summary>
        public Dictionary<Point, VIZCore3D.NET.Data.Vertex3D> GRID_CROSS_MAP { get; set; }

        /// <summary>
        /// Dock BoundBox
        /// </summary>
        public VIZCore3D.NET.Data.BoundBox3D DOCK_BOUNDBOX { get; set; }

        /// <summary>
        /// Water BoundBox
        /// </summary>
        public VIZCore3D.NET.Data.BoundBox3D WATER_BOUNDBOX { get; set; }

        /// <summary>
        /// Water Box ID
        /// </summary>
        public int WATER_BOX_ID { get; set; }

        /// <summary>
        /// SHIP NODE
        /// </summary>
        public List<VIZCore3D.NET.Data.Node> SHIP_NODE { get; set; }
        public List<VIZCore3D.NET.Data.Node> ETC_NODE { get; set; }


        private const int GRID_ITEM_GROUP_ID = 0;
        private const int GRID_CROSS_POINT_GROUP_ID = 1;

        public float LastZHeight { get; set; }

        public GridSpaceManager CollisionManager { get; set; }

        public List<ClashItem> ClashItems { get; set; }

        public VIZCore3D.NET.Data.Vertex3D SHIP_CENTER;

        public Dictionary<string, string> CLASH_RESULT_ITEMS { get; set; }


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

            // Event
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;

            WATER_BOX_ID = -1;

            //txtDockLength.Text = "160";
            txtDockDepth.Text = "14";
            txtMaxHeight.Text = "22000";

            CollisionManager = new GridSpaceManager();
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
        // Function - MODEL
        // ================================================
        private void btnOpenModel_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\Models\\VIZCore3D.NET.DockOut\\SHIP.viz", vizcore3d.GetEntryAssemblyPath());

            if (System.IO.File.Exists(path) == true)
            {
                vizcore3d.Model.Open(path);
            }
            else
            {
                vizcore3d.Model.OpenFileDialog();
            }

            MODEL_BOUNDBOX = vizcore3d.Model.BoundBox;

            GRID_CROSS_MAP = new Dictionary<Point, Data.Vertex3D>();
        }

        // ================================================
        // Function - DOCK
        // ================================================
        private void btnDockGenerate_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            vizcore3d.BeginUpdate();

            // Remove Dock Model
            ExistDockModel(true);

            string strDockLength = txtDockLength.Text; // m
            string strDockBreadth = txtDockBreadth.Text; // m
            string strDockDepth = txtDockDepth.Text; // m
            float thickness = 300.0f;

            string strDockFrontOffset = txtDockFrontOffset.Text; // mm
            string strDockSideOffset = txtDockSideOffset.Text; // mm

            float fDockLength = Convert.ToSingle(strDockLength) * 1000.0f;
            float fDockBreadth = Convert.ToSingle(strDockBreadth) * 1000.0f;
            float fDockDepth = Convert.ToSingle(strDockDepth) * 1000.0f;

            float fDockFrontOffset = Convert.ToSingle(strDockFrontOffset);
            float fDockSideOffset = Convert.ToSingle(strDockSideOffset);

            float fDockFrontVal = (fDockLength / 2) - (MODEL_BOUNDBOX.LengthX / 2) - fDockFrontOffset;
            float fDockSideVal = (fDockBreadth / 2) - (MODEL_BOUNDBOX.LengthY / 2) - fDockSideOffset;

            bool dockSingleModel = ckDockSingle.Checked;
            bool dockSideAll = ckDockSideAll.Checked;

            VIZCore3D.NET.Data.Node dockAssy = vizcore3d.Structure.CreateNode(
                0
                , VIZCore3D.NET.Data.NodeKind.ASSEMBLY
                , "DOCK_ASSY"
                );

            if (dockSingleModel == true)
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
                        MODEL_BOUNDBOX.CenterX - fDockFrontVal
                        , MODEL_BOUNDBOX.CenterY + fDockSideVal
                        , MODEL_BOUNDBOX.MinZ - (thickness / 2.0f)
                        );

                    Color dockColor = Color.FromArgb(50, 128, 128, 128);

                    vizcore3d.MeshEdit.AddPrimitiveBox(bodyIndex, length, matrix, dockColor, false);
                }

                // 뒷면
                if (dockSideAll == true)
                {
                    List<float> length = new List<float>();
                    length.Add(fDockLength);
                    length.Add(thickness);
                    length.Add(fDockDepth);

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.Identity();
                    matrix.SetTranslate(
                        MODEL_BOUNDBOX.CenterX - fDockFrontVal
                        , MODEL_BOUNDBOX.CenterY + (fDockBreadth / 2) + fDockSideVal
                        , MODEL_BOUNDBOX.MinZ + (fDockDepth / 2)
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
                        MODEL_BOUNDBOX.CenterX - fDockFrontVal
                        , MODEL_BOUNDBOX.CenterY - (fDockBreadth / 2) + fDockSideVal
                        , MODEL_BOUNDBOX.MinZ + (fDockDepth / 2)
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
                        MODEL_BOUNDBOX.CenterX - (fDockLength / 2) - fDockFrontVal
                        , MODEL_BOUNDBOX.CenterY + fDockSideVal
                        , MODEL_BOUNDBOX.MinZ + (fDockDepth / 2)
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
                        MODEL_BOUNDBOX.CenterX + (fDockLength / 2) - fDockFrontVal
                        , MODEL_BOUNDBOX.CenterY + fDockSideVal
                        , MODEL_BOUNDBOX.MinZ + (fDockDepth / 2)
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
                        MODEL_BOUNDBOX.CenterX - fDockFrontVal
                        , MODEL_BOUNDBOX.CenterY + fDockSideVal
                        , MODEL_BOUNDBOX.MinZ - (thickness / 2.0f)
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
                        MODEL_BOUNDBOX.CenterX - fDockFrontVal
                        , MODEL_BOUNDBOX.CenterY + (fDockBreadth / 2) + fDockSideVal
                        , MODEL_BOUNDBOX.MinZ + (fDockDepth / 2)
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
                        MODEL_BOUNDBOX.CenterX - fDockFrontVal
                        , MODEL_BOUNDBOX.CenterY - (fDockBreadth / 2) + fDockSideVal
                        , MODEL_BOUNDBOX.MinZ + (fDockDepth / 2)
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
                        MODEL_BOUNDBOX.CenterX - (fDockLength / 2) - fDockFrontVal
                        , MODEL_BOUNDBOX.CenterY + fDockSideVal
                        , MODEL_BOUNDBOX.MinZ + (fDockDepth / 2)
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
                        MODEL_BOUNDBOX.CenterX + (fDockLength / 2) - fDockFrontVal
                        , MODEL_BOUNDBOX.CenterY + fDockSideVal
                        , MODEL_BOUNDBOX.MinZ + (fDockDepth / 2)
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

            if (remove == true)
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

            string strDockFrontOffset = txtDockFrontOffset.Text; // mm
            string strDockSideOffset = txtDockSideOffset.Text; // mm

            float fDockLength = Convert.ToSingle(strDockLength) * 1000.0f;
            float fDockBreadth = Convert.ToSingle(strDockBreadth) * 1000.0f;
            float fDockDepth = Convert.ToSingle(strDockDepth) * 1000.0f;

            float fDockFrontOffset = Convert.ToSingle(strDockFrontOffset);
            float fDockSideOffset = Convert.ToSingle(strDockSideOffset);

            float fDockFrontVal = (fDockLength / 2) - (MODEL_BOUNDBOX.LengthX / 2) - fDockFrontOffset;
            float fDockSideVal = (fDockBreadth / 2) - (MODEL_BOUNDBOX.LengthY / 2) - fDockSideOffset;

            float startX = MODEL_BOUNDBOX.CenterX - (fDockLength / 2);
            float startY = MODEL_BOUNDBOX.CenterY + (fDockBreadth / 2);
            float depth = MODEL_BOUNDBOX.MinZ;

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
                coll.Add(new VIZCore3D.NET.Data.Vertex3D(startX + (i * intervalX) - fDockFrontVal, startY + fDockSideVal, depth));
                coll.Add(new VIZCore3D.NET.Data.Vertex3D(startX + (i * intervalX) - fDockFrontVal, startY - fDockBreadth + fDockSideVal, depth));
                gridLines.Add(coll);
            }

            for (int i = 1; i < nTimesY; i++)
            {
                VIZCore3D.NET.Data.Vertex3DItemCollection coll = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                coll.Add(new VIZCore3D.NET.Data.Vertex3D(startX-fDockFrontVal, startY - (i * intervalY) + fDockSideVal, depth));
                coll.Add(new VIZCore3D.NET.Data.Vertex3D(startX + fDockLength - fDockFrontVal, startY - (i * intervalY) + fDockSideVal, depth));
                gridLines.Add(coll);
            }

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
                        startX + (i * intervalX) - fDockFrontVal
                        , startY - (j * intervalY) + fDockSideVal
                        , depth - 5.0f
                        );

                    VIZCore3D.NET.Data.Vertex3D max = new VIZCore3D.NET.Data.Vertex3D(
                        startX + ((i + 1) * intervalX) - fDockFrontVal
                        , startY - ((j + 1) * intervalY) + fDockSideVal
                        , depth + 5.0f
                        );

                    box1.SetMinMaxPoints(new VIZCore3D.NET.Data.BoundBox3D(min, max));

                    gridPart.AddPrimitive(box1);

                    GridSpaceItem gs = new GridSpaceItem();
                    gs.Name = string.Format("GRID_PART_{0}_{1}", i + 1, j + 1);
                    gs.NoX = i + 1;
                    gs.NoY = j + 1;
                    gs.GridBoundBox = new VIZCore3D.NET.Data.BoundBox3D(min, max);
                    CollisionManager.Add(gs);
                }
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

            if (ckGridHighlightCrossPoint.Checked == true)
                vizcore3d.ShapeDrawing.AddVertex(crossPoints, GRID_CROSS_POINT_GROUP_ID, Color.Yellow, 1, 2, true);

            // 데이터 재구성
            vizcore3d.Structure.RebuildData();

            vizcore3d.EndUpdate();

            byte[] buffer = vizcore3d.Primitive.GetStream("GRID_MODOEL");

            vizcore3d.Model.AddStream(new List<VIZCore3D.NET.Data.StreamData>() { new VIZCore3D.NET.Data.StreamData(buffer, "GRID_MODEL") });
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
        // Function - FLOODING
        // ================================================
        private void btnFloodingInit_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> dock = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "DOCK_ASSY" }, false, true, false, false, true, false);
            if (dock.Count == 0) return;

            SHIP_NODE = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "DDH" }, false, true, false, false, true, false);
            if (SHIP_NODE.Count == 0) return;

            DOCK_BOUNDBOX = vizcore3d.Object3D.GeometryProperty.FromNode(dock, false).GetBoundBox();
            WATER_BOUNDBOX = vizcore3d.Object3D.GeometryProperty.FromNode(dock, false).GetBoundBox();

            WATER_BOX_ID = vizcore3d.SelectionBox.Add(DOCK_BOUNDBOX, Color.FromArgb(10, Color.Blue), Color.Gray, "WATER");

            tbHeight.Scroll -= new System.EventHandler(this.tbHeight_Scroll);
            tbHeight.Enabled = true;
            tbHeight.Value = 0;
            tbHeight.Scroll += new System.EventHandler(this.tbHeight_Scroll);

            vizcore3d.View.Message.TextSize = Data.FontSize.Size_26_Bold;
            vizcore3d.View.Message.Color = Color.Red;

            vizcore3d.View.RotateCamera(Data.ShipbuildingCameraDirection.STARBOARD);
        }

        private void tbHeight_Scroll(object sender, EventArgs e)
        {
            if (WATER_BOX_ID == -1) return;

            float maxHeight = Convert.ToSingle(txtMaxHeight.Text);
            float floatingHeight = Convert.ToSingle(txtFloatingHeight.Text);
            float ratio = maxHeight / 100;

            float vals = tbHeight.Value * ratio;
            WATER_BOUNDBOX.MaxZ = DOCK_BOUNDBOX.MaxZ + vals;

            vizcore3d.View.Message.Show(Data.MessageId.ID_01, string.Format("{0:#,0} mm.", vals), 10, 10);

            if (vals > floatingHeight)
            {
                vizcore3d.Object3D.Transform.Move(SHIP_NODE, new VIZCore3D.NET.Data.Vector3D(0, 0, vals - floatingHeight), true);
                //vizcore3d.Object3D.Transform.Move(SHIP_NODE, new VIZCore3D.NET.Data.Vector3D(0, 0, ratio), false);

                LastZHeight = vals - floatingHeight;
            }

            vizcore3d.SelectionBox.SetSize(WATER_BOX_ID, WATER_BOUNDBOX);
        }

        private void btnFloodingClear_Click(object sender, EventArgs e)
        {
            vizcore3d.View.Message.Hide(Data.MessageId.ID_01);
            vizcore3d.SelectionBox.Clear();
            WATER_BOX_ID = -1;

            tbHeight.Scroll -= new System.EventHandler(this.tbHeight_Scroll);
            tbHeight.Enabled = false;
            tbHeight.Value = 0;
            tbHeight.Scroll += new System.EventHandler(this.tbHeight_Scroll);

            vizcore3d.Object3D.Transform.RestoreTransformAll();
        }

        private void btnSelectShip_Click(object sender, EventArgs e)
        {
            if (SHIP_NODE == null || SHIP_NODE.Count == 0) return;

            vizcore3d.Object3D.Select(SHIP_NODE, true);
        }

        private void btnHandle_Click(object sender, EventArgs e)
        {
            vizcore3d.Object3D.Transform.EnableHandle = !vizcore3d.Object3D.Transform.EnableHandle;
        }


        // ================================================
        // Function - CLASH
        // ================================================
        private void btnClashCheck_Click(object sender, EventArgs e)
        {
            vizcore3d.Clash.EnableMultiThread = true;
            DetectedCount = 0;
            CLASH_RESULT_ITEMS = new Dictionary<string, string>();

            vizcore3d.View.RotateCamera(Data.ShipbuildingCameraDirection.TOP);

            float xRange = Convert.ToSingle(txtClashXAxis.Text); // m
            float yRange = Convert.ToSingle(txtClashYAxis.Text); // m

            float xInterval = Convert.ToSingle(txtClashXOffset.Text); // m
            float yInterval = Convert.ToSingle(txtClashYOffset.Text); // m

            float xCount = (xRange * 2) / xInterval;
            float yCount = (yRange * 2) / yInterval;

            if (SHIP_NODE == null || SHIP_NODE.Count == 0)
                SHIP_NODE = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "DDH" }, false, true, false, false, true, false);

            if (SHIP_NODE.Count == 0) return;

            ETC_NODE = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "SUPPORTER", "DOCK_ASSY", "GRID_MODEL" }, false, true, false, false, true, false);

            ClashItems = new List<ClashItem>();

            CollisionManager.ResetCollisionCount();

            SHIP_CENTER = vizcore3d.Object3D.GeometryProperty.FromNode(SHIP_NODE).CenterPoint;

            ClashItems.Add(new ClashItem(new VIZCore3D.NET.Data.Vector3D(-xRange * 1000, yRange * 1000, 0)));

            for (int j = 0; j < yCount; j++)
            {
                ClashItems.Add(new ClashItem(new VIZCore3D.NET.Data.Vector3D(0, -yInterval * 1000, 0)));

                for (int i = 0; i < xCount; i++)
                {
                    ClashItems.Add(new ClashItem(new VIZCore3D.NET.Data.Vector3D(xInterval * 1000, 0, 0)));
                }

                ClashItems.Add(new ClashItem(new VIZCore3D.NET.Data.Vector3D(-xRange * 1000 * 2, 0, 0)));
            }

            // Original Position
            //vizcore3d.Object3D.Transform.MoveTo(SHIP_NODE, SHIP_CENTER);

            DetectCollision();

            //for (int i = 0; i < ClashItems.Count; i++)
            //{
            //    vizcore3d.Object3D.Transform.Move(SHIP_NODE, ClashItems[i].Translation, false);
            //    Application.DoEvents();
            //}
        }

        private bool DetectCollision()
        {
            int index = -1;
            for (int i = 0; i < ClashItems.Count; i++)
            {
                if(ClashItems[i].Completed == true) continue;
                index = i;
                break;
            }

            if (index == -1)
            {
                vizcore3d.Object3D.Transform.MoveTo(SHIP_NODE, SHIP_CENTER);

                MessageBox.Show(string.Format("Complted Detect Collision. - {0:#,0} EA", DetectedCount), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Activate();

                return false;
            }

            vizcore3d.Object3D.Transform.Move(SHIP_NODE, ClashItems[index].Translation, false);
            Application.DoEvents();

            if (ckClashSimulation.Checked == true)
            {
                ClashItems[index].Completed = true;

                if (startCheck == null)
                {
                    startCheck = new System.Timers.Timer();
                    startCheck.Interval = 100;
                    startCheck.Elapsed += StartCheck_Elapsed;
                }

                startCheck.Enabled = true;

                return true;
            }

            VIZCore3D.NET.Data.ClashTest item = new VIZCore3D.NET.Data.ClashTest();

            item.Name = "CLASH";
            //item.TestKind = VIZCore3D.NET.Data.ClashTest.ClashTestKind.GROUP_VS_GROUP;
            item.TestKind = VIZCore3D.NET.Data.ClashTest.ClashTestKind.SELECTED_MODEL_VS_OTHER;

            item.UseClearanceValue = false;
            item.ClearanceValue = 3.0f;
            item.UseRangeValue = false;
            item.RangeValue = 2.0f;
            item.UsePenetrationTolerance = false;
            item.PenetrationTolerance = 1.0f;

            item.VisibleOnly = false;
            item.BottomLevel = 1;

            item.GroupA = SHIP_NODE;
            item.GroupB = ETC_NODE;

            vizcore3d.Clash.Add(item);

            ClashItems[index].ClashID = item.ID;

            vizcore3d.Clash.PerformInterferenceCheck(item.ID);

            return true;
        }
        private int DetectedCount = 0;
        private void Clash_OnClashTestFinishedEvent(object sender, Event.EventManager.ClashEventArgs e)
        {
            int id = e.ID;
            VIZCore3D.NET.Data.ClashTest clash = vizcore3d.Clash.GetItem(e.ID);

            List<VIZCore3D.NET.Data.ClashTestResultItem> items = vizcore3d.Clash.GetResultItem(
            clash
            , VIZCore3D.NET.Manager.ClashManager.ResultGroupingOptions.PART
            );

            //MessageBox.Show(string.Format("{0}/{1}/{2}EA", e.ID, clash.ID, items.Count), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DetectedCount += items.Count;

            foreach (VIZCore3D.NET.Data.ClashTestResultItem item in items)
            {
                CollisionManager.CheckCollisionSpace(item.HotPoint);

                if (CLASH_RESULT_ITEMS.ContainsKey(item.NodeNameB) == false)
                    CLASH_RESULT_ITEMS.Add(item.NodeNameB, item.NodeNameB);
            }

            foreach (ClashItem item in ClashItems)
            {
                if (item.ClashID != id) continue;
                item.Completed = true;
            }

            if(startCheck == null)
            {
                startCheck = new System.Timers.Timer();
                startCheck.Interval = 100;
                startCheck.Elapsed += StartCheck_Elapsed;
            }

            startCheck.Enabled = true;
        }

        private void StartCheck_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            startCheck.Enabled = false;

            this.Invoke(new EventHandler(delegate
            {
                DetectCollision();
            }));
        }

        private System.Timers.Timer startCheck { get; set; }

        private void btnClashResultShow_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();

            List<VIZCore3D.NET.Data.Node> hidden = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "SUPPORTER", "DDH" }, false, true, false, false, true, false);
            vizcore3d.Object3D.Show(hidden, false);

            List<VIZCore3D.NET.Data.Node> grid = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "GRID_MODEL" }, false, true, false, false, true, false);
            vizcore3d.Object3D.Color.SetColor(grid, Color.White);

            // GRID_ASSY_ROOT
            List<VIZCore3D.NET.Data.Node> grid_assy = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "GRID_ASSY_ROOT" }, false, true, false, false, true, false);
            if(grid_assy.Count != 0)
            {
                List<VIZCore3D.NET.Data.Node> grid_part = grid_assy[0].GetChildObject3d(Data.Object3DChildOption.CHILD_ONLY);
                Dictionary<string, VIZCore3D.NET.Data.Node> grid_part_map = new Dictionary<string, VIZCore3D.NET.Data.Node>();

                foreach (VIZCore3D.NET.Data.Node part in grid_part)
                {
                    if (grid_part_map.ContainsKey(part.NodeName) == false)
                        grid_part_map.Add(part.NodeName, part);
                }

                VIZCore3D.NET.Utility.ColorBrewerPalettesHelper brewerColor = new VIZCore3D.NET.Utility.ColorBrewerPalettesHelper();
                //List<Color> colors = brewerColor.GetColors(Utility.ColorBrewerPalettesHelper.Kind.Sequential_Reds);
                brewerColor.SetPalette(VIZCore3D.NET.Utility.ColorBrewerPalettesHelper.Kind.Sequential_Reds);
                int maxVal = CollisionManager.GetMaxCount();
                brewerColor.SetRange(0, maxVal);

                bool ClashBrewerPalettes = ckClashBrewerPalettes.Checked;

                foreach (GridSpaceItem item in CollisionManager.Items)
                {
                    if (item.CollisionCount == 0) continue;

                    Color highlightColor = Color.Red;
                    if (ClashBrewerPalettes == true)
                        highlightColor = brewerColor.GetRangeColor(item.CollisionCount);

                    vizcore3d.Object3D.Color.SetColor(
                        new List<int>() { grid_part_map[item.Name].Index }
                        , highlightColor
                        );
                } 
            }

            vizcore3d.EndUpdate();

            gbClashResult.Text = string.Format("Result Items - {0:#,0}", CLASH_RESULT_ITEMS.Count);

            lvClash.BeginUpdate();
            lvClash.Items.Clear();
            foreach (KeyValuePair<string, string> item in CLASH_RESULT_ITEMS)
            {
                ListViewItem lvi = new ListViewItem(new string[] { item.Key });
                lvClash.Items.Add(lvi);
            }
            lvClash.EndUpdate();
        }

        private void btnClashResultClear_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();
            vizcore3d.Object3D.Color.RestoreAll();
            vizcore3d.Object3D.Show(Data.Object3DKind.ALL, true);
            vizcore3d.EndUpdate();
        }

        private void lvClash_DoubleClick(object sender, EventArgs e)
        {
            if (lvClash.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvClash.SelectedItems[0];
            string name = lvi.SubItems[0].Text;

            vizcore3d.Object3D.Show(Data.Object3DKind.ALL, true);

            List<VIZCore3D.NET.Data.Node> node = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { name }, false, false, false, false, true, false);
            if (node.Count == 0) return;

            if (vizcore3d.View.XRay.Enable == false)
                vizcore3d.View.XRay.Enable = true;

            vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.View.XRay.Clear();

            vizcore3d.Object3D.Select(node, true, true);
            vizcore3d.View.XRay.Select(node, true, true);
        }


        // ================================================
        // Function - Animation
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
        }

        
    }
}
