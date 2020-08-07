using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.MeshEdit
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ShowModule(UserControl ctrl)
        {
            if(splitContainer1.Panel2.Controls.Count != 0)
            {
                UserControl prev = (UserControl)splitContainer1.Panel2.Controls[0];
                prev.Dispose();
                prev = null;
            }

            splitContainer1.Panel2.Controls.Clear();
            ctrl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(ctrl);
        }

        private void btnMergeBody_Click(object sender, EventArgs e)
        {
            ShowModule(new Modules.MergeBodyControl());
        }

        private void btnMoveVertex_Click(object sender, EventArgs e)
        {
            ShowModule(new Modules.MoveVertexControl());
        }
    }
}
