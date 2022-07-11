using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConnectionHandler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UserIdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserIdTextBox.Enabled = PasswordTextBox.Enabled = UserIdCheckBox.Checked;
            if (UserIdCheckBox.Checked)
                UserIdTextBox.Focus();
        }

        private string GetConnectionString(string dbName)
        {
            var conStr = new SqlConnectionStringBuilder();
            conStr.DataSource = DataSourceTextBox.Text;
            conStr.InitialCatalog = dbName;
            if (UserIdCheckBox.Checked)
            {
                conStr.IntegratedSecurity = false;
                conStr.UserID = UserIdTextBox.Text;
                conStr.Password = PasswordTextBox.Text;
            }
            else
                conStr.IntegratedSecurity = true;

            return conStr.ConnectionString;

        }



        private void ConnectButton_Click(object sender, EventArgs e)
        {
            DatabasesComboBox.Enabled = false;
            DatabasesComboBox.Items.Clear();

            using (var con = new SqlConnection(GetConnectionString("master")))
            {
                con.Open();
                var com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "select * from sys.databases";
                var reader = com.ExecuteReader();

                while (reader.Read())
                {
                    DatabasesComboBox.Enabled = true;
                    DatabasesComboBox.Items.Add(reader["name"]);
                }

            }
        }

        private void DatabasesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TablesCheckedListBox.Items.Clear();

            using (var con = new SqlConnection(GetConnectionString(DatabasesComboBox.SelectedItem.ToString())))
            {
                con.Open();
                var com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "select * from INFORMATION_SCHEMA.TABLES";
                var reader = com.ExecuteReader();

                while (reader.Read())
                {
                    TablesCheckedListBox.Items.Add(reader["table_schema"] + "." + reader["table_name"]);
                }

            }



        }

        private void CheckedAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckedAllCheckBox.CheckState == CheckState.Indeterminate)
                return;
            int i = TablesCheckedListBox.Items.Count;
            for (int index = 0; index < i; index++)
            {
                TablesCheckedListBox.SetItemChecked(index, CheckedAllCheckBox.Checked);
            }
         
        }

        private void TablesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedAllCheckBox.CheckState = CheckState.Indeterminate;
        }
    }
}
