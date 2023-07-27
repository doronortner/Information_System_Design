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
    public partial class ProgramMenu_Expenses : Form
    {
        private Tech7program currentProgram;
        public ProgramMenu_Expenses()
        {
            InitializeComponent();
            Name_Label.Text = "Hello " + Program.loggedInWorker.get_name();
            Expenses_Btn.BackColor = Color.DeepSkyBlue; // Menu button clicked on when you open this window
            this.currentProgram = Program.seekProgramByName(Program.clickedOnProgram);
            ProgramName_Label.Text = this.currentProgram.get_name();
            Budget.Text = this.currentProgram.get_budget().ToString();
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

        private void Participants_Btn_Click(object sender, EventArgs e)
        {
            ProgramMenu_Participants pmp = new ProgramMenu_Participants();
            pmp.Show();
            this.Hide();
        }

        private void Expense_Btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Amount_Box.Text, out _))
            {
                this.currentProgram.set_budget(int.Parse(Amount_Box.Text));  
                this.currentProgram.update_Tech7program();  // Not working
                Budget.Text = this.currentProgram.get_budget().ToString();
            }
        }
    }
}
