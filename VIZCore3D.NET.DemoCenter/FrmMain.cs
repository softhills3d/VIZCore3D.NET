using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.DemoCenter
{
    public partial class FrmMain : Form
    {
        public Dictionary<string, DemoItem> Demos { get; set; }
        public FrmMain()
        {
            InitializeComponent();

            BindData();
        }

        private void BindData()
        {
            Demos = new Dictionary<string, DemoItem>();


            tvHierarchy.ExpandAll();
            tvHierarchy.AfterSelect += TvHierarchy_AfterSelect;
        }

        private void TvHierarchy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            if (e.Node.Tag == null) return;

            string tag = (string)e.Node.Tag;
            if (String.IsNullOrEmpty(tag) == true) return;

            if (Demos.ContainsKey(tag) == false) return;

            ShowDemoInformation(Demos[tag]);
        }

        private void ShowDemoInformation(DemoItem info)
        {

        }
    }
}
