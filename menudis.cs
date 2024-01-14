using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class menudis : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");
        public menudis()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btshow_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
