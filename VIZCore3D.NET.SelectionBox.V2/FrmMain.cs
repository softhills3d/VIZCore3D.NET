using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.SelectionBox.V2
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
            vizcore3d.ToolbarMeasurement.Visible = false;
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
            // 개체 선택 이벤트
            vizcore3d.Object3D.OnSelectedObject3D += Object3D_OnSelectedObject3D;

            // 뷰 영역 Drag & Drop 이벤트
            vizcore3d.View.OnViewDragDrop += View_OnViewDragDrop;

            // 선택상자(Selection Box) 이벤트
            vizcore3d.SelectionBox.OnSelectionBoxDragEvent += SelectionBox_OnSelectionBoxDragEvent;
            vizcore3d.SelectionBox.OnSelectionBoxSelectedEvent += SelectionBox_OnSelectionBoxSelectedEvent;
            vizcore3d.SelectionBox.OnSelectionBoxAddSelectionEvent += SelectionBox_OnSelectionBoxAddSelectionEvent;
            vizcore3d.SelectionBox.OnSelectionBoxDeselectedEvent += SelectionBox_OnSelectionBoxDeselectedEvent;
            vizcore3d.SelectionBox.OnSelectionboxResizedEvent += SelectionBox_OnSelectionboxResizedEvent;
            vizcore3d.SelectionBox.OnSelectionBoxDeletedEvent += SelectionBox_OnSelectionBoxDeletedEvent;
            vizcore3d.SelectionBox.OnSelectionBoxClearedEvent += SelectionBox_OnSelectionBoxClearedEvent;
            vizcore3d.SelectionBox.OnSelectionBoxDividedEvent += SelectionBox_OnSelectionBoxDividedEvent;
            vizcore3d.SelectionBox.OnSelectionBoxMergedEvent += SelectionBox_OnSelectionBoxMergedEvent;

            lvUser.SelectedIndexChanged += LvUser_SelectedIndexChanged;

            InitUserList();

            vizcore3d.SelectionBox.EnableController(true, true, false);
        }

        

        private void InitUserList()
        {
            lvUser.Items.Add(new ListViewItem(new string[] { "", "ANDREW", "Blue" }, 0));
            lvUser.Items.Add(new ListViewItem(new string[] { "", "ANNE", "Orange" }, 0));
            lvUser.Items.Add(new ListViewItem(new string[] { "", "JANET", "Yellow" }, 0));
            lvUser.Items.Add(new ListViewItem(new string[] { "", "LAURA", "Green" }, 0));
            lvUser.Items.Add(new ListViewItem(new string[] { "", "MARGARET", "Indigo" }, 0));
            lvUser.Items.Add(new ListViewItem(new string[] { "", "MICHAEL", "Purple" }, 0));
            lvUser.Items.Add(new ListViewItem(new string[] { "", "NANCY", "Beige" }, 0));
            lvUser.Items.Add(new ListViewItem(new string[] { "", "ROBERT", "Crimson" }, 0));
            lvUser.Items.Add(new ListViewItem(new string[] { "", "STEVEN", "Khaki" }, 0));
        }

        private void Object3D_OnSelectedObject3D(object sender, Event.EventManager.SelectedObject3DEventArgs e)
        {
        }

        private void View_OnViewDragDrop(object sender, Event.EventManager.ViewDragDropEventArgs e)
        {
            // ================================================
            // API
            // ================================================
            int id = vizcore3d.SelectionBox.HitTest(e.X, e.Y);
            if (id == -1) return;

            // 확인
            if (id != -1 && e.DragItem != null && e.DragItem is ListViewItem)
            {
                ListViewItem lvi = (ListViewItem)e.DragItem;
                lvi.Tag = id;

                string strColor = lvi.SubItems[2].Text;
                Color color = Color.FromName(strColor);

                vizcore3d.SelectionBox.SetLabel(id, lvi.SubItems[1].Text);

                vizcore3d.SelectionBox.SetFaceColor(id, GetTransparencyColor(color));
                vizcore3d.SelectionBox.SetFontColor(id, Color.Black);
            }
        }

        private void SelectionBox_OnSelectionBoxMergedEvent(object sender, Event.EventManager.SelectionBoxMergedEventArgs e)
        {
        }

        private void SelectionBox_OnSelectionBoxDividedEvent(object sender, Event.EventManager.SelectionBoxDividedEventArgs e)
        {
        }

        private void SelectionBox_OnSelectionBoxClearedEvent(object sender, EventArgs e)
        {
        }

        private void SelectionBox_OnSelectionBoxDeletedEvent(object sender, Event.EventManager.SelectionBoxDeletedEventArgs e)
        {
        }

        private void SelectionBox_OnSelectionboxResizedEvent(object sender, Event.EventManager.SelectionBoxResizedEventArgs e)
        {
        }

        private void SelectionBox_OnSelectionBoxDeselectedEvent(object sender, Event.EventManager.SelectionBoxEventArgs e)
        {
        }

        private void SelectionBox_OnSelectionBoxAddSelectionEvent(object sender, Event.EventManager.SelectionBoxEventArgs e)
        {
        }



        private void SelectionBox_OnSelectionBoxSelectedEvent(object sender, Event.EventManager.SelectionBoxEventArgs e)
        {
            string label = vizcore3d.SelectionBox.GetLabel(e.ID);

            if (String.IsNullOrEmpty(label) == true) return;

            lvUser.SelectedIndexChanged -= LvUser_SelectedIndexChanged;

            int index = -1;
            for (int i = 0; i < lvUser.Items.Count; i++)
            {
                lvUser.Items[i].Selected = false;
                string name = lvUser.Items[i].SubItems[1].Text;

                if (index == -1 && label == name)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                lvUser.SelectedIndexChanged += LvUser_SelectedIndexChanged;
                return;
            }

            lvUser.EnsureVisible(index);
            lvUser.Items[index].Selected = true;

            lvUser.SelectedIndexChanged += LvUser_SelectedIndexChanged;
        }

        private void SelectionBox_OnSelectionBoxDragEvent(object sender, Event.EventManager.SelectionBoxEventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            vizcore3d.SelectionBox.Clear();

            int xCount = Convert.ToInt32(txtCountX.Text);
            int yCount = Convert.ToInt32(txtCountY.Text);
            int zCount = Convert.ToInt32(txtCountZ.Text);

            VIZCore3D.NET.Data.BoundBox3D box = vizcore3d.Model.BoundBox;

            float xWidth = box.LengthX / xCount;
            float yWidth = box.LengthY / yCount;
            float zWidth = box.LengthZ / zCount;

            vizcore3d.BeginUpdate();

            for (int x = 0; x < xCount; x++)
            {
                for (int y = 0; y < yCount; y++)
                {
                    for (int z = 0; z < zCount; z++)
                    {
                        string title = string.Format("선택상자 - {0}/{1}/{2}", x + 1, y + 1, z + 1);
                        string label = string.Format("{0}/{1}/{2}", x + 1, y + 1, z + 1);

                        VIZCore3D.NET.Data.Vertex3D min = new Data.Vertex3D(
                            box.MinX + (xWidth * x)
                            , box.MinY + (yWidth * y)
                            , box.MinZ + (zWidth * z)
                            );

                        VIZCore3D.NET.Data.Vertex3D max = new Data.Vertex3D(
                            min.X + xWidth
                            , min.Y + yWidth
                            , min.Z + zWidth
                            );

                        VIZCore3D.NET.Data.BoundBox3D selectionbox = new Data.BoundBox3D(min, max);

                        int id = vizcore3d.SelectionBox.Add(
                            selectionbox
                            , GetTransparencyColor(Color.FromArgb(100, 255, 255, 255))
                            , GetTransparencyColor(Color.Black)
                            , title
                            );

                        vizcore3d.SelectionBox.SetLabel(id, label);
                    } // z
                } // y
            }// x


            vizcore3d.EndUpdate();

            vizcore3d.SelectionBox.MouseSelectionMode = true;
        }

        private void LvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ckMoveCenter.Checked == false) return;
            if (lvUser.SelectedItems.Count == 0) return;

            ListViewItem lvi = lvUser.SelectedItems[0];
            if (lvi.Tag == null) return;

            int id = (int)lvi.Tag;

            vizcore3d.BeginUpdate();
            vizcore3d.SelectionBox.Select(false);   // 전체 선택 취소
            vizcore3d.SelectionBox.Select(new List<int>() { id }, true); // 선택항목 설정
            vizcore3d.SelectionBox.MoveCenterScreen(true);
            vizcore3d.EndUpdate();
        }

        private System.Drawing.Color GetTransparencyColor(System.Drawing.Color color)
        {
            int transparency = 70;
            return vizcore3d.SelectionBox.GetTransparencyColor(color, transparency);
        }

        private void lvUser_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }
    }
}
