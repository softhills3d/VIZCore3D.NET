namespace VIZCore3D.NET.MeshEdit
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
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.toolbarMergeBody = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMergeBodyAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMergeBodyCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarMoveVertex = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMoveVertexAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveVertexCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarMoveLine = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMoveLineAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveLineCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarMoveSurface = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMoveSurfaceAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveSurfaceCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarMoveBaseSurface = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMoveBaseSurfaceAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveBaseSurfaceCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarCutSurface = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCutSurfaceAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCutSurfaceCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarSimplify = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnSimplifyAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSimplifyCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtOsnapIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowOsnap = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ckEnableParam = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCustomAPI = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVertex5 = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.txtVertex4 = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.txtVertex3 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtVertex2 = new System.Windows.Forms.TextBox();
            this.txtVertex1 = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBodyIndex2 = new System.Windows.Forms.TextBox();
            this.txtBodyIndex1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpChildObject = new System.Windows.Forms.TabPage();
            this.dataGridNode = new System.Windows.Forms.DataGridView();
            this.tpDataEdgeLoop = new System.Windows.Forms.TabPage();
            this.txtEdgeLoop = new System.Windows.Forms.TextBox();
            this.tpOsnap = new System.Windows.Forms.TabPage();
            this.txtOsnap = new System.Windows.Forms.TextBox();
            this.tpNodeVertexChanged = new System.Windows.Forms.TabPage();
            this.txtNodeVertexChanged = new System.Windows.Forms.TextBox();
            this.tpNodeRemoved = new System.Windows.Forms.TabPage();
            this.txtNodeRemoved = new System.Windows.Forms.TextBox();
            this.tpNodeIndexChanged = new System.Windows.Forms.TabPage();
            this.txtNodeIndexChanged = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtEdgeLoopIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDrawEdgeLoop = new System.Windows.Forms.Button();
            this.rbDrawLine = new System.Windows.Forms.RadioButton();
            this.rbDrawVertex = new System.Windows.Forms.RadioButton();
            this.ckEnableXray = new System.Windows.Forms.CheckBox();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpChildObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNode)).BeginInit();
            this.tpDataEdgeLoop.SuspendLayout();
            this.tpOsnap.SuspendLayout();
            this.tpNodeVertexChanged.SuspendLayout();
            this.tpNodeRemoved.SuspendLayout();
            this.tpNodeIndexChanged.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarMergeBody,
            this.toolbarMoveVertex,
            this.toolbarMoveLine,
            this.toolbarMoveSurface,
            this.toolbarMoveBaseSurface,
            this.toolbarCutSurface,
            this.toolbarSimplify});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(1495, 25);
            this.toolbar.TabIndex = 0;
            this.toolbar.Text = "toolStrip1";
            // 
            // toolbarMergeBody
            // 
            this.toolbarMergeBody.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarMergeBody.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMergeBodyAPI,
            this.btnMergeBodyCustom});
            this.toolbarMergeBody.Image = ((System.Drawing.Image)(resources.GetObject("toolbarMergeBody.Image")));
            this.toolbarMergeBody.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarMergeBody.Name = "toolbarMergeBody";
            this.toolbarMergeBody.Size = new System.Drawing.Size(54, 22);
            this.toolbarMergeBody.Text = "Merge";
            // 
            // btnMergeBodyAPI
            // 
            this.btnMergeBodyAPI.Name = "btnMergeBodyAPI";
            this.btnMergeBodyAPI.Size = new System.Drawing.Size(116, 22);
            this.btnMergeBodyAPI.Text = "API";
            this.btnMergeBodyAPI.Click += new System.EventHandler(this.btnMergeBodyAPI_Click);
            // 
            // btnMergeBodyCustom
            // 
            this.btnMergeBodyCustom.Name = "btnMergeBodyCustom";
            this.btnMergeBodyCustom.Size = new System.Drawing.Size(116, 22);
            this.btnMergeBodyCustom.Text = "Custom";
            this.btnMergeBodyCustom.Click += new System.EventHandler(this.btnMergeBodyCustom_Click);
            // 
            // toolbarMoveVertex
            // 
            this.toolbarMoveVertex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarMoveVertex.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoveVertexAPI,
            this.btnMoveVertexCustom});
            this.toolbarMoveVertex.Image = ((System.Drawing.Image)(resources.GetObject("toolbarMoveVertex.Image")));
            this.toolbarMoveVertex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarMoveVertex.Name = "toolbarMoveVertex";
            this.toolbarMoveVertex.Size = new System.Drawing.Size(54, 22);
            this.toolbarMoveVertex.Text = "Vertex";
            // 
            // btnMoveVertexAPI
            // 
            this.btnMoveVertexAPI.Name = "btnMoveVertexAPI";
            this.btnMoveVertexAPI.Size = new System.Drawing.Size(116, 22);
            this.btnMoveVertexAPI.Text = "API";
            this.btnMoveVertexAPI.Click += new System.EventHandler(this.btnMoveVertexAPI_Click);
            // 
            // btnMoveVertexCustom
            // 
            this.btnMoveVertexCustom.Name = "btnMoveVertexCustom";
            this.btnMoveVertexCustom.Size = new System.Drawing.Size(116, 22);
            this.btnMoveVertexCustom.Text = "Custom";
            this.btnMoveVertexCustom.Click += new System.EventHandler(this.btnMoveVertexCustom_Click);
            // 
            // toolbarMoveLine
            // 
            this.toolbarMoveLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarMoveLine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoveLineAPI,
            this.btnMoveLineCustom});
            this.toolbarMoveLine.Image = ((System.Drawing.Image)(resources.GetObject("toolbarMoveLine.Image")));
            this.toolbarMoveLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarMoveLine.Name = "toolbarMoveLine";
            this.toolbarMoveLine.Size = new System.Drawing.Size(42, 22);
            this.toolbarMoveLine.Text = "Line";
            // 
            // btnMoveLineAPI
            // 
            this.btnMoveLineAPI.Name = "btnMoveLineAPI";
            this.btnMoveLineAPI.Size = new System.Drawing.Size(116, 22);
            this.btnMoveLineAPI.Text = "API";
            this.btnMoveLineAPI.Click += new System.EventHandler(this.btnMoveLineAPI_Click);
            // 
            // btnMoveLineCustom
            // 
            this.btnMoveLineCustom.Name = "btnMoveLineCustom";
            this.btnMoveLineCustom.Size = new System.Drawing.Size(116, 22);
            this.btnMoveLineCustom.Text = "Custom";
            this.btnMoveLineCustom.Click += new System.EventHandler(this.btnMoveLineCustom_Click);
            // 
            // toolbarMoveSurface
            // 
            this.toolbarMoveSurface.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarMoveSurface.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoveSurfaceAPI,
            this.btnMoveSurfaceCustom});
            this.toolbarMoveSurface.Image = ((System.Drawing.Image)(resources.GetObject("toolbarMoveSurface.Image")));
            this.toolbarMoveSurface.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarMoveSurface.Name = "toolbarMoveSurface";
            this.toolbarMoveSurface.Size = new System.Drawing.Size(60, 22);
            this.toolbarMoveSurface.Text = "Surface";
            // 
            // btnMoveSurfaceAPI
            // 
            this.btnMoveSurfaceAPI.Name = "btnMoveSurfaceAPI";
            this.btnMoveSurfaceAPI.Size = new System.Drawing.Size(116, 22);
            this.btnMoveSurfaceAPI.Text = "API";
            this.btnMoveSurfaceAPI.Click += new System.EventHandler(this.btnMoveSurfaceAPI_Click);
            // 
            // btnMoveSurfaceCustom
            // 
            this.btnMoveSurfaceCustom.Name = "btnMoveSurfaceCustom";
            this.btnMoveSurfaceCustom.Size = new System.Drawing.Size(116, 22);
            this.btnMoveSurfaceCustom.Text = "Custom";
            this.btnMoveSurfaceCustom.Click += new System.EventHandler(this.btnMoveSurfaceCustom_Click);
            // 
            // toolbarMoveBaseSurface
            // 
            this.toolbarMoveBaseSurface.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarMoveBaseSurface.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoveBaseSurfaceAPI,
            this.btnMoveBaseSurfaceCustom});
            this.toolbarMoveBaseSurface.Image = ((System.Drawing.Image)(resources.GetObject("toolbarMoveBaseSurface.Image")));
            this.toolbarMoveBaseSurface.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarMoveBaseSurface.Name = "toolbarMoveBaseSurface";
            this.toolbarMoveBaseSurface.Size = new System.Drawing.Size(88, 22);
            this.toolbarMoveBaseSurface.Text = "Base Surface";
            // 
            // btnMoveBaseSurfaceAPI
            // 
            this.btnMoveBaseSurfaceAPI.Name = "btnMoveBaseSurfaceAPI";
            this.btnMoveBaseSurfaceAPI.Size = new System.Drawing.Size(116, 22);
            this.btnMoveBaseSurfaceAPI.Text = "API";
            this.btnMoveBaseSurfaceAPI.Click += new System.EventHandler(this.btnMoveBaseSurfaceAPI_Click);
            // 
            // btnMoveBaseSurfaceCustom
            // 
            this.btnMoveBaseSurfaceCustom.Name = "btnMoveBaseSurfaceCustom";
            this.btnMoveBaseSurfaceCustom.Size = new System.Drawing.Size(116, 22);
            this.btnMoveBaseSurfaceCustom.Text = "Custom";
            this.btnMoveBaseSurfaceCustom.Click += new System.EventHandler(this.btnMoveBaseSurfaceCustom_Click);
            // 
            // toolbarCutSurface
            // 
            this.toolbarCutSurface.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarCutSurface.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCutSurfaceAPI,
            this.btnCutSurfaceCustom});
            this.toolbarCutSurface.Image = ((System.Drawing.Image)(resources.GetObject("toolbarCutSurface.Image")));
            this.toolbarCutSurface.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarCutSurface.Name = "toolbarCutSurface";
            this.toolbarCutSurface.Size = new System.Drawing.Size(83, 22);
            this.toolbarCutSurface.Text = "Cut Surface";
            // 
            // btnCutSurfaceAPI
            // 
            this.btnCutSurfaceAPI.Name = "btnCutSurfaceAPI";
            this.btnCutSurfaceAPI.Size = new System.Drawing.Size(116, 22);
            this.btnCutSurfaceAPI.Text = "API";
            this.btnCutSurfaceAPI.Click += new System.EventHandler(this.btnCutSurfaceAPI_Click);
            // 
            // btnCutSurfaceCustom
            // 
            this.btnCutSurfaceCustom.Name = "btnCutSurfaceCustom";
            this.btnCutSurfaceCustom.Size = new System.Drawing.Size(116, 22);
            this.btnCutSurfaceCustom.Text = "Custom";
            this.btnCutSurfaceCustom.Click += new System.EventHandler(this.btnCutSurfaceCustom_Click);
            // 
            // toolbarSimplify
            // 
            this.toolbarSimplify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarSimplify.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSimplifyAPI,
            this.btnSimplifyCustom});
            this.toolbarSimplify.Image = ((System.Drawing.Image)(resources.GetObject("toolbarSimplify.Image")));
            this.toolbarSimplify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarSimplify.Name = "toolbarSimplify";
            this.toolbarSimplify.Size = new System.Drawing.Size(64, 22);
            this.toolbarSimplify.Text = "Simplify";
            // 
            // btnSimplifyAPI
            // 
            this.btnSimplifyAPI.Name = "btnSimplifyAPI";
            this.btnSimplifyAPI.Size = new System.Drawing.Size(116, 22);
            this.btnSimplifyAPI.Text = "API";
            this.btnSimplifyAPI.Click += new System.EventHandler(this.btnSimplifyAPI_Click);
            // 
            // btnSimplifyCustom
            // 
            this.btnSimplifyCustom.Name = "btnSimplifyCustom";
            this.btnSimplifyCustom.Size = new System.Drawing.Size(116, 22);
            this.btnSimplifyCustom.Text = "Custom";
            this.btnSimplifyCustom.Click += new System.EventHandler(this.btnSimplifyCustom_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1495, 806);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtOsnapIndex);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.btnShowOsnap);
            this.groupBox6.Location = new System.Drawing.Point(12, 488);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(220, 105);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Osnap";
            // 
            // txtOsnapIndex
            // 
            this.txtOsnapIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOsnapIndex.Location = new System.Drawing.Point(95, 26);
            this.txtOsnapIndex.Name = "txtOsnapIndex";
            this.txtOsnapIndex.Size = new System.Drawing.Size(100, 21);
            this.txtOsnapIndex.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Index";
            // 
            // btnShowOsnap
            // 
            this.btnShowOsnap.Location = new System.Drawing.Point(27, 63);
            this.btnShowOsnap.Name = "btnShowOsnap";
            this.btnShowOsnap.Size = new System.Drawing.Size(168, 23);
            this.btnShowOsnap.TabIndex = 0;
            this.btnShowOsnap.Text = "Show Osnap";
            this.btnShowOsnap.UseVisualStyleBackColor = true;
            this.btnShowOsnap.Click += new System.EventHandler(this.btnShowOsnap_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.ckEnableParam);
            this.groupBox5.Location = new System.Drawing.Point(12, 302);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(220, 76);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Boolean";
            // 
            // ckEnableParam
            // 
            this.ckEnableParam.AutoSize = true;
            this.ckEnableParam.Location = new System.Drawing.Point(64, 33);
            this.ckEnableParam.Name = "ckEnableParam";
            this.ckEnableParam.Size = new System.Drawing.Size(63, 16);
            this.ckEnableParam.TabIndex = 0;
            this.ckEnableParam.Text = "Enable";
            this.ckEnableParam.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnCustomAPI);
            this.groupBox3.Location = new System.Drawing.Point(12, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 98);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execute";
            // 
            // btnCustomAPI
            // 
            this.btnCustomAPI.Location = new System.Drawing.Point(27, 40);
            this.btnCustomAPI.Name = "btnCustomAPI";
            this.btnCustomAPI.Size = new System.Drawing.Size(168, 23);
            this.btnCustomAPI.TabIndex = 0;
            this.btnCustomAPI.Text = "Call Custom API";
            this.btnCustomAPI.UseVisualStyleBackColor = true;
            this.btnCustomAPI.Click += new System.EventHandler(this.btnCustomAPI_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtVertex5);
            this.groupBox2.Controls.Add(this.lb5);
            this.groupBox2.Controls.Add(this.txtVertex4);
            this.groupBox2.Controls.Add(this.lb4);
            this.groupBox2.Controls.Add(this.txtVertex3);
            this.groupBox2.Controls.Add(this.lb3);
            this.groupBox2.Controls.Add(this.txtVertex2);
            this.groupBox2.Controls.Add(this.txtVertex1);
            this.groupBox2.Controls.Add(this.lb2);
            this.groupBox2.Controls.Add(this.lb1);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 184);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vertex";
            // 
            // txtVertex5
            // 
            this.txtVertex5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVertex5.Location = new System.Drawing.Point(95, 150);
            this.txtVertex5.Name = "txtVertex5";
            this.txtVertex5.Size = new System.Drawing.Size(100, 21);
            this.txtVertex5.TabIndex = 9;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(25, 153);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(23, 12);
            this.lb5.TabIndex = 8;
            this.lb5.Text = "V.5";
            // 
            // txtVertex4
            // 
            this.txtVertex4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVertex4.Location = new System.Drawing.Point(95, 118);
            this.txtVertex4.Name = "txtVertex4";
            this.txtVertex4.Size = new System.Drawing.Size(100, 21);
            this.txtVertex4.TabIndex = 7;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(25, 121);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(23, 12);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "V.4";
            // 
            // txtVertex3
            // 
            this.txtVertex3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVertex3.Location = new System.Drawing.Point(95, 88);
            this.txtVertex3.Name = "txtVertex3";
            this.txtVertex3.Size = new System.Drawing.Size(100, 21);
            this.txtVertex3.TabIndex = 5;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(25, 91);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(23, 12);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "V.3";
            // 
            // txtVertex2
            // 
            this.txtVertex2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVertex2.Location = new System.Drawing.Point(95, 57);
            this.txtVertex2.Name = "txtVertex2";
            this.txtVertex2.Size = new System.Drawing.Size(100, 21);
            this.txtVertex2.TabIndex = 3;
            // 
            // txtVertex1
            // 
            this.txtVertex1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVertex1.Location = new System.Drawing.Point(95, 26);
            this.txtVertex1.Name = "txtVertex1";
            this.txtVertex1.Size = new System.Drawing.Size(100, 21);
            this.txtVertex1.TabIndex = 2;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(25, 60);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(23, 12);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "V.2";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(25, 29);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(23, 12);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "V.1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtBodyIndex2);
            this.groupBox1.Controls.Add(this.txtBodyIndex1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Param. - Index";
            // 
            // txtBodyIndex2
            // 
            this.txtBodyIndex2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBodyIndex2.Location = new System.Drawing.Point(95, 57);
            this.txtBodyIndex2.Name = "txtBodyIndex2";
            this.txtBodyIndex2.Size = new System.Drawing.Size(100, 21);
            this.txtBodyIndex2.TabIndex = 3;
            // 
            // txtBodyIndex1
            // 
            this.txtBodyIndex1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBodyIndex1.Location = new System.Drawing.Point(95, 26);
            this.txtBodyIndex1.Name = "txtBodyIndex1";
            this.txtBodyIndex1.Size = new System.Drawing.Size(100, 21);
            this.txtBodyIndex1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Body Idx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Body Idx";
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
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Size = new System.Drawing.Size(1248, 806);
            this.splitContainer2.SplitterDistance = 631;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tcMain);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1248, 171);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpChildObject);
            this.tcMain.Controls.Add(this.tpDataEdgeLoop);
            this.tcMain.Controls.Add(this.tpOsnap);
            this.tcMain.Controls.Add(this.tpNodeVertexChanged);
            this.tcMain.Controls.Add(this.tpNodeRemoved);
            this.tcMain.Controls.Add(this.tpNodeIndexChanged);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(3, 17);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1242, 151);
            this.tcMain.TabIndex = 2;
            // 
            // tpChildObject
            // 
            this.tpChildObject.Controls.Add(this.dataGridNode);
            this.tpChildObject.Location = new System.Drawing.Point(4, 22);
            this.tpChildObject.Name = "tpChildObject";
            this.tpChildObject.Padding = new System.Windows.Forms.Padding(3);
            this.tpChildObject.Size = new System.Drawing.Size(1234, 125);
            this.tpChildObject.TabIndex = 0;
            this.tpChildObject.Text = "Object3D (Children)";
            this.tpChildObject.UseVisualStyleBackColor = true;
            // 
            // dataGridNode
            // 
            this.dataGridNode.AllowUserToAddRows = false;
            this.dataGridNode.AllowUserToDeleteRows = false;
            this.dataGridNode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridNode.Location = new System.Drawing.Point(3, 3);
            this.dataGridNode.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridNode.Name = "dataGridNode";
            this.dataGridNode.ReadOnly = true;
            this.dataGridNode.RowTemplate.Height = 34;
            this.dataGridNode.Size = new System.Drawing.Size(1228, 119);
            this.dataGridNode.TabIndex = 1;
            // 
            // tpDataEdgeLoop
            // 
            this.tpDataEdgeLoop.Controls.Add(this.txtEdgeLoop);
            this.tpDataEdgeLoop.Location = new System.Drawing.Point(4, 22);
            this.tpDataEdgeLoop.Name = "tpDataEdgeLoop";
            this.tpDataEdgeLoop.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataEdgeLoop.Size = new System.Drawing.Size(1234, 125);
            this.tpDataEdgeLoop.TabIndex = 1;
            this.tpDataEdgeLoop.Text = "Data :: Edge Loop";
            this.tpDataEdgeLoop.UseVisualStyleBackColor = true;
            // 
            // txtEdgeLoop
            // 
            this.txtEdgeLoop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEdgeLoop.Location = new System.Drawing.Point(3, 3);
            this.txtEdgeLoop.Multiline = true;
            this.txtEdgeLoop.Name = "txtEdgeLoop";
            this.txtEdgeLoop.ReadOnly = true;
            this.txtEdgeLoop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEdgeLoop.Size = new System.Drawing.Size(1228, 119);
            this.txtEdgeLoop.TabIndex = 0;
            // 
            // tpOsnap
            // 
            this.tpOsnap.Controls.Add(this.txtOsnap);
            this.tpOsnap.Location = new System.Drawing.Point(4, 22);
            this.tpOsnap.Name = "tpOsnap";
            this.tpOsnap.Padding = new System.Windows.Forms.Padding(3);
            this.tpOsnap.Size = new System.Drawing.Size(1234, 125);
            this.tpOsnap.TabIndex = 2;
            this.tpOsnap.Text = "Event :: Osnap";
            this.tpOsnap.UseVisualStyleBackColor = true;
            // 
            // txtOsnap
            // 
            this.txtOsnap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOsnap.Location = new System.Drawing.Point(3, 3);
            this.txtOsnap.Multiline = true;
            this.txtOsnap.Name = "txtOsnap";
            this.txtOsnap.ReadOnly = true;
            this.txtOsnap.Size = new System.Drawing.Size(1228, 119);
            this.txtOsnap.TabIndex = 0;
            // 
            // tpNodeVertexChanged
            // 
            this.tpNodeVertexChanged.Controls.Add(this.txtNodeVertexChanged);
            this.tpNodeVertexChanged.Location = new System.Drawing.Point(4, 22);
            this.tpNodeVertexChanged.Name = "tpNodeVertexChanged";
            this.tpNodeVertexChanged.Padding = new System.Windows.Forms.Padding(3);
            this.tpNodeVertexChanged.Size = new System.Drawing.Size(1234, 125);
            this.tpNodeVertexChanged.TabIndex = 3;
            this.tpNodeVertexChanged.Text = "Event :: NodeTreeChanged";
            this.tpNodeVertexChanged.UseVisualStyleBackColor = true;
            // 
            // txtNodeVertexChanged
            // 
            this.txtNodeVertexChanged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNodeVertexChanged.Location = new System.Drawing.Point(3, 3);
            this.txtNodeVertexChanged.Multiline = true;
            this.txtNodeVertexChanged.Name = "txtNodeVertexChanged";
            this.txtNodeVertexChanged.ReadOnly = true;
            this.txtNodeVertexChanged.Size = new System.Drawing.Size(1228, 119);
            this.txtNodeVertexChanged.TabIndex = 0;
            // 
            // tpNodeRemoved
            // 
            this.tpNodeRemoved.Controls.Add(this.txtNodeRemoved);
            this.tpNodeRemoved.Location = new System.Drawing.Point(4, 22);
            this.tpNodeRemoved.Name = "tpNodeRemoved";
            this.tpNodeRemoved.Padding = new System.Windows.Forms.Padding(3);
            this.tpNodeRemoved.Size = new System.Drawing.Size(1234, 125);
            this.tpNodeRemoved.TabIndex = 4;
            this.tpNodeRemoved.Text = "Event :: NodeRemoved";
            this.tpNodeRemoved.UseVisualStyleBackColor = true;
            // 
            // txtNodeRemoved
            // 
            this.txtNodeRemoved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNodeRemoved.Location = new System.Drawing.Point(3, 3);
            this.txtNodeRemoved.Multiline = true;
            this.txtNodeRemoved.Name = "txtNodeRemoved";
            this.txtNodeRemoved.ReadOnly = true;
            this.txtNodeRemoved.Size = new System.Drawing.Size(1228, 119);
            this.txtNodeRemoved.TabIndex = 0;
            // 
            // tpNodeIndexChanged
            // 
            this.tpNodeIndexChanged.Controls.Add(this.txtNodeIndexChanged);
            this.tpNodeIndexChanged.Location = new System.Drawing.Point(4, 22);
            this.tpNodeIndexChanged.Name = "tpNodeIndexChanged";
            this.tpNodeIndexChanged.Padding = new System.Windows.Forms.Padding(3);
            this.tpNodeIndexChanged.Size = new System.Drawing.Size(1234, 125);
            this.tpNodeIndexChanged.TabIndex = 5;
            this.tpNodeIndexChanged.Text = "Event :: NodeIndexChanged";
            this.tpNodeIndexChanged.UseVisualStyleBackColor = true;
            // 
            // txtNodeIndexChanged
            // 
            this.txtNodeIndexChanged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNodeIndexChanged.Location = new System.Drawing.Point(3, 3);
            this.txtNodeIndexChanged.Multiline = true;
            this.txtNodeIndexChanged.Name = "txtNodeIndexChanged";
            this.txtNodeIndexChanged.ReadOnly = true;
            this.txtNodeIndexChanged.Size = new System.Drawing.Size(1228, 119);
            this.txtNodeIndexChanged.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.ckEnableXray);
            this.groupBox7.Controls.Add(this.rbDrawVertex);
            this.groupBox7.Controls.Add(this.rbDrawLine);
            this.groupBox7.Controls.Add(this.txtEdgeLoopIndex);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.btnDrawEdgeLoop);
            this.groupBox7.Location = new System.Drawing.Point(12, 599);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(220, 141);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Draw Edge Loop";
            // 
            // txtEdgeLoopIndex
            // 
            this.txtEdgeLoopIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdgeLoopIndex.Location = new System.Drawing.Point(95, 26);
            this.txtEdgeLoopIndex.Name = "txtEdgeLoopIndex";
            this.txtEdgeLoopIndex.Size = new System.Drawing.Size(100, 21);
            this.txtEdgeLoopIndex.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Index";
            // 
            // btnDrawEdgeLoop
            // 
            this.btnDrawEdgeLoop.Location = new System.Drawing.Point(27, 83);
            this.btnDrawEdgeLoop.Name = "btnDrawEdgeLoop";
            this.btnDrawEdgeLoop.Size = new System.Drawing.Size(168, 23);
            this.btnDrawEdgeLoop.TabIndex = 0;
            this.btnDrawEdgeLoop.Text = "Draw";
            this.btnDrawEdgeLoop.UseVisualStyleBackColor = true;
            this.btnDrawEdgeLoop.Click += new System.EventHandler(this.btnDrawEdgeLoop_Click);
            // 
            // rbDrawLine
            // 
            this.rbDrawLine.AutoSize = true;
            this.rbDrawLine.Checked = true;
            this.rbDrawLine.Location = new System.Drawing.Point(30, 56);
            this.rbDrawLine.Name = "rbDrawLine";
            this.rbDrawLine.Size = new System.Drawing.Size(47, 16);
            this.rbDrawLine.TabIndex = 5;
            this.rbDrawLine.TabStop = true;
            this.rbDrawLine.Text = "Line";
            this.rbDrawLine.UseVisualStyleBackColor = true;
            // 
            // rbDrawVertex
            // 
            this.rbDrawVertex.AutoSize = true;
            this.rbDrawVertex.Location = new System.Drawing.Point(95, 56);
            this.rbDrawVertex.Name = "rbDrawVertex";
            this.rbDrawVertex.Size = new System.Drawing.Size(59, 16);
            this.rbDrawVertex.TabIndex = 6;
            this.rbDrawVertex.Text = "Vertex";
            this.rbDrawVertex.UseVisualStyleBackColor = true;
            // 
            // ckEnableXray
            // 
            this.ckEnableXray.AutoSize = true;
            this.ckEnableXray.Location = new System.Drawing.Point(30, 113);
            this.ckEnableXray.Name = "ckEnableXray";
            this.ckEnableXray.Size = new System.Drawing.Size(60, 16);
            this.ckEnableXray.TabIndex = 7;
            this.ckEnableXray.Text = "X-Ray";
            this.ckEnableXray.UseVisualStyleBackColor = true;
            this.ckEnableXray.CheckedChanged += new System.EventHandler(this.ckEnableXray_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 831);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.MeshEdit";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpChildObject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNode)).EndInit();
            this.tpDataEdgeLoop.ResumeLayout(false);
            this.tpDataEdgeLoop.PerformLayout();
            this.tpOsnap.ResumeLayout(false);
            this.tpOsnap.PerformLayout();
            this.tpNodeVertexChanged.ResumeLayout(false);
            this.tpNodeVertexChanged.PerformLayout();
            this.tpNodeRemoved.ResumeLayout(false);
            this.tpNodeRemoved.PerformLayout();
            this.tpNodeIndexChanged.ResumeLayout(false);
            this.tpNodeIndexChanged.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripDropDownButton toolbarMergeBody;
        private System.Windows.Forms.ToolStripMenuItem btnMergeBodyAPI;
        private System.Windows.Forms.ToolStripMenuItem btnMergeBodyCustom;
        private System.Windows.Forms.ToolStripDropDownButton toolbarMoveVertex;
        private System.Windows.Forms.ToolStripMenuItem btnMoveVertexAPI;
        private System.Windows.Forms.ToolStripMenuItem btnMoveVertexCustom;
        private System.Windows.Forms.ToolStripDropDownButton toolbarMoveLine;
        private System.Windows.Forms.ToolStripMenuItem btnMoveLineAPI;
        private System.Windows.Forms.ToolStripMenuItem btnMoveLineCustom;
        private System.Windows.Forms.ToolStripDropDownButton toolbarMoveSurface;
        private System.Windows.Forms.ToolStripMenuItem btnMoveSurfaceAPI;
        private System.Windows.Forms.ToolStripMenuItem btnMoveSurfaceCustom;
        private System.Windows.Forms.ToolStripDropDownButton toolbarMoveBaseSurface;
        private System.Windows.Forms.ToolStripMenuItem btnMoveBaseSurfaceAPI;
        private System.Windows.Forms.ToolStripMenuItem btnMoveBaseSurfaceCustom;
        private System.Windows.Forms.ToolStripDropDownButton toolbarSimplify;
        private System.Windows.Forms.ToolStripMenuItem btnSimplifyAPI;
        private System.Windows.Forms.ToolStripMenuItem btnSimplifyCustom;
        private System.Windows.Forms.ToolStripDropDownButton toolbarCutSurface;
        private System.Windows.Forms.ToolStripMenuItem btnCutSurfaceAPI;
        private System.Windows.Forms.ToolStripMenuItem btnCutSurfaceCustom;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBodyIndex2;
        private System.Windows.Forms.TextBox txtBodyIndex1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVertex2;
        private System.Windows.Forms.TextBox txtVertex1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtVertex5;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.TextBox txtVertex4;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txtVertex3;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCustomAPI;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridNode;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckEnableParam;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpChildObject;
        private System.Windows.Forms.TabPage tpDataEdgeLoop;
        private System.Windows.Forms.TextBox txtEdgeLoop;
        private System.Windows.Forms.TabPage tpOsnap;
        private System.Windows.Forms.TextBox txtOsnap;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtOsnapIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowOsnap;
        private System.Windows.Forms.TabPage tpNodeVertexChanged;
        private System.Windows.Forms.TextBox txtNodeVertexChanged;
        private System.Windows.Forms.TabPage tpNodeRemoved;
        private System.Windows.Forms.TextBox txtNodeRemoved;
        private System.Windows.Forms.TabPage tpNodeIndexChanged;
        private System.Windows.Forms.TextBox txtNodeIndexChanged;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbDrawVertex;
        private System.Windows.Forms.RadioButton rbDrawLine;
        private System.Windows.Forms.TextBox txtEdgeLoopIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDrawEdgeLoop;
        private System.Windows.Forms.CheckBox ckEnableXray;
    }
}

