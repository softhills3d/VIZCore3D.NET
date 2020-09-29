namespace VIZCore3D.NET.AssembleHull
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpASP = new System.Windows.Forms.TabPage();
            this.ckShowOriginalLocation = new System.Windows.Forms.CheckBox();
            this.btnDisassembly = new System.Windows.Forms.Button();
            this.btnDeckBase = new System.Windows.Forms.Button();
            this.btnLoadASP = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDisassemblyGhost = new System.Windows.Forms.Button();
            this.btnDeckBaseGhost = new System.Windows.Forms.Button();
            this.btnLoadASPGhost = new System.Windows.Forms.Button();
            this.tpAnimation = new System.Windows.Forms.TabPage();
            this.btnDeck = new System.Windows.Forms.Button();
            this.btnLoadAnimation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCustomMenu = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpASP.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tpAnimation.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1386, 707);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpASP);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpAnimation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 707);
            this.tabControl1.TabIndex = 0;
            // 
            // tpASP
            // 
            this.tpASP.Controls.Add(this.ckShowOriginalLocation);
            this.tpASP.Controls.Add(this.btnDisassembly);
            this.tpASP.Controls.Add(this.btnDeckBase);
            this.tpASP.Controls.Add(this.btnLoadASP);
            this.tpASP.Location = new System.Drawing.Point(4, 22);
            this.tpASP.Name = "tpASP";
            this.tpASP.Padding = new System.Windows.Forms.Padding(3);
            this.tpASP.Size = new System.Drawing.Size(329, 681);
            this.tpASP.TabIndex = 0;
            this.tpASP.Text = "ASP";
            this.tpASP.UseVisualStyleBackColor = true;
            // 
            // ckShowOriginalLocation
            // 
            this.ckShowOriginalLocation.AutoSize = true;
            this.ckShowOriginalLocation.Location = new System.Drawing.Point(22, 158);
            this.ckShowOriginalLocation.Name = "ckShowOriginalLocation";
            this.ckShowOriginalLocation.Size = new System.Drawing.Size(155, 16);
            this.ckShowOriginalLocation.TabIndex = 3;
            this.ckShowOriginalLocation.Text = "Show Original Location";
            this.ckShowOriginalLocation.UseVisualStyleBackColor = true;
            // 
            // btnDisassembly
            // 
            this.btnDisassembly.Location = new System.Drawing.Point(22, 113);
            this.btnDisassembly.Name = "btnDisassembly";
            this.btnDisassembly.Size = new System.Drawing.Size(100, 23);
            this.btnDisassembly.TabIndex = 2;
            this.btnDisassembly.Text = "Disassembly";
            this.btnDisassembly.UseVisualStyleBackColor = true;
            this.btnDisassembly.Click += new System.EventHandler(this.btnDisassembly_Click);
            // 
            // btnDeckBase
            // 
            this.btnDeckBase.Location = new System.Drawing.Point(22, 68);
            this.btnDeckBase.Name = "btnDeckBase";
            this.btnDeckBase.Size = new System.Drawing.Size(100, 23);
            this.btnDeckBase.TabIndex = 1;
            this.btnDeckBase.Text = "DECK";
            this.btnDeckBase.UseVisualStyleBackColor = true;
            this.btnDeckBase.Click += new System.EventHandler(this.btnDeckBase_Click);
            // 
            // btnLoadASP
            // 
            this.btnLoadASP.Location = new System.Drawing.Point(22, 25);
            this.btnLoadASP.Name = "btnLoadASP";
            this.btnLoadASP.Size = new System.Drawing.Size(100, 23);
            this.btnLoadASP.TabIndex = 0;
            this.btnLoadASP.Text = "Load";
            this.btnLoadASP.UseVisualStyleBackColor = true;
            this.btnLoadASP.Click += new System.EventHandler(this.btnLoadASP_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDisassemblyGhost);
            this.tabPage2.Controls.Add(this.btnDeckBaseGhost);
            this.tabPage2.Controls.Add(this.btnLoadASPGhost);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(329, 681);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ASP (Ghost)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDisassemblyGhost
            // 
            this.btnDisassemblyGhost.Location = new System.Drawing.Point(22, 113);
            this.btnDisassemblyGhost.Name = "btnDisassemblyGhost";
            this.btnDisassemblyGhost.Size = new System.Drawing.Size(100, 23);
            this.btnDisassemblyGhost.TabIndex = 5;
            this.btnDisassemblyGhost.Text = "Disassembly";
            this.btnDisassemblyGhost.UseVisualStyleBackColor = true;
            this.btnDisassemblyGhost.Click += new System.EventHandler(this.btnDisassemblyGhost_Click);
            // 
            // btnDeckBaseGhost
            // 
            this.btnDeckBaseGhost.Location = new System.Drawing.Point(22, 68);
            this.btnDeckBaseGhost.Name = "btnDeckBaseGhost";
            this.btnDeckBaseGhost.Size = new System.Drawing.Size(100, 23);
            this.btnDeckBaseGhost.TabIndex = 4;
            this.btnDeckBaseGhost.Text = "DECK";
            this.btnDeckBaseGhost.UseVisualStyleBackColor = true;
            this.btnDeckBaseGhost.Click += new System.EventHandler(this.btnDeckBaseGhost_Click);
            // 
            // btnLoadASPGhost
            // 
            this.btnLoadASPGhost.Location = new System.Drawing.Point(22, 25);
            this.btnLoadASPGhost.Name = "btnLoadASPGhost";
            this.btnLoadASPGhost.Size = new System.Drawing.Size(100, 23);
            this.btnLoadASPGhost.TabIndex = 3;
            this.btnLoadASPGhost.Text = "Load";
            this.btnLoadASPGhost.UseVisualStyleBackColor = true;
            this.btnLoadASPGhost.Click += new System.EventHandler(this.btnLoadASPGhost_Click);
            // 
            // tpAnimation
            // 
            this.tpAnimation.Controls.Add(this.btnAddCustomMenu);
            this.tpAnimation.Controls.Add(this.groupBox1);
            this.tpAnimation.Controls.Add(this.btnDeck);
            this.tpAnimation.Controls.Add(this.btnLoadAnimation);
            this.tpAnimation.Location = new System.Drawing.Point(4, 22);
            this.tpAnimation.Name = "tpAnimation";
            this.tpAnimation.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnimation.Size = new System.Drawing.Size(329, 681);
            this.tpAnimation.TabIndex = 2;
            this.tpAnimation.Text = "Animation";
            this.tpAnimation.UseVisualStyleBackColor = true;
            // 
            // btnDeck
            // 
            this.btnDeck.Location = new System.Drawing.Point(183, 25);
            this.btnDeck.Name = "btnDeck";
            this.btnDeck.Size = new System.Drawing.Size(76, 23);
            this.btnDeck.TabIndex = 8;
            this.btnDeck.Text = "DECK";
            this.btnDeck.UseVisualStyleBackColor = true;
            this.btnDeck.Click += new System.EventHandler(this.btnDeck_Click);
            // 
            // btnLoadAnimation
            // 
            this.btnLoadAnimation.Location = new System.Drawing.Point(22, 25);
            this.btnLoadAnimation.Name = "btnLoadAnimation";
            this.btnLoadAnimation.Size = new System.Drawing.Size(140, 23);
            this.btnLoadAnimation.TabIndex = 0;
            this.btnLoadAnimation.Text = "Load";
            this.btnLoadAnimation.UseVisualStyleBackColor = true;
            this.btnLoadAnimation.Click += new System.EventHandler(this.btnLoadAnimation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panelView);
            this.groupBox1.Location = new System.Drawing.Point(8, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 308);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // btnAddCustomMenu
            // 
            this.btnAddCustomMenu.Location = new System.Drawing.Point(22, 66);
            this.btnAddCustomMenu.Name = "btnAddCustomMenu";
            this.btnAddCustomMenu.Size = new System.Drawing.Size(140, 23);
            this.btnAddCustomMenu.TabIndex = 10;
            this.btnAddCustomMenu.Text = "Add Custom Menu";
            this.btnAddCustomMenu.UseVisualStyleBackColor = true;
            this.btnAddCustomMenu.Click += new System.EventHandler(this.btnAddCustomMenu_Click);
            // 
            // panelView
            // 
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(3, 17);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(309, 288);
            this.panelView.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 707);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET Assemble The Hull";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpASP.ResumeLayout(false);
            this.tpASP.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tpAnimation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpASP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLoadASP;
        private System.Windows.Forms.Button btnDeckBase;
        private System.Windows.Forms.Button btnDisassembly;
        private System.Windows.Forms.CheckBox ckShowOriginalLocation;
        private System.Windows.Forms.Button btnDisassemblyGhost;
        private System.Windows.Forms.Button btnDeckBaseGhost;
        private System.Windows.Forms.Button btnLoadASPGhost;
        private System.Windows.Forms.TabPage tpAnimation;
        private System.Windows.Forms.Button btnLoadAnimation;
        private System.Windows.Forms.Button btnDeck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddCustomMenu;
        private System.Windows.Forms.Panel panelView;
    }
}

