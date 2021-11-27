namespace VIZCore3D.NET.CircleGeo
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
            this.lvData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ckHighlightCenter = new System.Windows.Forms.CheckBox();
            this.ckDistance = new System.Windows.Forms.CheckBox();
            this.ckClearReview = new System.Windows.Forms.CheckBox();
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
            this.splitContainer1.Size = new System.Drawing.Size(1066, 543);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckClearReview);
            this.groupBox1.Controls.Add(this.ckDistance);
            this.groupBox1.Controls.Add(this.ckHighlightCenter);
            this.groupBox1.Controls.Add(this.lvData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circle";
            // 
            // lvData
            // 
            this.lvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(6, 127);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(322, 386);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Diameter";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Center";
            this.columnHeader3.Width = 142;
            // 
            // ckHighlightCenter
            // 
            this.ckHighlightCenter.AutoSize = true;
            this.ckHighlightCenter.Checked = true;
            this.ckHighlightCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckHighlightCenter.Location = new System.Drawing.Point(19, 33);
            this.ckHighlightCenter.Name = "ckHighlightCenter";
            this.ckHighlightCenter.Size = new System.Drawing.Size(113, 16);
            this.ckHighlightCenter.TabIndex = 1;
            this.ckHighlightCenter.Text = "Highlight Center";
            this.ckHighlightCenter.UseVisualStyleBackColor = true;
            // 
            // ckDistance
            // 
            this.ckDistance.AutoSize = true;
            this.ckDistance.Checked = true;
            this.ckDistance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDistance.Location = new System.Drawing.Point(19, 64);
            this.ckDistance.Name = "ckDistance";
            this.ckDistance.Size = new System.Drawing.Size(109, 16);
            this.ckDistance.TabIndex = 2;
            this.ckDistance.Text = "Show Distance";
            this.ckDistance.UseVisualStyleBackColor = true;
            // 
            // ckClearReview
            // 
            this.ckClearReview.AutoSize = true;
            this.ckClearReview.Checked = true;
            this.ckClearReview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClearReview.Location = new System.Drawing.Point(19, 96);
            this.ckClearReview.Name = "ckClearReview";
            this.ckClearReview.Size = new System.Drawing.Size(54, 16);
            this.ckClearReview.TabIndex = 3;
            this.ckClearReview.Text = "Clear";
            this.ckClearReview.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 543);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.CircleGeo";
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
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox ckHighlightCenter;
        private System.Windows.Forms.CheckBox ckDistance;
        private System.Windows.Forms.CheckBox ckClearReview;
    }
}

