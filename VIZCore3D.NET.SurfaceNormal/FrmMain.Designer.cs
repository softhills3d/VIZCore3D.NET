namespace VIZCore3D.NET.SurfaceNormal
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
            this.btnShowOsnap = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWorldX = new System.Windows.Forms.TextBox();
            this.txtWorldY = new System.Windows.Forms.TextBox();
            this.txtWorldZ = new System.Windows.Forms.TextBox();
            this.btnConvertWorldToScreen = new System.Windows.Forms.Button();
            this.txtScreenY = new System.Windows.Forms.TextBox();
            this.txtScreenX = new System.Windows.Forms.TextBox();
            this.btnGetCenter = new System.Windows.Forms.Button();
            this.ckUseCamera = new System.Windows.Forms.CheckBox();
            this.btnGetNormal = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetNormal3D = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1253, 770);
            this.splitContainer1.SplitterDistance = 417;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnShowOsnap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnap :: Surface";
            // 
            // btnShowOsnap
            // 
            this.btnShowOsnap.Location = new System.Drawing.Point(20, 30);
            this.btnShowOsnap.Name = "btnShowOsnap";
            this.btnShowOsnap.Size = new System.Drawing.Size(94, 23);
            this.btnShowOsnap.TabIndex = 0;
            this.btnShowOsnap.Text = "Show Osnap";
            this.btnShowOsnap.UseVisualStyleBackColor = true;
            this.btnShowOsnap.Click += new System.EventHandler(this.btnShowOsnap_Click);
            // 
            // lvItems
            // 
            this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(6, 20);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(377, 493);
            this.lvItems.TabIndex = 1;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pick";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Surface";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Position";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Normal";
            this.columnHeader4.Width = 97;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnGetNormal3D);
            this.groupBox2.Controls.Add(this.btnGetNormal);
            this.groupBox2.Controls.Add(this.ckUseCamera);
            this.groupBox2.Controls.Add(this.btnGetCenter);
            this.groupBox2.Controls.Add(this.txtScreenY);
            this.groupBox2.Controls.Add(this.txtScreenX);
            this.groupBox2.Controls.Add(this.btnConvertWorldToScreen);
            this.groupBox2.Controls.Add(this.txtWorldZ);
            this.groupBox2.Controls.Add(this.txtWorldY);
            this.groupBox2.Controls.Add(this.txtWorldX);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 140);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "World To Screen";
            // 
            // txtWorldX
            // 
            this.txtWorldX.Location = new System.Drawing.Point(20, 25);
            this.txtWorldX.Name = "txtWorldX";
            this.txtWorldX.Size = new System.Drawing.Size(70, 21);
            this.txtWorldX.TabIndex = 0;
            // 
            // txtWorldY
            // 
            this.txtWorldY.Location = new System.Drawing.Point(96, 25);
            this.txtWorldY.Name = "txtWorldY";
            this.txtWorldY.Size = new System.Drawing.Size(70, 21);
            this.txtWorldY.TabIndex = 1;
            // 
            // txtWorldZ
            // 
            this.txtWorldZ.Location = new System.Drawing.Point(172, 25);
            this.txtWorldZ.Name = "txtWorldZ";
            this.txtWorldZ.Size = new System.Drawing.Size(70, 21);
            this.txtWorldZ.TabIndex = 2;
            // 
            // btnConvertWorldToScreen
            // 
            this.btnConvertWorldToScreen.Location = new System.Drawing.Point(248, 60);
            this.btnConvertWorldToScreen.Name = "btnConvertWorldToScreen";
            this.btnConvertWorldToScreen.Size = new System.Drawing.Size(63, 23);
            this.btnConvertWorldToScreen.TabIndex = 3;
            this.btnConvertWorldToScreen.Text = "Convert";
            this.btnConvertWorldToScreen.UseVisualStyleBackColor = true;
            this.btnConvertWorldToScreen.Click += new System.EventHandler(this.btnConvertWorldToScreen_Click);
            // 
            // txtScreenY
            // 
            this.txtScreenY.Location = new System.Drawing.Point(96, 62);
            this.txtScreenY.Name = "txtScreenY";
            this.txtScreenY.ReadOnly = true;
            this.txtScreenY.Size = new System.Drawing.Size(70, 21);
            this.txtScreenY.TabIndex = 5;
            // 
            // txtScreenX
            // 
            this.txtScreenX.Location = new System.Drawing.Point(20, 62);
            this.txtScreenX.Name = "txtScreenX";
            this.txtScreenX.ReadOnly = true;
            this.txtScreenX.Size = new System.Drawing.Size(70, 21);
            this.txtScreenX.TabIndex = 4;
            // 
            // btnGetCenter
            // 
            this.btnGetCenter.Location = new System.Drawing.Point(248, 25);
            this.btnGetCenter.Name = "btnGetCenter";
            this.btnGetCenter.Size = new System.Drawing.Size(66, 23);
            this.btnGetCenter.TabIndex = 6;
            this.btnGetCenter.Text = "Center";
            this.btnGetCenter.UseVisualStyleBackColor = true;
            this.btnGetCenter.Click += new System.EventHandler(this.btnGetCenter_Click);
            // 
            // ckUseCamera
            // 
            this.ckUseCamera.AutoSize = true;
            this.ckUseCamera.Checked = true;
            this.ckUseCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckUseCamera.Location = new System.Drawing.Point(173, 67);
            this.ckUseCamera.Name = "ckUseCamera";
            this.ckUseCamera.Size = new System.Drawing.Size(69, 16);
            this.ckUseCamera.TabIndex = 7;
            this.ckUseCamera.Text = "Camera";
            this.ckUseCamera.UseVisualStyleBackColor = true;
            // 
            // btnGetNormal
            // 
            this.btnGetNormal.Location = new System.Drawing.Point(20, 98);
            this.btnGetNormal.Name = "btnGetNormal";
            this.btnGetNormal.Size = new System.Drawing.Size(146, 23);
            this.btnGetNormal.TabIndex = 1;
            this.btnGetNormal.Text = "Get Normal(X,Y)";
            this.btnGetNormal.UseVisualStyleBackColor = true;
            this.btnGetNormal.Click += new System.EventHandler(this.btnGetNormal_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lvItems);
            this.groupBox3.Location = new System.Drawing.Point(12, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 519);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // btnGetNormal3D
            // 
            this.btnGetNormal3D.Location = new System.Drawing.Point(173, 98);
            this.btnGetNormal3D.Name = "btnGetNormal3D";
            this.btnGetNormal3D.Size = new System.Drawing.Size(146, 23);
            this.btnGetNormal3D.TabIndex = 8;
            this.btnGetNormal3D.Text = "Get Normal(X,Y,Z)";
            this.btnGetNormal3D.UseVisualStyleBackColor = true;
            this.btnGetNormal3D.Click += new System.EventHandler(this.btnGetNormal3D_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 770);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.SurfaceNormal";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowOsnap;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetCenter;
        private System.Windows.Forms.TextBox txtScreenY;
        private System.Windows.Forms.TextBox txtScreenX;
        private System.Windows.Forms.Button btnConvertWorldToScreen;
        private System.Windows.Forms.TextBox txtWorldZ;
        private System.Windows.Forms.TextBox txtWorldY;
        private System.Windows.Forms.TextBox txtWorldX;
        private System.Windows.Forms.CheckBox ckUseCamera;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetNormal;
        private System.Windows.Forms.Button btnGetNormal3D;
    }
}

