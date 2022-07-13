namespace ConnectionHandler
{
    partial class MainForm
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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSourceTextBox = new System.Windows.Forms.TextBox();
            this.UserIdCheckBox = new System.Windows.Forms.CheckBox();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.TablesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DatabasesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameSpaceTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CheckedAllCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(640, 14);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(100, 28);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Source";
            // 
            // DataSourceTextBox
            // 
            this.DataSourceTextBox.Location = new System.Drawing.Point(115, 14);
            this.DataSourceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataSourceTextBox.Name = "DataSourceTextBox";
            this.DataSourceTextBox.Size = new System.Drawing.Size(493, 22);
            this.DataSourceTextBox.TabIndex = 0;
            // 
            // UserIdCheckBox
            // 
            this.UserIdCheckBox.AutoSize = true;
            this.UserIdCheckBox.Location = new System.Drawing.Point(27, 52);
            this.UserIdCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserIdCheckBox.Name = "UserIdCheckBox";
            this.UserIdCheckBox.Size = new System.Drawing.Size(74, 20);
            this.UserIdCheckBox.TabIndex = 2;
            this.UserIdCheckBox.Text = "User ID";
            this.UserIdCheckBox.UseVisualStyleBackColor = true;
            this.UserIdCheckBox.CheckedChanged += new System.EventHandler(this.UserIdCheckBox_CheckedChanged);
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Enabled = false;
            this.UserIdTextBox.Location = new System.Drawing.Point(115, 49);
            this.UserIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(197, 22);
            this.UserIdTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(409, 49);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(199, 22);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // TablesCheckedListBox
            // 
            this.TablesCheckedListBox.CheckOnClick = true;
            this.TablesCheckedListBox.FormattingEnabled = true;
            this.TablesCheckedListBox.Location = new System.Drawing.Point(27, 151);
            this.TablesCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TablesCheckedListBox.Name = "TablesCheckedListBox";
            this.TablesCheckedListBox.Size = new System.Drawing.Size(696, 361);
            this.TablesCheckedListBox.TabIndex = 7;
            this.TablesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.TablesCheckedListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Databases";
            // 
            // DatabasesComboBox
            // 
            this.DatabasesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatabasesComboBox.Enabled = false;
            this.DatabasesComboBox.FormattingEnabled = true;
            this.DatabasesComboBox.Location = new System.Drawing.Point(113, 86);
            this.DatabasesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatabasesComboBox.Name = "DatabasesComboBox";
            this.DatabasesComboBox.Size = new System.Drawing.Size(495, 24);
            this.DatabasesComboBox.TabIndex = 5;
            this.DatabasesComboBox.SelectedIndexChanged += new System.EventHandler(this.DatabasesComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 545);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name Space";
            // 
            // NameSpaceTextBox
            // 
            this.NameSpaceTextBox.Location = new System.Drawing.Point(124, 542);
            this.NameSpaceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameSpaceTextBox.Name = "NameSpaceTextBox";
            this.NameSpaceTextBox.Size = new System.Drawing.Size(484, 22);
            this.NameSpaceTextBox.TabIndex = 8;
            this.NameSpaceTextBox.TextChanged += new System.EventHandler(this.NameSpaceTextBox_TextChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Enabled = false;
            this.GenerateButton.Location = new System.Drawing.Point(640, 539);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(100, 28);
            this.GenerateButton.TabIndex = 9;
            this.GenerateButton.Text = "Generate ...";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CheckedAllCheckBox
            // 
            this.CheckedAllCheckBox.AutoSize = true;
            this.CheckedAllCheckBox.Location = new System.Drawing.Point(28, 124);
            this.CheckedAllCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckedAllCheckBox.Name = "CheckedAllCheckBox";
            this.CheckedAllCheckBox.Size = new System.Drawing.Size(166, 20);
            this.CheckedAllCheckBox.TabIndex = 6;
            this.CheckedAllCheckBox.Text = "Check All / Uncheck All";
            this.CheckedAllCheckBox.UseVisualStyleBackColor = true;
            this.CheckedAllCheckBox.CheckedChanged += new System.EventHandler(this.CheckedAllCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 590);
            this.Controls.Add(this.CheckedAllCheckBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.NameSpaceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DatabasesComboBox);
            this.Controls.Add(this.TablesCheckedListBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.DataSourceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.UserIdCheckBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Connection Handler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DataSourceTextBox;
        private System.Windows.Forms.CheckBox UserIdCheckBox;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckedListBox TablesCheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DatabasesComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameSpaceTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox CheckedAllCheckBox;
    }
}

