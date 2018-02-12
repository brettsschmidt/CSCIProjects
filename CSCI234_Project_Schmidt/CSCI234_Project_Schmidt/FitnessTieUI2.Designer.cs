namespace CSCI234_Project_Schmidt
{
    partial class FitnessTieUI2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitnessTieUI2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catBox = new System.Windows.Forms.ComboBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.eXER_CAT_CDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.catCombo = new System.Windows.Forms.ToolStripComboBox();
            this.getActiveItems = new System.Windows.Forms.ToolStripButton();
            this.getAllItems = new System.Windows.Forms.ToolStripButton();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.sTT001EXERMASTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTB001_TRAINER_COMPATIBLEDataSet = new CSCI234_Project_Schmidt.STB001_TRAINER_COMPATIBLEDataSet();
            this.sTT001_EXER_MASTERTableAdapter = new CSCI234_Project_Schmidt.STB001_TRAINER_COMPATIBLEDataSetTableAdapters.STT001_EXER_MASTERTableAdapter();
            this.helpButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXERNAMEAK1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXERDESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXERCATCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXERADDUSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXERADDDTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXERCHGUSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXERCHGDTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXERSTATCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTT001EXERMASTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTB001_TRAINER_COMPATIBLEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eXERIDDataGridViewTextBoxColumn,
            this.eXERNAMEAK1DataGridViewTextBoxColumn,
            this.eXERDESCDataGridViewTextBoxColumn,
            this.eXERCATCDDataGridViewTextBoxColumn,
            this.eXERADDUSERIDDataGridViewTextBoxColumn,
            this.eXERADDDTMDataGridViewTextBoxColumn,
            this.eXERCHGUSERIDDataGridViewTextBoxColumn,
            this.eXERCHGDTMDataGridViewTextBoxColumn,
            this.eXERSTATCDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTT001EXERMASTERBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 546);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // catBox
            // 
            this.catBox.FormattingEnabled = true;
            this.catBox.Location = new System.Drawing.Point(404, 1);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(121, 24);
            this.catBox.TabIndex = 2;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.newButton,
            this.helpButton,
            this.eXER_CAT_CDToolStripLabel,
            this.catCombo,
            this.getActiveItems,
            this.getAllItems});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1242, 28);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // eXER_CAT_CDToolStripLabel
            // 
            this.eXER_CAT_CDToolStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eXER_CAT_CDToolStripLabel.Enabled = false;
            this.eXER_CAT_CDToolStripLabel.Name = "eXER_CAT_CDToolStripLabel";
            this.eXER_CAT_CDToolStripLabel.Size = new System.Drawing.Size(72, 25);
            this.eXER_CAT_CDToolStripLabel.Text = "Category:";
            // 
            // catCombo
            // 
            this.catCombo.Name = "catCombo";
            this.catCombo.Size = new System.Drawing.Size(121, 28);
            this.catCombo.SelectedIndexChanged += new System.EventHandler(this.catCombo_SelectedIndexChanged);
            this.catCombo.Click += new System.EventHandler(this.catCombo_Click);
            // 
            // getActiveItems
            // 
            this.getActiveItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getActiveItems.Image = ((System.Drawing.Image)(resources.GetObject("getActiveItems.Image")));
            this.getActiveItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.getActiveItems.Name = "getActiveItems";
            this.getActiveItems.Size = new System.Drawing.Size(170, 25);
            this.getActiveItems.Text = "Display Active Exercises";
            this.getActiveItems.Click += new System.EventHandler(this.getActiveItems_Click);
            // 
            // getAllItems
            // 
            this.getAllItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getAllItems.Image = ((System.Drawing.Image)(resources.GetObject("getAllItems.Image")));
            this.getAllItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.getAllItems.Name = "getAllItems";
            this.getAllItems.Size = new System.Drawing.Size(147, 25);
            this.getAllItems.Text = "Display All Exercises";
            this.getAllItems.Click += new System.EventHandler(this.getAllItems_Click);
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 25);
            this.newButton.Text = "New Exercise";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // sTT001EXERMASTERBindingSource
            // 
            this.sTT001EXERMASTERBindingSource.DataMember = "STT001_EXER_MASTER";
            this.sTT001EXERMASTERBindingSource.DataSource = this.sTB001_TRAINER_COMPATIBLEDataSet;
            // 
            // sTB001_TRAINER_COMPATIBLEDataSet
            // 
            this.sTB001_TRAINER_COMPATIBLEDataSet.DataSetName = "STB001_TRAINER_COMPATIBLEDataSet";
            this.sTB001_TRAINER_COMPATIBLEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTT001_EXER_MASTERTableAdapter
            // 
            this.sTT001_EXER_MASTERTableAdapter.ClearBeforeFill = true;
            // 
            // helpButton
            // 
            this.helpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(45, 25);
            this.helpButton.Text = "Help";
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 25);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // eXERIDDataGridViewTextBoxColumn
            // 
            this.eXERIDDataGridViewTextBoxColumn.DataPropertyName = "EXER_ID";
            this.eXERIDDataGridViewTextBoxColumn.HeaderText = "Exercise ID";
            this.eXERIDDataGridViewTextBoxColumn.Name = "eXERIDDataGridViewTextBoxColumn";
            this.eXERIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXERNAMEAK1DataGridViewTextBoxColumn
            // 
            this.eXERNAMEAK1DataGridViewTextBoxColumn.DataPropertyName = "EXER_NAME_AK1";
            this.eXERNAMEAK1DataGridViewTextBoxColumn.HeaderText = "Exercise Name";
            this.eXERNAMEAK1DataGridViewTextBoxColumn.Name = "eXERNAMEAK1DataGridViewTextBoxColumn";
            this.eXERNAMEAK1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXERDESCDataGridViewTextBoxColumn
            // 
            this.eXERDESCDataGridViewTextBoxColumn.DataPropertyName = "EXER_DESC";
            this.eXERDESCDataGridViewTextBoxColumn.HeaderText = "Description";
            this.eXERDESCDataGridViewTextBoxColumn.Name = "eXERDESCDataGridViewTextBoxColumn";
            this.eXERDESCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXERCATCDDataGridViewTextBoxColumn
            // 
            this.eXERCATCDDataGridViewTextBoxColumn.DataPropertyName = "EXER_CAT_CD";
            this.eXERCATCDDataGridViewTextBoxColumn.HeaderText = "Category";
            this.eXERCATCDDataGridViewTextBoxColumn.Name = "eXERCATCDDataGridViewTextBoxColumn";
            this.eXERCATCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXERADDUSERIDDataGridViewTextBoxColumn
            // 
            this.eXERADDUSERIDDataGridViewTextBoxColumn.DataPropertyName = "EXER_ADD_USER_ID";
            this.eXERADDUSERIDDataGridViewTextBoxColumn.HeaderText = "Add User ID";
            this.eXERADDUSERIDDataGridViewTextBoxColumn.Name = "eXERADDUSERIDDataGridViewTextBoxColumn";
            this.eXERADDUSERIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXERADDDTMDataGridViewTextBoxColumn
            // 
            this.eXERADDDTMDataGridViewTextBoxColumn.DataPropertyName = "EXER_ADD_DTM";
            this.eXERADDDTMDataGridViewTextBoxColumn.HeaderText = "Add User DTM";
            this.eXERADDDTMDataGridViewTextBoxColumn.Name = "eXERADDDTMDataGridViewTextBoxColumn";
            this.eXERADDDTMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXERCHGUSERIDDataGridViewTextBoxColumn
            // 
            this.eXERCHGUSERIDDataGridViewTextBoxColumn.DataPropertyName = "EXER_CHG_USER_ID";
            this.eXERCHGUSERIDDataGridViewTextBoxColumn.HeaderText = "Change User ID";
            this.eXERCHGUSERIDDataGridViewTextBoxColumn.Name = "eXERCHGUSERIDDataGridViewTextBoxColumn";
            this.eXERCHGUSERIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXERCHGDTMDataGridViewTextBoxColumn
            // 
            this.eXERCHGDTMDataGridViewTextBoxColumn.DataPropertyName = "EXER_CHG_DTM";
            this.eXERCHGDTMDataGridViewTextBoxColumn.HeaderText = "Change DTM";
            this.eXERCHGDTMDataGridViewTextBoxColumn.Name = "eXERCHGDTMDataGridViewTextBoxColumn";
            this.eXERCHGDTMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXERSTATCDDataGridViewTextBoxColumn
            // 
            this.eXERSTATCDDataGridViewTextBoxColumn.DataPropertyName = "EXER_STAT_CD";
            this.eXERSTATCDDataGridViewTextBoxColumn.HeaderText = "Status";
            this.eXERSTATCDDataGridViewTextBoxColumn.Name = "eXERSTATCDDataGridViewTextBoxColumn";
            this.eXERSTATCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FitnessTieUI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 579);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.catBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FitnessTieUI2";
            this.Text = "FitnessTieUI2";
            this.Load += new System.EventHandler(this.FitnessTieUI2_Load);
            this.MdiChildActivate += new System.EventHandler(this.FitnessTieUI2_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTT001EXERMASTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTB001_TRAINER_COMPATIBLEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private STB001_TRAINER_COMPATIBLEDataSet sTB001_TRAINER_COMPATIBLEDataSet;
        private System.Windows.Forms.BindingSource sTT001EXERMASTERBindingSource;
        private STB001_TRAINER_COMPATIBLEDataSetTableAdapters.STT001_EXER_MASTERTableAdapter sTT001_EXER_MASTERTableAdapter;
        private System.Windows.Forms.ComboBox catBox;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel eXER_CAT_CDToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox catCombo;
        private System.Windows.Forms.ToolStripButton getActiveItems;
        private System.Windows.Forms.ToolStripButton getAllItems;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton helpButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXERNAMEAK1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXERDESCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXERCATCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXERADDUSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXERADDDTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXERCHGUSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXERCHGDTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXERSTATCDDataGridViewTextBoxColumn;
    }
}