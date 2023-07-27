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
    public partial class MainMenu_Main : Form
    {
        public MainMenu_Main()
        {
            InitializeComponent();
            Name_Label.Text = "Hello " + Program.loggedInWorker.get_name();
            MainMenu_Btn.BackColor = Color.DeepSkyBlue; // Menu button clicked on when you open this window
            if (Program.loggedInWorker.get_title().ToString() == "CommunityManager")
            {
                Accounts_Btn.Visible = true;
            }
        }

        private void SignOut_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Identification i = new Identification();
            i.Show();
            this.Hide();
        }

        private void Program1_Btn_Click(object sender, EventArgs e) // Go to the program
        {
            Program.clickedOnProgram = Program1_Btn.Text.ToString();
            ProgramMenu_Overview pmo = new ProgramMenu_Overview();
            pmo.Show();
            this.Hide();
        }

        private void Accounts_Btn_Click(object sender, EventArgs e)  // Go to accounts management
        {
            MainMenu_Accounts mma = new MainMenu_Accounts();
            mma.Show();
            this.Hide();
        }

        private void Tasks_Btn_Click(object sender, EventArgs e)  // Go to task management
        {
            WorkerTasksView wtv = new WorkerTasksView();
            wtv.Show();
            this.Hide();
        }

        private void Desks_Btn_Click(object sender, EventArgs e)  // Go to desks management
        {
            if(Program.loggedInWorker.get_title().ToString() == "CommunityManager")
            {
                RestrictionsScreen rs = new RestrictionsScreen();
                rs.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sorry, you are not authorized to manage tasks, if necessary ask the community manager");
        }

        private void Report_Btn_Click(object sender, EventArgs e)  // Produce a report
        {
            dashboard db = new dashboard();
            db.Show();
            this.Hide(); 
        }
    }
}
