using System.Windows.Forms;

namespace VIZCore3D.NET.AnimationClashTest
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSetStartPos = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStartPosZ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStartPosY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStartPosX = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeletePath = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.cbAxis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ckConnectedSurfaceNormalVector = new System.Windows.Forms.CheckBox();
            this.ckPenetration = new System.Windows.Forms.CheckBox();
            this.ckResultAssembly = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvPath = new System.Windows.Forms.ListView();
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader55 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader56 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.txtBottomLevel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer2.Panel1.Controls.Add(this.btnClear);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.btnPerformTest);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1584, 594);
            this.splitContainer2.SplitterDistance = 277;
            this.splitContainer2.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetStartPos);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtStartPosZ);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtStartPosY);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtStartPosX);
            this.groupBox3.Location = new System.Drawing.Point(12, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 77);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "시작 지점";
            // 
            // btnSetStartPos
            // 
            this.btnSetStartPos.Location = new System.Drawing.Point(153, 45);
            this.btnSetStartPos.Name = "btnSetStartPos";
            this.btnSetStartPos.Size = new System.Drawing.Size(93, 23);
            this.btnSetStartPos.TabIndex = 20;
            this.btnSetStartPos.Text = "설정";
            this.btnSetStartPos.UseVisualStyleBackColor = true;
            this.btnSetStartPos.Click += new System.EventHandler(this.btnSetStartPos_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "Z";
            // 
            // txtStartPosZ
            // 
            this.txtStartPosZ.Location = new System.Drawing.Point(191, 18);
            this.txtStartPosZ.Name = "txtStartPosZ";
            this.txtStartPosZ.Size = new System.Drawing.Size(55, 21);
            this.txtStartPosZ.TabIndex = 19;
            this.txtStartPosZ.Text = "10000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "Y";
            // 
            // txtStartPosY
            // 
            this.txtStartPosY.Location = new System.Drawing.Point(109, 18);
            this.txtStartPosY.Name = "txtStartPosY";
            this.txtStartPosY.Size = new System.Drawing.Size(55, 21);
            this.txtStartPosY.TabIndex = 17;
            this.txtStartPosY.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "X";
            // 
            // txtStartPosX
            // 
            this.txtStartPosX.Location = new System.Drawing.Point(25, 18);
            this.txtStartPosX.Name = "txtStartPosX";
            this.txtStartPosX.Size = new System.Drawing.Size(55, 21);
            this.txtStartPosX.TabIndex = 15;
            this.txtStartPosX.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnDeletePath);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtDistance);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btnAddPath);
            this.groupBox5.Controls.Add(this.cbAxis);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(12, 376);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 112);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Path";
            // 
            // btnDeletePath
            // 
            this.btnDeletePath.Location = new System.Drawing.Point(6, 75);
            this.btnDeletePath.Name = "btnDeletePath";
            this.btnDeletePath.Size = new System.Drawing.Size(93, 23);
            this.btnDeletePath.TabIndex = 14;
            this.btnDeletePath.Text = "경로 삭제";
            this.btnDeletePath.UseVisualStyleBackColor = true;
            this.btnDeletePath.Click += new System.EventHandler(this.btnDeletePath_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "mm";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(91, 48);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 21);
            this.txtDistance.TabIndex = 12;
            this.txtDistance.Text = "-1000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "이동 거리";
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(153, 75);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(93, 23);
            this.btnAddPath.TabIndex = 10;
            this.btnAddPath.Text = "경로 추가";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // cbAxis
            // 
            this.cbAxis.FormattingEnabled = true;
            this.cbAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cbAxis.Location = new System.Drawing.Point(91, 22);
            this.cbAxis.Name = "cbAxis";
            this.cbAxis.Size = new System.Drawing.Size(100, 20);
            this.cbAxis.TabIndex = 1;
            this.cbAxis.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "방향";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.ckConnectedSurfaceNormalVector);
            this.groupBox6.Controls.Add(this.ckPenetration);
            this.groupBox6.Controls.Add(this.ckResultAssembly);
            this.groupBox6.Location = new System.Drawing.Point(12, 197);
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 564);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 126);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
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
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 56);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group";
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
            this.btnPerformTest.Location = new System.Drawing.Point(148, 564);
            this.btnPerformTest.Name = "btnPerformTest";
            this.btnPerformTest.Size = new System.Drawing.Size(117, 23);
            this.btnPerformTest.TabIndex = 16;
            this.btnPerformTest.Text = "Start";
            this.btnPerformTest.UseVisualStyleBackColor = true;
            this.btnPerformTest.Click += new System.EventHandler(this.btnPerformTest_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer3.Panel1MinSize = 220;
            this.splitContainer3.Size = new System.Drawing.Size(1303, 594);
            this.splitContainer3.SplitterDistance = 220;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvPath);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 594);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Path";
            // 
            // lvPath
            // 
            this.lvPath.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader53,
            this.columnHeader54,
            this.columnHeader55,
            this.columnHeader56});
            this.lvPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPath.FullRowSelect = true;
            this.lvPath.GridLines = true;
            this.lvPath.HideSelection = false;
            this.lvPath.Location = new System.Drawing.Point(3, 17);
            this.lvPath.Name = "lvPath";
            this.lvPath.Size = new System.Drawing.Size(214, 574);
            this.lvPath.TabIndex = 1;
            this.lvPath.UseCompatibleStateImageBehavior = false;
            this.lvPath.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader53
            // 
            this.columnHeader53.Text = "No";
            this.columnHeader53.Width = 30;
            // 
            // columnHeader54
            // 
            this.columnHeader54.Text = "X";
            this.columnHeader54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader55
            // 
            this.columnHeader55.Text = "Y";
            this.columnHeader55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader56
            // 
            this.columnHeader56.Text = "Z";
            this.columnHeader56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.columnHeader26});
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
            // txtBottomLevel
            // 
            this.txtBottomLevel.Location = new System.Drawing.Point(128, 70);
            this.txtBottomLevel.Name = "txtBottomLevel";
            this.txtBottomLevel.Size = new System.Drawing.Size(100, 21);
            this.txtBottomLevel.TabIndex = 8;
            this.txtBottomLevel.Text = "0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 806);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "VIZCore3D.NET.AnimationClashTest";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button btnClear;
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
        private GroupBox groupBox5;
        private Label label8;
        private TextBox txtDistance;
        private Label label9;
        private Button btnAddPath;
        private ComboBox cbAxis;
        private Label label3;
        private GroupBox groupBox3;
        private Label label12;
        private TextBox txtStartPosZ;
        private Label label10;
        private TextBox txtStartPosY;
        private Label label11;
        private TextBox txtStartPosX;
        private Button btnSetStartPos;
        private SplitContainer splitContainer3;
        private GroupBox groupBox4;
        private ListView lvPath;
        private Button btnDeletePath;
        private ColumnHeader columnHeader53;
        private ColumnHeader columnHeader54;
        private ColumnHeader columnHeader55;
        private ColumnHeader columnHeader56;
        private TextBox txtBottomLevel;
    }
}

