using System.Windows.Forms;

namespace VIZCore3D.NET.AnimationClashTest2
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
            this.btnGenerateAnimation = new System.Windows.Forms.Button();
            this.btnOpenSampleModel = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ckConnectedSurfaceNormalVector = new System.Windows.Forms.CheckBox();
            this.ckPenetration = new System.Windows.Forms.CheckBox();
            this.ckResultAssembly = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBottomLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPenetrationTolerance = new System.Windows.Forms.TextBox();
            this.txtRangeValue = new System.Windows.Forms.TextBox();
            this.ckUsePenetrationTolerance = new System.Windows.Forms.CheckBox();
            this.ckUseRangeValue = new System.Windows.Forms.CheckBox();
            this.ckVisibleOnly = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddGroupA = new System.Windows.Forms.Button();
            this.btnAddGroupB = new System.Windows.Forms.Button();
            this.btnPerformTest = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lvResult = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 510;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbResult);
            this.splitContainer1.Size = new System.Drawing.Size(1584, 806);
            this.splitContainer1.SplitterDistance = 594;
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
            this.splitContainer2.Panel1.Controls.Add(this.btnGenerateAnimation);
            this.splitContainer2.Panel1.Controls.Add(this.btnOpenSampleModel);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.btnPerformTest);
            this.splitContainer2.Size = new System.Drawing.Size(1584, 594);
            this.splitContainer2.SplitterDistance = 277;
            this.splitContainer2.TabIndex = 16;
            // 
            // btnGenerateAnimation
            // 
            this.btnGenerateAnimation.Location = new System.Drawing.Point(12, 121);
            this.btnGenerateAnimation.Name = "btnGenerateAnimation";
            this.btnGenerateAnimation.Size = new System.Drawing.Size(253, 33);
            this.btnGenerateAnimation.TabIndex = 23;
            this.btnGenerateAnimation.Text = "3. 애니메이션 생성";
            this.btnGenerateAnimation.UseVisualStyleBackColor = true;
            this.btnGenerateAnimation.Click += new System.EventHandler(this.btnGenerateAnimation_Click);
            // 
            // btnOpenSampleModel
            // 
            this.btnOpenSampleModel.Location = new System.Drawing.Point(12, 21);
            this.btnOpenSampleModel.Name = "btnOpenSampleModel";
            this.btnOpenSampleModel.Size = new System.Drawing.Size(253, 32);
            this.btnOpenSampleModel.TabIndex = 22;
            this.btnOpenSampleModel.Text = "1. 샘플 모델 열기";
            this.btnOpenSampleModel.UseVisualStyleBackColor = true;
            this.btnOpenSampleModel.Click += new System.EventHandler(this.btnOpenSampleModel_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.ckConnectedSurfaceNormalVector);
            this.groupBox6.Controls.Add(this.ckPenetration);
            this.groupBox6.Controls.Add(this.ckResultAssembly);
            this.groupBox6.Location = new System.Drawing.Point(12, 292);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(253, 90);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Result Filter";
            // 
            // ckConnectedSurfaceNormalVector
            // 
            this.ckConnectedSurfaceNormalVector.AutoSize = true;
            this.ckConnectedSurfaceNormalVector.Location = new System.Drawing.Point(17, 64);
            this.ckConnectedSurfaceNormalVector.Name = "ckConnectedSurfaceNormalVector";
            this.ckConnectedSurfaceNormalVector.Size = new System.Drawing.Size(112, 16);
            this.ckConnectedSurfaceNormalVector.TabIndex = 3;
            this.ckConnectedSurfaceNormalVector.Text = "인접면 법선벡터";
            this.ckConnectedSurfaceNormalVector.UseVisualStyleBackColor = true;
            // 
            // ckPenetration
            // 
            this.ckPenetration.AutoSize = true;
            this.ckPenetration.Location = new System.Drawing.Point(17, 42);
            this.ckPenetration.Name = "ckPenetration";
            this.ckPenetration.Size = new System.Drawing.Size(116, 16);
            this.ckPenetration.TabIndex = 2;
            this.ckPenetration.Text = "침투 결과만 조회";
            this.ckPenetration.UseVisualStyleBackColor = true;
            // 
            // ckResultAssembly
            // 
            this.ckResultAssembly.AutoSize = true;
            this.ckResultAssembly.Location = new System.Drawing.Point(17, 20);
            this.ckResultAssembly.Name = "ckResultAssembly";
            this.ckResultAssembly.Size = new System.Drawing.Size(81, 16);
            this.ckResultAssembly.TabIndex = 0;
            this.ckResultAssembly.Text = "Assembly";
            this.ckResultAssembly.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtBottomLevel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPenetrationTolerance);
            this.groupBox2.Controls.Add(this.txtRangeValue);
            this.groupBox2.Controls.Add(this.ckUsePenetrationTolerance);
            this.groupBox2.Controls.Add(this.ckUseRangeValue);
            this.groupBox2.Controls.Add(this.ckVisibleOnly);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 126);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // txtBottomLevel
            // 
            this.txtBottomLevel.Location = new System.Drawing.Point(128, 70);
            this.txtBottomLevel.Name = "txtBottomLevel";
            this.txtBottomLevel.Size = new System.Drawing.Size(100, 21);
            this.txtBottomLevel.TabIndex = 8;
            this.txtBottomLevel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "검사제외 끝레벨";
            // 
            // txtPenetrationTolerance
            // 
            this.txtPenetrationTolerance.Location = new System.Drawing.Point(128, 44);
            this.txtPenetrationTolerance.Name = "txtPenetrationTolerance";
            this.txtPenetrationTolerance.Size = new System.Drawing.Size(100, 21);
            this.txtPenetrationTolerance.TabIndex = 6;
            this.txtPenetrationTolerance.Text = "0";
            // 
            // txtRangeValue
            // 
            this.txtRangeValue.Location = new System.Drawing.Point(128, 18);
            this.txtRangeValue.Name = "txtRangeValue";
            this.txtRangeValue.Size = new System.Drawing.Size(100, 21);
            this.txtRangeValue.TabIndex = 5;
            this.txtRangeValue.Text = "0";
            // 
            // ckUsePenetrationTolerance
            // 
            this.ckUsePenetrationTolerance.AutoSize = true;
            this.ckUsePenetrationTolerance.Checked = true;
            this.ckUsePenetrationTolerance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckUsePenetrationTolerance.Location = new System.Drawing.Point(18, 46);
            this.ckUsePenetrationTolerance.Name = "ckUsePenetrationTolerance";
            this.ckUsePenetrationTolerance.Size = new System.Drawing.Size(96, 16);
            this.ckUsePenetrationTolerance.TabIndex = 4;
            this.ckUsePenetrationTolerance.Text = "접촉허용오차";
            this.ckUsePenetrationTolerance.UseVisualStyleBackColor = true;
            // 
            // ckUseRangeValue
            // 
            this.ckUseRangeValue.AutoSize = true;
            this.ckUseRangeValue.Checked = true;
            this.ckUseRangeValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckUseRangeValue.Location = new System.Drawing.Point(18, 23);
            this.ckUseRangeValue.Name = "ckUseRangeValue";
            this.ckUseRangeValue.Size = new System.Drawing.Size(96, 16);
            this.ckUseRangeValue.TabIndex = 3;
            this.ckUseRangeValue.Text = "근접허용범위";
            this.ckUseRangeValue.UseVisualStyleBackColor = true;
            // 
            // ckVisibleOnly
            // 
            this.ckVisibleOnly.AutoSize = true;
            this.ckVisibleOnly.Location = new System.Drawing.Point(17, 96);
            this.ckVisibleOnly.Name = "ckVisibleOnly";
            this.ckVisibleOnly.Size = new System.Drawing.Size(92, 16);
            this.ckVisibleOnly.TabIndex = 2;
            this.ckVisibleOnly.Text = "Visible Only";
            this.ckVisibleOnly.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAddGroupA);
            this.groupBox1.Controls.Add(this.btnAddGroupB);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 56);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Group";
            // 
            // btnAddGroupA
            // 
            this.btnAddGroupA.Location = new System.Drawing.Point(6, 20);
            this.btnAddGroupA.Name = "btnAddGroupA";
            this.btnAddGroupA.Size = new System.Drawing.Size(117, 23);
            this.btnAddGroupA.TabIndex = 1;
            this.btnAddGroupA.Text = "Add Group A";
            this.btnAddGroupA.UseVisualStyleBackColor = true;
            this.btnAddGroupA.Click += new System.EventHandler(this.btnAddGroupA_Click);
            // 
            // btnAddGroupB
            // 
            this.btnAddGroupB.Location = new System.Drawing.Point(129, 20);
            this.btnAddGroupB.Name = "btnAddGroupB";
            this.btnAddGroupB.Size = new System.Drawing.Size(117, 23);
            this.btnAddGroupB.TabIndex = 2;
            this.btnAddGroupB.Text = "Add Group B";
            this.btnAddGroupB.UseVisualStyleBackColor = true;
            this.btnAddGroupB.Click += new System.EventHandler(this.btnAddGroupB_Click);
            // 
            // btnPerformTest
            // 
            this.btnPerformTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerformTest.Location = new System.Drawing.Point(12, 388);
            this.btnPerformTest.Name = "btnPerformTest";
            this.btnPerformTest.Size = new System.Drawing.Size(253, 65);
            this.btnPerformTest.TabIndex = 16;
            this.btnPerformTest.Text = "4. 간섭검사 시작";
            this.btnPerformTest.UseVisualStyleBackColor = true;
            this.btnPerformTest.Click += new System.EventHandler(this.btnPerformTest_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lvResult);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResult.Location = new System.Drawing.Point(0, 0);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(1584, 208);
            this.gbResult.TabIndex = 1;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // lvResult
            // 
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader23,
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
            this.columnHeader20,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27});
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(3, 17);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(1578, 188);
            this.lvResult.TabIndex = 0;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            this.lvResult.DoubleClick += new System.EventHandler(this.lvResult_DoubleClick);
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "NO.";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SUB ID";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 125;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Translation";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Result Kind";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Node Index A";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 149;
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
            // columnHeader24
            // 
            this.columnHeader24.Text = "Normal";
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Projection A";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Projection B";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Playback Time";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 806);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "VIZCore3D.NET.AnimationClashTest2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtPenetrationTolerance;
        private TextBox txtRangeValue;
        private CheckBox ckUsePenetrationTolerance;
        private CheckBox ckUseRangeValue;
        private CheckBox ckVisibleOnly;
        private GroupBox groupBox1;
        private Button btnAddGroupA;
        private Button btnAddGroupB;
        private Button btnPerformTest;
        private GroupBox gbResult;
        private ListView lvResult;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private GroupBox groupBox6;
        private CheckBox ckConnectedSurfaceNormalVector;
        private CheckBox ckPenetration;
        private CheckBox ckResultAssembly;
        private TextBox txtBottomLevel;
        private Button btnOpenSampleModel;
        private Button btnGenerateAnimation;
        private ColumnHeader columnHeader27;
    }
}

