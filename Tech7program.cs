using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_Project
{

    public class Tech7program
    {
        private string connectionString = @"Data Source=IEMDBS;Initial Catalog=SAD_11;Integrated Security=True;";

        private string ID;
        private Worker programManager;
        private string name;
        private DateTime startDT;
        private DateTime endDT;
        private int budget;
        private ProgramStatus programStatus;
        public System.Collections.Generic.List<ExternalEntity> participants;

        public Tech7program(string ID, Worker programManager, string name, DateTime startDT, DateTime endDT, int budget, ProgramStatus programStatus, bool is_new)
        {
            this.ID = ID;
            this.programManager = programManager;
            this.name = name;
            this.startDT = startDT;
            this.endDT = endDT;
            this.budget = budget;
            this.programStatus = programStatus;

            if (is_new)
            {
                this.create_Tech7program();
                Program.Tech7programs.Add(this);
            }
        }

        public String get_ID()
        {
            return this.ID;
        }
        public String get_name()
        {
            return this.name;
        }
        public int get_budget()
        {
            return this.budget;
        }

        public ProgramStatus get_programStatus()
        {
            return this.programStatus;
        }
        public void set_ProgramManager(Worker programManager)
        {
            this.programManager = programManager;
        }

        public void set_ProgramStatus(ProgramStatus programStatus)
        {
            this.programStatus = programStatus;
        }

        public void set_budget(int expense)
        {
            this.budget = this.budget - expense;
        }


        public System.Collections.Generic.List<ExternalEntity> Participants 
        {
            get
            {
                if (participants == null)
                    participants = new System.Collections.Generic.List<ExternalEntity>();
                return participants;
            }
            set
            {
                RemoveAllPartcipants();
                if (value != null)
                {
                    foreach (ExternalEntity newPartcipant in value)
                        AddParticipant(newPartcipant);
                }
            }
        }

        public void AddParticipant(ExternalEntity newPartcipant)
        {
            if (newPartcipant == null)
                return;
            if (participants == null)
                this.participants = new List<ExternalEntity>();

            if (!this.participants.Contains(newPartcipant))
            {
                this.participants.Add(newPartcipant);
            }
        }
        public void RemoveParticipant(ExternalEntity oldParticipant)
        {
            if (oldParticipant == null)
                return;
            if (this.participants != null)
                if (this.participants.Contains(oldParticipant))
                {
                    this.participants.Remove(oldParticipant);
                }
        }

        public void RemoveAllPartcipants()
        {
            if (participants != null)
            {
                participants.Clear();
            }
        }


        public void create_Tech7program()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_add_Program @ProgramID @WorkerId, @ProgramName, @StartDate,  @EndDate, @Budget,  @Status";
            c.Parameters.AddWithValue("@ProgramID", this.ID);
            c.Parameters.AddWithValue("@WorkerId", this.programManager.getID());
            c.Parameters.AddWithValue("@ProgramName", this.name);
            c.Parameters.AddWithValue("@StartDate", this.startDT);
            c.Parameters.AddWithValue("@EndDate", this.endDT);
            c.Parameters.AddWithValue("@Budget", this.budget);
            c.Parameters.AddWithValue("@Status", this.programStatus.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void create_programToParticipantConnection(string ParticipantPhone)  // Updates connecting table
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO ProgramParticipants (EntityPhone, ProgramID) VALUES (@EntityPhone, @ProgramID)", connection))
                {
                    command.Parameters.AddWithValue("@EntityPhone", ParticipantPhone);
                    command.Parameters.AddWithValue("@ProgramID", this.ID);
                    command.ExecuteNonQuery();
                }
            }
        }


        public void update_Tech7program()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_update_Program @ProgramID , @WorkerID, @ProgramName,@StartDate, @EndDate ,@Budget, @Status";
            c.Parameters.AddWithValue("@ProgramID", this.ID);
            c.Parameters.AddWithValue("@WorkerId", this.programManager.getID());
            c.Parameters.AddWithValue("@ProgramName", this.name);
            c.Parameters.AddWithValue("@StartDate", this.startDT);
            c.Parameters.AddWithValue("@EndDate", this.endDT);
            c.Parameters.AddWithValue("@Budget", this.budget);
            c.Parameters.AddWithValue("@Status", this.programStatus.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
