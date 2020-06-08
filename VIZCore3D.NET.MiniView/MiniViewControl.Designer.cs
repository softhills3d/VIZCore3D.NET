namespace VIZCore3D.NET.MiniView
{
    partial class MiniViewControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbMiniView = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbMiniView
            // 
            this.gbMiniView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMiniView.Location = new System.Drawing.Point(0, 0);
            this.gbMiniView.Name = "gbMiniView";
            this.gbMiniView.Size = new System.Drawing.Size(320, 239);
            this.gbMiniView.TabIndex = 0;
            this.gbMiniView.TabStop = false;
            this.gbMiniView.Text = "Mini View";
            // 
            // MiniViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMiniView);
            this.Name = "MiniViewControl";
            this.Size = new System.Drawing.Size(320, 239);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMiniView;
    }
}
