using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class Act : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public Act()
        {
            InitializeComponent();
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
        private void buttoncustom5_Click(object sender, EventArgs e)
        {
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

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
