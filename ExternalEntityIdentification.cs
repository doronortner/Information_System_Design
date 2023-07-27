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
    public partial class ExternalEntityIdentification : Form
    {
        public ExternalEntityIdentification()
        {
            InitializeComponent();
        }

        private void Connect_button_Click(object sender, EventArgs e)  // Connects entity to the system
        {
            if (Program.checkEntityPassword(Phone_Combo.Text + Phone_Box.Text, Password_Box.Text) == false)  // Check if the phone number matches the password
            {
                MessageBox.Show("Wrong phone number or password, please try again");
            }
            else
            {
                Program.loggedInEntity = Program.seekExternalEntity(Phone_Combo.Text + Phone_Box.Text);    // Updates a field in Program that indicates who is logged in into the system at the moment
                ViewDeskBookings vdb = new ViewDeskBookings();
                vdb.Show();
                this.Hide();
            } 
        }

        private void Cancel_button_Click(object sender, EventArgs e)  // Go back
        {
            Sign_Login_Message slm = new Sign_Login_Message();
            slm.Show();
            this.Hide();
        }
    }
}
