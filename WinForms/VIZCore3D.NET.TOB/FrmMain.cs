using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.TOB
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
        /// Demo Mode
        /// </summary>
        public bool DemoMode { get; set; }

        public List<VIZCore3D.NET.Data.Node> BLOCK_NODES { get; set; }
        public List<VIZCore3D.NET.Data.Node> LOADER_NODES { get; set; }

        public Dictionary<int, VIZCore3D.NET.Data.Node> LUG1 { get; set; }
        public Dictionary<int, VIZCore3D.NET.Data.Node> LUG2 { get; set; }

        public Dictionary<int, int> ROLLER { get; set; }
        public Dictionary<int, VIZCore3D.NET.Data.Node> ROLLER1 { get; set; }
        public Dictionary<int, VIZCore3D.NET.Data.Node> ROLLER2 { get; set; }
        public Dictionary<int, VIZCore3D.NET.Data.Node> ROLLER3 { get; set; }
        public Dictionary<int, VIZCore3D.NET.Data.Node> ROLLER4 { get; set; }
        

        public Dictionary<int, CollisionItem> CollisionObjects { get; set; }

        public bool AnimationOnly { get; set; }
        public bool EnablePerformanceLog { get; set; }
        public bool StopTurnOver { get; set; }
        public bool DisplayAngle { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();

            vizcore3d.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(vizcore3d);

            // Event
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;

            // Demo Mode
            DemoMode = System.Environment.MachineName.ToUpper() == "GJKIM-ADELL" ? true : false;
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

            // 윤곽
            vizcore3d.View.SilhouetteEdge = true;

            // 그림자
            vizcore3d.View.RealtimeShadow = true;

            // 음영
            vizcore3d.View.ShadingEffect = true;

            // 환경조명
            vizcore3d.View.EnvironmentLight = true;

            // Anti-Aliasing
            vizcore3d.View.AntiAliasing = true;

            // 바닥 그림자
            vizcore3d.View.FloorShadow = true;

            // 면 반사
            vizcore3d.View.PlaneReflection = false;
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

            #region 설정 - 측정 스타일
            VIZCore3D.NET.Data.MeasureStyle style = vizcore3d.Review.Measure.GetStyle();
            style.LineColor = Color.Yellow;
            style.ArrowColor = Color.Pink;
            style.BackgroundTransparent = true;
            style.FontColor = Color.Red;
            style.Prefix = false;
            style.AlignDistanceTextMargine = 100;
            style.AlignDistanceTextPosition = 1;
            vizcore3d.Review.Measure.SetStyle(style);
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

        #region Function - VIZCore3D.NET : Add Event Handler
        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
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
        // Example - Event
        // ================================================
        private void btnLoadGoliath_Click(object sender, EventArgs e)
        {
            if (DemoMode == true)
            {
                vizcore3d.Model.AddStream(
                    new VIZCore3D.NET.Data.StreamData(
                        System.IO.File.ReadAllBytes("E:\\MODELS\\SHOWCASE\\TOB\\GOLIATH_CRANE.V8.viz")
                        , "CRANE"
                        )
                    );

                vizcore3d.View.ResetView();
            }
            else
                vizcore3d.Model.AddFileDialog();
        }

        private void btnLoadBlock1_Click(object sender, EventArgs e)
        {
            if (DemoMode == true)
            {
                vizcore3d.Model.AddStream(
                    new VIZCore3D.NET.Data.StreamData(
                        System.IO.File.ReadAllBytes("E:\\MODELS\\SHOWCASE\\TOB\\BLOCK3.viz")
                        , "BLK"
                        )
                    );
            }
            else
                vizcore3d.Model.AddFileDialog();
        }

        private void btnLoadBlock2_Click(object sender, EventArgs e)
        {
            if (DemoMode == true)
            {
                vizcore3d.Model.AddStream(
                    new VIZCore3D.NET.Data.StreamData(
                        System.IO.File.ReadAllBytes("E:\\MODELS\\SHOWCASE\\TOB\\BLOCK2-3.viz")
                        , "BLK"
                        )
                    );
            }
            else
                vizcore3d.Model.AddFileDialog();
        }

        private List<VIZCore3D.NET.Data.Node> GetNode(string name)
        {
            List<VIZCore3D.NET.Data.Node> nodes =
                vizcore3d.Object3D.Find.QuickSearch(
                    new List<string>() { name } /* Keyword */
                    , false                     /* Join Condition */
                    , true                      /* Assembly Only */
                    , true                      /* Visible Only */
                    , false                     /* Selected Node Only */
                    , true                      /* Full Match */
                    , false                     /* Include Node Path */
                    );

            return nodes;
        }

        private void AddRollerCache(int index)
        {
            if (ROLLER.ContainsKey(index) == false)
                ROLLER.Add(index, index);
        }

        private void FindItems()
        {
            List<VIZCore3D.NET.Data.Node> lug1 = GetNode("LUG01");
            List<VIZCore3D.NET.Data.Node> lug2 = GetNode("LUG02");

            List<VIZCore3D.NET.Data.Node> lug1Children = lug1[0].GetChildObject3d(VIZCore3D.NET.Data.Object3DChildOption.CHILD_ONLY);
            LUG1 = new Dictionary<int, Data.Node>();
            for (int i = 0; i < lug1Children.Count; i++)
            {
                if (LUG1.ContainsKey(i + 1) == false)
                    LUG1.Add(i + 1, lug1Children[i]);
            }

            List<VIZCore3D.NET.Data.Node> lug2Children = lug2[0].GetChildObject3d(VIZCore3D.NET.Data.Object3DChildOption.CHILD_ONLY);
            LUG2 = new Dictionary<int, Data.Node>();
            for (int i = 0; i < lug2Children.Count; i++)
            {
                if (LUG2.ContainsKey(i + 1) == false)
                    LUG2.Add(i + 1, lug2Children[i]);
            }

            ROLLER = new Dictionary<int, int>();
            ROLLER1 = new Dictionary<int, Data.Node>();
            ROLLER2 = new Dictionary<int, Data.Node>();
            ROLLER3 = new Dictionary<int, Data.Node>();
            ROLLER4 = new Dictionary<int, Data.Node>();
            Dictionary<string, VIZCore3D.NET.Data.Node> names = vizcore3d.Object3D.GetNodeNameMap(false);

            for (int i = 0; i < 7; i++)
            {
                string nameStr1 = string.Format("LOADER-01-01-{0:D2}", i + 1);
                if (names.ContainsKey(nameStr1) == true)
                {
                    ROLLER1.Add(i + 1, names[nameStr1]);
                    AddRollerCache(names[nameStr1].Index);
                }

                string nameStr2 = string.Format("LOADER-01-02-{0:D2}", i + 1);
                if (names.ContainsKey(nameStr2) == true)
                {
                    ROLLER2.Add(i + 1, names[nameStr2]);
                    AddRollerCache(names[nameStr2].Index);
                }

                string nameStr3 = string.Format("LOADER-02-01-{0:D2}", i + 1);
                if (names.ContainsKey(nameStr3) == true)
                {
                    ROLLER3.Add(i + 1, names[nameStr3]);
                    AddRollerCache(names[nameStr3].Index);
                }

                string nameStr4 = string.Format("LOADER-02-02-{0:D2}", i + 1);
                if (names.ContainsKey(nameStr4) == true)
                {
                    ROLLER4.Add(i + 1, names[nameStr4]);
                    AddRollerCache(names[nameStr4].Index);
                }
            }
        }

        private void btnAlignCenterBlock_Click(object sender, EventArgs e)
        {
            LOADER_NODES = GetNode("LOADER");
            BLOCK_NODES = GetNode("BLK");

            FindItems();

            vizcore3d.BeginUpdate();

            // 블록 작업베이스 회전
            vizcore3d.Object3D.Transform.Rotate(BLOCK_NODES, 90, 0, 0, true, false);

            // 가운데 정렬
            VIZCore3D.NET.Data.BoundBox3D loader_bbox
                = vizcore3d.Object3D.GeometryProperty.FromNode(LOADER_NODES).GetBoundBox();

            VIZCore3D.NET.Data.BoundBox3D block_bbox
                = vizcore3d.Object3D.GeometryProperty.FromNode(BLOCK_NODES).GetBoundBox();

            vizcore3d.Object3D.Transform.MoveTo(
                BLOCK_NODES
                , loader_bbox.CenterX
                , loader_bbox.CenterY
                , block_bbox.CenterZ
                );

            vizcore3d.EndUpdate();
        }

        private void btnHighlightColor_Click(object sender, EventArgs e)
        {
            if (BLOCK_NODES.Count == 0) BLOCK_NODES = GetNode("BLK");
            if (BLOCK_NODES.Count == 0) return;

            vizcore3d.Object3D.Color.SetColor(BLOCK_NODES, Color.White);
        }

        private void backgroundWorkerTurnOver_DoWork(object sender, DoWorkEventArgs e)
        {
            ThreadParameter threadParam = (ThreadParameter)e.Argument;
            int count = threadParam.Angle;
            int waitTime = threadParam.AnimationOnly == true ? 100 : 0;

            for (int i = 0; i < count; i++)
            {
                if (backgroundWorkerTurnOver.CancellationPending == true)
                { 
                    e.Cancel = true;
                    return;
                }

                backgroundWorkerTurnOver.ReportProgress(i);

                System.Threading.Thread.Sleep(waitTime);
            }

            e.Result = count;
        }

        private void backgroundWorkerTurnOver_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int step = e.ProgressPercentage;

            if (backgroundWorkerTurnOver.CancellationPending == true) return;

            vizcore3d.BeginUpdate();
            vizcore3d.Object3D.Transform.Rotate(BLOCK_NODES, -1, 0, 0, false, false);

            // LUG1 - ROLLER1
            // LUG2 - ROLLER4
            vizcore3d.ShapeDrawing.Clear();
            vizcore3d.ShapeDrawing.DepthTest = true;

            bool find = false;

            if (DisplayAngle == true)
                vizcore3d.Review.Measure.Clear();

            for (int i = 0; i < 7; i++)
            {
                VIZCore3D.NET.Data.Node lug1 = LUG1[i + 1];
                VIZCore3D.NET.Data.Object3DProperty propLug1 = vizcore3d.Object3D.GeometryProperty.FromNode(lug1);

                VIZCore3D.NET.Data.Node roller1 = ROLLER1[i + 1];
                VIZCore3D.NET.Data.Object3DProperty propRoller1 = vizcore3d.Object3D.GeometryProperty.FromNode(roller1);


                VIZCore3D.NET.Data.Node lug2 = LUG2[i + 1];
                VIZCore3D.NET.Data.Object3DProperty propLug2 = vizcore3d.Object3D.GeometryProperty.FromNode(lug2);

                VIZCore3D.NET.Data.Node roller2 = ROLLER4[i + 1];
                VIZCore3D.NET.Data.Object3DProperty propRoller2 = vizcore3d.Object3D.GeometryProperty.FromNode(roller2);

                {
                    List<VIZCore3D.NET.Data.Vertex3DItemCollection> item1 = new List<Data.Vertex3DItemCollection>();
                    VIZCore3D.NET.Data.Vertex3DItemCollection coll1 = new Data.Vertex3DItemCollection();
                    coll1.Add(propLug1.CenterPoint);
                    coll1.Add(propRoller1.CenterPoint);
                    item1.Add(coll1);
                    vizcore3d.ShapeDrawing.AddLine(item1, i, Color.Black, 1, true);
                    //vizcore3d.ShapeDrawing.AddCylinder(item1, i, Color.Black, 10, true);
                }

                {
                    List<VIZCore3D.NET.Data.Vertex3DItemCollection> item2 = new List<Data.Vertex3DItemCollection>();
                    VIZCore3D.NET.Data.Vertex3DItemCollection coll2 = new Data.Vertex3DItemCollection();
                    coll2.Add(propLug2.CenterPoint);
                    coll2.Add(propRoller2.CenterPoint);
                    item2.Add(coll2);
                    vizcore3d.ShapeDrawing.AddLine(item2, i + 7, Color.Black, 1, true);
                    //vizcore3d.ShapeDrawing.AddCylinder(item2, i + 7, Color.Black, 10, true);
                }

                CollisionItem collision1 = new CollisionItem();
                CollisionItem collision2 = new CollisionItem();

                bool find1 = AddCollisionData(step, lug1.NodeName, roller1.NodeName, propLug1.CenterPoint, propRoller1.CenterPoint, "TOB #1", out collision1);
                bool find2 = AddCollisionData(step, lug2.NodeName, roller2.NodeName, propLug2.CenterPoint, propRoller2.CenterPoint, "TOB #2", out collision2);

                if (find1 == true || find2 == true) find = true;

                AddAngle(lug1, propLug1.CenterPoint, propRoller1.CenterPoint, find1 == true ? collision1 : null);
                AddAngle(lug2, propLug2.CenterPoint, propRoller2.CenterPoint, find2 == true ? collision2 : null);
            }

            vizcore3d.EndUpdate();

            if (find == true && StopTurnOver == true) backgroundWorkerTurnOver.CancelAsync();

            Application.DoEvents();
        }

        private bool AddCollisionData(int step, string lugName, string rollerName, VIZCore3D.NET.Data.Vertex3D lug, VIZCore3D.NET.Data.Vertex3D roller, string tag, out CollisionItem collisionItem)
        {
            collisionItem = new CollisionItem();

            if (AnimationOnly == true) return false;

            VIZCore3D.NET.Data.Vertex3D start = lug;
            VIZCore3D.NET.Data.Vertex3D finish = roller;
            VIZCore3D.NET.Data.Vertex3D offset = start.PointToPoint(finish, 200);

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            List<VIZCore3D.NET.Data.NearestObjectByAxisPoint> nearObjects
                = vizcore3d.GeometryUtility.GetNearestObjects(new List<int>() { 0 }, offset, finish, 0);

            sw.Stop();

            if (EnablePerformanceLog == true)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1} ms", tag, sw.ElapsedMilliseconds.ToString()));
                System.Diagnostics.Trace.WriteLine(string.Format("{0} : {1} ms", tag, sw.ElapsedMilliseconds.ToString()));
            }

            bool find = false;

            foreach (VIZCore3D.NET.Data.NearestObjectByAxisPoint item in nearObjects)
            {
                if (item.Index > 0 && ROLLER.ContainsKey(item.Index) == false)
                {
                    if (CollisionObjects.ContainsKey(item.Index) == false)
                    {
                        string nodePath = vizcore3d.Object3D.GetNodePath(item.Index);
                        if (nodePath.Contains("BLK") == true)
                        {
                            collisionItem.Set(item, lugName, rollerName, nodePath);

                            CollisionObjects.Add(item.Index, collisionItem);
                            find = true;

                            //System.Diagnostics.Trace.WriteLine("[TOB] Collision Block");
                        }
                    }
                }
            }

            return find;
        }

        private List<VIZCore3D.NET.Data.Vertex3D> GetCircleCenterPoint(VIZCore3D.NET.Data.Vertex3D center, List<VIZCore3D.NET.Data.CircleData> circles)
        {
            List<VIZCore3D.NET.Data.Vertex3D> items = new List<VIZCore3D.NET.Data.Vertex3D>();

            foreach (VIZCore3D.NET.Data.CircleData item in circles)
            {
                float distance = center.Distance(item.Center);

                if (distance > 50)
                {
                    VIZCore3D.NET.Data.Vertex3D normal = item.Center.GetNormalized(center);
                    VIZCore3D.NET.Data.Vertex3D v1 = center.PointToVector(normal, 100);
                    VIZCore3D.NET.Data.Vertex3D v2 = center.PointToVector(normal, -100);

                    items.Add(v1);
                    items.Add(v2);

                    break;
                }
            }

            return items.ToList();
        }

        private void AddAngle(VIZCore3D.NET.Data.Node lug, VIZCore3D.NET.Data.Vertex3D center, VIZCore3D.NET.Data.Vertex3D roller, CollisionItem collisionItem)
        {
            if (DisplayAngle == false) return;

            List<VIZCore3D.NET.Data.CircleData> circles = vizcore3d.GeometryUtility.GetCircleData(lug.Index);
            List<VIZCore3D.NET.Data.Vertex3D> circleCenter = GetCircleCenterPoint(center, circles);
            if (circleCenter.Count < 2) return;

            VIZCore3D.NET.Data.Vertex3D v1 = circleCenter[0];
            VIZCore3D.NET.Data.Vertex3D v2 = circleCenter[1];

            VIZCore3D.NET.Data.Vertex3D vLug1 = center.PointToPoint(v1, 500);
            VIZCore3D.NET.Data.Vertex3D vLug2 = center.PointToPoint(v2, 500);
            VIZCore3D.NET.Data.Vertex3D vRoller = center.PointToPoint(roller, 500);

            int mid1 = vizcore3d.Review.Measure.AddCustom3PointAngle(center, vRoller, vLug1);
            int mid2 = vizcore3d.Review.Measure.AddCustom3PointAngle(center, vRoller, vLug2);

            if (collisionItem != null)
            {
                collisionItem.Angle1 = vizcore3d.Review.Measure.GetItem(mid1).Title;
                collisionItem.Angle2 = vizcore3d.Review.Measure.GetItem(mid2).Title;
            }
        }

        private void backgroundWorkerTurnOver_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (AnimationOnly == false)
            {
                if (CollisionObjects.Keys.Count > 0)
                    vizcore3d.Object3D.Color.SetColor(CollisionObjects.Keys.ToList(), Color.Red);
                else
                    MessageBox.Show("Collision Objects is nothing.");
            }

            if (BLOCK_NODES.Count > 0)
            {
                VIZCore3D.NET.Data.Vertex3D center = vizcore3d.Object3D.GeometryProperty.FromNode(BLOCK_NODES).CenterPoint;
                vizcore3d.View.SetPivotPosition(center);
                vizcore3d.Update();
            }
        }

        private void btnTurnOverRun_Click(object sender, EventArgs e)
        {
            int angle = Convert.ToInt32(txtTurnOverAngle.Text);

            ThreadParameter threadParam = new ThreadParameter();
            threadParam.Angle = angle;
            threadParam.AnimationOnly = AnimationOnly;

            CollisionObjects = new Dictionary<int, CollisionItem>();

            AnimationOnly = ckAnimationOnly.Checked;
            StopTurnOver = ckStopTurnOver.Checked;
            DisplayAngle = ckDisplayAngle.Checked;

            backgroundWorkerTurnOver.WorkerReportsProgress = true;
            backgroundWorkerTurnOver.WorkerSupportsCancellation = true;

            backgroundWorkerTurnOver.RunWorkerAsync(threadParam);
        }

        private void btnReportDialog_Click(object sender, EventArgs e)
        {
            FrmReportDialog dlg = new FrmReportDialog(CollisionObjects.Values.ToList());
            dlg.ShowDialog();
        }
    }
}