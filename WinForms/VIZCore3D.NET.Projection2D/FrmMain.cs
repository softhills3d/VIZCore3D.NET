﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.Projection2D
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

        private ResultControl result;


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

            result = new ResultControl();
            result.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(result);
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
            
        }

        private void btnProjection2D_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            vizcore3d.ShowWaitForm();

            int scale = Convert.ToInt32(txtScale.Text);
            bool vertexAll = ckVertexAll.Checked;
            int quality = tbQuality.Value;

            int virtualImageWidth = Convert.ToInt32(txtVirtualImageWidth.Text);
            int virtualImageHeight = Convert.ToInt32(txtVirtualImageHeight.Text);

            bool enableCoordinateCorrection = ckCoordinateCorrection.Checked;

            //VIZCore3D.NET.Data.Projection2D projection = vizcore3d.View.Get2DProjectionVertex(80, false, 1, 1024, 1024);

            VIZCore3D.NET.Data.Projection2D projection = vizcore3d.View.Get2DProjectionVertex(
                scale                           /* Scale이 클수록 Point의 범위가 줄어듬. 실제 모델의 축소 비율 */
                , vertexAll                     /* True : 모든 형상의 데이터, False : 영역이 제일 큰 형상의 외곽 정보만 추출 */
                , quality                       /* 투영 공간 개수. 범위(1~10). 1(빠르게 처리되지만 품질 보통) ~ 10(오래걸리지만 품질 높음) */
                , virtualImageWidth             /* 투영 공간의 가로 길이. PX단위. 원격(혹은 콘솔) 모드에서는 1024만 가능 */
                , virtualImageHeight            /* 투영 공간의 세로 길이. PX단위. 원격(혹은 콘솔) 모드에서는 1024만 가능 */
                , enableCoordinateCorrection    /* 2D 투영 포인트 좌표 보정 여부. True(XY평면좌표), False(투영결과좌표) */
                );

            if (projection == null) return;

            System.Drawing.Point translation = new Point(0, 0);

            if (String.IsNullOrEmpty(txtX.Text) == false)
                translation.X = Convert.ToInt32(txtX.Text);

            if (String.IsNullOrEmpty(txtY.Text) == false)
                translation.Y = Convert.ToInt32(txtY.Text);

            System.Drawing.Point customTranslation = new Point(0, 0);

            if (String.IsNullOrEmpty(txtCustomMargineX.Text) == false)
                customTranslation.X = Convert.ToInt32(txtCustomMargineX.Text);

            if (String.IsNullOrEmpty(txtCustomMargineY.Text) == false)
                customTranslation.Y = Convert.ToInt32(txtCustomMargineY.Text);

            result.SetData(projection, translation, ckCustomMargine.Checked, customTranslation);

            vizcore3d.CloseWaitForm();
        }

        private void btnSetModelMatrix_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtM00.Text) == true) return;
            if (String.IsNullOrEmpty(txtM01.Text) == true) return;
            if (String.IsNullOrEmpty(txtM02.Text) == true) return;
            if (String.IsNullOrEmpty(txtM03.Text) == true) return;
            if (String.IsNullOrEmpty(txtM10.Text) == true) return;
            if (String.IsNullOrEmpty(txtM11.Text) == true) return;
            if (String.IsNullOrEmpty(txtM12.Text) == true) return;
            if (String.IsNullOrEmpty(txtM13.Text) == true) return;
            if (String.IsNullOrEmpty(txtM20.Text) == true) return;
            if (String.IsNullOrEmpty(txtM21.Text) == true) return;
            if (String.IsNullOrEmpty(txtM22.Text) == true) return;
            if (String.IsNullOrEmpty(txtM23.Text) == true) return;
            if (String.IsNullOrEmpty(txtM30.Text) == true) return;
            if (String.IsNullOrEmpty(txtM31.Text) == true) return;
            if (String.IsNullOrEmpty(txtM32.Text) == true) return;
            if (String.IsNullOrEmpty(txtM33.Text) == true) return;

            float[] matrix = new float[16];

            matrix[0] = Convert.ToSingle(txtM00.Text);
            matrix[1] = Convert.ToSingle(txtM01.Text);
            matrix[2] = Convert.ToSingle(txtM02.Text);
            matrix[3] = Convert.ToSingle(txtM03.Text);
            matrix[4] = Convert.ToSingle(txtM10.Text);
            matrix[5] = Convert.ToSingle(txtM11.Text);
            matrix[6] = Convert.ToSingle(txtM12.Text);
            matrix[7] = Convert.ToSingle(txtM13.Text);
            matrix[8] = Convert.ToSingle(txtM20.Text);
            matrix[9] = Convert.ToSingle(txtM21.Text);
            matrix[10] = Convert.ToSingle(txtM22.Text);
            matrix[11] = Convert.ToSingle(txtM23.Text);
            matrix[12] = Convert.ToSingle(txtM30.Text);
            matrix[13] = Convert.ToSingle(txtM31.Text);
            matrix[14] = Convert.ToSingle(txtM32.Text);
            matrix[15] = Convert.ToSingle(txtM33.Text);

            vizcore3d.Model.SetModelMatrix(matrix);
            vizcore3d.View.ResetView();
            vizcore3d.View.MoveCamera(Data.CameraDirection.Z_PLUS);
        }

        private void btnPasteMatrix_Click(object sender, EventArgs e)
        {
            string str = Clipboard.GetText();

            if (String.IsNullOrEmpty(str) == true) return;

            string[] mat = str.Split(new char[] { ',' });
            if (mat == null || mat.Length != 16) return;

            txtM00.Text = mat[0];
            txtM01.Text = mat[1];
            txtM02.Text = mat[2];
            txtM03.Text = mat[3];
            txtM10.Text = mat[4];
            txtM11.Text = mat[5];
            txtM12.Text = mat[6];
            txtM13.Text = mat[7];
            txtM20.Text = mat[8];
            txtM21.Text = mat[9];
            txtM22.Text = mat[10];
            txtM23.Text = mat[11];
            txtM30.Text = mat[12];
            txtM31.Text = mat[13];
            txtM32.Text = mat[14];
            txtM33.Text = mat[15];
        }

        private void timerAuto_Tick(object sender, EventArgs e)
        {
            timerAuto.Enabled = false;

            //if(BlockNetworkIndex == BlockNetwork.Count)
            //{
            //    timerAuto.Enabled = false;
            //    return;
            //}

            //List<int> items = GetPart(BlockNetwork[BlockNetworkIndex]);
            //BlockNetworkIndex++;

            //HideBlock(items);

            //btnProjection2D.PerformClick();
        }

        private List<int> GetPart(List<int> block)
        {
            List<string> keywork = new List<string>();
            foreach (int item in block)
            {
                keywork.Add(item.ToString());
            }

            List<Data.Node> items = vizcore3d.Object3D.Find.QuickSearch(keywork, false, false, false, false, true, false);

            List<int> result = new List<int>();
            foreach (Data.Node item in items)
            {
                if (item.Kind != Data.NodeKind.PART) continue;
                result.Add(item.Index);
            }

            return result;
        }

        private void HideBlock(List<int> block)
        {
            vizcore3d.Object3D.Show(block, false);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            BlockNetwork = new List<List<int>>();
            BlockNetwork.Add(new List<int>() { 801, 802, 803, 804, 810, 824, 825, 834, 835, 701, 702, 703, 704, 705, 706, 707, 708, 421, 422, 424, 425, 426, 428, 431, 432, 434, 435, 436, 438 });
            BlockNetwork.Add(new List<int>() { 508 });
            BlockNetwork.Add(new List<int>() { 507 });
            BlockNetwork.Add(new List<int>() { 506 });
            BlockNetwork.Add(new List<int>() { 505 });
            BlockNetwork.Add(new List<int>() { 504 });
            BlockNetwork.Add(new List<int>() { 503 });
            BlockNetwork.Add(new List<int>() { 502 });
            BlockNetwork.Add(new List<int>() { 501 });
            BlockNetwork.Add(new List<int>() { 639, 629 });
            BlockNetwork.Add(new List<int>() { 638, 628 });
            BlockNetwork.Add(new List<int>() { 637, 627 });
            BlockNetwork.Add(new List<int>() { 636, 626 });
            BlockNetwork.Add(new List<int>() { 635, 625 });
            BlockNetwork.Add(new List<int>() { 634, 624 });
            BlockNetwork.Add(new List<int>() { 633, 623 });
            BlockNetwork.Add(new List<int>() { 632, 622 });
            BlockNetwork.Add(new List<int>() { 631, 621 });
            BlockNetwork.Add(new List<int>() { 209 });
            BlockNetwork.Add(new List<int>() { 208 });
            BlockNetwork.Add(new List<int>() { 237, 227 });
            BlockNetwork.Add(new List<int>() { 236, 226 });
            BlockNetwork.Add(new List<int>() { 235, 225 });
            BlockNetwork.Add(new List<int>() { 234, 224 });
            BlockNetwork.Add(new List<int>() { 233, 223 });
            BlockNetwork.Add(new List<int>() { 232, 222 });
            BlockNetwork.Add(new List<int>() { 651, 641, 201 });
            BlockNetwork.Add(new List<int>() { 310 });
            BlockNetwork.Add(new List<int>() { 305 });
            BlockNetwork.Add(new List<int>() { 304 });
            BlockNetwork.Add(new List<int>() { 313 });
            BlockNetwork.Add(new List<int>() { 303 });
            BlockNetwork.Add(new List<int>() { 312 });
            BlockNetwork.Add(new List<int>() { 311 });
            BlockNetwork.Add(new List<int>() { 302 });
            BlockNetwork.Add(new List<int>() { 321, 331 });
            BlockNetwork.Add(new List<int>() { 301 });
            BlockNetwork.Add(new List<int>() { 134, 124 });
            BlockNetwork.Add(new List<int>() { 154, 144 });
            BlockNetwork.Add(new List<int>() { 135, 125 });
            BlockNetwork.Add(new List<int>() { 133, 123 });
            BlockNetwork.Add(new List<int>() { 153, 143 });
            BlockNetwork.Add(new List<int>() { 113 });
            BlockNetwork.Add(new List<int>() { 111 });
            BlockNetwork.Add(new List<int>() { 132, 122 });
            BlockNetwork.Add(new List<int>() { 152, 142 });
            BlockNetwork.Add(new List<int>() { 131, 121, 104 });
            BlockNetwork.Add(new List<int>() { 103 });
            BlockNetwork.Add(new List<int>() { 151, 141 });
            BlockNetwork.Add(new List<int>() { 110 });

            timerAuto.Enabled = true;
        }

        private List<List<int>> BlockNetwork;

        private void btnLoadTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            if (dlg.ShowDialog() != DialogResult.OK) return;

            List<string> models = dlg.FileNames.ToList();

            int scale = Convert.ToInt32(txtScale.Text);
            bool vertexAll = ckVertexAll.Checked;
            int quality = tbQuality.Value;

            int virtualImageWidth = Convert.ToInt32(txtVirtualImageWidth.Text);
            int virtualImageHeight = Convert.ToInt32(txtVirtualImageHeight.Text);

            bool enableCoordinateCorrection = ckCoordinateCorrection.Checked;

            vizcore3d.EnableProgressForm = false;
            vizcore3d.EnableWaitForm = false;

            while (true)
            {
                foreach (string item in models)
                {
                    //vizcore3d.ShowWaitForm();

                    vizcore3d.Model.Open(item);

                    VIZCore3D.NET.Data.Projection2D projection = vizcore3d.View.Get2DProjectionVertex(
                        scale                           /* Scale이 클수록 Point의 범위가 줄어듬. 실제 모델의 축소 비율 */
                        , vertexAll                     /* True : 모든 형상의 데이터, False : 영역이 제일 큰 형상의 외곽 정보만 추출 */
                        , quality                       /* 투영 공간 개수. 범위(1~10). 1(빠르게 처리되지만 품질 보통) ~ 10(오래걸리지만 품질 높음) */
                        , virtualImageWidth             /* 투영 공간의 가로 길이. PX단위. 원격(혹은 콘솔) 모드에서는 1024만 가능 */
                        , virtualImageHeight            /* 투영 공간의 세로 길이. PX단위. 원격(혹은 콘솔) 모드에서는 1024만 가능 */
                        , enableCoordinateCorrection    /* 2D 투영 포인트 좌표 보정 여부. True(XY평면좌표), False(투영결과좌표) */
                        );

                    if (projection == null) return;

                    System.Drawing.Point translation = new Point(0, 0);

                    if (String.IsNullOrEmpty(txtX.Text) == false)
                        translation.X = Convert.ToInt32(txtX.Text);

                    if (String.IsNullOrEmpty(txtY.Text) == false)
                        translation.Y = Convert.ToInt32(txtY.Text);

                    System.Drawing.Point customTranslation = new Point(0, 0);

                    if (String.IsNullOrEmpty(txtCustomMargineX.Text) == false)
                        customTranslation.X = Convert.ToInt32(txtCustomMargineX.Text);

                    if (String.IsNullOrEmpty(txtCustomMargineY.Text) == false)
                        customTranslation.Y = Convert.ToInt32(txtCustomMargineY.Text);

                    result.SetData(projection, translation, ckCustomMargine.Checked, customTranslation);
                }
            }
        }
    }                                        
}
