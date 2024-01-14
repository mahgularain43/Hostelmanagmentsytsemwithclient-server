namespace hostelproject
{
    partial class menu
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
            label14 = new Label();
            panel2 = new Panel();
            buttoncustom1 = new Buttoncustom();
            buttoncustom2 = new Buttoncustom();
            buttoncustom3 = new Buttoncustom();
            buttoncustom4 = new Buttoncustom();
            btnsent = new Buttoncustom();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1263, 389);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(63, 65);
            label14.Name = "label14";
            label14.Size = new Size(142, 29);
            label14.TabIndex = 40;
            label14.Text = "Daily Menu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(63, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 41;
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
            buttoncustom1.Location = new Point(1119, 547);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(179, 41);
            buttoncustom1.TabIndex = 42;
            buttoncustom1.Text = "SHOW MONTHLY ";
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
            buttoncustom2.Location = new Point(931, 594);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(161, 41);
            buttoncustom2.TabIndex = 43;
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
            buttoncustom3.Location = new Point(1119, 597);
            buttoncustom3.Name = "buttoncustom3";
            buttoncustom3.Size = new Size(179, 41);
            buttoncustom3.TabIndex = 44;
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
            buttoncustom4.Location = new Point(931, 550);
            buttoncustom4.Name = "buttoncustom4";
            buttoncustom4.Size = new Size(161, 41);
            buttoncustom4.TabIndex = 45;
            buttoncustom4.Text = "DISPLAY";
            buttoncustom4.UseVisualStyleBackColor = false;
            buttoncustom4.Click += buttoncustom4_Click;
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
            btnsent.Location = new Point(1088, 102);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(198, 35);
            btnsent.TabIndex = 71;
            btnsent.Text = "LEAVE";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 650);
            Controls.Add(btnsent);
            Controls.Add(buttoncustom4);
            Controls.Add(buttoncustom3);
            Controls.Add(buttoncustom2);
            Controls.Add(buttoncustom1);
            Controls.Add(panel2);
            Controls.Add(label14);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu";
            Load += menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label14;
        private Panel panel2;
        private Buttoncustom buttoncustom1;
        private Buttoncustom buttoncustom2;
        private Buttoncustom buttoncustom3;
        private Buttoncustom buttoncustom4;
        private Buttoncustom btnsent;
    }
}