namespace VIZCore3D.NET.TOB
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
            this.btnHighlightColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckDisplayAngle = new System.Windows.Forms.CheckBox();
            this.ckStopTurnOver = new System.Windows.Forms.CheckBox();
            this.ckPerformance = new System.Windows.Forms.CheckBox();
            this.ckAnimationOnly = new System.Windows.Forms.CheckBox();
            this.txtTurnOverAngle = new System.Windows.Forms.TextBox();
            this.cbTurnOverAxis = new System.Windows.Forms.ComboBox();
            this.btnTurnOverRun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAlignCenterBlock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadBlock2 = new System.Windows.Forms.Button();
            this.btnLoadBlock1 = new System.Windows.Forms.Button();
            this.btnLoadGoliath = new System.Windows.Forms.Button();
            this.backgroundWorkerTurnOver = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnReportDialog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1081, 621);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnHighlightColor);
            this.groupBox4.Location = new System.Drawing.Point(12, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 58);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Highlight";
            // 
            // btnHighlightColor
            // 
            this.btnHighlightColor.Location = new System.Drawing.Point(22, 20);
            this.btnHighlightColor.Name = "btnHighlightColor";
            this.btnHighlightColor.Size = new System.Drawing.Size(75, 23);
            this.btnHighlightColor.TabIndex = 2;
            this.btnHighlightColor.Text = "Color";
            this.btnHighlightColor.UseVisualStyleBackColor = true;
            this.btnHighlightColor.Click += new System.EventHandler(this.btnHighlightColor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ckDisplayAngle);
            this.groupBox3.Controls.Add(this.ckStopTurnOver);
            this.groupBox3.Controls.Add(this.ckPerformance);
            this.groupBox3.Controls.Add(this.ckAnimationOnly);
            this.groupBox3.Controls.Add(this.txtTurnOverAngle);
            this.groupBox3.Controls.Add(this.cbTurnOverAxis);
            this.groupBox3.Controls.Add(this.btnTurnOverRun);
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 177);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turn Over";
            // 
            // ckDisplayAngle
            // 
            this.ckDisplayAngle.AutoSize = true;
            this.ckDisplayAngle.Location = new System.Drawing.Point(22, 121);
            this.ckDisplayAngle.Name = "ckDisplayAngle";
            this.ckDisplayAngle.Size = new System.Drawing.Size(102, 16);
            this.ckDisplayAngle.TabIndex = 8;
            this.ckDisplayAngle.Text = "Display Angle";
            this.ckDisplayAngle.UseVisualStyleBackColor = true;
            // 
            // ckStopTurnOver
            // 
            this.ckStopTurnOver.AutoSize = true;
            this.ckStopTurnOver.Location = new System.Drawing.Point(22, 95);
            this.ckStopTurnOver.Name = "ckStopTurnOver";
            this.ckStopTurnOver.Size = new System.Drawing.Size(116, 16);
            this.ckStopTurnOver.TabIndex = 7;
            this.ckStopTurnOver.Text = "Stop. If Collision";
            this.ckStopTurnOver.UseVisualStyleBackColor = true;
            // 
            // ckPerformance
            // 
            this.ckPerformance.AutoSize = true;
            this.ckPerformance.Location = new System.Drawing.Point(22, 146);
            this.ckPerformance.Name = "ckPerformance";
            this.ckPerformance.Size = new System.Drawing.Size(121, 16);
            this.ckPerformance.TabIndex = 6;
            this.ckPerformance.Text = "Performance Log";
            this.ckPerformance.UseVisualStyleBackColor = true;
            // 
            // ckAnimationOnly
            // 
            this.ckAnimationOnly.AutoSize = true;
            this.ckAnimationOnly.Checked = true;
            this.ckAnimationOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAnimationOnly.Location = new System.Drawing.Point(22, 70);
            this.ckAnimationOnly.Name = "ckAnimationOnly";
            this.ckAnimationOnly.Size = new System.Drawing.Size(110, 16);
            this.ckAnimationOnly.TabIndex = 5;
            this.ckAnimationOnly.Text = "Animation Only";
            this.ckAnimationOnly.UseVisualStyleBackColor = true;
            // 
            // txtTurnOverAngle
            // 
            this.txtTurnOverAngle.Location = new System.Drawing.Point(85, 28);
            this.txtTurnOverAngle.Name = "txtTurnOverAngle";
            this.txtTurnOverAngle.Size = new System.Drawing.Size(72, 21);
            this.txtTurnOverAngle.TabIndex = 4;
            this.txtTurnOverAngle.Text = "90";
            // 
            // cbTurnOverAxis
            // 
            this.cbTurnOverAxis.FormattingEnabled = true;
            this.cbTurnOverAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cbTurnOverAxis.Location = new System.Drawing.Point(22, 29);
            this.cbTurnOverAxis.Name = "cbTurnOverAxis";
            this.cbTurnOverAxis.Size = new System.Drawing.Size(57, 20);
            this.cbTurnOverAxis.TabIndex = 3;
            this.cbTurnOverAxis.Text = "X";
            // 
            // btnTurnOverRun
            // 
            this.btnTurnOverRun.Location = new System.Drawing.Point(177, 29);
            this.btnTurnOverRun.Name = "btnTurnOverRun";
            this.btnTurnOverRun.Size = new System.Drawing.Size(61, 23);
            this.btnTurnOverRun.TabIndex = 2;
            this.btnTurnOverRun.Text = "Run";
            this.btnTurnOverRun.UseVisualStyleBackColor = true;
            this.btnTurnOverRun.Click += new System.EventHandler(this.btnTurnOverRun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAlignCenterBlock);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Align";
            // 
            // btnAlignCenterBlock
            // 
            this.btnAlignCenterBlock.Location = new System.Drawing.Point(22, 20);
            this.btnAlignCenterBlock.Name = "btnAlignCenterBlock";
            this.btnAlignCenterBlock.Size = new System.Drawing.Size(75, 23);
            this.btnAlignCenterBlock.TabIndex = 2;
            this.btnAlignCenterBlock.Text = "Center";
            this.btnAlignCenterBlock.UseVisualStyleBackColor = true;
            this.btnAlignCenterBlock.Click += new System.EventHandler(this.btnAlignCenterBlock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLoadBlock2);
            this.groupBox1.Controls.Add(this.btnLoadBlock1);
            this.groupBox1.Controls.Add(this.btnLoadGoliath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Models";
            // 
            // btnLoadBlock2
            // 
            this.btnLoadBlock2.Location = new System.Drawing.Point(163, 20);
            this.btnLoadBlock2.Name = "btnLoadBlock2";
            this.btnLoadBlock2.Size = new System.Drawing.Size(54, 23);
            this.btnLoadBlock2.TabIndex = 2;
            this.btnLoadBlock2.Text = "BLK #2";
            this.btnLoadBlock2.UseVisualStyleBackColor = true;
            this.btnLoadBlock2.Click += new System.EventHandler(this.btnLoadBlock2_Click);
            // 
            // btnLoadBlock1
            // 
            this.btnLoadBlock1.Location = new System.Drawing.Point(103, 20);
            this.btnLoadBlock1.Name = "btnLoadBlock1";
            this.btnLoadBlock1.Size = new System.Drawing.Size(54, 23);
            this.btnLoadBlock1.TabIndex = 1;
            this.btnLoadBlock1.Text = "BLK #1";
            this.btnLoadBlock1.UseVisualStyleBackColor = true;
            this.btnLoadBlock1.Click += new System.EventHandler(this.btnLoadBlock1_Click);
            // 
            // btnLoadGoliath
            // 
            this.btnLoadGoliath.Location = new System.Drawing.Point(22, 20);
            this.btnLoadGoliath.Name = "btnLoadGoliath";
            this.btnLoadGoliath.Size = new System.Drawing.Size(75, 23);
            this.btnLoadGoliath.TabIndex = 0;
            this.btnLoadGoliath.Text = "GOLIATH";
            this.btnLoadGoliath.UseVisualStyleBackColor = true;
            this.btnLoadGoliath.Click += new System.EventHandler(this.btnLoadGoliath_Click);
            // 
            // backgroundWorkerTurnOver
            // 
            this.backgroundWorkerTurnOver.WorkerReportsProgress = true;
            this.backgroundWorkerTurnOver.WorkerSupportsCancellation = true;
            this.backgroundWorkerTurnOver.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTurnOver_DoWork);
            this.backgroundWorkerTurnOver.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerTurnOver_ProgressChanged);
            this.backgroundWorkerTurnOver.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerTurnOver_RunWorkerCompleted);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnReportDialog);
            this.groupBox5.Location = new System.Drawing.Point(12, 387);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 58);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Report";
            // 
            // btnReportDialog
            // 
            this.btnReportDialog.Location = new System.Drawing.Point(22, 20);
            this.btnReportDialog.Name = "btnReportDialog";
            this.btnReportDialog.Size = new System.Drawing.Size(75, 23);
            this.btnReportDialog.TabIndex = 2;
            this.btnReportDialog.Text = "Dialog";
            this.btnReportDialog.UseVisualStyleBackColor = true;
            this.btnReportDialog.Click += new System.EventHandler(this.btnReportDialog_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 621);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.TOB";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadBlock1;
        private System.Windows.Forms.Button btnLoadGoliath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAlignCenterBlock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTurnOverAngle;
        private System.Windows.Forms.ComboBox cbTurnOverAxis;
        private System.Windows.Forms.Button btnTurnOverRun;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTurnOver;
        private System.Windows.Forms.CheckBox ckAnimationOnly;
        private System.Windows.Forms.Button btnLoadBlock2;
        private System.Windows.Forms.CheckBox ckPerformance;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHighlightColor;
        private System.Windows.Forms.CheckBox ckStopTurnOver;
        private System.Windows.Forms.CheckBox ckDisplayAngle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnReportDialog;
    }
}

