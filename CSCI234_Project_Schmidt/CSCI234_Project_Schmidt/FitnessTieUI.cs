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
    public partial class FitnessTieUI : Form
    {

        

        public FitnessTieUI()
        {
            InitializeComponent();
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            STB001_TRAINER_COMPATIBLEDataSet data = new STB001_TRAINER_COMPATIBLEDataSet();
            
        }

        private void addExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!exerciseToolStrip1.Visible)
            {
                exerciseToolStrip1.Visible = true;
                return;
            }
            if (!exerciseToolStrip2.Visible)
            {
                exerciseToolStrip2.Visible = true;
                return;
            }
            if (!exerciseToolStrip3.Visible)
            {
                exerciseToolStrip3.Visible = true;
                return;
            }
            if (!exerciseToolStrip4.Visible)
            {
                exerciseToolStrip4.Visible = true;
                return;
            }
            if (!exerciseToolStrip5.Visible)
            {
                exerciseToolStrip5.Visible = true;
                return;
            }
            if (!exerciseToolStrip6.Visible)
            {
                exerciseToolStrip6.Visible = true;
                return;
            }
            if (!exerciseToolStrip7.Visible)
            {
                exerciseToolStrip7.Visible = true;
                return;
            }
            if (!exerciseToolStrip8.Visible)
            {
                exerciseToolStrip8.Visible = true;
                return;
            }
        }

        private void FitnessTieUI_Load(object sender, EventArgs e)
        {

        }

        private void exerciseUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void exercisePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                workoutPanel.Visible = false;
                exerciseContainer.Visible = false;
                graphics.DrawString("Exit", DefaultFont, Brushes.Green, 50   , 50);
            }


            this.Dispose();
            
        }
    }
}
