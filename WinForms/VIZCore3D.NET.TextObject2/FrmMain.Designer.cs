namespace VIZCore3D.NET.TextObject2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnMovePlusTextUp = new System.Windows.Forms.Button();
            this.btnMoveMinusTextUp = new System.Windows.Forms.Button();
            this.btnMoveMinusTextDir = new System.Windows.Forms.Button();
            this.btnMovePlusTextDir = new System.Windows.Forms.Button();
            this.btnMovePlusNormal = new System.Windows.Forms.Button();
            this.btnMoveMinusNormal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddTextObjectNote = new System.Windows.Forms.Button();
            this.btnRotateClockWise = new System.Windows.Forms.Button();
            this.btnRotateCounterClockWise = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddTextObjectNote);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 671);
            this.splitContainer1.SplitterDistance = 368;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnMovePlusTextUp
            // 
            this.btnMovePlusTextUp.Location = new System.Drawing.Point(8, 210);
            this.btnMovePlusTextUp.Name = "btnMovePlusTextUp";
            this.btnMovePlusTextUp.Size = new System.Drawing.Size(328, 29);
            this.btnMovePlusTextUp.TabIndex = 11;
            this.btnMovePlusTextUp.Text = "TextUp 방향으로 이동";
            this.btnMovePlusTextUp.UseVisualStyleBackColor = true;
            this.btnMovePlusTextUp.Click += new System.EventHandler(this.btnMovePlusTextUp_Click);
            // 
            // btnMoveMinusTextUp
            // 
            this.btnMoveMinusTextUp.Location = new System.Drawing.Point(8, 177);
            this.btnMoveMinusTextUp.Name = "btnMoveMinusTextUp";
            this.btnMoveMinusTextUp.Size = new System.Drawing.Size(328, 29);
            this.btnMoveMinusTextUp.TabIndex = 10;
            this.btnMoveMinusTextUp.Text = "TextUp 의 반대 방향으로 이동";
            this.btnMoveMinusTextUp.UseVisualStyleBackColor = true;
            this.btnMoveMinusTextUp.Click += new System.EventHandler(this.btnMoveMinusTextUp_Click);
            // 
            // btnMoveMinusTextDir
            // 
            this.btnMoveMinusTextDir.Location = new System.Drawing.Point(7, 98);
            this.btnMoveMinusTextDir.Name = "btnMoveMinusTextDir";
            this.btnMoveMinusTextDir.Size = new System.Drawing.Size(328, 29);
            this.btnMoveMinusTextDir.TabIndex = 9;
            this.btnMoveMinusTextDir.Text = "TextDir 의 반대 방향으로 이동";
            this.btnMoveMinusTextDir.UseVisualStyleBackColor = true;
            this.btnMoveMinusTextDir.Click += new System.EventHandler(this.btnMoveMinusTextDir_Click);
            // 
            // btnMovePlusTextDir
            // 
            this.btnMovePlusTextDir.Location = new System.Drawing.Point(7, 133);
            this.btnMovePlusTextDir.Name = "btnMovePlusTextDir";
            this.btnMovePlusTextDir.Size = new System.Drawing.Size(328, 29);
            this.btnMovePlusTextDir.TabIndex = 8;
            this.btnMovePlusTextDir.Text = "TextDir 방향으로 이동";
            this.btnMovePlusTextDir.UseVisualStyleBackColor = true;
            this.btnMovePlusTextDir.Click += new System.EventHandler(this.btnMovePlusTextDir_Click);
            // 
            // btnMovePlusNormal
            // 
            this.btnMovePlusNormal.Location = new System.Drawing.Point(6, 55);
            this.btnMovePlusNormal.Name = "btnMovePlusNormal";
            this.btnMovePlusNormal.Size = new System.Drawing.Size(328, 29);
            this.btnMovePlusNormal.TabIndex = 7;
            this.btnMovePlusNormal.Text = "Normal 방향으로 이동";
            this.btnMovePlusNormal.UseVisualStyleBackColor = true;
            this.btnMovePlusNormal.Click += new System.EventHandler(this.btnMovePlusNormal_Click);
            // 
            // btnMoveMinusNormal
            // 
            this.btnMoveMinusNormal.Location = new System.Drawing.Point(6, 20);
            this.btnMoveMinusNormal.Name = "btnMoveMinusNormal";
            this.btnMoveMinusNormal.Size = new System.Drawing.Size(328, 29);
            this.btnMoveMinusNormal.TabIndex = 6;
            this.btnMoveMinusNormal.Text = "Normal 의 반대 방향으로 이동";
            this.btnMoveMinusNormal.UseVisualStyleBackColor = true;
            this.btnMoveMinusNormal.Click += new System.EventHandler(this.btnMoveMinusNormal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "4. 아래 버튼들로 TextObject 노트를 조작해보세요.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "3. 우측 3D뷰에서 TextObject 노트를 클릭해주세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. 아래 버튼으로 TextObject 노트를 추가해주세요.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. 모델을 열어주세요.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 126);
            this.textBox1.TabIndex = 1;
            // 
            // btnAddTextObjectNote
            // 
            this.btnAddTextObjectNote.Location = new System.Drawing.Point(12, 69);
            this.btnAddTextObjectNote.Name = "btnAddTextObjectNote";
            this.btnAddTextObjectNote.Size = new System.Drawing.Size(344, 25);
            this.btnAddTextObjectNote.TabIndex = 0;
            this.btnAddTextObjectNote.Text = "TextObject 노트 추가";
            this.btnAddTextObjectNote.UseVisualStyleBackColor = true;
            this.btnAddTextObjectNote.Click += new System.EventHandler(this.btnAddTextObjectNote_Click);
            // 
            // btnRotateClockWise
            // 
            this.btnRotateClockWise.Location = new System.Drawing.Point(7, 20);
            this.btnRotateClockWise.Name = "btnRotateClockWise";
            this.btnRotateClockWise.Size = new System.Drawing.Size(327, 23);
            this.btnRotateClockWise.TabIndex = 12;
            this.btnRotateClockWise.Text = "시계 방향으로 회전";
            this.btnRotateClockWise.UseVisualStyleBackColor = true;
            this.btnRotateClockWise.Click += new System.EventHandler(this.btnRotateClockWise_Click);
            // 
            // btnRotateCounterClockWise
            // 
            this.btnRotateCounterClockWise.Location = new System.Drawing.Point(6, 49);
            this.btnRotateCounterClockWise.Name = "btnRotateCounterClockWise";
            this.btnRotateCounterClockWise.Size = new System.Drawing.Size(327, 23);
            this.btnRotateCounterClockWise.TabIndex = 13;
            this.btnRotateCounterClockWise.Text = "반시계 방향으로 회전";
            this.btnRotateCounterClockWise.UseVisualStyleBackColor = true;
            this.btnRotateCounterClockWise.Click += new System.EventHandler(this.btnRotateCounterClockWise_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMoveMinusNormal);
            this.groupBox1.Controls.Add(this.btnMovePlusNormal);
            this.groupBox1.Controls.Add(this.btnMoveMinusTextDir);
            this.groupBox1.Controls.Add(this.btnMovePlusTextUp);
            this.groupBox1.Controls.Add(this.btnMovePlusTextDir);
            this.groupBox1.Controls.Add(this.btnMoveMinusTextUp);
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 249);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이동";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRotateClockWise);
            this.groupBox2.Controls.Add(this.btnRotateCounterClockWise);
            this.groupBox2.Location = new System.Drawing.Point(12, 569);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 84);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회전";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 671);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAddTextObjectNote;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMovePlusTextUp;
        private System.Windows.Forms.Button btnMoveMinusTextUp;
        private System.Windows.Forms.Button btnMoveMinusTextDir;
        private System.Windows.Forms.Button btnMovePlusTextDir;
        private System.Windows.Forms.Button btnMovePlusNormal;
        private System.Windows.Forms.Button btnMoveMinusNormal;
        private System.Windows.Forms.Button btnRotateClockWise;
        private System.Windows.Forms.Button btnRotateCounterClockWise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

