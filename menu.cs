using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class menu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttoncustom8_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();

        }

        private void buttoncustom9_Click(object sender, EventArgs e)
        {
            Complaints cp = new Complaints();
            cp.Show();
        }

        private void buttoncustom11_Click(object sender, EventArgs e)
        {
            Actcalen ac = new Actcalen();
            ac.Show();
        }

        private void buttoncustom12_Click(object sender, EventArgs e)
        {
            SalaryEmp fe = new SalaryEmp();
            fe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }


        private string[] GenerateWeeklyMenu()
        {
            string[] menu = new string[7];

            // Generate random menu items for each day
            menu[0] = GenerateRandomMenuItem(); // Monday
            menu[1] = GenerateRandomMenuItem(); // Tuesday
            menu[2] = GenerateRandomMenuItem(); // Wednesday
            menu[3] = GenerateRandomMenuItem(); // Thursday
            menu[4] = GenerateRandomMenuItem(); // Friday
            menu[5] = GenerateRandomMenuItem(); // Saturday
            menu[6] = GenerateRandomMenuItem(); // Sunday

            return menu;
        }

        private string GenerateRandomMenuItem()
        {
            string[] menuItems = { "Chicken Curry", "Beef Stir-fry", "Pasta Carbonara", "Vegetable Curry", "Fish Tacos", "Grilled Steak", "Caesar Salad", "Sushi Rolls" };

            Random random = new Random();
            int index = random.Next(0, menuItems.Length);

            return menuItems[index];
        }

        private void populate()
        {
            string query = "SELECT * FROM WeeklyMenu";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                DateTime startDate = new DateTime(2023, 6, 1); // Start date of the month
                DateTime endDate = new DateTime(2023, 6, 30); // End date of the month

                DateTime currentDate = startDate;

                while (currentDate <= endDate)
                {
                    // Generate the menu for the current week
                    string[] menu = GenerateWeeklyMenu();

                    // Create the INSERT statement
                    string query = "INSERT INTO WeeklyMenu (MenuID, WeekStartDate, WeekEndDate, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday) " +
                                   "VALUES (@MenuID, @WeekStartDate, @WeekEndDate, @Monday, @Tuesday, @Wednesday, @Thursday, @Friday, @Saturday, @Sunday)";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@MenuID", GetNextMenuID());
                        command.Parameters.AddWithValue("@WeekStartDate", currentDate);
                        command.Parameters.AddWithValue("@WeekEndDate", currentDate.AddDays(6));
                        command.Parameters.AddWithValue("@Monday", menu[0]);
                        command.Parameters.AddWithValue("@Tuesday", menu[1]);
                        command.Parameters.AddWithValue("@Wednesday", menu[2]);
                        command.Parameters.AddWithValue("@Thursday", menu[3]);
                        command.Parameters.AddWithValue("@Friday", menu[4]);
                        command.Parameters.AddWithValue("@Saturday", menu[5]);
                        command.Parameters.AddWithValue("@Sunday", menu[6]);

                        // Execute the INSERT statement
                        command.ExecuteNonQuery();
                    }

                    // Move to the next week
                    currentDate = currentDate.AddDays(7);
                }

                MessageBox.Show("Menu for the month inserted successfully!");
            }
            catch (SqlException ex)
            {
                // Handle the SQL exception here
                MessageBox.Show("An error occurred while inserting the menu: " + ex.Message);
            }
            finally
            {
                con.Close();
                populate();
            }
        }

        private int GetNextMenuID()
        {
            string query = "SELECT MAX(MenuID) FROM WeeklyMenu";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToInt32(result) + 1;
                }
                else
                {
                    return 1;
                }
            }
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Create the SqlCommand object with the stored procedure name
                using (SqlCommand command = new SqlCommand("UpdateMenu", con))
                {
                    // Set the command type to stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameter values
                    command.Parameters.AddWithValue("@MenuID", 2); // Update with the appropriate MenuID
                    command.Parameters.AddWithValue("@Monday", "KARAHI");
                    command.Parameters.AddWithValue("@Tuesday", "FRIED RICE WITH SHASHLIK");
                    command.Parameters.AddWithValue("@Wednesday", "Updated Wednesday Menu");
                    command.Parameters.AddWithValue("@Thursday", "Updated Thursday Menu");
                    command.Parameters.AddWithValue("@Friday", "Updated Friday Menu");
                    command.Parameters.AddWithValue("@Saturday", "Updated Saturday Menu");
                    command.Parameters.AddWithValue("@Sunday", "Updated Sunday Menu");

                    // Execute the stored procedure
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Menu updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Menu not found for the specified MenuID.");
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle the SQL exception here
                MessageBox.Show("An error occurred while updating the menu: " + ex.Message);
            }
            finally
            {
                con.Close();
                populate();
            }
        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Create the SqlCommand object with the stored procedure name
                using (SqlCommand command = new SqlCommand("DeleteMenu", con))
                {
                    // Set the command type to stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // Set parameter values
                    command.Parameters.AddWithValue("@MenuID", 20); // Delete with the appropriate MenuID

                    // Execute the stored procedure
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Menu deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Menu not found for the specified MenuID.");
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle the SQL exception here
                MessageBox.Show("An error occurred while deleting the menu: " + ex.Message);
            }
            finally
            {
                con.Close();
                populate();
            }
        }

        private void buttoncustom4_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



