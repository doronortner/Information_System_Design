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
    public partial class WorkerIdentification : Form
    {
        public WorkerIdentification()
        {
            InitializeComponent();
        }

        private void ID_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            if (Program.checkWorkerPassword(ID_Box.Text, Password_Box.Text) == false)  // Check if the ID matches the password
            {
                MessageBox.Show("Wrong ID or password, please try again");
            }

            else
            {
                Program.loggedInWorker = Program.seekWorker(ID_Box.Text);    // Updates a field in Program that indicates who is logged in into the system at the moment
                if (Program.loggedInWorker.ManagedPrograms != null)           // Updates a field in Program that indicates which program that managed by the worker is currently active (only 1)
                {
                    //foreach (Tech7program program in Program.loggedInWorker.ManagedPrograms)  // Delete?
                    //{
                    //    if (program.get_programStatus().ToString() == "Active")
                    //        Program.activeProgram = program;
                    //}
                }

                MainMenu_Main menu = new MainMenu_Main();
                menu.Show();
                this.Hide();
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Identification i = new Identification();
            i.Show();
            this.Hide();
        }
    }
}
