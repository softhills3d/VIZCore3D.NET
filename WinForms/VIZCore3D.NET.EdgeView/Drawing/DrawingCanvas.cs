using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VIZCore3D.NET.Data;

namespace VIZCore3D.NET.EdgeView.Drawing
{
    /// <summary>
    /// 2D 도면 표시 컨트롤 (Pan : 좌/중 버튼 드래그, Zoom : 휠, Fit : 더블클릭).
    /// Projection.GetEdgeProjection 결과의 선(Lines) / 문자(Texts)를 그대로 그림.
    /// 포인트 편집 모드 : 중요 포인트(꺾임점/분기점/끝점) 표시, 드래그로 이동 → EdgeProjectionResult.MoveKeyPoint 로 도면 변형.
    /// </summary>
    public class DrawingCanvas : Control
    {
        const float CornerAngle = 15.0f;   // 꺾임점 기준 각도 (도)
        const int PickPixel = 7;           // 포인트 선택 반경 (픽셀)

        List<EdgeProjectionResult> views = new List<EdgeProjectionResult>();
        double scale = 1, cx, cy;
        Point lastMouse;
        bool dragging;
        PointF mouseWorld;
        bool hasMouse;
        bool editMode;

        // 포인트 편집 : 마우스 아래 포인트 / 드래그 중인 포인트
        EdgeProjectionResult dragView;
        ProjectionKeyPoint2D hotPoint, dragPoint;

        public bool DarkTheme { get; set; }
        public bool ShowLegend { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }

        /// <summary>포인트를 이동하여 도면이 변형되면 발생</summary>
        public event EventHandler DrawingEdited;

        /// <summary>포인트 편집 모드 (중요 포인트 표시 / 드래그 이동)</summary>
        public bool EditMode
        {
            get { return editMode; }
            set
            {
                editMode = value;
                if (editMode) DetectKeyPoints();
                hotPoint = dragPoint = null;
                Invalidate();
            }
        }

        void DetectKeyPoints()
        {
            foreach (var v in views) v.GetKeyPoints(CornerAngle);
        }

        /// <summary>마우스 위치의 중요 포인트 검색</summary>
        bool PickKeyPoint(Point screen, out EdgeProjectionResult view, out ProjectionKeyPoint2D point)
        {
            view = null; point = null;
            var w = ToWorld(screen);
            float tol = (float)(PickPixel / scale);
            foreach (var v in views)
            {
                var p = v.FindKeyPoint(w, tol);
                if (p != null) { view = v; point = p; return true; }
            }
            return false;
        }

