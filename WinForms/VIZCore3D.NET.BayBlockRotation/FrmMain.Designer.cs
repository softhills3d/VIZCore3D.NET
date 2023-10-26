namespace VIZCore3D.NET.BayBlockRotation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImageHeight = new System.Windows.Forms.TextBox();
            this.txtImageWidth = new System.Windows.Forms.TextBox();
            this.btnExportImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadBlock = new System.Windows.Forms.Button();
            this.btnCreateBay = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRotateBlock = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenu.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1198, 689);
            this.splitContainer1.SplitterDistance = 399;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtImageHeight);
            this.groupBox2.Controls.Add(this.txtImageWidth);
            this.groupBox2.Controls.Add(this.btnExportImage);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export Image";
            // 
            // txtImageHeight
            // 
            this.txtImageHeight.Location = new System.Drawing.Point(117, 22);
            this.txtImageHeight.Name = "txtImageHeight";
            this.txtImageHeight.Size = new System.Drawing.Size(75, 21);
            this.txtImageHeight.TabIndex = 2;
            this.txtImageHeight.Text = "1024";
            // 
            // txtImageWidth
            // 
            this.txtImageWidth.Location = new System.Drawing.Point(26, 22);
            this.txtImageWidth.Name = "txtImageWidth";
            this.txtImageWidth.Size = new System.Drawing.Size(75, 21);
            this.txtImageWidth.TabIndex = 1;
            this.txtImageWidth.Text = "1024";
            // 
            // btnExportImage
            // 
            this.btnExportImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportImage.Location = new System.Drawing.Point(267, 20);
            this.btnExportImage.Name = "btnExportImage";
            this.btnExportImage.Size = new System.Drawing.Size(94, 23);
            this.btnExportImage.TabIndex = 0;
            this.btnExportImage.Text = "Export Image";
            this.btnExportImage.UseVisualStyleBackColor = true;
            this.btnExportImage.Click += new System.EventHandler(this.btnExportImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLoadBlock);
            this.groupBox1.Controls.Add(this.btnCreateBay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bay";
            // 
            // btnLoadBlock
            // 
            this.btnLoadBlock.Location = new System.Drawing.Point(117, 20);
            this.btnLoadBlock.Name = "btnLoadBlock";
            this.btnLoadBlock.Size = new System.Drawing.Size(75, 23);
            this.btnLoadBlock.TabIndex = 1;
            this.btnLoadBlock.Text = "Block";
            this.btnLoadBlock.UseVisualStyleBackColor = true;
            this.btnLoadBlock.Click += new System.EventHandler(this.btnLoadBlock_Click);
            // 
            // btnCreateBay
            // 
            this.btnCreateBay.Location = new System.Drawing.Point(26, 20);
            this.btnCreateBay.Name = "btnCreateBay";
            this.btnCreateBay.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBay.TabIndex = 0;
            this.btnCreateBay.Text = "Create";
            this.btnCreateBay.UseVisualStyleBackColor = true;
            this.btnCreateBay.Click += new System.EventHandler(this.btnCreateBay_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBlock,
            this.toolStripSeparator1,
            this.menuRotateBlock});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(142, 54);
            // 
            // menuBlock
            // 
            this.menuBlock.Name = "menuBlock";
            this.menuBlock.Size = new System.Drawing.Size(141, 22);
            this.menuBlock.Text = "BLOCK";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // menuRotateBlock
            // 
            this.menuRotateBlock.Name = "menuRotateBlock";
            this.menuRotateBlock.Size = new System.Drawing.Size(141, 22);
            this.menuRotateBlock.Text = "Rotate Block";
            this.menuRotateBlock.Click += new System.EventHandler(this.menuRotateBlock_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 689);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bay Block Rotation";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateBay;
        private System.Windows.Forms.Button btnLoadBlock;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuBlock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuRotateBlock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportImage;
        private System.Windows.Forms.TextBox txtImageHeight;
        private System.Windows.Forms.TextBox txtImageWidth;
    }
}

