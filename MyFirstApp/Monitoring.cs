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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySqlConnector;
using System.Diagnostics;

namespace MyFirstApp
{
    public partial class Monitoring : Form
    {
        private string connectionString;

        public Monitoring()
        {
            InitializeComponent();
            string spreadPath = Program.Configuration["XmlFilePaths:detected_result_cols"];
            LoadDataGridViewColumns(spreadPath);
            // InitializeImageList();
            connectionString = Program.Configuration.GetConnectionString("MySqlConnectionString");
        }

        // An Event When Monitoring Form Loading
        private void Monitoring_Load(object sender, EventArgs e)
        {
            imageRadioButton.Checked = true;
            textGroupBox.Enabled = false;

            LoadClassInfo();

            /*foreach (string key in imageList.Images.Keys)
            {
                // imageList 각 항목의 index 값 가져오기
                int idx = imageList.Images.IndexOfKey(key);
                // 자체적인 listView collection에 넣어줄 item 생성
                ListViewItem item = new ListViewItem(key, idx);
                // classListView items에 하나씩 추가
                classListView.Items.Add(item);

            }*/
        }

        /*        private void LoadClassInfo()
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "SELECT cls_num, cls_name FROM cls_info";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            MySqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                ClsInfo clsInfo = new ClsInfo
                                {
                                    ClsNum = reader.GetInt32("cls_num"),
                                    ClsName = reader.GetString("cls_name"),
                                };

                                ListViewItem item = new ListViewItem(clsInfo.ClsName)
                                {
                                    ImageIndex = clsInfo.ImageIndex,
                                    Tag = clsInfo,
                                };

                                classListView.Items.Add(item);
                                classCheckedListBox.Items.Add(clsInfo);
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error {ex.Message}");
                        }
                    };

                }*/

        private void LoadClassInfo()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // close를 보장해줌
                try
                {
                    conn.Open();
                    string query = "SELECT cls_num, cls_name FROM cls_info";
                    // 실행
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ClsInfo clsInfo = new ClsInfo()
                        {
                            ClsNum = reader.GetInt32("cls_num"),
                            ClsName = reader.GetString("cls_name")
                        };

                        ListViewItem item = new ListViewItem(clsInfo.ClsName)
                        {
                            ImageIndex = clsInfo.imageIndex,
                            Tag = clsInfo
                        };
                        classListView.Items.Add(item);
                        classCheckedListBox.Items.Add(clsInfo);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error{ex.Message}");
                }
                //connectionString

            }
        }


        // each view clear
        private void clearViewItems(string tag)
        {
            if (tag == "image")
            {
                foreach (ListViewItem item in classListView.SelectedItems)
                {
                    item.Selected = false;
                }
            }
            else if (tag == "text")
            {
                for (int i = 0; i < classCheckedListBox.Items.Count; i++)
                {
                    classCheckedListBox.SetItemChecked(i, false);
                }
            }

        }

        // image view items clear
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearViewItems("image");
        }

        // text view items clear
        private void clear2Button_Click(object sender, EventArgs e)
        {
            clearViewItems("text");
        }

        // object use
        private void imageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (imageRadioButton.Checked)
            {
                clearViewItems("text");
                textGroupBox.Enabled = false;
                imageGroupBox.Enabled = true;
            }

        }

        // event hanlder use
        private void textRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = (RadioButton) sender;
            if (temp != null && temp.Checked)
            {
                clearViewItems("image");
                imageGroupBox.Enabled = false;
                textGroupBox.Enabled = true;
            }
        }

        private void InquiryButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // open connection
                    conn.Open();
                    string query = BuildQuery();
                    // make cmd with query and conn
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // adapter's connection is short, but it can get all data just one time contrary to reader
                    // use more memories than reader
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    // gridview's list
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
            }
        }

        private string BuildQuery()
        {
            // string is an immutable object
            StringBuilder query = new StringBuilder("SELECT * FROM detected_result where 1 = 1");

            List<string> selectedItems = new List<string>();

            // control division by cases
            if (imageRadioButton.Checked)
            {
                foreach (ListViewItem item in classListView.SelectedItems)
                {
                    selectedItems.Add($"{((ClsInfo)item.Tag).ClsNum}");
                }
            }
            else if (textRadioButton.Checked == true)
            {
                foreach (object item in classCheckedListBox.CheckedItems)
                {
                    Console.WriteLine(item);
                    selectedItems.Add($"{((ClsInfo)item).ClsNum}");
                }
            }

            if (selectedItems.Count > 0)
            {
                string inWhere = string.Join('.', selectedItems);
                query.Append($" AND cls_num IN({inWhere})");
            }

            DateTime fromDate = fromDateTimePicker.Value.Date;
            DateTime toDate = toDateTimePicker.Value.Date;
            query.Append($" AND date >= '{fromDate:yyyy-MM-dd}' AND date <= '{toDate:yyyy-MM-dd:23:59:59}'");

            double confidence = 0.0;

            if (double.TryParse(SetRangeValues(confidenceText.Text), out double value))
            {
                confidence = value;
            }

            query.Append($" AND cls_conf >= {confidence}");

            string area = AreaText.Text;

            if (area == "")
            {
                area = "0";
            }

            query.Append($" AND area >= {area}");
            Console.WriteLine(query.ToString());
            return query.ToString();
        }

        private void confidenceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자나 제어문자가 아닐 시, 이벤트 자체를 무시
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                // 입력 자체 불가
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (confidenceText).Text.Contains("."))
            {
                e.Handled = true;
            }

            confidenceText.Text = SetRangeValues(confidenceText.Text);

        }

        /*        private void confidenceText_TextChanged(object sender, EventArgs e)
                {
                    float temp = float.Parse(confidenceText.Text);
                    if (!(temp >= 0.0f && temp <= 1.0))
                    {
                        confidenceText.Text = "";
                    }
                }*/

        // confidence value 0~1 check
        private string SetRangeValues(string text)
        {
            string rightValue = text;

            if (double.TryParse(text, out double value))
            {
                if (value < 0)
                {
                    rightValue = "0.0";
                }
                else if (value > 1)
                {
                    rightValue = "1.0";
                }
            }

            return rightValue;
        }

        private void AreaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자나 제어문자가 아닐 시, 이벤트 자체를 무시
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // 입력 자체 불가
                e.Handled = true;
            }
        }
    }
}
