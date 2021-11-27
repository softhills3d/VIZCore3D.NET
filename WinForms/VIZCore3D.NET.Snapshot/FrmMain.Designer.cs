namespace VIZCore3D.NET.Snapshot
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
            this.plView = new System.Windows.Forms.Panel();
            this.lvSnapshot = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnModelOpen = new System.Windows.Forms.Button();
            this.btnModelClose = new System.Windows.Forms.Button();
            this.btnSnapshotAdd = new System.Windows.Forms.Button();
            this.btnSnapshotList = new System.Windows.Forms.Button();
            this.btnResetView = new System.Windows.Forms.Button();
            this.plView.SuspendLayout();
            this.SuspendLayout();
            // 
            // plView
            // 
            this.plView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plView.Controls.Add(this.lvSnapshot);
            this.plView.Location = new System.Drawing.Point(-1, -2);
            this.plView.Name = "plView";
            this.plView.Size = new System.Drawing.Size(1470, 714);
            this.plView.TabIndex = 0;
            // 
            // lvSnapshot
            // 
            this.lvSnapshot.BackgroundImageTiled = true;
            this.lvSnapshot.HideSelection = false;
            this.lvSnapshot.LargeImageList = this.imgList;
            this.lvSnapshot.Location = new System.Drawing.Point(179, 385);
            this.lvSnapshot.Name = "lvSnapshot";
            this.lvSnapshot.Size = new System.Drawing.Size(340, 226);
            this.lvSnapshot.SmallImageList = this.imgList;
            this.lvSnapshot.TabIndex = 0;
            this.lvSnapshot.UseCompatibleStateImageBehavior = false;
            this.lvSnapshot.SelectedIndexChanged += new System.EventHandler(this.lvSnapshot_SelectedIndexChanged);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(256, 256);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnModelOpen
            // 
            this.btnModelOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModelOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnModelOpen.Image")));
            this.btnModelOpen.Location = new System.Drawing.Point(24, 742);
            this.btnModelOpen.Name = "btnModelOpen";
            this.btnModelOpen.Size = new System.Drawing.Size(70, 42);
            this.btnModelOpen.TabIndex = 1;
            this.btnModelOpen.UseVisualStyleBackColor = true;
            this.btnModelOpen.Click += new System.EventHandler(this.btnModelOpen_Click);
            // 
            // btnModelClose
            // 
            this.btnModelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModelClose.Image = ((System.Drawing.Image)(resources.GetObject("btnModelClose.Image")));
            this.btnModelClose.Location = new System.Drawing.Point(116, 742);
            this.btnModelClose.Name = "btnModelClose";
            this.btnModelClose.Size = new System.Drawing.Size(82, 42);
            this.btnModelClose.TabIndex = 2;
            this.btnModelClose.UseVisualStyleBackColor = true;
            this.btnModelClose.Click += new System.EventHandler(this.btnModelClose_Click);
            // 
            // btnSnapshotAdd
            // 
            this.btnSnapshotAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSnapshotAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapshotAdd.Image")));
            this.btnSnapshotAdd.Location = new System.Drawing.Point(1264, 742);
            this.btnSnapshotAdd.Name = "btnSnapshotAdd";
            this.btnSnapshotAdd.Size = new System.Drawing.Size(75, 42);
            this.btnSnapshotAdd.TabIndex = 3;
            this.btnSnapshotAdd.UseVisualStyleBackColor = true;
            this.btnSnapshotAdd.Click += new System.EventHandler(this.btnSnapshotAdd_Click);
            // 
            // btnSnapshotList
            // 
            this.btnSnapshotList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSnapshotList.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapshotList.Image")));
            this.btnSnapshotList.Location = new System.Drawing.Point(1359, 742);
            this.btnSnapshotList.Name = "btnSnapshotList";
            this.btnSnapshotList.Size = new System.Drawing.Size(75, 42);
            this.btnSnapshotList.TabIndex = 4;
            this.btnSnapshotList.UseVisualStyleBackColor = true;
            this.btnSnapshotList.Click += new System.EventHandler(this.btnSnapshotList_Click);
            // 
            // btnResetView
            // 
            this.btnResetView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetView.Image = ((System.Drawing.Image)(resources.GetObject("btnResetView.Image")));
            this.btnResetView.Location = new System.Drawing.Point(217, 742);
            this.btnResetView.Name = "btnResetView";
            this.btnResetView.Size = new System.Drawing.Size(82, 42);
            this.btnResetView.TabIndex = 5;
            this.btnResetView.UseVisualStyleBackColor = true;
            this.btnResetView.Click += new System.EventHandler(this.btnResetView_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 796);
            this.Controls.Add(this.btnResetView);
            this.Controls.Add(this.btnSnapshotList);
            this.Controls.Add(this.btnSnapshotAdd);
            this.Controls.Add(this.btnModelClose);
            this.Controls.Add(this.btnModelOpen);
            this.Controls.Add(this.plView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.Snapshot";
            this.plView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plView;
        private System.Windows.Forms.Button btnModelOpen;
        private System.Windows.Forms.Button btnModelClose;
        private System.Windows.Forms.Button btnSnapshotAdd;
        private System.Windows.Forms.Button btnSnapshotList;
        private System.Windows.Forms.Button btnResetView;
        private System.Windows.Forms.ListView lvSnapshot;
        private System.Windows.Forms.ImageList imgList;
    }
}

