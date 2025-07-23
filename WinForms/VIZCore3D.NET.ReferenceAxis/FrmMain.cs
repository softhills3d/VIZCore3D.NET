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

        public FrmMain()
        {
            InitializeComponent();

            VIZCore3D.NET.ModuleInitializer.Run();

            vizcore3d = new VIZCore3D.NET.VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(vizcore3d);

            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            VIZCore3D.NET.Data.LicenseResults result
                = vizcore3d.License.LicenseServer("127.0.0.1", 8901);

            if(result != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            {
                return;
            }
        }
    }
}
