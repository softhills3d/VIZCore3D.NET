using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.MetadataDemo
{
    public partial class AddMetadataDialog : Form
    {
        public string MetadataName
        {
            get
            {
                return txtName.Text;
            }
        }

        public string MetadataFilePath
        {
            get
            {
                return txtPath.Text;
            }
        }

        public AddMetadataDialog()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            txtName.Text = System.IO.Path.GetFileName(dlg.FileName);
            txtPath.Text = dlg.FileName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) == true) return;

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
