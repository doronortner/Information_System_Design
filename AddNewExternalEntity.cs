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
    public partial class AddNewExternalEntity : Form
    {
        public AddNewExternalEntity()
        {
            InitializeComponent();
        }

        private void JoinDate_Click(object sender, EventArgs e)
        {

        }

        private void AddNewExteranlEntity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.Genders' table. You can move, or remove it, as needed.
            this.gendersTableAdapter.Fill(this.sAD_11DataSet.Genders);
            // TODO: This line of code loads data into the 'sAD_11DataSet.ExternalEntityType' table. You can move, or remove it, as needed.
            this.externalEntityTypeTableAdapter.Fill(this.sAD_11DataSet.ExternalEntityType);
            Phone_Combo.SelectedIndex = 0;
        }

        private void Confirm_Btn_Click(object sender, EventArgs e)
        {
            // Checks before creating an external entity

            if (Program.seekExternalEntityPhoneNumber(Phone_Box.Text) == true)   // Check if phone number exists in the system
            {
                MessageBox.Show("Phone number already exists in the system");
            }

            else if (Regex.IsMatch(Phone_Box.Text, @"^\d+$") == false | Phone_Box.Text.Length > 9)  // Check phone number
            {
                MessageBox.Show("Phone number is not valid, please try again");
            }

            else if (FirstName_Box.Text == "" | Regex.IsMatch(FirstName_Box.Text, @"^[a-zA-Z]+$") == false | FirstName_Box.Text.Length > 10)  // Check first name
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

            else if (Password_Box.Text == "" | Password_Box.Text.Length > 30 | Password_Box.Text.Contains(" "))  // Check password
            {
                MessageBox.Show("Password is not valid, please try again");
            }
            else if (ageBox.Text == "" | int.Parse(ageBox.Text) < 0 | int.Parse(ageBox.Text) > 120)  // Check password
            {
                MessageBox.Show("Password is not valid, please try again");
            }


            else
            {
                if (MessageBox.Show("Do you confirm all the details?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(Program.loggedInWorker != null)   // A worker is logged in (Community Manager)
                    {
                        ExternalEntity EE = new ExternalEntity(Phone_Combo.Text + Phone_Box.Text, FirstName_Box.Text, LastName_Box.Text, Email_Box.Text, DateTime.Parse(DT_Picker.Text), (ExternalEntityType)Enum.Parse(typeof(ExternalEntityType), Type_Combo.Text), Password_Box.Text, (Gender)Enum.Parse(typeof(Gender), GendercomboBox.Text), int.Parse(ageBox.Text), true);
                        ExternalEntityAccountManagement EEam = new ExternalEntityAccountManagement();
                        EEam.Show();
                        this.Hide();
                    }
                    else  // A guest signed up to the system
                    {
                        ExternalEntity EE = new ExternalEntity(Phone_Combo.Text + Phone_Box.Text, FirstName_Box.Text, LastName_Box.Text, Email_Box.Text, DateTime.Parse(DT_Picker.Text), (ExternalEntityType)Enum.Parse(typeof(ExternalEntityType), Type_Combo.Text), Password_Box.Text, (Gender)Enum.Parse(typeof(Gender), GendercomboBox.Text), int.Parse(ageBox.Text), true);
                        Program.loggedInEntity = Program.seekExternalEntity(Phone_Combo.Text + Phone_Box.Text);
                        DeskBookingScreen dbs = new DeskBookingScreen();
                        dbs.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            if (Program.loggedInWorker != null)   // A worker is logged in (Community Manager)
            {
                ExternalEntityAccountManagement EEam = new ExternalEntityAccountManagement();
                EEam.Show();
                this.Hide();
            }

            else  // A guest quited registartion
            {
                Identification i = new Identification();
                i.Show();
                this.Hide();
            }
        }

        private void Type_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
