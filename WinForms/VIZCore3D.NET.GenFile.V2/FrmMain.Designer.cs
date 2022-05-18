namespace VIZCore3D.NET.GenFile.V2
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
            this.btnOpenVIZ = new System.Windows.Forms.Button();
            this.btnOpenGen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMarkingDataCount = new System.Windows.Forms.Button();
            this.btnStringDataCount = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowString = new System.Windows.Forms.Button();
            this.btnShowMarking = new System.Windows.Forms.Button();
            this.btnHideMarking = new System.Windows.Forms.Button();
            this.btnHideString = new System.Windows.Forms.Button();
            this.btnCloseGen = new System.Windows.Forms.Button();
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
            this.splitContainer1.Size = new System.Drawing.Size(1103, 565);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCloseGen);
            this.groupBox1.Controls.Add(this.btnOpenGen);
            this.groupBox1.Controls.Add(this.btnOpenVIZ);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // btnOpenVIZ
            // 
            this.btnOpenVIZ.Location = new System.Drawing.Point(28, 32);
            this.btnOpenVIZ.Name = "btnOpenVIZ";
            this.btnOpenVIZ.Size = new System.Drawing.Size(96, 23);
            this.btnOpenVIZ.TabIndex = 0;
            this.btnOpenVIZ.Text = "Open VIZ";
            this.btnOpenVIZ.UseVisualStyleBackColor = true;
            this.btnOpenVIZ.Click += new System.EventHandler(this.btnOpenVIZ_Click);
            // 
            // btnOpenGen
            // 
            this.btnOpenGen.Location = new System.Drawing.Point(130, 32);
            this.btnOpenGen.Name = "btnOpenGen";
            this.btnOpenGen.Size = new System.Drawing.Size(96, 23);
            this.btnOpenGen.TabIndex = 1;
            this.btnOpenGen.Text = "Open GEN.";
            this.btnOpenGen.UseVisualStyleBackColor = true;
            this.btnOpenGen.Click += new System.EventHandler(this.btnOpenGen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnMarkingDataCount);
            this.groupBox2.Controls.Add(this.btnStringDataCount);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Count";
            // 
            // btnMarkingDataCount
            // 
            this.btnMarkingDataCount.Location = new System.Drawing.Point(28, 32);
            this.btnMarkingDataCount.Name = "btnMarkingDataCount";
            this.btnMarkingDataCount.Size = new System.Drawing.Size(96, 23);
            this.btnMarkingDataCount.TabIndex = 1;
            this.btnMarkingDataCount.Text = "Marking Data";
            this.btnMarkingDataCount.UseVisualStyleBackColor = true;
            this.btnMarkingDataCount.Click += new System.EventHandler(this.btnMarkingDataCount_Click);
            // 
            // btnStringDataCount
            // 
            this.btnStringDataCount.Location = new System.Drawing.Point(130, 32);
            this.btnStringDataCount.Name = "btnStringDataCount";
            this.btnStringDataCount.Size = new System.Drawing.Size(96, 23);
            this.btnStringDataCount.TabIndex = 0;
            this.btnStringDataCount.Text = "String Data";
            this.btnStringDataCount.UseVisualStyleBackColor = true;
            this.btnStringDataCount.Click += new System.EventHandler(this.btnStringDataCount_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnHideString);
            this.groupBox3.Controls.Add(this.btnHideMarking);
            this.groupBox3.Controls.Add(this.btnShowString);
            this.groupBox3.Controls.Add(this.btnShowMarking);
            this.groupBox3.Location = new System.Drawing.Point(12, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 99);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Marking && String";
            // 
            // btnShowString
            // 
            this.btnShowString.Location = new System.Drawing.Point(130, 32);
            this.btnShowString.Name = "btnShowString";
            this.btnShowString.Size = new System.Drawing.Size(96, 23);
            this.btnShowString.TabIndex = 1;
            this.btnShowString.Text = "Show String";
            this.btnShowString.UseVisualStyleBackColor = true;
            this.btnShowString.Click += new System.EventHandler(this.btnShowString_Click);
            // 
            // btnShowMarking
            // 
            this.btnShowMarking.Location = new System.Drawing.Point(28, 32);
            this.btnShowMarking.Name = "btnShowMarking";
            this.btnShowMarking.Size = new System.Drawing.Size(96, 23);
            this.btnShowMarking.TabIndex = 0;
            this.btnShowMarking.Text = "Show Marking";
            this.btnShowMarking.UseVisualStyleBackColor = true;
            this.btnShowMarking.Click += new System.EventHandler(this.btnShowMarking_Click);
            // 
            // btnHideMarking
            // 
            this.btnHideMarking.Location = new System.Drawing.Point(28, 61);
            this.btnHideMarking.Name = "btnHideMarking";
            this.btnHideMarking.Size = new System.Drawing.Size(96, 23);
            this.btnHideMarking.TabIndex = 2;
            this.btnHideMarking.Text = "Hide Marking";
            this.btnHideMarking.UseVisualStyleBackColor = true;
            this.btnHideMarking.Click += new System.EventHandler(this.btnHideMarking_Click);
            // 
            // btnHideString
            // 
            this.btnHideString.Location = new System.Drawing.Point(130, 61);
            this.btnHideString.Name = "btnHideString";
            this.btnHideString.Size = new System.Drawing.Size(96, 23);
            this.btnHideString.TabIndex = 3;
            this.btnHideString.Text = "Hide String";
            this.btnHideString.UseVisualStyleBackColor = true;
            this.btnHideString.Click += new System.EventHandler(this.btnHideString_Click);
            // 
            // btnCloseGen
            // 
            this.btnCloseGen.Location = new System.Drawing.Point(232, 32);
            this.btnCloseGen.Name = "btnCloseGen";
            this.btnCloseGen.Size = new System.Drawing.Size(96, 23);
            this.btnCloseGen.TabIndex = 2;
            this.btnCloseGen.Text = "Close GEN.";
            this.btnCloseGen.UseVisualStyleBackColor = true;
            this.btnCloseGen.Click += new System.EventHandler(this.btnCloseGen_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 565);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.GenFile.V2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenGen;
        private System.Windows.Forms.Button btnOpenVIZ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMarkingDataCount;
        private System.Windows.Forms.Button btnStringDataCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHideString;
        private System.Windows.Forms.Button btnHideMarking;
        private System.Windows.Forms.Button btnShowString;
        private System.Windows.Forms.Button btnShowMarking;
        private System.Windows.Forms.Button btnCloseGen;
    }
}

