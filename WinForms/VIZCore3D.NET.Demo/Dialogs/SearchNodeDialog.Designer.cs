namespace VIZCore3D.NET.Demo.Dialogs
{
    partial class SearchNodeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchNodeDialog));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckFullMatch = new System.Windows.Forms.CheckBox();
            this.ckCondition = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckVisibleOnly = new System.Windows.Forms.CheckBox();
            this.ckAssemblyOnly = new System.Windows.Forms.CheckBox();
            this.ckSelectedOnly = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvResult = new System.Windows.Forms.ListView();
            this.chNodeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chParentNodeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNodeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ckXray = new System.Windows.Forms.CheckBox();
            this.ckFlyToObject = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색어";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "애스터리스크( * - Asterisk )가 포함된 검색이 가능합니다.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "세미콜론( ; - Semicolon ) 으로 복수개의 검색어를 지정할 수 있습니다.";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(391, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKeyword.Location = new System.Drawing.Point(19, 21);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(366, 21);
            this.txtKeyword.TabIndex = 0;
            this.txtKeyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ckFullMatch);
            this.groupBox2.Controls.Add(this.ckCondition);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "옵션";
            // 
            // ckFullMatch
            // 
            this.ckFullMatch.AutoSize = true;
            this.ckFullMatch.Location = new System.Drawing.Point(154, 20);
            this.ckFullMatch.Name = "ckFullMatch";
            this.ckFullMatch.Size = new System.Drawing.Size(88, 16);
            this.ckFullMatch.TabIndex = 1;
            this.ckFullMatch.Text = "검색어 일치";
            this.ckFullMatch.UseVisualStyleBackColor = true;
            // 
            // ckCondition
            // 
            this.ckCondition.AutoSize = true;
            this.ckCondition.Location = new System.Drawing.Point(19, 20);
            this.ckCondition.Name = "ckCondition";
            this.ckCondition.Size = new System.Drawing.Size(77, 16);
            this.ckCondition.TabIndex = 0;
            this.ckCondition.Text = "AND 검색";
            this.ckCondition.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ckVisibleOnly);
            this.groupBox3.Controls.Add(this.ckAssemblyOnly);
            this.groupBox3.Controls.Add(this.ckSelectedOnly);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "대상";
            // 
            // ckVisibleOnly
            // 
            this.ckVisibleOnly.AutoSize = true;
            this.ckVisibleOnly.Location = new System.Drawing.Point(275, 20);
            this.ckVisibleOnly.Name = "ckVisibleOnly";
            this.ckVisibleOnly.Size = new System.Drawing.Size(100, 16);
            this.ckVisibleOnly.TabIndex = 4;
            this.ckVisibleOnly.Text = "보이는 모델만";
            this.ckVisibleOnly.UseVisualStyleBackColor = true;
            // 
            // ckAssemblyOnly
            // 
            this.ckAssemblyOnly.AutoSize = true;
            this.ckAssemblyOnly.Checked = true;
            this.ckAssemblyOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAssemblyOnly.Location = new System.Drawing.Point(154, 20);
            this.ckAssemblyOnly.Name = "ckAssemblyOnly";
            this.ckAssemblyOnly.Size = new System.Drawing.Size(100, 16);
            this.ckAssemblyOnly.TabIndex = 3;
            this.ckAssemblyOnly.Text = "어셈블리 단위";
            this.ckAssemblyOnly.UseVisualStyleBackColor = true;
            // 
            // ckSelectedOnly
            // 
            this.ckSelectedOnly.AutoSize = true;
            this.ckSelectedOnly.Location = new System.Drawing.Point(19, 20);
            this.ckSelectedOnly.Name = "ckSelectedOnly";
            this.ckSelectedOnly.Size = new System.Drawing.Size(116, 16);
            this.ckSelectedOnly.TabIndex = 2;
            this.ckSelectedOnly.Text = "선택된 개체 이하";
            this.ckSelectedOnly.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lvResult);
            this.groupBox4.Location = new System.Drawing.Point(12, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 295);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "검색 결과";
            // 
            // lvResult
            // 
            this.lvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNodeName,
            this.chParentNodeName,
            this.chNodeType});
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(6, 20);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(470, 269);
            this.lvResult.TabIndex = 0;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            this.lvResult.SelectedIndexChanged += new System.EventHandler(this.lvResult_SelectedIndexChanged);
            // 
            // chNodeName
            // 
            this.chNodeName.Text = "이름";
            this.chNodeName.Width = 194;
            // 
            // chParentNodeName
            // 
            this.chParentNodeName.Text = "상위 이름";
            this.chParentNodeName.Width = 164;
            // 
            // chNodeType
            // 
            this.chNodeType.Text = "유형";
            this.chNodeType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNodeType.Width = 80;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.ckXray);
            this.groupBox5.Controls.Add(this.ckFlyToObject);
            this.groupBox5.Location = new System.Drawing.Point(12, 525);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(482, 65);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "결과 보기 옵션";
            // 
            // ckXray
            // 
            this.ckXray.AutoSize = true;
            this.ckXray.Checked = true;
            this.ckXray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckXray.Location = new System.Drawing.Point(154, 32);
            this.ckXray.Name = "ckXray";
            this.ckXray.Size = new System.Drawing.Size(78, 16);
            this.ckXray.TabIndex = 4;
            this.ckXray.Text = "Xray 모드";
            this.ckXray.UseVisualStyleBackColor = true;
            // 
            // ckFlyToObject
            // 
            this.ckFlyToObject.AutoSize = true;
            this.ckFlyToObject.Checked = true;
            this.ckFlyToObject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckFlyToObject.Location = new System.Drawing.Point(19, 32);
            this.ckFlyToObject.Name = "ckFlyToObject";
            this.ckFlyToObject.Size = new System.Drawing.Size(88, 16);
            this.ckFlyToObject.TabIndex = 3;
            this.ckFlyToObject.Text = "개체로 비행";
            this.ckFlyToObject.UseVisualStyleBackColor = true;
            // 
            // SearchNodeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 602);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchNodeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "검색 다이얼로그";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchNodeDialog_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckFullMatch;
        private System.Windows.Forms.CheckBox ckCondition;
        private System.Windows.Forms.CheckBox ckVisibleOnly;
        private System.Windows.Forms.CheckBox ckAssemblyOnly;
        private System.Windows.Forms.CheckBox ckSelectedOnly;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckXray;
        private System.Windows.Forms.CheckBox ckFlyToObject;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader chNodeName;
        private System.Windows.Forms.ColumnHeader chParentNodeName;
        private System.Windows.Forms.ColumnHeader chNodeType;
        private System.Windows.Forms.Label label2;
    }
}