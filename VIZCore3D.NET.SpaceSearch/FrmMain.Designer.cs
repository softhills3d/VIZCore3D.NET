namespace VIZCore3D.NET.SpaceSearch
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnViewModel = new System.Windows.Forms.Button();
            this.lvResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbResultNode = new System.Windows.Forms.Label();
            this.lbResultFile = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbNode = new System.Windows.Forms.RadioButton();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbZ = new System.Windows.Forms.TrackBar();
            this.tbY = new System.Windows.Forms.TrackBar();
            this.tbX = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCenterY = new System.Windows.Forms.TextBox();
            this.txtCenterX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLengthX = new System.Windows.Forms.TextBox();
            this.txtLengthY = new System.Windows.Forms.TextBox();
            this.txtLengthZ = new System.Windows.Forms.TextBox();
            this.txtCenterZ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbMaxZ = new System.Windows.Forms.Label();
            this.lbMinZ = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbMaxY = new System.Windows.Forms.Label();
            this.lbMinY = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMaxX = new System.Windows.Forms.Label();
            this.lbMinX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.rbFileUnit = new System.Windows.Forms.RadioButton();
            this.rbNodeUnit = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1420, 799);
            this.splitContainer1.SplitterDistance = 521;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rbNodeUnit);
            this.groupBox4.Controls.Add(this.rbFileUnit);
            this.groupBox4.Controls.Add(this.btnViewModel);
            this.groupBox4.Controls.Add(this.lvResult);
            this.groupBox4.Controls.Add(this.lbResultNode);
            this.groupBox4.Controls.Add(this.lbResultFile);
            this.groupBox4.Location = new System.Drawing.Point(14, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 322);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // btnViewModel
            // 
            this.btnViewModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewModel.Location = new System.Drawing.Point(401, 20);
            this.btnViewModel.Name = "btnViewModel";
            this.btnViewModel.Size = new System.Drawing.Size(75, 23);
            this.btnViewModel.TabIndex = 3;
            this.btnViewModel.Text = "View";
            this.btnViewModel.UseVisualStyleBackColor = true;
            this.btnViewModel.Click += new System.EventHandler(this.btnViewModel_Click);
            // 
            // lvResult
            // 
            this.lvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(6, 50);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(470, 266);
            this.lvResult.TabIndex = 2;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 445;
            // 
            // lbResultNode
            // 
            this.lbResultNode.AutoSize = true;
            this.lbResultNode.Location = new System.Drawing.Point(127, 26);
            this.lbResultNode.Name = "lbResultNode";
            this.lbResultNode.Size = new System.Drawing.Size(73, 12);
            this.lbResultNode.TabIndex = 1;
            this.lbResultNode.Text = "Node : 0 EA";
            // 
            // lbResultFile
            // 
            this.lbResultFile.AutoSize = true;
            this.lbResultFile.Location = new System.Drawing.Point(37, 26);
            this.lbResultFile.Name = "lbResultFile";
            this.lbResultFile.Size = new System.Drawing.Size(63, 12);
            this.lbResultFile.TabIndex = 0;
            this.lbResultFile.Text = "File : 0 EA";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rbNode);
            this.groupBox3.Controls.Add(this.rbFile);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Location = new System.Drawing.Point(12, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 60);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Option";
            // 
            // rbNode
            // 
            this.rbNode.AutoSize = true;
            this.rbNode.Checked = true;
            this.rbNode.Location = new System.Drawing.Point(117, 23);
            this.rbNode.Name = "rbNode";
            this.rbNode.Size = new System.Drawing.Size(53, 16);
            this.rbNode.TabIndex = 4;
            this.rbNode.TabStop = true;
            this.rbNode.Text = "Node";
            this.rbNode.UseVisualStyleBackColor = true;
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(41, 23);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(43, 16);
            this.rbFile.TabIndex = 3;
            this.rbFile.Text = "File";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(403, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbZ);
            this.groupBox2.Controls.Add(this.tbY);
            this.groupBox2.Controls.Add(this.tbX);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zone";
            // 
            // tbZ
            // 
            this.tbZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZ.Location = new System.Drawing.Point(276, 147);
            this.tbZ.Maximum = 100;
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(202, 45);
            this.tbZ.TabIndex = 3;
            this.tbZ.Scroll += new System.EventHandler(this.tbZ_Scroll);
            // 
            // tbY
            // 
            this.tbY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbY.Location = new System.Drawing.Point(276, 98);
            this.tbY.Maximum = 100;
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(202, 45);
            this.tbY.TabIndex = 2;
            this.tbY.Scroll += new System.EventHandler(this.tbY_Scroll);
            // 
            // tbX
            // 
            this.tbX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbX.Location = new System.Drawing.Point(276, 47);
            this.tbX.Maximum = 100;
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(202, 45);
            this.tbX.TabIndex = 1;
            this.tbX.Scroll += new System.EventHandler(this.tbX_Scroll);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.12698F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.87302F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtCenterY, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCenterX, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLengthX, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtLengthY, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtLengthZ, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtCenterZ, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(36, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 172);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "Z";
            // 
            // txtCenterY
            // 
            this.txtCenterY.Location = new System.Drawing.Point(45, 89);
            this.txtCenterY.Name = "txtCenterY";
            this.txtCenterY.Size = new System.Drawing.Size(77, 21);
            this.txtCenterY.TabIndex = 4;
            // 
            // txtCenterX
            // 
            this.txtCenterX.Location = new System.Drawing.Point(45, 37);
            this.txtCenterX.Name = "txtCenterX";
            this.txtCenterX.Size = new System.Drawing.Size(77, 21);
            this.txtCenterX.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Axis";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "Length(mm)";
            // 
            // txtLengthX
            // 
            this.txtLengthX.Location = new System.Drawing.Point(128, 37);
            this.txtLengthX.Name = "txtLengthX";
            this.txtLengthX.Size = new System.Drawing.Size(84, 21);
            this.txtLengthX.TabIndex = 9;
            this.txtLengthX.Text = "2000";
            // 
            // txtLengthY
            // 
            this.txtLengthY.Location = new System.Drawing.Point(128, 89);
            this.txtLengthY.Name = "txtLengthY";
            this.txtLengthY.Size = new System.Drawing.Size(84, 21);
            this.txtLengthY.TabIndex = 10;
            this.txtLengthY.Text = "2000";
            // 
            // txtLengthZ
            // 
            this.txtLengthZ.Location = new System.Drawing.Point(128, 141);
            this.txtLengthZ.Name = "txtLengthZ";
            this.txtLengthZ.Size = new System.Drawing.Size(84, 21);
            this.txtLengthZ.TabIndex = 11;
            this.txtLengthZ.Text = "2000";
            // 
            // txtCenterZ
            // 
            this.txtCenterZ.Location = new System.Drawing.Point(45, 141);
            this.txtCenterZ.Name = "txtCenterZ";
            this.txtCenterZ.Size = new System.Drawing.Size(77, 21);
            this.txtCenterZ.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "Center";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.lbCount);
            this.groupBox1.Controls.Add(this.btnSelectFiles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VIZ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.Controls.Add(this.lbMaxZ, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbMinZ, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbMaxY, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbMinY, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbMaxX, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbMinX, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 82);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbMaxZ
            // 
            this.lbMaxZ.AutoSize = true;
            this.lbMaxZ.Location = new System.Drawing.Point(307, 62);
            this.lbMaxZ.Name = "lbMaxZ";
            this.lbMaxZ.Size = new System.Drawing.Size(11, 12);
            this.lbMaxZ.TabIndex = 11;
            this.lbMaxZ.Text = "0";
            // 
            // lbMinZ
            // 
            this.lbMinZ.AutoSize = true;
            this.lbMinZ.Location = new System.Drawing.Point(155, 62);
            this.lbMinZ.Name = "lbMinZ";
            this.lbMinZ.Size = new System.Drawing.Size(11, 12);
            this.lbMinZ.TabIndex = 10;
            this.lbMinZ.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "Z";
            // 
            // lbMaxY
            // 
            this.lbMaxY.AutoSize = true;
            this.lbMaxY.Location = new System.Drawing.Point(307, 42);
            this.lbMaxY.Name = "lbMaxY";
            this.lbMaxY.Size = new System.Drawing.Size(11, 12);
            this.lbMaxY.TabIndex = 8;
            this.lbMaxY.Text = "0";
            // 
            // lbMinY
            // 
            this.lbMinY.AutoSize = true;
            this.lbMinY.Location = new System.Drawing.Point(155, 42);
            this.lbMinY.Name = "lbMinY";
            this.lbMinY.Size = new System.Drawing.Size(11, 12);
            this.lbMinY.TabIndex = 7;
            this.lbMinY.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Y";
            // 
            // lbMaxX
            // 
            this.lbMaxX.AutoSize = true;
            this.lbMaxX.Location = new System.Drawing.Point(307, 21);
            this.lbMaxX.Name = "lbMaxX";
            this.lbMaxX.Size = new System.Drawing.Size(11, 12);
            this.lbMaxX.TabIndex = 5;
            this.lbMaxX.Text = "0";
            // 
            // lbMinX
            // 
            this.lbMinX.AutoSize = true;
            this.lbMinX.Location = new System.Drawing.Point(155, 21);
            this.lbMinX.Name = "lbMinX";
            this.lbMinX.Size = new System.Drawing.Size(11, 12);
            this.lbMinX.TabIndex = 4;
            this.lbMinX.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min.";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(34, 39);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(76, 12);
            this.lbCount.TabIndex = 1;
            this.lbCount.Text = "Count : 0 EA";
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFiles.Location = new System.Drawing.Point(396, 28);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(82, 23);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "Select...";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // rbFileUnit
            // 
            this.rbFileUnit.AutoSize = true;
            this.rbFileUnit.Checked = true;
            this.rbFileUnit.Location = new System.Drawing.Point(262, 24);
            this.rbFileUnit.Name = "rbFileUnit";
            this.rbFileUnit.Size = new System.Drawing.Size(48, 16);
            this.rbFileUnit.TabIndex = 4;
            this.rbFileUnit.TabStop = true;
            this.rbFileUnit.Text = "FILE";
            this.rbFileUnit.UseVisualStyleBackColor = true;
            // 
            // rbNodeUnit
            // 
            this.rbNodeUnit.AutoSize = true;
            this.rbNodeUnit.Location = new System.Drawing.Point(327, 24);
            this.rbNodeUnit.Name = "rbNodeUnit";
            this.rbNodeUnit.Size = new System.Drawing.Size(57, 16);
            this.rbNodeUnit.TabIndex = 5;
            this.rbNodeUnit.Text = "NODE";
            this.rbNodeUnit.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 799);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.SpaceSearch";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbMaxZ;
        private System.Windows.Forms.Label lbMinZ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbMaxY;
        private System.Windows.Forms.Label lbMinY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMaxX;
        private System.Windows.Forms.Label lbMinX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtCenterZ;
        private System.Windows.Forms.TextBox txtCenterY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCenterX;
        private System.Windows.Forms.TrackBar tbX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLengthX;
        private System.Windows.Forms.TextBox txtLengthY;
        private System.Windows.Forms.TextBox txtLengthZ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar tbZ;
        private System.Windows.Forms.TrackBar tbY;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbNode;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbResultNode;
        private System.Windows.Forms.Label lbResultFile;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnViewModel;
        private System.Windows.Forms.RadioButton rbNodeUnit;
        private System.Windows.Forms.RadioButton rbFileUnit;
    }
}

