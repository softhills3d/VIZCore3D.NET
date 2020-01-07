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
        /// <summary>
        /// Key 항목 선택
        /// </summary>
        public event UDAKeyNodeClickedEventHandler OnUDAKeyNodeClickedEvent;
        /// <summary>
        /// Key/Value 항목 선택
        /// </summary>
        public event UDAValueNodeClickedEventHandler OnUDAValueNodeClickedEvent;

        /// <summary>
        /// 사용자 정의 속성 Key 목록
        /// </summary>
        public List<string> Keys { get; set; }

        public UDATreeDialog(List<string> keys)
        {
            InitializeComponent();

            Keys = keys;

            // 키 목록 생성
            tvAttribute.BeginUpdate();

            foreach (string key in keys)
            {
                TreeNode tnKey = tvAttribute.Nodes.Add(key);
                tnKey.Tag = key;
            }

            tvAttribute.EndUpdate();
        }

        private void tvAttribute_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 노드 선택
            if (e.Node == null) return;
            if (e.Node.Tag == null) return;

            string tag = (string)e.Node.Tag;

            if (String.IsNullOrEmpty(tag) == true) return;

            // 선택된 노드가 Key 노드인 경우
            if(tag.Contains("@") == false)
            {
                if (e.Node.Nodes.Count != 0) return;

                if(OnUDAKeyNodeClickedEvent != null)
                {
                    // Key 노드에 해당하는 Value 노드 목록 요청 및 반환
                    List<string> vals = OnUDAKeyNodeClickedEvent(this, new UDAKeyNodeClickedEventArgs(tag));

                    // Value 노드 트리 구조 생성
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
            // 선택된 노드가 Value 노드인 경우
            else
            {
                string[] item = tag.Split(new char[] { '@' });

                if (item == null || item.Length != 2) return;

                if(OnUDAValueNodeClickedEvent != null)
                {
                    // Value 노드에 해당하는 개체 목록 요청 및 반환
                    List<VIZCore3D.NET.Data.Node> nodes = OnUDAValueNodeClickedEvent(this, new UDAValueNodeClickedEventArgs(item[0], item[1]));

                    // 목록에 표시
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
