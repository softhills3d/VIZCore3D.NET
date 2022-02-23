using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.TOB
{
    public partial class FrmReportDialog : Form
    {
        public FrmReportDialog()
        {
            InitializeComponent();
        }

        public FrmReportDialog(List<CollisionItem> items)
        {
            InitializeComponent();

            lvItems.BeginUpdate();
            foreach (CollisionItem item in items)
            {
                ListViewItem lvi = new ListViewItem(
                    new string[] {
                        item.LugName
                        , item.RollerName
                        , item.CollisionNodeName
                        , item.Distance.ToString()
                        , item.NodeIndex.ToString()
                        , item.Angle1
                        , item.Angle2
                    }
                    );
                lvi.Tag = item;
                lvItems.Items.Add(lvi);
            }
            lvItems.EndUpdate();
        }
    }
}