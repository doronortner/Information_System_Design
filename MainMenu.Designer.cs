namespace Group11_Project
{
    partial class MainMenu
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
            this.Name_Label = new System.Windows.Forms.Label();
            this.SignOut_Label = new System.Windows.Forms.LinkLabel();
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.Accounts_Btn = new System.Windows.Forms.Button();
            this.Tasks_Btn = new System.Windows.Forms.Button();
            this.MainMenu_Btn = new System.Windows.Forms.Button();
            this.mainMenu_Control1 = new Group11_Project.MainMenu_Control();
            this.tasks_Control1 = new Group11_Project.Tasks_Control();
            this.accounts_Control1 = new Group11_Project.Accounts_Control();
            this.Top_Panel.SuspendLayout();
            this.Side_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.Top_Panel.Controls.Add(this.Name_Label);
            this.Top_Panel.Controls.Add(this.SignOut_Label);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(972, 46);
            this.Top_Panel.TabIndex = 0;
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
            this.Name_Label.Click += new System.EventHandler(this.Name_Label_Click);
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
            // Side_Panel
            // 
            this.Side_Panel.BackColor = System.Drawing.Color.AliceBlue;
            this.Side_Panel.Controls.Add(this.Accounts_Btn);
            this.Side_Panel.Controls.Add(this.Tasks_Btn);
            this.Side_Panel.Controls.Add(this.MainMenu_Btn);
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 46);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(157, 621);
            this.Side_Panel.TabIndex = 1;
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
            this.MainMenu_Btn.Click += new System.EventHandler(this.MainMenu_Btn_Click);
            // 
            // mainMenu_Control1
            // 
            this.mainMenu_Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu_Control1.Location = new System.Drawing.Point(157, 46);
            this.mainMenu_Control1.Name = "mainMenu_Control1";
            this.mainMenu_Control1.Size = new System.Drawing.Size(815, 621);
            this.mainMenu_Control1.TabIndex = 3;
            // 
            // tasks_Control1
            // 
            this.tasks_Control1.BackColor = System.Drawing.Color.White;
            this.tasks_Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasks_Control1.Location = new System.Drawing.Point(157, 46);
            this.tasks_Control1.Name = "tasks_Control1";
            this.tasks_Control1.Size = new System.Drawing.Size(815, 621);
            this.tasks_Control1.TabIndex = 2;
            this.tasks_Control1.Visible = false;
            // 
            // accounts_Control1
            // 
            this.accounts_Control1.Location = new System.Drawing.Point(315, 206);
            this.accounts_Control1.Name = "accounts_Control1";
            this.accounts_Control1.Size = new System.Drawing.Size(452, 295);
            this.accounts_Control1.TabIndex = 4;
            this.accounts_Control1.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 667);
            this.Controls.Add(this.accounts_Control1);
            this.Controls.Add(this.mainMenu_Control1);
            this.Controls.Add(this.tasks_Control1);
            this.Controls.Add(this.Side_Panel);
            this.Controls.Add(this.Top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            this.Side_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Button Tasks_Btn;
        private System.Windows.Forms.Button MainMenu_Btn;
        private Tasks_Control tasks_Control1;
        private MainMenu_Control mainMenu_Control1;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.LinkLabel SignOut_Label;
        private System.Windows.Forms.Button Accounts_Btn;
        private Accounts_Control accounts_Control1;
    }
}