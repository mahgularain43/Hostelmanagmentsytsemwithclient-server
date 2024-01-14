using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class SalaryEmp : Form

    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");
        public SalaryEmp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            string employee_name = txtEmployeeName.Texts;
            string position = cmbposition.SelectedItem.ToString();
            string status = cmbstatus.SelectedItem.ToString();
            string salary = txtSalary.Texts;

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("InsertEmployeeSalary", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // command.Parameters.AddWithValue("@staff_id", StaffId);
                    command.Parameters.AddWithValue("@employee_name", employee_name);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@salary", salary);


                    command.ExecuteNonQuery();

                    MessageBox.Show("Employee salary inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //fn.getdata();
            populate();
        }

        public void populate()
        {
            con.Open();
            string query = "select * from EmployeeSalary";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            populate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    int salary_id;
                    decimal new_salary;

                    if (!int.TryParse(txtsalid.Texts, out salary_id) || !decimal.TryParse(txtNewsal.Texts, out new_salary))
                    {
                        MessageBox.Show("Invalid input values. Please enter numeric values.");
                        return;
                    }
                    SqlCommand command = new SqlCommand("UpdateSalary", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@salary_id", salary_id);
                    command.Parameters.AddWithValue("@salary", new_salary);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Employee salary updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            populate();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewsal__Textchanged(object sender, EventArgs e)
        {

        }

        private void txtSalary__Textchanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

