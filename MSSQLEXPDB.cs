using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace CheckCasher
{
    class MSSQLEXPDB : SQLDB
    {
        SqlConnection conn = null;
        //string connstr = "Datasource=" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + 
        //"\\CheckCasher.sdf;password=";

        //string connstr = "data source=owner-pc\\checkcasher;initial catalog=CheckCasher;"+
          //  "integrated security=SSPI;Trusted_Connection=Yes;persist security info=False";
        string connstr = string.Empty;

        private string getConnStr()    {
            string str = "data source="+ConfigurationManager.AppSettings.Get("ds");
            //str = str + ";User ID=" + ConfigurationManager.AppSettings.Get("user");
            //str = str + ";Password=" + ConfigurationManager.AppSettings.Get("pwd");
            str = str + ";initial catalog=" + ConfigurationManager.AppSettings.Get("ic");
            str = str + ";integrated security=" + ConfigurationManager.AppSettings.Get("is");
            str = str + ";Trusted_Connection=" + ConfigurationManager.AppSettings.Get("tc");
            str = str + ";persist security info=" + ConfigurationManager.AppSettings.Get("psi");
            //MessageBox.Show(str);
            //string cstr = "Data Source=67.80.82.197;database=checkcasher;Integrated Security=False;User Id=sa;Password=equat10n;Connect Timeout=0";
            return str;
        }

        public MSSQLEXPDB()
        {
            connstr = getConnStr();
        }



        public void close()
        {
            conn.Close();
        }

        public void connect()
        {
            if (conn == null || conn.State == ConnectionState.Broken || conn.State == ConnectionState.Closed)
            {
                conn = new SqlConnection(connstr);
                conn.Open();
            }
        }

        public int ExecuteNonQuery(string sql)
        {
            connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            int res = cmd.ExecuteNonQuery();
            close();
            return res;
        }

        public DbDataReader ExecuteQuery(string sql)
        {
            connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return rdr;
        }

        public DbDataReader GetImage(string sql)
        {
            connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader rdr = cmd.ExecuteReader();

            return rdr;
        }

        public int UpdateImage(string sql, object data, string param)
        {
            connect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter(param, data));
            int res = cmd.ExecuteNonQuery();
            close();
            return res;
        }
    }
}