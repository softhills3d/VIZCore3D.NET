namespace VIZCore3D.NET.Disassembly
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
            this.btnRestoreSelectedObject = new System.Windows.Forms.Button();
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSphere = new System.Windows.Forms.Button();
            this.btnLinear = new System.Windows.Forms.Button();
            this.btnAxis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAxis = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckAnimation = new System.Windows.Forms.CheckBox();
            this.ckSelectedObject = new System.Windows.Forms.CheckBox();
            this.txtSideGap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisassemble = new System.Windows.Forms.Button();
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1334, 689);
            this.splitContainer1.SplitterDistance = 444;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnRestoreSelectedObject);
            this.groupBox3.Controls.Add(this.btnRestoreAll);
            this.groupBox3.Location = new System.Drawing.Point(12, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Restore";
            // 
            // btnRestoreSelectedObject
            // 
            this.btnRestoreSelectedObject.Location = new System.Drawing.Point(147, 32);
            this.btnRestoreSelectedObject.Name = "btnRestoreSelectedObject";
            this.btnRestoreSelectedObject.Size = new System.Drawing.Size(75, 23);
            this.btnRestoreSelectedObject.TabIndex = 4;
            this.btnRestoreSelectedObject.Text = "Selected Object";
            this.btnRestoreSelectedObject.UseVisualStyleBackColor = true;
            this.btnRestoreSelectedObject.Click += new System.EventHandler(this.btnRestoreSelectedObject_Click);
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.Location = new System.Drawing.Point(54, 32);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(75, 23);
            this.btnRestoreAll.TabIndex = 3;
            this.btnRestoreAll.Text = "All";
            this.btnRestoreAll.UseVisualStyleBackColor = true;
            this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDisassemble);
            this.groupBox2.Controls.Add(this.btnSphere);
            this.groupBox2.Controls.Add(this.btnLinear);
            this.groupBox2.Controls.Add(this.btnAxis);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbAxis);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disassembly";
            // 
            // btnSphere
            // 
            this.btnSphere.Location = new System.Drawing.Point(252, 79);
            this.btnSphere.Name = "btnSphere";
            this.btnSphere.Size = new System.Drawing.Size(75, 23);
            this.btnSphere.TabIndex = 4;
            this.btnSphere.Text = "Sphere";
            this.btnSphere.UseVisualStyleBackColor = true;
            this.btnSphere.Click += new System.EventHandler(this.btnSphere_Click);
            // 
            // btnLinear
            // 
            this.btnLinear.Location = new System.Drawing.Point(147, 79);
            this.btnLinear.Name = "btnLinear";
            this.btnLinear.Size = new System.Drawing.Size(75, 23);
            this.btnLinear.TabIndex = 3;
            this.btnLinear.Text = "Linear";
            this.btnLinear.UseVisualStyleBackColor = true;
            this.btnLinear.Click += new System.EventHandler(this.btnLinear_Click);
            // 
            // btnAxis
            // 
            this.btnAxis.Location = new System.Drawing.Point(49, 79);
            this.btnAxis.Name = "btnAxis";
            this.btnAxis.Size = new System.Drawing.Size(75, 23);
            this.btnAxis.TabIndex = 2;
            this.btnAxis.Text = "Axis";
            this.btnAxis.UseVisualStyleBackColor = true;
            this.btnAxis.Click += new System.EventHandler(this.btnAxis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Axis";
            // 
            // cbAxis
            // 
            this.cbAxis.FormattingEnabled = true;
            this.cbAxis.Items.AddRange(new object[] {
            "X+",
            "X-",
            "Y+",
            "Y-",
            "Z+",
            "Z-",
            "XYZ"});
            this.cbAxis.Location = new System.Drawing.Point(92, 32);
            this.cbAxis.Name = "cbAxis";
            this.cbAxis.Size = new System.Drawing.Size(121, 20);
            this.cbAxis.TabIndex = 0;
            this.cbAxis.Text = "XYZ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckAnimation);
            this.groupBox1.Controls.Add(this.ckSelectedObject);
            this.groupBox1.Controls.Add(this.txtSideGap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDistance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property";
            // 
            // ckAnimation
            // 
            this.ckAnimation.AutoSize = true;
            this.ckAnimation.Checked = true;
            this.ckAnimation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAnimation.Location = new System.Drawing.Point(49, 25);
            this.ckAnimation.Name = "ckAnimation";
            this.ckAnimation.Size = new System.Drawing.Size(80, 16);
            this.ckAnimation.TabIndex = 5;
            this.ckAnimation.Text = "Animation";
            this.ckAnimation.UseVisualStyleBackColor = true;
            // 
            // ckSelectedObject
            // 
            this.ckSelectedObject.AutoSize = true;
            this.ckSelectedObject.Location = new System.Drawing.Point(49, 137);
            this.ckSelectedObject.Name = "ckSelectedObject";
            this.ckSelectedObject.Size = new System.Drawing.Size(113, 16);
            this.ckSelectedObject.TabIndex = 4;
            this.ckSelectedObject.Text = "Selected Object";
            this.ckSelectedObject.UseVisualStyleBackColor = true;
            // 
            // txtSideGap
            // 
            this.txtSideGap.Location = new System.Drawing.Point(122, 95);
            this.txtSideGap.Name = "txtSideGap";
            this.txtSideGap.Size = new System.Drawing.Size(100, 21);
            this.txtSideGap.TabIndex = 3;
            this.txtSideGap.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Side Gap";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(122, 57);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 21);
            this.txtDistance.TabIndex = 1;
            this.txtDistance.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance";
            // 
            // btnDisassemble
            // 
            this.btnDisassemble.Location = new System.Drawing.Point(224, 32);
            this.btnDisassemble.Name = "btnDisassemble";
            this.btnDisassemble.Size = new System.Drawing.Size(103, 23);
            this.btnDisassemble.TabIndex = 5;
            this.btnDisassemble.Text = "Disassemble";
            this.btnDisassemble.UseVisualStyleBackColor = true;
            this.btnDisassemble.Click += new System.EventHandler(this.btnDisassemble_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 689);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Disassembly";
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
        private System.Windows.Forms.TextBox txtSideGap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSphere;
        private System.Windows.Forms.Button btnLinear;
        private System.Windows.Forms.Button btnAxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAxis;
        private System.Windows.Forms.CheckBox ckSelectedObject;
        private System.Windows.Forms.CheckBox ckAnimation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRestoreSelectedObject;
        private System.Windows.Forms.Button btnRestoreAll;
        private System.Windows.Forms.Button btnDisassemble;
    }
}

