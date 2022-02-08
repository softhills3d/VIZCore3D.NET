namespace VIZCore3D.NET.Osnap
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
            this.lvOsnap = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowOsnap = new System.Windows.Forms.Button();
            this.Osnap = new System.Windows.Forms.GroupBox();
            this.ckCircle = new System.Windows.Forms.CheckBox();
            this.ckLine = new System.Windows.Forms.CheckBox();
            this.ckVertex = new System.Windows.Forms.CheckBox();
            this.ckSurface = new System.Windows.Forms.CheckBox();
            this.ckAddNote = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Osnap.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Osnap);
            this.splitContainer1.Size = new System.Drawing.Size(1252, 611);
            this.splitContainer1.SplitterDistance = 417;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvOsnap);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 403);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Osnap Data";
            // 
            // lvOsnap
            // 
            this.lvOsnap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOsnap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvOsnap.FullRowSelect = true;
            this.lvOsnap.GridLines = true;
            this.lvOsnap.HideSelection = false;
            this.lvOsnap.Location = new System.Drawing.Point(13, 20);
            this.lvOsnap.Name = "lvOsnap";
            this.lvOsnap.Size = new System.Drawing.Size(365, 377);
            this.lvOsnap.TabIndex = 0;
            this.lvOsnap.UseCompatibleStateImageBehavior = false;
            this.lvOsnap.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kind";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Point";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Start";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "End";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Center";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Normal";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckAddNote);
            this.groupBox1.Controls.Add(this.btnShowOsnap);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnap";
            // 
            // btnShowOsnap
            // 
            this.btnShowOsnap.Location = new System.Drawing.Point(22, 24);
            this.btnShowOsnap.Name = "btnShowOsnap";
            this.btnShowOsnap.Size = new System.Drawing.Size(147, 31);
            this.btnShowOsnap.TabIndex = 0;
            this.btnShowOsnap.Text = "Show";
            this.btnShowOsnap.UseVisualStyleBackColor = true;
            this.btnShowOsnap.Click += new System.EventHandler(this.btnShowOsnap_Click);
            // 
            // Osnap
            // 
            this.Osnap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Osnap.Controls.Add(this.ckCircle);
            this.Osnap.Controls.Add(this.ckLine);
            this.Osnap.Controls.Add(this.ckVertex);
            this.Osnap.Controls.Add(this.ckSurface);
            this.Osnap.Location = new System.Drawing.Point(12, 12);
            this.Osnap.Name = "Osnap";
            this.Osnap.Size = new System.Drawing.Size(389, 100);
            this.Osnap.TabIndex = 0;
            this.Osnap.TabStop = false;
            this.Osnap.Text = "Osnap Kind";
            // 
            // ckCircle
            // 
            this.ckCircle.AutoSize = true;
            this.ckCircle.Checked = true;
            this.ckCircle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCircle.Location = new System.Drawing.Point(270, 42);
            this.ckCircle.Name = "ckCircle";
            this.ckCircle.Size = new System.Drawing.Size(57, 16);
            this.ckCircle.TabIndex = 3;
            this.ckCircle.Text = "Circle";
            this.ckCircle.UseVisualStyleBackColor = true;
            // 
            // ckLine
            // 
            this.ckLine.AutoSize = true;
            this.ckLine.Checked = true;
            this.ckLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckLine.Location = new System.Drawing.Point(199, 42);
            this.ckLine.Name = "ckLine";
            this.ckLine.Size = new System.Drawing.Size(48, 16);
            this.ckLine.TabIndex = 2;
            this.ckLine.Text = "Line";
            this.ckLine.UseVisualStyleBackColor = true;
            // 
            // ckVertex
            // 
            this.ckVertex.AutoSize = true;
            this.ckVertex.Checked = true;
            this.ckVertex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckVertex.Location = new System.Drawing.Point(117, 42);
            this.ckVertex.Name = "ckVertex";
            this.ckVertex.Size = new System.Drawing.Size(52, 16);
            this.ckVertex.TabIndex = 1;
            this.ckVertex.Text = "Point";
            this.ckVertex.UseVisualStyleBackColor = true;
            // 
            // ckSurface
            // 
            this.ckSurface.AutoSize = true;
            this.ckSurface.Checked = true;
            this.ckSurface.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSurface.Location = new System.Drawing.Point(30, 42);
            this.ckSurface.Name = "ckSurface";
            this.ckSurface.Size = new System.Drawing.Size(67, 16);
            this.ckSurface.TabIndex = 0;
            this.ckSurface.Text = "Surface";
            this.ckSurface.UseVisualStyleBackColor = true;
            // 
            // ckAddNote
            // 
            this.ckAddNote.AutoSize = true;
            this.ckAddNote.Location = new System.Drawing.Point(180, 32);
            this.ckAddNote.Name = "ckAddNote";
            this.ckAddNote.Size = new System.Drawing.Size(76, 16);
            this.ckAddNote.TabIndex = 4;
            this.ckAddNote.Text = "Add Note";
            this.ckAddNote.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 611);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Osnap";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Osnap.ResumeLayout(false);
            this.Osnap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Osnap;
        private System.Windows.Forms.CheckBox ckSurface;
        private System.Windows.Forms.CheckBox ckLine;
        private System.Windows.Forms.CheckBox ckVertex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowOsnap;
        private System.Windows.Forms.CheckBox ckCircle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvOsnap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox ckAddNote;
    }
}

