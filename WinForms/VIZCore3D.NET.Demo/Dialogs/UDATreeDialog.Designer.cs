namespace VIZCore3D.NET.Demo.Dialogs
{
    partial class UDATreeDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDATreeDialog));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvAttribute = new System.Windows.Forms.TreeView();
            this.dataGridNode = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNode)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvAttribute);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridNode);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvAttribute
            // 
            this.tvAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvAttribute.Location = new System.Drawing.Point(0, 0);
            this.tvAttribute.Name = "tvAttribute";
            this.tvAttribute.Size = new System.Drawing.Size(266, 450);
            this.tvAttribute.TabIndex = 0;
            this.tvAttribute.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAttribute_AfterSelect);
            // 
            // dataGridNode
            // 
            this.dataGridNode.AllowUserToAddRows = false;
            this.dataGridNode.AllowUserToDeleteRows = false;
            this.dataGridNode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridNode.Location = new System.Drawing.Point(0, 0);
            this.dataGridNode.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridNode.Name = "dataGridNode";
            this.dataGridNode.ReadOnly = true;
            this.dataGridNode.RowTemplate.Height = 34;
            this.dataGridNode.Size = new System.Drawing.Size(530, 450);
            this.dataGridNode.TabIndex = 1;
            // 
            // UDATreeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UDATreeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UDA Tree Dialog";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvAttribute;
        private System.Windows.Forms.DataGridView dataGridNode;
    }
}