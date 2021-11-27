using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VIZCore3D.NET.Projection2D.DrawControl
{
    /// <summary>
    /// UserControl1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PathGeometryControl : UserControl
    {
        public PathGeometryControl()
        {
            InitializeComponent();
        }

        public void DrawPathGeometry(string PATHDATA)
        {
            MyCanvas.Children.Clear();

            if (String.IsNullOrEmpty(PATHDATA) == true) return;

            Path myPath = new Path();
            myPath.Stroke = Brushes.Red;
            myPath.StrokeThickness = 1;
            myPath.Data = Geometry.Parse(PATHDATA);

            //Console.WriteLine(myPath.Data.ToString());

            MyCanvas.Children.Add(myPath);
        }

        public void DrawPoints(string Point)
        {
            MyCanvas.Children.Clear();

            if (String.IsNullOrEmpty(Point) == true) return;

            string[] Points = Point.Split(new char[] { ',' });
            string PathDataByPoints = String.Empty;

            int minX = 1000;
            int minY = 1000;

            for (int i = 0; i < Points.Length; i++)
            {
                if (i % 2 != 0) continue;

                int nX = Convert.ToInt32(Points[i]);
                int nY = Convert.ToInt32(Points[i + 1]);

                minX = Math.Min(minX, nX);
                minY = Math.Min(minY, nY);

                if (i == 0)
                {
                    PathDataByPoints = string.Format("M{0},{1}", Points[i], Points[i + 1]);
                }
                else if (i < Points.Length - 3)
                {
                    PathDataByPoints += string.Format("L{0},{1}", Points[i], Points[i + 1]);
                }
                else
                {
                    PathDataByPoints += string.Format("L{0},{1}z", Points[i], Points[i + 1]);
                }
            }

            int nMargineX = 0;
            int nMargineY = 0;

            TranslateTransform translateTransform = new TranslateTransform(0 - minX + nMargineX, 0 - minY + nMargineY);


            Path myPath = new Path();
            myPath.Stroke = Brushes.Red;
            myPath.StrokeThickness = 1;
            myPath.Data = Geometry.Parse(PathDataByPoints);
            myPath.RenderTransform = translateTransform;

            MyCanvas.Children.Clear();
            MyCanvas.Children.Add(myPath);
        }
    }
}
