namespace VIZCore3D.NET.GroupSilhouetteEdge
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
            this.ckHiddenLine = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbGroupWidth = new System.Windows.Forms.ComboBox();
            this.cbGroupId = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnVisible = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckGeneralDotted = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbWidth = new System.Windows.Forms.ComboBox();
            this.btnAllColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDot = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.cbHiddenLineType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1104, 551);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbHiddenLineType);
            this.groupBox3.Controls.Add(this.ckHiddenLine);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.cbGroupWidth);
            this.groupBox3.Controls.Add(this.cbGroupId);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnVisible);
            this.groupBox3.Location = new System.Drawing.Point(12, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 242);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Basic";
            // 
            // ckHiddenLine
            // 
            this.ckHiddenLine.AutoSize = true;
            this.ckHiddenLine.Location = new System.Drawing.Point(23, 180);
            this.ckHiddenLine.Name = "ckHiddenLine";
            this.ckHiddenLine.Size = new System.Drawing.Size(91, 16);
            this.ckHiddenLine.TabIndex = 10;
            this.ckHiddenLine.Text = "Hidden Line";
            this.ckHiddenLine.UseVisualStyleBackColor = true;
            this.ckHiddenLine.CheckedChanged += new System.EventHandler(this.ckHiddenLine_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Group ID:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(23, 142);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(197, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbGroupWidth
            // 
            this.cbGroupWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupWidth.FormattingEnabled = true;
            this.cbGroupWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbGroupWidth.Location = new System.Drawing.Point(81, 107);
            this.cbGroupWidth.Name = "cbGroupWidth";
            this.cbGroupWidth.Size = new System.Drawing.Size(140, 20);
            this.cbGroupWidth.TabIndex = 8;
            this.cbGroupWidth.SelectedValueChanged += new System.EventHandler(this.cbGroupWidth_SelectedValueChanged);
            // 
            // cbGroupId
            // 
            this.cbGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupId.FormattingEnabled = true;
            this.cbGroupId.Location = new System.Drawing.Point(81, 71);
            this.cbGroupId.Name = "cbGroupId";
            this.cbGroupId.Size = new System.Drawing.Size(64, 20);
            this.cbGroupId.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(151, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(23, 31);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(197, 23);
            this.btnVisible.TabIndex = 2;
            this.btnVisible.Text = "Visible";
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckGeneralDotted);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbWidth);
            this.groupBox1.Controls.Add(this.btnAllColor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // ckGeneralDotted
            // 
            this.ckGeneralDotted.AutoSize = true;
            this.ckGeneralDotted.Location = new System.Drawing.Point(151, 36);
            this.ckGeneralDotted.Name = "ckGeneralDotted";
            this.ckGeneralDotted.Size = new System.Drawing.Size(59, 16);
            this.ckGeneralDotted.TabIndex = 4;
            this.ckGeneralDotted.Text = "Dotted";
            this.ckGeneralDotted.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Width: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGeneralAdd_Click);
            // 
            // cbWidth
            // 
            this.cbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWidth.FormattingEnabled = true;
            this.cbWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbWidth.Location = new System.Drawing.Point(70, 68);
            this.cbWidth.Name = "cbWidth";
            this.cbWidth.Size = new System.Drawing.Size(140, 20);
            this.cbWidth.TabIndex = 4;
            this.cbWidth.SelectedIndexChanged += new System.EventHandler(this.cbWidth_SelectedIndexChanged);
            // 
            // btnAllColor
            // 
            this.btnAllColor.Location = new System.Drawing.Point(23, 32);
            this.btnAllColor.Name = "btnAllColor";
            this.btnAllColor.Size = new System.Drawing.Size(75, 23);
            this.btnAllColor.TabIndex = 6;
            this.btnAllColor.Text = "Color";
            this.btnAllColor.UseVisualStyleBackColor = true;
            this.btnAllColor.Click += new System.EventHandler(this.btnAllColor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbDot);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 115);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom";
            // 
            // cbDot
            // 
            this.cbDot.AutoSize = true;
            this.cbDot.Location = new System.Drawing.Point(151, 34);
            this.cbDot.Name = "cbDot";
            this.cbDot.Size = new System.Drawing.Size(59, 16);
            this.cbDot.TabIndex = 3;
            this.cbDot.Text = "Dotted";
            this.cbDot.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(23, 30);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cbHiddenLineType
            // 
            this.cbHiddenLineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHiddenLineType.FormattingEnabled = true;
            this.cbHiddenLineType.Items.AddRange(new object[] {
            "Line",
            "Dotted"});
            this.cbHiddenLineType.Location = new System.Drawing.Point(132, 208);
            this.cbHiddenLineType.Name = "cbHiddenLineType";
            this.cbHiddenLineType.Size = new System.Drawing.Size(88, 20);
            this.cbHiddenLineType.TabIndex = 11;
            this.cbHiddenLineType.SelectedIndexChanged += new System.EventHandler(this.cbHiddenLineType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hidden Line Type";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 551);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.MeasureFrame";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVisible;
        private System.Windows.Forms.CheckBox cbDot;
        private System.Windows.Forms.ComboBox cbWidth;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAllColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbGroupId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckGeneralDotted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGroupWidth;
        private System.Windows.Forms.CheckBox ckHiddenLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHiddenLineType;
    }
}

