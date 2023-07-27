namespace Group11_Project
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbOccupation = new System.Windows.Forms.ComboBox();
            this.allowedOccupationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11_Project.SAD_11DataSet();
            this.chartOccupationSortedByTopic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lnlOccupationSortedByTopic = new System.Windows.Forms.Label();
            this.meetupTopicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumTotalMember = new System.Windows.Forms.Label();
            this.lblTotalnumberofmembers = new System.Windows.Forms.Label();
            this.lblNumMale = new System.Windows.Forms.Label();
            this.lblNumberofmalemembers = new System.Windows.Forms.Label();
            this.lblNumFemale = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.lblNumberoffemalemembers = new System.Windows.Forms.Label();
            this.chartTop3Topics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTheBestLecturer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AvrAge = new System.Windows.Forms.Panel();
            this.lblAvrAgeOfMembers = new System.Windows.Forms.Label();
            this.AvregeAge = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumMeetups = new System.Windows.Forms.Label();
            this.numberOfMeetups = new System.Windows.Forms.Label();
            this.btnOkCostumData = new System.Windows.Forms.Button();
            this.btnCostum = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.DashBoardLabel = new System.Windows.Forms.Label();
            this.meetupTopicTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.MeetupTopicTableAdapter();
            this.allowedOccupationTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.AllowedOccupationTableAdapter();
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allowedOccupationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOccupationSortedByTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetupTopicBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop3Topics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTheBestLecturer)).BeginInit();
            this.AvrAge.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.cmbOccupation);
            this.panel4.Controls.Add(this.chartOccupationSortedByTopic);
            this.panel4.Controls.Add(this.lnlOccupationSortedByTopic);
            this.panel4.Location = new System.Drawing.Point(159, 402);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 227);
            this.panel4.TabIndex = 31;
            // 
            // cmbOccupation
            // 
            this.cmbOccupation.DataSource = this.allowedOccupationBindingSource;
            this.cmbOccupation.DisplayMember = "AllowedOccupation";
            this.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOccupation.FormattingEnabled = true;
            this.cmbOccupation.Location = new System.Drawing.Point(256, 8);
            this.cmbOccupation.Name = "cmbOccupation";
            this.cmbOccupation.Size = new System.Drawing.Size(121, 21);
            this.cmbOccupation.TabIndex = 13;
            this.cmbOccupation.ValueMember = "AllowedOccupation";
            this.cmbOccupation.SelectedIndexChanged += new System.EventHandler(this.cmbOccupation_SelectedIndexChanged);
            // 
            // allowedOccupationBindingSource
            // 
            this.allowedOccupationBindingSource.DataMember = "AllowedOccupation";
            this.allowedOccupationBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartOccupationSortedByTopic
            // 
            chartArea4.Name = "ChartArea1";
            this.chartOccupationSortedByTopic.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartOccupationSortedByTopic.Legends.Add(legend4);
            this.chartOccupationSortedByTopic.Location = new System.Drawing.Point(4, 29);
            this.chartOccupationSortedByTopic.Name = "chartOccupationSortedByTopic";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartOccupationSortedByTopic.Series.Add(series4);
            this.chartOccupationSortedByTopic.Size = new System.Drawing.Size(387, 190);
            this.chartOccupationSortedByTopic.TabIndex = 12;
            this.chartOccupationSortedByTopic.Text = "Occupation Sorted By Topic";
            title4.Name = "Title1";
            this.chartOccupationSortedByTopic.Titles.Add(title4);
            // 
            // lnlOccupationSortedByTopic
            // 
            this.lnlOccupationSortedByTopic.AutoSize = true;
            this.lnlOccupationSortedByTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lnlOccupationSortedByTopic.Location = new System.Drawing.Point(5, 6);
            this.lnlOccupationSortedByTopic.Name = "lnlOccupationSortedByTopic";
            this.lnlOccupationSortedByTopic.Size = new System.Drawing.Size(232, 20);
            this.lnlOccupationSortedByTopic.TabIndex = 11;
            this.lnlOccupationSortedByTopic.Text = "Occupation Sorted By Topic";
            // 
            // meetupTopicBindingSource
            // 
            this.meetupTopicBindingSource.DataMember = "MeetupTopic";
            this.meetupTopicBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblNumTotalMember);
            this.panel3.Controls.Add(this.lblTotalnumberofmembers);
            this.panel3.Controls.Add(this.lblNumMale);
            this.panel3.Controls.Add(this.lblNumberofmalemembers);
            this.panel3.Controls.Add(this.lblNumFemale);
            this.panel3.Controls.Add(this.lblTotalMembers);
            this.panel3.Controls.Add(this.lblNumberoffemalemembers);
            this.panel3.Location = new System.Drawing.Point(6, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 227);
            this.panel3.TabIndex = 30;
            // 
            // lblNumTotalMember
            // 
            this.lblNumTotalMember.AutoSize = true;
            this.lblNumTotalMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumTotalMember.Location = new System.Drawing.Point(43, 185);
            this.lblNumTotalMember.Name = "lblNumTotalMember";
            this.lblNumTotalMember.Size = new System.Drawing.Size(64, 25);
            this.lblNumTotalMember.TabIndex = 16;
            this.lblNumTotalMember.Text = "1000";
            // 
            // lblTotalnumberofmembers
            // 
            this.lblTotalnumberofmembers.AutoSize = true;
            this.lblTotalnumberofmembers.Location = new System.Drawing.Point(6, 172);
            this.lblTotalnumberofmembers.Name = "lblTotalnumberofmembers";
            this.lblTotalnumberofmembers.Size = new System.Drawing.Size(126, 13);
            this.lblTotalnumberofmembers.TabIndex = 15;
            this.lblTotalnumberofmembers.Text = "Total number of members";
            // 
            // lblNumMale
            // 
            this.lblNumMale.AutoSize = true;
            this.lblNumMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumMale.Location = new System.Drawing.Point(43, 110);
            this.lblNumMale.Name = "lblNumMale";
            this.lblNumMale.Size = new System.Drawing.Size(64, 25);
            this.lblNumMale.TabIndex = 14;
            this.lblNumMale.Text = "1000";
            // 
            // lblNumberofmalemembers
            // 
            this.lblNumberofmalemembers.AutoSize = true;
            this.lblNumberofmalemembers.Location = new System.Drawing.Point(6, 97);
            this.lblNumberofmalemembers.Name = "lblNumberofmalemembers";
            this.lblNumberofmalemembers.Size = new System.Drawing.Size(126, 13);
            this.lblNumberofmalemembers.TabIndex = 13;
            this.lblNumberofmalemembers.Text = "Number of male members";
            // 
            // lblNumFemale
            // 
            this.lblNumFemale.AutoSize = true;
            this.lblNumFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumFemale.Location = new System.Drawing.Point(43, 39);
            this.lblNumFemale.Name = "lblNumFemale";
            this.lblNumFemale.Size = new System.Drawing.Size(64, 25);
            this.lblNumFemale.TabIndex = 12;
            this.lblNumFemale.Text = "1000";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTotalMembers.Location = new System.Drawing.Point(3, 6);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(127, 20);
            this.lblTotalMembers.TabIndex = 11;
            this.lblTotalMembers.Text = "Total Members";
            // 
            // lblNumberoffemalemembers
            // 
            this.lblNumberoffemalemembers.AutoSize = true;
            this.lblNumberoffemalemembers.Location = new System.Drawing.Point(1, 26);
            this.lblNumberoffemalemembers.Name = "lblNumberoffemalemembers";
            this.lblNumberoffemalemembers.Size = new System.Drawing.Size(135, 13);
            this.lblNumberoffemalemembers.TabIndex = 10;
            this.lblNumberoffemalemembers.Text = "Number of female members";
            // 
            // chartTop3Topics
            // 
            chartArea5.Name = "ChartArea1";
            this.chartTop3Topics.ChartAreas.Add(chartArea5);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.chartTop3Topics.Legends.Add(legend5);
            this.chartTop3Topics.Location = new System.Drawing.Point(613, 49);
            this.chartTop3Topics.Name = "chartTop3Topics";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            series5.IsValueShownAsLabel = true;
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartTop3Topics.Series.Add(series5);
            this.chartTop3Topics.Size = new System.Drawing.Size(307, 580);
            this.chartTop3Topics.TabIndex = 29;
            this.chartTop3Topics.Text = "chartTop3Topics";
            title5.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title5.Name = "Title1";
            title5.Text = "Top 3 Topics";
            this.chartTop3Topics.Titles.Add(title5);
            // 
            // chartTheBestLecturer
            // 
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.Title = "Lecturer Names";
            chartArea6.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisY.Title = "Number of Meetups";
            chartArea6.Name = "ChartArea1";
            this.chartTheBestLecturer.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Name = "Legend1";
            this.chartTheBestLecturer.Legends.Add(legend6);
            this.chartTheBestLecturer.Location = new System.Drawing.Point(6, 109);
            this.chartTheBestLecturer.Name = "chartTheBestLecturer";
            series6.ChartArea = "ChartArea1";
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartTheBestLecturer.Series.Add(series6);
            this.chartTheBestLecturer.Size = new System.Drawing.Size(601, 287);
            this.chartTheBestLecturer.TabIndex = 28;
            this.chartTheBestLecturer.Text = "The Best Lecturer";
            title6.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title6.Name = "Title1";
            title6.Text = "The best Lecturer";
            this.chartTheBestLecturer.Titles.Add(title6);
            // 
            // AvrAge
            // 
            this.AvrAge.BackColor = System.Drawing.Color.White;
            this.AvrAge.Controls.Add(this.lblAvrAgeOfMembers);
            this.AvrAge.Controls.Add(this.AvregeAge);
            this.AvrAge.Location = new System.Drawing.Point(307, 49);
            this.AvrAge.Name = "AvrAge";
            this.AvrAge.Size = new System.Drawing.Size(300, 55);
            this.AvrAge.TabIndex = 27;
            // 
            // lblAvrAgeOfMembers
            // 
            this.lblAvrAgeOfMembers.AutoSize = true;
            this.lblAvrAgeOfMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAvrAgeOfMembers.Location = new System.Drawing.Point(60, 17);
            this.lblAvrAgeOfMembers.Name = "lblAvrAgeOfMembers";
            this.lblAvrAgeOfMembers.Size = new System.Drawing.Size(64, 25);
            this.lblAvrAgeOfMembers.TabIndex = 11;
            this.lblAvrAgeOfMembers.Text = "1000";
            // 
            // AvregeAge
            // 
            this.AvregeAge.AutoSize = true;
            this.AvregeAge.Location = new System.Drawing.Point(6, 4);
            this.AvregeAge.Name = "AvregeAge";
            this.AvregeAge.Size = new System.Drawing.Size(125, 13);
            this.AvregeAge.TabIndex = 10;
            this.AvregeAge.Text = "Average age of members";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblNumMeetups);
            this.panel2.Controls.Add(this.numberOfMeetups);
            this.panel2.Location = new System.Drawing.Point(6, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 55);
            this.panel2.TabIndex = 26;
            // 
            // lblNumMeetups
            // 
            this.lblNumMeetups.AutoSize = true;
            this.lblNumMeetups.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumMeetups.Location = new System.Drawing.Point(60, 17);
            this.lblNumMeetups.Name = "lblNumMeetups";
            this.lblNumMeetups.Size = new System.Drawing.Size(64, 25);
            this.lblNumMeetups.TabIndex = 11;
            this.lblNumMeetups.Text = "1000";
            // 
            // numberOfMeetups
            // 
            this.numberOfMeetups.AutoSize = true;
            this.numberOfMeetups.Location = new System.Drawing.Point(6, 4);
            this.numberOfMeetups.Name = "numberOfMeetups";
            this.numberOfMeetups.Size = new System.Drawing.Size(99, 13);
            this.numberOfMeetups.TabIndex = 10;
            this.numberOfMeetups.Text = "Number of meetups";
            // 
            // btnOkCostumData
            // 
            this.btnOkCostumData.Location = new System.Drawing.Point(559, 12);
            this.btnOkCostumData.Name = "btnOkCostumData";
            this.btnOkCostumData.Size = new System.Drawing.Size(29, 30);
            this.btnOkCostumData.TabIndex = 25;
            this.btnOkCostumData.Text = "Ok";
            this.btnOkCostumData.UseVisualStyleBackColor = true;
            this.btnOkCostumData.Visible = false;
            this.btnOkCostumData.Click += new System.EventHandler(this.btnOkCostumData_Click);
            // 
            // btnCostum
            // 
            this.btnCostum.Location = new System.Drawing.Point(596, 13);
            this.btnCostum.Name = "btnCostum";
            this.btnCostum.Size = new System.Drawing.Size(104, 30);
            this.btnCostum.TabIndex = 24;
            this.btnCostum.Text = "Custom";
            this.btnCostum.UseVisualStyleBackColor = true;
            this.btnCostum.Click += new System.EventHandler(this.btnCostum_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Location = new System.Drawing.Point(706, 13);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(104, 30);
            this.btnLast7Days.TabIndex = 22;
            this.btnLast7Days.Text = "Last 7 days";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Location = new System.Drawing.Point(816, 13);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(104, 30);
            this.btnLast30Days.TabIndex = 21;
            this.btnLast30Days.Text = "Last 30 days";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MMM dd, yyyy";
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(433, 16);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(120, 20);
            this.dtpEnd.TabIndex = 20;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MMM dd, yyyy";
            this.dtpStart.Enabled = false;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(307, 16);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(120, 20);
            this.dtpStart.TabIndex = 19;
            // 
            // DashBoardLabel
            // 
            this.DashBoardLabel.AutoSize = true;
            this.DashBoardLabel.BackColor = System.Drawing.Color.White;
            this.DashBoardLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DashBoardLabel.Location = new System.Drawing.Point(0, 0);
            this.DashBoardLabel.Margin = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.DashBoardLabel.Name = "DashBoardLabel";
            this.DashBoardLabel.Size = new System.Drawing.Size(159, 31);
            this.DashBoardLabel.TabIndex = 18;
            this.DashBoardLabel.Text = "DashBoard";
            // 
            // meetupTopicTableAdapter
            // 
            this.meetupTopicTableAdapter.ClearBeforeFill = true;
            // 
            // allowedOccupationTableAdapter
            // 
            this.allowedOccupationTableAdapter.ClearBeforeFill = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(179, 13);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 32;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(931, 635);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chartTop3Topics);
            this.Controls.Add(this.chartTheBestLecturer);
            this.Controls.Add(this.AvrAge);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnOkCostumData);
            this.Controls.Add(this.btnCostum);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.DashBoardLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allowedOccupationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOccupationSortedByTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetupTopicBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop3Topics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTheBestLecturer)).EndInit();
            this.AvrAge.ResumeLayout(false);
            this.AvrAge.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbOccupation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOccupationSortedByTopic;
        private System.Windows.Forms.Label lnlOccupationSortedByTopic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumTotalMember;
        private System.Windows.Forms.Label lblTotalnumberofmembers;
        private System.Windows.Forms.Label lblNumMale;
        private System.Windows.Forms.Label lblNumberofmalemembers;
        private System.Windows.Forms.Label lblNumFemale;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label lblNumberoffemalemembers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop3Topics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTheBestLecturer;
        private System.Windows.Forms.Panel AvrAge;
        private System.Windows.Forms.Label lblAvrAgeOfMembers;
        private System.Windows.Forms.Label AvregeAge;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumMeetups;
        private System.Windows.Forms.Label numberOfMeetups;
        private System.Windows.Forms.Button btnOkCostumData;
        private System.Windows.Forms.Button btnCostum;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label DashBoardLabel;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource meetupTopicBindingSource;
        private SAD_11DataSetTableAdapters.MeetupTopicTableAdapter meetupTopicTableAdapter;
        private System.Windows.Forms.BindingSource allowedOccupationBindingSource;
        private SAD_11DataSetTableAdapters.AllowedOccupationTableAdapter allowedOccupationTableAdapter;
        private System.Windows.Forms.Button BackBtn;
    }
}