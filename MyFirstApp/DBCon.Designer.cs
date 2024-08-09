namespace MyFirstApp
{
    partial class DBCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBCon));
            dbInfoGroup = new GroupBox();
            txtPort = new TextBox();
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            txtPassword = new TextBox();
            txtUserId = new TextBox();
            pwdInputLabel = new Label();
            userIdInputLabel = new Label();
            txtDatabase = new TextBox();
            dbInputLabel = new Label();
            txtServer = new TextBox();
            serverInputLabel = new Label();
            dbInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dbInfoGroup
            // 
            dbInfoGroup.Controls.Add(txtPort);
            dbInfoGroup.Controls.Add(pictureBox1);
            dbInfoGroup.Controls.Add(btnSave);
            dbInfoGroup.Controls.Add(txtPassword);
            dbInfoGroup.Controls.Add(txtUserId);
            dbInfoGroup.Controls.Add(pwdInputLabel);
            dbInfoGroup.Controls.Add(userIdInputLabel);
            dbInfoGroup.Controls.Add(txtDatabase);
            dbInfoGroup.Controls.Add(dbInputLabel);
            dbInfoGroup.Controls.Add(txtServer);
            dbInfoGroup.Controls.Add(serverInputLabel);
            dbInfoGroup.Dock = DockStyle.Fill;
            dbInfoGroup.Location = new Point(0, 0);
            dbInfoGroup.Name = "dbInfoGroup";
            dbInfoGroup.Size = new Size(300, 260);
            dbInfoGroup.TabIndex = 0;
            dbInfoGroup.TabStop = false;
            dbInfoGroup.Text = "DB info";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(244, 33);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(40, 23);
            txtPort.TabIndex = 10;
            txtPort.KeyPress += txtPort_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(104, 188);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(104, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(180, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(104, 107);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(180, 23);
            txtUserId.TabIndex = 6;
            // 
            // pwdInputLabel
            // 
            pwdInputLabel.AutoSize = true;
            pwdInputLabel.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            pwdInputLabel.Location = new Point(17, 146);
            pwdInputLabel.Name = "pwdInputLabel";
            pwdInputLabel.Size = new Size(66, 15);
            pwdInputLabel.TabIndex = 5;
            pwdInputLabel.Text = "Password:";
            // 
            // userIdInputLabel
            // 
            userIdInputLabel.AutoSize = true;
            userIdInputLabel.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            userIdInputLabel.Location = new Point(17, 110);
            userIdInputLabel.Name = "userIdInputLabel";
            userIdInputLabel.Size = new Size(54, 15);
            userIdInputLabel.TabIndex = 4;
            userIdInputLabel.Text = "User ID:";
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(104, 71);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(180, 23);
            txtDatabase.TabIndex = 3;
            // 
            // dbInputLabel
            // 
            dbInputLabel.AutoSize = true;
            dbInputLabel.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            dbInputLabel.Location = new Point(17, 74);
            dbInputLabel.Name = "dbInputLabel";
            dbInputLabel.Size = new Size(66, 15);
            dbInputLabel.TabIndex = 2;
            dbInputLabel.Text = "Database:";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(104, 33);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(140, 23);
            txtServer.TabIndex = 1;
            // 
            // serverInputLabel
            // 
            serverInputLabel.AutoSize = true;
            serverInputLabel.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            serverInputLabel.Location = new Point(17, 36);
            serverInputLabel.Name = "serverInputLabel";
            serverInputLabel.Size = new Size(47, 15);
            serverInputLabel.TabIndex = 0;
            serverInputLabel.Text = "Server:";
            // 
            // DBCon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dbInfoGroup);
            Name = "DBCon";
            Size = new Size(300, 260);
            dbInfoGroup.ResumeLayout(false);
            dbInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox dbInfoGroup;
        private PictureBox pictureBox1;
        private Button btnSave;
        private TextBox txtPassword;
        private TextBox txtUserId;
        private Label pwdInputLabel;
        private Label userIdInputLabel;
        private TextBox txtDatabase;
        private Label dbInputLabel;
        private TextBox txtServer;
        private Label serverInputLabel;
        private TextBox txtPort;
    }
}
