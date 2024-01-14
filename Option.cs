namespace hostelproject
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form1 fs = new Form1();
            fs.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form1 fs = new Form1();
            fs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //int[] targetColor = { 255, 255, 255 };
        //int[] fadeRd = new int[3];
        private void timer1_Tick(object sender, EventArgs e)
        {
            //fadein();
            //fadeout();
        }
        //void fadeout()
        //{
        //    fadeRd[0] = label1.ForeColor.R;
        //    fadeRd[1] = label1.ForeColor.G;
        //    fadeRd[2] = label1.ForeColor.B;
        //    if (fadeRd[0] > this.BackColor.R)
        //        fadeRd[0]--;
        //    else if (fadeRd[0] < this.BackColor.R)
        //        fadeRd[0]++;
        //    if (fadeRd[1] > this.BackColor.G)
        //        fadeRd[1]--;
        //    else if (fadeRd[1] < this.BackColor.G)
        //        fadeRd[1]++;
        //    if (fadeRd[2] > this.BackColor.B)
        //        fadeRd[2]--;
        //    else if (fadeRd[2] < this.BackColor.B)
        //        fadeRd[2]++;

        //    if (fadeRd[0] == this.BackColor.R || fadeRd[1] == this.BackColor.G || fadeRd[2] == this.BackColor.B)
        //        timer1.Stop();

        //    label1.ForeColor = Color.FromArgb(fadeRd[0], fadeRd[1], fadeRd[2]);


        //}
        //void fadein()
        //{
        //    fadeRd[0] = label1.ForeColor.R;
        //    fadeRd[1] = label1.ForeColor.G;
        //    fadeRd[2] = label1.ForeColor.B;
        //    if (fadeRd[0] > targetColor[0])
        //        fadeRd[0]--;
        //    else if (fadeRd[0] < targetColor[0])
        //        fadeRd[0]++;
        //    if (fadeRd[1] > targetColor[1])
        //        fadeRd[1]--;
        //    else if (fadeRd[1] < targetColor[1])
        //        fadeRd[1]++;
        //    if (fadeRd[2] > targetColor[2])
        //        fadeRd[2]--;
        //    else if (fadeRd[2] < targetColor[2])
        //        fadeRd[2]++;

        //    if (fadeRd[0] == targetColor[0] || fadeRd[1] == targetColor[1] || fadeRd[2] == targetColor[2])
        //        timer1.Stop();

        //    label1.ForeColor = Color.FromArgb(fadeRd[0], fadeRd[1], fadeRd[2]);


        //}

        private void Option_Load(object sender, EventArgs e)
        {
            //label1.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
        }
    }
}
