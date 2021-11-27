namespace VIZCore3D.NET.Painting
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
            this.btnSelectColor1 = new System.Windows.Forms.Button();
            this.btnSelectColor2 = new System.Windows.Forms.Button();
            this.btnSelectColor3 = new System.Windows.Forms.Button();
            this.rbColor1 = new System.Windows.Forms.RadioButton();
            this.rbColor2 = new System.Windows.Forms.RadioButton();
            this.rbColor3 = new System.Windows.Forms.RadioButton();
            this.btnSetColor1 = new System.Windows.Forms.Button();
            this.btnSetColor2 = new System.Windows.Forms.Button();
            this.btnSetColor3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckSetColorByDefaultColor = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSetColorSelectedObject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPalette = new System.Windows.Forms.ComboBox();
            this.ckChildren = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1310, 729);
            this.splitContainer1.SplitterDistance = 448;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSetColor3);
            this.groupBox1.Controls.Add(this.btnSetColor2);
            this.groupBox1.Controls.Add(this.btnSetColor1);
            this.groupBox1.Controls.Add(this.rbColor3);
            this.groupBox1.Controls.Add(this.rbColor2);
            this.groupBox1.Controls.Add(this.rbColor1);
            this.groupBox1.Controls.Add(this.btnSelectColor3);
            this.groupBox1.Controls.Add(this.btnSelectColor2);
            this.groupBox1.Controls.Add(this.btnSelectColor1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Palette";
            // 
            // btnSelectColor1
            // 
            this.btnSelectColor1.Location = new System.Drawing.Point(141, 26);
            this.btnSelectColor1.Name = "btnSelectColor1";
            this.btnSelectColor1.Size = new System.Drawing.Size(131, 23);
            this.btnSelectColor1.TabIndex = 1;
            this.btnSelectColor1.Text = "Select";
            this.btnSelectColor1.UseVisualStyleBackColor = true;
            this.btnSelectColor1.Click += new System.EventHandler(this.btnSelectColor1_Click);
            // 
            // btnSelectColor2
            // 
            this.btnSelectColor2.Location = new System.Drawing.Point(141, 67);
            this.btnSelectColor2.Name = "btnSelectColor2";
            this.btnSelectColor2.Size = new System.Drawing.Size(131, 23);
            this.btnSelectColor2.TabIndex = 3;
            this.btnSelectColor2.Text = "Select";
            this.btnSelectColor2.UseVisualStyleBackColor = true;
            this.btnSelectColor2.Click += new System.EventHandler(this.btnSelectColor2_Click);
            // 
            // btnSelectColor3
            // 
            this.btnSelectColor3.Location = new System.Drawing.Point(141, 106);
            this.btnSelectColor3.Name = "btnSelectColor3";
            this.btnSelectColor3.Size = new System.Drawing.Size(131, 23);
            this.btnSelectColor3.TabIndex = 5;
            this.btnSelectColor3.Text = "Select";
            this.btnSelectColor3.UseVisualStyleBackColor = true;
            this.btnSelectColor3.Click += new System.EventHandler(this.btnSelectColor3_Click);
            // 
            // rbColor1
            // 
            this.rbColor1.AutoSize = true;
            this.rbColor1.Checked = true;
            this.rbColor1.Location = new System.Drawing.Point(59, 29);
            this.rbColor1.Name = "rbColor1";
            this.rbColor1.Size = new System.Drawing.Size(63, 16);
            this.rbColor1.TabIndex = 6;
            this.rbColor1.TabStop = true;
            this.rbColor1.Text = "Color 1";
            this.rbColor1.UseVisualStyleBackColor = true;
            // 
            // rbColor2
            // 
            this.rbColor2.AutoSize = true;
            this.rbColor2.Location = new System.Drawing.Point(59, 70);
            this.rbColor2.Name = "rbColor2";
            this.rbColor2.Size = new System.Drawing.Size(63, 16);
            this.rbColor2.TabIndex = 7;
            this.rbColor2.Text = "Color 2";
            this.rbColor2.UseVisualStyleBackColor = true;
            // 
            // rbColor3
            // 
            this.rbColor3.AutoSize = true;
            this.rbColor3.Location = new System.Drawing.Point(59, 109);
            this.rbColor3.Name = "rbColor3";
            this.rbColor3.Size = new System.Drawing.Size(63, 16);
            this.rbColor3.TabIndex = 8;
            this.rbColor3.Text = "Color 3";
            this.rbColor3.UseVisualStyleBackColor = true;
            // 
            // btnSetColor1
            // 
            this.btnSetColor1.Location = new System.Drawing.Point(278, 26);
            this.btnSetColor1.Name = "btnSetColor1";
            this.btnSetColor1.Size = new System.Drawing.Size(53, 23);
            this.btnSetColor1.TabIndex = 9;
            this.btnSetColor1.Text = "Set";
            this.btnSetColor1.UseVisualStyleBackColor = true;
            this.btnSetColor1.Click += new System.EventHandler(this.btnSetColor1_Click);
            // 
            // btnSetColor2
            // 
            this.btnSetColor2.Location = new System.Drawing.Point(278, 67);
            this.btnSetColor2.Name = "btnSetColor2";
            this.btnSetColor2.Size = new System.Drawing.Size(53, 23);
            this.btnSetColor2.TabIndex = 10;
            this.btnSetColor2.Text = "Set";
            this.btnSetColor2.UseVisualStyleBackColor = true;
            this.btnSetColor2.Click += new System.EventHandler(this.btnSetColor2_Click);
            // 
            // btnSetColor3
            // 
            this.btnSetColor3.Location = new System.Drawing.Point(278, 106);
            this.btnSetColor3.Name = "btnSetColor3";
            this.btnSetColor3.Size = new System.Drawing.Size(53, 23);
            this.btnSetColor3.TabIndex = 11;
            this.btnSetColor3.Text = "Set";
            this.btnSetColor3.UseVisualStyleBackColor = true;
            this.btnSetColor3.Click += new System.EventHandler(this.btnSetColor3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ckSetColorByDefaultColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event";
            // 
            // ckSetColorByDefaultColor
            // 
            this.ckSetColorByDefaultColor.AutoSize = true;
            this.ckSetColorByDefaultColor.Location = new System.Drawing.Point(59, 30);
            this.ckSetColorByDefaultColor.Name = "ckSetColorByDefaultColor";
            this.ckSetColorByDefaultColor.Size = new System.Drawing.Size(155, 16);
            this.ckSetColorByDefaultColor.TabIndex = 0;
            this.ckSetColorByDefaultColor.Text = "Auto : Set Default Color";
            this.ckSetColorByDefaultColor.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ckChildren);
            this.groupBox3.Controls.Add(this.cbPalette);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnSetColorSelectedObject);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Objects";
            // 
            // btnSetColorSelectedObject
            // 
            this.btnSetColorSelectedObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetColorSelectedObject.Location = new System.Drawing.Point(332, 44);
            this.btnSetColorSelectedObject.Name = "btnSetColorSelectedObject";
            this.btnSetColorSelectedObject.Size = new System.Drawing.Size(75, 23);
            this.btnSetColorSelectedObject.TabIndex = 0;
            this.btnSetColorSelectedObject.Text = "Set Color";
            this.btnSetColorSelectedObject.UseVisualStyleBackColor = true;
            this.btnSetColorSelectedObject.Click += new System.EventHandler(this.btnSetColorSelectedObject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Palette";
            // 
            // cbPalette
            // 
            this.cbPalette.FormattingEnabled = true;
            this.cbPalette.Location = new System.Drawing.Point(106, 46);
            this.cbPalette.Name = "cbPalette";
            this.cbPalette.Size = new System.Drawing.Size(121, 20);
            this.cbPalette.TabIndex = 2;
            // 
            // ckChildren
            // 
            this.ckChildren.AutoSize = true;
            this.ckChildren.Location = new System.Drawing.Point(233, 48);
            this.ckChildren.Name = "ckChildren";
            this.ckChildren.Size = new System.Drawing.Size(71, 16);
            this.ckChildren.TabIndex = 3;
            this.ckChildren.Text = "Children";
            this.ckChildren.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 729);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Painting";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectColor1;
        private System.Windows.Forms.Button btnSelectColor2;
        private System.Windows.Forms.Button btnSelectColor3;
        private System.Windows.Forms.RadioButton rbColor3;
        private System.Windows.Forms.RadioButton rbColor2;
        private System.Windows.Forms.RadioButton rbColor1;
        private System.Windows.Forms.Button btnSetColor3;
        private System.Windows.Forms.Button btnSetColor2;
        private System.Windows.Forms.Button btnSetColor1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckSetColorByDefaultColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckChildren;
        private System.Windows.Forms.ComboBox cbPalette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetColorSelectedObject;
    }
}

