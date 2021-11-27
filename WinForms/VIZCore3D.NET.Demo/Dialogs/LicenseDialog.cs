using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.Demo.Dialogs
{
    public partial class LicenseDialog : Form
    {
        public string LicenseFile
        {
            get
            {
                return txtFile.Text;
            }
        }

        public string LicenseIp
        {
            get
            {
                return txtIp.Text;
            }
        }

        public string LicensePort
        {
            get
            {
                return txtPort.Text;
            }
        }

        public LicenseDialog()
        {
            InitializeComponent();

            GetConfiguration();
        }

        private void GetConfiguration()
        {
            string path = string.Format("{0}\\License.ini", Application.StartupPath);

            if (System.IO.File.Exists(path) == false) return;

            VIZCore3D.NET.Utility.IniFile ini = new Utility.IniFile();
            ini.Load(path);

            if (ini.ContainsSection("License") == false) return;

            VIZCore3D.NET.Utility.IniSection section = new Utility.IniSection();
            if (ini.TryGetSection("License", out section) == false) return;

            txtFile.Text = section["File"].ToString();
            txtIp.Text = section["IP"].ToString();
            txtPort.Text = section["PORT"].ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\License.ini", Application.StartupPath);

            VIZCore3D.NET.Utility.IniFile ini = new Utility.IniFile();
            if(System.IO.File.Exists(path) == true)
                ini.Load(path);

            VIZCore3D.NET.Utility.IniSection section;

            if (ini.ContainsSection("License") == false)
                section = ini.Add("License");
            else
                section = ini["License"];

            if (String.IsNullOrEmpty(txtFile.Text) == false)
            {
                section["File"] = new Utility.IniValue(txtFile.Text);
                section["IP"] = new Utility.IniValue("");
                section["PORT"] = new Utility.IniValue("");

                ini.Save(path);
            }
            else if(String.IsNullOrEmpty(txtIp.Text) == false && String.IsNullOrEmpty(txtPort.Text) == false)
            {
                section["File"] = new Utility.IniValue("");
                section["IP"] = new Utility.IniValue(txtIp.Text);
                section["PORT"] = new Utility.IniValue(txtPort.Text);

                ini.Save(path);
            }
            else
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "License (*.lic)|*.lic";
            if (dlg.ShowDialog() != DialogResult.OK) return;

            txtFile.Text = dlg.FileName;
        }

        private void btnClearFile_Click(object sender, EventArgs e)
        {
            txtFile.Text = String.Empty;
        }
    }
}
