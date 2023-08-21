using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Data.SqlClient;

namespace CheckCasher
{
    class CustUtil
    {
       
        public static void loadCustomersPhone(String[] cols, DataTable t, string phone)
        {
            DbDataReader rdr = DB.getInstance().ExecuteQuery(
                "select company,phone,fname,lname,street1,city,state,zip from customers where phone='"+phone+"' order by company asc");
            t.Rows.Clear();
            while (rdr.Read())
            {

                DataRow r = t.NewRow();
                for (int i = 0; i < cols.Length; i++)
                {
                    string val = rdr.GetValue(i).ToString();
                    r[cols[i]] = val;
                }
                t.Rows.Add(r);
            }
            rdr.Close();
            DB.getInstance().close();
        }
        public static void loadCustomers(String[] cols, DataTable t)
        {
            DbDataReader rdr = DB.getInstance().ExecuteQuery(
                "select id,phone,fname,lname,street1,city,state,zip from customers order by id asc");
            t.Rows.Clear();
            while (rdr.Read())
            {

                DataRow r = t.NewRow();
                for (int i = 0; i < cols.Length; i++)
                {
                    string val = rdr.GetValue(i).ToString();                    
                    r[cols[i]] = val;                    
                }
                t.Rows.Add(r);
            }
            rdr.Close();
            DB.getInstance().close();
        }

        public static void loadCustomersFilter(String[] cols, DataTable t, String city)
        {
            DbDataReader rdr = DB.getInstance().ExecuteQuery(
                "select company,phone,fname,lname,street1,city,state,zip from customers where city='"+city+"' order by company asc");
            t.Rows.Clear();
            while (rdr.Read())
            {

                DataRow r = t.NewRow();
                for (int i = 0; i < cols.Length; i++)
                {
                    string val = rdr.GetValue(i).ToString();
                    r[cols[i]] = val;
                }
                t.Rows.Add(r);
            }
            rdr.Close();
            DB.getInstance().close();
        }

        public static void loadTxn(String[] cols, DataTable t, string custId)
        {
            DbDataReader rdr = DB.getInstance().ExecuteQuery(
                "select last_updated,txid,customer,amount,routing,account,checkno,bank from txn where customer='"+custId+"' order by last_updated desc");
            t.Rows.Clear();
            while (rdr.Read())
            {

                DataRow r = t.NewRow();
                for (int i = 0; i < cols.Length; i++)
                {
                    string val = rdr.GetValue(i).ToString();
                    r[cols[i]] = val;
                }
                t.Rows.Add(r);
            }
            rdr.Close();
            DB.getInstance().close();
        }

        public static BitmapImage GetImage(DbDataReader _rdr, int i)
        {
            int type = DB.getInstance().getType();
            if (type == DB.MSSQL)
                return GetImageMSSQL(_rdr, i);
            else
                return GetImageMSSQLEXP(_rdr, i);
        }

       public static BitmapImage GetImageMSSQLEXP(DbDataReader _rdr, int i)
      {
          SqlDataReader rdr = (SqlDataReader)_rdr;
          //MemoryStream ms = new MemoryStream();
         // BinaryWriter bw = new BinaryWriter(ms);
          // Reset the starting byte for the new BLOB.
          //long startIndex = 0;
          //byte[] outbyte = new byte[32768];
          //int bufferSize = 32768;
        
          // Read the bytes into outbyte[] and retain the number of bytes returned.
          byte [] buf = rdr.GetSqlBinary(i).Value;
          
          //byte[] buf = ms.GetBuffer();
          //ms.Close();
          //bw.Close();
          BitmapImage img = new BitmapImage();
          img.BeginInit();        
          img.StreamSource = new MemoryStream(buf);        
          img.EndInit();
          return img;
      }


    public static BitmapImage GetImageMSSQL(DbDataReader rdr, int i)
    {
        MemoryStream ms = new MemoryStream();
        BinaryWriter bw = new BinaryWriter(ms);
        // Reset the starting byte for the new BLOB.
        long startIndex = 0;
        byte[] outbyte = new byte[32768];
        int bufferSize = 32768;
        
        // Read the bytes into outbyte[] and retain the number of bytes returned.
        long retval = rdr.GetBytes(i, startIndex, outbyte, 0, 32768);
        // Continue reading and writing while there are bytes beyond the size of the buffer.
        while (retval == bufferSize)
        {
            bw.Write(outbyte);
            bw.Flush();
            // Reposition the start index to the end of the last buffer and fill the buffer.
            startIndex += bufferSize;
            retval = rdr.GetBytes(i, startIndex, outbyte, 0, bufferSize);
        }
        // Write the remaining buffer.
        bw.Write(outbyte, 0, (int)retval);
        bw.Flush();
        byte[] buf = ms.GetBuffer();
        ms.Close();
        bw.Close();
        BitmapImage img = new BitmapImage();
        img.BeginInit();        
        img.StreamSource = new MemoryStream(buf);        
        img.EndInit();
        return img;
    }
}
}
