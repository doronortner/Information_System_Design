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
using System.Windows.Forms.DataVisualization.Charting;

namespace Group11_Project
{
    public partial class dashboard : Form
    {
        // Fields
        private DateTime StartDate;
        private DateTime EndDate;
        private int NumberOfDays;
        private AllowedOccupation Occupation;

        private string connection = @"Data Source=IEMDBS;Initial Catalog=SAD_11;Integrated Security=True;";
        public List<KeyValuePair<string, int>> TheBestLecturer { get; private set; }
        public List<KeyValuePair<string, int>> TopMeetupsTopic { get; private set; }
        public List<KeyValuePair<string, int>> OccupationSortByTopic { get; private set; }

        public dashboard()
        {
            InitializeComponent();
          
            //Default - Last 30 days
            dtpStart.Value = DateTime.Today.AddDays(-30);
            dtpEnd.Value = DateTime.Now;
            this.StartDate = DateTime.Today.AddDays(-30);
            this.EndDate = DateTime.Now;
            this.NumberOfDays = (EndDate - StartDate).Days;
            btnLast30Days.Select();
            loadData();
        }




        private void loadData()  // Loads all the data from DB
        {

                NumberOfMembers();
                NumberOfMalefMembers();
                NumberOfFemaleMembers();
                NumberOfMeetups();
                AverageAge();
                GetTheBestLecturer();
                GetMeetupsTopTopics();
                GetNumberByOccupationSortByTopic();

        }


