using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Group11_Project
{
    public partial class ProgramMenu_Participants : Form
    {
        private Tech7program currentProgram;
        private ExternalEntity participant;   // Check <-------------------------------------
        private int index;

        public ProgramMenu_Participants()
        {
            InitializeComponent();
            //if (Program.loggedInWorker.get_title().ToString() != "ProgramManager")
            //    Status_Combo.Visible = false;
            removeButton.Hide();
            Name_Label.Text = "Hello " + Program.loggedInWorker.get_name();
            Participants_Btn.BackColor = Color.DeepSkyBlue; // Menu button clicked on when you open this window
            this.currentProgram = Program.seekProgramByName(Program.clickedOnProgram);
            ProgramName_Label.Text = this.currentProgram.get_name();

            if (Program.loggedInWorker.get_title().ToString() != "ProgramManager")
            {
                Expenses_Btn.Visible = false;
                Add_Btn.Visible = false;
            }

            DataTable participants = new DataTable();   // Populate tasks table
            participants.Columns.Add("Phone", typeof(string));
            participants.Columns.Add("First Name", typeof(string));
            participants.Columns.Add("Last Name", typeof(string));
            participants.Columns.Add("Email", typeof(string));
            participants.Columns.Add("Gender", typeof(string));
            participants.Columns.Add("Age", typeof(string));

            if (this.currentProgram.Participants != null)
            {
                foreach (ExternalEntity ee in this.currentProgram.Participants)
                {
                    string[] names = ee.get_name().Split(' ');
                    participants.Rows.Add(ee.get_phoneNumber(), names[0], names[1], ee.get_email(), ee.get_gender(), ee.get_age());
                }
                Participants_Table.DataSource = participants;
            }
        }

        private void SignOut_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Identification i = new Identification();
            i.Show();
            this.Hide();
        }

        private void MainMenu_Btn_Click(object sender, EventArgs e)
        {
            MainMenu_Main mmm = new MainMenu_Main();
            mmm.Show();
            this.Hide();
        }

        private void Overview_Btn_Click(object sender, EventArgs e)
        {
            ProgramMenu_Overview pmo = new ProgramMenu_Overview();
            pmo.Show();
            this.Hide();
        }

        private void Expenses_Btn_Click(object sender, EventArgs e)
        {
            ProgramMenu_Expenses pme = new ProgramMenu_Expenses();
            pme.Show();
            this.Hide();
        }

        private void ProgramMenu_Participants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.Genders' table. You can move, or remove it, as needed.
            this.gendersTableAdapter.Fill(this.sAD_11DataSet.Genders);
            // TODO: This line of code loads data into the 'sAD_11DataSet.ExternalEntities' table. You can move, or remove it, as needed.
            this.externalEntitiesTableAdapter.Fill(this.sAD_11DataSet.ExternalEntities);
            // TODO: This line of code loads data into the 'sAD_11DataSet.ProgramParticipants' table. You can move, or remove it, as needed.
            this.programParticipantsTableAdapter.Fill(this.sAD_11DataSet.ProgramParticipants);

        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if (Program.seekExternalEntityPhoneNumber(phoneComboBox.Text + PhoneBox.Text))
            {
                ExternalEntity T = Program.seekExternalEntity(phoneComboBox.Text + PhoneBox.Text);
                if (MessageBox.Show("This phone number is already exists in the system, do you want to add "+T.get_name()+ " the participant to the program? ", "update task", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    currentProgram.AddParticipant(T);
                    T.AddPrograms(currentProgram);
                    currentProgram.create_programToParticipantConnection(T.get_phoneNumber());
                }
            }
            else
            {
                if (Regex.IsMatch(PhoneBox.Text, @"^\d+$") == false | PhoneBox.Text.Length > 9)  // Check phone number
                {
                    MessageBox.Show("Phone number is not valid, please try again");
                }

                else if (first_name_box.Text == "" | Regex.IsMatch(first_name_box.Text, @"^[a-zA-Z]+$") == false | first_name_box.Text.Length > 10)  // Check first name
                {
                    MessageBox.Show("First name is not valid, please try again");
                }

                else if (last_name_box.Text == "" | Regex.IsMatch(last_name_box.Text, @"^[a-zA-Z]+$") == false | last_name_box.Text.Length > 10)  // Check last name
                {
                    MessageBox.Show("Last name is not valid, please try again");
                }

                else if (Program.isValidEmail(email_box.Text) == false | email_box.Text == "" | email_box.Text.Length > 20)  // Check email
                {
                    MessageBox.Show("Email address is not valid, please try again");
                }
                else if (ageBox.Text == "" | int.Parse(ageBox.Text) < 0 | int.Parse(ageBox.Text) > 120)  // Check password
                {
                    MessageBox.Show("Password is not valid, please try again");
                }
                else
                {
                    ExternalEntity T = new ExternalEntity(phoneComboBox.Text+PhoneBox.Text, first_name_box.Text, last_name_box.Text, email_box.Text, DateTime.Now, (ExternalEntityType)Enum.Parse(typeof(ExternalEntityType), "Member"), "00000", (Gender)Enum.Parse(typeof(Gender), GenderComboBox.Text), int.Parse(ageBox.Text), true);
                    currentProgram.AddParticipant(T);
                    T.AddPrograms(currentProgram);
                    currentProgram.create_programToParticipantConnection(T.get_phoneNumber());
                }
            }
            ProgramMenu_Participants pmp = new ProgramMenu_Participants();
            pmp.Show();
            this.Hide();
        }

        private void Participants_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            participant.RemovePrograms(currentProgram);
            currentProgram.RemoveParticipant(participant);
            ProgramMenu_Participants pmp = new ProgramMenu_Participants();
            pmp.Show();
            this.Hide();
        }

        private void Participants_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            removeButton.Show();
            index = e.RowIndex;
            DataGridViewRow row = Participants_Table.Rows[index];
            participant = Program.seekExternalEntity(row.Cells[2].Value.ToString());
        }


    }
}
