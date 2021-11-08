namespace VIZCore3D.NET.MoveWithMouse
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnArrowCenter = new System.Windows.Forms.Button();
            this.btnLineCenter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckDraftView = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnDisassemble = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckEnable = new System.Windows.Forms.CheckBox();
            this.ckEnableLine = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1211, 663);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ckEnableLine);
            this.groupBox4.Controls.Add(this.btnArrowCenter);
            this.groupBox4.Controls.Add(this.btnLineCenter);
            this.groupBox4.Location = new System.Drawing.Point(12, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 154);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Line";
            // 
            // btnArrowCenter
            // 
            this.btnArrowCenter.Location = new System.Drawing.Point(24, 112);
            this.btnArrowCenter.Name = "btnArrowCenter";
            this.btnArrowCenter.Size = new System.Drawing.Size(176, 23);
            this.btnArrowCenter.TabIndex = 1;
            this.btnArrowCenter.Text = "Arrow (Center To Center)";
            this.btnArrowCenter.UseVisualStyleBackColor = true;
            this.btnArrowCenter.Click += new System.EventHandler(this.btnArrowCenter_Click);
            // 
            // btnLineCenter
            // 
            this.btnLineCenter.Location = new System.Drawing.Point(24, 64);
            this.btnLineCenter.Name = "btnLineCenter";
            this.btnLineCenter.Size = new System.Drawing.Size(176, 23);
            this.btnLineCenter.TabIndex = 0;
            this.btnLineCenter.Text = "Line (Center To Center)";
            this.btnLineCenter.UseVisualStyleBackColor = true;
            this.btnLineCenter.Click += new System.EventHandler(this.btnLineCenter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ckDraftView);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // ckDraftView
            // 
            this.ckDraftView.AutoSize = true;
            this.ckDraftView.Location = new System.Drawing.Point(24, 20);
            this.ckDraftView.Name = "ckDraftView";
            this.ckDraftView.Size = new System.Drawing.Size(99, 16);
            this.ckDraftView.TabIndex = 0;
            this.ckDraftView.Text = "2D Draft Style";
            this.ckDraftView.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.btnDisassemble);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transform";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(115, 32);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnDisassemble
            // 
            this.btnDisassemble.Location = new System.Drawing.Point(19, 32);
            this.btnDisassemble.Name = "btnDisassemble";
            this.btnDisassemble.Size = new System.Drawing.Size(90, 23);
            this.btnDisassemble.TabIndex = 0;
            this.btnDisassemble.Text = "Disassemble";
            this.btnDisassemble.UseVisualStyleBackColor = true;
            this.btnDisassemble.Click += new System.EventHandler(this.btnDisassemble_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckEnable);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // ckEnable
            // 
            this.ckEnable.AutoSize = true;
            this.ckEnable.Location = new System.Drawing.Point(24, 30);
            this.ckEnable.Name = "ckEnable";
            this.ckEnable.Size = new System.Drawing.Size(176, 16);
            this.ckEnable.TabIndex = 0;
            this.ckEnable.Text = "Enable : Move With Mouse";
            this.ckEnable.UseVisualStyleBackColor = true;
            this.ckEnable.CheckedChanged += new System.EventHandler(this.ckEnable_CheckedChanged);
            // 
            // ckEnableLine
            // 
            this.ckEnableLine.AutoSize = true;
            this.ckEnableLine.Location = new System.Drawing.Point(24, 30);
            this.ckEnableLine.Name = "ckEnableLine";
            this.ckEnableLine.Size = new System.Drawing.Size(63, 16);
            this.ckEnableLine.TabIndex = 2;
            this.ckEnableLine.Text = "Enable";
            this.ckEnableLine.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 663);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.MoveWithMouse";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckEnable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnDisassemble;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckDraftView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLineCenter;
        private System.Windows.Forms.Button btnArrowCenter;
        private System.Windows.Forms.CheckBox ckEnableLine;
    }
}

