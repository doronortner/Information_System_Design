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
    public partial class ExternalEntity_Menu : Form
    {
        public ExternalEntity_Menu()
        {
            InitializeComponent();
        }

        private void BookingDeskButton_Click(object sender, EventArgs e)
        {
            DeskBookingScreen dbs = new DeskBookingScreen();
            dbs.Show();
            this.Hide();
        }
    }
}
