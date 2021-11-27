using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.ClashTest.V3
{
    public class BlockItem
    {
        public string BlockName { get; set; }

        public VIZCore3D.NET.Data.ClashTest Clash { get; set; }

        public Dictionary<string, string> ClashBlock { get; set; }

        public BlockItem(string block)
        {
            BlockName = block;
            Clash = null;
            ClashBlock = new Dictionary<string, string>();
        }

        public void AddClashBlock(string block)
        {
            if (ClashBlock.ContainsKey(block) == true) return;

            ClashBlock.Add(block, block);
        }

        public bool HasClashBlock(string block)
        {
            return ClashBlock.ContainsKey(block);
        }
    }
}
