using IniParser;
using IniParser.Model;
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

namespace HongmoonShop
{
    public partial class Main : Form
    {
        public static SQLmanager sqlhelper;
        string sGoodsId;
        string sItemID;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            if (!File.Exists(Database.ODBCFile))
            {
                File.Create(Database.ODBCFile);
            }
            else
            {
                IniData data = parser.ReadFile(Database.ODBCFile);
                Database.SqlIP = data["Connection"]["IP"];
                Database.SqlUser = data["Connection"]["SqlUser"];
                Database.SqlPass = data["Connection"]["SqlPass"];
            }
            StsStatusLabel.Text = "Not Connected to SQL-Server!";
        }
        private void sQLSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sql = new SQL_Settings();
            sql.Show();
        }

        private void connectToSQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parser = new FileIniDataParser();
            if (!File.Exists(Database.ODBCFile))
            {
                File.Create(Database.ODBCFile);
            }
            else
            {
                IniData data = parser.ReadFile(Database.ODBCFile);
                Database.SqlIP = data["Connection"]["IP"];
                Database.SqlUser = data["Connection"]["SqlUser"];
                Database.SqlPass = data["Connection"]["SqlPass"];
                if (!string.IsNullOrWhiteSpace(Database.SqlIP) ||
                    !string.IsNullOrWhiteSpace(Database.SqlUser) ||
                    !string.IsNullOrWhiteSpace(Database.SqlPass))
                {
                    SQLmanager sqlhelper = new SQLmanager();
                    if (!sqlhelper.OpenConnection("Master"))
                    {
                        MessageBox.Show("Could not Connect to " + Database.SqlIP, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        StsStatusLabel.Text = "Connected to " + Database.SqlIP;
                        InitConnection(sqlhelper);
                        GboxMain.Enabled = true;
                    }
                }
            }
        }
        void InitConnection(SQLmanager Connection)
        {
            sqlhelper = Connection;
        }
        private void BtnLoadItems_Click(object sender, EventArgs e)
        {
            StsStatusLabel.Text = "";
            BtnLoadItems.Text = "Reload";
            Dictionary<string, string> GoodsDisplay = new Dictionary<string, string>();
            sqlhelper.Sqlconn.ChangeDatabase("GoodsDb");
            string sqlCommand = "SELECT GoodsId, GoodsDisplayName FROM GoodsDisplay WHERE LanguageCode = 11 ORDER By GoodsId";
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                using (SqlDataReader reader = sqlhelper.GetSqlDataReader(sqlCommand))
                {
                    while (reader.Read())
                    {
                        GoodsDisplay.Add(reader["GoodsId"].ToString(), reader["GoodsDisplayName"].ToString());
                    }
                }
                if (GoodsDisplay.Count > 0)
                {
                    CboxItemList.ValueMember = "Key";
                    CboxItemList.DisplayMember = "Value";
                    CboxItemList.DataSource = new BindingSource(GoodsDisplay, null);
                    CboxItemList.Enabled = true;
                    BtnSave.Enabled = true;
                    TxbItemUpdateName.Enabled = true;
                    TxbUpdatePrice.Enabled = true;
                }
            }
            catch (SqlException ex)
            {
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StsStatusLabel.Text = "";
            if (CboxItemList.SelectedIndex == -1)
                return;
            sGoodsId = ((KeyValuePair<string, string>)CboxItemList.SelectedItem).Key;
            SelectedItemInfo(sGoodsId, CboxItemList.Text);
        }
        void SelectedItemInfo(string GoodsId, string GoodsName)
        {
            if (string.IsNullOrWhiteSpace(GoodsId))
                return;

            TxbItemUpdateName.Text = GoodsName;
            StringBuilder errorMessages = new StringBuilder();
            try
            {
                string cmd1 = string.Format("SELECT ItemId FROM GoodsItems WHERE GoodsID = {0}", sGoodsId);
                using (SqlDataReader sdrGoodsID = sqlhelper.GetSqlDataReader(cmd1))
                {
                    if (sdrGoodsID.HasRows)
                    {
                        sdrGoodsID.Read();
                        sItemID = sdrGoodsID["ItemId"].ToString();
                    }
                    else
                        return;
                }

                string cmd2 = string.Format("Select SalePrice FROM GoodsSalePricePolicies WHERE GoodsId ={0}", sGoodsId);
                using (SqlDataReader sdrSalePrice = sqlhelper.GetSqlDataReader(cmd2))
                {
                    if (sdrSalePrice.HasRows)
                    {
                        sdrSalePrice.Read();
                        TxbUpdatePrice.Text = sdrSalePrice["SalePrice"].ToString().Split(',')[0].Trim();
                        TxbUpdatePrice.Enabled = true;
                    }
                    else
                        return;
                }

            }
            catch (SqlException ex)
            {
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
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string sNewPrice = TxbUpdatePrice.Text;
            string sNewName = TxbItemUpdateName.Text.Replace("'", "''");
            string sUpdateItem = "";

            sUpdateItem += $"UPDATE Goods SET GoodsName = N'{sNewName}' WHERE GoodsID = {sGoodsId}\r\n";
            sUpdateItem += $"UPDATE GoodsDisplay SET GoodsDisplayName = N'{sNewName}' WHERE GoodsId = {sGoodsId}\r\n";
            sUpdateItem += $"UPDATE Items SET ItemName ='{sNewName}' WHERE ItemId = {sItemID}\r\n";
            sUpdateItem += $"UPDATE ItemDisplay SET ItemDisplayName = N'{sNewName}' WHERE ItemId = {sItemID} and LanguageCode = 11\r\n";
            sUpdateItem += $"UPDATE GoodsSalePricePolicies SET SalePrice ='{sNewPrice}' WHERE GoodsId = {sGoodsId}";

            int i = sqlhelper.ExecuteSqlTransaction(sUpdateItem);
            if (i > 0)
            {
                StsStatusLabel.Text = "Item Edited!";
            }
        }
    }
}
