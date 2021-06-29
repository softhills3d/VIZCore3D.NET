namespace VIZCore3D.NET.DockOut
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
            this.gbClashResult = new System.Windows.Forms.GroupBox();
            this.lvClash = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDock = new System.Windows.Forms.TabPage();
            this.txtDockSideOffset = new System.Windows.Forms.TextBox();
            this.txtDockFrontOffset = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDockDelete = new System.Windows.Forms.Button();
            this.btnDockGenerate = new System.Windows.Forms.Button();
            this.ckDockSingle = new System.Windows.Forms.CheckBox();
            this.ckDockSideAll = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDockLength = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.txtDockBreadth = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.txtDockDepth = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpGrid = new System.Windows.Forms.TabPage();
            this.btnGridClearCross = new System.Windows.Forms.Button();
            this.ckGridHighlightCrossPoint = new System.Windows.Forms.CheckBox();
            this.btnGridClear = new System.Windows.Forms.Button();
            this.btnGridDraw = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGridIntervalX = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.txtGridIntervalY = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpFlooding = new System.Windows.Forms.TabPage();
            this.btnHandle = new System.Windows.Forms.Button();
            this.btnSelectShip = new System.Windows.Forms.Button();
            this.btnFloodingClear = new System.Windows.Forms.Button();
            this.txtFloatingHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxHeight = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnFloodingInit = new System.Windows.Forms.Button();
            this.tpClash = new System.Windows.Forms.TabPage();
            this.ckClashBrewerPalettes = new System.Windows.Forms.CheckBox();
            this.btnClashResultClear = new System.Windows.Forms.Button();
            this.btnClashResultShow = new System.Windows.Forms.Button();
            this.ckClashSimulation = new System.Windows.Forms.CheckBox();
            this.btnClashCheck = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtClashYOffset = new System.Windows.Forms.TextBox();
            this.txtClashXOffset = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClashYAxis = new System.Windows.Forms.TextBox();
            this.txtClashXAxis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpAnimation = new System.Windows.Forms.TabPage();
            this.btnAnimationPause = new System.Windows.Forms.Button();
            this.btnAnimationPlay = new System.Windows.Forms.Button();
            this.btnAnimationGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenModel = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbHeight = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbClashResult.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpDock.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpGrid.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpFlooding.SuspendLayout();
            this.tpClash.SuspendLayout();
            this.tpAnimation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbClashResult);
            this.splitContainer1.Panel1.Controls.Add(this.tcMain);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 588);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbClashResult
            // 
            this.gbClashResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClashResult.Controls.Add(this.lvClash);
            this.gbClashResult.Location = new System.Drawing.Point(12, 410);
            this.gbClashResult.Name = "gbClashResult";
            this.gbClashResult.Size = new System.Drawing.Size(407, 166);
            this.gbClashResult.TabIndex = 3;
            this.gbClashResult.TabStop = false;
            this.gbClashResult.Text = "Result Items";
            // 
            // lvClash
            // 
            this.lvClash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvClash.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvClash.FullRowSelect = true;
            this.lvClash.GridLines = true;
            this.lvClash.HideSelection = false;
            this.lvClash.Location = new System.Drawing.Point(6, 20);
            this.lvClash.Name = "lvClash";
            this.lvClash.Size = new System.Drawing.Size(395, 140);
            this.lvClash.TabIndex = 0;
            this.lvClash.UseCompatibleStateImageBehavior = false;
            this.lvClash.View = System.Windows.Forms.View.Details;
            this.lvClash.DoubleClick += new System.EventHandler(this.lvClash_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Items";
            this.columnHeader1.Width = 218;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpDock);
            this.tcMain.Controls.Add(this.tpGrid);
            this.tcMain.Controls.Add(this.tpFlooding);
            this.tcMain.Controls.Add(this.tpClash);
            this.tcMain.Controls.Add(this.tpAnimation);
            this.tcMain.Location = new System.Drawing.Point(12, 79);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(411, 329);
            this.tcMain.TabIndex = 2;
            // 
            // tpDock
            // 
            this.tpDock.Controls.Add(this.txtDockSideOffset);
            this.tpDock.Controls.Add(this.txtDockFrontOffset);
            this.tpDock.Controls.Add(this.label16);
            this.tpDock.Controls.Add(this.label15);
            this.tpDock.Controls.Add(this.btnDockDelete);
            this.tpDock.Controls.Add(this.btnDockGenerate);
            this.tpDock.Controls.Add(this.ckDockSingle);
            this.tpDock.Controls.Add(this.ckDockSideAll);
            this.tpDock.Controls.Add(this.tableLayoutPanel1);
            this.tpDock.Location = new System.Drawing.Point(4, 22);
            this.tpDock.Name = "tpDock";
            this.tpDock.Padding = new System.Windows.Forms.Padding(3);
            this.tpDock.Size = new System.Drawing.Size(403, 303);
            this.tpDock.TabIndex = 0;
            this.tpDock.Text = "DOCK";
            this.tpDock.UseVisualStyleBackColor = true;
            // 
            // txtDockSideOffset
            // 
            this.txtDockSideOffset.Location = new System.Drawing.Point(93, 85);
            this.txtDockSideOffset.Name = "txtDockSideOffset";
            this.txtDockSideOffset.Size = new System.Drawing.Size(100, 21);
            this.txtDockSideOffset.TabIndex = 12;
            this.txtDockSideOffset.Text = "1000";
            // 
            // txtDockFrontOffset
            // 
            this.txtDockFrontOffset.Location = new System.Drawing.Point(93, 62);
            this.txtDockFrontOffset.Name = "txtDockFrontOffset";
            this.txtDockFrontOffset.Size = new System.Drawing.Size(100, 21);
            this.txtDockFrontOffset.TabIndex = 11;
            this.txtDockFrontOffset.Text = "1000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "Side Offset";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 12);
            this.label15.TabIndex = 8;
            this.label15.Text = "Front Offset";
            // 
            // btnDockDelete
            // 
            this.btnDockDelete.Location = new System.Drawing.Point(111, 201);
            this.btnDockDelete.Name = "btnDockDelete";
            this.btnDockDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDockDelete.TabIndex = 7;
            this.btnDockDelete.Text = "Delete";
            this.btnDockDelete.UseVisualStyleBackColor = true;
            this.btnDockDelete.Click += new System.EventHandler(this.btnDockDelete_Click);
            // 
            // btnDockGenerate
            // 
            this.btnDockGenerate.Location = new System.Drawing.Point(17, 201);
            this.btnDockGenerate.Name = "btnDockGenerate";
            this.btnDockGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnDockGenerate.TabIndex = 6;
            this.btnDockGenerate.Text = "Generate";
            this.btnDockGenerate.UseVisualStyleBackColor = true;
            this.btnDockGenerate.Click += new System.EventHandler(this.btnDockGenerate_Click);
            // 
            // ckDockSingle
            // 
            this.ckDockSingle.AutoSize = true;
            this.ckDockSingle.Location = new System.Drawing.Point(17, 168);
            this.ckDockSingle.Name = "ckDockSingle";
            this.ckDockSingle.Size = new System.Drawing.Size(98, 16);
            this.ckDockSingle.TabIndex = 2;
            this.ckDockSingle.Text = "Single Model";
            this.ckDockSingle.UseVisualStyleBackColor = true;
            // 
            // ckDockSideAll
            // 
            this.ckDockSideAll.AutoSize = true;
            this.ckDockSideAll.Checked = true;
            this.ckDockSideAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDockSideAll.Location = new System.Drawing.Point(17, 146);
            this.ckDockSideAll.Name = "ckDockSideAll";
            this.ckDockSideAll.Size = new System.Drawing.Size(67, 16);
            this.ckDockSideAll.TabIndex = 1;
            this.ckDockSideAll.Text = "Side All";
            this.ckDockSideAll.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDockLength, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDockBreadth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDockDepth, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Breadth (m)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depth (m)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDockLength
            // 
            this.txtDockLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDockLength.Location = new System.Drawing.Point(3, 21);
            this.txtDockLength.Name = "txtDockLength";
            this.txtDockLength.Size = new System.Drawing.Size(123, 21);
            this.txtDockLength.TabIndex = 3;
            this.txtDockLength.Text = "260";
            this.txtDockLength.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtDockLength.WatermarkColor = System.Drawing.Color.Gray;
            this.txtDockLength.WatermarkText = "";
            // 
            // txtDockBreadth
            // 
            this.txtDockBreadth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDockBreadth.Location = new System.Drawing.Point(132, 21);
            this.txtDockBreadth.Name = "txtDockBreadth";
            this.txtDockBreadth.Size = new System.Drawing.Size(123, 21);
            this.txtDockBreadth.TabIndex = 4;
            this.txtDockBreadth.Text = "43";
            this.txtDockBreadth.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtDockBreadth.WatermarkColor = System.Drawing.Color.Gray;
            this.txtDockBreadth.WatermarkText = "";
            // 
            // txtDockDepth
            // 
            this.txtDockDepth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDockDepth.Location = new System.Drawing.Point(261, 21);
            this.txtDockDepth.Name = "txtDockDepth";
            this.txtDockDepth.Size = new System.Drawing.Size(127, 21);
            this.txtDockDepth.TabIndex = 5;
            this.txtDockDepth.Text = "12";
            this.txtDockDepth.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtDockDepth.WatermarkColor = System.Drawing.Color.Gray;
            this.txtDockDepth.WatermarkText = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Length (m)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpGrid
            // 
            this.tpGrid.Controls.Add(this.btnGridClearCross);
            this.tpGrid.Controls.Add(this.ckGridHighlightCrossPoint);
            this.tpGrid.Controls.Add(this.btnGridClear);
            this.tpGrid.Controls.Add(this.btnGridDraw);
            this.tpGrid.Controls.Add(this.tableLayoutPanel2);
            this.tpGrid.Location = new System.Drawing.Point(4, 22);
            this.tpGrid.Name = "tpGrid";
            this.tpGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrid.Size = new System.Drawing.Size(403, 303);
            this.tpGrid.TabIndex = 1;
            this.tpGrid.Text = "GRID";
            this.tpGrid.UseVisualStyleBackColor = true;
            // 
            // btnGridClearCross
            // 
            this.btnGridClearCross.Location = new System.Drawing.Point(171, 127);
            this.btnGridClearCross.Name = "btnGridClearCross";
            this.btnGridClearCross.Size = new System.Drawing.Size(100, 23);
            this.btnGridClearCross.TabIndex = 5;
            this.btnGridClearCross.Text = "Clear (Cross)";
            this.btnGridClearCross.UseVisualStyleBackColor = true;
            this.btnGridClearCross.Click += new System.EventHandler(this.btnGridClearCross_Click);
            // 
            // ckGridHighlightCrossPoint
            // 
            this.ckGridHighlightCrossPoint.AutoSize = true;
            this.ckGridHighlightCrossPoint.Checked = true;
            this.ckGridHighlightCrossPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckGridHighlightCrossPoint.Location = new System.Drawing.Point(11, 63);
            this.ckGridHighlightCrossPoint.Name = "ckGridHighlightCrossPoint";
            this.ckGridHighlightCrossPoint.Size = new System.Drawing.Size(142, 16);
            this.ckGridHighlightCrossPoint.TabIndex = 4;
            this.ckGridHighlightCrossPoint.Text = "Highlight Cross Point";
            this.ckGridHighlightCrossPoint.UseVisualStyleBackColor = true;
            // 
            // btnGridClear
            // 
            this.btnGridClear.Location = new System.Drawing.Point(88, 127);
            this.btnGridClear.Name = "btnGridClear";
            this.btnGridClear.Size = new System.Drawing.Size(75, 23);
            this.btnGridClear.TabIndex = 3;
            this.btnGridClear.Text = "Clear";
            this.btnGridClear.UseVisualStyleBackColor = true;
            this.btnGridClear.Click += new System.EventHandler(this.btnGridClear_Click);
            // 
            // btnGridDraw
            // 
            this.btnGridDraw.Location = new System.Drawing.Point(7, 127);
            this.btnGridDraw.Name = "btnGridDraw";
            this.btnGridDraw.Size = new System.Drawing.Size(75, 23);
            this.btnGridDraw.TabIndex = 2;
            this.btnGridDraw.Text = "Draw";
            this.btnGridDraw.UseVisualStyleBackColor = true;
            this.btnGridDraw.Click += new System.EventHandler(this.btnGridDraw_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtGridIntervalX, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtGridIntervalY, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 45);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Interval Y (mm)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGridIntervalX
            // 
            this.txtGridIntervalX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGridIntervalX.Location = new System.Drawing.Point(3, 21);
            this.txtGridIntervalX.Name = "txtGridIntervalX";
            this.txtGridIntervalX.Size = new System.Drawing.Size(189, 21);
            this.txtGridIntervalX.TabIndex = 3;
            this.txtGridIntervalX.Text = "2000";
            this.txtGridIntervalX.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtGridIntervalX.WatermarkColor = System.Drawing.Color.Gray;
            this.txtGridIntervalX.WatermarkText = "";
            // 
            // txtGridIntervalY
            // 
            this.txtGridIntervalY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGridIntervalY.Location = new System.Drawing.Point(198, 21);
            this.txtGridIntervalY.Name = "txtGridIntervalY";
            this.txtGridIntervalY.Size = new System.Drawing.Size(190, 21);
            this.txtGridIntervalY.TabIndex = 4;
            this.txtGridIntervalY.Text = "2000";
            this.txtGridIntervalY.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtGridIntervalY.WatermarkColor = System.Drawing.Color.Gray;
            this.txtGridIntervalY.WatermarkText = "";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "Interval X (mm)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpFlooding
            // 
            this.tpFlooding.Controls.Add(this.btnHandle);
            this.tpFlooding.Controls.Add(this.btnSelectShip);
            this.tpFlooding.Controls.Add(this.btnFloodingClear);
            this.tpFlooding.Controls.Add(this.txtFloatingHeight);
            this.tpFlooding.Controls.Add(this.label4);
            this.tpFlooding.Controls.Add(this.txtMaxHeight);
            this.tpFlooding.Controls.Add(this.label19);
            this.tpFlooding.Controls.Add(this.btnFloodingInit);
            this.tpFlooding.Location = new System.Drawing.Point(4, 22);
            this.tpFlooding.Name = "tpFlooding";
            this.tpFlooding.Padding = new System.Windows.Forms.Padding(3);
            this.tpFlooding.Size = new System.Drawing.Size(403, 303);
            this.tpFlooding.TabIndex = 6;
            this.tpFlooding.Text = "FLOODING";
            this.tpFlooding.UseVisualStyleBackColor = true;
            // 
            // btnHandle
            // 
            this.btnHandle.Location = new System.Drawing.Point(114, 164);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(75, 23);
            this.btnHandle.TabIndex = 7;
            this.btnHandle.Text = "Handle";
            this.btnHandle.UseVisualStyleBackColor = true;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // btnSelectShip
            // 
            this.btnSelectShip.Location = new System.Drawing.Point(22, 164);
            this.btnSelectShip.Name = "btnSelectShip";
            this.btnSelectShip.Size = new System.Drawing.Size(75, 23);
            this.btnSelectShip.TabIndex = 6;
            this.btnSelectShip.Text = "Select";
            this.btnSelectShip.UseVisualStyleBackColor = true;
            this.btnSelectShip.Click += new System.EventHandler(this.btnSelectShip_Click);
            // 
            // btnFloodingClear
            // 
            this.btnFloodingClear.Location = new System.Drawing.Point(114, 104);
            this.btnFloodingClear.Name = "btnFloodingClear";
            this.btnFloodingClear.Size = new System.Drawing.Size(75, 23);
            this.btnFloodingClear.TabIndex = 5;
            this.btnFloodingClear.Text = "Clear";
            this.btnFloodingClear.UseVisualStyleBackColor = true;
            this.btnFloodingClear.Click += new System.EventHandler(this.btnFloodingClear_Click);
            // 
            // txtFloatingHeight
            // 
            this.txtFloatingHeight.Location = new System.Drawing.Point(114, 55);
            this.txtFloatingHeight.Name = "txtFloatingHeight";
            this.txtFloatingHeight.Size = new System.Drawing.Size(100, 21);
            this.txtFloatingHeight.TabIndex = 4;
            this.txtFloatingHeight.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Floating Height";
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Location = new System.Drawing.Point(114, 17);
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(100, 21);
            this.txtMaxHeight.TabIndex = 2;
            this.txtMaxHeight.Text = "10000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "Max. Height";
            // 
            // btnFloodingInit
            // 
            this.btnFloodingInit.Location = new System.Drawing.Point(22, 104);
            this.btnFloodingInit.Name = "btnFloodingInit";
            this.btnFloodingInit.Size = new System.Drawing.Size(75, 23);
            this.btnFloodingInit.TabIndex = 0;
            this.btnFloodingInit.Text = "Init.";
            this.btnFloodingInit.UseVisualStyleBackColor = true;
            this.btnFloodingInit.Click += new System.EventHandler(this.btnFloodingInit_Click);
            // 
            // tpClash
            // 
            this.tpClash.Controls.Add(this.ckClashBrewerPalettes);
            this.tpClash.Controls.Add(this.btnClashResultClear);
            this.tpClash.Controls.Add(this.btnClashResultShow);
            this.tpClash.Controls.Add(this.ckClashSimulation);
            this.tpClash.Controls.Add(this.btnClashCheck);
            this.tpClash.Controls.Add(this.label11);
            this.tpClash.Controls.Add(this.label12);
            this.tpClash.Controls.Add(this.txtClashYOffset);
            this.tpClash.Controls.Add(this.txtClashXOffset);
            this.tpClash.Controls.Add(this.label13);
            this.tpClash.Controls.Add(this.label14);
            this.tpClash.Controls.Add(this.label9);
            this.tpClash.Controls.Add(this.label10);
            this.tpClash.Controls.Add(this.txtClashYAxis);
            this.tpClash.Controls.Add(this.txtClashXAxis);
            this.tpClash.Controls.Add(this.label7);
            this.tpClash.Controls.Add(this.label5);
            this.tpClash.Location = new System.Drawing.Point(4, 22);
            this.tpClash.Name = "tpClash";
            this.tpClash.Padding = new System.Windows.Forms.Padding(3);
            this.tpClash.Size = new System.Drawing.Size(403, 303);
            this.tpClash.TabIndex = 7;
            this.tpClash.Text = "CLASH";
            this.tpClash.UseVisualStyleBackColor = true;
            // 
            // ckClashBrewerPalettes
            // 
            this.ckClashBrewerPalettes.AutoSize = true;
            this.ckClashBrewerPalettes.Checked = true;
            this.ckClashBrewerPalettes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClashBrewerPalettes.Location = new System.Drawing.Point(32, 222);
            this.ckClashBrewerPalettes.Name = "ckClashBrewerPalettes";
            this.ckClashBrewerPalettes.Size = new System.Drawing.Size(113, 16);
            this.ckClashBrewerPalettes.TabIndex = 16;
            this.ckClashBrewerPalettes.Text = "Brewer Palettes";
            this.ckClashBrewerPalettes.UseVisualStyleBackColor = true;
            // 
            // btnClashResultClear
            // 
            this.btnClashResultClear.Location = new System.Drawing.Point(131, 244);
            this.btnClashResultClear.Name = "btnClashResultClear";
            this.btnClashResultClear.Size = new System.Drawing.Size(101, 23);
            this.btnClashResultClear.TabIndex = 15;
            this.btnClashResultClear.Text = "Clear Result";
            this.btnClashResultClear.UseVisualStyleBackColor = true;
            this.btnClashResultClear.Click += new System.EventHandler(this.btnClashResultClear_Click);
            // 
            // btnClashResultShow
            // 
            this.btnClashResultShow.Location = new System.Drawing.Point(32, 244);
            this.btnClashResultShow.Name = "btnClashResultShow";
            this.btnClashResultShow.Size = new System.Drawing.Size(91, 23);
            this.btnClashResultShow.TabIndex = 14;
            this.btnClashResultShow.Text = "Result View";
            this.btnClashResultShow.UseVisualStyleBackColor = true;
            this.btnClashResultShow.Click += new System.EventHandler(this.btnClashResultShow_Click);
            // 
            // ckClashSimulation
            // 
            this.ckClashSimulation.AutoSize = true;
            this.ckClashSimulation.Location = new System.Drawing.Point(32, 106);
            this.ckClashSimulation.Name = "ckClashSimulation";
            this.ckClashSimulation.Size = new System.Drawing.Size(113, 16);
            this.ckClashSimulation.TabIndex = 13;
            this.ckClashSimulation.Text = "Simulation Only";
            this.ckClashSimulation.UseVisualStyleBackColor = true;
            // 
            // btnClashCheck
            // 
            this.btnClashCheck.Location = new System.Drawing.Point(32, 143);
            this.btnClashCheck.Name = "btnClashCheck";
            this.btnClashCheck.Size = new System.Drawing.Size(75, 23);
            this.btnClashCheck.TabIndex = 12;
            this.btnClashCheck.Text = "Check";
            this.btnClashCheck.UseVisualStyleBackColor = true;
            this.btnClashCheck.Click += new System.EventHandler(this.btnClashCheck_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "m";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "m";
            // 
            // txtClashYOffset
            // 
            this.txtClashYOffset.Location = new System.Drawing.Point(238, 58);
            this.txtClashYOffset.Name = "txtClashYOffset";
            this.txtClashYOffset.Size = new System.Drawing.Size(55, 21);
            this.txtClashYOffset.TabIndex = 9;
            this.txtClashYOffset.Text = "2";
            // 
            // txtClashXOffset
            // 
            this.txtClashXOffset.Location = new System.Drawing.Point(238, 24);
            this.txtClashXOffset.Name = "txtClashXOffset";
            this.txtClashXOffset.Size = new System.Drawing.Size(55, 21);
            this.txtClashXOffset.TabIndex = 8;
            this.txtClashXOffset.Text = "2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(183, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "Y Offset";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(183, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "X Offset";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "m";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "m";
            // 
            // txtClashYAxis
            // 
            this.txtClashYAxis.Location = new System.Drawing.Point(68, 58);
            this.txtClashYAxis.Name = "txtClashYAxis";
            this.txtClashYAxis.Size = new System.Drawing.Size(55, 21);
            this.txtClashYAxis.TabIndex = 3;
            this.txtClashYAxis.Text = "12";
            // 
            // txtClashXAxis
            // 
            this.txtClashXAxis.Location = new System.Drawing.Point(68, 24);
            this.txtClashXAxis.Name = "txtClashXAxis";
            this.txtClashXAxis.Size = new System.Drawing.Size(55, 21);
            this.txtClashXAxis.TabIndex = 2;
            this.txtClashXAxis.Text = "40";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y±";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "X±";
            // 
            // tpAnimation
            // 
            this.tpAnimation.Controls.Add(this.btnAnimationPause);
            this.tpAnimation.Controls.Add(this.btnAnimationPlay);
            this.tpAnimation.Controls.Add(this.btnAnimationGenerate);
            this.tpAnimation.Location = new System.Drawing.Point(4, 22);
            this.tpAnimation.Name = "tpAnimation";
            this.tpAnimation.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnimation.Size = new System.Drawing.Size(403, 303);
            this.tpAnimation.TabIndex = 8;
            this.tpAnimation.Text = "Animation";
            this.tpAnimation.UseVisualStyleBackColor = true;
            // 
            // btnAnimationPause
            // 
            this.btnAnimationPause.Location = new System.Drawing.Point(110, 70);
            this.btnAnimationPause.Name = "btnAnimationPause";
            this.btnAnimationPause.Size = new System.Drawing.Size(75, 23);
            this.btnAnimationPause.TabIndex = 2;
            this.btnAnimationPause.Text = "Pause";
            this.btnAnimationPause.UseVisualStyleBackColor = true;
            this.btnAnimationPause.Click += new System.EventHandler(this.btnAnimationPause_Click);
            // 
            // btnAnimationPlay
            // 
            this.btnAnimationPlay.Location = new System.Drawing.Point(20, 70);
            this.btnAnimationPlay.Name = "btnAnimationPlay";
            this.btnAnimationPlay.Size = new System.Drawing.Size(75, 23);
            this.btnAnimationPlay.TabIndex = 1;
            this.btnAnimationPlay.Text = "Play";
            this.btnAnimationPlay.UseVisualStyleBackColor = true;
            this.btnAnimationPlay.Click += new System.EventHandler(this.btnAnimationPlay_Click);
            // 
            // btnAnimationGenerate
            // 
            this.btnAnimationGenerate.Location = new System.Drawing.Point(20, 32);
            this.btnAnimationGenerate.Name = "btnAnimationGenerate";
            this.btnAnimationGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnAnimationGenerate.TabIndex = 0;
            this.btnAnimationGenerate.Text = "Generate";
            this.btnAnimationGenerate.UseVisualStyleBackColor = true;
            this.btnAnimationGenerate.Click += new System.EventHandler(this.btnAnimationGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpenModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SHIP";
            // 
            // btnOpenModel
            // 
            this.btnOpenModel.Location = new System.Drawing.Point(24, 23);
            this.btnOpenModel.Name = "btnOpenModel";
            this.btnOpenModel.Size = new System.Drawing.Size(75, 23);
            this.btnOpenModel.TabIndex = 0;
            this.btnOpenModel.Text = "Open";
            this.btnOpenModel.UseVisualStyleBackColor = true;
            this.btnOpenModel.Click += new System.EventHandler(this.btnOpenModel_Click);
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
            this.splitContainer2.Panel1.Controls.Add(this.tbHeight);
            this.splitContainer2.Size = new System.Drawing.Size(748, 588);
            this.splitContainer2.SplitterDistance = 63;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbHeight
            // 
            this.tbHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHeight.Enabled = false;
            this.tbHeight.Location = new System.Drawing.Point(0, 0);
            this.tbHeight.Maximum = 100;
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbHeight.Size = new System.Drawing.Size(63, 588);
            this.tbHeight.TabIndex = 0;
            this.tbHeight.Scroll += new System.EventHandler(this.tbHeight_Scroll);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 588);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.DockOut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbClashResult.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpDock.ResumeLayout(false);
            this.tpDock.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpGrid.ResumeLayout(false);
            this.tpGrid.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpFlooding.ResumeLayout(false);
            this.tpFlooding.PerformLayout();
            this.tpClash.ResumeLayout(false);
            this.tpClash.PerformLayout();
            this.tpAnimation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenModel;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDock;
        private System.Windows.Forms.Button btnDockDelete;
        private System.Windows.Forms.Button btnDockGenerate;
        private System.Windows.Forms.CheckBox ckDockSingle;
        private System.Windows.Forms.CheckBox ckDockSideAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.WatermarkTextBox txtDockLength;
        private Controls.WatermarkTextBox txtDockBreadth;
        private Controls.WatermarkTextBox txtDockDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpGrid;
        private System.Windows.Forms.Button btnGridClearCross;
        private System.Windows.Forms.CheckBox ckGridHighlightCrossPoint;
        private System.Windows.Forms.Button btnGridClear;
        private System.Windows.Forms.Button btnGridDraw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private Controls.WatermarkTextBox txtGridIntervalX;
        private Controls.WatermarkTextBox txtGridIntervalY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tpFlooding;
        private System.Windows.Forms.TextBox txtMaxHeight;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnFloodingInit;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TrackBar tbHeight;
        private System.Windows.Forms.TextBox txtFloatingHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFloodingClear;
        private System.Windows.Forms.Button btnHandle;
        private System.Windows.Forms.Button btnSelectShip;
        private System.Windows.Forms.TabPage tpClash;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtClashYOffset;
        private System.Windows.Forms.TextBox txtClashXOffset;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClashYAxis;
        private System.Windows.Forms.TextBox txtClashXAxis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClashCheck;
        private System.Windows.Forms.TabPage tpAnimation;
        private System.Windows.Forms.Button btnAnimationPlay;
        private System.Windows.Forms.Button btnAnimationGenerate;
        private System.Windows.Forms.CheckBox ckClashSimulation;
        private System.Windows.Forms.Button btnClashResultClear;
        private System.Windows.Forms.Button btnClashResultShow;
        private System.Windows.Forms.Button btnAnimationPause;
        private System.Windows.Forms.TextBox txtDockSideOffset;
        private System.Windows.Forms.TextBox txtDockFrontOffset;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ckClashBrewerPalettes;
        private System.Windows.Forms.GroupBox gbClashResult;
        private System.Windows.Forms.ListView lvClash;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

