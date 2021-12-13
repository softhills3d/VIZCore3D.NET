using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.BayBlockRotation.Data
{
    public class BayManager
    {
        public List<Bay> Get()
        {
            List<Bay> items = new List<Bay>();
            
            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "B1 조립장";
                bay.Code = "010101";
                bay.Title = "B1 조립장";
                bay.Desc = "B1";
                bay.Width = 63;
                bay.Height = 40;
                bay.CraneCapa = 360;
                bay.LimitOutHeight = 12;
                bay.TotalArea = 0;
                bay.Efficiency = 0;
                bay.Symbol = "→5";

                bay.SKID = false;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(15, 501);
                bay.Points = "150,0;630,0;630,400;150,400;150,400;0,400;0,280;150,280;";
                bay.PointCount = 8;

                bay.CTI_POINT_NO = 7;
                bay.CTI_POINT = "0,280,150,400;150,0,310,200;310,0,470,200;150,200,310,400;470,0,630,200;310,200,470,400;470,200,630,400;";
                bay.CTI_POINT_TYPE = "C551W5;C551W5;C551W5;C551W5;C551W5;C551W5;C551W5;";
                bay.CTI_POINT_JIBUN = "UU1D01;UU1C03;UU1C05;UU1D03;UU5C07;UU1D05;UU1D07;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "B2 조립장";
                bay.Code = "010102";
                bay.Title = "B2 조립장";
                bay.Desc = "B2";
                bay.Width = 82;
                bay.Height = 40;
                bay.CraneCapa = 360;
                bay.LimitOutHeight = 12;
                bay.TotalArea = 0;
                bay.Efficiency = 0;
                bay.Symbol = "→6";

                bay.SKID = false;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(737, 498);
                bay.Points = "0,0;820,0;820,400;10,400;10,200;0,200;";
                bay.PointCount = 6;

                bay.CTI_POINT_NO = 10;
                bay.CTI_POINT = "0,0,170,200;10,200,170,400;170,0,340,200;340,0,500,200;500,0,660,200;660,0,820,200;170,200,340,400;340,200,500,400;500,200,660,400;660,200,820,400;";
                bay.CTI_POINT_TYPE = "C551W5;C551W5;C551W5;C551W5;C551W5;C551W5;C551W5;C551W5;C551W5;C551W5;";
                bay.CTI_POINT_JIBUN = "UU2C08;UU2D08;UU2C10;UU2C12;UU2C14;UU2C16;UU2D10;UU2D12;UU2D14;UU2D16;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "B3 조립장";
                bay.Code = "010103";
                bay.Title = "B3 조립장";
                bay.Desc = "B3";
                bay.Width = 64;
                bay.Height = 42;
                bay.CraneCapa = 360;
                bay.LimitOutHeight = 12;
                bay.TotalArea = 0;
                bay.Efficiency = 0;
                bay.Symbol = "→7";

                bay.SKID = false;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(1645, 486);
                bay.Points = "0,0;640,0;640,420;0,420;";
                bay.PointCount = 4;

                bay.CTI_POINT_NO = 8;
                bay.CTI_POINT = "0,0,160,210;160,0,320,210;320,0,480,210;480,0,640,210;0,210,160,420;160,210,320,420;320,210,480,420;480,210,640,420;";
                bay.CTI_POINT_TYPE = "C551W6;C551W6;C551W6;C551W6;C551W6;C551W6;C551W6;C551W6;";
                bay.CTI_POINT_JIBUN = "UU3C17;UU3C19;UU3C21;UU3C23;UU3D17;UU3D19;UU3D21;UU3D23;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "B4 조립장";
                bay.Code = "010104";
                bay.Title = "B4 조립장";
                bay.Desc = "B4";
                bay.Width = 70;
                bay.Height = 40;
                bay.CraneCapa = 360;
                bay.LimitOutHeight = 12;
                bay.TotalArea = 250;
                bay.Efficiency = 0;
                bay.Symbol = "→9";

                bay.SKID = false;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(19, 1038);
                bay.Points = "50,0;700,0;700,400;0,400;0,190;50,190;";
                bay.PointCount = 6;

                bay.CTI_POINT_NO = 8;
                bay.CTI_POINT = "50,0,210,190;520,190,700,400;210,0,370,190;370,0,530,190;530,0,700,190;340,190,520,400;170,190,340,400;0,190,170,400;";
                bay.CTI_POINT_TYPE = "C551W6;C551W6;C551W6;C551W6;C551W6;C551W6;C551W6;C551W6;";
                bay.CTI_POINT_JIBUN = "UU4C29;UU4D35;UU4C31;UU4C33;UU4C35;UU4D33;UU4D31;UU4D29;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "B5 조립장";
                bay.Code = "010105";
                bay.Title = "B5 조립장";
                bay.Desc = "B5";
                bay.Width = 72;
                bay.Height = 42;
                bay.CraneCapa = 360;
                bay.LimitOutHeight = 12;
                bay.TotalArea = 300;
                bay.Efficiency = 0;
                bay.Symbol = "→10";

                bay.SKID = false;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(799, 1030);
                bay.Points = "0,0;720,0;720,110;570,110;570,420;0,420;";
                bay.PointCount = 6;

                bay.CTI_POINT_NO = 7;
                bay.CTI_POINT = "0,0,190,210;380,210,570,420;0,210,190,420;190,210,380,420;190,0,380,210;380,0,570,210;570,0,720,110;";
                bay.CTI_POINT_TYPE = "C557W1;C557W1;C557W1;C557W1;C557W1;C55515;C55515;";
                bay.CTI_POINT_JIBUN = "UU5C37;UU5D41;UU5D37;UU5D39;UU5C39;UU5C41;UU5C43;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "B6 조립장";
                bay.Code = "010201";
                bay.Title = "B6 조립장";
                bay.Desc = "B6";
                bay.Width = 62;
                bay.Height = 18;
                bay.CraneCapa = 100;
                bay.LimitOutHeight = 7;
                bay.TotalArea = 100;
                bay.Efficiency = 0;
                bay.Symbol = "→2";

                bay.SKID = true;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(23, 259);
                bay.Points = "0,0;1400,0;1400,180;0,180;";
                bay.PointCount = 4;

                bay.CTI_POINT_NO = 10;
                bay.CTI_POINT = "1260,0,1400,180;1120,0,1260,180;980,0,1120,180;840,0,980,180;700,0,840,180;560,0,700,180;420,0,560,180;280,0,420,180;140,0,280,180;0,0,140,180;";
                bay.CTI_POINT_TYPE = "C55211;C55211;C55211;C55211;C55211;C55211;C55211;C55211;C55211;C55211;";
                bay.CTI_POINT_JIBUN = ";;;;;;;;;;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "B7 조립장";
                bay.Code = "010202";
                bay.Title = "B7 조립장";
                bay.Desc = "B7";
                bay.Width = 62;
                bay.Height = 15;
                bay.CraneCapa = 100;
                bay.LimitOutHeight = 7;
                bay.TotalArea = 10;
                bay.Efficiency = 0;
                bay.Symbol = "→1";

                bay.SKID = false;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(23, 39);
                bay.Points = "0,150;0,0;1260,0;1260,150;";
                bay.PointCount = 4;

                bay.CTI_POINT_NO = 12;
                bay.CTI_POINT = "0,0,100,150;819,0,959,150;700,0,820,150;100,0,200,150;200,0,300,150;300,0,400,150;400,0,500,150;500,0,600,150;600,0,700,150;957,0,1061,150;1060,0,1160,150;1160,0,1260,150;";
                bay.CTI_POINT_TYPE = "C55221;C55221;C55221;C55221;C55221;C55221;C55221;C55221;C55221;C55221;C55221;C55221;";
                bay.CTI_POINT_JIBUN = "UF1A01;UF1A12;UF1A08;AF1A02;UF1A03;UF1A04;UF1A05;UF1A06;UF1A07;UF1A13;UF1A14;UF1A15;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "B8 조립장";
                bay.Code = "010203";
                bay.Title = "B8 조립장";
                bay.Desc = "B8";
                bay.Width = 80;
                bay.Height = 34;
                bay.CraneCapa = 100;
                bay.LimitOutHeight = 7;
                bay.TotalArea = 0;
                bay.Efficiency = 0;
                bay.Symbol = "→3";

                bay.SKID = false;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(1460, 49);
                bay.Points = "0,0;800,0;800,340;0,340;";
                bay.PointCount = 4;

                bay.CTI_POINT_NO = 8;
                bay.CTI_POINT = "400,0,600,181;600,181,800,339;600,0,800,181;400,181,600,339;199,181,401,339;0,180,200,339;0,0,200,181;200,0,401,181;";
                bay.CTI_POINT_TYPE = "C55512;C55512;C55512;C55512;C55511;C55511;C55511;C55511;";
                bay.CTI_POINT_JIBUN = "UF3A22;UF3B24;UF3A24;UF3B22;UF3B20;UF3B18;UF3A18;UF3A20;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "B9 조립장";
                bay.Code = "010204";
                bay.Title = "B9 조립장";
                bay.Desc = "B9";
                bay.Width = 80;
                bay.Height = 34;
                bay.CraneCapa = 150;
                bay.LimitOutHeight = 8;
                bay.TotalArea = 0;
                bay.Efficiency = 0;
                bay.Symbol = "→4";

                bay.SKID = false;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(2323, 47);
                bay.Points = "0,0;800,0;800,340;0,340;";
                bay.PointCount = 4;

                bay.CTI_POINT_NO = 8;
                bay.CTI_POINT = "201,0,400,170;400,0,601,170;601,0,801,170;0,169,201,340;201,169,400,340;400,170,601,340;601,170,801,340;0,0,201,169;";
                bay.CTI_POINT_TYPE = "C551W2;C551W2;C551W2;C551W2;C551W2;C551W2;C551W2;C551W2;";
                bay.CTI_POINT_JIBUN = "UF4A29;UF4A33;UF4A35;UF4B27;UF4B29;UF4B33;UF4B35;UF4A27;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "A1 조립장";
                bay.Code = "010205";
                bay.Title = "A1 조립장";
                bay.Desc = "A1";
                bay.Width = 74;
                bay.Height = 34;
                bay.CraneCapa = 150;
                bay.LimitOutHeight = 8;
                bay.TotalArea = 0;
                bay.Efficiency = 0;
                bay.Symbol = "→8";

                bay.SKID = false;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(2366, 529);
                bay.Points = "0,0;740,0;740,150;560,150;560,340;0,340;";
                bay.PointCount = 6;

                bay.CTI_POINT_NO = 7;
                bay.CTI_POINT = "560,0,740,150;0,170,180,340;0,0,180,170;180,0,370,170;370,0,560,170;180,170,370,340;370,170,560,340;";
                bay.CTI_POINT_TYPE = "C551W2;C551W2;C551W2;C551W2;C551W2;C551W2;C55515;";
                bay.CTI_POINT_JIBUN = "UF5A43;UF5B37;UF5A37;UF5A39;UF5A41;UF5B39;UF5B41;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "A2 조립장";
                bay.Code = "010300";
                bay.Title = "A2 조립장";
                bay.Desc = "A2";
                bay.Width = 110;
                bay.Height = 34;
                bay.CraneCapa = 170;
                bay.LimitOutHeight = 8;
                bay.TotalArea = 195;
                bay.Efficiency = 0;
                bay.Symbol = "→11";

                bay.SKID = false;
                bay.SHELTER = false;

                bay.Margine = new System.Drawing.Point(1609, 1086);
                bay.Points = "0,0;1100,0;1100,340;0,340;";
                bay.PointCount = 4;

                bay.CTI_POINT_NO = 12;
                bay.CTI_POINT = "0,0,190,170;380,0,570,170;190,0,380,170;570,0,750,170;750,0,930,170;930,0,1100,170;0,170,190,340;190,170,380,340;380,170,570,340;570,170,750,340;750,170,930,340;930,170,1100,340;";
                bay.CTI_POINT_TYPE = "C557W1;C557W1;C557W1;C557W1;C557W1;C557W1;C557W1;C557W1;C557W1;C557W1;C557W1;C557W1;";
                bay.CTI_POINT_JIBUN = "UN1E30;UN1E34;UN1E32;UN1E36;UN1E38;UN1E40;UN1F30;UN1F32;UN1F34;UN1F36;UN1F38;UN1F40;";

                items.Add(bay);
            }

            {
                Bay bay = new Bay();

                bay.Department = "C55000-01";
                bay.Name = "A3 조립장";
                bay.Code = "010500";
                bay.Title = "A3 조립장";
                bay.Desc = "A3";
                bay.Width = 200;
                bay.Height = 42;
                bay.CraneCapa = 360;
                bay.LimitOutHeight = 999;
                bay.TotalArea = 200;
                bay.Efficiency = 0;
                bay.Symbol = "→12";

                bay.SKID = false;
                bay.SHELTER = true;

                bay.Margine = new System.Drawing.Point(27, 1508);
                bay.Points = "0,450;0,0;1650,0;1650,450;";
                bay.PointCount = 4;

                bay.CTI_POINT_NO = 6;
                bay.CTI_POINT = "0,0,780,220;0,220,780,450;780,220,1450,450;780,0,1450,220;1450,220,1650,450;1450,0,1650,220;";
                bay.CTI_POINT_TYPE = "C551W6;C551W5;C557W1;C551W2;C55513;C55515;";
                bay.CTI_POINT_JIBUN = "";

                items.Add(bay);
            }

            return items;
        }
    }
}
