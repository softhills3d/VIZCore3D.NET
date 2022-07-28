namespace VIZCore3D.NET.SectionVolume
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenModel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSectionPlane = new System.Windows.Forms.Button();
            this.btnSectionBox = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpClippedParts = new System.Windows.Forms.TabPage();
            this.tpErrorParts = new System.Windows.Forms.TabPage();
            this.lvClippedParts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvErrorParts = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckAuto = new System.Windows.Forms.CheckBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpClippedParts.SuspendLayout();
            this.tpErrorParts.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 549);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(787, 549);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpenModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // btnOpenModel
            // 
            this.btnOpenModel.Location = new System.Drawing.Point(16, 29);
            this.btnOpenModel.Name = "btnOpenModel";
            this.btnOpenModel.Size = new System.Drawing.Size(75, 23);
            this.btnOpenModel.TabIndex = 0;
            this.btnOpenModel.Text = "Open";
            this.btnOpenModel.UseVisualStyleBackColor = true;
            this.btnOpenModel.Click += new System.EventHandler(this.btnOpenModel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSectionBox);
            this.groupBox2.Controls.Add(this.btnSectionPlane);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Section";
            // 
            // btnSectionPlane
            // 
            this.btnSectionPlane.Location = new System.Drawing.Point(16, 24);
            this.btnSectionPlane.Name = "btnSectionPlane";
            this.btnSectionPlane.Size = new System.Drawing.Size(55, 23);
            this.btnSectionPlane.TabIndex = 1;
            this.btnSectionPlane.Text = "Plane";
            this.btnSectionPlane.UseVisualStyleBackColor = true;
            this.btnSectionPlane.Click += new System.EventHandler(this.btnSectionPlane_Click);
            // 
            // btnSectionBox
            // 
            this.btnSectionBox.Location = new System.Drawing.Point(77, 24);
            this.btnSectionBox.Name = "btnSectionBox";
            this.btnSectionBox.Size = new System.Drawing.Size(55, 23);
            this.btnSectionBox.TabIndex = 2;
            this.btnSectionBox.Text = "Box";
            this.btnSectionBox.UseVisualStyleBackColor = true;
            this.btnSectionBox.Click += new System.EventHandler(this.btnSectionBox_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpClippedParts);
            this.tabControl1.Controls.Add(this.tpErrorParts);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 245);
            this.tabControl1.TabIndex = 0;
            // 
            // tpClippedParts
            // 
            this.tpClippedParts.Controls.Add(this.lvClippedParts);
            this.tpClippedParts.Location = new System.Drawing.Point(4, 22);
            this.tpClippedParts.Name = "tpClippedParts";
            this.tpClippedParts.Padding = new System.Windows.Forms.Padding(3);
            this.tpClippedParts.Size = new System.Drawing.Size(779, 219);
            this.tpClippedParts.TabIndex = 0;
            this.tpClippedParts.Text = "Clipped Parts";
            this.tpClippedParts.UseVisualStyleBackColor = true;
            // 
            // tpErrorParts
            // 
            this.tpErrorParts.Controls.Add(this.lvErrorParts);
            this.tpErrorParts.Location = new System.Drawing.Point(4, 22);
            this.tpErrorParts.Name = "tpErrorParts";
            this.tpErrorParts.Padding = new System.Windows.Forms.Padding(3);
            this.tpErrorParts.Size = new System.Drawing.Size(779, 219);
            this.tpErrorParts.TabIndex = 1;
            this.tpErrorParts.Text = "Error Parts";
            this.tpErrorParts.UseVisualStyleBackColor = true;
            // 
            // lvClippedParts
            // 
            this.lvClippedParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvClippedParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvClippedParts.FullRowSelect = true;
            this.lvClippedParts.GridLines = true;
            this.lvClippedParts.HideSelection = false;
            this.lvClippedParts.Location = new System.Drawing.Point(3, 3);
            this.lvClippedParts.Name = "lvClippedParts";
            this.lvClippedParts.Size = new System.Drawing.Size(773, 213);
            this.lvClippedParts.TabIndex = 0;
            this.lvClippedParts.UseCompatibleStateImageBehavior = false;
            this.lvClippedParts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Parent";
            this.columnHeader3.Width = 197;
            // 
            // lvErrorParts
            // 
            this.lvErrorParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvErrorParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvErrorParts.FullRowSelect = true;
            this.lvErrorParts.GridLines = true;
            this.lvErrorParts.HideSelection = false;
            this.lvErrorParts.Location = new System.Drawing.Point(3, 3);
            this.lvErrorParts.Name = "lvErrorParts";
            this.lvErrorParts.Size = new System.Drawing.Size(773, 213);
            this.lvErrorParts.TabIndex = 1;
            this.lvErrorParts.UseCompatibleStateImageBehavior = false;
            this.lvErrorParts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Index";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 210;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Parent";
            this.columnHeader6.Width = 197;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnManual);
            this.groupBox3.Controls.Add(this.ckAuto);
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 64);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // ckAuto
            // 
            this.ckAuto.AutoSize = true;
            this.ckAuto.Location = new System.Drawing.Point(16, 32);
            this.ckAuto.Name = "ckAuto";
            this.ckAuto.Size = new System.Drawing.Size(49, 16);
            this.ckAuto.TabIndex = 0;
            this.ckAuto.Text = "Auto";
            this.ckAuto.UseVisualStyleBackColor = true;
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(77, 28);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(68, 23);
            this.btnManual.TabIndex = 3;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtVolume);
            this.groupBox4.Controls.Add(this.txtArea);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 133);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Geometry Property";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Volume";
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.Location = new System.Drawing.Point(16, 48);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(172, 21);
            this.txtArea.TabIndex = 2;
            // 
            // txtVolume
            // 
            this.txtVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVolume.Location = new System.Drawing.Point(16, 91);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(172, 21);
            this.txtVolume.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 549);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.SectionVolume";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpClippedParts.ResumeLayout(false);
            this.tpErrorParts.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSectionBox;
        private System.Windows.Forms.Button btnSectionPlane;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpClippedParts;
        private System.Windows.Forms.TabPage tpErrorParts;
        private System.Windows.Forms.ListView lvClippedParts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvErrorParts;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckAuto;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

