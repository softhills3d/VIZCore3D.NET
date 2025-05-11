namespace VIZCore3D.NET.MultiControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbContainer1 = new System.Windows.Forms.GroupBox();
            this.gbContainer2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnExecute1 = new System.Windows.Forms.Button();
            this.btnExecute2 = new System.Windows.Forms.Button();
            this.btnExecute3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbContainer3)).BeginInit();
            this.gbContainer3.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnExecute1);
            this.splitContainer1.Panel1.Controls.Add(this.gbContainer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 659);
            this.splitContainer1.SplitterDistance = 428;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnExecute2);
            this.splitContainer2.Panel1.Controls.Add(this.gbContainer2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnExecute3);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(852, 659);
            this.splitContainer2.SplitterDistance = 460;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbContainer1
            // 
            this.gbContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContainer1.Location = new System.Drawing.Point(12, 58);
            this.gbContainer1.Name = "gbContainer1";
            this.gbContainer1.Size = new System.Drawing.Size(405, 589);
            this.gbContainer1.TabIndex = 0;
            this.gbContainer1.TabStop = false;
            this.gbContainer1.Text = "Run / New";
            // 
            // gbContainer2
            // 
            this.gbContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContainer2.Location = new System.Drawing.Point(11, 58);
            this.gbContainer2.Name = "gbContainer2";
            this.gbContainer2.Size = new System.Drawing.Size(437, 589);
            this.gbContainer2.TabIndex = 1;
            this.gbContainer2.TabStop = false;
            this.gbContainer2.Text = "New";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gbContainer3);
            this.groupBox3.Location = new System.Drawing.Point(14, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 589);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New (Multi)";
            // 
            // gbContainer3
            // 
            this.gbContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbContainer3.Location = new System.Drawing.Point(3, 17);
            this.gbContainer3.Name = "gbContainer3";
            this.gbContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.gbContainer3.Size = new System.Drawing.Size(351, 569);
            this.gbContainer3.SplitterDistance = 298;
            this.gbContainer3.TabIndex = 0;
            // 
            // btnExecute1
            // 
            this.btnExecute1.Location = new System.Drawing.Point(21, 18);
            this.btnExecute1.Name = "btnExecute1";
            this.btnExecute1.Size = new System.Drawing.Size(75, 23);
            this.btnExecute1.TabIndex = 1;
            this.btnExecute1.Text = "Execute";
            this.btnExecute1.UseVisualStyleBackColor = true;
            this.btnExecute1.Click += new System.EventHandler(this.btnExecute1_Click);
            // 
            // btnExecute2
            // 
            this.btnExecute2.Location = new System.Drawing.Point(11, 18);
            this.btnExecute2.Name = "btnExecute2";
            this.btnExecute2.Size = new System.Drawing.Size(75, 23);
            this.btnExecute2.TabIndex = 2;
            this.btnExecute2.Text = "Execute";
            this.btnExecute2.UseVisualStyleBackColor = true;
            this.btnExecute2.Click += new System.EventHandler(this.btnExecute2_Click);
            // 
            // btnExecute3
            // 
            this.btnExecute3.Location = new System.Drawing.Point(17, 18);
            this.btnExecute3.Name = "btnExecute3";
            this.btnExecute3.Size = new System.Drawing.Size(75, 23);
            this.btnExecute3.TabIndex = 3;
            this.btnExecute3.Text = "Execute";
            this.btnExecute3.UseVisualStyleBackColor = true;
            this.btnExecute3.Click += new System.EventHandler(this.btnExecute3_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 659);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.MultiControl";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbContainer3)).EndInit();
            this.gbContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnExecute1;
        private System.Windows.Forms.GroupBox gbContainer1;
        private System.Windows.Forms.Button btnExecute2;
        private System.Windows.Forms.GroupBox gbContainer2;
        private System.Windows.Forms.Button btnExecute3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer gbContainer3;
    }
}

