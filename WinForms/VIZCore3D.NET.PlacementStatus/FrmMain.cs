﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.PlacementStatus
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

        private List<string> Models { get; set; }

        private Dictionary<string, Data.BoundBox3D> SpaceManager { get; set; }

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

            Models = new List<string>();
            SpaceManager = new Dictionary<string, Data.BoundBox3D>();
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
            vizcore3d.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;

            // 커스텀 드로잉(텍스트) 클릭 이벤트
            vizcore3d.TextDrawing.OnTextDrawingItemClickedEvent += TextDrawing_OnTextDrawingItemClickedEvent;
        }

        private void TextDrawing_OnTextDrawingItemClickedEvent(object sender, Event.EventManager.TextDrawingItemClickedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Event : {0}\n", "OnTextDrawingItemClickedEvent");
            sb.AppendFormat("ID : {0}\n", e.Item.ID);
            sb.AppendFormat("Center : {0}\n", e.Item.Center.ToString());
            sb.AppendFormat("Direction : {0}\n", e.Item.Direction.ToString());
            sb.AppendFormat("UpDirection : {0}\n", e.Item.UpDirection.ToString());
            sb.AppendFormat("Height : {0}\n", e.Item.Height);
            sb.AppendFormat("Color : {0}\n", e.Item.FontColor.ToString());
            sb.AppendFormat("Text : {0}\n", e.Item.Text);
            System.Diagnostics.Trace.WriteLine(sb.ToString());
        }

        private void Object3D_OnObject3DSelected(object sender, VIZCore3D.NET.Event.EventManager.Object3DSelectedEventArgs e)
        {
            if (e.Node.Count == 0) return;
        }

        private void MakeDashboard()
        {
            float contentsColumn = Convert.ToSingle(txtContentsColumn.Text); // 4.0f;
            float contentsRow = Convert.ToSingle(txtContentsRow.Text); // 5.0f;
            float titleHeight = Convert.ToSingle(txtTitleHeight.Text); // 3000.0f;
            float subTitleHeight = Convert.ToSingle(txtSubTitleHeight.Text); // 2000.0f;
            float contentsWidth = Convert.ToSingle(txtContentsWidth.Text); // 15000.0f;
            float contentsHeight = Convert.ToSingle(txtContentsHeight.Text); // 15000.0f;

            vizcore3d.Model.Close();
            SpaceManager.Clear();

            VIZCore3D.NET.Manager.PrimitiveObject root = vizcore3d.Primitive.AddNode("DASHBOARD");

            VIZCore3D.NET.Manager.PrimitiveObject title = root.AddNode("TITLE", 3);

            {
                VIZCore3D.NET.Manager.PrimitiveBox box = new VIZCore3D.NET.Manager.PrimitiveBox();
                VIZCore3D.NET.Data.Vertex3D min = new VIZCore3D.NET.Data.Vertex3D(0, 0, -500);
                VIZCore3D.NET.Data.Vertex3D max = new VIZCore3D.NET.Data.Vertex3D(contentsColumn * contentsWidth, -titleHeight, 0);
                VIZCore3D.NET.Data.BoundBox3D boundbox = new VIZCore3D.NET.Data.BoundBox3D(min, max);
                SpaceManager.Add("TITLE", boundbox);
                box.SetMinMaxPoints(boundbox);
                title.AddPrimitive(box);
            }

            VIZCore3D.NET.Manager.PrimitiveObject contents = root.AddNode("CONTENTS", 10);

            VIZCore3D.NET.Manager.PrimitiveObject group = contents.AddNode("GROUP", 4);
            VIZCore3D.NET.Manager.PrimitiveObject model = contents.AddNode("MODEL", 10);

            {
                int ID = 1;

                for (int i = 0; i < contentsRow; i++)
                {
                    for (int j = 0; j < contentsColumn; j++)
                    {
                        {
                            VIZCore3D.NET.Manager.PrimitiveObject groupItem = group.AddNode(string.Format("GROUP_{0:D2}", ID), 4);

                            // Title
                            VIZCore3D.NET.Manager.PrimitiveBox groupTitleBox = new Manager.PrimitiveBox();
                            VIZCore3D.NET.Data.Vertex3D min = new VIZCore3D.NET.Data.Vertex3D(
                                j * contentsWidth
                                , -titleHeight - (i * (subTitleHeight + contentsHeight))
                                , -500
                                );
                            VIZCore3D.NET.Data.Vertex3D max = new VIZCore3D.NET.Data.Vertex3D(
                                (j + 1) * contentsWidth
                                , -titleHeight - (i * (subTitleHeight + contentsHeight)) - subTitleHeight
                                , 0
                                );
                            VIZCore3D.NET.Data.BoundBox3D groupBoundBox = new VIZCore3D.NET.Data.BoundBox3D(min, max);
                            SpaceManager.Add(string.Format("GROUP_{0:D2}", ID), groupBoundBox);
                            groupTitleBox.SetMinMaxPoints(groupBoundBox);
                            groupItem.AddPrimitive(groupTitleBox);
                        }

                        {
                            VIZCore3D.NET.Manager.PrimitiveObject modelItem = model.AddNode(string.Format("MODEL_{0:D2}", ID), 10);

                            // Thumbnail
                            VIZCore3D.NET.Manager.PrimitiveBox thumbnailBox = new VIZCore3D.NET.Manager.PrimitiveBox();
                            VIZCore3D.NET.Data.Vertex3D min = new VIZCore3D.NET.Data.Vertex3D(
                                j * contentsWidth
                                , -titleHeight - (i * (subTitleHeight + contentsHeight)) - subTitleHeight
                                , -500
                                );
                            VIZCore3D.NET.Data.Vertex3D max = new VIZCore3D.NET.Data.Vertex3D(
                                (j + 1) * contentsWidth
                                , -titleHeight - ((i + 1) * (subTitleHeight + contentsHeight))
                                , 0
                                );
                            VIZCore3D.NET.Data.BoundBox3D thumbnailBoundBox = new VIZCore3D.NET.Data.BoundBox3D(min, max);
                            SpaceManager.Add(string.Format("MODEL_{0:D2}", ID), thumbnailBoundBox);
                            thumbnailBox.SetMinMaxPoints(thumbnailBoundBox);
                            modelItem.AddPrimitive(thumbnailBox);
                        }

                        ID++;
                    }
                }
            }


            {
                vizcore3d.TextDrawing.Clear();

                {
                    VIZCore3D.NET.Data.BoundBox3D boundbox = SpaceManager["TITLE"];

                    VIZCore3D.NET.Data.Vertex3D center = new VIZCore3D.NET.Data.Vertex3D();
                    center.X = boundbox.MinX + (boundbox.LengthX * 0.5f);
                    center.Y = boundbox.MinY + (boundbox.LengthY * 0.5f);
                    center.Z = boundbox.MaxZ;

                    vizcore3d.TextDrawing.Add(
                        center
                        , new VIZCore3D.NET.Data.Vector3D(1, 0, 0) /* X+ 방향으로 텍스트가 표시 */
                        , new VIZCore3D.NET.Data.Vector3D(0, 1, 0) /* 텍스트의 위쪽 방향 : Z+에서 볼때, Y+가 위쪽 임. */
                        , 2000
                        , 100
                        , Color.Black
                        , txtTitle.Text
                        );
                }

                {
                    foreach (KeyValuePair<string, Data.BoundBox3D> item in SpaceManager)
                    {
                        if (item.Key.Contains("GROUP_") == false) continue;

                        VIZCore3D.NET.Data.Vertex3D center = new VIZCore3D.NET.Data.Vertex3D();
                        center.X = item.Value.MinX + (contentsWidth * 0.5f);
                        center.Y = item.Value.MinY + (item.Value.LengthY * 0.5f);
                        center.Z = item.Value.MaxZ;

                        vizcore3d.TextDrawing.Add(
                            center
                            , new VIZCore3D.NET.Data.Vector3D(1, 0, 0) /* X+ 방향으로 텍스트가 표시 */
                            , new VIZCore3D.NET.Data.Vector3D(0, 1, 0) /* 텍스트의 위쪽 방향 : Z+에서 볼때, Y+가 위쪽 임. */
                            , 1000
                            , 100
                            , Color.Black
                            , item.Key.Replace("GROUP", "MODEL")
                            );
                    }
                }
            }

            vizcore3d.Primitive.OpenModel("BAY_BLOCK");

            if(Models.Count != 0)
            {
                PlaceModel();
            }
            else
            {
                vizcore3d.View.MoveCamera(VIZCore3D.NET.Data.CameraDirection.Z_PLUS);
                vizcore3d.View.Navigation = VIZCore3D.NET.Data.NavigationModes.PAN;
                vizcore3d.View.SetRenderMode(VIZCore3D.NET.Data.RenderModes.SMOOTH_EDGE);

                vizcore3d.View.FitToView();
            }
        }

        private void PlaceModel()
        {
            vizcore3d.BeginUpdate();

            int contentsColumn = Convert.ToInt32(txtContentsColumn.Text); // 4.0f;
            int contentsRow = Convert.ToInt32(txtContentsRow.Text); // 5.0f;

            int count = contentsColumn * contentsRow;

            if(Models.Count < count)
            {
                vizcore3d.Model.Add(Models);
            }
            else
            {
                List<string> subModel = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    subModel.Add(Models[i]);
                }
                vizcore3d.Model.Add(subModel);
                Models = subModel;
            }

            for (int i = 0; i < count; i++)
            {
                if (Models.Count - 1 < i) continue;

                // MODEL NAME
                string name = System.IO.Path.GetFileNameWithoutExtension(Models[i]).ToUpper();

                // MODEL BOUNDBOX
                VIZCore3D.NET.Data.BoundBox3D boundBox = VIZCore3D.NET.Manager.ModelManager.GetModelBoundBox(Models[i]);

                List<VIZCore3D.NET.Data.Node> node = vizcore3d.Object3D.Find.QuickSearch(new List<string>() { name }, false, true, false, false, true, false);
                if (node.Count == 0) continue;

                string spaceName = string.Format("MODEL_{0:D2}", i + 1);

                if (SpaceManager.ContainsKey(spaceName) == false) continue;

                VIZCore3D.NET.Data.BoundBox3D modelBoundBox = SpaceManager[spaceName];

                vizcore3d.Object3D.Transform.Move(
                    new int[] { node[0].Index }
                    , modelBoundBox.CenterX - boundBox.CenterX
                    , modelBoundBox.CenterY - boundBox.CenterY
                    , modelBoundBox.CenterZ - boundBox.CenterZ + (ckModelISO.Checked == false ? boundBox.LengthZ * 0.5f : boundBox.LengthZ * 3.0f)
                    , false
                    );

                if (ckModelISO.Checked == true)
                {
                    vizcore3d.Object3D.Select(node, true);

                    vizcore3d.Object3D.Transform.Rotate(
                        new VIZCore3D.NET.Data.Vector3D(50.0f, -40.0f, -30.0f)
                        , true
                        );

                    vizcore3d.Object3D.Select(node, false);
                }
            }

            vizcore3d.View.MoveCamera(VIZCore3D.NET.Data.CameraDirection.Z_PLUS);
            vizcore3d.View.Navigation = VIZCore3D.NET.Data.NavigationModes.PAN;
            vizcore3d.View.SetRenderMode(VIZCore3D.NET.Data.RenderModes.SMOOTH_EDGE);

            vizcore3d.EndUpdate();

            vizcore3d.View.FitToView();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            MakeDashboard();

            vizcore3d.View.SilhouetteEdge = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = vizcore3d.Model.OpenFilter;
            dlg.Multiselect = true;

            if (dlg.ShowDialog() != DialogResult.OK) return;

            Models.Clear();

            foreach (string item in dlg.FileNames)
            {
                Models.Add(item);
            }

            txtContentsWidth.ReadOnly = true;
            txtContentsHeight.ReadOnly = true;

            //VIZCore3D.NET.Data.BoundBox3D boundBox = GetModelBoundBox();

            //float max = boundBox.MaxLengthXY * 0.6f;

            //txtContentsWidth.Text = max.ToString();
            //txtContentsHeight.Text = max.ToString();


            float lengthX = 0.0f;
            float lengthY = 0.0f;
            int nBoundCount = 0;

            foreach (string item in Models)
            {
                VIZCore3D.NET.Data.BoundBox3D mBox = VIZCore3D.NET.Manager.ModelManager.GetModelBoundBox(item);
                lengthX = Math.Max(lengthX, mBox.LengthX);
                lengthY = Math.Max(lengthY, mBox.LengthY);
                nBoundCount++;
            }

            if (nBoundCount != 0)
            {
                txtContentsWidth.Text = Convert.ToString(lengthX + 2000.0f);
                txtContentsHeight.Text = Convert.ToString(lengthY + 2000.0f);
            }
        }

        private VIZCore3D.NET.Data.BoundBox3D GetModelBoundBox()
        {
            VIZCore3D.NET.Data.BoundBox3D ModelBoundBox = new VIZCore3D.NET.Data.BoundBox3D();

            foreach (string item in Models)
            {
                VIZCore3D.NET.Data.BoundBox3D mBox = VIZCore3D.NET.Manager.ModelManager.GetModelBoundBox(item);

                if (mBox.ResetData == false)
                    ModelBoundBox.Set(mBox);
            }

            return ModelBoundBox;
        }

        private void btnClearModel_Click(object sender, EventArgs e)
        {
            Models.Clear();

            txtContentsWidth.ReadOnly = false;
            txtContentsHeight.ReadOnly = false;

            txtContentsWidth.Text = "15000";
            txtContentsHeight.Text = "15000";
        }
    }
}
