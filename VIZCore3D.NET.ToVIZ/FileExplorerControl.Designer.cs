namespace VIZCore3D.NET.ToVIZ
{
    partial class FileExplorerControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckRVT = new System.Windows.Forms.CheckBox();
            this.ckRVM = new System.Windows.Forms.CheckBox();
            this.ckREV = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnToVIZ = new System.Windows.Forms.Button();
            this.btnToVIZConversion = new System.Windows.Forms.Button();
            this.ckVIZ = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSelectPath);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(97, 64);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(431, 21);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPath.Location = new System.Drawing.Point(552, 32);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 1;
            this.btnSelectPath.Text = "Select";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Location = new System.Drawing.Point(97, 32);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(431, 21);
            this.txtSource.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ckVIZ);
            this.groupBox2.Controls.Add(this.ckRVT);
            this.groupBox2.Controls.Add(this.ckRVM);
            this.groupBox2.Controls.Add(this.ckREV);
            this.groupBox2.Location = new System.Drawing.Point(4, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // ckRVT
            // 
            this.ckRVT.AutoSize = true;
            this.ckRVT.Location = new System.Drawing.Point(228, 32);
            this.ckRVT.Name = "ckRVT";
            this.ckRVT.Size = new System.Drawing.Size(48, 16);
            this.ckRVT.TabIndex = 2;
            this.ckRVT.Text = "RVT";
            this.ckRVT.UseVisualStyleBackColor = true;
            // 
            // ckRVM
            // 
            this.ckRVM.AutoSize = true;
            this.ckRVM.Checked = true;
            this.ckRVM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRVM.Location = new System.Drawing.Point(131, 32);
            this.ckRVM.Name = "ckRVM";
            this.ckRVM.Size = new System.Drawing.Size(51, 16);
            this.ckRVM.TabIndex = 1;
            this.ckRVM.Text = "RVM";
            this.ckRVM.UseVisualStyleBackColor = true;
            // 
            // ckREV
            // 
            this.ckREV.AutoSize = true;
            this.ckREV.Checked = true;
            this.ckREV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckREV.Location = new System.Drawing.Point(46, 32);
            this.ckREV.Name = "ckREV";
            this.ckREV.Size = new System.Drawing.Size(48, 16);
            this.ckREV.TabIndex = 0;
            this.ckREV.Text = "REV";
            this.ckREV.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lvFiles);
            this.groupBox3.Location = new System.Drawing.Point(4, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 446);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Files";
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.GridLines = true;
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(3, 17);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(645, 426);
            this.lvFiles.TabIndex = 0;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 169;
            // 
            // btnToVIZ
            // 
            this.btnToVIZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToVIZ.Location = new System.Drawing.Point(271, 213);
            this.btnToVIZ.Name = "btnToVIZ";
            this.btnToVIZ.Size = new System.Drawing.Size(155, 23);
            this.btnToVIZ.TabIndex = 3;
            this.btnToVIZ.Text = "To VIZ (Export Mode)";
            this.btnToVIZ.UseVisualStyleBackColor = true;
            this.btnToVIZ.Click += new System.EventHandler(this.btnToVIZ_Click);
            // 
            // btnToVIZConversion
            // 
            this.btnToVIZConversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToVIZConversion.Location = new System.Drawing.Point(448, 213);
            this.btnToVIZConversion.Name = "btnToVIZConversion";
            this.btnToVIZConversion.Size = new System.Drawing.Size(183, 23);
            this.btnToVIZConversion.TabIndex = 4;
            this.btnToVIZConversion.Text = "To VIZ (Conversion Mode)";
            this.btnToVIZConversion.UseVisualStyleBackColor = true;
            this.btnToVIZConversion.Click += new System.EventHandler(this.btnToVIZConversion_Click);
            // 
            // ckVIZ
            // 
            this.ckVIZ.AutoSize = true;
            this.ckVIZ.Location = new System.Drawing.Point(311, 32);
            this.ckVIZ.Name = "ckVIZ";
            this.ckVIZ.Size = new System.Drawing.Size(43, 16);
            this.ckVIZ.TabIndex = 3;
            this.ckVIZ.Text = "VIZ";
            this.ckVIZ.UseVisualStyleBackColor = true;
            // 
            // FileExplorerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnToVIZConversion);
            this.Controls.Add(this.btnToVIZ);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FileExplorerControl";
            this.Size = new System.Drawing.Size(658, 703);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckRVT;
        private System.Windows.Forms.CheckBox ckRVM;
        private System.Windows.Forms.CheckBox ckREV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnToVIZ;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnToVIZConversion;
        private System.Windows.Forms.CheckBox ckVIZ;
    }
}
