namespace VIZCore3D.NET.Projection2D
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLoadTest = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.ckCustomMargine = new System.Windows.Forms.CheckBox();
            this.txtCustomMargineY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomMargineX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckCoordinateCorrection = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVirtualImageHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVirtualImageWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuality = new System.Windows.Forms.TrackBar();
            this.ckVertexAll = new System.Windows.Forms.CheckBox();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtM33 = new System.Windows.Forms.TextBox();
            this.txtM32 = new System.Windows.Forms.TextBox();
            this.txtM31 = new System.Windows.Forms.TextBox();
            this.txtM30 = new System.Windows.Forms.TextBox();
            this.txtM23 = new System.Windows.Forms.TextBox();
            this.txtM22 = new System.Windows.Forms.TextBox();
            this.txtM21 = new System.Windows.Forms.TextBox();
            this.txtM20 = new System.Windows.Forms.TextBox();
            this.txtM13 = new System.Windows.Forms.TextBox();
            this.txtM12 = new System.Windows.Forms.TextBox();
            this.txtM11 = new System.Windows.Forms.TextBox();
            this.txtM10 = new System.Windows.Forms.TextBox();
            this.txtM03 = new System.Windows.Forms.TextBox();
            this.txtM02 = new System.Windows.Forms.TextBox();
            this.txtM01 = new System.Windows.Forms.TextBox();
            this.txtM00 = new System.Windows.Forms.TextBox();
            this.btnSetModelMatrix = new System.Windows.Forms.Button();
            this.btnPasteMatrix = new System.Windows.Forms.Button();
            this.btnProjection2D = new System.Windows.Forms.Button();
            this.timerAuto = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1296, 846);
            this.splitContainer1.SplitterDistance = 514;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.btnProjection2D);
            this.splitContainer2.Size = new System.Drawing.Size(514, 846);
            this.splitContainer2.SplitterDistance = 570;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnLoadTest);
            this.groupBox5.Location = new System.Drawing.Point(12, 502);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(488, 52);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TEST";
            // 
            // btnLoadTest
            // 
            this.btnLoadTest.Location = new System.Drawing.Point(46, 20);
            this.btnLoadTest.Name = "btnLoadTest";
            this.btnLoadTest.Size = new System.Drawing.Size(100, 23);
            this.btnLoadTest.TabIndex = 0;
            this.btnLoadTest.Text = "Load Test";
            this.btnLoadTest.UseVisualStyleBackColor = true;
            this.btnLoadTest.Click += new System.EventHandler(this.btnLoadTest_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnAuto);
            this.groupBox4.Controls.Add(this.ckCustomMargine);
            this.groupBox4.Controls.Add(this.txtCustomMargineY);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtCustomMargineX);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 454);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 42);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Custom Margine";
            // 
            // btnAuto
            // 
            this.btnAuto.Image = ((System.Drawing.Image)(resources.GetObject("btnAuto.Image")));
            this.btnAuto.Location = new System.Drawing.Point(430, 13);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(43, 23);
            this.btnAuto.TabIndex = 12;
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // ckCustomMargine
            // 
            this.ckCustomMargine.AutoSize = true;
            this.ckCustomMargine.Location = new System.Drawing.Point(346, 17);
            this.ckCustomMargine.Name = "ckCustomMargine";
            this.ckCustomMargine.Size = new System.Drawing.Size(68, 16);
            this.ckCustomMargine.TabIndex = 11;
            this.ckCustomMargine.Text = "Custom";
            this.ckCustomMargine.UseVisualStyleBackColor = true;
            // 
            // txtCustomMargineY
            // 
            this.txtCustomMargineY.Location = new System.Drawing.Point(204, 15);
            this.txtCustomMargineY.Name = "txtCustomMargineY";
            this.txtCustomMargineY.Size = new System.Drawing.Size(100, 21);
            this.txtCustomMargineY.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "Y";
            // 
            // txtCustomMargineX
            // 
            this.txtCustomMargineX.Location = new System.Drawing.Point(46, 15);
            this.txtCustomMargineX.Name = "txtCustomMargineX";
            this.txtCustomMargineX.Size = new System.Drawing.Size(100, 21);
            this.txtCustomMargineX.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "X";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtY);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtX);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 47);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Margine";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(204, 16);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 21);
            this.txtY.TabIndex = 3;
            this.txtY.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(46, 16);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 21);
            this.txtX.TabIndex = 1;
            this.txtX.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ckCoordinateCorrection);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtVirtualImageHeight);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtVirtualImageWidth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbQuality);
            this.groupBox2.Controls.Add(this.ckVertexAll);
            this.groupBox2.Controls.Add(this.txtScale);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 141);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // ckCoordinateCorrection
            // 
            this.ckCoordinateCorrection.AutoSize = true;
            this.ckCoordinateCorrection.Checked = true;
            this.ckCoordinateCorrection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCoordinateCorrection.Location = new System.Drawing.Point(346, 113);
            this.ckCoordinateCorrection.Name = "ckCoordinateCorrection";
            this.ckCoordinateCorrection.Size = new System.Drawing.Size(82, 16);
            this.ckCoordinateCorrection.TabIndex = 10;
            this.ckCoordinateCorrection.Text = "Correction";
            this.ckCoordinateCorrection.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Height";
            // 
            // txtVirtualImageHeight
            // 
            this.txtVirtualImageHeight.Location = new System.Drawing.Point(280, 109);
            this.txtVirtualImageHeight.Name = "txtVirtualImageHeight";
            this.txtVirtualImageHeight.Size = new System.Drawing.Size(49, 21);
            this.txtVirtualImageHeight.TabIndex = 8;
            this.txtVirtualImageHeight.Text = "1024";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Width";
            // 
            // txtVirtualImageWidth
            // 
            this.txtVirtualImageWidth.Location = new System.Drawing.Point(160, 109);
            this.txtVirtualImageWidth.Name = "txtVirtualImageWidth";
            this.txtVirtualImageWidth.Size = new System.Drawing.Size(49, 21);
            this.txtVirtualImageWidth.TabIndex = 6;
            this.txtVirtualImageWidth.Text = "1024";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Virtual Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quality";
            // 
            // tbQuality
            // 
            this.tbQuality.Location = new System.Drawing.Point(77, 58);
            this.tbQuality.Minimum = 1;
            this.tbQuality.Name = "tbQuality";
            this.tbQuality.Size = new System.Drawing.Size(387, 45);
            this.tbQuality.TabIndex = 3;
            this.tbQuality.Value = 1;
            // 
            // ckVertexAll
            // 
            this.ckVertexAll.AutoSize = true;
            this.ckVertexAll.Location = new System.Drawing.Point(199, 22);
            this.ckVertexAll.Name = "ckVertexAll";
            this.ckVertexAll.Size = new System.Drawing.Size(78, 16);
            this.ckVertexAll.TabIndex = 2;
            this.ckVertexAll.Text = "Vertex All";
            this.ckVertexAll.UseVisualStyleBackColor = true;
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(77, 20);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(100, 21);
            this.txtScale.TabIndex = 1;
            this.txtScale.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scale";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.btnSetModelMatrix);
            this.groupBox1.Controls.Add(this.btnPasteMatrix);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtM33, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtM32, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtM31, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtM30, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtM23, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtM22, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtM21, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtM20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtM13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtM12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtM11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtM10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtM03, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtM02, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtM01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtM00, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtM33
            // 
            this.txtM33.Location = new System.Drawing.Point(330, 78);
            this.txtM33.Name = "txtM33";
            this.txtM33.Size = new System.Drawing.Size(100, 21);
            this.txtM33.TabIndex = 15;
            this.txtM33.Text = "1";
            // 
            // txtM32
            // 
            this.txtM32.Location = new System.Drawing.Point(221, 78);
            this.txtM32.Name = "txtM32";
            this.txtM32.Size = new System.Drawing.Size(100, 21);
            this.txtM32.TabIndex = 14;
            this.txtM32.Text = "0";
            // 
            // txtM31
            // 
            this.txtM31.Location = new System.Drawing.Point(112, 78);
            this.txtM31.Name = "txtM31";
            this.txtM31.Size = new System.Drawing.Size(100, 21);
            this.txtM31.TabIndex = 13;
            this.txtM31.Text = "0";
            // 
            // txtM30
            // 
            this.txtM30.Location = new System.Drawing.Point(3, 78);
            this.txtM30.Name = "txtM30";
            this.txtM30.Size = new System.Drawing.Size(100, 21);
            this.txtM30.TabIndex = 12;
            this.txtM30.Text = "0";
            // 
            // txtM23
            // 
            this.txtM23.Location = new System.Drawing.Point(330, 53);
            this.txtM23.Name = "txtM23";
            this.txtM23.Size = new System.Drawing.Size(100, 21);
            this.txtM23.TabIndex = 11;
            this.txtM23.Text = "0";
            // 
            // txtM22
            // 
            this.txtM22.Location = new System.Drawing.Point(221, 53);
            this.txtM22.Name = "txtM22";
            this.txtM22.Size = new System.Drawing.Size(100, 21);
            this.txtM22.TabIndex = 10;
            this.txtM22.Text = "1";
            // 
            // txtM21
            // 
            this.txtM21.Location = new System.Drawing.Point(112, 53);
            this.txtM21.Name = "txtM21";
            this.txtM21.Size = new System.Drawing.Size(100, 21);
            this.txtM21.TabIndex = 9;
            this.txtM21.Text = "0";
            // 
            // txtM20
            // 
            this.txtM20.Location = new System.Drawing.Point(3, 53);
            this.txtM20.Name = "txtM20";
            this.txtM20.Size = new System.Drawing.Size(100, 21);
            this.txtM20.TabIndex = 8;
            this.txtM20.Text = "0";
            // 
            // txtM13
            // 
            this.txtM13.Location = new System.Drawing.Point(330, 28);
            this.txtM13.Name = "txtM13";
            this.txtM13.Size = new System.Drawing.Size(100, 21);
            this.txtM13.TabIndex = 7;
            this.txtM13.Text = "0";
            // 
            // txtM12
            // 
            this.txtM12.Location = new System.Drawing.Point(221, 28);
            this.txtM12.Name = "txtM12";
            this.txtM12.Size = new System.Drawing.Size(100, 21);
            this.txtM12.TabIndex = 6;
            this.txtM12.Text = "0";
            // 
            // txtM11
            // 
            this.txtM11.Location = new System.Drawing.Point(112, 28);
            this.txtM11.Name = "txtM11";
            this.txtM11.Size = new System.Drawing.Size(100, 21);
            this.txtM11.TabIndex = 5;
            this.txtM11.Text = "1";
            // 
            // txtM10
            // 
            this.txtM10.Location = new System.Drawing.Point(3, 28);
            this.txtM10.Name = "txtM10";
            this.txtM10.Size = new System.Drawing.Size(100, 21);
            this.txtM10.TabIndex = 4;
            this.txtM10.Text = "0";
            // 
            // txtM03
            // 
            this.txtM03.Location = new System.Drawing.Point(330, 3);
            this.txtM03.Name = "txtM03";
            this.txtM03.Size = new System.Drawing.Size(100, 21);
            this.txtM03.TabIndex = 3;
            this.txtM03.Text = "0";
            // 
            // txtM02
            // 
            this.txtM02.Location = new System.Drawing.Point(221, 3);
            this.txtM02.Name = "txtM02";
            this.txtM02.Size = new System.Drawing.Size(100, 21);
            this.txtM02.TabIndex = 2;
            this.txtM02.Text = "0";
            // 
            // txtM01
            // 
            this.txtM01.Location = new System.Drawing.Point(112, 3);
            this.txtM01.Name = "txtM01";
            this.txtM01.Size = new System.Drawing.Size(100, 21);
            this.txtM01.TabIndex = 1;
            this.txtM01.Text = "0";
            // 
            // txtM00
            // 
            this.txtM00.Location = new System.Drawing.Point(3, 3);
            this.txtM00.Name = "txtM00";
            this.txtM00.Size = new System.Drawing.Size(100, 21);
            this.txtM00.TabIndex = 0;
            this.txtM00.Text = "1";
            // 
            // btnSetModelMatrix
            // 
            this.btnSetModelMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetModelMatrix.Location = new System.Drawing.Point(356, 140);
            this.btnSetModelMatrix.Name = "btnSetModelMatrix";
            this.btnSetModelMatrix.Size = new System.Drawing.Size(108, 23);
            this.btnSetModelMatrix.TabIndex = 2;
            this.btnSetModelMatrix.Text = "Set Matrix";
            this.btnSetModelMatrix.UseVisualStyleBackColor = true;
            this.btnSetModelMatrix.Click += new System.EventHandler(this.btnSetModelMatrix_Click);
            // 
            // btnPasteMatrix
            // 
            this.btnPasteMatrix.Location = new System.Drawing.Point(26, 140);
            this.btnPasteMatrix.Name = "btnPasteMatrix";
            this.btnPasteMatrix.Size = new System.Drawing.Size(120, 23);
            this.btnPasteMatrix.TabIndex = 3;
            this.btnPasteMatrix.Text = "Paste (Clipboard)";
            this.btnPasteMatrix.UseVisualStyleBackColor = true;
            this.btnPasteMatrix.Click += new System.EventHandler(this.btnPasteMatrix_Click);
            // 
            // btnProjection2D
            // 
            this.btnProjection2D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjection2D.Location = new System.Drawing.Point(12, 27);
            this.btnProjection2D.Name = "btnProjection2D";
            this.btnProjection2D.Size = new System.Drawing.Size(488, 41);
            this.btnProjection2D.TabIndex = 0;
            this.btnProjection2D.Text = "Projection 2D";
            this.btnProjection2D.UseVisualStyleBackColor = true;
            this.btnProjection2D.Click += new System.EventHandler(this.btnProjection2D_Click);
            // 
            // timerAuto
            // 
            this.timerAuto.Interval = 500;
            this.timerAuto.Tick += new System.EventHandler(this.timerAuto_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 846);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Projection2D";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnProjection2D;
        private System.Windows.Forms.Button btnSetModelMatrix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtM33;
        private System.Windows.Forms.TextBox txtM32;
        private System.Windows.Forms.TextBox txtM31;
        private System.Windows.Forms.TextBox txtM30;
        private System.Windows.Forms.TextBox txtM23;
        private System.Windows.Forms.TextBox txtM22;
        private System.Windows.Forms.TextBox txtM21;
        private System.Windows.Forms.TextBox txtM20;
        private System.Windows.Forms.TextBox txtM13;
        private System.Windows.Forms.TextBox txtM12;
        private System.Windows.Forms.TextBox txtM11;
        private System.Windows.Forms.TextBox txtM10;
        private System.Windows.Forms.TextBox txtM03;
        private System.Windows.Forms.TextBox txtM02;
        private System.Windows.Forms.TextBox txtM01;
        private System.Windows.Forms.TextBox txtM00;
        private System.Windows.Forms.Button btnPasteMatrix;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tbQuality;
        private System.Windows.Forms.CheckBox ckVertexAll;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVirtualImageHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVirtualImageWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckCoordinateCorrection;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCustomMargineY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomMargineX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckCustomMargine;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Timer timerAuto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLoadTest;
    }
}

