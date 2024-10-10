namespace VIZCore3D.NET.SectionClippedEdge
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.ckMulti = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbSectionBox = new System.Windows.Forms.RadioButton();
            this.rbSection = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.rbY = new System.Windows.Forms.RadioButton();
            this.rbZ = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1506, 713);
            this.splitContainer1.SplitterDistance = 694;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 542);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3D MODEL";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOffset);
            this.groupBox1.Controls.Add(this.ckMulti);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.rbSectionBox);
            this.groupBox1.Controls.Add(this.rbSection);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Offset: ";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(551, 23);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(100, 21);
            this.txtOffset.TabIndex = 6;
            this.txtOffset.Text = "3000";
            // 
            // ckMulti
            // 
            this.ckMulti.AutoSize = true;
            this.ckMulti.Location = new System.Drawing.Point(443, 27);
            this.ckMulti.Name = "ckMulti";
            this.ckMulti.Size = new System.Drawing.Size(51, 16);
            this.ckMulti.TabIndex = 5;
            this.ckMulti.Text = "Multi";
            this.ckMulti.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(362, 22);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbSectionBox
            // 
            this.rbSectionBox.AutoSize = true;
            this.rbSectionBox.Location = new System.Drawing.Point(182, 26);
            this.rbSectionBox.Name = "rbSectionBox";
            this.rbSectionBox.Size = new System.Drawing.Size(87, 16);
            this.rbSectionBox.TabIndex = 3;
            this.rbSectionBox.Text = "SectionBox";
            this.rbSectionBox.UseVisualStyleBackColor = true;
            this.rbSectionBox.CheckedChanged += new System.EventHandler(this.rbSectionBox_CheckedChanged);
            // 
            // rbSection
            // 
            this.rbSection.AutoSize = true;
            this.rbSection.Checked = true;
            this.rbSection.Location = new System.Drawing.Point(111, 26);
            this.rbSection.Name = "rbSection";
            this.rbSection.Size = new System.Drawing.Size(65, 16);
            this.rbSection.TabIndex = 2;
            this.rbSection.TabStop = true;
            this.rbSection.Text = "Section";
            this.rbSection.UseVisualStyleBackColor = true;
            this.rbSection.CheckedChanged += new System.EventHandler(this.rbSection_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(281, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Section";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 689);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clipped View";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rbZ);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtPosition);
            this.groupBox4.Controls.Add(this.btnClear2);
            this.groupBox4.Controls.Add(this.rbY);
            this.groupBox4.Controls.Add(this.rbX);
            this.groupBox4.Controls.Add(this.btnAddPosition);
            this.groupBox4.Location = new System.Drawing.Point(12, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(668, 58);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Section Position Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Position: ";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(286, 25);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 21);
            this.txtPosition.TabIndex = 6;
            this.txtPosition.Text = "3000";
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(392, 23);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(75, 23);
            this.btnClear2.TabIndex = 4;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Checked = true;
            this.rbX.Location = new System.Drawing.Point(111, 26);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(31, 16);
            this.rbX.TabIndex = 2;
            this.rbX.TabStop = true;
            this.rbX.Text = "X";
            this.rbX.UseVisualStyleBackColor = true;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new System.Drawing.Point(30, 23);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(75, 23);
            this.btnAddPosition.TabIndex = 0;
            this.btnAddPosition.Text = "Add Section";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // rbY
            // 
            this.rbY.AutoSize = true;
            this.rbY.Location = new System.Drawing.Point(148, 26);
            this.rbY.Name = "rbY";
            this.rbY.Size = new System.Drawing.Size(31, 16);
            this.rbY.TabIndex = 3;
            this.rbY.Text = "Y";
            this.rbY.UseVisualStyleBackColor = true;
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(185, 26);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(31, 16);
            this.rbZ.TabIndex = 8;
            this.rbZ.Text = "Z";
            this.rbZ.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 713);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Section";
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbSectionBox;
        private System.Windows.Forms.RadioButton rbSection;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox ckMulti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.RadioButton rbY;
        private System.Windows.Forms.RadioButton rbX;
        private System.Windows.Forms.Button btnAddPosition;
    }
}

