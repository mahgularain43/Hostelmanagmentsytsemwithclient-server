namespace Client
{
    partial class Chatstudent
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
            connectButton = new Button();
            portLabel = new Label();
            localaddrLabel = new Label();
            portTextBox = new TextBox();
            logLabel = new Label();
            logTextBox = new TextBox();
            sendLabel = new Label();
            sendTextBox = new TextBox();
            clearButton = new Button();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            keyLabel = new Label();
            keyTextBox = new TextBox();
            addrTextBox = new TextBox();
            versionLabel = new Label();
            checkBox = new CheckBox();
            btnleave = new Button();
            SuspendLayout();
            // 
            // connectButton
            // 
            connectButton.BackColor = Color.RoyalBlue;
            connectButton.ForeColor = SystemColors.ButtonHighlight;
            connectButton.Location = new Point(13, 13);
            connectButton.Margin = new Padding(4);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(116, 28);
            connectButton.TabIndex = 28;
            connectButton.TabStop = false;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = false;
            connectButton.Click += ConnectButton_Click;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.ForeColor = Color.RoyalBlue;
            portLabel.Location = new Point(412, 21);
            portLabel.Margin = new Padding(8, 4, 4, 4);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(32, 15);
            portLabel.TabIndex = 27;
            portLabel.Text = "Port:";
            // 
            // localaddrLabel
            // 
            localaddrLabel.AutoSize = true;
            localaddrLabel.ForeColor = Color.RoyalBlue;
            localaddrLabel.Location = new Point(213, 18);
            localaddrLabel.Margin = new Padding(8, 4, 4, 4);
            localaddrLabel.Name = "localaddrLabel";
            localaddrLabel.Size = new Size(52, 15);
            localaddrLabel.TabIndex = 26;
            localaddrLabel.Text = "Address:";
            // 
            // portTextBox
            // 
            portTextBox.Location = new Point(449, 18);
            portTextBox.Margin = new Padding(4);
            portTextBox.MaxLength = 10;
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(132, 23);
            portTextBox.TabIndex = 25;
            portTextBox.TabStop = false;
            portTextBox.Text = "9000";
            portTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // logLabel
            // 
            logLabel.AutoSize = true;
            logLabel.ForeColor = Color.RoyalBlue;
            logLabel.Location = new Point(284, 117);
            logLabel.Margin = new Padding(8, 4, 4, 4);
            logLabel.Name = "logLabel";
            logLabel.Size = new Size(27, 15);
            logLabel.TabIndex = 31;
            logLabel.Text = "Log";
            // 
            // logTextBox
            // 
            logTextBox.BackColor = SystemColors.Window;
            logTextBox.Location = new Point(13, 138);
            logTextBox.Margin = new Padding(4);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(568, 230);
            logTextBox.TabIndex = 30;
            logTextBox.TabStop = false;
            // 
            // sendLabel
            // 
            sendLabel.AutoSize = true;
            sendLabel.ForeColor = Color.RoyalBlue;
            sendLabel.Location = new Point(8, 376);
            sendLabel.Margin = new Padding(8, 4, 4, 4);
            sendLabel.Name = "sendLabel";
            sendLabel.Size = new Size(33, 15);
            sendLabel.TabIndex = 33;
            sendLabel.Text = "Send";
            // 
            // sendTextBox
            // 
            sendTextBox.Location = new Point(16, 400);
            sendTextBox.Margin = new Padding(4);
            sendTextBox.Name = "sendTextBox";
            sendTextBox.ScrollBars = ScrollBars.Vertical;
            sendTextBox.Size = new Size(568, 23);
            sendTextBox.TabIndex = 32;
            sendTextBox.TabStop = false;
            sendTextBox.KeyDown += SendTextBox_KeyDown;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.RoyalBlue;
            clearButton.ForeColor = Color.GhostWhite;
            clearButton.Location = new Point(465, 102);
            clearButton.Margin = new Padding(4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(116, 28);
            clearButton.TabIndex = 34;
            clearButton.TabStop = false;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = Color.RoyalBlue;
            usernameLabel.Location = new Point(203, 49);
            usernameLabel.Margin = new Padding(8, 4, 4, 4);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(63, 15);
            usernameLabel.TabIndex = 36;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(269, 46);
            usernameTextBox.Margin = new Padding(4);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(132, 23);
            usernameTextBox.TabIndex = 35;
            usernameTextBox.TabStop = false;
            usernameTextBox.Text = "Client";
            usernameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.ForeColor = Color.RoyalBlue;
            keyLabel.Location = new Point(413, 49);
            keyLabel.Margin = new Padding(8, 4, 4, 4);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(29, 15);
            keyLabel.TabIndex = 38;
            keyLabel.Text = "Key:";
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(449, 46);
            keyTextBox.Margin = new Padding(4);
            keyTextBox.MaxLength = 200;
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(132, 23);
            keyTextBox.TabIndex = 37;
            keyTextBox.TabStop = false;
            keyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // addrTextBox
            // 
            addrTextBox.Location = new Point(268, 18);
            addrTextBox.Margin = new Padding(4);
            addrTextBox.MaxLength = 200;
            addrTextBox.Name = "addrTextBox";
            addrTextBox.RightToLeft = RightToLeft.Yes;
            addrTextBox.Size = new Size(132, 23);
            addrTextBox.TabIndex = 39;
            addrTextBox.TabStop = false;
            addrTextBox.Text = "127.0.0.1";
            addrTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new Point(560, 376);
            versionLabel.Margin = new Padding(8, 4, 4, 4);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(28, 15);
            versionLabel.TabIndex = 40;
            versionLabel.Text = "v1.5";
            // 
            // checkBox
            // 
            checkBox.Cursor = Cursors.Hand;
            checkBox.ForeColor = Color.RoyalBlue;
            checkBox.Location = new Point(449, 74);
            checkBox.Margin = new Padding(4);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(72, 20);
            checkBox.TabIndex = 41;
            checkBox.Text = "Hide key";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // btnleave
            // 
            btnleave.BackColor = Color.RoyalBlue;
            btnleave.ForeColor = SystemColors.ControlLightLight;
            btnleave.Location = new Point(632, 352);
            btnleave.Margin = new Padding(4);
            btnleave.Name = "btnleave";
            btnleave.Size = new Size(116, 28);
            btnleave.TabIndex = 42;
            btnleave.TabStop = false;
            btnleave.Text = "Leave";
            btnleave.UseVisualStyleBackColor = false;
            btnleave.Click += btnleave_Click;
            // 
            // Chatstudent
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(792, 433);
            Controls.Add(btnleave);
            Controls.Add(checkBox);
            Controls.Add(versionLabel);
            Controls.Add(addrTextBox);
            Controls.Add(keyLabel);
            Controls.Add(keyTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(clearButton);
            Controls.Add(sendLabel);
            Controls.Add(sendTextBox);
            Controls.Add(logLabel);
            Controls.Add(logTextBox);
            Controls.Add(connectButton);
            Controls.Add(portLabel);
            Controls.Add(localaddrLabel);
            Controls.Add(portTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Chatstudent";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            FormClosing += Client_FormClosing;
            Load += Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label localaddrLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox addrTextBox;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.CheckBox checkBox;
        private Button btnleave;
    }
}

