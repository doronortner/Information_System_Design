namespace Group11_Project
{
    partial class Identification
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
            this.Login = new System.Windows.Forms.Label();
            this.Pleasechoose = new System.Windows.Forms.Label();
            this.Worker_button = new System.Windows.Forms.Button();
            this.Guest_button = new System.Windows.Forms.Button();
            this.allowedOccupationTableAdapter1 = new Group11_Project.SAD_11DataSetTableAdapters.AllowedOccupationTableAdapter();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Login.Location = new System.Drawing.Point(127, 30);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(195, 73);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseWaitCursor = true;
            // 
            // Pleasechoose
            // 
            this.Pleasechoose.AutoSize = true;
            this.Pleasechoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Pleasechoose.Location = new System.Drawing.Point(150, 116);
            this.Pleasechoose.Name = "Pleasechoose";
            this.Pleasechoose.Size = new System.Drawing.Size(148, 24);
            this.Pleasechoose.TabIndex = 1;
            this.Pleasechoose.Text = "Please choose";
            this.Pleasechoose.UseWaitCursor = true;
            // 
            // Worker_button
            // 
            this.Worker_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Worker_button.Location = new System.Drawing.Point(263, 195);
            this.Worker_button.Name = "Worker_button";
            this.Worker_button.Size = new System.Drawing.Size(149, 52);
            this.Worker_button.TabIndex = 2;
            this.Worker_button.Text = "Worker";
            this.Worker_button.UseVisualStyleBackColor = true;
            this.Worker_button.UseWaitCursor = true;
            this.Worker_button.Click += new System.EventHandler(this.Worker_button_Click);
            // 
            // Guest_button
            // 
            this.Guest_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Guest_button.Location = new System.Drawing.Point(46, 195);
            this.Guest_button.Name = "Guest_button";
            this.Guest_button.Size = new System.Drawing.Size(149, 52);
            this.Guest_button.TabIndex = 3;
            this.Guest_button.Text = "Guest";
            this.Guest_button.UseVisualStyleBackColor = true;
            this.Guest_button.UseWaitCursor = true;
            this.Guest_button.Click += new System.EventHandler(this.ExternalEntity_button_Click);
            // 
            // allowedOccupationTableAdapter1
            // 
            this.allowedOccupationTableAdapter1.ClearBeforeFill = true;
            // 
            // Identification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(455, 265);
            this.Controls.Add(this.Guest_button);
            this.Controls.Add(this.Worker_button);
            this.Controls.Add(this.Pleasechoose);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Identification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identification";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Pleasechoose;
        private System.Windows.Forms.Button Worker_button;
        private System.Windows.Forms.Button Guest_button;
        private SAD_11DataSetTableAdapters.AllowedOccupationTableAdapter allowedOccupationTableAdapter1;
    }
}