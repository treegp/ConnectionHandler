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
            this.ConnectButton.Location = new System.Drawing.Point(480, 11);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Source";
            // 
            // DataSourceTextBox
            // 
            this.DataSourceTextBox.Location = new System.Drawing.Point(86, 11);
            this.DataSourceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DataSourceTextBox.Name = "DataSourceTextBox";
            this.DataSourceTextBox.Size = new System.Drawing.Size(371, 20);
            this.DataSourceTextBox.TabIndex = 0;
            // 
            // UserIdCheckBox
            // 
            this.UserIdCheckBox.AutoSize = true;
            this.UserIdCheckBox.Location = new System.Drawing.Point(20, 42);
            this.UserIdCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserIdCheckBox.Name = "UserIdCheckBox";
            this.UserIdCheckBox.Size = new System.Drawing.Size(62, 17);
            this.UserIdCheckBox.TabIndex = 1;
            this.UserIdCheckBox.Text = "User ID";
            this.UserIdCheckBox.UseVisualStyleBackColor = true;
            this.UserIdCheckBox.CheckedChanged += new System.EventHandler(this.UserIdCheckBox_CheckedChanged);
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Enabled = false;
            this.UserIdTextBox.Location = new System.Drawing.Point(86, 40);
            this.UserIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(149, 20);
            this.UserIdTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(307, 40);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(150, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // TablesCheckedListBox
            // 
            this.TablesCheckedListBox.CheckOnClick = true;
            this.TablesCheckedListBox.FormattingEnabled = true;
            this.TablesCheckedListBox.Location = new System.Drawing.Point(20, 123);
            this.TablesCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.TablesCheckedListBox.Name = "TablesCheckedListBox";
            this.TablesCheckedListBox.Size = new System.Drawing.Size(523, 304);
            this.TablesCheckedListBox.TabIndex = 5;
            this.TablesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.TablesCheckedListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Databases";
            // 
            // DatabasesComboBox
            // 
            this.DatabasesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatabasesComboBox.Enabled = false;
            this.DatabasesComboBox.FormattingEnabled = true;
            this.DatabasesComboBox.Location = new System.Drawing.Point(85, 70);
            this.DatabasesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.DatabasesComboBox.Name = "DatabasesComboBox";
            this.DatabasesComboBox.Size = new System.Drawing.Size(372, 21);
            this.DatabasesComboBox.TabIndex = 6;
            this.DatabasesComboBox.SelectedIndexChanged += new System.EventHandler(this.DatabasesComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name Space";
            // 
            // NameSpaceTextBox
            // 
            this.NameSpaceTextBox.Location = new System.Drawing.Point(93, 440);
            this.NameSpaceTextBox.Name = "NameSpaceTextBox";
            this.NameSpaceTextBox.Size = new System.Drawing.Size(364, 20);
            this.NameSpaceTextBox.TabIndex = 8;
            this.NameSpaceTextBox.TextChanged += new System.EventHandler(this.NameSpaceTextBox_TextChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Enabled = false;
            this.GenerateButton.Location = new System.Drawing.Point(480, 438);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 9;
            this.GenerateButton.Text = "Generate ...";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CheckedAllCheckBox
            // 
            this.CheckedAllCheckBox.AutoSize = true;
            this.CheckedAllCheckBox.Checked = true;
            this.CheckedAllCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.CheckedAllCheckBox.Location = new System.Drawing.Point(21, 101);
            this.CheckedAllCheckBox.Name = "CheckedAllCheckBox";
            this.CheckedAllCheckBox.Size = new System.Drawing.Size(140, 17);
            this.CheckedAllCheckBox.TabIndex = 10;
            this.CheckedAllCheckBox.Text = "Check All / Uncheck All";
            this.CheckedAllCheckBox.UseVisualStyleBackColor = true;
            this.CheckedAllCheckBox.CheckedChanged += new System.EventHandler(this.CheckedAllCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 479);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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

