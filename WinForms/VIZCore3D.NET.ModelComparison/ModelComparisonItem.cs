using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.ModelComparison
{  
    public class ModelComparisonItem
    {
        public VIZCore3D.NET.Data.Node Node1 { get; set; }
        public VIZCore3D.NET.Data.Node Node2 { get; set; }

        public VIZCore3D.NET.Data.BoundBox3D BBox1 { get; set; }
        public VIZCore3D.NET.Data.BoundBox3D BBox2 { get; set; }

        public int MeshCount1 { get; set; }
        public int MeshCount2 { get; set; }

        public bool RESULT_EXIST_A { get; set; }
        public bool RESULT_EXIST_B { get; set; }
        public bool RESULT_EXIST_BOTH { get; set; }
        public bool RESULT_LOCATION { get; set; }
        public bool RESULT_SHAPE { get; set; }

        public ModelComparisonItem()
        {
            RESULT_EXIST_A = false;
            RESULT_EXIST_B = false;
            RESULT_EXIST_BOTH = false;
            RESULT_LOCATION = false;
            RESULT_SHAPE = false;
        }

        public void Compare()
        {
            if (RESULT_EXIST_A == false) return;
            if (RESULT_EXIST_B == false) return;
            if (RESULT_EXIST_BOTH == false) return;

            if (BBox1.Equals(BBox2, false) == true)
                RESULT_LOCATION = true;

            if(Node1.Kind == VIZCore3D.NET.Data.NodeKind.PART)
            {
                if (MeshCount1 == MeshCount2)
                    RESULT_SHAPE = true;
            }
        }

        public string[] GetListViewItem()
        {
            string[] items = new string[]
            {
                RESULT_EXIST_A == true ? Node1.NodeName : String.Empty
                , RESULT_EXIST_B == true ? Node2.NodeName : String.Empty
                , RESULT_EXIST_BOTH == true ? String.Empty : (RESULT_EXIST_A == true ? "모델 삭제" : "모델 추가")
                , RESULT_EXIST_BOTH == false ? String.Empty : (RESULT_LOCATION == true ? String.Empty : "위치 변경")
                , RESULT_EXIST_BOTH == false ? String.Empty : (Node1.Kind == VIZCore3D.NET.Data.NodeKind.PART ? (RESULT_SHAPE == true ? String.Empty : "형상 변경") : String.Empty)
                , MeshCount1.ToString()
                , MeshCount2.ToString()
                , BBox1 != null ? BBox1.ToString() : String.Empty
                , BBox2 != null ? BBox2.ToString() : String.Empty
            };

            return items;
        }

        public bool IsSameModel()
        {
            if (RESULT_EXIST_A == false) return false;
            if (RESULT_EXIST_B == false) return false;
            if (RESULT_EXIST_BOTH == false) return false;
            if (RESULT_LOCATION == false) return false;

            if (Node1.Kind != VIZCore3D.NET.Data.NodeKind.PART) return true;

            if (RESULT_SHAPE == false) return false;

            return true;
        }
    }
}
