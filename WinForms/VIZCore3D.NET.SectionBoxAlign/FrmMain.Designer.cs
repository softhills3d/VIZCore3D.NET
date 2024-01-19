namespace VIZCore3D.NET.SectionBoxAlign
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
            this.btnAddSectionBox = new System.Windows.Forms.Button();
            this.btnClearSectionBox = new System.Windows.Forms.Button();
            this.Osnap = new System.Windows.Forms.GroupBox();
            this.ckCircle = new System.Windows.Forms.CheckBox();
            this.ckLine = new System.Windows.Forms.CheckBox();
            this.ckVertex = new System.Windows.Forms.CheckBox();
            this.ckSurface = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowOsnap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Osnap.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.Osnap);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(981, 545);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClearSectionBox);
            this.groupBox1.Controls.Add(this.btnAddSectionBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SectionBox";
            // 
            // btnAddSectionBox
            // 
            this.btnAddSectionBox.Location = new System.Drawing.Point(25, 30);
            this.btnAddSectionBox.Name = "btnAddSectionBox";
            this.btnAddSectionBox.Size = new System.Drawing.Size(75, 23);
            this.btnAddSectionBox.TabIndex = 0;
            this.btnAddSectionBox.Text = "Add";
            this.btnAddSectionBox.UseVisualStyleBackColor = true;
            this.btnAddSectionBox.Click += new System.EventHandler(this.btnAddSectionBox_Click);
            // 
            // btnClearSectionBox
            // 
            this.btnClearSectionBox.Location = new System.Drawing.Point(106, 30);
            this.btnClearSectionBox.Name = "btnClearSectionBox";
            this.btnClearSectionBox.Size = new System.Drawing.Size(75, 23);
            this.btnClearSectionBox.TabIndex = 1;
            this.btnClearSectionBox.Text = "Clear";
            this.btnClearSectionBox.UseVisualStyleBackColor = true;
            this.btnClearSectionBox.Click += new System.EventHandler(this.btnClearSectionBox_Click);
            // 
            // Osnap
            // 
            this.Osnap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Osnap.Controls.Add(this.ckCircle);
            this.Osnap.Controls.Add(this.ckLine);
            this.Osnap.Controls.Add(this.ckVertex);
            this.Osnap.Controls.Add(this.ckSurface);
            this.Osnap.Location = new System.Drawing.Point(12, 94);
            this.Osnap.Name = "Osnap";
            this.Osnap.Size = new System.Drawing.Size(305, 74);
            this.Osnap.TabIndex = 1;
            this.Osnap.TabStop = false;
            this.Osnap.Text = "Osnap Kind";
            // 
            // ckCircle
            // 
            this.ckCircle.AutoSize = true;
            this.ckCircle.Enabled = false;
            this.ckCircle.Location = new System.Drawing.Point(210, 32);
            this.ckCircle.Name = "ckCircle";
            this.ckCircle.Size = new System.Drawing.Size(57, 16);
            this.ckCircle.TabIndex = 3;
            this.ckCircle.Text = "Circle";
            this.ckCircle.UseVisualStyleBackColor = true;
            // 
            // ckLine
            // 
            this.ckLine.AutoSize = true;
            this.ckLine.Checked = true;
            this.ckLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckLine.Location = new System.Drawing.Point(156, 32);
            this.ckLine.Name = "ckLine";
            this.ckLine.Size = new System.Drawing.Size(48, 16);
            this.ckLine.TabIndex = 2;
            this.ckLine.Text = "Line";
            this.ckLine.UseVisualStyleBackColor = true;
            // 
            // ckVertex
            // 
            this.ckVertex.AutoSize = true;
            this.ckVertex.Enabled = false;
            this.ckVertex.Location = new System.Drawing.Point(98, 32);
            this.ckVertex.Name = "ckVertex";
            this.ckVertex.Size = new System.Drawing.Size(52, 16);
            this.ckVertex.TabIndex = 1;
            this.ckVertex.Text = "Point";
            this.ckVertex.UseVisualStyleBackColor = true;
            // 
            // ckSurface
            // 
            this.ckSurface.AutoSize = true;
            this.ckSurface.Enabled = false;
            this.ckSurface.Location = new System.Drawing.Point(25, 32);
            this.ckSurface.Name = "ckSurface";
            this.ckSurface.Size = new System.Drawing.Size(67, 16);
            this.ckSurface.TabIndex = 0;
            this.ckSurface.Text = "Surface";
            this.ckSurface.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnShowOsnap);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Osnap";
            // 
            // btnShowOsnap
            // 
            this.btnShowOsnap.Location = new System.Drawing.Point(22, 24);
            this.btnShowOsnap.Name = "btnShowOsnap";
            this.btnShowOsnap.Size = new System.Drawing.Size(147, 31);
            this.btnShowOsnap.TabIndex = 0;
            this.btnShowOsnap.Text = "Show";
            this.btnShowOsnap.UseVisualStyleBackColor = true;
            this.btnShowOsnap.Click += new System.EventHandler(this.btnShowOsnap_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 545);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.SectionBoxAlign";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Osnap.ResumeLayout(false);
            this.Osnap.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearSectionBox;
        private System.Windows.Forms.Button btnAddSectionBox;
        private System.Windows.Forms.GroupBox Osnap;
        private System.Windows.Forms.CheckBox ckCircle;
        private System.Windows.Forms.CheckBox ckLine;
        private System.Windows.Forms.CheckBox ckVertex;
        private System.Windows.Forms.CheckBox ckSurface;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowOsnap;
    }
}

