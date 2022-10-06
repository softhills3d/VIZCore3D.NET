namespace VIZCore3D.NET.SomeLookup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExport = new System.Windows.Forms.RadioButton();
            this.rbVIZXML = new System.Windows.Forms.RadioButton();
            this.rbLinkNode = new System.Windows.Forms.RadioButton();
            this.btnShowModel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(962, 515);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail View";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnShowModel);
            this.groupBox1.Controls.Add(this.rbLinkNode);
            this.groupBox1.Controls.Add(this.rbVIZXML);
            this.groupBox1.Controls.Add(this.rbExport);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // rbExport
            // 
            this.rbExport.AutoSize = true;
            this.rbExport.Checked = true;
            this.rbExport.Location = new System.Drawing.Point(32, 26);
            this.rbExport.Name = "rbExport";
            this.rbExport.Size = new System.Drawing.Size(59, 16);
            this.rbExport.TabIndex = 0;
            this.rbExport.TabStop = true;
            this.rbExport.Text = "Export";
            this.rbExport.UseVisualStyleBackColor = true;
            // 
            // rbVIZXML
            // 
            this.rbVIZXML.AutoSize = true;
            this.rbVIZXML.Location = new System.Drawing.Point(32, 48);
            this.rbVIZXML.Name = "rbVIZXML";
            this.rbVIZXML.Size = new System.Drawing.Size(68, 16);
            this.rbVIZXML.TabIndex = 1;
            this.rbVIZXML.Text = "VIZXML";
            this.rbVIZXML.UseVisualStyleBackColor = true;
            // 
            // rbLinkNode
            // 
            this.rbLinkNode.AutoSize = true;
            this.rbLinkNode.Location = new System.Drawing.Point(32, 70);
            this.rbLinkNode.Name = "rbLinkNode";
            this.rbLinkNode.Size = new System.Drawing.Size(80, 16);
            this.rbLinkNode.TabIndex = 2;
            this.rbLinkNode.Text = "Link Node";
            this.rbLinkNode.UseVisualStyleBackColor = true;
            // 
            // btnShowModel
            // 
            this.btnShowModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowModel.Location = new System.Drawing.Point(226, 81);
            this.btnShowModel.Name = "btnShowModel";
            this.btnShowModel.Size = new System.Drawing.Size(75, 23);
            this.btnShowModel.TabIndex = 3;
            this.btnShowModel.Text = "Show";
            this.btnShowModel.UseVisualStyleBackColor = true;
            this.btnShowModel.Click += new System.EventHandler(this.btnShowModel_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 515);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Some Model Lookup";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLinkNode;
        private System.Windows.Forms.RadioButton rbVIZXML;
        private System.Windows.Forms.RadioButton rbExport;
        private System.Windows.Forms.Button btnShowModel;
    }
}

