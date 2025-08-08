using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.UnfoldBlock
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


        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            vizcore3d = new VIZCore3DControl();

            vizcore3d.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(vizcore3d);

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
        // Function
        // ================================================
        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\Models\\VIZCore3D.NET.MoveWithMouse", vizcore3d.GetEntryAssemblyPath());
            //string path = string.Format("{0}\\Models\\VIZCore3D.NET.GridThreeD\\GRID", vizcore3d.GetEntryAssemblyPath());

            if (System.IO.Directory.Exists(path) == false) return;

            string[] files = System.IO.Directory.GetFiles(path, "*.viz");

            vizcore3d.Model.Close();
            vizcore3d.Model.Add(files);
        }

        public Dictionary<string, VIZCore3D.NET.Data.Node> Blocks { get; set; }

        private void btnUnfold_Click(object sender, EventArgs e)
        {
            Unfold_Case1();
            //Unfold_Case2();
        }

        private void Unfold_Case1()
        {
            // F71, F72, F73, H11, H12, H13, H14, H15, H16

            // A41, A42, E41, E42, E43, F41, F42, S41, S42, S43
            // A31, A32, E31, E32, E33, F12, F31, S31, S32, S33
            // A21, A22, A23, E21, E23, F21, S21, S22, S23
            // A11, B11, B12, B13, E11, E12, E13, E14, F11

            // H22, H23, H24, M11
            // H31, H32, H33, H34
            // H41, H42, H43, H44
            // H51, M12

            Blocks = new Dictionary<string, VIZCore3D.NET.Data.Node>();

            List<VIZCore3D.NET.Data.Node> children = vizcore3d.Object3D.FromIndex(0)
                .GetChildObject3d(VIZCore3D.NET.Data.Object3DChildOption.CHILD_ONLY);

            foreach (VIZCore3D.NET.Data.Node item in children)
            {
                if (Blocks.ContainsKey(item.NodeName) == false)
                    Blocks.Add(item.NodeName, item);
            }

            float lengthY = vizcore3d.Model.BoundBox.LengthY;

            vizcore3d.BeginUpdate();

            // F71, F72, F73, H11, H12, H13, H14, H15, H16
            MoveAxisY("F71", lengthY, 0);
            MoveAxisY("F72", lengthY, 0);
            MoveAxisY("F73", lengthY, 0);
            MoveAxisY("H11", lengthY, 0);
            MoveAxisY("H12", lengthY, 0);
            MoveAxisY("H13", lengthY, 0);
            MoveAxisY("H14", lengthY, 0);
            MoveAxisY("H15", lengthY, 0);
            MoveAxisY("H16", lengthY, 0);

            // A41, A42, E41, E42, E43, F41, F42, S41, S42, S43
            MoveAxisY("A41", lengthY, -1);
            MoveAxisY("A42", lengthY, -1);
            MoveAxisY("E41", lengthY, -1);
            MoveAxisY("E42", lengthY, -1);
            MoveAxisY("E43", lengthY, -1);
            MoveAxisY("F41", lengthY, -1);
            MoveAxisY("F42", lengthY, -1);
            MoveAxisY("S41", lengthY, -1);
            MoveAxisY("S42", lengthY, -1);
            MoveAxisY("S43", lengthY, -1);

            // A31, A32, E31, E32, E33, F12, F31, S31, S32, S33
            MoveAxisY("A31", lengthY, -2);
            MoveAxisY("A32", lengthY, -2);
            MoveAxisY("E31", lengthY, -2);
            MoveAxisY("E32", lengthY, -2);
            MoveAxisY("E33", lengthY, -2);
            MoveAxisY("F12", lengthY, -2);
            MoveAxisY("F31", lengthY, -2);
            MoveAxisY("S31", lengthY, -2);
            MoveAxisY("S32", lengthY, -2);
            MoveAxisY("S33", lengthY, -2);

            // A21, A22, A23, E21, E23, F21, S21, S22, S23
            MoveAxisY("A21", lengthY, -3);
            MoveAxisY("A22", lengthY, -3);
            MoveAxisY("A23", lengthY, -3);
            MoveAxisY("E21", lengthY, -3);
            MoveAxisY("E23", lengthY, -3);
            MoveAxisY("F21", lengthY, -3);
            MoveAxisY("S21", lengthY, -3);
            MoveAxisY("S22", lengthY, -3);
            MoveAxisY("S23", lengthY, -3);

            // A11, B11, B12, B13, E11, E12, E13, E14, F11
            MoveAxisY("A11", lengthY, -4);
            MoveAxisY("B11", lengthY, -4);
            MoveAxisY("B12", lengthY, -4);
            MoveAxisY("B13", lengthY, -4);
            MoveAxisY("E11", lengthY, -4);
            MoveAxisY("E12", lengthY, -4);
            MoveAxisY("E13", lengthY, -4);
            MoveAxisY("E14", lengthY, -4);
            MoveAxisY("F11", lengthY, -4);

            // H22, H23, H24, M11
            MoveAxisY("H22", lengthY, 1);
            MoveAxisY("H23", lengthY, 1);
            MoveAxisY("H24", lengthY, 1);
            MoveAxisY("M11", lengthY, 1);

            // H31, H32, H33, H34
            MoveAxisY("H31", lengthY, 2);
            MoveAxisY("H32", lengthY, 2);
            MoveAxisY("H33", lengthY, 2);
            MoveAxisY("H34", lengthY, 2);

            // H41, H42, H43, H44
            MoveAxisY("H41", lengthY, 3);
            MoveAxisY("H42", lengthY, 3);
            MoveAxisY("H43", lengthY, 3);
            MoveAxisY("H44", lengthY, 3);

            // H51, M12
            MoveAxisY("H51", lengthY, 4);
            MoveAxisY("M12", lengthY, 4);

            List<string> keys = Blocks.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                bool result = vizcore3d.Object3D.Disassembly.AddGroup(
                    i                           /* ID : 0 ~ */
                    , Blocks[keys[i]].Index     /* NODE INDEX */
                    , true                      /* Recursive */
                    );
            }

            vizcore3d.View.EnableAnimation = false;
            vizcore3d.Object3D.Disassembly.DisassembleBySphereCenterDistanceRate(true, 0.8f);

            //AddNote();

            vizcore3d.EndUpdate();

            vizcore3d.View.ResetView();
        }

        private void Unfold_Case2()
        {
            Blocks = new Dictionary<string, VIZCore3D.NET.Data.Node>();

            List<VIZCore3D.NET.Data.Node> children = vizcore3d.Object3D.FromIndex(0)
                .GetChildObject3d(VIZCore3D.NET.Data.Object3DChildOption.CHILD_ONLY);

            foreach (VIZCore3D.NET.Data.Node item in children)
            {
                if (Blocks.ContainsKey(item.NodeName) == false)
                    Blocks.Add(item.NodeName, item);
            }

            float lengthY = vizcore3d.Model.BoundBox.LengthY;

            vizcore3d.BeginUpdate();

            for (int i = 1; i < 6; i++)
            {
                List<string> mBlock = new List<string>();
                foreach (KeyValuePair<string, VIZCore3D.NET.Data.Node> item in Blocks)
                {
                    string[] vals = item.Key.Split(new char[] { '-' });
                    if (vals[2] != i.ToString()) continue;

                    mBlock.Add(item.Key);
                }

                if (mBlock.Count == 0) continue;

                foreach (string item in mBlock)
                {
                    int offset = 0;
                    if (i < 3) offset = -i;
                    else if (i > 3) offset = i - 3;

                    MoveAxisY(item, lengthY, offset);
                }
            }

            List<string> keys = Blocks.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                bool result = vizcore3d.Object3D.Disassembly.AddGroup(
                    i                           /* ID : 0 ~ */
                    , Blocks[keys[i]].Index     /* NODE INDEX */
                    , true                      /* Recursive */
                    );
            }

            vizcore3d.View.EnableAnimation = false;
            vizcore3d.Object3D.Disassembly.DisassembleBySphereCenterDistanceRate(true, 0.8f);

            vizcore3d.EndUpdate();

            vizcore3d.View.ResetView();
        }

        private void MoveAxisY(string block, float length, int ratio)
        {
            if (Blocks.ContainsKey(block) == false) return;

            VIZCore3D.NET.Data.Node node = Blocks[block];

            VIZCore3D.NET.Data.Object3DProperty prop =
                vizcore3d.Object3D.GeometryProperty.FromNode(node);

            float minZ = prop.GetBoundBox().MinZ;

            vizcore3d.Object3D.Transform.Move(new List<VIZCore3D.NET.Data.Node>() { node }, 0.0f, length * ratio, -minZ);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();
            vizcore3d.Object3D.Transform.RestoreTransformAll();
            vizcore3d.View.ResetView();
            vizcore3d.EndUpdate();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();

            AddNote();

            vizcore3d.EndUpdate();
        }

        private void AddNote()
        {
            VIZCore3D.NET.Data.NoteStyle style = vizcore3d.Review.Note.GetStyle();

            List<string> keys = Blocks.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                VIZCore3D.NET.Data.Node node = Blocks[keys[i]];

                VIZCore3D.NET.Data.Object3DProperty prop =
                    vizcore3d.Object3D.GeometryProperty.FromIndex(node.Index);

                vizcore3d.Review.Note.AddNote3D(node.NodeName, prop.CenterPoint);
            }
        }

        private void btnClearNote_Click(object sender, EventArgs e)
        {
            vizcore3d.Review.Note.Clear();
        }

        private void Object3D_OnObject3DSelected(object sender, Event.EventManager.Object3DSelectedEventArgs e)
        {
            if (e.Node.Count == 0) return;

            MessageBox.Show(e.Node[0].NodeName, "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
