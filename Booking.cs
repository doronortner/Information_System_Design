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
    public class Booking
    {
        private string BookingID;
        private ExternalEntity ExternalEntity;
        private Desk Desk;
        private DateTime StartTime;
        private DateTime EndTime;
    

    public Booking(string BookingID, ExternalEntity ExternalEntity, Desk Desk, DateTime StartTime, DateTime EndTime, bool is_new)
    {
        this.BookingID = BookingID;
        this.ExternalEntity = ExternalEntity;
        this.StartTime = StartTime;
        this.EndTime = EndTime;
        this.Desk = Desk;

        if (is_new)
        {
            this.create_Booking();
            Program.Bookings.Add(this);
        }
        ExternalEntity.AddBooking(this);
        Desk.AddBooking(this);
        }

        public string get_BookingID()
        {
            return this.BookingID;
        }

        public DateTime get_StartTime()
        {
            return this.StartTime;
        }
        public DateTime get_EndTime()
        {
            return this.EndTime;
        }
        public Desk get_Desk()
        {
            return this.Desk;
        }

        public string get_DeskID()
        {
            return this.Desk.get_DeskID();
        }

        public void set_StartTime(DateTime StartTime)
        {
            this.StartTime = StartTime;
        }

        public void set_EndTime(DateTime EndTime)
        {
            this.EndTime = EndTime;
        }


        public void create_Booking()
       {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE sp_add_Booking @BookingID, @ExternalEntitysID, @DeskID, @StartTime, @EndTime";
        c.Parameters.AddWithValue("@BookingID", this.BookingID);
        c.Parameters.AddWithValue("@ExternalEntitysID", this.ExternalEntity.get_phoneNumber());
        c.Parameters.AddWithValue("@DeskID", this.Desk.get_DeskID());
        c.Parameters.AddWithValue("@StartTime", this.StartTime);
        c.Parameters.AddWithValue("@EndTime", this.EndTime);
        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
       }
    }
}