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
    public partial class LoginCon : UserControl
    {
        public LoginCon()
        {
            InitializeComponent();
        }

        public string Id
        {
            get { return idTextBox.Text; }
        }

        public string Password
        {
            get { return passwordTextBox.Text; }
        }
    }
}
