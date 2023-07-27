namespace Group11_Project
{
    partial class ExternalEntityAccountManagement
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
            this.viewExternalEntity_btn = new System.Windows.Forms.Button();
            this.addExternalEntity_btn = new System.Windows.Forms.Button();
            this.ExternalEntityAM = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewExternalEntity_btn
            // 
            this.viewExternalEntity_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.viewExternalEntity_btn.Location = new System.Drawing.Point(393, 130);
            this.viewExternalEntity_btn.Name = "viewExternalEntity_btn";
            this.viewExternalEntity_btn.Size = new System.Drawing.Size(191, 57);
            this.viewExternalEntity_btn.TabIndex = 4;
            this.viewExternalEntity_btn.Text = "View Entities";
            this.viewExternalEntity_btn.UseVisualStyleBackColor = true;
            this.viewExternalEntity_btn.Click += new System.EventHandler(this.viewExternalEntity_btn_Click);
            // 
            // addExternalEntity_btn
            // 
            this.addExternalEntity_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addExternalEntity_btn.Location = new System.Drawing.Point(139, 130);
            this.addExternalEntity_btn.Name = "addExternalEntity_btn";
            this.addExternalEntity_btn.Size = new System.Drawing.Size(191, 57);
            this.addExternalEntity_btn.TabIndex = 3;
            this.addExternalEntity_btn.Text = "Add External Entity";
            this.addExternalEntity_btn.UseVisualStyleBackColor = true;
            this.addExternalEntity_btn.Click += new System.EventHandler(this.addExternalEntity_btn_Click);
            // 
            // ExternalEntityAM
            // 
            this.ExternalEntityAM.AutoSize = true;
            this.ExternalEntityAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExternalEntityAM.Location = new System.Drawing.Point(20, 36);
            this.ExternalEntityAM.Name = "ExternalEntityAM";
            this.ExternalEntityAM.Size = new System.Drawing.Size(712, 46);
            this.ExternalEntityAM.TabIndex = 5;
            this.ExternalEntityAM.Text = "External Entity Account Management";
            this.ExternalEntityAM.Click += new System.EventHandler(this.ExternalEntityAM_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.Location = new System.Drawing.Point(298, 212);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(134, 34);
            this.Back_Button.TabIndex = 6;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // ExternalEntityAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(744, 271);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.ExternalEntityAM);
            this.Controls.Add(this.viewExternalEntity_btn);
            this.Controls.Add(this.addExternalEntity_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExternalEntityAccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExternalEntityAccountManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewExternalEntity_btn;
        private System.Windows.Forms.Button addExternalEntity_btn;
        private System.Windows.Forms.Label ExternalEntityAM;
        private System.Windows.Forms.Button Back_Button;
    }
}