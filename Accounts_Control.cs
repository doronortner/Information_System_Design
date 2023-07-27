using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11_Project
{
    public partial class Accounts_Control : UserControl
    {
        public Accounts_Control()
        {
            InitializeComponent();
        }
        
        private void Workers_Btn_Click(object sender, EventArgs e)
        {
            WorkersAccountManagement wam = new WorkersAccountManagement();
            wam.Show();
        }

        private void Entities_Btn_Click(object sender, EventArgs e)
        {
            ExternalEntityAccountManagement eeam = new ExternalEntityAccountManagement();
            eeam.Show();
        }
    }
}
