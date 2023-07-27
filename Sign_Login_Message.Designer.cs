namespace Group11_Project
{
    partial class Sign_Login_Message
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
            this.Sign_Btn = new System.Windows.Forms.Button();
            this.Log_btn = new System.Windows.Forms.Button();
            this.Back_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sign_Btn
            // 
            this.Sign_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Sign_Btn.Location = new System.Drawing.Point(65, 23);
            this.Sign_Btn.Name = "Sign_Btn";
            this.Sign_Btn.Size = new System.Drawing.Size(137, 46);
            this.Sign_Btn.TabIndex = 0;
            this.Sign_Btn.Text = "Sign Up";
            this.Sign_Btn.UseVisualStyleBackColor = true;
            this.Sign_Btn.Click += new System.EventHandler(this.Sign_Btn_Click);
            // 
            // Log_btn
            // 
            this.Log_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Log_btn.Location = new System.Drawing.Point(266, 23);
            this.Log_btn.Name = "Log_btn";
            this.Log_btn.Size = new System.Drawing.Size(137, 46);
            this.Log_btn.TabIndex = 1;
            this.Log_btn.Text = "Log in";
            this.Log_btn.UseVisualStyleBackColor = true;
            this.Log_btn.Click += new System.EventHandler(this.Log_btn_Click);
            // 
            // Back_Btn
            // 
            this.Back_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Back_Btn.Location = new System.Drawing.Point(173, 91);
            this.Back_Btn.Name = "Back_Btn";
            this.Back_Btn.Size = new System.Drawing.Size(121, 26);
            this.Back_Btn.TabIndex = 2;
            this.Back_Btn.Text = "Back";
            this.Back_Btn.UseVisualStyleBackColor = true;
            this.Back_Btn.Click += new System.EventHandler(this.Back_Btn_Click);
            // 
            // Sign_Login_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(473, 139);
            this.Controls.Add(this.Back_Btn);
            this.Controls.Add(this.Log_btn);
            this.Controls.Add(this.Sign_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sign_Login_Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sign_Btn;
        private System.Windows.Forms.Button Log_btn;
        private System.Windows.Forms.Button Back_Btn;
    }
}