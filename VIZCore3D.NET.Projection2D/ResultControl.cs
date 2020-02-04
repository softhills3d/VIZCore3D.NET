using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Add Reference
// PresentationCore
// PresentationFramework
// System.Xaml
// WindowsBase
// WindowsFormsIntegration

using System.Windows;
using System.Windows.Forms.Integration;
using System.Windows.Media;

using System.ServiceModel;

namespace VIZCore3D.NET.Projection2D
{
    public partial class ResultControl : UserControl
    {
        private ElementHost ctrlHost = null;
        private VIZCore3D.NET.Projection2D.DrawControl.PathGeometryControl P2D_Viewer = null;

        public ResultControl()
        {
            InitializeComponent();
        }

        public void SetData(VIZCore3D.NET.Data.Projection2D projection)
        {
            txtArea.Text = projection.Area.ToString();
            txtVertexCount.Text = projection.VertexCount.ToString();
            txtVertexBoundBox.Text = projection.BoundBoxVertex.ToString();
            txtNodeBoundBox.Text = projection.BoundBoxNode.ToStringMax();
            txtMatrix.Text = projection.Matrix;

            txtPoints.Text = projection.Points;
            txtVertex.Text = projection.Vertex;
            txtPathGeometry.Text = projection.PathGeometryString;

            if (ctrlHost == null)
            {
                ctrlHost = new ElementHost();
                ctrlHost.Dock = DockStyle.Fill;
                tabPage5.Controls.Add(ctrlHost);
                P2D_Viewer = new DrawControl.PathGeometryControl();
                P2D_Viewer.InitializeComponent();
                ctrlHost.Child = P2D_Viewer;
            }

            P2D_Viewer.DrawPathGeometry(projection.PathGeometryString);
        }
    }
}
