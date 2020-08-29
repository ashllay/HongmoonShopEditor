using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HongmoonShop
{
    public static class Database
    {
        public static string SqlIP, SqlUser, SqlPass;
        public static string ODBCFile = @"ODBC.ini";
        public static string GetConnection(string databaseName)
        {
            return string.Concat(new string[]
            {
                "server=",SqlIP,";uid=",SqlUser,";pwd=",SqlPass,";database=",databaseName
            });
        }
    }

    public class SQLmanager
    {
        public SqlConnection Sqlconn;
        public SqlCommand Sqlcmd;
        public bool OpenConnection(string database)
        {
            bool Conn;
            StringBuilder errorMessages = new StringBuilder();
            Sqlconn = new SqlConnection
            {
                ConnectionString = Database.GetConnection(database)
            };
            try
            {
                Sqlconn.Open();
                Conn = true;
            }
            catch (SqlException ex)
            {//https://docs.microsoft.com/pt-br/dotnet/api/system.data.sqlclient.sqlexception?view=dotnet-plat-ext-3.1
                Conn = false;
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Message: " + ex.Errors[i].Message + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n");
                }
                MessageBox.Show(errorMessages.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Conn;
        }
        public void CloseConnect()
        {
            if (Sqlconn.State == ConnectionState.Open)
                Sqlconn.Close();
        }
        public SqlDataReader GetSqlDataReader(string sqlstr)
        {
            SqlCommand sqlcommand = new SqlCommand
            {
                Connection = Sqlconn,
                CommandText = sqlstr
            };
            SqlDataReader sqlreader = sqlcommand.ExecuteReader();
            return sqlreader;
        }

        public int ExecuteSqlTransaction(string sqlstr)
        {
            StringBuilder errorMessages = new StringBuilder();

            int result = 0;

            SqlTransaction tran = Sqlconn.BeginTransaction();
            SqlCommand sqlcommand = Sqlconn.CreateCommand();
            sqlcommand.Transaction = tran;
            try
            {
                sqlcommand.CommandText = sqlstr;
                result = sqlcommand.ExecuteNonQuery();
                tran.Commit();
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append(//"Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        //"LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n"// +
                        /*"Procedure: " + ex.Errors[i].Procedure + "\n"*/);
                }
                MessageBox.Show(errorMessages.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //finally
            //{
            //    Sqlconn.Close();
            //    Sqlconn.Dispose();
            //}
            return result;
        }
    }
}
