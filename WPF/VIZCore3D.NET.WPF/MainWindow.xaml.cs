﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using VIZCore3D.NET;
using VIZCore3D.NET.Data;
using VIZCore3D.NET.Manager;

namespace WpfVizzard
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        // ================================================
        // Attribute & Property
        // ================================================
        /// <summary>
        /// VIZCore3D.NET
        /// </summary>
        private VIZCore3DControl vizcore3d;

        public MainWindow()
        {
            InitializeComponent();

            InitViz3DControl();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //InitViz3DControl();
        }

        private void InitViz3DControl()
        {
            try
            {
                if (vizcore3d == null)
                {
                    // Initialize VIZCore3D.NET
                    ModuleInitializer.Run();

                    // Construction
                    vizcore3d = new VIZCore3DControl();
                    vizcorehost.Child = vizcore3d;

                    // Event
                    vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
                }

                //NextStepDispatcher next = new NextStepDispatcher();
                //next.NextStep += OnConstructNext;
                //next.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
            //VIZCore3D.NET.Dialogs.LicenseDialog dlg = new VIZCore3D.NET.Dialogs.LicenseDialog();
            //if (dlg.ShowDialog() != DialogResult.OK) return;

            //VIZCore3D.NET.Data.LicenseResults result;

            //if (String.IsNullOrEmpty(dlg.LicenseFile) == false)
            //{
            //    result = vizcore3d.License.LicenseFile(dlg.LicenseFile);
            //}
            //else if (String.IsNullOrEmpty(dlg.LicenseIp) == false && String.IsNullOrEmpty(dlg.LicensePort) == false)
            //{
            //    result = vizcore3d.License.LicenseServer(dlg.LicenseIp, Convert.ToInt32(dlg.LicensePort));
            //}
            //else
            //{
            //    return;
            //}

            LicenseResults result = vizcore3d.License.LicenseFile(@"C:\LICENSE\VIZCore3D.NET.lic");

            //LicenseResults result = vizcore3d.License.LicenseServer("127.0.0.1", 8901);
            //LicenseResults result = vizcore3d.License.LicenseServer("192.168.0.215", 8901);
            if (result != LicenseResults.SUCCESS)
            {
                System.Windows.MessageBox.Show(string.Format("LICENSE CODE : {0}", result.ToString()), "Viz",MessageBoxButton.OK, MessageBoxImage.Error);
                return ;
            }

            // Init. VIZCore3D.NET
            InitializeVIZCore3D();
        }

        private void InitializeVIZCore3D()
        {
            if (vizcore3d != null)
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

                // 모델 열기 시, 스트럭처 병합 설정
                vizcore3d.Model.OpenMergeStructureMode = MergeStructureModes.NONE;

                // 모델 저장 시, 스트럭처 병합 설정
                vizcore3d.Model.SaveMergeStructureMode = MergeStructureModes.NONE;

                // 실린더 원형 품질 개수 : Nomal(12~36), Small(6~36)
                vizcore3d.Model.ReadNormalCylinderSide = 12;
                vizcore3d.Model.ReadSmallCylinderSide = 6;

                // 보이는 모델만 저장

                // VIZXML to VIZ 옵션
                vizcore3d.Model.VIZXMLtoVIZOption = ExportVIZXMLToVIZOptions.LOAD_UNLOADED_NODE;

                // 선택 가능 개체 : 전체, 불투명한 개체
                vizcore3d.View.SelectionObject3DType = SelectionObject3DTypes.ALL;

                // 개체 선택 유형 : 색상, 경계로 선택 (개체), 경계로 선택 (전체)
                vizcore3d.View.SelectionMode = Object3DSelectionOptions.HIGHLIGHT_COLOR;

                // 개체 선택 색상
                vizcore3d.View.SelectionColor = System.Drawing.Color.Red;

                // 모델 조회 시, Pre-Select 설정
                vizcore3d.View.PreSelect.Enable = false;

                // 모델 조회 시, Pre-Select 색상 설정
                vizcore3d.View.PreSelect.HighlightColor = System.Drawing.Color.Lime;

                // 모델 조회 시, Pre-Select Label
                vizcore3d.View.PreSelect.Label = PreSelectStyle.LabelKind.HIERACHY_BOTTOM_UP;

                // 모델 조회 시, Pre-Select Font
                vizcore3d.View.PreSelect.LabelFont = new System.Drawing.Font("Arial", 10.0f);
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
                vizcore3d.View.RotationAxis = Axis.X;
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
                vizcore3d.Walkthrough.AvatarModel = (int)AvatarModels.MAN1;
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
                vizcore3d.View.XRay.ColorType = XRayColorTypes.SELECTION_COLOR;
                // 배경유형
                //vizcore3d.View.BackgroundMode = BackgroundModes.COLOR_ONE;
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
                vizcore3d.Review.Note.BackgroundColor = System.Drawing.Color.Yellow;
                // 배경 투명
                vizcore3d.Review.Note.BackgroudTransparent = false;
                // 글자색
                vizcore3d.Review.Note.FontColor = System.Drawing.Color.Black;
                // 글자 크기
                vizcore3d.Review.Note.FontSize = FontSizeKind.SIZE16;
                // 글자 굵게
                vizcore3d.Review.Note.FontBold = true;
                // 지시선(라인) 색상
                vizcore3d.Review.Note.LineColor = System.Drawing.Color.White;
                // 지시선(라인) 두께
                vizcore3d.Review.Note.LineWidth = 2;
                // 지시선 중앙 연결
                vizcore3d.Review.Note.LinkArrowTailToText = NoteManager.LinkArrowTailToTextKind.OUTLINE;
                // 화살표 색상
                vizcore3d.Review.Note.ArrowColor = System.Drawing.Color.Red;
                // 화살표 두께
                vizcore3d.Review.Note.ArrowWidth = 10;
                // 텍스트상자 라인 색상
                vizcore3d.Review.Note.TextBoxLineColor = System.Drawing.Color.Black;

                // 심볼 배경색
                vizcore3d.Review.Note.SymbolBackgroundColor = System.Drawing.Color.Red;
                // 심볼 글자색
                vizcore3d.Review.Note.SymbolFontColor = System.Drawing.Color.White;
                // 심볼 크기
                vizcore3d.Review.Note.SymbolSize = 10;
                // 심볼 글자 크기
                vizcore3d.Review.Note.SymbolFontSize = FontSizeKind.SIZE16;
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
                MeasureStyle measureStyle = vizcore3d.Review.Measure.GetStyle();

                // Prefix 조회
                measureStyle.Prefix = true;
                // Frame(좌표계)로 표시
                measureStyle.Frame = true;
                // DX, DY, DZ 표시
                measureStyle.DX_DY_DZ = true;
                // 측정 단위 표시
                measureStyle.Unit = true;
                // 측정 단위 유형
                measureStyle.UnitKind = MeasureUnitKind.RUT_MILLIMETER;
                // 소수점 이하 자리수
                measureStyle.NumberOfDecimalPlaces = 2;
                // 연속거리 표시
                measureStyle.ContinuousDistance = true;

                // 배경 투명
                measureStyle.BackgroundTransparent = false;
                // 배경색
                measureStyle.BackgroundColor = System.Drawing.Color.Blue;
                // 글자색
                measureStyle.FontColor = System.Drawing.Color.White;
                // 글자크기
                measureStyle.FontSize = FontSizeKind.SIZE14;
                // 글자 두껍게
                measureStyle.FontBold = false;
                // 지시선 색
                measureStyle.LineColor = System.Drawing.Color.White;
                // 지시선 두께
                measureStyle.LineWidth = 2;
                // 화살표 색
                measureStyle.ArrowColor = System.Drawing.Color.Red;
                // 화살표 크기
                measureStyle.ArrowSize = 10;
                // 보조 지시선 표시
                measureStyle.AssistantLine = true;
                // 보조 지시선 표시 개수
                measureStyle.AssistantLineCount = -1;
                // 보조 지시선 라인 스타일
                measureStyle.AssistantLineStyle = MeasureStyle.AssistantLineType.DOTTEDLINE;
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
                vizcore3d.Section.SectionLineColor = System.Drawing.Color.Red;
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
                vizcore3d.Frame.ForeColor = System.Drawing.Color.Black;

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
                vizcore3d.Statusbar.Visible = true;


                // ================================================================
                // 모델 열기 시, 3D 화면 Rendering 재시작
                // ================================================================
                vizcore3d.EndUpdate();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (vizcore3d == null) return;

            vizcore3d.Dispose();
        }
    }
}
