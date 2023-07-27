namespace Group11_Project
{
    partial class ExternalEntity_Menu
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
            this.BookingDeskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookingDeskButton
            // 
            this.BookingDeskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BookingDeskButton.Location = new System.Drawing.Point(126, 87);
            this.BookingDeskButton.Name = "BookingDeskButton";
            this.BookingDeskButton.Size = new System.Drawing.Size(150, 85);
            this.BookingDeskButton.TabIndex = 0;
            this.BookingDeskButton.Text = "Book A Desk";
            this.BookingDeskButton.UseVisualStyleBackColor = true;
            this.BookingDeskButton.Click += new System.EventHandler(this.BookingDeskButton_Click);
            // 
            // ExternalEntity_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 367);
            this.Controls.Add(this.BookingDeskButton);
            this.Name = "ExternalEntity_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExternalEntity_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BookingDeskButton;
    }
}