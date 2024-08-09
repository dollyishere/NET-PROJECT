namespace MyFirstApp
{
    partial class AboutControl
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
            lblProductName = new Label();
            lblVersion = new Label();
            lblCopyright = new Label();
            lblCompany = new Label();
            textDesc = new TextBox();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(3, 11);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(43, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "제품명";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(3, 42);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(31, 15);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "버전";
            lblVersion.Click += label2_Click;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Location = new Point(3, 73);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(43, 15);
            lblCopyright.TabIndex = 2;
            lblCopyright.Text = "저작권";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(3, 104);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(59, 15);
            lblCompany.TabIndex = 3;
            lblCompany.Text = "회사 이름";
            // 
            // textDesc
            // 
            textDesc.Dock = DockStyle.Bottom;
            textDesc.Location = new Point(0, 138);
            textDesc.Multiline = true;
            textDesc.Name = "textDesc";
            textDesc.ReadOnly = true;
            textDesc.Size = new Size(300, 167);
            textDesc.TabIndex = 4;
            textDesc.Text = "설명";
            // 
            // AboutControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textDesc);
            Controls.Add(lblCompany);
            Controls.Add(lblCopyright);
            Controls.Add(lblVersion);
            Controls.Add(lblProductName);
            Name = "AboutControl";
            Size = new Size(300, 305);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblVersion;
        private Label lblCopyright;
        private Label lblCompany;
        private TextBox textDesc;
    }
}
