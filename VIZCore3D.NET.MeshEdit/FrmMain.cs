using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.MeshEdit
{
    public partial class FrmMain : Form
    {
        public enum CustomAPI
        {
            MERGE_BODY = 0,
            MOVE_VERTEX = 1,
            MOVE_LINE = 2,
            MOVE_SURFACE = 3,
            MOVE_BASESURFACE = 4,
            SIMPLIFY = 5,
            CUT_SURFACE = 6
        }

        // ================================================
        // Attribute & Property
        // ================================================
        /// <summary>
        /// VIZCore3D.NET
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        private CustomAPI CustomKind;

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

            // Disable
            DisableParam();
        }

        private void DisableParam()
        {
            txtBodyIndex1.Enabled = false;
            txtBodyIndex2.Enabled = false;
            txtVertex1.Enabled = false;
            txtVertex2.Enabled = false;
            txtVertex3.Enabled = false;
            txtVertex4.Enabled = false;
            txtVertex5.Enabled = false;
            ckEnableParam.Enabled = false;
            btnCustomAPI.Enabled = false;

            lb1.Text = "V.1";
            lb2.Text = "V.2";
            lb3.Text = "V.3";
            lb4.Text = "V.4";
            lb5.Text = "V.5";
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
            // 모델 열기 시, 3D 화면 Rendering 재시작
            // ================================================================
            vizcore3d.EndUpdate();
        }
        #endregion

        #region Function - VIZCore3D.NET : Add Event
        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            vizcore3d.Object3D.OnSelectedObject3D += Object3D_OnSelectedObject3D;
            vizcore3d.GeometryUtility.OnOsnapPickingItem += GeometryUtility_OnOsnapPickingItem;
            vizcore3d.MeshEdit.OnMeshEditNodeIndexChangedEvent += MeshEdit_OnMeshEditNodeIndexChangedEvent;
            vizcore3d.MeshEdit.OnMeshEditNodeRemovedEvent += MeshEdit_OnMeshEditNodeRemovedEvent;
            vizcore3d.MeshEdit.OnMeshEditNodeVertexChangedEvent += MeshEdit_OnMeshEditNodeVertexChangedEvent;
        }

        private void MeshEdit_OnMeshEditNodeVertexChangedEvent(object sender, Event.EventManager.MeshEditNodeVertexChangedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("BODY ID : {0}", e.BodyId));
            sb.AppendLine(string.Format("V1 : {0}", e.Vertex1.ToString()));
            sb.AppendLine(string.Format("V2 : {0}", e.Vertex2.ToString()));

            txtNodeVertexChanged.Text = sb.ToString();
        }

        private void MeshEdit_OnMeshEditNodeRemovedEvent(object sender, Event.EventManager.MeshEditNodeRemovedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("FILE : {0}", e.File));
            sb.AppendLine(string.Format("INDEX : {0}", e.Index));

            txtNodeRemoved.Text = sb.ToString();
        }

        private void MeshEdit_OnMeshEditNodeIndexChangedEvent(object sender, Event.EventManager.MeshEditNodeIndexChangedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("ADDED NODES : {0}", e.AddedNodes.ToString()));
            sb.AppendLine(string.Format("COPY NODE ID : ", string.Join(",", e.CopyNodeId.ToArray())));
            sb.AppendLine(string.Format("REMOVE NODE ID : ", string.Join(",", e.RemoveNodeId.ToArray())));
            sb.AppendLine(string.Format("LOAD NODE ID : ", string.Join(",", e.LoadNodeId.ToArray())));
            sb.AppendLine(string.Format("UNLOAD NODE ID : ", string.Join(",", e.UnloadNodeId.ToArray())));

            txtNodeIndexChanged.Text = sb.ToString();
        }

        private void Object3D_OnSelectedObject3D(object sender, Event.EventManager.SelectedObject3DEventArgs e)
        {
            if(e.Node.Count == 0)
            {
                dataGridNode.DataSource = null;

                txtEdgeLoop.Text = String.Empty;
            }
            else
            {
                txtEdgeLoopIndex.Text = e.Node[0].Index.ToString();
                txtOsnapIndex.Text = e.Node[0].Index.ToString();

                // 선택 노드 및 하위 목록
                List<VIZCore3D.NET.Data.Node> items = new List<Data.Node>();
                items.Add(e.Node[0]);

                List<VIZCore3D.NET.Data.Node> child = vizcore3d.Object3D.GetChildObject3d(e.Node[0].Index, Data.Object3DChildOption.ALL_CHILDREN, true);

                items.AddRange(child);

                dataGridNode.DataSource = items;

                // 선택 노드 Edge Loop
                ShowLogEdgeLoop(e.Node[0].Index);
            }
        }

        private void GeometryUtility_OnOsnapPickingItem(object sender, Event.EventManager.OsnapPickingItemEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Kind : {0}", e.Kind.ToString()));
            sb.AppendLine(string.Format("Point : {0}", e.Point == null ? "" : e.Point.ToString()));
            sb.AppendLine(string.Format("Start : {0}", e.Start == null ? "" : e.Start.ToString()));
            sb.AppendLine(string.Format("End : {0}", e.End == null ? "" : e.End.ToString()));
            sb.AppendLine(string.Format("Center : {0}", e.Center == null ? "" : e.Center.ToString()));
            sb.AppendLine(string.Format("Normal : {0}", e.Normal == null ? "" : e.Normal.ToString()));

            txtOsnap.Text = sb.ToString();
        }
        #endregion



        // ================================================
        // Event - Mesh Edit.
        // ================================================
        private void btnMergeBodyAPI_Click(object sender, EventArgs e)
        {
            vizcore3d.MeshEdit.MergeBody();
        }

        private void btnMoveVertexAPI_Click(object sender, EventArgs e)
        {
            vizcore3d.MeshEdit.MoveVertex();
        }

        private void btnMoveLineAPI_Click(object sender, EventArgs e)
        {
            vizcore3d.MeshEdit.MoveVertexToLineProjection();
        }

        private void btnMoveSurfaceAPI_Click(object sender, EventArgs e)
        {
            vizcore3d.MeshEdit.MoveVertexToSurfaceProjection();
        }

        private void btnMoveBaseSurfaceAPI_Click(object sender, EventArgs e)
        {
            vizcore3d.MeshEdit.MoveVertexToLineProjectionWithBaseSurface();
        }

        private void btnSimplifyAPI_Click(object sender, EventArgs e)
        {
            vizcore3d.MeshEdit.SimplifyMesh();
        }

        private void btnCutSurfaceAPI_Click(object sender, EventArgs e)
        {
            vizcore3d.MeshEdit.CutSurfaceWithBaseSurface();
        }


        // ================================================
        // Event - Mesh Edit (Custom)
        // ================================================
        private void btnMergeBodyCustom_Click(object sender, EventArgs e)
        {
            CustomKind = CustomAPI.MERGE_BODY;

            DisableParam();
            txtBodyIndex1.Enabled = true;
            txtBodyIndex2.Enabled = true;
            btnCustomAPI.Enabled = true;
        }

        private void btnMoveVertexCustom_Click(object sender, EventArgs e)
        {
            CustomKind = CustomAPI.MOVE_VERTEX;

            DisableParam();
            txtBodyIndex1.Enabled = true;
            txtVertex1.Enabled = true;
            txtVertex2.Enabled = true;
            btnCustomAPI.Enabled = true;
        }

        private void btnMoveLineCustom_Click(object sender, EventArgs e)
        {
            CustomKind = CustomAPI.MOVE_LINE;

            DisableParam();
            txtBodyIndex1.Enabled = true;
            txtVertex1.Enabled = true;
            txtVertex2.Enabled = true;
            txtVertex3.Enabled = true;
            lb2.Text = "Line1";
            lb3.Text = "Line2";
            btnCustomAPI.Enabled = true;
        }

        private void btnMoveSurfaceCustom_Click(object sender, EventArgs e)
        {
            CustomKind = CustomAPI.MOVE_SURFACE;

            DisableParam();
            txtBodyIndex1.Enabled = true;
            txtVertex1.Enabled = true;
            txtVertex2.Enabled = true;
            txtVertex3.Enabled = true;
            lb2.Text = "Plane";
            lb3.Text = "Normal";
            btnCustomAPI.Enabled = true;
        }

        private void btnMoveBaseSurfaceCustom_Click(object sender, EventArgs e)
        {
            CustomKind = CustomAPI.MOVE_BASESURFACE;

            DisableParam();
            txtBodyIndex1.Enabled = true;
            txtVertex1.Enabled = true;
            txtVertex2.Enabled = true;
            txtVertex3.Enabled = true;
            txtVertex4.Enabled = true;
            txtVertex5.Enabled = true;
            lb2.Text = "Line1";
            lb3.Text = "Line2";
            lb4.Text = "Plane";
            lb5.Text = "Normal";
            btnCustomAPI.Enabled = true;
        }

        private void btnSimplifyCustom_Click(object sender, EventArgs e)
        {
            CustomKind = CustomAPI.SIMPLIFY;

            DisableParam();
            txtBodyIndex1.Enabled = true;
            ckEnableParam.Enabled = true;
            btnCustomAPI.Enabled = true;
        }

        private void btnCutSurfaceCustom_Click(object sender, EventArgs e)
        {
            CustomKind = CustomAPI.CUT_SURFACE;

            DisableParam();
            txtBodyIndex1.Enabled = true;
            txtBodyIndex2.Enabled = true;
            btnCustomAPI.Enabled = true;
        }

        private void btnCustomAPI_Click(object sender, EventArgs e)
        {
            switch (CustomKind)
            {
                case CustomAPI.MERGE_BODY:
                    CustomMergeBody();
                    break;
                case CustomAPI.MOVE_VERTEX:
                    CustomMoveVertex();
                    break;
                case CustomAPI.MOVE_LINE:
                    CustomMoveLine();
                    break;
                case CustomAPI.MOVE_SURFACE:
                    CustomMoveSurface();
                    break;
                case CustomAPI.MOVE_BASESURFACE:
                    CustomMoveBaseSurface();
                    break;
                case CustomAPI.SIMPLIFY:
                    CustomSimplify();
                    break;
                case CustomAPI.CUT_SURFACE:
                    CustomCutSurface();
                    break;
                default:
                    break;
            }
        }

        private VIZCore3D.NET.Data.Vertex3D GetVertex(TextBox input)
        {
            if (String.IsNullOrEmpty(input.Text) == true) return null;
            string strVertex = input.Text;
            string[] vertex = strVertex.Split(new char[] { ',' });
            if (vertex.Length != 3) return null;

            VIZCore3D.NET.Data.Vertex3D v = new Data.Vertex3D(vertex[0], vertex[1], vertex[2]);
            return v;
        }

        private void CustomMergeBody()
        {
            if (String.IsNullOrEmpty(txtBodyIndex1.Text) == true) return;
            if (String.IsNullOrEmpty(txtBodyIndex2.Text) == true) return;

            int bodyIndex1 = Convert.ToInt32(txtBodyIndex1.Text);
            int bodyIndex2 = Convert.ToInt32(txtBodyIndex2.Text);

            int partIndex1 = vizcore3d.Object3D.GetParentIndex(bodyIndex1);
            int partIndex2 = vizcore3d.Object3D.GetParentIndex(bodyIndex2);

            int meshCount1_1 = vizcore3d.Object3D.GetMeshCount(partIndex1);
            int meshCount1_2 = vizcore3d.Object3D.GetMeshCount(partIndex2);

            if (vizcore3d.Object3D.GetNodeKind(bodyIndex1) != Data.NodeKind.BODY) return;
            if (vizcore3d.Object3D.GetNodeKind(bodyIndex2) != Data.NodeKind.BODY) return;

            vizcore3d.MeshEdit.MergeBody(bodyIndex1, bodyIndex2);

            int meshCount2_1 = vizcore3d.Object3D.GetMeshCount(partIndex1);
            int meshCount2_2 = vizcore3d.Object3D.GetMeshCount(partIndex2);

            MessageBox.Show(string.Format("Before : {0} / {1}\r\n\r\nAfter : {2} / {3}", meshCount1_1, meshCount1_2, meshCount2_1, meshCount2_2), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CustomMoveVertex()
        {
            if (String.IsNullOrEmpty(txtBodyIndex1.Text) == true) return;

            int bodyIndex1 = Convert.ToInt32(txtBodyIndex1.Text);

            if (vizcore3d.Object3D.GetNodeKind(bodyIndex1) != Data.NodeKind.BODY) return;

            VIZCore3D.NET.Data.Vertex3D v1 = GetVertex(txtVertex1);
            VIZCore3D.NET.Data.Vertex3D v2 = GetVertex(txtVertex2);

            if (v1 == null) return;
            if (v2 == null) return;

            vizcore3d.MeshEdit.MoveVertex(bodyIndex1, v1, v2);
        }

        private void CustomMoveLine()
        {
            if (String.IsNullOrEmpty(txtBodyIndex1.Text) == true) return;

            int bodyIndex1 = Convert.ToInt32(txtBodyIndex1.Text);

            if (vizcore3d.Object3D.GetNodeKind(bodyIndex1) != Data.NodeKind.BODY) return;

            VIZCore3D.NET.Data.Vertex3D v = GetVertex(txtVertex1);
            VIZCore3D.NET.Data.Vertex3D line1 = GetVertex(txtVertex2);
            VIZCore3D.NET.Data.Vertex3D line2 = GetVertex(txtVertex3);

            if (v == null) return;
            if (line1 == null) return;
            if (line2 == null) return;

            vizcore3d.MeshEdit.MoveVertexToLineProjection(bodyIndex1, v, line1, line2);
        }

        private void CustomMoveSurface()
        {
            if (String.IsNullOrEmpty(txtBodyIndex1.Text) == true) return;

            int bodyIndex1 = Convert.ToInt32(txtBodyIndex1.Text);

            if (vizcore3d.Object3D.GetNodeKind(bodyIndex1) != Data.NodeKind.BODY) return;

            VIZCore3D.NET.Data.Vertex3D v = GetVertex(txtVertex1);
            VIZCore3D.NET.Data.Vertex3D plane = GetVertex(txtVertex2);
            VIZCore3D.NET.Data.Vertex3D planeNormal = GetVertex(txtVertex3);

            if (v == null) return;
            if (plane == null) return;
            if (planeNormal == null) return;

            vizcore3d.MeshEdit.MoveVertexToLineProjection(bodyIndex1, v, plane, planeNormal);
        }

        private void CustomMoveBaseSurface()
        {
            if (String.IsNullOrEmpty(txtBodyIndex1.Text) == true) return;

            int bodyIndex1 = Convert.ToInt32(txtBodyIndex1.Text);

            if (vizcore3d.Object3D.GetNodeKind(bodyIndex1) != Data.NodeKind.BODY) return;

            VIZCore3D.NET.Data.Vertex3D v = GetVertex(txtVertex1);
            VIZCore3D.NET.Data.Vertex3D line1 = GetVertex(txtVertex2);
            VIZCore3D.NET.Data.Vertex3D line2 = GetVertex(txtVertex3);
            VIZCore3D.NET.Data.Vertex3D plane = GetVertex(txtVertex4);
            VIZCore3D.NET.Data.Vertex3D planeNormal = GetVertex(txtVertex5);

            if (v == null) return;
            if (line1 == null) return;
            if (line2 == null) return;
            if (plane == null) return;
            if (planeNormal == null) return;

            vizcore3d.MeshEdit.MoveVertexToLineProjectionWithBaseSurface(bodyIndex1, v, line1, line2, plane, planeNormal);
        }

        private void CustomSimplify()
        {
            if (String.IsNullOrEmpty(txtBodyIndex1.Text) == true) return;

            int bodyIndex1 = Convert.ToInt32(txtBodyIndex1.Text);

            if (vizcore3d.Object3D.GetNodeKind(bodyIndex1) != Data.NodeKind.BODY) return;

            List<VIZCore3D.NET.Data.Vertex3D> items = VIZCore3D.NET.Data.Vertex3D.GetVertexList(txtVertex1.Text);
            if (items == null) return;
            if (items.Count == 0) return;

            vizcore3d.MeshEdit.SimplifyMesh(bodyIndex1, items, ckEnableParam.Checked);
        }

        private void CustomCutSurface()
        {
            if (String.IsNullOrEmpty(txtBodyIndex1.Text) == true) return;
            if (String.IsNullOrEmpty(txtBodyIndex2.Text) == true) return;

            int bodyIndex1 = Convert.ToInt32(txtBodyIndex1.Text);
            int bodyIndex2 = Convert.ToInt32(txtBodyIndex2.Text);

            if (vizcore3d.Object3D.GetNodeKind(bodyIndex1) != Data.NodeKind.BODY) return;
            if (vizcore3d.Object3D.GetNodeKind(bodyIndex2) != Data.NodeKind.BODY) return;

            vizcore3d.MeshEdit.CutSurfaceWithBaseSurface(bodyIndex1, bodyIndex2);
        }

        private void btnShowOsnap_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            if(String.IsNullOrEmpty(txtOsnapIndex.Text) == true)
            {
                vizcore3d.GeometryUtility.ShowOsnap(
                    false   /* Surface */
                    , true  /* Vertex */
                    , true  /* Line */
                    , true  /* Circle */
                    );
            }
            else
            {
                vizcore3d.GeometryUtility.ShowOsnap(
                    Convert.ToInt32(txtOsnapIndex.Text)
                    , false /* Surface */
                    , true  /* Vertex */
                    , true  /* Line */
                    , true  /* Circle */
                    );
            }
        }

        private void ShowLogEdgeLoop(int index)
        {
            List<VIZCore3D.NET.Data.EdgeLoops> edgeLoop = vizcore3d.MeshEdit.GetEdgeLoops(index);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < edgeLoop.Count; i++)
            {
                sb.AppendLine(string.Format("Vertex Count : {0} EA", edgeLoop[i].Vertex.Count));
                sb.AppendLine("");

                for (int j = 0; j < edgeLoop[i].Vertex.Count; j++)
                {
                    sb.AppendLine(string.Format("{0} : {1}", j + 1, edgeLoop[i].Vertex[j].ToString()));
                }
                sb.AppendLine("");

                sb.AppendLine(string.Format("Edge Loop Count : {0} EA", edgeLoop[i].Loop.Count));
                sb.AppendLine("");

                foreach (KeyValuePair<int, int> item in edgeLoop[i].Loop)
                {
                    sb.AppendLine(string.Format("Loop Vertex Start Index : {0}, Count : {1}", item.Key, item.Value));
                }
                sb.AppendLine("");

                for (int j = 0; j < edgeLoop[i].LoopVertex.Count; j++)
                {
                    VIZCore3D.NET.Data.Vertex3DItemCollection item = edgeLoop[i].LoopVertex[j];

                    sb.AppendLine(string.Format("No: {0} / Count : {1}", j + 1, item.Count));
                    for (int k = 0; k < item.Count; k++)
                    {
                        VIZCore3D.NET.Data.Vertex3D vertex = item[k];
                        sb.AppendLine(string.Format("{0} : {1}", k + 1, vertex.ToString()));
                    }

                    sb.AppendLine("");
                }
            }

            txtEdgeLoop.Text = sb.ToString();
        }

        private void btnDrawEdgeLoop_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEdgeLoopIndex.Text) == true) return;

            int nodeIndex = Convert.ToInt32(txtEdgeLoopIndex.Text);

            vizcore3d.Object3D.Select(new List<int>() { nodeIndex }, false, false);

            List<VIZCore3D.NET.Data.EdgeLoops> edgeLoop = vizcore3d.MeshEdit.GetEdgeLoops(nodeIndex);

            if (edgeLoop.Count == 0) return;

            VIZCore3D.NET.Utility.ColorPaletteHelper palette = new Utility.ColorPaletteHelper("Default");

            vizcore3d.BeginUpdate();

            if (rbDrawLine.Checked == true)
            {
                for (int i = 0; i < edgeLoop.Count; i++)
                {
                    // 전체 한번에 그리기
                    //vizcore3d.ShapeDrawing.AddLine(
                    //    edgeLoop[i].LoopVertex              /* Vertex List */
                    //    , i                                 /* Group Id */
                    //    , palette.GetPaletteColor(i).Color1 /* Color */
                    //    , 3.0f                              /* Thickness */
                    //    , true                              /* Visible */
                    //    );

                    for (int j = 0; j < edgeLoop[i].LoopVertex.Count; j++)
                    {
                        VIZCore3D.NET.Data.Vertex3DItemCollection item = edgeLoop[i].LoopVertex[j];

                        // 개별로 그리기
                        vizcore3d.ShapeDrawing.AddLine(
                            new List<Data.Vertex3DItemCollection>() { item }    /* Vertex List */
                            , j                                                 /* Group Id */
                            , palette.GetPaletteColor(j).Color1                 /* Color */
                            , 3.0f                                              /* Thickness */
                            , true                                              /* Visible */
                            );
                    }
                }
            }
            else if(rbDrawVertex.Checked == true)
            {
                for (int i = 0; i < edgeLoop.Count; i++)
                {
                    for (int j = 0; j < edgeLoop[i].LoopVertex.Count; j++)
                    {
                        VIZCore3D.NET.Data.Vertex3DItemCollection item = edgeLoop[i].LoopVertex[j];

                        vizcore3d.ShapeDrawing.AddVertex(
                            item.BaseCollection
                            , j
                            , palette.GetPaletteColor(j).Color1
                            , 3.0f
                            , 5.0f
                            , true
                            );
                    }
                }
            }

            vizcore3d.EndUpdate();
        }

        private void ckEnableXray_CheckedChanged(object sender, EventArgs e)
        {
            vizcore3d.View.XRay.Enable = ckEnableXray.Checked;
        }
    }
}
