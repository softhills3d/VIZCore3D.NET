using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.WebBrowserInterworking
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public class JavaScriptInterface
    {
        public event JavaScriptOpenModelEventHandler OnOpenModel;
        public event JavaScriptCloseModelEventHandler OnCloseModel;

        public void showMessageBox(string msg)
        {
            MessageBox.Show(msg, "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void openModel(string file)
        {
            if (OnOpenModel == null) return;
            OnOpenModel(this, new JavaScriptOpenModelEventArgs(file));
        }

        public void closeModel()
        {
            if (OnCloseModel == null) return;
            OnCloseModel(this, new EventArgs());
        }
    }
}
