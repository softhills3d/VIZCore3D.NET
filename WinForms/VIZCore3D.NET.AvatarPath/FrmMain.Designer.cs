namespace VIZCore3D.NET.AvatarPath
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDetectCollision = new System.Windows.Forms.Button();
            this.btnCollistionPoint = new System.Windows.Forms.Button();
            this.btnGetPathTick = new System.Windows.Forms.Button();
            this.btnClearPos = new System.Windows.Forms.Button();
            this.btnDeletePos = new System.Windows.Forms.Button();
            this.btnAddPos = new System.Windows.Forms.Button();
            this.ckRepeat = new System.Windows.Forms.CheckBox();
            this.lvPosition = new System.Windows.Forms.ListView();
            this.chIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckPlayRepeatMode = new System.Windows.Forms.CheckBox();
            this.btnRewind = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHidePath = new System.Windows.Forms.Button();
            this.btnShowPath = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeletePath = new System.Windows.Forms.Button();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.lvPath = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckAvatarViewCamera = new System.Windows.Forms.CheckBox();
            this.ckCollisionNodeHighlight = new System.Windows.Forms.CheckBox();
            this.ckCollisionSymbolVisible = new System.Windows.Forms.CheckBox();
            this.ckCollisionNoteVisible = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAvatarPose = new System.Windows.Forms.ComboBox();
            this.ckVisible = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetOption = new System.Windows.Forms.Button();
            this.ckLastPathAsDir = new System.Windows.Forms.CheckBox();
            this.txtRotateSpeed = new System.Windows.Forms.TextBox();
            this.txtWalkSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbTickTotal = new System.Windows.Forms.Label();
            this.lbTick = new System.Windows.Forms.Label();
            this.tbPos = new System.Windows.Forms.TrackBar();
            this.timerDetect = new System.Windows.Forms.Timer(this.components);
            this.btnSetAvatarPose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPos)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1512, 810);
            this.splitContainer1.SplitterDistance = 466;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnDetectCollision);
            this.groupBox5.Controls.Add(this.btnCollistionPoint);
            this.groupBox5.Controls.Add(this.btnGetPathTick);
            this.groupBox5.Controls.Add(this.btnClearPos);
            this.groupBox5.Controls.Add(this.btnDeletePos);
            this.groupBox5.Controls.Add(this.btnAddPos);
            this.groupBox5.Controls.Add(this.ckRepeat);
            this.groupBox5.Controls.Add(this.lvPosition);
            this.groupBox5.Location = new System.Drawing.Point(12, 507);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(438, 291);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Path Position";
            // 
            // btnDetectCollision
            // 
            this.btnDetectCollision.Location = new System.Drawing.Point(116, 45);
            this.btnDetectCollision.Name = "btnDetectCollision";
            this.btnDetectCollision.Size = new System.Drawing.Size(75, 23);
            this.btnDetectCollision.TabIndex = 9;
            this.btnDetectCollision.Text = "Automatic";
            this.btnDetectCollision.UseVisualStyleBackColor = true;
            this.btnDetectCollision.Click += new System.EventHandler(this.btnDetectCollision_Click);
            // 
            // btnCollistionPoint
            // 
            this.btnCollistionPoint.Location = new System.Drawing.Point(197, 45);
            this.btnCollistionPoint.Name = "btnCollistionPoint";
            this.btnCollistionPoint.Size = new System.Drawing.Size(117, 23);
            this.btnCollistionPoint.TabIndex = 8;
            this.btnCollistionPoint.Text = "Display Collision";
            this.btnCollistionPoint.UseVisualStyleBackColor = true;
            this.btnCollistionPoint.Click += new System.EventHandler(this.btnCollistionPoint_Click);
            // 
            // btnGetPathTick
            // 
            this.btnGetPathTick.Location = new System.Drawing.Point(11, 45);
            this.btnGetPathTick.Name = "btnGetPathTick";
            this.btnGetPathTick.Size = new System.Drawing.Size(86, 23);
            this.btnGetPathTick.TabIndex = 7;
            this.btnGetPathTick.Text = "Time(Tick)";
            this.btnGetPathTick.UseVisualStyleBackColor = true;
            this.btnGetPathTick.Click += new System.EventHandler(this.btnGetPathTick_Click);
            // 
            // btnClearPos
            // 
            this.btnClearPos.Location = new System.Drawing.Point(278, 19);
            this.btnClearPos.Name = "btnClearPos";
            this.btnClearPos.Size = new System.Drawing.Size(75, 23);
            this.btnClearPos.TabIndex = 6;
            this.btnClearPos.Text = "Clear";
            this.btnClearPos.UseVisualStyleBackColor = true;
            this.btnClearPos.Click += new System.EventHandler(this.btnClearPos_Click);
            // 
            // btnDeletePos
            // 
            this.btnDeletePos.Location = new System.Drawing.Point(197, 19);
            this.btnDeletePos.Name = "btnDeletePos";
            this.btnDeletePos.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePos.TabIndex = 5;
            this.btnDeletePos.Text = "Delete";
            this.btnDeletePos.UseVisualStyleBackColor = true;
            this.btnDeletePos.Click += new System.EventHandler(this.btnDeletePos_Click);
            // 
            // btnAddPos
            // 
            this.btnAddPos.Location = new System.Drawing.Point(116, 19);
            this.btnAddPos.Name = "btnAddPos";
            this.btnAddPos.Size = new System.Drawing.Size(75, 23);
            this.btnAddPos.TabIndex = 4;
            this.btnAddPos.Text = "Add";
            this.btnAddPos.UseVisualStyleBackColor = true;
            this.btnAddPos.Click += new System.EventHandler(this.btnAddPos_Click);
            // 
            // ckRepeat
            // 
            this.ckRepeat.AutoSize = true;
            this.ckRepeat.Checked = true;
            this.ckRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckRepeat.Location = new System.Drawing.Point(11, 23);
            this.ckRepeat.Name = "ckRepeat";
            this.ckRepeat.Size = new System.Drawing.Size(99, 16);
            this.ckRepeat.TabIndex = 2;
            this.ckRepeat.Text = "Repeat Mode";
            this.ckRepeat.UseVisualStyleBackColor = true;
            // 
            // lvPosition
            // 
            this.lvPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPosition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIndex,
            this.chX,
            this.chY,
            this.chZ});
            this.lvPosition.FullRowSelect = true;
            this.lvPosition.GridLines = true;
            this.lvPosition.HideSelection = false;
            this.lvPosition.Location = new System.Drawing.Point(6, 74);
            this.lvPosition.Name = "lvPosition";
            this.lvPosition.Size = new System.Drawing.Size(426, 211);
            this.lvPosition.TabIndex = 1;
            this.lvPosition.UseCompatibleStateImageBehavior = false;
            this.lvPosition.View = System.Windows.Forms.View.Details;
            // 
            // chIndex
            // 
            this.chIndex.Text = "Index";
            // 
            // chX
            // 
            this.chX.Text = "X";
            this.chX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chX.Width = 100;
            // 
            // chY
            // 
            this.chY.Text = "Y";
            this.chY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chY.Width = 100;
            // 
            // chZ
            // 
            this.chZ.Text = "Z";
            this.chZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chZ.Width = 100;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ckPlayRepeatMode);
            this.groupBox4.Controls.Add(this.btnRewind);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnPause);
            this.groupBox4.Controls.Add(this.btnPlay);
            this.groupBox4.Controls.Add(this.btnHidePath);
            this.groupBox4.Controls.Add(this.btnShowPath);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnDeletePath);
            this.groupBox4.Controls.Add(this.btnAddPath);
            this.groupBox4.Controls.Add(this.lvPath);
            this.groupBox4.Location = new System.Drawing.Point(12, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 199);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Avatar Path";
            // 
            // ckPlayRepeatMode
            // 
            this.ckPlayRepeatMode.AutoSize = true;
            this.ckPlayRepeatMode.Location = new System.Drawing.Point(331, 54);
            this.ckPlayRepeatMode.Name = "ckPlayRepeatMode";
            this.ckPlayRepeatMode.Size = new System.Drawing.Size(99, 16);
            this.ckPlayRepeatMode.TabIndex = 10;
            this.ckPlayRepeatMode.Text = "Repeat Mode";
            this.ckPlayRepeatMode.UseVisualStyleBackColor = true;
            // 
            // btnRewind
            // 
            this.btnRewind.Location = new System.Drawing.Point(249, 49);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(75, 23);
            this.btnRewind.TabIndex = 9;
            this.btnRewind.Text = "Rewind";
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(168, 49);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(87, 49);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(6, 49);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHidePath
            // 
            this.btnHidePath.Location = new System.Drawing.Point(341, 20);
            this.btnHidePath.Name = "btnHidePath";
            this.btnHidePath.Size = new System.Drawing.Size(75, 23);
            this.btnHidePath.TabIndex = 5;
            this.btnHidePath.Text = "Hide Path";
            this.btnHidePath.UseVisualStyleBackColor = true;
            this.btnHidePath.Click += new System.EventHandler(this.btnHidePath_Click);
            // 
            // btnShowPath
            // 
            this.btnShowPath.Location = new System.Drawing.Point(260, 20);
            this.btnShowPath.Name = "btnShowPath";
            this.btnShowPath.Size = new System.Drawing.Size(75, 23);
            this.btnShowPath.TabIndex = 4;
            this.btnShowPath.Text = "Show Path";
            this.btnShowPath.UseVisualStyleBackColor = true;
            this.btnShowPath.Click += new System.EventHandler(this.btnShowPath_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeletePath
            // 
            this.btnDeletePath.Location = new System.Drawing.Point(87, 20);
            this.btnDeletePath.Name = "btnDeletePath";
            this.btnDeletePath.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePath.TabIndex = 2;
            this.btnDeletePath.Text = "Delete";
            this.btnDeletePath.UseVisualStyleBackColor = true;
            this.btnDeletePath.Click += new System.EventHandler(this.btnDeletePath_Click);
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(6, 20);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(75, 23);
            this.btnAddPath.TabIndex = 1;
            this.btnAddPath.Text = "Add";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // lvPath
            // 
            this.lvPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPath.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chTitle});
            this.lvPath.FullRowSelect = true;
            this.lvPath.GridLines = true;
            this.lvPath.HideSelection = false;
            this.lvPath.Location = new System.Drawing.Point(6, 78);
            this.lvPath.Name = "lvPath";
            this.lvPath.Size = new System.Drawing.Size(426, 115);
            this.lvPath.TabIndex = 0;
            this.lvPath.UseCompatibleStateImageBehavior = false;
            this.lvPath.View = System.Windows.Forms.View.Details;
            this.lvPath.SelectedIndexChanged += new System.EventHandler(this.lvPath_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            this.chTitle.Width = 300;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Location = new System.Drawing.Point(12, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Avatar Path (Import / Export)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSetAvatarPose);
            this.groupBox2.Controls.Add(this.ckAvatarViewCamera);
            this.groupBox2.Controls.Add(this.ckCollisionNodeHighlight);
            this.groupBox2.Controls.Add(this.ckCollisionSymbolVisible);
            this.groupBox2.Controls.Add(this.ckCollisionNoteVisible);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbAvatarPose);
            this.groupBox2.Controls.Add(this.ckVisible);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // ckAvatarViewCamera
            // 
            this.ckAvatarViewCamera.AutoSize = true;
            this.ckAvatarViewCamera.Checked = true;
            this.ckAvatarViewCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAvatarViewCamera.Location = new System.Drawing.Point(197, 86);
            this.ckAvatarViewCamera.Name = "ckAvatarViewCamera";
            this.ckAvatarViewCamera.Size = new System.Drawing.Size(140, 16);
            this.ckAvatarViewCamera.TabIndex = 13;
            this.ckAvatarViewCamera.Text = "Avatar View Camera";
            this.ckAvatarViewCamera.UseVisualStyleBackColor = true;
            this.ckAvatarViewCamera.CheckedChanged += new System.EventHandler(this.ckAvatarViewCamera_CheckedChanged);
            // 
            // ckCollisionNodeHighlight
            // 
            this.ckCollisionNodeHighlight.AutoSize = true;
            this.ckCollisionNodeHighlight.Checked = true;
            this.ckCollisionNodeHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCollisionNodeHighlight.Location = new System.Drawing.Point(35, 89);
            this.ckCollisionNodeHighlight.Name = "ckCollisionNodeHighlight";
            this.ckCollisionNodeHighlight.Size = new System.Drawing.Size(159, 16);
            this.ckCollisionNodeHighlight.TabIndex = 12;
            this.ckCollisionNodeHighlight.Text = "Collision Node Highlight";
            this.ckCollisionNodeHighlight.UseVisualStyleBackColor = true;
            // 
            // ckCollisionSymbolVisible
            // 
            this.ckCollisionSymbolVisible.AutoSize = true;
            this.ckCollisionSymbolVisible.Checked = true;
            this.ckCollisionSymbolVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCollisionSymbolVisible.Location = new System.Drawing.Point(197, 64);
            this.ckCollisionSymbolVisible.Name = "ckCollisionSymbolVisible";
            this.ckCollisionSymbolVisible.Size = new System.Drawing.Size(162, 16);
            this.ckCollisionSymbolVisible.TabIndex = 11;
            this.ckCollisionSymbolVisible.Text = "Collision Symbol Visible";
            this.ckCollisionSymbolVisible.UseVisualStyleBackColor = true;
            // 
            // ckCollisionNoteVisible
            // 
            this.ckCollisionNoteVisible.AutoSize = true;
            this.ckCollisionNoteVisible.Location = new System.Drawing.Point(35, 64);
            this.ckCollisionNoteVisible.Name = "ckCollisionNoteVisible";
            this.ckCollisionNoteVisible.Size = new System.Drawing.Size(145, 16);
            this.ckCollisionNoteVisible.TabIndex = 10;
            this.ckCollisionNoteVisible.Text = "Collision Note Visible";
            this.ckCollisionNoteVisible.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pose";
            // 
            // cbAvatarPose
            // 
            this.cbAvatarPose.FormattingEnabled = true;
            this.cbAvatarPose.Items.AddRange(new object[] {
            "NORMAL",
            "IDLE",
            "WALK",
            "BOW_DOWN_IDLE",
            "BOW_DOWN_WALK",
            "HANDS_UP",
            "KNEEL_IDLE",
            "SEEING_IDLE",
            "SIT1_IDLE",
            "SIT2_IDLE",
            "SIT3_IDLE",
            "CLIMBING_DOWN",
            "CLIMBING",
            "HANDS_HALF_UP_IDLE",
            "HANDS_HALF_UP_READY",
            "LAY_DOWN_IDLE",
            "LAY_DOWN_READY",
            "SEEING90_IDLE",
            "SEEING90_READY"});
            this.cbAvatarPose.Location = new System.Drawing.Point(223, 29);
            this.cbAvatarPose.Name = "cbAvatarPose";
            this.cbAvatarPose.Size = new System.Drawing.Size(156, 20);
            this.cbAvatarPose.TabIndex = 9;
            this.cbAvatarPose.Text = "NORMAL";
            // 
            // ckVisible
            // 
            this.ckVisible.AutoSize = true;
            this.ckVisible.Checked = true;
            this.ckVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckVisible.Location = new System.Drawing.Point(35, 31);
            this.ckVisible.Name = "ckVisible";
            this.ckVisible.Size = new System.Drawing.Size(119, 16);
            this.ckVisible.TabIndex = 0;
            this.ckVisible.Text = "Path Line Visible";
            this.ckVisible.UseVisualStyleBackColor = true;
            this.ckVisible.CheckedChanged += new System.EventHandler(this.ckVisible_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSetOption);
            this.groupBox1.Controls.Add(this.ckLastPathAsDir);
            this.groupBox1.Controls.Add(this.txtRotateSpeed);
            this.groupBox1.Controls.Add(this.txtWalkSpeed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // btnSetOption
            // 
            this.btnSetOption.Location = new System.Drawing.Point(260, 56);
            this.btnSetOption.Name = "btnSetOption";
            this.btnSetOption.Size = new System.Drawing.Size(75, 23);
            this.btnSetOption.TabIndex = 5;
            this.btnSetOption.Text = "Set";
            this.btnSetOption.UseVisualStyleBackColor = true;
            this.btnSetOption.Click += new System.EventHandler(this.btnSetOption_Click);
            // 
            // ckLastPathAsDir
            // 
            this.ckLastPathAsDir.AutoSize = true;
            this.ckLastPathAsDir.Location = new System.Drawing.Point(260, 31);
            this.ckLastPathAsDir.Name = "ckLastPathAsDir";
            this.ckLastPathAsDir.Size = new System.Drawing.Size(119, 16);
            this.ckLastPathAsDir.TabIndex = 4;
            this.ckLastPathAsDir.Text = "Last Path As Dir.";
            this.ckLastPathAsDir.UseVisualStyleBackColor = true;
            // 
            // txtRotateSpeed
            // 
            this.txtRotateSpeed.Location = new System.Drawing.Point(133, 59);
            this.txtRotateSpeed.Name = "txtRotateSpeed";
            this.txtRotateSpeed.Size = new System.Drawing.Size(100, 21);
            this.txtRotateSpeed.TabIndex = 3;
            this.txtRotateSpeed.Text = "1";
            // 
            // txtWalkSpeed
            // 
            this.txtWalkSpeed.Location = new System.Drawing.Point(133, 29);
            this.txtWalkSpeed.Name = "txtWalkSpeed";
            this.txtWalkSpeed.Size = new System.Drawing.Size(100, 21);
            this.txtWalkSpeed.TabIndex = 2;
            this.txtWalkSpeed.Text = "1500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rotate Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Walk Speed";
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
            this.splitContainer2.Panel2.Controls.Add(this.lbTickTotal);
            this.splitContainer2.Panel2.Controls.Add(this.lbTick);
            this.splitContainer2.Panel2.Controls.Add(this.tbPos);
            this.splitContainer2.Size = new System.Drawing.Size(1042, 810);
            this.splitContainer2.SplitterDistance = 732;
            this.splitContainer2.TabIndex = 0;
            // 
            // lbTickTotal
            // 
            this.lbTickTotal.AutoSize = true;
            this.lbTickTotal.Location = new System.Drawing.Point(14, 44);
            this.lbTickTotal.Name = "lbTickTotal";
            this.lbTickTotal.Size = new System.Drawing.Size(29, 12);
            this.lbTickTotal.TabIndex = 2;
            this.lbTickTotal.Text = "0000";
            // 
            // lbTick
            // 
            this.lbTick.AutoSize = true;
            this.lbTick.Location = new System.Drawing.Point(14, 19);
            this.lbTick.Name = "lbTick";
            this.lbTick.Size = new System.Drawing.Size(29, 12);
            this.lbTick.TabIndex = 1;
            this.lbTick.Text = "0000";
            // 
            // tbPos
            // 
            this.tbPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPos.LargeChange = 1000;
            this.tbPos.Location = new System.Drawing.Point(95, 19);
            this.tbPos.Maximum = 1000;
            this.tbPos.Name = "tbPos";
            this.tbPos.Size = new System.Drawing.Size(935, 45);
            this.tbPos.SmallChange = 100;
            this.tbPos.TabIndex = 0;
            this.tbPos.TickFrequency = 100;
            this.tbPos.Scroll += new System.EventHandler(this.tbPos_Scroll);
            // 
            // btnSetAvatarPose
            // 
            this.btnSetAvatarPose.Location = new System.Drawing.Point(386, 29);
            this.btnSetAvatarPose.Name = "btnSetAvatarPose";
            this.btnSetAvatarPose.Size = new System.Drawing.Size(44, 23);
            this.btnSetAvatarPose.TabIndex = 14;
            this.btnSetAvatarPose.Text = "Set";
            this.btnSetAvatarPose.UseVisualStyleBackColor = true;
            this.btnSetAvatarPose.Click += new System.EventHandler(this.btnSetAvatarPose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 810);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.AvatarPath";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbPos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckLastPathAsDir;
        private System.Windows.Forms.TextBox txtRotateSpeed;
        private System.Windows.Forms.TextBox txtWalkSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetOption;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckVisible;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvPath;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeletePath;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ListView lvPosition;
        private System.Windows.Forms.ColumnHeader chIndex;
        private System.Windows.Forms.ColumnHeader chX;
        private System.Windows.Forms.ColumnHeader chY;
        private System.Windows.Forms.ColumnHeader chZ;
        private System.Windows.Forms.Button btnClearPos;
        private System.Windows.Forms.Button btnDeletePos;
        private System.Windows.Forms.Button btnAddPos;
        private System.Windows.Forms.CheckBox ckRepeat;
        private System.Windows.Forms.Button btnHidePath;
        private System.Windows.Forms.Button btnShowPath;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox ckPlayRepeatMode;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnGetPathTick;
        private System.Windows.Forms.TrackBar tbPos;
        private System.Windows.Forms.Label lbTick;
        private System.Windows.Forms.Label lbTickTotal;
        private System.Windows.Forms.Button btnCollistionPoint;
        private System.Windows.Forms.ComboBox cbAvatarPose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDetectCollision;
        private System.Windows.Forms.Timer timerDetect;
        private System.Windows.Forms.CheckBox ckCollisionSymbolVisible;
        private System.Windows.Forms.CheckBox ckCollisionNoteVisible;
        private System.Windows.Forms.CheckBox ckCollisionNodeHighlight;
        private System.Windows.Forms.CheckBox ckAvatarViewCamera;
        private System.Windows.Forms.Button btnSetAvatarPose;
    }
}

