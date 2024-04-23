using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using VIZCore3D.NET.Data;

namespace VIZCore3D.NET.Simulation
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

        private List<TranslateInfo> pathItems = new List<TranslateInfo>();
        private VIZCore3D.NET.Data.ClashTest clash;
        private List<VIZCore3D.NET.Data.Node> groupA = new List<Node>();
        private int progressIndex = 0;
        private float Time = 0;
        private List<Vertex3D> hotPoints = new List<Vertex3D>();
        List<ClashResultSymbols> symbols = new List<ClashResultSymbols>();

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
            vizcore3d.ToolbarAnimation.Visible = true;
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
            vizcore3d.Clash.OnClashTestFinishedEvent += Clash_OnClashTestFinishedEvent;
            vizcore3d.Animation.OnAnimationPlaybackFinishedEvent += Animation_OnAnimationPlaybackFinishedEvent;
        }

        private void Clash_OnClashTestFinishedEvent(object sender, VIZCore3D.NET.Event.EventManager.ClashEventArgs e)
        {
            this.Invoke(new EventHandler(delegate
            {
                ShowResult();
            }));

            this.Activate();
        }

        private void Animation_OnAnimationPlaybackFinishedEvent(object sender, Event.EventManager.AnimationPlaybackEventArgs e)
        {
            vizcore3d.Object3D.Transform.RestoreTransformAll();

            if (ckClashTest.Checked)
            {
                vizcore3d.ShowProgressForm();
                Thread thread = new Thread(() => StartClashTest());
                thread.Start();
            }
        }

        private void View_OnViewDefaultMouseDownEvent(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            VIZCore3D.NET.Data.PickedSurfaceData data = vizcore3d.View.GetPickedSurfaceNormalVector(e.X, e.Y);

            // 선택된 부재가 없음
            if (data.Picked == false) return;

            // 표면점이 없음
            if (data.Surface == false) return;

            // 선택된 지점
            VIZCore3D.NET.Data.Vertex3D position = data.Position;

            lvPath.BeginUpdate();
            ListViewItem lvi = new ListViewItem(new string[] { (lvPath.Items.Count + 1).ToString(), position.X.ToString(), position.Y.ToString(), position.Z.ToString() });
            lvPath.Items.Add(lvi);
            lvPath.EndUpdate();

            vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
        }
        #endregion

        private void btnImportYard_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\Models\\VIZCore3D.NET.Simulation\\YARD", vizcore3d.GetEntryAssemblyPath());

            if (System.IO.Directory.Exists(path) == true)
            {
                string[] file = System.IO.Directory.GetFiles(path, "*.viz");
                vizcore3d.Model.Add(file);
            }
            else
            {
                vizcore3d.Model.AddFileDialog();
            }
        }

        private void btnImportTransporter_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\Models\\VIZCore3D.NET.Simulation\\TRANSPORTER", vizcore3d.GetEntryAssemblyPath());

            if (System.IO.Directory.Exists(path) == true)
            {
                string[] file = System.IO.Directory.GetFiles(path, "*.viz");
                vizcore3d.Model.Add(file);
            }
            else
            {
                vizcore3d.Model.AddFileDialog();
            }
        }

        private void btnImportBlock_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\Models\\VIZCore3D.NET.Simulation\\BLOCK", vizcore3d.GetEntryAssemblyPath());

            if (System.IO.Directory.Exists(path) == true)
            {
                string[] file = System.IO.Directory.GetFiles(path, "*.viz");
                vizcore3d.Model.Add(file);
            }
            else
            {
                vizcore3d.Model.AddFileDialog();
            }
        }

        private void btnSetGroup_Click(object sender, EventArgs e)
        {
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.SELECTED_TOP);
            if (items.Count == 0)
            {
                MessageBox.Show("선택된 항목이 없습니다.", "VIZCore3D.NET.Simulation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupA = items;

            MessageBox.Show("선택된 모델을 그룹에 설정 하였습니다.", "VIZCore3D.NET.Simulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
        }

        private void ckSetPath_CheckedChanged(object sender, EventArgs e)
        {
            if(ckSetPath.Checked == true)
            {
                vizcore3d.View.OnViewDefaultMouseDownEvent += View_OnViewDefaultMouseDownEvent;
                vizcore3d.View.SelectionMode = VIZCore3D.NET.Data.Object3DSelectionOptions.NOT_HIGHLIGHT;
            }
            else
            {
                vizcore3d.View.OnViewDefaultMouseDownEvent -= View_OnViewDefaultMouseDownEvent;
                vizcore3d.View.SelectionMode = VIZCore3D.NET.Data.Object3DSelectionOptions.HIGHLIGHT_COLOR;
            }
        }

        private void btnDeletePath_Click(object sender, EventArgs e)
        {
            if (lvPath.SelectedItems.Count == 0) return;

            lvPath.Items.Remove(lvPath.SelectedItems[0]);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvPath.BeginUpdate();
            lvPath.Items.Clear();
            lvPath.EndUpdate();
        }

        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            if (groupA.Count == 0)
            {
                MessageBox.Show("Group을 설정 하십시오.", "VIZCore3D.NET.Simulation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if(lvPath.Items.Count == 0)
            {
                MessageBox.Show("Path를 설정 하십시오.", "VIZCore3D.NET.Simulation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                pathItems.Clear();
                symbols.Clear();
                vizcore3d.Object3D.Transform.RestoreTransformAll();
                ResultViewClear();

                VIZCore3D.NET.Data.Object3DProperty prop = groupA[0].GetGeometryProperty();
                
                // 출발 지점 추가
                List<Vertex3D> vertices = new List<Vertex3D>();
                Vertex3D startPoint = new Vertex3D(prop.CenterPoint.X, prop.CenterPoint.Y, prop.CenterPoint.Z);
                vertices.Add(startPoint);

                // Set Path 목록 항목 추가
                for (int i = 0; i < lvPath.Items.Count; i++)
                {
                    ListViewItem item = lvPath.Items[i];
                    Vertex3D vertex = new Vertex3D(Convert.ToSingle(item.SubItems[1].Text), Convert.ToSingle(item.SubItems[2].Text), Convert.ToSingle(item.SubItems[3].Text));
                    vertices.Add(vertex);
                }

                int count = vertices.Count;
                for (int i = 0; i < count; i++)
                {
                    if (i + 1 >= count)
                        continue;

                    // Set Move
                    float x = vertices[i + 1].X - vertices[i].X;
                    float y = vertices[i + 1].Y - vertices[i].Y;
                    float z = 0f;

                    TranslateInfo path = new TranslateInfo(true, x, y, z);
                    pathItems.Add(path);

                    // Set Rotate
                    if (i + 2 < count)
                    {
                        Vector3D vDir1 = Vector3D.GetDirectionVector(vertices[i + 2], vertices[i + 1]);
                        Vector3D vDir2 = Vector3D.GetDirectionVector(vertices[i + 1], vertices[i]);

                        float angle = vDir1.GetAngleBetweenVectorInDegree(vDir2);

                        if(angle != 0)      // 두 방향 벡터 사잇각이 0이 아니면 Rotate
                        {
                            TranslateInfo path2 = new TranslateInfo(false, 0, 0, angle);
                            pathItems.Add(path2);
                        }
                    }                            
                }
            }    

            progressIndex = 0;
            vizcore3d.Clash.Clear();
            clash = new Data.ClashTest();

            ShowAnimation();   
        }

        private void ShowAnimation()
        {
            if (groupA.Count == 0 || pathItems == null || pathItems.Count == 0)
                return;

            vizcore3d.BeginUpdate();

            vizcore3d.Object3D.Transform.RestoreTransformAll();
            vizcore3d.Animation.Clear();

            VIZCore3D.NET.Data.Animation animation = vizcore3d.Animation.Add("Test");
            int id = animation.ID;

            Time = 0;

            AddKey(true, false, 0);

            for (int i = 0; i < pathItems.Count; i++)
            {
                if (pathItems[i].IsMove == true)
                {
                    vizcore3d.Object3D.Transform.Move(groupA, pathItems[i].X, pathItems[i].Y, pathItems[i].Z, false);
                    AddKey(true, false, 5);
                }     
                else
                {
                    vizcore3d.Object3D.Transform.Rotate(groupA, pathItems[i].X, pathItems[i].Y, pathItems[i].Z, false);
                    AddKey(true, false, 1);
                }                
            }

            vizcore3d.Object3D.Transform.RestoreTransformAll();
            vizcore3d.EndUpdate();

            // Play
            vizcore3d.Animation.PlayingTime = Time;

            vizcore3d.View.RealtimeShadow = true;
            vizcore3d.View.EnvironmentLight = true;
            vizcore3d.View.AntiAliasing = true;

            vizcore3d.Animation.Select(id);
            vizcore3d.Animation.Play(false, 0);
        }

        // 애니메이션 키 추가
        public void AddKey(bool modelKey, bool cameraKey, float internval)
        {
            Time += internval;

            if (cameraKey)
                vizcore3d.Animation.AddKey(Time, VIZCore3D.NET.Manager.AnimationManager.AnimationKeyType.CAMERA);

            if (modelKey)
                vizcore3d.Animation.AddKey(Time, VIZCore3D.NET.Manager.AnimationManager.AnimationKeyType.MODEL);
        }

        private void StartClashTest()
        {
            if (pathItems == null || pathItems.Count == 0)
            {
                MessageBox.Show("Path를 설정 해주세요.", "VIZCore3D.NET.Simulation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            vizcore3d.BeginUpdate();
            vizcore3d.Object3D.Transform.RestoreTransformAll();

            for (int i = 0; i <= progressIndex; i++)
            {
                if (pathItems[i].IsMove == true)
                {
                    vizcore3d.Object3D.Transform.Move(groupA, pathItems[i].X, pathItems[i].Y, pathItems[i].Z, false);
                }
                else
                {
                    vizcore3d.Object3D.Transform.Rotate(groupA, pathItems[i].X, pathItems[i].Y, pathItems[i].Z, false);
                }
            }
            vizcore3d.EndUpdate();

            clash.Name = "CLASH TEST";
            clash.TestKind = VIZCore3D.NET.Data.ClashTest.ClashTestKind.SELECTED_MODEL_VS_OTHER;

            clash.GroupA = groupA;

            clash.UseClearanceValue = false;                            // 여유허용범위
            clash.ClearanceValue = 0.0f;                                // 여유허용범위
            clash.UseRangeValue = true;                                 // 근접허용범위
            clash.RangeValue = 2.0f;                                    // 근접허용범위
            clash.UsePenetrationTolerance = true;                       // 접촉허용오차
            clash.PenetrationTolerance = 1.0f;                          // 접촉허용오차

            clash.VisibleOnly = true;
            clash.BottomLevel = 2;

            vizcore3d.Clash.Clear();
            bool result = vizcore3d.Clash.Add(clash);
            
            if(result)
            {
                vizcore3d.Clash.EnableMultiThread = false;
                vizcore3d.Clash.PerformInterferenceCheck(clash.ID, false);
            }      
        }

        private void ShowResult()
        {
            List<VIZCore3D.NET.Data.ClashTestResultItem> items = null;

            items = vizcore3d.Clash.GetResultItem(
                clash
                , true
                ? VIZCore3D.NET.Manager.ClashManager.ResultGroupingOptions.ASSEMBLY
                : VIZCore3D.NET.Manager.ClashManager.ResultGroupingOptions.PART
                );

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == null)
                    return;

                VIZCore3D.NET.Data.Vertex3D hotPoint = new VIZCore3D.NET.Data.Vertex3D();
                hotPoint.X = items[i].HotPoint.X;
                hotPoint.Y = items[i].HotPoint.Y;
                hotPoint.Z = items[i].HotPoint.Z;

                hotPoints.Add(hotPoint);
                symbols.Add(ClashResultSymbols.Triangle);
            }

            vizcore3d.BeginUpdate();

            // Add Result Symbol
            vizcore3d.Clash.ShowResultSymbol(
                hotPoints
                , symbols
                , 10.0f
                , true
                , Color.Yellow
                , false
                );

            vizcore3d.EndUpdate();

            progressIndex++;
            if (progressIndex < pathItems.Count)
            {
                Thread thread = new Thread(() => StartClashTest());
                thread.Start();
            }
            else
            {
                progressIndex = 0;
                vizcore3d.CloseProgressForm();
            }
        }

        private void ResultViewClear()
        {
            vizcore3d.BeginUpdate();

            // Clear Selection/HotPoint/Note
            vizcore3d.View.XRay.Clear();
            vizcore3d.ShapeDrawing.Clear();
            vizcore3d.Clash.ClearResultSymbol();

            vizcore3d.EndUpdate();
        }

        private void btnClearSimulation_Click(object sender, EventArgs e)
        {
            vizcore3d.Animation.Pause();
            vizcore3d.Object3D.Transform.RestoreTransformAll();

            ResultViewClear();
            
            lvPath.Items.Clear();
            pathItems.Clear();
            symbols.Clear();

            groupA.Clear();
        }

        public class TranslateInfo
        {
            public bool IsMove { get; set; }
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }

            public TranslateInfo()
            {
                IsMove = true;
                X = 0f;
                Y = 0f;
                Z = 0f;
            }

            public TranslateInfo(bool isMove, float x = 0, float y = 0, float z = 0)
            {
                IsMove = isMove;
                X = x;
                Y = y;
                Z = z;
            }
        }
    }
}
