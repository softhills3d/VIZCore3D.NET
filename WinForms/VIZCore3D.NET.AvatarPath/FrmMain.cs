using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.AvatarPath
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

        private Dictionary<string, VIZCore3D.NET.Data.Vector3D> CollisionPoint;

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

        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            // 모델 닫기
            vizcore3d.Model.OnModelClosedEvent += Model_OnModelClosedEvent;

            // 위치 목록 갱신
            vizcore3d.Walkthrough.AvatarPath.OnPositionUpdatedEvent += AvatarPath_OnPositionUpdatedEvent;

            // 애니메이션 종료
            vizcore3d.Walkthrough.AvatarPath.OnAnimationFinishedEvent += AvatarPath_OnAnimationFinishedEvent;
        }

        private void Model_OnModelClosedEvent(object sender, EventArgs e)
        {
            lvPath.Items.Clear();
            lvPosition.Items.Clear();
        }

        private void AvatarPath_OnPositionUpdatedEvent(object sender, Event.EventManager.AvatarPathEventArgs e)
        {
            lvPosition.BeginUpdate();
            lvPosition.Items.Clear();
            VIZCore3D.NET.Data.AvatarPathItem item = vizcore3d.Walkthrough.AvatarPath.GetPath(e.ID);
            List<VIZCore3D.NET.Data.Vertex3D> position = item.Positions;
            for (int i = 0; i < position.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(new string[] 
                {
                    i.ToString()
                    , position[i].X.ToString()
                    , position[i].Y.ToString()
                    , position[i].Z.ToString()
                }
                );
                lvPosition.Items.Add(lvi);
            }
            lvPosition.EndUpdate();
        }

        private void AvatarPath_OnAnimationFinishedEvent(object sender, EventArgs e)
        {
            if (ckPlayRepeatMode.Checked == false) return;

            vizcore3d.Walkthrough.AvatarPath.RewindAnimation();
            vizcore3d.Walkthrough.AvatarPath.PlayAnimation();
        }

        private void btnSetOption_Click(object sender, EventArgs e)
        {
            vizcore3d.Walkthrough.AvatarPath.WalkSpeed = Convert.ToSingle(txtWalkSpeed.Text);
            vizcore3d.Walkthrough.AvatarPath.RotateSpeed = Convert.ToSingle(txtRotateSpeed.Text);
            vizcore3d.Walkthrough.AvatarPath.LastPathAsDirection = ckLastPathAsDir.Checked;
        }

        private void ckVisible_CheckedChanged(object sender, EventArgs e)
        {
            vizcore3d.Walkthrough.AvatarPath.VisiblePath = ckVisible.Checked;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            vizcore3d.Walkthrough.AvatarPath.OpenFileDialog();

            lvPosition.Items.Clear();
            lvPath.Items.Clear();

            lvPath.BeginUpdate();
            int count = vizcore3d.Walkthrough.AvatarPath.Count;

            for (int i = 0; i < count; i++)
            {
                VIZCore3D.NET.Data.AvatarPathItem item = vizcore3d.Walkthrough.AvatarPath.GetPathByIndex(i);

                ListViewItem lvi = new ListViewItem(new string[] 
                {
                    item.ID.ToString()
                    , item.Title
                }
                );
                lvi.Tag = item;
                lvPath.Items.Add(lvi);
            }
            lvPath.EndUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            vizcore3d.Walkthrough.AvatarPath.SaveFileDialog();
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            int count = vizcore3d.Walkthrough.AvatarPath.Count;
            VIZCore3D.NET.Dialogs.AddNodeDialog dlg = new Dialogs.AddNodeDialog(string.Format("AVATAR PATH #{0}", count++));
            if (dlg.ShowDialog() != DialogResult.OK) return;

            string title = dlg.NodeName;

            VIZCore3D.NET.Data.AvatarPathItem item = vizcore3d.Walkthrough.AvatarPath.Add(title);

            lvPath.BeginUpdate();
            ListViewItem lvi = new ListViewItem(new string[] 
                    {
                        item.ID.ToString()
                        , item.Title
                    }
                );

            lvi.Tag = item;
            lvPath.Items.Add(lvi);
            lvPath.EndUpdate();

            lvPosition.Items.Clear();
        }

        private void btnDeletePath_Click(object sender, EventArgs e)
        {
            if (lvPath.SelectedItems.Count == 0) return;
            if (lvPath.SelectedItems[0].Tag == null) return;

            VIZCore3D.NET.Data.AvatarPathItem item = (VIZCore3D.NET.Data.AvatarPathItem)lvPath.SelectedItems[0].Tag;

            vizcore3d.Walkthrough.AvatarPath.Delete(item.ID);

            lvPath.Items.Remove(lvPath.SelectedItems[0]);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            vizcore3d.Walkthrough.AvatarPath.Clear();
            lvPath.Items.Clear();
            lvPosition.Items.Clear();
        }

        private void btnShowPath_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Walkthrough.AvatarPath.PathID == -1) return;
            vizcore3d.Walkthrough.AvatarPath.PathItem.VisiblePath = true;

            /*
            if (lvPath.SelectedItems.Count == 0) return;
            if (lvPath.SelectedItems[0].Tag == null) return;

            VIZCore3D.NET.Data.AvatarPathItem item = (VIZCore3D.NET.Data.AvatarPathItem)lvPath.SelectedItems[0].Tag;

            item.VisiblePath = true;
            */
        }

        private void btnHidePath_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Walkthrough.AvatarPath.PathID == -1) return;
            vizcore3d.Walkthrough.AvatarPath.PathItem.VisiblePath = false;

            /*
            if (lvPath.SelectedItems.Count == 0) return;
            if (lvPath.SelectedItems[0].Tag == null) return;

            VIZCore3D.NET.Data.AvatarPathItem item = (VIZCore3D.NET.Data.AvatarPathItem)lvPath.SelectedItems[0].Tag;

            item.VisiblePath = false;
            */
        }

        private void btnAddPos_Click(object sender, EventArgs e)
        {
            int id = vizcore3d.Walkthrough.AvatarPath.PathID;

            if (id == -1) return;

            VIZCore3D.NET.Data.AvatarPathItem item = vizcore3d.Walkthrough.AvatarPath.GetPath(id);

            //item.AddPosition(new VIZCore3D.NET.Data.Vertex3D(100, 200, 300));
            item.AddPosition(-1, ckRepeat.Checked);
        }

        private void btnDeletePos_Click(object sender, EventArgs e)
        {
            int id = vizcore3d.Walkthrough.AvatarPath.PathID;

            if (id == -1) return;

            VIZCore3D.NET.Data.AvatarPathItem item = vizcore3d.Walkthrough.AvatarPath.GetPath(id);

            if (lvPosition.SelectedItems.Count == 0) return;
            int index = Convert.ToInt32(lvPosition.SelectedItems[0].SubItems[0].Text);

            item.DeletePosition(index);

            List<VIZCore3D.NET.Data.Vertex3D> positions = item.Positions;
            lvPosition.BeginUpdate();
            lvPosition.Items.Clear();
            for (int i = 0; i < positions.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    i.ToString()
                    , positions[i].X.ToString()
                    , positions[i].Y.ToString()
                    , positions[i].Z.ToString()
                }
                );
                lvPosition.Items.Add(lvi);
            }
            lvPosition.EndUpdate();
        }

        private void btnClearPos_Click(object sender, EventArgs e)
        {
            int id = vizcore3d.Walkthrough.AvatarPath.PathID;

            if (id == -1) return;

            VIZCore3D.NET.Data.AvatarPathItem item = vizcore3d.Walkthrough.AvatarPath.GetPath(id);
            item.DeletePosition();

            lvPosition.Items.Clear();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Walkthrough.AvatarPath.IsPlaying() == true) return;

            vizcore3d.Walkthrough.AvatarPath.PlayAnimation();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            vizcore3d.Walkthrough.AvatarPath.PauseAnimation();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            vizcore3d.Walkthrough.AvatarPath.StopAnimation();
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            vizcore3d.Walkthrough.AvatarPath.RewindAnimation();
        }

        private void lvPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPath.SelectedItems.Count == 0) return;
            if (lvPath.SelectedItems[0].Tag == null) return;

            VIZCore3D.NET.Data.AvatarPathItem item = (VIZCore3D.NET.Data.AvatarPathItem)lvPath.SelectedItems[0].Tag;
            vizcore3d.Walkthrough.AvatarPath.Select(item.ID, true);

            List<VIZCore3D.NET.Data.Vertex3D> positions = item.Positions;
            lvPosition.BeginUpdate();
            lvPosition.Items.Clear();
            for (int i = 0; i < positions.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(new string[] 
                {
                    i.ToString()
                    , positions[i].X.ToString()
                    , positions[i].Y.ToString()
                    , positions[i].Z.ToString()
                }
                );
                lvPosition.Items.Add(lvi);
            }
            lvPosition.EndUpdate();
        }

        private void btnGetPathTick_Click(object sender, EventArgs e)
        {
            int pos = vizcore3d.Walkthrough.AvatarPath.GetAnimationTickPostion();
            int time = vizcore3d.Walkthrough.AvatarPath.GetAnimationTime();

            tbPos.Maximum = time;

            lbTick.Text = string.Format("{0:#,0}", time);
            lbTickTotal.Text = string.Format("{0:#,0}", time);

            CollisionPoint = new Dictionary<string, Data.Vector3D>();
        }

        private void tbPos_Scroll(object sender, EventArgs e)
        {
            if (vizcore3d.View.Navigation != VIZCore3D.NET.Data.NavigationModes.WALK)
                vizcore3d.View.Navigation = VIZCore3D.NET.Data.NavigationModes.WALK;

            if (vizcore3d.Walkthrough.Avatar == false)
                vizcore3d.Walkthrough.Avatar = true;

            if (vizcore3d.Walkthrough.EnableAvatarAutoZoom == true)
                vizcore3d.Walkthrough.EnableAvatarAutoZoom = false;

            int val = tbPos.Value;

            vizcore3d.Walkthrough.AvatarPath.SetAvatarPositionByTick(val);

            lbTick.Text = string.Format("{0:#,0}", val);

            if (vizcore3d.Walkthrough.CreateAvatarCollision() == true)
            {
                List<VIZCore3D.NET.Data.Vector3D> result = vizcore3d.Walkthrough.GetAvatarCollision();

                foreach (VIZCore3D.NET.Data.Vector3D item in result)
                {
                    if (CollisionPoint.ContainsKey(item.ToString()) == false)
                        CollisionPoint.Add(item.ToString(), item);
                }
            }
        }

        private void btnCollistionPoint_Click(object sender, EventArgs e)
        {
            if (CollisionPoint == null) return;

            vizcore3d.BeginUpdate();
            vizcore3d.Review.Note.Clear();
            vizcore3d.Clash.ClearResultSymbol();

            int count = 0;
            List<VIZCore3D.NET.Data.Vertex3D> points = new List<VIZCore3D.NET.Data.Vertex3D>();
            List<VIZCore3D.NET.Data.ClashResultSymbols> symbols = new List<VIZCore3D.NET.Data.ClashResultSymbols>();

            foreach (KeyValuePair<string, VIZCore3D.NET.Data.Vector3D> item in CollisionPoint)
            {
                VIZCore3D.NET.Data.Vertex3D surface = item.Value.ToVertex3D();
                VIZCore3D.NET.Data.Vertex3D text = item.Value.ToVertex3D();
                text.Z += 1000.0f;

                int noteId = vizcore3d.Review.Note.AddNoteSurface(string.Format("Collision : {0}\r\n{1}", count, item.Value), text, surface);
                count++;

                points.Add(surface);
                symbols.Add(VIZCore3D.NET.Data.ClashResultSymbols.Triangle);
            }

            vizcore3d.Clash.ShowResultSymbol(points, symbols, 10, true, Color.Yellow, false);

            vizcore3d.EndUpdate();

            vizcore3d.View.Navigation = VIZCore3D.NET.Data.NavigationModes.ROTATE;
            vizcore3d.View.ResetView();
        }
    }
}
