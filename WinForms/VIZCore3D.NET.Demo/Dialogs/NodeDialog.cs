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
    public partial class NodeDialog : Form
    {
        public NodeDialog()
        {
            InitializeComponent();
        }

        public NodeDialog(List<VIZCore3D.NET.Data.Node> items)
        {
            InitializeComponent();

            SetDataSource(items);
        }

        public void SetDataSource(List<VIZCore3D.NET.Data.Node> items)
        {
            dataGridNode.DataSource = items;
        }

        private void NodeDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
