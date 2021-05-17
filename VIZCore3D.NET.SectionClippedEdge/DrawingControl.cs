using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.SectionClippedEdge
{
    public partial class DrawingControl : UserControl
    {
        public List<List<PointF>> Lines { get; set; }

        public DrawingControl()
        {
            InitializeComponent();
        }

        public void SetData(List<List<PointF>> lines)
        {
            Lines = lines;

            Invalidate();
        }

        public void ClearData()
        {
            Lines = null;

            Invalidate();
        }

        private void DrawingControl_Paint(object sender, PaintEventArgs e)
        {
            if (Lines == null)
            {
                e.Graphics.FillRectangle(Brushes.Black, new Rectangle(0, 0, this.Width, this.Height));
                return;
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.White, 1))
            {
                foreach (List<PointF> item in Lines)
                {
                    e.Graphics.DrawLines(pen, item.ToArray());
                }
            }
        }
    }
}
