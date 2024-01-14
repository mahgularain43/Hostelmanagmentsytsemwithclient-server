namespace hostelproject
{
    partial class SalaryEmp
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
            btnInsert = new Buttoncustom();
            label1 = new Label();
            btnDisplay = new Buttoncustom();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtEmployeeName = new Textboxcustom();
            txtSalary = new Textboxcustom();
            cmbposition = new ComboBox();
            cmbstatus = new ComboBox();
            btnUpdate = new Buttoncustom();
            txtNewsal = new Textboxcustom();
            label5 = new Label();
            txtsalid = new Textboxcustom();
            label7 = new Label();
            btnsent = new Buttoncustom();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(443, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(859, 351);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.CornflowerBlue;
            btnInsert.BorderColor = Color.Black;
            btnInsert.BorderRadius = 40;
            btnInsert.BorderSize = 0;
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(43, 555);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(165, 60);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(68, 41);
            label1.Name = "label1";
            label1.Size = new Size(258, 29);
            label1.TabIndex = 6;
            label1.Text = "EMPLOYEE SALARY";
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.CornflowerBlue;
            btnDisplay.BorderColor = Color.Black;
            btnDisplay.BorderRadius = 40;
            btnDisplay.BorderSize = 0;
            btnDisplay.FlatAppearance.BorderSize = 0;
            btnDisplay.FlatStyle = FlatStyle.Flat;
            btnDisplay.ForeColor = Color.White;
            btnDisplay.Location = new Point(786, 566);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(161, 49);
            btnDisplay.TabIndex = 7;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 280);
            label2.Name = "label2";
            label2.Size = new Size(80, 26);
            label2.TabIndex = 8;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 190);
            label3.Name = "label3";
            label3.Size = new Size(98, 26);
            label3.TabIndex = 9;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 105);
            label4.Name = "label4";
            label4.Size = new Size(188, 26);
            label4.TabIndex = 10;
            label4.Text = "Employee Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(34, 370);
            label6.Name = "label6";
            label6.Size = new Size(80, 26);
            label6.TabIndex = 12;
            label6.Text = "Salary";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BackColor = SystemColors.Control;
            txtEmployeeName.BorderColor = Color.DarkBlue;
            txtEmployeeName.BorderFocusColor = Color.Indigo;
            txtEmployeeName.BorderRadius = 0;
            txtEmployeeName.BorderSize = 3;
            txtEmployeeName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmployeeName.ForeColor = Color.DimGray;
            txtEmployeeName.Location = new Point(34, 137);
            txtEmployeeName.Multiline = false;
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Padding = new Padding(10, 7, 10, 7);
            txtEmployeeName.PasswordChar = false;
            txtEmployeeName.PlaceholderColor = Color.White;
            txtEmployeeName.PlaceholderText = "";
            txtEmployeeName.Size = new Size(352, 39);
            txtEmployeeName.TabIndex = 75;
            txtEmployeeName.Texts = "";
            txtEmployeeName.UnderlinedStyle = true;
            // 
            // txtSalary
            // 
            txtSalary.BackColor = SystemColors.Control;
            txtSalary.BorderColor = Color.DarkBlue;
            txtSalary.BorderFocusColor = Color.Indigo;
            txtSalary.BorderRadius = 0;
            txtSalary.BorderSize = 3;
            txtSalary.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.ForeColor = Color.DimGray;
            txtSalary.Location = new Point(34, 402);
            txtSalary.Multiline = false;
            txtSalary.Name = "txtSalary";
            txtSalary.Padding = new Padding(10, 7, 10, 7);
            txtSalary.PasswordChar = false;
            txtSalary.PlaceholderColor = Color.White;
            txtSalary.PlaceholderText = "";
            txtSalary.Size = new Size(362, 39);
            txtSalary.TabIndex = 76;
            txtSalary.Texts = "";
            txtSalary.UnderlinedStyle = true;
            txtSalary._Textchanged += txtSalary__Textchanged;
            // 
            // cmbposition
            // 
            cmbposition.FormattingEnabled = true;
            cmbposition.Items.AddRange(new object[] { "Mess Staff", "Accountant", "Cleaner", "Hostel Incharge" });
            cmbposition.Location = new Point(34, 231);
            cmbposition.Name = "cmbposition";
            cmbposition.Size = new Size(352, 33);
            cmbposition.TabIndex = 77;
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "Working", "Left" });
            cmbstatus.Location = new Point(34, 325);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(352, 33);
            cmbstatus.TabIndex = 78;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.BorderColor = Color.Black;
            btnUpdate.BorderRadius = 40;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(223, 555);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 60);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtNewsal
            // 
            txtNewsal.BackColor = SystemColors.Control;
            txtNewsal.BorderColor = Color.DarkBlue;
            txtNewsal.BorderFocusColor = Color.Indigo;
            txtNewsal.BorderRadius = 0;
            txtNewsal.BorderSize = 3;
            txtNewsal.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewsal.ForeColor = Color.DimGray;
            txtNewsal.Location = new Point(34, 479);
            txtNewsal.Multiline = false;
            txtNewsal.Name = "txtNewsal";
            txtNewsal.Padding = new Padding(10, 7, 10, 7);
            txtNewsal.PasswordChar = false;
            txtNewsal.PlaceholderColor = Color.White;
            txtNewsal.PlaceholderText = "";
            txtNewsal.Size = new Size(362, 39);
            txtNewsal.TabIndex = 81;
            txtNewsal.Texts = "";
            txtNewsal.UnderlinedStyle = true;
            txtNewsal._Textchanged += txtNewsal__Textchanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 447);
            label5.Name = "label5";
            label5.Size = new Size(176, 26);
            label5.TabIndex = 80;
            label5.Text = "Updated Salary";
            // 
            // txtsalid
            // 
            txtsalid.BackColor = SystemColors.Control;
            txtsalid.BorderColor = Color.DarkBlue;
            txtsalid.BorderFocusColor = Color.Indigo;
            txtsalid.BorderRadius = 0;
            txtsalid.BorderSize = 3;
            txtsalid.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtsalid.ForeColor = Color.DimGray;
            txtsalid.Location = new Point(452, 137);
            txtsalid.Multiline = false;
            txtsalid.Name = "txtsalid";
            txtsalid.Padding = new Padding(10, 7, 10, 7);
            txtsalid.PasswordChar = false;
            txtsalid.PlaceholderColor = Color.White;
            txtsalid.PlaceholderText = "";
            txtsalid.Size = new Size(352, 39);
            txtsalid.TabIndex = 83;
            txtsalid.Texts = "";
            txtsalid.UnderlinedStyle = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(452, 105);
            label7.Name = "label7";
            label7.Size = new Size(38, 29);
            label7.TabIndex = 82;
            label7.Text = "ID";
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
            btnsent.Location = new Point(972, 566);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(140, 49);
            btnsent.TabIndex = 84;
            btnsent.Text = "LEAVE";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(43, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 85;
            // 
            // SalaryEmp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 650);
            Controls.Add(panel2);
            Controls.Add(btnsent);
            Controls.Add(txtsalid);
            Controls.Add(label7);
            Controls.Add(txtNewsal);
            Controls.Add(label5);
            Controls.Add(btnUpdate);
            Controls.Add(cmbstatus);
            Controls.Add(cmbposition);
            Controls.Add(txtSalary);
            Controls.Add(txtEmployeeName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDisplay);
            Controls.Add(label1);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            ForeColor = Color.RoyalBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalaryEmp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feechallan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Buttoncustom btnInsert;
        private Label label1;
        private Buttoncustom btnDisplay;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Textboxcustom txtEmployeeName;
        private Textboxcustom txtSalary;
        private ComboBox cmbposition;
        private ComboBox cmbstatus;
        private Buttoncustom btnUpdate;
        private Textboxcustom txtNewsal;
        private Label label5;
        private Textboxcustom txtsalid;
        private Label label7;
        private Buttoncustom btnsent;
        private Panel panel2;
    }
}