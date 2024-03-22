namespace VIZCore3D.NET.NoteTransform
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
            this.groupBoxRotation = new System.Windows.Forms.GroupBox();
            this.btnRotate = new System.Windows.Forms.Button();
            this.txtAngleZ = new System.Windows.Forms.TextBox();
            this.txtAngleY = new System.Windows.Forms.TextBox();
            this.txtAngleX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetSelectedNodes = new System.Windows.Forms.Button();
            this.lvNodes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearNote = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.groupBoxTranslation = new System.Windows.Forms.GroupBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.txtDistanceZ = new System.Windows.Forms.TextBox();
            this.txtDistanceY = new System.Windows.Forms.TextBox();
            this.txtDistanceX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxRotation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxTranslation.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxTranslation);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxRotation);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 582);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxRotation
            // 
            this.groupBoxRotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRotation.Controls.Add(this.btnRotate);
            this.groupBoxRotation.Controls.Add(this.txtAngleZ);
            this.groupBoxRotation.Controls.Add(this.txtAngleY);
            this.groupBoxRotation.Controls.Add(this.txtAngleX);
            this.groupBoxRotation.Location = new System.Drawing.Point(12, 264);
            this.groupBoxRotation.Name = "groupBoxRotation";
            this.groupBoxRotation.Size = new System.Drawing.Size(342, 77);
            this.groupBoxRotation.TabIndex = 2;
            this.groupBoxRotation.TabStop = false;
            this.groupBoxRotation.Text = "Rotation";
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(253, 34);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 3;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // txtAngleZ
            // 
            this.txtAngleZ.Location = new System.Drawing.Point(172, 34);
            this.txtAngleZ.Name = "txtAngleZ";
            this.txtAngleZ.Size = new System.Drawing.Size(75, 21);
            this.txtAngleZ.TabIndex = 2;
            // 
            // txtAngleY
            // 
            this.txtAngleY.Location = new System.Drawing.Point(91, 34);
            this.txtAngleY.Name = "txtAngleY";
            this.txtAngleY.Size = new System.Drawing.Size(75, 21);
            this.txtAngleY.TabIndex = 1;
            // 
            // txtAngleX
            // 
            this.txtAngleX.Location = new System.Drawing.Point(10, 34);
            this.txtAngleX.Name = "txtAngleX";
            this.txtAngleX.Size = new System.Drawing.Size(75, 21);
            this.txtAngleX.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnGetSelectedNodes);
            this.groupBox2.Controls.Add(this.lvNodes);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nodes";
            // 
            // btnGetSelectedNodes
            // 
            this.btnGetSelectedNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetSelectedNodes.Location = new System.Drawing.Point(261, 20);
            this.btnGetSelectedNodes.Name = "btnGetSelectedNodes";
            this.btnGetSelectedNodes.Size = new System.Drawing.Size(75, 23);
            this.btnGetSelectedNodes.TabIndex = 2;
            this.btnGetSelectedNodes.Text = "Get";
            this.btnGetSelectedNodes.UseVisualStyleBackColor = true;
            this.btnGetSelectedNodes.Click += new System.EventHandler(this.btnGetSelectedNodes_Click);
            // 
            // lvNodes
            // 
            this.lvNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvNodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvNodes.FullRowSelect = true;
            this.lvNodes.GridLines = true;
            this.lvNodes.HideSelection = false;
            this.lvNodes.Location = new System.Drawing.Point(6, 48);
            this.lvNodes.Name = "lvNodes";
            this.lvNodes.Size = new System.Drawing.Size(330, 117);
            this.lvNodes.TabIndex = 0;
            this.lvNodes.UseCompatibleStateImageBehavior = false;
            this.lvNodes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClearNote);
            this.groupBox1.Controls.Add(this.btnAddNote);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Note";
            // 
            // btnClearNote
            // 
            this.btnClearNote.Location = new System.Drawing.Point(120, 26);
            this.btnClearNote.Name = "btnClearNote";
            this.btnClearNote.Size = new System.Drawing.Size(75, 23);
            this.btnClearNote.TabIndex = 1;
            this.btnClearNote.Text = "Clear";
            this.btnClearNote.UseVisualStyleBackColor = true;
            this.btnClearNote.Click += new System.EventHandler(this.btnClearNote_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(29, 26);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 0;
            this.btnAddNote.Text = "Add";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // groupBoxTranslation
            // 
            this.groupBoxTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTranslation.Controls.Add(this.btnTranslate);
            this.groupBoxTranslation.Controls.Add(this.txtDistanceZ);
            this.groupBoxTranslation.Controls.Add(this.txtDistanceY);
            this.groupBoxTranslation.Controls.Add(this.txtDistanceX);
            this.groupBoxTranslation.Location = new System.Drawing.Point(12, 347);
            this.groupBoxTranslation.Name = "groupBoxTranslation";
            this.groupBoxTranslation.Size = new System.Drawing.Size(342, 77);
            this.groupBoxTranslation.TabIndex = 3;
            this.groupBoxTranslation.TabStop = false;
            this.groupBoxTranslation.Text = "Translation";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(253, 34);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // txtDistanceZ
            // 
            this.txtDistanceZ.Location = new System.Drawing.Point(172, 34);
            this.txtDistanceZ.Name = "txtDistanceZ";
            this.txtDistanceZ.Size = new System.Drawing.Size(75, 21);
            this.txtDistanceZ.TabIndex = 2;
            // 
            // txtDistanceY
            // 
            this.txtDistanceY.Location = new System.Drawing.Point(91, 34);
            this.txtDistanceY.Name = "txtDistanceY";
            this.txtDistanceY.Size = new System.Drawing.Size(75, 21);
            this.txtDistanceY.TabIndex = 1;
            // 
            // txtDistanceX
            // 
            this.txtDistanceX.Location = new System.Drawing.Point(10, 34);
            this.txtDistanceX.Name = "txtDistanceX";
            this.txtDistanceX.Size = new System.Drawing.Size(75, 21);
            this.txtDistanceX.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 582);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transform Note";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxRotation.ResumeLayout(false);
            this.groupBoxRotation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxTranslation.ResumeLayout(false);
            this.groupBoxTranslation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.ListView lvNodes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBoxRotation;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.TextBox txtAngleZ;
        private System.Windows.Forms.TextBox txtAngleY;
        private System.Windows.Forms.TextBox txtAngleX;
        private System.Windows.Forms.Button btnGetSelectedNodes;
        private System.Windows.Forms.GroupBox groupBoxTranslation;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox txtDistanceZ;
        private System.Windows.Forms.TextBox txtDistanceY;
        private System.Windows.Forms.TextBox txtDistanceX;
    }
}

