﻿using System;
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
        private VIZCore3D.NET.Data.Projection2D projection;

        public ResultControl()
        {
            InitializeComponent();
        }

        public void SetData(VIZCore3D.NET.Data.Projection2D projectionData, System.Drawing.Point translation, bool enableCustomMargine, System.Drawing.Point CustomTranslation)
        {
            projection = projectionData;

            txtArea.Text = projection.Area.ToString();
            txtVertexCount.Text = projection.VertexCount.ToString();
            txtVertexBoundBox.Text = projection.BoundBoxVertex.ToString();
            txtNodeBoundBox.Text = projection.BoundBoxNode.ToStringMax();
            txtMatrix.Text = projection.Matrix;

            txtCorrectionFactorX.Text = projection.CorrectionFactor.X.ToString();
            txtCorrectionFactorY.Text = projection.CorrectionFactor.Y.ToString();

            txtPoints.Text = projection.Points;
            txtVertex.Text = projection.Vertex;
            txtPathGeometry.Text = projection.PathGeometryString;

            if (ctrlHost == null)
            {
                ctrlHost = new ElementHost();
                //ctrlHost.Dock = DockStyle.Fill;
                ctrlHost.Size = new System.Drawing.Size(3000, 3000);
                panelPath.Controls.Add(ctrlHost);
                P2D_Viewer = new DrawControl.PathGeometryControl();
                P2D_Viewer.InitializeComponent();
                ctrlHost.Child = P2D_Viewer;
            }
            
            if(projection.EnableCoordinateCorrection == true)
                projection.MovePoints(translation.X, translation.Y, true);

            if(enableCustomMargine == true)
                projection.MovePoints(CustomTranslation.X, CustomTranslation.Y, true);

            int minX = 0;
            int minY = 0;
            int maxX = 0;
            int maxY = 0;

            List<System.Drawing.Point> pointList = projection.GetPointList();
            for (int i = 0; i < pointList.Count; i++)
            {
                System.Drawing.Point current = pointList[i];

                if(i != 0)
                {
                    minX = Math.Min(minX, current.X);
                    minY = Math.Min(minY, current.Y);

                    maxX = Math.Max(maxX, current.X);
                    maxY = Math.Max(maxY, current.Y);
                }
                else
                {
                    minX = current.X;
                    minY = current.Y;

                    maxX = current.X;
                    maxY = current.Y;
                }
            }

            txtMinX.Text = minX.ToString();
            txtMinY.Text = minY.ToString();
            txtMaxX.Text = maxX.ToString();
            txtMaxY.Text = maxY.ToString();

            P2D_Viewer.DrawPathGeometry(projection.PathGeometryString);

            /*
            System.Drawing.Bitmap bitmap = new Bitmap(Convert.ToInt32(maxX), Convert.ToInt32(maxY));
            string[] Points = projection.Points.Split(new char[] { ',' });

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            for (int i = 0; i < Points.Length; i++)
            {
                if (i % 4 != 0) continue;

                int x1 = Convert.ToInt32(Points[i + 0]);
                int y1 = Convert.ToInt32(Points[i + 1]);

                if (i + 3 > Points.Length) continue;

                int x2 = Convert.ToInt32(Points[i + 2]);
                int y2 = Convert.ToInt32(Points[i + 3]);

                path.AddLine(x1, y1, x2, y2);
            }

            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);

            System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Black, 1);
            g.FillPath(System.Drawing.Brushes.Lime, path);
            g.DrawPath(p, path);

            p.Dispose();
            g.Dispose();

            bitmap.Save("C:\\Temp\\Image.bmp");

            bitmap.Dispose();
            */
        }

        private void tbZoom_Scroll(object sender, EventArgs e)
        {
            string path = projection.ZoomOut(tbZoom.Value, false);
            P2D_Viewer.DrawPathGeometry(path);
        }
    }
}
