namespace VIZCore3D.NET.NodeCreation
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
            this.btnCreateFileNode = new System.Windows.Forms.Button();
            this.btnCreateNodeBulk100 = new System.Windows.Forms.Button();
            this.btnCreateNode100 = new System.Windows.Forms.Button();
            this.btnNewEmptyModel = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1300, 571);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCreateFileNode);
            this.groupBox1.Controls.Add(this.btnCreateNodeBulk100);
            this.groupBox1.Controls.Add(this.btnCreateNode100);
            this.groupBox1.Controls.Add(this.btnNewEmptyModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creation";
            // 
            // btnCreateFileNode
            // 
            this.btnCreateFileNode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFileNode.Location = new System.Drawing.Point(24, 168);
            this.btnCreateFileNode.Name = "btnCreateFileNode";
            this.btnCreateFileNode.Size = new System.Drawing.Size(250, 23);
            this.btnCreateFileNode.TabIndex = 3;
            this.btnCreateFileNode.Text = "File Node";
            this.btnCreateFileNode.UseVisualStyleBackColor = true;
            this.btnCreateFileNode.Click += new System.EventHandler(this.btnCreateFileNode_Click);
            // 
            // btnCreateNodeBulk100
            // 
            this.btnCreateNodeBulk100.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNodeBulk100.Location = new System.Drawing.Point(24, 126);
            this.btnCreateNodeBulk100.Name = "btnCreateNodeBulk100";
            this.btnCreateNodeBulk100.Size = new System.Drawing.Size(250, 23);
            this.btnCreateNodeBulk100.TabIndex = 2;
            this.btnCreateNodeBulk100.Text = "Node 1000 EA (BULK)";
            this.btnCreateNodeBulk100.UseVisualStyleBackColor = true;
            this.btnCreateNodeBulk100.Click += new System.EventHandler(this.btnCreateNodeBulk1000_Click);
            // 
            // btnCreateNode100
            // 
            this.btnCreateNode100.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNode100.Location = new System.Drawing.Point(24, 78);
            this.btnCreateNode100.Name = "btnCreateNode100";
            this.btnCreateNode100.Size = new System.Drawing.Size(250, 23);
            this.btnCreateNode100.TabIndex = 1;
            this.btnCreateNode100.Text = "Node 100 EA";
            this.btnCreateNode100.UseVisualStyleBackColor = true;
            this.btnCreateNode100.Click += new System.EventHandler(this.btnCreateNode100_Click);
            // 
            // btnNewEmptyModel
            // 
            this.btnNewEmptyModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewEmptyModel.Location = new System.Drawing.Point(24, 34);
            this.btnNewEmptyModel.Name = "btnNewEmptyModel";
            this.btnNewEmptyModel.Size = new System.Drawing.Size(250, 23);
            this.btnNewEmptyModel.TabIndex = 0;
            this.btnNewEmptyModel.Text = "New Empty Model";
            this.btnNewEmptyModel.UseVisualStyleBackColor = true;
            this.btnNewEmptyModel.Click += new System.EventHandler(this.btnNewEmptyModel_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 571);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.NodeCreation";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNewEmptyModel;
        private System.Windows.Forms.Button btnCreateNode100;
        private System.Windows.Forms.Button btnCreateNodeBulk100;
        private System.Windows.Forms.Button btnCreateFileNode;
    }
}

