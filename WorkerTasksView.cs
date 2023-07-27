using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group11_Project
{
    public partial class WorkerTasksView : Form
    {
        Worker worker = Program.loggedInWorker;
        private int index;
        private Task existTask;
        public WorkerTasksView()
        {
            InitializeComponent();
            updateButton.Hide();
            DataTable WorkerTasksTable = new DataTable();   // Populate tasks table
            WorkerTasksTable.Columns.Add("TaskID", typeof(string));
            WorkerTasksTable.Columns.Add("Title", typeof(string));
            WorkerTasksTable.Columns.Add("Due Date", typeof(DateTime));
            WorkerTasksTable.Columns.Add("Status", typeof(string));

            if (Program.loggedInWorker.Tasks != null)
            {
                foreach (Task task in Program.loggedInWorker.Tasks)
                {
                    task.update_status();
                    WorkerTasksTable.Rows.Add(task.get_taskID().ToString(), task.get_taskTitle().ToString(), task.get_dueDate(), task.get_status().ToString());
                }
                WorkerTaskView.DataSource = WorkerTasksTable;
            }
        }
        private void WorkerTasksView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.TaskLabel' table. You can move, or remove it, as needed.
            this.taskLabelTableAdapter.Fill(this.sAD_11DataSet.TaskLabel);
            // TODO: This line of code loads data into the 'sAD_11DataSet.TaskStatus' table. You can move, or remove it, as needed.
            this.taskStatusTableAdapter.Fill(this.sAD_11DataSet.TaskStatus);
            // TODO: This line of code loads data into the 'sAD_11DataSet.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.sAD_11DataSet.Tasks);

        }

        private void WorkerTaskView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateButton.Show();
            // When clicked on a worker, it will preview his data in the text boxes
            index = e.RowIndex;
            DataGridViewRow row = WorkerTaskView.Rows[index];
            existTask = Program.seekTask(row.Cells[0].Value.ToString());  // Pointer on the worker that we clicked on (so we could update his data later)
            TitleTextBox.Text = existTask.get_taskTitle();
            dateTimePicker1.Text = existTask.get_dueDate().ToString();
            DescriptionTextBox.Text = existTask.get_description();
            LabelComboBox.Text = existTask.get_label().ToString();
            StatusComboBox.Text = existTask.get_status().ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == "" | TitleTextBox.Text.Length > 30)  // Check first name
            {
                MessageBox.Show("The task title is not valid, please try again");
            }
            else if (DescriptionTextBox.Text.Length > 200)  // Check first name
            {
                MessageBox.Show("The Description is too long , please try again");
            }
            else if (DateTime.Compare(DateTime.Parse(dateTimePicker1.Text), DateTime.Now) < 0 & StatusComboBox.Text == "InProcess")  // Check first name
            {
                MessageBox.Show("The selected due date has passed, please change the due date or update the task status");
            }
            else
            {
                if (MessageBox.Show("Do you want to update this task?", "update task", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Updates task data in DB
                    existTask.set_taskTitle(TitleTextBox.Text);
                    existTask.set_dueDate(DateTime.Parse(dateTimePicker1.Text));
                    existTask.set_description(DescriptionTextBox.Text);
                    existTask.set_label((Label)Enum.Parse(typeof(Label), LabelComboBox.Text));
                    existTask.set_status((StatusTask)Enum.Parse(typeof(StatusTask), StatusComboBox.Text));
                    existTask.update_task();

                    // Updates the task in the table
                    DataGridViewRow newdata = WorkerTaskView.Rows[index];
                    newdata.Cells[1].Value = TitleTextBox.Text;
                    newdata.Cells[2].Value = dateTimePicker1.Text;
                    newdata.Cells[3].Value = StatusComboBox.Text;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainMenu_Main mmm = new MainMenu_Main();
            mmm.Show();
            this.Hide();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTask at = new AddTask();
            at.Show();
            this.Hide();
         }
    }
}