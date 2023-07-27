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
    public partial class AddNewWorker : Form
    {
        public AddNewWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Checks before creating a worker
            if(Regex.IsMatch(ID_Box.Text, @"^\d+$") == false | ID_Box.Text.Length > 10 | ID_Box.Text == "") // Check ID
            {
                MessageBox.Show("ID is not valid, please try again");
            }

            else if (Program.seekWorkerID(ID_Box.Text) == true)   // Check if ID exists in the system
            {
                MessageBox.Show("ID already exists in the system");
            }

            if (FirstName_Box.Text == "" | Regex.IsMatch(FirstName_Box.Text, @"^[a-zA-Z]+$") == false | FirstName_Box.Text.Length > 10)  // Check first name
            {
                MessageBox.Show("First name is not valid, please try again");
            }

            else if (LastName_Box.Text == "" | Regex.IsMatch(LastName_Box.Text, @"^[a-zA-Z]+$") == false | LastName_Box.Text.Length > 10)  // Check last name
            {
                MessageBox.Show("Last name is not valid, please try again");
            }

            else if (Program.isValidEmail(Email_Box.Text) == false | Email_Box.Text == "" | Email_Box.Text.Length > 20)  // Check email
            {
                MessageBox.Show("Email address is not valid, please try again");
            }

            else if (Regex.IsMatch(Phone_Box.Text, @"^\d+$") == false | Phone_Box.Text.Length > 9)  // Check phone number
            {
                MessageBox.Show("Phone number is not valid, please try again");
            }

            else if (Password_Box.Text == "" | Password_Box.Text.Length > 30 | Password_Box.Text.Contains(" "))  // Check password
            {
                MessageBox.Show("Password is not valid, please try again");
            }

            else
            {
                if (MessageBox.Show("Do you want to add worker to the system?", "Add worker", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Add Worker
                    Worker w = new Worker(ID_Box.Text, FirstName_Box.Text, LastName_Box.Text, Email_Box.Text, Phone_Combo.Text + Phone_Box.Text, DateTime.Parse(DT_Picker.Text), (JobTitle)Enum.Parse(typeof(JobTitle), Title_Combo.Text), (WorkerStatus)Enum.Parse(typeof(WorkerStatus), Status_Combo.Text), Password_Box.Text, true);
                    WorkersAccountManagement wam = new WorkersAccountManagement();
                    wam.Show();
                    this.Close();
                }   
            }      
        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddNewWorker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.WorkerStatus' table. You can move, or remove it, as needed.
            this.workerStatusTableAdapter.Fill(this.sAD_11DataSet.WorkerStatus);
            // TODO: This line of code loads data into the 'sAD_11DataSet.JobTitles' table. You can move, or remove it, as needed.
            this.jobTitlesTableAdapter.Fill(this.sAD_11DataSet.JobTitles);
            Phone_Combo.SelectedIndex = 0;

        }

        private void ID_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            WorkersAccountManagement wam = new WorkersAccountManagement();
            wam.Show();
            this.Hide();
        }
    }
}
