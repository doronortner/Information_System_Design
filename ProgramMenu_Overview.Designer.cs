namespace Group11_Project
{
    partial class ProgramMenu_Overview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Name_Label = new System.Windows.Forms.Label();
            this.SignOut_Label = new System.Windows.Forms.LinkLabel();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.ProgramName_Label = new System.Windows.Forms.Label();
            this.Lower_Panel = new System.Windows.Forms.Panel();
            this.MainMenu_Btn = new System.Windows.Forms.Button();
            this.Expenses_Btn = new System.Windows.Forms.Button();
            this.Participants_Btn = new System.Windows.Forms.Button();
            this.Overview_Btn = new System.Windows.Forms.Button();
            this.Status_Combo = new System.Windows.Forms.ComboBox();
            this.Tasks_Table = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Budget = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Participants_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Top_Panel.SuspendLayout();
            this.Lower_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(693, 17);
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
            this.SignOut_Label.Location = new System.Drawing.Point(882, 17);
            this.SignOut_Label.Name = "SignOut_Label";
            this.SignOut_Label.Size = new System.Drawing.Size(62, 17);
            this.SignOut_Label.TabIndex = 0;
            this.SignOut_Label.TabStop = true;
            this.SignOut_Label.Text = "Sign Out";
            this.SignOut_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignOut_Label_LinkClicked);
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
            this.Top_Panel.TabIndex = 1;
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
            this.Lower_Panel.TabIndex = 3;
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
            this.Participants_Btn.Click += new System.EventHandler(this.Participants_Btn_Click);
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
            // 
            // Status_Combo
            // 
            this.Status_Combo.DisplayMember = "Status";
            this.Status_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_Combo.FormattingEnabled = true;
            this.Status_Combo.Items.AddRange(new object[] {
            "Active",
            "Archived",
            "Finished",
            "Planning",
            "Preparation"});
            this.Status_Combo.Location = new System.Drawing.Point(439, 277);
            this.Status_Combo.Name = "Status_Combo";
            this.Status_Combo.Size = new System.Drawing.Size(137, 21);
            this.Status_Combo.TabIndex = 16;
            this.Status_Combo.ValueMember = "Status";
            this.Status_Combo.SelectedIndexChanged += new System.EventHandler(this.Status_Combo_SelectedIndexChanged);
            // 
            // Tasks_Table
            // 
            this.Tasks_Table.AllowUserToDeleteRows = false;
            this.Tasks_Table.AllowUserToResizeColumns = false;
            this.Tasks_Table.AllowUserToResizeRows = false;
            this.Tasks_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tasks_Table.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tasks_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Tasks_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tasks_Table.Location = new System.Drawing.Point(230, 352);
            this.Tasks_Table.Name = "Tasks_Table";
            this.Tasks_Table.Size = new System.Drawing.Size(606, 190);
            this.Tasks_Table.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(112, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tasks";
            // 
            // Budget
            // 
            this.Budget.AutoSize = true;
            this.Budget.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Budget.ForeColor = System.Drawing.Color.SteelBlue;
            this.Budget.Location = new System.Drawing.Point(752, 176);
            this.Budget.Name = "Budget";
            this.Budget.Size = new System.Drawing.Size(84, 28);
            this.Budget.TabIndex = 13;
            this.Budget.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(501, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Remained Budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(112, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Status";
            // 
            // Participants_Label
            // 
            this.Participants_Label.AutoSize = true;
            this.Participants_Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participants_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.Participants_Label.Location = new System.Drawing.Point(272, 176);
            this.Participants_Label.Name = "Participants_Label";
            this.Participants_Label.Size = new System.Drawing.Size(84, 28);
            this.Participants_Label.TabIndex = 10;
            this.Participants_Label.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(107, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Participants";
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.Status_Label.Location = new System.Drawing.Point(235, 268);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(84, 28);
            this.Status_Label.TabIndex = 18;
            this.Status_Label.Text = "label2";
            // 
            // ProgramMenu_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 628);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.Status_Combo);
            this.Controls.Add(this.Tasks_Table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Budget);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Participants_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lower_Panel);
            this.Controls.Add(this.Top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramMenu_Overview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramMenu_Overview";
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            this.Lower_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.LinkLabel SignOut_Label;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Panel Lower_Panel;
        private System.Windows.Forms.Button Expenses_Btn;
        private System.Windows.Forms.Button Participants_Btn;
        private System.Windows.Forms.Button Overview_Btn;
        private System.Windows.Forms.Button MainMenu_Btn;
        private System.Windows.Forms.ComboBox Status_Combo;
        private System.Windows.Forms.DataGridView Tasks_Table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Budget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Participants_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProgramName_Label;
        private System.Windows.Forms.Label Status_Label;
    }
}