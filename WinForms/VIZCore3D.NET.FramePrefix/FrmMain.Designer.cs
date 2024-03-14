namespace VIZCore3D.NET.FramePrefix
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
            this.groupBoxOption = new System.Windows.Forms.GroupBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.checkBoxSetPrefix = new System.Windows.Forms.CheckBox();
            this.radioButtonPosition = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.groupBoxOpen = new System.Windows.Forms.GroupBox();
            this.buttonFrameOpen = new System.Windows.Forms.Button();
            this.buttonModelOpen = new System.Windows.Forms.Button();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxZ = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxOption.SuspendLayout();
            this.groupBoxOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxOption);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxOpen);
            this.splitContainer1.Size = new System.Drawing.Size(984, 661);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxOption
            // 
            this.groupBoxOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOption.Controls.Add(this.checkBoxZ);
            this.groupBoxOption.Controls.Add(this.checkBoxY);
            this.groupBoxOption.Controls.Add(this.checkBoxX);
            this.groupBoxOption.Controls.Add(this.buttonApply);
            this.groupBoxOption.Controls.Add(this.textBoxPrefix);
            this.groupBoxOption.Controls.Add(this.checkBoxSetPrefix);
            this.groupBoxOption.Controls.Add(this.radioButtonPosition);
            this.groupBoxOption.Controls.Add(this.radioButtonID);
            this.groupBoxOption.Location = new System.Drawing.Point(11, 80);
            this.groupBoxOption.Name = "groupBoxOption";
            this.groupBoxOption.Size = new System.Drawing.Size(260, 160);
            this.groupBoxOption.TabIndex = 1;
            this.groupBoxOption.TabStop = false;
            this.groupBoxOption.Text = "Option";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(165, 123);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Location = new System.Drawing.Point(140, 96);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(100, 21);
            this.textBoxPrefix.TabIndex = 3;
            // 
            // checkBoxSetPrefix
            // 
            this.checkBoxSetPrefix.AutoSize = true;
            this.checkBoxSetPrefix.Location = new System.Drawing.Point(19, 101);
            this.checkBoxSetPrefix.Name = "checkBoxSetPrefix";
            this.checkBoxSetPrefix.Size = new System.Drawing.Size(108, 16);
            this.checkBoxSetPrefix.TabIndex = 2;
            this.checkBoxSetPrefix.Text = "Set User Prefix";
            this.checkBoxSetPrefix.UseVisualStyleBackColor = true;
            // 
            // radioButtonPosition
            // 
            this.radioButtonPosition.AutoSize = true;
            this.radioButtonPosition.Location = new System.Drawing.Point(140, 74);
            this.radioButtonPosition.Name = "radioButtonPosition";
            this.radioButtonPosition.Size = new System.Drawing.Size(68, 16);
            this.radioButtonPosition.TabIndex = 1;
            this.radioButtonPosition.Text = "Position";
            this.radioButtonPosition.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Checked = true;
            this.radioButtonID.Location = new System.Drawing.Point(19, 74);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(34, 16);
            this.radioButtonID.TabIndex = 0;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // groupBoxOpen
            // 
            this.groupBoxOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOpen.Controls.Add(this.buttonFrameOpen);
            this.groupBoxOpen.Controls.Add(this.buttonModelOpen);
            this.groupBoxOpen.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOpen.Name = "groupBoxOpen";
            this.groupBoxOpen.Size = new System.Drawing.Size(260, 62);
            this.groupBoxOpen.TabIndex = 0;
            this.groupBoxOpen.TabStop = false;
            this.groupBoxOpen.Text = "Open";
            // 
            // buttonFrameOpen
            // 
            this.buttonFrameOpen.Location = new System.Drawing.Point(139, 28);
            this.buttonFrameOpen.Name = "buttonFrameOpen";
            this.buttonFrameOpen.Size = new System.Drawing.Size(100, 23);
            this.buttonFrameOpen.TabIndex = 1;
            this.buttonFrameOpen.Text = "Frame Open";
            this.buttonFrameOpen.UseVisualStyleBackColor = true;
            this.buttonFrameOpen.Click += new System.EventHandler(this.buttonFrameOpen_Click);
            // 
            // buttonModelOpen
            // 
            this.buttonModelOpen.Location = new System.Drawing.Point(18, 28);
            this.buttonModelOpen.Name = "buttonModelOpen";
            this.buttonModelOpen.Size = new System.Drawing.Size(100, 23);
            this.buttonModelOpen.TabIndex = 0;
            this.buttonModelOpen.Text = "Model Open";
            this.buttonModelOpen.UseVisualStyleBackColor = true;
            this.buttonModelOpen.Click += new System.EventHandler(this.buttonModelOpen_Click);
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Checked = true;
            this.checkBoxX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX.Location = new System.Drawing.Point(20, 37);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(32, 16);
            this.checkBoxX.TabIndex = 5;
            this.checkBoxX.Text = "X";
            this.checkBoxX.UseVisualStyleBackColor = true;
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Checked = true;
            this.checkBoxY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxY.Location = new System.Drawing.Point(80, 37);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(32, 16);
            this.checkBoxY.TabIndex = 6;
            this.checkBoxY.Text = "Y";
            this.checkBoxY.UseVisualStyleBackColor = true;
            // 
            // checkBoxZ
            // 
            this.checkBoxZ.AutoSize = true;
            this.checkBoxZ.Checked = true;
            this.checkBoxZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxZ.Location = new System.Drawing.Point(140, 37);
            this.checkBoxZ.Name = "checkBoxZ";
            this.checkBoxZ.Size = new System.Drawing.Size(32, 16);
            this.checkBoxZ.TabIndex = 7;
            this.checkBoxZ.Text = "Z";
            this.checkBoxZ.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "VIZCore3D.NET.FramePrefix";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxOption.ResumeLayout(false);
            this.groupBoxOption.PerformLayout();
            this.groupBoxOpen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxOpen;
        private System.Windows.Forms.Button buttonFrameOpen;
        private System.Windows.Forms.Button buttonModelOpen;
        private System.Windows.Forms.GroupBox groupBoxOption;
        private System.Windows.Forms.RadioButton radioButtonPosition;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.CheckBox checkBoxSetPrefix;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.CheckBox checkBoxZ;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox checkBoxX;
    }
}

