using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void txtuser_TextChanged(object sender, EventArgs e)
        {



        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
            {
                connection.Open();

                string username = txtuser.Text;
                string password = txtpass.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter your username and password.");
                }
                else
                {
                    string query = "SELECT COUNT(*) FROM users WHERE username = @username AND pass = @pass";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@pass", password);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Login successful!");

                        if (username == "admin")
                        {
                            this.Hide();
                            HomeAdmin ha = new HomeAdmin();
                            ha.ShowDialog(); // Use ShowDialog to make the new form modal
                        }
                        else
                        {
                            this.Hide();
                            HomeStudent hs = new HomeStudent();
                            hs.ShowDialog(); // Use ShowDialog to make the new form modal
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }



            // }
            //else
            //{
            //    MessageBox.Show("Invalid username or password!");
            //}
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
        }
    }
}
