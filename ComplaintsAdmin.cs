using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class ComplaintsAdmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public ComplaintsAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void populate()
        {
            con.Open();
            string query = "select * from Complaint";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            try
            {
                string enrollmentNumber = Microsoft.VisualBasic.Interaction.InputBox("Enter Enrollment Number or Student ID:", "Update Complaint Status");

                if (!string.IsNullOrEmpty(enrollmentNumber))
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                    {
                        connection.Open();

                        // Check if enrollmentNumber is already updated
                        if (IsEnrollmentUpdated(enrollmentNumber))
                        {
                            MessageBox.Show("The entered enrollment number is already updated.");
                        }
                        else
                        {
                            using (SqlCommand command = new SqlCommand("UpdateComplaintStatus", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.AddWithValue("@enrollno", enrollmentNumber);
                                command.Parameters.AddWithValue("@status", "Complete");

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Complaint status updated successfully!");
                                }
                                else
                                {
                                    MessageBox.Show("No rows updated. Please check the enrollment number or student ID.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enrollment number / ID cannot be empty!");
                }

                // Assuming this function retrieves and displays the updated complaints data
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        bool IsEnrollmentUpdated(string enrollmentNumber)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Complaint WHERE student_id = @enrollno AND Status = 'Complete'", connection))
                {
                    command.Parameters.AddWithValue("@enrollno", enrollmentNumber);

                    int rowCount = (int)command.ExecuteScalar();

                    return rowCount > 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbll.Visible = false;

        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }

}

