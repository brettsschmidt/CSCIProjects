namespace CSCI234_Project_Schmidt
{
    partial class NewExerciseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewExerciseForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExerVideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExerDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerCat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.exerAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgDTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purgeButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.exitButton,
            this.deleteButton,
            this.purgeButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1338, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(44, 24);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExerID,
            this.ExerName,
            this.ExerVideo,
            this.ExerDesc,
            this.exerCat,
            this.exerAdd,
            this.addDTM,
            this.chgUser,
            this.chgDTM,
            this.exerPhoto,
            this.exerStat});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1338, 439);
            this.dataGridView1.TabIndex = 1;
            // 
            // ExerID
            // 
            this.ExerID.HeaderText = "Exercise ID";
            this.ExerID.Name = "ExerID";
            this.ExerID.ReadOnly = true;
            // 
            // ExerName
            // 
            this.ExerName.HeaderText = "Exercise Name";
            this.ExerName.Name = "ExerName";
            // 
            // ExerVideo
            // 
            this.ExerVideo.HeaderText = "Video Link";
            this.ExerVideo.Name = "ExerVideo";
            // 
            // ExerDesc
            // 
            this.ExerDesc.HeaderText = "Description";
            this.ExerDesc.Name = "ExerDesc";
            // 
            // exerCat
            // 
            this.exerCat.HeaderText = "Category";
            this.exerCat.Name = "exerCat";
            // 
            // exerAdd
            // 
            this.exerAdd.HeaderText = "Add User ID";
            this.exerAdd.Name = "exerAdd";
            this.exerAdd.ReadOnly = true;
            // 
            // addDTM
            // 
            this.addDTM.HeaderText = "Add DTM";
            this.addDTM.Name = "addDTM";
            this.addDTM.ReadOnly = true;
            // 
            // chgUser
            // 
            this.chgUser.HeaderText = "Change User ID";
            this.chgUser.Name = "chgUser";
            this.chgUser.ReadOnly = true;
            // 
            // chgDTM
            // 
            this.chgDTM.HeaderText = "Change DTM";
            this.chgDTM.Name = "chgDTM";
            this.chgDTM.ReadOnly = true;
            // 
            // exerPhoto
            // 
            this.exerPhoto.HeaderText = "Photo Link";
            this.exerPhoto.Name = "exerPhoto";
            // 
            // exerStat
            // 
            this.exerStat.HeaderText = "Status";
            this.exerStat.Name = "exerStat";
            this.exerStat.ReadOnly = true;
            // 
            // purgeButton
            // 
            this.purgeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.purgeButton.Image = ((System.Drawing.Image)(resources.GetObject("purgeButton.Image")));
            this.purgeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.purgeButton.Name = "purgeButton";
            this.purgeButton.Size = new System.Drawing.Size(51, 24);
            this.purgeButton.Text = "Purge";
            this.purgeButton.Click += new System.EventHandler(this.purgeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(57, 24);
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // NewExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::CSCI234_Project_Schmidt.Properties.Resources.SVA_Logo;
            this.ClientSize = new System.Drawing.Size(1338, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "NewExerciseForm";
            this.Text = "NewExerciseForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerDesc;
        private System.Windows.Forms.DataGridViewComboBoxColumn exerCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDTM;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgDTM;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerStat;
        private System.Windows.Forms.ToolStripButton purgeButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
    }
}