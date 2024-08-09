namespace MyFirstApp
{
    partial class AboutBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBoxForm));
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            aboutControl1 = new AboutControl();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(aboutControl1);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(446, 349);
            splitContainer1.SplitterDistance = 148;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(10, 5, 10, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(3);
            pictureBox1.Size = new Size(148, 349);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // aboutControl1
            // 
            aboutControl1.Dock = DockStyle.Top;
            aboutControl1.Location = new Point(0, 0);
            aboutControl1.Margin = new Padding(10);
            aboutControl1.Name = "aboutControl1";
            aboutControl1.Size = new Size(294, 301);
            aboutControl1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(207, 314);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "확인(&C)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AboutBoxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 349);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBoxForm";
            Text = "About MyDB";
            KeyPress += AboutBoxForm_KeyPress;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button button1;
        private AboutControl aboutControl1;
    }
}