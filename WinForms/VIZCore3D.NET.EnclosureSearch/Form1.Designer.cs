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
            this.panelLeft.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
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
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.MaximumSize = new System.Drawing.Size(278, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. 상단에 Open 버튼을 클릭하여 공간 모델, 검색 대상 모델을 엽니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.MaximumSize = new System.Drawing.Size(278, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. 모델 트리를 열고, 공간 모델의 루트 노드를 클릭합니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.MaximumSize = new System.Drawing.Size(278, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "3. 우측 패널에 \"공간 검색\" 버튼을 클릭합니다.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.MaximumSize = new System.Drawing.Size(278, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "4. 모델 트리에서 공간 모델을 끕니다.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 272);
            this.label5.MaximumSize = new System.Drawing.Size(278, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "5. 모델 트리에서 검색 대상 모델을 클릭 후, 상단 툴바에서 \"선택 개체 투명도\" 를 약 90% 로 바꿉니다.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 340);
            this.label6.MaximumSize = new System.Drawing.Size(278, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "6. 결과를 확인합니다. (상단 툴바에서 렌더링 효과 개별 설정 --> 윤곽을 켜면 좀더 가시성이 좋아집니다.)";
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
    }
}
