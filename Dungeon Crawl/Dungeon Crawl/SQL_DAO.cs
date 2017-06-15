using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawl
{
    public static class SQL_DAO
    {
        public static Item getItemInfoFromDB(int id)
        {
            Item i = new Item();
            string sql = "SELECT * FROM Items WHERE ID = " + id + "";
            OleDbConnection itemDB = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Items.mdb");
            itemDB.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand();
            command.Connection = itemDB;
            command.CommandText = sql;
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                i.ItemId = reader.GetInt32(reader.GetOrdinal("ID"));
                i.ItemName = reader.GetString(reader.GetOrdinal("ItemName"));
                i.ItemType = reader.GetString(reader.GetOrdinal("Type"));
                i.ItemPower = reader.GetInt32(reader.GetOrdinal("BonusValue"));
                i.GoldValue = reader.GetInt32(reader.GetOrdinal("GoldValue"));
            }
            itemDB.Close();
            return i;
        }
        public static int getItemDBLength()
        {
            int i = 0;
            String sql = "SELECT ID FROM Items";
            OleDbConnection itemDB = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Items.mdb");
            itemDB.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand();
            command.Connection = itemDB;
            command.CommandText = sql;
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                i++;
            }
            return i;
        }
    }
}
