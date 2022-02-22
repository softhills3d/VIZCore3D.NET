namespace VIZCore3D.NET.Erection.V1
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDock = new System.Windows.Forms.TabPage();
            this.btnDockDelete = new System.Windows.Forms.Button();
            this.btnDockGenerate = new System.Windows.Forms.Button();
            this.ckDockSingle = new System.Windows.Forms.CheckBox();
            this.ckDockSideAll = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDockLength = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.txtDockBreadth = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.txtDockDepth = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAnimation = new System.Windows.Forms.TabPage();
            this.btnAnimationPause = new System.Windows.Forms.Button();
            this.btnAnimationPlay = new System.Windows.Forms.Button();
            this.btnAnimationGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbModelSimplified = new System.Windows.Forms.RadioButton();
            this.rbModelOutside = new System.Windows.Forms.RadioButton();
            this.rbModelVIZ = new System.Windows.Forms.RadioButton();
            this.btnImportModel = new System.Windows.Forms.Button();
            this.btnSimplified = new System.Windows.Forms.Button();
            this.btnOutside = new System.Windows.Forms.Button();
            this.btnLoadItems = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpDock.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpAnimation.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tcMain);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 656);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpDock);
            this.tcMain.Controls.Add(this.tpAnimation);
            this.tcMain.Location = new System.Drawing.Point(12, 409);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(457, 235);
            this.tcMain.TabIndex = 2;
            // 
            // tpDock
            // 
            this.tpDock.Controls.Add(this.btnDockDelete);
            this.tpDock.Controls.Add(this.btnDockGenerate);
            this.tpDock.Controls.Add(this.ckDockSingle);
            this.tpDock.Controls.Add(this.ckDockSideAll);
            this.tpDock.Controls.Add(this.tableLayoutPanel1);
            this.tpDock.Location = new System.Drawing.Point(4, 22);
            this.tpDock.Name = "tpDock";
            this.tpDock.Padding = new System.Windows.Forms.Padding(3);
            this.tpDock.Size = new System.Drawing.Size(449, 209);
            this.tpDock.TabIndex = 0;
            this.tpDock.Text = "DOCK";
            this.tpDock.UseVisualStyleBackColor = true;
            // 
            // btnDockDelete
            // 
            this.btnDockDelete.Location = new System.Drawing.Point(105, 118);
            this.btnDockDelete.Name = "btnDockDelete";
            this.btnDockDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDockDelete.TabIndex = 11;
            this.btnDockDelete.Text = "Delete";
            this.btnDockDelete.UseVisualStyleBackColor = true;
            this.btnDockDelete.Click += new System.EventHandler(this.btnDockDelete_Click);
            // 
            // btnDockGenerate
            // 
            this.btnDockGenerate.Location = new System.Drawing.Point(11, 118);
            this.btnDockGenerate.Name = "btnDockGenerate";
            this.btnDockGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnDockGenerate.TabIndex = 10;
            this.btnDockGenerate.Text = "Generate";
            this.btnDockGenerate.UseVisualStyleBackColor = true;
            this.btnDockGenerate.Click += new System.EventHandler(this.btnDockGenerate_Click);
            // 
            // ckDockSingle
            // 
            this.ckDockSingle.AutoSize = true;
            this.ckDockSingle.Location = new System.Drawing.Point(11, 85);
            this.ckDockSingle.Name = "ckDockSingle";
            this.ckDockSingle.Size = new System.Drawing.Size(98, 16);
            this.ckDockSingle.TabIndex = 9;
            this.ckDockSingle.Text = "Single Model";
            this.ckDockSingle.UseVisualStyleBackColor = true;
            // 
            // ckDockSideAll
            // 
            this.ckDockSideAll.AutoSize = true;
            this.ckDockSideAll.Checked = true;
            this.ckDockSideAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDockSideAll.Location = new System.Drawing.Point(11, 63);
            this.ckDockSideAll.Name = "ckDockSideAll";
            this.ckDockSideAll.Size = new System.Drawing.Size(67, 16);
            this.ckDockSideAll.TabIndex = 8;
            this.ckDockSideAll.Text = "Side All";
            this.ckDockSideAll.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDockLength, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDockBreadth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDockDepth, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 45);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Breadth (m)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depth (m)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDockLength
            // 
            this.txtDockLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDockLength.Location = new System.Drawing.Point(3, 21);
            this.txtDockLength.Name = "txtDockLength";
            this.txtDockLength.Size = new System.Drawing.Size(138, 21);
            this.txtDockLength.TabIndex = 3;
            this.txtDockLength.Text = "220";
            this.txtDockLength.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtDockLength.WatermarkColor = System.Drawing.Color.Gray;
            this.txtDockLength.WatermarkText = "";
            // 
            // txtDockBreadth
            // 
            this.txtDockBreadth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDockBreadth.Location = new System.Drawing.Point(147, 21);
            this.txtDockBreadth.Name = "txtDockBreadth";
            this.txtDockBreadth.Size = new System.Drawing.Size(138, 21);
            this.txtDockBreadth.TabIndex = 4;
            this.txtDockBreadth.Text = "70";
            this.txtDockBreadth.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtDockBreadth.WatermarkColor = System.Drawing.Color.Gray;
            this.txtDockBreadth.WatermarkText = "";
            // 
            // txtDockDepth
            // 
            this.txtDockDepth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDockDepth.Location = new System.Drawing.Point(291, 21);
            this.txtDockDepth.Name = "txtDockDepth";
            this.txtDockDepth.Size = new System.Drawing.Size(143, 21);
            this.txtDockDepth.TabIndex = 5;
            this.txtDockDepth.Text = "20";
            this.txtDockDepth.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtDockDepth.WatermarkColor = System.Drawing.Color.Gray;
            this.txtDockDepth.WatermarkText = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Length (m)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpAnimation
            // 
            this.tpAnimation.Controls.Add(this.btnAnimationPause);
            this.tpAnimation.Controls.Add(this.btnAnimationPlay);
            this.tpAnimation.Controls.Add(this.btnAnimationGenerate);
            this.tpAnimation.Location = new System.Drawing.Point(4, 22);
            this.tpAnimation.Name = "tpAnimation";
            this.tpAnimation.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnimation.Size = new System.Drawing.Size(449, 209);
            this.tpAnimation.TabIndex = 1;
            this.tpAnimation.Text = "Animation";
            this.tpAnimation.UseVisualStyleBackColor = true;
            // 
            // btnAnimationPause
            // 
            this.btnAnimationPause.Location = new System.Drawing.Point(105, 53);
            this.btnAnimationPause.Name = "btnAnimationPause";
            this.btnAnimationPause.Size = new System.Drawing.Size(75, 23);
            this.btnAnimationPause.TabIndex = 5;
            this.btnAnimationPause.Text = "Pause";
            this.btnAnimationPause.UseVisualStyleBackColor = true;
            this.btnAnimationPause.Click += new System.EventHandler(this.btnAnimationPause_Click);
            // 
            // btnAnimationPlay
            // 
            this.btnAnimationPlay.Location = new System.Drawing.Point(15, 53);
            this.btnAnimationPlay.Name = "btnAnimationPlay";
            this.btnAnimationPlay.Size = new System.Drawing.Size(75, 23);
            this.btnAnimationPlay.TabIndex = 4;
            this.btnAnimationPlay.Text = "Play";
            this.btnAnimationPlay.UseVisualStyleBackColor = true;
            this.btnAnimationPlay.Click += new System.EventHandler(this.btnAnimationPlay_Click);
            // 
            // btnAnimationGenerate
            // 
            this.btnAnimationGenerate.Location = new System.Drawing.Point(15, 15);
            this.btnAnimationGenerate.Name = "btnAnimationGenerate";
            this.btnAnimationGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnAnimationGenerate.TabIndex = 3;
            this.btnAnimationGenerate.Text = "Generate";
            this.btnAnimationGenerate.UseVisualStyleBackColor = true;
            this.btnAnimationGenerate.Click += new System.EventHandler(this.btnAnimationGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rbModelSimplified);
            this.groupBox2.Controls.Add(this.rbModelOutside);
            this.groupBox2.Controls.Add(this.rbModelVIZ);
            this.groupBox2.Controls.Add(this.btnImportModel);
            this.groupBox2.Controls.Add(this.btnSimplified);
            this.groupBox2.Controls.Add(this.btnOutside);
            this.groupBox2.Controls.Add(this.btnLoadItems);
            this.groupBox2.Controls.Add(this.lvItems);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // rbModelSimplified
            // 
            this.rbModelSimplified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbModelSimplified.AutoSize = true;
            this.rbModelSimplified.Checked = true;
            this.rbModelSimplified.Location = new System.Drawing.Point(207, 280);
            this.rbModelSimplified.Name = "rbModelSimplified";
            this.rbModelSimplified.Size = new System.Drawing.Size(78, 16);
            this.rbModelSimplified.TabIndex = 7;
            this.rbModelSimplified.TabStop = true;
            this.rbModelSimplified.Text = "Simplified";
            this.rbModelSimplified.UseVisualStyleBackColor = true;
            // 
            // rbModelOutside
            // 
            this.rbModelOutside.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbModelOutside.AutoSize = true;
            this.rbModelOutside.Location = new System.Drawing.Point(135, 280);
            this.rbModelOutside.Name = "rbModelOutside";
            this.rbModelOutside.Size = new System.Drawing.Size(66, 16);
            this.rbModelOutside.TabIndex = 6;
            this.rbModelOutside.Text = "Outside";
            this.rbModelOutside.UseVisualStyleBackColor = true;
            // 
            // rbModelVIZ
            // 
            this.rbModelVIZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbModelVIZ.AutoSize = true;
            this.rbModelVIZ.Location = new System.Drawing.Point(87, 280);
            this.rbModelVIZ.Name = "rbModelVIZ";
            this.rbModelVIZ.Size = new System.Drawing.Size(42, 16);
            this.rbModelVIZ.TabIndex = 5;
            this.rbModelVIZ.Text = "VIZ";
            this.rbModelVIZ.UseVisualStyleBackColor = true;
            // 
            // btnImportModel
            // 
            this.btnImportModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportModel.Location = new System.Drawing.Point(6, 277);
            this.btnImportModel.Name = "btnImportModel";
            this.btnImportModel.Size = new System.Drawing.Size(75, 23);
            this.btnImportModel.TabIndex = 4;
            this.btnImportModel.Text = "Import";
            this.btnImportModel.UseVisualStyleBackColor = true;
            this.btnImportModel.Click += new System.EventHandler(this.btnImportModel_Click);
            // 
            // btnSimplified
            // 
            this.btnSimplified.Location = new System.Drawing.Point(190, 28);
            this.btnSimplified.Name = "btnSimplified";
            this.btnSimplified.Size = new System.Drawing.Size(105, 23);
            this.btnSimplified.TabIndex = 3;
            this.btnSimplified.Text = "Gen. Simplified";
            this.btnSimplified.UseVisualStyleBackColor = true;
            this.btnSimplified.Click += new System.EventHandler(this.btnSimplified_Click);
            // 
            // btnOutside
            // 
            this.btnOutside.Location = new System.Drawing.Point(87, 28);
            this.btnOutside.Name = "btnOutside";
            this.btnOutside.Size = new System.Drawing.Size(97, 23);
            this.btnOutside.TabIndex = 2;
            this.btnOutside.Text = "Gen. Outside";
            this.btnOutside.UseVisualStyleBackColor = true;
            this.btnOutside.Click += new System.EventHandler(this.btnOutside_Click);
            // 
            // btnLoadItems
            // 
            this.btnLoadItems.Location = new System.Drawing.Point(6, 28);
            this.btnLoadItems.Name = "btnLoadItems";
            this.btnLoadItems.Size = new System.Drawing.Size(75, 23);
            this.btnLoadItems.TabIndex = 1;
            this.btnLoadItems.Text = "Load";
            this.btnLoadItems.UseVisualStyleBackColor = true;
            this.btnLoadItems.Click += new System.EventHandler(this.btnLoadItems_Click);
            // 
            // lvItems
            // 
            this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(6, 57);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(445, 214);
            this.lvItems.TabIndex = 0;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "VIZ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Outside";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Simplified";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repository";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(376, 30);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(6, 30);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(364, 21);
            this.txtPath.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 656);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Erection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpDock.ResumeLayout(false);
            this.tpDock.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpAnimation.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnLoadItems;
        private System.Windows.Forms.Button btnSimplified;
        private System.Windows.Forms.Button btnOutside;
        private System.Windows.Forms.RadioButton rbModelSimplified;
        private System.Windows.Forms.RadioButton rbModelOutside;
        private System.Windows.Forms.RadioButton rbModelVIZ;
        private System.Windows.Forms.Button btnImportModel;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDock;
        private System.Windows.Forms.TabPage tpAnimation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.WatermarkTextBox txtDockLength;
        private Controls.WatermarkTextBox txtDockBreadth;
        private Controls.WatermarkTextBox txtDockDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDockDelete;
        private System.Windows.Forms.Button btnDockGenerate;
        private System.Windows.Forms.CheckBox ckDockSingle;
        private System.Windows.Forms.CheckBox ckDockSideAll;
        private System.Windows.Forms.Button btnAnimationPause;
        private System.Windows.Forms.Button btnAnimationPlay;
        private System.Windows.Forms.Button btnAnimationGenerate;
    }
}

