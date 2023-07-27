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
    public partial class Identification : Form
    {
        public Identification()
        {
            InitializeComponent();
        }

        private void ExternalEntity_button_Click(object sender, EventArgs e)  // log in as an entity
        {
            Sign_Login_Message slm = new Sign_Login_Message();
            slm.Show();
            this.Hide();
        }

        private void Worker_button_Click(object sender, EventArgs e)  // log in as a worker
        {
            WorkerIdentification anw = new WorkerIdentification();
            anw.Show();
            this.Hide();
        }
    }
}
