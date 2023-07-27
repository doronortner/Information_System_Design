using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel;


namespace Group11_Project
{
    static class Program
    {
        /// <summary>-
        /// The main entry point for the application.
        /// </summary>
        /// 
        // Fields
        public static Worker loggedInWorker;
        public static ExternalEntity loggedInEntity;
        public static string clickedOnProgram; 
        public static System.Collections.Generic.List<Worker> Workers;
        public static System.Collections.Generic.List<ExternalEntity> ExternalEntities;
        public static System.Collections.Generic.List<Booking> Bookings;
        public static System.Collections.Generic.List<Desk> Desks;
        public static System.Collections.Generic.List<Meetup> Meetups;
        public static System.Collections.Generic.List<Task> Tasks;
        public static System.Collections.Generic.List<Restriction> Restrictions;
        public static System.Collections.Generic.List<Tech7program> Tech7programs;

        [STAThread]


        // -----------------------------------  Seek methods --------------------------------------------
        public static Worker seekWorker(string id)  
        {
            foreach (Worker w in Workers)
            {
                if (w.getID() == id)
                    return w;
            }
            return null;
        }

        public static Boolean seekWorkerID(string id)
        {
            foreach (Worker w in Workers)
            {
                if (w.getID() == id)
                    return true;
            }
            return false;
        }

        public static ExternalEntity seekExternalEntity(string phoneNumber)
        {
            foreach (ExternalEntity ee in ExternalEntities)
            {
                if (ee.get_phoneNumber() == phoneNumber)
                    return ee;
            }
            return null;
        }

        public static Boolean seekExternalEntityPhoneNumber(string phoneNumber)
        {
            foreach (ExternalEntity ee in ExternalEntities)
            {
                if (ee.get_phoneNumber() == phoneNumber)
                    return true;
            }
            return false;
        }

        public static Desk seekDesk(string deskID)
        {
            foreach (Desk d in Desks)
            {
                if (d.get_DeskID() == deskID)
                    return d;
            }
            return null;
        }
        public static Task seekTask(string id)
        {
            foreach (Task T in Tasks)
            {
                if (T.get_taskID() == id)
                    return T;
            }
            return null;
        }
        public static Booking seekBooking(string id)
        {
            foreach (Booking B in Bookings)
            {
                if (B.get_BookingID() == id)
                    return B;
            }
            return null;
        }
        public static Tech7program seekProgramByName(string programName)
        {
            foreach (Tech7program p in Tech7programs)
            {
                if (p.get_name() == programName)
                    return p;
            }
            return null;
        }
        public static string NewTaskID()
        {
            int id = 0;
            foreach (Task t in Tasks)
            {
                if (int.Parse(t.get_taskID()) > id)
                    id = int.Parse(t.get_taskID());
            }
            return ((id + 1).ToString());
        }
        public static string NewRestrictionID()
        {
            int id = 0;
            foreach (Restriction r in Restrictions)
            {
                if (int.Parse(r.get_RestrictionID()) > id)
                    id = int.Parse(r.get_RestrictionID());
            }
            return ((id + 1).ToString());
        }

        public static Boolean checkEntityPassword(string phoneNumber, string password)  // Check if password of an entity matches the log in password
        {
            foreach (ExternalEntity ee in ExternalEntities)
            {
                if (ee.get_phoneNumber() == phoneNumber & ee.get_password() == password)
                    return true;
            }
            return false;
        }

        public static Boolean checkWorkerPassword(string ID, string password)  // Check if password of an worker matches the log in password
        {
            foreach (Worker w in Workers)
            {
                if (w.getID() == ID & w.get_password() == password)
                    return true;
            }
            return false;
        }

        public static string NewBookingID()
        {
            int id = 0;
            foreach (Booking b in Program.Bookings)
            {
                if (int.Parse(b.get_BookingID()) > id)
                    id = int.Parse(b.get_BookingID());
            }
            return ((id + 1).ToString());
        }
    

