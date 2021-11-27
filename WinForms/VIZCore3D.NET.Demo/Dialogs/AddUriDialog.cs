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
    public partial class AddUriDialog : Form
    {
        public AddUriDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public List<VIZCore3D.NET.Data.StreamData> GetStreamDataList()
        {
            List<VIZCore3D.NET.Data.StreamData> items = new List<Data.StreamData>();

            if(String.IsNullOrEmpty(txtName1.Text) == false && String.IsNullOrEmpty(txtUri1.Text) == false)
            {
                VIZCore3D.NET.Data.StreamData stream = new Data.StreamData(txtUri1.Text, txtName1.Text);
                items.Add(stream);
            }

            if (String.IsNullOrEmpty(txtName2.Text) == false && String.IsNullOrEmpty(txtUri2.Text) == false)
            {
                VIZCore3D.NET.Data.StreamData stream = new Data.StreamData(txtUri2.Text, txtName2.Text);
                items.Add(stream);
            }

            if (String.IsNullOrEmpty(txtName3.Text) == false && String.IsNullOrEmpty(txtUri3.Text) == false)
            {
                VIZCore3D.NET.Data.StreamData stream = new Data.StreamData(txtUri3.Text, txtName3.Text);
                items.Add(stream);
            }

            if (String.IsNullOrEmpty(txtName4.Text) == false && String.IsNullOrEmpty(txtUri4.Text) == false)
            {
                VIZCore3D.NET.Data.StreamData stream = new Data.StreamData(txtUri4.Text, txtName4.Text);
                items.Add(stream);
            }

            return items;
        }
    }
}
