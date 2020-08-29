using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace HongmoonShop
{
    public partial class SQL_Settings : Form
    {
        public SQL_Settings()
        {
            InitializeComponent();
            var parser = new FileIniDataParser();
            if (!File.Exists(Database.ODBCFile))
            {
                File.Create(Database.ODBCFile);
            }
            else
            {
                IniData data = parser.ReadFile(Database.ODBCFile);
                Database.SqlIP = data["Connection"]["IP"];
                TxbSQLIP.Text = Database.SqlIP;
                Database.SqlUser = data["Connection"]["SqlUser"];
                TxbSQLuser.Text = Database.SqlUser;
                Database.SqlPass = data["Connection"]["SqlPass"];
                TxbSQLpass.Text = Database.SqlPass;
            }
        }
        private void BtnTestSQL_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            StringBuilder errorMessages = new StringBuilder();
            sqlConnection.ConnectionString = string.Concat(new string[]
            {
                "Data Source=",TxbSQLIP.Text,";Initial Catalog=Master;User ID=",TxbSQLuser.Text,";Password=",TxbSQLpass.Text
            });
            try
            {
                sqlConnection.Open();
                MessageBox.Show("Sql connection OK!", "SQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {//https://docs.microsoft.com/pt-br/dotnet/api/system.data.sqlclient.sqlexception?view=dotnet-plat-ext-3.1
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Message: " + ex.Errors[i].Message + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n");
                }
                MessageBox.Show(errorMessages.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SQL_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(Database.ODBCFile);
            Database.SqlIP = TxbSQLIP.Text;
            Database.SqlUser = TxbSQLuser.Text;
            Database.SqlPass = TxbSQLpass.Text;

            data["Connection"]["IP"] = Database.SqlIP;
            data["Connection"]["SqlUser"] = Database.SqlUser;
            data["Connection"]["SqlPass"] = Database.SqlPass;

            parser.WriteFile(Database.ODBCFile, data);
        }
    }
}
