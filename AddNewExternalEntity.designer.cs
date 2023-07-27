namespace Group11_Project
{
    partial class AddNewExternalEntity
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
            this.AddNewEE = new System.Windows.Forms.Label();
            this.Phone_Combo = new System.Windows.Forms.ComboBox();
            this.Phone_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.LastName_Box = new System.Windows.Forms.TextBox();
            this.FirstName_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DT_Picker = new System.Windows.Forms.DateTimePicker();
            this.JoinDate = new System.Windows.Forms.Label();
            this.Type_Combo = new System.Windows.Forms.ComboBox();
            this.externalEntityTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11_Project.SAD_11DataSet();
            this.Type = new System.Windows.Forms.Label();
            this.externalEntityTypeTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.ExternalEntityTypeTableAdapter();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Confirm_Btn = new System.Windows.Forms.Button();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.gendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GenderLabel = new System.Windows.Forms.Label();
            this.gendersTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.GendersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.externalEntityTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewEE
            // 
            this.AddNewEE.AutoSize = true;
            this.AddNewEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddNewEE.Location = new System.Drawing.Point(65, 50);
            this.AddNewEE.Name = "AddNewEE";
            this.AddNewEE.Size = new System.Drawing.Size(341, 44);
            this.AddNewEE.TabIndex = 1;
            this.AddNewEE.Text = "Registration Form";
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
            this.Phone_Combo.Location = new System.Drawing.Point(178, 130);
            this.Phone_Combo.Name = "Phone_Combo";
            this.Phone_Combo.Size = new System.Drawing.Size(68, 21);
            this.Phone_Combo.TabIndex = 21;
            // 
            // Phone_Box
            // 
            this.Phone_Box.Location = new System.Drawing.Point(295, 130);
            this.Phone_Box.Name = "Phone_Box";
            this.Phone_Box.Size = new System.Drawing.Size(95, 20);
            this.Phone_Box.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(265, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "-";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.phone.Location = new System.Drawing.Point(60, 129);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(60, 20);
            this.phone.TabIndex = 18;
            this.phone.Text = "Phone";
            // 
            // LastName_Box
            // 
            this.LastName_Box.Location = new System.Drawing.Point(178, 220);
            this.LastName_Box.Name = "LastName_Box";
            this.LastName_Box.Size = new System.Drawing.Size(212, 20);
            this.LastName_Box.TabIndex = 25;
            // 
            // FirstName_Box
            // 
            this.FirstName_Box.Location = new System.Drawing.Point(178, 174);
            this.FirstName_Box.Name = "FirstName_Box";
            this.FirstName_Box.Size = new System.Drawing.Size(212, 20);
            this.FirstName_Box.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(59, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(59, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "First Name";
            // 
            // Email_Box
            // 
            this.Email_Box.Location = new System.Drawing.Point(178, 265);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.Size = new System.Drawing.Size(212, 20);
            this.Email_Box.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(60, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email";
            // 
            // DT_Picker
            // 
            this.DT_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Picker.Location = new System.Drawing.Point(178, 312);
            this.DT_Picker.Name = "DT_Picker";
            this.DT_Picker.Size = new System.Drawing.Size(212, 20);
            this.DT_Picker.TabIndex = 29;
            // 
            // JoinDate
            // 
            this.JoinDate.AutoSize = true;
            this.JoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.JoinDate.Location = new System.Drawing.Point(60, 312);
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.Size = new System.Drawing.Size(86, 20);
            this.JoinDate.TabIndex = 28;
            this.JoinDate.Text = "Join Date";
            this.JoinDate.Click += new System.EventHandler(this.JoinDate_Click);
            // 
            // Type_Combo
            // 
            this.Type_Combo.DataSource = this.externalEntityTypeBindingSource;
            this.Type_Combo.DisplayMember = "Type";
            this.Type_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_Combo.FormattingEnabled = true;
            this.Type_Combo.Location = new System.Drawing.Point(178, 357);
            this.Type_Combo.Name = "Type_Combo";
            this.Type_Combo.Size = new System.Drawing.Size(212, 21);
            this.Type_Combo.TabIndex = 31;
            // 
            // externalEntityTypeBindingSource
            // 
            this.externalEntityTypeBindingSource.DataMember = "ExternalEntityType";
            this.externalEntityTypeBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Type.Location = new System.Drawing.Point(60, 358);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(47, 20);
            this.Type.TabIndex = 30;
            this.Type.Text = "Type";
            this.Type.Click += new System.EventHandler(this.Type_Click);
            // 
            // externalEntityTypeTableAdapter
            // 
            this.externalEntityTypeTableAdapter.ClearBeforeFill = true;
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(178, 403);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(212, 20);
            this.Password_Box.TabIndex = 33;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Password.Location = new System.Drawing.Point(60, 403);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 20);
            this.Password.TabIndex = 32;
            this.Password.Text = "Password";
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Cancel_Btn.Location = new System.Drawing.Point(295, 578);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(132, 46);
            this.Cancel_Btn.TabIndex = 35;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Confirm_Btn
            // 
            this.Confirm_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Confirm_Btn.Location = new System.Drawing.Point(51, 578);
            this.Confirm_Btn.Name = "Confirm_Btn";
            this.Confirm_Btn.Size = new System.Drawing.Size(132, 46);
            this.Confirm_Btn.TabIndex = 34;
            this.Confirm_Btn.Text = "Confirm";
            this.Confirm_Btn.UseVisualStyleBackColor = true;
            this.Confirm_Btn.Click += new System.EventHandler(this.Confirm_Btn_Click);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(178, 499);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(212, 20);
            this.ageBox.TabIndex = 39;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ageLabel.Location = new System.Drawing.Point(60, 499);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(41, 20);
            this.ageLabel.TabIndex = 38;
            this.ageLabel.Text = "Age";
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.DataSource = this.gendersBindingSource;
            this.GendercomboBox.DisplayMember = "Gender";
            this.GendercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Location = new System.Drawing.Point(178, 453);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(212, 21);
            this.GendercomboBox.TabIndex = 37;
            // 
            // gendersBindingSource
            // 
            this.gendersBindingSource.DataMember = "Genders";
            this.gendersBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GenderLabel.Location = new System.Drawing.Point(60, 454);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(69, 20);
            this.GenderLabel.TabIndex = 36;
            this.GenderLabel.Text = "Gender";
            // 
            // gendersTableAdapter
            // 
            this.gendersTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewExternalEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(483, 642);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.GendercomboBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Confirm_Btn);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Type_Combo);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.DT_Picker);
            this.Controls.Add(this.JoinDate);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastName_Box);
            this.Controls.Add(this.FirstName_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Phone_Combo);
            this.Controls.Add(this.Phone_Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.AddNewEE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewExternalEntity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddNewExteranlEntity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.externalEntityTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNewEE;
        private System.Windows.Forms.ComboBox Phone_Combo;
        private System.Windows.Forms.TextBox Phone_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox LastName_Box;
        private System.Windows.Forms.TextBox FirstName_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DT_Picker;
        private System.Windows.Forms.Label JoinDate;
        private System.Windows.Forms.ComboBox Type_Combo;
        private System.Windows.Forms.Label Type;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource externalEntityTypeBindingSource;
        private SAD_11DataSetTableAdapters.ExternalEntityTypeTableAdapter externalEntityTypeTableAdapter;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Confirm_Btn;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.ComboBox GendercomboBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.BindingSource gendersBindingSource;
        private SAD_11DataSetTableAdapters.GendersTableAdapter gendersTableAdapter;
    }
}