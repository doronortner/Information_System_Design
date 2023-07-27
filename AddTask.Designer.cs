namespace Group11_Project
{
    partial class AddTask
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
            this.TopLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.Labellabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.LabelComboBox = new System.Windows.Forms.ComboBox();
            this.taskLabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11_Project.SAD_11DataSet();
            this.taskLabelTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.TaskLabelTableAdapter();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.taskStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskStatusTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.TaskStatusTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.WorkersTableAdapter();
            this.workersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.taskLabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TopLabel.Location = new System.Drawing.Point(171, 36);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(388, 63);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "Add New Task";
            this.TopLabel.Click += new System.EventHandler(this.TopLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TitleLabel.Location = new System.Drawing.Point(57, 161);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(108, 25);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Task Title";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DueDateLabel.Location = new System.Drawing.Point(63, 218);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(102, 25);
            this.DueDateLabel.TabIndex = 2;
            this.DueDateLabel.Text = "Due Date";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DescriptionLabel.Location = new System.Drawing.Point(63, 363);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(120, 25);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description";
            // 
            // Labellabel
            // 
            this.Labellabel.AutoSize = true;
            this.Labellabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Labellabel.Location = new System.Drawing.Point(63, 268);
            this.Labellabel.Name = "Labellabel";
            this.Labellabel.Size = new System.Drawing.Size(65, 25);
            this.Labellabel.TabIndex = 4;
            this.Labellabel.Text = "Label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(63, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(299, 167);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(196, 20);
            this.TitleTextBox.TabIndex = 6;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(299, 368);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(196, 20);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // LabelComboBox
            // 
            this.LabelComboBox.DataSource = this.taskLabelBindingSource;
            this.LabelComboBox.DisplayMember = "Label";
            this.LabelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LabelComboBox.FormattingEnabled = true;
            this.LabelComboBox.Location = new System.Drawing.Point(299, 274);
            this.LabelComboBox.Name = "LabelComboBox";
            this.LabelComboBox.Size = new System.Drawing.Size(196, 21);
            this.LabelComboBox.TabIndex = 9;
            this.LabelComboBox.ValueMember = "Label";
            // 
            // taskLabelBindingSource
            // 
            this.taskLabelBindingSource.DataMember = "TaskLabel";
            this.taskLabelBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskLabelTableAdapter
            // 
            this.taskLabelTableAdapter.ClearBeforeFill = true;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DataSource = this.taskStatusBindingSource;
            this.StatusComboBox.DisplayMember = "Status";
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(299, 321);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(196, 21);
            this.StatusComboBox.TabIndex = 10;
            this.StatusComboBox.ValueMember = "Status";
            // 
            // taskStatusBindingSource
            // 
            this.taskStatusBindingSource.DataMember = "TaskStatus";
            this.taskStatusBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // taskStatusTableAdapter
            // 
            this.taskStatusTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 221);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2023, 1, 5, 0, 0, 0, 0);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ConfirmButton.Location = new System.Drawing.Point(98, 482);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(139, 45);
            this.ConfirmButton.TabIndex = 12;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton1
            // 
            this.CancelButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CancelButton1.Location = new System.Drawing.Point(489, 482);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(139, 45);
            this.CancelButton1.TabIndex = 13;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // workersBindingSource1
            // 
            this.workersBindingSource1.DataMember = "Workers";
            this.workersBindingSource1.DataSource = this.sAD_11DataSet;
            // 
            // workersBindingSource2
            // 
            this.workersBindingSource2.DataMember = "Workers";
            this.workersBindingSource2.DataSource = this.sAD_11DataSet;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(710, 600);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.LabelComboBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Labellabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TopLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTask";
            this.Load += new System.EventHandler(this.AddTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskLabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label Labellabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox LabelComboBox;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource taskLabelBindingSource;
        private SAD_11DataSetTableAdapters.TaskLabelTableAdapter taskLabelTableAdapter;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.BindingSource taskStatusBindingSource;
        private SAD_11DataSetTableAdapters.TaskStatusTableAdapter taskStatusTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private SAD_11DataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource workersBindingSource1;
        private System.Windows.Forms.BindingSource workersBindingSource2;
    }
}