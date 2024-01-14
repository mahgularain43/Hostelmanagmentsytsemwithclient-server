namespace hostelproject
{
    partial class HostelStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            cmbstatus = new ComboBox();
            cmbposition = new ComboBox();
            label4 = new Label();
            txtname = new Textboxcustom();
            label1 = new Label();
            txtAddress = new Textboxcustom();
            txtphone = new Textboxcustom();
            label2 = new Label();
            label3 = new Label();
            label13 = new Label();
            label5 = new Label();
            buttoncustom1 = new Buttoncustom();
            buttoncustom2 = new Buttoncustom();
            buttoncustom3 = new Buttoncustom();
            buttoncustom4 = new Buttoncustom();
            label8 = new Label();
            txtemail = new Textboxcustom();
            label6 = new Label();
            txtid = new Textboxcustom();
            label7 = new Label();
            buttoncustom5 = new Buttoncustom();
            btnsent = new Buttoncustom();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Highlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(626, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(881, 436);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "Working", "Left" });
            cmbstatus.Location = new Point(198, 432);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(173, 33);
            cmbstatus.TabIndex = 27;
            // 
            // cmbposition
            // 
            cmbposition.FormattingEnabled = true;
            cmbposition.Items.AddRange(new object[] { "Mess Staff", "Accountant", "Cleaner", "Hostel Incharge" });
            cmbposition.Location = new Point(198, 380);
            cmbposition.Name = "cmbposition";
            cmbposition.Size = new Size(173, 33);
            cmbposition.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 314);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 23;
            // 
            // txtname
            // 
            txtname.BackColor = SystemColors.Control;
            txtname.BorderColor = Color.DarkBlue;
            txtname.BorderFocusColor = Color.Indigo;
            txtname.BorderRadius = 0;
            txtname.BorderSize = 3;
            txtname.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.ForeColor = Color.DimGray;
            txtname.Location = new Point(252, 143);
            txtname.Multiline = false;
            txtname.Name = "txtname";
            txtname.Padding = new Padding(10, 7, 10, 7);
            txtname.PasswordChar = false;
            txtname.PlaceholderColor = Color.White;
            txtname.PlaceholderText = "";
            txtname.Size = new Size(297, 39);
            txtname.TabIndex = 42;
            txtname.Texts = "";
            txtname.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(65, 154);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 41;
            label1.Text = "Staff Name";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.BorderColor = Color.DarkBlue;
            txtAddress.BorderFocusColor = Color.Indigo;
            txtAddress.BorderRadius = 0;
            txtAddress.BorderSize = 3;
            txtAddress.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = Color.DimGray;
            txtAddress.Location = new Point(252, 250);
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.Padding = new Padding(10, 7, 10, 7);
            txtAddress.PasswordChar = false;
            txtAddress.PlaceholderColor = Color.White;
            txtAddress.PlaceholderText = "";
            txtAddress.Size = new Size(297, 39);
            txtAddress.TabIndex = 44;
            txtAddress.Texts = "";
            txtAddress.UnderlinedStyle = true;
            // 
            // txtphone
            // 
            txtphone.BackColor = SystemColors.Control;
            txtphone.BorderColor = Color.DarkBlue;
            txtphone.BorderFocusColor = Color.Indigo;
            txtphone.BorderRadius = 0;
            txtphone.BorderSize = 3;
            txtphone.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtphone.ForeColor = Color.DimGray;
            txtphone.Location = new Point(252, 300);
            txtphone.Multiline = false;
            txtphone.Name = "txtphone";
            txtphone.Padding = new Padding(10, 7, 10, 7);
            txtphone.PasswordChar = false;
            txtphone.PlaceholderColor = Color.White;
            txtphone.PlaceholderText = "";
            txtphone.Size = new Size(297, 39);
            txtphone.TabIndex = 46;
            txtphone.Texts = "";
            txtphone.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(65, 264);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 47;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(65, 314);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 48;
            label3.Text = "Staff Phone";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.RoyalBlue;
            label13.Location = new Point(65, 380);
            label13.Name = "label13";
            label13.Size = new Size(89, 25);
            label13.TabIndex = 49;
            label13.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(65, 432);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 50;
            label5.Text = "Status";
            // 
            // buttoncustom1
            // 
            buttoncustom1.BackColor = Color.CornflowerBlue;
            buttoncustom1.BorderColor = Color.Black;
            buttoncustom1.BorderRadius = 40;
            buttoncustom1.BorderSize = 0;
            buttoncustom1.FlatAppearance.BorderSize = 0;
            buttoncustom1.FlatStyle = FlatStyle.Flat;
            buttoncustom1.ForeColor = Color.White;
            buttoncustom1.Location = new Point(65, 503);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(148, 45);
            buttoncustom1.TabIndex = 51;
            buttoncustom1.Text = "ADD";
            buttoncustom1.UseVisualStyleBackColor = false;
            buttoncustom1.Click += buttoncustom1_Click;
            // 
            // buttoncustom2
            // 
            buttoncustom2.BackColor = Color.CornflowerBlue;
            buttoncustom2.BorderColor = Color.Black;
            buttoncustom2.BorderRadius = 40;
            buttoncustom2.BorderSize = 0;
            buttoncustom2.FlatAppearance.BorderSize = 0;
            buttoncustom2.FlatStyle = FlatStyle.Flat;
            buttoncustom2.ForeColor = Color.White;
            buttoncustom2.Location = new Point(242, 503);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(148, 45);
            buttoncustom2.TabIndex = 52;
            buttoncustom2.Text = "UPDATE";
            buttoncustom2.UseVisualStyleBackColor = false;
            buttoncustom2.Click += buttoncustom2_Click;
            // 
            // buttoncustom3
            // 
            buttoncustom3.BackColor = Color.CornflowerBlue;
            buttoncustom3.BorderColor = Color.Black;
            buttoncustom3.BorderRadius = 40;
            buttoncustom3.BorderSize = 0;
            buttoncustom3.FlatAppearance.BorderSize = 0;
            buttoncustom3.FlatStyle = FlatStyle.Flat;
            buttoncustom3.ForeColor = Color.White;
            buttoncustom3.Location = new Point(414, 503);
            buttoncustom3.Name = "buttoncustom3";
            buttoncustom3.Size = new Size(148, 45);
            buttoncustom3.TabIndex = 53;
            buttoncustom3.Text = "DELETE";
            buttoncustom3.UseVisualStyleBackColor = false;
            buttoncustom3.Click += buttoncustom3_Click;
            // 
            // buttoncustom4
            // 
            buttoncustom4.BackColor = Color.CornflowerBlue;
            buttoncustom4.BorderColor = Color.Black;
            buttoncustom4.BorderRadius = 40;
            buttoncustom4.BorderSize = 0;
            buttoncustom4.FlatAppearance.BorderSize = 0;
            buttoncustom4.FlatStyle = FlatStyle.Flat;
            buttoncustom4.ForeColor = Color.White;
            buttoncustom4.Location = new Point(555, 89);
            buttoncustom4.Name = "buttoncustom4";
            buttoncustom4.Size = new Size(109, 45);
            buttoncustom4.TabIndex = 54;
            buttoncustom4.Text = "SEARCH";
            buttoncustom4.UseVisualStyleBackColor = false;
            buttoncustom4.Click += buttoncustom4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(854, 97);
            label8.Name = "label8";
            label8.Size = new Size(201, 28);
            label8.TabIndex = 70;
            label8.Text = "EMPLOYEE LIST";
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.Control;
            txtemail.BorderColor = Color.DarkBlue;
            txtemail.BorderFocusColor = Color.Indigo;
            txtemail.BorderRadius = 0;
            txtemail.BorderSize = 3;
            txtemail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.ForeColor = Color.DimGray;
            txtemail.Location = new Point(258, 197);
            txtemail.Multiline = false;
            txtemail.Name = "txtemail";
            txtemail.Padding = new Padding(10, 7, 10, 7);
            txtemail.PasswordChar = false;
            txtemail.PlaceholderColor = Color.White;
            txtemail.PlaceholderText = "";
            txtemail.Size = new Size(297, 39);
            txtemail.TabIndex = 72;
            txtemail.Texts = "";
            txtemail.UnderlinedStyle = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(71, 208);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 71;
            label6.Text = "Email";
            // 
            // txtid
            // 
            txtid.BackColor = SystemColors.Control;
            txtid.BorderColor = Color.DarkBlue;
            txtid.BorderFocusColor = Color.Indigo;
            txtid.BorderRadius = 0;
            txtid.BorderSize = 3;
            txtid.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtid.ForeColor = Color.DimGray;
            txtid.Location = new Point(252, 97);
            txtid.Multiline = false;
            txtid.Name = "txtid";
            txtid.Padding = new Padding(10, 7, 10, 7);
            txtid.PasswordChar = false;
            txtid.PlaceholderColor = Color.White;
            txtid.PlaceholderText = "";
            txtid.Size = new Size(297, 39);
            txtid.TabIndex = 74;
            txtid.Texts = "";
            txtid.UnderlinedStyle = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(65, 100);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 73;
            label7.Text = "Staff Id";
            // 
            // buttoncustom5
            // 
            buttoncustom5.BackColor = Color.CornflowerBlue;
            buttoncustom5.BorderColor = Color.Black;
            buttoncustom5.BorderRadius = 40;
            buttoncustom5.BorderSize = 0;
            buttoncustom5.FlatAppearance.BorderSize = 0;
            buttoncustom5.FlatStyle = FlatStyle.Flat;
            buttoncustom5.ForeColor = Color.White;
            buttoncustom5.Location = new Point(144, 563);
            buttoncustom5.Name = "buttoncustom5";
            buttoncustom5.Size = new Size(148, 45);
            buttoncustom5.TabIndex = 75;
            buttoncustom5.Text = "DISPLAY";
            buttoncustom5.UseVisualStyleBackColor = false;
            buttoncustom5.Click += buttoncustom5_Click;
            // 
            // btnsent
            // 
            btnsent.BackColor = Color.CornflowerBlue;
            btnsent.BorderColor = Color.Black;
            btnsent.BorderRadius = 40;
            btnsent.BorderSize = 0;
            btnsent.FlatAppearance.BorderSize = 0;
            btnsent.FlatStyle = FlatStyle.Flat;
            btnsent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsent.ForeColor = Color.White;
            btnsent.Location = new Point(332, 564);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(156, 45);
            btnsent.TabIndex = 76;
            btnsent.Text = "LEAVE";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
            // 
            // HostelStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 650);
            Controls.Add(btnsent);
            Controls.Add(buttoncustom5);
            Controls.Add(txtid);
            Controls.Add(label7);
            Controls.Add(txtemail);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(buttoncustom4);
            Controls.Add(buttoncustom3);
            Controls.Add(buttoncustom2);
            Controls.Add(buttoncustom1);
            Controls.Add(label5);
            Controls.Add(label13);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtphone);
            Controls.Add(txtAddress);
            Controls.Add(txtname);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(cmbstatus);
            Controls.Add(cmbposition);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HostelStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HostelStaff";
            Load += HostelStaff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private ComboBox cmbstatus;
        private ComboBox cmbposition;
        private Label label4;
        private Textboxcustom txtname;
        private Label label1;
        private Textboxcustom txtAddress;
        private Textboxcustom txtphone;
        private Label label2;
        private Label label3;
        private Label label13;
        private Label label5;
        private Buttoncustom buttoncustom1;
        private Buttoncustom buttoncustom2;
        private Buttoncustom buttoncustom3;
        private Buttoncustom buttoncustom4;
        private Label label8;
        private Textboxcustom txtemail;
        private Label label6;
        private Textboxcustom txtid;
        private Label label7;
        private Buttoncustom buttoncustom5;
        private Buttoncustom btnsent;
    }
}