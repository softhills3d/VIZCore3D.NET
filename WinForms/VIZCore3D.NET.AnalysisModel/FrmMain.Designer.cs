namespace VIZCore3D.NET.AnalysisModel
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
            this.btnPickSurface = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnViewModel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenAnalysis = new System.Windows.Forms.Button();
            this.btnOpenDesign = new System.Windows.Forms.Button();
            this.txtPathModel2 = new System.Windows.Forms.TextBox();
            this.txtPathModel1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckDepthTest = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 534);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnPickSurface);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 57);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Surface";
            // 
            // btnPickSurface
            // 
            this.btnPickSurface.Location = new System.Drawing.Point(18, 20);
            this.btnPickSurface.Name = "btnPickSurface";
            this.btnPickSurface.Size = new System.Drawing.Size(64, 23);
            this.btnPickSurface.TabIndex = 7;
            this.btnPickSurface.Text = "Pick";
            this.btnPickSurface.UseVisualStyleBackColor = true;
            this.btnPickSurface.Click += new System.EventHandler(this.btnPickSurface_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ckDepthTest);
            this.groupBox2.Controls.Add(this.btnViewModel);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 57);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // btnViewModel
            // 
            this.btnViewModel.Location = new System.Drawing.Point(18, 20);
            this.btnViewModel.Name = "btnViewModel";
            this.btnViewModel.Size = new System.Drawing.Size(64, 23);
            this.btnViewModel.TabIndex = 6;
            this.btnViewModel.Text = "Load";
            this.btnViewModel.UseVisualStyleBackColor = true;
            this.btnViewModel.Click += new System.EventHandler(this.btnViewModel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpenAnalysis);
            this.groupBox1.Controls.Add(this.btnOpenDesign);
            this.groupBox1.Controls.Add(this.txtPathModel2);
            this.groupBox1.Controls.Add(this.txtPathModel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // btnOpenAnalysis
            // 
            this.btnOpenAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenAnalysis.Location = new System.Drawing.Point(261, 59);
            this.btnOpenAnalysis.Name = "btnOpenAnalysis";
            this.btnOpenAnalysis.Size = new System.Drawing.Size(64, 23);
            this.btnOpenAnalysis.TabIndex = 5;
            this.btnOpenAnalysis.Text = "Open";
            this.btnOpenAnalysis.UseVisualStyleBackColor = true;
            this.btnOpenAnalysis.Click += new System.EventHandler(this.btnOpenAnalysis_Click);
            // 
            // btnOpenDesign
            // 
            this.btnOpenDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDesign.Location = new System.Drawing.Point(261, 25);
            this.btnOpenDesign.Name = "btnOpenDesign";
            this.btnOpenDesign.Size = new System.Drawing.Size(64, 23);
            this.btnOpenDesign.TabIndex = 4;
            this.btnOpenDesign.Text = "Open";
            this.btnOpenDesign.UseVisualStyleBackColor = true;
            this.btnOpenDesign.Click += new System.EventHandler(this.btnOpenDesign_Click);
            // 
            // txtPathModel2
            // 
            this.txtPathModel2.Location = new System.Drawing.Point(51, 61);
            this.txtPathModel2.Name = "txtPathModel2";
            this.txtPathModel2.Size = new System.Drawing.Size(204, 21);
            this.txtPathModel2.TabIndex = 3;
            // 
            // txtPathModel1
            // 
            this.txtPathModel1.Location = new System.Drawing.Point(51, 27);
            this.txtPathModel1.Name = "txtPathModel1";
            this.txtPathModel1.Size = new System.Drawing.Size(204, 21);
            this.txtPathModel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "해석";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "설계";
            // 
            // ckDepthTest
            // 
            this.ckDepthTest.AutoSize = true;
            this.ckDepthTest.Location = new System.Drawing.Point(107, 24);
            this.ckDepthTest.Name = "ckDepthTest";
            this.ckDepthTest.Size = new System.Drawing.Size(85, 16);
            this.ckDepthTest.TabIndex = 7;
            this.ckDepthTest.Text = "Depth Test";
            this.ckDepthTest.UseVisualStyleBackColor = true;
            this.ckDepthTest.CheckedChanged += new System.EventHandler(this.ckDepthTest_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 534);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.AnalysisModel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenAnalysis;
        private System.Windows.Forms.Button btnOpenDesign;
        private System.Windows.Forms.TextBox txtPathModel2;
        private System.Windows.Forms.TextBox txtPathModel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnViewModel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPickSurface;
        private System.Windows.Forms.CheckBox ckDepthTest;
    }
}

