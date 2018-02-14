using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerciseToolStrip
{
    public partial class exerciseToolStrip : UserControl
    {
        string[] perMax = { "100", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95" };
        string[] rest = { "30", "0", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90" };
        string[] sets = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" };


        public exerciseToolStrip()
        {
            InitializeComponent();
            foreach(string s in perMax)
            {
                perComboBox.Items.Add(s);
            }
            foreach(string s in rest)
            {
                restComboBox.Items.Add(s);
            }
            foreach(string s in sets)
            {
                setsComboBox.Items.Add(s);
                repsComboBox.Items.Add(s);
            }
            
        }

        public void setExerciseToolStrip(string PerMax, string Rest, string Sets)
        {
            perComboBox.SelectedItem= PerMax;
            restComboBox.SelectedItem = Rest;
            setsComboBox.SelectedItem = Sets;
        }

        public void setComboBoxes(string[] exNames, string[] cats)
        {
            foreach(string s in exNames)
            {
                exerciseComboBox.Items.Add(s);
            }
            foreach(string s in cats)
            {
                exCatComboBox.Items.Add(s);
            }
        }

        public void setExerciseToolStrip(string Name, string category, string Sets, string Rest, string PerMax, string Reps )
        {
            exerciseComboBox.SelectedText = Name;
            exCatComboBox.SelectedText = category;
            setsComboBox.SelectedText = Sets;
            restComboBox.SelectedText = Rest;
            perComboBox.SelectedText = PerMax;
            repsComboBox.SelectedText = Reps;

        }

        public string[] getExerciseToolStrip()
        {
            return new string[] { exerciseComboBox.SelectedText, exCatComboBox.SelectedText, setsComboBox.SelectedText, repsComboBox.SelectedText, restComboBox.SelectedText, perComboBox.SelectedText   };
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
