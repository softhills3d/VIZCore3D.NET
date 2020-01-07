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
    public partial class UDADialog : Form
    {
        public UDADialog()
        {
            InitializeComponent();
        }

        public UDADialog(Dictionary<string, string> uda)
        {
            InitializeComponent();


            lvList.BeginUpdate();
            foreach (KeyValuePair<string, string> item in uda)
            {
                ListViewItem lvi = new ListViewItem(new string[] { item.Key, item.Value });
                lvList.Items.Add(lvi);
            }
            lvList.EndUpdate();
        }
    }
}
