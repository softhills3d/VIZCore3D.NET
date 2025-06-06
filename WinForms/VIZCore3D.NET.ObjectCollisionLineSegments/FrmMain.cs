using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.ObjectCollisionLineSegments
{
    public partial class FrmMain : Form
    {
        private VIZCore3D.NET.VIZCore3DControl vizcore3d { get; set; }
        private List<VIZCore3D.NET.Data.Node> SourceNodes { get; set; }
        private List<VIZCore3D.NET.Data.Node> TargetNodes { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            VIZCore3D.NET.ModuleInitializer.Run();

            vizcore3d = new VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
            this.splitContainer1.Panel2.Controls.Add(vizcore3d);

            btnColor.BackColor = Color.Red;
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.LicenseResults results 
                = vizcore3d.License.LicenseServer("127.0.0.1", 8901);

            if(results != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            {
                MessageBox.Show("License Error : " + results.ToString());
                return;
            }

            vizcore3d.Model.OnModelClosedEvent += Model_OnModelClosedEvent;
        }

        private void Model_OnModelClosedEvent(object sender, EventArgs e)
        {
            ClearItems();
        }

        private void btnGetSource_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            SourceNodes
                = vizcore3d.Object3D.FromFilter(
                    ckTop1.Checked == true 
                    ? VIZCore3D.NET.Data.Object3dFilter.SELECTED_TOP 
                    : VIZCore3D.NET.Data.Object3dFilter.SELECTED_PART
                    );

            if (SourceNodes.Count == 0) return;

            txtSource.Text = SourceNodes[0].NodeName;
        }

        private void btnGetTarget_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            TargetNodes
                = vizcore3d.Object3D.FromFilter(
                    ckTop2.Checked == true
                    ? VIZCore3D.NET.Data.Object3dFilter.SELECTED_TOP
                    : VIZCore3D.NET.Data.Object3dFilter.SELECTED_PART
                    );

            if (TargetNodes.Count == 0) return;

            txtTarget.Text = TargetNodes[0].NodeName;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;
            if (SourceNodes == null || SourceNodes.Count == 0) return;
            
            // Clear
            vizcore3d.Object3D.Select(VIZCore3D.NET.Data.Object3dSelectionModes.DESELECT_ALL);
            lvItems.Items.Clear();
            vizcore3d.ShapeDrawing.Clear();

            List<VIZCore3D.NET.Data.Vector3D> lineSegments = null;

            if (TargetNodes == null || TargetNodes.Count == 0)
            {
                lineSegments 
                    = vizcore3d.GeometryUtility.GetObjectCollisionLine(SourceNodes);
            }
            else
            {
                lineSegments
                    = vizcore3d.GeometryUtility.GetObjectCollisionLine(
                        SourceNodes[0].Index
                        , TargetNodes[0].Index
                        );
            }

            List<VIZCore3D.NET.Data.Vertex3DItemCollection> items = new List<Data.Vertex3DItemCollection>();

            lvItems.BeginUpdate();

            int index = 1;
            int groupId = 1;
            for (int i = 0; i < lineSegments.Count - 1; i += 2)
            {
                Data.Vertex3DItemCollection item = new Data.Vertex3DItemCollection();
                item.BaseCollection.Add(lineSegments[i + 0].ToVertex3D());
                item.BaseCollection.Add(lineSegments[i + 1].ToVertex3D());
                items.Add(item);

                AddPoints(index, groupId, lineSegments[i + 0]);

                index++;

                AddPoints(index, groupId, lineSegments[i + 1]);

                index++;
                groupId++;
            }

            lvItems.EndUpdate();

            // Draw
            int shapeId = vizcore3d.ShapeDrawing.AddLine(
                items
                , 0
                , btnColor.BackColor
                , Convert.ToSingle(txtThickness.Text)
                , true
            );
        }

        private void AddPoints(int no, int group, VIZCore3D.NET.Data.Vector3D v)
        {
            ListViewItem lvi = new ListViewItem(
                    new string[]
                    {
                            no.ToString()
                            , group.ToString()
                            , v.X.ToString()
                            , v.Y.ToString()
                            , v.Z.ToString()
                        }
                    );

            lvItems.Items.Add(lvi);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearItems();
        }

        private void ClearItems()
        {
            if (SourceNodes != null) SourceNodes.Clear();
            if (TargetNodes != null) TargetNodes.Clear();
            lvItems.Items.Clear();
            vizcore3d.ShapeDrawing.Clear();
            txtSource.Text = String.Empty;
            txtTarget.Text = String.Empty;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.AllowFullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = btnColor.BackColor;

            if (dlg.ShowDialog() != DialogResult.OK) return;

            btnColor.BackColor = dlg.Color;
        }

        private void ckDepthTest_CheckedChanged(object sender, EventArgs e)
        {
            vizcore3d.ShapeDrawing.DepthTest = ckDepthTest.Checked;
        }
    }
}
