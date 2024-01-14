namespace hostelproject
{
    partial class Option
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatAppearance.MouseDownBackColor = Color.LightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(182, 404);
            button1.Name = "button1";
            button1.Size = new Size(401, 137);
            button1.TabIndex = 0;
            button1.Text = "Administrator ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatAppearance.MouseDownBackColor = Color.LightBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(790, 404);
            button2.Name = "button2";
            button2.Size = new Size(401, 137);
            button2.TabIndex = 1;
            button2.Text = "Student";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(450, 216);
            label1.Name = "label1";
            label1.Size = new Size(526, 52);
            label1.TabIndex = 2;
            label1.Text = "Bahria University Hostel ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(518, 322);
            label2.Name = "label2";
            label2.Size = new Size(319, 40);
            label2.TabIndex = 3;
            label2.Text = "Choose one option";
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Controls.Add(button3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1423, 67);
            panel4.TabIndex = 14;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(1351, 0);
            button3.Name = "button3";
            button3.Size = new Size(72, 67);
            button3.TabIndex = 14;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // Option
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1423, 713);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Option";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Option";
            Load += Option_Load;
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}