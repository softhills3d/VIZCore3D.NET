using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIZCore3D.NET.BayBlockRotation.Data
{
    public class APM_BASE120
    {
        public string SHOP_CD { get; set; }
        public string BAY_CD { get; set; }
        public string PLATE_CD { get; set; }
        public string PLATE_DESC { get; set; }
        public string WORKTEAM_CD { get; set; }

        public System.Drawing.Point MinPoint { get; set; }
        public System.Drawing.Point MaxPoint { get; set; }

        public APM_BASE120(string shop_cd, string bay_cd, string plate_cd, string plate_desc, string workteam_cd)
        {
            SHOP_CD = shop_cd;
            BAY_CD = bay_cd;
            PLATE_CD = plate_cd;
            PLATE_DESC = plate_desc;
            WORKTEAM_CD = workteam_cd;
        }

        public static List<APM_BASE120> Get(string shop_cd, string bay_cd)
        {
            List<APM_BASE120> items = new List<APM_BASE120>();

            if (shop_cd == "C01")
            {
                if (bay_cd == "010101")
                {
                    items.Add(new APM_BASE120("C01", "010101", "UU1C05", "UU1C05", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010101", "UU5C07", "UU5C07", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010101", "UU1D05", "UU1D05", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010101", "UU1D01", "UU1D01", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010101", "UU1C03", "UU1C03", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010101", "UU1D03", "UU1D03", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010101", "UU1D07", "UU1D07", "C551W5"));
                }
                else if (bay_cd == "010102")
                {
                    items.Add(new APM_BASE120("C01", "010102", "UU2D16", "UU2D16", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010102", "UU2C14", "UU2C14", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010102", "UU2C16", "UU2C16", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010102", "UU2D14", "UU2D14", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010102", "UU2C12", "UU2C12", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010102", "UU2D08", "UU2D08", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010102", "UU2D10", "UU2D10", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010102", "UU2C08", "UU2C08", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010102", "UU2C10", "UU2C10", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010102", "UU2D12", "UU2D12", "C551W5"));
                }
                else if (bay_cd == "010103")
                {
                    items.Add(new APM_BASE120("C01", "010103", "UU3C17", "UU3C17", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010103", "UU3C23", "UU3C23", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010103", "UU3D17", "UU3D17", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010103", "UU3D21", "UU3D21", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010103", "UU3D23", "UU3D23", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010103", "UU3D19", "UU3D19", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010103", "UU3C19", "UU3C19", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010103", "UU3C21", "UU3C21", "C551W6"));
                }
                else if (bay_cd == "010104")
                {
                    items.Add(new APM_BASE120("C01", "010104", "UU4D35", "UU4D35", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010104", "UU4D31", "UU4D31", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010104", "UU4C35", "UU4C35", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010104", "UU4D33", "UU4D33", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010104", "UU4C31", "UU4C31", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010104", "UU4C33", "UU4C33", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010104", "UU4C29", "UU4C29", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010104", "UU4D29", "UU4D29", "C551W6"));
                }
                else if (bay_cd == "010105")
                {
                    items.Add(new APM_BASE120("C01", "010105", "UU5C37", "UU5C37", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010105", "UU5D41", "UU5D41", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010105", "UU5C39", "UU5C39", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010105", "UU5D39", "UU5D39", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010105", "UU5C41", "UU5C41", "C55515"));
                    items.Add(new APM_BASE120("C01", "010105", "UU5C43", "UU5C43", "C55515"));
                    items.Add(new APM_BASE120("C01", "010105", "UU5D37", "UU5D37", "C557W1"));
                }
                else if (bay_cd == "010201")
                {
                    items.Add(new APM_BASE120("C01", "010201", "FF1C02", "FF1C02", "C55211"));
                    items.Add(new APM_BASE120("C01", "010201", "FF1C01", "FF1C01", "C55211"));
                    items.Add(new APM_BASE120("C01", "010201", "FF1C04", "FF1C04", "C55211"));
                    items.Add(new APM_BASE120("C01", "010201", "FF1C10", "FF1C10", "C55211"));
                    items.Add(new APM_BASE120("C01", "010201", "FF1C03", "FF1C03", "C55211"));
                    items.Add(new APM_BASE120("C01", "010201", "FF1C06", "FF1C06", "C55211"));
                    items.Add(new APM_BASE120("C01", "010201", "FF1C07", "FF1C07", "C55211"));
                    items.Add(new APM_BASE120("C01", "010201", "FF1C09", "FF1C09", "C55211"));
                    items.Add(new APM_BASE120("C01", "010201", "FF1C08", "FF1C08", "C55211"));
                    items.Add(new APM_BASE120("C01", "010201", "FF1C05", "FF1C05", "C55211"));
                }
                else if (bay_cd == "010202")
                {
                    items.Add(new APM_BASE120("C01", "010202", "UF1A04", "UF1A04", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "UF1A13", "UF1A13", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "UF1A03", "UF1A03", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "UF1A14", "UF1A14", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "UF1A05", "UF1A05", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "UF1A07", "UF1A07", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "UF1A15", "UF1A15", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "UF1A12", "UF1A12", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "UF1A01", "UF1A01", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "UF1A08", "UF1A08", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "AF1A02", "AF1A02", "C55221"));
                    items.Add(new APM_BASE120("C01", "010202", "UF1A06", "UF1A06", "C55221"));
                }
                else if (bay_cd == "010203")
                {
                    items.Add(new APM_BASE120("C01", "010203", "UF3B22", "UF3B22", "C55512"));
                    items.Add(new APM_BASE120("C01", "010203", "UF3B20", "UF3B20", "C55511"));
                    items.Add(new APM_BASE120("C01", "010203", "UF3B18", "UF3B18", "C55511"));
                    items.Add(new APM_BASE120("C01", "010203", "UF3A20", "UF3A20", "C55511"));
                    items.Add(new APM_BASE120("C01", "010203", "UF3A24", "UF3A24", "C55512"));
                    items.Add(new APM_BASE120("C01", "010203", "UF3B24", "UF3B24", "C55512"));
                    items.Add(new APM_BASE120("C01", "010203", "UF3A22", "UF3A22", "C55512"));
                    items.Add(new APM_BASE120("C01", "010203", "UF3A18", "UF3A18", "C55511"));
                }
                else if (bay_cd == "010204")
                {
                    items.Add(new APM_BASE120("C01", "010204", "UF4A35", "UF4A35", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010204", "UF4B33", "UF4B33", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010204", "UF4A33", "UF4A33", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010204", "UF4B29", "UF4B29", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010204", "UF4B27", "UF4B27", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010204", "UF4A29", "UF4A29", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010204", "UF4B35", "UF4B35", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010204", "UF4A27", "UF4A27", "C551W2"));
                }
                else if (bay_cd == "010205")
                {
                    items.Add(new APM_BASE120("C01", "010205", "UF5A41", "UF5A41", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010205", "UF5B41", "UF5B41", "C55515"));
                    items.Add(new APM_BASE120("C01", "010205", "UF5B37", "UF5B37", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010205", "UF5A37", "UF5A37", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010205", "UF5B39", "UF5B39", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010205", "UF5A43", "UF5A43", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010205", "UF5A39", "UF5A39", "C551W2"));
                }
                else if (bay_cd == "010300")
                {
                    items.Add(new APM_BASE120("C01", "010300", "UN1E32", "UN1E32", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1E40", "UN1E40", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1F36", "UN1F36", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1E34", "UN1E34", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1F40", "UN1F40", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1F32", "UN1F32", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1E38", "UN1E38", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1F38", "UN1F38", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1E36", "UN1E36", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1F30", "UN1F30", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1E30", "UN1E30", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010300", "UN1F34", "UN1F34", "C557W1"));
                }
                else if (bay_cd == "010500")
                {
                    items.Add(new APM_BASE120("C01", "010500", "SS1A03", "SS1A03", "C551W2"));
                    items.Add(new APM_BASE120("C01", "010500", "SS1A01", "SS1A01", "C551W6"));
                    items.Add(new APM_BASE120("C01", "010500", "SS1B03", "SS1B03", "C557W1"));
                    items.Add(new APM_BASE120("C01", "010500", "SS1A05", "SS1A05", "C55515"));
                    items.Add(new APM_BASE120("C01", "010500", "SS1B01", "SS1B01", "C551W5"));
                    items.Add(new APM_BASE120("C01", "010500", "SS1B05", "SS1B05", "C55513"));
                }
            }
            else
            {

            }

            return items;
        }
    }
}
