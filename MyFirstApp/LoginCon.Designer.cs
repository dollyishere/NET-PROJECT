namespace MyFirstApp
{
    partial class LoginCon
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
            idLabel = new Label();
            passwordLabel = new Label();
            idTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(3, 16);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(19, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(3, 42);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(68, 10);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(120, 23);
            idTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(68, 39);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(120, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // LoginCon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(passwordTextBox);
            Controls.Add(idTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(idLabel);
            Name = "LoginCon";
            Size = new Size(191, 73);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label passwordLabel;
        private TextBox idTextBox;
        private TextBox passwordTextBox;
    }
}