        private void NumberOfMembers()  // Presents total number of community memebers
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = @"select count (*) from ExternalEntities where Type = 'Member'";
                    SQL_CON SC = new SQL_CON();
                    SqlDataReader rdr = SC.execute_query(command);
                    List<int> result = new List<int>();
                    if (rdr.Read())
                    {
                        result.Add((int)rdr[0]);
                    }
                    lblNumTotalMember.Text = result[0].ToString();
                }
            }
        }
        private void NumberOfMalefMembers()  // Presents total number of male community memebers 
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = @" select count(*) from ExternalEntities Where Gender = 'Male'";
                    SQL_CON SC = new SQL_CON();
                    SqlDataReader rdr = SC.execute_query(command);
                    List<int> result = new List<int>();
                    if (rdr.Read())
                    {
                        result.Add((int)rdr[0]);
                    }
                    lblNumMale.Text = result[0].ToString();
                }
            }
        }

        private void NumberOfFemaleMembers() // Presents total number of female community memebers
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = @"select count(*) as counting from ExternalEntities Where Gender = 'Female' and Type = 'Member'  ";
                    SQL_CON SC = new SQL_CON();
                    SqlDataReader rdr = SC.execute_query(command);
                    List<int> result = new List<int>();
                    if (rdr.Read())
                    {
                        result.Add((int)rdr[0]);
                    }
                    lblNumFemale.Text = result[0].ToString();
                }
            }
        }

        private void NumberOfMeetups()  // Presents total number of meetups
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = @"select count (*) from dbo.Meetups";
                    SQL_CON SC = new SQL_CON();
                    SqlDataReader rdr = SC.execute_query(command);
                    List<int> result = new List<int>();
                    if (rdr.Read())
                    {
                        result.Add((int)rdr[0]);
                    }

                    lblNumMeetups.Text = result[0].ToString();
                }
            }
        }

        private void AverageAge()  // Presents the average age of the community members
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = @"select sum(CAST(Age as int))/ COUNT(PhoneNumber) from ExternalEntities";
                    SQL_CON SC = new SQL_CON();
                    SqlDataReader rdr = SC.execute_query(command);
                    List<int> result = new List<int>();
                    if (rdr.Read())
                    {
                        result.Add((int)rdr[0]);
                    }
                    
                    lblAvrAgeOfMembers.Text = result[0].ToString();
                }
            }
        }

        public void GetTheBestLecturer()  // Presents the best lecturer graph
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    List<string> xValues = new List<string>();
                    List<int> yValues = new List<int>();
                    command.Connection = conn;
                    command.CommandText = @"select LM.FullName, count (LM.MeetupID) AS numberOfLecturs 
                                            from LecturerMeetup as LM JOIN Meetups as M ON M.MeetupID = LM.MeetupID
                                            where (M.StartTime >= @S_Time AND M.EndTime <= @E_Time)
                                            group by LM.FullName";
                    command.Parameters.Add("@S_Time", System.Data.SqlDbType.DateTime).Value = this.StartDate;
                    command.Parameters.Add("@E_Time", System.Data.SqlDbType.DateTime).Value = this.EndDate;
                    SQL_CON SC = new SQL_CON();
                    SqlDataReader rdr = SC.execute_query(command);

                    while (rdr.Read())
                    {
                        xValues.Add((string)rdr[0]);
                        yValues.Add((int)rdr[1]);
                    }

                    chartTheBestLecturer.Series.Clear();
                    chartTheBestLecturer.Series.Add("Meetups");
                    chartTheBestLecturer.Series["Meetups"].ChartType = SeriesChartType.Column;
                    chartTheBestLecturer.Series["Meetups"].Points.DataBindXY(xValues, yValues);
                }
            }
        }

        public void GetMeetupsTopTopics()   // Presents the top topic of meetups accordings to date
        {
            TopMeetupsTopic = new List<KeyValuePair<string, int>>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = @"SELECT TOP 3 Topic, COUNT(MeetupID) 
                                            FROM Meetups
                                            WHERE (StartTime >= @S_Time AND EndTime <= @E_Time)
                                            GROUP BY Topic 
                                            ORDER BY COUNT(MeetupID) DESC";
                    command.Parameters.Add("@S_Time", System.Data.SqlDbType.DateTime).Value = this.StartDate;
                    command.Parameters.Add("@E_Time", System.Data.SqlDbType.DateTime).Value = this.EndDate;
                    SQL_CON SC = new SQL_CON();
                    SqlDataReader rdr = SC.execute_query(command);
                    while (rdr.Read())
                    {
                        TopMeetupsTopic.Add(new KeyValuePair<string, int>((string)rdr[0], (int)rdr[1])
                            );

                    }

                    // Add data points to the series
                    chartTop3Topics.Series.Clear();
                    chartTop3Topics.Series.Add("Topics");
                    chartTop3Topics.Series["Topics"].ChartType = SeriesChartType.Doughnut;
                    for (int i = 0; i < TopMeetupsTopic.Count; i++)
                    {
                        chartTop3Topics.Series["Topics"].Points.AddXY(TopMeetupsTopic[i].Key, TopMeetupsTopic[i].Value);
                    }
                }
            }

        }
        public void GetNumberByOccupationSortByTopic()  // Get the top topic according to member occupation
        {
            OccupationSortByTopic = new List<KeyValuePair<string, int>>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;

                    command.CommandText = @"select M.Topic, count(*)
                                            from EntitiesOccupation AS EO JOIN ExternalEntities AS EE ON EO.EntityPhone = EE.PhoneNumber
                                            JOIN EntitiesGoesToMeetup AS EEGM ON EE.PhoneNumber = EEGM.EntityPhone
                                            JOIN Meetups AS M ON M.MeetupID = EEGM.MeetupID
                                            where Occupation = @Occupation AND (StartTime >= @S_Time AND EndTime <= @E_Time)
                                            group by M.Topic";

                    command.Parameters.Add("@S_Time", System.Data.SqlDbType.DateTime).Value = this.StartDate;
                    command.Parameters.Add("@E_Time", System.Data.SqlDbType.DateTime).Value = this.EndDate;
                    command.Parameters.Add("@Occupation", SqlDbType.VarChar).Value = Occupation;

                    //cmbOccupation.DataSource = EntityOccupation;
                    SQL_CON SC = new SQL_CON();
                    SqlDataReader rdr = SC.execute_query(command);
                    while (rdr.Read())
                    {

                        OccupationSortByTopic.Add(new KeyValuePair<string, int>((string)rdr[0], (int)rdr[1])
                            );
                    }
                    // Add data points to the series
                    chartOccupationSortedByTopic.Series.Clear();
                    chartOccupationSortedByTopic.Series.Add("TopicsByOccupation");
                    chartOccupationSortedByTopic.Series["TopicsByOccupation"].ChartType = SeriesChartType.Pie;
                    for (int i = 0; i < OccupationSortByTopic.Count; i++)
                    {
                        chartOccupationSortedByTopic.Series["TopicsByOccupation"].Points.AddXY(OccupationSortByTopic[i].Key, OccupationSortByTopic[i].Value);
                    }
                }


            }
        }

       

        private void DisableCustomDates()
        {
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            btnOkCostumData.Visible = false;
        }

        private void btnCostum_Click(object sender, EventArgs e)
        {
            dtpStart.Enabled = true;
            dtpEnd.Enabled = true;
            btnOkCostumData.Visible = true;
        }

        private void btnOkCostumData_Click(object sender, EventArgs e)
        {
            this.StartDate = dtpStart.Value;
            this.EndDate = dtpEnd.Value;
            loadData();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddDays(-7);
            dtpEnd.Value = DateTime.Now;
            this.StartDate = dtpStart.Value;
            this.EndDate = dtpEnd.Value;
            btnLast7Days.Select();
            loadData();
            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today.AddDays(-30);
            dtpEnd.Value = DateTime.Now;
            this.StartDate = dtpStart.Value;
            this.EndDate = dtpEnd.Value;
            btnLast30Days.Select();
            loadData();
            DisableCustomDates();
        }

        private void cmbOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Occupation = (AllowedOccupation)Enum.Parse(typeof(AllowedOccupation), cmbOccupation.Text);
            loadData();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.AllowedOccupation' table. You can move, or remove it, as needed.
            this.allowedOccupationTableAdapter.Fill(this.sAD_11DataSet.AllowedOccupation);
            // TODO: This line of code loads data into the 'sAD_11DataSet.MeetupTopic' table. You can move, or remove it, as needed.
            this.meetupTopicTableAdapter.Fill(this.sAD_11DataSet.MeetupTopic);

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu_Main mmm = new MainMenu_Main();
            mmm.Show();
            this.Hide();
        }
    }
}

