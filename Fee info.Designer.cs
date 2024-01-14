namespace hostelproject
{
    partial class Fee_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fee_info));
            dateTimePicker1 = new DateTimePicker();
            txtPaymentId = new Textboxcustom();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            btnPrint = new Buttoncustom();
            btnReset = new Buttoncustom();
            btnGenerate = new Buttoncustom();
            txtResult = new RichTextBox();
            label2 = new Label();
            label5 = new Label();
            txtRoomNumber = new Textboxcustom();
            txtStudentName = new Textboxcustom();
            txtEnrollment = new Textboxcustom();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnsent = new Buttoncustom();
            label6 = new Label();
            buttoncustom1 = new Buttoncustom();
            panel2 = new Panel();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.HotTrack;
            dateTimePicker1.Location = new Point(228, 390);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(276, 31);
            dateTimePicker1.TabIndex = 44;
            // 
            // txtPaymentId
            // 
            txtPaymentId.BackColor = SystemColors.Control;
            txtPaymentId.BorderColor = Color.DarkBlue;
            txtPaymentId.BorderFocusColor = Color.Indigo;
            txtPaymentId.BorderRadius = 0;
            txtPaymentId.BorderSize = 3;
            txtPaymentId.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaymentId.ForeColor = Color.DimGray;
            txtPaymentId.Location = new Point(228, 149);
            txtPaymentId.Multiline = false;
            txtPaymentId.Name = "txtPaymentId";
            txtPaymentId.Padding = new Padding(10, 7, 10, 7);
            txtPaymentId.PasswordChar = false;
            txtPaymentId.PlaceholderColor = Color.White;
            txtPaymentId.PlaceholderText = "";
            txtPaymentId.Size = new Size(297, 39);
            txtPaymentId.TabIndex = 55;
            txtPaymentId.Texts = "";
            txtPaymentId.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(54, 162);
            label1.Name = "label1";
            label1.Size = new Size(130, 26);
            label1.TabIndex = 54;
            label1.Text = "Challan No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(54, 334);
            label3.Name = "label3";
            label3.Size = new Size(166, 26);
            label3.TabIndex = 58;
            label3.Text = "Room Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(54, 390);
            label4.Name = "label4";
            label4.Size = new Size(96, 26);
            label4.TabIndex = 61;
            label4.Text = "MONTH";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(766, 74);
            label8.Name = "label8";
            label8.Size = new Size(126, 28);
            label8.TabIndex = 67;
            label8.Text = "CHALLAN";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.CornflowerBlue;
            btnPrint.BorderColor = Color.Black;
            btnPrint.BorderRadius = 40;
            btnPrint.BorderSize = 0;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(401, 525);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(148, 45);
            btnPrint.TabIndex = 71;
            btnPrint.Text = "PRINT";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.CornflowerBlue;
            btnReset.BorderColor = Color.Black;
            btnReset.BorderRadius = 40;
            btnReset.BorderSize = 0;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(228, 525);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(148, 45);
            btnReset.TabIndex = 70;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.CornflowerBlue;
            btnGenerate.BorderColor = Color.Black;
            btnGenerate.BorderRadius = 40;
            btnGenerate.BorderSize = 0;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(54, 525);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(148, 45);
            btnGenerate.TabIndex = 69;
            btnGenerate.Text = "GENERATE";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(564, 117);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(496, 507);
            txtResult.TabIndex = 73;
            txtResult.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(54, 277);
            label2.Name = "label2";
            label2.Size = new Size(127, 26);
            label2.TabIndex = 74;
            label2.Text = "Enrollment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(54, 213);
            label5.Name = "label5";
            label5.Size = new Size(164, 26);
            label5.TabIndex = 75;
            label5.Text = "Student Name";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.BackColor = SystemColors.Control;
            txtRoomNumber.BorderColor = Color.DarkBlue;
            txtRoomNumber.BorderFocusColor = Color.Indigo;
            txtRoomNumber.BorderRadius = 0;
            txtRoomNumber.BorderSize = 3;
            txtRoomNumber.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomNumber.ForeColor = Color.DimGray;
            txtRoomNumber.Location = new Point(228, 321);
            txtRoomNumber.Multiline = false;
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Padding = new Padding(10, 7, 10, 7);
            txtRoomNumber.PasswordChar = false;
            txtRoomNumber.PlaceholderColor = Color.White;
            txtRoomNumber.PlaceholderText = "";
            txtRoomNumber.Size = new Size(297, 39);
            txtRoomNumber.TabIndex = 76;
            txtRoomNumber.Texts = "";
            txtRoomNumber.UnderlinedStyle = true;
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = SystemColors.Control;
            txtStudentName.BorderColor = Color.DarkBlue;
            txtStudentName.BorderFocusColor = Color.Indigo;
            txtStudentName.BorderRadius = 0;
            txtStudentName.BorderSize = 3;
            txtStudentName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentName.ForeColor = Color.DimGray;
            txtStudentName.Location = new Point(224, 200);
            txtStudentName.Multiline = false;
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Padding = new Padding(10, 7, 10, 7);
            txtStudentName.PasswordChar = false;
            txtStudentName.PlaceholderColor = Color.White;
            txtStudentName.PlaceholderText = "";
            txtStudentName.Size = new Size(297, 39);
            txtStudentName.TabIndex = 77;
            txtStudentName.Texts = "";
            txtStudentName.UnderlinedStyle = true;
            // 
            // txtEnrollment
            // 
            txtEnrollment.BackColor = SystemColors.Control;
            txtEnrollment.BorderColor = Color.DarkBlue;
            txtEnrollment.BorderFocusColor = Color.Indigo;
            txtEnrollment.BorderRadius = 0;
            txtEnrollment.BorderSize = 3;
            txtEnrollment.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnrollment.ForeColor = Color.DimGray;
            txtEnrollment.Location = new Point(224, 264);
            txtEnrollment.Multiline = false;
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Padding = new Padding(10, 7, 10, 7);
            txtEnrollment.PasswordChar = false;
            txtEnrollment.PlaceholderColor = Color.White;
            txtEnrollment.PlaceholderText = "";
            txtEnrollment.Size = new Size(297, 39);
            txtEnrollment.TabIndex = 78;
            txtEnrollment.Texts = "";
            txtEnrollment.UnderlinedStyle = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
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
            btnsent.Location = new Point(228, 578);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(148, 46);
            btnsent.TabIndex = 79;
            btnsent.Text = "LEAVE";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(1262, 74);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 80;
            label6.Text = "PAID STATUS";
            // 
            // buttoncustom1
            // 
            buttoncustom1.BackColor = Color.AliceBlue;
            buttoncustom1.BorderColor = Color.RoyalBlue;
            buttoncustom1.BorderRadius = 40;
            buttoncustom1.BorderSize = 2;
            buttoncustom1.FlatAppearance.BorderSize = 0;
            buttoncustom1.FlatStyle = FlatStyle.Flat;
            buttoncustom1.ForeColor = Color.RoyalBlue;
            buttoncustom1.Location = new Point(1449, 70);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(120, 37);
            buttoncustom1.TabIndex = 82;
            buttoncustom1.Text = "CHECK";
            buttoncustom1.UseVisualStyleBackColor = false;
            buttoncustom1.Click += buttoncustom1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(38, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 83;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(72, 37);
            label7.Name = "label7";
            label7.Size = new Size(304, 28);
            label7.TabIndex = 84;
            label7.Text = "CHALLAN MANAGEMENT";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1077, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(511, 507);
            dataGridView1.TabIndex = 85;
            // 
            // Fee_info
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 650);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(buttoncustom1);
            Controls.Add(label6);
            Controls.Add(btnsent);
            Controls.Add(txtEnrollment);
            Controls.Add(txtStudentName);
            Controls.Add(txtRoomNumber);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtResult);
            Controls.Add(btnPrint);
            Controls.Add(btnReset);
            Controls.Add(btnGenerate);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPaymentId);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fee_info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fee_info";
            Load += Fee_info_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Textboxcustom txtPaymentId;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label8;
        private Buttoncustom btnPrint;
        private Buttoncustom btnReset;
        private Buttoncustom btnGenerate;
        private RichTextBox txtResult;
        private Label label2;
        private Label label5;
        private Textboxcustom txtRoomNumber;
        private Textboxcustom txtStudentName;
        private Textboxcustom txtEnrollment;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Buttoncustom btnsent;
        private Label label6;
        private Buttoncustom buttoncustom1;
        private Panel panel2;
        private Label label7;
        private DataGridView dataGridView1;
    }
}