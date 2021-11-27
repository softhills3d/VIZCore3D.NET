using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace VIZCore3D.NET.ImportAttribute
{
    public class ShxAttributeXmlHelper
    {
        public List<ShxAttributeXmlNode> AttributeList { get; set; }

        public ShxAttributeXmlHelper()
        {
            AttributeList = new List<ShxAttributeXmlNode>();
        }

        public void Import(string path)
        {
            //**********************************************************
            // Read XML
            //**********************************************************

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;                         // Exclude comments
            settings.ValidationType = ValidationType.None;          // Validation

            // Create reader based on settings
            XmlReader reader = XmlReader.Create(path, settings);

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(reader);// XML 파일 읽기
            }
            catch (System.Xml.XmlException ex)
            {
                string msg = ex.Message;
            }

            XmlNode rootNode = null;

            for (int i = 0; i < doc.ChildNodes.Count; i++)
            {
                XmlNode childNode = doc.ChildNodes[i];

                if (childNode.Name == "ModelPublishingData")
                    rootNode = childNode;
            }

            if (rootNode == null) return;

            LoadModels(rootNode);
        }

        private void LoadModels(XmlNode rootNode)
        {
            XmlNode ModelsNode = null;

            for (int i = 0; i < rootNode.ChildNodes.Count; i++)
            {
                XmlNode childNode = rootNode.ChildNodes[i];

                if (childNode.Name == "Models")
                    ModelsNode = childNode;
            }

            if (ModelsNode == null) return;

            LoadModel(ModelsNode);
        }

        private void LoadModel(XmlNode modelsNode)
        {
            for (int i = 0; i < modelsNode.ChildNodes.Count; i++)
            {
                XmlNode childNode = modelsNode.ChildNodes[i];

                if (childNode.Name == "Model")
                    LoadItem(childNode);
            }
        }

        private void LoadItem(XmlNode modelNode)
        {
            for (int i = 0; i < modelNode.ChildNodes.Count; i++)
            {
                XmlNode childNode = modelNode.ChildNodes[i];

                if (childNode.Name == "Item")
                {
                    string name = GetXmlAttribute(childNode, "name");

                    ShxAttributeXmlNode prop = new ShxAttributeXmlNode(name);

                    if(childNode.ChildNodes.Count == 1)
                    {
                        XmlNode FormPropertiesNode = childNode.ChildNodes[0];

                        for (int j = 0; j < FormPropertiesNode.ChildNodes.Count; j++)
                        {
                            XmlNode propNode = FormPropertiesNode.ChildNodes[j];

                            string key = GetXmlAttribute(propNode, "name");
                            string val = GetXmlAttribute(propNode, "value");

                            prop.Add(key, val, true);
                        }
                    }

                    AttributeList.Add(prop);
                }
            }
        }

        private string GetXmlAttribute(XmlNode node, string name)
        {
            if (node.Attributes.GetNamedItem(name) == null) return String.Empty;
            else return node.Attributes.GetNamedItem(name).Value;
        }
    }
}
