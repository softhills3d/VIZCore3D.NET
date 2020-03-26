namespace VIZCore3D.NET.Projection2D
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSetModelMatrix = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtM33 = new System.Windows.Forms.TextBox();
            this.txtM32 = new System.Windows.Forms.TextBox();
            this.txtM31 = new System.Windows.Forms.TextBox();
            this.txtM30 = new System.Windows.Forms.TextBox();
            this.txtM23 = new System.Windows.Forms.TextBox();
            this.txtM22 = new System.Windows.Forms.TextBox();
            this.txtM21 = new System.Windows.Forms.TextBox();
            this.txtM20 = new System.Windows.Forms.TextBox();
            this.txtM13 = new System.Windows.Forms.TextBox();
            this.txtM12 = new System.Windows.Forms.TextBox();
            this.txtM11 = new System.Windows.Forms.TextBox();
            this.txtM10 = new System.Windows.Forms.TextBox();
            this.txtM03 = new System.Windows.Forms.TextBox();
            this.txtM02 = new System.Windows.Forms.TextBox();
            this.txtM01 = new System.Windows.Forms.TextBox();
            this.txtM00 = new System.Windows.Forms.TextBox();
            this.btnProjection2D = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1296, 846);
            this.splitContainer1.SplitterDistance = 514;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnSetModelMatrix);
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel1.Controls.Add(this.btnProjection2D);
            this.splitContainer2.Size = new System.Drawing.Size(514, 846);
            this.splitContainer2.SplitterDistance = 237;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnSetModelMatrix
            // 
            this.btnSetModelMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetModelMatrix.Location = new System.Drawing.Point(367, 204);
            this.btnSetModelMatrix.Name = "btnSetModelMatrix";
            this.btnSetModelMatrix.Size = new System.Drawing.Size(108, 23);
            this.btnSetModelMatrix.TabIndex = 2;
            this.btnSetModelMatrix.Text = "Set Matrix";
            this.btnSetModelMatrix.UseVisualStyleBackColor = true;
            this.btnSetModelMatrix.Click += new System.EventHandler(this.btnSetModelMatrix_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtM33, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtM32, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtM31, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtM30, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtM23, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtM22, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtM21, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtM20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtM13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtM12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtM11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtM10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtM03, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtM02, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtM01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtM00, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtM33
            // 
            this.txtM33.Location = new System.Drawing.Point(330, 78);
            this.txtM33.Name = "txtM33";
            this.txtM33.Size = new System.Drawing.Size(100, 21);
            this.txtM33.TabIndex = 15;
            this.txtM33.Text = "1";
            // 
            // txtM32
            // 
            this.txtM32.Location = new System.Drawing.Point(221, 78);
            this.txtM32.Name = "txtM32";
            this.txtM32.Size = new System.Drawing.Size(100, 21);
            this.txtM32.TabIndex = 14;
            this.txtM32.Text = "0";
            // 
            // txtM31
            // 
            this.txtM31.Location = new System.Drawing.Point(112, 78);
            this.txtM31.Name = "txtM31";
            this.txtM31.Size = new System.Drawing.Size(100, 21);
            this.txtM31.TabIndex = 13;
            this.txtM31.Text = "0";
            // 
            // txtM30
            // 
            this.txtM30.Location = new System.Drawing.Point(3, 78);
            this.txtM30.Name = "txtM30";
            this.txtM30.Size = new System.Drawing.Size(100, 21);
            this.txtM30.TabIndex = 12;
            this.txtM30.Text = "0";
            // 
            // txtM23
            // 
            this.txtM23.Location = new System.Drawing.Point(330, 53);
            this.txtM23.Name = "txtM23";
            this.txtM23.Size = new System.Drawing.Size(100, 21);
            this.txtM23.TabIndex = 11;
            this.txtM23.Text = "0";
            // 
            // txtM22
            // 
            this.txtM22.Location = new System.Drawing.Point(221, 53);
            this.txtM22.Name = "txtM22";
            this.txtM22.Size = new System.Drawing.Size(100, 21);
            this.txtM22.TabIndex = 10;
            this.txtM22.Text = "1";
            // 
            // txtM21
            // 
            this.txtM21.Location = new System.Drawing.Point(112, 53);
            this.txtM21.Name = "txtM21";
            this.txtM21.Size = new System.Drawing.Size(100, 21);
            this.txtM21.TabIndex = 9;
            this.txtM21.Text = "0";
            // 
            // txtM20
            // 
            this.txtM20.Location = new System.Drawing.Point(3, 53);
            this.txtM20.Name = "txtM20";
            this.txtM20.Size = new System.Drawing.Size(100, 21);
            this.txtM20.TabIndex = 8;
            this.txtM20.Text = "0";
            // 
            // txtM13
            // 
            this.txtM13.Location = new System.Drawing.Point(330, 28);
            this.txtM13.Name = "txtM13";
            this.txtM13.Size = new System.Drawing.Size(100, 21);
            this.txtM13.TabIndex = 7;
            this.txtM13.Text = "0";
            // 
            // txtM12
            // 
            this.txtM12.Location = new System.Drawing.Point(221, 28);
            this.txtM12.Name = "txtM12";
            this.txtM12.Size = new System.Drawing.Size(100, 21);
            this.txtM12.TabIndex = 6;
            this.txtM12.Text = "0";
            // 
            // txtM11
            // 
            this.txtM11.Location = new System.Drawing.Point(112, 28);
            this.txtM11.Name = "txtM11";
            this.txtM11.Size = new System.Drawing.Size(100, 21);
            this.txtM11.TabIndex = 5;
            this.txtM11.Text = "1";
            // 
            // txtM10
            // 
            this.txtM10.Location = new System.Drawing.Point(3, 28);
            this.txtM10.Name = "txtM10";
            this.txtM10.Size = new System.Drawing.Size(100, 21);
            this.txtM10.TabIndex = 4;
            this.txtM10.Text = "0";
            // 
            // txtM03
            // 
            this.txtM03.Location = new System.Drawing.Point(330, 3);
            this.txtM03.Name = "txtM03";
            this.txtM03.Size = new System.Drawing.Size(100, 21);
            this.txtM03.TabIndex = 3;
            this.txtM03.Text = "0";
            // 
            // txtM02
            // 
            this.txtM02.Location = new System.Drawing.Point(221, 3);
            this.txtM02.Name = "txtM02";
            this.txtM02.Size = new System.Drawing.Size(100, 21);
            this.txtM02.TabIndex = 2;
            this.txtM02.Text = "0";
            // 
            // txtM01
            // 
            this.txtM01.Location = new System.Drawing.Point(112, 3);
            this.txtM01.Name = "txtM01";
            this.txtM01.Size = new System.Drawing.Size(100, 21);
            this.txtM01.TabIndex = 1;
            this.txtM01.Text = "0";
            // 
            // txtM00
            // 
            this.txtM00.Location = new System.Drawing.Point(3, 3);
            this.txtM00.Name = "txtM00";
            this.txtM00.Size = new System.Drawing.Size(100, 21);
            this.txtM00.TabIndex = 0;
            this.txtM00.Text = "1";
            // 
            // btnProjection2D
            // 
            this.btnProjection2D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjection2D.Location = new System.Drawing.Point(38, 27);
            this.btnProjection2D.Name = "btnProjection2D";
            this.btnProjection2D.Size = new System.Drawing.Size(437, 41);
            this.btnProjection2D.TabIndex = 0;
            this.btnProjection2D.Text = "Projection 2D";
            this.btnProjection2D.UseVisualStyleBackColor = true;
            this.btnProjection2D.Click += new System.EventHandler(this.btnProjection2D_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 846);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Projection2D";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnProjection2D;
        private System.Windows.Forms.Button btnSetModelMatrix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtM33;
        private System.Windows.Forms.TextBox txtM32;
        private System.Windows.Forms.TextBox txtM31;
        private System.Windows.Forms.TextBox txtM30;
        private System.Windows.Forms.TextBox txtM23;
        private System.Windows.Forms.TextBox txtM22;
        private System.Windows.Forms.TextBox txtM21;
        private System.Windows.Forms.TextBox txtM20;
        private System.Windows.Forms.TextBox txtM13;
        private System.Windows.Forms.TextBox txtM12;
        private System.Windows.Forms.TextBox txtM11;
        private System.Windows.Forms.TextBox txtM10;
        private System.Windows.Forms.TextBox txtM03;
        private System.Windows.Forms.TextBox txtM02;
        private System.Windows.Forms.TextBox txtM01;
        private System.Windows.Forms.TextBox txtM00;
    }
}

