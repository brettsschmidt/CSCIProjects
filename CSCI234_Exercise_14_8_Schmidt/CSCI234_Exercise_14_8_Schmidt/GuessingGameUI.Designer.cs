namespace CSCI234_Exercise_14_8_Schmidt
{
    partial class Form1
    {

        public class GameTextBox : System.Windows.Forms.TextBox
        {

        }

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GuessingTextBox = new System.Windows.Forms.TextBox();
            this.ComputerVoiceLabel = new System.Windows.Forms.Label();
            this.TryAgainButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuessingTextBox
            // 
            this.GuessingTextBox.Location = new System.Drawing.Point(65, 103);
            this.GuessingTextBox.Name = "GuessingTextBox";
            this.GuessingTextBox.Size = new System.Drawing.Size(325, 22);
            this.GuessingTextBox.TabIndex = 0;
            this.GuessingTextBox.Tag = "";
            this.GuessingTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.GuessingTextBox.Enter += new System.EventHandler(this.GuessingTextBox_Enter);
            this.GuessingTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GuessingTextBox_KeyUp);
            // 
            // ComputerVoiceLabel
            // 
            this.ComputerVoiceLabel.AutoSize = true;
            this.ComputerVoiceLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ComputerVoiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerVoiceLabel.Location = new System.Drawing.Point(12, 37);
            this.ComputerVoiceLabel.Name = "ComputerVoiceLabel";
            this.ComputerVoiceLabel.Size = new System.Drawing.Size(429, 36);
            this.ComputerVoiceLabel.TabIndex = 1;
            this.ComputerVoiceLabel.Text = "I have a number between 1 and 1000--can you guess my number?\r\nPlease enter your f" +
    "irst guess.";
            this.ComputerVoiceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TryAgainButton
            // 
            this.TryAgainButton.Location = new System.Drawing.Point(339, 179);
            this.TryAgainButton.Name = "TryAgainButton";
            this.TryAgainButton.Size = new System.Drawing.Size(102, 23);
            this.TryAgainButton.TabIndex = 2;
            this.TryAgainButton.Text = "Try again";
            this.TryAgainButton.UseVisualStyleBackColor = true;
            this.TryAgainButton.Click += new System.EventHandler(this.TryAgainButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(315, 131);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 214);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.TryAgainButton);
            this.Controls.Add(this.ComputerVoiceLabel);
            this.Controls.Add(this.GuessingTextBox);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GuessingTextBox;
        private System.Windows.Forms.Label ComputerVoiceLabel;
        private System.Windows.Forms.Button TryAgainButton;
        private System.Windows.Forms.Button EnterButton;
    }
}

