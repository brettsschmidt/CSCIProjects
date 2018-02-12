using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI234_Project_Schmidt
{
    public partial class FitnessTieUI2 : Form
    {
        STB001_TRAINER_COMPATIBLEDataSetTableAdapters.STT009_CAT_CODETableAdapter catCodeAdapter = new STB001_TRAINER_COMPATIBLEDataSetTableAdapters.STT009_CAT_CODETableAdapter();

        public FitnessTieUI2()
        {
            InitializeComponent();
            for (int jo = 0; jo < catCodeAdapter.GetData().Rows.Count; jo++)
            {
                catCombo.Items.Add(catCodeAdapter.GetData()[jo].CAT_NAME);
            }

        }

        private void FitnessTieUI2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTB001_TRAINER_COMPATIBLEDataSet.STT001_EXER_MASTER' table. You can move, or remove it, as needed.
            this.sTT001_EXER_MASTERTableAdapter.Fill(this.sTB001_TRAINER_COMPATIBLEDataSet.STT001_EXER_MASTER);

        }

      


        private void getActiveItems_Click(object sender, EventArgs e)
        {
            try
            {
                this.sTT001_EXER_MASTERTableAdapter.qryActiveExer(this.sTB001_TRAINER_COMPATIBLEDataSet.STT001_EXER_MASTER);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void getAllItems_Click(object sender, EventArgs e)
        {
            try
            {
                this.sTT001_EXER_MASTERTableAdapter.Fill(this.sTB001_TRAINER_COMPATIBLEDataSet.STT001_EXER_MASTER);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void catCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sTT001_EXER_MASTERTableAdapter.FillBy(this.sTB001_TRAINER_COMPATIBLEDataSet.STT001_EXER_MASTER, (string)catCombo.SelectedItem);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int test = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            Exercise selectedExer = new Exercise(test);

            NewExerciseForm exerciseForm = new NewExerciseForm(selectedExer, 1);
            this.IsMdiContainer = true;
            exerciseForm.MdiParent = this;
            
            exerciseForm.Show();
            
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
           
            
            
        }

        private void FitnessTieUI2_MdiChildActivate(object sender, EventArgs e)
        {
            if(dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
                fillByToolStrip.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
                fillByToolStrip.Visible = false;
            }

            
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            NewExerciseForm exerciseForm = new NewExerciseForm();
            this.IsMdiContainer = true;
            exerciseForm.MdiParent = this;

            exerciseForm.Show();
        }

        private void catCombo_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Fitness Tie application! Feel free to create as many workouts as you want.\nIf you want to update an existing double click on the row you would like to update and a new window will pop up.\nIf you would like to create a new one click the New Exercise button. If would like to search through exercises by category click on the Category combobox in the top left corner and select one. Active Exercises will display the exercises that are not deleted. All Exercises will display all the exercises.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
