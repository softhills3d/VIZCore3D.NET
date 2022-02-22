using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.ClashTest.V3
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
        /// 3D Model BoundBox
        /// </summary>
        public VIZCore3D.NET.Data.BoundBox3D MODEL_BOUNDBOX { get; set; }

        public List<BlockItem> Blocks { get; set; }


        // ================================================
        // Contruction
        // ================================================
        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            // Construction
            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(vizcore3d);

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

        #region Function - VIZCore3D.NET : Event
        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            vizcore3d.Clash.OnClashProgressEvent += Clash_OnClashProgressEvent;
            vizcore3d.Clash.OnClashTestFinishedEvent += Clash_OnClashTestFinishedEvent;
        }
        #endregion



        // ================================================
        // Event - VIZCore3D.NET.Clash
        // ================================================
        private void Clash_OnClashProgressEvent(object sender, Event.EventManager.ClashProgressEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(string.Format("{0}% - {1:N0} EA", e.Progress, e.Count));
        }

        private void Clash_OnClashTestFinishedEvent(object sender, VIZCore3D.NET.Event.EventManager.ClashEventArgs e)
        {
            this.Invoke(new EventHandler(delegate
            {
                AnalyzeResults();
            }));
        }


        // ================================================
        // Event - GUI
        // ================================================
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (System.Environment.MachineName.ToUpper() != "GJKIM-ADELL")
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() != DialogResult.OK) return;

                txtPath.Text = dlg.SelectedPath;
            }
            else
            {
                txtPath.Text = "E:\\MODELS\\SHOWCASE\\ERECTION.CLASH";
            }
        }

        private void btnLoadItems_Click(object sender, EventArgs e)
        {
            string dir = txtPath.Text;
            if (String.IsNullOrEmpty(dir) == true) return;
            if (System.IO.Directory.Exists(dir) == false) return;
            string path = System.IO.Path.Combine(dir, "Z99_ERECT_ALL.txt");
            if (System.IO.File.Exists(path) == false) return;

            Blocks = new List<BlockItem>();

            lvItems.BeginUpdate();
            lvItems.Items.Clear();

            string[] items = System.IO.File.ReadAllLines(path);

            for (int i = 0; i < items.Length; i++)
            {
                string item = items[i];
                string[] vals = item.Split(new char[] { ',' });

                string viz1 = string.Format("{0}\\{1}\\{1}.viz", dir, vals[0]);
                string viz2 = string.Format("{0}\\{1}\\{1}_OUTSIDE.viz", dir, vals[0]);
                string viz3 = string.Format("{0}\\{1}\\{1}_SIMPLIFIED.viz", dir, vals[0]);

                ListViewItem lvi = new ListViewItem(new string[] {
                    string.Format("{0}", i + 1)
                    , vals[0]
                    , vals[1]
                    , System.IO.File.Exists(viz1) == true ? "Y" : ""
                    , System.IO.File.Exists(viz2) == true ? "Y" : ""
                });
                lvItems.Items.Add(lvi);

                // Block List
                Blocks.Add(new BlockItem(vals[0]));
            }

            lvItems.EndUpdate();
        }

        private void btnOutside_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvItems.Items.Count; i++)
            {
                ListViewItem lvi = lvItems.Items[i];
                string name = lvi.SubItems[1].Text;
                string outside = lvi.SubItems[4].Text;

                string viz1 = string.Format("{0}\\{1}\\{1}.viz", txtPath.Text, name);
                string viz2 = string.Format("{0}\\{1}\\{1}_OUTSIDE.viz", txtPath.Text, name);

                vizcore3d.Model.Open(viz1);

                // 외형 검색
                List<VIZCore3D.NET.Data.Node> outsideModel = vizcore3d.Object3D.Find.GetOutsidePart(false);

                // 저장
                vizcore3d.Model.ExportVIZ(viz2, outsideModel);

                lvi.SubItems[4].Text = "Y";
                lvItems.EnsureVisible(lvi.Index);

                Application.DoEvents();
            }

            vizcore3d.Model.Close();

            btnLoadItems.PerformClick();
        }

        private void btnImportModel_Click(object sender, EventArgs e)
        {
            vizcore3d.Model.Close();
            List<VIZCore3D.NET.Data.StreamData> stream = new List<VIZCore3D.NET.Data.StreamData>();

            for (int i = 0; i < lvItems.Items.Count; i++)
            {
                ListViewItem lvi = lvItems.Items[i];
                string name = lvi.SubItems[1].Text;

                string viz1 = string.Format("{0}\\{1}\\{1}.viz", txtPath.Text, name);
                string viz2 = string.Format("{0}\\{1}\\{1}_OUTSIDE.viz", txtPath.Text, name);
                string viz3 = string.Format("{0}\\{1}\\{1}_SIMPLIFIED.viz", txtPath.Text, name);

                if (rbModelVIZ.Checked == true)
                    stream.Add(new Data.StreamData(System.IO.File.ReadAllBytes(viz1), name));
                else if (rbModelOutside.Checked == true)
                    stream.Add(new Data.StreamData(System.IO.File.ReadAllBytes(viz2), name));
            }

            vizcore3d.Model.AddStream(stream);

            MODEL_BOUNDBOX = vizcore3d.Model.BoundBox;
        }



        // ================================================
        // Event - GUI :: Clash
        // ================================================
        private void btnAddClashTask_Click(object sender, EventArgs e)
        {
            if (Blocks == null || Blocks.Count == 0) return;

            Dictionary<string, List<VIZCore3D.NET.Data.Node>> nameMap = vizcore3d.Object3D.GetNodeNameMapFromDepth(1, false);

            for (int i = 1; i < Blocks.Count; i++)
            {
                BlockItem block = Blocks[i];

                string name = block.BlockName;

                VIZCore3D.NET.Data.ClashTest clash = new VIZCore3D.NET.Data.ClashTest();

                clash.Name = string.Format(string.Format("BLOCK : {0}", name));
                clash.TestKind = VIZCore3D.NET.Data.ClashTest.ClashTestKind.GROUP_VS_GROUP;

                clash.UseClearanceValue = false;
                clash.ClearanceValue = 3.0f;
                clash.UseRangeValue = false;
                clash.RangeValue = 2.0f;
                clash.UsePenetrationTolerance = true;
                clash.PenetrationTolerance = 1.0f;

                clash.VisibleOnly = false;
                clash.BottomLevel = 2;

                clash.GroupA = GetPreviousBlock(nameMap, name, i);
                clash.GroupB = nameMap.ContainsKey(name) == true ? nameMap[name] : null;

                if (clash.GroupA == null || clash.GroupA.Count == 0) continue;
                if (clash.GroupB == null || clash.GroupB.Count == 0) continue;

                vizcore3d.Clash.Add(clash);
                block.Clash = clash;
            }

            MessageBox.Show("Completd.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<VIZCore3D.NET.Data.Node> GetPreviousBlock(Dictionary<string, List<VIZCore3D.NET.Data.Node>> source, string name, int index)
        {
            List<VIZCore3D.NET.Data.Node> nodes = new List<VIZCore3D.NET.Data.Node>();

            for (int i = index - 1; i > -1; i--)
            {
                BlockItem block = Blocks[i];

                string currentBlockName = block.BlockName;

                if (source.ContainsKey(currentBlockName) == false) continue;

                nodes.Add(source[currentBlockName][0]);
            }

            return nodes;
        }

        private void btnRunTest_Click(object sender, EventArgs e)
        {
            int count = vizcore3d.Clash.ClashTestCount;

            //MessageBox.Show(count.ToString());

            List<int> id = new List<int>();
            for (int i = 0; i < Blocks.Count; i++)
            {
                if (Blocks[i].Clash == null) continue;
                id.Add(Blocks[i].Clash.ID);

                //if (i == 8) break;
            }

            //MessageBox.Show(id.Count.ToString());

            vizcore3d.Clash.PerformInterferenceCheck(id);
        }

        private void AnalyzeResults()
        {
            for (int i = 0; i < Blocks.Count; i++)
            {
                BlockItem block = Blocks[i];
                if (block.Clash == null) continue;

                List<VIZCore3D.NET.Data.ClashTestResultItem> results = 
                    vizcore3d.Clash.GetResultItem(
                        block.Clash
                        , VIZCore3D.NET.Manager.ClashManager.ResultGroupingOptions.ASSEMBLY
                        );

                foreach (VIZCore3D.NET.Data.ClashTestResultItem item in results)
                {
                    string[] nodepath = item.NodePathArrayA;
                    if (nodepath == null || nodepath.Length == 0) continue;

                    block.AddClashBlock(nodepath[0]);
                }
            }

            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < Blocks.Count; i++)
            //{
            //    BlockItem block = Blocks[i];
            //    sb.AppendLine(string.Format("{0} = {1}", block.BlockName, string.Join(",",block.ClashBlock.Keys.ToArray())));
            //}
            //MessageBox.Show(sb.ToString());

            ShowResults();
        }

        private void ShowResults()
        {
            InitDesignResultList();

            lvResults.BeginUpdate();

            for (int i = 0; i < Blocks.Count; i++)
            {
                BlockItem block = Blocks[i];

                List<string> val = new List<string>();
                val.Add(block.BlockName);
                for (int j = 0; j < Blocks.Count; j++)
                {
                    BlockItem clashBlock = Blocks[j];
                    bool result = block.HasClashBlock(clashBlock.BlockName);

                    val.Add(result == true ? "Y" : ".");
                }

                ListViewItem lvi = new ListViewItem(val.ToArray());
                lvi.Tag = block;
                lvResults.Items.Add(lvi);
            }

            lvResults.EndUpdate();
        }

        private void InitDesignResultList()
        {
            if (lvResults.Columns.Count != 0) return;

            lvResults.BeginUpdate();

            for (int i = 0; i < Blocks.Count + 1; i++)
            {
                System.Windows.Forms.ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = i == 0 ? "BLOCK" : Blocks[i - 1].BlockName;
                columnHeader.Width = 60;

                if (i != 0) columnHeader.TextAlign = HorizontalAlignment.Center;

                lvResults.Columns.Add(columnHeader);
            }

            lvResults.EndUpdate();
        }

        private void lvResults_DoubleClick(object sender, EventArgs e)
        {
            if (lvResults.SelectedItems.Count == 0) return;

            ListViewItem lvi = lvResults.SelectedItems[0];
            if (lvi.Tag == null) return;

            BlockItem block = (BlockItem)lvi.Tag;

            Dictionary<string, List<VIZCore3D.NET.Data.Node>> nameMap = vizcore3d.Object3D.GetNodeNameMapFromDepth(1, false);

            vizcore3d.BeginUpdate();

            vizcore3d.View.XRay.Clear();

            if (vizcore3d.View.XRay.Enable == false)
                vizcore3d.View.XRay.Enable = true;

            vizcore3d.View.XRay.ColorType = Data.XRayColorTypes.OBJECT_COLOR;

            if (nameMap.ContainsKey(block.BlockName) == true)
            {
                vizcore3d.Object3D.Color.SetColor(nameMap[block.BlockName], Color.Red);
                vizcore3d.View.XRay.Select(nameMap[block.BlockName], true);
            }

            List<VIZCore3D.NET.Data.Node> targetBlock = new List<Data.Node>();
            foreach (string item in block.ClashBlock.Keys)
            {
                if (nameMap.ContainsKey(item) == false) continue;
                targetBlock.Add(nameMap[item][0]);
            }

            if (targetBlock.Count != 0)
            {
                vizcore3d.Object3D.Color.SetColor(targetBlock, Color.Blue);
                vizcore3d.View.XRay.Select(targetBlock, true);
            }

            vizcore3d.EndUpdate();
        }
    }
}
