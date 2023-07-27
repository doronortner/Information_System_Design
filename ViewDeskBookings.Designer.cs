namespace Group11_Project
{
    partial class ViewDeskBookings
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
            this.BookingDataGridView = new System.Windows.Forms.DataGridView();
            this.topLebal = new System.Windows.Forms.Label();
            this.NewBookingButton = new System.Windows.Forms.Button();
            this.CancelBooking_Btn = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.SignOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingDataGridView
            // 
            this.BookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingDataGridView.Location = new System.Drawing.Point(31, 181);
            this.BookingDataGridView.Name = "BookingDataGridView";
            this.BookingDataGridView.Size = new System.Drawing.Size(739, 244);
            this.BookingDataGridView.TabIndex = 0;
            this.BookingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookingDataGridView_CellContentClick);
            // 
            // topLebal
            // 
            this.topLebal.AutoSize = true;
            this.topLebal.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.topLebal.Location = new System.Drawing.Point(228, 27);
            this.topLebal.Name = "topLebal";
            this.topLebal.Size = new System.Drawing.Size(347, 63);
            this.topLebal.TabIndex = 1;
            this.topLebal.Text = "My Bookings";
            // 
            // NewBookingButton
            // 
            this.NewBookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NewBookingButton.Location = new System.Drawing.Point(254, 118);
            this.NewBookingButton.Name = "NewBookingButton";
            this.NewBookingButton.Size = new System.Drawing.Size(291, 38);
            this.NewBookingButton.TabIndex = 2;
            this.NewBookingButton.Text = "New Desk Reservation";
            this.NewBookingButton.UseVisualStyleBackColor = true;
            this.NewBookingButton.Click += new System.EventHandler(this.NewBookingButton_Click);
            // 
            // CancelBooking_Btn
            // 
            this.CancelBooking_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CancelBooking_Btn.Location = new System.Drawing.Point(254, 448);
            this.CancelBooking_Btn.Name = "CancelBooking_Btn";
            this.CancelBooking_Btn.Size = new System.Drawing.Size(291, 38);
            this.CancelBooking_Btn.TabIndex = 3;
            this.CancelBooking_Btn.Text = "Cancel Desk Reservation";
            this.CancelBooking_Btn.UseVisualStyleBackColor = true;
            this.CancelBooking_Btn.Click += new System.EventHandler(this.CancelBooking_Btn_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.helloLabel.Location = new System.Drawing.Point(12, 9);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(45, 17);
            this.helloLabel.TabIndex = 4;
            this.helloLabel.Text = "Hello";
            // 
            // SignOutButton
            // 
            this.SignOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SignOutButton.Location = new System.Drawing.Point(716, 9);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(89, 32);
            this.SignOutButton.TabIndex = 5;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // ViewDeskBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(817, 511);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.CancelBooking_Btn);
            this.Controls.Add(this.NewBookingButton);
            this.Controls.Add(this.topLebal);
            this.Controls.Add(this.BookingDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewDeskBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDeskBookings";
            ((System.ComponentModel.ISupportInitialize)(this.BookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BookingDataGridView;
        private System.Windows.Forms.Label topLebal;
        private System.Windows.Forms.Button NewBookingButton;
        private System.Windows.Forms.Button CancelBooking_Btn;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Button SignOutButton;
    }
}