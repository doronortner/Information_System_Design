using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11_Project
{
    public partial class ViewWorkers : Form
    {
        private Worker exist_Worker;
        private int index;

        public ViewWorkers()
        {
            InitializeComponent();
            Update_Btn.Hide();
        }

        private void ViewWorkers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.WorkerStatus' table. You can move, or remove it, as needed.
            this.workerStatusTableAdapter.Fill(this.sAD_11DataSet.WorkerStatus);
            // TODO: This line of code loads data into the 'sAD_11DataSet.JobTitles' table. You can move, or remove it, as needed.
            this.jobTitlesTableAdapter.Fill(this.sAD_11DataSet.JobTitles);
            // TODO: This line of code loads data into the 'sAD_11DataSet.get_all_workers' table. You can move, or remove it, as needed.
            this.get_all_workersTableAdapter.Fill(this.sAD_11DataSet.get_all_workers);
            // TODO: This line of code loads data into the 'sAD_11DataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.sAD_11DataSet.Workers);

        }

        private void Cance_Btn_Click(object sender, EventArgs e)
        {
            WorkersAccountManagement wam = new WorkersAccountManagement();
            wam.Show();
            this.Hide();
        }

        private void WorkersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Update_Btn.Show();
            // When clicked on a worker, it will preview his data in the text boxes
            index = e.RowIndex;
            DataGridViewRow row = WorkersTable.Rows[index];
            exist_Worker = Program.seekWorker(row.Cells[0].Value.ToString());  // Pointer on the worker that we clicked on (so we could update his data later)
            First_Box.Text = row.Cells[1].Value.ToString();
            Last_Box.Text = row.Cells[2].Value.ToString();
            Email_Box.Text = row.Cells[3].Value.ToString();
            Phone_Box.Text = row.Cells[4].Value.ToString();
            Title_Combo.Text = row.Cells[6].Value.ToString();
            Status_Combo.Text = row.Cells[7].Value.ToString();
        }

        private void Update_Btn_Click(object sender, EventArgs e) 
        {
            // Checks before updating worker's data
            if (First_Box.Text == "" | Regex.IsMatch(First_Box.Text, @"^[a-zA-Z]+$") == false | First_Box.Text.Length > 10)  // Check first name
            {
                MessageBox.Show("First name is not valid, please try again");
            }

            else if (Last_Box.Text == "" | Regex.IsMatch(Last_Box.Text, @"^[a-zA-Z]+$") == false | Last_Box.Text.Length > 10)  // Check last name
            {
                MessageBox.Show("Last name is not valid, please try again");
            }

            else if (Program.isValidEmail(Email_Box.Text) == false | Email_Box.Text == "" | Email_Box.Text.Length > 20)  // Check email
            {
                MessageBox.Show("Email address is not valid, please try again");
            }

            else if (Regex.IsMatch(Phone_Box.Text.Substring(1), @"^\d+$") == false | Phone_Box.Text.Length > 13)  // Check phone number
            {
                MessageBox.Show("Phone number is not valid, please try again");  
            }

            else if (Phone_Box.Text.Substring(0,1) != "+")  // Check phone number starts with '+'
            {
                MessageBox.Show("Phone number is not valid, don't forget + in the beginning");  
            }

            else
            {
                if (MessageBox.Show("Do you want to apply the update?", "Update worker", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    // Updates worker data in DB
                    exist_Worker.set_name(First_Box.Text, Last_Box.Text);
                    exist_Worker.set_email(Email_Box.Text);
                    exist_Worker.set_phoneNumber(Phone_Box.Text);
                    exist_Worker.set_title((JobTitle)Enum.Parse(typeof(JobTitle), Title_Combo.Text));
                    exist_Worker.set_status((WorkerStatus)Enum.Parse(typeof(WorkerStatus), Status_Combo.Text));
                    exist_Worker.update_worker();

                    // Updates the preview in the table
                    DataGridViewRow newdata = WorkersTable.Rows[index];
                    newdata.Cells[1].Value = First_Box.Text;
                    newdata.Cells[2].Value = Last_Box.Text;
                    newdata.Cells[3].Value = Email_Box.Text;
                    newdata.Cells[4].Value = Phone_Box.Text;
                    newdata.Cells[6].Value = Title_Combo.Text;
                    newdata.Cells[7].Value = Status_Combo.Text;
                }   
            } 
        }
    }
}
