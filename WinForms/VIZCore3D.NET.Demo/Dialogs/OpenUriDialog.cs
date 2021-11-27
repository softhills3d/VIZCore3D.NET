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
    public partial class OpenUriDialog : Form
    {
        public string ModelName
        {
            get
            {
                return txtModelName.Text;
            }
        }

        public string ModelUri
        {
            get
            {
                return txtUri.Text;
            }
        }

        public OpenUriDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUri.Text) == true) return;
            if (String.IsNullOrEmpty(txtModelName.Text) == true) return;

            string model = System.IO.Path.GetFileNameWithoutExtension(txtUri.Text).ToUpper();
            string imodel = txtModelName.Text.ToUpper();
            if(imodel.Equals(model) == false)
            {
                DialogResult dr = MessageBox.Show("URI의 모델 이름이 다릅니다. 변경하시겠습니까?", "VIZCore3D.NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    txtModelName.Text = model;
            }

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
