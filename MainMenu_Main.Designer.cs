namespace Group11_Project
{
    partial class MainMenu_Main
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
            this.Name_Label = new System.Windows.Forms.Label();
            this.SignOut_Label = new System.Windows.Forms.LinkLabel();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.Accounts_Btn = new System.Windows.Forms.Button();
            this.Tasks_Btn = new System.Windows.Forms.Button();
            this.MainMenu_Btn = new System.Windows.Forms.Button();
            this.Report_Btn = new System.Windows.Forms.Button();
            this.Desks_Btn = new System.Windows.Forms.Button();
            this.AddProgram_Label = new System.Windows.Forms.Label();
            this.AddProgram_Btn = new System.Windows.Forms.Button();
            this.Marketing = new System.Windows.Forms.Label();
            this.Tech7_Hub = new System.Windows.Forms.Label();
            this.Programs = new System.Windows.Forms.Label();
            this.Program_Flow = new System.Windows.Forms.FlowLayoutPanel();
            this.Program1_Btn = new System.Windows.Forms.Button();
            this.Top_Panel.SuspendLayout();
            this.Side_Panel.SuspendLayout();
            this.Program_Flow.SuspendLayout();
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
            this.Top_Panel.Controls.Add(this.Name_Label);
            this.Top_Panel.Controls.Add(this.SignOut_Label);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(956, 46);
            this.Top_Panel.TabIndex = 1;
            // 
            // Side_Panel
            // 
            this.Side_Panel.BackColor = System.Drawing.Color.AliceBlue;
            this.Side_Panel.Controls.Add(this.Accounts_Btn);
            this.Side_Panel.Controls.Add(this.Tasks_Btn);
            this.Side_Panel.Controls.Add(this.MainMenu_Btn);
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 46);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(157, 582);
            this.Side_Panel.TabIndex = 2;
            // 
            // Accounts_Btn
            // 
            this.Accounts_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Accounts_Btn.FlatAppearance.BorderSize = 0;
            this.Accounts_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accounts_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Accounts_Btn.ForeColor = System.Drawing.Color.Gray;
            this.Accounts_Btn.Location = new System.Drawing.Point(0, 88);
            this.Accounts_Btn.Name = "Accounts_Btn";
            this.Accounts_Btn.Size = new System.Drawing.Size(157, 44);
            this.Accounts_Btn.TabIndex = 2;
            this.Accounts_Btn.Text = "Accounts";
            this.Accounts_Btn.UseVisualStyleBackColor = true;
            this.Accounts_Btn.Visible = false;
            this.Accounts_Btn.Click += new System.EventHandler(this.Accounts_Btn_Click);
            // 
            // Tasks_Btn
            // 
            this.Tasks_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tasks_Btn.FlatAppearance.BorderSize = 0;
            this.Tasks_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tasks_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Tasks_Btn.ForeColor = System.Drawing.Color.Gray;
            this.Tasks_Btn.Location = new System.Drawing.Point(0, 44);
            this.Tasks_Btn.Name = "Tasks_Btn";
            this.Tasks_Btn.Size = new System.Drawing.Size(157, 44);
            this.Tasks_Btn.TabIndex = 1;
            this.Tasks_Btn.Text = "Tasks";
            this.Tasks_Btn.UseVisualStyleBackColor = true;
            this.Tasks_Btn.Click += new System.EventHandler(this.Tasks_Btn_Click);
            // 
            // MainMenu_Btn
            // 
            this.MainMenu_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenu_Btn.FlatAppearance.BorderSize = 0;
            this.MainMenu_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MainMenu_Btn.ForeColor = System.Drawing.Color.Gray;
            this.MainMenu_Btn.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_Btn.Name = "MainMenu_Btn";
            this.MainMenu_Btn.Size = new System.Drawing.Size(157, 44);
            this.MainMenu_Btn.TabIndex = 0;
            this.MainMenu_Btn.Text = "Main Menu";
            this.MainMenu_Btn.UseVisualStyleBackColor = true;
            // 
            // Report_Btn
            // 
            this.Report_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_Btn.Location = new System.Drawing.Point(272, 486);
            this.Report_Btn.Name = "Report_Btn";
            this.Report_Btn.Size = new System.Drawing.Size(94, 91);
            this.Report_Btn.TabIndex = 17;
            this.Report_Btn.Text = "Produce Report";
            this.Report_Btn.UseVisualStyleBackColor = true;
            this.Report_Btn.Click += new System.EventHandler(this.Report_Btn_Click);
            // 
            // Desks_Btn
            // 
            this.Desks_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desks_Btn.Location = new System.Drawing.Point(272, 305);
            this.Desks_Btn.Name = "Desks_Btn";
            this.Desks_Btn.Size = new System.Drawing.Size(94, 91);
            this.Desks_Btn.TabIndex = 16;
            this.Desks_Btn.Text = "Desks";
            this.Desks_Btn.UseVisualStyleBackColor = true;
            this.Desks_Btn.Click += new System.EventHandler(this.Desks_Btn_Click);
            // 
            // AddProgram_Label
            // 
            this.AddProgram_Label.AutoSize = true;
            this.AddProgram_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProgram_Label.Location = new System.Drawing.Point(638, 211);
            this.AddProgram_Label.Name = "AddProgram_Label";
            this.AddProgram_Label.Size = new System.Drawing.Size(95, 17);
            this.AddProgram_Label.TabIndex = 15;
            this.AddProgram_Label.Text = "Add Program";
            // 
            // AddProgram_Btn
            // 
            this.AddProgram_Btn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProgram_Btn.Location = new System.Drawing.Point(663, 170);
            this.AddProgram_Btn.Name = "AddProgram_Btn";
            this.AddProgram_Btn.Size = new System.Drawing.Size(40, 38);
            this.AddProgram_Btn.TabIndex = 14;
            this.AddProgram_Btn.Text = "+";
            this.AddProgram_Btn.UseVisualStyleBackColor = true;
            // 
            // Marketing
            // 
            this.Marketing.AutoSize = true;
            this.Marketing.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marketing.Location = new System.Drawing.Point(226, 415);
            this.Marketing.Name = "Marketing";
            this.Marketing.Size = new System.Drawing.Size(200, 44);
            this.Marketing.TabIndex = 11;
            this.Marketing.Text = "Marketing";
            // 
            // Tech7_Hub
            // 
            this.Tech7_Hub.AutoSize = true;
            this.Tech7_Hub.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tech7_Hub.Location = new System.Drawing.Point(226, 246);
            this.Tech7_Hub.Name = "Tech7_Hub";
            this.Tech7_Hub.Size = new System.Drawing.Size(208, 44);
            this.Tech7_Hub.TabIndex = 10;
            this.Tech7_Hub.Text = "Tech7 Hub";
            // 
            // Programs
            // 
            this.Programs.AutoSize = true;
            this.Programs.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programs.Location = new System.Drawing.Point(226, 82);
            this.Programs.Name = "Programs";
            this.Programs.Size = new System.Drawing.Size(188, 44);
            this.Programs.TabIndex = 9;
            this.Programs.Text = "Programs";
            // 
            // Program_Flow
            // 
            this.Program_Flow.AutoScroll = true;
            this.Program_Flow.Controls.Add(this.Program1_Btn);
            this.Program_Flow.Location = new System.Drawing.Point(272, 143);
            this.Program_Flow.Name = "Program_Flow";
            this.Program_Flow.Size = new System.Drawing.Size(340, 100);
            this.Program_Flow.TabIndex = 18;
            // 
            // Program1_Btn
            // 
            this.Program1_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Program1_Btn.Location = new System.Drawing.Point(3, 3);
            this.Program1_Btn.Name = "Program1_Btn";
            this.Program1_Btn.Size = new System.Drawing.Size(94, 91);
            this.Program1_Btn.TabIndex = 12;
            this.Program1_Btn.Text = "BIPA11";
            this.Program1_Btn.UseVisualStyleBackColor = true;
            this.Program1_Btn.Click += new System.EventHandler(this.Program1_Btn_Click);
            // 
            // MainMenu_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 628);
            this.Controls.Add(this.Program_Flow);
            this.Controls.Add(this.Report_Btn);
            this.Controls.Add(this.Desks_Btn);
            this.Controls.Add(this.AddProgram_Label);
            this.Controls.Add(this.AddProgram_Btn);
            this.Controls.Add(this.Marketing);
            this.Controls.Add(this.Tech7_Hub);
            this.Controls.Add(this.Programs);
            this.Controls.Add(this.Side_Panel);
            this.Controls.Add(this.Top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu_Main";
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            this.Side_Panel.ResumeLayout(false);
            this.Program_Flow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.LinkLabel SignOut_Label;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Button Accounts_Btn;
        private System.Windows.Forms.Button Tasks_Btn;
        private System.Windows.Forms.Button MainMenu_Btn;
        private System.Windows.Forms.Button Report_Btn;
        private System.Windows.Forms.Button Desks_Btn;
        private System.Windows.Forms.Label AddProgram_Label;
        private System.Windows.Forms.Button AddProgram_Btn;
        private System.Windows.Forms.Label Marketing;
        private System.Windows.Forms.Label Tech7_Hub;
        private System.Windows.Forms.Label Programs;
        private System.Windows.Forms.FlowLayoutPanel Program_Flow;
        private System.Windows.Forms.Button Program1_Btn;
    }
}