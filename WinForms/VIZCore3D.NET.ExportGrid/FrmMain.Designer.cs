namespace VIZCore3D.NET.ExportGrid
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModelClose = new System.Windows.Forms.Button();
            this.btnModelOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportGridReverse = new System.Windows.Forms.Button();
            this.btnExportGrid = new System.Windows.Forms.Button();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddBox = new System.Windows.Forms.Button();
            this.btnClearBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxZ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMinZ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMinY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinX = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtExportReversePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1MinSize = 243;
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModelClose);
            this.groupBox2.Controls.Add(this.btnModelOpen);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 63);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model";
            // 
            // btnModelClose
            // 
            this.btnModelClose.Location = new System.Drawing.Point(8, 24);
            this.btnModelClose.Name = "btnModelClose";
            this.btnModelClose.Size = new System.Drawing.Size(75, 23);
            this.btnModelClose.TabIndex = 26;
            this.btnModelClose.Text = "Close";
            this.btnModelClose.UseVisualStyleBackColor = true;
            this.btnModelClose.Click += new System.EventHandler(this.btnModelClose_Click);
            // 
            // btnModelOpen
            // 
            this.btnModelOpen.Location = new System.Drawing.Point(136, 24);
            this.btnModelOpen.Name = "btnModelOpen";
            this.btnModelOpen.Size = new System.Drawing.Size(75, 23);
            this.btnModelOpen.TabIndex = 26;
            this.btnModelOpen.Text = "Open";
            this.btnModelOpen.UseVisualStyleBackColor = true;
            this.btnModelOpen.Click += new System.EventHandler(this.btnModelOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportGrid);
            this.groupBox1.Controls.Add(this.txtExportPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 85);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // btnExportGridReverse
            // 
            this.btnExportGridReverse.Location = new System.Drawing.Point(118, 53);
            this.btnExportGridReverse.Name = "btnExportGridReverse";
            this.btnExportGridReverse.Size = new System.Drawing.Size(93, 23);
            this.btnExportGridReverse.TabIndex = 28;
            this.btnExportGridReverse.Text = "ExportReverse";
            this.btnExportGridReverse.UseVisualStyleBackColor = true;
            this.btnExportGridReverse.Click += new System.EventHandler(this.btnExportGridReverse_Click);
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Location = new System.Drawing.Point(118, 51);
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.Size = new System.Drawing.Size(93, 23);
            this.btnExportGrid.TabIndex = 27;
            this.btnExportGrid.Text = "ExportGrid";
            this.btnExportGrid.UseVisualStyleBackColor = true;
            this.btnExportGrid.Click += new System.EventHandler(this.btnExportGrid_Click);
            // 
            // txtExportPath
            // 
            this.txtExportPath.Location = new System.Drawing.Point(8, 20);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.Size = new System.Drawing.Size(203, 21);
            this.txtExportPath.TabIndex = 26;
            this.txtExportPath.Text = "C:\\Temp\\ExportGird.viz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddBox);
            this.groupBox3.Controls.Add(this.btnClearBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtMaxZ);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMaxY);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMaxX);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtMinZ);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMinY);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtMinX);
            this.groupBox3.Location = new System.Drawing.Point(12, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 143);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BoundBox";
            // 
            // btnAddBox
            // 
            this.btnAddBox.Location = new System.Drawing.Point(136, 103);
            this.btnAddBox.Name = "btnAddBox";
            this.btnAddBox.Size = new System.Drawing.Size(75, 23);
            this.btnAddBox.TabIndex = 0;
            this.btnAddBox.Text = "AddBox";
            this.btnAddBox.UseVisualStyleBackColor = true;
            this.btnAddBox.Click += new System.EventHandler(this.btnAddBox_Click);
            // 
            // btnClearBox
            // 
            this.btnClearBox.Location = new System.Drawing.Point(8, 103);
            this.btnClearBox.Name = "btnClearBox";
            this.btnClearBox.Size = new System.Drawing.Size(75, 23);
            this.btnClearBox.TabIndex = 25;
            this.btnClearBox.Text = "ClearBox";
            this.btnClearBox.UseVisualStyleBackColor = true;
            this.btnClearBox.Click += new System.EventHandler(this.btnClearBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "MaxZ";
            // 
            // txtMaxZ
            // 
            this.txtMaxZ.Location = new System.Drawing.Point(156, 72);
            this.txtMaxZ.Name = "txtMaxZ";
            this.txtMaxZ.Size = new System.Drawing.Size(55, 21);
            this.txtMaxZ.TabIndex = 25;
            this.txtMaxZ.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "MaxY";
            // 
            // txtMaxY
            // 
            this.txtMaxY.Location = new System.Drawing.Point(156, 45);
            this.txtMaxY.Name = "txtMaxY";
            this.txtMaxY.Size = new System.Drawing.Size(55, 21);
            this.txtMaxY.TabIndex = 23;
            this.txtMaxY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "MaxX";
            // 
            // txtMaxX
            // 
            this.txtMaxX.Location = new System.Drawing.Point(156, 18);
            this.txtMaxX.Name = "txtMaxX";
            this.txtMaxX.Size = new System.Drawing.Size(55, 21);
            this.txtMaxX.TabIndex = 21;
            this.txtMaxX.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "MinZ";
            // 
            // txtMinZ
            // 
            this.txtMinZ.Location = new System.Drawing.Point(46, 72);
            this.txtMinZ.Name = "txtMinZ";
            this.txtMinZ.Size = new System.Drawing.Size(55, 21);
            this.txtMinZ.TabIndex = 19;
            this.txtMinZ.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "MinY";
            // 
            // txtMinY
            // 
            this.txtMinY.Location = new System.Drawing.Point(46, 45);
            this.txtMinY.Name = "txtMinY";
            this.txtMinY.Size = new System.Drawing.Size(55, 21);
            this.txtMinY.TabIndex = 17;
            this.txtMinY.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "MinX";
            // 
            // txtMinX
            // 
            this.txtMinX.Location = new System.Drawing.Point(46, 18);
            this.txtMinX.Name = "txtMinX";
            this.txtMinX.Size = new System.Drawing.Size(55, 21);
            this.txtMinX.TabIndex = 15;
            this.txtMinX.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtExportReversePath);
            this.groupBox4.Controls.Add(this.btnExportGridReverse);
            this.groupBox4.Location = new System.Drawing.Point(12, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 89);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ExportReverse";
            // 
            // txtExportReversePath
            // 
            this.txtExportReversePath.Location = new System.Drawing.Point(8, 22);
            this.txtExportReversePath.Name = "txtExportReversePath";
            this.txtExportReversePath.Size = new System.Drawing.Size(203, 21);
            this.txtExportReversePath.TabIndex = 28;
            this.txtExportReversePath.Text = "C:\\Temp\\ExportGirdReverse.viz";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "VIZCore3D.NET.ExportGrid";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMinZ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMinX;
        private System.Windows.Forms.Button btnAddBox;
        private System.Windows.Forms.Button btnClearBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportGrid;
        private System.Windows.Forms.TextBox txtExportPath;
        private System.Windows.Forms.Button btnExportGridReverse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModelClose;
        private System.Windows.Forms.Button btnModelOpen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtExportReversePath;
    }
}

