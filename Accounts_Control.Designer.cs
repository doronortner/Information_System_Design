namespace Group11_Project
{
    partial class Accounts_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Workers_Btn = new System.Windows.Forms.Button();
            this.Entities_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Workers_Btn
            // 
            this.Workers_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workers_Btn.Location = new System.Drawing.Point(50, 92);
            this.Workers_Btn.Name = "Workers_Btn";
            this.Workers_Btn.Size = new System.Drawing.Size(135, 128);
            this.Workers_Btn.TabIndex = 1;
            this.Workers_Btn.Text = "Workers";
            this.Workers_Btn.UseVisualStyleBackColor = true;
            this.Workers_Btn.Click += new System.EventHandler(this.Workers_Btn_Click);
            // 
            // Entities_Btn
            // 
            this.Entities_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entities_Btn.Location = new System.Drawing.Point(249, 92);
            this.Entities_Btn.Name = "Entities_Btn";
            this.Entities_Btn.Size = new System.Drawing.Size(135, 128);
            this.Entities_Btn.TabIndex = 2;
            this.Entities_Btn.Text = "Entities";
            this.Entities_Btn.UseVisualStyleBackColor = true;
            this.Entities_Btn.Click += new System.EventHandler(this.Entities_Btn_Click);
            // 
            // Accounts_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Entities_Btn);
            this.Controls.Add(this.Workers_Btn);
            this.Name = "Accounts_Control";
            this.Size = new System.Drawing.Size(452, 295);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Workers_Btn;
        private System.Windows.Forms.Button Entities_Btn;
    }
}
