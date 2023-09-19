using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VIZCore3D.NET.ClashTest.V4
{
    public partial class FrmMain : Form
    {
        // ================================================
        // Attribute & Property
        // ================================================
        /// <summary>
        /// VIZCore3D.NET
        /// </summary>
        public VIZCore3D.NET.VIZCore3DControl vizcore3d { get; set; }


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
            
        }
        #endregion

        #region Function - VIZCore3D.NET : Event
        /// <summary>
        /// 이벤트 등록
        /// </summary>
        private void InitializeVIZCore3DEvent()
        {
            vizcore3d.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;
            vizcore3d.Clash.OnClashTestFinishedEvent += Clash_OnClashTestFinishedEvent;
        }
        #endregion

        // ================================================
        // Event
        // ================================================
        private void btnOpen_Click(object sender, EventArgs e)
        {
			vizcore3d.Model.OpenFileDialog();
		}

        private void Object3D_OnObject3DSelected(object sender, Event.EventManager.Object3DSelectedEventArgs e)
        {
            if (e.Node.Count == 0) return;

            if (ckClashEnable.Checked == true)
            {
				ClearClashResult();
				ExecuteClashTest(e.Node);
			}            
        }

        private void ClearClashResult()
        {
            vizcore3d.BeginUpdate();

            vizcore3d.Object3D.Color.RestoreColor();

            vizcore3d.Object3D.Select(VIZCore3D.NET.Data.Object3dSelectionModes.DESELECT_ALL);
            vizcore3d.View.XRay.Clear();

            vizcore3d.Clash.ClearResultSymbol();

            vizcore3d.EndUpdate();
        }

        private VIZCore3D.NET.Data.ClashTest clash;

        private void ExecuteClashTest(List<VIZCore3D.NET.Data.Node> nodes)
        {
            vizcore3d.Clash.Clear();

            clash = new VIZCore3D.NET.Data.ClashTest();

            clash.Name = "CLASH TEST #1";
            clash.TestKind = VIZCore3D.NET.Data.ClashTest.ClashTestKind.SELECTED_MODEL_VS_OTHER;

            clash.UseClearanceValue = false;
            clash.ClearanceValue = 3.0f;
            clash.UseRangeValue = false;
            clash.RangeValue = 2.0f;
            clash.UsePenetrationTolerance = true;
            clash.PenetrationTolerance = 1.0f;

            clash.VisibleOnly = false;
            clash.BottomLevel = 2;

            clash.GroupA = nodes;

            bool result = vizcore3d.Clash.Add(clash);

            if (result == false) return;

            vizcore3d.Clash.PerformInterferenceCheck(clash.ID);
        }

        private void Clash_OnClashTestFinishedEvent(object sender, Event.EventManager.ClashEventArgs e)
        {
            int id = e.ID;

            List<VIZCore3D.NET.Data.ClashTestResultItem> items =
                vizcore3d.Clash.GetResultItem(clash, VIZCore3D.NET.Manager.ClashManager.ResultGroupingOptions.PART);

            if (items == null || items.Count == 0) return;

            List<int> nodeA = new List<int>();
            List<int> nodeB = new List<int>();
            List<int> node = new List<int>();

            List<VIZCore3D.NET.Data.Vertex3D> v = new List<VIZCore3D.NET.Data.Vertex3D>();
            List<VIZCore3D.NET.Data.ClashResultSymbols> symbols = new List<VIZCore3D.NET.Data.ClashResultSymbols>();

            foreach (VIZCore3D.NET.Data.ClashTestResultItem item in items)
            {
                nodeA.Add(item.NodeIndexA);
                nodeB.Add(item.NodeIndexB);

                node.Add(item.NodeIndexA);
                node.Add(item.NodeIndexB);

                v.Add(item.HotPoint);

                switch (item.ResultKind)
                {
                    case VIZCore3D.NET.Data.ClashTestResultItem.ClashResultKind.PROXIMITY:
                        symbols.Add(VIZCore3D.NET.Data.ClashResultSymbols.Circle);
                        break;
                    case VIZCore3D.NET.Data.ClashTestResultItem.ClashResultKind.CONTACT:
                        symbols.Add(VIZCore3D.NET.Data.ClashResultSymbols.Square);
                        break;
                    case VIZCore3D.NET.Data.ClashTestResultItem.ClashResultKind.PENETRATION:
                        symbols.Add(VIZCore3D.NET.Data.ClashResultSymbols.Triangle);
                        break;
                    case VIZCore3D.NET.Data.ClashTestResultItem.ClashResultKind.CLEARANCE:
                        symbols.Add(VIZCore3D.NET.Data.ClashResultSymbols.Circle);
                        break;
                    default:
                        break;
                }
            }

            vizcore3d.BeginUpdate();

            vizcore3d.Object3D.Color.SetColor(nodeA, Color.Blue);
            vizcore3d.Object3D.Color.SetColor(nodeB, Color.Red);

            if (vizcore3d.View.XRay.Enable == false)
                vizcore3d.View.XRay.Enable = true;

            vizcore3d.View.XRay.Select(node, true, false);

            vizcore3d.Clash.ShowResultSymbol(v, symbols);

            vizcore3d.EndUpdate();
        }

		/// <summary>
		/// 파일 오픈 후 Primitive 추가
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOpen2_Click(object sender, EventArgs e)
		{
            if (vizcore3d.Model.OpenFileDialog())
            {

                VIZCore3D.NET.Manager.PrimitiveObject root = vizcore3d.Primitive.AddNode("Root", 4 /* Yellow Color*/);

                VIZCore3D.NET.Manager.PrimitiveObject child1 = root.AddNode("CHILD1", 7 /* Blue Color */);
                {
                    VIZCore3D.NET.Manager.PrimitiveBox box1 = new VIZCore3D.NET.Manager.PrimitiveBox();

                    box1.Set2Point(
                        new float[] { 0, 0, 0 }
                        , new float[] { 100, 100, 100 }
                        , 500.0f
                        );

                    child1.AddPrimitive(box1);


                    VIZCore3D.NET.Manager.PrimitiveBox box2 = new VIZCore3D.NET.Manager.PrimitiveBox();

                    VIZCore3D.NET.Data.BoundBox3D boundBox1 = new VIZCore3D.NET.Data.BoundBox3D(
                            new VIZCore3D.NET.Data.Vertex3D(200, 200, 200)
                            , new VIZCore3D.NET.Data.Vertex3D(800, 800, 800)
                            );

                    box2.SetMinMaxPoints(boundBox1);

                    child1.AddPrimitive(box2);
                }


                VIZCore3D.NET.Manager.PrimitiveObject child2 = root.AddNode("CHILD2", 11 /* Pink Color */);
                {
                    VIZCore3D.NET.Manager.PrimitiveCylinder cylinder1 = new VIZCore3D.NET.Manager.PrimitiveCylinder();

                    cylinder1.Set2Point(
                        new float[] { 400, 400, 400 }
                        , new float[] { 600, 600, 600 }
                        , 500.0f
                        );

                    child2.AddPrimitive(cylinder1);
                }

                // Open Model
                vizcore3d.Primitive.OpenModel("Primitive", true);

            }
		}

        /// <summary>
        /// 그룹 간섭검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void btnClash_Click(object sender, EventArgs e)
		{
			vizcore3d.Clash.Clear();

			Dictionary<string, List<VIZCore3D.NET.Data.Node>> nameMap = vizcore3d.Object3D.GetNodeNameMapFromDepth(1, false);

			clash = new VIZCore3D.NET.Data.ClashTest();

			clash.Name = "CLASH GROUP TEST #1";
			clash.TestKind = VIZCore3D.NET.Data.ClashTest.ClashTestKind.GROUP_VS_GROUP;

			clash.UseClearanceValue = false;
			clash.ClearanceValue = 3.0f;
			clash.UseRangeValue = false;
			clash.RangeValue = 2.0f;
			clash.UsePenetrationTolerance = true;
			clash.PenetrationTolerance = 1.0f;

			clash.VisibleOnly = false;
			clash.BottomLevel = 2;

            int[] nTemp = { 1 };
            clash.GroupA = vizcore3d.Object3D.GetNodes(nTemp, false);
			clash.GroupB = nameMap.ContainsKey("Primitive") == true ? nameMap["Primitive"] : null;

			bool result = vizcore3d.Clash.Add(clash);

			if (result == false) return;

			vizcore3d.Clash.PerformInterferenceCheck(clash.ID);
		}
	}
}
