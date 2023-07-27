namespace Group11_Project
{
    partial class WorkersAccountManagement
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
            this.UpperLabel = new System.Windows.Forms.Label();
            this.addWorker_btn = new System.Windows.Forms.Button();
            this.viewWorkers_btn = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpperLabel
            // 
            this.UpperLabel.AutoSize = true;
            this.UpperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpperLabel.Location = new System.Drawing.Point(39, 34);
            this.UpperLabel.Name = "UpperLabel";
            this.UpperLabel.Size = new System.Drawing.Size(595, 46);
            this.UpperLabel.TabIndex = 0;
            this.UpperLabel.Text = "Workers Account Management";
            this.UpperLabel.Click += new System.EventHandler(this.UpperLabel_Click);
            // 
            // addWorker_btn
            // 
            this.addWorker_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addWorker_btn.Location = new System.Drawing.Point(128, 102);
            this.addWorker_btn.Name = "addWorker_btn";
            this.addWorker_btn.Size = new System.Drawing.Size(166, 57);
            this.addWorker_btn.TabIndex = 1;
            this.addWorker_btn.Text = "Add Worker";
            this.addWorker_btn.UseVisualStyleBackColor = true;
            this.addWorker_btn.Click += new System.EventHandler(this.addWorker_btn_Click);
            // 
            // viewWorkers_btn
            // 
            this.viewWorkers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.viewWorkers_btn.Location = new System.Drawing.Point(387, 102);
            this.viewWorkers_btn.Name = "viewWorkers_btn";
            this.viewWorkers_btn.Size = new System.Drawing.Size(166, 57);
            this.viewWorkers_btn.TabIndex = 2;
            this.viewWorkers_btn.Text = "View Workers";
            this.viewWorkers_btn.UseVisualStyleBackColor = true;
            this.viewWorkers_btn.Click += new System.EventHandler(this.viewWorkers_btn_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.Location = new System.Drawing.Point(274, 184);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(134, 34);
            this.Back_Button.TabIndex = 7;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // WorkersAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(674, 240);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.viewWorkers_btn);
            this.Controls.Add(this.addWorker_btn);
            this.Controls.Add(this.UpperLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkersAccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WorkersAccountManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpperLabel;
        private System.Windows.Forms.Button addWorker_btn;
        private System.Windows.Forms.Button viewWorkers_btn;
        private System.Windows.Forms.Button Back_Button;
    }
}