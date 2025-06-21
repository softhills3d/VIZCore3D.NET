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
                    VIZCore3D.NET.Data.Object3dFilter.SELECTED_PART
                    );

            if (SourceNodes.Count == 0) return;

            if (SourceNodes.Count == 1)
                txtSource.Text = SourceNodes[0].NodeName;
            else
                txtSource.Text = string.Format("{0} and {1} other items", SourceNodes[0].NodeName, SourceNodes.Count - 1);
        }

        private VIZCore3D.NET.Manager.GeometryUtilityManager.ObjectCollisionType GetCollisionType()
        {
            if (rbAll.Checked == true) return Manager.GeometryUtilityManager.ObjectCollisionType.ALL;
            else if (rbInternal.Checked == true) return Manager.GeometryUtilityManager.ObjectCollisionType.INTERNAL;
            else return Manager.GeometryUtilityManager.ObjectCollisionType.EXTERNAL;
        }

        private void btnGetTarget_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            TargetNodes
                = vizcore3d.Object3D.FromFilter(
                    VIZCore3D.NET.Data.Object3dFilter.SELECTED_PART
                    );

            if (TargetNodes.Count == 0) return;

            if (SourceNodes.Count == 1)
                txtTarget.Text = TargetNodes[0].NodeName;
            else
                txtTarget.Text = string.Format("{0} and {1} other items", TargetNodes[0].NodeName, TargetNodes.Count - 1);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;
            if (SourceNodes == null || SourceNodes.Count == 0) return;
            
            // Clear
            vizcore3d.Object3D.Select(VIZCore3D.NET.Data.Object3dSelectionModes.DESELECT_ALL);
            lvItems.Items.Clear();
            vizcore3d.ShapeDrawing.Clear();

            List<VIZCore3D.NET.Data.IntersectionLine> lineSegments = null;

            if (TargetNodes == null || TargetNodes.Count == 0)
            {
                lineSegments 
                    = vizcore3d.GeometryUtility.GetObjectCollisionLine(SourceNodes, GetCollisionType());
            }
            else
            {
                lineSegments
                    = vizcore3d.GeometryUtility.GetObjectCollisionLine(
                        SourceNodes
                        , TargetNodes
                        );
            }

            List<VIZCore3D.NET.Data.Vertex3DItemCollection> items = new List<Data.Vertex3DItemCollection>();

            lvItems.BeginUpdate();

            int index = 1;
            for (int i = 0; i < lineSegments.Count; i++)
            {
                Data.Vertex3DItemCollection item = new Data.Vertex3DItemCollection();
                item.BaseCollection.Add(lineSegments[i].Start.ToVertex3D());
                item.BaseCollection.Add(lineSegments[i].End.ToVertex3D());
                items.Add(item);

                AddPoints(index, lineSegments[i]);

                index++;
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

        private void AddPoints(int no, VIZCore3D.NET.Data.IntersectionLine s)
        {
            ListViewItem lvi = new ListViewItem(
                    new string[]
                    {
                            no.ToString()
                            , s.SourceID.ToString()
                            , s.TargetID.ToString()
                            , s.Start.ToString()
                            , s.End.ToString()
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