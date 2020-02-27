﻿namespace VIZCore3D.NET.ClashTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteResult = new System.Windows.Forms.Button();
            this.btnPerformTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTestKind = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckVisibleOnly = new System.Windows.Forms.CheckBox();
            this.ckUseRangeValue = new System.Windows.Forms.CheckBox();
            this.ckUsePenetrationTolerance = new System.Windows.Forms.CheckBox();
            this.txtRangeValue = new System.Windows.Forms.TextBox();
            this.txtPenetrationTolerance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBottomLevel = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddGroupA = new System.Windows.Forms.Button();
            this.btnAddGroupB = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1402, 803);
            this.splitContainer1.SplitterDistance = 629;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1402, 629);
            this.splitContainer2.SplitterDistance = 391;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnPerformTest);
            this.groupBox1.Controls.Add(this.btnDeleteResult);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clash";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(113, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteResult
            // 
            this.btnDeleteResult.Location = new System.Drawing.Point(18, 60);
            this.btnDeleteResult.Name = "btnDeleteResult";
            this.btnDeleteResult.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteResult.TabIndex = 2;
            this.btnDeleteResult.Text = "DEL. Result";
            this.btnDeleteResult.UseVisualStyleBackColor = true;
            this.btnDeleteResult.Click += new System.EventHandler(this.btnDeleteResult_Click);
            // 
            // btnPerformTest
            // 
            this.btnPerformTest.Location = new System.Drawing.Point(113, 60);
            this.btnPerformTest.Name = "btnPerformTest";
            this.btnPerformTest.Size = new System.Drawing.Size(89, 23);
            this.btnPerformTest.TabIndex = 3;
            this.btnPerformTest.Text = "Start";
            this.btnPerformTest.UseVisualStyleBackColor = true;
            this.btnPerformTest.Click += new System.EventHandler(this.btnPerformTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbBottomLevel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPenetrationTolerance);
            this.groupBox2.Controls.Add(this.txtRangeValue);
            this.groupBox2.Controls.Add(this.ckUsePenetrationTolerance);
            this.groupBox2.Controls.Add(this.ckUseRangeValue);
            this.groupBox2.Controls.Add(this.ckVisibleOnly);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbTestKind);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // cbTestKind
            // 
            this.cbTestKind.FormattingEnabled = true;
            this.cbTestKind.Items.AddRange(new object[] {
            "모델 검사",
            "장비 검사",
            "그룹 검사",
            "이동 검사"});
            this.cbTestKind.Location = new System.Drawing.Point(75, 35);
            this.cbTestKind.Name = "cbTestKind";
            this.cbTestKind.Size = new System.Drawing.Size(95, 20);
            this.cbTestKind.TabIndex = 0;
            this.cbTestKind.Text = "그룹 검사";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "검사유형";
            // 
            // ckVisibleOnly
            // 
            this.ckVisibleOnly.AutoSize = true;
            this.ckVisibleOnly.Location = new System.Drawing.Point(222, 39);
            this.ckVisibleOnly.Name = "ckVisibleOnly";
            this.ckVisibleOnly.Size = new System.Drawing.Size(92, 16);
            this.ckVisibleOnly.TabIndex = 2;
            this.ckVisibleOnly.Text = "Visible Only";
            this.ckVisibleOnly.UseVisualStyleBackColor = true;
            // 
            // ckUseRangeValue
            // 
            this.ckUseRangeValue.AutoSize = true;
            this.ckUseRangeValue.Location = new System.Drawing.Point(18, 81);
            this.ckUseRangeValue.Name = "ckUseRangeValue";
            this.ckUseRangeValue.Size = new System.Drawing.Size(96, 16);
            this.ckUseRangeValue.TabIndex = 3;
            this.ckUseRangeValue.Text = "근접허용범위";
            this.ckUseRangeValue.UseVisualStyleBackColor = true;
            // 
            // ckUsePenetrationTolerance
            // 
            this.ckUsePenetrationTolerance.AutoSize = true;
            this.ckUsePenetrationTolerance.Checked = true;
            this.ckUsePenetrationTolerance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckUsePenetrationTolerance.Location = new System.Drawing.Point(18, 113);
            this.ckUsePenetrationTolerance.Name = "ckUsePenetrationTolerance";
            this.ckUsePenetrationTolerance.Size = new System.Drawing.Size(96, 16);
            this.ckUsePenetrationTolerance.TabIndex = 4;
            this.ckUsePenetrationTolerance.Text = "접촉허용오차";
            this.ckUsePenetrationTolerance.UseVisualStyleBackColor = true;
            // 
            // txtRangeValue
            // 
            this.txtRangeValue.Location = new System.Drawing.Point(128, 76);
            this.txtRangeValue.Name = "txtRangeValue";
            this.txtRangeValue.Size = new System.Drawing.Size(100, 21);
            this.txtRangeValue.TabIndex = 5;
            this.txtRangeValue.Text = "2";
            // 
            // txtPenetrationTolerance
            // 
            this.txtPenetrationTolerance.Location = new System.Drawing.Point(128, 111);
            this.txtPenetrationTolerance.Name = "txtPenetrationTolerance";
            this.txtPenetrationTolerance.Size = new System.Drawing.Size(100, 21);
            this.txtPenetrationTolerance.TabIndex = 6;
            this.txtPenetrationTolerance.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "검사제외 끝레벨";
            // 
            // cbBottomLevel
            // 
            this.cbBottomLevel.FormattingEnabled = true;
            this.cbBottomLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbBottomLevel.Location = new System.Drawing.Point(128, 149);
            this.cbBottomLevel.Name = "cbBottomLevel";
            this.cbBottomLevel.Size = new System.Drawing.Size(95, 20);
            this.cbBottomLevel.TabIndex = 8;
            this.cbBottomLevel.Text = "2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvResult);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1402, 170);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // lvResult
            // 
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader21,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(3, 17);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(1396, 150);
            this.lvResult.TabIndex = 0;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SUB ID";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Node Index A";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 149;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnAddGroupB);
            this.groupBox4.Controls.Add(this.btnAddGroupA);
            this.groupBox4.Location = new System.Drawing.Point(12, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 78);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Group";
            // 
            // btnAddGroupA
            // 
            this.btnAddGroupA.Location = new System.Drawing.Point(18, 36);
            this.btnAddGroupA.Name = "btnAddGroupA";
            this.btnAddGroupA.Size = new System.Drawing.Size(117, 23);
            this.btnAddGroupA.TabIndex = 0;
            this.btnAddGroupA.Text = "Add Group A";
            this.btnAddGroupA.UseVisualStyleBackColor = true;
            this.btnAddGroupA.Click += new System.EventHandler(this.btnAddGroupA_Click);
            // 
            // btnAddGroupB
            // 
            this.btnAddGroupB.Location = new System.Drawing.Point(159, 36);
            this.btnAddGroupB.Name = "btnAddGroupB";
            this.btnAddGroupB.Size = new System.Drawing.Size(117, 23);
            this.btnAddGroupB.TabIndex = 1;
            this.btnAddGroupB.Text = "Add Group B";
            this.btnAddGroupB.UseVisualStyleBackColor = true;
            this.btnAddGroupB.Click += new System.EventHandler(this.btnAddGroupB_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Location = new System.Drawing.Point(12, 397);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(367, 100);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Path";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Node Index B";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Node Name A";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Node Name B";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Distance";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hot Point";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Frame X";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Frame Y";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Frame Z";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Flag";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Node ID A";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Node ID B";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Comment A";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Comment B";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Parent Name A";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Parent Name B";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Node Path A";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Node Path B";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Result Kind";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 803);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.ClashTest";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPerformTest;
        private System.Windows.Forms.Button btnDeleteResult;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbBottomLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPenetrationTolerance;
        private System.Windows.Forms.TextBox txtRangeValue;
        private System.Windows.Forms.CheckBox ckUsePenetrationTolerance;
        private System.Windows.Forms.CheckBox ckUseRangeValue;
        private System.Windows.Forms.CheckBox ckVisibleOnly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTestKind;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddGroupB;
        private System.Windows.Forms.Button btnAddGroupA;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
    }
}
