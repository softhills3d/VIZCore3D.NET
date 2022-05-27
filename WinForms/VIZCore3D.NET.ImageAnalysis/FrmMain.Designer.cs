namespace VIZCore3D.NET.ImageAnalysis
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
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbTransform = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbAngle30 = new System.Windows.Forms.RadioButton();
            this.rbAngle33 = new System.Windows.Forms.RadioButton();
            this.rbAngle35 = new System.Windows.Forms.RadioButton();
            this.rbAngle38 = new System.Windows.Forms.RadioButton();
            this.rbAngle42 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDistance25 = new System.Windows.Forms.RadioButton();
            this.rbDistance19 = new System.Windows.Forms.RadioButton();
            this.rbDistance16 = new System.Windows.Forms.RadioButton();
            this.rbDistance13 = new System.Windows.Forms.RadioButton();
            this.rbDistance10 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtCameraPosition = new System.Windows.Forms.TextBox();
            this.btnCameraPosition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModelCenter = new System.Windows.Forms.Button();
            this.txtModelCenter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.btnApply);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(955, 542);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(223, 473);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.cbTransform);
            this.groupBox5.Location = new System.Drawing.Point(12, 405);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 62);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Transform";
            // 
            // cbTransform
            // 
            this.cbTransform.FormattingEnabled = true;
            this.cbTransform.Location = new System.Drawing.Point(21, 24);
            this.cbTransform.Name = "cbTransform";
            this.cbTransform.Size = new System.Drawing.Size(121, 20);
            this.cbTransform.TabIndex = 0;
            this.cbTransform.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rbAngle30);
            this.groupBox4.Controls.Add(this.rbAngle33);
            this.groupBox4.Controls.Add(this.rbAngle35);
            this.groupBox4.Controls.Add(this.rbAngle38);
            this.groupBox4.Controls.Add(this.rbAngle42);
            this.groupBox4.Location = new System.Drawing.Point(12, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 62);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Angle";
            // 
            // rbAngle30
            // 
            this.rbAngle30.AutoSize = true;
            this.rbAngle30.Location = new System.Drawing.Point(229, 30);
            this.rbAngle30.Name = "rbAngle30";
            this.rbAngle30.Size = new System.Drawing.Size(45, 16);
            this.rbAngle30.TabIndex = 8;
            this.rbAngle30.Text = "30.1";
            this.rbAngle30.UseVisualStyleBackColor = true;
            // 
            // rbAngle33
            // 
            this.rbAngle33.AutoSize = true;
            this.rbAngle33.Location = new System.Drawing.Point(177, 30);
            this.rbAngle33.Name = "rbAngle33";
            this.rbAngle33.Size = new System.Drawing.Size(45, 16);
            this.rbAngle33.TabIndex = 7;
            this.rbAngle33.Text = "33.7";
            this.rbAngle33.UseVisualStyleBackColor = true;
            // 
            // rbAngle35
            // 
            this.rbAngle35.AutoSize = true;
            this.rbAngle35.Location = new System.Drawing.Point(125, 30);
            this.rbAngle35.Name = "rbAngle35";
            this.rbAngle35.Size = new System.Drawing.Size(45, 16);
            this.rbAngle35.TabIndex = 6;
            this.rbAngle35.Text = "35.6";
            this.rbAngle35.UseVisualStyleBackColor = true;
            // 
            // rbAngle38
            // 
            this.rbAngle38.AutoSize = true;
            this.rbAngle38.Location = new System.Drawing.Point(73, 30);
            this.rbAngle38.Name = "rbAngle38";
            this.rbAngle38.Size = new System.Drawing.Size(45, 16);
            this.rbAngle38.TabIndex = 5;
            this.rbAngle38.Text = "38.4";
            this.rbAngle38.UseVisualStyleBackColor = true;
            // 
            // rbAngle42
            // 
            this.rbAngle42.AutoSize = true;
            this.rbAngle42.Checked = true;
            this.rbAngle42.Location = new System.Drawing.Point(21, 30);
            this.rbAngle42.Name = "rbAngle42";
            this.rbAngle42.Size = new System.Drawing.Size(45, 16);
            this.rbAngle42.TabIndex = 4;
            this.rbAngle42.TabStop = true;
            this.rbAngle42.Text = "42.6";
            this.rbAngle42.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rbDistance25);
            this.groupBox3.Controls.Add(this.rbDistance19);
            this.groupBox3.Controls.Add(this.rbDistance16);
            this.groupBox3.Controls.Add(this.rbDistance13);
            this.groupBox3.Controls.Add(this.rbDistance10);
            this.groupBox3.Location = new System.Drawing.Point(12, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 62);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distance";
            // 
            // rbDistance25
            // 
            this.rbDistance25.AutoSize = true;
            this.rbDistance25.Location = new System.Drawing.Point(229, 30);
            this.rbDistance25.Name = "rbDistance25";
            this.rbDistance25.Size = new System.Drawing.Size(46, 16);
            this.rbDistance25.TabIndex = 8;
            this.rbDistance25.Text = "25m";
            this.rbDistance25.UseVisualStyleBackColor = true;
            // 
            // rbDistance19
            // 
            this.rbDistance19.AutoSize = true;
            this.rbDistance19.Location = new System.Drawing.Point(177, 30);
            this.rbDistance19.Name = "rbDistance19";
            this.rbDistance19.Size = new System.Drawing.Size(46, 16);
            this.rbDistance19.TabIndex = 7;
            this.rbDistance19.Text = "19m";
            this.rbDistance19.UseVisualStyleBackColor = true;
            // 
            // rbDistance16
            // 
            this.rbDistance16.AutoSize = true;
            this.rbDistance16.Location = new System.Drawing.Point(125, 30);
            this.rbDistance16.Name = "rbDistance16";
            this.rbDistance16.Size = new System.Drawing.Size(46, 16);
            this.rbDistance16.TabIndex = 6;
            this.rbDistance16.Text = "16m";
            this.rbDistance16.UseVisualStyleBackColor = true;
            // 
            // rbDistance13
            // 
            this.rbDistance13.AutoSize = true;
            this.rbDistance13.Location = new System.Drawing.Point(73, 30);
            this.rbDistance13.Name = "rbDistance13";
            this.rbDistance13.Size = new System.Drawing.Size(46, 16);
            this.rbDistance13.TabIndex = 5;
            this.rbDistance13.Text = "13m";
            this.rbDistance13.UseVisualStyleBackColor = true;
            // 
            // rbDistance10
            // 
            this.rbDistance10.AutoSize = true;
            this.rbDistance10.Checked = true;
            this.rbDistance10.Location = new System.Drawing.Point(21, 30);
            this.rbDistance10.Name = "rbDistance10";
            this.rbDistance10.Size = new System.Drawing.Size(46, 16);
            this.rbDistance10.TabIndex = 4;
            this.rbDistance10.TabStop = true;
            this.rbDistance10.Text = "10m";
            this.rbDistance10.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "m";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(21, 20);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(41, 21);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Text = "14";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(21, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(46, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.btnModelCenter);
            this.groupBox6.Controls.Add(this.txtModelCenter);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.btnCameraPosition);
            this.groupBox6.Controls.Add(this.txtCameraPosition);
            this.groupBox6.Location = new System.Drawing.Point(12, 81);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(286, 123);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Position";
            // 
            // txtCameraPosition
            // 
            this.txtCameraPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCameraPosition.Location = new System.Drawing.Point(21, 42);
            this.txtCameraPosition.Name = "txtCameraPosition";
            this.txtCameraPosition.ReadOnly = true;
            this.txtCameraPosition.Size = new System.Drawing.Size(178, 21);
            this.txtCameraPosition.TabIndex = 1;
            // 
            // btnCameraPosition
            // 
            this.btnCameraPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCameraPosition.Location = new System.Drawing.Point(205, 42);
            this.btnCameraPosition.Name = "btnCameraPosition";
            this.btnCameraPosition.Size = new System.Drawing.Size(75, 23);
            this.btnCameraPosition.TabIndex = 12;
            this.btnCameraPosition.Text = "Get";
            this.btnCameraPosition.UseVisualStyleBackColor = true;
            this.btnCameraPosition.Click += new System.EventHandler(this.btnCameraPosition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Camera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Model Center";
            // 
            // btnModelCenter
            // 
            this.btnModelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModelCenter.Location = new System.Drawing.Point(205, 86);
            this.btnModelCenter.Name = "btnModelCenter";
            this.btnModelCenter.Size = new System.Drawing.Size(75, 23);
            this.btnModelCenter.TabIndex = 15;
            this.btnModelCenter.Text = "Get";
            this.btnModelCenter.UseVisualStyleBackColor = true;
            this.btnModelCenter.Click += new System.EventHandler(this.btnModelCenter_Click);
            // 
            // txtModelCenter
            // 
            this.txtModelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelCenter.Location = new System.Drawing.Point(21, 86);
            this.txtModelCenter.Name = "txtModelCenter";
            this.txtModelCenter.ReadOnly = true;
            this.txtModelCenter.Size = new System.Drawing.Size(178, 21);
            this.txtModelCenter.TabIndex = 14;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 542);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.ImageAnalysis";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbAngle30;
        private System.Windows.Forms.RadioButton rbAngle33;
        private System.Windows.Forms.RadioButton rbAngle35;
        private System.Windows.Forms.RadioButton rbAngle38;
        private System.Windows.Forms.RadioButton rbAngle42;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDistance25;
        private System.Windows.Forms.RadioButton rbDistance19;
        private System.Windows.Forms.RadioButton rbDistance16;
        private System.Windows.Forms.RadioButton rbDistance13;
        private System.Windows.Forms.RadioButton rbDistance10;
        private System.Windows.Forms.ComboBox cbTransform;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCameraPosition;
        private System.Windows.Forms.TextBox txtCameraPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModelCenter;
        private System.Windows.Forms.TextBox txtModelCenter;
        private System.Windows.Forms.Label label1;
    }
}

