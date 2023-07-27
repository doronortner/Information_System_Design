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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Name_Label.Text = "Hello " + Program.loggedInWorker.get_name();
            MainMenu_Btn.BackColor = Color.DeepSkyBlue; // Menu button clicked on when you open this window
            if (Program.loggedInWorker.get_title().ToString() == "CommunityManager")
            {
                Accounts_Btn.Visible = true;
            }
        }

        private void Tasks_Btn_Click(object sender, EventArgs e)
        {
            tasks_Control1.Visible = true;
            mainMenu_Control1.Visible = false;
            accounts_Control1.Visible = false;

            if (Tasks_Btn.Focused == true)
            {
                Tasks_Btn.BackColor = Color.DeepSkyBlue;
                MainMenu_Btn.BackColor = Side_Panel.BackColor;
                Accounts_Btn.BackColor = Side_Panel.BackColor;
            }
        }

        private void MainMenu_Btn_Click(object sender, EventArgs e)
        {
            mainMenu_Control1.Visible = true;
            tasks_Control1.Visible = false;
            accounts_Control1.Visible = false;

            if (MainMenu_Btn.Focused == true)
            {
                MainMenu_Btn.BackColor = Color.DeepSkyBlue;
                Tasks_Btn.BackColor = Side_Panel.BackColor;
                Accounts_Btn.BackColor = Side_Panel.BackColor;
            }

        }

        private void Accounts_Btn_Click(object sender, EventArgs e)
        {
            accounts_Control1.Visible = true;
            mainMenu_Control1.Visible = false;
            tasks_Control1.Visible = false;

            if (Accounts_Btn.Focused == true)
            {
                Accounts_Btn.BackColor = Color.DeepSkyBlue;
                Tasks_Btn.BackColor = Side_Panel.BackColor;
                MainMenu_Btn.BackColor = Side_Panel.BackColor;
            }
        }

        private void SignOut_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Identification i = new Identification();
            i.Show();
            this.Hide();
        }

        private void Name_Label_Click(object sender, EventArgs e)
        {

        }


    }
}
