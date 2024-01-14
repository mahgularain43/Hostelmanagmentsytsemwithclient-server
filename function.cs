using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True";
            return con;
        }
        public DataSet getdata(String query)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setdata(String query, String msg)
        {
            SqlConnection connection = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(msg, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
