namespace hostelproject
{
    partial class RoomsManagement
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
            label9 = new Label();
            label1 = new Label();
            txtRoomno = new Textboxcustom();
            btnAdd = new Buttoncustom();
            buttoncustom2 = new Buttoncustom();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            btnsent = new Buttoncustom();
            buttoncustom1 = new Buttoncustom();
            txtsrch = new TextBox();
            buttoncustom3 = new Buttoncustom();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(277, 92);
            label9.Name = "label9";
            label9.Size = new Size(175, 28);
            label9.TabIndex = 31;
            label9.Text = "INSERT ROOM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(57, 139);
            label1.Name = "label1";
            label1.Size = new Size(112, 26);
            label1.TabIndex = 32;
            label1.Text = "Room No";
            // 
            // txtRoomno
            // 
            txtRoomno.BackColor = SystemColors.Control;
            txtRoomno.BorderColor = Color.DarkBlue;
            txtRoomno.BorderFocusColor = Color.Indigo;
            txtRoomno.BorderRadius = 0;
            txtRoomno.BorderSize = 3;
            txtRoomno.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomno.ForeColor = Color.DimGray;
            txtRoomno.Location = new Point(215, 123);
            txtRoomno.Multiline = false;
            txtRoomno.Name = "txtRoomno";
            txtRoomno.Padding = new Padding(10, 7, 10, 7);
            txtRoomno.PasswordChar = false;
            txtRoomno.PlaceholderColor = Color.White;
            txtRoomno.PlaceholderText = "";
            txtRoomno.Size = new Size(297, 39);
            txtRoomno.TabIndex = 40;
            txtRoomno.Texts = "";
            txtRoomno.UnderlinedStyle = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.BorderColor = Color.Black;
            btnAdd.BorderRadius = 40;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(393, 288);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 33);
            btnAdd.TabIndex = 43;
            btnAdd.Text = "INSERT";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += buttoncustom1_Click;
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
            buttoncustom2.Location = new Point(1072, 134);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(116, 36);
            buttoncustom2.TabIndex = 47;
            buttoncustom2.Text = "SEARCH";
            buttoncustom2.UseVisualStyleBackColor = false;
            buttoncustom2.Click += buttoncustom2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(149, 404);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(968, 196);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(527, 359);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 51;
            label6.Text = "ALL ROOMS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(57, 187);
            label7.Name = "label7";
            label7.Size = new Size(133, 26);
            label7.TabIndex = 52;
            label7.Text = "Room Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Triple", "Double", "Single" });
            comboBox1.Location = new Point(215, 180);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 33);
            comboBox1.TabIndex = 53;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Vacant ", "occupied" });
            comboBox3.Location = new Point(258, 235);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(261, 33);
            comboBox3.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(47, 237);
            label2.Name = "label2";
            label2.Size = new Size(205, 26);
            label2.TabIndex = 59;
            label2.Text = "Occupancy Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(695, 136);
            label5.Name = "label5";
            label5.Size = new Size(112, 26);
            label5.TabIndex = 61;
            label5.Text = "Room No";
            // 
            // btnsent
            // 
            btnsent.BackColor = Color.CornflowerBlue;
            btnsent.BorderColor = Color.Black;
            btnsent.BorderRadius = 40;
            btnsent.BorderSize = 0;
            btnsent.FlatAppearance.BorderSize = 0;
            btnsent.FlatStyle = FlatStyle.Flat;
            btnsent.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsent.ForeColor = Color.White;
            btnsent.Location = new Point(1217, 580);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(125, 41);
            btnsent.TabIndex = 71;
            btnsent.Text = "LEAVE";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
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
            buttoncustom1.Location = new Point(393, 327);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(128, 36);
            buttoncustom1.TabIndex = 72;
            buttoncustom1.Text = "SHOW";
            buttoncustom1.UseVisualStyleBackColor = false;
            buttoncustom1.Click += buttoncustom1_Click_1;
            // 
            // txtsrch
            // 
            txtsrch.Location = new Point(847, 139);
            txtsrch.Name = "txtsrch";
            txtsrch.Size = new Size(185, 31);
            txtsrch.TabIndex = 73;
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
            buttoncustom3.Location = new Point(527, 131);
            buttoncustom3.Name = "buttoncustom3";
            buttoncustom3.Size = new Size(128, 31);
            buttoncustom3.TabIndex = 74;
            buttoncustom3.Text = "Update";
            buttoncustom3.UseVisualStyleBackColor = false;
            buttoncustom3.Click += buttoncustom3_Click;
            // 
            // RoomsManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 650);
            Controls.Add(buttoncustom3);
            Controls.Add(txtsrch);
            Controls.Add(buttoncustom1);
            Controls.Add(btnsent);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(buttoncustom2);
            Controls.Add(btnAdd);
            Controls.Add(txtRoomno);
            Controls.Add(label1);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomsManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooms";
            Load += RoomsManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Label label1;
        private Textboxcustom txtRoomno;
        private Buttoncustom btnAdd;
        private Buttoncustom buttoncustom2;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private Label label2;
        private Label label5;
        private Buttoncustom btnsent;
        private Buttoncustom buttoncustom1;
        private TextBox txtsrch;
        private Buttoncustom buttoncustom3;
    }
}