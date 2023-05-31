using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.BayBlock
{
    public enum ViewKind
    {
        D2 = 0,
        D3 = 1
    }

    public partial class FrmMain : Form
    {
        // ================================================
        // Attribute & Property
        // ================================================
        /// <summary>
        /// VIZCore3D.NET
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;


        private OutlinePathDrawingControl DrawingControl;

        /// <summary>
        /// Mouse Down Position
        /// </summary>
        public System.Drawing.Point MousePt { get; set; }

        /// <summary>
        /// 선택 BLOCK 이동 거리
        /// </summary>
        public VIZCore3D.NET.Data.Vector3D BlockMovingDistance { get; set; }

        /// <summary>
        /// View Mouse Down
        /// </summary>
        public System.Drawing.Point ViewMouseDownPt { get; set; }
        /// <summary>
        /// View Mouse Move
        /// </summary>
        public System.Drawing.Point ViewMouseMovePt { get; set; }
        /// <summary>
        /// View Mouse Up
        /// </summary>
        public System.Drawing.Point ViewMouseUpPt { get; set; }

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

            // OutlinePath DrawingControl
            DrawingControl = new OutlinePathDrawingControl();
            DrawingControl.VIZCore = vizcore3d;
            DrawingControl.Dock = DockStyle.Fill;
            groupBox2.Controls.Add(DrawingControl);
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

            InitializeVIZCore3DCustomOption();
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
            // 블록::마우스 다운 이벤트
            vizcore3d.View.MouseBasedObjectMove.OnMouseDownEvent += MouseBasedObjectMove_OnMouseDownEvent;

            // 블록::마우스 이동 이벤트
            vizcore3d.View.MouseBasedObjectMove.OnMouseMoveEvent += MouseBasedObjectMove_OnMouseMoveEvent;

            // 블록::마우스 업 이벤트
            vizcore3d.View.MouseBasedObjectMove.OnMouseUpEvent += MouseBasedObjectMove_OnMouseUpEvent;

            // 블록:: 마우스 더블클릭 이벤트
            vizcore3d.View.MouseBasedObjectMove.OnMouseDoubleClickEvent += MouseBasedObjectMove_OnMouseDoubleClickEvent;

            // View Default Mouse Down
            vizcore3d.View.OnViewDefaultMouseDownEvent += View_OnViewDefaultMouseDownEvent;

            // View Default Mouse Move
            vizcore3d.View.OnViewDefaultMouseMoveEvent += View_OnViewDefaultMouseMoveEvent;

            // View Default Mouse Up
            vizcore3d.View.OnViewDefaultMouseUpEvent += View_OnViewDefaultMouseUpEvent;

            // Keyboard 방향키 모델 이동/회전
            vizcore3d.View.KeyboardBasedTransform.OnTransformEvent += KeyboardBasedTransform_OnTransformEvent;

            // Drag & Drop 이벤트
            vizcore3d.View.OnViewDragEnter += View_OnViewDragEnter;
            vizcore3d.View.OnViewDragOver += View_OnViewDragOver;
            vizcore3d.View.OnViewDragDrop += View_OnViewDragDrop;
            vizcore3d.View.OnViewDragLeave += View_OnViewDragLeave;


            // 개체 선택 (이전)
            vizcore3d.Object3D.OnObject3DSelecting += Object3D_OnObject3DSelecting;

            // 개체 선택 (이후)
            vizcore3d.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;

            // PreSelect
            vizcore3d.View.OnViewPreSelectLabelEvent += View_OnViewPreSelectLabelEvent;

            // Mouse Double Click Event
            vizcore3d.View.OnViewMouseDoubleClickEvent += View_OnViewMouseDoubleClickEvent;

            // Mouse Wheel Event
            //vizcore3d.View.OnViewDefaultMouseWheelEvent += View_OnViewDefaultMouseWheelEvent;

            vizcore3d.View.OnCameraStateChangedEvent += View_OnCameraStateChangedEvent;


            // Object Removed Event
            vizcore3d.Object3D.OnObject3DRemoved += Object3D_OnObject3DRemoved;
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
        // Function - Example
        // ================================================
        private void btnOpenModels_Click(object sender, EventArgs e)
        {
            lvModels.BeginUpdate();
            lvModels.Items.Clear();

            string basePath = "D:\\GitHub\\VIZCore3D.NET.BayBlock";

            if (System.IO.Directory.Exists(basePath) == true)
            {
                string[] dirs = System.IO.Directory.GetDirectories(basePath, "*.*", System.IO.SearchOption.TopDirectoryOnly);

                foreach (string dir in dirs)
                {
                    string name = new System.IO.DirectoryInfo(dir).Name;
                    string path = string.Format("{0}\\{1}\\{1}_SIMPLIFIED.viz", basePath, name);

                    if (System.IO.File.Exists(path) == false) continue;

                    ListViewItem lvi = new ListViewItem(new string[] { name });
                    lvi.Tag = path;

                    lvModels.Items.Add(lvi);
                }
            }
            else
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Multiselect = true;
                dlg.Filter = "VIZ Files (*.viz)|*.viz";

                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (string path in dlg.FileNames)
                    {
                        string name = System.IO.Path.GetFileNameWithoutExtension(path);

                        ListViewItem lvi = new ListViewItem(new string[] { name });
                        lvi.Tag = path;

                        lvModels.Items.Add(lvi);
                    }
                }
            }

            lvModels.EndUpdate();
        }

        private List<BlockOutlinePath> ProjectionItems { get; set; }

        private void btnBlockProjection_Click(object sender, EventArgs e)
        {
            int count = lvModels.Items.Count;

            ProjectionItems = new List<BlockOutlinePath>();

            for (int i = 0; i < count; i++)
            {
                ListViewItem lvi = lvModels.Items[i];
                string name = lvi.SubItems[0].Text;
                string path = (string)lvi.Tag;

                vizcore3d.Model.Close();
                vizcore3d.Model.Open(path);

                vizcore3d.View.MoveCamera(VIZCore3D.NET.Data.CameraDirection.Z_PLUS);

                VIZCore3D.NET.Data.Projection2D projection = vizcore3d.View.Get2DProjectionVertex(
                60          /* Scale이 클수록 Point의 범위가 줄어듬. 실제 모델의 축소 비율 */
                , false     /* True : 모든 형상의 데이터, False : 영역이 제일 큰 형상의 외곽 정보만 추출 */
                , 1         /* 투영 공간 개수. 범위(1~10). 1(빠르게 처리되지만 품질 보통) ~ 10(오래걸리지만 품질 높음) */
                , 1024      /* 투영 공간의 가로 길이. PX단위. 원격(혹은 콘솔) 모드에서는 1024만 가능 */
                , 1024      /* 투영 공간의 세로 길이. PX단위. 원격(혹은 콘솔) 모드에서는 1024만 가능 */
                , true      /* 2D 투영 포인트 좌표 보정 여부. True(XY평면좌표), False(투영결과좌표) */
                );

                if (projection == null) continue;

                VIZCore3D.NET.Data.BoundBox3D boundBox = projection.BoundBoxNode;
                //DrawingControl.AddItem(name, projection.PathGeometryString, boundBox.LengthY, boundBox.LengthX, boundBox.LengthZ);

                BlockOutlinePath item = new BlockOutlinePath(name, projection.PathGeometryString, boundBox.LengthY, boundBox.LengthX, boundBox.LengthZ, new Size(150, 150));
                ProjectionItems.Add(item);

                Application.DoEvents();

                if (i == 10)
                    break;
            }

            vizcore3d.Model.Close();
        }

        #region Function - VIZCore3D.NET : Custom Option
        private void InitializeVIZCore3DCustomOption()
        {
            // 마우스로 부재 중복 선택 시, 상위 모델 선택 차단
            vizcore3d.View.EnableParentSelection = false;

            // 마우스로 더블 클릭 활성화 (기본값:True)
            //vizcore3d.View.EnableDoubleClick = true;

            // 마우스로 부재 더블 클릭시, 화면 중심 이동 기능 차단
            vizcore3d.View.EnableDoubleClickFocusAndFit = false;

            // Assign Context Menu
            //vizcore3d.View.SetContextMenu(VIZCore3D.NET.Data.ViewContextMenuKind.NODE_SINGLE, contextMenu);

            // 키보드 이동/회전 지원
            vizcore3d.View.KeyboardBasedTransform.Enable = true;
            vizcore3d.View.KeyboardBasedTransform.Axis = VIZCore3D.NET.Data.AxisDirection.Z_PLUS;
            vizcore3d.View.KeyboardBasedTransform.Angle = 90.0f;
            vizcore3d.View.KeyboardBasedTransform.DetailAngle = 10.0f;
            vizcore3d.View.KeyboardBasedTransform.Distance = 1000.0f;
            vizcore3d.View.KeyboardBasedTransform.DetailDistance = 100.0f;
        }
        #endregion

        private void btnAddBay_Click(object sender, EventArgs e)
        {
            // New Empty Model
            int index = vizcore3d.Model.NewEmptyModel("BAY");

            string assemblyName = "BAY_ASSEMBLY";
            VIZCore3D.NET.Data.Node assemblyNode =
                vizcore3d.Structure.CreateNode(
                    index                                   /* Parent Node Index */
                    , VIZCore3D.NET.Data.NodeKind.ASSEMBLY  /* Node Kind */
                    , assemblyName                          /* Node Name */
                    );

            string partName = "BAY_PART";
            VIZCore3D.NET.Data.Node partNode =
                vizcore3d.Structure.CreateNode(
                    assemblyNode.Index                      /* Parent Node Index */
                    , VIZCore3D.NET.Data.NodeKind.PART      /* Node Kind */
                    , partName                              /* Node Name */
                    );

            string bodyName = "BAY_BODY";
            int bodyId =
                vizcore3d.Structure.CreateBody(
                    partNode.Index                          /* Parent Node Index */
                    , bodyName                              /* Node Name */
                    );

            int bodyIndex = vizcore3d.Object3D.GetBodyIndex(bodyId);

            {
                List<float> length = new List<float>() { 400000.0f, 300000.0f, 1000.0f };

                VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                matrix.Identity();

                vizcore3d.MeshEdit.AddPrimitiveBox(
                    bodyIndex           /* Body Node Index */
                    , length            /* Length */
                    , matrix            /* Matrix */
                    , Color.FromArgb(128, 128, 0)    /* Color */
                    , false             /* Rebuild Data */
                    , 1.0f              /* Scale */
                    );
            }

            vizcore3d.Structure.RebuildData();

            // 2D 뷰로 표시
            ChangeView(ViewKind.D2);

            DrawingControl.SetOutlineData(ProjectionItems);
        }

        private void Object3D_OnObject3DRemoved(object sender, VIZCore3D.NET.Event.EventManager.Object3DRemovedEventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.ASSEMBLY);

            int moving_group_id = 0;
            foreach (VIZCore3D.NET.Data.Node item in items)
            {
                if (item.NodeName == "새모델") continue;
                if (item.NodeName.Contains("BAY_") == true) continue;

                vizcore3d.View.MouseBasedObjectMove.Add(moving_group_id, item.Index);
                moving_group_id++;
            }

            vizcore3d.View.MouseBasedObjectMove.EnableMode(true);
        }

        private void View_OnViewMouseDoubleClickEvent(object sender, VIZCore3D.NET.Event.EventManager.ViewMouseDoubleClickEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(string.Format("NODE: {0} / Location: {1},{2}", e.NodeIndex, e.Location.X, e.Location.Y));
        }

        private void View_OnCameraStateChangedEvent(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.CameraData camera = vizcore3d.View.GetCameraData();

            System.Drawing.Size viewSize = vizcore3d.View.Size;

            VIZCore3D.NET.Data.Vertex3D leftTop = new VIZCore3D.NET.Data.Vertex3D(0.0f, 0.0f, 0.5f);
            VIZCore3D.NET.Data.Vertex3D rightBottom = new VIZCore3D.NET.Data.Vertex3D(viewSize.Width, viewSize.Height, 0.5f);
            VIZCore3D.NET.Data.Vertex3D world1 = vizcore3d.View.ScreenToWorld(leftTop, false);
            VIZCore3D.NET.Data.Vertex3D world2 = vizcore3d.View.ScreenToWorld(rightBottom, false);

            float worldWidth = Math.Abs(world2.X - world1.X); //화면 전체의 World 좌표계의 거리
            float worldHeight = Math.Abs(world2.Y - world1.Y);

            float wMax = Math.Max(worldWidth, worldHeight);
            float currentBlockZoom = wMax;

            DrawingControl.SetItemDrawingRatio(
                camera.Zoom
                , new SizeF(worldWidth, worldHeight)
                , new Size(viewSize.Width, viewSize.Height)
                );
        }

        private void MouseBasedObjectMove_OnMouseDownEvent(object sender, VIZCore3D.NET.Event.EventManager.MouseBaseObjectMoveEventArgs e)
        {
            string str = string.Format("Mouse Down : {0} / {1} / {2} / {3} / {4} / {5} / {6}"
                , e.MoveOption.ToString()
                , e.GroupId
                , e.Move.ToString()
                , e.Anlge
                , e.MousePosition.X
                , e.MousePosition.Y
                , e.Node.Count()
                );

            System.Diagnostics.Debug.WriteLine(str);

            // Mouse Down 위치 백업
            MousePt = e.MousePosition;

            // 선택 BLOCK 위치
            BlockMovingDistance = new VIZCore3D.NET.Data.Vector3D(0, 0, 0);
        }

        private void MouseBasedObjectMove_OnMouseMoveEvent(object sender, VIZCore3D.NET.Event.EventManager.MouseBaseObjectMoveEventArgs e)
        {
            string str = string.Format("Mouse Move : {0} / {1} / {2} / {3} / {4} / {5} / {6}"
                , e.MoveOption.ToString()
                , e.GroupId
                , e.Move.ToString()
                , e.Anlge
                , e.MousePosition.X
                , e.MousePosition.Y
                , e.Node.Count()
                );

            System.Diagnostics.Debug.WriteLine(str);

            // 뷰 외부로 개체를 Drag 하는 경우...
            string contailed = string.Format("--> Contain Mouse : {0}", e.IsContainedPosition() == true ? "Contained" : "NG");
            System.Diagnostics.Debug.WriteLine(contailed);

            // 배치 블록 -> 미배치 블록
            // 마우스 위치가 뷰 영역을 벗어난 경우를 체크
            if (e.IsContainedPosition() == false)
            {
                e.Cancel = true;

                List<int> selectedItem = new List<int>();
                if (e.GroupsId.Count != 1)
                {
                    foreach (int groupNode in e.GroupsId)
                    {
                        selectedItem.AddRange(vizcore3d.View.MouseBasedObjectMove.GetGroupNode(groupNode));
                    }
                }
                else
                {
                    selectedItem.Add(e.Node[0]);
                }

                // Item Drag Drop
                DoDragDrop(selectedItem, DragDropEffects.Copy);

                return;
            }

            // 마우스로 회전일 경우는 중단
            if (e.MoveOption == VIZCore3D.NET.Manager.MouseBasedObjectMoveManager.MovingOptions.ROTATION) return;

            vizcore3d.BeginUpdate();
            for (int i = 0; i < e.GroupsId.Count; i++)
            {
                // 현재 이동되는 개체의 연계된 리뷰 정보(아이디) 조회
                List<int> review = vizcore3d.View.MouseBasedObjectMove.GetLinkedReview(e.GroupsId[i]);
                if (review.Count == 0) break;

                // 해당 리뷰(노트)의 정보 조회
                VIZCore3D.NET.Data.NoteItem note = vizcore3d.Review.Note.GetItem(review[0]);

                // 해당 리뷰(노트)의 위치 정보 조회
                List<VIZCore3D.NET.Data.ReviewPosition> position = note.Position;

                // 마우스가 이동한 거리만큼 리뷰의 위치를 재설정
                note.UpdatePosition(position[0], position[0].Position + e.Move);

                // BLOCK 이동 거리 누적
                if (i == 0)
                    BlockMovingDistance = BlockMovingDistance + e.Move;
            }

            vizcore3d.EndUpdate();
        }

        private void MouseBasedObjectMove_OnMouseUpEvent(object sender, VIZCore3D.NET.Event.EventManager.MouseBaseObjectMoveEventArgs e)
        {
            string str = string.Format("Mouse Up : {0} / {1} / {2} / {3} / {4} / {5} / {6}"
                , e.MoveOption.ToString()
                , e.GroupId
                , e.Move.ToString()
                , e.Anlge
                , e.MousePosition.X
                , e.MousePosition.Y
                , e.Node.Count()
                );

            System.Diagnostics.Debug.WriteLine(str);

            // Case 1
            /*
            vizcore3d.BeginUpdate();

            List<VIZCore3D.NET.Data.NearestObjectByAxisPoint> items = vizcore3d.GeometryUtility.GetNearestObjects(e.MousePosition.X, e.MousePosition.Y, true, false);

            // 빈공간에 블록을 놓은 경우
            if (items.Count == 1)
            {
                for (int i = 0; i < e.GroupsId.Count; i++)
                {
                    // 현재 이동되는 개체의 연계된 리뷰 정보(아이디) 조회
                    List<int> review = vizcore3d.View.MouseBasedObjectMove.GetLinkedReview(e.GroupsId[i]);
                    if (review.Count == 0) return;

                    // 해당 리뷰(노트)의 정보 조회
                    VIZCore3D.NET.Data.NoteItem note = vizcore3d.Review.Note.GetItem(review[0]);

                    vizcore3d.Review.Show(review, true);

                    // 해당 리뷰(노트)의 위치 정보 조회
                    List<VIZCore3D.NET.Data.ReviewPosition> position = note.Position;

                    // 원래 이동전 위치로 이동
                    vizcore3d.Object3D.Transform.Move(
                        vizcore3d.View.MouseBasedObjectMove.GetGroupNode(e.GroupsId[i]).ToArray()
                        , -BlockMovingDistance.X
                        , -BlockMovingDistance.Y
                        , -BlockMovingDistance.Z
                        , false
                        );

                    VIZCore3D.NET.Data.Vertex3D center = vizcore3d.Object3D.GeometryProperty.FromIndex(vizcore3d.View.MouseBasedObjectMove.GetGroupNode(e.GroupsId[i])[0], false).CenterPoint;

                    // 마우스가 이동한 거리만큼 리뷰의 위치를 재설정
                    note.UpdatePosition(position[0], center);
                }
            }
            // 위치에 놓은 경우
            else
            {
                for (int i = 0; i < e.GroupsId.Count; i++)
                {
                    // 현재 이동되는 개체의 연계된 리뷰 정보(아이디) 조회
                    List<int> review = vizcore3d.View.MouseBasedObjectMove.GetLinkedReview(e.GroupsId[i]);
                    if (review.Count == 0) return;

                    // 해당 리뷰(노트)의 정보 조회
                    VIZCore3D.NET.Data.NoteItem note = vizcore3d.Review.Note.GetItem(review[0]);

                    vizcore3d.Review.Show(review, true);

                    // 해당 리뷰(노트)의 위치 정보 조회
                    List<VIZCore3D.NET.Data.ReviewPosition> position = note.Position;

                    // 마우스가 이동한 거리만큼 리뷰의 위치를 재설정
                    note.UpdatePosition(position[0], position[0].Position + new VIZCore3D.NET.Data.Vertex3D(BlockMovingDistance.X, BlockMovingDistance.Y, BlockMovingDistance.Z));
                }
            }

            vizcore3d.EndUpdate();
            */

            // Case 2
            vizcore3d.BeginUpdate();

            // 단일블록 처리
            if (e.GroupsId.Count == 1)
            {
                #region 단일 블록 처리
                List<VIZCore3D.NET.Data.NearestObjectByAxisPoint> items = vizcore3d.GeometryUtility.GetNearestObjects(e.MousePosition.X, e.MousePosition.Y, true, false);

                // 빈공간에 블록을 놓은 경우
                if (items.Count == 1)
                {
                    for (int i = 0; i < e.GroupsId.Count; i++)
                    {
                        // 현재 이동되는 개체의 연계된 리뷰 정보(아이디) 조회
                        List<int> review = vizcore3d.View.MouseBasedObjectMove.GetLinkedReview(e.GroupsId[i]);
                        if (review.Count == 0) return;

                        // 해당 리뷰(노트)의 정보 조회
                        VIZCore3D.NET.Data.NoteItem note = vizcore3d.Review.Note.GetItem(review[0]);

                        //vizcore3d.Review.Show(review, true);

                        // 해당 리뷰(노트)의 위치 정보 조회
                        List<VIZCore3D.NET.Data.ReviewPosition> position = note.Position;

                        // 원래 이동전 위치로 이동
                        vizcore3d.Object3D.Transform.Move(
                            vizcore3d.View.MouseBasedObjectMove.GetGroupNode(e.GroupsId[i]).ToArray()
                            , -BlockMovingDistance.X
                            , -BlockMovingDistance.Y
                            , -BlockMovingDistance.Z
                            , false
                            );

                        VIZCore3D.NET.Data.Vertex3D center = vizcore3d.Object3D.GeometryProperty.FromIndex(vizcore3d.View.MouseBasedObjectMove.GetGroupNode(e.GroupsId[i])[0], false).CenterPoint;

                        // 마우스가 이동한 거리만큼 리뷰의 위치를 재설정
                        note.UpdatePosition(position[0], center);
                    }
                }
                // 위치에 놓은 경우
                else
                {
                    for (int i = 0; i < e.GroupsId.Count; i++)
                    {
                        // 현재 이동되는 개체의 연계된 리뷰 정보(아이디) 조회
                        //List<int> review = vizcore3d.View.MouseBasedObjectMove.GetLinkedReview(e.GroupsId[i]);
                        //if (review.Count == 0) return;

                        // 해당 리뷰(노트)의 정보 조회
                        //VIZCore3D.NET.Data.NoteItem note = vizcore3d.Review.Note.GetItem(review[0]);

                        //vizcore3d.Review.Show(review, true);

                        // 해당 리뷰(노트)의 위치 정보 조회
                        //List<VIZCore3D.NET.Data.ReviewPosition> position = note.Position;

                        // 마우스가 이동한 거리만큼 리뷰의 위치를 재설정
                        //note.UpdatePosition(position[0], position[0].Position + new VIZCore3D.NET.Data.Vertex3D(BlockMovingDistance.X, BlockMovingDistance.Y, BlockMovingDistance.Z));
                    }
                }
                #endregion
            }
            // 복수블록 처리
            else
            {
                foreach (int groupId in e.GroupsId)
                {
                    // 그룹아이디의 해당하는 노드 인덱스
                    List<int> nodeIndex = vizcore3d.View.MouseBasedObjectMove.GetGroupNode(groupId);

                    // 모델 정보
                    VIZCore3D.NET.Data.Object3DProperty prop = vizcore3d.Object3D.GeometryProperty.FromIndex(nodeIndex[0]);
                    // 모델 중심점
                    VIZCore3D.NET.Data.Vertex3D geoCenter = prop.CenterPoint;
                    // 화면 좌표
                    VIZCore3D.NET.Data.Vertex3D screen = vizcore3d.View.WorldToScreen(geoCenter, true);

                    // 충돌 부재 검사
                    List<VIZCore3D.NET.Data.NearestObjectByAxisPoint> nearItems = vizcore3d.GeometryUtility.GetNearestObjects(
                        Convert.ToInt32(screen.X)
                        , Convert.ToInt32(screen.Y)
                        , true
                        , false
                        );

                    // 빈공간에 블록을 놓은 경우
                    if (nearItems.Count == 1)
                    {
                        // 현재 이동되는 개체의 연계된 리뷰 정보(아이디) 조회
                        List<int> review = vizcore3d.View.MouseBasedObjectMove.GetLinkedReview(groupId);
                        if (review.Count == 0) return;

                        // 해당 리뷰(노트)의 정보 조회
                        VIZCore3D.NET.Data.NoteItem note = vizcore3d.Review.Note.GetItem(review[0]);

                        //vizcore3d.Review.Show(review, true);

                        // 해당 리뷰(노트)의 위치 정보 조회
                        List<VIZCore3D.NET.Data.ReviewPosition> position = note.Position;

                        // 원래 이동전 위치로 이동
                        vizcore3d.Object3D.Transform.Move(
                            nodeIndex.ToArray()
                            , -BlockMovingDistance.X
                            , -BlockMovingDistance.Y
                            , -BlockMovingDistance.Z
                            , false
                            );

                        // 마우스가 이동한 거리만큼 리뷰의 위치를 재설정
                        note.UpdatePosition(position[0], geoCenter - BlockMovingDistance);
                    }
                    else
                    {
                        // 현재 이동되는 개체의 연계된 리뷰 정보(아이디) 조회
                        //List<int> review = vizcore3d.View.MouseBasedObjectMove.GetLinkedReview(groupId);
                        //if (review.Count == 0) return;

                        // 해당 리뷰(노트)의 정보 조회
                        //VIZCore3D.NET.Data.NoteItem note = vizcore3d.Review.Note.GetItem(review[0]);

                        //vizcore3d.Review.Show(review, true);

                        // 해당 리뷰(노트)의 위치 정보 조회
                        //List<VIZCore3D.NET.Data.ReviewPosition> position = note.Position;

                        // 마우스가 이동한 거리만큼 리뷰의 위치를 재설정
                        //note.UpdatePosition(position[0], position[0].Position + new VIZCore3D.NET.Data.Vertex3D(BlockMovingDistance.X, BlockMovingDistance.Y, BlockMovingDistance.Z));
                    }
                }
            }

            vizcore3d.EndUpdate();

            BlockMovingDistance = new VIZCore3D.NET.Data.Vector3D();

            vizcore3d.Object3D.Select(VIZCore3D.NET.Data.Object3dSelectionModes.DESELECT_ALL);
        }

        private void MouseBasedObjectMove_OnMouseDoubleClickEvent(object sender, VIZCore3D.NET.Event.EventManager.MouseBaseObjectMoveEventArgs e)
        {
            string str = string.Format("Mouse DoubleClick : {0} / {1} / {2} / {3} / {4} / {5} / {6}"
                , e.MoveOption.ToString()
                , e.GroupId
                , e.Move.ToString()
                , e.Anlge
                , e.MousePosition.X
                , e.MousePosition.Y
                , e.Node.Count()
                );

            System.Diagnostics.Debug.WriteLine(str);

            List<VIZCore3D.NET.Data.NearestObjectByAxisPoint> items = vizcore3d.GeometryUtility.GetNearestObjects(e.MousePosition.X, e.MousePosition.Y, true, false);
            if (items.Count == 0) return;

            vizcore3d.Object3D.Transform.Rotate(e.Node.ToArray(), 0, 0, 90, false, false);
        }

        private void KeyboardBasedTransform_OnTransformEvent(object sender, VIZCore3D.NET.Event.EventManager.KeyboardBasedObjectTransformEventArgs e)
        {
            // 회전은 처리하지 않음
            if (e.Distance == null) return;

            int groupId = vizcore3d.View.MouseBasedObjectMove.GetGroupId(e.Node[0].Index);
            if (groupId == -1) return;

            // 현재 이동되는 개체의 연계된 리뷰 정보(아이디) 조회
            List<int> review = vizcore3d.View.MouseBasedObjectMove.GetLinkedReview(groupId);
            if (review.Count == 0) return;

            // 해당 리뷰(노트)의 정보 조회
            VIZCore3D.NET.Data.NoteItem note = vizcore3d.Review.Note.GetItem(review[0]);

            // 해당 리뷰(노트)의 위치 정보 조회
            List<VIZCore3D.NET.Data.ReviewPosition> position = note.Position;

            // 마우스가 이동한 거리만큼 리뷰의 위치를 재설정
            note.UpdatePosition(position[0], position[0].Position + e.Distance);

            // BLOCK 이동 거리 누적
            BlockMovingDistance = BlockMovingDistance + e.Distance;
        }

        private void View_OnViewDragEnter(object sender, VIZCore3D.NET.Event.EventManager.ViewDragDropEventArgs e)
        {
            object dragItem = e.DragItem;
            int x = e.X;
            int y = e.Y;

            //vizcore3d.View.MouseBasedObjectMove.UpdateMoveBase(x, y, false); //이전 형상 Update 

            //외부에서 Drag로 들어왔을경우 1회만 호출하도록
            if (!DrawingControl.ItemDragState) return;
            if (DrawingControl.ItemDragViewDrawingEnter) return;
            DrawingControl.ItemDragViewDrawingEnter = true;

            // 마우스 개체 이동상태 목록 제거
            vizcore3d.View.MouseBasedObjectMove.ClearMove();

            string name = DrawingControl.SelectedItem.GetLabel();

            if ((dragItem is ListViewItem) == true)
            {
                ListViewItem lvi = (ListViewItem)dragItem;
                name = lvi.SubItems[0].Text;
            }

            if (string.IsNullOrEmpty(name)) return;
            //VIZCore3D.NET.Data.Vertex3D position = nearest[0].CollisionPoint;
            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(new List<string> { name }, false, true, false, false, true, false);
            if (nodes.Count == 0)
            {
                //MessageBox.Show("No Found.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Mouse 기반 강제 등록
            vizcore3d.BeginUpdate();
            e.DragItem = nodes;

            int movingGroupId = vizcore3d.View.MouseBasedObjectMove.GetGroupId(nodes[0].Index);
            List<int> reviewId = vizcore3d.View.MouseBasedObjectMove.GetLinkedReview(movingGroupId);

            vizcore3d.Object3D.Show(nodes, true);
            vizcore3d.Review.Note.Show(new List<int> { reviewId[0] }, true);

            vizcore3d.View.MouseBasedObjectMove.AddMove(nodes[0], true);

            vizcore3d.View.MouseBasedObjectMove.UpdateMoveBase(x, y, true);

            VIZCore3D.NET.Data.NoteItem note = vizcore3d.Review.Note.GetItem(reviewId[0]);
            VIZCore3D.NET.Data.Vertex3D position = nodes[0].GetGeometryProperty().GetBoundBox().GetCenter();
            note.UpdatePosition(note.Position[0], position);

            vizcore3d.EndUpdate();
        }

        private void View_OnViewDragOver(object sender, VIZCore3D.NET.Event.EventManager.ViewDragDropEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            vizcore3d.View.MouseBasedObjectMove.UpdateMove(e.X, e.Y);
        }

        private void View_OnViewDragLeave(object sender, EventArgs e)
        {

        }

        private void View_OnViewDragDrop(object sender, VIZCore3D.NET.Event.EventManager.ViewDragDropEventArgs e)
        {
            // 마우스 개체 이동상태 목록 제거
            vizcore3d.View.MouseBasedObjectMove.ClearMove();

            object dragItem = e.DragItem;
            int x = e.X;
            int y = e.Y;

            {
                string name = DrawingControl.SelectedItem.GetLabel();
                if (string.IsNullOrEmpty(name)) return;

                List<VIZCore3D.NET.Data.NearestObjectByAxisPoint> nearest = vizcore3d.GeometryUtility.GetNearestObjects(x, y);

                if (nearest.Count <= 0)
                {
                    MessageBox.Show("No Model.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nearest.Count <= 0)
                {
                    MessageBox.Show("No Picked.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                VIZCore3D.NET.Data.Vertex3D position = nearest[0].CollisionPoint;

                List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(new List<string> { name }, false, true, false, false, true, false);
                if (nodes.Count == 0)
                {
                    MessageBox.Show("No Found.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int movingGroupId = vizcore3d.View.MouseBasedObjectMove.GetGroupId(nodes[0].Index);
                List<int> reviewId = vizcore3d.View.MouseBasedObjectMove.GetLinkedReview(movingGroupId);

                if (reviewId.Count == 0) return;

                vizcore3d.BeginUpdate();

                //vizcore3d.Object3D.Show(nodes, true);
                //vizcore3d.Review.Note.Show(new List<int> { reviewId[0] }, true);
                //
                //VIZCore3D.NET.Data.Vertex3D center
                //    = vizcore3d.Object3D.GeometryProperty.FromIndex(nodes[0].Index).CenterPoint;
                //
                //vizcore3d.Object3D.Transform.Move(
                //    nodes
                //    , new VIZCore3D.NET.Data.Vector3D(position.X - center.X, position.Y - center.Y, 0)
                //    , false
                //    );

                VIZCore3D.NET.Data.NoteItem note = vizcore3d.Review.Note.GetItem(reviewId[0]);
                note.UpdatePosition(note.Position[0], position);

                vizcore3d.EndUpdate();
            }

            vizcore3d.Object3D.Select(VIZCore3D.NET.Data.Object3dSelectionModes.DESELECT_ALL);
        }

        private void ChangeView(ViewKind viewMode, bool fit = true)
        {
            if (viewMode == ViewKind.D2)
            {
                vizcore3d.View.RotateCamera(VIZCore3D.NET.Data.ShipbuildingCameraDirection.TOP);
                vizcore3d.View.Navigation = VIZCore3D.NET.Data.NavigationModes.PAN;
                if (fit == true) vizcore3d.View.FitToView();

                // 지정된 개체를 대상으로 마우스로 이동 동작이 수행가능하도록 설정
                vizcore3d.View.MouseBasedObjectMove.EnableMode(true, VIZCore3D.NET.Manager.MouseBasedObjectMoveManager.MovingOptions.MOVE);

                // 지정된 개체를 대상으로 키보드 방향키로 이동/회전하는 동작 활성화
                vizcore3d.View.KeyboardBasedTransform.Enable = true;

                // 2D 경우, Grid Line Depth Test
                vizcore3d.ShapeDrawing.DepthTest = true;

                // 바닥면 카메라 회전 차단 해제
                vizcore3d.Walkthrough.LockZAxisAngleRange = false;

                // Mouse Input Preset
                vizcore3d.View.SetMouseInputPreset(VIZCore3D.NET.Data.MouseInputPreset.CUSTOM_2D_MODE);
            }
            else
            {
                vizcore3d.View.Navigation = VIZCore3D.NET.Data.NavigationModes.ROTATE;
                if (fit == true) vizcore3d.View.ResetView();

                // 3D 모드에서는 블록이동 금지
                vizcore3d.View.MouseBasedObjectMove.EnableMode(false, VIZCore3D.NET.Manager.MouseBasedObjectMoveManager.MovingOptions.MOVE);

                // 지정된 개체를 대상으로 키보드 방향키로 이동/회전하는 동작 비활성화
                vizcore3d.View.KeyboardBasedTransform.Enable = false;

                // 3D 경우, Grid Line Depth Test
                vizcore3d.ShapeDrawing.DepthTest = true;

                // 바닥면 카메라 회전 차단
                vizcore3d.Walkthrough.LockZAxisAngleRange = true;

                // Mouse Input Preset
                vizcore3d.View.SetMouseInputPreset(VIZCore3D.NET.Data.MouseInputPreset.CUSTOM_3D_MODE);
            }
        }

        private void View_OnViewDefaultMouseDownEvent(object sender, MouseEventArgs e)
        {
            // Backup Mouse Location
            ViewMouseDownPt = e.Location;
        }

        private void View_OnViewDefaultMouseMoveEvent(object sender, MouseEventArgs e)
        {
            // Backup Mouse Location
            ViewMouseMovePt = e.Location;
        }

        private void View_OnViewDefaultMouseUpEvent(object sender, MouseEventArgs e)
        {
            // Backup Mouse Location
            ViewMouseUpPt = e.Location;
        }

        private void Object3D_OnObject3DSelecting(object sender, VIZCore3D.NET.Event.EventManager.Object3DSelectingEventArgs e)
        {
            if (e.Node.NodeName.Contains("BAY") == true)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void Object3D_OnObject3DSelected(object sender, VIZCore3D.NET.Event.EventManager.Object3DSelectedEventArgs e)
        {
            if (e.Node.Count != 0)
                System.Diagnostics.Trace.WriteLine(string.Format("Selected : {0}", e.Node[0].Index));
        }

        private void View_OnViewPreSelectLabelEvent(object sender, VIZCore3D.NET.Event.EventManager.ViewPreSelectLabelEventArgs e)
        {
            e.Cancel = true;

            VIZCore3D.NET.Data.Node node = vizcore3d.Object3D.FromIndex(e.NodeIndex);

            if (node.NodeName.Contains("BLOCK_INFO_") == false)
            {
                e.Label = String.Empty;
                return;
            }

            Color color = node.GetColor();

            e.Label = string.Format("{0}\r\n\r\nR : {1}\r\nG : {2}\r\nB : {3}", node.NodeName, color.R, color.G, color.B);
        }

        public VIZCore3D.NET.Data.NoteStyle GetNoteStyle()
        {
            VIZCore3D.NET.Data.NoteStyle style = vizcore3d.Review.Note.GetStyle();
            style.BackgroudTransparent = true;
            //style.BackgroudTransparent = false;
            //style.BackgroundColor = Color.Yellow;
            //style.UseTextBox = true;
            //style.TextBoxLineColor = Color.Black;

            return style;
        }

        private void btnAddBlock_Click(object sender, EventArgs e)
        {
            int count = lvModels.Items.Count;

            VIZCore3D.NET.Data.NoteStyle style = GetNoteStyle();

            List<string> files = new List<string>();
            for (int i = 0; i < count; i++)
            {
                ListViewItem lvi = lvModels.Items[i];
                string name = lvi.SubItems[0].Text;
                string path = (string)lvi.Tag;

                files.Add(path);
            }

            vizcore3d.BeginUpdate();

            /*
            System.Collections.Concurrent.ConcurrentBag<VIZCore3D.NET.Data.StreamData> stream = new System.Collections.Concurrent.ConcurrentBag<VIZCore3D.NET.Data.StreamData>();
            System.Threading.Tasks.Parallel.ForEach(files.ToArray(), (currentItem) =>
            {
                VIZCore3D.NET.Data.StreamData data = new VIZCore3D.NET.Data.StreamData();
                string name = System.IO.Path.GetFileNameWithoutExtension(currentItem);
                name = name.Replace("_SIMPLIFIED", "");
                name = string.Format("0000-{0}", name);

                data.ModelName = name;
                data.Stream = System.IO.File.ReadAllBytes(currentItem);

                stream.Add(data);
            });
            */

            List<VIZCore3D.NET.Data.StreamData> stream = new List<VIZCore3D.NET.Data.StreamData>();
            for (int i = 0; i < files.Count; i++)
            {
                VIZCore3D.NET.Data.StreamData data = new VIZCore3D.NET.Data.StreamData();
                string name = System.IO.Path.GetFileNameWithoutExtension(files[i]);
                name = name.Replace("_SIMPLIFIED", "");
                name = string.Format("0000-{0}", name);

                data.ModelName = name;
                data.Stream = System.IO.File.ReadAllBytes(files[i]);

                stream.Add(data);
            }

            vizcore3d.Model.AddStream(stream.ToList());

            float bowHeight = vizcore3d.Walkthrough.AvatarBowWalkHeight; // 아바타 숙임 높이

            for (int i = 0; i < files.Count; i++)
            {
                string name = stream[i].ModelName;
                List<VIZCore3D.NET.Data.Node> node = vizcore3d.Object3D.Find.QuickSearch(
                    new List<string>() { name }
                    , false
                    , true
                    , false
                    , false
                    , true
                    , false
                    );

                if (node.Count == 0) continue;

                // Matrix 설정
                /*
                string jigMatrix = "1,0,0,0,0,1,0,0,0,0,1,0,188370,-22350,0,1";
                VIZCore3D.NET.Data.Matrix3D matrix = VIZCore3D.NET.Data.Matrix3D.FromString(jigMatrix);
                */

                /*
                string[] vals = name.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                VIZCore3D.NET.Data.Matrix3D matrix = GetMatrix(vals[0], vals[1]);
                node[0].Transform(matrix);
                */

                // 마우스로 이동할 대상 추가
                vizcore3d.View.MouseBasedObjectMove.Add(i, node[0].Index);

                // 모델의 중심에 3D 노트 추가
                VIZCore3D.NET.Data.Object3DProperty prop = vizcore3d.Object3D.GeometryProperty.FromIndex(node[0].Index);

                //회전된 aabb 정렬 모델중심구하기
                List<VIZCore3D.NET.Data.Vertex3D> aabboxVertex = vizcore3d.Review.Measure.GetBoundBoxVertex(new List<int>() { node[0].Index }).VertexItems;
                VIZCore3D.NET.Data.Vector3D vMin = new VIZCore3D.NET.Data.Vector3D(), vMax = new VIZCore3D.NET.Data.Vector3D();
                for (int k = 0; k < aabboxVertex.Count; k++)
                {
                    if (k == 0)
                    {
                        vMin = aabboxVertex[k].ToVector3D();
                        vMax = aabboxVertex[k].ToVector3D();
                    }
                    else
                    {
                        vMin.Min(aabboxVertex[k].ToVector3D());
                        vMax.Max(aabboxVertex[k].ToVector3D());
                    }
                }

                VIZCore3D.NET.Data.Vector3D vCenter = (vMax + vMin) / 2.0f;

                float ptZ = ((vMax.Z - vMin.Z) * 0.5f) + bowHeight - vCenter.Z;

                vizcore3d.Object3D.Transform.Move(new List<int>() { node[0].Index }.ToArray(), 0.0f, 0.0f, ptZ, false);

                prop = vizcore3d.Object3D.GeometryProperty.FromIndex(node[0].Index);
                int noteId = vizcore3d.Review.Note.AddNote3D(name, prop.CenterPoint, style);


                // 3D 노트가 사용자로부터 선택이 되지 않도록 설정
                vizcore3d.Review.AllowSelection(noteId, false);

                // 3D 노트 DepthTest : 모델에 가려지면 노트 숨기는 옵션
                //vizcore3d.Review.Note.EnableDepthTest(noteId, true);

                // 마우스로 이동대상 그룹과 리뷰 아이디 연계
                vizcore3d.View.MouseBasedObjectMove.LinkReview(i, noteId);

                vizcore3d.Object3D.Color.SetColor(new List<int>() { node[0].Index }, Color.LightGray);

                // 숨김
                vizcore3d.Object3D.Show(new List<int> { node[0].Index }, false);
                vizcore3d.Review.Note.Show(new List<int> { noteId }, false);
            }

            // 지정된 개체를 대상으로 마우스로 이동 동작이 수행가능하도록 설정
            vizcore3d.View.MouseBasedObjectMove.EnableMode(true, VIZCore3D.NET.Manager.MouseBasedObjectMoveManager.MovingOptions.MOVE);

            vizcore3d.EndUpdate();
        }
    }
}
