using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.MultiViewSync
{
    public partial class FrmMain : Form
    {
        // ================================================
        // Attribute & Property
        // ================================================
        /// <summary>
        /// VIZCore3D.NET Main Control
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3dMain;

        /// <summary>
        /// VIZCore3D.NET Sub #1 Control
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3dSub1;

        /// <summary>
        /// VIZCore3D.NET Sub #2 Control
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3dSub2;

        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            {
                // Construction
                vizcore3dMain = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dMain.Dock = DockStyle.Fill;
                splitContainer1.Panel1.Controls.Add(vizcore3dMain);

                // Event
                vizcore3dMain.OnInitializedVIZCore3D += VIZCore3DMain_OnInitializedVIZCore3D;
            }

            {
                // Construction
                vizcore3dSub1 = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dSub1.Dock = DockStyle.Fill;
                splitContainer2.Panel1.Controls.Add(vizcore3dSub1);

                // Event
                vizcore3dSub1.OnInitializedVIZCore3D += VIZCore3DSub1_OnInitializedVIZCore3D;
            }

            {
                // Construction
                vizcore3dSub2 = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dSub2.Dock = DockStyle.Fill;
                splitContainer2.Panel2.Controls.Add(vizcore3dSub2);

                // Event
                vizcore3dSub2.OnInitializedVIZCore3D += VIZCore3DSub2_OnInitializedVIZCore3D;
            }
        }



        // ================================================
        // Event - VIZCore3D.NET
        // ================================================
        #region Event - OnInitializedVIZCore3D
        private void VIZCore3DMain_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
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
                licenseResult = vizcore3dMain.License.LicenseServer(
                    licenseInfo.ContainsKey("LICENSE_IP") == true ? licenseInfo["LICENSE_IP"] : String.Empty
                    , licenseInfo.ContainsKey("LICENSE_PORT") == true ? Convert.ToInt32(licenseInfo["LICENSE_PORT"]) : 8901
                    );
            }
            // 라이선스 파일
            else if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.FILE)
            {
                licenseResult = vizcore3dMain.License.LicenseFile(
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
            InitializeVIZCore3D(vizcore3dMain, 0);
            InitializeVIZCore3DEvent(0);
        }

        private void VIZCore3DSub1_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
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
                licenseResult = vizcore3dSub1.License.LicenseServer(
                    licenseInfo.ContainsKey("LICENSE_IP") == true ? licenseInfo["LICENSE_IP"] : String.Empty
                    , licenseInfo.ContainsKey("LICENSE_PORT") == true ? Convert.ToInt32(licenseInfo["LICENSE_PORT"]) : 8901
                    );
            }
            // 라이선스 파일
            else if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.FILE)
            {
                licenseResult = vizcore3dSub1.License.LicenseFile(
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
            InitializeVIZCore3D(vizcore3dSub1, 1);
            InitializeVIZCore3DEvent(1);
        }

        private void VIZCore3DSub2_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
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
                licenseResult = vizcore3dSub2.License.LicenseServer(
                    licenseInfo.ContainsKey("LICENSE_IP") == true ? licenseInfo["LICENSE_IP"] : String.Empty
                    , licenseInfo.ContainsKey("LICENSE_PORT") == true ? Convert.ToInt32(licenseInfo["LICENSE_PORT"]) : 8901
                    );
            }
            // 라이선스 파일
            else if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.FILE)
            {
                licenseResult = vizcore3dSub2.License.LicenseFile(
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
            InitializeVIZCore3D(vizcore3dSub2, 2);
            InitializeVIZCore3DEvent(2);
        }
        #endregion

        // ================================================
        // Function - VIZCore3D.NET : Initialize
        // ================================================
        #region Function - VIZCore3D.NET : Initialize
        private void InitializeVIZCore3D(VIZCore3D.NET.VIZCore3DControl vizcore3d, int viewId)
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

            if(viewId != 0)
            {
                vizcore3d.View.Toolbar.Enable = false;
            }
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
            if (viewId == 1 || viewId == 2) vizcore3d.ToolbarMain.Visible = false;

            vizcore3d.ToolbarNote.Visible = false;
            vizcore3d.ToolbarMeasure.Visible = false;
            vizcore3d.ToolbarSection.Visible = true;
            if (viewId == 1 || viewId == 2) vizcore3d.ToolbarSection.Visible = false;

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
            // 설정 - Mouse 제어
            // ================================================================
            if (viewId == 1)
            {
                // Remove Mouse Operation
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Wheel;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Down_Left;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Down_Middle;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Down_Right;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.DoubleClick_Left;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.DoubleClick_Middle;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.DoubleClick_Right;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Up_Left;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Up_Middle;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Up_Right;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Move;
            }
            else if (viewId == 2)
            {
                // Remove Mouse Operation
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Wheel;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Down_Left;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Down_Middle;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Down_Right;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.DoubleClick_Left;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.DoubleClick_Middle;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.DoubleClick_Right;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Up_Left;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Up_Middle;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Up_Right;
                vizcore3d.MouseControl = vizcore3d.MouseControl & ~VIZCore3D.NET.MouseControls.Move;
            }


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
        private void InitializeVIZCore3DEvent(int viewId)
        {
            if (viewId == 0)
            {
                // Mouse Wheel
                vizcore3dMain.View.OnViewDefaultMouseWheelEvent += View_OnViewDefaultMouseWheelEvent;

                // Mouse Down
                vizcore3dMain.View.OnViewDefaultMouseDownEvent += View_OnViewDefaultMouseDownEvent;

                // Mouse Double Click
                vizcore3dMain.View.OnViewDefaultMouseDoubleClickEvent += View_OnViewDefaultMouseDoubleClickEvent;

                // Mouse Up
                vizcore3dMain.View.OnViewDefaultMouseUpEvent += View_OnViewDefaultMouseUpEvent;

                // Mouse Move
                vizcore3dMain.View.OnViewDefaultMouseMoveEvent += View_OnViewDefaultMouseMoveEvent;

                // Key Down
                vizcore3dMain.OnVIZCore3DKeyDown += VIZCore3DMain_OnVIZCore3DKeyDown;
                vizcore3dMain.OnVIZCore3DKeyUp += VIZCore3DMain_OnVIZCore3DKeyUp;

                // View Toolbar - View Changed
                vizcore3dMain.View.OnViewToolbarViewChangedEvent += View_OnViewToolbarViewChangedEvent;

                // Toolbar Item Clicked
                vizcore3dMain.OnToolbarItemClicked += VIZCore3DMain_OnToolbarItemClicked;

                // Section
                vizcore3dMain.Section.OnSectionEvent += Section_OnSectionEvent;
                vizcore3dMain.Section.OnSectionHandleEvent += Section_OnSectionHandleEvent;

                // Visible
                vizcore3dMain.ModelTree.OnModelTreeNodeVisibleChangedEvent += ModelTree_OnModelTreeNodeVisibleChangedEvent;
                vizcore3dMain.Object3D.OnObject3DVisibleChangedEvent += Object3D_OnObject3DVisibleChangedEvent;

                // View Changed
                vizcore3dMain.View.OnCameraStateChangedEvent += View_OnCameraStateChangedEvent;

                // Selection
                vizcore3dMain.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;
            }
            else if (viewId == 1)
            {

            }
            else if (viewId == 2)
            {

            }
        }
        #endregion


        // ================================================
        // Function - Sync View
        // ================================================
        private void UpdateSubView()
        {
            vizcore3dSub1.BeginUpdate();
            vizcore3dSub2.BeginUpdate();

            Data.CameraData camera = vizcore3dMain.View.GetCameraData();
            vizcore3dSub1.View.SetCameraData(camera);
            vizcore3dSub2.View.SetCameraData(camera);

            vizcore3dSub1.EndUpdate();
            vizcore3dSub2.EndUpdate();
        }

        // ================================================
        // Event :: VIZCore3D.NET Main Default Event
        // ================================================
        private void View_OnViewDefaultMouseWheelEvent(object sender, MouseEventArgs e)
        {
            UpdateSubView();
        }

        private void View_OnViewDefaultMouseDownEvent(object sender, MouseEventArgs e)
        {
            
        }

        private void View_OnViewDefaultMouseDoubleClickEvent(object sender, MouseEventArgs e)
        {
            UpdateSubView();
        }

        private void View_OnViewDefaultMouseUpEvent(object sender, MouseEventArgs e)
        {
        }

        private void View_OnViewDefaultMouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UpdateSubView();
            }
            if (e.Button == MouseButtons.Right)
            {
                UpdateSubView();
            }
            if (e.Button == MouseButtons.Middle)
            {
                UpdateSubView();
            }
        }

        private void VIZCore3DMain_OnVIZCore3DKeyDown(object sender, Event.EventManager.VIZCoreKeyDownEventArgs e)
        {
            //vizcore3dSub1.SetCustomKeyDown(e.KeyValue);
            //vizcore3dSub2.SetCustomKeyDown(e.KeyValue);
        }

        private void VIZCore3DMain_OnVIZCore3DKeyUp(object sender, Event.EventManager.VIZCoreKeyUpEventArgs e)
        {
            
        }

        private void View_OnViewToolbarViewChangedEvent(object sender, Event.EventManager.ViewToolbarViewChangedEventArgs e)
        {
            vizcore3dSub1.View.MoveCamera(e.CameraDirection);
            vizcore3dSub2.View.MoveCamera(e.CameraDirection);
        }

        private void ModelTree_OnModelTreeNodeVisibleChangedEvent(object sender, Event.EventManager.ModelTreeNodeVisibleChangedEventArgs e)
        {
            vizcore3dSub1.BeginUpdate();
            vizcore3dSub1.Object3D.Show(e.NodeIndex, e.Visible);
            vizcore3dSub1.EndUpdate();

            vizcore3dSub2.BeginUpdate();
            vizcore3dSub2.Object3D.Show(e.NodeIndex, e.Visible);
            vizcore3dSub2.EndUpdate();
        }

        private void Object3D_OnObject3DVisibleChangedEvent(object sender, Event.EventManager.Object3DVisibleChangedEventArgs e)
        {
            vizcore3dSub1.BeginUpdate();
            vizcore3dSub1.Object3D.Show(e.Node, e.Visible);
            vizcore3dSub1.EndUpdate();

            vizcore3dSub2.BeginUpdate();
            vizcore3dSub2.Object3D.Show(e.Node, e.Visible);
            vizcore3dSub2.EndUpdate();
        }

        private void View_OnCameraStateChangedEvent(object sender, EventArgs e)
        {
            UpdateSubView();
        }

        private void Object3D_OnObject3DSelected(object sender, Event.EventManager.Object3DSelectedEventArgs e)
        {
            vizcore3dSub1.Object3D.Select(VIZCore3D.NET.Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3dSub2.Object3D.Select(VIZCore3D.NET.Data.Object3dSelectionModes.DESELECT_ALL);

            if (e.Node.Count == 0) return;

            vizcore3dSub1.Object3D.Select(e.Node, true);
            vizcore3dSub2.Object3D.Select(e.Node, true);
        }

        private void VIZCore3DMain_OnToolbarItemClicked(object sender, Event.ToolbarItemClickedEventArgs e)
        {
            switch (e.Item)
            {
                case Data.ToolbarItems.MAIN_CLOSE:
                    {
                        e.Cancel = true;

                        vizcore3dMain.Model.Close();
                        vizcore3dSub1.Model.Close();
                        vizcore3dSub2.Model.Close();
                    }
                    break;
                case Data.ToolbarItems.MAIN_NEW:
                    break;
                case Data.ToolbarItems.MAIN_OPEN:
                    {
                        e.Cancel = true;

                        OpenFileDialog dlg = new OpenFileDialog();
                        dlg.Filter = "VIZ (*.viz)|*.viz";
                        if (dlg.ShowDialog() != DialogResult.OK) return;

                        string path = dlg.FileName;
                        VIZCore3D.NET.Data.StreamData stream = new VIZCore3D.NET.Data.StreamData(path);

                        vizcore3dMain.Model.OpenStream(stream);
                        vizcore3dSub1.Model.OpenStream(stream);
                        vizcore3dSub2.Model.OpenStream(stream);
                    }
                    break;
                case Data.ToolbarItems.MAIN_ADD:
                    {
                        e.Cancel = true;

                        OpenFileDialog dlg = new OpenFileDialog();
                        dlg.Filter = "VIZ (*.viz)|*.viz";
                        dlg.Multiselect = true;
                        if (dlg.ShowDialog() != DialogResult.OK) return;

                        List<VIZCore3D.NET.Data.StreamData> stream = new List<VIZCore3D.NET.Data.StreamData>();

                        foreach (string item in dlg.FileNames)
                        {
                            stream.Add(new VIZCore3D.NET.Data.StreamData(item));
                        }

                        vizcore3dMain.Model.AddStream(stream);
                        vizcore3dSub1.Model.AddStream(stream);
                        vizcore3dSub2.Model.AddStream(stream);
                    }
                    break;
                case Data.ToolbarItems.MAIN_OPEN_FRAME:
                    break;
                case Data.ToolbarItems.MAIN_OPEN_GENERIC:
                    break;
                case Data.ToolbarItems.MAIN_SAVE_VIZ:
                    break;
                case Data.ToolbarItems.MAIN_SAVEAS_VIZ:
                    break;
                case Data.ToolbarItems.MAIN_EXPORT:
                    break;
                case Data.ToolbarItems.MAIN_EXPORT_STRUCTURE:
                    break;
                case Data.ToolbarItems.MAIN_EXPORT_OUTSIDE:
                    break;
                case Data.ToolbarItems.MAIN_MERGERULES_ADD:
                    break;
                case Data.ToolbarItems.MAIN_MERGERULES_OPEN:
                    break;
                case Data.ToolbarItems.MAIN_MERGERULES_CLEAR:
                    break;
                case Data.ToolbarItems.MAIN_EXPORT_VIZX:
                    break;
                case Data.ToolbarItems.MAIN_CONVERSION:
                    break;
                case Data.ToolbarItems.MAIN_SIMPLIFY_MODEL:
                    break;
                case Data.ToolbarItems.MAIN_MODELTREE:
                    break;
                case Data.ToolbarItems.MAIN_PROJECTION_PERSPECTIVE:
                    break;
                case Data.ToolbarItems.MAIN_PROJECTION_ORTHOGRAPHIC:
                    break;
                case Data.ToolbarItems.MAIN_NAVIGATION_PAN:
                    break;
                case Data.ToolbarItems.MAIN_NAVIGATION_ROTATE:
                    break;
                case Data.ToolbarItems.MAIN_NAVIGATION_ORBIT:
                    break;
                case Data.ToolbarItems.MAIN_NAVIGATION_WALK:
                    break;
                case Data.ToolbarItems.MAIN_NAVIGATION_FLY:
                    break;
                case Data.ToolbarItems.MAIN_AVATAR_VISIBLE:
                    break;
                case Data.ToolbarItems.MAIN_AVATAR_POSITION:
                    break;
                case Data.ToolbarItems.MAIN_RENDERING_WIRE:
                    break;
                case Data.ToolbarItems.MAIN_RENDERING_FLAT:
                    break;
                case Data.ToolbarItems.MAIN_RENDERING_SMOOTH:
                    break;
                case Data.ToolbarItems.MAIN_RENDERING_EDGE:
                    break;
                case Data.ToolbarItems.MAIN_RENDERING_SMOOTHEDGE:
                    break;
                case Data.ToolbarItems.MAIN_RENDERING_HIDDENLINEREMOVAL:
                    break;
                case Data.ToolbarItems.MAIN_RENDERING_DASH_LINE:
                    break;
                case Data.ToolbarItems.MAIN_EFFECT_PHONGSHADING:
                    break;
                case Data.ToolbarItems.MAIN_EFFECT_PBR:
                    break;
                case Data.ToolbarItems.MAIN_EFFECT_SILHOUETTEEDGE:
                    break;
                case Data.ToolbarItems.MAIN_EFFECT_REALTIMESHADOW:
                    break;
                case Data.ToolbarItems.MAIN_EFFECT_FLOORSHADOW:
                    break;
                case Data.ToolbarItems.MAIN_EFFECT_SHADING:
                    break;
                case Data.ToolbarItems.MAIN_EFFECT_ENVIRONMENTLIGHT:
                    break;
                case Data.ToolbarItems.MAIN_EFFECT_PLANEREFLECTION:
                    break;
                case Data.ToolbarItems.MAIN_EFFECT_ANTIALIASING:
                    break;
                case Data.ToolbarItems.MAIN_EFFECT_SETTING:
                    break;
                case Data.ToolbarItems.MAIN_XRAY:
                    break;
                case Data.ToolbarItems.MAIN_SELECTION_BOX:
                    break;
                case Data.ToolbarItems.MAIN_SELECTION_BOX_MULTI:
                    break;
                case Data.ToolbarItems.MAIN_SELECTION_ALL:
                    break;
                case Data.ToolbarItems.MAIN_SELECTION_CLEAR:
                    break;
                case Data.ToolbarItems.MAIN_SELECTION_INVERT:
                    break;
                case Data.ToolbarItems.MAIN_VISIBLE_HIDE_SELECTED:
                    break;
                case Data.ToolbarItems.MAIN_VISIBLE_HIDE_UNSELECTED:
                    break;
                case Data.ToolbarItems.MAIN_VISIBLE_SHOW_ALL:
                    break;
                case Data.ToolbarItems.MAIN_VISIBLE_HIDE_ALL:
                    break;
                case Data.ToolbarItems.MAIN_MINIVIEW:
                    break;
                case Data.ToolbarItems.MAIN_VIEW_RESET:
                    break;
                case Data.ToolbarItems.MAIN_VIEW_FIT:
                    break;
                case Data.ToolbarItems.MAIN_VIEW_MOVECENTER:
                    break;
                case Data.ToolbarItems.MAIN_VIEW_FLY:
                    break;
                case Data.ToolbarItems.MAIN_VIEW_BOXZOOM:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_ISOPLUS:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_ISOMINUS:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_XPLUS:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_XMINUS:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_YPLUS:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_YMINUS:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_ZPLUS:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_ZMINUS:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_XPLUS_ANGLE:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_XMINUS_ANGLE:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_YPLUS_ANGLE:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_YMINUS_ANGLE:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_ZPLUS_ANGLE:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_ZMINUS_ANGLE:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_AXIS_PLUS:
                    break;
                case Data.ToolbarItems.MAIN_CAMERA_AXIS_MINUS:
                    break;
                case Data.ToolbarItems.MAIN_COLOR_CHANGE:
                    break;
                case Data.ToolbarItems.MAIN_COLOR_RESTORE:
                    break;
                case Data.ToolbarItems.MAIN_COLOR_RESTORE_ALL:
                    break;
                case Data.ToolbarItems.MAIN_ALPHA_CHANGE:
                    break;
                case Data.ToolbarItems.MAIN_ALPHA_RESTORE:
                    break;
                case Data.ToolbarItems.MAIN_ALPHA_RESTORE_ALL:
                    break;
                case Data.ToolbarItems.MAIN_COLOR_ALPHA_RESTORE_ALL:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_HANDLE:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_HANDLE_DEFAULT:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_HANDLE_AXIS:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_HANDLE_PLANE:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_HANDLE_ROTATE:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_ROTATE:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_MOVE:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_RESTORE:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_RESTORE_ALL:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_MOVE_TARGET_POINT:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_MOVE_TARGET_LINE:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_MOVE_TARGET_SURFACE:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_DISASSEMBLY:
                    break;
                case Data.ToolbarItems.MAIN_TRANSFORM_MATRIX:
                    break;
                case Data.ToolbarItems.MAIN_FIND_NODE:
                    break;
                case Data.ToolbarItems.MAIN_FIND_OUTSIDE:
                    break;
                case Data.ToolbarItems.MAIN_FIND_SPACE:
                    break;
                case Data.ToolbarItems.MAIN_SCREENITEM_FRAME:
                    break;
                case Data.ToolbarItems.MAIN_SCREENITEM_VIEWTOOLBAR:
                    break;
                case Data.ToolbarItems.MAIN_SCREENITEM_AXIS:
                    break;
                case Data.ToolbarItems.MAIN_IMAGE_CLIPBOARD:
                    break;
                case Data.ToolbarItems.MAIN_PRINT:
                    break;
                case Data.ToolbarItems.MAIN_WINDOW_GEOMETRY_PROPERTY:
                    break;
                case Data.ToolbarItems.MAIN_WINDOW_UDA:
                    break;
                case Data.ToolbarItems.MAIN_WINDOW_UDA_TREE:
                    break;
                case Data.ToolbarItems.MAIN_SETTING:
                    break;
                case Data.ToolbarItems.MAIN_MODEL_INFORMATION:
                    break;
                case Data.ToolbarItems.MAIN_FRAME_OPEN:
                    break;
                case Data.ToolbarItems.SECTION_ADD_PLANE:
                    break;
                case Data.ToolbarItems.SECTION_ADD_BOX:
                    {
                        e.Cancel = true;

                        vizcore3dMain.Section.AddBox(false);
                        vizcore3dSub1.Section.AddBox(false);
                        vizcore3dSub2.Section.AddBox(false);
                    }
                    break;
                case Data.ToolbarItems.SECTION_ADD_INBOX3:
                    break;
                case Data.ToolbarItems.SECTION_ADD_INBOX6:
                    break;
                case Data.ToolbarItems.SECTION_CLIPPING_ONEWAY:
                    break;
                case Data.ToolbarItems.SECTION_CLIPPING_BIDIRECTIONAL:
                    break;
                case Data.ToolbarItems.SECTION_CLIPPING_CHANGE:
                    break;
                case Data.ToolbarItems.SECTION_ADD_PLANE_PART:
                    break;
                case Data.ToolbarItems.SECTION_ADD_BOX_PART:
                    break;
                case Data.ToolbarItems.SECTION_DELETE:
                    break;
                case Data.ToolbarItems.SECTION_CLEAR:
                    break;
                case Data.ToolbarItems.SECTION_HANDLE_ROTATE:
                    break;
                case Data.ToolbarItems.SECTION_HANDLE_SCALE:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_X:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_Y:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_Z:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_HORIZONTAL:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_VERTICAL:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_CROSS:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_BETWEEN_TWO_POINTS:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_THREE_POINTS:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_SURFACE:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_TWO_POINTS:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_FRAME:
                    break;
                case Data.ToolbarItems.SECTION_ALIGN_SELECT_POINT:
                    break;
                case Data.ToolbarItems.SECTION_VISIBLE_LINE:
                    {
                        e.Cancel = true;

                        vizcore3dMain.Section.ShowSectionLine = !vizcore3dMain.Section.ShowSectionLine;

                        vizcore3dSub1.Section.ShowSectionLine = vizcore3dMain.Section.ShowSectionLine;
                        vizcore3dSub2.Section.ShowSectionLine = vizcore3dMain.Section.ShowSectionLine;
                    }
                    break;
                case Data.ToolbarItems.SECTION_VISIBLE_PLANE:
                    {
                        e.Cancel = true;

                        vizcore3dMain.Section.ShowSectionPlane = !vizcore3dMain.Section.ShowSectionPlane;

                        vizcore3dSub1.Section.ShowSectionPlane = vizcore3dMain.Section.ShowSectionPlane;
                        vizcore3dSub2.Section.ShowSectionPlane = vizcore3dMain.Section.ShowSectionPlane;
                    }
                    break;
                case Data.ToolbarItems.NOTE_ADD_NOTE_SURFACE:
                    break;
                case Data.ToolbarItems.NOTE_ADD_NOTE_2:
                    break;
                case Data.ToolbarItems.NOTE_ADD_NOTE_3:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_BEGIN:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_DELETE:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_END:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_TEXT:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_PEN:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_LINE:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_SQUARE:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_CIRCLE:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_CLOUD:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_ARROW:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_FREECURVE:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_SHOW_ALL:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_HIDE_ALL:
                    break;
                case Data.ToolbarItems.NOTE_DRAWMODE_STYLE:
                    break;
                case Data.ToolbarItems.NOTE_DELETE:
                    break;
                case Data.ToolbarItems.NOTE_CLEAR:
                    break;
                case Data.ToolbarItems.NOTE_SHOW_ALL:
                    break;
                case Data.ToolbarItems.NOTE_HIDE_ALL:
                    break;
                case Data.ToolbarItems.NOTE_SURFACE_SHOW_ALL:
                    break;
                case Data.ToolbarItems.NOTE_SURFACE_HIDE_ALL:
                    break;
                case Data.ToolbarItems.NOTE_3D_SHOW_ALL:
                    break;
                case Data.ToolbarItems.NOTE_3D_HIDE_ALL:
                    break;
                case Data.ToolbarItems.NOTE_2D_SHOW_ALL:
                    break;
                case Data.ToolbarItems.NOTE_2D_HIDE_ALL:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_BASIC_POSITION:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_BASIC_DISTANCE:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_BASIC_ANGLE:
                    break;
                case Data.ToolbarItems.MEASURE_ADD:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_POINTS:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_CUSTOMLINEAXIS:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_PARALLELPLANE:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_MINIMUM:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_BOP:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_AXIALDIRECTIONXYZ:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_AXIALDIRECTIONX:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_AXIALDIRECTIONY:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_AXIALDIRECTIONZ:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_CONTINUOUS:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_CONTINUOUS_AXIALDIRECTIONX:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_CONTINUOUS_AXIALDIRECTIONY:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_DISTANCE_CONTINUOUS_AXIALDIRECTIONZ:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_AREA:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_ANGLE:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_INTERSECTION_LINE_PLANE:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_INTERSECTION_CYLINDER_CYLINDER:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_BOUNDBOX:
                    break;
                case Data.ToolbarItems.MEASURE_ADD_BOUNDBOX_PLANE:
                    break;
                case Data.ToolbarItems.MEASURE_CANCEL:
                    break;
                case Data.ToolbarItems.MEASURE_SHOW_ALL:
                    break;
                case Data.ToolbarItems.MEASURE_HIDE_ALL:
                    break;
                case Data.ToolbarItems.MEASURE_DELETE:
                    break;
                case Data.ToolbarItems.MEASURE_CLEAR:
                    break;
                case Data.ToolbarItems.PRIMITIVE_BOX:
                    break;
                case Data.ToolbarItems.PRIMITIVE_PYRAMID:
                    break;
                case Data.ToolbarItems.PRIMITIVE_CYLINDER:
                    break;
                case Data.ToolbarItems.PRIMITIVE_SLOPE_BOTTOM_CYLINDER:
                    break;
                case Data.ToolbarItems.PRIMITIVE_CONE:
                    break;
                case Data.ToolbarItems.PRIMITIVE_CIRCULAR_TORUS:
                    break;
                case Data.ToolbarItems.PRIMITIVE_RECTANGULAR_TORUS:
                    break;
                case Data.ToolbarItems.PRIMITIVE_SPHERE:
                    break;
                case Data.ToolbarItems.PRIMITIVE_SPHEROID:
                    break;
                default:
                    break;
            }
        }

        private void Section_OnSectionEvent(object sender, Event.EventManager.SectionEventArgs e)
        {
            switch (e.EventType)
            {
                case Manager.SectionManager.EventTypes.ADD:
                    break;
                case Manager.SectionManager.EventTypes.DELETE:
                    {
                        vizcore3dSub1.Section.Delete(e.Section.ID);
                        vizcore3dSub2.Section.Delete(e.Section.ID);
                    }
                    break;
                case Manager.SectionManager.EventTypes.CLEAR:
                    {
                        vizcore3dSub1.Section.Clear();
                        vizcore3dSub2.Section.Clear();
                    }
                    break;
                case Manager.SectionManager.EventTypes.SELECT:
                    break;
                case Manager.SectionManager.EventTypes.TRANSFORM:
                    {
                        VIZCore3D.NET.Data.BoundBox3D box = vizcore3dMain.Section.SelectedItem.BoundBox;

                        vizcore3dSub1.Section.SetBoxSize(e.Section.ID, box);
                        vizcore3dSub2.Section.SetBoxSize(e.Section.ID, box);
                    }
                    break;
                case Manager.SectionManager.EventTypes.RESIZED:
                    {
                        VIZCore3D.NET.Data.BoundBox3D box = vizcore3dMain.Section.SelectedItem.BoundBox;

                        vizcore3dSub1.Section.SetBoxSize(e.Section.ID, box);
                        vizcore3dSub2.Section.SetBoxSize(e.Section.ID, box);
                    }
                    break;
                default:
                    break;
            }
        }

        private void Section_OnSectionHandleEvent(object sender, Event.EventManager.SectionHandleEventArgs e)
        {
            switch (e.EventType)
            {
                case Manager.SectionManager.HandleEventTypes.ENABLE:
                    break;
                case Manager.SectionManager.HandleEventTypes.DISABLE:
                    break;
                default:
                    break;
            }
        }
    }
}
