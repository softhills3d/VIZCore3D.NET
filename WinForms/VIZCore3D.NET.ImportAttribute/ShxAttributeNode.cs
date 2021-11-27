using System;
using System.Collections.Generic;
using System.Text;

namespace VIZCore3D.NET.ImportAttribute
{
    /// <summary>
    /// AVEVA Attribute Node Class
    /// </summary>
    public class ShxAttributeNode
    {
        /// <summary>
        /// 노드 이름
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 속성 목록
        /// </summary>
        public Dictionary<string, string> Property { get; set; }
        /// <summary>
        /// 자식 노드
        /// </summary>
        public List<ShxAttributeNode> Children { get; set; }
        /// <summary>
        /// 부모 노드
        /// </summary>
        public ShxAttributeNode ParentNode { get; set; }
        /// <summary>
        /// 노드 경로
        /// </summary>
        public string NodePath
        {
            get
            {
                return GetNodePath();
            }
        }
        /// <summary>
        /// Node Path 상대 경로
        /// </summary>
        public string PrefixNodePath { get; set; }

        /// <summary>
        /// 속성 파일
        /// </summary>
        public string AttributeFileName { get; set; }

        /// <summary>
        /// 생성자
        /// </summary>
        public ShxAttributeNode()
        {
            Property = new Dictionary<string, string>();

            Children = new List<ShxAttributeNode>();
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="prefixNodePath">Node Path 상대 경로</param>
        public ShxAttributeNode(string prefixNodePath)
        {
            Property = new Dictionary<string, string>();

            Children = new List<ShxAttributeNode>();

            PrefixNodePath = prefixNodePath;
        }

        /// <summary>
        /// 노드 설정
        /// </summary>
        /// <param name="stream">파일 열기 스트림</param>
        /// <param name="node">노드 이름</param>
        /// <param name="nodes">전체 노드 목록</param>
        public void SetNode(System.IO.StreamReader stream, string node, List<ShxAttributeNode> nodes)
        {
            SetName(node);

            while (true)
            {
                string str = stream.ReadLine();

                if (String.IsNullOrEmpty(str) == true)
                    break;

                if (str.Trim().StartsWith("NEW") == true)
                {
                    ShxAttributeNode child = new ShxAttributeNode();
                    child.ParentNode = this;
                    Children.Add(child);
                    nodes.Add(child);
                    child.SetNode(stream, str, nodes);
                }
                else if (str.Trim().StartsWith("END") == true)
                {
                    break;
                }
                else
                {
                    string[] separatingChars = { ":=" };
                    string[] vals = str.Trim().Split(separatingChars, StringSplitOptions.RemoveEmptyEntries);

                    if (vals != null && vals.Length > 0)
                    {
                        if (Property.ContainsKey(vals[0].Trim()) == false)
                            Property.Add(vals[0].Trim(), vals.Length == 2 ? vals[1].Trim() : String.Empty);
                    }
                }
            }
        }

        /// <summary>
        /// 노드 이름 설정
        /// </summary>
        /// <param name="str">노드 이름 텍스트</param>
        private void SetName(string str)
        {
            str = str.Trim().Substring(4);

            if (str.StartsWith("/") == true)
                str = str.Substring(1);

            Name = str;
        }

        /// <summary>
        /// 노드 경로 반환
        /// </summary>
        /// <returns>노드 경로(NodePath)</returns>
        private string GetNodePath()
        {
            if (ParentNode == null)
            {
                if (String.IsNullOrEmpty(PrefixNodePath) == true)
                    return Name;
                else
                    return PrefixNodePath;
            }
            else
            {
                return string.Format("{0}\\{1}", ParentNode.GetNodePath(), Name);
            }
        }

        /// <summary>
        /// Get Property Count
        /// </summary>
        /// <returns>Total Property Count</returns>
        public int GetPropertyCount()
        {
            if (Children.Count == 0) return Property.Count;

            int child_property_count = 0;

            foreach (ShxAttributeNode item in Children)
            {
                child_property_count += item.GetPropertyCount();
            }

            return Property.Count + child_property_count;
        }
    }
}
