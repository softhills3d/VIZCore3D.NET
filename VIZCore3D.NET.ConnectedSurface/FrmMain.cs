using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.ConnectedSurface
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

            // Construction
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
            // 윤곽
            vizcore3d.View.SilhouetteEdge = true;
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
            vizcore3d.Review.Note.LineColor = Color.Black;
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
            vizcore3d.ToolbarNote.Visible = true;
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

        #region Function - VIZCore3D.NET : Event
        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            vizcore3d.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;
        }
        #endregion

        private void Object3D_OnObject3DSelected(object sender, Event.EventManager.Object3DSelectedEventArgs e)
        {
            if (ckEnable.Checked == false) return;
            if (e.Node.Count == 0) return;

            if (e.Node.Count != 1) return;

            if (String.IsNullOrEmpty(txtPart1.Text) == true)
            {
                txtPart1.Text = e.Node[0].Index.ToString();
            }
            else if (String.IsNullOrEmpty(txtPart2.Text) == true)
            {
                txtPart2.Text = e.Node[0].Index.ToString();

                btnGetNormalVector.PerformClick();
            }
        }

        private void btnGetNormalVector_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPart1.Text) == true) return;
            if (String.IsNullOrEmpty(txtPart2.Text) == true) return;

            VIZCore3D.NET.Data.ConnectedSurfaceNormalVectorItem item = vizcore3d.GeometryUtility.GetConnectedSurfaceNormalVector(Convert.ToInt32(txtPart1.Text), Convert.ToInt32(txtPart2.Text));
            AddResult(item, true, false);

            txtPart1.Text = String.Empty;
            txtPart2.Text = String.Empty;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPart1.Text = String.Empty;
            txtPart2.Text = String.Empty;
        }

        private void AddResult(VIZCore3D.NET.Data.ConnectedSurfaceNormalVectorItem item, bool note, bool nv)
        {
            VIZCore3D.NET.Data.Node node1 = vizcore3d.Object3D.FromIndex(item.Index1);
            VIZCore3D.NET.Data.Node node2 = vizcore3d.Object3D.FromIndex(item.Index2);

            string no = Convert.ToString(lvResult.Items.Count + 1);

            ListViewItem lvi = new ListViewItem(
                new string[]
                {
                    no
                    , node1.Index.ToString()
                    , node2.Index.ToString()
                    , node1.NodeName
                    , node2.NodeName
                    , item.Normal.ToString()
                    , item.Projection1.ToString()
                    , item.Projection2.ToString()
                }
                );

            lvi.Tag = item;

            if (item.Normal.Z > 0)
                lvi.BackColor = Color.Yellow;

            lvResult.Items.Add(lvi);

            if (note == true)
            {
                VIZCore3D.NET.Data.MultiColorText text = new Data.MultiColorText();
                text.AddLine(string.Format("NO. : {0}", no), Color.Purple);
                text.AddLine(string.Format("NODE #1 : {0}", node1.NodeName), Color.Black);
                text.AddLine(string.Format("NODE #2 : {0}", node2.NodeName), Color.Blue);
                text.AddLine(string.Format("N/V : {0}", item.Normal.ToString()), Color.Red);

                VIZCore3D.NET.Data.Vertex3D pos = new VIZCore3D.NET.Data.Vertex3D(item.Projection1.X + 500, item.Projection1.Y + 500, item.Projection1.Z + 3500);

                vizcore3d.Review.Note.AddNoteSurface(text, pos, item.Projection1);
            }

            if(nv == true)
            {
                if (Convert.ToInt32(item.Normal.X) != 0 || Convert.ToInt32(item.Normal.Y) != 0 || Convert.ToInt32(item.Normal.Z) != 0) return;

                vizcore3d.ShapeDrawing.AddVertex(
                    new List<VIZCore3D.NET.Data.Vertex3D>()
                    {
                        item.TestPosition
                    }
                    , 0
                    , Color.Blue
                    , 10
                    , 10
                    , true
                    );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvResult.Items.Clear();

            vizcore3d.Review.Note.Clear();
        }

        private List<SampleItem> GetSampleData()
        {
            List<SampleItem> items = new List<SampleItem>();

            items.Add(new SampleItem("11,052.00", "	672.00", "5,183.00", "E32C-SS1A-J1(E32C-1-1P)", "E23P-UA-P3(E23P-1-5P)"));
            items.Add(new SampleItem("11,056.00", "-714.00", "5,172.00", "E32C-SS1M-J1(E32C-1-1S)", "E23S-UA-P3(E23P-1-5S)"));
            items.Add(new SampleItem("11,952.00", "-900.00", "5,177.00", "E32C-SS1M-J1(E32C-1-1S)", "E23S-UA-P3(E23P-1-5S)"));
            items.Add(new SampleItem("13,353.00", "-1,181.00", "5,195.00", "E32C-SS1M-J1(E32C-1-1S)", "E23S-UA-P3(E23P-1-5S)"));
            items.Add(new SampleItem("16,550.00", "-2,027.00", "5,171.00", "E32C-SS1M-J3(E32C-1-5S)", "E23S-UA-P4(E23P-1-7S)"));
            items.Add(new SampleItem("19,754.00", "-3,199.00", "5,170.00", "E32C-SS1M-J5(E32C-1-9S)", "E23S-UA-P5(E23P-1-9S)"));
            items.Add(new SampleItem("22,948.00", "-4,930.00", "5,174.00", "E32C-SS1M-J7(E32C-1-13S)", "E22S-UA-P3(E22P-1-5S)"));
            items.Add(new SampleItem("25,347.00", "-6,633.00", "5,178.00", "E32C-SS1M-J9(E32C-1-17S)", "E22S-UA-P4(E22P-1-7S)"));
            items.Add(new SampleItem("27,761.00", "-8,453.00", "5,172.00", "E31S-SS2-J2(E31P-2-1S)", "E22S-UA-P4(E22P-1-7S)"));
            items.Add(new SampleItem("30,154.00", "-9,950.00", "5,166.00", "E31S-SS2-J2(E31P-2-1S)", "E21S-UA-P4(E21P-1-7S)"));
            items.Add(new SampleItem("32,558.00", "-11,002.00", "5,164.00", "E31S-SS1-J1(E31P-1-1S)", "E21S-UA-P5(E21P-1-9S)"));
            items.Add(new SampleItem("35,754.00", "-11,970.00", "5,172.00", "E31S-SS1-J1(E31P-1-1S)", "E21S-UA-P5(E21P-1-9S)"));
            items.Add(new SampleItem("40,555.00", "-12,909.00", "5,250.00", "E31S-SS1-J3(E31P-1-5S)", "E24S-SS-J3(E24P-1-5S)"));
            items.Add(new SampleItem("41,549.00", "-13,067.00", "5,292.00", "E31S-SS1-J3(E31P-1-5S)", "E24S-SS-J3(E24P-1-5S)"));
            items.Add(new SampleItem("41,548.00", "13,068.00", "5,292.00", "E31P-SS1-J3(E31P-1-5P)", "E24P-SS-J3(E24P-1-5P)"));
            items.Add(new SampleItem("40,550.00", "12,914.00", "5,247.00", "E31P-SS1-J3(E31P-1-5P)", "E24P-SS-J3(E24P-1-5P)"));
            items.Add(new SampleItem("35,747.00", "11,967.00", "5,175.00", "E31P-SS1-J1(E31P-1-1P)", "E21P-UA-P5(E21P-1-9P)"));
            items.Add(new SampleItem("32,550.00", "10,996.00", "5,167.00", "E31P-SS1-J1(E31P-1-1P)", "E21P-UA-P5(E21P-1-9P)"));
            items.Add(new SampleItem("30,152.00", "9,946.00", "5,177.00", "E31P-SS2-J2(E31P-2-1P)", "E21P-UA-P4(E21P-1-7P)"));
            items.Add(new SampleItem("27,754.00", "8,455.00", "5,179.00", "E31P-SS2-J2(E31P-2-1P)", "E22P-UA-P4(E22P-1-7P)"));
            items.Add(new SampleItem("25,346.00", "6,635.00", "5,174.00", "E32C-SS1A-J9(E32C-1-17P)", "E22P-UA-P4(E22P-1-7P)"));
            items.Add(new SampleItem("22,945.00", "4,932.00", "5,171.00", "E32C-SS1A-J7(E32C-1-13P)", "E22P-UA-P3(E22P-1-5P)"));
            items.Add(new SampleItem("19,750.00", "3,202.00", "5,165.00", "E32C-SS1A-J5(E32C-1-9P)", "E23P-UA-P5(E23P-1-9P)"));
            items.Add(new SampleItem("16,549.00", "2,023.00", "5,174.00", "E32C-SS1A-J3(E32C-1-5P)", "E23P-UA-P4(E23P-1-7P)"));
            items.Add(new SampleItem("11,948.00", "870.00", "5,180.00", "E32C-SS1A-J1(E32C-1-1P)", "E23P-UA-P3(E23P-1-5P)"));

            return items;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.FromFilter(Data.Object3dFilter.PART);
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (VIZCore3D.NET.Data.Node item in nodes)
            {
                if (map.ContainsKey(item.NodeName) == false)
                    map.Add(item.NodeName, item.Index);
            }

            List<SampleItem> items = GetSampleData();
            
            vizcore3d.BeginUpdate();
            foreach (SampleItem item in items)
            {
                if (map.ContainsKey(item.Name1) == false) continue;
                if (map.ContainsKey(item.Name2) == false) continue;

                item.Index1 = map[item.Name1];
                item.Index2 = map[item.Name2];

                VIZCore3D.NET.Data.ConnectedSurfaceNormalVectorItem nv 
                    = vizcore3d.GeometryUtility.GetConnectedSurfaceNormalVector(
                        item.Index1
                        , item.Index2
                        , new Data.Vertex3D(item.X, item.Y, item.Z)
                        , 10 /* Face Distance Tolerance */
                        );

                AddResult(nv, true, true);
            }
            vizcore3d.EndUpdate();
        }

        private void lvResult_DoubleClick(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems.Count == 0) return;
            if (lvResult.SelectedItems[0].Tag == null) return;

            ListViewItem lvi = lvResult.SelectedItems[0];
            VIZCore3D.NET.Data.ConnectedSurfaceNormalVectorItem nv = (VIZCore3D.NET.Data.ConnectedSurfaceNormalVectorItem)lvi.Tag;

            vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.Object3D.Select(new List<int>() { nv.Index1, nv.Index2 }, true, true);
        }
    }

    public class SampleItem
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public string Name1 { get; set; }
        public string Name2 { get; set; }

        public int Index1 { get; set; }
        public int Index2 { get; set; }

        public SampleItem(string x, string y, string z, string name1, string name2)
        {
            X = Convert.ToSingle(x.Trim());
            Y = Convert.ToSingle(y.Trim());
            Z = Convert.ToSingle(z.Trim());

            Name1 = name1.Trim();
            Name2 = name2.Trim();

            Index1 = -1;
            Index2 = -1;
        }
    }
}
