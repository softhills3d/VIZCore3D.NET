using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIZCore3D.NET.BayBlockRotation.Data
{
    public class APM_BASE110
    {
        public string SHOP_CD { get; set; }
        public string BAY_CD { get; set; }
        public string BAY_DESC { get; set; }

        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public VIZCore3D.NET.Data.TextDrawingItem BayLabel { get; set; }

        /// <summary>
        /// Min Point
        /// </summary>
        public System.Drawing.Point MinPoint { get; set; }

        public APM_BASE110(string shop_cd, string bay_cd, string bay_desc, int offsetX, int offsetY)
        {
            SHOP_CD = shop_cd;
            BAY_CD = bay_cd;
            BAY_DESC = bay_desc;

            OffsetX = offsetX;
            OffsetY = offsetY;
            BayLabel = null;
        }

        public static List<APM_BASE110> Get(string shop_cd)
        {
            List<APM_BASE110> items = new List<APM_BASE110>();

            if(shop_cd == "C01")
            {
                items.Add(new APM_BASE110("C01", "010101", "U1", 23, 501));
                items.Add(new APM_BASE110("C01", "010102", "U2", 737, 498));
                items.Add(new APM_BASE110("C01", "010103", "U3", 1645,  486));
                items.Add(new APM_BASE110("C01", "010104", "U4", 19, 1038));
                items.Add(new APM_BASE110("C01", "010105", "U5", 799, 1030));
                items.Add(new APM_BASE110("C01", "010201", "SKID", 23, 259));
                items.Add(new APM_BASE110("C01", "010202", "FIX", 23, 39));
                items.Add(new APM_BASE110("C01", "010203", "F3", 1460, 49));
                items.Add(new APM_BASE110("C01", "010204", "F4", 2323, 47));
                items.Add(new APM_BASE110("C01", "010205", "F5", 2366, 529));
                items.Add(new APM_BASE110("C01", "010300", "N", 1609, 1086));
                items.Add(new APM_BASE110("C01", "010500", "S", 27, 1508));
            }
            

            return items;
        }
    }
}
