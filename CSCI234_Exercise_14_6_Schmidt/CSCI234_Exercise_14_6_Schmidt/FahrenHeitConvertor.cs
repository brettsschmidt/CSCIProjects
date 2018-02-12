using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI234_Exercise_14_6_Schmidt
{
    public partial class FahrenHeitConvertor : Form
    {
        public FahrenHeitConvertor()
        {
            InitializeComponent();
        }

        private void UserTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                double m_Convertion = (5D / 9D) * (Convert.ToDouble(UserTextBox.Text) - 32D);
                ComputerVoiceLabel.Text = Convert.ToDouble(UserTextBox.Text) + " Fahrenheit is: \n" + m_Convertion.ToString("#.00") + " Celsius";
                UserTextBox.Text = "";
            }
        }
    }
}
