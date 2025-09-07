using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.LoadingSpace
{
    public partial class FrmMain : Form
    {
        private VIZCore3D.NET.VIZCore3DControl vizcore3d { get; set; }

        private VIZCore3D.NET.Data.BoundBox3D ModelBoundBox { get; set; }

        private List<VIZCore3D.NET.Data.Vector3D> Paths { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            VIZCore3D.NET.ModuleInitializer.Run();

            vizcore3d = new VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
            splitContainer1.Panel2.Controls.Add(vizcore3d);
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.LicenseResults result = 
            vizcore3d.License.LicenseServer("127.0.0.1", 8901);

            if(result != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            {
                MessageBox.Show("VIZCore3D License Error: {0}" + result.ToString());
                return;
            }

            vizcore3d.View.SelectionMode = VIZCore3D.NET.Data.Object3DSelectionOptions.HIGHLIGHT_COLOR_AND_SILHOUETTEEDGE;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            vizcore3d.Model.OpenFileDialog();
        }

        private void txtBlock_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtBlock.Text) == true) return;

                List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(txtBlock.Text, true);

                vizcore3d.Object3D.Select(nodes, true);
            }
        }

        private void btnAnimatePath_Click(object sender, EventArgs e)
        {
            ModelBoundBox = vizcore3d.Model.BoundBox;

            List<VIZCore3D.NET.Data.Node> nodes = vizcore3d.Object3D.Find.QuickSearch(txtBlock.Text, true);
            VIZCore3D.NET.Data.BoundBox3D blockBoundBox = vizcore3d.Object3D.GetBoundBox(nodes);

            Paths = new List<Data.Vector3D>();
            for (int i = 0; i < 5; i++)
            {
                Paths.Add(new Data.Vector3D(0.0f, 0.0f, 1000.0f));
            }

            for (int i = 0; i < 25; i++)
            {
                Paths.Add(new Data.Vector3D(-1000.0f, 0.0f, 0.0f));
            }

            float lengthZ = blockBoundBox.MinZ + 5000.0f;
            int countZ = (int)(lengthZ / 1000.0f);

            for (int i = 0; i < countZ; i++)
            {
                Paths.Add(new Data.Vector3D(0.0f, 0.0f, -1000.0f));
            }

            VIZCore3D.NET.Data.Vertex3D start = blockBoundBox.GetCenter();
            vizcore3d.ShapeDrawing.AddVertex(new List<VIZCore3D.NET.Data.Vertex3D>() { start.Clone() }, 0, Color.Black, 5.0f, 10.0f, true);

            for (int i = 0; i < Paths.Count; i++)
            {
                start += Paths[i];
                vizcore3d.ShapeDrawing.AddVertex(new List<VIZCore3D.NET.Data.Vertex3D>() { start.Clone() }, 0, Color.Black, 5.0f, 10.0f, true);
            }

            VIZCore3D.NET.Data.Matrix3D matrix = new VIZCore3D.NET.Data.Matrix3D();
            matrix.Identity();
            VIZCore3D.NET.Data.Vector3D move = new Data.Vector3D(0, 0, 0);
            for (int i = 0; i < Paths.Count; i++)
            {
                //matrix.Identity();
                //matrix.SetTranslate(Paths[i]);

                move += Paths[i];

                vizcore3d.BeginUpdate();
                //vizcore3d.Object3D.Transform.Transform(nodes, matrix, false);
                vizcore3d.Object3D.Transform.Move(nodes, move, true);
                vizcore3d.EndUpdate();
            }
        }
    }
}
