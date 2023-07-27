using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11_Project
{
    public partial class MainMenu_Accounts : Form
    {
        public MainMenu_Accounts()
        {
            InitializeComponent();
            Name_Label.Text = "Hello " + Program.loggedInWorker.get_name();  // Present user name up top
            Accounts_Btn.BackColor = Color.DeepSkyBlue; // Menu button clicked on when you open this window
            if (Program.loggedInWorker.get_title().ToString() == "CommunityManager")  // Only community manager will be able to reach "Accounts"
            {
                Accounts_Btn.Visible = true;
            }
        }

        private void SignOut_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  // Sign out
        {
            Identification i = new Identification();
            i.Show();
            this.Hide();
        }

        private void Workers_Btn_Click(object sender, EventArgs e)  // Go to worker acccounts managet
        {
            WorkersAccountManagement wam = new WorkersAccountManagement();
            wam.Show();
        }

        private void Entities_Btn_Click(object sender, EventArgs e)  // Go to entity acccounts managet
        {
            ExternalEntityAccountManagement eeam = new ExternalEntityAccountManagement();
            eeam.Show();
        }

        private void MainMenu_Btn_Click(object sender, EventArgs e)  // Go back
        {
            MainMenu_Main mmm = new MainMenu_Main();
            mmm.Show();
            this.Hide();
        }
    }
}
