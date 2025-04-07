using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.NodeThumbnail
{
    public partial class FrmMain : Form
    {
        private VIZCore3D.NET.VIZCore3DControl vizcore3d {  get; set; }

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

        private void ShowThumbnail(int depth)
        {
            Dictionary<int, System.Drawing.Image> result = 
                vizcore3d.View.GetNodeThumbnail(depth, Data.CameraDirection.ISO_PLUS, 300, 300);

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(90, 90);

            lvFiles.BeginUpdate();
            lvFiles.Items.Clear();

            lvFiles.LargeImageList = imgList;
            lvFiles.SmallImageList = imgList;
            lvFiles.StateImageList = imgList;

            foreach (KeyValuePair<int, System.Drawing.Image> item in result)
            {
                System.Drawing.Image img = item.Value;
                if (img != null)
                    imgList.Images.Add(item.Key.ToString(), img);

                string name = vizcore3d.Object3D.FromIndex(item.Key).NodeName;

                ListViewItem lvi = new ListViewItem(new string[] { "", name });
                if (img != null)
                    lvi.ImageKey = item.Key.ToString();

                lvFiles.Items.Add(lvi);
            }

            lvFiles.EndUpdate();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string depthStr = txtDepth.Text;
            if (String.IsNullOrEmpty(depthStr) == true) return;

            int depth = Convert.ToInt32(depthStr);

            ShowThumbnail(depth);
        }
    }
}
