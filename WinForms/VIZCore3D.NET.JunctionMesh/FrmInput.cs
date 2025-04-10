using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.JuctionMesh
{
    public partial class FrmInput : Form
    {
        public int IndexA
        {
            get
            {
                return Convert.ToInt32(txtIndexA.Text);
            }
        }

        public int IndexB
        {
            get
            {
                return Convert.ToInt32(txtIndexB.Text);
            }
        }

        public FrmInput()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIndexA.Text) == true) return;
            if (String.IsNullOrEmpty(txtIndexB.Text) == true) return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
