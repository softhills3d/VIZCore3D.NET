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
    public partial class StructureDialog : Form
    {
        public StructureDialog(List<VIZCore3D.NET.Data.Node> items)
        {
            InitializeComponent();

            if (items == null || items.Count == 0) return;

            TreeNode tnNode = new TreeNode();

            for (int i = 0; i < items.Count; i++)
            {
                if(i == 0)
                {
                    tnNode = tvStructure.Nodes.Add(items[i].NodeName);
                }
                else
                {
                    tnNode = tnNode.Nodes.Add(items[i].NodeName);
                }
            }

            tvStructure.ExpandAll();
        }
    }
}
