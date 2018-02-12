namespace CSCI234_Exercise_15_5_Schmidt
{
    partial class Form1
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
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserEnterButton = new System.Windows.Forms.Button();
            this.loginPasswordUserControl1 = new LoginPasswordUserControl.LoginPasswordUserControl();
            this.LoginEnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserListBox
            // 
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.ItemHeight = 16;
            this.UserListBox.Location = new System.Drawing.Point(12, 67);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.ScrollAlwaysVisible = true;
            this.UserListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.UserListBox.Size = new System.Drawing.Size(688, 356);
            this.UserListBox.Sorted = true;
            this.UserListBox.TabIndex = 0;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Enabled = false;
            this.UserTextBox.Location = new System.Drawing.Point(12, 39);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(556, 22);
            this.UserTextBox.TabIndex = 1;
            this.UserTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enjoy typing strings to be added to the ListBox and then sorted!";
            // 
            // UserEnterButton
            // 
            this.UserEnterButton.Enabled = false;
            this.UserEnterButton.Location = new System.Drawing.Point(586, 38);
            this.UserEnterButton.Name = "UserEnterButton";
            this.UserEnterButton.Size = new System.Drawing.Size(114, 23);
            this.UserEnterButton.TabIndex = 3;
            this.UserEnterButton.Text = "Enter";
            this.UserEnterButton.UseVisualStyleBackColor = true;
            this.UserEnterButton.Click += new System.EventHandler(this.UserEnterButton_Click);
            // 
            // loginPasswordUserControl1
            // 
            this.loginPasswordUserControl1.Location = new System.Drawing.Point(108, 104);
            this.loginPasswordUserControl1.Name = "loginPasswordUserControl1";
            this.loginPasswordUserControl1.Size = new System.Drawing.Size(296, 150);
            this.loginPasswordUserControl1.TabIndex = 4;
            this.loginPasswordUserControl1.Load += new System.EventHandler(this.loginPasswordUserControl_Load);
            // 
            // LoginEnterButton
            // 
            this.LoginEnterButton.Location = new System.Drawing.Point(295, 216);
            this.LoginEnterButton.Name = "LoginEnterButton";
            this.LoginEnterButton.Size = new System.Drawing.Size(75, 23);
            this.LoginEnterButton.TabIndex = 5;
            this.LoginEnterButton.Text = "Enter";
            this.LoginEnterButton.UseVisualStyleBackColor = true;
            this.LoginEnterButton.Click += new System.EventHandler(this.LoginEnterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 434);
            this.Controls.Add(this.LoginEnterButton);
            this.Controls.Add(this.loginPasswordUserControl1);
            this.Controls.Add(this.UserEnterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.UserListBox);
            this.Name = "Form1";
            this.Text = "String Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserEnterButton;
        private LoginPasswordUserControl.LoginPasswordUserControl loginPasswordUserControl1;
        private System.Windows.Forms.Button LoginEnterButton;
    }
}

