using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.Demo
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
        /// 노드 목록 조회용 다이얼로그
        /// </summary>
        private Dialogs.NodeDialog nodeDialog;

        /// <summary>
        /// 노드 보이기/숨기기 및 로드/언로드 테스트 다이얼로그
        /// </summary>
        private Dialogs.Object3dTestDialog object3dTestDialog;

        /// <summary>
        /// 화면 메시지 출력 상태
        /// </summary>
        public bool EnableMessage { get; set; }


        // ================================================
        // Construction
        // ================================================
        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            // Construction
            vizcore3d = new VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            panelView.Controls.Add(vizcore3d);

            // Event
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;

            // GUI
            nodeDialog = null;

            // Message
            EnableMessage = false;
        }


        // ================================================
        // Event - VIZCore3D.NET
        // ================================================
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
            if (result != Data.LicenseResults.SUCCESS)
            {
                MessageBox.Show(string.Format("LICENSE CODE : {0}", result.ToString()), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Init. VIZCore3D.NET
            InitializeVIZCore3D();
            InitializeVIZCore3DEvent();
        }

        
        private void Model_OnModelProgressChangedEvent(object sender, VIZCore3D.NET.Event.EventManager.ModelProgressEventArgs e)
        {
            //e.Progress;
        }


        /// <summary>
        /// 개체 선택 이벤트
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">Event Args</param>
        private void Object3D_OnSelectedObject3D(object sender, Event.EventManager.SelectedObject3DEventArgs e)
        {
            if(e.Node.Count > 0)
            {
                // 선택된 개체가 있음
                //MessageBox.Show(e.Node.Count.ToString());

                if (EnableMessage == true)
                {
                    vizcore3d.BeginUpdate();
                    Data.Object3DProperty prop = vizcore3d.Object3D.GeometryProperty.FromIndex(e.Node[0].Index, true);

                    vizcore3d.View.Message.Show(Data.MessageId.ID_01, string.Format("Name : {0}", e.Node[0].NodeName), 5, 5, Data.FontSize.Size_14_Bold, Color.Red);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_02, string.Format("Path : {0}", prop.AssemblyPath), 5, 20, Data.FontSize.Size_14, Color.Orange);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_03, string.Format("Center : {0}", prop.CenterPoint.ToString()), 5, 35, Data.FontSize.Size_14, Color.Yellow);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_04, string.Format("Min. : {0}", prop.MinPoint.ToString()), 5, 50, Data.FontSize.Size_14, Color.Green);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_05, string.Format("Max. : {0}", prop.MaxPoint.ToString()), 5, 65, Data.FontSize.Size_14, Color.Blue);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_06, string.Format("Mass : {0}", prop.Mass), 5, 80, Data.FontSize.Size_14, Color.Indigo);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_07, string.Format("Area : {0}", prop.SurfaceArea), 5, 95, Data.FontSize.Size_14, Color.Purple);

                    vizcore3d.EndUpdate();
                }
            }
            else
            {
                //모든 개체 선택 해제

                if (EnableMessage == true)
                {
                    vizcore3d.BeginUpdate();

                    vizcore3d.View.Message.Clear();
                    Data.BoundBox3D bbox = vizcore3d.Model.BoundBox;

                    vizcore3d.View.Message.Show(Data.MessageId.ID_01, string.Format("Min. X : {0}", bbox.MinX), 5, 5, Data.FontSize.Size_14, Color.Red);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_02, string.Format("Min. Y : {0}", bbox.MinY), 5, 20, Data.FontSize.Size_14, Color.Orange);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_03, string.Format("Min. Z : {0}", bbox.MinZ), 5, 35, Data.FontSize.Size_14, Color.Yellow);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_04, string.Format("Max. X : {0}", bbox.MaxX), 5, 50, Data.FontSize.Size_14, Color.Green);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_05, string.Format("Max. Y : {0}", bbox.MaxY), 5, 65, Data.FontSize.Size_14, Color.Blue);
                    vizcore3d.View.Message.Show(Data.MessageId.ID_06, string.Format("Max. Z : {0}", bbox.MaxZ), 5, 80, Data.FontSize.Size_14, Color.Indigo);

                    vizcore3d.EndUpdate();
                }
            }

        }

        /// <summary>
        /// 단면 이벤트
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">Event Args</param>
        private void Section_OnSectionEvent(object sender, Event.EventManager.SectionEventArgs e)
        {   
            switch (e.EventType)
            {                
                case Manager.SectionManager.EventTypes.ADD:
                    //생성 이벤트
                    break;
                case Manager.SectionManager.EventTypes.DELETE:
                    //삭제 이벤트
                    break;
                case Manager.SectionManager.EventTypes.DELETE_ALL:
                    //전체 삭제 이벤트
                    break;
                case Manager.SectionManager.EventTypes.SELECT:
                    //선택 이벤트
                    break;
                case Manager.SectionManager.EventTypes.TRANSFORM:
                    //이동 및 회전 이벤트
                    break;
                default:
                    break;
            }

            // 단면 정보 없음
            if (e.Section == null)
                return;

            switch (e.Section.SectionType)
            {
                case Manager.SectionManager.SectionTypes.SECTION:
                    // 단면
                    break;
                case Manager.SectionManager.SectionTypes.SECTION_BOX:
                    // 상자
                    break;
                case Manager.SectionManager.SectionTypes.SECTION_INBOX:
                    // 인박스
                    break;
                default:
                    break;
            }
        }




        // ================================================
        // Function - Node Dialog
        // ================================================
        private void ShowNodeDialog(List<VIZCore3D.NET.Data.Node> items)
        {
            if (nodeDialog == null)
            {
                nodeDialog = new Dialogs.NodeDialog(items);
            }
            else
            {
                nodeDialog.SetDataSource(items);
            }

            nodeDialog.Show();
        }

        // ================================================
        // Function - VIZCore3D.NET : Initialize
        // ================================================
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

            // 모델 열기 시, 스트럭처 병합 설정
            vizcore3d.Model.OpenMergeStructureMode = Data.MergeStructureModes.NONE;

            // 모델 저장 시, 스트럭처 병합 설정
            vizcore3d.Model.SaveMergeStructureMode = Data.MergeStructureModes.NONE;

            // 실린더 원형 품질 개수 : Nomal(12~36), Small(6~36)
            vizcore3d.Model.ReadNormalCylinderSide = 12;
            vizcore3d.Model.ReadSmallCylinderSide = 6;

            // 보이는 모델만 저장

            // VIZXML to VIZ 옵션
            vizcore3d.Model.VIZXMLtoVIZOption = Data.ExportVIZXMLToVIZOptions.LOAD_UNLOADED_NODE;

            // 선택 가능 개체 : 전체, 불투명한 개체
            vizcore3d.View.SelectionObject3DType = Data.SelectionObject3DTypes.ALL;

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
            vizcore3d.View.RotationAxis = Data.Axis.X;
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
            vizcore3d.Walkthrough.AvatarModel = (int)Data.AvatarModels.MAN1;
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
            vizcore3d.View.XRay.ColorType = Data.XRayColorTypes.SELECTION_COLOR;
            // 배경유형
            //vizcore3d.View.BackgroundMode = Data.BackgroundModes.COLOR_ONE;
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
            vizcore3d.Review.Note.FontSize = Manager.NoteManager.FontSizeKind.SIZE12;
            // 글자 굵게
            vizcore3d.Review.Note.FontBold = false;
            // 지시선(라인) 색상
            vizcore3d.Review.Note.LineColor = Color.Black;
            // 지시선(라인) 두께
            vizcore3d.Review.Note.LineWidth = 3;
            // 지시선 중앙 연결
            vizcore3d.Review.Note.LinkArrowTailToText = Manager.NoteManager.LinkArrowTailToTextKind.END;
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
            vizcore3d.Review.Note.SymbolFontSize = Manager.NoteManager.FontSizeKind.SIZE10;
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
            vizcore3d.ToolbarMeasurement.Visible = false;
            vizcore3d.ToolbarSection.Visible = false;
            vizcore3d.ToolbarClash.Visible = false;
            vizcore3d.ToolbarAnimation.Visible = false;
            vizcore3d.ToolbarSimulation.Visible = false;
            #endregion

            // ================================================================
            // 설정 - 상태바
            // ================================================================
            vizcore3d.Statusbar.Visible = true;


            // ================================================================
            // 모델 열기 시, 3D 화면 Rendering 재시작
            // ================================================================
            vizcore3d.View.EndUpdate();
        }

        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            // 모델 선택/해제 이벤트
            vizcore3d.Object3D.OnSelectedObject3D += Object3D_OnSelectedObject3D;

            // 단면(상자) 갱신 이벤트
            vizcore3d.Section.OnSectionEvent += Section_OnSectionEvent;
        }

        // ================================================
        // Event - Menu : FILE
        // ================================================
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            // 모델 열기
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = vizcore3d.Model.OpenFilter;
            if (dlg.ShowDialog() != DialogResult.OK) return;

            vizcore3d.Model.OnModelProgressChangedEvent += Model_OnModelProgressChangedEvent;
            vizcore3d.Model.Open(dlg.FileName);
            vizcore3d.Model.OnModelProgressChangedEvent -= Model_OnModelProgressChangedEvent;
        }

        private void menuFileOpenUri_Click(object sender, EventArgs e)
        {
            // 지정된 URI의 모델 열기(스트림)
            Dialogs.OpenUriDialog dlg = new Dialogs.OpenUriDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            if (String.IsNullOrEmpty(dlg.ModelName) == false)
                vizcore3d.Model.OpenUri(dlg.ModelName, dlg.ModelUri);
            else
                vizcore3d.Model.OpenUri(dlg.ModelUri);
        }

        private void menuFileAdd_Click(object sender, EventArgs e)
        {
            // 모델 추가
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = vizcore3d.Model.AddFilter;
            dlg.Multiselect = true;
            if (dlg.ShowDialog() != DialogResult.OK) return;

            vizcore3d.Model.OnModelProgressChangedEvent += Model_OnModelProgressChangedEvent;
            vizcore3d.Model.Add(dlg.FileNames);
            vizcore3d.Model.OnModelProgressChangedEvent -= Model_OnModelProgressChangedEvent;
        }

        private void menuFileAddUri_Click(object sender, EventArgs e)
        {
            // 지정된 URI의 모델 추가(스트림)
            Dialogs.AddUriDialog dlg = new Dialogs.AddUriDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            vizcore3d.Model.OnModelProgressChangedEvent += Model_OnModelProgressChangedEvent;
            vizcore3d.Model.AddStream(dlg.GetStreamDataList());
            vizcore3d.Model.OnModelProgressChangedEvent -= Model_OnModelProgressChangedEvent;
        }

        private void menuFileExport_Click(object sender, EventArgs e)
        {
            // 간략 형식 내보내기
            ExportSimple();

            // 세부 설정 내보내기
            //ExportDetail();
        }

        private void ExportSimple()
        {
            vizcore3d.Model.ExportFileDialog(true);
        }

        private void ExportDetail()
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            // 내보내기
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "모델 내보내기";
            dlg.Filter = vizcore3d.Model.ExportFilter;
            if (dlg.ShowDialog() != DialogResult.OK) return;

            bool result = false;

            if (dlg.FilterIndex == 1)
            {
                result = vizcore3d.Model.ExportVIZ(dlg.FileName);
            }
            else if (dlg.FilterIndex == 2)
            {
                result = vizcore3d.Model.ExportVIZXML(dlg.FileName);
            }
            else if (dlg.FilterIndex == 3)
            {
                result = vizcore3d.Model.ExportVIZM(dlg.FileName);
            }
            else if (dlg.FilterIndex == 4)
            {
                result = vizcore3d.Model.ExportVIZW(dlg.FileName);
            }
            else if (dlg.FilterIndex == 5)
            {
                result = vizcore3d.Model.ExportObj(dlg.FileName);
            }
            else if (dlg.FilterIndex == 6)
            {
                result = vizcore3d.Model.ExportSTL(dlg.FileName, VIZCore3D.NET.Data.ExportStlFileType.ASCII);
            }
            else if (dlg.FilterIndex == 7)
            {
                result = vizcore3d.Model.ExportSTL(dlg.FileName, VIZCore3D.NET.Data.ExportStlFileType.BINARY);
            }

            if (result == false)
            {
                MessageBox.Show("EXPORT - FAIL", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", dlg.FileName));
            }
        }

        private void menuFileClose_Click(object sender, EventArgs e)
        {
            // 모델 닫기
            vizcore3d.Model.Close();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ================================================
        // Event - Menu : Bar
        // ================================================
        private void menuToolbarMain_Click(object sender, EventArgs e)
        {
            // 툴바 보이기/숨기기
            vizcore3d.ToolbarMain.Visible = !vizcore3d.ToolbarMain.Visible;
        }

        private void menuStatusbar_Click(object sender, EventArgs e)
        {
            // 상태바 보이기/숨기기
            vizcore3d.Statusbar.Visible = !vizcore3d.Statusbar.Visible;
        }






        // ================================================
        // Event - Menu : Tools
        // ================================================
        private void menuToolsDebugInformation_Click(object sender, EventArgs e)
        {
            // 디버그 정보 보이기/숨기기
            vizcore3d.Debug.Visible = !vizcore3d.Debug.Visible;
        }

        // ================================================
        // Event - Menu : API -> OBJECT3D
        // ================================================
        private void menuApiObject3dRoot_Click(object sender, EventArgs e)
        {
            // Root 노드 정보 조회
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.ROOT);
            ShowNodeDialog(items);
        }

        private void menuApiObject3dFile_Click(object sender, EventArgs e)
        {
            // 파일 노드 정보 조회
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.FILE);
            ShowNodeDialog(items);
        }

        private void menuApiObject3dAll_Click(object sender, EventArgs e)
        {
            // 전체 노드 정보 조회
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.ALL);
            ShowNodeDialog(items);
        }

        private void menuApiObject3dPart_Click(object sender, EventArgs e)
        {
            // 파트 노드 정보 조회
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.PART);
            ShowNodeDialog(items);
        }

        private void menuApiObject3dSelectedTop_Click(object sender, EventArgs e)
        {
            // 선택된 상위 노드 정보 조회
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.SELECTED_TOP);
            ShowNodeDialog(items);
        }

        private void menuApiObject3dSelectedAll_Click(object sender, EventArgs e)
        {
            // 선택된 전체 노드 정보 조회
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.SELECTED_ALL);
            ShowNodeDialog(items);
        }

        private void menuApiObject3dLockedHidden_Click(object sender, EventArgs e)
        {
            // 잠금 숨김 상태의 노드 정보 조회
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(VIZCore3D.NET.Data.Object3dFilter.LOCKED_HIDDEN);
            ShowNodeDialog(items);
        }

        private void menuApiObject3dSelectedObject_Click(object sender, EventArgs e)
        {
            // 전체 선택 노드 정보 조회
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(Data.Object3dFilter.SELECTED_ALL);
            ShowNodeDialog(items);
        }

        private void menuApiObject3dSelectedChild_Click(object sender, EventArgs e)
        {
            // 선택된 노드의 자식 노드 정보 조회
            List<VIZCore3D.NET.Data.Node> selectedItems = vizcore3d.Object3D.FromFilter(Data.Object3dFilter.SELECTED_TOP);
            if (selectedItems.Count == 0) return;
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.GetChildObject3d(selectedItems[0].Index, Data.Object3DChildOption.CHILD_ONLY);
            ShowNodeDialog(items);
        }

        private void menuApiObject3dTestDialog_Click(object sender, EventArgs e)
        {
            if (object3dTestDialog == null)
                object3dTestDialog = new Dialogs.Object3dTestDialog(vizcore3d);

            object3dTestDialog.Show();
        }

        private void menuApiObject3dStructure_Click(object sender, EventArgs e)
        {
            // 선택된 노드의 구조 정보 조회
            List<VIZCore3D.NET.Data.Node> selectedItems = vizcore3d.Object3D.FromFilter(Data.Object3dFilter.SELECTED_TOP);
            if (selectedItems.Count == 0) return;

            List<VIZCore3D.NET.Data.Node> structure = vizcore3d.Object3D.GetNodeStructure(selectedItems[0].Index, true);
            Dialogs.StructureDialog dlg = new Dialogs.StructureDialog(structure);
            dlg.ShowDialog();
        }


        // ================================================
        // Event - Menu : API -> VIEW
        // ================================================
        private void menuApiViewPreSelect_Click(object sender, EventArgs e)
        {
            // PreSelect 기능 활성화/비활성화
            vizcore3d.View.EnablePreSelect = !vizcore3d.View.EnablePreSelect;
        }

        private void menuApiViewXrayColor_Click(object sender, EventArgs e)
        {
            // Xray 모드에서 선택 개체의 색상 표시 방법 전환
            if (vizcore3d.View.XRay.ColorType == Data.XRayColorTypes.OBJECT_COLOR)
                vizcore3d.View.XRay.ColorType = Data.XRayColorTypes.SELECTION_COLOR;
            else
                vizcore3d.View.XRay.ColorType = Data.XRayColorTypes.OBJECT_COLOR;
        }

        private void menuApiViewImageToClipboard_Click(object sender, EventArgs e)
        {
            // 현재 화면을 클립보드에 저장
            vizcore3d.View.CaptureImageToClipboard();
        }

        private void menuApiViewCaptureImage_Click(object sender, EventArgs e)
        {
            // 현재 화면 이미지 조회
            System.Drawing.Image img = vizcore3d.View.CaptureImage();
            Dialogs.ViewImageDialog dlg = new Dialogs.ViewImageDialog(img);
            dlg.ShowDialog();
        }

        private void menuApiViewMessage_Click(object sender, EventArgs e)
        {
            // 개체 선택 시, 개체 정보를 화면에 표시 활성화/비활성화
            EnableMessage = !EnableMessage;
        }

        private void menuApiViewExportImageBackgroundMode_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            vizcore3d.View.BeginBackgroundRenderingMode(800, 600);

            for (int i = 0; i < 8; i++)
            {
                ExportImageBackgroundMode((Data.CameraDirection)i);
            }

            vizcore3d.View.EndBackgroundRenderingMode();
        }

        private void ExportImageBackgroundMode(Data.CameraDirection camera)
        {
            vizcore3d.View.MoveCamera(camera);

            System.Drawing.Image img = vizcore3d.View.GetBackgroundRenderingImage();
            img.Save(string.Format("C:\\Temp\\{0}.jpg", camera.ToString()));
        }

        // ================================================
        // Event - Menu : API -> Geometry Property
        // ================================================
        private void menuApiGeometryProperty_Click(object sender, EventArgs e)
        {
            // 선택된 노드의 Geometry 속성 정보 조회
            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.FromFilter(Data.Object3dFilter.SELECTED_TOP);
            if (items.Count == 0) return;

            Dialogs.GeometryPropertyDialog dlg;

            if (items.Count == 0)
                dlg = new Dialogs.GeometryPropertyDialog(vizcore3d.Object3D.GeometryProperty.FromIndex(items[0].Index, false));
            else
                dlg = new Dialogs.GeometryPropertyDialog(vizcore3d.Object3D.GeometryProperty.FromSelectedObject3D(false));

            dlg.ShowDialog();
        }


        // ================================================
        // Event - Menu : API -> UDA -> Keys
        // ================================================
        private void menuApiUDAKeys_Click(object sender, EventArgs e)
        {
            // 사용자 정의 속성 중 Key 목록 조회
            List<string> keys = vizcore3d.Object3D.UDA.Keys;

            if (keys.Count == 0)
                MessageBox.Show("Key is null.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show(string.Join(",", keys.ToArray()), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuApiUDAValues_Click(object sender, EventArgs e)
        {
            // 선택된 개체의 사용자 정의 속성 정보 조회
            List<Data.Node> items = vizcore3d.Object3D.FromFilter(Data.Object3dFilter.SELECTED_TOP);
            if (items.Count == 0) return;

            Dictionary<string, string> uda = vizcore3d.Object3D.UDA.FromIndex(items[0].Index);

            Dialogs.UDADialog dlg = new Dialogs.UDADialog(uda);
            dlg.ShowDialog();
        }

        private void menuApiUDATree_Click(object sender, EventArgs e)
        {
            // 전체 사용자 정의 속성 트리 형식으로 조회
            List<string> keys = vizcore3d.Object3D.UDA.Keys;

            Dialogs.UDATreeDialog dlg = new Dialogs.UDATreeDialog(keys);
            dlg.OnUDAKeyNodeClickedEvent += UDATreeDialog_OnUDAKeyNodeClickedEvent;
            dlg.OnUDAValueNodeClickedEvent += UDATreeDialog_OnUDAValueNodeClickedEvent;
            dlg.ShowDialog();
        }

        private List<string> UDATreeDialog_OnUDAKeyNodeClickedEvent(object sender, Dialogs.UDAKeyNodeClickedEventArgs e)
        {
            // 사용자 정의 속성 Key 선택 시, Value 목록 반환
            List<string> vals = vizcore3d.Object3D.UDA.GetValues(e.Key);
            return vals;
        }

        private List<Data.Node> UDATreeDialog_OnUDAValueNodeClickedEvent(object sender, Dialogs.UDAValueNodeClickedEventArgs e)
        {
            // 사용자 정의 속성의 Key/Value에 해당하는 노드 목록 반환
            List<Data.Node> nodes = vizcore3d.Object3D.UDA.GetNodes(e.Key, e.Value);
            return nodes;
        }

        // ================================================
        // Event - Menu : API -> Find
        // ================================================
        private void menuApiFind_Click(object sender, EventArgs e)
        {
            // Case 1 - API로 노드 검색
            //Dialogs.InputNameDialog dlg = new Dialogs.InputNameDialog();
            //if (dlg.ShowDialog() != DialogResult.OK) return;

            //List<Data.Node> items = vizcore3d.Object3D.Find.QuickSearch(
            //    new List<string>() { dlg.Keyword }
            //    , false     /* 복수 검색어 결합조건. True : AND, False : OR */
            //    , false     /* Assembly Only. True : Assembly Node, False : All Node */
            //    , false     /* Visible Only. True : Visible Node, False : All Node */
            //    , false     /* Selected Node Only. True : Selected Node, False : All Node */
            //    , false     /* Full Math. True : Equal, False : Contains */
            //    );

            //ShowNodeDialog(items);


            // Case 2 - 검색 GUI
            Dialogs.SearchNodeDialog dlg = new Dialogs.SearchNodeDialog();
            dlg.OnQuickSearchEvent += SearchNode_OnQuickSearchEvent;                // 검색 이벤트
            dlg.OnQuickSearchViewEvent += SearchNode_OnQuickSearchViewEvent;        // 검색 결과 조회 이벤트
            dlg.OnQuickSearchClosedEvent += SearchNode_OnQuickSearchClosedEvent;    // 검색 다이얼로그 종료 이벤트
            dlg.Show();
        }

        private List<Data.Node> SearchNode_OnQuickSearchEvent(object sender, Dialogs.QuickSearchEventArgs e)
        {
            // 검색 GUI에서 요청한 Keyword로 검색 수행 결과 반환
            List<Data.Node> items = vizcore3d.Object3D.Find.QuickSearch(e.Keyword, e.JoinCondition, e.AssemblyOnly, e.VisibleOnly, e.SelectedOnly, e.FullMatch);
            return vizcore3d.Object3D.UpdateNodePath(items);
        }

        private void SearchNode_OnQuickSearchViewEvent(object sender, Dialogs.QuickSearchViewEventArgs e)
        {
            // 검색 결과 목록에서 항목 선택 시, 화면에 하이라이트
            if (e.Xray == true)
            {
                if (vizcore3d.View.XRay.Enable == false)
                    vizcore3d.View.XRay.Enable = true;

                vizcore3d.View.XRay.Clear();

                vizcore3d.View.XRay.Select(new List<int> { e.ResultNode.Index }, true);

                vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
                vizcore3d.Object3D.Select(new List<int> { e.ResultNode.Index }, true);
            }
            else
            {
                if (vizcore3d.View.XRay.Enable == true)
                    vizcore3d.View.XRay.Enable = false;

                vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
                vizcore3d.Object3D.Select(new List<int> { e.ResultNode.Index }, true);
            }

            if (e.FlyToObject == true)
            {
                vizcore3d.View.FlyToObject3d(new List<int> { e.ResultNode.Index }, 1.0f);
            }
            else
            {
                vizcore3d.View.MoveCenterToObject3d();
            }
        }

        private void SearchNode_OnQuickSearchClosedEvent(object sender, EventArgs e)
        {
            // 검색 창 닫기 시, Xray 모드 해제
            vizcore3d.View.XRay.Enable = false;
        }


        // ================================================
        // Event - Menu : API -> Frame
        // ================================================
        private void menuApiFrameCreateByAPI_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            // 갱신 시작
            vizcore3d.Frame.BeginUpdate();

            // X 축명 변경
            vizcore3d.Frame.UpdateGridAxisName(Data.Axis.X, "FR");

            vizcore3d.Frame.AddGridLine(Data.Axis.X, 0, 0);
            vizcore3d.Frame.AddGridLine(Data.Axis.X, 1, 77800);
            vizcore3d.Frame.AddGridLine(Data.Axis.X, 2, 92495);
            vizcore3d.Frame.AddGridLine(Data.Axis.X, 3, 119800);
            vizcore3d.Frame.AddGridLine(Data.Axis.X, 4, 134500);
            vizcore3d.Frame.AddGridLine(Data.Axis.X, 5, 142500);
            vizcore3d.Frame.AddGridLine(Data.Axis.X, 6, 157200);
            vizcore3d.Frame.AddGridLine(Data.Axis.X, 7, 161800);
            vizcore3d.Frame.AddGridLine(Data.Axis.X, 8, 164500);
            vizcore3d.Frame.AddGridLine(Data.Axis.X, 9, 170500);
            vizcore3d.Frame.AddGridLine(Data.Axis.X, 10, 176500);

            // Y축명 변경
            vizcore3d.Frame.UpdateGridAxisName(Data.Axis.Y, "LP"); 

            vizcore3d.Frame.AddGridLine(Data.Axis.Y, -10, -64000);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, -9, -60000);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, -8, -54200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, -7, -52000);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, -6, -48200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, -5, -42200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, -4, -36200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, -3, -30200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, -2, -24200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, -1, -18200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 0, 0);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 1, 18200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 2, 24200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 3, 30200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 4, 36200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 5, 42200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 6, 48200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 7, 52000);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 8, 54200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 9, 60000);
            vizcore3d.Frame.AddGridLine(Data.Axis.Y, 10, 64000);

            //Z 축명 변경
            vizcore3d.Frame.UpdateGridAxisName(Data.Axis.Z, "LP");  

            vizcore3d.Frame.AddGridLine(Data.Axis.Z, 0, 0);
            vizcore3d.Frame.AddGridLine(Data.Axis.Z, 1, 103500);
            vizcore3d.Frame.AddGridLine(Data.Axis.Z, 2, 109200);
            vizcore3d.Frame.AddGridLine(Data.Axis.Z, 3, 112875);
            vizcore3d.Frame.AddGridLine(Data.Axis.Z, 4, 114750);
            vizcore3d.Frame.AddGridLine(Data.Axis.Z, 5, 119850);
            vizcore3d.Frame.AddGridLine(Data.Axis.Z, 6, 123115);
            vizcore3d.Frame.AddGridLine(Data.Axis.Z, 7, 125500);
            vizcore3d.Frame.AddGridLine(Data.Axis.Z, 8, 131740);
            vizcore3d.Frame.AddGridLine(Data.Axis.Z, 9, 137500);

            // 갱신 종료
            vizcore3d.Frame.EndUpdate();

            // 화면 표시
            vizcore3d.Frame.Visible = true;
        }
    }
}
