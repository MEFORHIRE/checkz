using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.IO;
using System.Windows;

namespace CheckCasher
{
    class InvUtil
    {
        private static String biller = "";

        public static Invoice getInvoice(string customer, string biller)
        {
            DbDataReader rdr = DB.getInstance().ExecuteQuery("select company,street1,street2,city,state,zip,phone,s_street1,s_street2,s_city,s_state,s_zip,s_phone from customers where company='" + customer + "'");
            Customer c = new Customer();
            Customer sc = new Customer();
            int i = 0;
            string name ="";
            if (rdr.Read())
            {
                i = 0;
                name = rdr.GetString(i++);
                c.name = name;
                c.address = rdr.GetString(i++);
                string st2 = rdr.GetString(i++);
                if (st2 != null && st2.Trim().Length > 0)
                {                    
                    c.address = c.address + "\r\n" + st2;
                }
                c.city = rdr.GetString(i++);
                c.state = rdr.GetString(i++) + "-" + rdr.GetString(i++);
                c.phone = rdr.GetString(i++);

                
                sc.address = rdr.GetString(i++) + "\r\n" + rdr.GetString(i++);
                sc.city = rdr.GetString(i++);
                sc.state = rdr.GetString(i++) + " " + rdr.GetString(i++);
                sc.phone = rdr.GetString(i++);
            }
            rdr.Close();
            DB.getInstance().close();

            rdr = DB.getInstance().ExecuteQuery("select company,street1,street2,city,state,zip,phone from billers where company='" + biller + "'");
            Customer b = new Customer();
            if (rdr.Read())
            {
                i = 0;
                b.name = rdr.GetString(i++);
                b.address = rdr.GetString(i++);
                string st2 = rdr.GetString(i++);
                if (st2 != null && st2.Trim().Length > 0)
                {                    
                    b.address = b.address + "\r\n" + st2;
                }
                b.city = rdr.GetString(i++);
                b.state = rdr.GetString(i++) + " " + rdr.GetString(i++);
                //MessageBox.Show(b.ToString());
                b.phone = rdr.GetString(i++);
            }
            rdr.Close();
            DB.getInstance().close();
            Invoice inv = new Invoice();
            inv.cust = c;
            inv.biller = b;
            
            if (sc.ToString().Trim().Length > 0)
            {
                //MessageBox.Show("st " + sc.ToString() + " end");
                sc.name = name;
                inv.scust = sc;
            }
            else
            {
                inv.scust = c;
            }
                
            return inv;
        }

        public static String getBiller()
        {
            if (biller.Length == 0)
            {
                DbDataReader rdr = DB.getInstance().ExecuteQuery(
                    "select company,street1,street2,city,state,phone,fax,email from billers");

                if (rdr.Read())
                {
                    for (int i = 0; i < 8; i++)
                    {
                        biller = biller + rdr.GetString(i) + "\n\r";
                    }
                }
                rdr.Close();
                DB.getInstance().close();
            }
            return biller;
        }

        public static void loadInv(String[] cols, DataTable t)
        {
            DbDataReader rdr = DB.getInstance().ExecuteQuery(
                "select item_code,item,vendor,qty,buy_price,sell_price from items order by qty desc");
            t.Rows.Clear();
            while (rdr.Read())
            {
                DataRow r = t.NewRow();
                for (int i = 0; i < cols.Length; i++)
                {
                    string val = "";
                    if (i == 4 || i == 5)
                    {
                        double v = rdr.GetDouble(i);
                        val = v.ToString("N2");
                    }
                    else
                    {                        
                     val = rdr.GetValue(i).ToString();          
  
                    }
                    r[cols[i]] = val;                   
                }
                t.Rows.Add(r);
            }
            rdr.Close();
            DB.getInstance().close();

        }
    }
}
