namespace CSCI234_Exercise_17_4_Schmidt
{
    partial class Exercise17_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise17_4));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.nextButton = new System.Windows.Forms.ToolStripButton();
            this.enterButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.nextButton,
            this.newButton,
            this.saveButton,
            this.enterButton,
            this.exitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(715, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(76, 24);
            this.openButton.Text = "Open File";
            this.openButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.openButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // nextButton
            // 
            this.nextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.nextButton.Enabled = false;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(95, 24);
            this.nextButton.Text = "Next Record";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.enterButton.Enabled = false;
            this.enterButton.Image = ((System.Drawing.Image)(resources.GetObject("enterButton.Image")));
            this.enterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(47, 24);
            this.enterButton.Text = "Enter";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 24);
            this.saveButton.Text = "Save As";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(98, 69);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(410, 22);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(98, 97);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(410, 22);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(98, 125);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(410, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(98, 153);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.ReadOnly = true;
            this.classTextBox.Size = new System.Drawing.Size(410, 22);
            this.classTextBox.TabIndex = 4;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(98, 181);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.ReadOnly = true;
            this.gradeTextBox.Size = new System.Drawing.Size(410, 22);
            this.gradeTextBox.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(37, 24);
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newButton.Enabled = false;
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(70, 24);
            this.newButton.Text = "New File";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID#:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Class:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grade:";
            // 
            // Exercise17_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Exercise17_4";
            this.Text = "Student Data Serializing Form";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton nextButton;
        private System.Windows.Forms.ToolStripButton enterButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.ToolStripButton exitButton;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

