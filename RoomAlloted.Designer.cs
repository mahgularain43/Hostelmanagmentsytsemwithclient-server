namespace hostelproject
{
    partial class RoomAlloted
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
            label5 = new Label();
            panel2 = new Panel();
            label14 = new Label();
            btnsent = new Buttoncustom();
            buttoncustom1 = new Buttoncustom();
            txtroom = new TextBox();
            buttoncustom2 = new Buttoncustom();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1082, 443);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(33, 114);
            label5.Name = "label5";
            label5.Size = new Size(115, 26);
            label5.TabIndex = 27;
            label5.Text = "Room no.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(33, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 41;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(33, 41);
            label14.Name = "label14";
            label14.Size = new Size(277, 29);
            label14.TabIndex = 42;
            label14.Text = "ROOM ALLOTED LIST";
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
            btnsent.Location = new Point(587, 96);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(198, 35);
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
            buttoncustom1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncustom1.ForeColor = Color.White;
            buttoncustom1.Location = new Point(587, 137);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(198, 35);
            buttoncustom1.TabIndex = 72;
            buttoncustom1.Text = "DISPLAY";
            buttoncustom1.UseVisualStyleBackColor = false;
            buttoncustom1.Click += buttoncustom1_Click;
            // 
            // txtroom
            // 
            txtroom.Location = new Point(174, 109);
            txtroom.Name = "txtroom";
            txtroom.Size = new Size(182, 31);
            txtroom.TabIndex = 73;
            // 
            // buttoncustom2
            // 
            buttoncustom2.BackColor = Color.CornflowerBlue;
            buttoncustom2.BorderColor = Color.Black;
            buttoncustom2.BorderRadius = 40;
            buttoncustom2.BorderSize = 0;
            buttoncustom2.FlatAppearance.BorderSize = 0;
            buttoncustom2.FlatStyle = FlatStyle.Flat;
            buttoncustom2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncustom2.ForeColor = Color.White;
            buttoncustom2.Location = new Point(378, 109);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(156, 31);
            buttoncustom2.TabIndex = 74;
            buttoncustom2.Text = "SEARCH";
            buttoncustom2.UseVisualStyleBackColor = false;
            buttoncustom2.Click += buttoncustom2_Click;
            // 
            // RoomAlloted
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 650);
            Controls.Add(buttoncustom2);
            Controls.Add(txtroom);
            Controls.Add(buttoncustom1);
            Controls.Add(btnsent);
            Controls.Add(label14);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomAlloted";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomAvailability";
            Load += RoomAvailability_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label5;
        private Panel panel2;
        private Label label14;
        private Buttoncustom btnsent;
        private Buttoncustom buttoncustom1;
        private TextBox txtroom;
        private Buttoncustom buttoncustom2;
    }
}