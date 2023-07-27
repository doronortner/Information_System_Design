namespace Group11_Project
{
    partial class AddNewWorker
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
            this.label1 = new System.Windows.Forms.Label();
            this.Confirm_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.FirstName_Box = new System.Windows.Forms.TextBox();
            this.LastName_Box = new System.Windows.Forms.TextBox();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.Phone_Box = new System.Windows.Forms.TextBox();
            this.Phone_Combo = new System.Windows.Forms.ComboBox();
            this.Title_Combo = new System.Windows.Forms.ComboBox();
            this.jobTitlesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11_Project.SAD_11DataSet();
            this.jobTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Status_Combo = new System.Windows.Forms.ComboBox();
            this.workerStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DT_Picker = new System.Windows.Forms.DateTimePicker();
            this.jobTitlesTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.JobTitlesTableAdapter();
            this.sAD11DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerStatusTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.WorkerStatusTableAdapter();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobTitlesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD11DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(121, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Worker";
            // 
            // Confirm_Btn
            // 
            this.Confirm_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Confirm_Btn.Location = new System.Drawing.Point(83, 533);
            this.Confirm_Btn.Name = "Confirm_Btn";
            this.Confirm_Btn.Size = new System.Drawing.Size(132, 46);
            this.Confirm_Btn.TabIndex = 1;
            this.Confirm_Btn.Text = "Confirm";
            this.Confirm_Btn.UseVisualStyleBackColor = true;
            this.Confirm_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Cancel_Btn.Location = new System.Drawing.Point(370, 533);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(132, 46);
            this.Cancel_Btn.TabIndex = 2;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(95, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(95, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(95, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(95, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(95, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(334, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(95, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(95, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hire Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(95, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Status";
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(251, 119);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(212, 20);
            this.ID_Box.TabIndex = 12;
            this.ID_Box.TextChanged += new System.EventHandler(this.ID_Box_TextChanged);
            // 
            // FirstName_Box
            // 
            this.FirstName_Box.Location = new System.Drawing.Point(251, 163);
            this.FirstName_Box.Name = "FirstName_Box";
            this.FirstName_Box.Size = new System.Drawing.Size(212, 20);
            this.FirstName_Box.TabIndex = 13;
            // 
            // LastName_Box
            // 
            this.LastName_Box.Location = new System.Drawing.Point(251, 208);
            this.LastName_Box.Name = "LastName_Box";
            this.LastName_Box.Size = new System.Drawing.Size(212, 20);
            this.LastName_Box.TabIndex = 14;
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(251, 250);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(212, 20);
            this.Email_Box.TabIndex = 15;
            // 
            // Phone_Box
            // 
            this.Phone_Box.Location = new System.Drawing.Point(364, 298);
            this.Phone_Box.Name = "Phone_Box";
            this.Phone_Box.Size = new System.Drawing.Size(138, 20);
            this.Phone_Box.TabIndex = 16;
            // 
            // Phone_Combo
            // 
            this.Phone_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Phone_Combo.FormattingEnabled = true;
            this.Phone_Combo.Items.AddRange(new object[] {
            "+972",
            "+971",
            "+1",
            "+44",
            "+49"});
            this.Phone_Combo.Location = new System.Drawing.Point(251, 297);
            this.Phone_Combo.Name = "Phone_Combo";
            this.Phone_Combo.Size = new System.Drawing.Size(68, 21);
            this.Phone_Combo.TabIndex = 17;
            // 
            // Title_Combo
            // 
            this.Title_Combo.DataSource = this.jobTitlesBindingSource1;
            this.Title_Combo.DisplayMember = "JobTitle";
            this.Title_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Title_Combo.FormattingEnabled = true;
            this.Title_Combo.Location = new System.Drawing.Point(251, 340);
            this.Title_Combo.Name = "Title_Combo";
            this.Title_Combo.Size = new System.Drawing.Size(212, 21);
            this.Title_Combo.TabIndex = 18;
            this.Title_Combo.ValueMember = "JobTitle";
            // 
            // jobTitlesBindingSource1
            // 
            this.jobTitlesBindingSource1.DataMember = "JobTitles";
            this.jobTitlesBindingSource1.DataSource = this.sAD_11DataSet;
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobTitlesBindingSource
            // 
            this.jobTitlesBindingSource.DataMember = "JobTitles";
            this.jobTitlesBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // Status_Combo
            // 
            this.Status_Combo.DataSource = this.workerStatusBindingSource;
            this.Status_Combo.DisplayMember = "Status";
            this.Status_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_Combo.FormattingEnabled = true;
            this.Status_Combo.Location = new System.Drawing.Point(251, 425);
            this.Status_Combo.Name = "Status_Combo";
            this.Status_Combo.Size = new System.Drawing.Size(212, 21);
            this.Status_Combo.TabIndex = 19;
            // 
            // workerStatusBindingSource
            // 
            this.workerStatusBindingSource.DataMember = "WorkerStatus";
            this.workerStatusBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // DT_Picker
            // 
            this.DT_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Picker.Location = new System.Drawing.Point(251, 385);
            this.DT_Picker.Name = "DT_Picker";
            this.DT_Picker.Size = new System.Drawing.Size(212, 20);
            this.DT_Picker.TabIndex = 20;
            // 
            // jobTitlesTableAdapter
            // 
            this.jobTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // sAD11DataSetBindingSource
            // 
            this.sAD11DataSetBindingSource.DataSource = this.sAD_11DataSet;
            this.sAD11DataSetBindingSource.Position = 0;
            // 
            // workerStatusTableAdapter
            // 
            this.workerStatusTableAdapter.ClearBeforeFill = true;
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(251, 465);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(212, 20);
            this.Password_Box.TabIndex = 35;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Password.Location = new System.Drawing.Point(97, 465);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 20);
            this.Password.TabIndex = 34;
            this.Password.Text = "Password";
            // 
            // AddNewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(570, 616);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.DT_Picker);
            this.Controls.Add(this.Status_Combo);
            this.Controls.Add(this.Title_Combo);
            this.Controls.Add(this.Phone_Combo);
            this.Controls.Add(this.Phone_Box);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.LastName_Box);
            this.Controls.Add(this.FirstName_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Confirm_Btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewWorker";
            this.Load += new System.EventHandler(this.AddNewWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobTitlesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD11DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirm_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox FirstName_Box;
        private System.Windows.Forms.TextBox LastName_Box;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.TextBox Phone_Box;
        private System.Windows.Forms.ComboBox Phone_Combo;
        private System.Windows.Forms.ComboBox Title_Combo;
        private System.Windows.Forms.ComboBox Status_Combo;
        private System.Windows.Forms.DateTimePicker DT_Picker;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource jobTitlesBindingSource;
        private SAD_11DataSetTableAdapters.JobTitlesTableAdapter jobTitlesTableAdapter;
        private System.Windows.Forms.BindingSource sAD11DataSetBindingSource;
        private System.Windows.Forms.BindingSource workerStatusBindingSource;
        private SAD_11DataSetTableAdapters.WorkerStatusTableAdapter workerStatusTableAdapter;
        private System.Windows.Forms.BindingSource jobTitlesBindingSource1;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Label Password;
    }
}