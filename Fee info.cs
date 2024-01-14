using System.Data;
using System.Data.SqlClient;

namespace hostelproject
{
    public partial class Fee_info : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");
        public Fee_info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Declare a HashSet to store generated challan IDs
            HashSet<string> generatedChallanIds = new HashSet<string>();

            // Function to generate a unique challan ID
            string GenerateUniqueChallanId()
            {
                string challanId;
                do
                {
                    // Generate a random 6-digit number as a string for simplicity
                    challanId = new Random().Next(100000, 999999).ToString();
                } while (generatedChallanIds.Contains(challanId)); // Check if ID is already generated

                // Add the generated ID to the HashSet
                generatedChallanIds.Add(challanId);

                return challanId;
            }

            // Your existing code
            txtResult.Clear();

            txtResult.Text += "\n\n";
            txtResult.Text += "\t***********************************************\n";
            txtResult.Text += "\t********    BAHRIA HOSTEL KARACHI    **********\n";
            txtResult.Text += "\t***********************************************\n\n";

            txtResult.Text += "\t***********************************************\n";
            txtResult.Text += "\t*************    FEE CHALLAN    ***************\n";
            txtResult.Text += "\t***********************************************\n\n";

            txtResult.Text += "\tDate: " + DateTime.Now + "\n\n";

            // Generate a unique challan ID
            string uniqueChallanId = GenerateUniqueChallanId();
            txtResult.Text += "\tPaymentID: " + uniqueChallanId + "\n\n";

            txtResult.Text += "\tStudentName: " + txtStudentName.Texts + "\n\n";
            txtResult.Text += "\tEnrollment: " + txtEnrollment.Texts + "\n\n";
            txtResult.Text += "\tRoomNumber: " + txtRoomNumber.Texts + "\n\n";

            txtResult.Text += "\tAmount: 250000\n\n";

            txtResult.Text += "\t***********************************************";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Microsoft sans serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fee_info_Load(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            string query = "SELECT * FROM Fee";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
