using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group11_Project
{
    public class ExternalEntity
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime joinDate;
        private ExternalEntityType type;
        private string password;
        private Gender gender;
        private int age;


        public System.Collections.Generic.List<AllowedOccupation> occupations;
        public System.Collections.Generic.List<Tech7program> EEPrograms;
        public System.Collections.Generic.List<Meetup> meetups;
        public System.Collections.Generic.List<Booking> bookings;


        public ExternalEntity(string phoneNumber, string firstName, string lastName, string email, DateTime joinDate, ExternalEntityType type, string password, Gender gender, int age, bool is_new)
        {
            this.phoneNumber = phoneNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.joinDate = joinDate;
            this.type = type;
            this.password = password;
            this.gender = gender;
            this.age = age;

            if (is_new)
            {
                this.create_ExternalEntity();
                Program.ExternalEntities.Add(this);
            }
        }

        public string get_name()
        {
            return this.firstName + " " + this.lastName;
        }

        public ExternalEntityType get_type()
        {
            return this.type;
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

        public Gender get_gender()
        {
            return this.gender;
        }
        public int get_age()
        {
            return this.age;
        }
        public void set_name(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void set_password(string password)
        {
            this.password = password;
        }

        public void set_phoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void set_email(string email)
        {
            this.email = email;
        }
        public void set_gender(Gender gender)
        {
            this.gender = gender;
        }
        public void set_age(int age)
        {
            this.age = age;
        }


        public void set_type(ExternalEntityType t)
        {
            this.type = t;
        }
        public System.Collections.Generic.List<Tech7program> Tech7programs // get and set for the whole list
        {
            get
            {
                if (EEPrograms == null)
                    EEPrograms = new System.Collections.Generic.List<Tech7program>();
                return EEPrograms;
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
            if (this.EEPrograms == null)
                this.EEPrograms = new System.Collections.Generic.List<Tech7program>();
            if (!this.EEPrograms.Contains(newprogram))
            {
                this.EEPrograms.Add(newprogram);
            }
        }
        public void RemovePrograms(Tech7program oldProgram)
        {
            if (oldProgram == null)
                return;
            if (this.EEPrograms != null)
                if (this.EEPrograms.Contains(oldProgram))
                {
                    this.EEPrograms.Remove(oldProgram);
                    SqlCommand c = new SqlCommand();
                    c.CommandText = "EXECUTE dbo.sp_delete_participantFromProg @EntityPhone, @ProgramID";
                    c.Parameters.AddWithValue("@EntityPhone", this.phoneNumber);
                    c.Parameters.AddWithValue("@ProgramID", oldProgram.get_ID());
                    SQL_CON SC = new SQL_CON();
                    SC.execute_non_query(c);
                }
        }

        public void RemoveAllPrograms()
        {
            if (EEPrograms != null)
            {
                EEPrograms.Clear();
            }
        }

        public System.Collections.Generic.List<AllowedOccupation> Occupations // get and set for the whole list
        {
            get
            {
                if (occupations == null)
                    occupations = new System.Collections.Generic.List<AllowedOccupation>();
                return occupations;
            }
            set
            {
                RemoveAllOccupations();
                if (value != null)
                {
                    foreach (AllowedOccupation o in value)
                        AddOccupation(o);
                }
            }
        }

        public void AddOccupation(AllowedOccupation o)
        {
            if (o == null)
                return;
            if (this.occupations == null)
                this.occupations = new System.Collections.Generic.List<AllowedOccupation>();
            if (!this.occupations.Contains(o))
            {
                this.occupations.Add(o);
            }
        }
        public void RemoveOccupation(AllowedOccupation oldOccupation)
        {
            if (oldOccupation == null)
                return;
            if (this.occupations != null)
                if (this.occupations.Contains(oldOccupation))
                {
                    this.occupations.Remove(oldOccupation);
                    SqlCommand c = new SqlCommand();
                    c.CommandText = "EXECUTE dbo.sp_delete_occupation @EntityPhone, @Occupation";
                    c.Parameters.AddWithValue("@EntityPhone", this.phoneNumber);
                    c.Parameters.AddWithValue("@Occupation", oldOccupation.ToString());
                    SQL_CON SC = new SQL_CON();
                    SC.execute_non_query(c);
                }
        }

        public void RemoveAllOccupations()
        {
            if (occupations != null)
            {
                occupations.Clear();
            }
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
                    SqlCommand c = new SqlCommand();
                    c.CommandText = "EXECUTE DELETE FROM dbo.EntitiesGoesToMeetup WHERE EntityPhone = @EntityPhone AND MeetupID = @MeetupID";
                    c.Parameters.AddWithValue("@EntityPhone", this.phoneNumber);
                    c.Parameters.AddWithValue("@MeetupID", oldMeetup.get_meetupID());
                    SQL_CON SC = new SQL_CON();
                    SC.execute_non_query(c);
                }
        }

        public void RemoveAllMeetups()
        {
            if (meetups != null)
            {
                meetups.Clear();
            }
        }

        public System.Collections.Generic.List<Booking> Bookings // get and set for the whole list
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


        public void create_ExternalEntity()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE sp_add_ExternalEntity @PhoneNumber, @FirstName, @LastName , @Email, @JoinDate , @Type, @Password, @Gender, @Age";
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@JoinDate", this.joinDate);
            c.Parameters.AddWithValue("@Type", this.type.ToString());
            c.Parameters.AddWithValue("@Password", this.password);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@Age", this.age);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_ExternalEntity()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_update_ExternalEntity @PhoneNumber, @FirstName, @LastName , @Email, @JoinDate , @Type, @Password, @Gender, @Age";
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@FirstName", this.firstName);
            c.Parameters.AddWithValue("@LastName", this.lastName);
            c.Parameters.AddWithValue("@Email", this.email);
            c.Parameters.AddWithValue("@JoinDate", this.joinDate);
            c.Parameters.AddWithValue("@Type", this.type.ToString());
            c.Parameters.AddWithValue("@Password", this.password);
            c.Parameters.AddWithValue("@Gender", this.gender.ToString());
            c.Parameters.AddWithValue("@Age", this.age);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);  
       }

        public void create_ExternalEntityOccupation(AllowedOccupation occupation)
        {
            this.AddOccupation(occupation);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE sp_add_EntityOccupation @PhoneNumber, @Occupation";
            c.Parameters.AddWithValue("@PhoneNumber", this.phoneNumber);
            c.Parameters.AddWithValue("@Occupation", occupation.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}
