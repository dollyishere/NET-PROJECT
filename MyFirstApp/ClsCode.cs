using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
// using MySql.Data.MySqlClient;
using MySqlConnector;

namespace MyFirstApp
{
    public partial class ClsCode : Form
    {
        private string connectionString;
        private BindingSource bindingSource;

        public ClsCode()
        {
            InitializeComponent();
            string spreadPath = Program.Configuration["XmlFilePaths:cls_info_cols"];
            LoadDataGridViewColumns(spreadPath);

            connectionString = Program.Configuration.GetConnectionString("MySqlConnectionString");

            bindingSource = new BindingSource();

            // ClsInfo를 여러 개 담는 bindingSource를 생성(쉽게 처리 가능하도록)
            // 하지만 그냥 넣지 않고 binding 시킴 => 어떤 특정 컨트롤에 착 달라붙어서 유기적으로 돌아감
            // 변경사항 있으면 자동으로 반영되게 하려면 Binding 사용하면 ㅇㅋ
            bindingSource.DataSource = new BindingList<ClsInfo>();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource;

            txtClsNum.DataBindings.Add("Text", bindingSource, "ClsNum", true, DataSourceUpdateMode.OnPropertyChanged);
            txtClsName.DataBindings.Add("Text", bindingSource, "ClsName", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadData(txtFilter.Text);
        }

        private void LoadData(string filter = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM cls_info ";
                    if (!string.IsNullOrEmpty(filter))
                    {
                        query += "WHERE cls_name LIKE @filter ";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(filter))
                    {
                        cmd.Parameters.AddWithValue("@filter", filter + "%");
                    }
                    /*                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                                        DataTable dataTable = new DataTable();
                                        adapter.Fill(dataTable);

                                        dataGridView1.DataSource = dataTable;*/

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        var clsInfoList = (BindingList<ClsInfo>)bindingSource.DataSource;
                        clsInfoList.Clear();

                        while (reader.Read())
                        {
                            /*                        clsInfoList.Add(new ClsInfo
                                                    {
                                                        ClsNum = reader.GetInt32("cls_num"),
                                                        ClsName = reader.GetString("cls_name"),
                                                    });*/

                            ClsInfo clsInfo = new ClsInfo();
                            clsInfo.ClsNum = reader.GetInt32("cls_num");
                            clsInfo.ClsName = reader.GetString("cls_name");
                            clsInfoList.Add(clsInfo);
                        }

                        // reader.Close();
                    };


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }

                // 변경된 데이터만 반영시키기
                bindingSource.ResetBindings(false);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            var newClsInfo = new ClsInfo();
            newClsInfo.IsDirty = true;

            var clsInfoList = (BindingList<ClsInfo>)bindingSource.DataSource;
            clsInfoList.Add(newClsInfo);

            // ((BindingList<ClsInfo>)bindingSource.DataSource).Add(newClsInfo);

            // 위치 몇 번이었는지 받기 => 자동 증가
            bindingSource.Position = bindingSource.IndexOf(newClsInfo);
            newClsInfo.ClsNum = bindingSource.Position;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // current를 사용하면 현재 선택된 게 어떤건지, 주변에는 뭐가 있는지 알 수 있음
            var currentClsInfo = (ClsInfo)bindingSource.Current;
            // SaveData(currentClsInfo);
            SaveMultiData();
            bindingSource.ResetBindings(false);
        }

        // 단일 객체 저장
        private void SaveData(ClsInfo clsInfo)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                       INSERT INTO cls_info (cls_num, cls_name)
                       VALUES(@cls_num, @cls_name)
                       ON DUPLICATE KEY
                       UPDATE cls_name = VALUES(cls_name);
                     ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cls_num", clsInfo.ClsNum);
                        cmd.Parameters.AddWithValue("@cls_name", clsInfo.ClsName);

                        cmd.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"error : {ex.Message}");
                }
            }
        }
        // 다중 데이터 저장(IsDirty 값 변경)
        private void SaveMultiData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {  
                    conn.Open();

                    // BeginTransaction은 rollback 시키거나 commit 시키는 start position을 세팅해두는 것임
                    using (MySqlTransaction transaction = conn.BeginTransaction()) {
                        try {
                            string query = @"
                               INSERT INTO cls_info (cls_num, cls_name)
                               VALUES(@cls_num, @cls_name)
                               ON DUPLICATE KEY
                               UPDATE cls_name = VALUES(cls_name);
                             ";

                            using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
                            {
                                foreach (ClsInfo clsInfo in bindingSource.List)
                                {
                                    // 값 변경이 됐을 때, db 값 저장 or 수정
                                    if (clsInfo.IsDirty)
                                    {
                                        cmd.Parameters.AddWithValue("@cls_num", clsInfo.ClsNum);
                                        cmd.Parameters.AddWithValue("@cls_name", clsInfo.ClsName);

                                        cmd.ExecuteNonQuery();

                                        clsInfo.IsDirty = false;
                                    }
                                }
                            }
                            transaction.Commit();
                    }   catch (Exception ex) {
                        transaction.Rollback();
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
               
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var currentClsInfo = (ClsInfo)bindingSource.Current;
            MessageBox.Show($"DELETE DATA: The class number is {currentClsInfo.ClsNum}");
            deleteData(currentClsInfo);
            bindingSource.RemoveCurrent();
            bindingSource.ResetBindings(false);
        }

        private void deleteData(ClsInfo clsInfo)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                       DELETE FROM cls_info
                       WHERE cls_num = @cls_num;
                     ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cls_num", clsInfo.ClsNum);

                        cmd.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"error : {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 데이터들 중에서 값이 변경된 아이들의 데이터와 연결된 애들을 가져옴
                var clsInfo = (ClsInfo) dataGridView1.Rows[e.RowIndex].DataBoundItem;
                clsInfo.IsDirty = true;
            }
        }
    }

}
