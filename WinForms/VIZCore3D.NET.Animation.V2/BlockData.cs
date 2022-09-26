using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.Animation.V2
{
    public class BlockData
    {
        public int NO { get; set; }
        public string SHIP_CODE { get; set; }
        public string BLOCK { get; set; }
        public string ERECTION_DATE { get; set; }

        public VIZCore3D.NET.Data.Node BlockNode { get; set; }
        public VIZCore3D.NET.Data.Node GhostNode { get; set; }

        public VIZCore3D.NET.Data.Vertex3D Center { get; set; }

        public float AnimationTime { get; set; }

        public BlockData()
        {

        }

        public BlockData(int no, string shipCode, string block, string date)
        {
            NO = no;
            SHIP_CODE = shipCode;
            BLOCK = block;
            ERECTION_DATE = date;

            BlockNode = null;
        }

        public string GetMessageString()
        {
            return string.Format("{0} : {1}", BLOCK, ERECTION_DATE);
        }
    }
}
