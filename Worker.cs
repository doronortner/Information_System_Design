
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.ComponentModel;

namespace Group11_Project
{
    public class Worker
    {
        private string workerID;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime hireDate;
        private JobTitle title;
        private WorkerStatus status;
        private string password;
        private System.Collections.Generic.List<Meetup> meetups;
        private System.Collections.Generic.List<Restriction> restrictions;
        private System.Collections.Generic.List<Task> workerTasks;
        private System.Collections.Generic.List<Tech7program> managedPrograms;

        public Worker(string workerID, string firstName, string lastName, string email, string phoneNumber, DateTime hireDate, JobTitle title, WorkerStatus status, string password, bool is_new)
        {
            this.workerID = workerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.hireDate = hireDate;
            this.title = title;
            this.status = status;
            this.password = password;

            if (is_new)
            {
                this.create_worker();
                Program.Workers.Add(this);
            }

            
        }

        public string get_name()
        {
            return this.firstName + " " +this.lastName;
        }
        public string getID()
        {
            return this.workerID;
        }

        public JobTitle get_title()
        {
            return this.title;
        }
        public string get_email()
        {
            return this.email;
        }
        public string get_phoneNumber()
        {
            return this.phoneNumber;
        }

        public string get_password()
        {
            return this.password;
        }

        public void set_name(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void set_email(string email)
        {
            this.email = email;
        }

        public void set_phoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void set_title(JobTitle t)
        {
            this.title = t;
        }

        public void set_status(WorkerStatus status)
        {
            this.status = status;
        }


        public System.Collections.Generic.List<Meetup> Meetups // get and set for the whole list
        {
            get
            {
                if (meetups == null)
                    meetups = new System.Collections.Generic.List<Meetup>();
                return meetups;
            }
            set
            {
                RemoveAllMeetups();
                if (value != null)
                {
                    foreach (Meetup m in value)
                        AddMeetup(m);
                }
            }
        }

        public void AddMeetup(Meetup m)
        {
            if (m == null)
                return;
            if (this.meetups == null)
                this.meetups = new System.Collections.Generic.List<Meetup>();
            if (!this.meetups.Contains(m))
            {
                this.meetups.Add(m);
            }
        }

        public void RemoveMeetup(Meetup oldMeetup)
        {
            if (oldMeetup == null)
                return;
            if (this.meetups != null)
                if (this.meetups.Contains(oldMeetup))
                {
                    this.meetups.Remove(oldMeetup);
                }
        }

        public void RemoveAllMeetups()
        {
            if (meetups != null)
            {
                meetups.Clear();
            }
        }
        public System.Collections.Generic.List<Task> Tasks // get and set for the whole list
        {
            get
            {
                if (workerTasks == null)
                    workerTasks = new System.Collections.Generic.List<Task>();
                return workerTasks;
            }
            set
            {
                RemoveAllMeetups();
                if (value != null)
                {
                    foreach (Task T in value)
                        AddTask(T);
                }
            }
        }

        public void AddTask(Task newTask)
        {
            if (newTask == null)
                return;
            if (this.workerTasks == null)
                this.workerTasks = new System.Collections.Generic.List<Task>();
            if (!this.workerTasks.Contains(newTask))
            {
                this.workerTasks.Add(newTask);
            }
        }

        public void RemoveTask(Task oldTask)
        {
            if (oldTask == null)
                return;
            if (this.workerTasks != null)
                if (this.workerTasks.Contains(oldTask))
                {
                    this.workerTasks.Remove(oldTask);
                    SqlCommand c = new SqlCommand();
                    c.CommandText = "EXECUTE DELETE FROM dbo.Tasks WHERE TaskID = @TaskID";
                    c.Parameters.AddWithValue("@TaskID", oldTask.get_taskID());
                    SQL_CON SC = new SQL_CON();
                    SC.execute_non_query(c);
                }
        }

        public void RemoveAllTasks()
        {
            if (workerTasks != null)
            {
                workerTasks.Clear();
            }
        }

        public System.Collections.Generic.List<Restriction> Restrictions // get and set for the whole list
        {
            get
            {
                if (restrictions == null)
                    restrictions = new System.Collections.Generic.List<Restriction>();
                return restrictions;
            }
            set
            {
                RemoveAllRestrictions();
                if (value != null)
                {
                    foreach (Restriction r in value)
                        AddRestriction(r);
                }
            }
        }

        public void AddRestriction(Restriction r)
        {
            if (r == null)
                return;
            if (this.restrictions == null)
                this.restrictions = new System.Collections.Generic.List<Restriction>();
            if (!this.restrictions.Contains(r))
            {
                this.restrictions.Add(r);
            }
        }

        public void RemoveRestriction(Restriction oldRestriction)
        {
            if (oldRestriction == null)
                return;
            if (this.restrictions != null)
                if (this.restrictions.Contains(oldRestriction))
                {
                    this.restrictions.Remove(oldRestriction);
                }
        }

        public void RemoveAllRestrictions()
        {
            if (restrictions != null)
            {
                restrictions.Clear();
            }
        }

        public System.Collections.Generic.List<Tech7program> ManagedPrograms // get and set for the whole list
        {
            get
            {
                if (managedPrograms == null)
                    managedPrograms = new System.Collections.Generic.List<Tech7program>();
                return managedPrograms;
            }
            set
            {
                RemoveAllPrograms();
                if (value != null)
                {
                    foreach (Tech7program program in value)
                        AddPrograms(program);
                }
            }
        }

        public void AddPrograms(Tech7program newprogram)
        {
            if (newprogram == null)
                return;
            if (this.managedPrograms == null)
                this.managedPrograms = new System.Collections.Generic.List<Tech7program>();
            if (!this.managedPrograms.Contains(newprogram))
            {
                this.managedPrograms.Add(newprogram);
                newprogram.set_ProgramManager(this);
            }
        }
        public void RemovePrograms(Tech7program oldProgram)
        {
            if (oldProgram == null)
                return;
            if (this.managedPrograms != null)
                if (this.managedPrograms.Contains(oldProgram))
                {

                    oldProgram.set_ProgramManager(null);
                    this.managedPrograms.Remove(oldProgram);  
                }
        }

        public void RemoveAllPrograms()
        {
            if (managedPrograms != null)
            {
                managedPrograms.Clear();
            }
        }


        public void create_worker()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_add_worker @WorkerID, @FirstName, @LastName,  @Email, @PhoneNumber, @HireDate, @JobTitle, @Status, @Password";
            c.Parameters.AddWithValue("@WorkerID", this.workerID);
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@HireDate", this.hireDate);
            c.Parameters.AddWithValue("@JobTitle", this.title.ToString());
            c.Parameters.AddWithValue("@Status", this.status.ToString());
            c.Parameters.AddWithValue("@Password", this.password);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_worker()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_update_worker @WorkerID, @FirstName, @LastName,  @Email, @PhoneNumber, @HireDate, @JobTitle, @Status, @Password";
            c.Parameters.AddWithValue("@WorkerID", this.workerID);
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@HireDate", this.hireDate);
            c.Parameters.AddWithValue("@JobTitle", this.title.ToString());
            c.Parameters.AddWithValue("@Status", this.status.ToString());
            c.Parameters.AddWithValue("@Password", this.password);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }        
    }
}