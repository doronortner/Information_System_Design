namespace Group11_Project
{
    partial class ProgramMenu_Participants
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
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.ProgramName_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.SignOut_Label = new System.Windows.Forms.LinkLabel();
            this.Lower_Panel = new System.Windows.Forms.Panel();
            this.MainMenu_Btn = new System.Windows.Forms.Button();
            this.Expenses_Btn = new System.Windows.Forms.Button();
            this.Participants_Btn = new System.Windows.Forms.Button();
            this.Overview_Btn = new System.Windows.Forms.Button();
            this.Participants_Table = new System.Windows.Forms.DataGridView();
            this.sAD_11DataSet = new Group11_Project.SAD_11DataSet();
            this.programParticipantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programParticipantsTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.ProgramParticipantsTableAdapter();
            this.externalEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.externalEntitiesTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.ExternalEntitiesTableAdapter();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.last_name_box = new System.Windows.Forms.TextBox();
            this.first_name_box = new System.Windows.Forms.TextBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.gendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gendersTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.GendersTableAdapter();
            this.removeButton = new System.Windows.Forms.Button();
            this.phoneComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Top_Panel.SuspendLayout();
            this.Lower_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Participants_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programParticipantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.Top_Panel.Controls.Add(this.ProgramName_Label);
            this.Top_Panel.Controls.Add(this.Name_Label);
            this.Top_Panel.Controls.Add(this.SignOut_Label);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(956, 46);
            this.Top_Panel.TabIndex = 2;
            // 
            // ProgramName_Label
            // 
            this.ProgramName_Label.AutoSize = true;
            this.ProgramName_Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramName_Label.ForeColor = System.Drawing.Color.Maroon;
            this.ProgramName_Label.Location = new System.Drawing.Point(369, 9);
            this.ProgramName_Label.Name = "ProgramName_Label";
            this.ProgramName_Label.Size = new System.Drawing.Size(183, 28);
            this.ProgramName_Label.TabIndex = 17;
            this.ProgramName_Label.Text = "ProgramName";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(579, 17);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(40, 17);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "Hello";
            // 
            // SignOut_Label
            // 
            this.SignOut_Label.ActiveLinkColor = System.Drawing.Color.Black;
            this.SignOut_Label.AutoSize = true;
            this.SignOut_Label.DisabledLinkColor = System.Drawing.Color.Black;
            this.SignOut_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOut_Label.LinkColor = System.Drawing.Color.Black;
            this.SignOut_Label.Location = new System.Drawing.Point(739, 17);
            this.SignOut_Label.Name = "SignOut_Label";
            this.SignOut_Label.Size = new System.Drawing.Size(62, 17);
            this.SignOut_Label.TabIndex = 0;
            this.SignOut_Label.TabStop = true;
            this.SignOut_Label.Text = "Sign Out";
            this.SignOut_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignOut_Label_LinkClicked);
            // 
            // Lower_Panel
            // 
            this.Lower_Panel.BackColor = System.Drawing.Color.AliceBlue;
            this.Lower_Panel.Controls.Add(this.MainMenu_Btn);
            this.Lower_Panel.Controls.Add(this.Expenses_Btn);
            this.Lower_Panel.Controls.Add(this.Participants_Btn);
            this.Lower_Panel.Controls.Add(this.Overview_Btn);
            this.Lower_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lower_Panel.Location = new System.Drawing.Point(0, 46);
            this.Lower_Panel.Name = "Lower_Panel";
            this.Lower_Panel.Size = new System.Drawing.Size(956, 56);
            this.Lower_Panel.TabIndex = 4;
            // 
            // MainMenu_Btn
            // 
            this.MainMenu_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainMenu_Btn.FlatAppearance.BorderSize = 0;
            this.MainMenu_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Btn.ForeColor = System.Drawing.Color.Black;
            this.MainMenu_Btn.Location = new System.Drawing.Point(841, 0);
            this.MainMenu_Btn.Name = "MainMenu_Btn";
            this.MainMenu_Btn.Size = new System.Drawing.Size(115, 56);
            this.MainMenu_Btn.TabIndex = 7;
            this.MainMenu_Btn.Text = "Main Menu";
            this.MainMenu_Btn.UseVisualStyleBackColor = true;
            this.MainMenu_Btn.Click += new System.EventHandler(this.MainMenu_Btn_Click);
            // 
            // Expenses_Btn
            // 
            this.Expenses_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Expenses_Btn.FlatAppearance.BorderSize = 0;
            this.Expenses_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expenses_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_Btn.ForeColor = System.Drawing.Color.Gray;
            this.Expenses_Btn.Location = new System.Drawing.Point(384, 0);
            this.Expenses_Btn.Name = "Expenses_Btn";
            this.Expenses_Btn.Size = new System.Drawing.Size(192, 56);
            this.Expenses_Btn.TabIndex = 6;
            this.Expenses_Btn.Text = "Expenses";
            this.Expenses_Btn.UseVisualStyleBackColor = true;
            this.Expenses_Btn.Click += new System.EventHandler(this.Expenses_Btn_Click);
            // 
            // Participants_Btn
            // 
            this.Participants_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Participants_Btn.FlatAppearance.BorderSize = 0;
            this.Participants_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Participants_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participants_Btn.ForeColor = System.Drawing.Color.Gray;
            this.Participants_Btn.Location = new System.Drawing.Point(192, 0);
            this.Participants_Btn.Name = "Participants_Btn";
            this.Participants_Btn.Size = new System.Drawing.Size(192, 56);
            this.Participants_Btn.TabIndex = 4;
            this.Participants_Btn.Text = "Participants";
            this.Participants_Btn.UseVisualStyleBackColor = true;
            // 
            // Overview_Btn
            // 
            this.Overview_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Overview_Btn.FlatAppearance.BorderSize = 0;
            this.Overview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Overview_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overview_Btn.ForeColor = System.Drawing.Color.Gray;
            this.Overview_Btn.Location = new System.Drawing.Point(0, 0);
            this.Overview_Btn.Name = "Overview_Btn";
            this.Overview_Btn.Size = new System.Drawing.Size(192, 56);
            this.Overview_Btn.TabIndex = 3;
            this.Overview_Btn.Text = "Overview";
            this.Overview_Btn.UseVisualStyleBackColor = true;
            this.Overview_Btn.Click += new System.EventHandler(this.Overview_Btn_Click);
            // 
            // Participants_Table
            // 
            this.Participants_Table.AllowUserToDeleteRows = false;
            this.Participants_Table.AllowUserToResizeColumns = false;
            this.Participants_Table.AllowUserToResizeRows = false;
            this.Participants_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Participants_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Participants_Table.Location = new System.Drawing.Point(86, 187);
            this.Participants_Table.Name = "Participants_Table";
            this.Participants_Table.RowTemplate.ReadOnly = true;
            this.Participants_Table.Size = new System.Drawing.Size(653, 278);
            this.Participants_Table.TabIndex = 5;
            this.Participants_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Participants_Table_CellClick);
            this.Participants_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Participants_Table_CellContentClick);
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programParticipantsBindingSource
            // 
            this.programParticipantsBindingSource.DataMember = "ProgramParticipants";
            this.programParticipantsBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // programParticipantsTableAdapter
            // 
            this.programParticipantsTableAdapter.ClearBeforeFill = true;
            // 
            // externalEntitiesBindingSource
            // 
            this.externalEntitiesBindingSource.DataMember = "ExternalEntities";
            this.externalEntitiesBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // externalEntitiesTableAdapter
            // 
            this.externalEntitiesTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(757, 156);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(62, 21);
            this.Add_Btn.TabIndex = 6;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(108, 160);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(97, 20);
            this.PhoneBox.TabIndex = 7;
            this.PhoneBox.Text = "Phone";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(636, 157);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(97, 20);
            this.ageBox.TabIndex = 8;
            this.ageBox.Text = "Age";
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(417, 158);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(97, 20);
            this.email_box.TabIndex = 9;
            this.email_box.Text = "Email";
            // 
            // last_name_box
            // 
            this.last_name_box.Location = new System.Drawing.Point(314, 158);
            this.last_name_box.Name = "last_name_box";
            this.last_name_box.Size = new System.Drawing.Size(97, 20);
            this.last_name_box.TabIndex = 10;
            this.last_name_box.Text = "Last Name";
            // 
            // first_name_box
            // 
            this.first_name_box.Location = new System.Drawing.Point(211, 159);
            this.first_name_box.Name = "first_name_box";
            this.first_name_box.Size = new System.Drawing.Size(97, 20);
            this.first_name_box.TabIndex = 11;
            this.first_name_box.Text = "First Name";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DataSource = this.gendersBindingSource;
            this.GenderComboBox.DisplayMember = "Gender";
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(520, 157);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(110, 21);
            this.GenderComboBox.TabIndex = 12;
            this.GenderComboBox.ValueMember = "Gender";
            // 
            // gendersBindingSource
            // 
            this.gendersBindingSource.DataMember = "Genders";
            this.gendersBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // gendersTableAdapter
            // 
            this.gendersTableAdapter.ClearBeforeFill = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(757, 440);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(62, 23);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // phoneComboBox
            // 
            this.phoneComboBox.FormattingEnabled = true;
            this.phoneComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.phoneComboBox.Items.AddRange(new object[] {
            "+972",
            "+971",
            "+1",
            "+44",
            "+49"});
            this.phoneComboBox.Location = new System.Drawing.Point(12, 161);
            this.phoneComboBox.Name = "phoneComboBox";
            this.phoneComboBox.Size = new System.Drawing.Size(71, 21);
            this.phoneComboBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(89, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "-";
            // 
            // ProgramMenu_Participants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneComboBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.first_name_box);
            this.Controls.Add(this.last_name_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Participants_Table);
            this.Controls.Add(this.Lower_Panel);
            this.Controls.Add(this.Top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramMenu_Participants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r";
            this.Load += new System.EventHandler(this.ProgramMenu_Participants_Load);
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            this.Lower_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Participants_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programParticipantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Label ProgramName_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.LinkLabel SignOut_Label;
        private System.Windows.Forms.Panel Lower_Panel;
        private System.Windows.Forms.Button MainMenu_Btn;
        private System.Windows.Forms.Button Expenses_Btn;
        private System.Windows.Forms.Button Participants_Btn;
        private System.Windows.Forms.Button Overview_Btn;
        private System.Windows.Forms.DataGridView Participants_Table;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource programParticipantsBindingSource;
        private SAD_11DataSetTableAdapters.ProgramParticipantsTableAdapter programParticipantsTableAdapter;
        private System.Windows.Forms.BindingSource externalEntitiesBindingSource;
        private SAD_11DataSetTableAdapters.ExternalEntitiesTableAdapter externalEntitiesTableAdapter;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox last_name_box;
        private System.Windows.Forms.TextBox first_name_box;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.BindingSource gendersBindingSource;
        private SAD_11DataSetTableAdapters.GendersTableAdapter gendersTableAdapter;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox phoneComboBox;
        private System.Windows.Forms.Label label1;
    }
}