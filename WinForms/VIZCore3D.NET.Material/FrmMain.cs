using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VIZCore3D.NET.Material
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

            vizcore3d.Object3D.OnObject3DSelected += Object3D_OnObject3DSelected;
        }

        private void Object3D_OnObject3DSelected(object sender, Event.EventManager.Object3DSelectedEventArgs e)
        {
            if (e.Node.Count == 0)
            {
                txtObjectIndex.Text = String.Empty;
                return;
            }

            txtObjectIndex.Text = e.Node[0].Index.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string app = Application.StartupPath;
            string res = string.Format("{0}\\Resources", app);
            string[] files = System.IO.Directory.GetFiles(res);

            AddImageItem(files);
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "PNG (*.png)|*.png";
            if (dlg.ShowDialog() != DialogResult.OK) return;

            AddImageItem(dlg.FileNames);
        }

        private void AddImageItem(string[] items)
        {
            lvItems.Items.Clear();

            for (int i = 0; i < items.Length; i++)
            {
                try
                {
                    var image = Image.FromFile(items[i]);
                    imgThumb.Images.Add(image);

                    var item = new ListViewItem
                    {
                        Text = System.IO.Path.GetFileNameWithoutExtension(items[i]),
                        ImageIndex = i
                    };

                    lvItems.Items.Add(item);
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string index = txtObjectIndex.Text;
            if (String.IsNullOrEmpty(index) == true) return;

            // Continue....
        }
    }
}
