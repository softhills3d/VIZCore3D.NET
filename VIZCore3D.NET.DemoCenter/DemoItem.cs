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
        public string Title { get; set; }
        public string Description { get; set; }

        public string PreviewImagePath { get; set; }
        public string YouTubeUri { get; set; }
        public string GitHubUri { get; set; }
    }
}
