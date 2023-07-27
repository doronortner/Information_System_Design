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
    public partial class AddTask : Form
    {
        string WorkerID = Program.loggedInWorker.getID();  
        public AddTask()
        {
            InitializeComponent();
          
        }

        private void TopLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'sAD_11DataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.sAD_11DataSet.Workers);
            // TODO: This line of code loads data into the 'sAD_11DataSet.TaskStatus' table. You can move, or remove it, as needed.
            this.taskStatusTableAdapter.Fill(this.sAD_11DataSet.TaskStatus);
            // TODO: This line of code loads data into the 'sAD_11DataSet.TaskLabel' table. You can move, or remove it, as needed.
            this.taskLabelTableAdapter.Fill(this.sAD_11DataSet.TaskLabel);

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            // Validate input
            if (TitleTextBox.Text == "" | TitleTextBox.Text.Length > 30)  // Check task title
            {
                MessageBox.Show("The task title is not valid, please try again");
            }
            else if (DescriptionTextBox.Text.Length > 200)  // Check description
            {
                MessageBox.Show("The Description is too long , please try again");
            }
            else if(DateTime.Compare(DateTime.Parse(dateTimePicker1.Text), DateTime.Now) < 0 & StatusComboBox.Text == "InProcess")  // Check time and status
            {
                MessageBox.Show("The selected due date has passed, please change the due date or update the task status");
            }
            else
            {
                if (MessageBox.Show("Do you want to add this task?", "Add task", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Create Task
                    string TaskID = Program.NewTaskID();
                    Label L = (Label)Enum.Parse(typeof(Label), LabelComboBox.Text);
                    StatusTask S = (StatusTask)Enum.Parse(typeof(StatusTask), StatusComboBox.Text);
                    Worker W = Program.seekWorker(WorkerID);
                    Task T = new Task(TaskID, W, TitleTextBox.Text, DateTime.Parse(dateTimePicker1.Text), DescriptionTextBox.Text, L, S, true);
                }
            }
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            WorkerTasksView wtv = new WorkerTasksView();
            wtv.Show();
            this.Hide();
        }
    }
}
