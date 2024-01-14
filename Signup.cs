using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btssignup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SIGN UP SUCCESSFULL");
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fs = new Form1();
            fs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textboxcustom3__Textchanged(object sender, EventArgs e)
        {

        }

        private void textboxcustom4__Textchanged(object sender, EventArgs e)
        {

        }

        private void textboxcustom5__Textchanged(object sender, EventArgs e)
        {

        }

        private void txtuser__Textchanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtpass.Text;
            string confirmPassword = txtcpass.Text;
            string email = txtEmail.Text;
            DateTime dateRegistered = DateTime.Now;

            // Check if the password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match!");
                return;
            }
            else

                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("InsertSignup", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@date_registered", dateRegistered);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Signup successful!");

                        // Close the current signup form
                        this.Close();

                        // Open the login form
                        Form1 loginForm = new Form1();
                        loginForm.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


