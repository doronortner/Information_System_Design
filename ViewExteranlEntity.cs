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
    public partial class ViewExteranlEntity : Form
    {

        private ExternalEntity exist_ExternalEntity;
        private int index;

        public ViewExteranlEntity()
        {
            InitializeComponent();
            Update_Btn.Hide();
        }

    private void ViewExteranlEntity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.AllowedOccupation' table. You can move, or remove it, as needed.
            this.allowedOccupationTableAdapter.Fill(this.sAD_11DataSet.AllowedOccupation);
            // TODO: This line of code loads data into the 'sAD_11DataSet1.Genders' table. You can move, or remove it, as needed.
            this.gendersTableAdapter.Fill(this.sAD_11DataSet1.Genders);
            // TODO: This line of code loads data into the 'sAD_11DataSet.ExternalEntityType' table. You can move, or remove it, as needed.
            this.externalEntityTypeTableAdapter.Fill(this.sAD_11DataSet.ExternalEntityType);
            // TODO: This line of code loads data into the 'sAD_11DataSet.ExternalEntitys' table. You can move, or remove it, as needed.
            this.externalEntitiesTableAdapter.Fill(this.sAD_11DataSet.ExternalEntities);
        }

        private void externalEntitiesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OccupationCheckedListBox.Items.Clear();
            Update_Btn.Show();
            // When clicked on an External Entity, it will preview his data in the text boxes
            index = e.RowIndex;
            DataGridViewRow row = externalEntitiesTable.Rows[index];
            exist_ExternalEntity = Program.seekExternalEntity(row.Cells[0].Value.ToString());  // Pointer on the External Entity that we clicked on (so we could update his data later)
            Phone_Box.Text = row.Cells[0].Value.ToString();  
            First_Box.Text = row.Cells[1].Value.ToString();
            Last_Box.Text = row.Cells[2].Value.ToString();
            Email_Box.Text = row.Cells[3].Value.ToString();
            Type_Combo.Text = row.Cells[5].Value.ToString();
            GenderComboBox.Text = row.Cells[7].Value.ToString();
            AgeTextBox.Text = row.Cells[8].Value.ToString();

            Array Occupations = Enum.GetValues(typeof(AllowedOccupation));
            foreach (AllowedOccupation occupation in Occupations)
            {
                    if(exist_ExternalEntity.Occupations.Contains(occupation))
                        OccupationCheckedListBox.Items.Add(occupation.ToString(), CheckState.Checked);
                    else
                        OccupationCheckedListBox.Items.Add(occupation.ToString());
            }

        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            ExternalEntityAccountManagement eeam = new ExternalEntityAccountManagement();
            eeam.Show();
            this.Hide();
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            // Checks before updating external entity's data

            if (Program.seekExternalEntityPhoneNumber(Phone_Box.Text) == true && exist_ExternalEntity.get_phoneNumber() != Phone_Box.Text)   // Check if phone number exists in the system
            {
                MessageBox.Show("Phone number already exists in the system");
            }

            else if (Regex.IsMatch(Phone_Box.Text.Substring(1), @"^\d+$") == false | Phone_Box.Text.Length > 13)  // Check phone number
            {
                MessageBox.Show("Phone number is not valid, please try again");
            }

            else if (Phone_Box.Text.Substring(0, 1) != "+")
            {
                MessageBox.Show("Phone number is not valid, don't forget + in the beginning");  // Check phone number starts with '+'
            }

            else if (First_Box.Text == "" | Regex.IsMatch(First_Box.Text, @"^[a-zA-Z]+$") == false | First_Box.Text.Length > 10)  // Check first name
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
            else if (AgeTextBox.Text == "" | int.Parse(AgeTextBox.Text) < 0 | int.Parse(AgeTextBox.Text) > 120)  // Check password
            {
                MessageBox.Show("Password is not valid, please try again");
            }
            
            else
            {
                if (MessageBox.Show("Do you want to apply the update?", "Update Entity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Updates enetity's data in DB
                    exist_ExternalEntity.set_name(First_Box.Text, Last_Box.Text);
                    exist_ExternalEntity.set_email(Email_Box.Text);
                    exist_ExternalEntity.set_phoneNumber(Phone_Box.Text);
                    exist_ExternalEntity.set_type((ExternalEntityType)Enum.Parse(typeof(ExternalEntityType), Type_Combo.Text));
                    exist_ExternalEntity.set_gender((Gender)Enum.Parse(typeof(Gender), GenderComboBox.Text));
                    exist_ExternalEntity.set_age(int.Parse(AgeTextBox.Text));
                    foreach(string s in OccupationCheckedListBox.Items)
                    {
                        if (OccupationCheckedListBox.CheckedItems.Contains(s))
                        {
                                if (exist_ExternalEntity.Occupations.Contains((AllowedOccupation)Enum.Parse(typeof(AllowedOccupation), s)) == false)
                                {
                                    exist_ExternalEntity.create_ExternalEntityOccupation((AllowedOccupation)Enum.Parse(typeof(AllowedOccupation), s));
                                }
                        }
                        else
                            exist_ExternalEntity.RemoveOccupation((AllowedOccupation)Enum.Parse(typeof(AllowedOccupation), s));

                    }
                    exist_ExternalEntity.update_ExternalEntity();
                
                    // Updates the preview in the table
                    DataGridViewRow newdata = externalEntitiesTable.Rows[index];
                    newdata.Cells[0].Value = Phone_Box.Text;
                    newdata.Cells[1].Value = First_Box.Text;
                    newdata.Cells[2].Value = Last_Box.Text;
                    newdata.Cells[3].Value = Email_Box.Text; 
                    newdata.Cells[5].Value = Type_Combo.Text;
                    newdata.Cells[7].Value = GenderComboBox.Text;
                    newdata.Cells[8].Value = AgeTextBox.Text;

                }

            }


        
        }


    }
}
