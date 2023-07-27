using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_Project
{
    public class Task
    {
        private string ID;
        public Worker worker;
        private string taskTitle;
        private DateTime dueDate;
        private string description;
        private Label label;
        private StatusTask status;


        public Task(string ID, Worker worker, string taskTitle, DateTime dueDate, string description, Label label, StatusTask status, bool is_new)
        {
            this.ID = ID;
            this.worker = worker;
            this.taskTitle = taskTitle;
            this.dueDate = dueDate;
            this.description = description;
            this.label = label;
            this.status = status;
            if (is_new)
            {
                this.create_task();
                Program.Tasks.Add(this);
                worker.AddTask(this);
            }
        }

        public string get_taskID()
        {
            return this.ID;
        }
        public Worker get_worker()
        {
            return this.worker;
        }
        public string get_taskTitle()
        {
            return this.taskTitle;
        }
        public DateTime get_dueDate()
        {
            return this.dueDate;
        }
        public StatusTask get_status()
        {
            return this.status;
        }
        public Label get_label()
        {
            return this.label;
        }
        public string get_description()
        {
           return this.description;
        }
        public void set_status(StatusTask status)
        {
            this.status = status;
        }
        public void set_label(Label label)
        {
            this.label = label;
        }
        public void set_taskTitle(string taskTitle)
        {
            this.taskTitle = taskTitle;
        }
        public void set_description(string description)
        {
            this.description = description;
        }
        public void set_dueDate(DateTime dueDate)
        {
            this.dueDate = dueDate;
        }
        public void update_status()
        {
            if(this.status.ToString() == "InProcess" & DateTime.Compare(this.dueDate, DateTime.Now) < 0)
            {
                this.status = (StatusTask)Enum.Parse(typeof(StatusTask), "Late");
                this.update_task();
            }
        }

        public void create_task()   
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_add_task @TaskID, @worker, @Title, @DueDate,  @Description, @Label,  @Status";
            c.Parameters.AddWithValue("@TaskID", this.ID);
            c.Parameters.AddWithValue("@worker", this.worker.getID());
            c.Parameters.AddWithValue("@Title", this.taskTitle);
            c.Parameters.AddWithValue("@DueDate", this.dueDate);
            c.Parameters.AddWithValue("@Description", this.description);
            c.Parameters.AddWithValue("@Label", this.label.ToString());
            c.Parameters.AddWithValue("@Status", this.status.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_task()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Update_task @TaskID, @worker, @Title, @DueDate,  @Description, @Label,  @Status";
            c.Parameters.AddWithValue("@TaskID", this.ID);
            c.Parameters.AddWithValue("@worker", this.worker.getID());
            c.Parameters.AddWithValue("@Title", this.taskTitle);
            c.Parameters.AddWithValue("@DueDate", this.dueDate);
            c.Parameters.AddWithValue("@Description", this.description);
            c.Parameters.AddWithValue("@Label", this.label.ToString());
            c.Parameters.AddWithValue("@Status", this.status.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
