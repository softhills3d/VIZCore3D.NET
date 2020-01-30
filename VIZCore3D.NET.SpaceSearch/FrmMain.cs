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

        public List<string> Source { get; set; }

        public VIZCore3D.NET.Data.BoundBox3D ModelBoundBox { get; set; }

        public Dictionary<string, List<string>> ResultMap { get; set; }

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


            Source = new List<string>();
            ModelBoundBox = new Data.BoundBox3D();
            ResultMap = new Dictionary<string, List<string>>();
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
            vizcore3d.View.Walkthrough.LockZAxis = true;
            // 선속도 : m/s
            vizcore3d.View.Walkthrough.Speed = 2.0f;
            // 각속도
            vizcore3d.View.Walkthrough.AngularSpeed = 30.0f;
            // 높이
            vizcore3d.View.Walkthrough.AvatarHeight = 1800.0f;
            // 반지름
            vizcore3d.View.Walkthrough.AvatarCollisionRadius = 400.0f;
            // 숙임높이
            vizcore3d.View.Walkthrough.AvatarBowWalkHeight = 1300.0f;
            // 충돌
            vizcore3d.View.Walkthrough.UseAvatarCollision = false;
            // 중력
            vizcore3d.View.Walkthrough.UseAvatarGravity = false;
            // 숙임
            vizcore3d.View.Walkthrough.UseAvatarBowWalk = false;
            // 모델
            vizcore3d.View.Walkthrough.AvatarModel = (int)Data.AvatarModels.MAN1;
            // 자동줌
            vizcore3d.View.Walkthrough.EnableAvatarAutoZoom = false;
            // 충돌상자보기
            vizcore3d.View.Walkthrough.ShowAvatarCollisionCylinder = false;
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
            vizcore3d.View.Frame.XYPlane = true;
            vizcore3d.View.Frame.YZPlane = true;
            vizcore3d.View.Frame.ZXPlane = true;
            vizcore3d.View.Frame.PlanLine = true;
            vizcore3d.View.Frame.SectionLine = true;
            vizcore3d.View.Frame.ElevationLine = true;

            // 좌표값 표기
            vizcore3d.View.Frame.ShowNumber = true;

            // 모델 앞에 표기
            vizcore3d.View.Frame.BringToFront = false;

            // Frame(좌표계, SHIP GRID) 색상
            vizcore3d.View.Frame.ForeColor = Color.Black;

            // 홀수번째 표시
            vizcore3d.View.Frame.ShowOddNumber = true;
            // 짝수번째 표시
            vizcore3d.View.Frame.ShowEvenNumber = true;
            // 단면상자에 자동 맞춤
            vizcore3d.View.Frame.AutoFitSectionBox = true;
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

        private bool OpenFiles()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "VIZ (*.viz)|*.viz";
            if (dlg.ShowDialog() != DialogResult.OK) return false;

            Source.AddRange(dlg.FileNames.ToList());
            return true;
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            Source.Clear();

            if (OpenFiles() == false) return;

            CalcBoundBox();
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            if (OpenFiles() == false) return;

            CalcBoundBox();
        }

        private void CalcBoundBox()
        {
            ModelBoundBox = new Data.BoundBox3D();

            lbCount.Text = string.Format("Count : {0} EA", Source.Count);

            foreach (string item in Source)
            {
                VIZCore3D.NET.Data.BoundBox3D mBox = VIZCore3D.NET.Manager.ModelManager.GetModelBoundBox(item);

                ModelBoundBox.Add(mBox);
            }

            lbMinX.Text = Convert.ToInt32(ModelBoundBox.MinX).ToString("n0");
            lbMinY.Text = Convert.ToInt32(ModelBoundBox.MinY).ToString("n0");
            lbMinZ.Text = Convert.ToInt32(ModelBoundBox.MinZ).ToString("n0");

            lbMaxX.Text = Convert.ToInt32(ModelBoundBox.MaxX).ToString("n0");
            lbMaxY.Text = Convert.ToInt32(ModelBoundBox.MaxY).ToString("n0");
            lbMaxZ.Text = Convert.ToInt32(ModelBoundBox.MaxZ).ToString("n0");

            VIZCore3D.NET.Data.Vertex3D center = ModelBoundBox.GetCenter();
            txtCenterX.Text = Convert.ToInt32(center.X).ToString();
            txtCenterY.Text = Convert.ToInt32(center.Y).ToString();
            txtCenterZ.Text = Convert.ToInt32(center.Z).ToString();

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
            float pos = ModelBoundBox.MinX + (ModelBoundBox.GetLengthX() / 100.0f * tbX.Value);
            txtCenterX.Text = Convert.ToInt32(pos).ToString();
        }

        private void tbY_Scroll(object sender, EventArgs e)
        {
            float pos = ModelBoundBox.MinY + (ModelBoundBox.GetLengthY() / 100.0f * tbY.Value);
            txtCenterY.Text = Convert.ToInt32(pos).ToString();
        }

        private void tbZ_Scroll(object sender, EventArgs e)
        {
            float pos = ModelBoundBox.MinZ + (ModelBoundBox.GetLengthZ() / 100.0f * tbZ.Value);
            txtCenterZ.Text = Convert.ToInt32(pos).ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.BoundBox3D space = new Data.BoundBox3D();
            space.Add(
                new VIZCore3D.NET.Data.Vertex3D
                (
                    txtCenterX.Text
                    , txtCenterY.Text
                    , txtCenterZ.Text
                )
                , Convert.ToSingle(txtLengthX.Text)
                , Convert.ToSingle(txtLengthY.Text)
                , Convert.ToSingle(txtLengthZ.Text)
                );

            ResultMap = new Dictionary<string, List<string>>();

            foreach (string item in Source)
            {
                VIZCore3D.NET.Data.BoundBox3D mBox = VIZCore3D.NET.Manager.ModelManager.GetModelBoundBox(item);

                if (space.IsRangeCollide(mBox) == false && mBox.IsRangeCollide(space) == false) continue;

                if (ResultMap.ContainsKey(item) == false)
                    ResultMap.Add(item, new List<string>());
            }

            lbResultFile.Text = string.Format("File : {0} EA", ResultMap.Count);
            lbResultNode.Text = "Node : 0 EA";
            ShowResultList();

            if (rbNode.Checked == false) return;

            foreach (string item in ResultMap.Keys)
            {
                VIZCore3D.NET.Data.ShStructure stru = new Data.ShStructure(item);
                foreach (VIZCore3D.NET.Data.ShModelTreeNode node in stru.GetStructureNodeList())
                {
                    if (node.BoundBox == null) continue;
                    if (node.NodeType != Data.ShModelTreeNodeType.PART) continue;
                    if (space.IsRangeCollide(node.BoundBox) == false) continue;

                    List<string> nodepath = ResultMap[item];
                    nodepath.Add(node.NodePath);
                }
            }

            int nodeCount = 0;
            foreach (KeyValuePair<string, List<string>> item in ResultMap)
            {
                nodeCount += item.Value.Count;
            }

            lbResultNode.Text = string.Format("Node : {0} EA", nodeCount);

            ShowResultList();
        }

        private void ShowResultList()
        {
            lvResult.BeginUpdate();
            lvResult.Groups.Clear();
            lvResult.Items.Clear();

            if(rbFile.Checked == true)
            {
                foreach (KeyValuePair<string, List<string>> item in ResultMap)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { System.IO.Path.GetFileName(item.Key) });
                    lvi.Tag = item.Key;
                    lvResult.Items.Add(lvi);
                }
            }
            else
            {
                foreach (KeyValuePair<string, List<string>> item in ResultMap)
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
            if (ResultMap.Count == 0) return;
            vizcore3d.Model.Close();

            // 파일 단위 검색 결과의 경우
            if (rbFile.Checked == true)
            {
                // 결과 모델 열기
                vizcore3d.Model.Add(ResultMap.Keys.ToArray());
            }
            // 노드 단위 검색 결과의 경우
            else
            {
                // 파일 단위로 조회 후, 검색 결과 하이라이트
                if(ckFile.Checked == true)
                {
                    // 결과 모델 열기
                    vizcore3d.Model.Add(ResultMap.Keys.ToArray());

                    // 전체 로딩된 모델의 경로
                    Dictionary<string, VIZCore3D.NET.Data.Node> nodePath = vizcore3d.Object3D.GetNodePathMap();
                    List<VIZCore3D.NET.Data.Node> resultNode = new List<Data.Node>();
                    foreach (KeyValuePair<string, List<string>> item in ResultMap)
                    {
                        // 검색 결과에 추가해야 하는 접두어
                        string prefix = System.IO.Path.GetFileNameWithoutExtension(item.Key).ToUpper();

                        foreach (string path in item.Value)
                        {
                            // 검색 결과에 새로운 노드패스 설정 및 해당 정보로 검색
                            string str = string.Format("{0}\\{1}", prefix, path);

                            // 검색 결과 취합
                            if (nodePath.ContainsKey(str) == true)
                                resultNode.Add(nodePath[str]);
                        }
                    }

                    // 검색 결과 하이라이트
                    vizcore3d.View.XRay.Enable = true;
                    vizcore3d.View.XRay.Clear();
                    vizcore3d.View.XRay.Select(resultNode, true, true);
                    vizcore3d.View.FlyToObject3d(resultNode, 1.2f);
                }
                // 검색 결과 노드만 조회
                else
                {

                }
            }
        }
    }
}
