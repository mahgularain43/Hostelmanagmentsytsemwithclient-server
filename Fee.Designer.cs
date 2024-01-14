namespace hostelproject
{
    partial class Fee
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
            label8 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnsent = new Buttoncustom();
            buttoncustom1 = new Buttoncustom();
            buttoncustom2 = new Buttoncustom();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(104, 54);
            label8.Name = "label8";
            label8.Size = new Size(245, 28);
            label8.TabIndex = 68;
            label8.Text = "FEE CHALLAN INFO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(786, 369);
            dataGridView1.TabIndex = 69;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(51, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 70;
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
            btnsent.Location = new Point(1340, 527);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(131, 40);
            btnsent.TabIndex = 80;
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
            buttoncustom1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncustom1.ForeColor = Color.White;
            buttoncustom1.Location = new Point(585, 521);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(126, 46);
            buttoncustom1.TabIndex = 81;
            buttoncustom1.Text = "CHECK";
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
            buttoncustom2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncustom2.ForeColor = Color.White;
            buttoncustom2.Location = new Point(728, 521);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(129, 46);
            buttoncustom2.TabIndex = 82;
            buttoncustom2.Text = "UPDATE";
            buttoncustom2.UseVisualStyleBackColor = false;
            buttoncustom2.Click += buttoncustom2_Click;
            // 
            // Fee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 644);
            Controls.Add(buttoncustom2);
            Controls.Add(buttoncustom1);
            Controls.Add(btnsent);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Buttoncustom btnsent;
        private Buttoncustom buttoncustom1;
        private Buttoncustom buttoncustom2;
    }
}