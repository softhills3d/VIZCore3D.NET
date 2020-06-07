namespace VIZCore3D.NET.MiniView
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
            this.btnUpdateModel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckTopMost = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.rbIndex = new System.Windows.Forms.RadioButton();
            this.rbSelected = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1109, 677);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnUpdateModel);
            this.groupBox4.Location = new System.Drawing.Point(12, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 81);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update";
            // 
            // btnUpdateModel
            // 
            this.btnUpdateModel.Location = new System.Drawing.Point(31, 35);
            this.btnUpdateModel.Name = "btnUpdateModel";
            this.btnUpdateModel.Size = new System.Drawing.Size(238, 31);
            this.btnUpdateModel.TabIndex = 0;
            this.btnUpdateModel.Text = "Update Model";
            this.btnUpdateModel.UseVisualStyleBackColor = true;
            this.btnUpdateModel.Click += new System.EventHandler(this.btnUpdateModel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ckTopMost);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Property";
            // 
            // ckTopMost
            // 
            this.ckTopMost.AutoSize = true;
            this.ckTopMost.Location = new System.Drawing.Point(34, 30);
            this.ckTopMost.Name = "ckTopMost";
            this.ckTopMost.Size = new System.Drawing.Size(78, 16);
            this.ckTopMost.TabIndex = 0;
            this.ckTopMost.Text = "Top Most";
            this.ckTopMost.UseVisualStyleBackColor = true;
            this.ckTopMost.CheckedChanged += new System.EventHandler(this.ckTopMost_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtIndex);
            this.groupBox2.Controls.Add(this.rbIndex);
            this.groupBox2.Controls.Add(this.rbSelected);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // txtIndex
            // 
            this.txtIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIndex.Location = new System.Drawing.Point(133, 60);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 21);
            this.txtIndex.TabIndex = 2;
            // 
            // rbIndex
            // 
            this.rbIndex.AutoSize = true;
            this.rbIndex.Location = new System.Drawing.Point(34, 61);
            this.rbIndex.Name = "rbIndex";
            this.rbIndex.Size = new System.Drawing.Size(59, 16);
            this.rbIndex.TabIndex = 1;
            this.rbIndex.Text = "INDEX";
            this.rbIndex.UseVisualStyleBackColor = true;
            // 
            // rbSelected
            // 
            this.rbSelected.AutoSize = true;
            this.rbSelected.Checked = true;
            this.rbSelected.Location = new System.Drawing.Point(31, 28);
            this.rbSelected.Name = "rbSelected";
            this.rbSelected.Size = new System.Drawing.Size(72, 16);
            this.rbSelected.TabIndex = 0;
            this.rbSelected.TabStop = true;
            this.rbSelected.Text = "Selected";
            this.rbSelected.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnHide);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(124, 38);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(31, 38);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Location = new System.Drawing.Point(12, 385);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 200);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mini View";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 677);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.MiniView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.RadioButton rbIndex;
        private System.Windows.Forms.RadioButton rbSelected;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckTopMost;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateModel;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

