using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.ProjectionGrid
{
    public partial class GridPanelControl : UserControl
    {
        private List<System.Drawing.PointF> Points { get; set; }

        public GridPanelControl()
        {
            InitializeComponent();
        }

        public void SetData(List<System.Drawing.PointF> points)
        {
            Points = points;

            Invalidate();
        }

        private void GridPanelControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int width = this.Size.Width;
            int height = this.Size.Height;

            Pen pen = new Pen(Brushes.Black);

            for (int i = 1; i < width; i++)
            {
                e.Graphics.DrawLine(
                    pen
                    , new Point(i, 0)
                    , new Point(i, height)
                    );

                i += 4;
            }

            for (int i = 1; i < height; i++)
            {
                e.Graphics.DrawLine(
                    pen
                    , new Point(0, i)
                    , new Point(width, i)
                    );

                i += 4;
            }

            pen.Dispose();

            if (Points != null && Points.Count != 0)
            {
                Pen p = new Pen(Brushes.Red, 0.1f);
                for (int i = 0; i < Points.Count; i++)
                {
                    System.Drawing.PointF p1 = Points[i];
                    System.Drawing.PointF p2 = new PointF(p1.X + 2.0f, p1.Y + 2.0f);
                    e.Graphics.DrawLine(p, p1, p2);
                }
                p.Dispose();
            }
        }
    }
}
