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

        // Options
        private bool showGrid = true;
        private bool showBoundBox = false;
        private bool showDimensions = true;
        private bool fillShape = false;

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
        /// Draw WPF PathGeometry string with real 3D dimensions
        /// </summary>
        public void DrawPathGeometry(string PATHDATA, double realWidth, double realHeight)
        {
            real3DWidth = realWidth;
            real3DHeight = realHeight;
            hasReal3DDimensions = (realWidth > 0 && realHeight > 0);
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
