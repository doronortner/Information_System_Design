namespace Group11_Project
{
    partial class WorkerIdentification
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
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Connect_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your credentials ";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ID.Location = new System.Drawing.Point(70, 118);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(41, 25);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Password.Location = new System.Drawing.Point(70, 172);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(121, 25);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password:";
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(215, 124);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(179, 20);
            this.ID_Box.TabIndex = 3;
            this.ID_Box.TextChanged += new System.EventHandler(this.ID_Box_TextChanged);
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(215, 177);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(179, 20);
            this.Password_Box.TabIndex = 4;
            this.Password_Box.TextChanged += new System.EventHandler(this.Password_Box_TextChanged);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(289, 237);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(95, 33);
            this.Cancel_button.TabIndex = 15;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(129, 237);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(95, 33);
            this.Connect_button.TabIndex = 14;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // WorkerIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(517, 311);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerIdentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerIdentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Connect_button;
    }
}