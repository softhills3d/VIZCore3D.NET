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
    public partial class UDATreeDialog : Form
    {
        public event UDAKeyNodeClickedEventHandler OnUDAKeyNodeClickedEvent;
        public event UDAValueNodeClickedEventHandler OnUDAValueNodeClickedEvent;

        public List<string> Keys { get; set; }

        public UDATreeDialog(List<string> keys)
        {
            InitializeComponent();

            Keys = keys;

            tvAttribute.BeginUpdate();

            foreach (string key in keys)
            {
                TreeNode tnKey = tvAttribute.Nodes.Add(key);
                tnKey.Tag = key;

                //if (vals.ContainsKey(key) == false) continue;
                //List<string> valList = vals[key];

                //foreach (string val in valList)
                //{
                //    TreeNode tnVal = tnKey.Nodes.Add(val);
                //    tnVal.Tag = string.Format("{0}@{1}", key, val);
                //}
            }

            tvAttribute.EndUpdate();
        }

        private void tvAttribute_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            if (e.Node.Tag == null) return;

            string tag = (string)e.Node.Tag;

            if (String.IsNullOrEmpty(tag) == true) return;

            // Select Key Node
            if(tag.Contains("@") == false)
            {
                if (e.Node.Nodes.Count != 0) return;

                if(OnUDAKeyNodeClickedEvent != null)
                {
                    List<string> vals = OnUDAKeyNodeClickedEvent(this, new UDAKeyNodeClickedEventArgs(tag));

                    tvAttribute.BeginUpdate();
                    foreach (string item in vals)
                    {
                        TreeNode tnVal = e.Node.Nodes.Add(item);
                        tnVal.Tag = string.Format("{0}@{1}", tag, item);
                    }
                    e.Node.Expand();
                    tvAttribute.EndUpdate();
                }
            }
            else
            {
                string[] item = tag.Split(new char[] { '@' });

                if (item == null || item.Length != 2) return;

                if(OnUDAValueNodeClickedEvent != null)
                {
                    List<VIZCore3D.NET.Data.Node> nodes = OnUDAValueNodeClickedEvent(this, new UDAValueNodeClickedEventArgs(item[0], item[1]));

                    if (nodes == null) return;

                    dataGridNode.DataSource = nodes;
                }
            }
        }
    }


    public delegate List<string> UDAKeyNodeClickedEventHandler(object sender, UDAKeyNodeClickedEventArgs e);

    public class UDAKeyNodeClickedEventArgs : EventArgs
    {
        public string Key { get; set; }

        public UDAKeyNodeClickedEventArgs(string key)
        {
            Key = key;
        }
    }

    public delegate List<Data.Node> UDAValueNodeClickedEventHandler(object sender, UDAValueNodeClickedEventArgs e);

    public class UDAValueNodeClickedEventArgs : EventArgs
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public UDAValueNodeClickedEventArgs(string key, string val)
        {
            Key = key;
            Value = val;
        }
    }
}
