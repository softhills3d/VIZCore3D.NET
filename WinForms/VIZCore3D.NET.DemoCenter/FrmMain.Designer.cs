namespace VIZCore3D.NET.DemoCenter
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Lightweight");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Export Node");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Attribute (UDA) V1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Attribute (UDA) V2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Comparison");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Structure");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Structure / Thumbnail (Node)");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Thumbnail V1");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Thumbnail V2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Model", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Disassembly");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Geometry Property");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Group");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("O(Object) SNAP");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Painting");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Search");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Space Search");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Objects in Zone");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Object3D", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Capture Image");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Mini View");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("2D Projection");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Shortest Distance");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("View", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Note");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("SnapShot");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("UserView");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Review", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Clash Test");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Avatar Path");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Walkthrough", new System.Windows.Forms.TreeNode[] {
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Block Animation");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Animation", new System.Windows.Forms.TreeNode[] {
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("WDL");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Import External Data", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("3D Dashboard");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Real-time shape creation", new System.Windows.Forms.TreeNode[] {
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Divide / Group");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Drag & Drop");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Selection Box", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("PMI");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Custom Drawing");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Block Arrangement");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Etc.", new System.Windows.Forms.TreeNode[] {
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("VIZCore3D.NET", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode20,
            treeNode25,
            treeNode29,
            treeNode30,
            treeNode32,
            treeNode34,
            treeNode36,
            treeNode38,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode45});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvHierarchy = new System.Windows.Forms.TreeView();
            this.imgTreeNode = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnYouTube = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtContents = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbAPI = new System.Windows.Forms.Label();
            this.lvAPI = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1509, 809);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tvHierarchy);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 785);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hierarchy";
            // 
            // tvHierarchy
            // 
            this.tvHierarchy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvHierarchy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvHierarchy.ImageIndex = 0;
            this.tvHierarchy.ImageList = this.imgTreeNode;
            this.tvHierarchy.Location = new System.Drawing.Point(3, 22);
            this.tvHierarchy.Name = "tvHierarchy";
            treeNode1.Name = "Lightweight";
            treeNode1.Tag = "VIZCore3D.NET.ToVIZ";
            treeNode1.Text = "Lightweight";
            treeNode2.Name = "Export Node";
            treeNode2.Tag = "VIZCore3D.NET.ExportNode";
            treeNode2.Text = "Export Node";
            treeNode3.Name = "Attribute (UDA) V1";
            treeNode3.Tag = "VIZCore3D.NET.UDA";
            treeNode3.Text = "Attribute (UDA) V1";
            treeNode4.Name = "Attribute (UDA) V2";
            treeNode4.Tag = "VIZCore3D.NET.ImportAttribute";
            treeNode4.Text = "Attribute (UDA) V2";
            treeNode5.Name = "Comparison";
            treeNode5.Tag = "VIZCore3D.NET.ModelComparison";
            treeNode5.Text = "Comparison";
            treeNode6.Name = "Structure";
            treeNode6.Tag = "VIZCore3D.NET.Structure";
            treeNode6.Text = "Structure";
            treeNode7.Name = "Structure / Thumbnail (Node)";
            treeNode7.Tag = "VIZCore3D.NET.StructureThumbnail";
            treeNode7.Text = "Structure / Thumbnail (Node)";
            treeNode8.Name = "Thumbnail V1";
            treeNode8.Tag = "VIZCore3D.NET.Thumbnail";
            treeNode8.Text = "Thumbnail V1";
            treeNode9.Name = "Thumbnail V2";
            treeNode9.Tag = "VIZCore3D.NET.GenerateThumbnail";
            treeNode9.Text = "Thumbnail V2";
            treeNode10.Name = "Model";
            treeNode10.Text = "Model";
            treeNode11.Name = "Node";
            treeNode11.Tag = "VIZCore3D.NET.NodeDetail";
            treeNode11.Text = "Node";
            treeNode12.Name = "Disassembly";
            treeNode12.Tag = "VIZCore3D.NET.Disassembly";
            treeNode12.Text = "Disassembly";
            treeNode13.Name = "Geometry Property";
            treeNode13.Tag = "VIZCore3D.NET.GeometryProperty";
            treeNode13.Text = "Geometry Property";
            treeNode14.Name = "Group";
            treeNode14.Tag = "VIZCore3D.NET.Group";
            treeNode14.Text = "Group";
            treeNode15.Name = "O(Object) SNAP";
            treeNode15.Tag = "VIZCore3D.NET.Osnap";
            treeNode15.Text = "O(Object) SNAP";
            treeNode16.Name = "Painting";
            treeNode16.Tag = "VIZCore3D.NET.Painting";
            treeNode16.Text = "Painting";
            treeNode17.Name = "Search";
            treeNode17.Tag = "VIZCore3D.NET.Search";
            treeNode17.Text = "Search";
            treeNode18.Name = "Space Search";
            treeNode18.Tag = "VIZCore3D.NET.SpaceSearch";
            treeNode18.Text = "Space Search";
            treeNode19.Name = "Objects in Zone";
            treeNode19.Tag = "VIZCore3D.NET.ZoneObjects";
            treeNode19.Text = "Objects in Zone";
            treeNode20.Name = "Object3D";
            treeNode20.Text = "Object3D";
            treeNode21.Name = "Capture Image";
            treeNode21.Tag = "VIZCore3D.NET.CaptureImage";
            treeNode21.Text = "Capture Image";
            treeNode22.Name = "Mini View";
            treeNode22.Tag = "VIZCore3D.NET.MiniView";
            treeNode22.Text = "Mini View";
            treeNode23.Name = "2D Projection";
            treeNode23.Tag = "VIZCore3D.NET.Projection2D";
            treeNode23.Text = "2D Projection";
            treeNode24.Name = "Shortest Distance";
            treeNode24.Tag = "VIZCore3D.NET.ShortestDistance";
            treeNode24.Text = "Shortest Distance";
            treeNode25.Name = "View";
            treeNode25.Text = "View";
            treeNode26.Name = "Note";
            treeNode26.Tag = "VIZCore3D.NET.Note";
            treeNode26.Text = "Note";
            treeNode27.Name = "SnapShot";
            treeNode27.Tag = "VIZCore3D.NET.Snapshot";
            treeNode27.Text = "SnapShot";
            treeNode28.Name = "UserView";
            treeNode28.Tag = "VIZCore3D.NET.UserView";
            treeNode28.Text = "UserView";
            treeNode29.Name = "Review";
            treeNode29.Text = "Review";
            treeNode30.Name = "Clash Test";
            treeNode30.Tag = "VIZCore3D.NET.ClashTest";
            treeNode30.Text = "Clash Test";
            treeNode31.Name = "Avatar Path";
            treeNode31.Tag = "VIZCore3D.NET.AvatarPath";
            treeNode31.Text = "Avatar Path";
            treeNode32.Name = "Walkthrough";
            treeNode32.Text = "Walkthrough";
            treeNode33.Name = "Block Animation";
            treeNode33.Tag = "VIZCore3D.NET.Animation.Block";
            treeNode33.Text = "Block Animation";
            treeNode34.Name = "Animation";
            treeNode34.Text = "Animation";
            treeNode35.Name = "WDL";
            treeNode35.Tag = "VIZCore3D.NET.Import.WDL";
            treeNode35.Text = "WDL";
            treeNode36.Name = "Import External Data";
            treeNode36.Text = "Import External Data";
            treeNode37.Name = "3D Dashboard";
            treeNode37.Tag = "VIZCore3D.NET.PlacementStatus";
            treeNode37.Text = "3D Dashboard";
            treeNode38.Name = "Real-time shape creation";
            treeNode38.Text = "Real-time shape creation";
            treeNode39.Name = "Divide / Group";
            treeNode39.Tag = "VIZCore3D.NET.SelectionBox";
            treeNode39.Text = "Divide / Group";
            treeNode40.Name = "Drag & Drop";
            treeNode40.Tag = "VIZCore3D.NET.SelectionBox.V2";
            treeNode40.Text = "Drag & Drop";
            treeNode41.Name = "Selection Box";
            treeNode41.Text = "Selection Box";
            treeNode42.Name = "PMI";
            treeNode42.Tag = "VIZCore3D.NET.PMI";
            treeNode42.Text = "PMI";
            treeNode43.Name = "Custom Drawing";
            treeNode43.Tag = "VIZCore3D.NET.ShapeDrawing";
            treeNode43.Text = "Custom Drawing";
            treeNode44.Name = "Block Arrangement";
            treeNode44.Tag = "VIZCore3D.NET.BlockArrangement";
            treeNode44.Text = "Block Arrangement";
            treeNode45.Name = "Etc.";
            treeNode45.Text = "Etc.";
            treeNode46.Name = "VIZCore3D.NET";
            treeNode46.Text = "VIZCore3D.NET";
            this.tvHierarchy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode46});
            this.tvHierarchy.SelectedImageIndex = 0;
            this.tvHierarchy.Size = new System.Drawing.Size(347, 760);
            this.tvHierarchy.TabIndex = 0;
            // 
            // imgTreeNode
            // 
            this.imgTreeNode.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTreeNode.ImageStream")));
            this.imgTreeNode.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTreeNode.Images.SetKeyName(0, "VIZZARD_x16.png");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Size = new System.Drawing.Size(1127, 809);
            this.splitContainer2.SplitterDistance = 374;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Size = new System.Drawing.Size(1127, 374);
            this.splitContainer3.SplitterDistance = 515;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnOpenFolder);
            this.groupBox2.Controls.Add(this.btnRun);
            this.groupBox2.Controls.Add(this.btnYouTube);
            this.groupBox2.Controls.Add(this.btnGitHub);
            this.groupBox2.Controls.Add(this.pbPreview);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 350);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Enabled = false;
            this.btnOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFolder.Image")));
            this.btnOpenFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.Location = new System.Drawing.Point(95, 21);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(89, 39);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "Open";
            this.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Enabled = false;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(190, 21);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(77, 39);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnYouTube
            // 
            this.btnYouTube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYouTube.Enabled = false;
            this.btnYouTube.Image = ((System.Drawing.Image)(resources.GetObject("btnYouTube.Image")));
            this.btnYouTube.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYouTube.Location = new System.Drawing.Point(382, 21);
            this.btnYouTube.Name = "btnYouTube";
            this.btnYouTube.Size = new System.Drawing.Size(111, 39);
            this.btnYouTube.TabIndex = 2;
            this.btnYouTube.Text = "YouTube";
            this.btnYouTube.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYouTube.UseVisualStyleBackColor = true;
            this.btnYouTube.Click += new System.EventHandler(this.btnYouTube_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGitHub.Enabled = false;
            this.btnGitHub.Image = ((System.Drawing.Image)(resources.GetObject("btnGitHub.Image")));
            this.btnGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGitHub.Location = new System.Drawing.Point(273, 21);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(103, 39);
            this.btnGitHub.TabIndex = 1;
            this.btnGitHub.Text = "GitHub";
            this.btnGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGitHub.UseVisualStyleBackColor = true;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPreview.Image = ((System.Drawing.Image)(resources.GetObject("pbPreview.Image")));
            this.pbPreview.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPreview.InitialImage")));
            this.pbPreview.Location = new System.Drawing.Point(6, 71);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(487, 273);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtContents);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 350);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail";
            // 
            // txtContents
            // 
            this.txtContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContents.Location = new System.Drawing.Point(3, 22);
            this.txtContents.Multiline = true;
            this.txtContents.Name = "txtContents";
            this.txtContents.ReadOnly = true;
            this.txtContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContents.Size = new System.Drawing.Size(587, 325);
            this.txtContents.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lbAPI);
            this.groupBox4.Controls.Add(this.lvAPI);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1110, 416);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "API";
            // 
            // lbAPI
            // 
            this.lbAPI.AutoSize = true;
            this.lbAPI.Location = new System.Drawing.Point(47, 21);
            this.lbAPI.Name = "lbAPI";
            this.lbAPI.Size = new System.Drawing.Size(117, 19);
            this.lbAPI.TabIndex = 1;
            this.lbAPI.Text = "Items = 0 EA";
            // 
            // lvAPI
            // 
            this.lvAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAPI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAPI.FullRowSelect = true;
            this.lvAPI.GridLines = true;
            this.lvAPI.HideSelection = false;
            this.lvAPI.Location = new System.Drawing.Point(6, 49);
            this.lvAPI.Name = "lvAPI";
            this.lvAPI.Size = new System.Drawing.Size(1098, 361);
            this.lvAPI.TabIndex = 0;
            this.lvAPI.UseCompatibleStateImageBehavior = false;
            this.lvAPI.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            this.columnHeader1.Width = 800;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 809);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.DemoCenter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvHierarchy;
        private System.Windows.Forms.ImageList imgTreeNode;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button btnYouTube;
        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.TextBox txtContents;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListView lvAPI;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lbAPI;
        private System.Windows.Forms.Button btnOpenFolder;
    }
}