        public DrawingCanvas()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);
            ShowLegend = true;
            Message = "3D 모델에서 개체를 선택하면 모서리 기반 2D 도면이 표시됩니다.";
        }

        public List<EdgeProjectionResult> Views { get { return views; } }

        public void SetViews(List<EdgeProjectionResult> v, bool fit)
        {
            views = v ?? new List<EdgeProjectionResult>();
            hotPoint = dragPoint = null;
            if (editMode) DetectKeyPoints();
            if (fit) FitToView();
            Invalidate();
        }

        RectangleF AllBounds()
        {
            RectangleF all = RectangleF.Empty;
            foreach (var v in views)
            {
                var b = v.GetBounds();
                if (b.IsEmpty) continue;
                all = all.IsEmpty ? b : RectangleF.Union(all, b);
            }
            return all;
        }

        public void FitToView()
        {
            var b = AllBounds();
            if (b.IsEmpty || Width < 10 || Height < 10) { Invalidate(); return; }
            double w = Math.Max(b.Width, 1e-9), h = Math.Max(b.Height, 1e-9);
            scale = Math.Min((Width - 40) / w, (Height - 40) / h);
            if (scale <= 0 || double.IsInfinity(scale) || double.IsNaN(scale)) scale = 1;
            cx = b.X + b.Width / 2.0; cy = b.Y + b.Height / 2.0;
            Invalidate();
        }

        // 도면 좌표(Y 위쪽) → 화면 좌표(Y 아래쪽)
        PointF ToScreen(PointF p)
        {
            return new PointF((float)((p.X - cx) * scale + Width / 2.0), (float)(-(p.Y - cy) * scale + Height / 2.0));
        }

        PointF ToWorld(Point p)
        {
            return new PointF((float)((p.X - Width / 2.0) / scale + cx), (float)(-(p.Y - Height / 2.0) / scale + cy));
        }

        // ------------------------------------------------------------------
        // 스타일
        // ------------------------------------------------------------------
        public Color PaperColor { get { return DarkTheme ? Color.FromArgb(30, 32, 36) : Color.White; } }

        public Color ColorOf(ProjectionLineKind k)
        {
            switch (k)
            {
                case ProjectionLineKind.OUTER: return DarkTheme ? Color.WhiteSmoke : Color.Black;
                case ProjectionLineKind.INNER: return DarkTheme ? Color.FromArgb(90, 170, 255) : Color.FromArgb(0, 70, 200);
                case ProjectionLineKind.FEATURE: return DarkTheme ? Color.FromArgb(190, 190, 190) : Color.FromArgb(70, 70, 70);
                case ProjectionLineKind.SILHOUETTE: return DarkTheme ? Color.FromArgb(160, 200, 160) : Color.FromArgb(40, 110, 40);
                case ProjectionLineKind.HIDDEN: return DarkTheme ? Color.FromArgb(130, 130, 130) : Color.FromArgb(150, 150, 150);
                case ProjectionLineKind.CENTER: return DarkTheme ? Color.FromArgb(255, 110, 110) : Color.FromArgb(200, 30, 30);
                default: return DarkTheme ? Color.FromArgb(80, 210, 200) : Color.FromArgb(0, 130, 120);
            }
        }

        Pen PenOf(ProjectionLineKind k)
        {
            var p = new Pen(ColorOf(k), 1f);
            switch (k)
            {
                case ProjectionLineKind.OUTER: p.Width = 2.2f; break;
                case ProjectionLineKind.INNER: p.Width = 1.8f; break;
                case ProjectionLineKind.HIDDEN: p.DashPattern = new float[] { 5, 3 }; break;
                case ProjectionLineKind.CENTER: p.DashPattern = new float[] { 12, 3, 2, 3 }; p.Width = 0.8f; break;
                case ProjectionLineKind.DIMENSION: p.Width = 0.8f; break;
            }
            return p;
        }

        // ------------------------------------------------------------------
        // 그리기
        // ------------------------------------------------------------------
        protected override void OnPaint(PaintEventArgs e)
        {
            var gr = e.Graphics;
            gr.Clear(PaperColor);
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            if (views.Count == 0)
            {
                using (var br = new SolidBrush(ColorOf(ProjectionLineKind.FEATURE)))
                using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                    gr.DrawString(Message ?? "", Font, br, ClientRectangle, sf);
                return;
            }

            // 그리는 순서 : 은선 → 치수/중심선 → 일반 → 실루엣 → Inner → Outer
            ProjectionLineKind[] order =
            {
                ProjectionLineKind.HIDDEN, ProjectionLineKind.DIMENSION, ProjectionLineKind.CENTER, ProjectionLineKind.FEATURE,
                ProjectionLineKind.SILHOUETTE, ProjectionLineKind.INNER, ProjectionLineKind.OUTER
            };
            var rect = new RectangleF(-50, -50, Width + 100, Height + 100);
            foreach (var k in order)
                using (var pen = PenOf(k))
                    foreach (var v in views)
                        foreach (var l in v.Lines)
                        {
                            if (l.Kind != k) continue;
                            var a = ToScreen(l.Start); var b = ToScreen(l.End);
                            if (Math.Max(a.X, b.X) < rect.Left || Math.Min(a.X, b.X) > rect.Right ||
                                Math.Max(a.Y, b.Y) < rect.Top || Math.Min(a.Y, b.Y) > rect.Bottom) continue;
                            gr.DrawLine(pen, a, b);
                        }

            foreach (var v in views)
                foreach (var t in v.Texts) DrawText(gr, t);

            if (editMode) DrawKeyPoints(gr);
            if (ShowLegend) DrawLegend(gr);
            DrawInfo(gr);
        }

        void DrawText(Graphics gr, ProjectionText2D t)
        {
            float px = (float)(t.Height * scale);
            if (px < 5) return;
            if (px > 400) px = 400;
            var p = ToScreen(t.Position);
            using (var f = new Font("Segoe UI", px, GraphicsUnit.Pixel))
            using (var br = new SolidBrush(ColorOf(t.Kind)))
            using (var sf = new StringFormat())
            {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = t.Align == ProjectionTextAlign.LEFT ? StringAlignment.Near : t.Align == ProjectionTextAlign.RIGHT ? StringAlignment.Far : StringAlignment.Center;
                var st = gr.Save();
                gr.TranslateTransform(p.X, p.Y);
                if (t.Angle != 0) gr.RotateTransform(-t.Angle);
                gr.DrawString(t.Text, f, br, 0, 0, sf);
                gr.Restore(st);
            }
        }

        void DrawKeyPoints(Graphics gr)
        {
            Color normal = DarkTheme ? Color.FromArgb(255, 190, 60) : Color.FromArgb(230, 120, 0);
            Color hot = DarkTheme ? Color.FromArgb(255, 80, 200) : Color.FromArgb(220, 0, 140);
            using (var pen = new Pen(normal, 1.5f))
            using (var fill = new SolidBrush(PaperColor))
            using (var hotBrush = new SolidBrush(hot))
                foreach (var v in views)
                    foreach (var k in v.KeyPoints)
                    {
                        var p = ToScreen(k.Position);
                        bool isHot = k == hotPoint || k == dragPoint;
                        float r = isHot ? 6 : 4;
                        // 꺾임점 = 사각형, 분기점 = 마름모, 끝점 = 원
                        var rect = new RectangleF(p.X - r, p.Y - r, r * 2, r * 2);
                        Brush br = isHot ? (Brush)hotBrush : fill;
                        if (k.Kind == ProjectionKeyPointKind.CORNER) { gr.FillRectangle(br, rect); gr.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height); }
                        else if (k.Kind == ProjectionKeyPointKind.END) { gr.FillEllipse(br, rect); gr.DrawEllipse(pen, rect); }
                        else
                        {
                            var poly = new[] { new PointF(p.X, p.Y - r - 1), new PointF(p.X + r + 1, p.Y), new PointF(p.X, p.Y + r + 1), new PointF(p.X - r - 1, p.Y) };
                            gr.FillPolygon(br, poly); gr.DrawPolygon(pen, poly);
                        }
                    }
        }

        void DrawLegend(Graphics gr)
        {
            var items = new[]
            {
                new KeyValuePair<ProjectionLineKind,string>(ProjectionLineKind.OUTER, "Outer Contour"),
                new KeyValuePair<ProjectionLineKind,string>(ProjectionLineKind.INNER, "Inner Contour (Hole)"),
                new KeyValuePair<ProjectionLineKind,string>(ProjectionLineKind.FEATURE, "Edge"),
                new KeyValuePair<ProjectionLineKind,string>(ProjectionLineKind.SILHOUETTE, "Silhouette"),
                new KeyValuePair<ProjectionLineKind,string>(ProjectionLineKind.HIDDEN, "Hidden"),
                new KeyValuePair<ProjectionLineKind,string>(ProjectionLineKind.CENTER, "Center"),
            };
            int rowH = 16, y = 10, x = Width - 180;
            using (var bg = new SolidBrush(Color.FromArgb(200, PaperColor)))
                gr.FillRectangle(bg, x - 4, y - 4, 170, items.Length * rowH + 8);
            using (var br = new SolidBrush(ColorOf(ProjectionLineKind.FEATURE)))
                foreach (var it in items)
                {
                    using (var p = PenOf(it.Key))
                        gr.DrawLine(p, x, y + rowH / 2, x + 30, y + rowH / 2);
                    gr.DrawString(it.Value, Font, br, x + 38, y + 1);
                    y += rowH;
                }
        }

        void DrawInfo(Graphics gr)
        {
            var sb = new System.Text.StringBuilder();
            if (!string.IsNullOrEmpty(Title)) sb.Append(Title.Length > 80 ? Title.Substring(0, 80) + "..." : Title).Append("   ");
            sb.AppendFormat("1px = {0:0.###}", 1.0 / scale);
            if (hasMouse) sb.AppendFormat("   X {0:0.##}  Y {1:0.##}", mouseWorld.X, mouseWorld.Y);
            using (var br = new SolidBrush(ColorOf(ProjectionLineKind.FEATURE)))
                gr.DrawString(sb.ToString(), Font, br, 8, Height - Font.Height - 6);
        }

        // ------------------------------------------------------------------
        // 마우스
        // ------------------------------------------------------------------
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Focus();
            if (editMode && e.Button == MouseButtons.Left && PickKeyPoint(e.Location, out dragView, out dragPoint))
            {
                Cursor = Cursors.Hand;   // 포인트 드래그 시작
                return;
            }
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Middle)
            {
                dragging = true; lastMouse = e.Location; Cursor = Cursors.SizeAll;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            mouseWorld = ToWorld(e.Location); hasMouse = true;
            if (dragPoint != null)
            {
                // 도면 좌표로 변환 후 API 로 포인트 이동 (연결된 선 변형, 치수 갱신)
                dragView.MoveKeyPoint(dragPoint.Id, mouseWorld);
                Invalidate();
                return;
            }
            if (editMode && !dragging)
            {
                EdgeProjectionResult v; ProjectionKeyPoint2D p;
                PickKeyPoint(e.Location, out v, out p);
                hotPoint = p;
                Cursor = p != null ? Cursors.Hand : Cursors.Default;
            }
            if (dragging)
            {
                cx -= (e.X - lastMouse.X) / scale;
                cy += (e.Y - lastMouse.Y) / scale;
                lastMouse = e.Location;
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (dragPoint != null)
            {
                dragPoint = null; dragView = null;
                if (DrawingEdited != null) DrawingEdited(this, EventArgs.Empty);
            }
            dragging = false; Cursor = Cursors.Default;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hasMouse = false; Invalidate();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            var before = ToWorld(e.Location);
            scale *= e.Delta > 0 ? 1.2 : 1 / 1.2;
            var after = ToWorld(e.Location);
            cx += before.X - after.X; cy += before.Y - after.Y;
            Invalidate();
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            FitToView();
        }

        public Bitmap RenderToBitmap()
        {
            var bmp = new Bitmap(Math.Max(1, Width), Math.Max(1, Height));
            DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }
    }
}
