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
    public partial class DeskBookingScreen : Form
    {
        private string connectionString = @"Data Source=IEMDBS;Initial Catalog=SAD_11;Integrated Security=True;";
        TimeSpan Roundinterval = TimeSpan.FromHours(1); //designed to allow rounding down tha asked dates 

        public DeskBookingScreen()
        {
            InitializeComponent();
        }
        private void DeskBookingHeader_Click(object sender, EventArgs e)
        {

        }

        private void askedStartDt_ValueChanged(object sender, EventArgs e)
        {
            askedEndDt.MinDate = askedStartDt.Value.AddHours(1); //restrict EndDt minimal value to current startDt value plus one hour

        }
        private void askedEndDt_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void FindDeskBtn_Click(object sender, EventArgs e)  
        {
            if (!(askedEndDt.Value.Day == askedStartDt.Value.Day))
            {
                MessageBox.Show("Reservations are allowed for same day only," + Environment.NewLine + "make sure sequence is logical");
            }
            else
            {
                showOptDesks(askedStartDt.Value, askedEndDt.Value);
                AvailbleDeskGridView.Visible = true;
                BookBtn.Visible = true;
            }
        }


        private void AvailbleDeskGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeskBookingScreen_Load(object sender, EventArgs e)
        {

        }

        private void showOptDesks(DateTime startDt, DateTime endDt)  // Present all available desks
        {
            //convet DateTimePicker to suitable Formatt
            string startDtString = startDt.ToString("yyyy-MM-dd HH:00:ss");
            string endDtString = endDt.ToString("yyyy-MM-dd HH:00:ss");

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter availDeskData = new SqlDataAdapter("SELECT D.* FROM Desks AS D LEFT JOIN Bookings AS B ON D.DeskId = B.DeskID LEFT JOIN RestrictionOnDesks as ROD ON D.DeskID=ROD.DeskID LEFT JOIN Restrictions AS R ON ROD.RestrictionID=R.RestrictionID WHERE (B.BookingID IS NULL AND R.RestrictionID IS NULL) OR ((B.StartTime >= '" + endDtString + "' OR B.EndTime <= '" + startDtString + "') AND R.RestrictionID IS NULL) OR ((R.StartTime >= '" + endDtString + "' OR R.EndTime <= '" + startDtString + "') AND B.BookingID IS NULL);", sqlCon);
                DataTable tempAvailDesks = new DataTable();
               
                availDeskData.Fill(tempAvailDesks);

                AvailbleDeskGridView.DataSource = tempAvailDesks;
            }
        }
        
        private void BookBtn_Click(object sender, EventArgs e)
        {

            //hold new bookingID 
            string newBookID = Program.NewBookingID();
            //Hold Resevating user phoneNum (current user):
            ExternalEntity NewBookEnt = Program.loggedInEntity; //Program.loggedInEntity.get_phoneNumber();
            //Hold selected DeskID:
            Desk selectedDesk = Program.seekDesk(AvailbleDeskGridView.SelectedRows[0].Cells[0].Value.ToString());
            //convet DateTimePicker to suitable Formatt and hold them:
            string startDtString = askedStartDt.Value.ToString("yyyy-MM-dd HH:00:ss");
            string endDtString = askedEndDt.Value.ToString("yyyy-MM-dd HH:00:ss");

            Booking NewBook = new Booking(newBookID, NewBookEnt, selectedDesk, DateTime.Parse(startDtString), DateTime.Parse(endDtString),true);
            BookBtn.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)  // Exit form
        {
            if (Program.loggedInEntity == null)
            {
                ViewDeskBookings vdb = new ViewDeskBookings();
                vdb.Show();
                this.Hide();
            }

            else
            {
                Identification i = new Identification();
                i.Show();
                this.Hide();
            }

        }
    }
}
