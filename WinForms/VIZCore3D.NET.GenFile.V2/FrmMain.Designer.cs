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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckDepthTest = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHideLeftRightEnd = new System.Windows.Forms.Button();
            this.btnShowLeftRightEnd = new System.Windows.Forms.Button();
            this.btnHideString = new System.Windows.Forms.Button();
            this.btnHideMarking = new System.Windows.Forms.Button();
            this.btnShowString = new System.Windows.Forms.Button();
            this.btnShowMarking = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLeftRightEndDataCount = new System.Windows.Forms.Button();
            this.btnMarkingDataCount = new System.Windows.Forms.Button();
            this.btnStringDataCount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseGen = new System.Windows.Forms.Button();
            this.btnOpenGen = new System.Windows.Forms.Button();
            this.btnOpenVIZ = new System.Windows.Forms.Button();
            this.btnBevelSymbolDataCount = new System.Windows.Forms.Button();
            this.btnHideBevelSymbol = new System.Windows.Forms.Button();
            this.btnShowBevelSymbol = new System.Windows.Forms.Button();
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
            this.splitContainer1.Size = new System.Drawing.Size(1103, 565);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ckDepthTest);
            this.groupBox4.Location = new System.Drawing.Point(12, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 64);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // ckDepthTest
            // 
            this.ckDepthTest.AutoSize = true;
            this.ckDepthTest.Location = new System.Drawing.Point(28, 30);
            this.ckDepthTest.Name = "ckDepthTest";
            this.ckDepthTest.Size = new System.Drawing.Size(81, 16);
            this.ckDepthTest.TabIndex = 0;
            this.ckDepthTest.Text = "DepthTest";
            this.ckDepthTest.UseVisualStyleBackColor = true;
            this.ckDepthTest.CheckedChanged += new System.EventHandler(this.ckDepthTest_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnHideBevelSymbol);
            this.groupBox3.Controls.Add(this.btnShowBevelSymbol);
            this.groupBox3.Controls.Add(this.btnHideLeftRightEnd);
            this.groupBox3.Controls.Add(this.btnShowLeftRightEnd);
            this.groupBox3.Controls.Add(this.btnHideString);
            this.groupBox3.Controls.Add(this.btnHideMarking);
            this.groupBox3.Controls.Add(this.btnShowString);
            this.groupBox3.Controls.Add(this.btnShowMarking);
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 180);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Marking && String";
            // 
            // btnHideLeftRightEnd
            // 
            this.btnHideLeftRightEnd.Location = new System.Drawing.Point(232, 61);
            this.btnHideLeftRightEnd.Name = "btnHideLeftRightEnd";
            this.btnHideLeftRightEnd.Size = new System.Drawing.Size(96, 23);
            this.btnHideLeftRightEnd.TabIndex = 5;
            this.btnHideLeftRightEnd.Text = "Hide End";
            this.btnHideLeftRightEnd.UseVisualStyleBackColor = true;
            this.btnHideLeftRightEnd.Click += new System.EventHandler(this.btnHideLeftRightEnd_Click);
            // 
            // btnShowLeftRightEnd
            // 
            this.btnShowLeftRightEnd.Location = new System.Drawing.Point(232, 32);
            this.btnShowLeftRightEnd.Name = "btnShowLeftRightEnd";
            this.btnShowLeftRightEnd.Size = new System.Drawing.Size(96, 23);
            this.btnShowLeftRightEnd.TabIndex = 4;
            this.btnShowLeftRightEnd.Text = "Show End";
            this.btnShowLeftRightEnd.UseVisualStyleBackColor = true;
            this.btnShowLeftRightEnd.Click += new System.EventHandler(this.btnShowLeftRightEnd_Click);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBevelSymbolDataCount);
            this.groupBox2.Controls.Add(this.btnLeftRightEndDataCount);
            this.groupBox2.Controls.Add(this.btnMarkingDataCount);
            this.groupBox2.Controls.Add(this.btnStringDataCount);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 102);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Count";
            // 
            // btnLeftRightEndDataCount
            // 
            this.btnLeftRightEndDataCount.Location = new System.Drawing.Point(232, 32);
            this.btnLeftRightEndDataCount.Name = "btnLeftRightEndDataCount";
            this.btnLeftRightEndDataCount.Size = new System.Drawing.Size(96, 23);
            this.btnLeftRightEndDataCount.TabIndex = 2;
            this.btnLeftRightEndDataCount.Text = "End Data";
            this.btnLeftRightEndDataCount.UseVisualStyleBackColor = true;
            this.btnLeftRightEndDataCount.Click += new System.EventHandler(this.btnLeftRightEndDataCount_Click);
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
            // btnBevelSymbolDataCount
            // 
            this.btnBevelSymbolDataCount.Location = new System.Drawing.Point(28, 61);
            this.btnBevelSymbolDataCount.Name = "btnBevelSymbolDataCount";
            this.btnBevelSymbolDataCount.Size = new System.Drawing.Size(96, 23);
            this.btnBevelSymbolDataCount.TabIndex = 3;
            this.btnBevelSymbolDataCount.Text = "Bevel Symbol Data";
            this.btnBevelSymbolDataCount.UseVisualStyleBackColor = true;
            this.btnBevelSymbolDataCount.Click += new System.EventHandler(this.btnBevelSymbolDataCount_Click);
            // 
            // btnHideBevelSymbol
            // 
            this.btnHideBevelSymbol.Location = new System.Drawing.Point(28, 139);
            this.btnHideBevelSymbol.Name = "btnHideBevelSymbol";
            this.btnHideBevelSymbol.Size = new System.Drawing.Size(140, 23);
            this.btnHideBevelSymbol.TabIndex = 7;
            this.btnHideBevelSymbol.Text = "Hide Marking";
            this.btnHideBevelSymbol.UseVisualStyleBackColor = true;
            this.btnHideBevelSymbol.Click += new System.EventHandler(this.btnHideBevelSymbol_Click);
            // 
            // btnShowBevelSymbol
            // 
            this.btnShowBevelSymbol.Location = new System.Drawing.Point(28, 110);
            this.btnShowBevelSymbol.Name = "btnShowBevelSymbol";
            this.btnShowBevelSymbol.Size = new System.Drawing.Size(140, 23);
            this.btnShowBevelSymbol.TabIndex = 6;
            this.btnShowBevelSymbol.Text = "Show Bevel Symbol";
            this.btnShowBevelSymbol.UseVisualStyleBackColor = true;
            this.btnShowBevelSymbol.Click += new System.EventHandler(this.btnShowBevelSymbol_Click);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckDepthTest;
        private System.Windows.Forms.Button btnLeftRightEndDataCount;
        private System.Windows.Forms.Button btnHideLeftRightEnd;
        private System.Windows.Forms.Button btnShowLeftRightEnd;
        private System.Windows.Forms.Button btnBevelSymbolDataCount;
        private System.Windows.Forms.Button btnHideBevelSymbol;
        private System.Windows.Forms.Button btnShowBevelSymbol;
    }
}

