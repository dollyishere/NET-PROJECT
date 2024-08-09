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

namespace MyFirstApp
{
    public partial class Monitoring : Form
    {
        public Monitoring()
        {
            InitializeComponent();
            LoadDataGridViewColumns("detected_result_cols.xml");
            // InitializeImageList();
        }

        private void classListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeImageList()
        {
            imageList = new ImageList();

            // 이미지 파일명 리스트
            string[] imageNames = new string[]
            {
                "person", "bicycle", "car", "motorcycle", "airplane",
                "bus", "train", "truck", "boat", "traffic_light",
                "fire_hydrant", "stop_sign", "parking_meter", "bench",
                "bird", "cat", "dog", "horse", "sheep", "cow",
                "elephant", "bear", "zebra", "giraffe", "backpack",
                "umbrella", "handbag", "tie", "suitcase", "frisbee",
                "skis", "snowboard", "sports_ball", "kite", "baseball_bat",
                "baseball_glove", "skateboard", "surfboard", "tennis_racket",
                "bottle", "wine_glass", "cup", "fork", "knife", "spoon",
                "bowl", "banana", "apple", "sandwich", "orange", "broccoli",
                "carrot", "hot_dog", "pizza", "donut", "cake", "chair",
                "couch", "potted_plant", "bed", "dining_table", "toilet",
                "tv", "laptop", "mouse", "remote", "keyboard", "cell_phone",
                "microwave", "oven", "toaster", "sink", "refrigerator",
                "book", "clock", "vase", "scissors", "teddy_bear",
                "hair_drier", "toothbrush"
            };

            // 리소스에서 이미지를 불러와 ImageList에 추가 및 키 설정
            foreach (string name in imageNames)
            {
                var image = (Image)Properties.Resources.ResourceManager.GetObject(name);
                if (image != null)
                {
                    imageList.Images.Add(image);
                    imageList.Images.SetKeyName(imageList.Images.Count - 1, name);
                }
                else
                {
                    Console.WriteLine($"Resource not found: {name}");
                }
            }

            // 예시로 ListView에 ImageList를 연결
            classListView.LargeImageList = imageList;
            classListView.SmallImageList = imageList;
        }

        // An Event When Monitoring Form Loading
        private void Monitoring_Load(object sender, EventArgs e)
        {
            imageRadioButton.Checked = true;
            textGroupBox.Enabled = false;

            foreach (string key in imageList.Images.Keys)
            {
                // imageList 각 항목의 index 값 가져오기
                int idx = imageList.Images.IndexOfKey(key);
                // 자체적인 listView collection에 넣어줄 item 생성
                ListViewItem item = new ListViewItem(key, idx);
                // classListView items에 하나씩 추가
                classListView.Items.Add(item);

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
            } else if (tag == "text")
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
            RadioButton temp = (RadioButton)sender;
            if (temp != null && temp.Checked)
            {
                clearViewItems("image");
                imageGroupBox.Enabled = false;
                textGroupBox.Enabled = true;
            }
        }
    }
}
