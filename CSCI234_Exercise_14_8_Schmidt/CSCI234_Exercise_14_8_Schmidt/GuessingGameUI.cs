using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI234_Exercise_14_8_Schmidt
{
    public partial class Form1 : Form
    {
        GuessingGame curGuessingGame;

        public Form1()
        {
            InitializeComponent();
            curGuessingGame = new GuessingGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Answer curAnswer = curGuessingGame.UserGuess(Convert.ToInt32(GuessingTextBox.Text));
                if (curAnswer.getCorrect())
                {
                    ComputerVoiceLabel.Text = "Correct! Congrats!";
                    this.BackColor = Color.Green;
                    GuessingTextBox.Enabled = false;
                    EnterButton.Enabled = false;
                }
                else
                {
                    ComputerVoiceLabel.Text = curAnswer.getClue();
                    if (curAnswer.getWarmOrCold())
                    {
                        
                        this.BackColor = Color.Red;
                    }
                    else
                    {
                        this.BackColor = Color.Blue;
                    }
                }
                GuessingTextBox.Text = "";
            }
            catch (Exception E)
            {

            }


                
            

        }

        private void GuessingTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void TryAgainButton_Click(object sender, EventArgs e)
        {

            this.BackColor = default(Color);
            ComputerVoiceLabel.Text = "I have a number between 1 and 1000--can you guess my number?\nPlease enter your first guess.";
            GuessingTextBox.Enabled = true;
            EnterButton.Enabled = true;
            GuessingTextBox.Text = "";
            curGuessingGame = new GuessingGame();
        }

        private void GuessingTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                this.button2_Click(sender, e);
            }
        }
    }
}
