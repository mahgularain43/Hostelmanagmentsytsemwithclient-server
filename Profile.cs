using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class Profile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");
        public Profile()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textboxcustom2__Textchanged(object sender, EventArgs e)
        {

        }

        private void textboxcustom1__Textchanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void populate()
        {
            con.Open();
            string query = "select * from Profile";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            string name = txtname.Texts;
            string email = txtemail.Texts;
            string enrollNo = txtenroll.Texts;
            string phone = txtphoneno.Texts;
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string address = txtaddress.Texts;
            string fname = txtfname.Texts;

            try
            {
                string query = "INSERT INTO Profile (name, email, enrollno, phone, address, date_of_birth, father_name ) VALUES (@name, @email, @enrollno, @phone, @address, @date_of_birth,@father_name)";


                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@enrollno", enrollNo);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                    command.Parameters.AddWithValue("@father_name", fname);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Student saved successfully!");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //fn.getdata();
            populate();
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
            //    {

            //        string message = "Please note that you are only allowed to update your email address. Are you sure you want to proceed?";

            //        DialogResult dialogResult = MessageBox.Show(message, "Update Confirmation", MessageBoxButtons.YesNo);

            //        if (dialogResult == DialogResult.Yes)
            //        {

            //            string email = txtemail.Text;
            //            string enrollNo = txtenroll.Text;
            //            con.Open();

            //            SqlCommand command = new SqlCommand("UpdateProfileEmail", con);
            //            command.CommandType = CommandType.StoredProcedure;

            //            command.Parameters.AddWithValue("@enrollno", enrollNo);
            //            command.Parameters.AddWithValue("@email", email);

            //            int rowsAffected = command.ExecuteNonQuery();

            //            if (rowsAffected > 0)
            //            {
            //                MessageBox.Show("Email updated successfully!");
            //            }
            //            else
            //            {
            //                MessageBox.Show("No student record found with the provided enrollment number.");
            //            }
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}


            try
            {
                string enrollNo = txtenroll.Texts;
                string email = txtemail.Texts;

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("UpdateProfileEmail", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@enrollno", enrollNo);
                    command.Parameters.AddWithValue("@email", email);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Email updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the provided enrollment number.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }


            populate();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



