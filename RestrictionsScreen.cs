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
    public partial class RestrictionsScreen : Form
    {
        private string connectionString = @"Data Source=IEMDBS;Initial Catalog=SAD_11;Integrated Security=True;";

        public RestrictionsScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RestrictionsScreen_Load(object sender, EventArgs e)
        {
            //this.desksTableAdapter.Fill(this.sAD_11DataSet.Desks);

            using (SqlConnection sqlCon = new SqlConnection(connectionString))  //show all tabels upon opening form
            {
                sqlCon.Open();
                SqlDataAdapter AllDeskDataList = new SqlDataAdapter("select DeskID from Desks", sqlCon);
                DataTable tempDeskDataList = new DataTable();

                AllDeskDataList.Fill(tempDeskDataList);

                ShowDesksDataGrid.DataSource = tempDeskDataList;
            }

            RestrictionStartDt.MinDate = DateTime.Now;
            RestrictiondEndDt.MinDate = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e) //ShowRestrictionsBtn
        {
            ShowSelectedDesksRestriction();
        }

        private void askedStartDt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ShowDesksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExistingRestrictionsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimeFrameLbl_Click(object sender, EventArgs e)
        {

        }

        private void RestrictionStartDt_ValueChanged(object sender, EventArgs e)
        {
            RestrictiondEndDt.MinDate = RestrictionStartDt.Value.AddHours(1); //restrict EndDt minimal value to current startDt value plus one hour
        }

        private void RestrictiondEndDt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SubNewRestBtn_Click(object sender, EventArgs e)
        {
            string newRestrictionID = Program.NewRestrictionID();
            DateTime resStartDT = RestrictionStartDt.Value;
            resStartDT = resStartDT.AddMinutes(-resStartDT.Minute); //Floor picked start time to round hour
            DateTime resEndDT = RestrictiondEndDt.Value;
            resEndDT = resEndDT.AddMinutes(-resEndDT.Minute); //Floor picked end time to round hour
            //Build new restriction:
            Restriction restriction = new Restriction(newRestrictionID, Program.loggedInWorker, resStartDT, resEndDT, true);
            //insert restriction to every desk list and to connecting table 
            foreach (DataGridViewRow row in ShowDesksDataGrid.SelectedRows)
            {
                string CurrentDeskID = Convert.ToString(row.Cells["DeskId"].Value);
                Desk desk = Program.seekDesk(CurrentDeskID);
                Program.loggedInWorker.AddRestriction(restriction);
                desk.AddRestriction(restriction);
                restriction.AddDesk(desk);
                restriction.create_RestrictionOnDeskConnection(desk.get_DeskID());
            }

        }

        private void ShowSelectedDesksRestriction()
        {
            //build list with all selected desks:
            List<int> selectedDeskIds = new List<int>();
            foreach (DataGridViewRow row in ShowDesksDataGrid.SelectedRows)
            {
                int CurrentDeskID = Convert.ToInt32(row.Cells["DeskId"].Value);
                selectedDeskIds.Add(CurrentDeskID);
            }
            string inClause = string.Join(",", selectedDeskIds); // Build the IN clause for the SQL query.

            using (SqlConnection sqlCon = new SqlConnection(connectionString))  //show all restrictions for selected tabels within IN clause
            {
                sqlCon.Open();
                SqlDataAdapter selectedDesksRestrictions = new SqlDataAdapter("SELECT D.DeskID, R.RestrictionID, R.StartTime, R.EndTime FROM Desks AS D JOIN RestrictionOnDesks AS ROD ON D.DeskID=ROD.DeskID JOIN Restrictions AS R ON ROD.RestrictionID=R.RestrictionID WHERE D.DeskID IN (" + inClause + ")", sqlCon); //(" + inClause + ")"
                DataTable tempDeskRestrictionsTable = new DataTable();

                selectedDesksRestrictions.Fill(tempDeskRestrictionsTable);

                ExistingRestrictionsGridView.DataSource = tempDeskRestrictionsTable;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu_Main mmm = new MainMenu_Main();
            mmm.Show();
            this.Hide();
        }
    }
}
