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
    public partial class NewExerciseForm : Form
    {
        Exercise currentExer;

        public int m_selection;

        STB001_TRAINER_COMPATIBLEDataSetTableAdapters.STT009_CAT_CODETableAdapter catCodeAdapter = new STB001_TRAINER_COMPATIBLEDataSetTableAdapters.STT009_CAT_CODETableAdapter();

        public NewExerciseForm()
        {
            m_selection = new int();
            InitializeComponent();
            currentExer = new Exercise();
            purgeButton.Visible = false;
            deleteButton.Visible = false;
            this.m_selection = 2;
            dataGridView1.RowCount = 1;
            for (int jo = 0; jo < catCodeAdapter.GetData().Rows.Count; jo++)
            {
                exerCat.Items.Add(catCodeAdapter.GetData()[jo].CAT_NAME);
            }
        }

        public NewExerciseForm(Exercise exercise, int i)
        {
            m_selection = new int();
            InitializeComponent();
            currentExer = exercise;
            this.m_selection = i;
            dataGridView1.RowCount = 1;
            dataGridView1.Rows[0].Cells[0].Value = currentExer.ExerID;
            dataGridView1.Rows[0].Cells[1].Value = currentExer.ExerName;
            dataGridView1.Rows[0].Cells[2].Value = currentExer.ExerVideo;
            dataGridView1.Rows[0].Cells[3].Value = currentExer.ExerDesc;
            dataGridView1.Rows[0].Cells[4].Value = currentExer.ExerCat;
            dataGridView1.Rows[0].Cells[5].Value = currentExer.AddUserID;
            dataGridView1.Rows[0].Cells[6].Value = currentExer.AddDTM;
            dataGridView1.Rows[0].Cells[7].Value = currentExer.ChgUserID;
            dataGridView1.Rows[0].Cells[8].Value = currentExer.ChgDTM;
            dataGridView1.Rows[0].Cells[9].Value = currentExer.ExerStatCD;
            
            if(exercise.ExerStatCD == "A")
            {
                purgeButton.Visible = false;
            }
            else
            {
                deleteButton.Text = "Undelete";
            }

            for(int jo = 0; jo < catCodeAdapter.GetData().Rows.Count; jo++)
            {
                exerCat.Items.Add(catCodeAdapter.GetData()[jo].CAT_NAME);
            }
           
           

            if(i == 1)
            {
                saveButton.Text = "Update";
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (m_selection == 1)
            {
                try
                {

                    currentExer.ExerName = (string)dataGridView1.Rows[0].Cells[1].Value;
                    currentExer.ExerVideo = (string)dataGridView1.Rows[0].Cells[2].Value;
                    currentExer.ExerDesc = (string)dataGridView1.Rows[0].Cells[3].Value;
                    currentExer.ExerCat = (string)dataGridView1.Rows[0].Cells[4].Value;

                    currentExer.updateExercise();
                    this.Parent.ToString();
                    
                    this.Dispose();


                }
                catch (Exception E)
                {
                    MessageBox.Show("Incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    currentExer.ExerName = (string)dataGridView1.Rows[0].Cells[1].Value;
                    currentExer.ExerVideo = (string)dataGridView1.Rows[0].Cells[2].Value;
                    currentExer.ExerDesc = (string)dataGridView1.Rows[0].Cells[3].Value;
                    currentExer.ExerCat = (string)dataGridView1.Rows[0].Cells[4].Value;
                    currentExer.insertExercise();
                    this.Parent.ToString();
                    
                    this.Dispose();
                }
                catch(Exception E)
                {
                    MessageBox.Show("Incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void purgeButton_Click(object sender, EventArgs e)
        {
            currentExer.Purge();
            this.Dispose();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            currentExer.Delete();
            this.Dispose();
        }
    }
}
