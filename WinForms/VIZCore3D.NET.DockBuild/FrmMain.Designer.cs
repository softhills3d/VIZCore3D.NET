namespace VIZCore3D.NET.DockBuild
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
            this.gbPreviewSupporter = new System.Windows.Forms.GroupBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDock = new System.Windows.Forms.TabPage();
            this.btnDockDelete = new System.Windows.Forms.Button();
            this.btnDockGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDockOffset = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tpSpace = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBaseline = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSpaceClearPoint = new System.Windows.Forms.Button();
            this.ckSpacePoint = new System.Windows.Forms.CheckBox();
            this.ckSpaceBox = new System.Windows.Forms.CheckBox();
            this.btnSpaceClear = new System.Windows.Forms.Button();
            this.btnSpaceCheck = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSpaceOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tpSupport = new System.Windows.Forms.TabPage();
            this.btnSuppAdd = new System.Windows.Forms.Button();
            this.btnSuppPreview = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSuppHeight = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSuppOffsetY = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSuppBottomX = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.txtSuppBottomY = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.txtSuppTopX = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.txtSuppTopY = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.txtSuppOffsetX = new VIZCore3D.NET.Controls.WatermarkTextBox();
            this.tpSection = new System.Windows.Forms.TabPage();
            this.btnSectionClear = new System.Windows.Forms.Button();
            this.ckSectionLine = new System.Windows.Forms.CheckBox();
            this.ckSectionPlane = new System.Windows.Forms.CheckBox();
            this.btnSectionAdd = new System.Windows.Forms.Button();
            this.tpAnalysis = new System.Windows.Forms.TabPage();
            this.btnAnalysisModelHide = new System.Windows.Forms.Button();
            this.btnAnalysisModelShow = new System.Windows.Forms.Button();
            this.btnAnalysisMeasureXaxis = new System.Windows.Forms.Button();
            this.btnAnalysisMeasureClear = new System.Windows.Forms.Button();
            this.btnAnalysisModelClear = new System.Windows.Forms.Button();
            this.btnAnalysisModel = new System.Windows.Forms.Button();
            this.ckAnalysisMeasure = new System.Windows.Forms.CheckBox();
            this.ckAnalysisItem = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenModel = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbSection = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpDock.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpGrid.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpSpace.SuspendLayout();
            this.tpSupport.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tpSection.SuspendLayout();
            this.tpAnalysis.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSection)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbPreviewSupporter);
            this.splitContainer1.Panel1.Controls.Add(this.tcMain);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1079, 763);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbPreviewSupporter
            // 
            this.gbPreviewSupporter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPreviewSupporter.Location = new System.Drawing.Point(12, 414);
            this.gbPreviewSupporter.Name = "gbPreviewSupporter";
            this.gbPreviewSupporter.Size = new System.Drawing.Size(407, 336);
            this.gbPreviewSupporter.TabIndex = 2;
            this.gbPreviewSupporter.TabStop = false;
            this.gbPreviewSupporter.Text = "Preview Supporter";
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpDock);
            this.tcMain.Controls.Add(this.tpGrid);
            this.tcMain.Controls.Add(this.tpSpace);
            this.tcMain.Controls.Add(this.tpSupport);
            this.tcMain.Controls.Add(this.tpSection);
            this.tcMain.Controls.Add(this.tpAnalysis);
            this.tcMain.Location = new System.Drawing.Point(12, 79);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(411, 329);
            this.tcMain.TabIndex = 1;
            // 
            // tpDock
            // 
            this.tpDock.Controls.Add(this.btnDockDelete);
            this.tpDock.Controls.Add(this.btnDockGenerate);
            this.tpDock.Controls.Add(this.label5);
            this.tpDock.Controls.Add(this.txtDockOffset);
            this.tpDock.Controls.Add(this.label4);
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
            // btnDockDelete
            // 
            this.btnDockDelete.Location = new System.Drawing.Point(114, 151);
            this.btnDockDelete.Name = "btnDockDelete";
            this.btnDockDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDockDelete.TabIndex = 7;
            this.btnDockDelete.Text = "Delete";
            this.btnDockDelete.UseVisualStyleBackColor = true;
            this.btnDockDelete.Click += new System.EventHandler(this.btnDockDelete_Click);
            // 
            // btnDockGenerate
            // 
            this.btnDockGenerate.Location = new System.Drawing.Point(20, 151);
            this.btnDockGenerate.Name = "btnDockGenerate";
            this.btnDockGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnDockGenerate.TabIndex = 6;
            this.btnDockGenerate.Text = "Generate";
            this.btnDockGenerate.UseVisualStyleBackColor = true;
            this.btnDockGenerate.Click += new System.EventHandler(this.btnDockGenerate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "mm";
            // 
            // txtDockOffset
            // 
            this.txtDockOffset.Location = new System.Drawing.Point(73, 63);
            this.txtDockOffset.Name = "txtDockOffset";
            this.txtDockOffset.Size = new System.Drawing.Size(58, 21);
            this.txtDockOffset.TabIndex = 4;
            this.txtDockOffset.Text = "2000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Offset";
            // 
            // ckDockSingle
            // 
            this.ckDockSingle.AutoSize = true;
            this.ckDockSingle.Location = new System.Drawing.Point(20, 118);
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
            this.ckDockSideAll.Location = new System.Drawing.Point(20, 96);
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
            // tpSpace
            // 
            this.tpSpace.Controls.Add(this.label17);
            this.tpSpace.Controls.Add(this.txtBaseline);
            this.tpSpace.Controls.Add(this.label18);
            this.tpSpace.Controls.Add(this.btnSpaceClearPoint);
            this.tpSpace.Controls.Add(this.ckSpacePoint);
            this.tpSpace.Controls.Add(this.ckSpaceBox);
            this.tpSpace.Controls.Add(this.btnSpaceClear);
            this.tpSpace.Controls.Add(this.btnSpaceCheck);
            this.tpSpace.Controls.Add(this.label7);
            this.tpSpace.Controls.Add(this.txtSpaceOffset);
            this.tpSpace.Controls.Add(this.label9);
            this.tpSpace.Location = new System.Drawing.Point(4, 22);
            this.tpSpace.Name = "tpSpace";
            this.tpSpace.Padding = new System.Windows.Forms.Padding(3);
            this.tpSpace.Size = new System.Drawing.Size(403, 303);
            this.tpSpace.TabIndex = 2;
            this.tpSpace.Text = "SPACE";
            this.tpSpace.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(325, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 12);
            this.label17.TabIndex = 16;
            this.label17.Text = "mm";
            // 
            // txtBaseline
            // 
            this.txtBaseline.Location = new System.Drawing.Point(261, 20);
            this.txtBaseline.Name = "txtBaseline";
            this.txtBaseline.Size = new System.Drawing.Size(58, 21);
            this.txtBaseline.TabIndex = 15;
            this.txtBaseline.Text = "79696";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(201, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 12);
            this.label18.TabIndex = 14;
            this.label18.Text = "Baseline";
            // 
            // btnSpaceClearPoint
            // 
            this.btnSpaceClearPoint.Location = new System.Drawing.Point(20, 161);
            this.btnSpaceClearPoint.Name = "btnSpaceClearPoint";
            this.btnSpaceClearPoint.Size = new System.Drawing.Size(106, 23);
            this.btnSpaceClearPoint.TabIndex = 13;
            this.btnSpaceClearPoint.Text = "Clear (POINT)";
            this.btnSpaceClearPoint.UseVisualStyleBackColor = true;
            this.btnSpaceClearPoint.Click += new System.EventHandler(this.btnSpaceClearPoint_Click);
            // 
            // ckSpacePoint
            // 
            this.ckSpacePoint.AutoSize = true;
            this.ckSpacePoint.Checked = true;
            this.ckSpacePoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSpacePoint.Location = new System.Drawing.Point(21, 78);
            this.ckSpacePoint.Name = "ckSpacePoint";
            this.ckSpacePoint.Size = new System.Drawing.Size(61, 16);
            this.ckSpacePoint.TabIndex = 12;
            this.ckSpacePoint.Text = "POINT";
            this.ckSpacePoint.UseVisualStyleBackColor = true;
            // 
            // ckSpaceBox
            // 
            this.ckSpaceBox.AutoSize = true;
            this.ckSpaceBox.Checked = true;
            this.ckSpaceBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSpaceBox.Location = new System.Drawing.Point(21, 52);
            this.ckSpaceBox.Name = "ckSpaceBox";
            this.ckSpaceBox.Size = new System.Drawing.Size(49, 16);
            this.ckSpaceBox.TabIndex = 11;
            this.ckSpaceBox.Text = "BOX";
            this.ckSpaceBox.UseVisualStyleBackColor = true;
            // 
            // btnSpaceClear
            // 
            this.btnSpaceClear.Location = new System.Drawing.Point(20, 132);
            this.btnSpaceClear.Name = "btnSpaceClear";
            this.btnSpaceClear.Size = new System.Drawing.Size(106, 23);
            this.btnSpaceClear.TabIndex = 10;
            this.btnSpaceClear.Text = "Clear (BOX)";
            this.btnSpaceClear.UseVisualStyleBackColor = true;
            this.btnSpaceClear.Click += new System.EventHandler(this.btnSpaceClear_Click);
            // 
            // btnSpaceCheck
            // 
            this.btnSpaceCheck.Location = new System.Drawing.Point(19, 103);
            this.btnSpaceCheck.Name = "btnSpaceCheck";
            this.btnSpaceCheck.Size = new System.Drawing.Size(107, 23);
            this.btnSpaceCheck.TabIndex = 9;
            this.btnSpaceCheck.Text = "Check";
            this.btnSpaceCheck.UseVisualStyleBackColor = true;
            this.btnSpaceCheck.Click += new System.EventHandler(this.btnSpaceCheck_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "mm";
            // 
            // txtSpaceOffset
            // 
            this.txtSpaceOffset.Location = new System.Drawing.Point(72, 19);
            this.txtSpaceOffset.Name = "txtSpaceOffset";
            this.txtSpaceOffset.Size = new System.Drawing.Size(58, 21);
            this.txtSpaceOffset.TabIndex = 7;
            this.txtSpaceOffset.Text = "5000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "Offset";
            // 
            // tpSupport
            // 
            this.tpSupport.Controls.Add(this.btnSuppAdd);
            this.tpSupport.Controls.Add(this.btnSuppPreview);
            this.tpSupport.Controls.Add(this.tableLayoutPanel3);
            this.tpSupport.Location = new System.Drawing.Point(4, 22);
            this.tpSupport.Name = "tpSupport";
            this.tpSupport.Padding = new System.Windows.Forms.Padding(3);
            this.tpSupport.Size = new System.Drawing.Size(403, 303);
            this.tpSupport.TabIndex = 3;
            this.tpSupport.Text = "SUPPORTER";
            this.tpSupport.UseVisualStyleBackColor = true;
            // 
            // btnSuppAdd
            // 
            this.btnSuppAdd.Location = new System.Drawing.Point(92, 200);
            this.btnSuppAdd.Name = "btnSuppAdd";
            this.btnSuppAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSuppAdd.TabIndex = 4;
            this.btnSuppAdd.Text = "Add";
            this.btnSuppAdd.UseVisualStyleBackColor = true;
            this.btnSuppAdd.Click += new System.EventHandler(this.btnSuppAdd_Click);
            // 
            // btnSuppPreview
            // 
            this.btnSuppPreview.Location = new System.Drawing.Point(11, 200);
            this.btnSuppPreview.Name = "btnSuppPreview";
            this.btnSuppPreview.Size = new System.Drawing.Size(75, 23);
            this.btnSuppPreview.TabIndex = 3;
            this.btnSuppPreview.Text = "Preview";
            this.btnSuppPreview.UseVisualStyleBackColor = true;
            this.btnSuppPreview.Click += new System.EventHandler(this.btnSuppPreview_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.txtSuppHeight, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtSuppOffsetY, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtSuppBottomX, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSuppBottomY, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtSuppTopX, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtSuppTopY, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtSuppOffsetX, 1, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(187, 174);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // txtSuppHeight
            // 
            this.txtSuppHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuppHeight.Location = new System.Drawing.Point(77, 147);
            this.txtSuppHeight.Name = "txtSuppHeight";
            this.txtSuppHeight.Size = new System.Drawing.Size(107, 21);
            this.txtSuppHeight.TabIndex = 17;
            this.txtSuppHeight.Text = "1200";
            this.txtSuppHeight.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtSuppHeight.WatermarkColor = System.Drawing.Color.Gray;
            this.txtSuppHeight.WatermarkText = "";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 30);
            this.label16.TabIndex = 16;
            this.label16.Text = "Height";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSuppOffsetY
            // 
            this.txtSuppOffsetY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuppOffsetY.Location = new System.Drawing.Point(77, 123);
            this.txtSuppOffsetY.Name = "txtSuppOffsetY";
            this.txtSuppOffsetY.Size = new System.Drawing.Size(107, 21);
            this.txtSuppOffsetY.TabIndex = 15;
            this.txtSuppOffsetY.Text = "0";
            this.txtSuppOffsetY.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtSuppOffsetY.WatermarkColor = System.Drawing.Color.Gray;
            this.txtSuppOffsetY.WatermarkText = "";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 24);
            this.label15.TabIndex = 11;
            this.label15.Text = "Offset Y";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "Bottom X";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Bottom Y";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "Top X";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 24);
            this.label13.TabIndex = 9;
            this.label13.Text = "Top Y";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "Offset X";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSuppBottomX
            // 
            this.txtSuppBottomX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuppBottomX.Location = new System.Drawing.Point(77, 3);
            this.txtSuppBottomX.Name = "txtSuppBottomX";
            this.txtSuppBottomX.Size = new System.Drawing.Size(107, 21);
            this.txtSuppBottomX.TabIndex = 4;
            this.txtSuppBottomX.Text = "800";
            this.txtSuppBottomX.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtSuppBottomX.WatermarkColor = System.Drawing.Color.Gray;
            this.txtSuppBottomX.WatermarkText = "";
            // 
            // txtSuppBottomY
            // 
            this.txtSuppBottomY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuppBottomY.Location = new System.Drawing.Point(77, 27);
            this.txtSuppBottomY.Name = "txtSuppBottomY";
            this.txtSuppBottomY.Size = new System.Drawing.Size(107, 21);
            this.txtSuppBottomY.TabIndex = 3;
            this.txtSuppBottomY.Text = "1600";
            this.txtSuppBottomY.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtSuppBottomY.WatermarkColor = System.Drawing.Color.Gray;
            this.txtSuppBottomY.WatermarkText = "";
            // 
            // txtSuppTopX
            // 
            this.txtSuppTopX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuppTopX.Location = new System.Drawing.Point(77, 51);
            this.txtSuppTopX.Name = "txtSuppTopX";
            this.txtSuppTopX.Size = new System.Drawing.Size(107, 21);
            this.txtSuppTopX.TabIndex = 12;
            this.txtSuppTopX.Text = "400";
            this.txtSuppTopX.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtSuppTopX.WatermarkColor = System.Drawing.Color.Gray;
            this.txtSuppTopX.WatermarkText = "";
            // 
            // txtSuppTopY
            // 
            this.txtSuppTopY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuppTopY.Location = new System.Drawing.Point(77, 75);
            this.txtSuppTopY.Name = "txtSuppTopY";
            this.txtSuppTopY.Size = new System.Drawing.Size(107, 21);
            this.txtSuppTopY.TabIndex = 13;
            this.txtSuppTopY.Text = "800";
            this.txtSuppTopY.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtSuppTopY.WatermarkColor = System.Drawing.Color.Gray;
            this.txtSuppTopY.WatermarkText = "";
            // 
            // txtSuppOffsetX
            // 
            this.txtSuppOffsetX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuppOffsetX.Location = new System.Drawing.Point(77, 99);
            this.txtSuppOffsetX.Name = "txtSuppOffsetX";
            this.txtSuppOffsetX.Size = new System.Drawing.Size(107, 21);
            this.txtSuppOffsetX.TabIndex = 14;
            this.txtSuppOffsetX.Text = "0";
            this.txtSuppOffsetX.TextAlignment = System.Drawing.StringAlignment.Near;
            this.txtSuppOffsetX.WatermarkColor = System.Drawing.Color.Gray;
            this.txtSuppOffsetX.WatermarkText = "";
            // 
            // tpSection
            // 
            this.tpSection.Controls.Add(this.btnSectionClear);
            this.tpSection.Controls.Add(this.ckSectionLine);
            this.tpSection.Controls.Add(this.ckSectionPlane);
            this.tpSection.Controls.Add(this.btnSectionAdd);
            this.tpSection.Location = new System.Drawing.Point(4, 22);
            this.tpSection.Name = "tpSection";
            this.tpSection.Padding = new System.Windows.Forms.Padding(3);
            this.tpSection.Size = new System.Drawing.Size(403, 303);
            this.tpSection.TabIndex = 4;
            this.tpSection.Text = "SECTION";
            this.tpSection.UseVisualStyleBackColor = true;
            // 
            // btnSectionClear
            // 
            this.btnSectionClear.Location = new System.Drawing.Point(114, 97);
            this.btnSectionClear.Name = "btnSectionClear";
            this.btnSectionClear.Size = new System.Drawing.Size(75, 23);
            this.btnSectionClear.TabIndex = 3;
            this.btnSectionClear.Text = "Clear";
            this.btnSectionClear.UseVisualStyleBackColor = true;
            this.btnSectionClear.Click += new System.EventHandler(this.btnSectionClear_Click);
            // 
            // ckSectionLine
            // 
            this.ckSectionLine.AutoSize = true;
            this.ckSectionLine.Checked = true;
            this.ckSectionLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSectionLine.Location = new System.Drawing.Point(20, 46);
            this.ckSectionLine.Name = "ckSectionLine";
            this.ckSectionLine.Size = new System.Drawing.Size(48, 16);
            this.ckSectionLine.TabIndex = 2;
            this.ckSectionLine.Text = "Line";
            this.ckSectionLine.UseVisualStyleBackColor = true;
            this.ckSectionLine.CheckedChanged += new System.EventHandler(this.ckSectionLine_CheckedChanged);
            // 
            // ckSectionPlane
            // 
            this.ckSectionPlane.AutoSize = true;
            this.ckSectionPlane.Checked = true;
            this.ckSectionPlane.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSectionPlane.Location = new System.Drawing.Point(20, 24);
            this.ckSectionPlane.Name = "ckSectionPlane";
            this.ckSectionPlane.Size = new System.Drawing.Size(56, 16);
            this.ckSectionPlane.TabIndex = 1;
            this.ckSectionPlane.Text = "Plane";
            this.ckSectionPlane.UseVisualStyleBackColor = true;
            this.ckSectionPlane.CheckedChanged += new System.EventHandler(this.ckSectionPlane_CheckedChanged);
            // 
            // btnSectionAdd
            // 
            this.btnSectionAdd.Location = new System.Drawing.Point(20, 97);
            this.btnSectionAdd.Name = "btnSectionAdd";
            this.btnSectionAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSectionAdd.TabIndex = 0;
            this.btnSectionAdd.Text = "Add";
            this.btnSectionAdd.UseVisualStyleBackColor = true;
            this.btnSectionAdd.Click += new System.EventHandler(this.btnSectionAdd_Click);
            // 
            // tpAnalysis
            // 
            this.tpAnalysis.Controls.Add(this.btnAnalysisModelHide);
            this.tpAnalysis.Controls.Add(this.btnAnalysisModelShow);
            this.tpAnalysis.Controls.Add(this.btnAnalysisMeasureXaxis);
            this.tpAnalysis.Controls.Add(this.btnAnalysisMeasureClear);
            this.tpAnalysis.Controls.Add(this.btnAnalysisModelClear);
            this.tpAnalysis.Controls.Add(this.btnAnalysisModel);
            this.tpAnalysis.Controls.Add(this.ckAnalysisMeasure);
            this.tpAnalysis.Controls.Add(this.ckAnalysisItem);
            this.tpAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tpAnalysis.Name = "tpAnalysis";
            this.tpAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnalysis.Size = new System.Drawing.Size(403, 303);
            this.tpAnalysis.TabIndex = 5;
            this.tpAnalysis.Text = "Analysis";
            this.tpAnalysis.UseVisualStyleBackColor = true;
            // 
            // btnAnalysisModelHide
            // 
            this.btnAnalysisModelHide.Location = new System.Drawing.Point(21, 219);
            this.btnAnalysisModelHide.Name = "btnAnalysisModelHide";
            this.btnAnalysisModelHide.Size = new System.Drawing.Size(99, 23);
            this.btnAnalysisModelHide.TabIndex = 7;
            this.btnAnalysisModelHide.Text = "Hide Vessel";
            this.btnAnalysisModelHide.UseVisualStyleBackColor = true;
            this.btnAnalysisModelHide.Click += new System.EventHandler(this.btnAnalysisModelHide_Click);
            // 
            // btnAnalysisModelShow
            // 
            this.btnAnalysisModelShow.Location = new System.Drawing.Point(21, 180);
            this.btnAnalysisModelShow.Name = "btnAnalysisModelShow";
            this.btnAnalysisModelShow.Size = new System.Drawing.Size(99, 23);
            this.btnAnalysisModelShow.TabIndex = 6;
            this.btnAnalysisModelShow.Text = "Show Vessel";
            this.btnAnalysisModelShow.UseVisualStyleBackColor = true;
            this.btnAnalysisModelShow.Click += new System.EventHandler(this.btnAnalysisModelShow_Click);
            // 
            // btnAnalysisMeasureXaxis
            // 
            this.btnAnalysisMeasureXaxis.Location = new System.Drawing.Point(20, 140);
            this.btnAnalysisMeasureXaxis.Name = "btnAnalysisMeasureXaxis";
            this.btnAnalysisMeasureXaxis.Size = new System.Drawing.Size(147, 23);
            this.btnAnalysisMeasureXaxis.TabIndex = 5;
            this.btnAnalysisMeasureXaxis.Text = "Add Measure X Axis.\r\n";
            this.btnAnalysisMeasureXaxis.UseVisualStyleBackColor = true;
            this.btnAnalysisMeasureXaxis.Click += new System.EventHandler(this.btnAnalysisMeasureXaxis_Click);
            // 
            // btnAnalysisMeasureClear
            // 
            this.btnAnalysisMeasureClear.Location = new System.Drawing.Point(173, 140);
            this.btnAnalysisMeasureClear.Name = "btnAnalysisMeasureClear";
            this.btnAnalysisMeasureClear.Size = new System.Drawing.Size(99, 23);
            this.btnAnalysisMeasureClear.TabIndex = 4;
            this.btnAnalysisMeasureClear.Text = "Clear Measure";
            this.btnAnalysisMeasureClear.UseVisualStyleBackColor = true;
            this.btnAnalysisMeasureClear.Click += new System.EventHandler(this.btnAnalysisMeasureClear_Click);
            // 
            // btnAnalysisModelClear
            // 
            this.btnAnalysisModelClear.Location = new System.Drawing.Point(173, 98);
            this.btnAnalysisModelClear.Name = "btnAnalysisModelClear";
            this.btnAnalysisModelClear.Size = new System.Drawing.Size(99, 23);
            this.btnAnalysisModelClear.TabIndex = 3;
            this.btnAnalysisModelClear.Text = "Clear Model";
            this.btnAnalysisModelClear.UseVisualStyleBackColor = true;
            this.btnAnalysisModelClear.Click += new System.EventHandler(this.btnAnalysisModelClear_Click);
            // 
            // btnAnalysisModel
            // 
            this.btnAnalysisModel.Location = new System.Drawing.Point(20, 98);
            this.btnAnalysisModel.Name = "btnAnalysisModel";
            this.btnAnalysisModel.Size = new System.Drawing.Size(147, 23);
            this.btnAnalysisModel.TabIndex = 2;
            this.btnAnalysisModel.Text = "Generate 3D Model";
            this.btnAnalysisModel.UseVisualStyleBackColor = true;
            this.btnAnalysisModel.Click += new System.EventHandler(this.btnAnalysisModel_Click);
            // 
            // ckAnalysisMeasure
            // 
            this.ckAnalysisMeasure.AutoSize = true;
            this.ckAnalysisMeasure.Checked = true;
            this.ckAnalysisMeasure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAnalysisMeasure.Location = new System.Drawing.Point(20, 58);
            this.ckAnalysisMeasure.Name = "ckAnalysisMeasure";
            this.ckAnalysisMeasure.Size = new System.Drawing.Size(100, 16);
            this.ckAnalysisMeasure.TabIndex = 1;
            this.ckAnalysisMeasure.Text = "Add Measure";
            this.ckAnalysisMeasure.UseVisualStyleBackColor = true;
            // 
            // ckAnalysisItem
            // 
            this.ckAnalysisItem.AutoSize = true;
            this.ckAnalysisItem.Location = new System.Drawing.Point(20, 26);
            this.ckAnalysisItem.Name = "ckAnalysisItem";
            this.ckAnalysisItem.Size = new System.Drawing.Size(240, 16);
            this.ckAnalysisItem.TabIndex = 0;
            this.ckAnalysisItem.Text = "Analyze the Selected Item (Supporter)";
            this.ckAnalysisItem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpenModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 61);
            this.groupBox1.TabIndex = 0;
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
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbSection);
            this.splitContainer2.Size = new System.Drawing.Size(645, 763);
            this.splitContainer2.SplitterDistance = 706;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbSection
            // 
            this.tbSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSection.Enabled = false;
            this.tbSection.Location = new System.Drawing.Point(0, 0);
            this.tbSection.Name = "tbSection";
            this.tbSection.Size = new System.Drawing.Size(645, 53);
            this.tbSection.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 763);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.DockBuild";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpDock.ResumeLayout(false);
            this.tpDock.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpGrid.ResumeLayout(false);
            this.tpGrid.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpSpace.ResumeLayout(false);
            this.tpSpace.PerformLayout();
            this.tpSupport.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tpSection.ResumeLayout(false);
            this.tpSection.PerformLayout();
            this.tpAnalysis.ResumeLayout(false);
            this.tpAnalysis.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbSection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TrackBar tbSection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenModel;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDock;
        private System.Windows.Forms.TabPage tpGrid;
        private System.Windows.Forms.TabPage tpSpace;
        private System.Windows.Forms.TabPage tpSupport;
        private System.Windows.Forms.TabPage tpSection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.WatermarkTextBox txtDockLength;
        private Controls.WatermarkTextBox txtDockBreadth;
        private Controls.WatermarkTextBox txtDockDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckDockSingle;
        private System.Windows.Forms.CheckBox ckDockSideAll;
        private System.Windows.Forms.TextBox txtDockOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDockGenerate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private Controls.WatermarkTextBox txtGridIntervalX;
        private Controls.WatermarkTextBox txtGridIntervalY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGridClear;
        private System.Windows.Forms.Button btnGridDraw;
        private System.Windows.Forms.Button btnDockDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSpaceOffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSpaceCheck;
        private System.Windows.Forms.CheckBox ckGridHighlightCrossPoint;
        private System.Windows.Forms.Button btnGridClearCross;
        private System.Windows.Forms.Button btnSpaceClear;
        private System.Windows.Forms.CheckBox ckSpacePoint;
        private System.Windows.Forms.CheckBox ckSpaceBox;
        private System.Windows.Forms.Button btnSpaceClearPoint;
        private System.Windows.Forms.GroupBox gbPreviewSupporter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Controls.WatermarkTextBox txtSuppBottomY;
        private Controls.WatermarkTextBox txtSuppBottomX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Controls.WatermarkTextBox txtSuppOffsetY;
        private System.Windows.Forms.Label label15;
        private Controls.WatermarkTextBox txtSuppTopX;
        private Controls.WatermarkTextBox txtSuppTopY;
        private Controls.WatermarkTextBox txtSuppOffsetX;
        private System.Windows.Forms.Button btnSuppPreview;
        private Controls.WatermarkTextBox txtSuppHeight;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSuppAdd;
        private System.Windows.Forms.Button btnSectionAdd;
        private System.Windows.Forms.CheckBox ckSectionLine;
        private System.Windows.Forms.CheckBox ckSectionPlane;
        private System.Windows.Forms.Button btnSectionClear;
        private System.Windows.Forms.TabPage tpAnalysis;
        private System.Windows.Forms.CheckBox ckAnalysisMeasure;
        private System.Windows.Forms.CheckBox ckAnalysisItem;
        private System.Windows.Forms.Button btnAnalysisModel;
        private System.Windows.Forms.Button btnAnalysisModelClear;
        private System.Windows.Forms.Button btnAnalysisMeasureClear;
        private System.Windows.Forms.Button btnAnalysisMeasureXaxis;
        private System.Windows.Forms.Button btnAnalysisModelHide;
        private System.Windows.Forms.Button btnAnalysisModelShow;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBaseline;
        private System.Windows.Forms.Label label18;
    }
}

