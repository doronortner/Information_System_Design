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
    public class Desk
    {
        private string DeskID;
        private int NumOfScreens;
        private DeskType Type;
        private int Capacity;
        private int PricePerHour;
        public System.Collections.Generic.List<Booking> bookings;
        public System.Collections.Generic.List<Restriction> restrictions;

        public Desk(string DeskID, int NumOfScreens, DeskType Type, int Capacity, int PricePerHour, bool is_new)
        {
            this.DeskID = DeskID;
            this.NumOfScreens = NumOfScreens;
            this.Type = Type;
            this.Capacity = Capacity;
            this.PricePerHour = PricePerHour;

            if (is_new)
            {
                this.create_Desk();
                Program.Desks.Add(this);
            }
        }

         public string get_DeskID()
          {
             return this.DeskID;
          }

        public int get_NumOfScreens()
        {
            return this.NumOfScreens;
        }
        public DeskType get_Type()
        {
            return this.Type;
        }

        public int get_Capacity()
        {
            return this.Capacity;
        }
        public int get_PricePerHour()
        {
            return this.Capacity;
        }


        public System.Collections.Generic.List<Booking> Bookings
        {
            get
            {
                if (bookings == null)
                    bookings = new System.Collections.Generic.List<Booking>();
                return bookings;
            }
            set
            {
                RemoveAllBookings();
                if (value != null)
                {
                    foreach (Booking b in value)
                        AddBooking(b);
                }
            }
        }

        public void AddBooking(Booking b)
        {
            if (b == null)
                return;
            if (this.bookings == null)
                this.bookings = new System.Collections.Generic.List<Booking>();
            if (!this.bookings.Contains(b))
            {
                this.bookings.Add(b);
            }
        }

        public void RemoveBooking(Booking oldBooking)
        {
            if (oldBooking == null)
                return;
            if (this.bookings != null)
                if (this.bookings.Contains(oldBooking))
                {
                    this.bookings.Remove(oldBooking);
                    SqlCommand c = new SqlCommand();
                    c.CommandText = "EXECUTE dbo.sp_delete_booking @BookingID";
                    c.Parameters.AddWithValue("@BookingID", oldBooking.get_BookingID());
                    SQL_CON SC = new SQL_CON();
                    SC.execute_non_query(c);
                }
        }

        public void RemoveAllBookings()
        {
            if (bookings != null)
            {
                bookings.Clear();
            }
        }

        public System.Collections.Generic.List<Restriction> Restrictions 
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
            if (restrictions == null)
                restrictions = new System.Collections.Generic.List<Restriction>();
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

        public void create_Desk() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE sp_add_Desk @DeskID, @NumOfScreens, @Type, @Capacity, @PricePerHour";
            c.Parameters.AddWithValue("@DeskID", this.DeskID);
            c.Parameters.AddWithValue("@NumOfScreens", this.NumOfScreens);
            c.Parameters.AddWithValue("@Type", this.Type);
            c.Parameters.AddWithValue("@Capacity", this.Capacity);
            c.Parameters.AddWithValue("@PricePerHour", this.PricePerHour);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_desk()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_update_Desks @DeskID, @NumOfScreens, @Type, @Capacity, @PricePerHour";
            c.Parameters.AddWithValue("@DeskID", this.DeskID);
            c.Parameters.AddWithValue("@NumOfScreens", this.NumOfScreens);
            c.Parameters.AddWithValue("@Type", this.Type);
            c.Parameters.AddWithValue("@Capacity", this.Capacity);
            c.Parameters.AddWithValue("@PricePerHour", this.PricePerHour);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}

