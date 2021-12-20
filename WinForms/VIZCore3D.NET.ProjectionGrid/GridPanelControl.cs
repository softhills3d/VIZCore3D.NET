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
        private List<List<System.Drawing.PointF>> Points { get; set; }

        public GridPanelControl()
        {
            InitializeComponent();
        }

        public void SetData(List<List<System.Drawing.PointF>> points)
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
                SolidBrush blueBrush = new SolidBrush(Color.Blue);

                for (int i = 0; i < Points.Count; i++)
                {
                    List<System.Drawing.PointF> bodyPoint = Points[i];

                    for (int j = 0; j < bodyPoint.Count; j++)
                    {
                        if (j + 2 >= bodyPoint.Count) continue;

                        PointF[] pt =
                        {
                            bodyPoint[j + 0],
                            bodyPoint[j + 1],
                            bodyPoint[j + 2]
                        };

                        e.Graphics.DrawPolygon(p, pt);
                        //e.Graphics.FillPolygon(blueBrush, pt);

                        j += 2;
                    }

                    //e.Graphics.DrawPolygon(p, bodyPoint.ToArray());
                }
                p.Dispose();
                blueBrush.Dispose();
            }
        }
    }
}
