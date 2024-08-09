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
    public partial class AboutBoxForm : Form
    {
        public AboutBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutBoxForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals("C") || e.KeyChar.Equals('c')) // 'C' 키를 눌렀을 때
            {
                this.Close(); // 폼을 닫음
            }
        }
    }
}
