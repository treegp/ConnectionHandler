using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            DatabasesComboBox.Enabled = false;
            DatabasesComboBox.Items.Clear();

            var conStr = new SqlConnectionStringBuilder();
            conStr.DataSource = DataSourceTextBox.Text;
            conStr.InitialCatalog = "master";
            if (UserIdCheckBox.Checked)
            {
                conStr.IntegratedSecurity = false;
                conStr.UserID = UserIdTextBox.Text;
                conStr.Password = PasswordTextBox.Text;
            }
            else
                conStr.IntegratedSecurity=true;




            using (var con = new SqlConnection(conStr.ConnectionString))
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
    }
}
