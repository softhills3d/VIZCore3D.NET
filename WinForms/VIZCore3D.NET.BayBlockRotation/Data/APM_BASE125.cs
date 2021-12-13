using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIZCore3D.NET.BayBlockRotation.Data
{
    public class APM_BASE125
    {
        public string SHOP_CD { get; set; }
        public string BAY_CD { get; set; }
        public string PLATE_CD { get; set; }
        public int PLATE_ST_X { get; set; }
        public int PLATE_ST_Y { get; set; }

        public APM_BASE125(string shop_cd, string bay_cd, string plate_cd, int x, int y)
        {
            SHOP_CD = shop_cd;
            BAY_CD = bay_cd;
            PLATE_CD = plate_cd;
            PLATE_ST_X = x;
            PLATE_ST_Y = y;
        }

        public static List<APM_BASE125> Get(string shop_cd, string bay_cd, string plate_cd)
        {
            List<APM_BASE125> items = new List<APM_BASE125>();

            if (shop_cd == "C01")
            {
                if(bay_cd == "010101")
                {
                    if(plate_cd == "UU1C03")
                    {
                        items.Add(new APM_BASE125("C01", "010101", "UU1C03", 150, 0));
                        items.Add(new APM_BASE125("C01", "010101", "UU1C03", 310, 0));
                        items.Add(new APM_BASE125("C01", "010101", "UU1C03", 310, 200));
                        items.Add(new APM_BASE125("C01", "010101", "UU1C03", 150, 200));
                    }
                    else if (plate_cd == "UU1C05")
                    {
                        items.Add(new APM_BASE125("C01", "010101", "UU1C05", 310, 0));
                        items.Add(new APM_BASE125("C01", "010101", "UU1C05", 470, 0));
                        items.Add(new APM_BASE125("C01", "010101", "UU1C05", 470, 200));
                        items.Add(new APM_BASE125("C01", "010101", "UU1C05", 310, 200));
                    }
                    else if (plate_cd == "UU1C07")
                    {
                        items.Add(new APM_BASE125("C01", "010101", "UU1C07", 470, 0));
                        items.Add(new APM_BASE125("C01", "010101", "UU1C07", 630, 0));
                        items.Add(new APM_BASE125("C01", "010101", "UU1C07", 630, 200));
                        items.Add(new APM_BASE125("C01", "010101", "UU1C07", 470, 200));
                    }
                    else if (plate_cd == "UU1D01")
                    {
                        items.Add(new APM_BASE125("C01", "010101", "UU1D01", 0, 280));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D01", 150, 280));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D01", 150, 400));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D01", 0, 400));
                    }
                    else if (plate_cd == "UU1D03")
                    {
                        items.Add(new APM_BASE125("C01", "010101", "UU1D03", 150, 200));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D03", 310, 200));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D03", 310, 400));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D03", 150, 400));
                    }
                    else if (plate_cd == "UU1D05")
                    {
                        items.Add(new APM_BASE125("C01", "010101", "UU1D05", 310, 200));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D05", 470, 200));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D05", 470, 400));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D05", 310, 400));
                    }
                    else if (plate_cd == "UU1D07")
                    {
                        items.Add(new APM_BASE125("C01", "010101", "UU1D07", 470, 200));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D07", 630, 200));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D07", 630, 400));
                        items.Add(new APM_BASE125("C01", "010101", "UU1D07", 470, 400));
                    }
                    else
                    {

                    }
                }
                else if (bay_cd == "010102")
                {
                    if(plate_cd == "UU2C08")
                    {
                        items.Add(new APM_BASE125("C01", "010102", "UU2C08", 0, 0));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C08", 170, 0));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C08", 170, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C08", 0, 200));
                    }
                    else if(plate_cd == "UU2C10")
                    {
                        items.Add(new APM_BASE125("C01", "010102", "UU2C10", 170, 0));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C10", 340, 0));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C10", 340, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C10", 170, 200));
                    }
                    else if (plate_cd == "UU2C12")
                    {
                        items.Add(new APM_BASE125("C01", "010102", "UU2C12", 340, 0));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C12", 500, 0));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C12", 500, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C12", 340, 200));
                    }
                    else if (plate_cd == "UU2C14")
                    {
                        items.Add(new APM_BASE125("C01", "010102", "UU2C14", 500, 0));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C14", 660, 0));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C14", 660, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C14", 500, 200));
                    }
                    else if (plate_cd == "UU2C16")
                    {
                        items.Add(new APM_BASE125("C01", "010102", "UU2C16", 660, 0));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C16", 820, 0));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C16", 820, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2C16", 660, 200));
                    }
                    else if (plate_cd == "UU2D08")
                    {
                        items.Add(new APM_BASE125("C01", "010102", "UU2D08", 10, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D08", 170, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D08", 170, 400));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D08", 10, 400));
                    }
                    else if (plate_cd == "UU2D10")
                    {
                        items.Add(new APM_BASE125("C01", "010102", "UU2D10", 170, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D10", 340, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D10", 340, 400));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D10", 170, 400));
                    }
                    else if (plate_cd == "UU2D12")
                    {
                        items.Add(new APM_BASE125("C01", "010102", "UU2D12", 340, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D12", 500, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D12", 500, 400));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D12", 340, 400));
                    }
                    else if (plate_cd == "UU2D14")
                    {
                        items.Add(new APM_BASE125("C01", "010102", "UU2D14", 500, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D14", 660, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D14", 660, 400));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D14", 500, 400));
                    }
                    else if (plate_cd == "UU2D16")
                    {
                        items.Add(new APM_BASE125("C01", "010102", "UU2D16", 660, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D16", 820, 200));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D16", 820, 400));
                        items.Add(new APM_BASE125("C01", "010102", "UU2D16", 660, 400));
                    }
                    else
                    { }
                }
                else if (bay_cd == "010103")
                {
                    if (plate_cd == "UU3C17")
                    {
                        items.Add(new APM_BASE125("C01", "010103", "UU3C17", 0, 0));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C17", 160, 0));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C17", 160, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C17", 0, 210));
                    }
                    else if (plate_cd == "UU3C19")
                    {
                        items.Add(new APM_BASE125("C01", "010103", "UU3C19", 160, 0));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C19", 320, 0));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C19", 320, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C19", 160, 210));
                    }
                    else if (plate_cd == "UU3C21")
                    {
                        items.Add(new APM_BASE125("C01", "010103", "UU3C21", 320, 0));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C21", 480, 0));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C21", 480, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C21", 320, 210));
                    }
                    else if (plate_cd == "UU3C23")
                    {
                        items.Add(new APM_BASE125("C01", "010103", "UU3C23", 480, 0));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C23", 640, 0));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C23", 640, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3C23", 480, 210));
                    }
                    else if (plate_cd == "UU3D17")
                    {
                        items.Add(new APM_BASE125("C01", "010103", "UU3D17", 0, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D17", 160, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D17", 160, 420));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D17", 0, 420));
                    }
                    else if (plate_cd == "UU3D19")
                    {
                        items.Add(new APM_BASE125("C01", "010103", "UU3D19", 160, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D19", 320, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D19", 320, 420));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D19", 160, 420));
                    }
                    else if (plate_cd == "UU3D21")
                    {
                        items.Add(new APM_BASE125("C01", "010103", "UU3D21", 320, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D21", 480, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D21", 480, 420));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D21", 320, 420));
                    }
                    else if (plate_cd == "UU3D23")
                    {
                        items.Add(new APM_BASE125("C01", "010103", "UU3D23", 480, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D23", 640, 210));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D23", 640, 420));
                        items.Add(new APM_BASE125("C01", "010103", "UU3D23", 480, 420));
                    }
                    else
                    { }
                }
                else if (bay_cd == "010104")
                {
                    if (plate_cd == "UU4C29")
                    {
                        items.Add(new APM_BASE125("C01", "010104", "UU4C29", 50, 0));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C29", 210, 0));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C29", 210, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C29", 50, 190));
                    }
                    else if (plate_cd == "UU4C31")
                    {
                        items.Add(new APM_BASE125("C01", "010104", "UU4C31", 210, 0));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C31", 370, 0));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C31", 370, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C31", 210, 190));
                    }
                    else if (plate_cd == "UU4C33")
                    {
                        items.Add(new APM_BASE125("C01", "010104", "UU4C33", 370, 0));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C33", 530, 0));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C33", 530, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C33", 370, 190));
                    }
                    else if (plate_cd == "UU4C35")
                    {
                        items.Add(new APM_BASE125("C01", "010104", "UU4C35", 530, 0));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C35", 700, 0));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C35", 700, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4C35", 530, 190));
                    }
                    else if (plate_cd == "UU4D29")
                    {
                        items.Add(new APM_BASE125("C01", "010104", "UU4D29", 0, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D29", 170, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D29", 170, 400));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D29", 0, 400));
                    }
                    else if (plate_cd == "UU4D31")
                    {
                        items.Add(new APM_BASE125("C01", "010104", "UU4D31", 170, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D31", 340, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D31", 340, 400));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D31", 170, 400));
                    }
                    else if (plate_cd == "UU4D33")
                    {
                        items.Add(new APM_BASE125("C01", "010104", "UU4D33", 340, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D33", 520, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D33", 520, 400));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D33", 340, 400));
                    }
                    else if (plate_cd == "UU4D35")
                    {
                        items.Add(new APM_BASE125("C01", "010104", "UU4D35", 520, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D35", 700, 190));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D35", 700, 400));
                        items.Add(new APM_BASE125("C01", "010104", "UU4D35", 520, 400));
                    }
                    else
                    { }
                }
                else if (bay_cd == "010105")
                {
                    if (plate_cd == "UU5C37")
                    {
                        items.Add(new APM_BASE125("C01", "010105", "UU5C37", 0, 0));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C37", 190, 0));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C37", 190, 210));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C37", 0, 210));
                    }
                    else if (plate_cd == "UU5C39")
                    {
                        items.Add(new APM_BASE125("C01", "010105", "UU5C39", 190, 0));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C39", 380, 0));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C39", 380, 210));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C39", 190, 210));
                    }
                    else if (plate_cd == "UU5C41")
                    {
                        items.Add(new APM_BASE125("C01", "010105", "UU5C41", 380, 0));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C41", 570, 0));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C41", 570, 210));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C41", 380, 210));
                    }
                    else if (plate_cd == "UU5C43")
                    {
                        items.Add(new APM_BASE125("C01", "010105", "UU5C43", 570, 0));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C43", 720, 0));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C43", 720, 110));
                        items.Add(new APM_BASE125("C01", "010105", "UU5C43", 570, 110));
                    }
                    else if (plate_cd == "UU5D37")
                    {
                        items.Add(new APM_BASE125("C01", "010105", "UU5D37", 0, 210));
                        items.Add(new APM_BASE125("C01", "010105", "UU5D37", 190, 210));
                        items.Add(new APM_BASE125("C01", "010105", "UU5D37", 190, 420));
                        items.Add(new APM_BASE125("C01", "010105", "UU5D37", 0, 420));
                    }
                    else if (plate_cd == "UU5D39")
                    {
                        items.Add(new APM_BASE125("C01", "010105", "UU5D39", 190, 210));
                        items.Add(new APM_BASE125("C01", "010105", "UU5D39", 380, 210));
                        items.Add(new APM_BASE125("C01", "010105", "UU5D39", 380, 420));
                        items.Add(new APM_BASE125("C01", "010105", "UU5D39", 190, 420));
                    }
                    else if (plate_cd == "UU5D41")
                    {
                        items.Add(new APM_BASE125("C01", "010105", "UU5D41", 380, 210));
                        items.Add(new APM_BASE125("C01", "010105", "UU5D41", 570, 210));
                        items.Add(new APM_BASE125("C01", "010105", "UU5D41", 570, 420));
                        items.Add(new APM_BASE125("C01", "010105", "UU5D41", 380, 420));
                    }
                    else
                    { }
                }
                else if (bay_cd == "010201")
                {
                    if (plate_cd == "FF1C01")
                    {
                        items.Add(new APM_BASE125("C01", "010201", "FF1C01", 0, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C01", 140, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C01", 140, 180));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C01", 0, 180));
                    }
                    else if (plate_cd == "FF1C02")
                    {
                        items.Add(new APM_BASE125("C01", "010201", "FF1C02", 140, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C02", 280, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C02", 280, 180));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C02", 140, 180));
                    }
                    else if (plate_cd == "FF1C03")
                    {
                        items.Add(new APM_BASE125("C01", "010201", "FF1C03", 280, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C03", 420, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C03", 420, 180));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C03", 280, 180));
                    }
                    else if (plate_cd == "FF1C04")
                    {
                        items.Add(new APM_BASE125("C01", "010201", "FF1C04", 420, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C04", 560, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C04", 560, 180));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C04", 420, 180));
                    }
                    else if (plate_cd == "FF1C05")
                    {
                        items.Add(new APM_BASE125("C01", "010201", "FF1C05", 560, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C05", 700, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C05", 700, 180));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C05", 660, 180));
                    }
                    else if (plate_cd == "FF1C06")
                    {
                        items.Add(new APM_BASE125("C01", "010201", "FF1C06", 700, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C06", 840, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C06", 840, 180));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C06", 700, 180));
                    }
                    else if (plate_cd == "FF1C07")
                    {
                        items.Add(new APM_BASE125("C01", "010201", "FF1C07", 840, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C07", 980, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C07", 980, 180));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C07", 840, 180));
                    }
                    else if (plate_cd == "FF1C08")
                    {
                        items.Add(new APM_BASE125("C01", "010201", "FF1C08", 980, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C08", 1130, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C08", 1130, 180));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C08", 980, 180));
                    }
                    else if (plate_cd == "FF1C09")
                    {
                        items.Add(new APM_BASE125("C01", "010201", "FF1C09", 1120, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C09", 1260, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C09", 1260, 180));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C09", 1120, 180));
                    }
                    else if (plate_cd == "FF1C10")
                    {
                        items.Add(new APM_BASE125("C01", "010201", "FF1C10", 1260, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C10", 1400, 0));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C10", 1400, 180));
                        items.Add(new APM_BASE125("C01", "010201", "FF1C10", 1260, 180));
                    }
                    else
                    { }
                }
                else if (bay_cd == "010202")
                {
                    if (plate_cd == "AF1A02")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "AF1A02", 100, 0));
                        items.Add(new APM_BASE125("C01", "010202", "AF1A02", 200, 0));
                        items.Add(new APM_BASE125("C01", "010202", "AF1A02", 200, 150));
                        items.Add(new APM_BASE125("C01", "010202", "AF1A02", 100, 150));
                    }
                    else if (plate_cd == "UF1A01")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A01", 0, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A01", 100, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A01", 100, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A01", 0, 150));
                    }
                    else if (plate_cd == "UF1A03")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A03", 200, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A03", 300, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A03", 300, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A03", 200, 150));
                    }
                    else if (plate_cd == "UF1A04")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A04", 300, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A04", 400, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A04", 400, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A04", 300, 150));
                    }
                    else if (plate_cd == "UF1A05")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A05", 400, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A05", 500, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A05", 500, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A05", 400, 150));
                    }
                    else if (plate_cd == "UF1A06")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A06", 500, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A06", 600, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A06", 600, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A06", 500, 150));
                    }
                    else if (plate_cd == "UF1A07")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A07", 600, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A07", 700, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A07", 700, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A07", 600, 150));
                    }
                    else if (plate_cd == "UF1A08")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A08", 700, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A08", 820, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A08", 820, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A08", 700, 150));
                    }
                    else if (plate_cd == "UF1A12")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A12", 819, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A12", 959, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A12", 959, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A12", 819, 150));
                    }
                    else if (plate_cd == "UF1A13")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A13", 957, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A13", 1061, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A13", 1061, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A13", 957, 150));
                    }
                    else if (plate_cd == "UF1A14")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A14", 1060, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A14", 1160, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A14", 1160, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A14", 1060, 150));
                    }
                    else if (plate_cd == "UF1A15")
                    {
                        items.Add(new APM_BASE125("C01", "010202", "UF1A15", 1160, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A15", 1260, 0));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A15", 1260, 150));
                        items.Add(new APM_BASE125("C01", "010202", "UF1A15", 1160, 150));
                    }
                    else
                    { }
                }
                else if (bay_cd == "010203")
                {
                    if (plate_cd == "UF3A18")
                    {
                        items.Add(new APM_BASE125("C01", "010203", "UF3A18", 0, 0));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A18", 200, 0));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A18", 200, 181));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A18", 0, 181));
                    }
                    else if (plate_cd == "UF3A20")
                    {
                        items.Add(new APM_BASE125("C01", "010203", "UF3A20", 200, 0));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A20", 401, 0));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A20", 401, 181));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A20", 200, 181));
                    }
                    else if (plate_cd == "UF3A22")
                    {
                        items.Add(new APM_BASE125("C01", "010203", "UF3A22", 400, 0));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A22", 600, 0));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A22", 600, 181));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A22", 400, 181));
                    }
                    else if (plate_cd == "UF3A24")
                    {
                        items.Add(new APM_BASE125("C01", "010203", "UF3A24", 600, 0));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A24", 800, 0));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A24", 800, 181));
                        items.Add(new APM_BASE125("C01", "010203", "UF3A24", 600, 181));
                    }
                    else if (plate_cd == "UF3B18")
                    {
                        items.Add(new APM_BASE125("C01", "010203", "UF3B18", 0, 180));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B18", 200, 180));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B18", 200, 339));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B18", 0, 339));
                    }
                    else if (plate_cd == "UF3B20")
                    {
                        items.Add(new APM_BASE125("C01", "010203", "UF3B20", 199, 181));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B20", 401, 181));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B20", 401, 339));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B20", 199, 339));
                    }
                    else if (plate_cd == "UF3B22")
                    {
                        items.Add(new APM_BASE125("C01", "010203", "UF3B22", 400, 181));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B22", 600, 181));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B22", 600, 339));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B22", 400, 339));
                    }
                    else if (plate_cd == "UF3B24")
                    {
                        items.Add(new APM_BASE125("C01", "010203", "UF3B24", 600, 181));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B24", 800, 181));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B24", 800, 339));
                        items.Add(new APM_BASE125("C01", "010203", "UF3B24", 600, 339));
                    }
                    else
                    { }
                }
                else if (bay_cd == "010204")
                {
                    if (plate_cd == "UF4A27")
                    {
                        items.Add(new APM_BASE125("C01", "010204", "UF4A27", 0, 0));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A27", 201, 0));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A27", 201, 169));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A27", 0, 169));
                    }
                    else if (plate_cd == "UF4A29")
                    {
                        items.Add(new APM_BASE125("C01", "010204", "UF4A29", 201, 0));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A29", 400, 0));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A29", 400, 170));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A29", 201, 170));
                    }
                    else if (plate_cd == "UF4A33")
                    {
                        items.Add(new APM_BASE125("C01", "010204", "UF4A33", 400, 0));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A33", 601, 0));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A33", 601, 170));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A33", 400, 170));
                    }
                    else if (plate_cd == "UF4A35")
                    {
                        items.Add(new APM_BASE125("C01", "010204", "UF4A35", 601, 0));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A35", 801, 0));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A35", 801, 170));
                        items.Add(new APM_BASE125("C01", "010204", "UF4A35", 601, 170));
                    }
                    else if (plate_cd == "UF4B27")
                    {
                        items.Add(new APM_BASE125("C01", "010204", "UF4B27", 0, 169));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B27", 201, 169));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B27", 201, 340));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B27", 0, 340));
                    }
                    else if (plate_cd == "UF4B29")
                    {
                        items.Add(new APM_BASE125("C01", "010204", "UF4B29", 201, 169));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B29", 400, 169));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B29", 400, 340));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B29", 201, 340));
                    }
                    else if (plate_cd == "UF4B33")
                    {
                        items.Add(new APM_BASE125("C01", "010204", "UF4B33", 400, 170));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B33", 601, 170));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B33", 601, 340));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B33", 400, 340));
                    }
                    else if (plate_cd == "UF4B35")
                    {
                        items.Add(new APM_BASE125("C01", "010204", "UF4B35", 601, 170));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B35", 801, 170));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B35", 801, 340));
                        items.Add(new APM_BASE125("C01", "010204", "UF4B35", 601, 340));
                    }
                    else
                    { }
                }
                else if (bay_cd == "010205")
                {
                    if (plate_cd == "UF5A37")
                    {
                        items.Add(new APM_BASE125("C01", "010205", "UF5A37", 0, 0));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A37", 180, 0));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A37", 180, 170));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A37", 0, 170));
                    }
                    else if (plate_cd == "UF5A39")
                    {
                        items.Add(new APM_BASE125("C01", "010205", "UF5A39", 180, 0));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A39", 370, 0));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A39", 370, 170));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A39", 180, 170));
                    }
                    else if (plate_cd == "UF5A41")
                    {
                        items.Add(new APM_BASE125("C01", "010205", "UF5A41", 370, 0));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A41", 560, 0));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A41", 560, 170));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A41", 370, 170));
                    }
                    else if (plate_cd == "UF5A43")
                    {
                        items.Add(new APM_BASE125("C01", "010205", "UF5A43", 560, 0));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A43", 740, 0));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A43", 740, 150));
                        items.Add(new APM_BASE125("C01", "010205", "UF5A43", 560, 150));
                    }
                    else if (plate_cd == "UF5B37")
                    {
                        items.Add(new APM_BASE125("C01", "010205", "UF5B37", 0, 170));
                        items.Add(new APM_BASE125("C01", "010205", "UF5B37", 180, 170));
                        items.Add(new APM_BASE125("C01", "010205", "UF5B37", 180, 340));
                        items.Add(new APM_BASE125("C01", "010205", "UF5B37", 0, 340));
                    }
                    else if (plate_cd == "UF5B39")
                    {
                        items.Add(new APM_BASE125("C01", "010205", "UF5B39", 180, 170));
                        items.Add(new APM_BASE125("C01", "010205", "UF5B39", 370, 170));
                        items.Add(new APM_BASE125("C01", "010205", "UF5B39", 370, 340));
                        items.Add(new APM_BASE125("C01", "010205", "UF5B39", 180, 340));
                    }
                    else if (plate_cd == "UF5B41")
                    {
                        items.Add(new APM_BASE125("C01", "010205", "UF5B41", 370, 170));
                        items.Add(new APM_BASE125("C01", "010205", "UF5B41", 560, 170));
                        items.Add(new APM_BASE125("C01", "010205", "UF5B41", 560, 340));
                        items.Add(new APM_BASE125("C01", "010205", "UF5B41", 370, 340));
                    }
                    else
                    { }
                }
                else if (bay_cd == "010300")
                {
                    if (plate_cd == "UN1E30")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1E30", 0, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E30", 190, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E30", 190, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E30", 0, 170));
                    }
                    else if (plate_cd == "UN1E32")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1E32", 190, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E32", 380, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E32", 380, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E32", 190, 170));
                    }
                    else if (plate_cd == "UN1E34")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1E34", 380, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E34", 570, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E34", 570, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E34", 380, 170));
                    }
                    else if (plate_cd == "UN1E36")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1E36", 570, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E36", 750, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E36", 750, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E36", 570, 170));
                    }
                    else if (plate_cd == "UN1E38")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1E38", 750, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E38", 930, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E38", 930, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E38", 750, 170));
                    }
                    else if (plate_cd == "UN1E40")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1E40", 930, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E40", 1100, 0));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E40", 1100, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1E40", 930, 170));
                    }
                    else if (plate_cd == "UN1F30")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1F30", 0, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F30", 190, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F30", 190, 340));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F30", 0, 340));
                    }
                    else if (plate_cd == "UN1F32")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1F32", 190, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F32", 380, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F32", 380, 340));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F32", 190, 340));
                    }
                    else if (plate_cd == "UN1F34")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1F34", 380, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F34", 570, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F34", 570, 340));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F34", 380, 340));
                    }
                    else if (plate_cd == "UN1F36")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1F36", 570, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F36", 750, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F36", 750, 340));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F36", 570, 340));
                    }
                    else if (plate_cd == "UN1F38")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1F38", 750, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F38", 930, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F38", 930, 340));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F38", 750, 340));
                    }
                    else if (plate_cd == "UN1F40")
                    {
                        items.Add(new APM_BASE125("C01", "010300", "UN1F40", 930, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F40", 1100, 170));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F40", 1100, 340));
                        items.Add(new APM_BASE125("C01", "010300", "UN1F40", 930, 340));
                    }
                    else
                    { }
                }
                else 
                { }
            }
            else
            { }

            return items;
        }

        public static bool CALCULATE_JIBUN_OUTLINE_POINTS(APM_BASE110 BAY, APM_BASE120 plate, List<APM_BASE125> items)
        {
            System.Drawing.Point Min = new System.Drawing.Point(0, 0);
            System.Drawing.Point Max = new System.Drawing.Point(0, 0);

            if (items.Count == 0) return false;

            for (int i = 0; i < items.Count; i++)
            {
                APM_BASE125 item = items[i];

                if(i == 0)
                {
                    Min = new System.Drawing.Point(item.PLATE_ST_X, item.PLATE_ST_Y);
                    Max = new System.Drawing.Point(item.PLATE_ST_X, item.PLATE_ST_Y);
                }
                else
                {
                    Min = new System.Drawing.Point(
                        Math.Min(Min.X, item.PLATE_ST_X)
                        , Math.Min(Min.Y, item.PLATE_ST_Y)
                        );

                    Max = new System.Drawing.Point(
                        Math.Max(Max.X, item.PLATE_ST_X)
                        , Math.Max(Max.Y, item.PLATE_ST_Y)
                        );
                }
            }

            List<System.Drawing.Point> ptf = new List<System.Drawing.Point>();

            int scale = 100; // Scale

            // 시작 위치 및 스케일 적용
            plate.MinPoint = new System.Drawing.Point(
                (Min.X + BAY.OffsetX) * scale
                , (-Min.Y - BAY.OffsetY) * scale
                );

            plate.MaxPoint = new System.Drawing.Point(
                (Max.X + BAY.OffsetX) * scale
                , (-Max.Y - BAY.OffsetY) * scale
                );

            return true;
        }
    }
}
