namespace VIZCore3D.NET.ProjectionArea
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalArea = new System.Windows.Forms.TextBox();
            this.txtEmptyArea = new System.Windows.Forms.TextBox();
            this.txtProjectionArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProjectionZX = new System.Windows.Forms.Button();
            this.btnProjectionYZ = new System.Windows.Forms.Button();
            this.btnProjectionXY = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpImage = new System.Windows.Forms.TabPage();
            this.tpPoints = new System.Windows.Forms.TabPage();
            this.pbProjection = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjection)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 670);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTotalArea);
            this.groupBox3.Controls.Add(this.txtEmptyArea);
            this.groupBox3.Controls.Add(this.txtProjectionArea);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 153);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "mm²";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "mm²";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "mm²";
            // 
            // txtTotalArea
            // 
            this.txtTotalArea.Location = new System.Drawing.Point(101, 117);
            this.txtTotalArea.Name = "txtTotalArea";
            this.txtTotalArea.Size = new System.Drawing.Size(145, 21);
            this.txtTotalArea.TabIndex = 5;
            // 
            // txtEmptyArea
            // 
            this.txtEmptyArea.Location = new System.Drawing.Point(101, 77);
            this.txtEmptyArea.Name = "txtEmptyArea";
            this.txtEmptyArea.Size = new System.Drawing.Size(145, 21);
            this.txtEmptyArea.TabIndex = 4;
            // 
            // txtProjectionArea
            // 
            this.txtProjectionArea.Location = new System.Drawing.Point(101, 40);
            this.txtProjectionArea.Name = "txtProjectionArea";
            this.txtProjectionArea.Size = new System.Drawing.Size(145, 21);
            this.txtProjectionArea.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnProjectionZX);
            this.groupBox2.Controls.Add(this.btnProjectionYZ);
            this.groupBox2.Controls.Add(this.btnProjectionXY);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projection";
            // 
            // btnProjectionZX
            // 
            this.btnProjectionZX.Location = new System.Drawing.Point(217, 29);
            this.btnProjectionZX.Name = "btnProjectionZX";
            this.btnProjectionZX.Size = new System.Drawing.Size(75, 23);
            this.btnProjectionZX.TabIndex = 2;
            this.btnProjectionZX.Text = "ZX";
            this.btnProjectionZX.UseVisualStyleBackColor = true;
            this.btnProjectionZX.Click += new System.EventHandler(this.btnProjectionZX_Click);
            // 
            // btnProjectionYZ
            // 
            this.btnProjectionYZ.Location = new System.Drawing.Point(126, 29);
            this.btnProjectionYZ.Name = "btnProjectionYZ";
            this.btnProjectionYZ.Size = new System.Drawing.Size(75, 23);
            this.btnProjectionYZ.TabIndex = 1;
            this.btnProjectionYZ.Text = "YZ";
            this.btnProjectionYZ.UseVisualStyleBackColor = true;
            this.btnProjectionYZ.Click += new System.EventHandler(this.btnProjectionYZ_Click);
            // 
            // btnProjectionXY
            // 
            this.btnProjectionXY.Location = new System.Drawing.Point(34, 29);
            this.btnProjectionXY.Name = "btnProjectionXY";
            this.btnProjectionXY.Size = new System.Drawing.Size(75, 23);
            this.btnProjectionXY.TabIndex = 0;
            this.btnProjectionXY.Text = "XY";
            this.btnProjectionXY.UseVisualStyleBackColor = true;
            this.btnProjectionXY.Click += new System.EventHandler(this.btnProjectionXY_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(34, 29);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpImage);
            this.tabControl1.Controls.Add(this.tpPoints);
            this.tabControl1.Location = new System.Drawing.Point(12, 317);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 341);
            this.tabControl1.TabIndex = 4;
            // 
            // tpImage
            // 
            this.tpImage.Controls.Add(this.pbProjection);
            this.tpImage.Location = new System.Drawing.Point(4, 22);
            this.tpImage.Name = "tpImage";
            this.tpImage.Padding = new System.Windows.Forms.Padding(3);
            this.tpImage.Size = new System.Drawing.Size(325, 315);
            this.tpImage.TabIndex = 0;
            this.tpImage.Text = "Image";
            this.tpImage.UseVisualStyleBackColor = true;
            // 
            // tpPoints
            // 
            this.tpPoints.Location = new System.Drawing.Point(4, 22);
            this.tpPoints.Name = "tpPoints";
            this.tpPoints.Padding = new System.Windows.Forms.Padding(3);
            this.tpPoints.Size = new System.Drawing.Size(325, 315);
            this.tpPoints.TabIndex = 1;
            this.tpPoints.Text = "Points";
            this.tpPoints.UseVisualStyleBackColor = true;
            // 
            // pbProjection
            // 
            this.pbProjection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProjection.Location = new System.Drawing.Point(3, 3);
            this.pbProjection.Name = "pbProjection";
            this.pbProjection.Size = new System.Drawing.Size(319, 309);
            this.pbProjection.TabIndex = 0;
            this.pbProjection.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 670);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProjection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProjectionZX;
        private System.Windows.Forms.Button btnProjectionYZ;
        private System.Windows.Forms.Button btnProjectionXY;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalArea;
        private System.Windows.Forms.TextBox txtEmptyArea;
        private System.Windows.Forms.TextBox txtProjectionArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpImage;
        private System.Windows.Forms.PictureBox pbProjection;
        private System.Windows.Forms.TabPage tpPoints;
    }
}

