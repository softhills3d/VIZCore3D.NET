namespace VIZCore3D.NET.Projection2D
{
    partial class ResultControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.txtVertex = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtPathGeometry = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtVertexCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVertexBoundBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNodeBoundBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMatrix);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtNodeBoundBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtVertexBoundBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtVertexCount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtArea);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "일반";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPoints);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2D";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtVertex);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(489, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3D";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtPoints
            // 
            this.txtPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPoints.Location = new System.Drawing.Point(3, 3);
            this.txtPoints.Multiline = true;
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPoints.Size = new System.Drawing.Size(483, 376);
            this.txtPoints.TabIndex = 0;
            // 
            // txtVertex
            // 
            this.txtVertex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVertex.Location = new System.Drawing.Point(3, 3);
            this.txtVertex.Multiline = true;
            this.txtVertex.Name = "txtVertex";
            this.txtVertex.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtVertex.Size = new System.Drawing.Size(483, 376);
            this.txtVertex.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtPathGeometry);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(489, 382);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PathGeometry";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtPathGeometry
            // 
            this.txtPathGeometry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPathGeometry.Location = new System.Drawing.Point(3, 3);
            this.txtPathGeometry.Multiline = true;
            this.txtPathGeometry.Name = "txtPathGeometry";
            this.txtPathGeometry.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPathGeometry.Size = new System.Drawing.Size(483, 376);
            this.txtPathGeometry.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(489, 382);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Preview";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.Location = new System.Drawing.Point(137, 16);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(333, 21);
            this.txtArea.TabIndex = 1;
            // 
            // txtVertexCount
            // 
            this.txtVertexCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVertexCount.Location = new System.Drawing.Point(137, 53);
            this.txtVertexCount.Name = "txtVertexCount";
            this.txtVertexCount.Size = new System.Drawing.Size(333, 21);
            this.txtVertexCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vertex Count";
            // 
            // txtVertexBoundBox
            // 
            this.txtVertexBoundBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVertexBoundBox.Location = new System.Drawing.Point(137, 90);
            this.txtVertexBoundBox.Name = "txtVertexBoundBox";
            this.txtVertexBoundBox.Size = new System.Drawing.Size(333, 21);
            this.txtVertexBoundBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vertex Bound Box";
            // 
            // txtNodeBoundBox
            // 
            this.txtNodeBoundBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeBoundBox.Location = new System.Drawing.Point(137, 126);
            this.txtNodeBoundBox.Name = "txtNodeBoundBox";
            this.txtNodeBoundBox.Size = new System.Drawing.Size(333, 21);
            this.txtNodeBoundBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Node Bound Box";
            // 
            // txtMatrix
            // 
            this.txtMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatrix.Location = new System.Drawing.Point(137, 162);
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(333, 21);
            this.txtMatrix.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matrix";
            // 
            // ResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ResultControl";
            this.Size = new System.Drawing.Size(497, 408);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtVertex;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtPathGeometry;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNodeBoundBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVertexBoundBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVertexCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Label label5;
    }
}
