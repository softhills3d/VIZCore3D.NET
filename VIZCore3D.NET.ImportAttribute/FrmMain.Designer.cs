namespace VIZCore3D.NET.ImportAttribute
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
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnImportDump = new System.Windows.Forms.ToolStripButton();
            this.btnCustomXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvAttribute = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImportMultiAttribute = new System.Windows.Forms.ToolStripButton();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportDump,
            this.btnCustomXML,
            this.btnImportMultiAttribute,
            this.toolStripSeparator1,
            this.btnExport,
            this.toolStripSeparator2,
            this.btnNew});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1356, 25);
            this.toolBar.TabIndex = 0;
            this.toolBar.Text = "toolStrip1";
            // 
            // btnImportDump
            // 
            this.btnImportDump.Image = ((System.Drawing.Image)(resources.GetObject("btnImportDump.Image")));
            this.btnImportDump.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportDump.Name = "btnImportDump";
            this.btnImportDump.Size = new System.Drawing.Size(123, 22);
            this.btnImportDump.Text = "Import Dump File";
            this.btnImportDump.Click += new System.EventHandler(this.btnImportDump_Click);
            // 
            // btnCustomXML
            // 
            this.btnCustomXML.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomXML.Image")));
            this.btnCustomXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomXML.Name = "btnCustomXML";
            this.btnCustomXML.Size = new System.Drawing.Size(137, 22);
            this.btnCustomXML.Text = "Import Custom XML";
            this.btnCustomXML.Click += new System.EventHandler(this.btnCustomXML_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(61, 22);
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 22);
            this.btnNew.Text = "Close Model";
            this.btnNew.ToolTipText = "Close Model";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvAttribute);
            this.splitContainer1.Size = new System.Drawing.Size(1356, 707);
            this.splitContainer1.SplitterDistance = 1038;
            this.splitContainer1.TabIndex = 1;
            // 
            // lvAttribute
            // 
            this.lvAttribute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAttribute.FullRowSelect = true;
            this.lvAttribute.GridLines = true;
            this.lvAttribute.HideSelection = false;
            this.lvAttribute.Location = new System.Drawing.Point(0, 0);
            this.lvAttribute.Name = "lvAttribute";
            this.lvAttribute.Size = new System.Drawing.Size(314, 707);
            this.lvAttribute.TabIndex = 1;
            this.lvAttribute.UseCompatibleStateImageBehavior = false;
            this.lvAttribute.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 150;
            // 
            // btnImportMultiAttribute
            // 
            this.btnImportMultiAttribute.Image = ((System.Drawing.Image)(resources.GetObject("btnImportMultiAttribute.Image")));
            this.btnImportMultiAttribute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportMultiAttribute.Name = "btnImportMultiAttribute";
            this.btnImportMultiAttribute.Size = new System.Drawing.Size(146, 22);
            this.btnImportMultiAttribute.Text = "Import Multi Attribute";
            this.btnImportMultiAttribute.Click += new System.EventHandler(this.btnImportMultiAttribute_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 732);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET Import Attribute File";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvAttribute;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripButton btnImportDump;
        private System.Windows.Forms.ToolStripButton btnCustomXML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnImportMultiAttribute;
    }
}

