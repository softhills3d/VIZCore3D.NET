namespace VIZCore3D.NET.Joypad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuBarModel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarModelNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarModelOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarDeviceConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarDeviceDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarModel,
            this.menuBarDevice});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuBarModel
            // 
            this.menuBarModel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarModelNew,
            this.menuBarModelOpen});
            this.menuBarModel.Name = "menuBarModel";
            this.menuBarModel.Size = new System.Drawing.Size(53, 20);
            this.menuBarModel.Text = "Model";
            // 
            // menuBarModelNew
            // 
            this.menuBarModelNew.Name = "menuBarModelNew";
            this.menuBarModelNew.Size = new System.Drawing.Size(112, 22);
            this.menuBarModelNew.Text = "New";
            // 
            // menuBarModelOpen
            // 
            this.menuBarModelOpen.Name = "menuBarModelOpen";
            this.menuBarModelOpen.Size = new System.Drawing.Size(112, 22);
            this.menuBarModelOpen.Text = "Open...";
            // 
            // menuBarDevice
            // 
            this.menuBarDevice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarDeviceConnect,
            this.menuBarDeviceDisconnect});
            this.menuBarDevice.Name = "menuBarDevice";
            this.menuBarDevice.Size = new System.Drawing.Size(55, 20);
            this.menuBarDevice.Text = "Device";
            // 
            // menuBarDeviceConnect
            // 
            this.menuBarDeviceConnect.Name = "menuBarDeviceConnect";
            this.menuBarDeviceConnect.Size = new System.Drawing.Size(180, 22);
            this.menuBarDeviceConnect.Text = "Connect";
            this.menuBarDeviceConnect.Click += new System.EventHandler(this.menuBarDeviceConnect_Click);
            // 
            // menuBarDeviceDisconnect
            // 
            this.menuBarDeviceDisconnect.Name = "menuBarDeviceDisconnect";
            this.menuBarDeviceDisconnect.Size = new System.Drawing.Size(180, 22);
            this.menuBarDeviceDisconnect.Text = "Disconnect";
            this.menuBarDeviceDisconnect.Click += new System.EventHandler(this.menuBarDeviceDisconnect_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 635);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            // 
            // btnConnect
            // 
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(25, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 43);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.Image")));
            this.btnDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisconnect.Location = new System.Drawing.Point(143, 30);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(113, 43);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 659);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VIZCore3D.NET.Joypad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuBarModel;
        private System.Windows.Forms.ToolStripMenuItem menuBarDevice;
        private System.Windows.Forms.ToolStripMenuItem menuBarDeviceConnect;
        private System.Windows.Forms.ToolStripMenuItem menuBarDeviceDisconnect;
        private System.Windows.Forms.ToolStripMenuItem menuBarModelNew;
        private System.Windows.Forms.ToolStripMenuItem menuBarModelOpen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
    }
}

