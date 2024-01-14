namespace Server
{
    partial class ChatServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatServer));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            startButton = new Button();
            portLabel = new Label();
            localaddrLabel = new Label();
            portTextBox = new TextBox();
            logTextBox = new TextBox();
            clearButton = new Button();
            disconnectButton = new Button();
            sendTextBox = new TextBox();
            sendLabel = new Label();
            logLabel = new Label();
            clientsDataGridView = new DataGridView();
            identifier = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            dc = new DataGridViewButtonColumn();
            totalLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            keyTextBox = new TextBox();
            keyLabel = new Label();
            addrTextBox = new TextBox();
            versionLabel = new Label();
            checkBox = new CheckBox();
            btnleave = new Button();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            resources.ApplyResources(startButton, "startButton");
            startButton.BackColor = Color.RoyalBlue;
            startButton.ForeColor = SystemColors.ControlLightLight;
            startButton.Name = "startButton";
            startButton.TabStop = false;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartButton_Click;
            // 
            // portLabel
            // 
            resources.ApplyResources(portLabel, "portLabel");
            portLabel.BackColor = Color.Transparent;
            portLabel.ForeColor = Color.RoyalBlue;
            portLabel.Name = "portLabel";
            // 
            // localaddrLabel
            // 
            resources.ApplyResources(localaddrLabel, "localaddrLabel");
            localaddrLabel.BackColor = Color.Transparent;
            localaddrLabel.ForeColor = Color.RoyalBlue;
            localaddrLabel.Name = "localaddrLabel";
            // 
            // portTextBox
            // 
            resources.ApplyResources(portTextBox, "portTextBox");
            portTextBox.Name = "portTextBox";
            portTextBox.TabStop = false;
            // 
            // logTextBox
            // 
            resources.ApplyResources(logTextBox, "logTextBox");
            logTextBox.BackColor = SystemColors.Window;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.TabStop = false;
            // 
            // clearButton
            // 
            resources.ApplyResources(clearButton, "clearButton");
            clearButton.BackColor = Color.RoyalBlue;
            clearButton.ForeColor = SystemColors.ButtonHighlight;
            clearButton.Name = "clearButton";
            clearButton.TabStop = false;
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // disconnectButton
            // 
            resources.ApplyResources(disconnectButton, "disconnectButton");
            disconnectButton.BackColor = Color.RoyalBlue;
            disconnectButton.ForeColor = SystemColors.ControlLightLight;
            disconnectButton.Name = "disconnectButton";
            disconnectButton.TabStop = false;
            disconnectButton.UseVisualStyleBackColor = false;
            disconnectButton.Click += DisconnectButton_Click;
            // 
            // sendTextBox
            // 
            resources.ApplyResources(sendTextBox, "sendTextBox");
            sendTextBox.Name = "sendTextBox";
            sendTextBox.TabStop = false;
            sendTextBox.KeyDown += SendTextBox_KeyDown;
            // 
            // sendLabel
            // 
            resources.ApplyResources(sendLabel, "sendLabel");
            sendLabel.BackColor = Color.Transparent;
            sendLabel.ForeColor = Color.RoyalBlue;
            sendLabel.Name = "sendLabel";
            // 
            // logLabel
            // 
            resources.ApplyResources(logLabel, "logLabel");
            logLabel.BackColor = Color.Transparent;
            logLabel.ForeColor = Color.RoyalBlue;
            logLabel.Name = "logLabel";
            // 
            // clientsDataGridView
            // 
            resources.ApplyResources(clientsDataGridView, "clientsDataGridView");
            clientsDataGridView.AllowUserToAddRows = false;
            clientsDataGridView.AllowUserToDeleteRows = false;
            clientsDataGridView.AllowUserToResizeColumns = false;
            clientsDataGridView.AllowUserToResizeRows = false;
            clientsDataGridView.BackgroundColor = Color.Snow;
            clientsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            clientsDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            clientsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            clientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            clientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { identifier, name, dc });
            clientsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            clientsDataGridView.EnableHeadersVisualStyles = false;
            clientsDataGridView.MultiSelect = false;
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            clientsDataGridView.RowHeadersVisible = false;
            clientsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            clientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            clientsDataGridView.RowTemplate.Height = 24;
            clientsDataGridView.RowTemplate.ReadOnly = true;
            clientsDataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            clientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsDataGridView.ShowCellErrors = false;
            clientsDataGridView.ShowCellToolTips = false;
            clientsDataGridView.ShowEditingIcon = false;
            clientsDataGridView.ShowRowErrors = false;
            clientsDataGridView.TabStop = false;
            clientsDataGridView.CellClick += ClientsDataGridView_CellClick;
            // 
            // identifier
            // 
            identifier.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            identifier.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(identifier, "identifier");
            identifier.MaxInputLength = 20;
            identifier.Name = "identifier";
            identifier.ReadOnly = true;
            identifier.Resizable = DataGridViewTriState.False;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            name.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(name, "name");
            name.MaxInputLength = 20;
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.False;
            // 
            // dc
            // 
            dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dc.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(dc, "dc");
            dc.Name = "dc";
            dc.ReadOnly = true;
            dc.Resizable = DataGridViewTriState.False;
            dc.Text = "Kick";
            dc.UseColumnTextForButtonValue = true;
            // 
            // totalLabel
            // 
            resources.ApplyResources(totalLabel, "totalLabel");
            totalLabel.BackColor = Color.Transparent;
            totalLabel.ForeColor = Color.RoyalBlue;
            totalLabel.Name = "totalLabel";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(usernameLabel, "usernameLabel");
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.ForeColor = Color.RoyalBlue;
            usernameLabel.Name = "usernameLabel";
            // 
            // usernameTextBox
            // 
            resources.ApplyResources(usernameTextBox, "usernameTextBox");
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.TabStop = false;
            // 
            // keyTextBox
            // 
            resources.ApplyResources(keyTextBox, "keyTextBox");
            keyTextBox.Name = "keyTextBox";
            keyTextBox.TabStop = false;
            // 
            // keyLabel
            // 
            resources.ApplyResources(keyLabel, "keyLabel");
            keyLabel.BackColor = Color.Transparent;
            keyLabel.ForeColor = Color.RoyalBlue;
            keyLabel.Name = "keyLabel";
            // 
            // addrTextBox
            // 
            resources.ApplyResources(addrTextBox, "addrTextBox");
            addrTextBox.Name = "addrTextBox";
            addrTextBox.TabStop = false;
            // 
            // versionLabel
            // 
            resources.ApplyResources(versionLabel, "versionLabel");
            versionLabel.BackColor = Color.Transparent;
            versionLabel.Name = "versionLabel";
            // 
            // checkBox
            // 
            resources.ApplyResources(checkBox, "checkBox");
            checkBox.BackColor = Color.Transparent;
            checkBox.Cursor = Cursors.Hand;
            checkBox.ForeColor = Color.RoyalBlue;
            checkBox.Name = "checkBox";
            checkBox.UseVisualStyleBackColor = false;
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // btnleave
            // 
            resources.ApplyResources(btnleave, "btnleave");
            btnleave.BackColor = Color.RoyalBlue;
            btnleave.ForeColor = Color.Snow;
            btnleave.Name = "btnleave";
            btnleave.TabStop = false;
            btnleave.UseVisualStyleBackColor = false;
            btnleave.Click += btnleave_Click;
            // 
            // ChatServer
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Control;
            Controls.Add(btnleave);
            Controls.Add(checkBox);
            Controls.Add(versionLabel);
            Controls.Add(addrTextBox);
            Controls.Add(keyTextBox);
            Controls.Add(keyLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(totalLabel);
            Controls.Add(clientsDataGridView);
            Controls.Add(logLabel);
            Controls.Add(sendLabel);
            Controls.Add(sendTextBox);
            Controls.Add(disconnectButton);
            Controls.Add(clearButton);
            Controls.Add(logTextBox);
            Controls.Add(startButton);
            Controls.Add(portLabel);
            Controls.Add(localaddrLabel);
            Controls.Add(portTextBox);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "ChatServer";
            ShowIcon = false;
            FormClosing += Server_FormClosing;
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label localaddrLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn dc;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox addrTextBox;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.CheckBox checkBox;
        private Button btnleave;
    }
}

