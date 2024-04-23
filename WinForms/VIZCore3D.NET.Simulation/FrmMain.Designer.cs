namespace VIZCore3D.NET.Simulation
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSetGroup = new System.Windows.Forms.Button();
            this.groupBoxSimulate = new System.Windows.Forms.GroupBox();
            this.ckClashTest = new System.Windows.Forms.CheckBox();
            this.btnClearSimulation = new System.Windows.Forms.Button();
            this.btnStartSimulation = new System.Windows.Forms.Button();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.lvPath = new System.Windows.Forms.ListView();
            this.columnHeaderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearPath = new System.Windows.Forms.Button();
            this.btnDeletePath = new System.Windows.Forms.Button();
            this.ckSetPath = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImportTransporter = new System.Windows.Forms.Button();
            this.btnImportBlock = new System.Windows.Forms.Button();
            this.btnImportYard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxSimulate.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxSimulate);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPath);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1297, 656);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnSetGroup);
            this.groupBox4.Location = new System.Drawing.Point(6, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 53);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Group";
            // 
            // btnSetGroup
            // 
            this.btnSetGroup.Location = new System.Drawing.Point(12, 20);
            this.btnSetGroup.Name = "btnSetGroup";
            this.btnSetGroup.Size = new System.Drawing.Size(101, 23);
            this.btnSetGroup.TabIndex = 0;
            this.btnSetGroup.Text = "Set Group";
            this.btnSetGroup.UseVisualStyleBackColor = true;
            this.btnSetGroup.Click += new System.EventHandler(this.btnSetGroup_Click);
            // 
            // groupBoxSimulate
            // 
            this.groupBoxSimulate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSimulate.Controls.Add(this.ckClashTest);
            this.groupBoxSimulate.Controls.Add(this.btnClearSimulation);
            this.groupBoxSimulate.Controls.Add(this.btnStartSimulation);
            this.groupBoxSimulate.Location = new System.Drawing.Point(12, 492);
            this.groupBoxSimulate.Name = "groupBoxSimulate";
            this.groupBoxSimulate.Size = new System.Drawing.Size(357, 79);
            this.groupBoxSimulate.TabIndex = 1;
            this.groupBoxSimulate.TabStop = false;
            this.groupBoxSimulate.Text = "Simulation";
            // 
            // ckClashTest
            // 
            this.ckClashTest.AutoSize = true;
            this.ckClashTest.Location = new System.Drawing.Point(6, 23);
            this.ckClashTest.Name = "ckClashTest";
            this.ckClashTest.Size = new System.Drawing.Size(86, 16);
            this.ckClashTest.TabIndex = 5;
            this.ckClashTest.Text = "Clash Test";
            this.ckClashTest.UseVisualStyleBackColor = true;
            // 
            // btnClearSimulation
            // 
            this.btnClearSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSimulation.Location = new System.Drawing.Point(113, 45);
            this.btnClearSimulation.Name = "btnClearSimulation";
            this.btnClearSimulation.Size = new System.Drawing.Size(102, 23);
            this.btnClearSimulation.TabIndex = 4;
            this.btnClearSimulation.Text = "Clear";
            this.btnClearSimulation.UseVisualStyleBackColor = true;
            this.btnClearSimulation.Click += new System.EventHandler(this.btnClearSimulation_Click);
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartSimulation.Location = new System.Drawing.Point(6, 45);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(101, 23);
            this.btnStartSimulation.TabIndex = 3;
            this.btnStartSimulation.Text = "Start";
            this.btnStartSimulation.UseVisualStyleBackColor = true;
            this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPath.Controls.Add(this.lvPath);
            this.groupBoxPath.Controls.Add(this.btnClearPath);
            this.groupBoxPath.Controls.Add(this.btnDeletePath);
            this.groupBoxPath.Controls.Add(this.ckSetPath);
            this.groupBoxPath.Location = new System.Drawing.Point(12, 132);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(357, 354);
            this.groupBoxPath.TabIndex = 1;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Set Path";
            // 
            // lvPath
            // 
            this.lvPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPath.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNo,
            this.columnHeaderX,
            this.columnHeaderY,
            this.columnHeaderZ});
            this.lvPath.FullRowSelect = true;
            this.lvPath.GridLines = true;
            this.lvPath.HideSelection = false;
            this.lvPath.Location = new System.Drawing.Point(6, 49);
            this.lvPath.Name = "lvPath";
            this.lvPath.Size = new System.Drawing.Size(345, 299);
            this.lvPath.TabIndex = 9;
            this.lvPath.UseCompatibleStateImageBehavior = false;
            this.lvPath.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNo
            // 
            this.columnHeaderNo.Text = "No";
            this.columnHeaderNo.Width = 40;
            // 
            // columnHeaderX
            // 
            this.columnHeaderX.Text = "X";
            this.columnHeaderX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderX.Width = 100;
            // 
            // columnHeaderY
            // 
            this.columnHeaderY.Text = "Y";
            this.columnHeaderY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderY.Width = 100;
            // 
            // columnHeaderZ
            // 
            this.columnHeaderZ.Text = "Z";
            this.columnHeaderZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderZ.Width = 100;
            // 
            // btnClearPath
            // 
            this.btnClearPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPath.Image = global::VIZCore3D.NET.Simulation.Properties.Resources.Trash_16x16;
            this.btnClearPath.Location = new System.Drawing.Point(317, 18);
            this.btnClearPath.Name = "btnClearPath";
            this.btnClearPath.Size = new System.Drawing.Size(34, 25);
            this.btnClearPath.TabIndex = 8;
            this.btnClearPath.UseVisualStyleBackColor = true;
            this.btnClearPath.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeletePath
            // 
            this.btnDeletePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePath.Image = global::VIZCore3D.NET.Simulation.Properties.Resources.Cancel_16x16;
            this.btnDeletePath.Location = new System.Drawing.Point(277, 18);
            this.btnDeletePath.Name = "btnDeletePath";
            this.btnDeletePath.Size = new System.Drawing.Size(34, 25);
            this.btnDeletePath.TabIndex = 7;
            this.btnDeletePath.UseVisualStyleBackColor = true;
            this.btnDeletePath.Click += new System.EventHandler(this.btnDeletePath_Click);
            // 
            // ckSetPath
            // 
            this.ckSetPath.AutoSize = true;
            this.ckSetPath.Location = new System.Drawing.Point(6, 24);
            this.ckSetPath.Name = "ckSetPath";
            this.ckSetPath.Size = new System.Drawing.Size(71, 16);
            this.ckSetPath.TabIndex = 3;
            this.ckSetPath.Text = "Set Path";
            this.ckSetPath.UseVisualStyleBackColor = true;
            this.ckSetPath.CheckedChanged += new System.EventHandler(this.ckSetPath_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnImportTransporter);
            this.groupBox1.Controls.Add(this.btnImportBlock);
            this.groupBox1.Controls.Add(this.btnImportYard);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // btnImportTransporter
            // 
            this.btnImportTransporter.Location = new System.Drawing.Point(113, 20);
            this.btnImportTransporter.Name = "btnImportTransporter";
            this.btnImportTransporter.Size = new System.Drawing.Size(130, 23);
            this.btnImportTransporter.TabIndex = 2;
            this.btnImportTransporter.Text = "Import Transporter";
            this.btnImportTransporter.UseVisualStyleBackColor = true;
            this.btnImportTransporter.Click += new System.EventHandler(this.btnImportTransporter_Click);
            // 
            // btnImportBlock
            // 
            this.btnImportBlock.Location = new System.Drawing.Point(249, 20);
            this.btnImportBlock.Name = "btnImportBlock";
            this.btnImportBlock.Size = new System.Drawing.Size(102, 23);
            this.btnImportBlock.TabIndex = 1;
            this.btnImportBlock.Text = "Import Block";
            this.btnImportBlock.UseVisualStyleBackColor = true;
            this.btnImportBlock.Click += new System.EventHandler(this.btnImportBlock_Click);
            // 
            // btnImportYard
            // 
            this.btnImportYard.Location = new System.Drawing.Point(6, 20);
            this.btnImportYard.Name = "btnImportYard";
            this.btnImportYard.Size = new System.Drawing.Size(101, 23);
            this.btnImportYard.TabIndex = 0;
            this.btnImportYard.Text = "Import Yard";
            this.btnImportYard.UseVisualStyleBackColor = true;
            this.btnImportYard.Click += new System.EventHandler(this.btnImportYard_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 656);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "VIZCore3D.NET.Simulation";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBoxSimulate.ResumeLayout(false);
            this.groupBoxSimulate.PerformLayout();
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxSimulate;
        private System.Windows.Forms.Button btnClearSimulation;
        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImportYard;
        private System.Windows.Forms.Button btnImportTransporter;
        private System.Windows.Forms.Button btnImportBlock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSetGroup;
        private System.Windows.Forms.CheckBox ckSetPath;
        private System.Windows.Forms.Button btnClearPath;
        private System.Windows.Forms.Button btnDeletePath;
        private System.Windows.Forms.ListView lvPath;
        private System.Windows.Forms.ColumnHeader columnHeaderX;
        private System.Windows.Forms.ColumnHeader columnHeaderY;
        private System.Windows.Forms.ColumnHeader columnHeaderNo;
        private System.Windows.Forms.CheckBox ckClashTest;
        private System.Windows.Forms.ColumnHeader columnHeaderZ;
    }
}

