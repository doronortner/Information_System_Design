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
    public partial class Sign_Login_Message : Form
    {
        public Sign_Login_Message()
        {
            InitializeComponent();
        }

        private void Log_btn_Click(object sender, EventArgs e)
        {
            ExternalEntityIdentification eei = new ExternalEntityIdentification();
            eei.Show();
            this.Hide();
        }

        private void Sign_Btn_Click(object sender, EventArgs e)
        {
            AddNewExternalEntity anee = new AddNewExternalEntity();
            anee.Show();
            this.Hide();
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            Identification i = new Identification();
            i.Show();
            this.Hide();
        }
    }
}
