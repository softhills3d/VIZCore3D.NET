using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.Demo.Dialogs
{
    public partial class Object3dTestDialog : Form
    {
        private VIZCore3D.NET.VIZCore3DControl vizcore3d;

        public Object3dTestDialog()
        {
            InitializeComponent();
        }

        public Object3dTestDialog(VIZCore3D.NET.VIZCore3DControl ctrl)
        {
            InitializeComponent();

            vizcore3d = ctrl;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNodeIndex.Text) == true) return;

            vizcore3d.Object3D.Select(new List<int>() { Convert.ToInt32(txtNodeIndex.Text) }, true);
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNodeIndex.Text) == true) return;

            vizcore3d.Object3D.Select(new List<int>() { Convert.ToInt32(txtNodeIndex.Text) }, false);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNodeIndex.Text) == true) return;

            vizcore3d.Object3D.Show(new List<int>() { Convert.ToInt32(txtNodeIndex.Text) }, true);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNodeIndex.Text) == true) return;

            vizcore3d.Object3D.Show(new List<int>() { Convert.ToInt32(txtNodeIndex.Text) }, false);
        }
    }
}
