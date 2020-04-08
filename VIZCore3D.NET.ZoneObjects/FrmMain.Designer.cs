namespace VIZCore3D.NET.ZoneObjects
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
            this.btnAddBox = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnGetZoneObjects = new System.Windows.Forms.Button();
            this.gbObjects = new System.Windows.Forms.GroupBox();
            this.dataGridNode = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNode)).BeginInit();
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
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbObjects);
            this.splitContainer1.Panel2.Controls.Add(this.btnGetZoneObjects);
            this.splitContainer1.Panel2.Controls.Add(this.cbFilter);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddBox);
            this.splitContainer1.Size = new System.Drawing.Size(1152, 659);
            this.splitContainer1.SplitterDistance = 357;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAddBox
            // 
            this.btnAddBox.Location = new System.Drawing.Point(22, 15);
            this.btnAddBox.Name = "btnAddBox";
            this.btnAddBox.Size = new System.Drawing.Size(75, 23);
            this.btnAddBox.TabIndex = 0;
            this.btnAddBox.Text = "Add Box";
            this.btnAddBox.UseVisualStyleBackColor = true;
            this.btnAddBox.Click += new System.EventHandler(this.btnAddBox_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "포함 모델",
            "걸친 모델 포함",
            "걸친 모델만"});
            this.cbFilter.Location = new System.Drawing.Point(136, 17);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 20);
            this.cbFilter.TabIndex = 1;
            // 
            // btnGetZoneObjects
            // 
            this.btnGetZoneObjects.Location = new System.Drawing.Point(274, 17);
            this.btnGetZoneObjects.Name = "btnGetZoneObjects";
            this.btnGetZoneObjects.Size = new System.Drawing.Size(75, 23);
            this.btnGetZoneObjects.TabIndex = 2;
            this.btnGetZoneObjects.Text = "Get Items";
            this.btnGetZoneObjects.UseVisualStyleBackColor = true;
            this.btnGetZoneObjects.Click += new System.EventHandler(this.btnGetZoneObjects_Click);
            // 
            // gbObjects
            // 
            this.gbObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbObjects.Controls.Add(this.dataGridNode);
            this.gbObjects.Location = new System.Drawing.Point(12, 44);
            this.gbObjects.Name = "gbObjects";
            this.gbObjects.Size = new System.Drawing.Size(1128, 242);
            this.gbObjects.TabIndex = 3;
            this.gbObjects.TabStop = false;
            this.gbObjects.Text = "Objects";
            // 
            // dataGridNode
            // 
            this.dataGridNode.AllowUserToAddRows = false;
            this.dataGridNode.AllowUserToDeleteRows = false;
            this.dataGridNode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridNode.Location = new System.Drawing.Point(3, 17);
            this.dataGridNode.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridNode.Name = "dataGridNode";
            this.dataGridNode.ReadOnly = true;
            this.dataGridNode.RowTemplate.Height = 34;
            this.dataGridNode.Size = new System.Drawing.Size(1122, 222);
            this.dataGridNode.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 659);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIZCore3D.NET.ZoneObjects";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnGetZoneObjects;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnAddBox;
        private System.Windows.Forms.GroupBox gbObjects;
        private System.Windows.Forms.DataGridView dataGridNode;
    }
}

