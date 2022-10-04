using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VIZCore3D.NET.BayBlock
{
    public class BlockOutlinePath
    {
        public enum BlockOutlineDrawKind
        {
            BLOCK = 0,  //Block Item 맞춤
            VIEW,       //Model View 비율을 Block item 크기비율로 맞춤
            VIEWSCALE   //Model View에서 Model과 Block을 1:1 크기로 맞춤
        };

        // 기본 데이터
        public string SHIP_NO { get; set; }
        public string BLOCK { get; set; }
        public List<System.Drawing.Point> PATHDATA { get; set; }

        // 그리기 데이터
        public string PATHGEOMETRY { get; set; }
        public float LENGTH { get; set; }
        public float WIDTH { get; set; }
        public float HEIGHT { get; set; }

        public string DESC { get; set; }

        
        // 그리기 옵션
        public int FontSize { get; set; }
        public System.Drawing.Color FontColor { get; set; }
        public System.Drawing.Color FillColor { get; set; }
        public System.Drawing.Color BackColor { get; set; }

        public System.Drawing.Point Position { get; set; }
        public System.Drawing.Size BlockItemSize { get; set; }
        public System.Drawing.Point MaxPoint { get; set; }
        public System.Drawing.Point MinPoint { get; set; }
        public System.Drawing.Point CenterPoint { get; set; }
        public float Zoom { get; set; }         // World 크기
        public float ZoomRatio { get; set; }    //그리기 데이터 실제 크기
        public System.Drawing.SizeF ScreenSize { get; set; } //Model View Screen Size

        public BlockOutlineDrawKind drawKind { get; set; }

        public bool Visible { get; set; }
        public System.Drawing.Rectangle ItemRectangle { get; set; }
        public bool ShowItemRectangle { get; set; }
        public bool Focused { get; set; }

        public BlockOutlinePath(string name, string pathData, float length, float width, float height, System.Drawing.Size drawSize)
        {
            FontSize = 10;
            FontColor = System.Drawing.Color.Black;
            FillColor = System.Drawing.Color.Gray;
            BackColor = System.Drawing.Color.White;
            ShowItemRectangle = true;
            Focused = false;

            SHIP_NO = "0000";
            BLOCK = name;
            PATHGEOMETRY = pathData;
            LENGTH = length;
            WIDTH = width;
            HEIGHT = height;

            // 가변 데이터
            BlockItemSize = drawSize;

            // 데이터 정리
            MaxPoint = new System.Drawing.Point(0, 0);
            MinPoint = new System.Drawing.Point(0, 0);
            CenterPoint = new System.Drawing.Point(0, 0);
            Zoom = 1.0f;
            ZoomRatio = 1.0f;

            string str = PATHGEOMETRY.Substring(1);
            str = str.Substring(0, str.Length - 1);

            string[] path = str.Split(new char[] { 'L' }, StringSplitOptions.RemoveEmptyEntries);

            List<System.Drawing.Point> pathList = new List<System.Drawing.Point>();

            for (int i = 0; i < path.Length; i++)
            {
                string[] point = path[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                System.Drawing.Point cpoint = new System.Drawing.Point(Convert.ToInt32(point[0]), Convert.ToInt32(point[1]));
                pathList.Add(cpoint);

                if (i == 0)
                {
                    // 최대값
                    MaxPoint = new System.Drawing.Point(cpoint.X, cpoint.Y);

                    // 최소 값
                    MinPoint = new System.Drawing.Point(cpoint.X, cpoint.Y);
                }
                else
                {
                    int mx = Math.Max(cpoint.X, MaxPoint.X);
                    int my = Math.Max(cpoint.Y, MaxPoint.Y);

                    // 최대값
                    MaxPoint = new System.Drawing.Point(mx, my);

                    // 최소 값
                    int minX = Math.Min(cpoint.X, MinPoint.X);
                    int minY = Math.Min(cpoint.Y, MinPoint.Y);
                    MinPoint = new System.Drawing.Point(minX, minY);
                }
            }

            PATHDATA = pathList;

            // Scale 계산
            float rMax = Math.Max(LENGTH, WIDTH);
            float pMax = Math.Max(MaxPoint.X, MaxPoint.Y);
            
            ZoomRatio = rMax;

            //drawKind = BlockOutlineDrawKind.BLOCK;
            //drawKind = BlockOutlineDrawKind.VIEW;
            drawKind = BlockOutlineDrawKind.VIEWSCALE;

            ScreenSize = new System.Drawing.SizeF(0, 0);

            CenterPoint = new System.Drawing.Point((MaxPoint.X + MinPoint.X) / 2, (MaxPoint.Y + MinPoint.Y) / 2);
        }

        /// <summary>
        /// 그리기 포인트 반환
        /// </summary>
        /// <returns></returns>
        public System.Drawing.PointF[] GetDrawPoint()
        {
            // Scale 설정
            float currentScale = BlockItemSize.Width;
            float pMax = Math.Max(MaxPoint.X, MaxPoint.Y);
            float drawScale = currentScale / pMax;
            float currentDrawScale = 1.0f / pMax;


            System.Drawing.PointF centerOffset = new System.Drawing.PointF(CenterPoint.X, CenterPoint.Y);
            if (drawKind == BlockOutlineDrawKind.BLOCK)
            {
                centerOffset.X = (centerOffset.X * drawScale);
                centerOffset.Y = (centerOffset.Y * drawScale);
            }
            else if (drawKind == BlockOutlineDrawKind.VIEW)
            {
                //View
                //현재 화면 비율을 Block 크기 비율로 변경하여 그리기
                centerOffset.X = (centerOffset.X * (ZoomRatio / Zoom));
                centerOffset.Y = (centerOffset.Y * (ZoomRatio / Zoom));
            }
            else //if (drawKind == BlockOutlineDrawKind.VIEWSCALE)
            {
                centerOffset.X = (centerOffset.X * currentDrawScale) * (ZoomRatio / Zoom) * ScreenSize.Width;
                centerOffset.Y = (centerOffset.Y * currentDrawScale) * (ZoomRatio / Zoom) * ScreenSize.Width;
            }

            //draw Point추가
            List<System.Drawing.PointF> drawPoint = new List<System.Drawing.PointF>();
            for (int i = 0; i < PATHDATA.Count; i++)
            {
                System.Drawing.Point orgPt = PATHDATA[i];
                System.Drawing.PointF newPt = new System.Drawing.PointF(orgPt.X, orgPt.Y);
                
                if (drawKind == BlockOutlineDrawKind.BLOCK)
                {
                    newPt.X = (newPt.X * drawScale);
                    newPt.Y = (newPt.Y * drawScale);
                }
                else if (drawKind == BlockOutlineDrawKind.VIEW)
                {
                    //View
                    //현재 화면 비율을 Block 크기 비율로 변경하여 그리기
                    newPt.X = (newPt.X * (ZoomRatio / Zoom));
                    newPt.Y = (newPt.Y * (ZoomRatio / Zoom));
                }
                else //if (drawKind == BlockOutlineDrawKind.VIEWSCALE)
                {
                    newPt.X = (newPt.X * currentDrawScale) * (ZoomRatio / Zoom) * ScreenSize.Width;
                    newPt.Y = (newPt.Y * currentDrawScale) * (ZoomRatio / Zoom) * ScreenSize.Width;
                }

                //Center 보정
                {
                    newPt.X += (BlockItemSize.Width / 2) - centerOffset.X;
                    newPt.Y += (BlockItemSize.Height / 2) - centerOffset.Y;
                }
                drawPoint.Add(newPt);
            }

            return drawPoint.ToArray();
        }

        public string GetLabel()
        {
            return string.Format("{0}-{1}", SHIP_NO, BLOCK);
        }

        public void Draw(System.Drawing.Graphics g, int scrollbarValue)
        {
            // 상태 변경
            Visible = true;

            // 외곽 테두리 그리기
            ItemRectangle = new System.Drawing.Rectangle(
                Position.X
                , Position.Y - scrollbarValue
                , BlockItemSize.Width
                , BlockItemSize.Height
                );

            if (ShowItemRectangle == true)
            {
                g.DrawRectangle(
                    System.Drawing.Pens.Black
                    , ItemRectangle
                    );
            }

            if (Focused == true)
                g.FillRectangle(System.Drawing.Brushes.Yellow, ItemRectangle);

            System.Drawing.PointF[] drawPoint = GetDrawPoint();
            for (int i = 0; i < drawPoint.Length; i++)
            {
                //위치보정
                drawPoint[i].X += Position.X;
                drawPoint[i].Y += Position.Y - scrollbarValue;

                //외곽 테두리 넘는 것을 방지.
                drawPoint[i].X = Math.Max(drawPoint[i].X, ItemRectangle.Left);
                drawPoint[i].X = Math.Min(drawPoint[i].X, ItemRectangle.Right);

                drawPoint[i].Y = Math.Max(drawPoint[i].Y, ItemRectangle.Top);
                drawPoint[i].Y = Math.Min(drawPoint[i].Y, ItemRectangle.Bottom);
            }

            if (drawPoint.Length > 0)
            {
                g.DrawPolygon(System.Drawing.Pens.Black, drawPoint);
                g.FillPolygon(System.Drawing.Brushes.Lime, drawPoint);
            }

            // 텍스트 그리기
            // Create font and brush.
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", FontSize);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(FontColor);

            // Create point for upper-left corner of drawing.
            //float x = 10 + Position.X;
            //float y = 10 + Position.Y - scrollbarValue;

            // Set format of string.
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            drawFormat.FormatFlags = System.Drawing.StringFormatFlags.DisplayFormatControl;
            drawFormat.LineAlignment = System.Drawing.StringAlignment.Center;
            drawFormat.Alignment = System.Drawing.StringAlignment.Center;

            // Draw string to screen.
            g.DrawString(String.IsNullOrEmpty(DESC) == false ? DESC : string.Format("{0}-{1}", SHIP_NO, BLOCK), drawFont, drawBrush, ItemRectangle, drawFormat);
        }
    }
}
