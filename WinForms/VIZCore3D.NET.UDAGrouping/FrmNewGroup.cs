using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.UDAGrouping
{
    public partial class FrmNewGroup : Form
    {
        public string GroupTitle
        {
            get
            {
                return txtTitle.Text;
            }
            set
            {
                txtTitle.Text = value;
            }
        }

        public List<string> GroupItems { get; set; }

        public FrmNewGroup()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;

            if(String.IsNullOrEmpty(title) == true)
            {
                MessageBox.Show("Title is null.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (GroupItems != null && GroupItems.Count != 0)
            {
                bool exist = false;
                foreach (string item in GroupItems)
                {
                    if (item == title)
                    {
                        exist = true;
                        break;
                    }
                }

                if (exist == true)
                {
                    MessageBox.Show("It is an existing item.", "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.Focus();
                btnOK.PerformClick();
            }
        }
    }
}
