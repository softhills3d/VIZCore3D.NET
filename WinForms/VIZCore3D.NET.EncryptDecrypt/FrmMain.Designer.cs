namespace VIZCore3D.NET.EncryptDecrypt
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpEncrypt = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvItems = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOutputLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOutputRatio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEncryptFiles = new System.Windows.Forms.Button();
            this.btnClearFiles = new System.Windows.Forms.Button();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.tpDecrypt = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddEncryptedStream = new System.Windows.Forms.Button();
            this.btnAddEncryptedFile = new System.Windows.Forms.Button();
            this.btnOpenEncryptedStream = new System.Windows.Forms.Button();
            this.btnOpenEncryptedFile = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpEncrypt.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpDecrypt.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpEncrypt);
            this.tcMain.Controls.Add(this.tpDecrypt);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1153, 767);
            this.tcMain.TabIndex = 0;
            // 
            // tpEncrypt
            // 
            this.tpEncrypt.Controls.Add(this.groupBox3);
            this.tpEncrypt.Controls.Add(this.groupBox2);
            this.tpEncrypt.Controls.Add(this.groupBox1);
            this.tpEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tpEncrypt.Name = "tpEncrypt";
            this.tpEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tpEncrypt.Size = new System.Drawing.Size(1145, 741);
            this.tpEncrypt.TabIndex = 0;
            this.tpEncrypt.Text = "Encrypt";
            this.tpEncrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPassword1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(19, 45);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(199, 21);
            this.txtPassword1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvItems);
            this.groupBox2.Location = new System.Drawing.Point(249, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 727);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // lvItems
            // 
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chLength,
            this.chOutputLength,
            this.chOutputRatio});
            this.lvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(3, 17);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(882, 707);
            this.lvItems.TabIndex = 1;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 168;
            // 
            // chLength
            // 
            this.chLength.Text = "Length";
            this.chLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chLength.Width = 194;
            // 
            // chOutputLength
            // 
            this.chOutputLength.Text = "Output";
            this.chOutputLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chOutputLength.Width = 197;
            // 
            // chOutputRatio
            // 
            this.chOutputRatio.Text = "Ratio";
            this.chOutputRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chOutputRatio.Width = 91;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEncryptFiles);
            this.groupBox1.Controls.Add(this.btnClearFiles);
            this.groupBox1.Controls.Add(this.btnAddFiles);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // btnEncryptFiles
            // 
            this.btnEncryptFiles.Location = new System.Drawing.Point(17, 101);
            this.btnEncryptFiles.Name = "btnEncryptFiles";
            this.btnEncryptFiles.Size = new System.Drawing.Size(201, 23);
            this.btnEncryptFiles.TabIndex = 2;
            this.btnEncryptFiles.Text = "Encrypt Files...";
            this.btnEncryptFiles.UseVisualStyleBackColor = true;
            this.btnEncryptFiles.Click += new System.EventHandler(this.btnEncryptFiles_Click);
            // 
            // btnClearFiles
            // 
            this.btnClearFiles.Location = new System.Drawing.Point(17, 58);
            this.btnClearFiles.Name = "btnClearFiles";
            this.btnClearFiles.Size = new System.Drawing.Size(201, 23);
            this.btnClearFiles.TabIndex = 1;
            this.btnClearFiles.Text = "Clear Files";
            this.btnClearFiles.UseVisualStyleBackColor = true;
            this.btnClearFiles.Click += new System.EventHandler(this.btnClearFiles_Click);
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Location = new System.Drawing.Point(17, 29);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(201, 23);
            this.btnAddFiles.TabIndex = 0;
            this.btnAddFiles.Text = "Add Files...";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // tpDecrypt
            // 
            this.tpDecrypt.Controls.Add(this.groupBox6);
            this.tpDecrypt.Controls.Add(this.groupBox4);
            this.tpDecrypt.Controls.Add(this.groupBox5);
            this.tpDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tpDecrypt.Name = "tpDecrypt";
            this.tpDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecrypt.Size = new System.Drawing.Size(1145, 741);
            this.tpDecrypt.TabIndex = 1;
            this.tpDecrypt.Text = "Decrypt";
            this.tpDecrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Location = new System.Drawing.Point(249, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(888, 729);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "VIZCore3D.NET";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPassword2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(8, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(19, 45);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(199, 21);
            this.txtPassword2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.btnAddEncryptedStream);
            this.groupBox5.Controls.Add(this.btnAddEncryptedFile);
            this.groupBox5.Controls.Add(this.btnOpenEncryptedStream);
            this.groupBox5.Controls.Add(this.btnOpenEncryptedFile);
            this.groupBox5.Location = new System.Drawing.Point(8, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 177);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Files";
            // 
            // btnAddEncryptedStream
            // 
            this.btnAddEncryptedStream.Location = new System.Drawing.Point(17, 138);
            this.btnAddEncryptedStream.Name = "btnAddEncryptedStream";
            this.btnAddEncryptedStream.Size = new System.Drawing.Size(201, 23);
            this.btnAddEncryptedStream.TabIndex = 3;
            this.btnAddEncryptedStream.Text = "Add Stream...";
            this.btnAddEncryptedStream.UseVisualStyleBackColor = true;
            this.btnAddEncryptedStream.Click += new System.EventHandler(this.btnAddEncryptedStream_Click);
            // 
            // btnAddEncryptedFile
            // 
            this.btnAddEncryptedFile.Location = new System.Drawing.Point(17, 109);
            this.btnAddEncryptedFile.Name = "btnAddEncryptedFile";
            this.btnAddEncryptedFile.Size = new System.Drawing.Size(201, 23);
            this.btnAddEncryptedFile.TabIndex = 2;
            this.btnAddEncryptedFile.Text = "Add File...";
            this.btnAddEncryptedFile.UseVisualStyleBackColor = true;
            this.btnAddEncryptedFile.Click += new System.EventHandler(this.btnAddEncryptedFile_Click);
            // 
            // btnOpenEncryptedStream
            // 
            this.btnOpenEncryptedStream.Location = new System.Drawing.Point(17, 58);
            this.btnOpenEncryptedStream.Name = "btnOpenEncryptedStream";
            this.btnOpenEncryptedStream.Size = new System.Drawing.Size(201, 23);
            this.btnOpenEncryptedStream.TabIndex = 1;
            this.btnOpenEncryptedStream.Text = "Open Stream...";
            this.btnOpenEncryptedStream.UseVisualStyleBackColor = true;
            this.btnOpenEncryptedStream.Click += new System.EventHandler(this.btnOpenEncryptedStream_Click);
            // 
            // btnOpenEncryptedFile
            // 
            this.btnOpenEncryptedFile.Location = new System.Drawing.Point(17, 29);
            this.btnOpenEncryptedFile.Name = "btnOpenEncryptedFile";
            this.btnOpenEncryptedFile.Size = new System.Drawing.Size(201, 23);
            this.btnOpenEncryptedFile.TabIndex = 0;
            this.btnOpenEncryptedFile.Text = "Open File...";
            this.btnOpenEncryptedFile.UseVisualStyleBackColor = true;
            this.btnOpenEncryptedFile.Click += new System.EventHandler(this.btnOpenEncryptedFile_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 767);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt / Decrypt VIZ";
            this.tcMain.ResumeLayout(false);
            this.tpEncrypt.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tpDecrypt.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpEncrypt;
        private System.Windows.Forms.TabPage tpDecrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearFiles;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLength;
        private System.Windows.Forms.ColumnHeader chOutputLength;
        private System.Windows.Forms.ColumnHeader chOutputRatio;
        private System.Windows.Forms.Button btnEncryptFiles;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnOpenEncryptedFile;
        private System.Windows.Forms.Button btnOpenEncryptedStream;
        private System.Windows.Forms.Button btnAddEncryptedStream;
        private System.Windows.Forms.Button btnAddEncryptedFile;
    }
}

