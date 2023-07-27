using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11_Project
{
    public partial class ViewDeskBookings : Form
    {
        ExternalEntity Entity = Program.loggedInEntity;
        private int index;
        private Booking existBooking;

        public ViewDeskBookings()
        {
            InitializeComponent();
            CancelBooking_Btn.Hide();
            helloLabel.Text = "Hello " + Program.loggedInEntity.get_name();
            DataTable BookingsTable = new DataTable();   // Populate tasks table
            BookingsTable.Columns.Add("BookingID", typeof(string));
            BookingsTable.Columns.Add("Start time", typeof(DateTime));
            BookingsTable.Columns.Add("End time", typeof(DateTime));
            BookingsTable.Columns.Add("DeskID", typeof(string));
            BookingsTable.Columns.Add("Number Of Screens", typeof(int));
            BookingsTable.Columns.Add("Desk Type", typeof(string));
            BookingsTable.Columns.Add("Capacity", typeof(int));
            BookingsTable.Columns.Add("PricePerHour", typeof(int));

            if (Entity.Bookings != null)
            {
                foreach (Booking booking in Entity.Bookings)
                {
                    Desk desk = booking.get_Desk();
                    BookingsTable.Rows.Add(booking.get_BookingID().ToString(), booking.get_StartTime(), booking.get_EndTime(), desk.get_DeskID().ToString(), desk.get_NumOfScreens() ,desk.get_Type().ToString(), desk.get_Capacity(), desk.get_PricePerHour());
                }
                BookingDataGridView.DataSource = BookingsTable;
            }
        }

        private void BookingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = BookingDataGridView.Rows[index];
            existBooking = Program.seekBooking(row.Cells[0].Value.ToString());  // Pointer on the worker that we clicked on (so we could update his data later)
            CancelBooking_Btn.Show();
        }

        private void CancelBooking_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this booking?", "cancel booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Updates task data in DB
                Entity.RemoveBooking(existBooking);
                existBooking.get_Desk().RemoveBooking(existBooking);
                // Updates the task in the table
                ViewDeskBookings vdb = new ViewDeskBookings();
                vdb.Show();
                this.Hide();
             }
        }

        private void NewBookingButton_Click(object sender, EventArgs e)
        {
            DeskBookingScreen dbs = new DeskBookingScreen();
            dbs.Show();
            this.Hide();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to sign out?", "sign out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Identification i = new Identification();
                i.Show();
                this.Hide();
            }
        }
    }
}
