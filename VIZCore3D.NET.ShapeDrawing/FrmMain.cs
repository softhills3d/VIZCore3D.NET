using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.ShapeDrawing
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

            btnColor.BackColor = Color.Red;
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
            Utility.LicenseHelper.LicenseData licenseData = Utility.LicenseHelper.GetLicenseDataKind();

            // 등록된 정보 없는 경우, 설정 다이얼로그 실행
            if (licenseData == Utility.LicenseHelper.LicenseData.NONE)
            {
                VIZCore3D.NET.Dialogs.LicenseDialog dlg = new NET.Dialogs.LicenseDialog();
                if (dlg.ShowDialog() != DialogResult.OK) return;
            }

            // 라이선스 정보 재조회
            licenseData = Utility.LicenseHelper.GetLicenseDataKind();

            // 등록된 정보 조회
            Dictionary<string, string> licenseInfo = Utility.LicenseHelper.GetLicenseInformation();
            VIZCore3D.NET.Data.LicenseResults licenseResult = Data.LicenseResults.NONE;

            // 라이선스 서버
            if (licenseData == Utility.LicenseHelper.LicenseData.SERVER)
            {
                licenseResult = vizcore3d.License.LicenseServer(
                    licenseInfo.ContainsKey("LICENSE_IP") == true ? licenseInfo["LICENSE_IP"] : String.Empty
                    , licenseInfo.ContainsKey("LICENSE_PORT") == true ? Convert.ToInt32(licenseInfo["LICENSE_PORT"]) : 8901
                    );
            }
            // 라이선스 파일
            else if (licenseData == Utility.LicenseHelper.LicenseData.FILE)
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
            vizcore3d.View.SelectionMode = Data.Object3DSelectionOptions.HIGHLIGHT_COLOR;

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
            vizcore3d.View.SpecularGamma = 100.0f;
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
            vizcore3d.Review.Note.LinkArrowTailToText = VIZCore3D.NET.Manager.NoteManager.LinkArrowTailToTextKind.END;
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
            measureStyle.UnitKind = Data.MeasureUnitKind.RUT_MILLIMETER;
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
            measureStyle.FontSize = Data.FontSizeKind.SIZE14;
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
            measureStyle.AssistantLineStyle = Data.MeasureStyle.AssistantLineType.DOTTEDLINE;
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
            vizcore3d.ToolbarNote.Visible = false;
            vizcore3d.ToolbarMeasure.Visible = false;
            vizcore3d.ToolbarSection.Visible = false;
            vizcore3d.ToolbarClash.Visible = false;
            vizcore3d.ToolbarAnimation.Visible = false;
            vizcore3d.ToolbarSimulation.Visible = false;
            #endregion


            // ================================================================
            // 설정 - 상태바
            // ================================================================
            vizcore3d.Statusbar.Visible = false;


            // ================================================================
            // 설정 - Shape Drawing
            // ================================================================
            vizcore3d.ShapeDrawing.UseDepthTest(true);


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
            vizcore3d.Object3D.OnSelectedObject3D += Object3D_OnSelectedObject3D;
        }

        private void Object3D_OnSelectedObject3D(object sender, VIZCore3D.NET.Event.EventManager.SelectedObject3DEventArgs e)
        {
            if (e.Node.Count == 0) return;
            if (ckEnable.Checked == false) return;

            if (rbBoundBox.Checked == true)
                DrawByBoundBox(e.Node);
            else if (rbEdgeVertex.Checked == true)
                DrawByEdgeVertex(e.Node);
            else
                DrawByOsnap(e.Node);
        }

        private void DrawByBoundBox(List<Data.Node> node)
        {
            int shapeId = -1;
            int groupId = GetGroupId(node);
            string shapeType = String.Empty;

            if (rbLine.Checked == true)
            {
                shapeType = "Line";

                shapeId = vizcore3d.ShapeDrawing.AddLine(
                    GetVertexList() 
                    , groupId
                    , btnColor.BackColor
                    , Convert.ToSingle(txtThickness.Text)
                    , true
                    );
            }
            else if (rbCube.Checked == true)
            {
                shapeType = "Cube";

                shapeId = vizcore3d.ShapeDrawing.AddCube(
                    GetVertexList() 
                    , groupId
                    , btnColor.BackColor
                    , Convert.ToSingle(txtRadius.Text)
                    , true
                    );
            }
            else if (rbCylinder.Checked == true)
            {
                shapeType = "Cylinder";

                shapeId = vizcore3d.ShapeDrawing.AddCylinder(
                    GetVertexList() 
                    , groupId
                    , btnColor.BackColor
                    , Convert.ToSingle(txtRadius.Text)
                    , true
                    );
            }
            else if (rbVertex.Checked == true)
            {
                shapeType = "Vertex";

                shapeId = vizcore3d.ShapeDrawing.AddVertex(
                    GetVertex() 
                    , groupId
                    , btnColor.BackColor
                    , Convert.ToSingle(txtRadius.Text)
                    , Convert.ToSingle(txtSize.Text)
                    , true
                    );
            }

            AddList(shapeId, groupId, shapeType);
        }

        private void DrawByEdgeVertex(List<Data.Node> node)
        {
            int shapeId = -1;
            int groupId = GetGroupId(node);
            string shapeType = String.Empty;

            shapeType = "Vertex";

            List<VIZCore3D.NET.Data.Object3DEdgeVertex> edge = vizcore3d.Object3D.GetEdgeVertex(node[0].Index, true);

            foreach (VIZCore3D.NET.Data.Object3DEdgeVertex item in edge)
            {
                shapeId = vizcore3d.ShapeDrawing.AddVertex(
                item.Edge
                , groupId
                , btnColor.BackColor
                , Convert.ToSingle(txtRadius.Text)
                , Convert.ToSingle(txtSize.Text)
                , true
                );
            }
        }

        private void DrawByOsnap(List<VIZCore3D.NET.Data.Node> node)
        {
            int shapeId = -1;
            int groupId = GetGroupId(node);
            string shapeType = String.Empty;
            int index = node[0].Index;

            if (rbLine.Checked == true)
            {
                shapeType = "Line";

                shapeId = vizcore3d.ShapeDrawing.AddLine(
                    GetVertexList(index)
                    , groupId
                    , btnColor.BackColor
                    , Convert.ToSingle(txtThickness.Text)
                    , true
                    );
            }
            else if (rbCube.Checked == true)
            {
                shapeType = "Cube";

                shapeId = vizcore3d.ShapeDrawing.AddCube(
                    GetVertexList(index) 
                    , groupId
                    , btnColor.BackColor
                    , Convert.ToSingle(txtRadius.Text)
                    , true
                    );
            }
            else if (rbCylinder.Checked == true)
            {
                shapeType = "Cylinder";

                shapeId = vizcore3d.ShapeDrawing.AddCylinder(
                    GetVertexList(index) 
                    , groupId
                    , btnColor.BackColor
                    , Convert.ToSingle(txtRadius.Text)
                    , true
                    );
            }
            else if (rbVertex.Checked == true)
            {
                shapeType = "Vertex";

                shapeId = vizcore3d.ShapeDrawing.AddVertex(
                    GetVertex(index) 
                    , groupId
                    , btnColor.BackColor
                    , Convert.ToSingle(txtRadius.Text)
                    , Convert.ToSingle(txtSize.Text)
                    , true
                    );
            }

            AddList(shapeId, groupId, shapeType);
        }

        private void AddList(int id, int groupId, string shapeType)
        {
            ListViewItem lvi = new ListViewItem(new string[] { id.ToString(), groupId.ToString(), shapeType, "True" });
            lvList.Items.Add(lvi);
        }

        private List<VIZCore3D.NET.Data.Vertex3D> GetVertex()
        {
            List<VIZCore3D.NET.Data.Vertex3D> vertex = new List<VIZCore3D.NET.Data.Vertex3D>();

            Data.BoundBox3D boundbox = vizcore3d.Object3D.GeometryProperty.FromSelectedObject3D(false).GetBoundBox();

            vertex.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MinY, boundbox.MinZ));
            vertex.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MinY, boundbox.MinZ));
            vertex.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MaxY, boundbox.MinZ));
            vertex.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MinY, boundbox.MaxZ));
            vertex.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MaxY, boundbox.MinZ));
            vertex.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MaxY, boundbox.MaxZ));
            vertex.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MinY, boundbox.MaxZ));
            vertex.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MaxY, boundbox.MaxZ));

            return vertex;
        }

        private List<VIZCore3D.NET.Data.Vertex3D> GetVertex(int index)
        {
            List<VIZCore3D.NET.Data.OsnapVertex3D> osnap = vizcore3d.Object3D.GetOsnapPoint(index);

            List<VIZCore3D.NET.Data.Vertex3D> items = new List<VIZCore3D.NET.Data.Vertex3D>();
            foreach (VIZCore3D.NET.Data.OsnapVertex3D item in osnap)
            {
                items.Add(item.Start);
            }

            return items;
        }

        private List<VIZCore3D.NET.Data.Vertex3DItemCollection> GetVertexList()
        {
            List<VIZCore3D.NET.Data.Vertex3DItemCollection> vertex = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();

            VIZCore3D.NET.Data.BoundBox3D boundbox = vizcore3d.Object3D.GeometryProperty.FromSelectedObject3D(false).GetBoundBox();

            {
                Data.Vertex3DItemCollection item = new VIZCore3D.NET.Data.Vertex3DItemCollection();

                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MinY, boundbox.MinZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MaxY, boundbox.MinZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MaxY, boundbox.MinZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MinY, boundbox.MinZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MinY, boundbox.MinZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MinY, boundbox.MaxZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MaxY, boundbox.MaxZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MaxY, boundbox.MaxZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MinY, boundbox.MaxZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MinY, boundbox.MaxZ));

                vertex.Add(item);
            }

            {
                VIZCore3D.NET.Data.Vertex3DItemCollection item = new VIZCore3D.NET.Data.Vertex3DItemCollection();

                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MaxY, boundbox.MinZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MinX, boundbox.MaxY, boundbox.MaxZ));

                vertex.Add(item);
            }

            {
                VIZCore3D.NET.Data.Vertex3DItemCollection item = new VIZCore3D.NET.Data.Vertex3DItemCollection();

                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MaxY, boundbox.MinZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MaxY, boundbox.MaxZ));

                vertex.Add(item);
            }

            {
                VIZCore3D.NET.Data.Vertex3DItemCollection item = new VIZCore3D.NET.Data.Vertex3DItemCollection();

                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MinY, boundbox.MaxZ));
                item.Add(new VIZCore3D.NET.Data.Vertex3D(boundbox.MaxX, boundbox.MinY, boundbox.MinZ));

                vertex.Add(item);
            }

            return vertex;
        }

        private List<VIZCore3D.NET.Data.Vertex3DItemCollection> GetVertexList(int index)
        {
            List<VIZCore3D.NET.Data.OsnapVertex3D> osnap = vizcore3d.Object3D.GetOsnapPoint(index);

            List<VIZCore3D.NET.Data.Vertex3DItemCollection> vertex = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();

            foreach (Data.OsnapVertex3D point in osnap)
            {
                if(point.Kind == Data.OsnapKind.LINE)
                {
                    VIZCore3D.NET.Data.Vertex3DItemCollection item = new VIZCore3D.NET.Data.Vertex3DItemCollection();

                    item.Add(point.Start);
                    item.Add(point.End);

                    vertex.Add(item);
                }
                else if(point.Kind == Data.OsnapKind.CIRCLE)
                {
                    VIZCore3D.NET.Data.Vertex3DItemCollection item = new VIZCore3D.NET.Data.Vertex3DItemCollection();

                    item.Add(point.Start);
                    item.Add(point.End);

                    vertex.Add(item);
                }
            }

            return vertex;
        }

        private int GetGroupId(List<VIZCore3D.NET.Data.Node> nodes)
        {
            if (ckNodeIndex.Checked == true)
                return nodes[0].Index;
            else
                return Convert.ToInt32(txtGroupId.Text);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.AllowFullOpen = true;
            dlg.ShowHelp = true;

            if (dlg.ShowDialog() != DialogResult.OK) return;

            btnColor.BackColor = dlg.Color;
        }

        private void ckUseDepthTest_CheckedChanged(object sender, EventArgs e)
        {
            vizcore3d.ShapeDrawing.UseDepthTest(ckUseDepthTest.Checked);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            vizcore3d.ShapeDrawing.Show(true);

            lvList.BeginUpdate();
            for (int i = 0; i < lvList.Items.Count; i++)
            {
                lvList.Items[i].SubItems[3].Text = "True";
            }
            lvList.EndUpdate();
        }

        private void btnHideAll_Click(object sender, EventArgs e)
        {
            vizcore3d.ShapeDrawing.Show(false);

            lvList.BeginUpdate();
            for (int i = 0; i < lvList.Items.Count; i++)
            {
                lvList.Items[i].SubItems[3].Text = "False";
            }
            lvList.EndUpdate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            vizcore3d.ShapeDrawing.Clear();

            lvList.BeginUpdate();
            lvList.Items.Clear();
            lvList.EndUpdate();
        }

        private void btnShowChecked_Click(object sender, EventArgs e)
        {
            List<int> id = new List<int>();
            lvList.BeginUpdate();
            for (int i = 0; i < lvList.Items.Count; i++)
            {
                if (lvList.Items[i].Checked == false) continue;

                string item = lvList.Items[i].SubItems[0].Text;
                lvList.Items[i].SubItems[3].Text = "True";
                id.Add(Convert.ToInt32(item));
            }
            lvList.EndUpdate();

            vizcore3d.ShapeDrawing.Show(id, true);
        }

        private void btnHideChecked_Click(object sender, EventArgs e)
        {
            List<int> id = new List<int>();
            lvList.BeginUpdate();
            for (int i = 0; i < lvList.Items.Count; i++)
            {
                if (lvList.Items[i].Checked == false) continue;

                string item = lvList.Items[i].SubItems[0].Text;
                lvList.Items[i].SubItems[3].Text = "False";
                id.Add(Convert.ToInt32(item));
            }
            lvList.EndUpdate();

            vizcore3d.ShapeDrawing.Show(id, false);
        }

        private void btnShowGroup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtGroupId.Text) == true) return;

            string groupid = txtGroupId.Text;

            vizcore3d.ShapeDrawing.ShowGroup(Convert.ToInt32(groupid), true);

            lvList.BeginUpdate();
            for (int i = 0; i < lvList.Items.Count; i++)
            {
                string item = lvList.Items[i].SubItems[1].Text;

                if (groupid == item)
                    lvList.Items[i].SubItems[3].Text = "True";
            }
            lvList.EndUpdate();
        }

        private void btnHideGroup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtGroupId.Text) == true) return;

            string groupid = txtGroupId.Text;

            vizcore3d.ShapeDrawing.ShowGroup(Convert.ToInt32(groupid), false);

            lvList.BeginUpdate();
            for (int i = 0; i < lvList.Items.Count; i++)
            {
                string item = lvList.Items[i].SubItems[1].Text;

                if (groupid == item)
                    lvList.Items[i].SubItems[3].Text = "False";
            }
            lvList.EndUpdate();
        }

        private void btnDeleteChecked_Click(object sender, EventArgs e)
        {
            lvList.BeginUpdate();
            List<int> index = new List<int>();
            List<int> id = new List<int>();
            for (int i = lvList.Items.Count; i > 0; i--)
            {
                if (lvList.Items[i - 1].Checked == false) continue;

                index.Add(i - 1);
                id.Add(Convert.ToInt32(lvList.Items[i - 1].SubItems[0].Text));
            }
            for (int i = 0; i < index.Count; i++)
            {
                lvList.Items.RemoveAt(index[i]);
            }
            lvList.EndUpdate();

            vizcore3d.ShapeDrawing.Delete(id);
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtGroupId.Text) == true) return;

            string groupid = txtGroupId.Text;

            vizcore3d.ShapeDrawing.DeleteGroup(Convert.ToInt32(groupid));

            lvList.BeginUpdate();
            List<int> index = new List<int>();
            for (int i = lvList.Items.Count; i > 0; i--)
            {
                string item = lvList.Items[i - 1].SubItems[1].Text;

                if (groupid == item)
                    index.Add(i - 1);
            }
            for (int i = 0; i < index.Count; i++)
            {
                lvList.Items.RemoveAt(index[i]);
            }
            lvList.EndUpdate();
        }
    }
}
