using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace CheckCasher
{
    class MYSQLDB   : SQLDB
    {
        MySqlConnection conn = null;
        bool lcl = false;

        public MYSQLDB(bool lcl)
        {
            this.lcl = lcl;
        }

        public MYSQLDB()
        {
            this.lcl = false;
        }

        public void close()
        {
            conn.Close();
        }

        public void connect()
        {
            string MyConString;
            MyConString = "SERVER=localhost;" + "DATABASE=CheckCasher;" + "UID=root;" + "PASSWORD=;Convert Zero Datetime=true;";            
           conn = new MySqlConnection(MyConString);
           conn.Open();             
        }

        public int ExecuteNonQuery(string sql)
        {            
            connect();           
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;            
            int res = cmd.ExecuteNonQuery();
            close();
            return res;
        }

        public DbDataReader ExecuteQuery(string sql)
        {        
            connect();            
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

        public DbDataReader GetImage(string sql)
        {
            connect();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader rdr = cmd.ExecuteReader();

            return rdr;
        }

        public int UpdateImage(string sql, object data, string param)
        {
            connect();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add(new MySqlParameter(param, data));
            int res = cmd.ExecuteNonQuery();
            close();
            return res;
        }
    }
}