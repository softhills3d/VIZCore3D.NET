using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.GridThreeD
{
    public partial class FrmMain : Form
    {
        // ================================================
        // Attribute & Property
        // ================================================
        /// <summary>
        /// VIZCore3D.NET :: Main
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3dMain;

        /// <summary>
        /// VIZCore3D.NET :: Disassembly
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3dDisassembly;

        /// <summary>
        /// VIZCore3D.NET :: Grid
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3dGrid;

        /// <summary>
        /// VIZCore3D.NET :: View
        /// </summary>
        private VIZCore3D.NET.VIZCore3DControl vizcore3dView;

        /// <summary>
        /// Bounding Box :: Grid ID
        /// </summary>
        public Dictionary<int, string> BoxKey { get; set; }

        public string GridPath { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            // Initialize VIZCore3D.NET
            VIZCore3D.NET.ModuleInitializer.Run();

            #region Construction
            {
                vizcore3dMain = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dMain.Dock = DockStyle.Fill;
                splitContainer3.Panel1.Controls.Add(vizcore3dMain);
            }

            {
                vizcore3dDisassembly = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dDisassembly.Dock = DockStyle.Fill;
                splitContainer3.Panel2.Controls.Add(vizcore3dDisassembly);
            }

            {
                vizcore3dGrid = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dGrid.Dock = DockStyle.Fill;
                splitContainer4.Panel1.Controls.Add(vizcore3dGrid);
            }

            {
                vizcore3dView = new VIZCore3D.NET.VIZCore3DControl();

                vizcore3dView.Dock = DockStyle.Fill;
                splitContainer4.Panel2.Controls.Add(vizcore3dView);
            }
            #endregion

            #region Event
            vizcore3dMain.OnInitializedVIZCore3D += VIZCore3D_Main_OnInitializedVIZCore3D;
            vizcore3dDisassembly.OnInitializedVIZCore3D += VIZCore3D_Disassembly_OnInitializedVIZCore3D;
            vizcore3dGrid.OnInitializedVIZCore3D += VIZCore3D_Grid_OnInitializedVIZCore3D;
            vizcore3dView.OnInitializedVIZCore3D += VIZCore3D_View_OnInitializedVIZCore3D; 
            #endregion
        }

        // ================================================
        // Event - VIZCore3D.NET
        // ================================================
        #region Event - OnInitializedVIZCore3D
        private void VIZCore3D_Main_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3DHelper.OnInitializedVIZCore3D(vizcore3dMain);
        }

        private void VIZCore3D_Disassembly_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3DHelper.OnInitializedVIZCore3D(vizcore3dDisassembly);

            vizcore3dDisassembly.ToolbarMain.Visible = false;
        }

        private void VIZCore3D_Grid_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3DHelper.OnInitializedVIZCore3D(vizcore3dGrid);

            vizcore3dGrid.ToolbarMain.Visible = false;
            vizcore3dGrid.Model.UncheckToUnload = false;

            vizcore3dGrid.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;
        }

        private void VIZCore3D_View_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3DHelper.OnInitializedVIZCore3D(vizcore3dView);
        }

        #endregion


        // ================================================
        // Model
        // ================================================
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string machineName = System.Environment.MachineName.ToUpper();

            if (machineName == "GJKIM-ADELL")
            {
                vizcore3dMain.Model.Open("E:\\MODELS\\SHOWCASE\\SHIP\\H0000.viz");
            }
            else
            {
                vizcore3dMain.Model.OpenFileDialog();
            }
        }

        // ================================================
        // Bounding Box
        // ================================================
        private void btnBoxAdd_Click(object sender, EventArgs e)
        {
            if (vizcore3dMain.Model.IsOpen() == false) return;

            vizcore3dMain.SelectionBox.Clear();
            BoxKey = new Dictionary<int, string>();

            int xCount = Convert.ToInt32(txtBoxX.Text);
            int yCount = Convert.ToInt32(txtBoxY.Text);
            int zCount = Convert.ToInt32(txtBoxZ.Text);

            VIZCore3D.NET.Data.BoundBox3D box = vizcore3dMain.Model.BoundBox;

            float xWidth = box.LengthX / xCount;
            float yWidth = box.LengthY / yCount;
            float zWidth = box.LengthZ / zCount;

            vizcore3dMain.BeginUpdate();

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

                        int id = vizcore3dMain.SelectionBox.Add(
                            selectionbox
                            , Color.FromArgb(10, Color.White)
                            , Color.Black
                            , title
                            );

                        //vizcore3dMain.SelectionBox.SetLabel(id, label);

                        BoxKey.Add(id, string.Format("{0}-{1}-{2}", x + 1, y + 1, z + 1));
                    } // z
                } // y
            }// x


            vizcore3dMain.EndUpdate();

            CreateGridView();
        }

        private void btnBoxClear_Click(object sender, EventArgs e)
        {
            vizcore3dMain.BeginUpdate();
            vizcore3dMain.SelectionBox.Clear();
            vizcore3dMain.EndUpdate();
        }

        // ================================================
        // Grid
        // ================================================
        private string GetGridExportPath(bool clearGrid)
        {
            string path = String.Empty;

            if (String.IsNullOrEmpty(GridPath) == false) return GridPath;

            if (System.Environment.MachineName.ToUpper() == "GJKIM-ADELL")
            {
                path = "E:\\MODELS\\SHOWCASE\\SHIP\\GRID";
                if (System.IO.Directory.Exists(path) == false) System.IO.Directory.CreateDirectory(path);

                if (clearGrid == true)
                {
                    string[] files = System.IO.Directory.GetFiles(path);
                    foreach (string file in files)
                    {
                        System.IO.File.Delete(file);
                    }
                }
            }
            else
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() != DialogResult.OK) return String.Empty;
                path = dlg.SelectedPath;
            }

            GridPath = path;

            return path;
        }

        private void btnExportGrid_Click(object sender, EventArgs e)
        {
            if (vizcore3dMain.Model.IsOpen() == false) return;
            if (vizcore3dMain.SelectionBox.Items.Count == 0) return;
            if (BoxKey == null || BoxKey.Count == 0) return;

            string path = GetGridExportPath(true);

            List<string> output_grid = new List<string>();

            vizcore3dMain.ShowWaitForm();

            foreach (KeyValuePair<int, string> box in BoxKey)
            {
                VIZCore3D.NET.Data.SelectionBox item =
                    vizcore3dMain.SelectionBox.GetItem(box.Key);

                List<int> parts = vizcore3dMain.SelectionBox.GetObject3DIndex(
                    box.Key
                    , VIZCore3D.NET.Data.BoundBoxSearchOption.IncludingPart
                    );

                if (parts.Count == 0) continue;

                string output = string.Format("{0}\\{1}.viz", path, box.Value);

                vizcore3dMain.UpdateWaitForm("Export Grid...", box.Value);

                bool result_grid = vizcore3dMain.Model.ExportGrid(output, item.BoundBox, true);

                if (result_grid == false) continue;

                output_grid.Add(output);
            }

            vizcore3dMain.CloseWaitForm();

            if (output_grid.Count == 0) return;

            vizcore3dDisassembly.Model.Close();
            vizcore3dDisassembly.Model.Add(output_grid);
        }

        private void btnLoadGrid_Click(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(GetGridExportPath(false));

            vizcore3dDisassembly.Model.Close();

            if (files == null || files.Length == 0) return;

            vizcore3dDisassembly.Model.Add(files);
        }



        // ================================================
        // Disassembly
        // ================================================
        private void btnDisassembly_Click(object sender, EventArgs e)
        {
            if (vizcore3dDisassembly.Model.IsOpen() == false) return;

            vizcore3dDisassembly.Object3D.Disassembly.ClearGroup();

            vizcore3dDisassembly.Object3D.Disassembly.EnableAnimation = true;
            vizcore3dDisassembly.Object3D.Disassembly.Distance = 10000.0f;
            vizcore3dDisassembly.Object3D.Disassembly.SideGap = 5.0f;
            vizcore3dDisassembly.Object3D.Disassembly.Target = VIZCore3D.NET.Manager.DisassemblyManager.TargetKind.ALL;

            List<VIZCore3D.NET.Data.Node> items =
                vizcore3dDisassembly.Object3D.GetChildObject3d(
                    0                                                       /* Root Node Index */
                    , VIZCore3D.NET.Data.Object3DChildOption.CHILD_ONLY     /* Sub Node */
                    );

            for (int i = 0; i < items.Count; i++)
            {
                bool result = vizcore3dDisassembly.Object3D.Disassembly.AddGroup(
                    i                   /* ID : 0 ~ */
                    , items[i].Index    /* NODE INDEX */
                    , true              /* Recursive */
                    );
            }

            vizcore3dDisassembly.View.EnableAnimation = false;
            vizcore3dDisassembly.Object3D.Disassembly.Target = VIZCore3D.NET.Manager.DisassemblyManager.TargetKind.ALL;

            vizcore3dDisassembly.Object3D.Disassembly.DisassembleBySphereCenterDistanceRate(
                true        /* Use Group */
                , 0.5f      /* Rate */
                );
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            vizcore3dDisassembly.Object3D.Transform.RestoreTransformAll();

            vizcore3dDisassembly.View.ResetView();
        }



        // ================================================
        // Grid
        // ================================================
        private void btnGrid3D_Click(object sender, EventArgs e)
        {
            if (vizcore3dGrid.Model.IsOpen() == false) return;

            vizcore3dGrid.View.ResetView();
        }

        private void btnGrid2D_Click(object sender, EventArgs e)
        {
            if (vizcore3dGrid.Model.IsOpen() == false) return;

            vizcore3dGrid.View.RotateCamera(Data.ShipbuildingCameraDirection.TOP);
        }

        private void toolbarTree_Click(object sender, EventArgs e)
        {
            if (vizcore3dGrid.Model.IsOpen() == false) return;

            vizcore3dGrid.ModelTreeVisible = !vizcore3dGrid.ModelTreeVisible;
        }

        private void CreateGridView()
        {
            vizcore3dGrid.BeginUpdate();

            int rootIndex = vizcore3dGrid.Model.NewEmptyModel("GRID");

            int xCount = Convert.ToInt32(txtBoxX.Text);
            int yCount = Convert.ToInt32(txtBoxY.Text);
            int zCount = Convert.ToInt32(txtBoxZ.Text);

            VIZCore3D.NET.Data.BoundBox3D box = vizcore3dMain.Model.BoundBox;

            float xWidth = box.LengthX / xCount;
            float yWidth = box.LengthY / yCount;
            float zWidth = box.LengthZ / zCount;

            for (int z = zCount; z > 0; z--)
            {
                string assemblyName = string.Format("Z-AXIS-#{0}", z);
                VIZCore3D.NET.Data.Node assemblyNode =
                    vizcore3dGrid.Structure.CreateNode(
                        rootIndex                               /* Parent Node Index */
                        , VIZCore3D.NET.Data.NodeKind.ASSEMBLY  /* Node Kind */
                        , assemblyName                          /* Node Name */
                        );

                foreach (KeyValuePair<int, string> item in BoxKey)
                {
                    string zLabel = item.Value.Substring(item.Value.Length - 1);
                    if (zLabel != z.ToString()) continue;

                    string partName = item.Value;
                    VIZCore3D.NET.Data.Node partNode =
                        vizcore3dGrid.Structure.CreateNode(
                            assemblyNode.Index                      /* Parent Node Index */
                            , VIZCore3D.NET.Data.NodeKind.PART      /* Node Kind */
                            , partName                              /* Node Name */
                            );

                    string bodyName = string.Format("BODY-{0}", item.Value);
                    int bodyId =
                        vizcore3dGrid.Structure.CreateBody(
                            partNode.Index                          /* Parent Node Index */
                            , bodyName                              /* Node Name */
                            );

                    int bodyIndex = vizcore3dGrid.Object3D.GetBodyIndex(bodyId);

                    VIZCore3D.NET.Data.SelectionBox selectionBox = vizcore3dMain.SelectionBox.GetItem(item.Key);
                    List<float> length = new List<float>() {
                        selectionBox.BoundBox.LengthX
                        , selectionBox.BoundBox.LengthY
                        , selectionBox.BoundBox.LengthZ
                    };

                    VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
                    matrix.SetTranslate(selectionBox.BoundBox.GetCenter().ToVector3D());

                    vizcore3dGrid.MeshEdit.AddPrimitiveBox(
                            bodyIndex           /* Body Node Index */
                            , length            /* Length */
                            , matrix            /* Matrix */
                            , Color.White      /* Color */
                            , false             /* Rebuild Data */
                            );
                }
            }


            vizcore3dGrid.Structure.RebuildData();

            vizcore3dGrid.View.SilhouetteEdge = true;
            vizcore3dGrid.View.XRay.Enable = true;

            vizcore3dGrid.View.ResetView();

            vizcore3dGrid.EndUpdate();
        }

        private void Object3D_OnObject3DSelected(object sender, Event.EventManager.Object3DSelectedEventArgs e)
        {
            if (e.Node.Count == 0) return;

            if (e.Node[0].Kind != VIZCore3D.NET.Data.NodeKind.PART) return;

            string path = GetGridExportPath(false);
            if (String.IsNullOrEmpty(path) == true) return;

            string viz = string.Format("{0}\\{1}.viz", path, e.Node[0].NodeName);
            if (System.IO.File.Exists(viz) == false) return;

            vizcore3dView.Model.Open(viz);
        }
    }
}
