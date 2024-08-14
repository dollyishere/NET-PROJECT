using System.Windows.Forms;
using System.Xml;

namespace MyFirstApp
{
    partial class ClsCode
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
            txtFilter = new TextBox();
            searchButton = new Button();
            newButton = new Button();
            saveButton = new Button();
            txtClsName = new TextBox();
            txtClsNum = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            deleteButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            contextMenuStrip = new ContextMenuStrip(components);
            newItem = new ToolStripMenuItem();
            saveItem = new ToolStripMenuItem();
            deleteItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Dock = DockStyle.Fill;
            txtFilter.Location = new Point(3, 3);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(312, 23);
            txtFilter.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Dock = DockStyle.Fill;
            searchButton.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            searchButton.Location = new Point(321, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(74, 22);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // newButton
            // 
            newButton.Dock = DockStyle.Fill;
            newButton.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            newButton.Location = new Point(203, 3);
            newButton.Name = "newButton";
            newButton.Size = new Size(64, 24);
            newButton.TabIndex = 2;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Fill;
            saveButton.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            saveButton.Location = new Point(273, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(58, 24);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // txtClsName
            // 
            txtClsName.Dock = DockStyle.Fill;
            txtClsName.Location = new Point(55, 3);
            txtClsName.Name = "txtClsName";
            txtClsName.Size = new Size(142, 23);
            txtClsName.TabIndex = 5;
            // 
            // txtClsNum
            // 
            txtClsNum.Dock = DockStyle.Fill;
            txtClsNum.Location = new Point(3, 3);
            txtClsNum.Name = "txtClsNum";
            txtClsNum.ReadOnly = true;
            txtClsNum.Size = new Size(46, 23);
            txtClsNum.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.24083F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Controls.Add(txtFilter, 0, 0);
            tableLayoutPanel1.Controls.Add(searchButton, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(398, 28);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.Controls.Add(saveButton, 3, 0);
            tableLayoutPanel2.Controls.Add(txtClsNum, 0, 0);
            tableLayoutPanel2.Controls.Add(txtClsName, 1, 0);
            tableLayoutPanel2.Controls.Add(newButton, 2, 0);
            tableLayoutPanel2.Controls.Add(deleteButton, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 28);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(398, 30);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // deleteButton
            // 
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            deleteButton.Location = new Point(337, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(58, 24);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 58);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(398, 292);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(392, 286);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { newItem, saveItem, deleteItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(109, 70);
            // 
            // newItem
            // 
            newItem.Name = "newItem";
            newItem.Size = new Size(108, 22);
            newItem.Text = "New";
            newItem.Click += newButton_Click;
            // 
            // saveItem
            // 
            saveItem.Name = "saveItem";
            saveItem.Size = new Size(108, 22);
            saveItem.Text = "Save";
            saveItem.Click += saveButton_Click;
            // 
            // deleteItem
            // 
            deleteItem.Name = "deleteItem";
            deleteItem.Size = new Size(108, 22);
            deleteItem.Text = "Delete";
            deleteItem.Click += deleteButton_Click;
            // 
            // ClsCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 350);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "ClsCode";
            Text = "Class Codes";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private void LoadDataGridViewColumns(string xmlFilePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            XmlNodeList colList = xmlDoc.SelectNodes("/DataGridViewColumns/Column");

            if (colList != null)
            {
                foreach (XmlNode node in colList)
                {
                    string dataPropertyName = node["DataPropertyName"].InnerText;
                    string headerText = node["HeaderText"].InnerText;
                    int minimumWidth = int.Parse(node["MinimumWidth"].InnerText);
                    int width = int.Parse(node["Width"].InnerText);
                    bool readOnly = bool.Parse(node["ReadOnly"]?.InnerText ?? "false");

                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                    {
                        MinimumWidth = minimumWidth,
                        Width = width,
                        DataPropertyName = dataPropertyName,
                        HeaderText = headerText,
                        ReadOnly = true
                    };

                    dataGridView1.Columns.Add(column);

                }
            }

        }

        private TextBox txtFilter;
        private Button searchButton;
        private Button newButton;
        private Button saveButton;
        private TextBox txtClsName;
        private TextBox txtClsNum;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
        private Button deleteButton;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem newItem;
        private ToolStripMenuItem saveItem;
        private ToolStripMenuItem deleteItem;
    }
}