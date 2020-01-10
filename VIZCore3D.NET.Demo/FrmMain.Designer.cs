namespace VIZCore3D.NET.Demo
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpenUri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileAddUri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarManager = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolbarMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsDebugInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3D = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dPart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dSelectedTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dSelectedAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dLockedHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dSelectedObject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dSelectedChild = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dTestDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiObject3dStructure = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiViewPreSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiViewXrayColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiViewImageToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiViewCaptureImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiViewMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiViewExportImageBackgroundMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiGeometryProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiUDA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiUDAKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiUDAValues = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiUDATree = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApiFrameCreateByAPI = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelView = new System.Windows.Forms.Panel();
            this.menuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuBarManager,
            this.menuTools,
            this.menuApi});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1046, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuFileOpenUri,
            this.toolStripSeparator3,
            this.menuFileAdd,
            this.menuFileAddUri,
            this.toolStripSeparator4,
            this.menuFileExport,
            this.toolStripSeparator5,
            this.menuFileClose,
            this.toolStripSeparator2,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.menuFileOpen.Text = "Open...";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileOpenUri
            // 
            this.menuFileOpenUri.Name = "menuFileOpenUri";
            this.menuFileOpenUri.Size = new System.Drawing.Size(180, 22);
            this.menuFileOpenUri.Text = "Open Uri...";
            this.menuFileOpenUri.Click += new System.EventHandler(this.menuFileOpenUri_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFileAdd
            // 
            this.menuFileAdd.Name = "menuFileAdd";
            this.menuFileAdd.Size = new System.Drawing.Size(180, 22);
            this.menuFileAdd.Text = "Add...";
            this.menuFileAdd.Click += new System.EventHandler(this.menuFileAdd_Click);
            // 
            // menuFileAddUri
            // 
            this.menuFileAddUri.Name = "menuFileAddUri";
            this.menuFileAddUri.Size = new System.Drawing.Size(180, 22);
            this.menuFileAddUri.Text = "Add Uri...";
            this.menuFileAddUri.Click += new System.EventHandler(this.menuFileAddUri_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.Size = new System.Drawing.Size(180, 22);
            this.menuFileClose.Text = "Close";
            this.menuFileClose.Click += new System.EventHandler(this.menuFileClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(180, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuBarManager
            // 
            this.menuBarManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolbarMain,
            this.toolStripSeparator1,
            this.menuStatusbar});
            this.menuBarManager.Name = "menuBarManager";
            this.menuBarManager.Size = new System.Drawing.Size(36, 20);
            this.menuBarManager.Text = "Bar";
            // 
            // menuToolbarMain
            // 
            this.menuToolbarMain.Name = "menuToolbarMain";
            this.menuToolbarMain.Size = new System.Drawing.Size(154, 22);
            this.menuToolbarMain.Text = "Toolbar - Main";
            this.menuToolbarMain.Click += new System.EventHandler(this.menuToolbarMain_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // menuStatusbar
            // 
            this.menuStatusbar.Name = "menuStatusbar";
            this.menuStatusbar.Size = new System.Drawing.Size(154, 22);
            this.menuStatusbar.Text = "Statusbar";
            this.menuStatusbar.Click += new System.EventHandler(this.menuStatusbar_Click);
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolsDebugInformation});
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(47, 20);
            this.menuTools.Text = "Tools";
            // 
            // menuToolsDebugInformation
            // 
            this.menuToolsDebugInformation.Name = "menuToolsDebugInformation";
            this.menuToolsDebugInformation.Size = new System.Drawing.Size(177, 22);
            this.menuToolsDebugInformation.Text = "Debug Information";
            this.menuToolsDebugInformation.Click += new System.EventHandler(this.menuToolsDebugInformation_Click);
            // 
            // menuApi
            // 
            this.menuApi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApiObject3D,
            this.menuApiView,
            this.menuApiGeometryProperty,
            this.menuApiUDA,
            this.menuApiFind,
            this.menuApiFrame});
            this.menuApi.Name = "menuApi";
            this.menuApi.Size = new System.Drawing.Size(37, 20);
            this.menuApi.Text = "API";
            // 
            // menuApiObject3D
            // 
            this.menuApiObject3D.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApiObject3dRoot,
            this.menuApiObject3dFile,
            this.menuApiObject3dAll,
            this.menuApiObject3dPart,
            this.menuApiObject3dSelectedTop,
            this.menuApiObject3dSelectedAll,
            this.menuApiObject3dLockedHidden,
            this.menuApiObject3dSelectedObject,
            this.menuApiObject3dSelectedChild,
            this.menuApiObject3dTestDialog,
            this.menuApiObject3dStructure});
            this.menuApiObject3D.Name = "menuApiObject3D";
            this.menuApiObject3D.Size = new System.Drawing.Size(175, 22);
            this.menuApiObject3D.Text = "Object3D";
            // 
            // menuApiObject3dRoot
            // 
            this.menuApiObject3dRoot.Name = "menuApiObject3dRoot";
            this.menuApiObject3dRoot.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dRoot.Text = "ROOT...";
            this.menuApiObject3dRoot.Click += new System.EventHandler(this.menuApiObject3dRoot_Click);
            // 
            // menuApiObject3dFile
            // 
            this.menuApiObject3dFile.Name = "menuApiObject3dFile";
            this.menuApiObject3dFile.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dFile.Text = "FILE...";
            this.menuApiObject3dFile.Click += new System.EventHandler(this.menuApiObject3dFile_Click);
            // 
            // menuApiObject3dAll
            // 
            this.menuApiObject3dAll.Name = "menuApiObject3dAll";
            this.menuApiObject3dAll.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dAll.Text = "ALL...";
            this.menuApiObject3dAll.Click += new System.EventHandler(this.menuApiObject3dAll_Click);
            // 
            // menuApiObject3dPart
            // 
            this.menuApiObject3dPart.Name = "menuApiObject3dPart";
            this.menuApiObject3dPart.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dPart.Text = "PART...";
            this.menuApiObject3dPart.Click += new System.EventHandler(this.menuApiObject3dPart_Click);
            // 
            // menuApiObject3dSelectedTop
            // 
            this.menuApiObject3dSelectedTop.Name = "menuApiObject3dSelectedTop";
            this.menuApiObject3dSelectedTop.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dSelectedTop.Text = "SELECTED TOP...";
            this.menuApiObject3dSelectedTop.Click += new System.EventHandler(this.menuApiObject3dSelectedTop_Click);
            // 
            // menuApiObject3dSelectedAll
            // 
            this.menuApiObject3dSelectedAll.Name = "menuApiObject3dSelectedAll";
            this.menuApiObject3dSelectedAll.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dSelectedAll.Text = "SELECTED ALL...";
            this.menuApiObject3dSelectedAll.Click += new System.EventHandler(this.menuApiObject3dSelectedAll_Click);
            // 
            // menuApiObject3dLockedHidden
            // 
            this.menuApiObject3dLockedHidden.Name = "menuApiObject3dLockedHidden";
            this.menuApiObject3dLockedHidden.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dLockedHidden.Text = "LOCKED HIDDEN...";
            this.menuApiObject3dLockedHidden.Click += new System.EventHandler(this.menuApiObject3dLockedHidden_Click);
            // 
            // menuApiObject3dSelectedObject
            // 
            this.menuApiObject3dSelectedObject.Name = "menuApiObject3dSelectedObject";
            this.menuApiObject3dSelectedObject.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dSelectedObject.Text = "SELECTED OBJECT...";
            this.menuApiObject3dSelectedObject.Click += new System.EventHandler(this.menuApiObject3dSelectedObject_Click);
            // 
            // menuApiObject3dSelectedChild
            // 
            this.menuApiObject3dSelectedChild.Name = "menuApiObject3dSelectedChild";
            this.menuApiObject3dSelectedChild.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dSelectedChild.Text = "CHILD...";
            this.menuApiObject3dSelectedChild.Click += new System.EventHandler(this.menuApiObject3dSelectedChild_Click);
            // 
            // menuApiObject3dTestDialog
            // 
            this.menuApiObject3dTestDialog.Name = "menuApiObject3dTestDialog";
            this.menuApiObject3dTestDialog.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dTestDialog.Text = "SELECT, SHOW...";
            this.menuApiObject3dTestDialog.Click += new System.EventHandler(this.menuApiObject3dTestDialog_Click);
            // 
            // menuApiObject3dStructure
            // 
            this.menuApiObject3dStructure.Name = "menuApiObject3dStructure";
            this.menuApiObject3dStructure.Size = new System.Drawing.Size(181, 22);
            this.menuApiObject3dStructure.Text = "STRUCTURE...";
            this.menuApiObject3dStructure.Click += new System.EventHandler(this.menuApiObject3dStructure_Click);
            // 
            // menuApiView
            // 
            this.menuApiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApiViewPreSelect,
            this.menuApiViewXrayColor,
            this.menuApiViewImageToClipboard,
            this.menuApiViewCaptureImage,
            this.menuApiViewMessage,
            this.menuApiViewExportImageBackgroundMode});
            this.menuApiView.Name = "menuApiView";
            this.menuApiView.Size = new System.Drawing.Size(175, 22);
            this.menuApiView.Text = "View";
            // 
            // menuApiViewPreSelect
            // 
            this.menuApiViewPreSelect.Name = "menuApiViewPreSelect";
            this.menuApiViewPreSelect.Size = new System.Drawing.Size(256, 22);
            this.menuApiViewPreSelect.Text = "Pre-Select";
            this.menuApiViewPreSelect.Click += new System.EventHandler(this.menuApiViewPreSelect_Click);
            // 
            // menuApiViewXrayColor
            // 
            this.menuApiViewXrayColor.Name = "menuApiViewXrayColor";
            this.menuApiViewXrayColor.Size = new System.Drawing.Size(256, 22);
            this.menuApiViewXrayColor.Text = "X-Ray Color";
            this.menuApiViewXrayColor.Click += new System.EventHandler(this.menuApiViewXrayColor_Click);
            // 
            // menuApiViewImageToClipboard
            // 
            this.menuApiViewImageToClipboard.Name = "menuApiViewImageToClipboard";
            this.menuApiViewImageToClipboard.Size = new System.Drawing.Size(256, 22);
            this.menuApiViewImageToClipboard.Text = "Capture Screen To Clipboard";
            this.menuApiViewImageToClipboard.Click += new System.EventHandler(this.menuApiViewImageToClipboard_Click);
            // 
            // menuApiViewCaptureImage
            // 
            this.menuApiViewCaptureImage.Name = "menuApiViewCaptureImage";
            this.menuApiViewCaptureImage.Size = new System.Drawing.Size(256, 22);
            this.menuApiViewCaptureImage.Text = "Capture Screen...";
            this.menuApiViewCaptureImage.Click += new System.EventHandler(this.menuApiViewCaptureImage_Click);
            // 
            // menuApiViewMessage
            // 
            this.menuApiViewMessage.Name = "menuApiViewMessage";
            this.menuApiViewMessage.Size = new System.Drawing.Size(256, 22);
            this.menuApiViewMessage.Text = "Enable Message";
            this.menuApiViewMessage.Click += new System.EventHandler(this.menuApiViewMessage_Click);
            // 
            // menuApiViewExportImageBackgroundMode
            // 
            this.menuApiViewExportImageBackgroundMode.Name = "menuApiViewExportImageBackgroundMode";
            this.menuApiViewExportImageBackgroundMode.Size = new System.Drawing.Size(256, 22);
            this.menuApiViewExportImageBackgroundMode.Text = "Export Image (Background Mode)";
            this.menuApiViewExportImageBackgroundMode.Click += new System.EventHandler(this.menuApiViewExportImageBackgroundMode_Click);
            // 
            // menuApiGeometryProperty
            // 
            this.menuApiGeometryProperty.Name = "menuApiGeometryProperty";
            this.menuApiGeometryProperty.Size = new System.Drawing.Size(175, 22);
            this.menuApiGeometryProperty.Text = "Geometry Property";
            this.menuApiGeometryProperty.Click += new System.EventHandler(this.menuApiGeometryProperty_Click);
            // 
            // menuApiUDA
            // 
            this.menuApiUDA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApiUDAKeys,
            this.menuApiUDAValues,
            this.menuApiUDATree});
            this.menuApiUDA.Name = "menuApiUDA";
            this.menuApiUDA.Size = new System.Drawing.Size(175, 22);
            this.menuApiUDA.Text = "UDA";
            // 
            // menuApiUDAKeys
            // 
            this.menuApiUDAKeys.Name = "menuApiUDAKeys";
            this.menuApiUDAKeys.Size = new System.Drawing.Size(158, 22);
            this.menuApiUDAKeys.Text = "Keys";
            this.menuApiUDAKeys.Click += new System.EventHandler(this.menuApiUDAKeys_Click);
            // 
            // menuApiUDAValues
            // 
            this.menuApiUDAValues.Name = "menuApiUDAValues";
            this.menuApiUDAValues.Size = new System.Drawing.Size(158, 22);
            this.menuApiUDAValues.Text = "Selected Object";
            this.menuApiUDAValues.Click += new System.EventHandler(this.menuApiUDAValues_Click);
            // 
            // menuApiUDATree
            // 
            this.menuApiUDATree.Name = "menuApiUDATree";
            this.menuApiUDATree.Size = new System.Drawing.Size(158, 22);
            this.menuApiUDATree.Text = "Tree...";
            this.menuApiUDATree.Click += new System.EventHandler(this.menuApiUDATree_Click);
            // 
            // menuApiFind
            // 
            this.menuApiFind.Name = "menuApiFind";
            this.menuApiFind.Size = new System.Drawing.Size(175, 22);
            this.menuApiFind.Text = "Find";
            this.menuApiFind.Click += new System.EventHandler(this.menuApiFind_Click);
            // 
            // menuApiFrame
            // 
            this.menuApiFrame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApiFrameCreateByAPI});
            this.menuApiFrame.Name = "menuApiFrame";
            this.menuApiFrame.Size = new System.Drawing.Size(175, 22);
            this.menuApiFrame.Text = "Frame";
            // 
            // menuApiFrameCreateByAPI
            // 
            this.menuApiFrameCreateByAPI.Name = "menuApiFrameCreateByAPI";
            this.menuApiFrameCreateByAPI.Size = new System.Drawing.Size(147, 22);
            this.menuApiFrameCreateByAPI.Text = "Create By API";
            this.menuApiFrameCreateByAPI.Click += new System.EventHandler(this.menuApiFrameCreateByAPI_Click);
            // 
            // statusbar
            // 
            this.statusbar.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusbar.Location = new System.Drawing.Point(0, 646);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(1046, 22);
            this.statusbar.TabIndex = 1;
            this.statusbar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "MAIN STATUSBAR";
            // 
            // panelView
            // 
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 24);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1046, 622);
            this.panelView.TabIndex = 2;
            // 
            // menuFileExport
            // 
            this.menuFileExport.Name = "menuFileExport";
            this.menuFileExport.Size = new System.Drawing.Size(180, 22);
            this.menuFileExport.Text = "Export...";
            this.menuFileExport.Click += new System.EventHandler(this.menuFileExport_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 668);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Demo";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuBarManager;
        private System.Windows.Forms.ToolStripMenuItem menuToolbarMain;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuStatusbar;
        private System.Windows.Forms.ToolStripMenuItem menuFileAdd;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuToolsDebugInformation;
        private System.Windows.Forms.ToolStripMenuItem menuApi;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3D;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dRoot;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dFile;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dAll;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dPart;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dSelectedTop;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dSelectedAll;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dLockedHidden;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dSelectedObject;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dSelectedChild;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpenUri;
        private System.Windows.Forms.ToolStripMenuItem menuApiView;
        private System.Windows.Forms.ToolStripMenuItem menuApiViewPreSelect;
        private System.Windows.Forms.ToolStripMenuItem menuFileAddUri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuApiViewXrayColor;
        private System.Windows.Forms.ToolStripMenuItem menuApiGeometryProperty;
        private System.Windows.Forms.ToolStripMenuItem menuApiUDA;
        private System.Windows.Forms.ToolStripMenuItem menuApiUDAKeys;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dTestDialog;
        private System.Windows.Forms.ToolStripMenuItem menuApiFind;
        private System.Windows.Forms.ToolStripMenuItem menuApiUDAValues;
        private System.Windows.Forms.ToolStripMenuItem menuApiObject3dStructure;
        private System.Windows.Forms.ToolStripMenuItem menuApiUDATree;
        private System.Windows.Forms.ToolStripMenuItem menuApiViewImageToClipboard;
        private System.Windows.Forms.ToolStripMenuItem menuApiViewCaptureImage;
        private System.Windows.Forms.ToolStripMenuItem menuApiViewMessage;
        private System.Windows.Forms.ToolStripMenuItem menuApiFrame;
        private System.Windows.Forms.ToolStripMenuItem menuApiFrameCreateByAPI;
        private System.Windows.Forms.ToolStripMenuItem menuApiViewExportImageBackgroundMode;
        private System.Windows.Forms.ToolStripMenuItem menuFileExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

