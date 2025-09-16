using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.SymbolObjects
{
    public partial class FrmMain : Form
    {
        private VIZCore3D.NET.VIZCore3DControl vizcore3d { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            VIZCore3D.NET.ModuleInitializer.Run();

            vizcore3d = new VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(vizcore3d);
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            vizcore3d.License.LicenseServer("127.0.0.1", 8901);
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            bool result = vizcore3d.Review.Symbol.GenerateSymbalResource(dlg.SelectedPath);

            if (result == true)
            {
                MessageBox.Show("심볼 리소스 생성이 완료되었습니다.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("심볼 리소스 생성에 실패하였습니다.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            if (vizcore3d.Model.IsOpen() == false) return;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "VIZCore3D Symbol Resource (*.xml)|*.xml";
            if(dlg.ShowDialog() != DialogResult.OK) return;

            vizcore3d.Review.Symbol.AddResource(dlg.FileName);
        }

        private void btnShowSymbol_Click(object sender, EventArgs e)
        {
            vizcore3d.Review.Symbol.ShowSymbolDialog();
        }
    }
}
