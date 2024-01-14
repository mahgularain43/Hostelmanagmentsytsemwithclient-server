using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class RoomAlloted : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public RoomAlloted()
        {
            InitializeComponent();
        }

        private void RoomAvailability_Load(object sender, EventArgs e)
        {

        }
        public void populate()
        {
            con.Open();
            string query = "select * from Rooms";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
            {
                connection.Open();

                string query = @"SELECT Student.student_id, Rooms.room_id, Rooms.room_number, Rooms.occupancy_status
                     FROM Student
                     INNER JOIN Rooms ON Student.room_id = Rooms.room_id";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            string roomNumber = txtroom.Text.Trim();

            // Perform the search
            if (!string.IsNullOrEmpty(roomNumber))
            {
                // Filter the DataTable based on the room number
                DataTable filteredTable = ((DataTable)dataGridView1.DataSource).Clone();
                DataRow[] filteredRows = ((DataTable)dataGridView1.DataSource).Select($"room_number = '{roomNumber}'");

                foreach (DataRow row in filteredRows)
                {
                    filteredTable.ImportRow(row);
                }

                dataGridView1.DataSource = filteredTable;
            }
            else
            {
                // If room number is empty, show the original data
                populate();
            }
        }
    }
}
