namespace VIZCore3D.NET.Import.WDL
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wdlTree = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckUnit = new System.Windows.Forms.CheckBox();
            this.btnMakeModel = new System.Windows.Forms.Button();
            this.btnOpenWdl = new System.Windows.Forms.Button();
            this.btnOpenModel = new System.Windows.Forms.Button();
            this.ckHighlight = new System.Windows.Forms.CheckBox();
            this.ckXray = new System.Windows.Forms.CheckBox();
            this.lvParts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMakeStage = new System.Windows.Forms.Button();
            this.btnShowStage = new System.Windows.Forms.Button();
            this.backgroundWorkerStage = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.ckHighlight);
            this.splitContainer1.Panel2.Controls.Add(this.ckXray);
            this.splitContainer1.Panel2.Controls.Add(this.lvParts);
            this.splitContainer1.Size = new System.Drawing.Size(1198, 757);
            this.splitContainer1.SplitterDistance = 530;
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
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1198, 530);
            this.splitContainer2.SplitterDistance = 475;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.wdlTree);
            this.groupBox2.Location = new System.Drawing.Point(13, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 390);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tree";
            // 
            // wdlTree
            // 
            this.wdlTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wdlTree.Location = new System.Drawing.Point(3, 17);
            this.wdlTree.Name = "wdlTree";
            this.wdlTree.Size = new System.Drawing.Size(441, 370);
            this.wdlTree.TabIndex = 0;
            this.wdlTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.wdlTree_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnShowStage);
            this.groupBox1.Controls.Add(this.btnMakeStage);
            this.groupBox1.Controls.Add(this.ckUnit);
            this.groupBox1.Controls.Add(this.btnMakeModel);
            this.groupBox1.Controls.Add(this.btnOpenWdl);
            this.groupBox1.Controls.Add(this.btnOpenModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // ckUnit
            // 
            this.ckUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckUnit.AutoSize = true;
            this.ckUnit.Location = new System.Drawing.Point(367, 34);
            this.ckUnit.Name = "ckUnit";
            this.ckUnit.Size = new System.Drawing.Size(63, 16);
            this.ckUnit.TabIndex = 3;
            this.ckUnit.Text = "Bundle";
            this.ckUnit.UseVisualStyleBackColor = true;
            // 
            // btnMakeModel
            // 
            this.btnMakeModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeModel.Location = new System.Drawing.Point(263, 30);
            this.btnMakeModel.Name = "btnMakeModel";
            this.btnMakeModel.Size = new System.Drawing.Size(98, 23);
            this.btnMakeModel.TabIndex = 2;
            this.btnMakeModel.Text = "Make Model";
            this.btnMakeModel.UseVisualStyleBackColor = true;
            this.btnMakeModel.Click += new System.EventHandler(this.btnMakeModel_Click);
            // 
            // btnOpenWdl
            // 
            this.btnOpenWdl.Location = new System.Drawing.Point(126, 30);
            this.btnOpenWdl.Name = "btnOpenWdl";
            this.btnOpenWdl.Size = new System.Drawing.Size(75, 23);
            this.btnOpenWdl.TabIndex = 1;
            this.btnOpenWdl.Text = "WDL";
            this.btnOpenWdl.UseVisualStyleBackColor = true;
            this.btnOpenWdl.Click += new System.EventHandler(this.btnOpenWdl_Click);
            // 
            // btnOpenModel
            // 
            this.btnOpenModel.Location = new System.Drawing.Point(29, 30);
            this.btnOpenModel.Name = "btnOpenModel";
            this.btnOpenModel.Size = new System.Drawing.Size(75, 23);
            this.btnOpenModel.TabIndex = 0;
            this.btnOpenModel.Text = "MODEL";
            this.btnOpenModel.UseVisualStyleBackColor = true;
            this.btnOpenModel.Click += new System.EventHandler(this.btnOpenModel_Click);
            // 
            // ckHighlight
            // 
            this.ckHighlight.AutoSize = true;
            this.ckHighlight.Location = new System.Drawing.Point(94, 16);
            this.ckHighlight.Name = "ckHighlight";
            this.ckHighlight.Size = new System.Drawing.Size(72, 16);
            this.ckHighlight.TabIndex = 2;
            this.ckHighlight.Text = "Highlight";
            this.ckHighlight.UseVisualStyleBackColor = true;
            this.ckHighlight.CheckedChanged += new System.EventHandler(this.ckHighlight_CheckedChanged);
            // 
            // ckXray
            // 
            this.ckXray.AutoSize = true;
            this.ckXray.Location = new System.Drawing.Point(26, 16);
            this.ckXray.Name = "ckXray";
            this.ckXray.Size = new System.Drawing.Size(50, 16);
            this.ckXray.TabIndex = 1;
            this.ckXray.Text = "Xray";
            this.ckXray.UseVisualStyleBackColor = true;
            this.ckXray.CheckedChanged += new System.EventHandler(this.ckXray_CheckedChanged);
            // 
            // lvParts
            // 
            this.lvParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader16,
            this.columnHeader17});
            this.lvParts.FullRowSelect = true;
            this.lvParts.GridLines = true;
            this.lvParts.HideSelection = false;
            this.lvParts.Location = new System.Drawing.Point(3, 38);
            this.lvParts.Name = "lvParts";
            this.lvParts.Size = new System.Drawing.Size(1192, 182);
            this.lvParts.TabIndex = 0;
            this.lvParts.UseCompatibleStateImageBehavior = false;
            this.lvParts.View = System.Windows.Forms.View.Details;
            this.lvParts.DoubleClick += new System.EventHandler(this.lvParts_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "소유 부재";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "접촉 부재";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "각장/두께";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "수량";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "개선";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Level Code";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 88;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "STAGE";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PR";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "방향";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "용접 자세";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 82;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "길이(mm)";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader12.Width = 85;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ACT";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "비고";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMakeStage
            // 
            this.btnMakeStage.Location = new System.Drawing.Point(29, 68);
            this.btnMakeStage.Name = "btnMakeStage";
            this.btnMakeStage.Size = new System.Drawing.Size(75, 23);
            this.btnMakeStage.TabIndex = 4;
            this.btnMakeStage.Text = "Stage 구성";
            this.btnMakeStage.UseVisualStyleBackColor = true;
            this.btnMakeStage.Click += new System.EventHandler(this.btnMakeStage_Click);
            // 
            // btnShowStage
            // 
            this.btnShowStage.Location = new System.Drawing.Point(126, 68);
            this.btnShowStage.Name = "btnShowStage";
            this.btnShowStage.Size = new System.Drawing.Size(75, 23);
            this.btnShowStage.TabIndex = 5;
            this.btnShowStage.Text = "Stage 조회";
            this.btnShowStage.UseVisualStyleBackColor = true;
            this.btnShowStage.Click += new System.EventHandler(this.btnShowStage_Click);
            // 
            // backgroundWorkerStage
            // 
            this.backgroundWorkerStage.WorkerReportsProgress = true;
            this.backgroundWorkerStage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerStage_DoWork);
            this.backgroundWorkerStage.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerStage_ProgressChanged);
            this.backgroundWorkerStage.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerStage_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 757);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Import.WDL";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenWdl;
        private System.Windows.Forms.Button btnOpenModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView wdlTree;
        private System.Windows.Forms.ListView lvParts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Button btnMakeModel;
        private System.Windows.Forms.CheckBox ckXray;
        private System.Windows.Forms.CheckBox ckHighlight;
        private System.Windows.Forms.CheckBox ckUnit;
        private System.Windows.Forms.Button btnMakeStage;
        private System.Windows.Forms.Button btnShowStage;
        private System.ComponentModel.BackgroundWorker backgroundWorkerStage;
    }
}

