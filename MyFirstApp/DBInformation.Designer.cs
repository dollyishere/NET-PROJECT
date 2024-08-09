namespace MyFirstApp
{
    partial class DBInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBInformation));
            dbCon1 = new DBCon();
            SuspendLayout();
            // 
            // dbCon1
            // 
            dbCon1.Dock = DockStyle.Fill;
            dbCon1.Location = new Point(10, 10);
            dbCon1.Name = "dbCon1";
            dbCon1.Size = new Size(304, 261);
            dbCon1.TabIndex = 0;
            // 
            // DBInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 281);
            Controls.Add(dbCon1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DBInformation";
            Padding = new Padding(10);
            Text = "DBInformation";
            ResumeLayout(false);
        }

        #endregion

        private DBCon dbCon1;
    }
}