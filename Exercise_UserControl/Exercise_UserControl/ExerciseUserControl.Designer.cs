namespace Exercise_UserControl
{
    partial class ExerciseUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exerciseLabel = new System.Windows.Forms.Label();
            this.exerciseComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.setsLabel = new System.Windows.Forms.Label();
            this.setsComboBox = new System.Windows.Forms.ComboBox();
            this.repsLabel = new System.Windows.Forms.Label();
            this.repsComboBox = new System.Windows.Forms.ComboBox();
            this.restTimeLabel = new System.Windows.Forms.Label();
            this.restTimeComboBox = new System.Windows.Forms.ComboBox();
            this.perLabel = new System.Windows.Forms.Label();
            this.perComboBox = new System.Windows.Forms.ComboBox();
            this.secLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.secLabel);
            this.panel1.Controls.Add(this.perComboBox);
            this.panel1.Controls.Add(this.perLabel);
            this.panel1.Controls.Add(this.restTimeComboBox);
            this.panel1.Controls.Add(this.restTimeLabel);
            this.panel1.Controls.Add(this.repsComboBox);
            this.panel1.Controls.Add(this.repsLabel);
            this.panel1.Controls.Add(this.setsComboBox);
            this.panel1.Controls.Add(this.setsLabel);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.exerciseComboBox);
            this.panel1.Controls.Add(this.exerciseLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 61);
            this.panel1.TabIndex = 0;
            // 
            // exerciseLabel
            // 
            this.exerciseLabel.AutoSize = true;
            this.exerciseLabel.Location = new System.Drawing.Point(3, 22);
            this.exerciseLabel.Name = "exerciseLabel";
            this.exerciseLabel.Size = new System.Drawing.Size(65, 17);
            this.exerciseLabel.TabIndex = 0;
            this.exerciseLabel.Text = "Exercise:";
            // 
            // exerciseComboBox
            // 
            this.exerciseComboBox.FormattingEnabled = true;
            this.exerciseComboBox.Location = new System.Drawing.Point(74, 19);
            this.exerciseComboBox.Name = "exerciseComboBox";
            this.exerciseComboBox.Size = new System.Drawing.Size(121, 24);
            this.exerciseComboBox.TabIndex = 1;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(201, 22);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(69, 17);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(276, 19);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.categoryComboBox.TabIndex = 3;
            // 
            // setsLabel
            // 
            this.setsLabel.AutoSize = true;
            this.setsLabel.Location = new System.Drawing.Point(403, 22);
            this.setsLabel.Name = "setsLabel";
            this.setsLabel.Size = new System.Drawing.Size(40, 17);
            this.setsLabel.TabIndex = 4;
            this.setsLabel.Text = "Sets:";
            // 
            // setsComboBox
            // 
            this.setsComboBox.FormattingEnabled = true;
            this.setsComboBox.Location = new System.Drawing.Point(440, 19);
            this.setsComboBox.Name = "setsComboBox";
            this.setsComboBox.Size = new System.Drawing.Size(121, 24);
            this.setsComboBox.TabIndex = 5;
            // 
            // repsLabel
            // 
            this.repsLabel.AutoSize = true;
            this.repsLabel.Location = new System.Drawing.Point(567, 22);
            this.repsLabel.Name = "repsLabel";
            this.repsLabel.Size = new System.Drawing.Size(45, 17);
            this.repsLabel.TabIndex = 6;
            this.repsLabel.Text = "Reps:";
            // 
            // repsComboBox
            // 
            this.repsComboBox.FormattingEnabled = true;
            this.repsComboBox.Location = new System.Drawing.Point(618, 19);
            this.repsComboBox.Name = "repsComboBox";
            this.repsComboBox.Size = new System.Drawing.Size(121, 24);
            this.repsComboBox.TabIndex = 7;
            // 
            // restTimeLabel
            // 
            this.restTimeLabel.AutoSize = true;
            this.restTimeLabel.Location = new System.Drawing.Point(745, 22);
            this.restTimeLabel.Name = "restTimeLabel";
            this.restTimeLabel.Size = new System.Drawing.Size(76, 17);
            this.restTimeLabel.TabIndex = 8;
            this.restTimeLabel.Text = "Rest Time:";
            // 
            // restTimeComboBox
            // 
            this.restTimeComboBox.FormattingEnabled = true;
            this.restTimeComboBox.Location = new System.Drawing.Point(827, 19);
            this.restTimeComboBox.Name = "restTimeComboBox";
            this.restTimeComboBox.Size = new System.Drawing.Size(121, 24);
            this.restTimeComboBox.TabIndex = 9;
            this.restTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // perLabel
            // 
            this.perLabel.AutoSize = true;
            this.perLabel.Location = new System.Drawing.Point(990, 22);
            this.perLabel.Name = "perLabel";
            this.perLabel.Size = new System.Drawing.Size(130, 17);
            this.perLabel.TabIndex = 10;
            this.perLabel.Text = "Percentage of Max:";
            // 
            // perComboBox
            // 
            this.perComboBox.FormattingEnabled = true;
            this.perComboBox.Location = new System.Drawing.Point(1126, 19);
            this.perComboBox.Name = "perComboBox";
            this.perComboBox.Size = new System.Drawing.Size(121, 24);
            this.perComboBox.TabIndex = 11;
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Location = new System.Drawing.Point(954, 22);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(30, 17);
            this.secLabel.TabIndex = 12;
            this.secLabel.Text = "sec";
            // 
            // ExerciseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ExerciseUserControl";
            this.Size = new System.Drawing.Size(1273, 67);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox perComboBox;
        private System.Windows.Forms.Label perLabel;
        private System.Windows.Forms.ComboBox restTimeComboBox;
        private System.Windows.Forms.Label restTimeLabel;
        private System.Windows.Forms.ComboBox repsComboBox;
        private System.Windows.Forms.Label repsLabel;
        private System.Windows.Forms.ComboBox setsComboBox;
        private System.Windows.Forms.Label setsLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox exerciseComboBox;
        private System.Windows.Forms.Label exerciseLabel;
        private System.Windows.Forms.Label secLabel;
    }
}
