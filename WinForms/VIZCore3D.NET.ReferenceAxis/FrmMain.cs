using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.ReferenceAxis
{
    public partial class FrmMain : Form
    {
        private VIZCore3D.NET.VIZCore3DControl vizcore3d { get; set; }

        private int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
                txtID.Text = _ID.ToString();
            }
        }

        public FrmMain()
        {
            InitializeComponent();

            VIZCore3D.NET.ModuleInitializer.Run();

            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(vizcore3d);

            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;

            ID = -1;
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.LicenseResults result
                = vizcore3d.License.LicenseServer("127.0.0.1", 8901);

            if(result != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            {
                MessageBox.Show(string.Format("License Error: {0}", result));
                return;
            }
        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            int id =vizcore3d.View.ReferenceAxis.Create(
                new VIZCore3D.NET.Data.Vector3D(1.0f, 0.0f, 0.0f)         /* X-Axis */
                , new VIZCore3D.NET.Data.Vector3D(0.0f, 1.0f, 0.0f)       /* Y-Axis */
                , new VIZCore3D.NET.Data.Vector3D(0.0f, 0.0f, 0.0f)       /* Position */
                , "절대축"                                                /* Title */
                );

            ID = id;
        }

        private void btnCreate2_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            vizcore3d.View.ReferenceAxis.Reset();

            // =======================================================
            // Matrix 적용 예제
            // =======================================================
            VIZCore3D.NET.Data.Matrix3D matrix3D = new VIZCore3D.NET.Data.Matrix3D();
            matrix3D.Identity();
            matrix3D.Matrix = new float[16]
            {
                1.0f, 0.0f, 0.0f, 0.0f,
                0.0f, 0.0f, 1.0f, 0.0f,
                0.0f, -1.0f, 0.0f, 0.0f,
                0.0f, 0.0f, 0.0f, 1.0f
            };

            VIZCore3D.NET.Data.Vector3D xAxis = new VIZCore3D.NET.Data.Vector3D(1.0f, 0.0f, 0.0f);
            VIZCore3D.NET.Data.Vector3D yAxis = new VIZCore3D.NET.Data.Vector3D(0.0f, 1.0f, 0.0f);

            xAxis = matrix3D * xAxis;
            yAxis = matrix3D * yAxis;

            VIZCore3D.NET.Data.Vector3D pos = vizcore3d.Model.BoundBox.GetCenter().ToVector3D();

            int id = vizcore3d.View.ReferenceAxis.Create(
                xAxis       /* X-Axis */
                , yAxis     /* Y-Axis */
                , pos       /* Position */
                , "참조축"  /* Title */
                );


            // Default
            //int id = vizcore3d.View.ReferenceAxis.Create(
            //    new VIZCore3D.NET.Data.Vector3D(1.0f, 0.0f, 0.0f)         /* X-Axis */
            //    , new VIZCore3D.NET.Data.Vector3D(0.0f, 1.0f, 0.0f)       /* Y-Axis */
            //    , vizcore3d.Model.BoundBox.GetCenter().ToVector3D()       /* Position */
            //    , "참조축"                                                /* Title */
            //    );

            ID = id;

            vizcore3d.View.ReferenceAxis.Activate(ID, true);

            vizcore3d.View.ResetView();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (ID == -1) return;

            vizcore3d.View.ReferenceAxis.Select(ID);
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (ID == -1) return;

            vizcore3d.View.ReferenceAxis.Activate(ID, true);
        }

        private void btn3Point_Click(object sender, EventArgs e)
        {
            vizcore3d.View.ReferenceAxis.CreateBy3Point();
        }

        private void btn2Point1Edge_Click(object sender, EventArgs e)
        {
            vizcore3d.View.ReferenceAxis.CreateBy2Point1Edge();
        }

        private void btnSurfaceNormal1Edge_Click(object sender, EventArgs e)
        {
            vizcore3d.View.ReferenceAxis.CreateBySurfaceNormal1Edge();
        }

        private void btn1PointAxis_Click(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.Vector3D xAxis = new VIZCore3D.NET.Data.Vector3D(1.0f, 0.0f, 0.0f);
            VIZCore3D.NET.Data.Vector3D yAxis = new VIZCore3D.NET.Data.Vector3D(0.0f, 1.0f, 0.0f);

            vizcore3d.View.ReferenceAxis.CreateBy1PointAxis(xAxis, yAxis);
        }
    }
}
