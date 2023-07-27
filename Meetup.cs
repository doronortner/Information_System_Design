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
    public class Meetup
    {
        private string meetupID; 
        private Worker responsibleWorker;
        private DateTime startTime;
        private DateTime endTime;
        private string place;
        private string description;
        private MeetupTopic topic;
        private int maxParticipants;
        public System.Collections.Generic.List<ExternalEntity> participants;

        public Meetup(string meetupID, Worker responsibleWorker, DateTime startTime, DateTime endTime, string place, string description, MeetupTopic topic, int maxParticipants, bool is_new)
        {
            this.meetupID = meetupID;
            this.responsibleWorker = responsibleWorker;
            this.startTime = startTime;
            this.endTime = endTime;
            this.place = place;
            this.description = description;
            this.topic = topic;
            this.maxParticipants = maxParticipants;

            if (is_new)
            {
                this.create_Meetup();
                Program.Meetups.Add(this);
            }
        }
        public string get_meetupID()
        {
            return this.meetupID;
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
                        AddPartcipant(newPartcipant);
                }
            }
        }

        public void AddPartcipant(ExternalEntity newPartcipant)
        {
            if (newPartcipant == null)
                return;

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

        public void create_Meetup()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE sp_add_Meetup @MeetupID, @WorkerID, @StartTime, @EndTime, @Place, @Description, @Topic, @MaxParticipants";
            c.Parameters.AddWithValue("@MeetupID", this.meetupID);
            c.Parameters.AddWithValue("@WorkerID", this.responsibleWorker);
            c.Parameters.AddWithValue("@StartTime", this.startTime);
            c.Parameters.AddWithValue("@EndTime", this.endTime);
            c.Parameters.AddWithValue("@Place", this.place);
            c.Parameters.AddWithValue("@Description", this.description);
            c.Parameters.AddWithValue("@Topic", this.topic);
            c.Parameters.AddWithValue("@MaxParticipants", this.maxParticipants);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_meetup()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_update_Meetup @MeetupID, @WorkerID, @StartTime, @EndTime, @Place, @Description, @Topic, @MaxParticipants";
            c.Parameters.AddWithValue("@MeetupID", this.meetupID);
            c.Parameters.AddWithValue("@WorkerID", this.responsibleWorker);
            c.Parameters.AddWithValue("@StartTime", this.startTime);
            c.Parameters.AddWithValue("@EndTime", this.endTime);
            c.Parameters.AddWithValue("@Place", this.place);
            c.Parameters.AddWithValue("@Description", this.description);
            c.Parameters.AddWithValue("@Topic", this.topic);
            c.Parameters.AddWithValue("@MaxParticipants", this.maxParticipants);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
