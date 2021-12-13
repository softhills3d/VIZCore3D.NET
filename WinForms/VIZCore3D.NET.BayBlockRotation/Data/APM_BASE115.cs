using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIZCore3D.NET.BayBlockRotation.Data
{
    public class APM_BASE115
    {
        public string SHOP_CD { get; set; }
        public string BAY_CD { get; set; }
        public int VERTEX_IDX { get; set; }
        public int ST_X { get; set; }
        public int ST_Y { get; set; }

        public APM_BASE115(string shop_cd, string bay_cd, int vertex_idx, int st_x, int st_y)
        {
            SHOP_CD = shop_cd;
            BAY_CD = bay_cd;
            VERTEX_IDX = vertex_idx;
            ST_X = st_x;
            ST_Y = st_y;
        }

        public static List<System.Drawing.Point> BAY_OUTLINE_POINTS (APM_BASE110 BAY, List<APM_BASE115> items)
        {
            List<System.Drawing.Point> pt = new List<System.Drawing.Point>();

            for (int i = 0; i < items.Count; i++)
            {
                APM_BASE115 item = items[i];

                pt.Add(new System.Drawing.Point(item.ST_X, item.ST_Y));
            }

            List<System.Drawing.Point> ptf = new List<System.Drawing.Point>();

            int scale = 100; // Scale

            int minX = 100000;
            int maxY = 0;

            for (int i = 0; i < pt.Count; i++)
            {
                // 시작 위치 및 스케일 적용
                int x = (pt[i].X + BAY.OffsetX) * scale;
                int y = (-pt[i].Y - BAY.OffsetY) * scale;

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

            BAY.MinPoint = new System.Drawing.Point(minX, maxY);

            return ptf;
        }

        public static List<float> GetLength(List<System.Drawing.Point> point, float zLength, float scale)
        {
            int minX = 0;
            int minY = 0;
            int maxX = 0;
            int maxY = 0;

            for (int i = 0; i < point.Count; i++)
            {
                System.Drawing.Point pt = point[i];

                if(i == 0)
                {
                    minX = pt.X;
                    minY = pt.Y;

                    maxX = pt.X;
                    maxY = pt.Y;
                }
                else
                {
                    minX = Math.Min(minX, pt.X);
                    minY = Math.Min(minY, pt.Y);

                    maxX = Math.Max(maxX, pt.X);
                    maxY = Math.Max(maxY, pt.Y);
                }
            }

            List<float> length = new List<float>();
            length.Add((maxX - minX) * scale);
            length.Add((maxY - minY) * scale);
            length.Add(zLength);

            return length;
        }

        public static List<APM_BASE115> Get(string shop_cd, string bay_cd)
        {
            List<APM_BASE115> items = new List<APM_BASE115>();

            if(shop_cd == "C01")
            {
                if (bay_cd == "010101")
                {
                    items.Add(new APM_BASE115("C01", "010101", 1, 150, 0));
                    items.Add(new APM_BASE115("C01", "010101", 2, 630, 0));
                    items.Add(new APM_BASE115("C01", "010101", 3, 630, 400));
                    items.Add(new APM_BASE115("C01", "010101", 4, 150, 400));
                    items.Add(new APM_BASE115("C01", "010101", 5, 150, 400));
                    items.Add(new APM_BASE115("C01", "010101", 6, 0, 400));
                    items.Add(new APM_BASE115("C01", "010101", 7, 0, 280));
                    items.Add(new APM_BASE115("C01", "010101", 8, 150, 280));
                }
                else if(bay_cd == "010102")
                {
                    items.Add(new APM_BASE115("C01", "010102", 1, 0, 0));
                    items.Add(new APM_BASE115("C01", "010102", 2, 820, 0));
                    items.Add(new APM_BASE115("C01", "010102", 3, 820, 400));
                    items.Add(new APM_BASE115("C01", "010102", 4, 10, 400));
                    items.Add(new APM_BASE115("C01", "010102", 5, 10, 200));
                    items.Add(new APM_BASE115("C01", "010102", 6, 0, 200));
                }
                else if (bay_cd == "010103")
                {
                    items.Add(new APM_BASE115("C01", "010103", 1, 0, 0));
                    items.Add(new APM_BASE115("C01", "010103", 2, 640, 0  ));
                    items.Add(new APM_BASE115("C01", "010103", 3, 640, 420));
                    items.Add(new APM_BASE115("C01", "010103", 4, 0, 420));
                }
                else if (bay_cd == "010104")
                {
                    items.Add(new APM_BASE115("C01", "010104", 1, 50, 0));
                    items.Add(new APM_BASE115("C01", "010104", 2,   700,0  ));
                    items.Add(new APM_BASE115("C01", "010104", 3,   700,400));
                    items.Add(new APM_BASE115("C01", "010104", 4,   0  ,400));
                    items.Add(new APM_BASE115("C01", "010104", 5,   0  ,190));
                    items.Add(new APM_BASE115("C01", "010104", 6,   50 ,190));
                }
                else if (bay_cd == "010105")
                {
                    items.Add(new APM_BASE115("C01", "010105", 1, 0, 0));
                    items.Add(new APM_BASE115("C01","010105", 2,  720,0  ));
                    items.Add(new APM_BASE115("C01","010105", 3,  720,110));
                    items.Add(new APM_BASE115("C01","010105", 4,  570,110));
                    items.Add(new APM_BASE115("C01","010105", 5,  570,420));
                    items.Add(new APM_BASE115("C01","010105", 6,  0  ,420));
                }
                else if (bay_cd == "010201")
                {
                    items.Add(new APM_BASE115("C01", "010201", 1, 0, 0));
                    items.Add(new APM_BASE115("C01", "010201", 2, 1400, 0));
                    items.Add(new APM_BASE115("C01", "010201", 3, 1400, 180));
                    items.Add(new APM_BASE115("C01", "010201", 4, 0, 180));
                }
                else if (bay_cd == "010202")
                {
                    items.Add(new APM_BASE115("C01", "010202", 1, 0, 0));
                    items.Add(new APM_BASE115("C01", "010202", 2, 1260, 0));
                    items.Add(new APM_BASE115("C01", "010202", 3, 1260, 150));
                    items.Add(new APM_BASE115("C01", "010202", 4, 0, 150));
                }
                else if (bay_cd == "010203")
                {
                    items.Add(new APM_BASE115("C01", "010203", 1, 0,   0));
                    items.Add(new APM_BASE115("C01", "010203", 2, 800 ,    0));
                    items.Add(new APM_BASE115("C01", "010203", 3, 800 ,    340));
                    items.Add(new APM_BASE115("C01", "010203", 4, 0  , 340));
                }
                else if (bay_cd == "010204")
                {
                    items.Add(new APM_BASE115("C01", "010204", 1,   0 ,  0));
                    items.Add(new APM_BASE115("C01", "010204", 2,   800 ,    0));
                    items.Add(new APM_BASE115("C01", "010204", 3,   800 ,    340));
                    items.Add(new APM_BASE115("C01", "010204", 4,   0  , 340));
                }
                else if (bay_cd == "010205")
                {
                    items.Add(new APM_BASE115("C01", "010205", 1, 0,   0));
                    items.Add(new APM_BASE115("C01", "010205", 2, 740 ,    0));
                    items.Add(new APM_BASE115("C01", "010205", 3, 740 ,    150));
                    items.Add(new APM_BASE115("C01", "010205", 4, 560 ,    150));
                    items.Add(new APM_BASE115("C01", "010205", 5, 560  ,   340));
                    items.Add(new APM_BASE115("C01", "010205", 6, 0  , 340));
                }
                else if (bay_cd == "010300")
                {
                    items.Add(new APM_BASE115("C01", "010300", 1, 0  , 0));
                    items.Add(new APM_BASE115("C01", "010300", 2, 1100 ,   0));
                    items.Add(new APM_BASE115("C01", "010300", 3, 1100 ,   340));
                    items.Add(new APM_BASE115("C01", "010300", 4, 0  , 340));
                }
                else if (bay_cd == "010500")
                {
                    items.Add(new APM_BASE115("C01", "010500", 1, 0  , 0));
                    items.Add(new APM_BASE115("C01", "010500", 2, 1650,    0));
                    items.Add(new APM_BASE115("C01", "010500", 3, 1650,    450));
                    items.Add(new APM_BASE115("C01", "010500", 4, 0  , 450));
                }
            }
            else if(shop_cd == "C02")
            {
                if(bay_cd == "040201")
                {
                    items.Add(new APM_BASE115("C02", "040201", 1, 0, 0));
                    items.Add(new APM_BASE115("C02", "040201", 2, 80, 0));
                    items.Add(new APM_BASE115("C02", "040201", 3, 80, 20));
                    items.Add(new APM_BASE115("C02", "040201", 4, 0, 20));
                }
                else if (bay_cd == "040202")
                {
                    items.Add(new APM_BASE115("C02", "040202", 1, 0, 0));
                    items.Add(new APM_BASE115("C02", "040202", 2, 80, 0 ));
                    items.Add(new APM_BASE115("C02", "040202", 3, 80, 20));
                    items.Add(new APM_BASE115("C02", "040202", 4, 0 , 20));
                }
                else if (bay_cd == "040203")
                {
                    items.Add(new APM_BASE115("C02", "040203", 1, 0 ,  0));
                    items.Add(new APM_BASE115("C02", "040203", 2, 118  ,   0));
                    items.Add(new APM_BASE115("C02", "040203", 3, 118   ,  18));
                    items.Add(new APM_BASE115("C02", "040203", 4, 0   ,18));
                }
                else if (bay_cd == "040205")
                {
                    items.Add(new APM_BASE115("C02", "040205", 1, 13, 28));
                    items.Add(new APM_BASE115("C02", "040205", 2, 13,0 ));
                    items.Add(new APM_BASE115("C02", "040205", 3, 73,0 ));
                    items.Add(new APM_BASE115("C02", "040205", 4, 73,43));
                    items.Add(new APM_BASE115("C02", "040205", 5, 0 ,43));
                    items.Add(new APM_BASE115("C02", "040205", 6, 0 ,28));
                }
                else if (bay_cd == "040530")
                {
                    items.Add(new APM_BASE115("C02", "040530", 1, 0 ,0));
                    items.Add(new APM_BASE115("C02", "040530", 2, 40,0));
                    items.Add(new APM_BASE115("C02", "040530", 3, 40,20));
                    items.Add(new APM_BASE115("C02", "040530", 4, 0 ,20));
                }
                else if (bay_cd == "040700")
                {
                    items.Add(new APM_BASE115("C02", "040700", 1, 0, 0));
                    items.Add(new APM_BASE115("C02", "040700", 2, 40, 0 ));
                    items.Add(new APM_BASE115("C02", "040700", 3, 40, 80));
                    items.Add(new APM_BASE115("C02", "040700", 4, 0 , 80));
                }
                else if (bay_cd == "040920")
                {
                    items.Add(new APM_BASE115("C02", "040920", 1, 0 ,0 ));
                    items.Add(new APM_BASE115("C02", "040920", 2, 80,0 ));
                    items.Add(new APM_BASE115("C02", "040920", 3, 80,28));
                    items.Add(new APM_BASE115("C02", "040920", 4, 0 ,28));
                }
                else if (bay_cd == "040930")
                {
                    items.Add(new APM_BASE115("C02", "040930", 1, 0, 0));
                    items.Add(new APM_BASE115("C02", "040930", 2,  80,0 ));
                    items.Add(new APM_BASE115("C02", "040930", 3,  80,28));
                    items.Add(new APM_BASE115("C02", "040930", 4,  0 ,28));
                }
            }
            else if(shop_cd == "C03")
            {
                if (bay_cd == "210100")
                {
                    items.Add(new APM_BASE115("C03", "210100", 1, 0, 0));
                    items.Add(new APM_BASE115("C03", "210100", 2, 29,0 ));
                    items.Add(new APM_BASE115("C03", "210100", 3, 29,44));
                    items.Add(new APM_BASE115("C03", "210100", 4, 0 ,44));
                }
                else if (bay_cd == "210200")
                {
                    items.Add(new APM_BASE115("C03", "210200", 1, 0, 0));
                    items.Add(new APM_BASE115("C03", "210200", 2, 79,0 ));
                    items.Add(new APM_BASE115("C03", "210200", 3, 79,22));
                    items.Add(new APM_BASE115("C03", "210200", 4, 0 ,22));
                }
                else if (bay_cd == "210300")
                {
                    items.Add(new APM_BASE115("C03", "210300", 1, 0  , 0));
                    items.Add(new APM_BASE115("C03", "210300", 2, 145,     0));
                    items.Add(new APM_BASE115("C03", "210300", 3, 145  ,   21));
                    items.Add(new APM_BASE115("C03", "210300", 4, 0  , 21));
                }
                else if (bay_cd == "210302")
                {
                    items.Add(new APM_BASE115("C03", "210302", 1, 0, 0));
                    items.Add(new APM_BASE115("C03", "210302", 2, 80,0 ));
                    items.Add(new APM_BASE115("C03", "210302", 3, 80,22));
                    items.Add(new APM_BASE115("C03", "210302", 4, 0 ,22));
                }
                else if (bay_cd == "210401")
                {
                    items.Add(new APM_BASE115("C03", "210401", 1, 0, 0));
                    items.Add(new APM_BASE115("C03", "210401", 2, 126,0 ));
                    items.Add(new APM_BASE115("C03", "210401", 3, 126,16));
                    items.Add(new APM_BASE115("C03", "210401", 4, 0  ,16));
                }
                else if (bay_cd == "210402")
                {
                    items.Add(new APM_BASE115("C03", "210402", 1, 0, 0));
                    items.Add(new APM_BASE115("C03", "210402", 2, 74,0 ));
                    items.Add(new APM_BASE115("C03", "210402", 3, 74,21));
                    items.Add(new APM_BASE115("C03", "210402", 4, 0 ,21));
                }
                else if (bay_cd == "210403")
                {
                    items.Add(new APM_BASE115("C03", "210403", 1, 0 , 21));
                    items.Add(new APM_BASE115("C03", "210403", 2, 0 , 0 ));
                    items.Add(new APM_BASE115("C03", "210403", 3, 54, 0 ));
                    items.Add(new APM_BASE115("C03", "210403", 4, 54, 21));
                }
                else if (bay_cd == "210500")
                {
                    items.Add(new APM_BASE115("C03", "210500", 1, 0, 0));
                    items.Add(new APM_BASE115("C03", "210500", 2, 54,0 ));
                    items.Add(new APM_BASE115("C03", "210500", 3, 54,21));
                    items.Add(new APM_BASE115("C03", "210500", 4, 0 ,21));
                }
                else if (bay_cd == "210501")
                {
                    items.Add(new APM_BASE115("C03", "210501", 1, 0, 0));
                    items.Add(new APM_BASE115("C03", "210501", 2, 68,0 ));
                    items.Add(new APM_BASE115("C03", "210501", 3, 68,44));
                    items.Add(new APM_BASE115("C03", "210501", 4, 0 ,44));
                }
                else if (bay_cd == "210502")
                {
                    items.Add(new APM_BASE115("C03", "210502", 1, 0 ,43));
                    items.Add(new APM_BASE115("C03", "210502", 2, 0 ,0 ));
                    items.Add(new APM_BASE115("C03", "210502", 3, 74,0 ));
                    items.Add(new APM_BASE115("C03", "210502", 4, 74, 43));
                }
                else if (bay_cd == "210503")
                {
                    items.Add(new APM_BASE115("C03", "210503", 1, 0, 0));
                    items.Add(new APM_BASE115("C03", "210503", 2, 71, 0 ));
                    items.Add(new APM_BASE115("C03", "210503", 3, 71, 23));
                    items.Add(new APM_BASE115("C03", "210503", 4, 0 , 23));
                }
                else if (bay_cd == "210700")
                {
                    items.Add(new APM_BASE115("C03", "210700", 1, 0, 0));
                    items.Add(new APM_BASE115("C03", "210700", 2, 52,0 ));
                    items.Add(new APM_BASE115("C03", "210700", 3, 52,18));
                    items.Add(new APM_BASE115("C03", "210700", 4, 0 ,18));
                }
            }
            else
            {

            }

            return items;
        }
    }
}
