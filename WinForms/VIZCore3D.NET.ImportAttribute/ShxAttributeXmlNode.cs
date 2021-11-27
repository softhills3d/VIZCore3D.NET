using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.ImportAttribute
{
    public class ShxAttributeXmlNode
    {
        public string Name { get; set; }

        public Dictionary<string, string> Properties { get; set; }

        public ShxAttributeXmlNode(string name)
        {
            Name = name;

            Properties = new Dictionary<string, string>();
        }

        public bool Add(string key, string val, bool allowNullValue = true)
        {
            if(allowNullValue == false)
            {
                if (String.IsNullOrEmpty(val) == true) return false;
            }

            if(Properties.ContainsKey(key.ToUpper()) == false)
            {
                Properties.Add(key.ToUpper(), val.ToUpper());

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
