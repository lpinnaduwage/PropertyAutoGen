using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace propertyAutoGen.DAL
{
    public class SQLUtil
    {
        public static SqlDataReader GetDatabases(String cmdText)
        {
            SqlConnection con = new SqlConnection("Server=ADMIN-PC\\SQLEXPRESS;Database=master;Trusted_connection=true");
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = cmdText;

            return cmd.ExecuteReader();
        }


        public SqlDataReader GetData(String databaseName , String cmdText)//Gets Data of the selected Database
        {
            SqlConnection con = new SqlConnection("Server=ADMIN-PC\\SQLEXPRESS;Database=" + databaseName + ";Trusted_connection=true");
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = cmdText;

            return cmd.ExecuteReader(CommandBehavior.KeyInfo);
        }
    }
}
