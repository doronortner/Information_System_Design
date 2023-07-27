namespace Group11_Project
{
    partial class MainMenu_Accounts
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
            this.Entities_Btn = new System.Windows.Forms.Button();
            this.Workers_Btn = new System.Windows.Forms.Button();
            this.Top_Panel.SuspendLayout();
            this.Side_Panel.SuspendLayout();
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
            // Entities_Btn
            // 
            this.Entities_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entities_Btn.Location = new System.Drawing.Point(215, 149);
            this.Entities_Btn.Name = "Entities_Btn";
            this.Entities_Btn.Size = new System.Drawing.Size(322, 412);
            this.Entities_Btn.TabIndex = 4;
            this.Entities_Btn.Text = "Entities";
            this.Entities_Btn.UseVisualStyleBackColor = true;
            this.Entities_Btn.Click += new System.EventHandler(this.Entities_Btn_Click);
            // 
            // Workers_Btn
            // 
            this.Workers_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workers_Btn.Location = new System.Drawing.Point(568, 149);
            this.Workers_Btn.Name = "Workers_Btn";
            this.Workers_Btn.Size = new System.Drawing.Size(322, 412);
            this.Workers_Btn.TabIndex = 3;
            this.Workers_Btn.Text = "Workers";
            this.Workers_Btn.UseVisualStyleBackColor = true;
            this.Workers_Btn.Click += new System.EventHandler(this.Workers_Btn_Click);
            // 
            // MainMenu_Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 628);
            this.Controls.Add(this.Entities_Btn);
            this.Controls.Add(this.Workers_Btn);
            this.Controls.Add(this.Side_Panel);
            this.Controls.Add(this.Top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu_Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu_Accounts";
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            this.Side_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.LinkLabel SignOut_Label;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Button Accounts_Btn;
        private System.Windows.Forms.Button Tasks_Btn;
        private System.Windows.Forms.Button MainMenu_Btn;
        private System.Windows.Forms.Button Entities_Btn;
        private System.Windows.Forms.Button Workers_Btn;
    }
}