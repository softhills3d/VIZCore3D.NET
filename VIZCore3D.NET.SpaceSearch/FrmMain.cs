using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.SpaceSearch
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
            vizcore3d = new VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(vizcore3d);

            // Event
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
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

        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "VIZ (*.viz)|*.viz";
            if (dlg.ShowDialog() != DialogResult.OK) return;

            vizcore3d.Model.SpaceSearch.Models.Clear();

            vizcore3d.Model.SpaceSearch.AddModel(dlg.FileNames);

            this.Cursor = Cursors.WaitCursor;
            CalcBoundBox();
            this.Cursor = Cursors.Default;
        }

        private void CalcBoundBox()
        {
            lbCount.Text = string.Format("Count : {0} EA", vizcore3d.Model.SpaceSearch.ModelCount);

            VIZCore3D.NET.Data.BoundBox3D ModelBoundBox = vizcore3d.Model.SpaceSearch.GetModelBoundBox();

            lbMinX.Text = Convert.ToInt64(ModelBoundBox.MinX).ToString("n0");
            lbMinY.Text = Convert.ToInt64(ModelBoundBox.MinY).ToString("n0");
            lbMinZ.Text = Convert.ToInt64(ModelBoundBox.MinZ).ToString("n0");

            lbMaxX.Text = Convert.ToInt64(ModelBoundBox.MaxX).ToString("n0");
            lbMaxY.Text = Convert.ToInt64(ModelBoundBox.MaxY).ToString("n0");
            lbMaxZ.Text = Convert.ToInt64(ModelBoundBox.MaxZ).ToString("n0");

            VIZCore3D.NET.Data.Vertex3D center = ModelBoundBox.GetCenter();
            txtCenterX.Text = Convert.ToInt64(center.X).ToString();
            txtCenterY.Text = Convert.ToInt64(center.Y).ToString();
            txtCenterZ.Text = Convert.ToInt64(center.Z).ToString();

            this.tbX.Scroll -= new System.EventHandler(this.tbX_Scroll);
            this.tbY.Scroll -= new System.EventHandler(this.tbY_Scroll);
            this.tbZ.Scroll -= new System.EventHandler(this.tbZ_Scroll);

            tbX.Minimum = tbY.Minimum = tbZ.Minimum = 0;
            tbX.Maximum = tbY.Maximum = tbZ.Maximum = 100;
            tbX.Value = tbY.Value = tbZ.Value = 50;

            this.tbX.Scroll += new System.EventHandler(this.tbX_Scroll);
            this.tbY.Scroll += new System.EventHandler(this.tbY_Scroll);
            this.tbZ.Scroll += new System.EventHandler(this.tbZ_Scroll);
        }

        private void tbX_Scroll(object sender, EventArgs e)
        {
            float pos = vizcore3d.Model.SpaceSearch.ModelBoundBox.MinX + (vizcore3d.Model.SpaceSearch.ModelBoundBox.GetLengthX() / 100.0f * tbX.Value);
            txtCenterX.Text = Convert.ToInt32(pos).ToString();
        }

        private void tbY_Scroll(object sender, EventArgs e)
        {
            float pos = vizcore3d.Model.SpaceSearch.ModelBoundBox.MinY + (vizcore3d.Model.SpaceSearch.ModelBoundBox.GetLengthY() / 100.0f * tbY.Value);
            txtCenterY.Text = Convert.ToInt32(pos).ToString();
        }

        private void tbZ_Scroll(object sender, EventArgs e)
        {
            float pos = vizcore3d.Model.SpaceSearch.ModelBoundBox.MinZ + (vizcore3d.Model.SpaceSearch.ModelBoundBox.GetLengthZ() / 100.0f * tbZ.Value);
            txtCenterZ.Text = Convert.ToInt32(pos).ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool result = vizcore3d.Model.SpaceSearch.Search(
                new VIZCore3D.NET.Data.Vertex3D
                (
                    txtCenterX.Text
                    , txtCenterY.Text
                    , txtCenterZ.Text
                )
                , Convert.ToSingle(txtLengthX.Text)
                , Convert.ToSingle(txtLengthY.Text)
                , Convert.ToSingle(txtLengthZ.Text)
                , rbFile.Checked == true ? Manager.SearchTarget.MODEL : Manager.SearchTarget.NODE
                );

            ShowResultList();
        }

        private void ShowResultList()
        {
            lbResultFile.Text = string.Format("File : {0} EA", vizcore3d.Model.SpaceSearch.ResultFileCount);
            lbResultNode.Text = string.Format("Node : {0} EA", vizcore3d.Model.SpaceSearch.ResultNodeCount);

            lvResult.BeginUpdate();
            lvResult.Groups.Clear();
            lvResult.Items.Clear();

            if(rbFile.Checked == true)
            {
                foreach (KeyValuePair<string, List<string>> item in vizcore3d.Model.SpaceSearch.SearchResult)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { System.IO.Path.GetFileName(item.Key) });
                    lvi.Tag = item.Key;
                    lvResult.Items.Add(lvi);
                }
            }
            else
            {
                foreach (KeyValuePair<string, List<string>> item in vizcore3d.Model.SpaceSearch.SearchResult)
                {
                    ListViewGroup group = new ListViewGroup(System.IO.Path.GetFileName(item.Key), HorizontalAlignment.Left);
                    lvResult.Groups.Add(group);

                    foreach (string nodePath in item.Value)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { nodePath });
                        lvi.Tag = nodePath;
                        lvi.Group = group;
                        lvResult.Items.Add(lvi);
                    }
                }
            }

            lvResult.EndUpdate();
        }

        private void btnViewModel_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.SpaceSearch.ResultFileCount == 0) return;

            vizcore3d.Model.Close();

            // 파일 단위 검색 결과의 경우
            if (rbFile.Checked == true)
            {
                // 결과 모델 열기
                vizcore3d.Model.SpaceSearch.OpenResultModelFile();
            }
            // 노드 단위 검색 결과의 경우
            else
            {
                // 파일 단위로 조회 후, 검색 결과 하이라이트
                if(rbFileUnit.Checked == true)
                {
                    // 결과 모델 열기
                    vizcore3d.Model.SpaceSearch.OpenResultModelFile();

                    // 로드된 검색 결과 노드 목록 조회
                    List<VIZCore3D.NET.Data.Node> resultNode = vizcore3d.Model.SpaceSearch.GetResultNodeLoaded();

                    // 검색 결과 하이라이트
                    vizcore3d.View.XRay.Enable = true;
                    vizcore3d.View.XRay.Clear();
                    vizcore3d.View.XRay.Select(resultNode, true, true);
                    vizcore3d.View.FlyToObject3d(resultNode, 1.2f);
                }
                // 검색 결과 노드만 조회
                else
                {
                    vizcore3d.View.XRay.Enable = false;

                    // 검색 결과 노드만 조회
                    vizcore3d.Model.SpaceSearch.OpenResultModelNode();

                    // VIZXML은 모델이 언로드 상태로 조회 되므로, 최상위 노드를 조회 상태로 변경
                    vizcore3d.Object3D.ShowVIZXMLRoot();
                }
            }
        }

        //private string CreateVIZXML()
        //{
        //    VIZCore3D.NET.Manager.VIZXMLManager vizxml = new Manager.VIZXMLManager("SPACE_SEARCH");

        //    foreach (KeyValuePair<string, List<string>> item in vizcore3d.Model.SpaceSearch.SearchResult)
        //    {
        //        VIZCore3D.NET.Manager.VIZXMLNode model = new Manager.VIZXMLNode(System.IO.Path.GetFileNameWithoutExtension(item.Key).ToUpper());

        //        foreach (string nodePath in item.Value)
        //        {
        //            string[] path = nodePath.Split(new char[] { '\\' });

        //            VIZCore3D.NET.Manager.VIZXMLNode node = new Manager.VIZXMLNode(
        //                path[path.Length - 1]
        //                , item.Key
        //                , nodePath
        //                , Manager.VIZXML_MODEL_KIND.Part
        //                );

        //            model.AddNode(node);
        //        }

        //        vizxml.AddNode(model);
        //    }

        //    bool result = vizxml.ExportVIZXML();

        //    if (result == true) return vizxml.GetFilePath();
        //    else return String.Empty;
        //}
    }
}