        // --------------------------------------------- init lists --------------------------------------
        public static void initLists()
        {
            init_workers(); 
            init_ExternalEntities();
            init_Tasks();
            init_Desks();
            init_Bookings();
            init_Restrictions();
            init_Meetups();
            init_Tech7programs();
        }

        public static void init_workers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.get_all_workers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Workers = new List<Worker>();

            while (rdr.Read())
            {
                JobTitle T = (JobTitle)Enum.Parse(typeof(JobTitle), rdr.GetValue(6).ToString());
                WorkerStatus S = (WorkerStatus)Enum.Parse(typeof(WorkerStatus), rdr.GetValue(7).ToString());
                Worker w = new Worker(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), T, S, rdr.GetValue(8).ToString(), false);
                Workers.Add(w);
            }
        }

        public static void init_ExternalEntities() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.get_all_ExternalEntities";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            ExternalEntities = new List<ExternalEntity>();

            while (rdr.Read())
            {
                ExternalEntityType T = (ExternalEntityType)Enum.Parse(typeof(ExternalEntityType), rdr.GetValue(5).ToString());
                Gender G = (Gender)Enum.Parse(typeof(Gender), rdr.GetValue(7).ToString());
                ExternalEntity e = new ExternalEntity(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), DateTime.Parse(rdr.GetValue(4).ToString()), T, rdr.GetValue(6).ToString(),G, int.Parse(rdr.GetValue(8).ToString()),  false);
                ExternalEntities.Add(e);

                SqlCommand cmd = new SqlCommand();  // Add all occupations to each entity
                cmd.CommandText = "EXECUTE dbo.get_all_EntitiesOccupation";
                SQL_CON SCON = new SQL_CON();
                SqlDataReader reader = SCON.execute_query(cmd);
                while (reader.Read())
                {
                    if (rdr.GetValue(0).ToString() == reader.GetValue(0).ToString())
                    {
                        e.AddOccupation((AllowedOccupation)Enum.Parse(typeof(AllowedOccupation), reader.GetValue(1).ToString()));
                    }
                }
            }
        }

        public static void init_Tasks()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.get_all_Tasks";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Tasks = new List<Task>();

            while (rdr.Read())
            {
                Worker w = seekWorker(rdr.GetValue(1).ToString());
                Label L = (Label)Enum.Parse(typeof(Label), rdr.GetValue(5).ToString());
                StatusTask S = (StatusTask)Enum.Parse(typeof(StatusTask), rdr.GetValue(6).ToString());
                Task t = new Task(rdr.GetValue(0).ToString(), w, rdr.GetValue(2).ToString(), DateTime.Parse(rdr.GetValue(3).ToString()), rdr.GetValue(4).ToString(), L, S, false);
                Tasks.Add(t);
                w.AddTask(t);
                t.update_status();
            }
        }

        public static void init_Desks()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.get_all_Desks";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Desks = new List<Desk>();

            while (rdr.Read())
            {
                DeskType T = (DeskType)Enum.Parse(typeof(DeskType), rdr.GetValue(2).ToString());
                Desk d = new Desk(rdr.GetValue(0).ToString(), int.Parse(rdr.GetValue(1).ToString()), T, int.Parse(rdr.GetValue(3).ToString()), int.Parse(rdr.GetValue(4).ToString()), false);
                Desks.Add(d);
            }
        }

        public static void init_Bookings() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.get_all_Bookings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Bookings = new List<Booking>();

            while (rdr.Read())
            {
                ExternalEntity e = seekExternalEntity(rdr.GetValue(1).ToString());
                Desk d = seekDesk(rdr.GetValue(2).ToString());
                Booking b = new Booking(rdr.GetValue(0).ToString(), e, d, DateTime.Parse(rdr.GetValue(3).ToString()), DateTime.Parse(rdr.GetValue(4).ToString()), false);
                Bookings.Add(b);
                seekDesk(rdr.GetValue(2).ToString()).AddBooking(b);
                seekExternalEntity(rdr.GetValue(1).ToString()).AddBooking(b);
            }
        }

        public static void init_Restrictions()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.get_all_Restrictions";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Restrictions = new List<Restriction>();

            while (rdr.Read())
            {
                Worker w = seekWorker(rdr.GetValue(1).ToString());
                Restriction r = new Restriction(rdr.GetValue(0).ToString(), w, DateTime.Parse(rdr.GetValue(2).ToString()), DateTime.Parse(rdr.GetValue(3).ToString()), false);
                Restrictions.Add(r);
                seekWorker(rdr.GetValue(1).ToString()).AddRestriction(r);

                SqlCommand cmd = new SqlCommand();  // Add all restriction to each desk, and all desks to each restriction
                cmd.CommandText = "EXECUTE dbo.get_all_RestrictionsOnDesks";
                SQL_CON SCON = new SQL_CON();
                SqlDataReader reader = SCON.execute_query(cmd);
                while (reader.Read())
                {
                    if (rdr.GetValue(0).ToString() == reader.GetValue(1).ToString())
                    {
                        seekDesk(reader.GetValue(0).ToString()).AddRestriction(r);
                        r.AddDesk(seekDesk(reader.GetValue(0).ToString()));
                    }
                        
                }

            }
        }


        public static void init_Meetups() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.get_all_Meetups";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Meetups = new List<Meetup>();

            while (rdr.Read())
            {
                Worker w = seekWorker(rdr.GetValue(1).ToString());
                MeetupTopic T = (MeetupTopic)Enum.Parse(typeof(MeetupTopic), rdr.GetValue(6).ToString());    
                Meetup m = new Meetup(rdr.GetValue(0).ToString(), w, DateTime.Parse(rdr.GetValue(2).ToString()), DateTime.Parse(rdr.GetValue(3).ToString()), rdr.GetValue(4).ToString(), rdr.GetValue(5).ToString(), T, int.Parse(rdr.GetValue(7).ToString()), false);
                Meetups.Add(m);
                seekWorker(rdr.GetValue(1).ToString()).AddMeetup(m);

                SqlCommand cmd = new SqlCommand();  // Add all meetups to each entity, and all entities to each meetup
                cmd.CommandText = "EXECUTE dbo.get_all_EntitiesGoesToMeetups";
                SQL_CON SCON = new SQL_CON();
                SqlDataReader reader = SCON.execute_query(cmd);
                while (reader.Read())
                {
                    if (rdr.GetValue(0).ToString() == reader.GetValue(1).ToString())
                    {
                        m.AddPartcipant(seekExternalEntity(rdr.GetValue(0).ToString()));
                        seekExternalEntity(reader.GetValue(0).ToString()).AddMeetup(m);
                    } 
                }
            }
        }


        public static void init_Tech7programs()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Tech7programs";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Tech7programs = new List<Tech7program>();

            while (rdr.Read())
            {
                ProgramStatus S = (ProgramStatus)Enum.Parse(typeof(ProgramStatus), rdr.GetValue(6).ToString());
                Worker W = seekWorker(rdr.GetValue(1).ToString());
                Tech7program p = new Tech7program(rdr.GetValue(0).ToString(), W, rdr.GetValue(2).ToString(), DateTime.Parse(rdr.GetValue(3).ToString()), DateTime.Parse(rdr.GetValue(4).ToString()), int.Parse(rdr.GetValue(5).ToString()), S, false);
                Tech7programs.Add(p);
                W.AddPrograms(p);

                SqlCommand cmd = new SqlCommand();  // Add all programs to each entity, and all entities to each program
                cmd.CommandText = "EXECUTE dbo.get_all_ProgramParticipants";
                SQL_CON SCON = new SQL_CON();
                SqlDataReader reader = SCON.execute_query(cmd);
                while (reader.Read())
                {
                    if (rdr.GetValue(0).ToString() == reader.GetValue(1).ToString())
                    {
                        p.AddParticipant(seekExternalEntity(reader.GetValue(0).ToString()));
                        seekExternalEntity(reader.GetValue(0).ToString()).AddPrograms(p);
                    }
                }
            }
        }


        public static bool isValidEmail(string email)    
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return emailRegex.IsMatch(email);
        }



        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();
            Application.Run(new Identification());
        }
    }
}
