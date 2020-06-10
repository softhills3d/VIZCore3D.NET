using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.Import.WDL
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
        /// WDL Importer
        /// </summary>

        private VIZCore3D.NET.Importer.ShxWdl wdl;

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
            vizcore3d.Review.Note.FontSize = VIZCore3D.NET.Data.FontSizeKind.SIZE12;
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
            vizcore3d.Review.Note.SymbolFontSize = VIZCore3D.NET.Data.FontSizeKind.SIZE10;
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
            vizcore3d.ToolbarNote.Visible = true;
            vizcore3d.ToolbarMeasure.Visible = false;
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
            vizcore3d.EndUpdate();
        } 
        #endregion

        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            vizcore3d.Object3D.OnSelectedObject3D += Object3D_OnSelectedObject3D;
        }

        private void Object3D_OnSelectedObject3D(object sender, VIZCore3D.NET.Event.EventManager.SelectedObject3DEventArgs e)
        {
            if (e.Node.Count == 0)
            {
            }
            else
            {
                VIZCore3D.NET.Data.Node item = vizcore3d.Object3D.FromIndex(e.Node[0].Index, true);
                // WELDLINE 모델은 NodePath에 "WELD"가 포함되어 있음.
                if (item.NodePath.Contains("WELD") == false) return;

                List<VIZCore3D.NET.Importer.ShxWdlTreeData> items = wdl.GetTree(item.NodeName);

                if (items.Count == 0) return;

                wdlTree.AfterSelect -= new System.Windows.Forms.TreeViewEventHandler(this.wdlTree_AfterSelect);
                TreeNode itemNode = null;
                foreach (TreeNode node in wdlTree.Nodes)
                {
                    itemNode = FromID(items[0], node);
                    if (itemNode != null) break;
                }
                if (itemNode != null)
                    wdlTree.SelectedNode = itemNode;
                wdlTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.wdlTree_AfterSelect);
            }
        }

        public TreeNode FromID(VIZCore3D.NET.Importer.ShxWdlTreeData item, TreeNode rootNode)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                if (node.Tag.Equals(item)) return node;
                TreeNode next = FromID(item, node);
                if (next != null) return next;
            }
            return null;
        }
        

        private void btnOpenModel_Click(object sender, EventArgs e)
        {
            if(vizcore3d.Model.IsOpen() == true)
            {
                vizcore3d.Model.Close();
            }

            vizcore3d.Model.OpenFileDialog();
        }

        private void btnOpenWdl_Click(object sender, EventArgs e)
        {
            wdl = VIZCore3D.NET.Importer.ShxWdl.OpenWdlFileDialog();

            if (wdl == null) return;

            MakeTreeNode();
        }

        private void MakeTreeNode()
        {
            List<VIZCore3D.NET.Importer.ShxWdlTreeData> roots = wdl.GetRootTree();

            wdlTree.BeginUpdate();
            wdlTree.Nodes.Clear();

            foreach (VIZCore3D.NET.Importer.ShxWdlTreeData item in roots)
            {
                TreeNode node = wdlTree.Nodes.Add(item.FullName);
                node.Tag = item;

                if (item.Child.Count == 0) continue;
                MakeChildNode(node, item);
            }

            wdlTree.EndUpdate();
        }

        private void MakeChildNode(TreeNode parentNode, VIZCore3D.NET.Importer.ShxWdlTreeData treeData)
        {
            foreach (VIZCore3D.NET.Importer.ShxWdlTreeData item in treeData.Child)
            {
                TreeNode node = new TreeNode(item.FullName);
                node.Tag = item;
                parentNode.Nodes.Add(node);

                if (item.Child.Count == 0) continue;
                MakeChildNode(node, item);
            }
        }

        private void wdlTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            if (e.Node.Tag == null) return;

            VIZCore3D.NET.Importer.ShxWdlTreeData tree = (VIZCore3D.NET.Importer.ShxWdlTreeData)e.Node.Tag;

            VIZCore3D.NET.Importer.ShxWdlMatchingTree parts = wdl.GetParts(tree);
            if (parts == null) return;

            List<string> filter = new List<string>();
            List<string> filterEx = new List<string>();

            lvParts.BeginUpdate();
            lvParts.Items.Clear();

            // 중복 제거 및 Count
            Dictionary<string, int> Count = new Dictionary<string, int>();
            foreach (KeyValuePair<string, string> item in parts.Parts)
            {
                if (Count.ContainsKey(item.Key) == false)
                    Count.Add(item.Key, 1);
                else
                    Count[item.Key] = Count[item.Key] + 1;
            }

            foreach (KeyValuePair<string, int> item in Count)
            {
                VIZCore3D.NET.Importer.ShxWdlJLData jlData = wdl.GetJLData(item.Key);

                if (jlData == null) continue;

                ListViewItem lvi = new ListViewItem(
                    new string[] 
                        { 
                            jlData.Part                         /* 소유 부재 */
                            , jlData.ContactPart                /* 접촉 부재 */
                            , Convert.ToInt32(Convert.ToSingle(jlData.ContactPartWeight)).ToString() /* 각장/두께 */
                            , item.Value.ToString()             /* 수량 - 계산 */
                            , jlData.Sign                       /* 개선 */
                            , jlData.Code                       /* LEVEL CODE */
                            , jlData.Stage                      /* STAGE */
                            , jlData.PR                         /* PR */
                            , jlData.Direction                  /* 방향 */
                            , jlData.WeldingPosture.ToString() /* 용접자세 */
                            , Convert.ToInt32(jlData.WeldLineLength).ToString() /* 길이(mm) */
                            , jlData.ActCode                    /* ACT */
                            , jlData.WeldingTypeDetail          /* 비고 */
                        }
                    );

                lvi.Tag = jlData;

                lvParts.Items.Add(lvi);

                filter.Add(jlData.Part);
                filterEx.Add(jlData.Part);
                filterEx.Add(jlData.ContactPart);
            }

            lvParts.EndUpdate();

            if (filter.Count == 0) return;
            if (ckXray.Checked == false) return;

            List<VIZCore3D.NET.Data.Node> find = vizcore3d.Object3D.Find.QuickSearch(
                    filter
                    , false
                    , ckUnit.Checked == true ? false : true
                    , false
                    , false
                    , true
                    , true
                    );

            List<VIZCore3D.NET.Data.Node> result = new List<Data.Node>();
            foreach (VIZCore3D.NET.Data.Node item in find)
            {
                if (item.NodePath.Contains("WELD") == false) continue;
                result.Add(item);
            }

            if (result.Count == 0) return;

            vizcore3d.View.XRay.Clear();
            vizcore3d.View.XRay.Select(result, true, true);
            vizcore3d.View.FlyToObject3d(result, 1.0f);

            //if (ckHighlightPart.Checked == false)
            //{
            //    List<VIZCore3D.NET.Data.Node> find = vizcore3d.Object3D.Find.QuickSearch(
            //        filter
            //        , false
            //        , ckUnit.Checked == true ? false : true
            //        , false
            //        , false
            //        , true
            //        , true
            //        );

            //    List<VIZCore3D.NET.Data.Node> result = new List<Data.Node>();
            //    foreach (VIZCore3D.NET.Data.Node item in find)
            //    {
            //        if (item.NodePath.Contains("WELD") == false) continue;
            //        result.Add(item);
            //    }

            //    if (result.Count == 0) return;

            //    vizcore3d.View.XRay.Clear();
            //    vizcore3d.View.XRay.Select(result, true, true);
            //    vizcore3d.View.FlyToObject3d(result, 1.0f);
            //}
            //else if(ckHighlightPart.Checked == true)
            //{
            //    Dictionary<string, string> filterPart = new Dictionary<string, string>();
            //    foreach (string item in filterEx)
            //    {
            //        string[] filterArray = item.Split(new char[] { '-' });
            //        string name = string.Format("{0}-{1}", filterArray[0], filterArray[1]);

            //        if (filterPart.ContainsKey(name) == false)
            //            filterPart.Add(name, name);
            //    }

            //    List<VIZCore3D.NET.Data.Node> find = vizcore3d.Object3D.Find.QuickSearch(
            //        filterPart.Keys.ToList()      /* Keyword */
            //        , false     /* Join Condition : True - And, False - Or */
            //        , true      /* Assembly Only : True - Assembly Only, False - All */
            //        , false     /* Visible Only : True - Visible Only, False - All */
            //        , false     /* Selected Only : True - Selected Only, False - All */
            //        , true      /* Full Match : True - Full Match, False - Contains */
            //        , true      /* Include Node Path : True - Include, False - Exclude */
            //        );

            //    List<VIZCore3D.NET.Data.Node> result = new List<Data.Node>();
            //    foreach (VIZCore3D.NET.Data.Node item in find)
            //    {
            //        if (item.NodePath.Contains("WELD") == true) continue;
            //        result.Add(item);
            //    }

            //    //vizcore3d.View.XRay.Clear();

            //    if (result.Count != 0)
            //    {
            //        vizcore3d.View.XRay.Select(result, true, true);
            //        vizcore3d.View.FlyToObject3d(result, 1.0f);
            //    }
            //}
        }

        private void btnMakeModel_Click(object sender, EventArgs e)
        {
            int colorIndex = 8;
            vizcore3d.Primitive.Clear();

            // Automation
            //vizcore3d.Primitive.OpenWeldLine(
            //    string.Format("{0} WELD", wdl.INTRO_BLOCK)
            //    , colorIndex
            //    , 20
            //    , ckUnit.Checked == true ? Manager.PrimitiveManager.PrimitiveGenerationUnit.BUNDLE : Manager.PrimitiveManager.PrimitiveGenerationUnit.SEGMENTATION
            //    , wdl.JL_DATA.Values.ToList()
            //    );

            // API
            VIZCore3D.NET.Manager.PrimitiveObject root = vizcore3d.Primitive.AddNode("WELD");

            foreach (Importer.ShxWdlJLData item in wdl.JL_DATA.Values.ToList())
            {
                VIZCore3D.NET.Manager.PrimitiveObject node = root.AddNode(item.Part, colorIndex);

                if (ckUnit.Checked == true)
                {
                    foreach (Importer.ShxWdlJLDataPoint point in item.WeldLine)
                    {
                        VIZCore3D.NET.Manager.PrimitiveCylinder cylinder = new VIZCore3D.NET.Manager.PrimitiveCylinder();
                        cylinder.Set2Point(point.StartPoint, point.EndPoint, 5);
                        node.AddPrimitive(cylinder);
                    }
                }
                else
                {
                    for (int i = 0; i < item.WeldLine.Count; i++)
                    {
                        string name = string.Format("WELDLINE {0} of {1}", i + 1, item.Part);
                        VIZCore3D.NET.Manager.PrimitiveObject part = node.AddNode(name, colorIndex);

                        Importer.ShxWdlJLDataPoint point = item.WeldLine[i];

                        VIZCore3D.NET.Manager.PrimitiveCylinder cylinder = new VIZCore3D.NET.Manager.PrimitiveCylinder();
                        cylinder.Set2Point(point.StartPoint, point.EndPoint, 5);
                        part.AddPrimitive(cylinder);
                    }
                }
            }

            string output = string.Format("{0}{1} WELD.rev", System.IO.Path.GetTempPath(), wdl.INTRO_BLOCK);
            bool result = vizcore3d.Primitive.Export(output);
            if (result == false) return;

            vizcore3d.Model.Add(new string[] { output });
        }

        private void ckXray_CheckedChanged(object sender, EventArgs e)
        {
            if (ckXray.Checked == true)
                vizcore3d.View.SelectionObject3DType = Data.SelectionObject3DTypes.OPAQUE_OBJECT3D;
            else
                vizcore3d.View.SelectionObject3DType = Data.SelectionObject3DTypes.ALL;
            
            vizcore3d.View.XRay.Enable = ckXray.Checked;
        }

        private void ckHighlight_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHighlight.Checked == false)
            {
                vizcore3d.View.XRay.Clear();
            }
            else
            {
                List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.Find.QuickSearch(
                    new List<string>() { "WELD" }
                    , false
                    , true
                    , false
                    , false
                    , true
                    , false
                    );

                if (items.Count == 0) return;

                vizcore3d.View.XRay.Select(items, true, false);
            }
        }

        private void lvParts_DoubleClick(object sender, EventArgs e)
        {
            if (lvParts.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvParts.SelectedItems[0];
            if (lvi == null) return;
            if (lvi.Tag == null) return;

            VIZCore3D.NET.Importer.ShxWdlJLData jl = (VIZCore3D.NET.Importer.ShxWdlJLData)lvi.Tag;
            string name = jl.Part;

            List<VIZCore3D.NET.Data.Node> items = vizcore3d.Object3D.Find.QuickSearch(
                new List<string>() { name }
                , false
                , false
                , false
                , false
                , true
                , false
                );

            if (items.Count == 0) return;

            vizcore3d.Object3D.Select(VIZCore3D.NET.Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.Object3D.Select(items, true, true);

            vizcore3d.View.FlyToObject3d(1.0f);
        }

        private List<List<Data.Node>> STAGE1;
        private List<List<Data.Node>> STAGE2;

        private void btnMakeStage_Click(object sender, EventArgs e)
        {
            STAGE1 = new List<List<Data.Node>>();
            STAGE2 = new List<List<Data.Node>>();

            List<VIZCore3D.NET.Importer.ShxWdlTreeData> roots = wdl.GetRootTree();

            VIZCore3D.NET.Data.Node model = vizcore3d.Object3D.FromIndex(0);

            foreach (VIZCore3D.NET.Importer.ShxWdlTreeData item in roots)
            {
                if (model.NodeName != item.FullName) continue;

                if (item.Child.Count == 0) continue;
                MakeChildStageNode(item);
            }

            MessageBox.Show(string.Format("STAGE : {0} EA", STAGE1.Count), "VIZCore3D.NET.Import.WDL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MakeChildStageNode(VIZCore3D.NET.Importer.ShxWdlTreeData treeData)
        {
            foreach (VIZCore3D.NET.Importer.ShxWdlTreeData item in treeData.Child)
            {
                if(item.Child.Count == 0)
                {
                    Dictionary<string, string> partCache = new Dictionary<string, string>();

                    VIZCore3D.NET.Importer.ShxWdlMatchingTree part = wdl.GetParts(item);

                    foreach (KeyValuePair<string, string> partItem in part.Parts)
                    {
                        if (partCache.ContainsKey(partItem.Key) == false)
                            partCache.Add(partItem.Key, partItem.Key);
                    }

                    List<string> partList1 = new List<string>();
                    List<string> partList2 = new List<string>();

                    foreach (KeyValuePair<string, string> partName in partCache)
                    {
                        VIZCore3D.NET.Importer.ShxWdlJLData jlData = wdl.GetJLData(partName.Key);
                        if (jlData == null) continue;

                        partList1.Add(jlData.Part);
                        partList2.Add(jlData.ContactPart);
                    }

                    Dictionary<string, string> filterPart1 = new Dictionary<string, string>();
                    Dictionary<string, string> filterPart2 = new Dictionary<string, string>();
                    foreach (string filter in partList1)
                    {
                        string[] filterArray = filter.Split(new char[] { '-' });
                        string name = string.Format("{0}-{1}", filterArray[0], filterArray[1]);

                        if (filterPart1.ContainsKey(name) == false)
                            filterPart1.Add(name, name);
                    }

                    foreach (string filter in partList2)
                    {
                        string[] filterArray = filter.Split(new char[] { '-' });
                        string name = string.Format("{0}-{1}", filterArray[0], filterArray[1]);

                        if (filterPart2.ContainsKey(name) == false)
                            filterPart2.Add(name, name);
                    }

                    List<VIZCore3D.NET.Data.Node> find1 = vizcore3d.Object3D.Find.QuickSearch(
                        filterPart1.Keys.ToList()      /* Keyword */
                        , false     /* Join Condition : True - And, False - Or */
                        , true      /* Assembly Only : True - Assembly Only, False - All */
                        , false     /* Visible Only : True - Visible Only, False - All */
                        , false     /* Selected Only : True - Selected Only, False - All */
                        , true      /* Full Match : True - Full Match, False - Contains */
                        , true      /* Include Node Path : True - Include, False - Exclude */
                        );

                    List<VIZCore3D.NET.Data.Node> find2 = vizcore3d.Object3D.Find.QuickSearch(
                        filterPart2.Keys.ToList()      /* Keyword */
                        , false     /* Join Condition : True - And, False - Or */
                        , true      /* Assembly Only : True - Assembly Only, False - All */
                        , false     /* Visible Only : True - Visible Only, False - All */
                        , false     /* Selected Only : True - Selected Only, False - All */
                        , true      /* Full Match : True - Full Match, False - Contains */
                        , true      /* Include Node Path : True - Include, False - Exclude */
                        );

                    STAGE1.Add(find1);
                    STAGE2.Add(find2);
                }
                else
                {
                    MakeChildStageNode(item);
                }
            }
        }

        private bool IsRotatedCamera = false;

        private void btnShowStage_Click(object sender, EventArgs e)
        {
            if (STAGE1 == null || STAGE1.Count == 0)
            {
                MessageBox.Show("STAGE 구성이 되지 않았습니다.", "VIZCore3D.NET.Import.WDL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (IsRotatedCamera == false)
            {
                vizcore3d.View.RotateCameraByAxis(Data.Axis.X, Data.Directions.PLUS, 180);
                vizcore3d.View.RotateCameraByAxis(Data.Axis.Z, Data.Directions.PLUS, 180);
                vizcore3d.View.FitToView();

                IsRotatedCamera = true;
            }

            vizcore3d.View.XRay.Enable = true;

            backgroundWorkerStage.RunWorkerAsync(STAGE1.Count);
        }

        private void backgroundWorkerStage_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = (int)e.Argument;

            for (int i = 0; i < count; i++)
            {
                backgroundWorkerStage.ReportProgress(i);

                System.Threading.Thread.Sleep(500);
            }   
        }

        private void backgroundWorkerStage_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            vizcore3d.Object3D.Select(Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.Object3D.Color.RestoreColorAll();
            vizcore3d.View.XRay.Enable = false;
        }

        private void backgroundWorkerStage_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            vizcore3d.BeginUpdate();

            vizcore3d.Object3D.Color.RestoreColorAll();

            List<Data.Node> nodes1 = STAGE1[e.ProgressPercentage];
            List<Data.Node> nodes2 = STAGE2[e.ProgressPercentage];

            if (nodes1.Count == 0)
            {
                vizcore3d.EndUpdate();
                return;
            }

            vizcore3d.Object3D.Color.SetColor(nodes2, Color.Blue);
            vizcore3d.Object3D.Color.SetColor(nodes1, Color.Red);
            vizcore3d.View.XRay.Select(nodes1, true, false);
            vizcore3d.View.XRay.Select(nodes2, true, false);

            vizcore3d.EndUpdate();
        }
    }
}