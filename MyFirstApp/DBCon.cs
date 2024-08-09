using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class DBCon : UserControl
    {
        private string connectionString;

        public DBCon()
        {
            InitializeComponent();
            LoadConfiguration();
            DisplayCurrentConnString();
        }

        // port 번호 입력 시 숫자 & 제어문자 이외는 입력 불가 이벤트
        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자나 제어문자가 아닐 시, 이벤트 자체를 무시
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // 입력 자체 불가
                e.Handled = true;
            }
        }

        // load json information
        private void LoadConfiguration()
        {
            // "Server=192.168.0.47;Port=3306;Database=iot_db;User Id=pi;Password=pi1234!;"
            connectionString = Program.Configuration.GetConnectionString("MySqlConnectionString");

        }

        // input db info auto
        private void DisplayCurrentConnString()
        {
            if (connectionString != null)
            {
                // data parsing
                var connectionStringBuilder = new MySqlConnectionStringBuilder(connectionString);
                txtServer.Text = connectionStringBuilder.Server;
                txtPort.Text = connectionStringBuilder.Port.ToString();
                txtDatabase.Text = connectionStringBuilder.Database;
                txtUserId.Text = connectionStringBuilder.UserID;
                txtPassword.Text = connectionStringBuilder.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // data parsing
            var connectionStringBuilder = new MySqlConnectionStringBuilder()
            {
                Server = txtServer.Text,
                // uint는 unsigned integer의 약자로, 부호가 없는 32비트 정수형 데이터 타입
                Port = uint.Parse(txtPort.Text),
                Database = txtDatabase.Text,
                UserID = txtUserId.Text,
                Password = txtPassword.Text
            };

            MessageBox.Show("Saved Successful");

            SavedConnectionString("MySqlConnectionString", connectionStringBuilder.ConnectionString);

        }

        private void SavedConnectionString(string tag, string connectionString)
        {
            var json = File.ReadAllText("appsettings.json");
            // json 파일 불러와서 자동 구조화 시킴
            dynamic jsonObj = JsonConvert.DeserializeObject<dynamic>(json);

            // connectionString 관련 값 변경
            jsonObj["ConnectionStrings"][tag] = connectionString;

            // 수정본 string으로 다시 변환한 뒤 json로 다시 저장
            string output = JsonConvert.SerializeObject(jsonObj,
                Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("appsettings.json", output);
        }
    }
}
