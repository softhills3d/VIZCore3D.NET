using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.DemoCenter
{
    public partial class FrmMain : Form
    {
        public Dictionary<string, DemoItem> Demos { get; set; }
        public FrmMain()
        {
            InitializeComponent();

            BindData();
        }

        private void BindData()
        {
            LoadData();

            tvHierarchy.ExpandAll();
            tvHierarchy.AfterSelect += TvHierarchy_AfterSelect;
        }

        private void LoadData()
        {
            string input_xml = string.Format("{0}\\Data.xml", Application.StartupPath);
            Demos = new Dictionary<string, DemoItem>();

            //**********************************************************
            // Read XML
            //**********************************************************
            System.Xml.XmlReaderSettings settings = new System.Xml.XmlReaderSettings();
            settings.IgnoreComments = true;                                 // Exclude comments
            settings.ValidationType = System.Xml.ValidationType.None;       // Validation
            //settings.CheckCharacters = false;

            // Create reader based on settings
            System.Xml.XmlReader reader = System.Xml.XmlReader.Create(input_xml, settings);

            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(reader);// XML 파일 읽기

            System.Xml.XmlNode xmlRoot = doc.SelectSingleNode("/DemoCenter");
            if (xmlRoot == null) return;

            if(xmlRoot.HasChildNodes == true)
            {
                System.Xml.XmlNodeList nodeChildren = xmlRoot.ChildNodes;

                foreach (System.Xml.XmlElement item in nodeChildren)
                {
                    string name = String.Empty;
                    string project = String.Empty;
                    string youtube = String.Empty;
                    string contents = String.Empty;

                    if (item.HasAttribute("Name") == true)
                        name = item.Attributes["Name"].InnerText;

                    if (item.HasAttribute("Project") == true)
                        project = item.Attributes["Project"].InnerText;

                    if(item.HasChildNodes == true)
                    {
                        System.Xml.XmlNodeList nodeDetail = item.ChildNodes;
                        foreach (System.Xml.XmlElement detail in nodeDetail)
                        {
                            if (detail.Name == "YouTube")
                                youtube = detail.InnerText;
                            else if (detail.Name == "Contents")
                                contents = detail.InnerText;
                        }
                    }

                    DemoItem info = new DemoItem();
                    info.TagName = name;
                    info.ProjectCode = project;
                    info.YouTube = youtube;
                    info.Description = contents;

                    if (Demos.ContainsKey(info.TagName) == false)
                        Demos.Add(info.TagName, info);
                }
            }
        }

        private void TvHierarchy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            if (e.Node.Tag == null) return;

            //string tag = (string)e.Node.Tag;
            //if (String.IsNullOrEmpty(tag) == true) return;
            //if (Demos.ContainsKey(tag) == false) return;
            //ShowDemoInformation(Demos[tag]);

            string tag = e.Node.Text;
            if (Demos.ContainsKey(tag) == false) return;
            ShowDemoInformation(Demos[tag]);
        }

        private DemoItem SelectedItem = null;
        private void ShowDemoInformation(DemoItem info)
        {
            SelectedItem = info;

            pbPreview.ImageLocation = info.GetPreviewImagePath(Application.StartupPath);
            btnRun.Enabled = !String.IsNullOrEmpty(info.GetApplicationPath(Application.StartupPath));
            btnYouTube.Enabled = !String.IsNullOrEmpty(info.YouTube);
            btnGitHub.Enabled = !String.IsNullOrEmpty(info.GitHub);
            txtContents.Text = info.Description;

            List<string> api = info.GetApi(Application.StartupPath);
            lbAPI.Text = string.Format("Items = {0:N0} EA", api.Count);
            lvAPI.BeginUpdate();
            lvAPI.Items.Clear();
            foreach (string item in api)
            {
                ListViewItem lvi = new ListViewItem(new string[] { item });
                lvAPI.Items.Add(lvi);
            }
            lvAPI.EndUpdate();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null) return;
            System.Diagnostics.Process.Start(SelectedItem.GetApplicationPath(Application.StartupPath));
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null) return;
            System.Diagnostics.Process.Start("CHROME.EXE", SelectedItem.GitHub);
        }

        private void btnYouTube_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null) return;
            System.Diagnostics.Process.Start("CHROME.EXE", SelectedItem.YouTube);
        }
    }
}
