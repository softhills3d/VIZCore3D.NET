using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.MultiControl
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExecute1_Click(object sender, EventArgs e)
        {
            VIZCore3D.NET.ModuleInitializer.Run();

            VIZCore3D.NET.VIZCore3DControl vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            gbContainer1.Controls.Add(vizcore3d);
        }

        private void btnExecute2_Click(object sender, EventArgs e)
        {
            VIZCore3D.NET.VIZCore3DControl vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            gbContainer2.Controls.Add(vizcore3d);
        }

        private void btnExecute3_Click(object sender, EventArgs e)
        {
            VIZCore3D.NET.VIZCore3DControl vizcore3d1 = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d1.Dock = DockStyle.Fill;
            gbContainer3.Panel1.Controls.Add(vizcore3d1);

            VIZCore3D.NET.VIZCore3DControl vizcore3d2 = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d2.Dock = DockStyle.Fill;
            gbContainer3.Panel2.Controls.Add(vizcore3d2);
        }
    }
}
