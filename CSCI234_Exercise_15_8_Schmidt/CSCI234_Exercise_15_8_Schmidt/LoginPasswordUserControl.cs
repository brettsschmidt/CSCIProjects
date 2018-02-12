using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI234_Exercise_15_8_Schmidt
{
    public partial class LoginPasswordUserControl : UserControl
    {
        public LoginPasswordUserControl()
        {
            InitializeComponent();
        }

        public string getLogin()
        {
            return loginTextBox.Text;
        }

        public string getPassword()
        {
            return passwordTextBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
