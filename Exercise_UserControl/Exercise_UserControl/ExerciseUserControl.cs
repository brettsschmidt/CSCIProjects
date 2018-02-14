using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_UserControl
{
    public partial class ExerciseUserControl : UserControl
    {
        string[] perMax = { "100", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95" };
        string[] rest = { "30", "0", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90" };
        string[] sets = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" };

        public ExerciseUserControl()
        {
            InitializeComponent();
            foreach (string s in perMax)
            {
                perComboBox.Items.Add(s);
                    }
            foreach(string s in rest)
            {
                restTimeComboBox.Items.Add(s);
            }
            foreach(string s in sets)
            {
                setsComboBox.Items.Add(s);
            }
        }

        public ExerciseUserControl(string PerMax, string Rest, string Sets)
        {
            InitializeComponent();
            foreach (string s in perMax)
            {
                perComboBox.Items.Add(s);
            }
            foreach (string s in rest)
            {
                restTimeComboBox.Items.Add(s);
            }
            foreach (string s in sets)
            {
                setsComboBox.Items.Add(s);
            }

            perComboBox.SelectedItem = PerMax;
            restTimeComboBox.SelectedItem = Rest;
            setsComboBox.SelectedItem = Sets;

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
