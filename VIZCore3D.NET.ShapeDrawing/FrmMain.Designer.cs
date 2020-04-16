namespace VIZCore3D.NET.ShapeDrawing
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbOsnap = new System.Windows.Forms.RadioButton();
            this.rbEdgeVertex = new System.Windows.Forms.RadioButton();
            this.rbBoundBox = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnDeleteChecked = new System.Windows.Forms.Button();
            this.btnHideGroup = new System.Windows.Forms.Button();
            this.btnShowGroup = new System.Windows.Forms.Button();
            this.btnHideChecked = new System.Windows.Forms.Button();
            this.btnShowChecked = new System.Windows.Forms.Button();
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHideAll = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckNodeIndex = new System.Windows.Forms.CheckBox();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckUseDepthTest = new System.Windows.Forms.CheckBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckEnable = new System.Windows.Forms.CheckBox();
            this.rbVertex = new System.Windows.Forms.RadioButton();
            this.rbCylinder = new System.Windows.Forms.RadioButton();
            this.rbCube = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1236, 778);
            this.splitContainer1.SplitterDistance = 433;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.rbOsnap);
            this.groupBox6.Controls.Add(this.rbEdgeVertex);
            this.groupBox6.Controls.Add(this.rbBoundBox);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(408, 62);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Source";
            // 
            // rbOsnap
            // 
            this.rbOsnap.AutoSize = true;
            this.rbOsnap.Location = new System.Drawing.Point(233, 32);
            this.rbOsnap.Name = "rbOsnap";
            this.rbOsnap.Size = new System.Drawing.Size(60, 16);
            this.rbOsnap.TabIndex = 2;
            this.rbOsnap.TabStop = true;
            this.rbOsnap.Text = "Osnap";
            this.rbOsnap.UseVisualStyleBackColor = true;
            // 
            // rbEdgeVertex
            // 
            this.rbEdgeVertex.AutoSize = true;
            this.rbEdgeVertex.Location = new System.Drawing.Point(122, 32);
            this.rbEdgeVertex.Name = "rbEdgeVertex";
            this.rbEdgeVertex.Size = new System.Drawing.Size(92, 16);
            this.rbEdgeVertex.TabIndex = 1;
            this.rbEdgeVertex.TabStop = true;
            this.rbEdgeVertex.Text = "Edge Vertex";
            this.rbEdgeVertex.UseVisualStyleBackColor = true;
            // 
            // rbBoundBox
            // 
            this.rbBoundBox.AutoSize = true;
            this.rbBoundBox.Checked = true;
            this.rbBoundBox.Location = new System.Drawing.Point(21, 32);
            this.rbBoundBox.Name = "rbBoundBox";
            this.rbBoundBox.Size = new System.Drawing.Size(81, 16);
            this.rbBoundBox.TabIndex = 0;
            this.rbBoundBox.TabStop = true;
            this.rbBoundBox.Text = "BoundBox";
            this.rbBoundBox.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnDeleteGroup);
            this.groupBox5.Controls.Add(this.btnDeleteChecked);
            this.groupBox5.Controls.Add(this.btnHideGroup);
            this.groupBox5.Controls.Add(this.btnShowGroup);
            this.groupBox5.Controls.Add(this.btnHideChecked);
            this.groupBox5.Controls.Add(this.btnShowChecked);
            this.groupBox5.Controls.Add(this.lvList);
            this.groupBox5.Controls.Add(this.btnClear);
            this.groupBox5.Controls.Add(this.btnHideAll);
            this.groupBox5.Controls.Add(this.btnShowAll);
            this.groupBox5.Location = new System.Drawing.Point(12, 380);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(408, 386);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "List";
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(248, 89);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteGroup.TabIndex = 9;
            this.btnDeleteGroup.Text = "Delete (Group)";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // btnDeleteChecked
            // 
            this.btnDeleteChecked.Location = new System.Drawing.Point(248, 60);
            this.btnDeleteChecked.Name = "btnDeleteChecked";
            this.btnDeleteChecked.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteChecked.TabIndex = 8;
            this.btnDeleteChecked.Text = "Delete (Checked)";
            this.btnDeleteChecked.UseVisualStyleBackColor = true;
            this.btnDeleteChecked.Click += new System.EventHandler(this.btnDeleteChecked_Click);
            // 
            // btnHideGroup
            // 
            this.btnHideGroup.Location = new System.Drawing.Point(136, 89);
            this.btnHideGroup.Name = "btnHideGroup";
            this.btnHideGroup.Size = new System.Drawing.Size(103, 23);
            this.btnHideGroup.TabIndex = 7;
            this.btnHideGroup.Text = "Hide (Group)";
            this.btnHideGroup.UseVisualStyleBackColor = true;
            this.btnHideGroup.Click += new System.EventHandler(this.btnHideGroup_Click);
            // 
            // btnShowGroup
            // 
            this.btnShowGroup.Location = new System.Drawing.Point(21, 89);
            this.btnShowGroup.Name = "btnShowGroup";
            this.btnShowGroup.Size = new System.Drawing.Size(109, 23);
            this.btnShowGroup.TabIndex = 6;
            this.btnShowGroup.Text = "Show (Group)";
            this.btnShowGroup.UseVisualStyleBackColor = true;
            this.btnShowGroup.Click += new System.EventHandler(this.btnShowGroup_Click);
            // 
            // btnHideChecked
            // 
            this.btnHideChecked.Location = new System.Drawing.Point(136, 60);
            this.btnHideChecked.Name = "btnHideChecked";
            this.btnHideChecked.Size = new System.Drawing.Size(103, 23);
            this.btnHideChecked.TabIndex = 5;
            this.btnHideChecked.Text = "Hide (Checked)";
            this.btnHideChecked.UseVisualStyleBackColor = true;
            this.btnHideChecked.Click += new System.EventHandler(this.btnHideChecked_Click);
            // 
            // btnShowChecked
            // 
            this.btnShowChecked.Location = new System.Drawing.Point(21, 60);
            this.btnShowChecked.Name = "btnShowChecked";
            this.btnShowChecked.Size = new System.Drawing.Size(109, 23);
            this.btnShowChecked.TabIndex = 4;
            this.btnShowChecked.Text = "Show (Checked)";
            this.btnShowChecked.UseVisualStyleBackColor = true;
            this.btnShowChecked.Click += new System.EventHandler(this.btnShowChecked_Click);
            // 
            // lvList
            // 
            this.lvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvList.CheckBoxes = true;
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(6, 118);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(396, 262);
            this.lvList.TabIndex = 3;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Group";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Visible";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(248, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHideAll
            // 
            this.btnHideAll.Location = new System.Drawing.Point(136, 31);
            this.btnHideAll.Name = "btnHideAll";
            this.btnHideAll.Size = new System.Drawing.Size(103, 23);
            this.btnHideAll.TabIndex = 1;
            this.btnHideAll.Text = "Hide All";
            this.btnHideAll.UseVisualStyleBackColor = true;
            this.btnHideAll.Click += new System.EventHandler(this.btnHideAll_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(21, 31);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(109, 23);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ckNodeIndex);
            this.groupBox4.Controls.Add(this.txtGroupId);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 58);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TAG";
            // 
            // ckNodeIndex
            // 
            this.ckNodeIndex.AutoSize = true;
            this.ckNodeIndex.Location = new System.Drawing.Point(248, 27);
            this.ckNodeIndex.Name = "ckNodeIndex";
            this.ckNodeIndex.Size = new System.Drawing.Size(89, 16);
            this.ckNodeIndex.TabIndex = 7;
            this.ckNodeIndex.Text = "Node Index";
            this.ckNodeIndex.UseVisualStyleBackColor = true;
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(130, 24);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(100, 21);
            this.txtGroupId.TabIndex = 6;
            this.txtGroupId.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Group ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnColor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 63);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Style";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(130, 22);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 23);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ckUseDepthTest);
            this.groupBox2.Controls.Add(this.txtSize);
            this.groupBox2.Controls.Add(this.txtRadius);
            this.groupBox2.Controls.Add(this.txtThickness);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // ckUseDepthTest
            // 
            this.ckUseDepthTest.AutoSize = true;
            this.ckUseDepthTest.Checked = true;
            this.ckUseDepthTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckUseDepthTest.Location = new System.Drawing.Point(34, 68);
            this.ckUseDepthTest.Name = "ckUseDepthTest";
            this.ckUseDepthTest.Size = new System.Drawing.Size(107, 16);
            this.ckUseDepthTest.TabIndex = 6;
            this.ckUseDepthTest.Text = "Use DepthTest";
            this.ckUseDepthTest.UseVisualStyleBackColor = true;
            this.ckUseDepthTest.CheckedChanged += new System.EventHandler(this.ckUseDepthTest_CheckedChanged);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(331, 31);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(56, 21);
            this.txtSize.TabIndex = 5;
            this.txtSize.Text = "7";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(220, 31);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(56, 21);
            this.txtRadius.TabIndex = 4;
            this.txtRadius.Text = "5";
            // 
            // txtThickness
            // 
            this.txtThickness.Location = new System.Drawing.Point(102, 31);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.Size = new System.Drawing.Size(56, 21);
            this.txtThickness.TabIndex = 3;
            this.txtThickness.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thickness";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckEnable);
            this.groupBox1.Controls.Add(this.rbVertex);
            this.groupBox1.Controls.Add(this.rbCylinder);
            this.groupBox1.Controls.Add(this.rbCube);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // ckEnable
            // 
            this.ckEnable.AutoSize = true;
            this.ckEnable.Checked = true;
            this.ckEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckEnable.Location = new System.Drawing.Point(34, 24);
            this.ckEnable.Name = "ckEnable";
            this.ckEnable.Size = new System.Drawing.Size(63, 16);
            this.ckEnable.TabIndex = 4;
            this.ckEnable.Text = "Enable";
            this.ckEnable.UseVisualStyleBackColor = true;
            // 
            // rbVertex
            // 
            this.rbVertex.AutoSize = true;
            this.rbVertex.Location = new System.Drawing.Point(317, 23);
            this.rbVertex.Name = "rbVertex";
            this.rbVertex.Size = new System.Drawing.Size(59, 16);
            this.rbVertex.TabIndex = 3;
            this.rbVertex.Text = "Vertex";
            this.rbVertex.UseVisualStyleBackColor = true;
            // 
            // rbCylinder
            // 
            this.rbCylinder.AutoSize = true;
            this.rbCylinder.Location = new System.Drawing.Point(242, 23);
            this.rbCylinder.Name = "rbCylinder";
            this.rbCylinder.Size = new System.Drawing.Size(70, 16);
            this.rbCylinder.TabIndex = 2;
            this.rbCylinder.Text = "Cylinder";
            this.rbCylinder.UseVisualStyleBackColor = true;
            // 
            // rbCube
            // 
            this.rbCube.AutoSize = true;
            this.rbCube.Location = new System.Drawing.Point(181, 23);
            this.rbCube.Name = "rbCube";
            this.rbCube.Size = new System.Drawing.Size(53, 16);
            this.rbCube.TabIndex = 1;
            this.rbCube.Text = "Cube";
            this.rbCube.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Location = new System.Drawing.Point(126, 23);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(47, 16);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 778);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.ShapeDrawing";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVertex;
        private System.Windows.Forms.RadioButton rbCylinder;
        private System.Windows.Forms.RadioButton rbCube;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckNodeIndex;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnHideAll;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.CheckBox ckUseDepthTest;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox ckEnable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnDeleteChecked;
        private System.Windows.Forms.Button btnHideGroup;
        private System.Windows.Forms.Button btnShowGroup;
        private System.Windows.Forms.Button btnHideChecked;
        private System.Windows.Forms.Button btnShowChecked;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbOsnap;
        private System.Windows.Forms.RadioButton rbEdgeVertex;
        private System.Windows.Forms.RadioButton rbBoundBox;
    }
}

