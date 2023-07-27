namespace Group11_Project
{
    partial class WorkerTasksView
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
            this.WorkerTaskView = new System.Windows.Forms.DataGridView();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11_Project.SAD_11DataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.taskStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelComboBox = new System.Windows.Forms.ComboBox();
            this.taskLabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Labellabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TopLabal = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.tasksTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.TasksTableAdapter();
            this.taskStatusTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.TaskStatusTableAdapter();
            this.taskLabelTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.TaskLabelTableAdapter();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerTaskView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskLabelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkerTaskView
            // 
            this.WorkerTaskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkerTaskView.Location = new System.Drawing.Point(51, 116);
            this.WorkerTaskView.Name = "WorkerTaskView";
            this.WorkerTaskView.Size = new System.Drawing.Size(440, 355);
            this.WorkerTaskView.TabIndex = 0;
            this.WorkerTaskView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkerTaskView_CellClick);
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(760, 208);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2023, 1, 5, 0, 0, 0, 0);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DataSource = this.taskStatusBindingSource;
            this.StatusComboBox.DisplayMember = "Status";
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(760, 370);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(196, 21);
            this.StatusComboBox.TabIndex = 20;
            this.StatusComboBox.ValueMember = "Status";
            // 
            // taskStatusBindingSource
            // 
            this.taskStatusBindingSource.DataMember = "TaskStatus";
            this.taskStatusBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // LabelComboBox
            // 
            this.LabelComboBox.DataSource = this.taskLabelBindingSource;
            this.LabelComboBox.DisplayMember = "Label";
            this.LabelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LabelComboBox.FormattingEnabled = true;
            this.LabelComboBox.Location = new System.Drawing.Point(760, 314);
            this.LabelComboBox.Name = "LabelComboBox";
            this.LabelComboBox.Size = new System.Drawing.Size(196, 21);
            this.LabelComboBox.TabIndex = 19;
            this.LabelComboBox.ValueMember = "Label";
            // 
            // taskLabelBindingSource
            // 
            this.taskLabelBindingSource.DataMember = "TaskLabel";
            this.taskLabelBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(760, 264);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(196, 20);
            this.DescriptionTextBox.TabIndex = 18;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(760, 154);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(196, 20);
            this.TitleTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(604, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Status";
            // 
            // Labellabel
            // 
            this.Labellabel.AutoSize = true;
            this.Labellabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Labellabel.Location = new System.Drawing.Point(604, 308);
            this.Labellabel.Name = "Labellabel";
            this.Labellabel.Size = new System.Drawing.Size(65, 25);
            this.Labellabel.TabIndex = 15;
            this.Labellabel.Text = "Label";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DescriptionLabel.Location = new System.Drawing.Point(604, 264);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(120, 25);
            this.DescriptionLabel.TabIndex = 14;
            this.DescriptionLabel.Text = "Description";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DueDateLabel.Location = new System.Drawing.Point(604, 210);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(102, 25);
            this.DueDateLabel.TabIndex = 13;
            this.DueDateLabel.Text = "Due Date";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TitleLabel.Location = new System.Drawing.Point(598, 153);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(108, 25);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Task Title";
            // 
            // TopLabal
            // 
            this.TopLabal.AutoSize = true;
            this.TopLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TopLabal.Location = new System.Drawing.Point(248, 22);
            this.TopLabal.Name = "TopLabal";
            this.TopLabal.Size = new System.Drawing.Size(488, 63);
            this.TopLabal.TabIndex = 22;
            this.TopLabal.Text = "Task Management";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateButton.Location = new System.Drawing.Point(842, 493);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(114, 37);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // taskStatusTableAdapter
            // 
            this.taskStatusTableAdapter.ClearBeforeFill = true;
            // 
            // taskLabelTableAdapter
            // 
            this.taskLabelTableAdapter.ClearBeforeFill = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cancelButton.Location = new System.Drawing.Point(603, 493);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 37);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addTaskButton.Location = new System.Drawing.Point(134, 493);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(278, 37);
            this.addTaskButton.TabIndex = 25;
            this.addTaskButton.Text = "Add new Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // WorkerTasksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1007, 558);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.TopLabal);
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
            this.Controls.Add(this.WorkerTaskView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerTasksView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerTasksView";
            this.Load += new System.EventHandler(this.WorkerTasksView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkerTaskView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskLabelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WorkerTaskView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ComboBox LabelComboBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labellabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TopLabal;
        private System.Windows.Forms.Button updateButton;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private SAD_11DataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deuDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource taskStatusBindingSource;
        private SAD_11DataSetTableAdapters.TaskStatusTableAdapter taskStatusTableAdapter;
        private System.Windows.Forms.BindingSource taskLabelBindingSource;
        private SAD_11DataSetTableAdapters.TaskLabelTableAdapter taskLabelTableAdapter;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addTaskButton;
    }
}