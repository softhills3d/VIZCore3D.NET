using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.DockOut
{
    public class GridSpaceManager
    {
        public List<GridSpaceItem> Items { get; set; }

        public GridSpaceManager()
        {
            Items = new List<GridSpaceItem>();
        }

        public void Add(GridSpaceItem item)
        {
            Items.Add(item);
        }

        public void ResetCollisionCount()
        {
            foreach (GridSpaceItem item in Items)
            {
                item.CollisionCount = 0;
            }
        }

        public void CheckCollisionSpace(VIZCore3D.NET.Data.Vertex3D hotPoint)
        {
            foreach (GridSpaceItem item in Items)
            {
                item.CheckSpace(hotPoint);
            }
        }

        public int GetMaxCount()
        {
            int result = Int32.MinValue;
            foreach (GridSpaceItem item in Items)
            {
                result = Math.Max(result, item.CollisionCount);
            }
            return result;
        }
    }

    public class GridSpaceItem
    {
        public string Name { get; set; }
        public int NoX { get; set; }
        public int NoY { get; set; }
        public VIZCore3D.NET.Data.BoundBox3D GridBoundBox { get; set; }
        public int CollisionCount { get; set; }

        public GridSpaceItem()
        {

        }

        public void CheckSpace(VIZCore3D.NET.Data.Vertex3D v)
        {
            if (GridBoundBox.Contains(v, true, true, false) == true)
                CollisionCount++;
        }
    }
}
