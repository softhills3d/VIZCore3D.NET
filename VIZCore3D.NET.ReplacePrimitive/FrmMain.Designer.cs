namespace VIZCore3D.NET.ReplacePrimitive
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatrix43 = new System.Windows.Forms.TextBox();
            this.txtMatrix33 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatrix32 = new System.Windows.Forms.TextBox();
            this.txtBodyIndex = new System.Windows.Forms.TextBox();
            this.txtMatrix31 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatrix42 = new System.Windows.Forms.TextBox();
            this.btnBodyColor = new System.Windows.Forms.Button();
            this.txtMatrix23 = new System.Windows.Forms.TextBox();
            this.txtUnitScale = new System.Windows.Forms.TextBox();
            this.txtMatrix22 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatrix21 = new System.Windows.Forms.TextBox();
            this.txtMatrix11 = new System.Windows.Forms.TextBox();
            this.txtMatrix41 = new System.Windows.Forms.TextBox();
            this.txtMatrix12 = new System.Windows.Forms.TextBox();
            this.txtMatrix13 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNodeColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNodeIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPrimitive = new System.Windows.Forms.TabControl();
            this.tpCube = new System.Windows.Forms.TabPage();
            this.btnSetPrimitiveCube = new System.Windows.Forms.Button();
            this.txtLengthZCube = new System.Windows.Forms.TextBox();
            this.txtLengthYCube = new System.Windows.Forms.TextBox();
            this.txtLengthXCube = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpCylinder = new System.Windows.Forms.TabPage();
            this.txtCylinderHeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSetPrimitiveCylinder = new System.Windows.Forms.Button();
            this.rbCylinderZAxis = new System.Windows.Forms.RadioButton();
            this.rbCylinderYAxis = new System.Windows.Forms.RadioButton();
            this.rbCylinderXAxis = new System.Windows.Forms.RadioButton();
            this.txtCylinderSideCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCylinderRadius = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbReadWrite = new System.Windows.Forms.RadioButton();
            this.rbReadOnly = new System.Windows.Forms.RadioButton();
            this.rbNotProcessed = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPrimitive.SuspendLayout();
            this.tpCube.SuspendLayout();
            this.tpCylinder.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.tabPrimitive);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1330, 720);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMatrix43);
            this.groupBox2.Controls.Add(this.txtMatrix33);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMatrix32);
            this.groupBox2.Controls.Add(this.txtBodyIndex);
            this.groupBox2.Controls.Add(this.txtMatrix31);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMatrix42);
            this.groupBox2.Controls.Add(this.btnBodyColor);
            this.groupBox2.Controls.Add(this.txtMatrix23);
            this.groupBox2.Controls.Add(this.txtUnitScale);
            this.groupBox2.Controls.Add(this.txtMatrix22);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMatrix21);
            this.groupBox2.Controls.Add(this.txtMatrix11);
            this.groupBox2.Controls.Add(this.txtMatrix41);
            this.groupBox2.Controls.Add(this.txtMatrix12);
            this.groupBox2.Controls.Add(this.txtMatrix13);
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 236);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Common Primitive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Scale";
            // 
            // txtMatrix43
            // 
            this.txtMatrix43.Location = new System.Drawing.Point(198, 201);
            this.txtMatrix43.Name = "txtMatrix43";
            this.txtMatrix43.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix43.TabIndex = 24;
            this.txtMatrix43.Text = "0";
            // 
            // txtMatrix33
            // 
            this.txtMatrix33.Location = new System.Drawing.Point(198, 174);
            this.txtMatrix33.Name = "txtMatrix33";
            this.txtMatrix33.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix33.TabIndex = 23;
            this.txtMatrix33.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Body Index";
            // 
            // txtMatrix32
            // 
            this.txtMatrix32.Location = new System.Drawing.Point(113, 174);
            this.txtMatrix32.Name = "txtMatrix32";
            this.txtMatrix32.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix32.TabIndex = 22;
            this.txtMatrix32.Text = "0";
            // 
            // txtBodyIndex
            // 
            this.txtBodyIndex.Location = new System.Drawing.Point(111, 29);
            this.txtBodyIndex.Name = "txtBodyIndex";
            this.txtBodyIndex.Size = new System.Drawing.Size(68, 21);
            this.txtBodyIndex.TabIndex = 3;
            // 
            // txtMatrix31
            // 
            this.txtMatrix31.Location = new System.Drawing.Point(29, 174);
            this.txtMatrix31.Name = "txtMatrix31";
            this.txtMatrix31.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix31.TabIndex = 21;
            this.txtMatrix31.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color";
            // 
            // txtMatrix42
            // 
            this.txtMatrix42.Location = new System.Drawing.Point(113, 201);
            this.txtMatrix42.Name = "txtMatrix42";
            this.txtMatrix42.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix42.TabIndex = 20;
            this.txtMatrix42.Text = "0";
            // 
            // btnBodyColor
            // 
            this.btnBodyColor.Location = new System.Drawing.Point(240, 27);
            this.btnBodyColor.Name = "btnBodyColor";
            this.btnBodyColor.Size = new System.Drawing.Size(108, 23);
            this.btnBodyColor.TabIndex = 5;
            this.btnBodyColor.Text = "Color";
            this.btnBodyColor.UseVisualStyleBackColor = true;
            this.btnBodyColor.Click += new System.EventHandler(this.btnBodyColor_Click);
            // 
            // txtMatrix23
            // 
            this.txtMatrix23.Location = new System.Drawing.Point(198, 147);
            this.txtMatrix23.Name = "txtMatrix23";
            this.txtMatrix23.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix23.TabIndex = 19;
            this.txtMatrix23.Text = "0";
            // 
            // txtUnitScale
            // 
            this.txtUnitScale.Location = new System.Drawing.Point(111, 63);
            this.txtUnitScale.Name = "txtUnitScale";
            this.txtUnitScale.Size = new System.Drawing.Size(68, 21);
            this.txtUnitScale.TabIndex = 7;
            this.txtUnitScale.Text = "1";
            // 
            // txtMatrix22
            // 
            this.txtMatrix22.Location = new System.Drawing.Point(113, 147);
            this.txtMatrix22.Name = "txtMatrix22";
            this.txtMatrix22.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix22.TabIndex = 18;
            this.txtMatrix22.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Matrix";
            // 
            // txtMatrix21
            // 
            this.txtMatrix21.Location = new System.Drawing.Point(29, 147);
            this.txtMatrix21.Name = "txtMatrix21";
            this.txtMatrix21.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix21.TabIndex = 17;
            this.txtMatrix21.Text = "0";
            // 
            // txtMatrix11
            // 
            this.txtMatrix11.Location = new System.Drawing.Point(29, 120);
            this.txtMatrix11.Name = "txtMatrix11";
            this.txtMatrix11.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix11.TabIndex = 13;
            this.txtMatrix11.Text = "1";
            // 
            // txtMatrix41
            // 
            this.txtMatrix41.Location = new System.Drawing.Point(29, 201);
            this.txtMatrix41.Name = "txtMatrix41";
            this.txtMatrix41.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix41.TabIndex = 16;
            this.txtMatrix41.Text = "0";
            // 
            // txtMatrix12
            // 
            this.txtMatrix12.Location = new System.Drawing.Point(113, 120);
            this.txtMatrix12.Name = "txtMatrix12";
            this.txtMatrix12.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix12.TabIndex = 14;
            this.txtMatrix12.Text = "0";
            // 
            // txtMatrix13
            // 
            this.txtMatrix13.Location = new System.Drawing.Point(198, 120);
            this.txtMatrix13.Name = "txtMatrix13";
            this.txtMatrix13.Size = new System.Drawing.Size(68, 21);
            this.txtMatrix13.TabIndex = 15;
            this.txtMatrix13.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnNodeColor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNodeIndex);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 574);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 112);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Object";
            // 
            // btnNodeColor
            // 
            this.btnNodeColor.Location = new System.Drawing.Point(113, 71);
            this.btnNodeColor.Name = "btnNodeColor";
            this.btnNodeColor.Size = new System.Drawing.Size(100, 23);
            this.btnNodeColor.TabIndex = 4;
            this.btnNodeColor.Text = "Color";
            this.btnNodeColor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color";
            // 
            // txtNodeIndex
            // 
            this.txtNodeIndex.Location = new System.Drawing.Point(113, 34);
            this.txtNodeIndex.Name = "txtNodeIndex";
            this.txtNodeIndex.Size = new System.Drawing.Size(100, 21);
            this.txtNodeIndex.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Node Index";
            // 
            // tabPrimitive
            // 
            this.tabPrimitive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrimitive.Controls.Add(this.tpCube);
            this.tabPrimitive.Controls.Add(this.tpCylinder);
            this.tabPrimitive.Location = new System.Drawing.Point(12, 83);
            this.tabPrimitive.Name = "tabPrimitive";
            this.tabPrimitive.SelectedIndex = 0;
            this.tabPrimitive.Size = new System.Drawing.Size(375, 243);
            this.tabPrimitive.TabIndex = 2;
            // 
            // tpCube
            // 
            this.tpCube.Controls.Add(this.btnSetPrimitiveCube);
            this.tpCube.Controls.Add(this.txtLengthZCube);
            this.tpCube.Controls.Add(this.txtLengthYCube);
            this.tpCube.Controls.Add(this.txtLengthXCube);
            this.tpCube.Controls.Add(this.label6);
            this.tpCube.Location = new System.Drawing.Point(4, 22);
            this.tpCube.Name = "tpCube";
            this.tpCube.Padding = new System.Windows.Forms.Padding(3);
            this.tpCube.Size = new System.Drawing.Size(367, 217);
            this.tpCube.TabIndex = 0;
            this.tpCube.Text = "Cube";
            this.tpCube.UseVisualStyleBackColor = true;
            // 
            // btnSetPrimitiveCube
            // 
            this.btnSetPrimitiveCube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetPrimitiveCube.Location = new System.Drawing.Point(278, 60);
            this.btnSetPrimitiveCube.Name = "btnSetPrimitiveCube";
            this.btnSetPrimitiveCube.Size = new System.Drawing.Size(75, 23);
            this.btnSetPrimitiveCube.TabIndex = 25;
            this.btnSetPrimitiveCube.Text = "Set Prim.";
            this.btnSetPrimitiveCube.UseVisualStyleBackColor = true;
            this.btnSetPrimitiveCube.Click += new System.EventHandler(this.btnSetPrimitiveCube_Click);
            // 
            // txtLengthZCube
            // 
            this.txtLengthZCube.Location = new System.Drawing.Point(255, 16);
            this.txtLengthZCube.Name = "txtLengthZCube";
            this.txtLengthZCube.Size = new System.Drawing.Size(68, 21);
            this.txtLengthZCube.TabIndex = 11;
            this.txtLengthZCube.Text = "1";
            // 
            // txtLengthYCube
            // 
            this.txtLengthYCube.Location = new System.Drawing.Point(171, 16);
            this.txtLengthYCube.Name = "txtLengthYCube";
            this.txtLengthYCube.Size = new System.Drawing.Size(68, 21);
            this.txtLengthYCube.TabIndex = 10;
            this.txtLengthYCube.Text = "1";
            // 
            // txtLengthXCube
            // 
            this.txtLengthXCube.Location = new System.Drawing.Point(86, 16);
            this.txtLengthXCube.Name = "txtLengthXCube";
            this.txtLengthXCube.Size = new System.Drawing.Size(68, 21);
            this.txtLengthXCube.TabIndex = 9;
            this.txtLengthXCube.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Length";
            // 
            // tpCylinder
            // 
            this.tpCylinder.Controls.Add(this.txtCylinderHeight);
            this.tpCylinder.Controls.Add(this.label10);
            this.tpCylinder.Controls.Add(this.btnSetPrimitiveCylinder);
            this.tpCylinder.Controls.Add(this.rbCylinderZAxis);
            this.tpCylinder.Controls.Add(this.rbCylinderYAxis);
            this.tpCylinder.Controls.Add(this.rbCylinderXAxis);
            this.tpCylinder.Controls.Add(this.txtCylinderSideCount);
            this.tpCylinder.Controls.Add(this.label9);
            this.tpCylinder.Controls.Add(this.txtCylinderRadius);
            this.tpCylinder.Controls.Add(this.label8);
            this.tpCylinder.Location = new System.Drawing.Point(4, 22);
            this.tpCylinder.Name = "tpCylinder";
            this.tpCylinder.Padding = new System.Windows.Forms.Padding(3);
            this.tpCylinder.Size = new System.Drawing.Size(367, 217);
            this.tpCylinder.TabIndex = 1;
            this.tpCylinder.Text = "Cylinder";
            this.tpCylinder.UseVisualStyleBackColor = true;
            // 
            // txtCylinderHeight
            // 
            this.txtCylinderHeight.Location = new System.Drawing.Point(97, 50);
            this.txtCylinderHeight.Name = "txtCylinderHeight";
            this.txtCylinderHeight.Size = new System.Drawing.Size(68, 21);
            this.txtCylinderHeight.TabIndex = 28;
            this.txtCylinderHeight.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "Height";
            // 
            // btnSetPrimitiveCylinder
            // 
            this.btnSetPrimitiveCylinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetPrimitiveCylinder.Location = new System.Drawing.Point(271, 79);
            this.btnSetPrimitiveCylinder.Name = "btnSetPrimitiveCylinder";
            this.btnSetPrimitiveCylinder.Size = new System.Drawing.Size(75, 23);
            this.btnSetPrimitiveCylinder.TabIndex = 26;
            this.btnSetPrimitiveCylinder.Text = "Set Prim.";
            this.btnSetPrimitiveCylinder.UseVisualStyleBackColor = true;
            this.btnSetPrimitiveCylinder.Click += new System.EventHandler(this.btnSetPrimitiveCylinder_Click);
            // 
            // rbCylinderZAxis
            // 
            this.rbCylinderZAxis.AutoSize = true;
            this.rbCylinderZAxis.Checked = true;
            this.rbCylinderZAxis.Location = new System.Drawing.Point(200, 82);
            this.rbCylinderZAxis.Name = "rbCylinderZAxis";
            this.rbCylinderZAxis.Size = new System.Drawing.Size(60, 16);
            this.rbCylinderZAxis.TabIndex = 16;
            this.rbCylinderZAxis.TabStop = true;
            this.rbCylinderZAxis.Text = "Z Axis";
            this.rbCylinderZAxis.UseVisualStyleBackColor = true;
            // 
            // rbCylinderYAxis
            // 
            this.rbCylinderYAxis.AutoSize = true;
            this.rbCylinderYAxis.Location = new System.Drawing.Point(107, 82);
            this.rbCylinderYAxis.Name = "rbCylinderYAxis";
            this.rbCylinderYAxis.Size = new System.Drawing.Size(60, 16);
            this.rbCylinderYAxis.TabIndex = 15;
            this.rbCylinderYAxis.Text = "Y Axis";
            this.rbCylinderYAxis.UseVisualStyleBackColor = true;
            // 
            // rbCylinderXAxis
            // 
            this.rbCylinderXAxis.AutoSize = true;
            this.rbCylinderXAxis.Location = new System.Drawing.Point(24, 82);
            this.rbCylinderXAxis.Name = "rbCylinderXAxis";
            this.rbCylinderXAxis.Size = new System.Drawing.Size(60, 16);
            this.rbCylinderXAxis.TabIndex = 14;
            this.rbCylinderXAxis.Text = "X Axis";
            this.rbCylinderXAxis.UseVisualStyleBackColor = true;
            // 
            // txtCylinderSideCount
            // 
            this.txtCylinderSideCount.Location = new System.Drawing.Point(268, 23);
            this.txtCylinderSideCount.Name = "txtCylinderSideCount";
            this.txtCylinderSideCount.Size = new System.Drawing.Size(68, 21);
            this.txtCylinderSideCount.TabIndex = 13;
            this.txtCylinderSideCount.Text = "12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "Side Count";
            // 
            // txtCylinderRadius
            // 
            this.txtCylinderRadius.Location = new System.Drawing.Point(97, 23);
            this.txtCylinderRadius.Name = "txtCylinderRadius";
            this.txtCylinderRadius.Size = new System.Drawing.Size(68, 21);
            this.txtCylinderRadius.TabIndex = 11;
            this.txtCylinderRadius.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "Radius";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbReadWrite);
            this.groupBox1.Controls.Add(this.rbReadOnly);
            this.groupBox1.Controls.Add(this.rbNotProcessed);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primitive Data Read/Write Option";
            // 
            // rbReadWrite
            // 
            this.rbReadWrite.AutoSize = true;
            this.rbReadWrite.Location = new System.Drawing.Point(257, 28);
            this.rbReadWrite.Name = "rbReadWrite";
            this.rbReadWrite.Size = new System.Drawing.Size(93, 16);
            this.rbReadWrite.TabIndex = 2;
            this.rbReadWrite.Text = "Read / Write";
            this.rbReadWrite.UseVisualStyleBackColor = true;
            this.rbReadWrite.CheckedChanged += new System.EventHandler(this.rbReadWrite_CheckedChanged);
            // 
            // rbReadOnly
            // 
            this.rbReadOnly.AutoSize = true;
            this.rbReadOnly.Location = new System.Drawing.Point(154, 28);
            this.rbReadOnly.Name = "rbReadOnly";
            this.rbReadOnly.Size = new System.Drawing.Size(82, 16);
            this.rbReadOnly.TabIndex = 1;
            this.rbReadOnly.Text = "Read Only";
            this.rbReadOnly.UseVisualStyleBackColor = true;
            this.rbReadOnly.CheckedChanged += new System.EventHandler(this.rbReadOnly_CheckedChanged);
            // 
            // rbNotProcessed
            // 
            this.rbNotProcessed.AutoSize = true;
            this.rbNotProcessed.Checked = true;
            this.rbNotProcessed.Location = new System.Drawing.Point(30, 28);
            this.rbNotProcessed.Name = "rbNotProcessed";
            this.rbNotProcessed.Size = new System.Drawing.Size(107, 16);
            this.rbNotProcessed.TabIndex = 0;
            this.rbNotProcessed.TabStop = true;
            this.rbNotProcessed.Text = "Not Processed";
            this.rbNotProcessed.UseVisualStyleBackColor = true;
            this.rbNotProcessed.CheckedChanged += new System.EventHandler(this.rbNotProcessed_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 720);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.ReplacePrimitive";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPrimitive.ResumeLayout(false);
            this.tpCube.ResumeLayout(false);
            this.tpCube.PerformLayout();
            this.tpCylinder.ResumeLayout(false);
            this.tpCylinder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbReadWrite;
        private System.Windows.Forms.RadioButton rbReadOnly;
        private System.Windows.Forms.RadioButton rbNotProcessed;
        private System.Windows.Forms.TabControl tabPrimitive;
        private System.Windows.Forms.TabPage tpCube;
        private System.Windows.Forms.TabPage tpCylinder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNodeColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNodeIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBodyColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBodyIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitScale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLengthZCube;
        private System.Windows.Forms.TextBox txtLengthYCube;
        private System.Windows.Forms.TextBox txtLengthXCube;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatrix43;
        private System.Windows.Forms.TextBox txtMatrix33;
        private System.Windows.Forms.TextBox txtMatrix32;
        private System.Windows.Forms.TextBox txtMatrix31;
        private System.Windows.Forms.TextBox txtMatrix42;
        private System.Windows.Forms.TextBox txtMatrix23;
        private System.Windows.Forms.TextBox txtMatrix22;
        private System.Windows.Forms.TextBox txtMatrix21;
        private System.Windows.Forms.TextBox txtMatrix41;
        private System.Windows.Forms.TextBox txtMatrix13;
        private System.Windows.Forms.TextBox txtMatrix12;
        private System.Windows.Forms.TextBox txtMatrix11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSetPrimitiveCube;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCylinderSideCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCylinderRadius;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSetPrimitiveCylinder;
        private System.Windows.Forms.RadioButton rbCylinderZAxis;
        private System.Windows.Forms.RadioButton rbCylinderYAxis;
        private System.Windows.Forms.RadioButton rbCylinderXAxis;
        private System.Windows.Forms.TextBox txtCylinderHeight;
        private System.Windows.Forms.Label label10;
    }
}

