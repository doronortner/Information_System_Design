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
    public partial class ExternalEntityAccountManagement : Form
    {
        public ExternalEntityAccountManagement()
        {
            InitializeComponent();
        }

        private void ExternalEntityAM_Click(object sender, EventArgs e)
        {

        }

        private void addExternalEntity_btn_Click(object sender, EventArgs e)
        {
            AddNewExternalEntity anw = new AddNewExternalEntity();
            anw.Show();
            this.Hide();
        }

        private void viewExternalEntity_btn_Click(object sender, EventArgs e)
        {
            ViewExteranlEntity vee = new ViewExteranlEntity();
            vee.Show();
            this.Hide();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
