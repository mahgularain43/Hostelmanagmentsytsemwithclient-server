using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace hostelproject
{
    public partial class Fee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public Fee()
        {
            InitializeComponent();
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
        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    con.Open();

                    string feeIdInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the Challan No:", "Update Fee Status", "");

                    int feeId;
                    if (!int.TryParse(feeIdInput, out feeId))
                    {
                        MessageBox.Show("Invalid Fee ID. Please enter a numeric value.");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand("UpdateFeeStatusToPaid", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ChallanNo", feeId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Fee status updated to paid for Fee ID: " + feeId);
                            populate(); // Refresh the data in the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No fee record found for Fee ID: " + feeId);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle the SQL exception here
                MessageBox.Show("An error occurred while updating the fee status: " + ex.Message);
            }

        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {
            //string filePath = "C:\\Users\\Lenovo\\Desktop\\New folder\\OS\\Operating-Systems_9thEdition_WilliamStallings.pdf";



            //try
            //{
            //    StringBuilder text = new StringBuilder();

            //    using (PdfReader reader = new PdfReader(filePath))
            //    {
            //        for (int page = 1; page <= reader.NumberOfPages; page++)
            //        {
            //            text.Append(PdfTextExtractor.GetTextFromPage(reader, page));
            //        }
            //    }

            //    Console.WriteLine(text.ToString());
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("An error occurred while reading the PDF file: " + ex.Message);
            //}

            string filePath = "C:\\Users\\Lenovo\\Desktop\\New folder\\OS\\Operating-Systems_9thEdition_WilliamStallings.pdf";
            LoadPdf(filePath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadPdf(string filePath)
        {
            StringBuilder text = new StringBuilder();

            using (PdfReader reader = new PdfReader(filePath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            //textBox1.Text = text.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();

            using (PdfReader reader = new PdfReader("C:\\Users\\Lenovo\\Desktop"))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            //textBox1.Text = text.ToString();
        }
    }
}
