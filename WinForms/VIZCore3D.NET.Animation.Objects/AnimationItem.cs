using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.Animation.Objects
{
    public enum ENUM_TRANSFORM_KIND
    {
        NONE = 0,
        TRANSLATION = 1,
        ROTATION = 2
    }

    public class AnimationItem
    {
        public string NodeName { get; set; }
        public List<VIZCore3D.NET.Data.Node> Nodes { get; set; }
        public float TX { get; set; }
        public float TY { get; set; }
        public float TZ { get; set; }
        public float RX { get; set; }
        public float RY { get; set; }
        public float RZ { get; set; }

        public ENUM_TRANSFORM_KIND TransformKind { get; set; }

        public AnimationItem()
        {

        }

        public AnimationItem(string name, List<VIZCore3D.NET.Data.Node> nodes, float tx, float ty, float tz, float rx, float ry, float rz)
        {
            NodeName = name;
            Nodes = nodes;

            TX = tx;
            TY = ty;
            TZ = tz;

            RX = rx;
            RY = ry;
            RZ = rz;

            if (Convert.ToInt32(TX) == 0 && Convert.ToInt32(TY) == 0 && Convert.ToInt32(TZ) == 0 && Convert.ToInt32(RX) == 0 && Convert.ToInt32(RY) == 0 && Convert.ToInt32(RZ) == 0)
            {
                TransformKind = ENUM_TRANSFORM_KIND.NONE;
            }
            else if (Convert.ToInt32(TX) == 0 && Convert.ToInt32(TY) == 0 && Convert.ToInt32(TZ) == 0)
            {
                TransformKind = ENUM_TRANSFORM_KIND.ROTATION;
            }
            else
            {
                TransformKind = ENUM_TRANSFORM_KIND.TRANSLATION;
            }
        }
    }
}
