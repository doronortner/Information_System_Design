using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Group11_Project
{
    public partial class WorkersAccountManagement : Form
    {
        public WorkersAccountManagement()
        {
            InitializeComponent();
        }

        private void WorkersAccountManagement_Load(object sender, EventArgs e)
        {

        }

        private void UpperLabel_Click(object sender, EventArgs e)
        {

        }

        private void addWorker_btn_Click(object sender, EventArgs e)
        {
            AddNewWorker anw = new AddNewWorker();
            anw.Show();
            this.Hide();
        }

        private void viewWorkers_btn_Click(object sender, EventArgs e)
        {
            ViewWorkers vw = new ViewWorkers();
            vw.Show();
            this.Hide();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
