namespace Group11_Project
{
    partial class RestrictionsScreen
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
            this.ChooseDeskLbl = new System.Windows.Forms.Label();
            this.sAD_11DataSet = new Group11_Project.SAD_11DataSet();
            this.desksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desksTableAdapter = new Group11_Project.SAD_11DataSetTableAdapters.DesksTableAdapter();
            this.ShowDesksDataGrid = new System.Windows.Forms.DataGridView();
            this.ShowRestrictionsBtn = new System.Windows.Forms.Button();
            this.ExistingRestrictionsGridView = new System.Windows.Forms.DataGridView();
            this.TimeFrameLbl = new System.Windows.Forms.Label();
            this.RestrictiondEndDt = new System.Windows.Forms.DateTimePicker();
            this.RestrictionStartDt = new System.Windows.Forms.DateTimePicker();
            this.RestStrtLbl = new System.Windows.Forms.Label();
            this.RestEndLbl = new System.Windows.Forms.Label();
            this.SubNewRestBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDesksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistingRestrictionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseDeskLbl
            // 
            this.ChooseDeskLbl.AutoSize = true;
            this.ChooseDeskLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChooseDeskLbl.Location = new System.Drawing.Point(23, 58);
            this.ChooseDeskLbl.Name = "ChooseDeskLbl";
            this.ChooseDeskLbl.Size = new System.Drawing.Size(117, 20);
            this.ChooseDeskLbl.TabIndex = 0;
            this.ChooseDeskLbl.Text = "Choose Desks:";
            this.ChooseDeskLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // desksBindingSource
            // 
            this.desksBindingSource.DataMember = "Desks";
            this.desksBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // desksTableAdapter
            // 
            this.desksTableAdapter.ClearBeforeFill = true;
            // 
            // ShowDesksDataGrid
            // 
            this.ShowDesksDataGrid.AllowUserToAddRows = false;
            this.ShowDesksDataGrid.AllowUserToDeleteRows = false;
            this.ShowDesksDataGrid.AllowUserToResizeColumns = false;
            this.ShowDesksDataGrid.AllowUserToResizeRows = false;
            this.ShowDesksDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ShowDesksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDesksDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ShowDesksDataGrid.Location = new System.Drawing.Point(27, 96);
            this.ShowDesksDataGrid.Name = "ShowDesksDataGrid";
            this.ShowDesksDataGrid.ReadOnly = true;
            this.ShowDesksDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ShowDesksDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowDesksDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowDesksDataGrid.Size = new System.Drawing.Size(97, 197);
            this.ShowDesksDataGrid.TabIndex = 1;
            this.ShowDesksDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDesksDataGrid_CellContentClick);
            // 
            // ShowRestrictionsBtn
            // 
            this.ShowRestrictionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ShowRestrictionsBtn.Location = new System.Drawing.Point(215, 34);
            this.ShowRestrictionsBtn.Name = "ShowRestrictionsBtn";
            this.ShowRestrictionsBtn.Size = new System.Drawing.Size(250, 44);
            this.ShowRestrictionsBtn.TabIndex = 2;
            this.ShowRestrictionsBtn.Text = "Show existing Restrictions";
            this.ShowRestrictionsBtn.UseVisualStyleBackColor = true;
            this.ShowRestrictionsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExistingRestrictionsGridView
            // 
            this.ExistingRestrictionsGridView.AllowUserToAddRows = false;
            this.ExistingRestrictionsGridView.AllowUserToDeleteRows = false;
            this.ExistingRestrictionsGridView.AllowUserToResizeColumns = false;
            this.ExistingRestrictionsGridView.AllowUserToResizeRows = false;
            this.ExistingRestrictionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ExistingRestrictionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExistingRestrictionsGridView.Location = new System.Drawing.Point(166, 96);
            this.ExistingRestrictionsGridView.Name = "ExistingRestrictionsGridView";
            this.ExistingRestrictionsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ExistingRestrictionsGridView.Size = new System.Drawing.Size(393, 197);
            this.ExistingRestrictionsGridView.TabIndex = 3;
            this.ExistingRestrictionsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExistingRestrictionsGridView_CellContentClick);
            // 
            // TimeFrameLbl
            // 
            this.TimeFrameLbl.AutoSize = true;
            this.TimeFrameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TimeFrameLbl.Location = new System.Drawing.Point(34, 344);
            this.TimeFrameLbl.Name = "TimeFrameLbl";
            this.TimeFrameLbl.Size = new System.Drawing.Size(156, 20);
            this.TimeFrameLbl.TabIndex = 4;
            this.TimeFrameLbl.Text = "Choose Time Frame:";
            this.TimeFrameLbl.Click += new System.EventHandler(this.TimeFrameLbl_Click);
            // 
            // RestrictiondEndDt
            // 
            this.RestrictiondEndDt.CustomFormat = "dd/MM/yyyy HH:00";
            this.RestrictiondEndDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RestrictiondEndDt.Location = new System.Drawing.Point(256, 421);
            this.RestrictiondEndDt.Name = "RestrictiondEndDt";
            this.RestrictiondEndDt.Size = new System.Drawing.Size(132, 20);
            this.RestrictiondEndDt.TabIndex = 9;
            this.RestrictiondEndDt.ValueChanged += new System.EventHandler(this.RestrictiondEndDt_ValueChanged);
            // 
            // RestrictionStartDt
            // 
            this.RestrictionStartDt.CustomFormat = "dd/MM/yyyy HH:00";
            this.RestrictionStartDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RestrictionStartDt.Location = new System.Drawing.Point(42, 421);
            this.RestrictionStartDt.MinDate = new System.DateTime(2023, 1, 5, 0, 0, 0, 0);
            this.RestrictionStartDt.Name = "RestrictionStartDt";
            this.RestrictionStartDt.Size = new System.Drawing.Size(132, 20);
            this.RestrictionStartDt.TabIndex = 8;
            this.RestrictionStartDt.ValueChanged += new System.EventHandler(this.RestrictionStartDt_ValueChanged);
            // 
            // RestStrtLbl
            // 
            this.RestStrtLbl.AutoSize = true;
            this.RestStrtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RestStrtLbl.Location = new System.Drawing.Point(39, 392);
            this.RestStrtLbl.Name = "RestStrtLbl";
            this.RestStrtLbl.Size = new System.Drawing.Size(130, 17);
            this.RestStrtLbl.TabIndex = 10;
            this.RestStrtLbl.Text = "Restriction Start At:";
            // 
            // RestEndLbl
            // 
            this.RestEndLbl.AutoSize = true;
            this.RestEndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RestEndLbl.Location = new System.Drawing.Point(253, 392);
            this.RestEndLbl.Name = "RestEndLbl";
            this.RestEndLbl.Size = new System.Drawing.Size(125, 17);
            this.RestEndLbl.TabIndex = 11;
            this.RestEndLbl.Text = "Restriction End At:";
            // 
            // SubNewRestBtn
            // 
            this.SubNewRestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubNewRestBtn.Location = new System.Drawing.Point(436, 385);
            this.SubNewRestBtn.Name = "SubNewRestBtn";
            this.SubNewRestBtn.Size = new System.Drawing.Size(133, 67);
            this.SubNewRestBtn.TabIndex = 12;
            this.SubNewRestBtn.Text = "Submit new Restriction";
            this.SubNewRestBtn.UseVisualStyleBackColor = true;
            this.SubNewRestBtn.Click += new System.EventHandler(this.SubNewRestBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 13;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RestrictionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(593, 494);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SubNewRestBtn);
            this.Controls.Add(this.RestEndLbl);
            this.Controls.Add(this.RestStrtLbl);
            this.Controls.Add(this.RestrictiondEndDt);
            this.Controls.Add(this.RestrictionStartDt);
            this.Controls.Add(this.TimeFrameLbl);
            this.Controls.Add(this.ExistingRestrictionsGridView);
            this.Controls.Add(this.ShowRestrictionsBtn);
            this.Controls.Add(this.ShowDesksDataGrid);
            this.Controls.Add(this.ChooseDeskLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestrictionsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestrictionsScreen";
            this.Load += new System.EventHandler(this.RestrictionsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDesksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistingRestrictionsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseDeskLbl;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource desksBindingSource;
        private SAD_11DataSetTableAdapters.DesksTableAdapter desksTableAdapter;
        private System.Windows.Forms.DataGridView ShowDesksDataGrid;
        private System.Windows.Forms.Button ShowRestrictionsBtn;
        private System.Windows.Forms.DataGridView ExistingRestrictionsGridView;
        private System.Windows.Forms.Label TimeFrameLbl;
        private System.Windows.Forms.DateTimePicker RestrictiondEndDt;
        private System.Windows.Forms.DateTimePicker RestrictionStartDt;
        private System.Windows.Forms.Label RestStrtLbl;
        private System.Windows.Forms.Label RestEndLbl;
        private System.Windows.Forms.Button SubNewRestBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}