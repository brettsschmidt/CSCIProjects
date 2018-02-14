using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPasswordUserControl
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
    }
}
