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
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("WDL");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Import External Data", new System.Windows.Forms.TreeNode[] {
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("3D Dashboard");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Real-time shape creation", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Divide / Group");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Drag & Drop");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Selection Box", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Custom Drawing");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("VIZCore3D.NET", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode20,
            treeNode25,
            treeNode29,
            treeNode30,
            treeNode32,
            treeNode34,
            treeNode36,
            treeNode39,
            treeNode40});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvHierarchy = new System.Windows.Forms.TreeView();
            this.imgTreeNode = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 602);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tvHierarchy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 578);
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
            this.tvHierarchy.Location = new System.Drawing.Point(3, 17);
            this.tvHierarchy.Name = "tvHierarchy";
            treeNode1.Name = "Lightweight";
            treeNode1.Text = "Lightweight";
            treeNode2.Name = "Export Node";
            treeNode2.Text = "Export Node";
            treeNode3.Name = "Attribute (UDA) V1";
            treeNode3.Text = "Attribute (UDA) V1";
            treeNode4.Name = "Attribute (UDA) V2";
            treeNode4.Text = "Attribute (UDA) V2";
            treeNode5.Name = "Comparison";
            treeNode5.Text = "Comparison";
            treeNode6.Name = "Structure";
            treeNode6.Text = "Structure";
            treeNode7.Name = "Structure / Thumbnail (Node)";
            treeNode7.Text = "Structure / Thumbnail (Node)";
            treeNode8.Name = "Thumbnail V1";
            treeNode8.Text = "Thumbnail V1";
            treeNode9.Name = "Thumbnail V2";
            treeNode9.Text = "Thumbnail V2";
            treeNode10.Name = "Model";
            treeNode10.Text = "Model";
            treeNode11.Name = "Node";
            treeNode11.Text = "Node";
            treeNode12.Name = "Disassembly";
            treeNode12.Text = "Disassembly";
            treeNode13.Name = "Geometry Property";
            treeNode13.Text = "Geometry Property";
            treeNode14.Name = "Group";
            treeNode14.Text = "Group";
            treeNode15.Name = "O(Object) SNAP";
            treeNode15.Text = "O(Object) SNAP";
            treeNode16.Name = "Painting";
            treeNode16.Text = "Painting";
            treeNode17.Name = "Search";
            treeNode17.Text = "Search";
            treeNode18.Name = "Space Search";
            treeNode18.Text = "Space Search";
            treeNode19.Name = "Objects in Zone";
            treeNode19.Text = "Objects in Zone";
            treeNode20.Name = "Object3D";
            treeNode20.Text = "Object3D";
            treeNode21.Name = "Capture Image";
            treeNode21.Text = "Capture Image";
            treeNode22.Name = "Mini View";
            treeNode22.Text = "Mini View";
            treeNode23.Name = "2D Projection";
            treeNode23.Text = "2D Projection";
            treeNode24.Name = "Shortest Distance";
            treeNode24.Text = "Shortest Distance";
            treeNode25.Name = "View";
            treeNode25.Text = "View";
            treeNode26.Name = "Note";
            treeNode26.Text = "Note";
            treeNode27.Name = "SnapShot";
            treeNode27.Text = "SnapShot";
            treeNode28.Name = "UserView";
            treeNode28.Text = "UserView";
            treeNode29.Name = "Review";
            treeNode29.Text = "Review";
            treeNode30.Name = "Clash Test";
            treeNode30.Text = "Clash Test";
            treeNode31.Name = "Avatar Path";
            treeNode31.Text = "Avatar Path";
            treeNode32.Name = "Walkthrough";
            treeNode32.Text = "Walkthrough";
            treeNode33.Name = "WDL";
            treeNode33.Text = "WDL";
            treeNode34.Name = "Import External Data";
            treeNode34.Text = "Import External Data";
            treeNode35.Name = "3D Dashboard";
            treeNode35.Text = "3D Dashboard";
            treeNode36.Name = "Real-time shape creation";
            treeNode36.Text = "Real-time shape creation";
            treeNode37.Name = "Divide / Group";
            treeNode37.Text = "Divide / Group";
            treeNode38.Name = "Drag & Drop";
            treeNode38.Text = "Drag & Drop";
            treeNode39.Name = "Selection Box";
            treeNode39.Text = "Selection Box";
            treeNode40.Name = "Custom Drawing";
            treeNode40.Text = "Custom Drawing";
            treeNode41.Name = "VIZCore3D.NET";
            treeNode41.Text = "VIZCore3D.NET";
            this.tvHierarchy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode41});
            this.tvHierarchy.SelectedImageIndex = 0;
            this.tvHierarchy.Size = new System.Drawing.Size(347, 558);
            this.tvHierarchy.TabIndex = 0;
            // 
            // imgTreeNode
            // 
            this.imgTreeNode.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTreeNode.ImageStream")));
            this.imgTreeNode.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTreeNode.Images.SetKeyName(0, "VIZZARD_x16.png");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 602);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.DemoCenter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvHierarchy;
        private System.Windows.Forms.ImageList imgTreeNode;
    }
}

