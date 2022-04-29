namespace VIZCore3D.NET.GridThreeD
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadGrid = new System.Windows.Forms.Button();
            this.btnExportGrid = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBoxClear = new System.Windows.Forms.Button();
            this.btnBoxAdd = new System.Windows.Forms.Button();
            this.txtBoxZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.toolbarDisassembly = new System.Windows.Forms.ToolStrip();
            this.btnDisassembly = new System.Windows.Forms.ToolStripButton();
            this.btnRestore = new System.Windows.Forms.ToolStripButton();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.toolbarGrid = new System.Windows.Forms.ToolStrip();
            this.btnGrid3D = new System.Windows.Forms.ToolStripButton();
            this.btnGrid2D = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarTree = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolbarDisassembly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.toolbarGrid.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1178, 557);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnLoadGrid);
            this.groupBox3.Controls.Add(this.btnExportGrid);
            this.groupBox3.Location = new System.Drawing.Point(12, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 51);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grid";
            // 
            // btnLoadGrid
            // 
            this.btnLoadGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadGrid.Image")));
            this.btnLoadGrid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadGrid.Location = new System.Drawing.Point(110, 18);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(85, 23);
            this.btnLoadGrid.TabIndex = 1;
            this.btnLoadGrid.Text = "Load";
            this.btnLoadGrid.UseVisualStyleBackColor = true;
            this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnExportGrid.Image")));
            this.btnExportGrid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportGrid.Location = new System.Drawing.Point(19, 18);
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.Size = new System.Drawing.Size(85, 23);
            this.btnExportGrid.TabIndex = 0;
            this.btnExportGrid.Text = "Export";
            this.btnExportGrid.UseVisualStyleBackColor = true;
            this.btnExportGrid.Click += new System.EventHandler(this.btnExportGrid_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBoxClear);
            this.groupBox2.Controls.Add(this.btnBoxAdd);
            this.groupBox2.Controls.Add(this.txtBoxZ);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxY);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBoxX);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bounding Box";
            // 
            // btnBoxClear
            // 
            this.btnBoxClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBoxClear.Image = ((System.Drawing.Image)(resources.GetObject("btnBoxClear.Image")));
            this.btnBoxClear.Location = new System.Drawing.Point(165, 57);
            this.btnBoxClear.Name = "btnBoxClear";
            this.btnBoxClear.Size = new System.Drawing.Size(37, 32);
            this.btnBoxClear.TabIndex = 7;
            this.btnBoxClear.UseVisualStyleBackColor = true;
            this.btnBoxClear.Click += new System.EventHandler(this.btnBoxClear_Click);
            // 
            // btnBoxAdd
            // 
            this.btnBoxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnBoxAdd.Image")));
            this.btnBoxAdd.Location = new System.Drawing.Point(122, 57);
            this.btnBoxAdd.Name = "btnBoxAdd";
            this.btnBoxAdd.Size = new System.Drawing.Size(37, 32);
            this.btnBoxAdd.TabIndex = 1;
            this.btnBoxAdd.UseVisualStyleBackColor = true;
            this.btnBoxAdd.Click += new System.EventHandler(this.btnBoxAdd_Click);
            // 
            // txtBoxZ
            // 
            this.txtBoxZ.Location = new System.Drawing.Point(165, 27);
            this.txtBoxZ.Name = "txtBoxZ";
            this.txtBoxZ.Size = new System.Drawing.Size(37, 21);
            this.txtBoxZ.TabIndex = 6;
            this.txtBoxZ.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z";
            // 
            // txtBoxY
            // 
            this.txtBoxY.Location = new System.Drawing.Point(102, 27);
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.Size = new System.Drawing.Size(37, 21);
            this.txtBoxY.TabIndex = 4;
            this.txtBoxY.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Y";
            // 
            // txtBoxX
            // 
            this.txtBoxX.Location = new System.Drawing.Point(37, 27);
            this.txtBoxX.Name = "txtBoxX";
            this.txtBoxX.Size = new System.Drawing.Size(37, 21);
            this.txtBoxX.TabIndex = 2;
            this.txtBoxX.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(19, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(944, 557);
            this.splitContainer2.SplitterDistance = 303;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.toolbarDisassembly);
            this.splitContainer3.Size = new System.Drawing.Size(944, 303);
            this.splitContainer3.SplitterDistance = 439;
            this.splitContainer3.TabIndex = 0;
            // 
            // toolbarDisassembly
            // 
            this.toolbarDisassembly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDisassembly,
            this.btnRestore});
            this.toolbarDisassembly.Location = new System.Drawing.Point(0, 0);
            this.toolbarDisassembly.Name = "toolbarDisassembly";
            this.toolbarDisassembly.Size = new System.Drawing.Size(501, 25);
            this.toolbarDisassembly.TabIndex = 0;
            this.toolbarDisassembly.Text = "toolStrip1";
            // 
            // btnDisassembly
            // 
            this.btnDisassembly.Image = ((System.Drawing.Image)(resources.GetObject("btnDisassembly.Image")));
            this.btnDisassembly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisassembly.Name = "btnDisassembly";
            this.btnDisassembly.Size = new System.Drawing.Size(93, 22);
            this.btnDisassembly.Text = "Disassembly";
            this.btnDisassembly.Click += new System.EventHandler(this.btnDisassembly_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(66, 22);
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.toolbarGrid);
            this.splitContainer4.Size = new System.Drawing.Size(944, 250);
            this.splitContainer4.SplitterDistance = 438;
            this.splitContainer4.TabIndex = 0;
            // 
            // toolbarGrid
            // 
            this.toolbarGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGrid3D,
            this.btnGrid2D,
            this.toolStripSeparator1,
            this.toolbarTree});
            this.toolbarGrid.Location = new System.Drawing.Point(0, 0);
            this.toolbarGrid.Name = "toolbarGrid";
            this.toolbarGrid.Size = new System.Drawing.Size(438, 25);
            this.toolbarGrid.TabIndex = 0;
            this.toolbarGrid.Text = "toolStrip2";
            // 
            // btnGrid3D
            // 
            this.btnGrid3D.Image = ((System.Drawing.Image)(resources.GetObject("btnGrid3D.Image")));
            this.btnGrid3D.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrid3D.Name = "btnGrid3D";
            this.btnGrid3D.Size = new System.Drawing.Size(43, 22);
            this.btnGrid3D.Text = "3D";
            this.btnGrid3D.Click += new System.EventHandler(this.btnGrid3D_Click);
            // 
            // btnGrid2D
            // 
            this.btnGrid2D.Image = ((System.Drawing.Image)(resources.GetObject("btnGrid2D.Image")));
            this.btnGrid2D.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGrid2D.Name = "btnGrid2D";
            this.btnGrid2D.Size = new System.Drawing.Size(43, 22);
            this.btnGrid2D.Text = "2D";
            this.btnGrid2D.Click += new System.EventHandler(this.btnGrid2D_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbarTree
            // 
            this.toolbarTree.Image = ((System.Drawing.Image)(resources.GetObject("toolbarTree.Image")));
            this.toolbarTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarTree.Name = "toolbarTree";
            this.toolbarTree.Size = new System.Drawing.Size(49, 22);
            this.toolbarTree.Text = "Tree";
            this.toolbarTree.Click += new System.EventHandler(this.toolbarTree_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 557);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET - 3D Grid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.toolbarDisassembly.ResumeLayout(false);
            this.toolbarDisassembly.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.toolbarGrid.ResumeLayout(false);
            this.toolbarGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ToolStrip toolbarDisassembly;
        private System.Windows.Forms.ToolStripButton btnDisassembly;
        private System.Windows.Forms.ToolStripButton btnRestore;
        private System.Windows.Forms.ToolStrip toolbarGrid;
        private System.Windows.Forms.ToolStripButton btnGrid3D;
        private System.Windows.Forms.ToolStripButton btnGrid2D;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxX;
        private System.Windows.Forms.Button btnBoxClear;
        private System.Windows.Forms.Button btnBoxAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExportGrid;
        private System.Windows.Forms.Button btnLoadGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolbarTree;
    }
}

