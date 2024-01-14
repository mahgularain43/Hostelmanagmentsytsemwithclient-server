using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class Actcalen : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");
        public Actcalen()
        {
            InitializeComponent();
        }

        private void buttoncustom10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void populate()
        {
            string query = "SELECT * FROM ActivityCalendar";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private string[] GenerateWeeklyActivities()
        {
            string[] activities = new string[7];

            activities[0] = GenerateRandomActivity();
            activities[1] = GenerateRandomActivity();
            activities[2] = GenerateRandomActivity();
            activities[3] = GenerateRandomActivity();
            activities[4] = GenerateRandomActivity();
            activities[5] = GenerateRandomActivity();
            activities[6] = GenerateRandomActivity();

            return activities;
        }

        private string GenerateRandomActivity()
        {
            string[] availableActivities = new string[]
            {
        "Yoga session",
        "-----------",
        "-----------",
        "Art gallery visit",
        "------------------",
        "Gradening sessions",
        "----------------",
        "Music sessions",
        "---------------",
        "Movie night",
        "---------------",
        "Fitness class"
            };

            Random random = new Random();
            int index = random.Next(availableActivities.Length);

            return availableActivities[index];
        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    DateTime startDate = new DateTime(2023, 6, 1); // Start date of the month
                    DateTime endDate = new DateTime(2023, 6, 30); // End date of the month

                    DateTime currentDate = startDate;

                    while (currentDate <= endDate)
                    {
                        // Generate the activities for the current week
                        string[] activities = GenerateWeeklyActivities();

                        // Create the INSERT statement
                        string query = "INSERT INTO ActivityCalendar (WeekStartDate, WeekEndDate, MondayActivity, TuesdayActivity, WednesdayActivity, ThursdayActivity, FridayActivity, SaturdayActivity, SundayActivity) " +
                                       "VALUES (@WeekStartDate, @WeekEndDate, @MondayActivity, @TuesdayActivity, @WednesdayActivity, @ThursdayActivity, @FridayActivity, @SaturdayActivity, @SundayActivity)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Set parameter values
                            command.Parameters.AddWithValue("@WeekStartDate", currentDate);
                            command.Parameters.AddWithValue("@WeekEndDate", currentDate.AddDays(6));
                            command.Parameters.AddWithValue("@MondayActivity", activities[0]);
                            command.Parameters.AddWithValue("@TuesdayActivity", activities[1]);
                            command.Parameters.AddWithValue("@WednesdayActivity", activities[2]);
                            command.Parameters.AddWithValue("@ThursdayActivity", activities[3]);
                            command.Parameters.AddWithValue("@FridayActivity", activities[4]);
                            command.Parameters.AddWithValue("@SaturdayActivity", activities[5]);
                            command.Parameters.AddWithValue("@SundayActivity", activities[6]);

                            // Execute the INSERT statement
                            command.ExecuteNonQuery();
                        }

                        // Move to the next week
                        currentDate = currentDate.AddDays(7);
                    }

                    MessageBox.Show("Activity calendar for the month inserted successfully!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            populate();
        }

        private void buttoncustom4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    DateTime weekStartDate = new DateTime(2023, 6, 5); // Specify the week start date
                    string mondayActivity = "------------------------";
                    string tuesdayActivity = "Gardening";
                    string wednesdayActivity = "-----------------------";
                    string thursdayActivity = "------------------------";
                    string fridayActivity = "Movie Night";
                    string saturdayActivity = "------------------------";
                    string sundayActivity = "--------------------------";

                    SqlCommand command = new SqlCommand("UpdateActivityCalendar", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@weekStartDate", weekStartDate);
                    command.Parameters.AddWithValue("@mondayActivity", mondayActivity);
                    command.Parameters.AddWithValue("@tuesdayActivity", tuesdayActivity);
                    command.Parameters.AddWithValue("@wednesdayActivity", wednesdayActivity);
                    command.Parameters.AddWithValue("@thursdayActivity", thursdayActivity);
                    command.Parameters.AddWithValue("@fridayActivity", fridayActivity);
                    command.Parameters.AddWithValue("@saturdayActivity", saturdayActivity);
                    command.Parameters.AddWithValue("@sundayActivity", sundayActivity);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Activity Calendar updated successfully.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            populate();
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    int month = 6; // Specify the month
                    int year = 2023; // Specify the year

                    SqlCommand command = new SqlCommand("DeleteMonthActivities", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@month", month);
                    command.Parameters.AddWithValue("@year", year);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Activities for the month deleted successfully.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            populate();

        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    DateTime weekStartDate = new DateTime(2023, 6, 1); // Specify the start date of the week
                    DateTime weekEndDate = new DateTime(2023, 6, 7); // Specify the end date of the week

                    SqlCommand command = new SqlCommand("SearchEventsByWeek", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@weekStartDate", weekStartDate);
                    command.Parameters.AddWithValue("@weekEndDate", weekEndDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Events found for the specified week
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No events found for the specified week.");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void buttoncustom5_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
