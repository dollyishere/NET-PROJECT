using System.Xml;

namespace MyFirstApp
{
    partial class Monitoring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitoring));
            tableLayoutPanel1 = new TableLayoutPanel();
            FilterGroupBox = new GroupBox();
            label3 = new Label();
            AreaText = new TextBox();
            label4 = new Label();
            label2 = new Label();
            confidenceText = new TextBox();
            confidenceLabel = new Label();
            label1 = new Label();
            toDateTimePicker = new DateTimePicker();
            fromDateTimePicker = new DateTimePicker();
            InquiryButton = new Button();
            textRadioButton = new RadioButton();
            imageRadioButton = new RadioButton();
            imageGroupBox = new GroupBox();
            panel2 = new Panel();
            classListView = new ListView();
            imageList = new ImageList(components);
            panel1 = new Panel();
            clearButton = new Button();
            textGroupBox = new GroupBox();
            panel4 = new Panel();
            classCheckedListBox = new CheckedListBox();
            panel3 = new Panel();
            clear2Button = new Button();
            dataGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            FilterGroupBox.SuspendLayout();
            imageGroupBox.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            textGroupBox.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(FilterGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(imageGroupBox, 0, 1);
            tableLayoutPanel1.Controls.Add(textGroupBox, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 270F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(900, 472);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // FilterGroupBox
            // 
            tableLayoutPanel1.SetColumnSpan(FilterGroupBox, 2);
            FilterGroupBox.Controls.Add(label3);
            FilterGroupBox.Controls.Add(AreaText);
            FilterGroupBox.Controls.Add(label4);
            FilterGroupBox.Controls.Add(label2);
            FilterGroupBox.Controls.Add(confidenceText);
            FilterGroupBox.Controls.Add(confidenceLabel);
            FilterGroupBox.Controls.Add(label1);
            FilterGroupBox.Controls.Add(toDateTimePicker);
            FilterGroupBox.Controls.Add(fromDateTimePicker);
            FilterGroupBox.Controls.Add(InquiryButton);
            FilterGroupBox.Controls.Add(textRadioButton);
            FilterGroupBox.Controls.Add(imageRadioButton);
            FilterGroupBox.Dock = DockStyle.Fill;
            FilterGroupBox.Location = new Point(3, 3);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(894, 42);
            FilterGroupBox.TabIndex = 0;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Filter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(732, 17);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 11;
            label3.Text = "이상";
            // 
            // AreaText
            // 
            AreaText.Location = new Point(687, 13);
            AreaText.Name = "AreaText";
            AreaText.Size = new Size(39, 23);
            AreaText.TabIndex = 10;
            AreaText.KeyPress += AreaText_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label4.Location = new Point(647, 17);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 9;
            label4.Text = "Area";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(607, 17);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 8;
            label2.Text = "이상";
            // 
            // confidenceText
            // 
            confidenceText.Location = new Point(562, 13);
            confidenceText.Name = "confidenceText";
            confidenceText.Size = new Size(39, 23);
            confidenceText.TabIndex = 7;
            confidenceText.KeyPress += confidenceText_KeyPress;
            // 
            // confidenceLabel
            // 
            confidenceLabel.AutoSize = true;
            confidenceLabel.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            confidenceLabel.Location = new Point(485, 17);
            confidenceLabel.Name = "confidenceLabel";
            confidenceLabel.Size = new Size(71, 15);
            confidenceLabel.TabIndex = 6;
            confidenceLabel.Text = "Confidence";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 17);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 5;
            label1.Text = "~";
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Format = DateTimePickerFormat.Short;
            toDateTimePicker.Location = new Point(364, 13);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(108, 23);
            toDateTimePicker.TabIndex = 4;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Format = DateTimePickerFormat.Short;
            fromDateTimePicker.Location = new Point(229, 13);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(108, 23);
            fromDateTimePicker.TabIndex = 3;
            // 
            // InquiryButton
            // 
            InquiryButton.Dock = DockStyle.Right;
            InquiryButton.Location = new Point(816, 19);
            InquiryButton.Name = "InquiryButton";
            InquiryButton.Size = new Size(75, 20);
            InquiryButton.TabIndex = 2;
            InquiryButton.Text = "Inquiry";
            InquiryButton.UseVisualStyleBackColor = true;
            InquiryButton.Click += InquiryButton_Click;
            // 
            // textRadioButton
            // 
            textRadioButton.AutoSize = true;
            textRadioButton.Location = new Point(116, 17);
            textRadioButton.Name = "textRadioButton";
            textRadioButton.Size = new Size(91, 19);
            textRadioButton.TabIndex = 1;
            textRadioButton.Text = "class by text";
            textRadioButton.UseVisualStyleBackColor = true;
            textRadioButton.CheckedChanged += textRadioButton_CheckedChanged;
            // 
            // imageRadioButton
            // 
            imageRadioButton.AutoSize = true;
            imageRadioButton.Checked = true;
            imageRadioButton.Location = new Point(6, 17);
            imageRadioButton.Name = "imageRadioButton";
            imageRadioButton.Size = new Size(104, 19);
            imageRadioButton.TabIndex = 0;
            imageRadioButton.TabStop = true;
            imageRadioButton.Text = "class by image";
            imageRadioButton.UseVisualStyleBackColor = true;
            imageRadioButton.CheckedChanged += imageRadioButton_CheckedChanged;
            // 
            // imageGroupBox
            // 
            imageGroupBox.Controls.Add(panel2);
            imageGroupBox.Controls.Add(panel1);
            imageGroupBox.Dock = DockStyle.Fill;
            imageGroupBox.Location = new Point(3, 51);
            imageGroupBox.Name = "imageGroupBox";
            imageGroupBox.Size = new Size(624, 264);
            imageGroupBox.TabIndex = 1;
            imageGroupBox.TabStop = false;
            imageGroupBox.Text = "class by image";
            // 
            // panel2
            // 
            panel2.Controls.Add(classListView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 211);
            panel2.TabIndex = 1;
            // 
            // classListView
            // 
            classListView.Dock = DockStyle.Fill;
            classListView.LargeImageList = imageList;
            classListView.Location = new Point(0, 0);
            classListView.Name = "classListView";
            classListView.Size = new Size(618, 211);
            classListView.SmallImageList = imageList;
            classListView.StateImageList = imageList;
            classListView.TabIndex = 0;
            classListView.UseCompatibleStateImageBehavior = false;
            classListView.View = View.SmallIcon;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "person");
            imageList.Images.SetKeyName(1, "bicycle");
            imageList.Images.SetKeyName(2, "car");
            imageList.Images.SetKeyName(3, "motorcycle");
            imageList.Images.SetKeyName(4, "airplane");
            imageList.Images.SetKeyName(5, "bus");
            imageList.Images.SetKeyName(6, "train");
            imageList.Images.SetKeyName(7, "truck");
            imageList.Images.SetKeyName(8, "boat");
            imageList.Images.SetKeyName(9, "traffic light");
            imageList.Images.SetKeyName(10, "fire hydrant");
            imageList.Images.SetKeyName(11, "stop sign");
            imageList.Images.SetKeyName(12, "parking meter");
            imageList.Images.SetKeyName(13, "bench");
            imageList.Images.SetKeyName(14, "bird");
            imageList.Images.SetKeyName(15, "cat");
            imageList.Images.SetKeyName(16, "dog");
            imageList.Images.SetKeyName(17, "horse");
            imageList.Images.SetKeyName(18, "sheep");
            imageList.Images.SetKeyName(19, "cow");
            imageList.Images.SetKeyName(20, "elephant");
            imageList.Images.SetKeyName(21, "bear");
            imageList.Images.SetKeyName(22, "zebra");
            imageList.Images.SetKeyName(23, "giraffe");
            imageList.Images.SetKeyName(24, "backpack");
            imageList.Images.SetKeyName(25, "umbrella");
            imageList.Images.SetKeyName(26, "handbag");
            imageList.Images.SetKeyName(27, "tie");
            imageList.Images.SetKeyName(28, "suitcase");
            imageList.Images.SetKeyName(29, "frisbee");
            imageList.Images.SetKeyName(30, "skis");
            imageList.Images.SetKeyName(31, "snowboard");
            imageList.Images.SetKeyName(32, "sports ball");
            imageList.Images.SetKeyName(33, "kite");
            imageList.Images.SetKeyName(34, "baseball bat");
            imageList.Images.SetKeyName(35, "baseball glove");
            imageList.Images.SetKeyName(36, "skateboard");
            imageList.Images.SetKeyName(37, "surfboard");
            imageList.Images.SetKeyName(38, "tennis racket");
            imageList.Images.SetKeyName(39, "bottle");
            imageList.Images.SetKeyName(40, "wine glass");
            imageList.Images.SetKeyName(41, "cup");
            imageList.Images.SetKeyName(42, "fork");
            imageList.Images.SetKeyName(43, "knife");
            imageList.Images.SetKeyName(44, "spoon");
            imageList.Images.SetKeyName(45, "bowl");
            imageList.Images.SetKeyName(46, "banana");
            imageList.Images.SetKeyName(47, "apple");
            imageList.Images.SetKeyName(48, "sandwich");
            imageList.Images.SetKeyName(49, "orange");
            imageList.Images.SetKeyName(50, "broccoli");
            imageList.Images.SetKeyName(51, "carrot");
            imageList.Images.SetKeyName(52, "hot dog");
            imageList.Images.SetKeyName(53, "pizza");
            imageList.Images.SetKeyName(54, "donut");
            imageList.Images.SetKeyName(55, "cake");
            imageList.Images.SetKeyName(56, "chair");
            imageList.Images.SetKeyName(57, "couch");
            imageList.Images.SetKeyName(58, "potted plant");
            imageList.Images.SetKeyName(59, "bed");
            imageList.Images.SetKeyName(60, "dining table");
            imageList.Images.SetKeyName(61, "toilet");
            imageList.Images.SetKeyName(62, "tv");
            imageList.Images.SetKeyName(63, "laptop");
            imageList.Images.SetKeyName(64, "mouse");
            imageList.Images.SetKeyName(65, "remote");
            imageList.Images.SetKeyName(66, "keyboard");
            imageList.Images.SetKeyName(67, "cell phone");
            imageList.Images.SetKeyName(68, "microwave");
            imageList.Images.SetKeyName(69, "oven");
            imageList.Images.SetKeyName(70, "toaster");
            imageList.Images.SetKeyName(71, "sink");
            imageList.Images.SetKeyName(72, "refrigerator");
            imageList.Images.SetKeyName(73, "book");
            imageList.Images.SetKeyName(74, "clock");
            imageList.Images.SetKeyName(75, "vase");
            imageList.Images.SetKeyName(76, "scissors");
            imageList.Images.SetKeyName(77, "teddy bear");
            imageList.Images.SetKeyName(78, "hair drier");
            imageList.Images.SetKeyName(79, "toothbrush");
            // 
            // panel1
            // 
            panel1.Controls.Add(clearButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 31);
            panel1.TabIndex = 0;
            // 
            // clearButton
            // 
            clearButton.Dock = DockStyle.Right;
            clearButton.Location = new Point(543, 0);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 31);
            clearButton.TabIndex = 0;
            clearButton.Text = "clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // textGroupBox
            // 
            textGroupBox.Controls.Add(panel4);
            textGroupBox.Controls.Add(panel3);
            textGroupBox.Dock = DockStyle.Fill;
            textGroupBox.Location = new Point(633, 51);
            textGroupBox.Name = "textGroupBox";
            textGroupBox.Size = new Size(264, 264);
            textGroupBox.TabIndex = 2;
            textGroupBox.TabStop = false;
            textGroupBox.Text = "class by text";
            // 
            // panel4
            // 
            panel4.Controls.Add(classCheckedListBox);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 211);
            panel4.TabIndex = 1;
            // 
            // classCheckedListBox
            // 
            classCheckedListBox.Dock = DockStyle.Fill;
            classCheckedListBox.FormattingEnabled = true;
            classCheckedListBox.Location = new Point(0, 0);
            classCheckedListBox.Name = "classCheckedListBox";
            classCheckedListBox.Size = new Size(258, 211);
            classCheckedListBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(clear2Button);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 31);
            panel3.TabIndex = 0;
            // 
            // clear2Button
            // 
            clear2Button.Dock = DockStyle.Right;
            clear2Button.Location = new Point(183, 0);
            clear2Button.Name = "clear2Button";
            clear2Button.Size = new Size(75, 31);
            clear2Button.TabIndex = 0;
            clear2Button.Text = "clear";
            clear2Button.UseVisualStyleBackColor = true;
            clear2Button.Click += clear2Button_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView, 2);
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 321);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(894, 148);
            dataGridView.TabIndex = 3;
            // 
            // Monitoring
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 472);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Monitoring";
            Text = "객체 인식 데이터";
            Load += Monitoring_Load;
            tableLayoutPanel1.ResumeLayout(false);
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
            imageGroupBox.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            textGroupBox.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        // load xml data and add in dataGridView
        private void LoadDataGridViewColumns(string xmlFilePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            XmlNodeList colList = xmlDoc.SelectNodes("/DataGridViewColumns/Column");

            if (colList != null)
            {
                foreach (XmlNode node in colList)
                {
                    /*
                     	<DataPropertyName>date</DataPropertyName>
		                <HeaderText>Date</HeaderText>
		                <MinimumWidth>8</MinimumWidth>
		                <Width>300</Width>
                     */

                    string dataPropertyName = node["DataPropertyName"].InnerText;
                    string headerText = node["HeaderText"].InnerText;
                    int minimumWidth = int.Parse(node["MinimumWidth"].InnerText);
                    int width = int.Parse(node["Width"].InnerText);

                    // traditional
                    /* DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();

                    column2.MinimumWidth = minimumWidth;
                    column2.Width = width;
                    column2.HeaderText = headerText;
                    column2.Name = dataPropertyName;*/

                    // new(Builder?)
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                    {
                        MinimumWidth = minimumWidth,
                        Width = width,
                        DataPropertyName = dataPropertyName,
                        HeaderText = headerText,
                    };

                    dataGridView.Columns.Add(column);

                }
            }

        }
        
        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox FilterGroupBox;
        private RadioButton textRadioButton;
        private RadioButton imageRadioButton;
        private GroupBox imageGroupBox;
        private GroupBox textGroupBox;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Button clearButton;
        private Button clear2Button;
        private ListView classListView;
        private CheckedListBox classCheckedListBox;
        private ImageList imageList;
        private DataGridView dataGridView;
        private Button InquiryButton;
        private Label label1;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private Label confidenceLabel;
        private TextBox confidenceText;
        private Label label3;
        private TextBox AreaText;
        private Label label4;
        private Label label2;
    }
}