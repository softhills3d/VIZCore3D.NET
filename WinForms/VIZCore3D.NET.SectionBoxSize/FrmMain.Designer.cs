namespace VIZCore3D.NET.SectionBoxSize
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenModel = new System.Windows.Forms.Button();
            this.btnOpenFrame = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddSectionBox = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMinX = new System.Windows.Forms.ComboBox();
            this.cbMaxX = new System.Windows.Forms.ComboBox();
            this.tbMinX = new System.Windows.Forms.TrackBar();
            this.tbMaxX = new System.Windows.Forms.TrackBar();
            this.tbMaxY = new System.Windows.Forms.TrackBar();
            this.tbMinY = new System.Windows.Forms.TrackBar();
            this.cbMaxY = new System.Windows.Forms.ComboBox();
            this.cbMinY = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaxZ = new System.Windows.Forms.TrackBar();
            this.tbMinZ = new System.Windows.Forms.TrackBar();
            this.cbMaxZ = new System.Windows.Forms.ComboBox();
            this.cbMinZ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinZ)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(1130, 687);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpenFrame);
            this.groupBox1.Controls.Add(this.btnOpenModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open";
            // 
            // btnOpenModel
            // 
            this.btnOpenModel.Location = new System.Drawing.Point(33, 20);
            this.btnOpenModel.Name = "btnOpenModel";
            this.btnOpenModel.Size = new System.Drawing.Size(75, 23);
            this.btnOpenModel.TabIndex = 0;
            this.btnOpenModel.Text = "Model";
            this.btnOpenModel.UseVisualStyleBackColor = true;
            this.btnOpenModel.Click += new System.EventHandler(this.btnOpenModel_Click);
            // 
            // btnOpenFrame
            // 
            this.btnOpenFrame.Location = new System.Drawing.Point(114, 20);
            this.btnOpenFrame.Name = "btnOpenFrame";
            this.btnOpenFrame.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFrame.TabIndex = 1;
            this.btnOpenFrame.Text = "Frame";
            this.btnOpenFrame.UseVisualStyleBackColor = true;
            this.btnOpenFrame.Click += new System.EventHandler(this.btnOpenFrame_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAddSectionBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Section";
            // 
            // btnAddSectionBox
            // 
            this.btnAddSectionBox.Location = new System.Drawing.Point(33, 20);
            this.btnAddSectionBox.Name = "btnAddSectionBox";
            this.btnAddSectionBox.Size = new System.Drawing.Size(75, 23);
            this.btnAddSectionBox.TabIndex = 0;
            this.btnAddSectionBox.Text = "Add Box";
            this.btnAddSectionBox.UseVisualStyleBackColor = true;
            this.btnAddSectionBox.Click += new System.EventHandler(this.btnAddSectionBox_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbMaxZ);
            this.groupBox3.Controls.Add(this.tbMinZ);
            this.groupBox3.Controls.Add(this.cbMaxZ);
            this.groupBox3.Controls.Add(this.cbMinZ);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbMaxY);
            this.groupBox3.Controls.Add(this.tbMinY);
            this.groupBox3.Controls.Add(this.cbMaxY);
            this.groupBox3.Controls.Add(this.cbMinY);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbMaxX);
            this.groupBox3.Controls.Add(this.tbMinX);
            this.groupBox3.Controls.Add(this.cbMaxX);
            this.groupBox3.Controls.Add(this.cbMinX);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 535);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Section Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // cbMinX
            // 
            this.cbMinX.FormattingEnabled = true;
            this.cbMinX.Location = new System.Drawing.Point(38, 31);
            this.cbMinX.Name = "cbMinX";
            this.cbMinX.Size = new System.Drawing.Size(121, 20);
            this.cbMinX.TabIndex = 1;
            this.cbMinX.SelectedIndexChanged += new System.EventHandler(this.cbMinX_SelectedIndexChanged);
            // 
            // cbMaxX
            // 
            this.cbMaxX.FormattingEnabled = true;
            this.cbMaxX.Location = new System.Drawing.Point(197, 31);
            this.cbMaxX.Name = "cbMaxX";
            this.cbMaxX.Size = new System.Drawing.Size(121, 20);
            this.cbMaxX.TabIndex = 2;
            this.cbMaxX.SelectedIndexChanged += new System.EventHandler(this.cbMaxX_SelectedIndexChanged);
            // 
            // tbMinX
            // 
            this.tbMinX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinX.Location = new System.Drawing.Point(6, 57);
            this.tbMinX.Name = "tbMinX";
            this.tbMinX.Size = new System.Drawing.Size(343, 45);
            this.tbMinX.TabIndex = 3;
            this.tbMinX.Scroll += new System.EventHandler(this.tbMinX_Scroll);
            // 
            // tbMaxX
            // 
            this.tbMaxX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxX.Location = new System.Drawing.Point(6, 108);
            this.tbMaxX.Name = "tbMaxX";
            this.tbMaxX.Size = new System.Drawing.Size(343, 45);
            this.tbMaxX.TabIndex = 4;
            this.tbMaxX.Scroll += new System.EventHandler(this.tbMaxX_Scroll);
            // 
            // tbMaxY
            // 
            this.tbMaxY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxY.Location = new System.Drawing.Point(6, 261);
            this.tbMaxY.Name = "tbMaxY";
            this.tbMaxY.Size = new System.Drawing.Size(343, 45);
            this.tbMaxY.TabIndex = 9;
            this.tbMaxY.Scroll += new System.EventHandler(this.tbMaxY_Scroll);
            // 
            // tbMinY
            // 
            this.tbMinY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinY.Location = new System.Drawing.Point(6, 210);
            this.tbMinY.Name = "tbMinY";
            this.tbMinY.Size = new System.Drawing.Size(343, 45);
            this.tbMinY.TabIndex = 8;
            this.tbMinY.Scroll += new System.EventHandler(this.tbMinY_Scroll);
            // 
            // cbMaxY
            // 
            this.cbMaxY.FormattingEnabled = true;
            this.cbMaxY.Location = new System.Drawing.Point(197, 184);
            this.cbMaxY.Name = "cbMaxY";
            this.cbMaxY.Size = new System.Drawing.Size(121, 20);
            this.cbMaxY.TabIndex = 7;
            this.cbMaxY.SelectedIndexChanged += new System.EventHandler(this.cbMaxY_SelectedIndexChanged);
            // 
            // cbMinY
            // 
            this.cbMinY.FormattingEnabled = true;
            this.cbMinY.Location = new System.Drawing.Point(38, 184);
            this.cbMinY.Name = "cbMinY";
            this.cbMinY.Size = new System.Drawing.Size(121, 20);
            this.cbMinY.TabIndex = 6;
            this.cbMinY.SelectedIndexChanged += new System.EventHandler(this.cbMinY_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // tbMaxZ
            // 
            this.tbMaxZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxZ.Location = new System.Drawing.Point(6, 424);
            this.tbMaxZ.Name = "tbMaxZ";
            this.tbMaxZ.Size = new System.Drawing.Size(343, 45);
            this.tbMaxZ.TabIndex = 14;
            this.tbMaxZ.Scroll += new System.EventHandler(this.tbMaxZ_Scroll);
            // 
            // tbMinZ
            // 
            this.tbMinZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinZ.Location = new System.Drawing.Point(6, 373);
            this.tbMinZ.Name = "tbMinZ";
            this.tbMinZ.Size = new System.Drawing.Size(343, 45);
            this.tbMinZ.TabIndex = 13;
            this.tbMinZ.Scroll += new System.EventHandler(this.tbMinZ_Scroll);
            // 
            // cbMaxZ
            // 
            this.cbMaxZ.FormattingEnabled = true;
            this.cbMaxZ.Location = new System.Drawing.Point(197, 347);
            this.cbMaxZ.Name = "cbMaxZ";
            this.cbMaxZ.Size = new System.Drawing.Size(121, 20);
            this.cbMaxZ.TabIndex = 12;
            this.cbMaxZ.SelectedIndexChanged += new System.EventHandler(this.cbMaxZ_SelectedIndexChanged);
            // 
            // cbMinZ
            // 
            this.cbMinZ.FormattingEnabled = true;
            this.cbMinZ.Location = new System.Drawing.Point(38, 347);
            this.cbMinZ.Name = "cbMinZ";
            this.cbMinZ.Size = new System.Drawing.Size(121, 20);
            this.cbMinZ.TabIndex = 11;
            this.cbMinZ.SelectedIndexChanged += new System.EventHandler(this.cbMinZ_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Z";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 687);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.SectionBoxSize";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenFrame;
        private System.Windows.Forms.Button btnOpenModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddSectionBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tbMaxZ;
        private System.Windows.Forms.TrackBar tbMinZ;
        private System.Windows.Forms.ComboBox cbMaxZ;
        private System.Windows.Forms.ComboBox cbMinZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbMaxY;
        private System.Windows.Forms.TrackBar tbMinY;
        private System.Windows.Forms.ComboBox cbMaxY;
        private System.Windows.Forms.ComboBox cbMinY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbMaxX;
        private System.Windows.Forms.TrackBar tbMinX;
        private System.Windows.Forms.ComboBox cbMaxX;
        private System.Windows.Forms.ComboBox cbMinX;
        private System.Windows.Forms.Label label1;
    }
}

