namespace VIZCore3D.NET.CameraControl
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
            this.lvCamera = new System.Windows.Forms.ListView();
            this.columnZoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMatrix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackupCamera = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbSnapshot = new System.Windows.Forms.PictureBox();
            this.ckFitToView = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnapshot)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1265, 643);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ckFitToView);
            this.groupBox2.Controls.Add(this.lvCamera);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // lvCamera
            // 
            this.lvCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCamera.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnZoom,
            this.columnMatrix});
            this.lvCamera.FullRowSelect = true;
            this.lvCamera.GridLines = true;
            this.lvCamera.HideSelection = false;
            this.lvCamera.Location = new System.Drawing.Point(6, 52);
            this.lvCamera.Name = "lvCamera";
            this.lvCamera.Size = new System.Drawing.Size(294, 270);
            this.lvCamera.TabIndex = 0;
            this.lvCamera.UseCompatibleStateImageBehavior = false;
            this.lvCamera.View = System.Windows.Forms.View.Details;
            this.lvCamera.DoubleClick += new System.EventHandler(this.lvCamera_DoubleClick);
            // 
            // columnZoom
            // 
            this.columnZoom.Text = "Zoom";
            this.columnZoom.Width = 77;
            // 
            // columnMatrix
            // 
            this.columnMatrix.Text = "Matrix";
            this.columnMatrix.Width = 196;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBackupCamera);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera";
            // 
            // btnBackupCamera
            // 
            this.btnBackupCamera.Location = new System.Drawing.Point(23, 34);
            this.btnBackupCamera.Name = "btnBackupCamera";
            this.btnBackupCamera.Size = new System.Drawing.Size(75, 23);
            this.btnBackupCamera.TabIndex = 0;
            this.btnBackupCamera.Text = "Backup";
            this.btnBackupCamera.UseVisualStyleBackColor = true;
            this.btnBackupCamera.Click += new System.EventHandler(this.btnBackupCamera_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pbSnapshot);
            this.groupBox3.Location = new System.Drawing.Point(12, 452);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Snapshot";
            // 
            // pbSnapshot
            // 
            this.pbSnapshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSnapshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSnapshot.Location = new System.Drawing.Point(3, 17);
            this.pbSnapshot.Name = "pbSnapshot";
            this.pbSnapshot.Size = new System.Drawing.Size(300, 159);
            this.pbSnapshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSnapshot.TabIndex = 1;
            this.pbSnapshot.TabStop = false;
            // 
            // ckFitToView
            // 
            this.ckFitToView.AutoSize = true;
            this.ckFitToView.Checked = true;
            this.ckFitToView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckFitToView.Location = new System.Drawing.Point(23, 21);
            this.ckFitToView.Name = "ckFitToView";
            this.ckFitToView.Size = new System.Drawing.Size(83, 16);
            this.ckFitToView.TabIndex = 1;
            this.ckFitToView.Text = "Fit to View";
            this.ckFitToView.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 643);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.CameraControl";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSnapshot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackupCamera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvCamera;
        private System.Windows.Forms.ColumnHeader columnZoom;
        private System.Windows.Forms.ColumnHeader columnMatrix;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbSnapshot;
        private System.Windows.Forms.CheckBox ckFitToView;
    }
}

