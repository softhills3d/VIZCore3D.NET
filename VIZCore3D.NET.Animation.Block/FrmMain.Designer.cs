namespace VIZCore3D.NET.Animation.Block
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
            this.btnSetMaterialSea = new System.Windows.Forms.Button();
            this.btnSetMaterialDock = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowGroup = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.btnGenerateAnimation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadCrane = new System.Windows.Forms.Button();
            this.btnCreateDock = new System.Windows.Forms.Button();
            this.btnLoadBlock = new System.Windows.Forms.Button();
            this.btnSky = new System.Windows.Forms.Button();
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
            this.splitContainer1.Size = new System.Drawing.Size(1159, 602);
            this.splitContainer1.SplitterDistance = 472;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnSky);
            this.groupBox4.Controls.Add(this.btnSetMaterialSea);
            this.groupBox4.Controls.Add(this.btnSetMaterialDock);
            this.groupBox4.Location = new System.Drawing.Point(12, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(447, 86);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Material";
            // 
            // btnSetMaterialSea
            // 
            this.btnSetMaterialSea.Location = new System.Drawing.Point(117, 20);
            this.btnSetMaterialSea.Name = "btnSetMaterialSea";
            this.btnSetMaterialSea.Size = new System.Drawing.Size(75, 45);
            this.btnSetMaterialSea.TabIndex = 3;
            this.btnSetMaterialSea.Text = "Sea";
            this.btnSetMaterialSea.UseVisualStyleBackColor = true;
            this.btnSetMaterialSea.Click += new System.EventHandler(this.btnSetMaterialSea_Click);
            // 
            // btnSetMaterialDock
            // 
            this.btnSetMaterialDock.Location = new System.Drawing.Point(21, 20);
            this.btnSetMaterialDock.Name = "btnSetMaterialDock";
            this.btnSetMaterialDock.Size = new System.Drawing.Size(75, 45);
            this.btnSetMaterialDock.TabIndex = 2;
            this.btnSetMaterialDock.Text = "Dock";
            this.btnSetMaterialDock.UseVisualStyleBackColor = true;
            this.btnSetMaterialDock.Click += new System.EventHandler(this.btnSetMaterialDock_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnPause);
            this.groupBox3.Controls.Add(this.btnPlay);
            this.groupBox3.Location = new System.Drawing.Point(12, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animation";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(233, 37);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(127, 37);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(21, 37);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnShowGroup);
            this.groupBox2.Controls.Add(this.cbGroup);
            this.groupBox2.Controls.Add(this.btnGenerateAnimation);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animation Creation";
            // 
            // btnShowGroup
            // 
            this.btnShowGroup.Location = new System.Drawing.Point(279, 33);
            this.btnShowGroup.Name = "btnShowGroup";
            this.btnShowGroup.Size = new System.Drawing.Size(103, 23);
            this.btnShowGroup.TabIndex = 3;
            this.btnShowGroup.Text = "Show Group";
            this.btnShowGroup.UseVisualStyleBackColor = true;
            this.btnShowGroup.Click += new System.EventHandler(this.btnShowGroup_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Items.AddRange(new object[] {
            "GROUP 01",
            "GROUP 02",
            "GROUP 03",
            "GROUP 04",
            "GROUP 05",
            "GROUP 06",
            "GROUP 07",
            "GROUP 08",
            "GROUP 09",
            "GROUP 10",
            "GROUP 11",
            "GROUP 12"});
            this.cbGroup.Location = new System.Drawing.Point(152, 35);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(121, 20);
            this.cbGroup.TabIndex = 2;
            // 
            // btnGenerateAnimation
            // 
            this.btnGenerateAnimation.Location = new System.Drawing.Point(21, 29);
            this.btnGenerateAnimation.Name = "btnGenerateAnimation";
            this.btnGenerateAnimation.Size = new System.Drawing.Size(91, 31);
            this.btnGenerateAnimation.TabIndex = 1;
            this.btnGenerateAnimation.Text = "Generate";
            this.btnGenerateAnimation.UseVisualStyleBackColor = true;
            this.btnGenerateAnimation.Click += new System.EventHandler(this.btnGenerateAnimation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLoadCrane);
            this.groupBox1.Controls.Add(this.btnCreateDock);
            this.groupBox1.Controls.Add(this.btnLoadBlock);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // btnLoadCrane
            // 
            this.btnLoadCrane.Location = new System.Drawing.Point(213, 20);
            this.btnLoadCrane.Name = "btnLoadCrane";
            this.btnLoadCrane.Size = new System.Drawing.Size(75, 45);
            this.btnLoadCrane.TabIndex = 2;
            this.btnLoadCrane.Text = "Crane";
            this.btnLoadCrane.UseVisualStyleBackColor = true;
            this.btnLoadCrane.Click += new System.EventHandler(this.btnLoadCrane_Click);
            // 
            // btnCreateDock
            // 
            this.btnCreateDock.Location = new System.Drawing.Point(117, 20);
            this.btnCreateDock.Name = "btnCreateDock";
            this.btnCreateDock.Size = new System.Drawing.Size(75, 45);
            this.btnCreateDock.TabIndex = 1;
            this.btnCreateDock.Text = "Dock";
            this.btnCreateDock.UseVisualStyleBackColor = true;
            this.btnCreateDock.Click += new System.EventHandler(this.btnCreateDock_Click);
            // 
            // btnLoadBlock
            // 
            this.btnLoadBlock.Location = new System.Drawing.Point(21, 20);
            this.btnLoadBlock.Name = "btnLoadBlock";
            this.btnLoadBlock.Size = new System.Drawing.Size(75, 45);
            this.btnLoadBlock.TabIndex = 0;
            this.btnLoadBlock.Text = "Block";
            this.btnLoadBlock.UseVisualStyleBackColor = true;
            this.btnLoadBlock.Click += new System.EventHandler(this.btnLoadBlock_Click);
            // 
            // btnSky
            // 
            this.btnSky.Location = new System.Drawing.Point(213, 20);
            this.btnSky.Name = "btnSky";
            this.btnSky.Size = new System.Drawing.Size(75, 45);
            this.btnSky.TabIndex = 4;
            this.btnSky.Text = "Sky";
            this.btnSky.UseVisualStyleBackColor = true;
            this.btnSky.Click += new System.EventHandler(this.btnSky_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 602);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Animation.Block";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadCrane;
        private System.Windows.Forms.Button btnCreateDock;
        private System.Windows.Forms.Button btnLoadBlock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerateAnimation;
        private System.Windows.Forms.Button btnShowGroup;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSetMaterialDock;
        private System.Windows.Forms.Button btnSetMaterialSea;
        private System.Windows.Forms.Button btnSky;
    }
}

