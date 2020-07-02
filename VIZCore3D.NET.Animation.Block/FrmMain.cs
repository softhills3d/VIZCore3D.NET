using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.Animation.Block
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
        /// 애니메이션 키 시간
        /// </summary>
        private float Time = 0;

        /// <summary>
        /// 애니메이션 키 간격
        /// </summary>
        private float TimeInterval = 1.0f;

        private Dictionary<int, List<VIZCore3D.NET.Data.Node>> Nodes = null;

        private Dictionary<int, VIZCore3D.NET.Data.Vertex3D> CenterPoint = null;

        public bool TestMode
        {
            get
            {
                string name = System.Environment.MachineName.ToUpper();

                if (name == "GJKIM-DELL" || name == "GJKIM-PC") return true;
                else return false;
            }
        }

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
            vizcore3d.ToolbarMain.Visible = true;
            vizcore3d.ToolbarNote.Visible = false;
            vizcore3d.ToolbarMeasure.Visible = false;
            vizcore3d.ToolbarSection.Visible = false;
            vizcore3d.ToolbarClash.Visible = false;
            vizcore3d.ToolbarAnimation.Visible = true;
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

        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            // 재생 위치 변경
            vizcore3d.Animation.OnAnimationPlaybackPositionChangedEvent += Animation_OnAnimationPlaybackPositionChangedEvent;

            // 재생 종료
            vizcore3d.Animation.OnAnimationPlaybackFinishedEvent += Animation_OnAnimationPlaybackFinishedEvent;
        }

        private void Animation_OnAnimationPlaybackPositionChangedEvent(object sender, Event.EventManager.AnimationPlaybackPositionEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(string.Format("OnAnimationPlaybackPositionChangedEvent - ID : {0} / Time : {1}", e.ID, e.Time));
        }

        private void Animation_OnAnimationPlaybackFinishedEvent(object sender, Event.EventManager.AnimationPlaybackEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(string.Format("OnAnimationPlaybackFinishedEvent - ID : {0}", e.ID));
        }



        // ================================================
        // Basic Model
        // ================================================
        private void btnLoadBlock_Click(object sender, EventArgs e)
        {
            if(TestMode == false)
            {
                vizcore3d.Model.AddFileDialog();
            }
            else
            {
                //string path = @"C:\Users\gjkim\Desktop\MODELS_ANIMATION\FIXED_V3_SIMPLEFIED_V2";
                string path = @"C:\Users\Gjkim\Desktop\MODELS\H6501_REV_FIXED\FIXED_V3_SIMPLEFIED_V2";
                string[] file = System.IO.Directory.GetFiles(path, "*.viz");
                vizcore3d.Model.Add(file);
            }
        }

        private void btnCreateDock_Click(object sender, EventArgs e)
        {
            Data.Vertex3D center = new Data.Vertex3D();
            if (vizcore3d.Model.IsOpen() == true)
            {
                Data.BoundBox3D boundbox = vizcore3d.Model.BoundBox;
                center = boundbox.GetCenter();
            }
            else
            {
                center.X = 87614.0f;
                center.Y = 478.0f;
                center.Z = 21646.0f;
            }

            center.Z = center.Z - (center.Z * 0.9f);

            vizcore3d.Primitive.OpenCustomShapeDock(
                "DOCK_MODEL"                                /* MODEL NAME */
                , 8                                         /* COLOR INDEX */
                , center                                    /* CENTER */
                , new Data.Vertex3D(195000, 40000, 13000)   /* Axis Length */
                , 40000                                     /* Ground Length */
                , 1000                                      /* Thickness */
                );

            List<Data.Node> dock = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "DOCK", "GROUND" }, false, true, false, false, true, false);
            vizcore3d.Object3D.Color.SetTransparency(dock, 70);
        }

        private void btnLoadCrane_Click(object sender, EventArgs e)
        {
            if (TestMode == false)
            {
                vizcore3d.Model.AddFileDialog();
            }
            else
            {
                //string path = @"C:\Users\gjkim\Desktop\MODELS_ANIMATION\MISC\CRANE_ASSEMBLY_2";
                string path = @"C:\Users\Gjkim\Desktop\MODELS\MISC\CRANE_ASSEMBLY_2";
                string[] file = System.IO.Directory.GetFiles(path, "*.viz");
                vizcore3d.Model.Add(file);
            }
        }

        private int MaterialID = -1;
        private void btnSetMaterialDock_Click(object sender, EventArgs e)
        {
            vizcore3d.BeginUpdate();

            List<Data.Node> ground = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { "GROUND" }, false, true, false, false, true, false);
            if (ground.Count == 0) return;

            List<Data.Node> items = vizcore3d.Object3D.GetChildObject3d(ground[0].Index, Data.Object3DChildOption.CHILD_ONLY);

            vizcore3d.ShapeDrawing.DepthTest = true;

            List<int> customBox = new List<int>();
            foreach (Data.Node item in items)
            {
                VIZCore3D.NET.Data.BoundBox3D boundbox =
                         vizcore3d.Object3D.GeometryProperty.FromIndex(item.Index).GetBoundBox();
                int id = vizcore3d.ShapeDrawing.AddBox(
                              boundbox
                              , 1
                              , System.Drawing.Color.Gray
                              , true
                              );

                customBox.Add(id);
            }

            string image = "D:\\Concrete-Texture.jpg";
            if(MaterialID == -1)
                MaterialID = vizcore3d.Object3D.Material.Add(image);

            foreach (int item in customBox)
            {
                vizcore3d.ShapeDrawing.SetMaterial(item, MaterialID);
            }

            vizcore3d.EndUpdate();
        }

        private void btnGenerateAnimation_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            // 모델 데이터 맵핑
            GetNodes();
            CenterPoint = new Dictionary<int, Data.Vertex3D>();

            vizcore3d.View.EnableAutoFit = false;                                    /* 자동 화면맞춤 비활성 */
            //vizcore3d.View.Projection = VIZCore3D.NET.Data.Projections.Perspective;  /* 원근 뷰 설정 */
            vizcore3d.Animation.UseEffect = false;                                   /* 기본 효과 사용안함 설정 */

            vizcore3d.Animation.Clear();
            vizcore3d.Animation.Add("Animation");

            //vizcore3d.ShowWaitForm();

            vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
            VIZCore3D.NET.Data.Vertex3D bay = new Data.Vertex3D(83772, -41271, 8664);

            vizcore3d.BeginUpdate();

            foreach (KeyValuePair<int, List<VIZCore3D.NET.Data.Node>> item in Nodes)
            {
                if (item.Key == -2) continue;
                if (item.Key == -1) continue;
                if (item.Key == 0) continue;

                VIZCore3D.NET.Data.Object3DProperty prop = vizcore3d.Object3D.GeometryProperty.FromNode(Nodes[item.Key], false);

                if (CenterPoint.ContainsKey(item.Key) == false)
                    CenterPoint.Add(item.Key, prop.CenterPoint);

                vizcore3d.Object3D.Transform.Move(
                Nodes[item.Key]
                , bay.X - prop.CenterPoint.X
                , bay.Y - prop.CenterPoint.Y
                , bay.Z - prop.MinPoint.Z
                , false
                );
            }

            foreach (KeyValuePair<int, List<VIZCore3D.NET.Data.Node>> item in Nodes)
            {
                if (item.Key == -2) continue;
                if (item.Key == -1) continue;
                if (item.Key == 0) continue;

                vizcore3d.Object3D.Show(item.Value, false);
            }


            // 애니메이션 키 추가
            AddKey(true, true);

            for (int i = 1; i < 13; i++)
            {
                // 블록 조회
                vizcore3d.Object3D.Show(Nodes[i], true);

                // 애니메이션 키 추가
                AddKey(true, true);

                // 크레인 위치 확인
                VIZCore3D.NET.Data.Vertex3D tranc = vizcore3d.Object3D.Transform.GetMovedDistance(Nodes[-1]);

                // 크레인 이동 (BAY)
                vizcore3d.Object3D.Transform.Move(Nodes[-1], new VIZCore3D.NET.Data.Vertex3D(bay.X, 0.0f, 0.0f), true);

                // 애니메이션 키 추가
                AddKey(true, true);


                // 블록 Bring To Top
                VIZCore3D.NET.Data.Vertex3D tran1 = vizcore3d.Object3D.Transform.GetMovedDistance(Nodes[i]);

                // 블록
                VIZCore3D.NET.Data.Vertex3D tran2 = new VIZCore3D.NET.Data.Vertex3D(tran1.X, tran1.Y, tran1.Z + 20000);
                vizcore3d.Object3D.Transform.Move(Nodes[i], tran2, true);

                // 애니메이션 키 추가
                AddKey(true, true);

                // 블록
                VIZCore3D.NET.Data.Vertex3D tran3 = new VIZCore3D.NET.Data.Vertex3D(tran2.X, CenterPoint[i].Y, tran2.Z);
                vizcore3d.Object3D.Transform.Move(Nodes[i], tran3, true);

                // 크레인 이동 (BAY)
                //vizcore3d.Object3D.Transform.Move(Nodes[-1], new VIZCore3D.NET.Data.Vertex3D(tran3.X, 0.0f, 0.0f), true);

                // 애니메이션 키 추가
                AddKey(true, true);

                // 블록
                VIZCore3D.NET.Data.Vertex3D tran4 = new VIZCore3D.NET.Data.Vertex3D(0, CenterPoint[i].Y, tran3.Z);
                vizcore3d.Object3D.Transform.Move(Nodes[i], tran4, true);

                // 크레인 이동 (BAY)
                //vizcore3d.Object3D.Transform.Move(Nodes[-1], new VIZCore3D.NET.Data.Vertex3D(tran4.X, 0.0f, 0.0f), true);
                vizcore3d.Object3D.Transform.Move(Nodes[-1], new VIZCore3D.NET.Data.Vertex3D(CenterPoint[i].X, 0.0f, 0.0f), true);

                // 애니메이션 키 추가
                AddKey(true, true);

                // 블록
                vizcore3d.Object3D.Transform.RestoreTransform(Nodes[i]);

                // 애니메이션 키 추가
                AddKey(true, true);
            }

            AddKey(true, true);

            vizcore3d.EndUpdate();

            //vizcore3d.CloseWaitForm();

            MessageBox.Show("Animation Created.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// 애니메이션 키 추가
        /// </summary>
        public void AddKey(bool modelKey = true, bool cameraKey = false)
        {
            if (cameraKey)
                vizcore3d.Animation.AddKey(Time, VIZCore3D.NET.Manager.AnimationManager.AnimationKeyType.CAMERA);

            if (modelKey)
                vizcore3d.Animation.AddKey(Time, VIZCore3D.NET.Manager.AnimationManager.AnimationKeyType.MODEL);

            Time += TimeInterval;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            vizcore3d.Animation.PlayingTime = Time;

            vizcore3d.View.RealtimeShadow = true;
            vizcore3d.View.EnvironmentLight = true;
            vizcore3d.View.AntiAliasing = true;

            if (vizcore3d.View.Projection == Data.Projections.Orthographic)
                vizcore3d.View.Projection = VIZCore3D.NET.Data.Projections.Perspective;  /* 원근 뷰 설정 */

            vizcore3d.Animation.Play(false, 0);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            vizcore3d.Animation.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
        }

        private void btnShowGroup_Click(object sender, EventArgs e)
        {
            vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.View.XRay.Clear();

            int index = cbGroup.SelectedIndex;

            if (index == -1) return;

            if (GetGroup().ContainsKey(index + 1) == false) return;

            GetNodes();

            List<VIZCore3D.NET.Data.Node> nodes = Nodes[index + 1];

            vizcore3d.Object3D.Select(nodes, true, true);
            vizcore3d.View.XRay.Select(nodes, true, false);
        }

        private void GetNodes()
        {
            if (Nodes == null)
                Nodes = new Dictionary<int, List<Data.Node>>();
            else
                return;

            foreach (KeyValuePair<int, List<string>> item in GetGroup())
            {
                List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(GetGroup()[item.Key], false, true, false, false, true, false);

                Nodes.Add(item.Key, nodes);
            }
        }

        private Dictionary<int, List<string>> GetGroup()
        {
            Dictionary<int, List<string>> map = new Dictionary<int, List<string>>();

            {
                List<string> items = new List<string>() { "CRANE_LIFT" };
                map.Add(-2, items);
            }

            {
                List<string> items = new List<string>() { "CRANE_LIFT", "CRANE_SHELL" };
                map.Add(-1, items);
            }

            {
                List<string> items = new List<string>() { "DOCK_MODEL" };
                map.Add(0, items);
            }

            {
                List<string> items = new List<string>() {"101", "103", "104", "110"};
                map.Add(1, items);
            }

            {
                List<string> items = new List<string>() {"111", "121", "122", "131", "132", "141", "142", "151", "152"};
                map.Add(2, items);
            }

            {
                List<string> items = new List<string>() { "113", "123", "133", "143", "153"};
                map.Add(3, items);
            }

            {
                List<string> items = new List<string>() { "124", "125", "134", "135", "144", "154" };
                map.Add(4, items);
            }

            {
                List<string> items = new List<string>() { "201", "222", "232", "501", "502", "621", "622", "631", "632", "641", "651" };
                map.Add(5, items);
            }

            {
                List<string> items = new List<string>() { "223", "224", "233", "234", "503", "504", "623", "624", "633", "634" };
                map.Add(6, items);
            }

            {
                List<string> items = new List<string>() { "225", "226", "235", "236", "505", "625", "626", "635", "636" };
                map.Add(7, items);
            }

            {
                List<string> items = new List<string>() { "208", "227", "237", "506", "507", "508", "627", "628", "637", "638" };
                map.Add(8, items);
            }

            {
                List<string> items = new List<string>() { "209", "629", "639", "801", "802", "803", "804", "810", "824", "825", "834", "835" };
                map.Add(9, items);
            }

            {
                List<string> items = new List<string>() { "301", "311", "321", "331" };
                map.Add(10, items);
            }

            {
                List<string> items = new List<string>() { "310", "312", "313" };
                map.Add(11, items);
            }

            {
                List<string> items = new List<string>() { "302", "303", "304", "305" };
                map.Add(12, items);
            }

            return map;
        }

        
    }
}
