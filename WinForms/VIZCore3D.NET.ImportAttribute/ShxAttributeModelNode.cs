using System;
using System.Collections.Generic;
using System.Text;

namespace VIZCore3D.NET.ImportAttribute
{
    /// <summary>
    /// Shx Model Node
    /// </summary>
    public class ShxAttributeModelNode
    {
        /// <summary>
        /// Model Entity Id
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Model Node Path
        /// </summary>
        public string NodePath { get; set; }

        /// <summary>
        /// Model Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Construction
        /// </summary>
        public ShxAttributeModelNode()
        {

        }

        /// <summary>
        /// Construction
        /// </summary>
        /// <param name="id">Entity ID</param>
        /// <param name="name">Node Name</param>
        /// <param name="nodepath">Node Path</param>
        public ShxAttributeModelNode(long id, string name, string nodepath)
        {
            ID = id;
            Name = name;
            NodePath = nodepath;
        }
    }
}
