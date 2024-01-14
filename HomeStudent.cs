using Client;

namespace hostelproject
{
    public partial class HomeStudent : Form
    {
        public HomeStudent()
        {
            InitializeComponent();
        }

        private void buttoncustom7_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 278)
            {
                panel2.Height = 68;
            }
            else
            {
                panel2.Height = 278;
            }

        }

        private void hostelproject_Load(object sender, EventArgs e)
        {
            panel2.Height = 68;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.Show();
        }

        private void buttoncustom4_Click(object sender, EventArgs e)
        {


        }

        private void buttoncustom12_Click(object sender, EventArgs e)
        {
            Fee f = new Fee();
            f.Show();
        }

        private void buttoncustom11_Click(object sender, EventArgs e)
        {
            Act ac = new Act();
            ac.Show();
        }

        private void buttoncustom10_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
        }

        private void buttoncustom9_Click(object sender, EventArgs e)
        {
            Complaints cp = new Complaints();
            cp.Show();
        }

        private void buttoncustom8_Click(object sender, EventArgs e)
        {
            menudis m = new menudis();
            m.Show();
        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            RoomAlloted ra = new RoomAlloted();
            ra.Show();
        }

        private void buttoncustom2_Click_1(object sender, EventArgs e)
        {
            Chatstudent cs = new Chatstudent();
            cs.Show();
        }
    }
}
