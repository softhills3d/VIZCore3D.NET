namespace VIZCore3D.NET.ClashTest.V4
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
			this.btnClash = new System.Windows.Forms.Button();
			this.btnOpen2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ckClashEnable = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnOpen = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
			this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer1.Size = new System.Drawing.Size(1641, 871);
			this.splitContainer1.SplitterDistance = 402;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.btnClash);
			this.groupBox3.Controls.Add(this.btnOpen2);
			this.groupBox3.Location = new System.Drawing.Point(14, 214);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox3.Size = new System.Drawing.Size(378, 85);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Model + Primitive Manager Add";
			// 
			// btnClash
			// 
			this.btnClash.Location = new System.Drawing.Point(99, 36);
			this.btnClash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnClash.Name = "btnClash";
			this.btnClash.Size = new System.Drawing.Size(272, 29);
			this.btnClash.TabIndex = 1;
			this.btnClash.Text = "Group Clash (Model vs. Primitive)";
			this.btnClash.UseVisualStyleBackColor = true;
			this.btnClash.Click += new System.EventHandler(this.btnClash_Click);
			// 
			// btnOpen2
			// 
			this.btnOpen2.Location = new System.Drawing.Point(7, 36);
			this.btnOpen2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnOpen2.Name = "btnOpen2";
			this.btnOpen2.Size = new System.Drawing.Size(86, 29);
			this.btnOpen2.TabIndex = 0;
			this.btnOpen2.Text = "Open";
			this.btnOpen2.UseVisualStyleBackColor = true;
			this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.ckClashEnable);
			this.groupBox2.Location = new System.Drawing.Point(14, 108);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Size = new System.Drawing.Size(378, 99);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Clash Option";
			// 
			// ckClashEnable
			// 
			this.ckClashEnable.AutoSize = true;
			this.ckClashEnable.Location = new System.Drawing.Point(45, 42);
			this.ckClashEnable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ckClashEnable.Name = "ckClashEnable";
			this.ckClashEnable.Size = new System.Drawing.Size(73, 19);
			this.ckClashEnable.TabIndex = 0;
			this.ckClashEnable.Text = "Enable";
			this.ckClashEnable.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnOpen);
			this.groupBox1.Location = new System.Drawing.Point(14, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(378, 85);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Model";
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(45, 36);
			this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(86, 29);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1641, 871);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VIZCore3D.NET.ClashTest.V4";
			this.splitContainer1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckClashEnable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnOpen2;
		private System.Windows.Forms.Button btnClash;
	}
}

