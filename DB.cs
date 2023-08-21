using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Data.Common;
using System.Collections;


namespace CheckCasher
{
    class DB
    {
        public static int MYSQL = 0;
        public static int MSSQL = 1;
        public static int MSSQLEXP = 2;
        public static int LCL_MYSQL = 3;
        
        private SQLDB sqldb;
        private static DB db;
        private int type;


        private DB() : this(-1)
        {
        }

        private DB(int type)    {
            if (type == MSSQL)
            {
                try
                {
                    sqldb = new MSSQLDB();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.GetBaseException().Message + " " + e.GetBaseException().StackTrace);
                }
            }
            else if (type == LCL_MYSQL) sqldb = new MYSQLDB(true);
            else if (type == MSSQLEXP) sqldb = new MSSQLEXPDB();
            else sqldb = new MSSQLEXPDB();
            this.type = type;
        }

        public int getType()
        {
            return type;
        }

        public static DB getInstance()
        {
            if (db == null) db = new DB();
            return db;
        }

        public static DB getInstance(int type)
        {
            if (db == null) db = new DB(type);
            return db;
        }

        
        public String getUpdateString(Hashtable atts, string table, string where)
        {
            string str = "update " + table + " set ";
            int c = 0;
            foreach(DictionaryEntry de in atts)   {
                if(c++ == 0)
                str = str + " " + de.Key + "=" + de.Value;
                else
                    str = str + "," + de.Key + "=" + de.Value;
            }
            str = str + where;
            //MessageBox.Show(str);
            //"update customers set street1='" + _street1 + "',city='" + _city + "',state='" + _state + "',phone='" + _phone + "' where customer='" + _company + "'");
            return str;
        }

        public String getInsertString(ICollection vals, string table)
        {
            string str = "insert into "+table+" values(";
            int c = 0;
            foreach (object val in vals)
            {
                if (c++ == 0)
                    str = str + " " + val;
                else
                    str = str + "," + val;
            }
            str = str + ")";
            //MessageBox.Show(str);
            //"update customers set street1='" + _street1 + "',city='" + _city + "',state='" + _state + "',phone='" + _phone + "' where customer='" + _company + "'");
            return str;
        }

        

        public void close()
        {
            sqldb.close();
        }

        private void connect()
        {
            sqldb.connect();             
        }

        public int ExecuteNonQuery(string sql)
        {
            return sqldb.ExecuteNonQuery(sql);
        }

        public DbDataReader ExecuteQuery(string sql)
        {
            return sqldb.ExecuteQuery(sql);
        }

        public DbDataReader GetImage(string sql)
        {
            return sqldb.GetImage(sql);
        }

        public int UpdateImage(string sql, object data, string param)
        {
            return sqldb.UpdateImage(sql, data, param);
        }
    }
}