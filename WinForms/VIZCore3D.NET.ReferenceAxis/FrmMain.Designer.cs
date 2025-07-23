namespace VIZCore3D.NET.ReferenceAxis
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
            this.btnCreate2 = new System.Windows.Forms.Button();
            this.btnCreate1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn2Point1Edge = new System.Windows.Forms.Button();
            this.btn3Point = new System.Windows.Forms.Button();
            this.btnSurfaceNormal1Edge = new System.Windows.Forms.Button();
            this.btn1PointAxis = new System.Windows.Forms.Button();
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
            this.splitContainer1.Size = new System.Drawing.Size(1135, 626);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnCreate2);
            this.groupBox1.Controls.Add(this.btnCreate1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reference Axis";
            // 
            // btnCreate2
            // 
            this.btnCreate2.Location = new System.Drawing.Point(168, 32);
            this.btnCreate2.Name = "btnCreate2";
            this.btnCreate2.Size = new System.Drawing.Size(75, 23);
            this.btnCreate2.TabIndex = 1;
            this.btnCreate2.Text = "참조축";
            this.btnCreate2.UseVisualStyleBackColor = true;
            this.btnCreate2.Click += new System.EventHandler(this.btnCreate2_Click);
            // 
            // btnCreate1
            // 
            this.btnCreate1.Location = new System.Drawing.Point(87, 32);
            this.btnCreate1.Name = "btnCreate1";
            this.btnCreate1.Size = new System.Drawing.Size(75, 23);
            this.btnCreate1.TabIndex = 0;
            this.btnCreate1.Text = "절대축";
            this.btnCreate1.UseVisualStyleBackColor = true;
            this.btnCreate1.Click += new System.EventHandler(this.btnCreate1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(21, 32);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(60, 21);
            this.txtID.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnActivate);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(21, 30);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "선택";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(102, 30);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(75, 23);
            this.btnActivate.TabIndex = 4;
            this.btnActivate.Text = "활성화";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btn1PointAxis);
            this.groupBox3.Controls.Add(this.btnSurfaceNormal1Edge);
            this.groupBox3.Controls.Add(this.btn2Point1Edge);
            this.groupBox3.Controls.Add(this.btn3Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 223);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btn2Point1Edge
            // 
            this.btn2Point1Edge.Location = new System.Drawing.Point(21, 59);
            this.btn2Point1Edge.Name = "btn2Point1Edge";
            this.btn2Point1Edge.Size = new System.Drawing.Size(75, 23);
            this.btn2Point1Edge.TabIndex = 4;
            this.btn2Point1Edge.Text = "2점축";
            this.btn2Point1Edge.UseVisualStyleBackColor = true;
            this.btn2Point1Edge.Click += new System.EventHandler(this.btn2Point1Edge_Click);
            // 
            // btn3Point
            // 
            this.btn3Point.Location = new System.Drawing.Point(21, 30);
            this.btn3Point.Name = "btn3Point";
            this.btn3Point.Size = new System.Drawing.Size(75, 23);
            this.btn3Point.TabIndex = 3;
            this.btn3Point.Text = "3점축";
            this.btn3Point.UseVisualStyleBackColor = true;
            this.btn3Point.Click += new System.EventHandler(this.btn3Point_Click);
            // 
            // btnSurfaceNormal1Edge
            // 
            this.btnSurfaceNormal1Edge.Location = new System.Drawing.Point(21, 88);
            this.btnSurfaceNormal1Edge.Name = "btnSurfaceNormal1Edge";
            this.btnSurfaceNormal1Edge.Size = new System.Drawing.Size(75, 23);
            this.btnSurfaceNormal1Edge.TabIndex = 5;
            this.btnSurfaceNormal1Edge.Text = "법선축";
            this.btnSurfaceNormal1Edge.UseVisualStyleBackColor = true;
            this.btnSurfaceNormal1Edge.Click += new System.EventHandler(this.btnSurfaceNormal1Edge_Click);
            // 
            // btn1PointAxis
            // 
            this.btn1PointAxis.Location = new System.Drawing.Point(21, 117);
            this.btn1PointAxis.Name = "btn1PointAxis";
            this.btn1PointAxis.Size = new System.Drawing.Size(75, 23);
            this.btn1PointAxis.TabIndex = 6;
            this.btn1PointAxis.Text = "1점축";
            this.btn1PointAxis.UseVisualStyleBackColor = true;
            this.btn1PointAxis.Click += new System.EventHandler(this.btn1PointAxis_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 626);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.ReferenceAxis";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate2;
        private System.Windows.Forms.Button btnCreate1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSurfaceNormal1Edge;
        private System.Windows.Forms.Button btn2Point1Edge;
        private System.Windows.Forms.Button btn3Point;
        private System.Windows.Forms.Button btn1PointAxis;
    }
}

