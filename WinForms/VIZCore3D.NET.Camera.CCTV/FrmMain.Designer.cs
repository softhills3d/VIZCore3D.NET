namespace VIZCore3D.NET.Camera.CCTV
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
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckAntiAliasing = new System.Windows.Forms.CheckBox();
            this.ckEnvironmentLight = new System.Windows.Forms.CheckBox();
            this.ckShadingEffect = new System.Windows.Forms.CheckBox();
            this.ckRealtimeShadow = new System.Windows.Forms.CheckBox();
            this.ckSilhouetteEdge = new System.Windows.Forms.CheckBox();
            this.lbFOV = new System.Windows.Forms.Label();
            this.tbFOV = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDirX = new System.Windows.Forms.TextBox();
            this.txtDirY = new System.Windows.Forms.TextBox();
            this.txtDirZ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFOV)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(1330, 829);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lvList);
            this.groupBox3.Location = new System.Drawing.Point(12, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 460);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CCTV";
            // 
            // lvList
            // 
            this.lvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(6, 20);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(274, 422);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "X";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Y";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Z";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDown);
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Controls.Add(this.btnRight);
            this.groupBox2.Controls.Add(this.btnLeft);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controller";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(109, 79);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseUp);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(109, 21);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(173, 50);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(44, 50);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckAntiAliasing);
            this.groupBox1.Controls.Add(this.ckEnvironmentLight);
            this.groupBox1.Controls.Add(this.ckShadingEffect);
            this.groupBox1.Controls.Add(this.ckRealtimeShadow);
            this.groupBox1.Controls.Add(this.ckSilhouetteEdge);
            this.groupBox1.Controls.Add(this.lbFOV);
            this.groupBox1.Controls.Add(this.tbFOV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // ckAntiAliasing
            // 
            this.ckAntiAliasing.AutoSize = true;
            this.ckAntiAliasing.Location = new System.Drawing.Point(109, 115);
            this.ckAntiAliasing.Name = "ckAntiAliasing";
            this.ckAntiAliasing.Size = new System.Drawing.Size(96, 16);
            this.ckAntiAliasing.TabIndex = 7;
            this.ckAntiAliasing.Text = "Anti-Aliasing";
            this.ckAntiAliasing.UseVisualStyleBackColor = true;
            this.ckAntiAliasing.CheckedChanged += new System.EventHandler(this.ckAntiAliasing_CheckedChanged);
            // 
            // ckEnvironmentLight
            // 
            this.ckEnvironmentLight.AutoSize = true;
            this.ckEnvironmentLight.Location = new System.Drawing.Point(25, 115);
            this.ckEnvironmentLight.Name = "ckEnvironmentLight";
            this.ckEnvironmentLight.Size = new System.Drawing.Size(72, 16);
            this.ckEnvironmentLight.TabIndex = 6;
            this.ckEnvironmentLight.Text = "환경조명";
            this.ckEnvironmentLight.UseVisualStyleBackColor = true;
            this.ckEnvironmentLight.CheckedChanged += new System.EventHandler(this.ckEnvironmentLight_CheckedChanged);
            // 
            // ckShadingEffect
            // 
            this.ckShadingEffect.AutoSize = true;
            this.ckShadingEffect.Location = new System.Drawing.Point(188, 81);
            this.ckShadingEffect.Name = "ckShadingEffect";
            this.ckShadingEffect.Size = new System.Drawing.Size(48, 16);
            this.ckShadingEffect.TabIndex = 5;
            this.ckShadingEffect.Text = "음영";
            this.ckShadingEffect.UseVisualStyleBackColor = true;
            this.ckShadingEffect.CheckedChanged += new System.EventHandler(this.ckShadingEffect_CheckedChanged);
            // 
            // ckRealtimeShadow
            // 
            this.ckRealtimeShadow.AutoSize = true;
            this.ckRealtimeShadow.Location = new System.Drawing.Point(109, 81);
            this.ckRealtimeShadow.Name = "ckRealtimeShadow";
            this.ckRealtimeShadow.Size = new System.Drawing.Size(60, 16);
            this.ckRealtimeShadow.TabIndex = 4;
            this.ckRealtimeShadow.Text = "그림자";
            this.ckRealtimeShadow.UseVisualStyleBackColor = true;
            this.ckRealtimeShadow.CheckedChanged += new System.EventHandler(this.ckRealtimeShadow_CheckedChanged);
            // 
            // ckSilhouetteEdge
            // 
            this.ckSilhouetteEdge.AutoSize = true;
            this.ckSilhouetteEdge.Location = new System.Drawing.Point(25, 81);
            this.ckSilhouetteEdge.Name = "ckSilhouetteEdge";
            this.ckSilhouetteEdge.Size = new System.Drawing.Size(48, 16);
            this.ckSilhouetteEdge.TabIndex = 3;
            this.ckSilhouetteEdge.Text = "윤곽";
            this.ckSilhouetteEdge.UseVisualStyleBackColor = true;
            this.ckSilhouetteEdge.CheckedChanged += new System.EventHandler(this.ckSilhouetteEdge_CheckedChanged);
            // 
            // lbFOV
            // 
            this.lbFOV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFOV.AutoSize = true;
            this.lbFOV.Location = new System.Drawing.Point(212, 54);
            this.lbFOV.Name = "lbFOV";
            this.lbFOV.Size = new System.Drawing.Size(68, 12);
            this.lbFOV.TabIndex = 2;
            this.lbFOV.Text = "VALUE : 60";
            // 
            // tbFOV
            // 
            this.tbFOV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFOV.Location = new System.Drawing.Point(58, 20);
            this.tbFOV.Maximum = 74;
            this.tbFOV.Minimum = 45;
            this.tbFOV.Name = "tbFOV";
            this.tbFOV.Size = new System.Drawing.Size(230, 45);
            this.tbFOV.TabIndex = 1;
            this.tbFOV.Value = 60;
            this.tbFOV.ValueChanged += new System.EventHandler(this.tbFOV_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOV";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtDirZ);
            this.groupBox4.Controls.Add(this.txtDirY);
            this.groupBox4.Controls.Add(this.txtDirX);
            this.groupBox4.Location = new System.Drawing.Point(12, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 57);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Direction";
            // 
            // txtDirX
            // 
            this.txtDirX.Location = new System.Drawing.Point(6, 22);
            this.txtDirX.Name = "txtDirX";
            this.txtDirX.Size = new System.Drawing.Size(70, 21);
            this.txtDirX.TabIndex = 0;
            // 
            // txtDirY
            // 
            this.txtDirY.Location = new System.Drawing.Point(109, 22);
            this.txtDirY.Name = "txtDirY";
            this.txtDirY.Size = new System.Drawing.Size(70, 21);
            this.txtDirY.TabIndex = 1;
            // 
            // txtDirZ
            // 
            this.txtDirZ.Location = new System.Drawing.Point(210, 22);
            this.txtDirZ.Name = "txtDirZ";
            this.txtDirZ.Size = new System.Drawing.Size(70, 21);
            this.txtDirZ.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 829);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Camera.CCTV";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFOV)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbFOV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFOV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox ckSilhouetteEdge;
        private System.Windows.Forms.CheckBox ckAntiAliasing;
        private System.Windows.Forms.CheckBox ckEnvironmentLight;
        private System.Windows.Forms.CheckBox ckShadingEffect;
        private System.Windows.Forms.CheckBox ckRealtimeShadow;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDirZ;
        private System.Windows.Forms.TextBox txtDirY;
        private System.Windows.Forms.TextBox txtDirX;
    }
}

