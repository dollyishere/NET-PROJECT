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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Dock = DockStyle.Fill;
            lblProductName.Location = new Point(3, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(294, 30);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "제품명";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Dock = DockStyle.Fill;
            lblVersion.Location = new Point(3, 30);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(294, 30);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "버전";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Dock = DockStyle.Fill;
            lblCopyright.Location = new Point(3, 60);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(294, 30);
            lblCopyright.TabIndex = 2;
            lblCopyright.Text = "저작권";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Dock = DockStyle.Fill;
            lblCompany.Location = new Point(3, 90);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(294, 30);
            lblCompany.TabIndex = 3;
            lblCompany.Text = "회사 이름";
            // 
            // textDesc
            // 
            textDesc.Location = new Point(3, 123);
            textDesc.Multiline = true;
            textDesc.Name = "textDesc";
            textDesc.ReadOnly = true;
            textDesc.Size = new Size(294, 179);
            textDesc.TabIndex = 4;
            textDesc.Text = "설명";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblProductName, 0, 0);
            tableLayoutPanel1.Controls.Add(textDesc, 0, 4);
            tableLayoutPanel1.Controls.Add(lblVersion, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCompany, 0, 3);
            tableLayoutPanel1.Controls.Add(lblCopyright, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(300, 305);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // AboutControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AboutControl";
            Size = new Size(300, 305);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblProductName;
        private Label lblVersion;
        private Label lblCopyright;
        private Label lblCompany;
        private TextBox textDesc;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
