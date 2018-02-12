namespace CSCI234_Exercise_14_6_Schmidt
{
    partial class FahrenHeitConvertor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComputerVoiceLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComputerVoiceLabel
            // 
            this.ComputerVoiceLabel.AutoSize = true;
            this.ComputerVoiceLabel.Location = new System.Drawing.Point(12, 43);
            this.ComputerVoiceLabel.Name = "ComputerVoiceLabel";
            this.ComputerVoiceLabel.Size = new System.Drawing.Size(356, 17);
            this.ComputerVoiceLabel.TabIndex = 0;
            this.ComputerVoiceLabel.Text = "Please enter a Fahrenheit temperature to be converted";
            this.ComputerVoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(15, 107);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(201, 22);
            this.UserTextBox.TabIndex = 1;
            this.UserTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserTextBox_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 178);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.ComputerVoiceLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComputerVoiceLabel;
        private System.Windows.Forms.TextBox UserTextBox;
    }
}

