namespace hostelproject
{
    partial class ComplaintsAdmin
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
            panel2 = new Panel();
            label3 = new Label();
            btnDis = new Buttoncustom();
            buttoncustom1 = new Buttoncustom();
            lbll = new Label();
            btnsent = new Buttoncustom();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1097, 369);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(38, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(60, 61);
            label3.Name = "label3";
            label3.Size = new Size(144, 29);
            label3.TabIndex = 42;
            label3.Text = "Complaints";
            // 
            // btnDis
            // 
            btnDis.BackColor = Color.CornflowerBlue;
            btnDis.BorderColor = Color.Black;
            btnDis.BorderRadius = 40;
            btnDis.BorderSize = 0;
            btnDis.FlatAppearance.BorderSize = 0;
            btnDis.FlatStyle = FlatStyle.Flat;
            btnDis.ForeColor = Color.White;
            btnDis.Location = new Point(831, 547);
            btnDis.Name = "btnDis";
            btnDis.Size = new Size(146, 45);
            btnDis.TabIndex = 43;
            btnDis.Text = "Display";
            btnDis.UseVisualStyleBackColor = false;
            btnDis.Click += btnDis_Click;
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
            buttoncustom1.Location = new Point(983, 547);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(140, 45);
            buttoncustom1.TabIndex = 44;
            buttoncustom1.Text = "UPDATE";
            buttoncustom1.UseVisualStyleBackColor = false;
            buttoncustom1.Click += buttoncustom1_Click;
            // 
            // lbll
            // 
            lbll.AutoSize = true;
            lbll.ForeColor = Color.Red;
            lbll.Location = new Point(872, 519);
            lbll.Name = "lbll";
            lbll.Size = new Size(293, 25);
            lbll.TabIndex = 45;
            lbll.Text = "*Complaint processed successfully*";
            lbll.Click += label1_Click;
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
            btnsent.Location = new Point(992, 91);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(131, 41);
            btnsent.TabIndex = 71;
            btnsent.Text = "LEAVE";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
            // 
            // ComplaintsAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 650);
            Controls.Add(btnsent);
            Controls.Add(lbll);
            Controls.Add(buttoncustom1);
            Controls.Add(btnDis);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComplaintsAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComplaintsAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label3;
        private Buttoncustom btnDis;
        private Buttoncustom buttoncustom1;
        private Label lbll;
        private Buttoncustom btnsent;
    }
}