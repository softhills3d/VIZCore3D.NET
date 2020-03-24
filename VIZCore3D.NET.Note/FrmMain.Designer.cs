namespace VIZCore3D.NET.Note
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
            this.label1 = new System.Windows.Forms.Label();
            this.ckEnableDepthTest = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckTransparent = new System.Windows.Forms.CheckBox();
            this.ckUseSymbol = new System.Windows.Forms.CheckBox();
            this.ckEnable = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbEvent = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 701);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ckEnableDepthTest);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Only Surface Note without Symbol)";
            // 
            // ckEnableDepthTest
            // 
            this.ckEnableDepthTest.AutoSize = true;
            this.ckEnableDepthTest.Location = new System.Drawing.Point(49, 33);
            this.ckEnableDepthTest.Name = "ckEnableDepthTest";
            this.ckEnableDepthTest.Size = new System.Drawing.Size(124, 16);
            this.ckEnableDepthTest.TabIndex = 0;
            this.ckEnableDepthTest.Text = "Enable DepthTest";
            this.ckEnableDepthTest.UseVisualStyleBackColor = true;
            this.ckEnableDepthTest.CheckedChanged += new System.EventHandler(this.ckEnableDepthTest_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckTransparent);
            this.groupBox1.Controls.Add(this.ckUseSymbol);
            this.groupBox1.Controls.Add(this.ckEnable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // ckTransparent
            // 
            this.ckTransparent.AutoSize = true;
            this.ckTransparent.Checked = true;
            this.ckTransparent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTransparent.Location = new System.Drawing.Point(49, 99);
            this.ckTransparent.Name = "ckTransparent";
            this.ckTransparent.Size = new System.Drawing.Size(92, 16);
            this.ckTransparent.TabIndex = 2;
            this.ckTransparent.Text = "Transparent";
            this.ckTransparent.UseVisualStyleBackColor = true;
            // 
            // ckUseSymbol
            // 
            this.ckUseSymbol.AutoSize = true;
            this.ckUseSymbol.Checked = true;
            this.ckUseSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckUseSymbol.Location = new System.Drawing.Point(49, 66);
            this.ckUseSymbol.Name = "ckUseSymbol";
            this.ckUseSymbol.Size = new System.Drawing.Size(93, 16);
            this.ckUseSymbol.TabIndex = 1;
            this.ckUseSymbol.Text = "Use Symbol";
            this.ckUseSymbol.UseVisualStyleBackColor = true;
            // 
            // ckEnable
            // 
            this.ckEnable.AutoSize = true;
            this.ckEnable.Checked = true;
            this.ckEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckEnable.Location = new System.Drawing.Point(49, 31);
            this.ckEnable.Name = "ckEnable";
            this.ckEnable.Size = new System.Drawing.Size(63, 16);
            this.ckEnable.TabIndex = 0;
            this.ckEnable.Text = "Enable";
            this.ckEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lbEvent);
            this.groupBox3.Location = new System.Drawing.Point(12, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 426);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event";
            // 
            // lbEvent
            // 
            this.lbEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEvent.FormattingEnabled = true;
            this.lbEvent.ItemHeight = 12;
            this.lbEvent.Location = new System.Drawing.Point(3, 17);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(322, 406);
            this.lbEvent.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 701);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Note";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckEnable;
        private System.Windows.Forms.CheckBox ckUseSymbol;
        private System.Windows.Forms.CheckBox ckTransparent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckEnableDepthTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbEvent;
    }
}

