using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.BayBlockRotation.Data
{
    public class Bay
    {
        /// <summary>
        /// 부서 : JBN_DIS
        /// </summary>
        public string Department { get; set; }


        /// <summary>
        /// 작업장
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 작업장코드 : UP_OBJ_ID
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 작업장 대표명
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 작업장 Desc
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// 가로 Size
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// 세로 Size
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// 크레인 능력
        /// </summary>
        public int CraneCapa { get; set; }
        /// <summary>
        /// 반출 높이 제약
        /// </summary>
        public int LimitOutHeight { get; set; }
        /// <summary>
        /// 총면적
        /// </summary>
        public int TotalArea { get; set; }
        /// <summary>
        /// 작업장 효율
        /// </summary>
        public int Efficiency { get; set; }
        /// <summary>
        /// 정반 심볼
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// SKID Y/N
        /// </summary>
        public bool SKID { get; set; }
        /// <summary>
        /// SHELTER Y/N
        /// </summary>
        public bool SHELTER { get; set; }

        /// <summary>
        /// Margine
        /// </summary>
        public System.Drawing.Point Margine { get; set; }
        /// <summary>
        /// Drawing Point
        /// </summary>
        public string Points { get; set; }
        /// <summary>
        /// Drawing Point Count
        /// </summary>
        public int PointCount { get; set; }

        /// <summary>
        /// Min Point
        /// </summary>
        public System.Drawing.Point MinPoint { get; set; }

        /// <summary>
        /// Bay Label
        /// </summary>
        public VIZCore3D.NET.Data.TextDrawingItem BayLabel { get; set; }

        /// <summary>
        /// Drawing Point (Original)
        /// </summary>
        public List<System.Drawing.Point> Point
        {
            get
            {
                List<System.Drawing.Point> pts = new List<System.Drawing.Point>();

                if (String.IsNullOrEmpty(Points) == true) return pts;

                string[] pt = Points.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (pt == null || pt.Length == 0) return pts;

                if (PointCount != pt.Length) return pts;

                for (int i = 0; i < pt.Length; i++)
                {
                    string[] vals = pt[i].Split(new char[] { ',' });

                    pts.Add(
                        new System.Drawing.Point(
                            Convert.ToInt32(vals[0])
                            , Convert.ToInt32(vals[1])
                            ));
                }

                return pts;
            }
        }

        public List<System.Drawing.Point> GetDrawingPoint()
        {
            List<System.Drawing.Point> pt = Point;
            List<System.Drawing.Point> ptf = new List<System.Drawing.Point>();

            int scale = 100; // Scale

            int minX = 100000;
            int maxY = 0;

            for (int i = 0; i < pt.Count; i++)
            {
                // 시작 위치 및 스케일 적용
                int x = (pt[i].X + Margine.X) * scale;
                int y = (-pt[i].Y - Margine.Y) * scale;

                if (i == 0)
                {
                    minX = x;
                    maxY = y;
                }
                else
                {
                    minX = Math.Min(minX, x);
                    maxY = Math.Max(maxY, y);
                }

                ptf.Add(new System.Drawing.Point(x, y));
            }

            MinPoint = new System.Drawing.Point(minX, maxY);

            return ptf;
        }

        /// <summary>
        /// 정반 개수
        /// </summary>
        public int CTI_POINT_NO { get; set; }
        /// <summary>
        /// 정반 좌표
        /// </summary>
        public string CTI_POINT { get; set; }
        /// <summary>
        /// 정반 팀 코드
        /// </summary>
        public string CTI_POINT_TYPE { get; set; }
        /// <summary>
        /// 정반 지번 코드
        /// </summary>
        public string CTI_POINT_JIBUN { get; set; }

        /// <summary>
        /// 지번 Center Point List
        /// </summary>
        public List<VIZCore3D.NET.Data.Vertex3D> JIBUN_CENTER { get; set; }

        /// <summary>
        /// 지번 Label ID List
        /// </summary>
        public List<int> JIBUN_LABEL { get; set; }

        /// <summary>
        /// Drawing Point (Original)
        /// </summary>
        public List<System.Drawing.Point> CtiPoint
        {
            get
            {
                List<System.Drawing.Point> pts = new List<System.Drawing.Point>();

                if (String.IsNullOrEmpty(CTI_POINT) == true) return pts;

                string[] pt = CTI_POINT.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (pt == null || pt.Length == 0) return pts;

                if (CTI_POINT_NO != pt.Length) return pts;

                for (int i = 0; i < pt.Length; i++)
                {
                    string[] vals = pt[i].Split(new char[] { ',' });

                    pts.Add(
                        new System.Drawing.Point(
                            Convert.ToInt32(vals[0])
                            , Convert.ToInt32(vals[1])
                            ));

                    pts.Add(
                        new System.Drawing.Point(
                            Convert.ToInt32(vals[2])
                            , Convert.ToInt32(vals[3])
                            ));
                }

                return pts;
            }
        }

        /// <summary>
        /// 지번 코드 목록 반환
        /// </summary>
        /// <returns>지번 코드 목록</returns>
        public List<string> GetJibunList()
        {
            List<string> items = new List<string>();

            if (String.IsNullOrEmpty(CTI_POINT_JIBUN) == true) return items;

            string[] vals = CTI_POINT_JIBUN.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            items.AddRange(vals.ToList());

            return items;
        }

        /// <summary>
        /// 지번 코드 목록에서 해당 인덱스의 지번코드를 반환
        /// </summary>
        /// <param name="index">인덱스</param>
        /// <returns>지번코드</returns>
        public string GetJibunCode(int index)
        {
            List<string> items = GetJibunList();

            if(items.Count == 0) return String.Format("{0}_{1}", Desc, index);
            if(items.Count < index + 1) return String.Format("{0}_{1}", Desc, index);

            return items[index];
        }

        public List<System.Drawing.Point> GetCtiDrawingPoint()
        {
            List<System.Drawing.Point> pt = CtiPoint;
            List<System.Drawing.Point> ptf = new List<System.Drawing.Point>();

            int scale = 100; // Scale

            //int minX = 100000;
            //int maxY = 0;

            for (int i = 0; i < pt.Count; i++)
            {
                // 시작 위치 및 스케일 적용
                int x = (pt[i].X + Margine.X) * scale;
                int y = (-pt[i].Y - Margine.Y) * scale;


                /*
                if (i == 0)
                {
                    minX = x;
                    maxY = y;
                }
                else
                {
                    minX = Math.Min(minX, x);
                    maxY = Math.Max(maxY, y);
                }
                */

                ptf.Add(new System.Drawing.Point(x, y));
            }

            //MinPoint = new System.Drawing.Point(minX, maxY);

            return ptf;
        }

        public Bay()
        {
            JIBUN_CENTER = new List<VIZCore3D.NET.Data.Vertex3D>();
            JIBUN_LABEL = new List<int>();
        }
    }
}
