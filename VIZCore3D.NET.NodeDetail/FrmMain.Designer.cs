namespace VIZCore3D.NET.NodeDetail
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpNode = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNodeIndex = new System.Windows.Forms.TextBox();
            this.pgNode = new System.Windows.Forms.PropertyGrid();
            this.tpColor = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColorR = new System.Windows.Forms.TextBox();
            this.txtColorG = new System.Windows.Forms.TextBox();
            this.txtColorB = new System.Windows.Forms.TextBox();
            this.btnGetColor = new System.Windows.Forms.Button();
            this.btnColorReset = new System.Windows.Forms.Button();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTransparency = new System.Windows.Forms.TrackBar();
            this.btnResetTransparency = new System.Windows.Forms.Button();
            this.tpTransform = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnResetRotate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRotateZ = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRotateY = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRotateX = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnResetMove = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMoveX = new System.Windows.Forms.TextBox();
            this.txtMoveY = new System.Windows.Forms.TextBox();
            this.txtMoveZ = new System.Windows.Forms.TextBox();
            this.tpUDA = new System.Windows.Forms.TabPage();
            this.tpGeometry = new System.Windows.Forms.TabPage();
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGetUDA = new System.Windows.Forms.Button();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.btnGeometryProperty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpNode.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpColor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransparency)).BeginInit();
            this.tpTransform.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateX)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpUDA.SuspendLayout();
            this.tpGeometry.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tcMain);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 656);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpNode);
            this.tcMain.Controls.Add(this.tpColor);
            this.tcMain.Controls.Add(this.tpTransform);
            this.tcMain.Controls.Add(this.tpUDA);
            this.tcMain.Controls.Add(this.tpGeometry);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(386, 656);
            this.tcMain.TabIndex = 0;
            // 
            // tpNode
            // 
            this.tpNode.Controls.Add(this.groupBox3);
            this.tpNode.Controls.Add(this.pgNode);
            this.tpNode.Location = new System.Drawing.Point(4, 22);
            this.tpNode.Name = "tpNode";
            this.tpNode.Padding = new System.Windows.Forms.Padding(3);
            this.tpNode.Size = new System.Drawing.Size(378, 630);
            this.tpNode.TabIndex = 0;
            this.tpNode.Text = "Node";
            this.tpNode.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNodeIndex);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 66);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Object";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Node Index";
            // 
            // txtNodeIndex
            // 
            this.txtNodeIndex.Location = new System.Drawing.Point(101, 30);
            this.txtNodeIndex.Name = "txtNodeIndex";
            this.txtNodeIndex.Size = new System.Drawing.Size(100, 21);
            this.txtNodeIndex.TabIndex = 1;
            // 
            // pgNode
            // 
            this.pgNode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgNode.Location = new System.Drawing.Point(8, 78);
            this.pgNode.Name = "pgNode";
            this.pgNode.Size = new System.Drawing.Size(364, 544);
            this.pgNode.TabIndex = 2;
            // 
            // tpColor
            // 
            this.tpColor.Controls.Add(this.groupBox2);
            this.tpColor.Controls.Add(this.groupBox1);
            this.tpColor.Location = new System.Drawing.Point(4, 22);
            this.tpColor.Name = "tpColor";
            this.tpColor.Padding = new System.Windows.Forms.Padding(3);
            this.tpColor.Size = new System.Drawing.Size(378, 630);
            this.tpColor.TabIndex = 1;
            this.tpColor.Text = "Color";
            this.tpColor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.btnGetColor);
            this.groupBox2.Controls.Add(this.btnColorReset);
            this.groupBox2.Controls.Add(this.btnSetColor);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 159);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtColorR, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtColorG, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtColorB, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 61);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Blue";
            // 
            // txtColorR
            // 
            this.txtColorR.Location = new System.Drawing.Point(3, 33);
            this.txtColorR.Name = "txtColorR";
            this.txtColorR.Size = new System.Drawing.Size(75, 21);
            this.txtColorR.TabIndex = 5;
            // 
            // txtColorG
            // 
            this.txtColorG.Location = new System.Drawing.Point(118, 33);
            this.txtColorG.Name = "txtColorG";
            this.txtColorG.Size = new System.Drawing.Size(75, 21);
            this.txtColorG.TabIndex = 6;
            // 
            // txtColorB
            // 
            this.txtColorB.Location = new System.Drawing.Point(233, 33);
            this.txtColorB.Name = "txtColorB";
            this.txtColorB.Size = new System.Drawing.Size(75, 21);
            this.txtColorB.TabIndex = 7;
            // 
            // btnGetColor
            // 
            this.btnGetColor.Location = new System.Drawing.Point(11, 105);
            this.btnGetColor.Name = "btnGetColor";
            this.btnGetColor.Size = new System.Drawing.Size(92, 23);
            this.btnGetColor.TabIndex = 2;
            this.btnGetColor.Text = "Get Color";
            this.btnGetColor.UseVisualStyleBackColor = true;
            this.btnGetColor.Click += new System.EventHandler(this.btnGetColor_Click);
            // 
            // btnColorReset
            // 
            this.btnColorReset.Location = new System.Drawing.Point(207, 105);
            this.btnColorReset.Name = "btnColorReset";
            this.btnColorReset.Size = new System.Drawing.Size(92, 23);
            this.btnColorReset.TabIndex = 4;
            this.btnColorReset.Text = "Reset";
            this.btnColorReset.UseVisualStyleBackColor = true;
            this.btnColorReset.Click += new System.EventHandler(this.btnColorReset_Click);
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(109, 105);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(92, 23);
            this.btnSetColor.TabIndex = 3;
            this.btnSetColor.Text = "Set Color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbTransparency);
            this.groupBox1.Controls.Add(this.btnResetTransparency);
            this.groupBox1.Location = new System.Drawing.Point(8, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 109);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transparency";
            // 
            // tbTransparency
            // 
            this.tbTransparency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTransparency.Location = new System.Drawing.Point(6, 20);
            this.tbTransparency.Maximum = 100;
            this.tbTransparency.Name = "tbTransparency";
            this.tbTransparency.Size = new System.Drawing.Size(349, 45);
            this.tbTransparency.TabIndex = 6;
            this.tbTransparency.Scroll += new System.EventHandler(this.tbTransparency_Scroll);
            // 
            // btnResetTransparency
            // 
            this.btnResetTransparency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetTransparency.Location = new System.Drawing.Point(263, 71);
            this.btnResetTransparency.Name = "btnResetTransparency";
            this.btnResetTransparency.Size = new System.Drawing.Size(92, 23);
            this.btnResetTransparency.TabIndex = 7;
            this.btnResetTransparency.Text = "Reset";
            this.btnResetTransparency.UseVisualStyleBackColor = true;
            this.btnResetTransparency.Click += new System.EventHandler(this.btnResetTransparency_Click);
            // 
            // tpTransform
            // 
            this.tpTransform.Controls.Add(this.groupBox5);
            this.tpTransform.Controls.Add(this.groupBox4);
            this.tpTransform.Location = new System.Drawing.Point(4, 22);
            this.tpTransform.Name = "tpTransform";
            this.tpTransform.Size = new System.Drawing.Size(378, 630);
            this.tpTransform.TabIndex = 2;
            this.tpTransform.Text = "Transform";
            this.tpTransform.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnResetRotate);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tbRotateZ);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tbRotateY);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.tbRotateX);
            this.groupBox5.Location = new System.Drawing.Point(8, 162);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 229);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rotate";
            // 
            // btnResetRotate
            // 
            this.btnResetRotate.Location = new System.Drawing.Point(29, 187);
            this.btnResetRotate.Name = "btnResetRotate";
            this.btnResetRotate.Size = new System.Drawing.Size(75, 23);
            this.btnResetRotate.TabIndex = 7;
            this.btnResetRotate.Text = "Reset";
            this.btnResetRotate.UseVisualStyleBackColor = true;
            this.btnResetRotate.Click += new System.EventHandler(this.btnResetRotate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "Z";
            // 
            // tbRotateZ
            // 
            this.tbRotateZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRotateZ.LargeChange = 1;
            this.tbRotateZ.Location = new System.Drawing.Point(29, 136);
            this.tbRotateZ.Maximum = 90;
            this.tbRotateZ.Name = "tbRotateZ";
            this.tbRotateZ.Size = new System.Drawing.Size(326, 45);
            this.tbRotateZ.TabIndex = 5;
            this.tbRotateZ.Scroll += new System.EventHandler(this.tbRotateZ_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "Y";
            // 
            // tbRotateY
            // 
            this.tbRotateY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRotateY.LargeChange = 1;
            this.tbRotateY.Location = new System.Drawing.Point(28, 85);
            this.tbRotateY.Maximum = 90;
            this.tbRotateY.Name = "tbRotateY";
            this.tbRotateY.Size = new System.Drawing.Size(326, 45);
            this.tbRotateY.TabIndex = 3;
            this.tbRotateY.Scroll += new System.EventHandler(this.tbRotateY_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "X";
            // 
            // tbRotateX
            // 
            this.tbRotateX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRotateX.LargeChange = 1;
            this.tbRotateX.Location = new System.Drawing.Point(28, 34);
            this.tbRotateX.Maximum = 90;
            this.tbRotateX.Name = "tbRotateX";
            this.tbRotateX.Size = new System.Drawing.Size(326, 45);
            this.tbRotateX.TabIndex = 0;
            this.tbRotateX.Scroll += new System.EventHandler(this.tbRotateX_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnResetMove);
            this.groupBox4.Controls.Add(this.btnMove);
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Location = new System.Drawing.Point(8, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 142);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Move";
            // 
            // btnResetMove
            // 
            this.btnResetMove.Location = new System.Drawing.Point(99, 104);
            this.btnResetMove.Name = "btnResetMove";
            this.btnResetMove.Size = new System.Drawing.Size(75, 23);
            this.btnResetMove.TabIndex = 4;
            this.btnResetMove.Text = "Reset";
            this.btnResetMove.UseVisualStyleBackColor = true;
            this.btnResetMove.Click += new System.EventHandler(this.btnResetMove_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(9, 104);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMoveX, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMoveY, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMoveZ, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(349, 61);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Z";
            // 
            // txtMoveX
            // 
            this.txtMoveX.Location = new System.Drawing.Point(3, 33);
            this.txtMoveX.Name = "txtMoveX";
            this.txtMoveX.Size = new System.Drawing.Size(75, 21);
            this.txtMoveX.TabIndex = 5;
            this.txtMoveX.Text = "0";
            // 
            // txtMoveY
            // 
            this.txtMoveY.Location = new System.Drawing.Point(118, 33);
            this.txtMoveY.Name = "txtMoveY";
            this.txtMoveY.Size = new System.Drawing.Size(75, 21);
            this.txtMoveY.TabIndex = 6;
            this.txtMoveY.Text = "0";
            // 
            // txtMoveZ
            // 
            this.txtMoveZ.Location = new System.Drawing.Point(233, 33);
            this.txtMoveZ.Name = "txtMoveZ";
            this.txtMoveZ.Size = new System.Drawing.Size(75, 21);
            this.txtMoveZ.TabIndex = 7;
            this.txtMoveZ.Text = "0";
            // 
            // tpUDA
            // 
            this.tpUDA.Controls.Add(this.btnGetUDA);
            this.tpUDA.Controls.Add(this.lvList);
            this.tpUDA.Location = new System.Drawing.Point(4, 22);
            this.tpUDA.Name = "tpUDA";
            this.tpUDA.Size = new System.Drawing.Size(378, 630);
            this.tpUDA.TabIndex = 3;
            this.tpUDA.Text = "UDA";
            this.tpUDA.UseVisualStyleBackColor = true;
            // 
            // tpGeometry
            // 
            this.tpGeometry.Controls.Add(this.btnGeometryProperty);
            this.tpGeometry.Controls.Add(this.propertyGrid);
            this.tpGeometry.Location = new System.Drawing.Point(4, 22);
            this.tpGeometry.Name = "tpGeometry";
            this.tpGeometry.Size = new System.Drawing.Size(378, 630);
            this.tpGeometry.TabIndex = 4;
            this.tpGeometry.Text = "Geometry";
            this.tpGeometry.UseVisualStyleBackColor = true;
            // 
            // lvList
            // 
            this.lvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(8, 61);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(354, 561);
            this.lvList.TabIndex = 1;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KEY";
            this.columnHeader1.Width = 164;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "VALUE";
            this.columnHeader2.Width = 148;
            // 
            // btnGetUDA
            // 
            this.btnGetUDA.Location = new System.Drawing.Point(22, 19);
            this.btnGetUDA.Name = "btnGetUDA";
            this.btnGetUDA.Size = new System.Drawing.Size(75, 23);
            this.btnGetUDA.TabIndex = 2;
            this.btnGetUDA.Text = "Get UDA";
            this.btnGetUDA.UseVisualStyleBackColor = true;
            this.btnGetUDA.Click += new System.EventHandler(this.btnGetUDA_Click);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(8, 62);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(358, 560);
            this.propertyGrid.TabIndex = 1;
            // 
            // btnGeometryProperty
            // 
            this.btnGeometryProperty.Location = new System.Drawing.Point(21, 20);
            this.btnGeometryProperty.Name = "btnGeometryProperty";
            this.btnGeometryProperty.Size = new System.Drawing.Size(166, 23);
            this.btnGeometryProperty.TabIndex = 2;
            this.btnGeometryProperty.Text = "Get Geometry Property";
            this.btnGeometryProperty.UseVisualStyleBackColor = true;
            this.btnGeometryProperty.Click += new System.EventHandler(this.btnGeometryProperty_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 656);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.NodeDetail";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpNode.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpColor.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransparency)).EndInit();
            this.tpTransform.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotateX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpUDA.ResumeLayout(false);
            this.tpGeometry.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpNode;
        private System.Windows.Forms.TabPage tpColor;
        private System.Windows.Forms.TabPage tpTransform;
        private System.Windows.Forms.TabPage tpUDA;
        private System.Windows.Forms.TabPage tpGeometry;
        private System.Windows.Forms.TextBox txtNodeIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PropertyGrid pgNode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtColorB;
        private System.Windows.Forms.TextBox txtColorG;
        private System.Windows.Forms.TextBox txtColorR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnColorReset;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Button btnGetColor;
        private System.Windows.Forms.TrackBar tbTransparency;
        private System.Windows.Forms.Button btnResetTransparency;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnResetMove;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMoveX;
        private System.Windows.Forms.TextBox txtMoveY;
        private System.Windows.Forms.TextBox txtMoveZ;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnResetRotate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tbRotateZ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbRotateY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbRotateX;
        private System.Windows.Forms.Button btnGetUDA;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnGeometryProperty;
        private System.Windows.Forms.PropertyGrid propertyGrid;
    }
}

