namespace VIZCore3D.NET.EnclosureSearch
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnFit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStepOpenSpace = new System.Windows.Forms.Button();
            this.btnStepAddTarget = new System.Windows.Forms.Button();
            this.btnStepSelectSpace = new System.Windows.Forms.Button();
            this.btnStepSearch = new System.Windows.Forms.Button();
            this.btnStepHideSpace = new System.Windows.Forms.Button();
            this.btnStepTransparency = new System.Windows.Forms.Button();
            this.btnStepSilhouette = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnStepSilhouette);
            this.panelLeft.Controls.Add(this.btnStepTransparency);
            this.panelLeft.Controls.Add(this.btnStepHideSpace);
            this.panelLeft.Controls.Add(this.btnStepSearch);
            this.panelLeft.Controls.Add(this.btnStepSelectSpace);
            this.panelLeft.Controls.Add(this.btnStepAddTarget);
            this.panelLeft.Controls.Add(this.btnStepOpenSpace);
            this.panelLeft.Controls.Add(this.label6);
            this.panelLeft.Controls.Add(this.label5);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.btnFit);
            this.panelLeft.Controls.Add(this.btnClose);
            this.panelLeft.Controls.Add(this.btnOpen);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(302, 739);
            this.panelLeft.TabIndex = 0;
            // 
            // btnFit
            // 
            this.btnFit.Enabled = false;
            this.btnFit.Location = new System.Drawing.Point(200, 8);
            this.btnFit.Name = "btnFit";
            this.btnFit.Size = new System.Drawing.Size(90, 26);
            this.btnFit.TabIndex = 2;
            this.btnFit.Text = "Fit";
            this.btnFit.UseVisualStyleBackColor = true;
            this.btnFit.Click += new System.EventHandler(this.btnFit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(104, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(8, 8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 26);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panelView
            // 
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(302, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(882, 739);
            this.panelView.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1169, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Initializing...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.MaximumSize = new System.Drawing.Size(278, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. 아래 버튼으로 공간 모델과 검색 대상 모델을 차례로 엽니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.MaximumSize = new System.Drawing.Size(278, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. 모델 트리를 열고, 공간 모델의 루트 노드를 선택합니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.MaximumSize = new System.Drawing.Size(278, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "3. 공간 검색을 실행합니다. (우측 패널의 \"공간 검색\" 버튼과 같습니다.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 296);
            this.label4.MaximumSize = new System.Drawing.Size(278, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "4. 공간 모델을 끕니다. (모델 트리에서 공간 모델 체크 해제와 같습니다.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 378);
            this.label5.MaximumSize = new System.Drawing.Size(278, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "5. 검색 대상 모델의 투명도를 약 90% 로 바꿉니다. (검색 결과 Part 는 불투명하게 유지합니다.)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 460);
            this.label6.MaximumSize = new System.Drawing.Size(278, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "6. 결과를 확인합니다. (윤곽을 켜면 좀 더 가시성이 좋아집니다.)";
            // 
            // btnStepOpenSpace
            // 
            this.btnStepOpenSpace.Enabled = false;
            this.btnStepOpenSpace.Location = new System.Drawing.Point(12, 90);
            this.btnStepOpenSpace.Name = "btnStepOpenSpace";
            this.btnStepOpenSpace.Size = new System.Drawing.Size(135, 28);
            this.btnStepOpenSpace.TabIndex = 10;
            this.btnStepOpenSpace.Text = "공간 모델 열기";
            this.btnStepOpenSpace.UseVisualStyleBackColor = true;
            this.btnStepOpenSpace.Click += new System.EventHandler(this.btnStepOpenSpace_Click);
            // 
            // btnStepAddTarget
            // 
            this.btnStepAddTarget.Enabled = false;
            this.btnStepAddTarget.Location = new System.Drawing.Point(155, 90);
            this.btnStepAddTarget.Name = "btnStepAddTarget";
            this.btnStepAddTarget.Size = new System.Drawing.Size(135, 28);
            this.btnStepAddTarget.TabIndex = 11;
            this.btnStepAddTarget.Text = "검색 대상 모델 추가";
            this.btnStepAddTarget.UseVisualStyleBackColor = true;
            this.btnStepAddTarget.Click += new System.EventHandler(this.btnStepAddTarget_Click);
            // 
            // btnStepSelectSpace
            // 
            this.btnStepSelectSpace.Enabled = false;
            this.btnStepSelectSpace.Location = new System.Drawing.Point(12, 172);
            this.btnStepSelectSpace.Name = "btnStepSelectSpace";
            this.btnStepSelectSpace.Size = new System.Drawing.Size(278, 28);
            this.btnStepSelectSpace.TabIndex = 12;
            this.btnStepSelectSpace.Text = "공간 모델 루트 노드 선택";
            this.btnStepSelectSpace.UseVisualStyleBackColor = true;
            this.btnStepSelectSpace.Click += new System.EventHandler(this.btnStepSelectSpace_Click);
            // 
            // btnStepSearch
            // 
            this.btnStepSearch.Enabled = false;
            this.btnStepSearch.Location = new System.Drawing.Point(12, 254);
            this.btnStepSearch.Name = "btnStepSearch";
            this.btnStepSearch.Size = new System.Drawing.Size(278, 28);
            this.btnStepSearch.TabIndex = 13;
            this.btnStepSearch.Text = "공간 검색";
            this.btnStepSearch.UseVisualStyleBackColor = true;
            this.btnStepSearch.Click += new System.EventHandler(this.btnStepSearch_Click);
            // 
            // btnStepHideSpace
            // 
            this.btnStepHideSpace.Enabled = false;
            this.btnStepHideSpace.Location = new System.Drawing.Point(12, 336);
            this.btnStepHideSpace.Name = "btnStepHideSpace";
            this.btnStepHideSpace.Size = new System.Drawing.Size(278, 28);
            this.btnStepHideSpace.TabIndex = 14;
            this.btnStepHideSpace.Text = "공간 모델 끄기";
            this.btnStepHideSpace.UseVisualStyleBackColor = true;
            this.btnStepHideSpace.Click += new System.EventHandler(this.btnStepHideSpace_Click);
            // 
            // btnStepTransparency
            // 
            this.btnStepTransparency.Enabled = false;
            this.btnStepTransparency.Location = new System.Drawing.Point(12, 418);
            this.btnStepTransparency.Name = "btnStepTransparency";
            this.btnStepTransparency.Size = new System.Drawing.Size(278, 28);
            this.btnStepTransparency.TabIndex = 15;
            this.btnStepTransparency.Text = "검색 대상 모델 투명도 90%";
            this.btnStepTransparency.UseVisualStyleBackColor = true;
            this.btnStepTransparency.Click += new System.EventHandler(this.btnStepTransparency_Click);
            // 
            // btnStepSilhouette
            // 
            this.btnStepSilhouette.Enabled = false;
            this.btnStepSilhouette.Location = new System.Drawing.Point(12, 500);
            this.btnStepSilhouette.Name = "btnStepSilhouette";
            this.btnStepSilhouette.Size = new System.Drawing.Size(278, 28);
            this.btnStepSilhouette.TabIndex = 16;
            this.btnStepSilhouette.Text = "윤곽 켜기";
            this.btnStepSilhouette.UseVisualStyleBackColor = true;
            this.btnStepSilhouette.Click += new System.EventHandler(this.btnStepSilhouette_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.EnclosureSearch";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFit;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStepOpenSpace;
        private System.Windows.Forms.Button btnStepAddTarget;
        private System.Windows.Forms.Button btnStepSelectSpace;
        private System.Windows.Forms.Button btnStepSearch;
        private System.Windows.Forms.Button btnStepHideSpace;
        private System.Windows.Forms.Button btnStepTransparency;
        private System.Windows.Forms.Button btnStepSilhouette;
    }
}
