using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group11_Project

{
    public class Restriction
    {
        private string connectionString = @"Data Source=IEMDBS;Initial Catalog=SAD_11;Integrated Security=True;"; // Allows to use sql queries

        private string ID;
        private Worker restrictedBy;
        private DateTime startDT;
        private DateTime endDT;
        public System.Collections.Generic.List<Desk> restrictedDesks;


        public Restriction(string ID, Worker restrictedBy, DateTime startDT, DateTime endDT, bool is_new)
        {
            this.ID = ID;
            this.restrictedBy = restrictedBy;
            this.startDT = startDT;
            this.endDT = endDT;

            if (is_new)
            {
                this.create_Restriction();
                Program.Restrictions.Add(this);

            }
        }
        public string get_RestrictionID()
        {
            return this.ID;
        }
        public DateTime get_startDT()
        {
            return this.startDT;
        }
        public DateTime get_endDT()
        {
            return this.endDT;
        }
        public void set_startDT(DateTime startDT)
        {
            this.endDT = startDT;
        }
        public void set_endDT(DateTime endDT)
        {
            this.endDT = endDT;
        }

        public System.Collections.Generic.List<Desk> Desks 
        {
            get
            {
                if (restrictedDesks == null)
                    restrictedDesks = new System.Collections.Generic.List<Desk>();
                return restrictedDesks;
            }
            set
            {
                RemoveAllDesks();
                if (value != null)
                {
                    foreach (Desk d in value)
                        AddDesk(d);
                }
            }
        }

        public void AddDesk(Desk d)
        {
            if (d == null)
                return;
            if (restrictedDesks == null)
                restrictedDesks = new System.Collections.Generic.List<Desk>();
            if (!this.restrictedDesks.Contains(d))
            {
                this.restrictedDesks.Add(d);
            }
        }

        public void RemoveDesk(Desk oldDesk)
        {
            if (oldDesk == null)
                return;
            if (this.restrictedDesks != null)
                if (this.restrictedDesks.Contains(oldDesk))
                {
                    this.restrictedDesks.Remove(oldDesk);
                }
        }

        public void RemoveAllDesks()
        {
            if (restrictedDesks != null)
            {
                restrictedDesks.Clear();
            }
        }

        public void create_Restriction()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_add_Restriction @RestrictionID, @WorkerID, @StartTime, @EndTime";
            c.Parameters.AddWithValue("@RestrictionID", this.ID);
            c.Parameters.AddWithValue("@WorkerID", this.restrictedBy.getID());
            c.Parameters.AddWithValue("@StartTime", this.startDT);
            c.Parameters.AddWithValue("@EndTime", this.endDT);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void create_RestrictionOnDeskConnection(string desk) 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO RestrictionOnDesks (DeskID, RestrictionID) VALUES (@DeskID, @RestrictionID)", connection))
                {
                    command.Parameters.AddWithValue("@DeskID", desk);
                    command.Parameters.AddWithValue("@RestrictionID", this.ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void update_Restriction()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_add_Restriction @RestrictionID, @WorkerID, @StartTime, @EndTime";
            c.Parameters.AddWithValue("@RestrictionID", this.ID);
            c.Parameters.AddWithValue("@WorkerID", this.restrictedBy.getID());
            c.Parameters.AddWithValue("@StartTime", this.startDT);
            c.Parameters.AddWithValue("@EndTime", this.endDT);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
