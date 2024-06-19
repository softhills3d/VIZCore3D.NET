using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.SectionBoxSize
{
    public partial class FrmMain : Form
    {
        public VIZCore3D.NET.VIZCore3DControl vizcore3d { get; set; }

        public VIZCore3D.NET.Data.Section Section { get; set; }

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

            if (result != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            { 
                MessageBox.Show(string.Format("License Error Code: {0}", result), "License", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenModel_Click(object sender, EventArgs e)
        {
            vizcore3d.Model.OpenFileDialog();
        }

        private void btnOpenFrame_Click(object sender, EventArgs e)
        {
            vizcore3d.Frame.OpenFileDialog();
        }

        private void btnAddSectionBox_Click(object sender, EventArgs e)
        {
            Section = vizcore3d.Section.AddBox(false);

            VIZCore3D.NET.Data.BoundBox3D box = Section.BoundBox;

            cbMinX.SelectedIndexChanged -= new System.EventHandler(cbMinX_SelectedIndexChanged);
            cbMinY.SelectedIndexChanged -= new System.EventHandler(cbMinY_SelectedIndexChanged);
            cbMinZ.SelectedIndexChanged -= new System.EventHandler(cbMinZ_SelectedIndexChanged);

            cbMaxX.SelectedIndexChanged -= new System.EventHandler(cbMaxX_SelectedIndexChanged);
            cbMaxY.SelectedIndexChanged -= new System.EventHandler(cbMaxY_SelectedIndexChanged);
            cbMaxZ.SelectedIndexChanged -= new System.EventHandler(cbMaxZ_SelectedIndexChanged);

            tbMinX.Scroll -= new System.EventHandler(tbMinX_Scroll);
            tbMinY.Scroll -= new System.EventHandler(tbMinY_Scroll);
            tbMinZ.Scroll -= new System.EventHandler(tbMinZ_Scroll);

            tbMaxX.Scroll -= new System.EventHandler(tbMaxX_Scroll);
            tbMaxY.Scroll -= new System.EventHandler(tbMaxY_Scroll);
            tbMaxZ.Scroll -= new System.EventHandler(tbMaxZ_Scroll);


            tbMinX.Minimum = tbMaxX.Minimum = Convert.ToInt32(box.MinX);
            tbMinX.Maximum = tbMaxX.Maximum = Convert.ToInt32(box.MaxX);
            tbMinX.Value = tbMinX.Minimum;
            tbMaxX.Value = tbMaxX.Maximum;

            tbMinY.Minimum = tbMaxY.Minimum = Convert.ToInt32(box.MinY);
            tbMinY.Maximum = tbMaxY.Maximum = Convert.ToInt32(box.MaxY);
            tbMinY.Value = tbMinY.Minimum;
            tbMaxY.Value = tbMaxY.Maximum;

            tbMinZ.Minimum = tbMaxZ.Minimum = Convert.ToInt32(box.MinZ);
            tbMinZ.Maximum = tbMaxZ.Maximum = Convert.ToInt32(box.MaxZ);
            tbMinZ.Value = tbMinZ.Minimum;
            tbMaxZ.Value = tbMaxZ.Maximum;

            if(vizcore3d.Frame.HasFrame == true)
            {
                List<VIZCore3D.NET.Data.FrameItem> xItems = vizcore3d.Frame.GetGridItems(VIZCore3D.NET.Data.Axis.X);

                for (int i = 0; i < xItems.Count; i++)
                {
                    int position = GetFramePosition(Data.Axis.X, xItems[i].LabelStr);
                    if (position < (box.MinX - 1000.0f)) continue;
                    if ((box.MaxX + 1000.0f) < position) continue;

                    cbMinX.Items.Add(xItems[i].LabelStr);
                    cbMaxX.Items.Add(xItems[i].LabelStr);
                }

                cbMinX.Text = cbMinX.Items[0].ToString();
                cbMaxX.Text = cbMaxX.Items[cbMaxX.Items.Count - 1].ToString();

                List<VIZCore3D.NET.Data.FrameItem> yItems = vizcore3d.Frame.GetGridItems(VIZCore3D.NET.Data.Axis.Y);

                for (int i = 0; i < yItems.Count; i++)
                {
                    int position = GetFramePosition(Data.Axis.Y, yItems[i].LabelStr);
                    if (position < (box.MinY - 1000.0f)) continue;
                    if ((box.MaxY + 1000.0f) < position) continue;

                    cbMinY.Items.Add(yItems[i].LabelStr);
                    cbMaxY.Items.Add(yItems[i].LabelStr);
                }

                cbMinY.Text = cbMinY.Items[0].ToString();
                cbMaxY.Text = cbMaxY.Items[cbMaxY.Items.Count - 1].ToString();

                List<VIZCore3D.NET.Data.FrameItem> zItems = vizcore3d.Frame.GetGridItems(VIZCore3D.NET.Data.Axis.Z);

                for (int i = 0; i < zItems.Count; i++)
                {
                    int position = GetFramePosition(Data.Axis.Z, zItems[i].LabelStr);
                    if (position < (box.MinZ - 1000.0f)) continue;
                    if ((box.MaxZ + 1000.0f) < position) continue;

                    cbMinZ.Items.Add(zItems[i].LabelStr);
                    cbMaxZ.Items.Add(zItems[i].LabelStr);
                }

                cbMinZ.Text = cbMinZ.Items[0].ToString();
                cbMaxZ.Text = cbMaxZ.Items[cbMaxZ.Items.Count - 1].ToString();
            }

            cbMinX.SelectedIndexChanged += new System.EventHandler(cbMinX_SelectedIndexChanged);
            cbMinY.SelectedIndexChanged += new System.EventHandler(cbMinY_SelectedIndexChanged);
            cbMinZ.SelectedIndexChanged += new System.EventHandler(cbMinZ_SelectedIndexChanged);

            cbMaxX.SelectedIndexChanged += new System.EventHandler(cbMaxX_SelectedIndexChanged);
            cbMaxY.SelectedIndexChanged += new System.EventHandler(cbMaxY_SelectedIndexChanged);
            cbMaxZ.SelectedIndexChanged += new System.EventHandler(cbMaxZ_SelectedIndexChanged);

            tbMinX.Scroll += new System.EventHandler(tbMinX_Scroll);
            tbMinY.Scroll += new System.EventHandler(tbMinY_Scroll);
            tbMinZ.Scroll += new System.EventHandler(tbMinZ_Scroll);

            tbMaxX.Scroll += new System.EventHandler(tbMaxX_Scroll);
            tbMaxY.Scroll += new System.EventHandler(tbMaxY_Scroll);
            tbMaxZ.Scroll += new System.EventHandler(tbMaxZ_Scroll);
        }

        private void UpdateSectionBoxSize()
        {
            if (Section == null) return;

            VIZCore3D.NET.Data.BoundBox3D box = new VIZCore3D.NET.Data.BoundBox3D();

            box.MinX = tbMinX.Value;
            box.MaxX = tbMaxX.Value;
            box.MinY = tbMinY.Value;
            box.MaxY = tbMaxY.Value;
            box.MinZ = tbMinZ.Value;
            box.MaxZ = tbMaxZ.Value;

            vizcore3d.Section.SetBoxSize(Section.ID, box);
        }

        private int GetFramePosition(VIZCore3D.NET.Data.Axis axis, string frame)
        {
            VIZCore3D.NET.Data.FramePosition fp = vizcore3d.Frame.GetPosition(axis, frame);
            if (fp.ValidData == false) return 0;
            else return Convert.ToInt32(fp.Position);
        }

        private string GetFrameLabel(VIZCore3D.NET.Data.Axis axis, int position)
        { 
            VIZCore3D.NET.Data.FrameItem fi = vizcore3d.Frame.GetSnap(axis, Convert.ToSingle(position));
            string str = fi.LabelStr;
            if (str == "0") return String.Empty;
            else return str;
        }

        private void tbMinX_Scroll(object sender, EventArgs e)
        {
            cbMinX.SelectedIndexChanged -= new System.EventHandler(cbMinX_SelectedIndexChanged);
            cbMinX.Text = GetFrameLabel(VIZCore3D.NET.Data.Axis.X, tbMinX.Value);
            cbMinX.SelectedIndexChanged += new System.EventHandler(cbMinX_SelectedIndexChanged);

            UpdateSectionBoxSize();
        }

        private void tbMaxX_Scroll(object sender, EventArgs e)
        {
            cbMaxX.SelectedIndexChanged -= new System.EventHandler(cbMaxX_SelectedIndexChanged);
            cbMaxX.Text = GetFrameLabel(VIZCore3D.NET.Data.Axis.X, tbMaxX.Value);
            cbMaxX.SelectedIndexChanged += new System.EventHandler(cbMaxX_SelectedIndexChanged);

            UpdateSectionBoxSize();
        }

        private void tbMinY_Scroll(object sender, EventArgs e)
        {
            cbMinY.SelectedIndexChanged -= new System.EventHandler(cbMinY_SelectedIndexChanged);
            cbMinY.Text = GetFrameLabel(VIZCore3D.NET.Data.Axis.Y, tbMinY.Value);
            cbMinY.SelectedIndexChanged += new System.EventHandler(cbMinY_SelectedIndexChanged);

            UpdateSectionBoxSize();
        }

        private void tbMaxY_Scroll(object sender, EventArgs e)
        {
            cbMaxY.SelectedIndexChanged -= new System.EventHandler(cbMaxY_SelectedIndexChanged);
            cbMaxY.Text = GetFrameLabel(VIZCore3D.NET.Data.Axis.Y, tbMaxY.Value);
            cbMaxY.SelectedIndexChanged += new System.EventHandler(cbMaxY_SelectedIndexChanged);

            UpdateSectionBoxSize();
        }

        private void tbMinZ_Scroll(object sender, EventArgs e)
        {
            cbMinZ.SelectedIndexChanged -= new System.EventHandler(cbMinZ_SelectedIndexChanged);
            cbMinZ.Text = GetFrameLabel(VIZCore3D.NET.Data.Axis.Z, tbMinZ.Value);
            cbMinZ.SelectedIndexChanged += new System.EventHandler(cbMinZ_SelectedIndexChanged);

            UpdateSectionBoxSize();
        }

        private void tbMaxZ_Scroll(object sender, EventArgs e)
        {
            cbMaxZ.SelectedIndexChanged -= new System.EventHandler(cbMaxZ_SelectedIndexChanged);
            cbMaxZ.Text = GetFrameLabel(VIZCore3D.NET.Data.Axis.Z, tbMaxZ.Value);
            cbMaxZ.SelectedIndexChanged += new System.EventHandler(cbMaxZ_SelectedIndexChanged);

            UpdateSectionBoxSize();
        }

        private void cbMinX_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMinX.Scroll -= new System.EventHandler(tbMinX_Scroll);
            tbMinX.Value = GetFramePosition(VIZCore3D.NET.Data.Axis.X, cbMinX.Text);
            tbMinX.Scroll += new System.EventHandler(tbMinX_Scroll);

            UpdateSectionBoxSize();
        }

        private void cbMaxX_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMaxX.Scroll -= new System.EventHandler(tbMaxX_Scroll);
            tbMaxX.Value = GetFramePosition(VIZCore3D.NET.Data.Axis.X, cbMaxX.Text);
            tbMaxX.Scroll += new System.EventHandler(tbMaxX_Scroll);

            UpdateSectionBoxSize();
        }

        private void cbMinY_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMinY.Scroll -= new System.EventHandler(tbMinY_Scroll);
            tbMinY.Value = GetFramePosition(VIZCore3D.NET.Data.Axis.Y, cbMinY.Text);
            tbMinY.Scroll += new System.EventHandler(tbMinY_Scroll);

            UpdateSectionBoxSize();
        }

        private void cbMaxY_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMaxY.Scroll -= new System.EventHandler(tbMaxY_Scroll);
            tbMaxY.Value = GetFramePosition(VIZCore3D.NET.Data.Axis.Y, cbMaxY.Text);
            tbMaxY.Scroll += new System.EventHandler(tbMaxY_Scroll);

            UpdateSectionBoxSize();
        }

        private void cbMinZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMinZ.Scroll -= new System.EventHandler(tbMinZ_Scroll);
            tbMinZ.Value = GetFramePosition(VIZCore3D.NET.Data.Axis.Z, cbMinZ.Text);
            tbMinZ.Scroll += new System.EventHandler(tbMinZ_Scroll);

            UpdateSectionBoxSize();
        }

        private void cbMaxZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMaxZ.Scroll -= new System.EventHandler(tbMaxZ_Scroll);
            tbMaxZ.Value = GetFramePosition(VIZCore3D.NET.Data.Axis.Z, cbMaxZ.Text);
            tbMaxZ.Scroll += new System.EventHandler(tbMaxZ_Scroll);

            UpdateSectionBoxSize();
        }
    }
}
