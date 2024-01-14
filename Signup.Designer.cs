namespace hostelproject
{
    partial class Signup
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
            textboxcustom1 = new Textboxcustom();
            gradientPanel1 = new GradientPanel();
            buttoncustom2 = new Buttoncustom();
            txtcpass = new Textboxcustom();
            txtpass = new Textboxcustom();
            txtUsername = new Textboxcustom();
            txtEmail = new Textboxcustom();
            label1 = new Label();
            panel4 = new Panel();
            button2 = new Button();
            gradientPanel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // textboxcustom1
            // 
            textboxcustom1.BackColor = SystemColors.Window;
            textboxcustom1.BorderColor = Color.MediumSlateBlue;
            textboxcustom1.BorderFocusColor = Color.Indigo;
            textboxcustom1.BorderRadius = 0;
            textboxcustom1.BorderSize = 2;
            textboxcustom1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textboxcustom1.ForeColor = Color.DimGray;
            textboxcustom1.Location = new Point(581, 992);
            textboxcustom1.Multiline = false;
            textboxcustom1.Name = "textboxcustom1";
            textboxcustom1.Padding = new Padding(10, 7, 10, 7);
            textboxcustom1.PasswordChar = false;
            textboxcustom1.PlaceholderColor = Color.White;
            textboxcustom1.PlaceholderText = "";
            textboxcustom1.Size = new Size(390, 39);
            textboxcustom1.TabIndex = 2;
            textboxcustom1.Texts = "";
            textboxcustom1.UnderlinedStyle = false;
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = Color.RoyalBlue;
            gradientPanel1.Colorbottom = Color.RoyalBlue;
            gradientPanel1.Colortop = Color.RoyalBlue;
            gradientPanel1.Controls.Add(buttoncustom2);
            gradientPanel1.Controls.Add(txtcpass);
            gradientPanel1.Controls.Add(txtpass);
            gradientPanel1.Controls.Add(txtUsername);
            gradientPanel1.Controls.Add(txtEmail);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(panel4);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(581, 992);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.Paint += gradientPanel1_Paint;
            // 
            // buttoncustom2
            // 
            buttoncustom2.BackColor = Color.CornflowerBlue;
            buttoncustom2.BorderColor = Color.Black;
            buttoncustom2.BorderRadius = 40;
            buttoncustom2.BorderSize = 0;
            buttoncustom2.FlatAppearance.BorderSize = 0;
            buttoncustom2.FlatStyle = FlatStyle.Flat;
            buttoncustom2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttoncustom2.ForeColor = Color.White;
            buttoncustom2.Location = new Point(67, 684);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(419, 40);
            buttoncustom2.TabIndex = 21;
            buttoncustom2.Text = "Sign up";
            buttoncustom2.UseVisualStyleBackColor = false;
            buttoncustom2.Click += buttoncustom2_Click;
            // 
            // txtcpass
            // 
            txtcpass.BackColor = Color.RoyalBlue;
            txtcpass.BorderColor = Color.DarkBlue;
            txtcpass.BorderFocusColor = Color.Indigo;
            txtcpass.BorderRadius = 0;
            txtcpass.BorderSize = 2;
            txtcpass.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtcpass.ForeColor = Color.White;
            txtcpass.Location = new Point(67, 527);
            txtcpass.Multiline = false;
            txtcpass.Name = "txtcpass";
            txtcpass.Padding = new Padding(10, 7, 10, 7);
            txtcpass.PasswordChar = true;
            txtcpass.PlaceholderColor = Color.White;
            txtcpass.PlaceholderText = "Confirm Password ";
            txtcpass.Size = new Size(419, 40);
            txtcpass.TabIndex = 20;
            txtcpass.Texts = "";
            txtcpass.UnderlinedStyle = true;
            txtcpass._Textchanged += textboxcustom5__Textchanged;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.RoyalBlue;
            txtpass.BorderColor = Color.DarkBlue;
            txtpass.BorderFocusColor = Color.Indigo;
            txtpass.BorderRadius = 0;
            txtpass.BorderSize = 2;
            txtpass.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.ForeColor = Color.White;
            txtpass.Location = new Point(67, 425);
            txtpass.Multiline = false;
            txtpass.Name = "txtpass";
            txtpass.Padding = new Padding(10, 7, 10, 7);
            txtpass.PasswordChar = true;
            txtpass.PlaceholderColor = Color.White;
            txtpass.PlaceholderText = "Password ";
            txtpass.Size = new Size(419, 40);
            txtpass.TabIndex = 19;
            txtpass.Texts = "";
            txtpass.UnderlinedStyle = true;
            txtpass._Textchanged += textboxcustom4__Textchanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.RoyalBlue;
            txtUsername.BorderColor = Color.DarkBlue;
            txtUsername.BorderFocusColor = Color.Indigo;
            txtUsername.BorderRadius = 0;
            txtUsername.BorderSize = 2;
            txtUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(67, 325);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(10, 7, 10, 7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.White;
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(419, 40);
            txtUsername.TabIndex = 18;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = true;
            txtUsername._Textchanged += textboxcustom3__Textchanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.RoyalBlue;
            txtEmail.BorderColor = Color.DarkBlue;
            txtEmail.BorderFocusColor = Color.Indigo;
            txtEmail.BorderRadius = 0;
            txtEmail.BorderSize = 2;
            txtEmail.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(67, 245);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(10, 7, 10, 7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.White;
            txtEmail.PlaceholderText = " Email Address";
            txtEmail.Size = new Size(419, 40);
            txtEmail.TabIndex = 17;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 159);
            label1.Name = "label1";
            label1.Size = new Size(436, 40);
            label1.TabIndex = 15;
            label1.Text = "Bahria University Hostel ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Controls.Add(button2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(581, 67);
            panel4.TabIndex = 14;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(509, 0);
            button2.Name = "button2";
            button2.Size = new Size(72, 67);
            button2.TabIndex = 14;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 992);
            Controls.Add(gradientPanel1);
            Controls.Add(textboxcustom1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Textboxcustom textboxcustom1;
        private GradientPanel gradientPanel1;
        private Panel panel4;
        private Button button2;
        private Label label1;
        private Textboxcustom txtcpass;
        private Textboxcustom txtpass;
        private Textboxcustom txtUsername;
        private Textboxcustom txtEmail;
        private Buttoncustom buttoncustom2;
    }
}