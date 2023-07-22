namespace VIZCore3D.NET.SectionAutoClip
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
            this.btnClearSection = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHandleDisable = new System.Windows.Forms.Button();
            this.btnHandleSize = new System.Windows.Forms.Button();
            this.btnHandleMove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckParentObject = new System.Windows.Forms.CheckBox();
            this.ckMargin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckModelBoundBox = new System.Windows.Forms.CheckBox();
            this.ckEnable = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1013, 586);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnClearSection);
            this.groupBox3.Location = new System.Drawing.Point(12, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 62);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clear";
            // 
            // btnClearSection
            // 
            this.btnClearSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSection.Location = new System.Drawing.Point(19, 20);
            this.btnClearSection.Name = "btnClearSection";
            this.btnClearSection.Size = new System.Drawing.Size(159, 23);
            this.btnClearSection.TabIndex = 0;
            this.btnClearSection.Text = "Section";
            this.btnClearSection.UseVisualStyleBackColor = true;
            this.btnClearSection.Click += new System.EventHandler(this.btnClearSection_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnHandleDisable);
            this.groupBox2.Controls.Add(this.btnHandleSize);
            this.groupBox2.Controls.Add(this.btnHandleMove);
            this.groupBox2.Location = new System.Drawing.Point(12, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 137);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Handle";
            // 
            // btnHandleDisable
            // 
            this.btnHandleDisable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHandleDisable.Location = new System.Drawing.Point(19, 96);
            this.btnHandleDisable.Name = "btnHandleDisable";
            this.btnHandleDisable.Size = new System.Drawing.Size(159, 23);
            this.btnHandleDisable.TabIndex = 2;
            this.btnHandleDisable.Text = "Disable";
            this.btnHandleDisable.UseVisualStyleBackColor = true;
            this.btnHandleDisable.Click += new System.EventHandler(this.btnHandleDisable_Click);
            // 
            // btnHandleSize
            // 
            this.btnHandleSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHandleSize.Location = new System.Drawing.Point(19, 57);
            this.btnHandleSize.Name = "btnHandleSize";
            this.btnHandleSize.Size = new System.Drawing.Size(159, 23);
            this.btnHandleSize.TabIndex = 1;
            this.btnHandleSize.Text = "Scale";
            this.btnHandleSize.UseVisualStyleBackColor = true;
            this.btnHandleSize.Click += new System.EventHandler(this.btnHandleScale_Click);
            // 
            // btnHandleMove
            // 
            this.btnHandleMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHandleMove.Location = new System.Drawing.Point(19, 20);
            this.btnHandleMove.Name = "btnHandleMove";
            this.btnHandleMove.Size = new System.Drawing.Size(159, 23);
            this.btnHandleMove.TabIndex = 0;
            this.btnHandleMove.Text = "Move";
            this.btnHandleMove.UseVisualStyleBackColor = true;
            this.btnHandleMove.Click += new System.EventHandler(this.btnHandleMove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckParentObject);
            this.groupBox1.Controls.Add(this.ckMargin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtZ);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckModelBoundBox);
            this.groupBox1.Controls.Add(this.ckEnable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Clip";
            // 
            // ckParentObject
            // 
            this.ckParentObject.AutoSize = true;
            this.ckParentObject.Location = new System.Drawing.Point(35, 73);
            this.ckParentObject.Name = "ckParentObject";
            this.ckParentObject.Size = new System.Drawing.Size(100, 16);
            this.ckParentObject.TabIndex = 10;
            this.ckParentObject.Text = "Parent Object";
            this.ckParentObject.UseVisualStyleBackColor = true;
            // 
            // ckMargin
            // 
            this.ckMargin.AutoSize = true;
            this.ckMargin.Checked = true;
            this.ckMargin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckMargin.Location = new System.Drawing.Point(35, 95);
            this.ckMargin.Name = "ckMargin";
            this.ckMargin.Size = new System.Drawing.Size(63, 16);
            this.ckMargin.TabIndex = 9;
            this.ckMargin.Text = "Margin";
            this.ckMargin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(69, 183);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(80, 21);
            this.txtZ.TabIndex = 5;
            this.txtZ.Text = "5000";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(69, 156);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(80, 21);
            this.txtY.TabIndex = 4;
            this.txtY.Text = "5000";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(69, 129);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(80, 21);
            this.txtX.TabIndex = 3;
            this.txtX.Text = "5000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Margin";
            // 
            // ckModelBoundBox
            // 
            this.ckModelBoundBox.AutoSize = true;
            this.ckModelBoundBox.Location = new System.Drawing.Point(35, 51);
            this.ckModelBoundBox.Name = "ckModelBoundBox";
            this.ckModelBoundBox.Size = new System.Drawing.Size(125, 16);
            this.ckModelBoundBox.TabIndex = 1;
            this.ckModelBoundBox.Text = "Model Bound Box";
            this.ckModelBoundBox.UseVisualStyleBackColor = true;
            // 
            // ckEnable
            // 
            this.ckEnable.AutoSize = true;
            this.ckEnable.Checked = true;
            this.ckEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckEnable.Location = new System.Drawing.Point(19, 29);
            this.ckEnable.Name = "ckEnable";
            this.ckEnable.Size = new System.Drawing.Size(63, 16);
            this.ckEnable.TabIndex = 0;
            this.ckEnable.Text = "Enable";
            this.ckEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnAddNote);
            this.groupBox4.Location = new System.Drawing.Point(12, 448);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 62);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Note";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNote.Location = new System.Drawing.Point(19, 20);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(63, 23);
            this.btnAddNote.TabIndex = 0;
            this.btnAddNote.Text = "Add";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 586);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.SectionAutoClip";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHandleDisable;
        private System.Windows.Forms.Button btnHandleSize;
        private System.Windows.Forms.Button btnHandleMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckMargin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckModelBoundBox;
        private System.Windows.Forms.CheckBox ckEnable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearSection;
        private System.Windows.Forms.CheckBox ckParentObject;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddNote;
    }
}

