namespace hostelproject
{
    partial class Act
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
            buttoncustom3 = new Buttoncustom();
            btnsent = new Buttoncustom();
            panel2 = new Panel();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            buttoncustom5 = new Buttoncustom();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttoncustom3
            // 
            buttoncustom3.BackColor = Color.CornflowerBlue;
            buttoncustom3.BorderColor = Color.Black;
            buttoncustom3.BorderRadius = 40;
            buttoncustom3.BorderSize = 0;
            buttoncustom3.FlatAppearance.BorderSize = 0;
            buttoncustom3.FlatStyle = FlatStyle.Flat;
            buttoncustom3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncustom3.ForeColor = Color.White;
            buttoncustom3.Location = new Point(952, 95);
            buttoncustom3.Name = "buttoncustom3";
            buttoncustom3.Size = new Size(133, 38);
            buttoncustom3.TabIndex = 79;
            buttoncustom3.Text = "SEARCH";
            buttoncustom3.UseVisualStyleBackColor = false;
            buttoncustom3.Click += buttoncustom3_Click;
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
            btnsent.Location = new Point(1107, 95);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(133, 38);
            btnsent.TabIndex = 78;
            btnsent.Text = "LEAVE";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(72, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 77;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(91, 75);
            label14.Name = "label14";
            label14.Size = new Size(208, 29);
            label14.TabIndex = 80;
            label14.Text = "Activity Calender";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1175, 373);
            dataGridView1.TabIndex = 81;
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
            buttoncustom5.Location = new Point(1133, 531);
            buttoncustom5.Name = "buttoncustom5";
            buttoncustom5.Size = new Size(107, 33);
            buttoncustom5.TabIndex = 82;
            buttoncustom5.Text = "SH";
            buttoncustom5.UseVisualStyleBackColor = false;
            buttoncustom5.Click += buttoncustom5_Click;
            // 
            // Act
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 594);
            Controls.Add(buttoncustom5);
            Controls.Add(dataGridView1);
            Controls.Add(label14);
            Controls.Add(buttoncustom3);
            Controls.Add(btnsent);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Act";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Act";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Buttoncustom buttoncustom3;
        private Buttoncustom btnsent;
        private Panel panel2;
        private Label label14;
        private DataGridView dataGridView1;
        private Buttoncustom buttoncustom5;
    }
}