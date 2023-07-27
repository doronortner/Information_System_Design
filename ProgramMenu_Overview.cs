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
    
    public partial class ProgramMenu_Overview : Form
    {
        private Tech7program currentProgram;
        public ProgramMenu_Overview()
        {
            InitializeComponent();
            if (Program.loggedInWorker.get_title().ToString() != "ProgramManager")
            {
                Expenses_Btn.Visible = false;
                Status_Combo.Visible = false;
            }
                

            Name_Label.Text = "Hello " + Program.loggedInWorker.get_name();
            Overview_Btn.BackColor = Color.DeepSkyBlue; // Menu button clicked on when you open this window
            this.currentProgram = Program.seekProgramByName(Program.clickedOnProgram);
            Participants_Label.Text = this.currentProgram.Participants.Count.ToString();
            Status_Combo.Text = this.currentProgram.get_programStatus().ToString();
            Budget.Text = this.currentProgram.get_budget().ToString();
            Status_Label.Text = this.currentProgram.get_programStatus().ToString();
            ProgramName_Label.Text = this.currentProgram.get_name();

            DataTable programManagerTasksTable = new DataTable();   // Populate tasks table
            programManagerTasksTable.Columns.Add("Title", typeof(string));
            programManagerTasksTable.Columns.Add("Due Date", typeof(DateTime));
            programManagerTasksTable.Columns.Add("Description", typeof(string));
            programManagerTasksTable.Columns.Add("Status", typeof(string));

            if (Program.loggedInWorker.Tasks != null)   
            {
                foreach (Task task in Program.loggedInWorker.Tasks)
                {
                    if (task.get_label().ToString() == "ProgramRelated")
                        programManagerTasksTable.Rows.Add(task.get_taskTitle().ToString(), task.get_dueDate(), task.get_description(), task.get_status().ToString());
                }
                Tasks_Table.DataSource = programManagerTasksTable;
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

        private void Participants_Btn_Click(object sender, EventArgs e)
        {
            ProgramMenu_Participants pmp = new ProgramMenu_Participants();
            pmp.Show();
            this.Hide();
        }

        private void Expenses_Btn_Click(object sender, EventArgs e)
        {
            ProgramMenu_Expenses pme = new ProgramMenu_Expenses();
            pme.Show();
            this.Hide();
        }

        private void Status_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentProgram.set_ProgramStatus((ProgramStatus)Enum.Parse(typeof(ProgramStatus), Status_Combo.Text));  // Updates program status according to the combo box
            this.currentProgram.update_Tech7program();
            Status_Label.Text = Status_Combo.SelectedItem.ToString();   

        }
    }
}
