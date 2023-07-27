namespace Group11_Project
{
    partial class ViewWorkers
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
            this.sAD_11DataSet = new Group11_Project.SAD_11DataSet();
            this.WorkersTable = new System.Windows.Forms.DataGridView();
            this.workerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getallworkersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.WorkersTableAdapter();
            this.get_all_workersTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.get_all_workersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Cance_Btn = new System.Windows.Forms.Button();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.Status_Combo = new System.Windows.Forms.ComboBox();
            this.workerStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Title_Combo = new System.Windows.Forms.ComboBox();
            this.jobTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Phone_Box = new System.Windows.Forms.TextBox();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.Last_Box = new System.Windows.Forms.TextBox();
            this.First_Box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jobTitlesTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.JobTitlesTableAdapter();
            this.workerStatusTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.WorkerStatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallworkersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTitlesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WorkersTable
            // 
            this.WorkersTable.AllowUserToAddRows = false;
            this.WorkersTable.AllowUserToDeleteRows = false;
            this.WorkersTable.AllowUserToResizeColumns = false;
            this.WorkersTable.AllowUserToResizeRows = false;
            this.WorkersTable.AutoGenerateColumns = false;
            this.WorkersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.WorkersTable.DataSource = this.getallworkersBindingSource;
            this.WorkersTable.Location = new System.Drawing.Point(378, 140);
            this.WorkersTable.Name = "WorkersTable";
            this.WorkersTable.Size = new System.Drawing.Size(825, 301);
            this.WorkersTable.TabIndex = 0;
            this.WorkersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkersTable_CellClick);
            // 
            // workerIDDataGridViewTextBoxColumn
            // 
            this.workerIDDataGridViewTextBoxColumn.DataPropertyName = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.HeaderText = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.Name = "workerIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // getallworkersBindingSource
            // 
            this.getallworkersBindingSource.DataMember = "get_all_workers";
            this.getallworkersBindingSource.DataSource = this.sAD_11DataSet;
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
            // get_all_workersTableAdapter
            // 
            this.get_all_workersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(430, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Workers";
            // 
            // Cance_Btn
            // 
            this.Cance_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Cance_Btn.Location = new System.Drawing.Point(425, 515);
            this.Cance_Btn.Name = "Cance_Btn";
            this.Cance_Btn.Size = new System.Drawing.Size(159, 40);
            this.Cance_Btn.TabIndex = 2;
            this.Cance_Btn.Text = "Cancel";
            this.Cance_Btn.UseVisualStyleBackColor = true;
            this.Cance_Btn.Click += new System.EventHandler(this.Cance_Btn_Click);
            // 
            // Update_Btn
            // 
            this.Update_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Update_Btn.Location = new System.Drawing.Point(712, 515);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(159, 40);
            this.Update_Btn.TabIndex = 3;
            this.Update_Btn.Text = "Update";
            this.Update_Btn.UseVisualStyleBackColor = true;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // Status_Combo
            // 
            this.Status_Combo.DataSource = this.workerStatusBindingSource;
            this.Status_Combo.DisplayMember = "Status";
            this.Status_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_Combo.FormattingEnabled = true;
            this.Status_Combo.Location = new System.Drawing.Point(153, 366);
            this.Status_Combo.Name = "Status_Combo";
            this.Status_Combo.Size = new System.Drawing.Size(158, 21);
            this.Status_Combo.TabIndex = 37;
            // 
            // workerStatusBindingSource
            // 
            this.workerStatusBindingSource.DataMember = "WorkerStatus";
            this.workerStatusBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // Title_Combo
            // 
            this.Title_Combo.DataSource = this.jobTitlesBindingSource;
            this.Title_Combo.DisplayMember = "JobTitle";
            this.Title_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Title_Combo.FormattingEnabled = true;
            this.Title_Combo.Location = new System.Drawing.Point(153, 325);
            this.Title_Combo.Name = "Title_Combo";
            this.Title_Combo.Size = new System.Drawing.Size(158, 21);
            this.Title_Combo.TabIndex = 36;
            this.Title_Combo.ValueMember = "JobTitle";
            // 
            // jobTitlesBindingSource
            // 
            this.jobTitlesBindingSource.DataMember = "JobTitles";
            this.jobTitlesBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // Phone_Box
            // 
            this.Phone_Box.Location = new System.Drawing.Point(153, 283);
            this.Phone_Box.Name = "Phone_Box";
            this.Phone_Box.Size = new System.Drawing.Size(158, 20);
            this.Phone_Box.TabIndex = 34;
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(153, 236);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(158, 20);
            this.Email_Box.TabIndex = 33;
            // 
            // Last_Box
            // 
            this.Last_Box.Location = new System.Drawing.Point(153, 193);
            this.Last_Box.Name = "Last_Box";
            this.Last_Box.Size = new System.Drawing.Size(158, 20);
            this.Last_Box.TabIndex = 32;
            // 
            // First_Box
            // 
            this.First_Box.Location = new System.Drawing.Point(153, 149);
            this.First_Box.Name = "First_Box";
            this.First_Box.Size = new System.Drawing.Size(158, 20);
            this.First_Box.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(32, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(32, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(32, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(32, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(32, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(32, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "First Name";
            // 
            // jobTitlesTableAdapter
            // 
            this.jobTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // workerStatusTableAdapter
            // 
            this.workerStatusTableAdapter.ClearBeforeFill = true;
            // 
            // ViewWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1229, 609);
            this.Controls.Add(this.Status_Combo);
            this.Controls.Add(this.Title_Combo);
            this.Controls.Add(this.Phone_Box);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.Last_Box);
            this.Controls.Add(this.First_Box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.Cance_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorkersTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewWorkers";
            this.Load += new System.EventHandler(this.ViewWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallworkersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTitlesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.DataGridView WorkersTable;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private SAD_11DataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource getallworkersBindingSource;
        private SAD_11DataSetTableAdapters.get_all_workersTableAdapter get_all_workersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cance_Btn;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.ComboBox Status_Combo;
        private System.Windows.Forms.ComboBox Title_Combo;
        private System.Windows.Forms.TextBox Phone_Box;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.TextBox Last_Box;
        private System.Windows.Forms.TextBox First_Box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource jobTitlesBindingSource;
        private SAD_11DataSetTableAdapters.JobTitlesTableAdapter jobTitlesTableAdapter;
        private System.Windows.Forms.BindingSource workerStatusBindingSource;
        private SAD_11DataSetTableAdapters.WorkerStatusTableAdapter workerStatusTableAdapter;
    }
}