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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbEvent = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckEnableDepthTest = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckTransparent = new System.Windows.Forms.CheckBox();
            this.ckUseSymbol = new System.Windows.Forms.CheckBox();
            this.ckEnable = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGetSize = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1061, 701);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lbEvent);
            this.groupBox3.Location = new System.Drawing.Point(12, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 353);
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
            this.lbEvent.Size = new System.Drawing.Size(322, 333);
            this.lbEvent.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ckEnableDepthTest);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 79);
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
            this.groupBox1.Size = new System.Drawing.Size(328, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // ckTransparent
            // 
            this.ckTransparent.AutoSize = true;
            this.ckTransparent.Checked = true;
            this.ckTransparent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTransparent.Location = new System.Drawing.Point(49, 87);
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
            this.ckUseSymbol.Location = new System.Drawing.Point(49, 54);
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
            this.ckEnable.Location = new System.Drawing.Point(49, 19);
            this.ckEnable.Name = "ckEnable";
            this.ckEnable.Size = new System.Drawing.Size(63, 16);
            this.ckEnable.TabIndex = 0;
            this.ckEnable.Text = "Enable";
            this.ckEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtHeight);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtWidth);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnGetSize);
            this.groupBox4.Location = new System.Drawing.Point(12, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 114);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Size";
            // 
            // btnGetSize
            // 
            this.btnGetSize.Location = new System.Drawing.Point(39, 75);
            this.btnGetSize.Name = "btnGetSize";
            this.btnGetSize.Size = new System.Drawing.Size(75, 23);
            this.btnGetSize.TabIndex = 0;
            this.btnGetSize.Text = "Size";
            this.btnGetSize.UseVisualStyleBackColor = true;
            this.btnGetSize.Click += new System.EventHandler(this.btnGetSize_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(213, 31);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(65, 21);
            this.txtHeight.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(167, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "Height";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(71, 31);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ReadOnly = true;
            this.txtWidth.Size = new System.Drawing.Size(61, 21);
            this.txtWidth.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "Width";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGetSize;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label12;
    }
}

