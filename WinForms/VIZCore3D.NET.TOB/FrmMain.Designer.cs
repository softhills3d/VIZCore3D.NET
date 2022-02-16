namespace VIZCore3D.NET.TOB
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
            this.btnLoadGoliath = new System.Windows.Forms.Button();
            this.btnLoadBlock = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAlignCenterBlock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1081, 621);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLoadBlock);
            this.groupBox1.Controls.Add(this.btnLoadGoliath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Models";
            // 
            // btnLoadGoliath
            // 
            this.btnLoadGoliath.Location = new System.Drawing.Point(22, 20);
            this.btnLoadGoliath.Name = "btnLoadGoliath";
            this.btnLoadGoliath.Size = new System.Drawing.Size(75, 23);
            this.btnLoadGoliath.TabIndex = 0;
            this.btnLoadGoliath.Text = "GOLIATH";
            this.btnLoadGoliath.UseVisualStyleBackColor = true;
            this.btnLoadGoliath.Click += new System.EventHandler(this.btnLoadGoliath_Click);
            // 
            // btnLoadBlock
            // 
            this.btnLoadBlock.Location = new System.Drawing.Point(103, 20);
            this.btnLoadBlock.Name = "btnLoadBlock";
            this.btnLoadBlock.Size = new System.Drawing.Size(75, 23);
            this.btnLoadBlock.TabIndex = 1;
            this.btnLoadBlock.Text = "BLOCK";
            this.btnLoadBlock.UseVisualStyleBackColor = true;
            this.btnLoadBlock.Click += new System.EventHandler(this.btnLoadBlock_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAlignCenterBlock);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Align";
            // 
            // btnAlignCenterBlock
            // 
            this.btnAlignCenterBlock.Location = new System.Drawing.Point(22, 20);
            this.btnAlignCenterBlock.Name = "btnAlignCenterBlock";
            this.btnAlignCenterBlock.Size = new System.Drawing.Size(75, 23);
            this.btnAlignCenterBlock.TabIndex = 2;
            this.btnAlignCenterBlock.Text = "Center";
            this.btnAlignCenterBlock.UseVisualStyleBackColor = true;
            this.btnAlignCenterBlock.Click += new System.EventHandler(this.btnAlignCenterBlock_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 621);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.TOB";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadBlock;
        private System.Windows.Forms.Button btnLoadGoliath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAlignCenterBlock;
    }
}

