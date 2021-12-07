namespace VIZCore3D.NET.SimplifyBlockByPart
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
            this.btnExportModel = new System.Windows.Forms.Button();
            this.btnShowParts = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLinkModel = new System.Windows.Forms.Button();
            this.btnGenerateTree = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTriangleSet = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.btnSimplifyPart = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSingle = new System.Windows.Forms.TabPage();
            this.tpMulti = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExecuteMulti = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpSingle.SuspendLayout();
            this.tpMulti.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tcMain);
            this.splitContainer1.Size = new System.Drawing.Size(1123, 520);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnExportModel);
            this.groupBox4.Controls.Add(this.btnShowParts);
            this.groupBox4.Location = new System.Drawing.Point(6, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 72);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MODEL";
            // 
            // btnExportModel
            // 
            this.btnExportModel.Location = new System.Drawing.Point(125, 29);
            this.btnExportModel.Name = "btnExportModel";
            this.btnExportModel.Size = new System.Drawing.Size(90, 23);
            this.btnExportModel.TabIndex = 3;
            this.btnExportModel.Text = "Export";
            this.btnExportModel.UseVisualStyleBackColor = true;
            this.btnExportModel.Click += new System.EventHandler(this.btnExportModel_Click);
            // 
            // btnShowParts
            // 
            this.btnShowParts.Location = new System.Drawing.Point(20, 29);
            this.btnShowParts.Name = "btnShowParts";
            this.btnShowParts.Size = new System.Drawing.Size(90, 23);
            this.btnShowParts.TabIndex = 2;
            this.btnShowParts.Text = "Show";
            this.btnShowParts.UseVisualStyleBackColor = true;
            this.btnShowParts.Click += new System.EventHandler(this.btnShowParts_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnLinkModel);
            this.groupBox3.Controls.Add(this.btnGenerateTree);
            this.groupBox3.Location = new System.Drawing.Point(6, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MODEL TREE";
            // 
            // btnLinkModel
            // 
            this.btnLinkModel.Location = new System.Drawing.Point(125, 29);
            this.btnLinkModel.Name = "btnLinkModel";
            this.btnLinkModel.Size = new System.Drawing.Size(90, 23);
            this.btnLinkModel.TabIndex = 3;
            this.btnLinkModel.Text = "Link Model";
            this.btnLinkModel.UseVisualStyleBackColor = true;
            this.btnLinkModel.Click += new System.EventHandler(this.btnLinkModel_Click);
            // 
            // btnGenerateTree
            // 
            this.btnGenerateTree.Location = new System.Drawing.Point(20, 29);
            this.btnGenerateTree.Name = "btnGenerateTree";
            this.btnGenerateTree.Size = new System.Drawing.Size(90, 23);
            this.btnGenerateTree.TabIndex = 2;
            this.btnGenerateTree.Text = "Generate";
            this.btnGenerateTree.UseVisualStyleBackColor = true;
            this.btnGenerateTree.Click += new System.EventHandler(this.btnGenerateTree_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbTriangleSet);
            this.groupBox2.Controls.Add(this.rbTriangle);
            this.groupBox2.Controls.Add(this.btnSimplifyPart);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Location = new System.Drawing.Point(6, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task";
            // 
            // rbTriangleSet
            // 
            this.rbTriangleSet.AutoSize = true;
            this.rbTriangleSet.Checked = true;
            this.rbTriangleSet.Location = new System.Drawing.Point(105, 66);
            this.rbTriangleSet.Name = "rbTriangleSet";
            this.rbTriangleSet.Size = new System.Drawing.Size(91, 16);
            this.rbTriangleSet.TabIndex = 4;
            this.rbTriangleSet.TabStop = true;
            this.rbTriangleSet.Text = "Triangle Set";
            this.rbTriangleSet.UseVisualStyleBackColor = true;
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(20, 66);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(69, 16);
            this.rbTriangle.TabIndex = 3;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            // 
            // btnSimplifyPart
            // 
            this.btnSimplifyPart.Location = new System.Drawing.Point(125, 31);
            this.btnSimplifyPart.Name = "btnSimplifyPart";
            this.btnSimplifyPart.Size = new System.Drawing.Size(90, 23);
            this.btnSimplifyPart.TabIndex = 2;
            this.btnSimplifyPart.Text = "Simplify Part";
            this.btnSimplifyPart.UseVisualStyleBackColor = true;
            this.btnSimplifyPart.Click += new System.EventHandler(this.btnSimplifyPart_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(20, 31);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Part";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(245, 30);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(20, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(219, 21);
            this.txtInput.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpSingle);
            this.tcMain.Controls.Add(this.tpMulti);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(353, 496);
            this.tcMain.TabIndex = 5;
            // 
            // tpSingle
            // 
            this.tpSingle.Controls.Add(this.groupBox1);
            this.tpSingle.Controls.Add(this.groupBox4);
            this.tpSingle.Controls.Add(this.groupBox2);
            this.tpSingle.Controls.Add(this.groupBox3);
            this.tpSingle.Location = new System.Drawing.Point(4, 22);
            this.tpSingle.Name = "tpSingle";
            this.tpSingle.Padding = new System.Windows.Forms.Padding(3);
            this.tpSingle.Size = new System.Drawing.Size(345, 470);
            this.tpSingle.TabIndex = 0;
            this.tpSingle.Text = "Single";
            this.tpSingle.UseVisualStyleBackColor = true;
            // 
            // tpMulti
            // 
            this.tpMulti.Controls.Add(this.btnExecuteMulti);
            this.tpMulti.Controls.Add(this.groupBox6);
            this.tpMulti.Controls.Add(this.groupBox5);
            this.tpMulti.Location = new System.Drawing.Point(4, 22);
            this.tpMulti.Name = "tpMulti";
            this.tpMulti.Padding = new System.Windows.Forms.Padding(3);
            this.tpMulti.Size = new System.Drawing.Size(345, 470);
            this.tpMulti.TabIndex = 1;
            this.tpMulti.Text = "Multi";
            this.tpMulti.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnSelectFolder);
            this.groupBox5.Controls.Add(this.txtFolderPath);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(333, 72);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "INPUT PATH";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Location = new System.Drawing.Point(245, 30);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Select";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.Location = new System.Drawing.Point(20, 32);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(219, 21);
            this.txtFolderPath.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.lvFiles);
            this.groupBox6.Location = new System.Drawing.Point(6, 113);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(333, 351);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "FILES";
            // 
            // lvFiles
            // 
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.GridLines = true;
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(6, 20);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(321, 325);
            this.lvFiles.TabIndex = 0;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 93;
            // 
            // btnExecuteMulti
            // 
            this.btnExecuteMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecuteMulti.Location = new System.Drawing.Point(264, 84);
            this.btnExecuteMulti.Name = "btnExecuteMulti";
            this.btnExecuteMulti.Size = new System.Drawing.Size(75, 23);
            this.btnExecuteMulti.TabIndex = 3;
            this.btnExecuteMulti.Text = "Run";
            this.btnExecuteMulti.UseVisualStyleBackColor = true;
            this.btnExecuteMulti.Click += new System.EventHandler(this.btnExecuteMulti_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 520);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simplify Block By Part";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpSingle.ResumeLayout(false);
            this.tpMulti.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSimplifyPart;
        private System.Windows.Forms.RadioButton rbTriangleSet;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenerateTree;
        private System.Windows.Forms.Button btnLinkModel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExportModel;
        private System.Windows.Forms.Button btnShowParts;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpSingle;
        private System.Windows.Forms.TabPage tpMulti;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnExecuteMulti;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

