using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIZCore3D.NET.ToVIZ
{
    public enum ToVIZMode
    {
        EXPORT = 0,
        CONVERT = 1,
        OUTSIDE = 2,
        SIMPLIFIED = 3
    }

    public partial class FileExplorerControl : UserControl
    {
        public event ToVIZEventHandler OnToVIZEvent;

        public FileExplorerControl()
        {
            InitializeComponent();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            //Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog dlg = new Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog();
            //dlg.IsFolderPicker = true;
            //if (dlg.ShowDialog() != Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok) return;
            //txtSource.Text = dlg.FileName;

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (String.IsNullOrEmpty(txtSource.Text) == false)
                dlg.SelectedPath = txtSource.Text;
            if (dlg.ShowDialog() != DialogResult.OK) return;
            txtSource.Text = dlg.SelectedPath;

            if (String.IsNullOrEmpty(txtSource.Text) == true) return;

            string sourcePath = txtSource.Text;

            List<string> files = new List<string>();

            if(ckREV.Checked == true)
                files.AddRange(GetFiles(sourcePath, "*.rev"));
            if (ckRVM.Checked == true)
                files.AddRange(GetFiles(sourcePath, "*.rvm"));
            if (ckRVT.Checked == true)
                files.AddRange(GetFiles(sourcePath, "*.rvt"));
            if(ckVIZ.Checked == true)
                files.AddRange(GetFiles(sourcePath, "*.viz"));
            if(ckDGN.Checked == true)
                files.AddRange(GetFiles(sourcePath, "*.dgn"));

            lvFiles.BeginUpdate();
            lvFiles.Items.Clear();
            foreach (string item in files)
            {
                ListViewItem lvi = new ListViewItem(new string[] { System.IO.Path.GetFileName(item), "N/A" });
                lvFiles.Items.Add(lvi);
            }
            lvFiles.EndUpdate();
        }

        private List<string> GetFiles(string path, string filter)
        {
            string[] files = System.IO.Directory.GetFiles(path, filter, System.IO.SearchOption.TopDirectoryOnly);

            if (files == null || files.Length == 0) return new List<string>();

            return files.ToList();
        }

        private void btnToVIZ_Click(object sender, EventArgs e)
        {
            if (OnToVIZEvent == null) return;

            string source = txtSource.Text;
            string output = txtOutput.Text;

            foreach (ListViewItem item in lvFiles.Items)
            {
                ToVIZEventArgs args = new ToVIZEventArgs();
                args.Source = string.Format("{0}\\{1}", txtSource.Text, item.Text);
                args.Output = output;

                if (rbExport.Checked)
                    args.Mode = ToVIZMode.EXPORT;
                else if (rbConversion.Checked)
                    args.Mode = ToVIZMode.CONVERT;
                else if (rbOutside.Checked)
                    args.Mode = ToVIZMode.OUTSIDE;
                else if (rbSimplified.Checked)
                    args.Mode = ToVIZMode.SIMPLIFIED;
                else
                    args.Mode = ToVIZMode.EXPORT;

                if (rbAsIs.Checked)
                    args.MergeMode = Data.MergeStructureModes.NONE;
                else if (rbLeafAssembly.Checked)
                    args.MergeMode = Data.MergeStructureModes.LEAF_ASM_TO_PART;
                else if (rbPart.Checked)
                    args.MergeMode = Data.MergeStructureModes.ALL_TO_PART;
                else
                    args.MergeMode = Data.MergeStructureModes.NONE;

                this.Cursor = Cursors.WaitCursor;
                bool result = OnToVIZEvent(this, args);
                this.Cursor = Cursors.Default;

                lvFiles.Invoke(new EventHandler(delegate
                {
                    item.SubItems[1].Text = result == true ? "OK" : "NG";
                    item.EnsureVisible();
                    lvFiles.Refresh();
                }));
            }
        }
    }

    public delegate bool ToVIZEventHandler(object sender, ToVIZEventArgs e);

    public class ToVIZEventArgs : EventArgs
    {
        public ToVIZMode Mode { get; set; }
        public string Source { get; set; }
        public string Output { get; set; }
        public VIZCore3D.NET.Data.MergeStructureModes MergeMode { get; set; }
    }
}
