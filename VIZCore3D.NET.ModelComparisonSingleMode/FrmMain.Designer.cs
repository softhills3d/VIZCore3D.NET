namespace VIZCore3D.NET.ModelComparisonSingleMode
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTargetColor = new System.Windows.Forms.Button();
            this.btnSourceColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.ckOriginalSource = new System.Windows.Forms.CheckBox();
            this.ckOriginalTarget = new System.Windows.Forms.CheckBox();
            this.ckSolidTransparency = new System.Windows.Forms.CheckBox();
            this.ckWireTransparency = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSOLID_OVERLAY = new System.Windows.Forms.Button();
            this.btnSOLID_OVERLAY_INVERSE = new System.Windows.Forms.Button();
            this.btnSOLID_FOCUS_DELETE = new System.Windows.Forms.Button();
            this.btnSOLID_FOCUS_NEW = new System.Windows.Forms.Button();
            this.btnSOURCE_SOLID_COMPARE_WIRE = new System.Windows.Forms.Button();
            this.btnSOURCE_WIRE_COMPARE_SOLID = new System.Windows.Forms.Button();
            this.btnSOURCE_WIRE_COMPARE_WIRE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1295, 773);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ckWireTransparency);
            this.groupBox2.Controls.Add(this.ckSolidTransparency);
            this.groupBox2.Controls.Add(this.ckOriginalTarget);
            this.groupBox2.Controls.Add(this.ckOriginalSource);
            this.groupBox2.Controls.Add(this.btnTargetColor);
            this.groupBox2.Controls.Add(this.btnSourceColor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // btnTargetColor
            // 
            this.btnTargetColor.Location = new System.Drawing.Point(107, 62);
            this.btnTargetColor.Name = "btnTargetColor";
            this.btnTargetColor.Size = new System.Drawing.Size(75, 23);
            this.btnTargetColor.TabIndex = 3;
            this.btnTargetColor.Text = "Color";
            this.btnTargetColor.UseVisualStyleBackColor = true;
            this.btnTargetColor.Click += new System.EventHandler(this.btnTargetColor_Click);
            // 
            // btnSourceColor
            // 
            this.btnSourceColor.Location = new System.Drawing.Point(107, 30);
            this.btnSourceColor.Name = "btnSourceColor";
            this.btnSourceColor.Size = new System.Drawing.Size(75, 23);
            this.btnSourceColor.TabIndex = 2;
            this.btnSourceColor.Text = "Color";
            this.btnSourceColor.UseVisualStyleBackColor = true;
            this.btnSourceColor.Click += new System.EventHandler(this.btnSourceColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODEL (.VIZ)";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(252, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(6, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(240, 21);
            this.txtPath.TabIndex = 0;
            // 
            // ckOriginalSource
            // 
            this.ckOriginalSource.AutoSize = true;
            this.ckOriginalSource.Location = new System.Drawing.Point(207, 34);
            this.ckOriginalSource.Name = "ckOriginalSource";
            this.ckOriginalSource.Size = new System.Drawing.Size(101, 16);
            this.ckOriginalSource.TabIndex = 4;
            this.ckOriginalSource.Text = "Original Color";
            this.ckOriginalSource.UseVisualStyleBackColor = true;
            this.ckOriginalSource.CheckedChanged += new System.EventHandler(this.ckOriginalSource_CheckedChanged);
            // 
            // ckOriginalTarget
            // 
            this.ckOriginalTarget.AutoSize = true;
            this.ckOriginalTarget.Location = new System.Drawing.Point(207, 66);
            this.ckOriginalTarget.Name = "ckOriginalTarget";
            this.ckOriginalTarget.Size = new System.Drawing.Size(101, 16);
            this.ckOriginalTarget.TabIndex = 5;
            this.ckOriginalTarget.Text = "Original Color";
            this.ckOriginalTarget.UseVisualStyleBackColor = true;
            this.ckOriginalTarget.CheckedChanged += new System.EventHandler(this.ckOriginalTarget_CheckedChanged);
            // 
            // ckSolidTransparency
            // 
            this.ckSolidTransparency.AutoSize = true;
            this.ckSolidTransparency.Location = new System.Drawing.Point(42, 106);
            this.ckSolidTransparency.Name = "ckSolidTransparency";
            this.ckSolidTransparency.Size = new System.Drawing.Size(135, 16);
            this.ckSolidTransparency.TabIndex = 6;
            this.ckSolidTransparency.Text = "Solid Transparency";
            this.ckSolidTransparency.UseVisualStyleBackColor = true;
            // 
            // ckWireTransparency
            // 
            this.ckWireTransparency.AutoSize = true;
            this.ckWireTransparency.Location = new System.Drawing.Point(42, 128);
            this.ckWireTransparency.Name = "ckWireTransparency";
            this.ckWireTransparency.Size = new System.Drawing.Size(131, 16);
            this.ckWireTransparency.TabIndex = 7;
            this.ckWireTransparency.Text = "Wire Transparency";
            this.ckWireTransparency.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnSOURCE_WIRE_COMPARE_WIRE);
            this.groupBox3.Controls.Add(this.btnSOURCE_WIRE_COMPARE_SOLID);
            this.groupBox3.Controls.Add(this.btnSOURCE_SOLID_COMPARE_WIRE);
            this.groupBox3.Controls.Add(this.btnSOLID_FOCUS_NEW);
            this.groupBox3.Controls.Add(this.btnSOLID_FOCUS_DELETE);
            this.groupBox3.Controls.Add(this.btnSOLID_OVERLAY_INVERSE);
            this.groupBox3.Controls.Add(this.btnSOLID_OVERLAY);
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 312);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Solid";
            // 
            // btnSOLID_OVERLAY
            // 
            this.btnSOLID_OVERLAY.Location = new System.Drawing.Point(42, 45);
            this.btnSOLID_OVERLAY.Name = "btnSOLID_OVERLAY";
            this.btnSOLID_OVERLAY.Size = new System.Drawing.Size(242, 23);
            this.btnSOLID_OVERLAY.TabIndex = 0;
            this.btnSOLID_OVERLAY.Text = "SOLID_OVERLAY";
            this.btnSOLID_OVERLAY.UseVisualStyleBackColor = true;
            this.btnSOLID_OVERLAY.Click += new System.EventHandler(this.btnSOLID_OVERLAY_Click);
            // 
            // btnSOLID_OVERLAY_INVERSE
            // 
            this.btnSOLID_OVERLAY_INVERSE.Location = new System.Drawing.Point(42, 74);
            this.btnSOLID_OVERLAY_INVERSE.Name = "btnSOLID_OVERLAY_INVERSE";
            this.btnSOLID_OVERLAY_INVERSE.Size = new System.Drawing.Size(242, 23);
            this.btnSOLID_OVERLAY_INVERSE.TabIndex = 1;
            this.btnSOLID_OVERLAY_INVERSE.Text = "SOLID_OVERLAY_INVERSE";
            this.btnSOLID_OVERLAY_INVERSE.UseVisualStyleBackColor = true;
            this.btnSOLID_OVERLAY_INVERSE.Click += new System.EventHandler(this.btnSOLID_OVERLAY_INVERSE_Click);
            // 
            // btnSOLID_FOCUS_DELETE
            // 
            this.btnSOLID_FOCUS_DELETE.Location = new System.Drawing.Point(42, 103);
            this.btnSOLID_FOCUS_DELETE.Name = "btnSOLID_FOCUS_DELETE";
            this.btnSOLID_FOCUS_DELETE.Size = new System.Drawing.Size(242, 23);
            this.btnSOLID_FOCUS_DELETE.TabIndex = 2;
            this.btnSOLID_FOCUS_DELETE.Text = "SOLID_FOCUS_DELETE";
            this.btnSOLID_FOCUS_DELETE.UseVisualStyleBackColor = true;
            this.btnSOLID_FOCUS_DELETE.Click += new System.EventHandler(this.btnSOLID_FOCUS_DELETE_Click);
            // 
            // btnSOLID_FOCUS_NEW
            // 
            this.btnSOLID_FOCUS_NEW.Location = new System.Drawing.Point(42, 132);
            this.btnSOLID_FOCUS_NEW.Name = "btnSOLID_FOCUS_NEW";
            this.btnSOLID_FOCUS_NEW.Size = new System.Drawing.Size(242, 23);
            this.btnSOLID_FOCUS_NEW.TabIndex = 3;
            this.btnSOLID_FOCUS_NEW.Text = "SOLID_FOCUS_NEW";
            this.btnSOLID_FOCUS_NEW.UseVisualStyleBackColor = true;
            this.btnSOLID_FOCUS_NEW.Click += new System.EventHandler(this.btnSOLID_FOCUS_NEW_Click);
            // 
            // btnSOURCE_SOLID_COMPARE_WIRE
            // 
            this.btnSOURCE_SOLID_COMPARE_WIRE.Location = new System.Drawing.Point(42, 196);
            this.btnSOURCE_SOLID_COMPARE_WIRE.Name = "btnSOURCE_SOLID_COMPARE_WIRE";
            this.btnSOURCE_SOLID_COMPARE_WIRE.Size = new System.Drawing.Size(242, 23);
            this.btnSOURCE_SOLID_COMPARE_WIRE.TabIndex = 4;
            this.btnSOURCE_SOLID_COMPARE_WIRE.Text = "SOURCE_SOLID_COMPARE_WIRE";
            this.btnSOURCE_SOLID_COMPARE_WIRE.UseVisualStyleBackColor = true;
            this.btnSOURCE_SOLID_COMPARE_WIRE.Click += new System.EventHandler(this.btnSOURCE_SOLID_COMPARE_WIRE_Click);
            // 
            // btnSOURCE_WIRE_COMPARE_SOLID
            // 
            this.btnSOURCE_WIRE_COMPARE_SOLID.Location = new System.Drawing.Point(42, 225);
            this.btnSOURCE_WIRE_COMPARE_SOLID.Name = "btnSOURCE_WIRE_COMPARE_SOLID";
            this.btnSOURCE_WIRE_COMPARE_SOLID.Size = new System.Drawing.Size(242, 23);
            this.btnSOURCE_WIRE_COMPARE_SOLID.TabIndex = 5;
            this.btnSOURCE_WIRE_COMPARE_SOLID.Text = "SOURCE_WIRE_COMPARE_SOLID";
            this.btnSOURCE_WIRE_COMPARE_SOLID.UseVisualStyleBackColor = true;
            this.btnSOURCE_WIRE_COMPARE_SOLID.Click += new System.EventHandler(this.btnSOURCE_WIRE_COMPARE_SOLID_Click);
            // 
            // btnSOURCE_WIRE_COMPARE_WIRE
            // 
            this.btnSOURCE_WIRE_COMPARE_WIRE.Location = new System.Drawing.Point(42, 254);
            this.btnSOURCE_WIRE_COMPARE_WIRE.Name = "btnSOURCE_WIRE_COMPARE_WIRE";
            this.btnSOURCE_WIRE_COMPARE_WIRE.Size = new System.Drawing.Size(242, 23);
            this.btnSOURCE_WIRE_COMPARE_WIRE.TabIndex = 6;
            this.btnSOURCE_WIRE_COMPARE_WIRE.Text = "SOURCE_WIRE_COMPARE_WIRE";
            this.btnSOURCE_WIRE_COMPARE_WIRE.UseVisualStyleBackColor = true;
            this.btnSOURCE_WIRE_COMPARE_WIRE.Click += new System.EventHandler(this.btnSOURCE_WIRE_COMPARE_WIRE_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 773);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.ModelComparisonSingleMode";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTargetColor;
        private System.Windows.Forms.Button btnSourceColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckOriginalTarget;
        private System.Windows.Forms.CheckBox ckOriginalSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckWireTransparency;
        private System.Windows.Forms.CheckBox ckSolidTransparency;
        private System.Windows.Forms.Button btnSOLID_OVERLAY;
        private System.Windows.Forms.Button btnSOLID_OVERLAY_INVERSE;
        private System.Windows.Forms.Button btnSOLID_FOCUS_DELETE;
        private System.Windows.Forms.Button btnSOLID_FOCUS_NEW;
        private System.Windows.Forms.Button btnSOURCE_SOLID_COMPARE_WIRE;
        private System.Windows.Forms.Button btnSOURCE_WIRE_COMPARE_SOLID;
        private System.Windows.Forms.Button btnSOURCE_WIRE_COMPARE_WIRE;
    }
}

