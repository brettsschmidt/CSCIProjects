using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI234_Exercise_15_5_Schmidt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                UserListBox.Items.Add(UserTextBox.Text);
                
                UserTextBox.Text = "";
            }
        }

        private void UserEnterButton_Click(object sender, EventArgs e)
        {
            UserListBox.Items.Add(UserTextBox.Text);

            UserTextBox.Text = "";
        }

        private void loginPasswordUserControl_Load(object sender, EventArgs e)
        {

        }

        private void LoginEnterButton_Click(object sender, EventArgs e)
        {
            loginPasswordUserControl1.Visible = false;
            LoginEnterButton.Visible = false;
            UserTextBox.Enabled = true;
            UserEnterButton.Enabled = true;
            UserListBox.Items.Add(loginPasswordUserControl1.getLogin());
            UserListBox.Items.Add(loginPasswordUserControl1.getPassword());
        }
    }
}
