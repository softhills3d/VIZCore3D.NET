using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.TOB
{
    public class CollisionItem
    {
        public string LugName { get; set; }
        public string RollerName { get; set; }

        public VIZCore3D.NET.Data.Vertex3D CollisionPoint { get; set; }
        public float Distance { get; set; }
        public int NodeIndex { get; set; }
        public List<VIZCore3D.NET.Data.Vertex3D> Input { get; set; }

        public string CollisionNodeName { get; set; }

        public string Angle1 { get; set; }
        public string Angle2 { get; set; }

        public CollisionItem()
        {

        }

        public void Set(VIZCore3D.NET.Data.NearestObjectByAxisPoint raw, string lugName, string rollerName, string collisionNodeName)
        {
            LugName = lugName;
            RollerName = rollerName;
            CollisionNodeName = collisionNodeName;

            CollisionPoint = raw.CollisionPoint;
            Distance = raw.Distance;
            NodeIndex = raw.Index;
            Input = raw.InputPoint;
        }
    }
}
