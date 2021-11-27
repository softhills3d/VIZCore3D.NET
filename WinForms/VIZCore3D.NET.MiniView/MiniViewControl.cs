using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.MiniView
{
    public partial class MiniViewControl : UserControl
    {
        public Control MiniViewContainer
        {
            get
            {
                return gbMiniView;
            }
        }

        public MiniViewControl()
        {
            InitializeComponent();
        }
    }
}
