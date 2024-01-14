namespace hostelproject
{
    partial class menudis
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
            label14 = new Label();
            dataGridView1 = new DataGridView();
            btshow = new Buttoncustom();
            btnsent = new Buttoncustom();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(89, 68);
            label14.Name = "label14";
            label14.Size = new Size(142, 29);
            label14.TabIndex = 43;
            label14.Text = "Daily Menu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1243, 377);
            dataGridView1.TabIndex = 42;
            // 
            // btshow
            // 
            btshow.BackColor = Color.CornflowerBlue;
            btshow.BorderColor = Color.Black;
            btshow.BorderRadius = 40;
            btshow.BorderSize = 0;
            btshow.FlatAppearance.BorderSize = 0;
            btshow.FlatStyle = FlatStyle.Flat;
            btshow.ForeColor = Color.White;
            btshow.Location = new Point(927, 562);
            btshow.Name = "btshow";
            btshow.Size = new Size(153, 37);
            btshow.TabIndex = 44;
            btshow.Text = "CHECK";
            btshow.UseVisualStyleBackColor = false;
            btshow.Click += btshow_Click;
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
            btnsent.Location = new Point(1110, 562);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(145, 41);
            btnsent.TabIndex = 71;
            btnsent.Text = "LEAVE";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(34, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 72;
            // 
            // menudis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 650);
            Controls.Add(panel2);
            Controls.Add(btnsent);
            Controls.Add(btshow);
            Controls.Add(label14);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "menudis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menudis";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private DataGridView dataGridView1;
        private Buttoncustom btshow;
        private Buttoncustom btnsent;
        private Panel panel2;
    }
}