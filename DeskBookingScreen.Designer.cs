namespace Group11_Project
{
    partial class DeskBookingScreen
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
            this.DeskBookingHeader = new System.Windows.Forms.Label();
            this.FindDeskBtn = new System.Windows.Forms.Button();
            this.AvailbleDeskGridView = new System.Windows.Forms.DataGridView();
            this.askedStartDt = new System.Windows.Forms.DateTimePicker();
            this.askedEndDt = new System.Windows.Forms.DateTimePicker();
            this.BookBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.taskLabelTableAdapter1 = new Group11_Project.SAD_11DataSetTableAdapters.TaskLabelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvailbleDeskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeskBookingHeader
            // 
            this.DeskBookingHeader.AutoSize = true;
            this.DeskBookingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DeskBookingHeader.Location = new System.Drawing.Point(311, 32);
            this.DeskBookingHeader.Name = "DeskBookingHeader";
            this.DeskBookingHeader.Size = new System.Drawing.Size(342, 63);
            this.DeskBookingHeader.TabIndex = 0;
            this.DeskBookingHeader.Text = "Book a Desk";
            this.DeskBookingHeader.Click += new System.EventHandler(this.DeskBookingHeader_Click);
            // 
            // FindDeskBtn
            // 
            this.FindDeskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FindDeskBtn.Location = new System.Drawing.Point(104, 425);
            this.FindDeskBtn.Name = "FindDeskBtn";
            this.FindDeskBtn.Size = new System.Drawing.Size(134, 43);
            this.FindDeskBtn.TabIndex = 4;
            this.FindDeskBtn.Text = "Find Desk";
            this.FindDeskBtn.UseVisualStyleBackColor = true;
            this.FindDeskBtn.Click += new System.EventHandler(this.FindDeskBtn_Click);
            // 
            // AvailbleDeskGridView
            // 
            this.AvailbleDeskGridView.AllowUserToAddRows = false;
            this.AvailbleDeskGridView.AllowUserToDeleteRows = false;
            this.AvailbleDeskGridView.AllowUserToResizeColumns = false;
            this.AvailbleDeskGridView.AllowUserToResizeRows = false;
            this.AvailbleDeskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailbleDeskGridView.Location = new System.Drawing.Point(373, 163);
            this.AvailbleDeskGridView.Name = "AvailbleDeskGridView";
            this.AvailbleDeskGridView.ReadOnly = true;
            this.AvailbleDeskGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.AvailbleDeskGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AvailbleDeskGridView.Size = new System.Drawing.Size(540, 242);
            this.AvailbleDeskGridView.TabIndex = 5;
            this.AvailbleDeskGridView.Visible = false;
            this.AvailbleDeskGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AvailbleDeskGridView_CellContentClick);
            // 
            // askedStartDt
            // 
            this.askedStartDt.CustomFormat = "dd/MM/yyyy HH:00";
            this.askedStartDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.askedStartDt.Location = new System.Drawing.Point(104, 163);
            this.askedStartDt.MinDate = new System.DateTime(2023, 1, 5, 0, 0, 0, 0);
            this.askedStartDt.Name = "askedStartDt";
            this.askedStartDt.Size = new System.Drawing.Size(132, 20);
            this.askedStartDt.TabIndex = 6;
            this.askedStartDt.ValueChanged += new System.EventHandler(this.askedStartDt_ValueChanged);
            // 
            // askedEndDt
            // 
            this.askedEndDt.CustomFormat = "dd/MM/yyyy HH:00";
            this.askedEndDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.askedEndDt.Location = new System.Drawing.Point(104, 252);
            this.askedEndDt.Name = "askedEndDt";
            this.askedEndDt.Size = new System.Drawing.Size(132, 20);
            this.askedEndDt.TabIndex = 7;
            this.askedEndDt.ValueChanged += new System.EventHandler(this.askedEndDt_ValueChanged);
            // 
            // BookBtn
            // 
            this.BookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BookBtn.Location = new System.Drawing.Point(552, 425);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(161, 43);
            this.BookBtn.TabIndex = 8;
            this.BookBtn.Text = "Book Table";
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Visible = false;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "< My booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taskLabelTableAdapter1
            // 
            this.taskLabelTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(132, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(132, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "End";
            // 
            // DeskBookingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(986, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.askedEndDt);
            this.Controls.Add(this.askedStartDt);
            this.Controls.Add(this.AvailbleDeskGridView);
            this.Controls.Add(this.FindDeskBtn);
            this.Controls.Add(this.DeskBookingHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeskBookingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskBookingScreen";
            this.Load += new System.EventHandler(this.DeskBookingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvailbleDeskGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeskBookingHeader;
        private System.Windows.Forms.Button FindDeskBtn;
        private System.Windows.Forms.DataGridView AvailbleDeskGridView;
        private System.Windows.Forms.DateTimePicker askedStartDt;
        private System.Windows.Forms.DateTimePicker askedEndDt;
        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.Button button1;
        private SAD_11DataSetTableAdapters.TaskLabelTableAdapter taskLabelTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}