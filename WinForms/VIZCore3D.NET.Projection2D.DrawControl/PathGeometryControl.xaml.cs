using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using IOPath = System.IO.Path;

namespace VIZCore3D.NET.Projection2D.DrawControl
{
    public partial class PathGeometryControl : UserControl
    {
        // Geometry bounds
        private double geoMinX, geoMinY, geoMaxX, geoMaxY;
        private bool hasGeometry = false;

        // Pan state
        private bool isPanning = false;
        private Point panStart;
        private double panStartX, panStartY;

        // Current geometry data
        private string currentPathData = null;
        private string currentPointData = null;

        // Reference to drawn path for thickness update on zoom
        private Path geometryPath = null;
        private const double BaseStrokeThickness = 1.5;

        // Real 3D dimensions (mm) - passed from caller
        private double real3DWidth = 0;
        private double real3DHeight = 0;
        private bool hasReal3DDimensions = false;

        // Real 3D bounding box coordinates - for corner labels
        private double bbox3DMinX, bbox3DMinY, bbox3DMinZ;
        private double bbox3DMaxX, bbox3DMaxY, bbox3DMaxZ;
        private bool hasBBox3D = false;

        // Options
        private bool showGrid = true;
        private bool showBoundBox = false;
        private bool showDimensions = true;
        private bool fillShape = false;
        private bool showCorners = false;
        private bool showKeyPoints = false;

        // Colors
        private static readonly SolidColorBrush StrokeColor = new SolidColorBrush(Color.FromRgb(30, 80, 160));
        private static readonly SolidColorBrush StrokeColorLight = new SolidColorBrush(Color.FromRgb(100, 150, 220));
        private static readonly SolidColorBrush FillColor = new SolidColorBrush(Color.FromArgb(30, 30, 80, 160));
        private static readonly SolidColorBrush BBoxColor = new SolidColorBrush(Color.FromRgb(220, 60, 60));
        private static readonly SolidColorBrush DimColor = new SolidColorBrush(Color.FromRgb(80, 80, 80));
        private static readonly SolidColorBrush GridColorMajor = new SolidColorBrush(Color.FromRgb(210, 210, 210));
        private static readonly SolidColorBrush GridColorMinor = new SolidColorBrush(Color.FromRgb(235, 235, 235));
        private static readonly SolidColorBrush OriginColor = new SolidColorBrush(Color.FromRgb(180, 60, 60));

        public PathGeometryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Draw WPF PathGeometry string with real 3D bounding box
        /// </summary>
        public void DrawPathGeometry(string PATHDATA,
            double realWidth, double realHeight,
            double minX3D, double minY3D, double minZ3D,
            double maxX3D, double maxY3D, double maxZ3D)
        {
            real3DWidth = realWidth;
            real3DHeight = realHeight;
            hasReal3DDimensions = (realWidth > 0 && realHeight > 0);

            bbox3DMinX = minX3D; bbox3DMinY = minY3D; bbox3DMinZ = minZ3D;
            bbox3DMaxX = maxX3D; bbox3DMaxY = maxY3D; bbox3DMaxZ = maxZ3D;
            hasBBox3D = true;

            DrawPathGeometry(PATHDATA);
        }

        /// <summary>
        /// Draw WPF PathGeometry string with real 3D dimensions (no corner labels)
        /// </summary>
        public void DrawPathGeometry(string PATHDATA, double realWidth, double realHeight)
        {
            real3DWidth = realWidth;
            real3DHeight = realHeight;
            hasReal3DDimensions = (realWidth > 0 && realHeight > 0);
            hasBBox3D = false;
            DrawPathGeometry(PATHDATA);
        }

        /// <summary>
        /// Draw WPF PathGeometry string
        /// </summary>
        public void DrawPathGeometry(string PATHDATA)
        {
            MyCanvas.Children.Clear();
            OverlayCanvas.Children.Clear();
            currentPathData = PATHDATA;
            currentPointData = null;

            if (String.IsNullOrEmpty(PATHDATA))
            {
                hasGeometry = false;
                UpdateStatusBar();
                DrawGrid();
                return;
            }

            Geometry geo = Geometry.Parse(PATHDATA);
            Rect bounds = geo.Bounds;
            geoMinX = bounds.Left;
            geoMinY = bounds.Top;
            geoMaxX = bounds.Right;
            geoMaxY = bounds.Bottom;
            hasGeometry = true;

            geometryPath = new Path();
            geometryPath.Stroke = StrokeColor;
            geometryPath.StrokeThickness = BaseStrokeThickness / scaleTransform.ScaleX;
            geometryPath.StrokeLineJoin = PenLineJoin.Round;
            geometryPath.StrokeStartLineCap = PenLineCap.Round;
            geometryPath.StrokeEndLineCap = PenLineCap.Round;
            geometryPath.Data = geo;

            if (fillShape)
                geometryPath.Fill = FillColor;

            RenderOptions.SetEdgeMode(geometryPath, EdgeMode.Unspecified);

            MyCanvas.Children.Add(geometryPath);

            BuildFlattenedPoints();
            ZoomToFit();
        }

