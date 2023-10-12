using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegisterProtocolHandler
{
    public partial class FrmMain : Form
    {
        public string Key_AppUniqueName = "app";
        public const string Key_URLProtocol = "URL Protocol";
        public const string Key_DefaultIcon = "DefaultIcon";
        public const string Key_Shell = "shell";
        public const string Key_Open = "open";
        public const string Key_Command = "command";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "EXE (*.exe)|*.exe";

            if (dlg.ShowDialog() != DialogResult.OK) return;

            txtPath.Text = dlg.FileName;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string app = txtAppName.Text;
            string path = txtPath.Text;

            if (String.IsNullOrEmpty(app) == true) return;
            if (String.IsNullOrEmpty(path) == true) return;

            Key_AppUniqueName = app;

            RegisterProtocolHandler(path);
        }

        #region Registering an Application to a URI Scheme
        /// <summary>
        /// Registering an Application to a URI Scheme
        /// </summary>
        /// <param name="doRegistration"></param>
        private void RegisterProtocolHandler(string path)
        {
            if (String.IsNullOrEmpty(path) == true)
                throw new NullReferenceException("Path is null.");

            if (System.IO.File.Exists(path) == false)
                throw new System.IO.FileNotFoundException(path);

            try
            {
                string exeName = System.IO.Path.GetFileName(path);

                using (Microsoft.Win32.RegistryKey appKey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(Key_AppUniqueName))
                {
                    appKey.SetValue(null, string.Format("URL:Run {0} Protocol", Key_AppUniqueName.ToUpper()));
                    appKey.SetValue(Key_URLProtocol, "");

                    using (Microsoft.Win32.RegistryKey defaultIconKey = appKey.CreateSubKey(Key_DefaultIcon))
                    {
                        defaultIconKey.SetValue(null, string.Format("{0},1", exeName));
                    }

                    using (Microsoft.Win32.RegistryKey shellKey = appKey.CreateSubKey(Key_Shell))
                    using (Microsoft.Win32.RegistryKey openKey = shellKey.CreateSubKey(Key_Open))
                    using (Microsoft.Win32.RegistryKey commandKey = openKey.CreateSubKey(Key_Command))
                    {
                        string value = string.Format("\"{0}\" \"%1\"", path);
                        commandKey.SetValue(null, value);
                    }
                }

                MessageBox.Show("Completed.", "RegisterProtocolHandler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
