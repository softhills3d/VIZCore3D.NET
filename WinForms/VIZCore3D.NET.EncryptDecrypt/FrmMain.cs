using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShdCore.NET;

namespace VIZCore3D.NET.EncryptDecrypt
{
    public partial class FrmMain : Form
    {
        public List<FileItem> DataSource { get; set; }

        public VIZCore3D.NET.VIZCore3DControl vizcore3d { get; set; }

        public FrmMain()
        {
            InitializeComponent();

            DataSource = new List<FileItem>();

            VIZCore3D.NET.ModuleInitializer.Run();

            vizcore3d = new VIZCore3DControl();
            vizcore3d.Dock = DockStyle.Fill;
            vizcore3d.OnInitializedVIZCore3D += VIZCore3D_OnInitializedVIZCore3D;
            groupBox6.Controls.Add(vizcore3d);
        }

        private void VIZCore3D_OnInitializedVIZCore3D(object sender, EventArgs e)
        {
            // ================================================================
            // License Helper
            // ================================================================
            #region 라이선스
            // 라이선스 정보 조회
            VIZCore3D.NET.Utility.LicenseHelper.LicenseData licenseData = VIZCore3D.NET.Utility.LicenseHelper.GetLicenseDataKind();

            // 등록된 정보 없는 경우, 설정 다이얼로그 실행
            if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.NONE)
            {
                VIZCore3D.NET.Dialogs.LicenseDialog dlg = new VIZCore3D.NET.Dialogs.LicenseDialog();
                if (dlg.ShowDialog() != DialogResult.OK) return;
            }

            // 라이선스 정보 재조회
            licenseData = VIZCore3D.NET.Utility.LicenseHelper.GetLicenseDataKind();

            // 등록된 정보 조회
            Dictionary<string, string> licenseInfo = VIZCore3D.NET.Utility.LicenseHelper.GetLicenseInformation();
            VIZCore3D.NET.Data.LicenseResults licenseResult = VIZCore3D.NET.Data.LicenseResults.NONE;

            // 라이선스 서버
            if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.SERVER)
            {
                licenseResult = vizcore3d.License.LicenseServer(
                    licenseInfo.ContainsKey("LICENSE_IP") == true ? licenseInfo["LICENSE_IP"] : String.Empty
                    , licenseInfo.ContainsKey("LICENSE_PORT") == true ? Convert.ToInt32(licenseInfo["LICENSE_PORT"]) : 8901
                    );
            }
            // 라이선스 파일
            else if (licenseData == VIZCore3D.NET.Utility.LicenseHelper.LicenseData.FILE)
            {
                licenseResult = vizcore3d.License.LicenseFile(
                    licenseInfo.ContainsKey("LICENSE_FILE") == true ? licenseInfo["LICENSE_FILE"] : String.Empty
                    );
            }

            // 인증 결과
            if (licenseResult != VIZCore3D.NET.Data.LicenseResults.SUCCESS)
            {
                MessageBox.Show(string.Format("LICENSE CODE : {0}", licenseResult.ToString()), "VIZCore3D.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            lvItems.Items.Clear();

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "VIZ File|*.viz";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() != DialogResult.OK) return;

            lvItems.BeginUpdate();

            foreach (string file in dlg.FileNames)
            {
                FileItem item = new FileItem(file);
                DataSource.Add(item);

                ListViewItem lvi = new ListViewItem(new string[] { item.Name, item.Length.ToString("N0"), "", "" });
                lvi.Tag = item;
                lvItems.Items.Add(lvi);
            }

            lvItems.EndUpdate();
        }

        private void btnClearFiles_Click(object sender, EventArgs e)
        {
            lvItems.Items.Clear();

            DataSource.Clear();
        }

        private void btnEncryptFiles_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword1.Text) == true)
            {
                MessageBox.Show("Password is null.", "Security", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ShdCore.NET
            SecurityManager securityFile = new SecurityManager();

            for (int i = 0; i < lvItems.Items.Count; i++)
            {
                ListViewItem item = lvItems.Items[i];

                if (item.Tag == null) continue;
                FileItem file = (FileItem)item.Tag;

                securityFile.EncryptFile(file.Input, txtPassword1.Text, file.Output);

                bool update = file.UpdateOutput();

                if (update == false) continue;

                item.SubItems[2].Text = file.OutputLength.ToString("N0");
                item.SubItems[3].Text = file.Ratio.ToString();

                lvItems.EnsureVisible(i);

                lvItems.Refresh();

                System.Threading.Thread.Sleep(10);
            }
        }

        private void btnOpenEncryptedFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "VIZ File|*.viz";
            dlg.Multiselect = false;
            if (dlg.ShowDialog() != DialogResult.OK) return;

            if (String.IsNullOrEmpty(txtPassword2.Text) == true)
                vizcore3d.Model.Open(dlg.FileName);
            else 
                vizcore3d.Model.Open(dlg.FileName, txtPassword2.Text);
        }

        private void btnOpenEncryptedStream_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "VIZ File|*.viz";
            dlg.Multiselect = false;
            if (dlg.ShowDialog() != DialogResult.OK) return;

            if (String.IsNullOrEmpty(txtPassword2.Text) == true)
                vizcore3d.Model.OpenStream(new VIZCore3D.NET.Data.StreamData(dlg.FileName));
            else
                vizcore3d.Model.OpenStream(new VIZCore3D.NET.Data.StreamData(dlg.FileName), txtPassword2.Text);
        }

        private void btnAddEncryptedFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "VIZ File|*.viz";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() != DialogResult.OK) return;

            if (String.IsNullOrEmpty(txtPassword2.Text) == true)
                vizcore3d.Model.Add(dlg.FileNames);
            else
                vizcore3d.Model.Add(dlg.FileNames, txtPassword2.Text);
        }

        private void btnAddEncryptedStream_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "VIZ File|*.viz";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() != DialogResult.OK) return;

            if (String.IsNullOrEmpty(txtPassword2.Text) == true)
                vizcore3d.Model.AddStream(VIZCore3D.NET.Data.StreamData.GetStreams(dlg.FileNames));
            else
                vizcore3d.Model.AddStream(VIZCore3D.NET.Data.StreamData.GetStreams(dlg.FileNames), txtPassword2.Text);
        }
    }
}
