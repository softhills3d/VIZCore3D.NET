using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.MeasureFrame
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

            // Init.
            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
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
            vizcore3d.GeometryUtility.OnOsnapPickingItem += GeometryUtility_OnOsnapPickingItem;
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
        private void btnOpenModel_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\Models\\VIZCore3D.NET.MeasureFrame\\H1195_V303.viz", vizcore3d.GetEntryAssemblyPath());

            if(System.IO.File.Exists(path) == true)
            {
                vizcore3d.Model.Open(path);
            }
            else
            {
                vizcore3d.Model.OpenFileDialog();
            }
        }

        private void btnOpenFrame_Click(object sender, EventArgs e)
        {
            bool result = false;

            string path = string.Format("{0}\\Models\\VIZCore3D.NET.MeasureFrame\\H1195.DMP", vizcore3d.GetEntryAssemblyPath());

            if (System.IO.File.Exists(path) == true)
            {
                result = vizcore3d.Frame.Open(path);
            }
            else
            {
                result = vizcore3d.Frame.OpenFileDialog();
            }

            if (result == false) return;

            vizcore3d.Frame.Visible = true;
        }

        private void btnShowOsnap_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> nodes = 
                vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.SELECTED_TOP);

            if (nodes.Count == 0) return;
            if (vizcore3d.Frame.HasFrame == false) return;

            vizcore3d.GeometryUtility.ShowOsnap(
                nodes[0].Index  /* Node Index */
                , false         /* Surface */
                , true          /* Vertex */
                , true          /* Vertex Middle */
                , false         /* Line */
                , false         /* Circle */
                );
        }

        private void btnShowFrame_Click(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.Vertex3D v = new VIZCore3D.NET.Data.Vertex3D(txtX.Text, txtY.Text, txtZ.Text);

            ShowFrame(v);
        }

        private void ShowFrame(VIZCore3D.NET.Data.Vertex3D v)
        {
            vizcore3d.BeginUpdate();

            // Add Custom Measure
            vizcore3d.Review.Measure.AddCustomPosition(v);

            // Get Current Frame Item
            Dictionary<VIZCore3D.NET.Data.Axis, VIZCore3D.NET.Data.FrameItem> frame = 
                vizcore3d.Frame.GetFrame(v);

            // Axis Frame Item
            VIZCore3D.NET.Data.FrameItem currentX = frame[VIZCore3D.NET.Data.Axis.X];
            VIZCore3D.NET.Data.FrameItem currentY = frame[VIZCore3D.NET.Data.Axis.Y];
            VIZCore3D.NET.Data.FrameItem currentZ = frame[VIZCore3D.NET.Data.Axis.Z];

            // Frame String
            string xFrameStr = string.Format("{0}{1}", currentX.Label, currentX.GridID);
            string yFrameStr = string.Format("{0}{1}", currentY.Label, currentY.GridID);
            string zFrameStr = string.Format("{0}{1}", currentZ.Label, currentZ.GridID);

            // Frame Position
            VIZCore3D.NET.Data.FramePosition xPosition = 
                vizcore3d.Frame.GetPosition(VIZCore3D.NET.Data.Axis.X, xFrameStr);
            VIZCore3D.NET.Data.FramePosition yPosition =
                vizcore3d.Frame.GetPosition(VIZCore3D.NET.Data.Axis.Y, yFrameStr);
            VIZCore3D.NET.Data.FramePosition zPosition =
                vizcore3d.Frame.GetPosition(VIZCore3D.NET.Data.Axis.Z, zFrameStr);

            VIZCore3D.NET.Data.Vertex3D vmZ1 = new VIZCore3D.NET.Data.Vertex3D();

            // X-Base
            {
                List<VIZCore3D.NET.Data.Vertex3DItemCollection> xBaseLine = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();
                VIZCore3D.NET.Data.Vertex3DItemCollection xBasePoint = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                xBasePoint.Add(v);
                VIZCore3D.NET.Data.Vertex3D vX = v.Clone();
                vX.Y -= 2000.0f;
                xBasePoint.Add(vX);
                xBaseLine.Add(xBasePoint);

                VIZCore3D.NET.Data.Vertex3DItemCollection xOffsetPoint = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                VIZCore3D.NET.Data.Vertex3D vX1 = new VIZCore3D.NET.Data.Vertex3D(xPosition.Position, v.Y, v.Z);
                VIZCore3D.NET.Data.Vertex3D vX2 = new VIZCore3D.NET.Data.Vertex3D(xPosition.Position, v.Y - 2000.0f, v.Z);
                xOffsetPoint.Add(vX1);
                xOffsetPoint.Add(vX2);
                xBaseLine.Add(xOffsetPoint);

                vizcore3d.ShapeDrawing.AddDashLine(xBaseLine, 0, Color.Red, 5.0f, true, 100.0f);

                vizcore3d.TextDrawing.Add(vX2, new VIZCore3D.NET.Data.Vector3D(1, 0, 0), new VIZCore3D.NET.Data.Vector3D(0, 1, 0), 100, 100, Color.Black, string.Format("(X){0}", xFrameStr));

                // Middle Point
                VIZCore3D.NET.Data.Vertex3D vmX1 = v.PointToPoint(vX, 1000.0f);
                VIZCore3D.NET.Data.Vertex3D vmX2 = vX1.PointToPoint(vX2, 1000.0f);
                List<VIZCore3D.NET.Data.Vertex3DItemCollection> xMiddleLine = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();
                VIZCore3D.NET.Data.Vertex3DItemCollection xMiddlePoint = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                xMiddlePoint.Add(vmX2);
                xMiddlePoint.Add(vmX1);
                xMiddleLine.Add(xMiddlePoint);
                vizcore3d.ShapeDrawing.AddArrow(xMiddleLine, 3, Color.Black, Color.Yellow, 5, 10, true);

                VIZCore3D.NET.Data.Vertex3D mX = vmX2.PointToPoint(vmX1, (vmX1.X - vmX2.X) / 2);
                mX.Y += 100.0f;
                vizcore3d.TextDrawing.Add(mX, new VIZCore3D.NET.Data.Vector3D(1, 0, 0), new VIZCore3D.NET.Data.Vector3D(0, 1, 0), 70, 50, Color.Black, string.Format("{0}", Math.Abs(vmX1.X - vmX2.X)));

                vmZ1 = v.PointToPoint(vX, 800.0f);
            }

            // Y-Base
            {
                List<VIZCore3D.NET.Data.Vertex3DItemCollection> yBaseLine = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();
                VIZCore3D.NET.Data.Vertex3DItemCollection yBasePoint = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                yBasePoint.Add(v);
                VIZCore3D.NET.Data.Vertex3D vY = v.Clone();
                vY.X -= 2000.0f;
                yBasePoint.Add(vY);
                yBaseLine.Add(yBasePoint);

                VIZCore3D.NET.Data.Vertex3DItemCollection yOffsetPoint = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                VIZCore3D.NET.Data.Vertex3D vY1 = new VIZCore3D.NET.Data.Vertex3D(v.X, yPosition.Position, v.Z);
                VIZCore3D.NET.Data.Vertex3D vY2 = new VIZCore3D.NET.Data.Vertex3D(v.X - 2000.0f, yPosition.Position, v.Z);
                yOffsetPoint.Add(vY1);
                yOffsetPoint.Add(vY2);
                yBaseLine.Add(yOffsetPoint);

                vizcore3d.ShapeDrawing.AddDashLine(yBaseLine, 1, Color.Black, 5.0f, true, 100.0f);

                vizcore3d.TextDrawing.Add(vY2, new VIZCore3D.NET.Data.Vector3D(0, -1, 0), new VIZCore3D.NET.Data.Vector3D(1, 0, 0), 100, 100, Color.Black, string.Format("(Y){0}", yFrameStr));

                // Middle Point
                VIZCore3D.NET.Data.Vertex3D vmY1 = v.PointToPoint(vY, 1000.0f);
                VIZCore3D.NET.Data.Vertex3D vmY2 = vY1.PointToPoint(vY2, 1000.0f);
                List<VIZCore3D.NET.Data.Vertex3DItemCollection> yMiddleLine = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();
                VIZCore3D.NET.Data.Vertex3DItemCollection yMiddlePoint = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                yMiddlePoint.Add(vmY2);
                yMiddlePoint.Add(vmY1);
                yMiddleLine.Add(yMiddlePoint);
                vizcore3d.ShapeDrawing.AddArrow(yMiddleLine, 3, Color.Black, Color.Yellow, 5, 10, true);

                VIZCore3D.NET.Data.Vertex3D mY = vmY2.PointToPoint(vmY1, (vmY2.Y - vmY1.Y) / 2);
                mY.X += 100.0f;
                vizcore3d.TextDrawing.Add(mY, new VIZCore3D.NET.Data.Vector3D(0, -1, 0), new VIZCore3D.NET.Data.Vector3D(1, 0, 0), 70, 50, Color.Black, string.Format("{0}", Math.Abs(vmY1.Y - vmY2.Y)));
            }

            // Z-Base
            {
                List<VIZCore3D.NET.Data.Vertex3DItemCollection> zBaseLine = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();
                VIZCore3D.NET.Data.Vertex3DItemCollection zBasePoint = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                VIZCore3D.NET.Data.Vertex3D vZ0 = v.Clone();
                vZ0.Z = zPosition.Position;
                zBasePoint.Add(vZ0);
                VIZCore3D.NET.Data.Vertex3D vZ = v.Clone();
                vZ.Y -= 2000.0f;
                vZ.Z = zPosition.Position;
                zBasePoint.Add(vZ);
                zBaseLine.Add(zBasePoint);

                vizcore3d.ShapeDrawing.AddDashLine(zBaseLine, 2, Color.Blue, 5.0f, true, 100.0f);

                vizcore3d.TextDrawing.Add(vZ, new VIZCore3D.NET.Data.Vector3D(0, 0, -1), new VIZCore3D.NET.Data.Vector3D(1, 0, 0), 100, 100, Color.Black, string.Format("(Z){0}", zFrameStr));

                // Middle Point
                VIZCore3D.NET.Data.Vertex3D vmZ2 = vZ0.PointToPoint(vZ, 800.0f);
                List<VIZCore3D.NET.Data.Vertex3DItemCollection> zMiddleLine = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();
                VIZCore3D.NET.Data.Vertex3DItemCollection zMiddlePoint = new VIZCore3D.NET.Data.Vertex3DItemCollection();
                zMiddlePoint.Add(vmZ2);
                zMiddlePoint.Add(vmZ1);
                zMiddleLine.Add(zMiddlePoint);
                vizcore3d.ShapeDrawing.AddArrow(zMiddleLine, 3, Color.Black, Color.Yellow, 5, 10, true);

                VIZCore3D.NET.Data.Vertex3D mZ = vmZ2.PointToPoint(vmZ1, (vmZ2.Z - vmZ1.Z) / 2);
                mZ.Y -= 100.0f;
                vizcore3d.TextDrawing.Add(mZ, new VIZCore3D.NET.Data.Vector3D(0, 0, -1), new VIZCore3D.NET.Data.Vector3D(1, 0, 0), 70, 50, Color.Black, string.Format("{0}", Math.Abs(vmZ1.Z - vmZ2.Z)));
            }

            vizcore3d.EndUpdate();
        }

        // ================================================
        // Event
        // ================================================
        private void GeometryUtility_OnOsnapPickingItem(object sender, Event.EventManager.OsnapPickingItemEventArgs e)
        {
            if (e.Kind != VIZCore3D.NET.Data.OsnapKind.POINT) return;

            txtX.Text = e.Point.XToInt32().ToString();
            txtY.Text = e.Point.YToInt32().ToString();
            txtZ.Text = e.Point.ZToInt32().ToString();
        }
    }
}
