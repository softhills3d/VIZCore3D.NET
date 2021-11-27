namespace VIZCore3D.NET.ShortestDistance
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
            this.ckXPlus = new System.Windows.Forms.CheckBox();
            this.ckXMinus = new System.Windows.Forms.CheckBox();
            this.ckYMinus = new System.Windows.Forms.CheckBox();
            this.ckYPlus = new System.Windows.Forms.CheckBox();
            this.ckZMinus = new System.Windows.Forms.CheckBox();
            this.ckZPlus = new System.Windows.Forms.CheckBox();
            this.Osnap = new System.Windows.Forms.GroupBox();
            this.ckVertex = new System.Windows.Forms.CheckBox();
            this.ckSurface = new System.Windows.Forms.CheckBox();
            this.btnShowOsnap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.ckVisibleOnly = new System.Windows.Forms.CheckBox();
            this.ckOpaqueOnly = new System.Windows.Forms.CheckBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnFind);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1445, 822);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckZMinus);
            this.groupBox1.Controls.Add(this.ckZPlus);
            this.groupBox1.Controls.Add(this.ckYMinus);
            this.groupBox1.Controls.Add(this.ckYPlus);
            this.groupBox1.Controls.Add(this.ckXMinus);
            this.groupBox1.Controls.Add(this.ckXPlus);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option : Axis";
            // 
            // ckXPlus
            // 
            this.ckXPlus.AutoSize = true;
            this.ckXPlus.Checked = true;
            this.ckXPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckXPlus.Location = new System.Drawing.Point(45, 31);
            this.ckXPlus.Name = "ckXPlus";
            this.ckXPlus.Size = new System.Drawing.Size(38, 16);
            this.ckXPlus.TabIndex = 0;
            this.ckXPlus.Text = "X+";
            this.ckXPlus.UseVisualStyleBackColor = true;
            // 
            // ckXMinus
            // 
            this.ckXMinus.AutoSize = true;
            this.ckXMinus.Checked = true;
            this.ckXMinus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckXMinus.Location = new System.Drawing.Point(136, 31);
            this.ckXMinus.Name = "ckXMinus";
            this.ckXMinus.Size = new System.Drawing.Size(38, 16);
            this.ckXMinus.TabIndex = 1;
            this.ckXMinus.Text = "X-";
            this.ckXMinus.UseVisualStyleBackColor = true;
            // 
            // ckYMinus
            // 
            this.ckYMinus.AutoSize = true;
            this.ckYMinus.Checked = true;
            this.ckYMinus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckYMinus.Location = new System.Drawing.Point(136, 64);
            this.ckYMinus.Name = "ckYMinus";
            this.ckYMinus.Size = new System.Drawing.Size(38, 16);
            this.ckYMinus.TabIndex = 3;
            this.ckYMinus.Text = "Y-";
            this.ckYMinus.UseVisualStyleBackColor = true;
            // 
            // ckYPlus
            // 
            this.ckYPlus.AutoSize = true;
            this.ckYPlus.Checked = true;
            this.ckYPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckYPlus.Location = new System.Drawing.Point(45, 64);
            this.ckYPlus.Name = "ckYPlus";
            this.ckYPlus.Size = new System.Drawing.Size(38, 16);
            this.ckYPlus.TabIndex = 2;
            this.ckYPlus.Text = "Y+";
            this.ckYPlus.UseVisualStyleBackColor = true;
            // 
            // ckZMinus
            // 
            this.ckZMinus.AutoSize = true;
            this.ckZMinus.Location = new System.Drawing.Point(136, 99);
            this.ckZMinus.Name = "ckZMinus";
            this.ckZMinus.Size = new System.Drawing.Size(38, 16);
            this.ckZMinus.TabIndex = 5;
            this.ckZMinus.Text = "Z-";
            this.ckZMinus.UseVisualStyleBackColor = true;
            // 
            // ckZPlus
            // 
            this.ckZPlus.AutoSize = true;
            this.ckZPlus.Location = new System.Drawing.Point(45, 99);
            this.ckZPlus.Name = "ckZPlus";
            this.ckZPlus.Size = new System.Drawing.Size(38, 16);
            this.ckZPlus.TabIndex = 4;
            this.ckZPlus.Text = "Z+";
            this.ckZPlus.UseVisualStyleBackColor = true;
            // 
            // Osnap
            // 
            this.Osnap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Osnap.Controls.Add(this.btnShowOsnap);
            this.Osnap.Controls.Add(this.ckVertex);
            this.Osnap.Controls.Add(this.ckSurface);
            this.Osnap.Location = new System.Drawing.Point(12, 12);
            this.Osnap.Name = "Osnap";
            this.Osnap.Size = new System.Drawing.Size(310, 76);
            this.Osnap.TabIndex = 2;
            this.Osnap.TabStop = false;
            this.Osnap.Text = "Osnap Kind";
            // 
            // ckVertex
            // 
            this.ckVertex.AutoSize = true;
            this.ckVertex.Checked = true;
            this.ckVertex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckVertex.Location = new System.Drawing.Point(103, 33);
            this.ckVertex.Name = "ckVertex";
            this.ckVertex.Size = new System.Drawing.Size(52, 16);
            this.ckVertex.TabIndex = 1;
            this.ckVertex.Text = "Point";
            this.ckVertex.UseVisualStyleBackColor = true;
            // 
            // ckSurface
            // 
            this.ckSurface.AutoSize = true;
            this.ckSurface.Location = new System.Drawing.Point(30, 33);
            this.ckSurface.Name = "ckSurface";
            this.ckSurface.Size = new System.Drawing.Size(67, 16);
            this.ckSurface.TabIndex = 0;
            this.ckSurface.Text = "Surface";
            this.ckSurface.UseVisualStyleBackColor = true;
            // 
            // btnShowOsnap
            // 
            this.btnShowOsnap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowOsnap.Location = new System.Drawing.Point(175, 29);
            this.btnShowOsnap.Name = "btnShowOsnap";
            this.btnShowOsnap.Size = new System.Drawing.Size(129, 23);
            this.btnShowOsnap.TabIndex = 2;
            this.btnShowOsnap.Text = "Show Osnap";
            this.btnShowOsnap.UseVisualStyleBackColor = true;
            this.btnShowOsnap.Click += new System.EventHandler(this.btnShowOsnap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ckOpaqueOnly);
            this.groupBox2.Controls.Add(this.ckVisibleOnly);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 102);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option : Filter";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(247, 362);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ckVisibleOnly
            // 
            this.ckVisibleOnly.AutoSize = true;
            this.ckVisibleOnly.Location = new System.Drawing.Point(45, 38);
            this.ckVisibleOnly.Name = "ckVisibleOnly";
            this.ckVisibleOnly.Size = new System.Drawing.Size(92, 16);
            this.ckVisibleOnly.TabIndex = 0;
            this.ckVisibleOnly.Text = "Visible Only";
            this.ckVisibleOnly.UseVisualStyleBackColor = true;
            // 
            // ckOpaqueOnly
            // 
            this.ckOpaqueOnly.AutoSize = true;
            this.ckOpaqueOnly.Location = new System.Drawing.Point(45, 73);
            this.ckOpaqueOnly.Name = "ckOpaqueOnly";
            this.ckOpaqueOnly.Size = new System.Drawing.Size(98, 16);
            this.ckOpaqueOnly.TabIndex = 1;
            this.ckOpaqueOnly.Text = "Opaque Only";
            this.ckOpaqueOnly.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 822);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.ShortestDistance";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Osnap.ResumeLayout(false);
            this.Osnap.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckZMinus;
        private System.Windows.Forms.CheckBox ckZPlus;
        private System.Windows.Forms.CheckBox ckYMinus;
        private System.Windows.Forms.CheckBox ckYPlus;
        private System.Windows.Forms.CheckBox ckXMinus;
        private System.Windows.Forms.CheckBox ckXPlus;
        private System.Windows.Forms.GroupBox Osnap;
        private System.Windows.Forms.Button btnShowOsnap;
        private System.Windows.Forms.CheckBox ckVertex;
        private System.Windows.Forms.CheckBox ckSurface;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckOpaqueOnly;
        private System.Windows.Forms.CheckBox ckVisibleOnly;
        private System.Windows.Forms.Button btnFind;
    }
}

