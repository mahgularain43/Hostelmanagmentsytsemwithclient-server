using System.Data.SqlClient;

namespace hostelproject
{
    public partial class Complaints : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public Complaints()
        {
            InitializeComponent();
        }

        private void textboxcustom6__Textchanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //public void populate()
        //{
        //    string query = "select * from Complaint";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    cmd.ExecuteNonQuery();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    SqlCommandBuilder cb = new SqlCommandBuilder(da);
        //    var ds = new DataSet();
        //    da.Fill(ds);
        //    dataGridView1.DataSource = ds.Tables[0];
        //    con.Close();
        //}


        private void btnsent_Click(object sender, EventArgs e)
        {
            lbl.Visible = false;
            string enrollID = txtenroll.Texts;
            string title = txtTitle.Texts;
            string description = txtDescription.Texts;
            DateTime dateCreated = DateTime.Now;
            string status = "Pending"; // Assuming default status is "Pending"

            try
            {
                string query = "INSERT INTO Complaint (student_id, title, description, date_created, status) " +
                               "VALUES (@student_id, @title, @description, @date_created, @status)";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();

                    command.Parameters.AddWithValue("@student_id", enrollID);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@date_created", dateCreated);
                    command.Parameters.AddWithValue("@status", status);
                    command.ExecuteNonQuery();

                    lbl.Visible = true;
                    MessageBox.Show("Complaint sent successfully!");
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//*populate(); // Assuming this function retrieves and displays the updated complaints data
