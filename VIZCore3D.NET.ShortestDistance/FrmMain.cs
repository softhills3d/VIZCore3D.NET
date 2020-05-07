using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.ShortestDistance
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
            VIZCore3D.NET.Data.LicenseResults result = vizcore3d.License.LicenseFile("C:\\License\\VIZCore3D.NET.lic");
            //VIZCore3D.NET.Data.LicenseResults result = vizcore3d.License.LicenseServer("127.0.0.1", 8901);
            //VIZCore3D.NET.Data.LicenseResults result = vizcore3d.License.LicenseServer("192.168.0.215", 8901);
            if (result != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            {
                MessageBox.Show(string.Format("LICENSE CODE : {0}", result.ToString()), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            vizcore3d.View.BeginUpdate();


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
            vizcore3d.View.EnablePreSelect = false;

            // 모델 조회 시, Pre-Select 색상 설정
            vizcore3d.View.PreSelectColor = Color.Lime;
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
            vizcore3d.Review.Note.BackgroundColor = Color.White;
            // 배경 투명
            vizcore3d.Review.Note.BackgroudTransparent = false;
            // 글자색
            vizcore3d.Review.Note.FontColor = Color.Black;
            // 글자 크기
            vizcore3d.Review.Note.FontSize = VIZCore3D.NET.Manager.NoteManager.FontSizeKind.SIZE12;
            // 글자 굵게
            vizcore3d.Review.Note.FontBold = false;
            // 지시선(라인) 색상
            vizcore3d.Review.Note.LineColor = Color.Black;
            // 지시선(라인) 두께
            vizcore3d.Review.Note.LineWidth = 3;
            // 지시선 중앙 연결
            vizcore3d.Review.Note.LinkArrowTailToText = VIZCore3D.NET.Manager.NoteManager.LinkArrowTailToTextKind.END;
            // 화살표 색상
            vizcore3d.Review.Note.ArrowColor = Color.Red;
            // 화살표 두께
            vizcore3d.Review.Note.ArrowWidth = 10;

            // 심볼 배경색
            vizcore3d.Review.Note.SymbolBackgroundColor = Color.Yellow;
            // 심볼 글자색
            vizcore3d.Review.Note.SymbolFontColor = Color.Red;
            // 심볼 크기
            vizcore3d.Review.Note.SymbolSize = 10;
            // 심볼 글자 크기
            vizcore3d.Review.Note.SymbolFontSize = VIZCore3D.NET.Manager.NoteManager.FontSizeKind.SIZE10;
            // 심볼 글자 굵게
            vizcore3d.Review.Note.SymbolFontBold = true;
            #endregion


            // ================================================================
            // 설정 - 측정
            // ================================================================



            // ================================================================
            // 설정 - 단면
            // ================================================================
            // 단면 좌표간격으로 이동
            vizcore3d.Section.MoveSectionByFrameGrid = true;


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
            vizcore3d.View.EndUpdate();
        }
        #endregion

        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            vizcore3d.Object3D.OnSelectedObject3D += Object3D_OnSelectedObject3D;

            vizcore3d.GeometryUtility.OnOsnapPickingItem += GeometryUtility_OnOsnapPickingItem;
            vizcore3d.GeometryUtility.OnNearestObjectByPicking += GeometryUtility_OnNearestObjectByPicking;
        }

        private void Object3D_OnSelectedObject3D(object sender, VIZCore3D.NET.Event.EventManager.SelectedObject3DEventArgs e)
        {

        }

        private void GeometryUtility_OnOsnapPickingItem(object sender, Event.EventManager.OsnapPickingItemEventArgs e)
        {
            bool visibleOnly = ckVisibleOnly.Checked;
            bool opaqueOnly = ckOpaqueOnly.Checked;

            VIZCore3D.NET.Data.Vertex3D point = e.Point;

            vizcore3d.ShowWaitForm();

            vizcore3d.BeginUpdate();

            if (ckXPlus.Checked == true)
                GetNearestObject(Data.AxisDirection.X_PLUS, point, visibleOnly, opaqueOnly);
            if(ckXMinus.Checked == true)
                GetNearestObject(Data.AxisDirection.X_MINUS, point, visibleOnly, opaqueOnly);
            if (ckYPlus.Checked == true)
                GetNearestObject(Data.AxisDirection.Y_PLUS, point, visibleOnly, opaqueOnly);
            if (ckYMinus.Checked == true)
                GetNearestObject(Data.AxisDirection.Y_MINUS, point, visibleOnly, opaqueOnly);
            if (ckZPlus.Checked == true)
                GetNearestObject(Data.AxisDirection.Z_PLUS, point, visibleOnly, opaqueOnly);
            if (ckZMinus.Checked == true)
                GetNearestObject(Data.AxisDirection.Z_MINUS, point, visibleOnly, opaqueOnly);

            vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.EndUpdate();

            vizcore3d.CloseWaitForm();
        }

        private void GetNearestObject(VIZCore3D.NET.Data.AxisDirection axis, VIZCore3D.NET.Data.Vertex3D pt, bool visibleOnly, bool opaqueOnly)
        {
            VIZCore3D.NET.Data.NearestObjectByAxisPoint sdpt = vizcore3d.GeometryUtility.GetNearestObject(
                axis
                , pt
                , visibleOnly
                , opaqueOnly
                );

            if (sdpt.Index == -1) return;

            List<VIZCore3D.NET.Data.Vertex3DItemCollection> vertex = new List<VIZCore3D.NET.Data.Vertex3DItemCollection>();
            VIZCore3D.NET.Data.Vertex3DItemCollection item = new VIZCore3D.NET.Data.Vertex3DItemCollection();
            item.Add(pt);
            item.Add(sdpt.CollisionPoint);
            vertex.Add(item);


            int lineId = vizcore3d.ShapeDrawing.AddLine(
                    vertex
                    , sdpt.Index
                    , Color.Red
                    , 5.0f
                    , true
                    );

            //int vertexId = vizcore3d.ShapeDrawing.AddVertex(
            //        new List<VIZCore3D.NET.Data.Vertex3D>() { pt, sdpt.CollisionPoint }
            //        , sdpt.Index
            //        , Color.Red
            //        , 5.0f
            //        , 7.0f
            //        , true
            //        );

            string noteText = string.Format(
                "[{0}]{1}\r\nDistance: {2}\r\nCollision: {3}"
                , sdpt.Index
                , vizcore3d.Object3D.FromIndex(sdpt.Index).NodeName
                , sdpt.Distance.ToString()
                , sdpt.CollisionPoint.ToString()
                );
            VIZCore3D.NET.Data.Vertex3D text = new Data.Vertex3D(
                sdpt.CollisionPoint.X
                , sdpt.CollisionPoint.Y
                , sdpt.CollisionPoint.Z + 500
                );
            int surfaceNoteId = vizcore3d.Review.Note.AddNoteSurface(
                noteText
                , text
                , sdpt.CollisionPoint
                );
        }

        private void GeometryUtility_OnNearestObjectByPicking(object sender, Event.EventManager.NearestObjectByPickingEventArgs e)
        {
            string str = string.Format(
                "X+: {0}\r\nX-: {1}\r\nY+: {2}\r\nY-: {3}\r\nZ+: {4}\r\nZ-: {5}"
                , GetNodeName(e.XPlusIndex, true)
                , GetNodeName(e.XMinusIndex, true)
                , GetNodeName(e.YPlusIndex, true)
                , GetNodeName(e.YMinusIndex, true)
                , GetNodeName(e.ZPlusIndex, true)
                , GetNodeName(e.ZMinusIndex, true)
                );

            MessageBox.Show(str);
        }

        private string GetNodeName(int index, bool appendIndex)
        {
            if (index == -1) return "-1";

            Data.Node node = vizcore3d.Object3D.FromIndex(index);
            if (appendIndex == true)
                return string.Format("{0} ({1})", node.NodeName, index);
            else
                return string.Format("{0}", node.NodeName);
        }

        private void btnShowOsnap_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(Data.Object3dFilter.SELECTED_TOP);

            // 개체 선택 방식
            if (items.Count == 0)
            {
                vizcore3d.GeometryUtility.ShowOsnap(
                    ckSurface.Checked
                    , ckVertex.Checked
                    , false
                    , false
                    );
            }
            // 개체 지정 방식
            else
            {
                vizcore3d.GeometryUtility.ShowOsnap(
                    items[0].Index
                    , ckSurface.Checked
                    , ckVertex.Checked
                    , false
                    , false
                    );
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            vizcore3d.GeometryUtility.GetNearestObjectsByPicking(
                ckXPlus.Checked
                , ckXMinus.Checked
                , ckYPlus.Checked
                , ckYMinus.Checked
                , ckZPlus.Checked
                , ckZMinus.Checked
                );
        }
    }
}
