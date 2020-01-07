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
    public partial class ViewImageDialog : Form
    {
        public ViewImageDialog(System.Drawing.Image img)
        {
            InitializeComponent();

            pictureBox1.Image = img;
        }
    }
}
