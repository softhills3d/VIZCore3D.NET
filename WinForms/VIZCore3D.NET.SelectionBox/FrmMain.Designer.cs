﻿namespace VIZCore3D.NET.SelectionBox
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Item 1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Item 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Item 3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Item 4");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtSelectionBoxID = new System.Windows.Forms.TextBox();
            this.btnGetItemByScreenPosition = new System.Windows.Forms.Button();
            this.txtScreenY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtScreenX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMoveCenter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSetCustomContextMenu = new System.Windows.Forms.Button();
            this.ckControllerZ = new System.Windows.Forms.CheckBox();
            this.ckControllerY = new System.Windows.Forms.CheckBox();
            this.ckControllerX = new System.Windows.Forms.CheckBox();
            this.ckMouseSelection = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTransparency = new System.Windows.Forms.TextBox();
            this.ckTransparency = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSelectedLineColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelectedFaceColor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFaceColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportVIZ = new System.Windows.Forms.Button();
            this.tabSelectionBox = new System.Windows.Forms.TabControl();
            this.tpItems = new System.Windows.Forms.TabPage();
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpDrag = new System.Windows.Forms.TabPage();
            this.lvDragItem = new System.Windows.Forms.ListView();
            this.chDragItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHideLabel = new System.Windows.Forms.Button();
            this.btnShowLabel = new System.Windows.Forms.Button();
            this.btnHideAll = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportGrid = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCountZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtItemCount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ckFullyContained = new System.Windows.Forms.CheckBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.contextMenuSelectionBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cxSelectionBoxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportGridXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSelectionBox.SuspendLayout();
            this.tpItems.SuspendLayout();
            this.tpDrag.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.contextMenuSelectionBox.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1368, 845);
            this.splitContainer1.SplitterDistance = 456;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.txtSelectionBoxID);
            this.groupBox7.Controls.Add(this.btnGetItemByScreenPosition);
            this.groupBox7.Controls.Add(this.txtScreenY);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.txtScreenX);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Location = new System.Drawing.Point(12, 365);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(432, 56);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hit Test";
            // 
            // txtSelectionBoxID
            // 
            this.txtSelectionBoxID.Location = new System.Drawing.Point(277, 24);
            this.txtSelectionBoxID.Name = "txtSelectionBoxID";
            this.txtSelectionBoxID.ReadOnly = true;
            this.txtSelectionBoxID.Size = new System.Drawing.Size(60, 21);
            this.txtSelectionBoxID.TabIndex = 5;
            // 
            // btnGetItemByScreenPosition
            // 
            this.btnGetItemByScreenPosition.Location = new System.Drawing.Point(217, 22);
            this.btnGetItemByScreenPosition.Name = "btnGetItemByScreenPosition";
            this.btnGetItemByScreenPosition.Size = new System.Drawing.Size(49, 23);
            this.btnGetItemByScreenPosition.TabIndex = 4;
            this.btnGetItemByScreenPosition.Text = "Get";
            this.btnGetItemByScreenPosition.UseVisualStyleBackColor = true;
            this.btnGetItemByScreenPosition.Click += new System.EventHandler(this.btnGetItemByScreenPosition_Click);
            // 
            // txtScreenY
            // 
            this.txtScreenY.Location = new System.Drawing.Point(142, 24);
            this.txtScreenY.Name = "txtScreenY";
            this.txtScreenY.Size = new System.Drawing.Size(65, 21);
            this.txtScreenY.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "Y";
            // 
            // txtScreenX
            // 
            this.txtScreenX.Location = new System.Drawing.Point(45, 24);
            this.txtScreenX.Name = "txtScreenX";
            this.txtScreenX.Size = new System.Drawing.Size(65, 21);
            this.txtScreenX.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "X";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnMoveCenter);
            this.groupBox5.Location = new System.Drawing.Point(12, 303);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 56);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selected Item";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(138, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMoveCenter
            // 
            this.btnMoveCenter.Location = new System.Drawing.Point(28, 26);
            this.btnMoveCenter.Name = "btnMoveCenter";
            this.btnMoveCenter.Size = new System.Drawing.Size(102, 23);
            this.btnMoveCenter.TabIndex = 0;
            this.btnMoveCenter.Text = "Move Center";
            this.btnMoveCenter.UseVisualStyleBackColor = true;
            this.btnMoveCenter.Click += new System.EventHandler(this.btnMoveCenter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnSetCustomContextMenu);
            this.groupBox4.Controls.Add(this.ckControllerZ);
            this.groupBox4.Controls.Add(this.ckControllerY);
            this.groupBox4.Controls.Add(this.ckControllerX);
            this.groupBox4.Controls.Add(this.ckMouseSelection);
            this.groupBox4.Location = new System.Drawing.Point(12, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 50);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Option";
            // 
            // btnSetCustomContextMenu
            // 
            this.btnSetCustomContextMenu.Location = new System.Drawing.Point(289, 16);
            this.btnSetCustomContextMenu.Name = "btnSetCustomContextMenu";
            this.btnSetCustomContextMenu.Size = new System.Drawing.Size(128, 23);
            this.btnSetCustomContextMenu.TabIndex = 4;
            this.btnSetCustomContextMenu.Text = "Custom Menu";
            this.btnSetCustomContextMenu.UseVisualStyleBackColor = true;
            this.btnSetCustomContextMenu.Click += new System.EventHandler(this.btnSetCustomContextMenu_Click);
            // 
            // ckControllerZ
            // 
            this.ckControllerZ.AutoSize = true;
            this.ckControllerZ.Checked = true;
            this.ckControllerZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckControllerZ.Location = new System.Drawing.Point(251, 20);
            this.ckControllerZ.Name = "ckControllerZ";
            this.ckControllerZ.Size = new System.Drawing.Size(32, 16);
            this.ckControllerZ.TabIndex = 3;
            this.ckControllerZ.Text = "Z";
            this.ckControllerZ.UseVisualStyleBackColor = true;
            this.ckControllerZ.CheckedChanged += new System.EventHandler(this.ckControllerZ_CheckedChanged);
            // 
            // ckControllerY
            // 
            this.ckControllerY.AutoSize = true;
            this.ckControllerY.Checked = true;
            this.ckControllerY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckControllerY.Location = new System.Drawing.Point(213, 20);
            this.ckControllerY.Name = "ckControllerY";
            this.ckControllerY.Size = new System.Drawing.Size(32, 16);
            this.ckControllerY.TabIndex = 2;
            this.ckControllerY.Text = "Y";
            this.ckControllerY.UseVisualStyleBackColor = true;
            this.ckControllerY.CheckedChanged += new System.EventHandler(this.ckControllerY_CheckedChanged);
            // 
            // ckControllerX
            // 
            this.ckControllerX.AutoSize = true;
            this.ckControllerX.Checked = true;
            this.ckControllerX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckControllerX.Location = new System.Drawing.Point(175, 20);
            this.ckControllerX.Name = "ckControllerX";
            this.ckControllerX.Size = new System.Drawing.Size(32, 16);
            this.ckControllerX.TabIndex = 1;
            this.ckControllerX.Text = "X";
            this.ckControllerX.UseVisualStyleBackColor = true;
            this.ckControllerX.CheckedChanged += new System.EventHandler(this.ckControllerX_CheckedChanged);
            // 
            // ckMouseSelection
            // 
            this.ckMouseSelection.AutoSize = true;
            this.ckMouseSelection.Location = new System.Drawing.Point(44, 20);
            this.ckMouseSelection.Name = "ckMouseSelection";
            this.ckMouseSelection.Size = new System.Drawing.Size(119, 16);
            this.ckMouseSelection.TabIndex = 0;
            this.ckMouseSelection.Text = "Mouse Selection";
            this.ckMouseSelection.UseVisualStyleBackColor = true;
            this.ckMouseSelection.CheckedChanged += new System.EventHandler(this.ckMouseSelection_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtTransparency);
            this.groupBox3.Controls.Add(this.ckTransparency);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnSelectedLineColor);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnSelectedFaceColor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbFontSize);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnFontColor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnLineColor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnFaceColor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 162);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Style";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "(0~100)";
            // 
            // txtTransparency
            // 
            this.txtTransparency.Location = new System.Drawing.Point(155, 132);
            this.txtTransparency.Name = "txtTransparency";
            this.txtTransparency.Size = new System.Drawing.Size(100, 21);
            this.txtTransparency.TabIndex = 14;
            this.txtTransparency.Text = "70";
            // 
            // ckTransparency
            // 
            this.ckTransparency.AutoSize = true;
            this.ckTransparency.Checked = true;
            this.ckTransparency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTransparency.Location = new System.Drawing.Point(44, 135);
            this.ckTransparency.Name = "ckTransparency";
            this.ckTransparency.Size = new System.Drawing.Size(103, 16);
            this.ckTransparency.TabIndex = 13;
            this.ckTransparency.Text = "Transparency";
            this.ckTransparency.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "Selected";
            // 
            // btnSelectedLineColor
            // 
            this.btnSelectedLineColor.Location = new System.Drawing.Point(302, 95);
            this.btnSelectedLineColor.Name = "btnSelectedLineColor";
            this.btnSelectedLineColor.Size = new System.Drawing.Size(75, 23);
            this.btnSelectedLineColor.TabIndex = 11;
            this.btnSelectedLineColor.Text = "Color";
            this.btnSelectedLineColor.UseVisualStyleBackColor = true;
            this.btnSelectedLineColor.Click += new System.EventHandler(this.btnSelectedLineColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "Line Color";
            // 
            // btnSelectedFaceColor
            // 
            this.btnSelectedFaceColor.Location = new System.Drawing.Point(116, 95);
            this.btnSelectedFaceColor.Name = "btnSelectedFaceColor";
            this.btnSelectedFaceColor.Size = new System.Drawing.Size(75, 23);
            this.btnSelectedFaceColor.TabIndex = 9;
            this.btnSelectedFaceColor.Text = "Color";
            this.btnSelectedFaceColor.UseVisualStyleBackColor = true;
            this.btnSelectedFaceColor.Click += new System.EventHandler(this.btnSelectedFaceColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "Face Color";
            // 
            // cbFontSize
            // 
            this.cbFontSize.FormattingEnabled = true;
            this.cbFontSize.Items.AddRange(new object[] {
            "12",
            "14",
            "24",
            "40",
            "52"});
            this.cbFontSize.Location = new System.Drawing.Point(302, 51);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(75, 20);
            this.cbFontSize.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Font Size";
            // 
            // btnFontColor
            // 
            this.btnFontColor.Location = new System.Drawing.Point(116, 49);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(75, 23);
            this.btnFontColor.TabIndex = 5;
            this.btnFontColor.Text = "Color";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Font Color";
            // 
            // btnLineColor
            // 
            this.btnLineColor.Location = new System.Drawing.Point(302, 20);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(75, 23);
            this.btnLineColor.TabIndex = 3;
            this.btnLineColor.Text = "Color";
            this.btnLineColor.UseVisualStyleBackColor = true;
            this.btnLineColor.Click += new System.EventHandler(this.btnLineColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Line Color";
            // 
            // btnFaceColor
            // 
            this.btnFaceColor.Location = new System.Drawing.Point(116, 20);
            this.btnFaceColor.Name = "btnFaceColor";
            this.btnFaceColor.Size = new System.Drawing.Size(75, 23);
            this.btnFaceColor.TabIndex = 1;
            this.btnFaceColor.Text = "Color";
            this.btnFaceColor.UseVisualStyleBackColor = true;
            this.btnFaceColor.Click += new System.EventHandler(this.btnFaceColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Face Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnExportVIZ);
            this.groupBox2.Controls.Add(this.tabSelectionBox);
            this.groupBox2.Controls.Add(this.btnHideLabel);
            this.groupBox2.Controls.Add(this.btnShowLabel);
            this.groupBox2.Controls.Add(this.btnHideAll);
            this.groupBox2.Controls.Add(this.btnShowAll);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Location = new System.Drawing.Point(12, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // btnExportVIZ
            // 
            this.btnExportVIZ.Location = new System.Drawing.Point(259, 20);
            this.btnExportVIZ.Name = "btnExportVIZ";
            this.btnExportVIZ.Size = new System.Drawing.Size(81, 23);
            this.btnExportVIZ.TabIndex = 7;
            this.btnExportVIZ.Text = "Export VIZ";
            this.btnExportVIZ.UseVisualStyleBackColor = true;
            this.btnExportVIZ.Click += new System.EventHandler(this.btnExportVIZ_Click);
            // 
            // tabSelectionBox
            // 
            this.tabSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectionBox.Controls.Add(this.tpItems);
            this.tabSelectionBox.Controls.Add(this.tpDrag);
            this.tabSelectionBox.Location = new System.Drawing.Point(7, 93);
            this.tabSelectionBox.Name = "tabSelectionBox";
            this.tabSelectionBox.SelectedIndex = 0;
            this.tabSelectionBox.Size = new System.Drawing.Size(419, 307);
            this.tabSelectionBox.TabIndex = 6;
            // 
            // tpItems
            // 
            this.tpItems.Controls.Add(this.lvList);
            this.tpItems.Location = new System.Drawing.Point(4, 22);
            this.tpItems.Name = "tpItems";
            this.tpItems.Padding = new System.Windows.Forms.Padding(3);
            this.tpItems.Size = new System.Drawing.Size(411, 281);
            this.tpItems.TabIndex = 0;
            this.tpItems.Text = "Items";
            this.tpItems.UseVisualStyleBackColor = true;
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(3, 3);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(405, 275);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.Click += new System.EventHandler(this.lvList_Click);
            this.lvList.DoubleClick += new System.EventHandler(this.lvList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TITLE";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LABEL";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MIN";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MAX";
            // 
            // tpDrag
            // 
            this.tpDrag.Controls.Add(this.lvDragItem);
            this.tpDrag.Location = new System.Drawing.Point(4, 22);
            this.tpDrag.Name = "tpDrag";
            this.tpDrag.Padding = new System.Windows.Forms.Padding(3);
            this.tpDrag.Size = new System.Drawing.Size(411, 281);
            this.tpDrag.TabIndex = 1;
            this.tpDrag.Text = "Drag Test";
            this.tpDrag.UseVisualStyleBackColor = true;
            // 
            // lvDragItem
            // 
            this.lvDragItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDragItem});
            this.lvDragItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDragItem.FullRowSelect = true;
            this.lvDragItem.GridLines = true;
            this.lvDragItem.HideSelection = false;
            this.lvDragItem.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvDragItem.Location = new System.Drawing.Point(3, 3);
            this.lvDragItem.Name = "lvDragItem";
            this.lvDragItem.Size = new System.Drawing.Size(405, 275);
            this.lvDragItem.TabIndex = 0;
            this.lvDragItem.UseCompatibleStateImageBehavior = false;
            this.lvDragItem.View = System.Windows.Forms.View.Details;
            this.lvDragItem.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvDragItem_ItemDrag);
            // 
            // chDragItem
            // 
            this.chDragItem.Text = "Item";
            this.chDragItem.Width = 150;
            // 
            // btnHideLabel
            // 
            this.btnHideLabel.Location = new System.Drawing.Point(108, 49);
            this.btnHideLabel.Name = "btnHideLabel";
            this.btnHideLabel.Size = new System.Drawing.Size(80, 23);
            this.btnHideLabel.TabIndex = 5;
            this.btnHideLabel.Text = "Hide Label";
            this.btnHideLabel.UseVisualStyleBackColor = true;
            this.btnHideLabel.Click += new System.EventHandler(this.btnHideLabel_Click);
            // 
            // btnShowLabel
            // 
            this.btnShowLabel.Location = new System.Drawing.Point(108, 20);
            this.btnShowLabel.Name = "btnShowLabel";
            this.btnShowLabel.Size = new System.Drawing.Size(80, 23);
            this.btnShowLabel.TabIndex = 4;
            this.btnShowLabel.Text = "Show Label";
            this.btnShowLabel.UseVisualStyleBackColor = true;
            this.btnShowLabel.Click += new System.EventHandler(this.btnShowLabel_Click);
            // 
            // btnHideAll
            // 
            this.btnHideAll.Location = new System.Drawing.Point(11, 49);
            this.btnHideAll.Name = "btnHideAll";
            this.btnHideAll.Size = new System.Drawing.Size(75, 23);
            this.btnHideAll.TabIndex = 3;
            this.btnHideAll.Text = "Hide All";
            this.btnHideAll.UseVisualStyleBackColor = true;
            this.btnHideAll.Click += new System.EventHandler(this.btnHideAll_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(11, 20);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnExportGridXml);
            this.groupBox1.Controls.Add(this.btnExportGrid);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtCountZ);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCountY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCountX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "자동 분할";
            // 
            // btnExportGrid
            // 
            this.btnExportGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportGrid.Location = new System.Drawing.Point(302, 27);
            this.btnExportGrid.Name = "btnExportGrid";
            this.btnExportGrid.Size = new System.Drawing.Size(45, 23);
            this.btnExportGrid.TabIndex = 7;
            this.btnExportGrid.Text = "Grid";
            this.btnExportGrid.UseVisualStyleBackColor = true;
            this.btnExportGrid.Click += new System.EventHandler(this.btnExportGrid_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(197, 27);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(58, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCountZ
            // 
            this.txtCountZ.Location = new System.Drawing.Point(162, 29);
            this.txtCountZ.Name = "txtCountZ";
            this.txtCountZ.Size = new System.Drawing.Size(30, 21);
            this.txtCountZ.TabIndex = 5;
            this.txtCountZ.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Z";
            // 
            // txtCountY
            // 
            this.txtCountY.Location = new System.Drawing.Point(104, 29);
            this.txtCountY.Name = "txtCountY";
            this.txtCountY.Size = new System.Drawing.Size(30, 21);
            this.txtCountY.TabIndex = 3;
            this.txtCountY.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // txtCountX
            // 
            this.txtCountX.Location = new System.Drawing.Point(45, 29);
            this.txtCountX.Name = "txtCountX";
            this.txtCountX.Size = new System.Drawing.Size(30, 21);
            this.txtCountX.TabIndex = 1;
            this.txtCountX.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
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
            this.splitContainer2.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer2.Size = new System.Drawing.Size(908, 845);
            this.splitContainer2.SplitterDistance = 670;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtItemCount);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.ckFullyContained);
            this.groupBox6.Controls.Add(this.dgView);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(908, 171);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Item";
            // 
            // txtItemCount
            // 
            this.txtItemCount.Location = new System.Drawing.Point(230, 18);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.ReadOnly = true;
            this.txtItemCount.Size = new System.Drawing.Size(100, 21);
            this.txtItemCount.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(146, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "Item Count : ";
            // 
            // ckFullyContained
            // 
            this.ckFullyContained.AutoSize = true;
            this.ckFullyContained.Checked = true;
            this.ckFullyContained.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckFullyContained.Location = new System.Drawing.Point(6, 20);
            this.ckFullyContained.Name = "ckFullyContained";
            this.ckFullyContained.Size = new System.Drawing.Size(112, 16);
            this.ckFullyContained.TabIndex = 1;
            this.ckFullyContained.Text = "Fully Contained";
            this.ckFullyContained.UseVisualStyleBackColor = true;
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(3, 43);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowTemplate.Height = 23;
            this.dgView.Size = new System.Drawing.Size(902, 125);
            this.dgView.TabIndex = 0;
            // 
            // contextMenuSelectionBox
            // 
            this.contextMenuSelectionBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cxSelectionBoxDelete});
            this.contextMenuSelectionBox.Name = "contextMenuSelectionBox";
            this.contextMenuSelectionBox.Size = new System.Drawing.Size(147, 26);
            // 
            // cxSelectionBoxDelete
            // 
            this.cxSelectionBoxDelete.Name = "cxSelectionBoxDelete";
            this.cxSelectionBoxDelete.Size = new System.Drawing.Size(146, 22);
            this.cxSelectionBoxDelete.Text = "(커스텀) 삭제";
            this.cxSelectionBoxDelete.Click += new System.EventHandler(this.cxSelectionBoxDelete_Click);
            // 
            // btnExportGridXml
            // 
            this.btnExportGridXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportGridXml.Location = new System.Drawing.Point(353, 27);
            this.btnExportGridXml.Name = "btnExportGridXml";
            this.btnExportGridXml.Size = new System.Drawing.Size(69, 23);
            this.btnExportGridXml.TabIndex = 8;
            this.btnExportGridXml.Text = "Grid XML";
            this.btnExportGridXml.UseVisualStyleBackColor = true;
            this.btnExportGridXml.Click += new System.EventHandler(this.btnExportGridXml_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 845);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.SelectionBox";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabSelectionBox.ResumeLayout(false);
            this.tpItems.ResumeLayout(false);
            this.tpDrag.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.contextMenuSelectionBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCountZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbFontSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFaceColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckMouseSelection;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnMoveCenter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHideAll;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSelectedLineColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectedFaceColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckTransparency;
        private System.Windows.Forms.TextBox txtTransparency;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHideLabel;
        private System.Windows.Forms.Button btnShowLabel;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.CheckBox ckControllerZ;
        private System.Windows.Forms.CheckBox ckControllerY;
        private System.Windows.Forms.CheckBox ckControllerX;
        private System.Windows.Forms.ContextMenuStrip contextMenuSelectionBox;
        private System.Windows.Forms.ToolStripMenuItem cxSelectionBoxDelete;
        private System.Windows.Forms.Button btnSetCustomContextMenu;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtSelectionBoxID;
        private System.Windows.Forms.Button btnGetItemByScreenPosition;
        private System.Windows.Forms.TextBox txtScreenY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtScreenX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ckFullyContained;
        private System.Windows.Forms.TextBox txtItemCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl tabSelectionBox;
        private System.Windows.Forms.TabPage tpItems;
        private System.Windows.Forms.TabPage tpDrag;
        private System.Windows.Forms.ListView lvDragItem;
        private System.Windows.Forms.ColumnHeader chDragItem;
        private System.Windows.Forms.Button btnExportGrid;
        private System.Windows.Forms.Button btnExportVIZ;
        private System.Windows.Forms.Button btnExportGridXml;
    }
}

