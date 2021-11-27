using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIZCore3D.NET.WebBrowserInterworking
{
    public delegate void JavaScriptOpenModelEventHandler(object sender, JavaScriptOpenModelEventArgs e);

    public class JavaScriptOpenModelEventArgs : EventArgs
    {
        public string File { get; set; }

        public JavaScriptOpenModelEventArgs(string file)
        {
            File = file;
        }
    }

    public delegate void JavaScriptCloseModelEventHandler(object sender, EventArgs e);
}
