using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class AboutControl : UserControl
    {
        private Assembly assembly;

        public AboutControl()
        {
            InitializeComponent();
            assembly = Assembly.GetExecutingAssembly();
     
            lblCompany.Text = AssemblyCompany;
            lblCopyright.Text = AssemblyCopyright;
            lblProductName.Text = AssemblyProduct;
            lblVersion.Text = AssemblyVersion;
            textDesc.Text = AssemblyDescription;

        }

        public string AssemblyTitle
        {
            get
            {
                return assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title ?? "N/A";
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return assembly.GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                return assembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description.ToString();
            }
        }

        public string AssemblyProduct
        {
            get
            {
                return assembly.GetCustomAttribute<AssemblyProductAttribute>().Product ?? "N/A";
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                return assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright ?? "N/A";
            }
        }

        public string AssemblyCompany
        {
            get
            {
                return assembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company ?? "N/A";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCpyright_Click(object sender, EventArgs e)
        {

        }
    }

}
