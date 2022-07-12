using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
            conStr.MultipleActiveResultSets = true;
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

            if (NameSpaceTextBox.Text != "" & TablesCheckedListBox.CheckedItems.Count != 0)
                GenerateButton.Enabled = true;
            else
                GenerateButton.Enabled = false;
        }

        private void NameSpaceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameSpaceTextBox.Text != "" & TablesCheckedListBox.CheckedItems.Count != 0)
                GenerateButton.Enabled = true;
            else
                GenerateButton.Enabled = false;
        }






        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var tablesColumnsItems = new List<List<ColumnItems>>();
            var folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() != DialogResult.OK)
                return;

            var folder = folderDialog.SelectedPath;

            foreach (var item in TablesCheckedListBox.CheckedItems)
            {
                tablesColumnsItems.Add(GetColumnItems(item.ToString().Split('.')[0], item.ToString().Split('.')[1]));
            }

            GenerateClassFiles(tablesColumnsItems, folder, NameSpaceTextBox.Text);
            MessageBox.Show("All done!");

        }

        private void GenerateClassFiles(List<List<ColumnItems>> tci, string savePath, string nameSpace)
        {
            foreach (List<ColumnItems> table in tci)
            {
                List<string> file = new List<string>();

                file.Add("using System;");
                file.Add("namespace " + nameSpace);
                file.Add("{");
                file.Add("    [Table(\"" + table[0].TableSchema + "\")]");
                file.Add("    public class " + table[0].TableName);
                file.Add("    {");

                foreach (var column in table)
                {
                    string conditions;

                    if (column.IsNullable) conditions = "false,"; else conditions = "true,";
                    if (column.IsComputed) conditions += "true,"; else conditions += "false,";
                    if (column.IsPrimaryKey) conditions += "true"; else conditions += "false";

                    file.Add("        [Column(" + conditions + ")]");
                    file.Add("        public "+ConvertSQLDataTypes(column.Type,column.IsNullable)+" "+column.Name+" { get; set; }");
                    file.Add("");

                }
                file.Add("    }");
                file.Add("}");


                File.WriteAllLines(savePath + "/" + table[0].TableName + ".cs"  , file.ToArray());
            }


        }



        private List<ColumnItems> GetColumnItems(string tableschema, string tablename)
        {
            List<string> primaryKeys = new List<string>();
            List<string> computedColumns = new List<string>();
            List<ColumnItems> columnsItems = new List<ColumnItems>();

            using (var con = new SqlConnection(GetConnectionString(DatabasesComboBox.SelectedItem.ToString())))
            {
                con.Open();

                var comPrimaryKey = new SqlCommand();
                comPrimaryKey.Connection = con;
                comPrimaryKey.CommandText = "select ccu.COLUMN_NAME from INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ccu inner join INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc on tc.CONSTRAINT_NAME =  ccu.CONSTRAINT_NAME where tc.CONSTRAINT_TYPE = N'PRIMARY KEY' and ccu.TABLE_SCHEMA = N'" + tableschema + "' and ccu.TABLE_NAME = N'" + tablename + "'";
                var readerPrimaryKey = comPrimaryKey.ExecuteReader();

                while (readerPrimaryKey.Read())
                {
                    primaryKeys.Add(readerPrimaryKey["COLUMN_NAME"].ToString());
                }

                var comComputed = new SqlCommand();
                comComputed.Connection = con;
                comComputed.CommandText = "select [name] from sys.all_columns where  (is_identity=1 or is_computed=1) and [object_id]=object_id(N'" + tableschema + "." + tablename + "')";
                var readerComputed = comComputed.ExecuteReader();

                while (readerComputed.Read())
                {
                    computedColumns.Add(readerComputed["name"].ToString());
                }

                var comName = new SqlCommand();
                comName.Connection = con;
                comName.CommandText = "select COLUMN_NAME,IS_NULLABLE,DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_SCHEMA=N'" + tableschema + "' AND TABLE_NAME=N'" + tablename + "'";
                var readerName = comName.ExecuteReader();

                while (readerName.Read())
                {
                    var columnItems = new ColumnItems
                    {
                        TableName = tablename,
                        TableSchema = tableschema,
                        Name = readerName["COLUMN_NAME"].ToString(),
                        Type = readerName["DATA_TYPE"].ToString(),
                        IsNullable = readerName["IS_NULLABLE"].ToString() == "YES",
                        IsPrimaryKey = primaryKeys.Contains(readerName["COLUMN_NAME"].ToString()),
                        IsComputed = computedColumns.Contains(readerName["COLUMN_NAME"].ToString())
                    };
                    columnsItems.Add(columnItems);
                }

                return columnsItems;
            }







        }

        private string ConvertSQLDataTypes(string datatype, bool isNullable)
        {
            string[] SqlServerTypes = { "bigint", "binary", "bit", "char", "date", "datetime", "datetime2", "datetimeoffset", "decimal", "filestream", "float", "geography", "geometry", "hierarchyid", "image", "int", "money", "nchar", "ntext", "numeric", "nvarchar", "real", "rowversion", "smalldatetime", "smallint", "smallmoney", "sql_variant", "text", "time", "timestamp", "tinyint", "uniqueidentifier", "varbinary", "varchar", "xml" };

            string[] CSharpTypes = { "long", "byte[]", "bool", "char", "DateTime", "DateTime", "DateTime", "DateTimeOffset", "decimal", "byte[]", "double", "Microsoft.SqlServer.Types.SqlGeography", "Microsoft.SqlServer.Types.SqlGeometry", "Microsoft.SqlServer.Types.SqlHierarchyId", "byte[]", "int", "decimal", "string", "string", "decimal", "string", "Single", "byte[]", "DateTime", "short", "decimal", "object", "string", "TimeSpan", "byte[]", "byte", "Guid", "byte[]", "string", "string" };

            var index = Array.IndexOf(SqlServerTypes, datatype);
            string type;

            if (index > -1)
                type = CSharpTypes[index];
            else
                type = "object";

            if (isNullable)
                type = "Nullable<" + type + ">";

            return type;
        }


    }

    public class ColumnItems
    {
        public string TableName { get; set; }
        public string TableSchema { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsComputed { get; set; }
        public bool IsNullable { get; set; }
    }
}
