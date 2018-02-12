using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI234_Exercise_17_4_Schmidt
{
    public partial class Exercise17_4 : Form
    {
        private BinaryFormatter reader = new BinaryFormatter();
        private FileStream input;
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;

        public Exercise17_4()
        {
            InitializeComponent();
        }

        protected int TextBoxCount = 5;

        public enum TextBoxIndices
        {
            LAST,
            FIRST,
            ID,
            CLASS,
            GRADE
        }

        public void ClearTextBoxes()
        {
            foreach(Control guiControl in Controls)
            {
                if(guiControl is TextBox)
                {
                    ((TextBox)guiControl).Clear();
                }
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if (values.Length != TextBoxCount)
            {
                throw (new ArgumentException("There must be " + (TextBoxCount) + " strings in the array"));
            }
            else
            {
                lastNameTextBox.Text = values[(int)TextBoxIndices.LAST];
                firstNameTextBox.Text = values[(int)TextBoxIndices.FIRST];
                idTextBox.Text = values[(int)TextBoxIndices.ID];
                classTextBox.Text = values[(int)TextBoxIndices.CLASS];
                gradeTextBox.Text = values[(int)TextBoxIndices.GRADE];
            } }
        
        public string[] GetTextBoxValues()
        {
            string[] values = new string[TextBoxCount];

            values[(int)TextBoxIndices.LAST] = lastNameTextBox.Text;
            values[(int)TextBoxIndices.FIRST] = firstNameTextBox.Text;
            values[(int)TextBoxIndices.ID] = idTextBox.Text;
            values[(int)TextBoxIndices.CLASS] = classTextBox.Text;
            values[(int)TextBoxIndices.GRADE] = gradeTextBox.Text;

            return values;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if(result == DialogResult.OK)
            {
                ClearTextBoxes();

                if(fileName == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                    openButton.Enabled = false;
                    nextButton.Enabled = true;
                    SetTextBoxesToReadOnly();
                }
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                StudentData student = (StudentData)reader.Deserialize(input);

                string[] values = new string[]
                {
                    student.LastName,
                    student.FirstName,
                    student.ID,
                    student.StudentClass,
                    student.Grade
                };

                SetTextBoxValues(values);
            }
            catch(SerializationException)
            {
                input.Close();
                openButton.Enabled = true;
                nextButton.Enabled = false;
                newButton.Enabled = false;
                ClearTextBoxes();
                MessageBox.Show("No more records in file", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string[] values = GetTextBoxValues();

            StudentData student = new StudentData();

            if(values[(int) TextBoxIndices.LAST] != string.Empty)
            {
                try
                {
                    student.LastName = values[(int)TextBoxIndices.LAST];
                    student.FirstName = values[(int)TextBoxIndices.FIRST];
                    student.ID = values[(int)TextBoxIndices.ID];
                    student.StudentClass = values[(int)TextBoxIndices.CLASS];
                    student.Grade = values[(int)TextBoxIndices.GRADE];

                    formatter.Serialize(output, student);
                }
                catch(SerializationException)
                {
                    MessageBox.Show("Error Writing to File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Invalid Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            ClearTextBoxes();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            


            newButton.Enabled = true;
            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;

                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if(result == DialogResult.OK)
            {
                if(fileName == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                        saveButton.Enabled = false;
                        enterButton.Enabled = true;
                        SetTextBoxesToNotReadOnly();
                    }
                    catch(IOException)
                    {
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if(output!= null)
            {
                try
                {
                    output.Close();
                }
                catch(IOException)
                {
                    MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.Exit();
        }

        public void SetTextBoxesToReadOnly()
        {
            foreach (Control guiControl in Controls)
            {
                if (guiControl is TextBox)
                {
                    ((TextBox)guiControl).ReadOnly = true;
                }
            }
        }
        public void SetTextBoxesToNotReadOnly()
        {
            foreach (Control guiControl in Controls)
            {
                if (guiControl is TextBox)
                {
                    ((TextBox)guiControl).ReadOnly = false;
                }
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            try
            {
                input.Close();
            }
            catch(Exception E)
            {

            }
            try
            {
                output.Close();
            }
            catch(Exception E)
            {

            }
            SetTextBoxesToReadOnly();
            newButton.Enabled = false;
            saveButton.Enabled = true;
            openButton.Enabled = true;
        }
    }
}
