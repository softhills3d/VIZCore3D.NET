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
    public partial class GeometryPropertyDialog : Form
    {
        public GeometryPropertyDialog()
        {
            InitializeComponent();
        }

        public GeometryPropertyDialog(VIZCore3D.NET.Data.Object3DProperty prop)
        {
            InitializeComponent();

            propertyGrid.SelectedObject = prop;
        }

        public GeometryPropertyDialog(VIZCore3D.NET.Data.Objects3DProperty prop)
        {
            InitializeComponent();

            propertyGrid.SelectedObject = prop;
        }
    }
}