        /// <summary>
        /// Draw from comma-separated point string
        /// </summary>
        public void DrawPoints(string Point)
        {
            MyCanvas.Children.Clear();
            OverlayCanvas.Children.Clear();
            currentPointData = Point;
            currentPathData = null;

            if (String.IsNullOrEmpty(Point))
            {
                hasGeometry = false;
                UpdateStatusBar();
                DrawGrid();
                return;
            }

            string[] Points = Point.Split(new char[] { ',' });
            string PathDataByPoints = String.Empty;

            double minX = double.MaxValue;
            double minY = double.MaxValue;
            double maxX = double.MinValue;
            double maxY = double.MinValue;

            for (int i = 0; i < Points.Length; i++)
            {
                if (i % 2 != 0) continue;
                if (i + 1 >= Points.Length) break;

                double nX = Convert.ToDouble(Points[i]);
                double nY = Convert.ToDouble(Points[i + 1]);

                minX = Math.Min(minX, nX);
                minY = Math.Min(minY, nY);
                maxX = Math.Max(maxX, nX);
                maxY = Math.Max(maxY, nY);

                if (i == 0)
                    PathDataByPoints = string.Format("M{0},{1}", Points[i], Points[i + 1]);
                else if (i < Points.Length - 3)
                    PathDataByPoints += string.Format("L{0},{1}", Points[i], Points[i + 1]);
                else
                    PathDataByPoints += string.Format("L{0},{1}z", Points[i], Points[i + 1]);
            }

            geoMinX = minX;
            geoMinY = minY;
            geoMaxX = maxX;
            geoMaxY = maxY;
            hasGeometry = true;

            TranslateTransform tt = new TranslateTransform(-minX, -minY);

            geometryPath = new Path();
            geometryPath.Stroke = StrokeColor;
            geometryPath.StrokeThickness = BaseStrokeThickness / scaleTransform.ScaleX;
            geometryPath.StrokeLineJoin = PenLineJoin.Round;
            geometryPath.Data = Geometry.Parse(PathDataByPoints);
            geometryPath.RenderTransform = tt;

            if (fillShape)
                geometryPath.Fill = FillColor;

            RenderOptions.SetEdgeMode(geometryPath, EdgeMode.Unspecified);

            MyCanvas.Children.Add(geometryPath);

            BuildFlattenedPoints();
            ZoomToFit();
        }

        /// <summary>
        /// Zoom to fit geometry in the viewport
        /// </summary>
        public void ZoomToFit()
        {
            if (!hasGeometry) return;

            double viewW = ViewportCanvas.ActualWidth;
            double viewH = ViewportCanvas.ActualHeight;
            if (viewW <= 0 || viewH <= 0) return;

            double geoW = geoMaxX - geoMinX;
            double geoH = geoMaxY - geoMinY;
            if (geoW <= 0 || geoH <= 0) return;

            double margin = 40;
            double scaleX = (viewW - margin * 2) / geoW;
            double scaleY = (viewH - margin * 2) / geoH;
            double scale = Math.Min(scaleX, scaleY);

            scaleTransform.ScaleX = scale;
            scaleTransform.ScaleY = scale;

            double centerGeoX = (geoMinX + geoMaxX) / 2.0;
            double centerGeoY = (geoMinY + geoMaxY) / 2.0;

            translateTransform.X = viewW / 2.0 - centerGeoX * scale;
            translateTransform.Y = viewH / 2.0 - centerGeoY * scale;

            UpdateGeometryThickness();
            DrawGrid();
            if (hasGeometry) DrawOverlays();
            UpdateStatusBar();
        }

        /// <summary>
        /// Export current view as PNG
        /// </summary>
        public string ExportImage(string filePath = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.Filter = "PNG Image|*.png|BMP Image|*.bmp|JPEG Image|*.jpg";
                dlg.DefaultExt = ".png";
                dlg.FileName = "Projection2D";
                if (dlg.ShowDialog() != true) return null;
                filePath = dlg.FileName;
            }

            // Render the viewport
            double w = ViewportCanvas.ActualWidth;
            double h = ViewportCanvas.ActualHeight;
            if (w <= 0 || h <= 0) return null;

            RenderTargetBitmap rtb = new RenderTargetBitmap(
                (int)w, (int)h, 96, 96, PixelFormats.Pbgra32);
            rtb.Render(ViewportCanvas);

            BitmapEncoder encoder;
            string ext = IOPath.GetExtension(filePath).ToLower();
            if (ext == ".bmp")
                encoder = new BmpBitmapEncoder();
            else if (ext == ".jpg" || ext == ".jpeg")
                encoder = new JpegBitmapEncoder();
            else
                encoder = new PngBitmapEncoder();

            encoder.Frames.Add(BitmapFrame.Create(rtb));

            using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                encoder.Save(fs);
            }

