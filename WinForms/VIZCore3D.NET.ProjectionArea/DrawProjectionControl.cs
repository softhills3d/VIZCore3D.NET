using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.ProjectionArea
{
    public partial class DrawProjectionControl : UserControl
    {
        public List<VIZCore3D.NET.Data.Line3D> Lines { get; set; }

        public List<System.Drawing.PointF> Start { get; set; }
        public List<System.Drawing.PointF> End { get; set; }

        public float MinX { get; set; }
        public float MinY { get; set; }

        public DrawProjectionControl()
        {
            InitializeComponent();

            Lines = null;

            Start = new List<PointF>();
            End = new List<PointF>();
        }

        public void SetData(List<VIZCore3D.NET.Data.Line3D> lines)
        {
            Lines = lines;

            Start.Clear();
            End.Clear();

            for (int i = 0; i < Lines.Count; i++)
            {
                VIZCore3D.NET.Data.Line3D line = Lines[i];

                if (i == 0)
                {
                    MinX = line.Start2D.X;
                    MinY = line.End2D.Y;
                }
                else
                {
                    MinX = Math.Min(MinX, line.Start2D.X);
                    MinY = Math.Min(MinY, line.Start2D.Y);

                    MinX = Math.Min(MinX, line.End2D.X);
                    MinY = Math.Min(MinY, line.End2D.Y);
                }
            }

            float offsetX = 0.0f - MinX;
            float offsetY = 0.0f - MinY;

            for (int i = 0; i < Lines.Count; i++)
            {
                VIZCore3D.NET.Data.Line3D line = Lines[i];

                Start.Add(new PointF(line.Start2D.X + offsetX, line.Start2D.Y + offsetY));
                End.Add(new PointF(line.End2D.X + offsetX, line.End2D.Y + offsetY));
            }

            Invalidate();
        }


        private void DrawProjectionControl_Paint(object sender, PaintEventArgs e)
        {
            if (Lines == null) return;

            //e.Graphics.FillRectangle(Brushes.White, 0, 0, this.Width, this.Height);

            System.Drawing.Pen pen = new Pen(Brushes.Black, 1.0f);

            for (int i = 0; i < Start.Count; i++)
            {
                e.Graphics.DrawLine(pen, Start[i], End[i]);
            }

            pen.Dispose();
            pen = null;
        }
    }
}
