namespace Group11_Project
{
    partial class ExternalEntityIdentification
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
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Connect_button = new System.Windows.Forms.Button();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Phone_Box = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Phone_Combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(284, 240);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(95, 33);
            this.Cancel_button.TabIndex = 13;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(124, 240);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(95, 33);
            this.Connect_button.TabIndex = 12;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(241, 171);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(211, 20);
            this.Password_Box.TabIndex = 11;
            // 
            // Phone_Box
            // 
            this.Phone_Box.Location = new System.Drawing.Point(342, 121);
            this.Phone_Box.Name = "Phone_Box";
            this.Phone_Box.Size = new System.Drawing.Size(116, 20);
            this.Phone_Box.TabIndex = 10;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Password.Location = new System.Drawing.Point(54, 166);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(121, 25);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PhoneNumber.Location = new System.Drawing.Point(54, 117);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(174, 25);
            this.PhoneNumber.TabIndex = 8;
            this.PhoneNumber.Text = "Phone Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please enter your credentials";
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
            this.Phone_Combo.Location = new System.Drawing.Point(242, 120);
            this.Phone_Combo.Name = "Phone_Combo";
            this.Phone_Combo.Size = new System.Drawing.Size(68, 21);
            this.Phone_Combo.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(316, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "-";
            // 
            // ExternalEntityIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(518, 318);
            this.Controls.Add(this.Phone_Combo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Phone_Box);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExternalEntityIdentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.TextBox Phone_Box;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Phone_Combo;
        private System.Windows.Forms.Label label7;
    }
}