            return filePath;
        }

        #region Grid Drawing

        private void DrawGrid()
        {
            GridCanvas.Children.Clear();

            if (!showGrid) return;
            if (!hasGeometry) return;

            double viewW = ViewportCanvas.ActualWidth;
            double viewH = ViewportCanvas.ActualHeight;
            if (viewW <= 0 || viewH <= 0) return;

            double scale = scaleTransform.ScaleX;
            double tx = translateTransform.X;
            double ty = translateTransform.Y;

            // Calculate visible area in world coordinates
            double worldLeft = -tx / scale;
            double worldTop = -ty / scale;
            double worldRight = (viewW - tx) / scale;
            double worldBottom = (viewH - ty) / scale;

            // Choose grid spacing based on zoom level
            double worldWidth = worldRight - worldLeft;
            double targetCells = 10;
            double rawSpacing = worldWidth / targetCells;

            // Snap to nice numbers
            double spacing = GetNiceGridSpacing(rawSpacing);
            double majorSpacing = spacing * 5;

            // Draw minor grid lines
            double startX = Math.Floor(worldLeft / spacing) * spacing;
            double startY = Math.Floor(worldTop / spacing) * spacing;

            for (double x = startX; x <= worldRight; x += spacing)
            {
                bool isMajor = Math.Abs(x % majorSpacing) < spacing * 0.1;
                Line line = new Line();
                line.X1 = x; line.Y1 = worldTop;
                line.X2 = x; line.Y2 = worldBottom;
                line.Stroke = isMajor ? GridColorMajor : GridColorMinor;
                line.StrokeThickness = (isMajor ? 1.0 : 0.5) / scale;
                GridCanvas.Children.Add(line);
            }

            for (double y = startY; y <= worldBottom; y += spacing)
            {
                bool isMajor = Math.Abs(y % majorSpacing) < spacing * 0.1;
                Line line = new Line();
                line.X1 = worldLeft; line.Y1 = y;
                line.X2 = worldRight; line.Y2 = y;
                line.Stroke = isMajor ? GridColorMajor : GridColorMinor;
                line.StrokeThickness = (isMajor ? 1.0 : 0.5) / scale;
                GridCanvas.Children.Add(line);
            }

            // Draw origin crosshair
            if (worldLeft <= 0 && worldRight >= 0)
            {
                Line originY = new Line();
                originY.X1 = 0; originY.Y1 = worldTop;
                originY.X2 = 0; originY.Y2 = worldBottom;
                originY.Stroke = OriginColor;
                originY.StrokeThickness = 1.0 / scale;
                originY.Opacity = 0.5;
                GridCanvas.Children.Add(originY);
            }
            if (worldTop <= 0 && worldBottom >= 0)
            {
                Line originX = new Line();
                originX.X1 = worldLeft; originX.Y1 = 0;
                originX.X2 = worldRight; originX.Y2 = 0;
                originX.Stroke = OriginColor;
                originX.StrokeThickness = 1.0 / scale;
                originX.Opacity = 0.5;
                GridCanvas.Children.Add(originX);
            }
        }

        private double GetNiceGridSpacing(double raw)
        {
            double magnitude = Math.Pow(10, Math.Floor(Math.Log10(raw)));
            double normalized = raw / magnitude;

            if (normalized < 1.5) return magnitude;
            if (normalized < 3.5) return magnitude * 2;
            if (normalized < 7.5) return magnitude * 5;
            return magnitude * 10;
        }

        #endregion

        #region Overlay Drawing (BBox, Dimensions)

        private void DrawOverlays()
        {
            OverlayCanvas.Children.Clear();

            if (!hasGeometry) return;

            double geoW = geoMaxX - geoMinX;
            double geoH = geoMaxY - geoMinY;

            // Bounding box
            if (showBoundBox)
            {
                Rectangle bbox = new Rectangle();
                bbox.Width = geoW;
                bbox.Height = geoH;
                Canvas.SetLeft(bbox, geoMinX);
                Canvas.SetTop(bbox, geoMinY);
                bbox.Stroke = BBoxColor;
                bbox.StrokeThickness = 1;
                bbox.StrokeDashArray = new DoubleCollection(new double[] { 6, 3 });
                bbox.Fill = null;
                OverlayCanvas.Children.Add(bbox);
            }

            // Dimension labels
            if (showDimensions)
            {
                double scale = scaleTransform.ScaleX;
                double fontSize = Math.Max(8, 11 / scale);

                // Use real 3D dimensions if available, otherwise use projected bounds
                double dimW = hasReal3DDimensions ? real3DWidth : geoW;
                double dimH = hasReal3DDimensions ? real3DHeight : geoH;

                // Width dimension (bottom)
                DrawDimensionLine(geoMinX, geoMaxY + 15 / scale, geoMaxX, geoMaxY + 15 / scale,
                    FormatDimension(dimW), fontSize, scale);

                // Height dimension (right)
                DrawDimensionLine(geoMaxX + 15 / scale, geoMinY, geoMaxX + 15 / scale, geoMaxY,
                    FormatDimension(dimH), fontSize, scale, true);
            }

            // Key point labels on geometry lines
            if (hasBBox3D && showKeyPoints)
            {
                double scale = scaleTransform.ScaleX;
                DrawKeyPointLabels(scale);
            }

            // 3D coordinate labels at bounding box corners
            if (hasBBox3D && showCorners)
            {
                double scale = scaleTransform.ScaleX;
                double fontSize = Math.Max(7, 9.5 / scale);
                double pad = 5 / scale;

                // Top-Left corner: (MinX, MinY) in 2D → 3D min
                DrawCornerLabel(geoMinX, geoMinY, fontSize, scale, pad,
                    bbox3DMinX, bbox3DMaxY, bbox3DMaxZ,
                    HAlign.Right, VAlign.Bottom);

                // Top-Right corner
                DrawCornerLabel(geoMaxX, geoMinY, fontSize, scale, pad,
                    bbox3DMaxX, bbox3DMaxY, bbox3DMaxZ,
                    HAlign.Left, VAlign.Bottom);

                // Bottom-Left corner
                DrawCornerLabel(geoMinX, geoMaxY, fontSize, scale, pad,
                    bbox3DMinX, bbox3DMinY, bbox3DMinZ,
                    HAlign.Right, VAlign.Top);

                // Bottom-Right corner
                DrawCornerLabel(geoMaxX, geoMaxY, fontSize, scale, pad,
                    bbox3DMaxX, bbox3DMinY, bbox3DMinZ,
                    HAlign.Left, VAlign.Top);
            }
        }

        private void DrawDimensionLine(double x1, double y1, double x2, double y2,
            string label, double fontSize, double scale, bool vertical = false)
        {
            // Dimension line
            Line dimLine = new Line();
            dimLine.X1 = x1; dimLine.Y1 = y1;
            dimLine.X2 = x2; dimLine.Y2 = y2;
            dimLine.Stroke = DimColor;
            dimLine.StrokeThickness = 0.8 / scale;
            OverlayCanvas.Children.Add(dimLine);

            // Extension lines
            double ext = 5 / scale;
            if (!vertical)
            {
                AddExtLine(x1, y1 - ext, x1, y1 + ext, scale);
                AddExtLine(x2, y2 - ext, x2, y2 + ext, scale);
            }
            else
            {
                AddExtLine(x1 - ext, y1, x1 + ext, y1, scale);
                AddExtLine(x2 - ext, y2, x2 + ext, y2, scale);
            }

            // Arrow heads
            double arrowSize = 4 / scale;
            if (!vertical)
            {
                AddArrow(x1, y1, arrowSize, 0, scale);
                AddArrow(x2, y2, -arrowSize, 0, scale);
            }
            else
            {
                AddArrow(x1, y1, 0, arrowSize, scale);
                AddArrow(x2, y2, 0, -arrowSize, scale);
            }

            // Label
            TextBlock tb = new TextBlock();
            tb.Text = label;
            tb.FontSize = fontSize;
            tb.FontFamily = new FontFamily("Consolas");
            tb.Foreground = DimColor;

            if (vertical)
            {
                tb.RenderTransform = new RotateTransform(-90);
                double midY = (y1 + y2) / 2.0;
                Canvas.SetLeft(tb, (x1 + x2) / 2.0 + 3 / scale);
                Canvas.SetTop(tb, midY);
            }
            else
            {
                double midX = (x1 + x2) / 2.0;
                Canvas.SetLeft(tb, midX - 20 / scale);
                Canvas.SetTop(tb, y1 + 2 / scale);
            }

            OverlayCanvas.Children.Add(tb);
        }

        private void AddExtLine(double x1, double y1, double x2, double y2, double scale)
        {
            Line line = new Line();
            line.X1 = x1; line.Y1 = y1;
            line.X2 = x2; line.Y2 = y2;
            line.Stroke = DimColor;
            line.StrokeThickness = 0.5 / scale;
            OverlayCanvas.Children.Add(line);
        }

        private void AddArrow(double x, double y, double dx, double dy, double scale)
        {
            Polygon arrow = new Polygon();
            arrow.Fill = DimColor;
            double perpX = -dy * 0.4;
            double perpY = dx * 0.4;
            arrow.Points.Add(new Point(x, y));
            arrow.Points.Add(new Point(x - dx + perpX, y - dy + perpY));
            arrow.Points.Add(new Point(x - dx - perpX, y - dy - perpY));
            OverlayCanvas.Children.Add(arrow);
        }

        private string FormatDimension(double value)
        {
            if (Math.Abs(value) >= 1000000)
                return string.Format("{0:N0} mm", value);
            else if (Math.Abs(value) >= 1000)
                return string.Format("{0:N1} mm", value);
            else if (Math.Abs(value) >= 1)
                return string.Format("{0:N2} mm", value);
            else
                return string.Format("{0:N4} mm", value);
        }

        private enum HAlign { Left, Right }
        private enum VAlign { Top, Bottom }

        private static readonly SolidColorBrush CornerLabelBg = new SolidColorBrush(Color.FromArgb(200, 255, 255, 255));
        private static readonly SolidColorBrush CornerLabelFg = new SolidColorBrush(Color.FromRgb(180, 40, 40));
        private static readonly SolidColorBrush CornerDotBrush = new SolidColorBrush(Color.FromRgb(220, 60, 60));

        private static readonly SolidColorBrush KeyPointLabelBg = new SolidColorBrush(Color.FromArgb(210, 255, 255, 240));
        private static readonly SolidColorBrush KeyPointLabelFg = new SolidColorBrush(Color.FromRgb(40, 100, 40));
        private static readonly SolidColorBrush KeyPointDotBrush = new SolidColorBrush(Color.FromRgb(40, 140, 40));

        private void DrawCornerLabel(double geoX, double geoY,
            double fontSize, double scale, double pad,
            double x3D, double y3D, double z3D,
            HAlign hAlign, VAlign vAlign)
        {
            DrawPointLabel(geoX, geoY, fontSize, scale, pad,
                x3D, y3D, z3D, hAlign, vAlign,
                CornerDotBrush, CornerLabelBg, CornerLabelFg);
        }

        private void DrawPointLabel(double geoX, double geoY,
            double fontSize, double scale, double pad,
            double x3D, double y3D, double z3D,
            HAlign hAlign, VAlign vAlign,
            SolidColorBrush dotBrush, SolidColorBrush bgBrush, SolidColorBrush fgBrush)
        {
            // Dot
            double dotR = 3 / scale;
            Ellipse dot = new Ellipse();
            dot.Width = dotR * 2;
            dot.Height = dotR * 2;
            dot.Fill = dotBrush;
            Canvas.SetLeft(dot, geoX - dotR);
            Canvas.SetTop(dot, geoY - dotR);
            OverlayCanvas.Children.Add(dot);

            // Coordinate text
            string text = string.Format("({0:F1}, {1:F1}, {2:F1})", x3D, y3D, z3D);

            // Background border
            Border border = new Border();
            border.Background = bgBrush;
            border.BorderBrush = fgBrush;
            border.BorderThickness = new Thickness(0.5 / scale);
            border.CornerRadius = new CornerRadius(2 / scale);
            border.Padding = new Thickness(3 / scale, 1 / scale, 3 / scale, 1 / scale);

            TextBlock tb = new TextBlock();
            tb.Text = text;
            tb.FontSize = fontSize;
            tb.FontFamily = new FontFamily("Consolas");
            tb.Foreground = fgBrush;
            border.Child = tb;

            double offsetX = (hAlign == HAlign.Left) ? pad : -(pad + 180 / scale);
            double offsetY = (vAlign == VAlign.Top) ? pad : -(pad + 16 / scale);

            Canvas.SetLeft(border, geoX + offsetX);
            Canvas.SetTop(border, geoY + offsetY);
            OverlayCanvas.Children.Add(border);
        }

        /// <summary>
        /// Map 2D projected coordinate to approximate 3D coordinate
        /// </summary>
        private void Map2DTo3D(double px, double py, out double x3D, out double y3D, out double z3D)
        {
            double geoW = geoMaxX - geoMinX;
            double geoH = geoMaxY - geoMinY;

            double ratioX = geoW > 0 ? (px - geoMinX) / geoW : 0;
            double ratioY = geoH > 0 ? (py - geoMinY) / geoH : 0;

            // X maps left-to-right: MinX → MaxX
            x3D = bbox3DMinX + ratioX * (bbox3DMaxX - bbox3DMinX);
            // Y maps top-to-bottom in 2D, but MaxY→MinY in 3D (Y-up)
            y3D = bbox3DMaxY - ratioY * (bbox3DMaxY - bbox3DMinY);
            // Z: same as Y direction (top = MaxZ, bottom = MinZ)
            z3D = bbox3DMaxZ - ratioY * (bbox3DMaxZ - bbox3DMinZ);
        }

        /// <summary>
        /// Extract vertices from PathGeometry and find key points
        /// </summary>
        private void DrawKeyPointLabels(double scale)
        {
            if (!hasBBox3D) return;
            if (string.IsNullOrEmpty(currentPathData)) return;

            double fontSize = Math.Max(7, 8.5 / scale);
            double pad = 4 / scale;

            // Flatten PathGeometry to get all points
            Geometry geo = Geometry.Parse(currentPathData);
            PathGeometry flatGeo = geo.GetFlattenedPathGeometry(1.0, ToleranceType.Absolute);

            List<Point> allPoints = new List<Point>();
            foreach (PathFigure figure in flatGeo.Figures)
            {
                allPoints.Add(figure.StartPoint);
                foreach (PathSegment seg in figure.Segments)
                {
                    if (seg is PolyLineSegment)
                    {
                        PolyLineSegment pls = (PolyLineSegment)seg;
                        foreach (Point p in pls.Points)
                            allPoints.Add(p);
                    }
                    else if (seg is LineSegment)
                    {
                        allPoints.Add(((LineSegment)seg).Point);
                    }
                }
            }

            if (allPoints.Count < 3) return;

            // Find key points: extremes + significant direction changes
            List<int> keyIndices = new List<int>();

            // 1) Extreme points (min/max X, min/max Y)
            int idxMinX = 0, idxMaxX = 0, idxMinY = 0, idxMaxY = 0;
            for (int i = 1; i < allPoints.Count; i++)
            {
                if (allPoints[i].X < allPoints[idxMinX].X) idxMinX = i;
                if (allPoints[i].X > allPoints[idxMaxX].X) idxMaxX = i;
                if (allPoints[i].Y < allPoints[idxMinY].Y) idxMinY = i;
                if (allPoints[i].Y > allPoints[idxMaxY].Y) idxMaxY = i;
            }
            keyIndices.Add(idxMinX);
            keyIndices.Add(idxMaxX);
            keyIndices.Add(idxMinY);
            keyIndices.Add(idxMaxY);

            // 2) Significant angle changes (corners)
            double angleThreshold = 30.0; // degrees
            for (int i = 1; i < allPoints.Count - 1; i++)
            {
                Point prev = allPoints[i - 1];
                Point curr = allPoints[i];
                Point next = allPoints[i + 1];

                double dx1 = curr.X - prev.X;
                double dy1 = curr.Y - prev.Y;
                double dx2 = next.X - curr.X;
                double dy2 = next.Y - curr.Y;

                double len1 = Math.Sqrt(dx1 * dx1 + dy1 * dy1);
                double len2 = Math.Sqrt(dx2 * dx2 + dy2 * dy2);
                if (len1 < 0.001 || len2 < 0.001) continue;

                double dot = (dx1 * dx2 + dy1 * dy2) / (len1 * len2);
                dot = Math.Max(-1.0, Math.Min(1.0, dot));
                double angle = Math.Acos(dot) * 180.0 / Math.PI;

                if (angle >= angleThreshold)
                    keyIndices.Add(i);
            }

            // Deduplicate and filter points too close to each other
            List<Point> keyPoints = new List<Point>();
            HashSet<int> usedIndices = new HashSet<int>();
            double minDist = Math.Max(geoMaxX - geoMinX, geoMaxY - geoMinY) * 0.05;

            foreach (int idx in keyIndices)
            {
                if (usedIndices.Contains(idx)) continue;
                Point candidate = allPoints[idx];

                bool tooClose = false;
                foreach (Point existing in keyPoints)
                {
                    double dx = candidate.X - existing.X;
                    double dy = candidate.Y - existing.Y;
                    if (Math.Sqrt(dx * dx + dy * dy) < minDist)
                    {
                        tooClose = true;
                        break;
                    }
                }

                if (!tooClose)
                {
                    keyPoints.Add(candidate);
                    usedIndices.Add(idx);
                }
            }

            // Limit max labels to avoid clutter
            if (keyPoints.Count > 20) keyPoints = keyPoints.GetRange(0, 20);

            // Draw labels
            double centerX = (geoMinX + geoMaxX) / 2.0;
            double centerY = (geoMinY + geoMaxY) / 2.0;

            foreach (Point pt in keyPoints)
            {
                double x3D, y3D, z3D;
                Map2DTo3D(pt.X, pt.Y, out x3D, out y3D, out z3D);

                // Smart alignment: push label away from center
                HAlign ha = (pt.X >= centerX) ? HAlign.Left : HAlign.Right;
                VAlign va = (pt.Y >= centerY) ? VAlign.Top : VAlign.Bottom;

                DrawPointLabel(pt.X, pt.Y, fontSize, scale, pad,
                    x3D, y3D, z3D, ha, va,
                    KeyPointDotBrush, KeyPointLabelBg, KeyPointLabelFg);
            }
        }

        #endregion

        #region Mouse Interaction

        private void ViewportCanvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            double zoomFactor = e.Delta > 0 ? 1.15 : 1.0 / 1.15;

            Point mousePos = e.GetPosition(ViewportCanvas);

            // Get world position under mouse before zoom
            double worldX = (mousePos.X - translateTransform.X) / scaleTransform.ScaleX;
            double worldY = (mousePos.Y - translateTransform.Y) / scaleTransform.ScaleY;

            // Apply zoom
            double newScale = scaleTransform.ScaleX * zoomFactor;
            newScale = Math.Max(0.001, Math.Min(1000, newScale));

            scaleTransform.ScaleX = newScale;
            scaleTransform.ScaleY = newScale;

            // Adjust translation so world point stays under mouse
            translateTransform.X = mousePos.X - worldX * newScale;
            translateTransform.Y = mousePos.Y - worldY * newScale;

            UpdateGeometryThickness();
            DrawGrid();
            if (hasGeometry) DrawOverlays();
            UpdateStatusBar();
        }

        private void ViewportCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isPanning = true;
            panStart = e.GetPosition(this);
            panStartX = translateTransform.X;
            panStartY = translateTransform.Y;
            ViewportCanvas.CaptureMouse();
            ViewportCanvas.Cursor = Cursors.Hand;
        }

        private void ViewportCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isPanning = false;
            ViewportCanvas.ReleaseMouseCapture();
            ViewportCanvas.Cursor = Cursors.Arrow;
        }

        private void ViewportCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Update coordinate display
            Point mousePos = e.GetPosition(ViewportCanvas);
            double worldX = (mousePos.X - translateTransform.X) / scaleTransform.ScaleX;
            double worldY = (mousePos.Y - translateTransform.Y) / scaleTransform.ScaleY;
            txtCoordinate.Text = string.Format("X: {0:F1} mm  Y: {1:F1} mm", worldX, worldY);

            if (isPanning)
            {
                Point current = e.GetPosition(this);
                translateTransform.X = panStartX + (current.X - panStart.X);
                translateTransform.Y = panStartY + (current.Y - panStart.Y);

                DrawGrid();
                if (hasGeometry) DrawOverlays();
                UpdateStatusBar();
            }

            // Hover label on geometry line
            UpdateHoverLabel(worldX, worldY, e);
        }

        private void ViewportCanvas_MouseLeave(object sender, MouseEventArgs e)
        {
            hoverLabel.Visibility = Visibility.Collapsed;
        }

        // Cached line segments for hover hit-testing (pairs: start→end)
        private List<Point[]> flattenedSegments = null;

        private void BuildFlattenedPoints()
        {
            flattenedSegments = new List<Point[]>();
            if (geometryPath == null || geometryPath.Data == null) return;

            PathGeometry flatGeo = geometryPath.Data.GetFlattenedPathGeometry(0.5, ToleranceType.Absolute);

            foreach (PathFigure figure in flatGeo.Figures)
            {
                Point prev = figure.StartPoint;

                foreach (PathSegment seg in figure.Segments)
                {
                    List<Point> segPoints = new List<Point>();

                    if (seg is PolyLineSegment)
                    {
                        foreach (Point p in ((PolyLineSegment)seg).Points)
                            segPoints.Add(p);
                    }
                    else if (seg is LineSegment)
                    {
                        segPoints.Add(((LineSegment)seg).Point);
                    }

                    foreach (Point pt in segPoints)
                    {
                        flattenedSegments.Add(new Point[] { prev, pt });
                        prev = pt;
                    }
                }

                // Close figure: last point → start point
                if (figure.IsClosed)
                {
                    flattenedSegments.Add(new Point[] { prev, figure.StartPoint });
                }
            }
        }

        private double DistanceToSegment(Point p, Point a, Point b, out Point snap)
        {
            double dx = b.X - a.X;
            double dy = b.Y - a.Y;
            double lenSq = dx * dx + dy * dy;

            if (lenSq < 0.0001)
            {
                snap = a;
                return Math.Sqrt((p.X - a.X) * (p.X - a.X) + (p.Y - a.Y) * (p.Y - a.Y));
            }

            double t = ((p.X - a.X) * dx + (p.Y - a.Y) * dy) / lenSq;
            t = Math.Max(0, Math.Min(1, t));

            snap = new Point(a.X + t * dx, a.Y + t * dy);
            return Math.Sqrt((p.X - snap.X) * (p.X - snap.X) + (p.Y - snap.Y) * (p.Y - snap.Y));
        }

        private double DistanceToGeometry(double worldX, double worldY, out Point nearestPt)
        {
            nearestPt = new Point(worldX, worldY);
            if (flattenedSegments == null || flattenedSegments.Count == 0) return double.MaxValue;

            Point p = new Point(worldX, worldY);
            double minDist = double.MaxValue;

            foreach (Point[] seg in flattenedSegments)
            {
                Point snap;
                double d = DistanceToSegment(p, seg[0], seg[1], out snap);
                if (d < minDist)
                {
                    minDist = d;
                    nearestPt = snap;
                }
            }
            return minDist;
        }

        private void UpdateHoverLabel(double worldX, double worldY, MouseEventArgs e)
        {
            if (!hasGeometry || flattenedSegments == null)
            {
                hoverLabel.Visibility = Visibility.Collapsed;
                return;
            }

            // Check distance to geometry in screen pixels
            double hitRadiusWorld = 10.0 / scaleTransform.ScaleX;
            Point nearestPt;
            double dist = DistanceToGeometry(worldX, worldY, out nearestPt);

            if (dist <= hitRadiusWorld)
            {
                // Use the snapped point on the line for accurate coordinates
                double snapX = nearestPt.X;
                double snapY = nearestPt.Y;

                if (hasBBox3D)
                {
                    double x3D, y3D, z3D;
                    Map2DTo3D(snapX, snapY, out x3D, out y3D, out z3D);

                    hoverText.Text = string.Format(
                        "2D: ({0:F1}, {1:F1})\n3D: ({2:F1}, {3:F1}, {4:F1})",
                        snapX, snapY, x3D, y3D, z3D);
                }
                else
                {
                    hoverText.Text = string.Format("2D: ({0:F1}, {1:F1})", snapX, snapY);
                }

                Point screenPos = e.GetPosition((Grid)ViewportCanvas.Parent);
                hoverLabel.Margin = new Thickness(screenPos.X + 16, screenPos.Y - 10, 0, 0);
                hoverLabel.Visibility = Visibility.Visible;
            }
            else
            {
                hoverLabel.Visibility = Visibility.Collapsed;
            }
        }

        private void ViewportCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ZoomToFit();
        }

        private void ViewportCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (hasGeometry)
            {
                ZoomToFit();
            }
            else
            {
                DrawGrid();
            }
        }

        #endregion

        #region Toolbar Events

        private void btnZoomFit_Click(object sender, RoutedEventArgs e)
        {
            ZoomToFit();
        }

        private void btnZoomIn_Click(object sender, RoutedEventArgs e)
        {
            double viewW = ViewportCanvas.ActualWidth;
            double viewH = ViewportCanvas.ActualHeight;

            double centerX = viewW / 2.0;
            double centerY = viewH / 2.0;

            double worldX = (centerX - translateTransform.X) / scaleTransform.ScaleX;
            double worldY = (centerY - translateTransform.Y) / scaleTransform.ScaleY;

            double newScale = scaleTransform.ScaleX * 1.3;
            newScale = Math.Min(1000, newScale);

            scaleTransform.ScaleX = newScale;
            scaleTransform.ScaleY = newScale;
            translateTransform.X = centerX - worldX * newScale;
            translateTransform.Y = centerY - worldY * newScale;

            UpdateGeometryThickness();
            DrawGrid();
            if (hasGeometry) DrawOverlays();
            UpdateStatusBar();
        }

        private void btnZoomOut_Click(object sender, RoutedEventArgs e)
        {
            double viewW = ViewportCanvas.ActualWidth;
            double viewH = ViewportCanvas.ActualHeight;

            double centerX = viewW / 2.0;
            double centerY = viewH / 2.0;

            double worldX = (centerX - translateTransform.X) / scaleTransform.ScaleX;
            double worldY = (centerY - translateTransform.Y) / scaleTransform.ScaleY;

            double newScale = scaleTransform.ScaleX / 1.3;
            newScale = Math.Max(0.001, newScale);

            scaleTransform.ScaleX = newScale;
            scaleTransform.ScaleY = newScale;
            translateTransform.X = centerX - worldX * newScale;
            translateTransform.Y = centerY - worldY * newScale;

            UpdateGeometryThickness();
            DrawGrid();
            if (hasGeometry) DrawOverlays();
            UpdateStatusBar();
        }

        private void ckShowGrid_Click(object sender, RoutedEventArgs e)
        {
            showGrid = ckShowGrid.IsChecked == true;
            DrawGrid();
        }

        private void ckShowBoundBox_Click(object sender, RoutedEventArgs e)
        {
            showBoundBox = ckShowBoundBox.IsChecked == true;
            if (hasGeometry) DrawOverlays();
        }

        private void ckShowDimensions_Click(object sender, RoutedEventArgs e)
        {
            showDimensions = ckShowDimensions.IsChecked == true;
            if (hasGeometry) DrawOverlays();
        }

        private void ckFillShape_Click(object sender, RoutedEventArgs e)
        {
            fillShape = ckFillShape.IsChecked == true;
            // Redraw with fill
            if (currentPathData != null)
                DrawPathGeometry(currentPathData);
            else if (currentPointData != null)
                DrawPoints(currentPointData);
        }

        private void ckShowCorners_Click(object sender, RoutedEventArgs e)
        {
            showCorners = ckShowCorners.IsChecked == true;
            if (hasGeometry) DrawOverlays();
        }

        private void ckShowKeyPoints_Click(object sender, RoutedEventArgs e)
        {
            showKeyPoints = ckShowKeyPoints.IsChecked == true;
            if (hasGeometry) DrawOverlays();
        }

        private void btnExportImage_Click(object sender, RoutedEventArgs e)
        {
            string path = ExportImage();
            if (path != null)
                MessageBox.Show("Exported: " + path, "Export", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        #endregion

        #region Geometry Thickness Update

        private void UpdateGeometryThickness()
        {
            if (geometryPath != null)
                geometryPath.StrokeThickness = BaseStrokeThickness / scaleTransform.ScaleX;
        }

        #endregion

        #region Status Bar

        private void UpdateStatusBar()
        {
            double zoom = scaleTransform.ScaleX * 100;
            txtZoomLevel.Text = string.Format("{0:F0}%", zoom);

            if (hasGeometry)
            {
                double w = hasReal3DDimensions ? real3DWidth : (geoMaxX - geoMinX);
                double h = hasReal3DDimensions ? real3DHeight : (geoMaxY - geoMinY);
                txtBoundsInfo.Text = string.Format("W: {0:F1} mm  H: {1:F1} mm  |  Min({2:F1}, {3:F1})  Max({4:F1}, {5:F1})",
                    w, h, geoMinX, geoMinY, geoMaxX, geoMaxY);
            }
            else
            {
                txtBoundsInfo.Text = "";
            }
        }

        #endregion
    }
}
