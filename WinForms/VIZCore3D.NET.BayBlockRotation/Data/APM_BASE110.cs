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
            else if(shop_cd == "C02")
            {
                items.Add(new APM_BASE110("C02", "040201", "JF12", 1634, 376));
                items.Add(new APM_BASE110("C02", "040202", "JF22", 802, 380));
                items.Add(new APM_BASE110("C02", "040203", "JF11", 1263, 683));
                items.Add(new APM_BASE110("C02", "040205", "JF3", 16, 390));
                items.Add(new APM_BASE110("C02", "040530", "JF", 852, 684));
                items.Add(new APM_BASE110("C02", "040700", "T/O", 2528, 50));
                items.Add(new APM_BASE110("C02", "040920", "JU2", 800,60));
                items.Add(new APM_BASE110("C02", "040930", "JU3", 1637, 55));
            }
            else if(shop_cd == "C03")
            {
                items.Add(new APM_BASE110("C03", "210100", "가공작업장", 29, 529));
                items.Add(new APM_BASE110("C03", "210200", "선상가열작업장", 2377, 33));
                items.Add(new APM_BASE110("C03", "210300", "U1", 28, 36));
                items.Add(new APM_BASE110("C03", "210302", "U12", 1556, 33));
                items.Add(new APM_BASE110("C03", "210401", "U21", 26, 316));
                items.Add(new APM_BASE110("C03", "210402", "U22", 1575, 283));
                items.Add(new APM_BASE110("C03", "210403", "U23", 2378, 284));
                items.Add(new APM_BASE110("C03", "210500", "U3", 2378, 540));
                items.Add(new APM_BASE110("C03", "210501", "U31", 793, 540));
                items.Add(new APM_BASE110("C03", "210502", "U32", 1560, 539));
                items.Add(new APM_BASE110("C03", "210503", "U33", 2398, 749));
                items.Add(new APM_BASE110("C03", "210700", "옥외평중조장", 954, 998));
            }

            return items;
        }
    }
}
