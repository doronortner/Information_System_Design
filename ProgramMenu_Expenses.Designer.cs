namespace Group11_Project
{
    partial class ProgramMenu_Expenses
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
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.ProgramName_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.SignOut_Label = new System.Windows.Forms.LinkLabel();
            this.Lower_Panel = new System.Windows.Forms.Panel();
            this.MainMenu_Btn = new System.Windows.Forms.Button();
            this.Expenses_Btn = new System.Windows.Forms.Button();
            this.Participants_Btn = new System.Windows.Forms.Button();
            this.Overview_Btn = new System.Windows.Forms.Button();
            this.Budget = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount_Box = new System.Windows.Forms.TextBox();
            this.Expense_Btn = new System.Windows.Forms.Button();
            this.Top_Panel.SuspendLayout();
            this.Lower_Panel.SuspendLayout();
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
            this.Top_Panel.TabIndex = 3;
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
            this.Lower_Panel.TabIndex = 5;
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
            this.Overview_Btn.Click += new System.EventHandler(this.Overview_Btn_Click);
            // 
            // Budget
            // 
            this.Budget.AutoSize = true;
            this.Budget.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Budget.ForeColor = System.Drawing.Color.SteelBlue;
            this.Budget.Location = new System.Drawing.Point(531, 159);
            this.Budget.Name = "Budget";
            this.Budget.Size = new System.Drawing.Size(84, 28);
            this.Budget.TabIndex = 17;
            this.Budget.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(280, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Remained Budget";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(216, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Amount";
            // 
            // Amount_Box
            // 
            this.Amount_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Amount_Box.Location = new System.Drawing.Point(374, 261);
            this.Amount_Box.Name = "Amount_Box";
            this.Amount_Box.Size = new System.Drawing.Size(116, 31);
            this.Amount_Box.TabIndex = 19;
            // 
            // Expense_Btn
            // 
            this.Expense_Btn.Location = new System.Drawing.Point(536, 261);
            this.Expense_Btn.Name = "Expense_Btn";
            this.Expense_Btn.Size = new System.Drawing.Size(118, 28);
            this.Expense_Btn.TabIndex = 20;
            this.Expense_Btn.Text = "Add Expense";
            this.Expense_Btn.UseVisualStyleBackColor = true;
            this.Expense_Btn.Click += new System.EventHandler(this.Expense_Btn_Click);
            // 
            // ProgramMenu_Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 628);
            this.Controls.Add(this.Expense_Btn);
            this.Controls.Add(this.Amount_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Budget);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lower_Panel);
            this.Controls.Add(this.Top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramMenu_Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramMenu_Expenses";
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            this.Lower_Panel.ResumeLayout(false);
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
        private System.Windows.Forms.Label Budget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amount_Box;
        private System.Windows.Forms.Button Expense_Btn;
    }
}