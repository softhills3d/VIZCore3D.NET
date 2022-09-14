using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.Animation.V2
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


        private VIZCore3D.NET.Data.BoundBox3D OriginalBoundBox;

        private List<BlockData> BlockItems { get; set; }

        /// <summary>
        /// 애니메이션 키 시간
        /// </summary>
        private float Time = 0.0f;

        /// <summary>
        /// 애니메이션 키 간격
        /// </summary>
        private float TimeInterval = 1.0f;

        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            // Construction
            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();

            vizcore3d.Dock = DockStyle.Fill;
            splitContainer2.Panel1.Controls.Add(vizcore3d);

            // Event
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
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
            //InitializeVIZCore3DToolbar();
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
            vizcore3d.Model.UncheckToUnload = false;

            // 모델 열기 시, Edge 정보 로드 활성화
            vizcore3d.Model.LoadEdgeData = false;

            // 모델 열기 시, Edge 정보 생성 활성화
            vizcore3d.Model.GenerateEdgeData = false;

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

            #region 렌더링 효과
            vizcore3d.View.PhongShading = true;                                 // Phong Shading
            vizcore3d.View.SilhouetteEdge = true;                               // 윤곽
            vizcore3d.View.RealtimeShadow = false;                              // 실시간 그림자
            vizcore3d.View.ShadingEffect = false;                               // 음영
            vizcore3d.View.EnvironmentLight = false;                            // 환경조명
            vizcore3d.View.AntiAliasing = false;                                // Anti-Aliasing
            vizcore3d.View.FloorShadow = false;                                 // 바닥 그림자
            vizcore3d.View.PlaneReflection = false;                             // 면 반사

            vizcore3d.View.Shininess = 30;                                      // 광원세기 - 0 ~ 100
            vizcore3d.View.SilhouetteEdgeColor = Color.FromArgb(127, 0, 0, 0);  // 윤곽 색상 및 투명도 - Black, 50%
            vizcore3d.View.AmbientColor = Color.DarkGray;                       // 음영 색상
            vizcore3d.View.DiffuseLightColor = Color.FromArgb(255, 255, 232);   // 기본 빛 색상
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
            vizcore3d.Walkthrough.EnableAvatarAutoZoom = true;
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
            vizcore3d.ToolbarSimulation.Visible = false;
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

        #region Function - VIZCore3D.NET : Add Event Handler
        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            vizcore3d.Animation.OnAnimationPlaybackPositionChangedEvent += Animation_OnAnimationPlaybackPositionChangedEvent;
            vizcore3d.Animation.OnAnimationPlaybackFinishedEvent += Animation_OnAnimationPlaybackFinishedEvent;
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
        // Functions
        // ================================================
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string path = "E:\\MODELS\\SHOWCASE\\ANIMATION.V2\\MODEL.viz";

            vizcore3d.Model.Open(path);

            OriginalBoundBox = vizcore3d.Model.BoundBox;

            ShowSequence();
        }

        private void ShowSequence()
        {
            BlockItems = new List<BlockData>();

            string shipCode = "0000";

            BlockItems.Add(new BlockData(1, shipCode, "2B11", "2019-07-16"));
            BlockItems.Add(new BlockData(2, shipCode, "2E12", "2019-07-16"));
            BlockItems.Add(new BlockData(3, shipCode, "1E11", "2019-07-16"));
            BlockItems.Add(new BlockData(4, shipCode, "1B31", "2019-07-17"));
            BlockItems.Add(new BlockData(5, shipCode, "5B31", "2019-07-17"));
            BlockItems.Add(new BlockData(6, shipCode, "2B13", "2019-07-18"));
            BlockItems.Add(new BlockData(7, shipCode, "2B14", "2019-07-18"));
            BlockItems.Add(new BlockData(8, shipCode, "2B15", "2019-07-19"));
            BlockItems.Add(new BlockData(9, shipCode, "1E31", "2019-07-19"));
            BlockItems.Add(new BlockData(10, shipCode, "2B16", "2019-07-19"));
            BlockItems.Add(new BlockData(11, shipCode, "2B17", "2019-07-22"));
            BlockItems.Add(new BlockData(12, shipCode, "6T13", "2019-07-22"));
            BlockItems.Add(new BlockData(13, shipCode, "2T13", "2019-07-22"));
            BlockItems.Add(new BlockData(14, shipCode, "1B18", "2019-07-22"));
            BlockItems.Add(new BlockData(15, shipCode, "E32C", "2019-07-22"));
            BlockItems.Add(new BlockData(16, shipCode, "2B19", "2019-07-23"));
            BlockItems.Add(new BlockData(17, shipCode, "6T14", "2019-07-23"));
            BlockItems.Add(new BlockData(18, shipCode, "6T11", "2019-07-23"));
            BlockItems.Add(new BlockData(19, shipCode, "2T14", "2019-07-23"));
            BlockItems.Add(new BlockData(20, shipCode, "2T11", "2019-07-23"));
            BlockItems.Add(new BlockData(21, shipCode, "1L18", "2019-07-23"));
            BlockItems.Add(new BlockData(22, shipCode, "1S13", "2019-07-24"));
            BlockItems.Add(new BlockData(23, shipCode, "6T12", "2019-07-24"));
            BlockItems.Add(new BlockData(24, shipCode, "6T15", "2019-07-24"));
            BlockItems.Add(new BlockData(25, shipCode, "2T15", "2019-07-24"));
            BlockItems.Add(new BlockData(26, shipCode, "2T12", "2019-07-24"));
            BlockItems.Add(new BlockData(27, shipCode, "5S13", "2019-07-24"));
            BlockItems.Add(new BlockData(28, shipCode, "2F11", "2019-07-24"));
            BlockItems.Add(new BlockData(29, shipCode, "1E41", "2019-07-25"));
            BlockItems.Add(new BlockData(30, shipCode, "6T16", "2019-07-25"));
            BlockItems.Add(new BlockData(31, shipCode, "5E41", "2019-07-25"));
            BlockItems.Add(new BlockData(32, shipCode, "2T16", "2019-07-25"));
            BlockItems.Add(new BlockData(33, shipCode, "S15P", "2019-07-26"));
            BlockItems.Add(new BlockData(34, shipCode, "S15S", "2019-07-26"));
            BlockItems.Add(new BlockData(35, shipCode, "1N21", "2019-08-09"));
            BlockItems.Add(new BlockData(36, shipCode, "5S16", "2019-08-09"));
            BlockItems.Add(new BlockData(37, shipCode, "5S11", "2019-08-09"));
            BlockItems.Add(new BlockData(38, shipCode, "1S16", "2019-08-09"));
            BlockItems.Add(new BlockData(39, shipCode, "1S11", "2019-08-09"));
            BlockItems.Add(new BlockData(40, shipCode, "1S18", "2019-08-13"));
            BlockItems.Add(new BlockData(41, shipCode, "5S18", "2019-08-13"));
            BlockItems.Add(new BlockData(42, shipCode, "1F41", "2019-08-14"));
            BlockItems.Add(new BlockData(43, shipCode, "1D11", "2019-08-16"));
            BlockItems.Add(new BlockData(44, shipCode, "1F51", "2019-08-19"));
            BlockItems.Add(new BlockData(45, shipCode, "5E51", "2019-08-19"));
            BlockItems.Add(new BlockData(46, shipCode, "1E51", "2019-08-19"));
            BlockItems.Add(new BlockData(47, shipCode, "1D13", "2019-08-20"));
            BlockItems.Add(new BlockData(48, shipCode, "1N31", "2019-08-21"));
            BlockItems.Add(new BlockData(49, shipCode, "1D14", "2019-08-21"));
            BlockItems.Add(new BlockData(50, shipCode, "D93P", "2019-08-22"));
            BlockItems.Add(new BlockData(51, shipCode, "1D15", "2019-08-22"));
            BlockItems.Add(new BlockData(52, shipCode, "1D17", "2019-08-26"));
            BlockItems.Add(new BlockData(53, shipCode, "1H11", "2019-08-27"));
            BlockItems.Add(new BlockData(54, shipCode, "1H12", "2019-08-28"));
            BlockItems.Add(new BlockData(55, shipCode, "1H31", "2019-08-29"));
            BlockItems.Add(new BlockData(56, shipCode, "N40C", "2019-09-02"));

            Dictionary<string, List<VIZCore3D.NET.Data.Node>> nodes = vizcore3d.Object3D.GetNodeNameMapFromDepth(1, false);

            foreach (BlockData item in BlockItems)
            {
                if (nodes.ContainsKey(item.BLOCK) == true)
                {
                    item.BlockNode = nodes[item.BLOCK][0];
                }
            }

            lvBlock.BeginUpdate();
            lvBlock.Items.Clear();
            foreach (BlockData item in BlockItems)
            {
                ListViewItem lvi = new ListViewItem(new string[] { item.NO.ToString(), item.BLOCK, item.ERECTION_DATE, item.BlockNode == null ? "N" : "Y" });
                lvBlock.Items.Add(lvi);
            }
            lvBlock.EndUpdate();
        }

        private void btnAddAnimation_Click(object sender, EventArgs e)
        {
            // 화면 메시지 설정
            vizcore3d.View.Message.Color = Color.Red;
            vizcore3d.View.Message.TextSize = VIZCore3D.NET.Data.FontSize.Size_24_Bold;

            // 분해를 위한 블록별 그룹 등록
            if (BlockItems == null || BlockItems.Count == 0) return;
            for (int i = 0; i < BlockItems.Count; i++)
            {
                bool result = vizcore3d.Object3D.Disassembly.AddGroup(
                    i                                   /* ID : 0 ~ */
                    , BlockItems[i].BlockNode.Index     /* NODE INDEX */
                    , true                              /* Recursive */
                    );
            }

            vizcore3d.BeginUpdate();

            // 비율 분해
            vizcore3d.View.EnableAnimation = false;
            float rate = Convert.ToSingle(txtRate.Text);
            vizcore3d.Object3D.Disassembly.DisassembleBySphereCenterDistanceRate(true, rate);

            // 비율 분해 BoundBox
            VIZCore3D.NET.Data.BoundBox3D disBoundBox = vizcore3d.Model.BoundBox;
            float height = disBoundBox.LengthZ;

            // 모델 중심점 관리
            foreach (BlockData item in BlockItems)
            {
                if (item.BlockNode == null) continue;

                item.Center = item.BlockNode.GetCenter();
            }

            // 분해 복구
            vizcore3d.Object3D.Transform.RestoreTransformAll();

            // 모델 이동 : 분해된 상태처럼
            foreach (BlockData item in BlockItems)
            {
                if (item.BlockNode == null) continue;

                VIZCore3D.NET.Data.Vertex3D v = item.Center;
                v.Z += height;

                vizcore3d.Object3D.Transform.MoveTo(new List<VIZCore3D.NET.Data.Node>() { item.BlockNode }, v);
            }

            // 애니메이션 생성
            vizcore3d.Animation.UseEffect = false;      /* 기본 효과 사용안함 설정 */
            vizcore3d.Animation.Clear();
            vizcore3d.Animation.Add("Animation");

            Time = 0.0f;

            // 초기 위치 설정 (분해된 상태)
            AddKey(true, false, TimeInterval * 0.5f, "INIT.");

            // 순서대로 위치 초기화 시키면서 애니메이션 장면 추가
            for (int i = 0; i < BlockItems.Count; i++)
            {
                BlockData block = BlockItems[i];
                vizcore3d.Object3D.Transform.RestoreTransform(new List<VIZCore3D.NET.Data.Node>() { block.BlockNode });
                AddKey(true, false, TimeInterval * 0.5f, BlockItems[i].GetMessageString());

                block.AnimationTime = Time;
            }

            vizcore3d.EndUpdate();

            // 트랙바 설정
            tbAnimation.Enabled = true;
            tbAnimation.Maximum = Convert.ToInt32(Time);

            MessageBox.Show("Completed.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AddKey(bool modelKey, bool cameraKey, float internval, string tag)
        {
            Time += internval;

            if (cameraKey)
                vizcore3d.Animation.AddKey(Time, VIZCore3D.NET.Manager.AnimationManager.AnimationKeyType.CAMERA);

            if (modelKey)
                vizcore3d.Animation.AddKey(Time, VIZCore3D.NET.Manager.AnimationManager.AnimationKeyType.MODEL, tag);
        }

        private void tbAnimation_Scroll(object sender, EventArgs e)
        {
            int barValue = tbAnimation.Value;

            vizcore3d.Animation.CurrentPlayingTime = Convert.ToSingle(barValue);

            if (barValue == 0)
            {
                vizcore3d.View.Message.Clear();
            }
            else
            {
                for (int i = 0; i < BlockItems.Count; i++)
                {
                    float time = BlockItems[i].AnimationTime;
                    if (Convert.ToInt32(time) == barValue)
                    {
                        string message = BlockItems[i].GetMessageString();

                        ShowMessage(message);
                        break;
                    }
                }
            }
        }

        private void btnPlayAnimation_Click(object sender, EventArgs e)
        {
            tbAnimation.Scroll -= new System.EventHandler(this.tbAnimation_Scroll);

            vizcore3d.Animation.PlayingTime = Time;

            vizcore3d.View.RealtimeShadow = true;
            vizcore3d.View.EnvironmentLight = true;
            vizcore3d.View.AntiAliasing = true;

            if (vizcore3d.View.Projection == Data.Projections.Orthographic)
                vizcore3d.View.Projection = VIZCore3D.NET.Data.Projections.Perspective;  /* 원근 뷰 설정 */

            vizcore3d.Animation.Play(false, 0);
        }

        private void Animation_OnAnimationPlaybackPositionChangedEvent(object sender, Event.EventManager.AnimationPlaybackPositionEventArgs e)
        {
            tbAnimation.Value = Convert.ToInt32(e.Time);

            if (e.Tag == null) return;
            string tag = (string)e.Tag;

            if (String.IsNullOrEmpty(tag) == true) return;

            ShowMessage(tag);
        }

        private void ShowMessage(string text)
        {
            vizcore3d.View.Message.Show(Data.MessageId.ID_01, text, 20, 20, false);
        }

        private void Animation_OnAnimationPlaybackFinishedEvent(object sender, Event.EventManager.AnimationPlaybackEventArgs e)
        {
            tbAnimation.Scroll += new System.EventHandler(this.tbAnimation_Scroll);
        }

        private void btnPauseAnimation_Click(object sender, EventArgs e)
        {
            vizcore3d.Animation.Pause();

            tbAnimation.Scroll += new System.EventHandler(this.tbAnimation_Scroll);
        }
    }
}
