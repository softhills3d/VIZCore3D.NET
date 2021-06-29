using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.DockOut
{
    public class ClashItem
    {
        public bool Completed { get; set; }
        public VIZCore3D.NET.Data.Vector3D Translation { get; set; }
        public int ClashID { get; set; }

        public ClashItem(VIZCore3D.NET.Data.Vector3D v)
        {
            Completed = false;
            Translation = v;
            ClashID = -1;
        }
    }
}
