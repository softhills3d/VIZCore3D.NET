namespace VIZCore3D.NET.ToVIZ
{
    partial class FileExplorerControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.ckREV = new System.Windows.Forms.CheckBox();
            this.ckRVM = new System.Windows.Forms.CheckBox();
            this.ckRVT = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckRVT);
            this.groupBox1.Controls.Add(this.ckRVM);
            this.groupBox1.Controls.Add(this.ckREV);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "경로";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(20, 33);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(332, 21);
            this.txtPath.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(375, 31);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "선택";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // ckREV
            // 
            this.ckREV.AutoSize = true;
            this.ckREV.Location = new System.Drawing.Point(21, 69);
            this.ckREV.Name = "ckREV";
            this.ckREV.Size = new System.Drawing.Size(48, 16);
            this.ckREV.TabIndex = 2;
            this.ckREV.Text = "REV";
            this.ckREV.UseVisualStyleBackColor = true;
            // 
            // ckRVM
            // 
            this.ckRVM.AutoSize = true;
            this.ckRVM.Location = new System.Drawing.Point(109, 69);
            this.ckRVM.Name = "ckRVM";
            this.ckRVM.Size = new System.Drawing.Size(51, 16);
            this.ckRVM.TabIndex = 3;
            this.ckRVM.Text = "RVM";
            this.ckRVM.UseVisualStyleBackColor = true;
            // 
            // ckRVT
            // 
            this.ckRVT.AutoSize = true;
            this.ckRVT.Location = new System.Drawing.Point(198, 69);
            this.ckRVT.Name = "ckRVT";
            this.ckRVT.Size = new System.Drawing.Size(48, 16);
            this.ckRVT.TabIndex = 4;
            this.ckRVT.Text = "RVT";
            this.ckRVT.UseVisualStyleBackColor = true;
            // 
            // FileExplorerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FileExplorerControl";
            this.Size = new System.Drawing.Size(480, 767);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckRVT;
        private System.Windows.Forms.CheckBox ckRVM;
        private System.Windows.Forms.CheckBox ckREV;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtPath;
    }
}
