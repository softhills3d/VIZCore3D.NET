using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.DemoCenter
{
    public class DemoItem
    {
        public string TagName { get; set; }
        public string ProjectCode { get; set; }
        public string Description { get; set; }
        public string YouTube { get; set; }
        public string GitHub
        {
            get
            {
                if (ProjectCode == "VIZCore3D.NET.BlockArrangement") return String.Empty;

                return string.Format("https://github.com/softhills3d/VIZCore3D.NET/tree/master/{0}", ProjectCode);
            }
        }

        public string GetPreviewImagePath(string basePath)
        {
            string path = string.Format("{0}\\Preview\\{1}.png", basePath, ProjectCode);

            if (System.IO.File.Exists(path) == true)
            {
                return path;
            }
            else
            {
                return string.Format("{0}\\Preview\\VIZCore3D.NET.png", basePath);
            }
        }

        public string GetApplicationPath(string basePath)
        {
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(basePath);
            System.IO.DirectoryInfo root = info.Parent.Parent.Parent;

            string path = string.Format("{0}\\{1}\\bin\\Release\\{1}.exe", root.FullName, ProjectCode);

            if (System.IO.File.Exists(path) == true)
                return path;
            else
                return String.Empty;
        }

        public string GetProjectPath(string basePath)
        {
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(basePath);
            System.IO.DirectoryInfo root = info.Parent.Parent.Parent;

            string path = string.Format("{0}\\{1}", root.FullName, ProjectCode);

            if (System.IO.Directory.Exists(path) == true)
                return path;
            else
                return String.Empty;
        }

        public List<string> GetApi(string basePath)
        {
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(basePath);
            System.IO.DirectoryInfo root = info.Parent.Parent.Parent;
            string path = string.Format("{0}\\{1}", root.FullName, ProjectCode);

            if (System.IO.Directory.Exists(path) == false) return new List<string>();

            string[] files = System.IO.Directory.GetFiles(path, "*.cs", System.IO.SearchOption.AllDirectories);

            Dictionary<string, string> api = new Dictionary<string, string>();

            foreach (string item in files)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(item);
                while(!sr.EndOfStream)
                {
                    string code = sr.ReadLine().TrimStart();

                    if (code.Contains("vizcore3d.") == false) continue;
                    if (code.Substring(0, 2) == "//") continue;

                    if (api.ContainsKey(code) == false)
                        api.Add(code, code);
                }
                sr.Close();
            }

            List<string> keys = api.Keys.ToList();
            keys.Sort();
            return keys;
        }
    }
}
