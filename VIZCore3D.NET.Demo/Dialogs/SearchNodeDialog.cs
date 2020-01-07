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
    /// <summary>
    /// 검색 다이얼로그
    /// </summary>
    internal partial class SearchNodeDialog : Form
    {
        public event QuickSearchEventHandler OnQuickSearchEvent;
        public event QuickSearchViewEventHandler OnQuickSearchViewEvent;
        public event QuickSearchClosedEventHandler OnQuickSearchClosedEvent;

        /// <summary>
        /// 생성자
        /// </summary>
        public SearchNodeDialog()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (OnQuickSearchEvent == null) return;

            this.Cursor = Cursors.WaitCursor;

            QuickSearchEventArgs args = new QuickSearchEventArgs();
            args.Keyword = txtKeyword.Text.Split(new char[] { ';' }).ToList();
            args.JoinCondition = ckCondition.Checked;
            args.FullMatch = ckFullMatch.Checked;
            args.AssemblyOnly = ckAssemblyOnly.Checked;
            args.SelectedOnly = ckSelectedOnly.Checked;
            args.VisibleOnly = ckVisibleOnly.Checked;

            List<Data.Node> nodes = OnQuickSearchEvent(this, args);

            lvResult.BeginUpdate();
            lvResult.Items.Clear();
            foreach (Data.Node item in nodes)
            {
                ListViewItem lvi = new ListViewItem(new string[] { item.NodeName, item.GetParentName(), item.NodeType == Data.NodeTypes.NODE ? "ASS'Y" : "PART" });
                lvi.Tag = item;
                lvResult.Items.Add(lvi);
            }
            lvResult.EndUpdate();

            this.Cursor = Cursors.Default;
        }

        private void txtKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }

        private void lvResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems.Count == 0) return;

            ListViewItem lvi = lvResult.SelectedItems[0];
            if (lvi == null) return;
            if (lvi.Tag == null) return;

            Data.Node node = (Data.Node)lvi.Tag;
            if (node == null) return;

            if (OnQuickSearchViewEvent == null) return;

            QuickSearchViewEventArgs args = new QuickSearchViewEventArgs();
            args.ResultNode = node;
            args.FlyToObject = ckFlyToObject.Checked;
            args.Xray = ckXray.Checked;

            OnQuickSearchViewEvent(this, args);
        }

        private void SearchNodeDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (OnQuickSearchClosedEvent != null)
                OnQuickSearchClosedEvent(this, new EventArgs());
        }
    }


    public delegate List<Data.Node> QuickSearchEventHandler(object sender, QuickSearchEventArgs e);

    public class QuickSearchEventArgs : EventArgs
    {
        public List<string> Keyword { get; set; }
        public bool JoinCondition { get; set; }
        public bool FullMatch { get; set; }
        public bool AssemblyOnly { get; set; }
        public bool SelectedOnly { get; set; }
        public bool VisibleOnly { get; set; }
    }

    public delegate void QuickSearchViewEventHandler(object sender, QuickSearchViewEventArgs e);


    public class QuickSearchViewEventArgs : EventArgs
    {
        public Data.Node ResultNode { get; set; }
        public bool FlyToObject { get; set; }
        public bool Xray { get; set; }
    }

    public delegate void QuickSearchClosedEventHandler(object sender, EventArgs e);
}
