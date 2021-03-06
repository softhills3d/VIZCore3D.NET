﻿namespace VIZCore3D.NET.Projection2D
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtPathGeometry = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtVertex = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panelPath = new System.Windows.Forms.Panel();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.txtNodeBoundBox = new System.Windows.Forms.TextBox();
            this.txtVertexBoundBox = new System.Windows.Forms.TextBox();
            this.txtVertexCount = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorrectionFactorX = new System.Windows.Forms.TextBox();
            this.txtCorrectionFactorY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.txtPathGeometry.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPathGeometry.Size = new System.Drawing.Size(483, 376);
            this.txtPathGeometry.TabIndex = 0;
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
            // txtVertex
            // 
            this.txtVertex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVertex.Location = new System.Drawing.Point(3, 3);
            this.txtVertex.Multiline = true;
            this.txtVertex.Name = "txtVertex";
            this.txtVertex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtVertex.Size = new System.Drawing.Size(483, 376);
            this.txtVertex.TabIndex = 0;
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
            // txtPoints
            // 
            this.txtPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPoints.Location = new System.Drawing.Point(3, 3);
            this.txtPoints.Multiline = true;
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPoints.Size = new System.Drawing.Size(483, 376);
            this.txtPoints.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panelPath);
            this.tabPage5.Controls.Add(this.tbZoom);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(489, 382);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Preview";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panelPath
            // 
            this.panelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPath.AutoScroll = true;
            this.panelPath.Location = new System.Drawing.Point(6, 57);
            this.panelPath.Name = "panelPath";
            this.panelPath.Size = new System.Drawing.Size(477, 319);
            this.panelPath.TabIndex = 1;
            // 
            // tbZoom
            // 
            this.tbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZoom.LargeChange = 10;
            this.tbZoom.Location = new System.Drawing.Point(6, 6);
            this.tbZoom.Maximum = 100;
            this.tbZoom.Minimum = 10;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Size = new System.Drawing.Size(477, 45);
            this.tbZoom.TabIndex = 0;
            this.tbZoom.Value = 100;
            this.tbZoom.Scroll += new System.EventHandler(this.tbZoom_Scroll);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCorrectionFactorY);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtCorrectionFactorX);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtMatrix);
            this.tabPage1.Controls.Add(this.txtNodeBoundBox);
            this.tabPage1.Controls.Add(this.txtVertexBoundBox);
            this.tabPage1.Controls.Add(this.txtVertexCount);
            this.tabPage1.Controls.Add(this.txtArea);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "일반";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMatrix
            // 
            this.txtMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatrix.Location = new System.Drawing.Point(157, 162);
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(313, 21);
            this.txtMatrix.TabIndex = 9;
            // 
            // txtNodeBoundBox
            // 
            this.txtNodeBoundBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeBoundBox.Location = new System.Drawing.Point(157, 126);
            this.txtNodeBoundBox.Name = "txtNodeBoundBox";
            this.txtNodeBoundBox.Size = new System.Drawing.Size(313, 21);
            this.txtNodeBoundBox.TabIndex = 7;
            // 
            // txtVertexBoundBox
            // 
            this.txtVertexBoundBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVertexBoundBox.Location = new System.Drawing.Point(157, 90);
            this.txtVertexBoundBox.Name = "txtVertexBoundBox";
            this.txtVertexBoundBox.Size = new System.Drawing.Size(313, 21);
            this.txtVertexBoundBox.TabIndex = 5;
            // 
            // txtVertexCount
            // 
            this.txtVertexCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVertexCount.Location = new System.Drawing.Point(157, 53);
            this.txtVertexCount.Name = "txtVertexCount";
            this.txtVertexCount.Size = new System.Drawing.Size(313, 21);
            this.txtVertexCount.TabIndex = 3;
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.Location = new System.Drawing.Point(157, 16);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(313, 21);
            this.txtArea.TabIndex = 1;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Node Bound Box";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vertex Count";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correction Factor X";
            // 
            // txtCorrectionFactorX
            // 
            this.txtCorrectionFactorX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorrectionFactorX.Location = new System.Drawing.Point(157, 208);
            this.txtCorrectionFactorX.Name = "txtCorrectionFactorX";
            this.txtCorrectionFactorX.Size = new System.Drawing.Size(313, 21);
            this.txtCorrectionFactorX.TabIndex = 11;
            // 
            // txtCorrectionFactorY
            // 
            this.txtCorrectionFactorY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorrectionFactorY.Location = new System.Drawing.Point(157, 235);
            this.txtCorrectionFactorY.Name = "txtCorrectionFactorY";
            this.txtCorrectionFactorY.Size = new System.Drawing.Size(313, 21);
            this.txtCorrectionFactorY.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Correction Factor Y";
            // 
            // ResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ResultControl";
            this.Size = new System.Drawing.Size(497, 408);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtPathGeometry;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtVertex;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.TextBox txtNodeBoundBox;
        private System.Windows.Forms.TextBox txtVertexBoundBox;
        private System.Windows.Forms.TextBox txtVertexCount;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panelPath;
        private System.Windows.Forms.TrackBar tbZoom;
        private System.Windows.Forms.TextBox txtCorrectionFactorY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorrectionFactorX;
        private System.Windows.Forms.Label label6;
    }
}
