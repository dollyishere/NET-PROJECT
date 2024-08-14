using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;

namespace MyFirstApp
{
    public partial class LoginForm : Form
    {
        private string connectionString;

        // boolean 변수명은 보통 is~로 시작함
        public bool isAuthenticated { get; set; } = false;

        public LoginForm()
        {
            InitializeComponent();
            connectionString = Program.Configuration.GetConnectionString("MySqlConnectionString");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = loginCon1.Id.ToString();
            string password = loginCon1.Password.ToString();

            if (AuthenticatedUser(userName, password))
            {
                isAuthenticated = true;
/*                MDI mDI = new MDI();
                this.Hide();
                mDI.Show();*/
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid User", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // 어플리케이션 강제 종료
                Application.Exit();

            }
        }

        private bool AuthenticatedUser(string userName, string password)
        {
            int result = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = """
                        SELECT COUNT(1) FROM users 
                        WHERE username = @username AND password_hash = @passwordHash
                        """;
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@username", userName);
                            cmd.Parameters.AddWithValue("@passwordHash", EncryptPassword(password));

                            // ExecuteScalar로 단일 값 가져오는 것이 가능
                            result = Convert.ToInt32(cmd.ExecuteScalar());


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
            }

            return result > 0;
        }

        private string EncryptPassword(string password)

        {

            // 실제 암호화 로직을 여기에 구현해야 합니다.

            // 예: SHA-256 해시

            //SHA - 256은 Secure Hash Algorithm 256 - bit의 약자로, 256비트 길이의 해시 값을 생성하는 암호학적 해시 함수입니다.

            //SHA256.Create() 메서드는 SHA-256 해시 알고리즘을 구현한 객체를 생성합니다.

            //해시 함수는 바이트 배열을 입력으로 받기 때문에 문자열을 바이트 배열로 변환하는 과정이 필요

            //x2 형식 지정자는 각 바이트를 두 자리 16진수로 나타내며, 결과적으로 모든 바이트가 16진수 문자열로 변환됩니다.

            using (SHA256 sha256 = SHA256.Create())

            {

                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)

                {

                    builder.Append(b.ToString("x2"));

                }

                return builder.ToString();

            }

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
    }
}
