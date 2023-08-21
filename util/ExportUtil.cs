using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace CheckCasher.util
{
    public class ExportUtil
    {
        public static void exportBillers()
        {
            string billers = export("select company,phone,street1,street2,city,state,fax,email from billers order by company asc");
            saveFile(billers,"billers.csv");
        }

        public static void exportCustomers()
        {
            string cust = export("select company,phone,fname,lname,street1,street2,city,state,fax,email from customers order by company asc");
            saveFile(cust,"customers.csv");
        }

        public static void exportInventory()
        {
            string cust = export("select item_code,item,bar_code,qty,buy_price,sell_price,vendor from items order by qty desc");
            saveFile(cust, "inventory.csv");
        }

        public static void exportInvoices()
        {
            string cust = export("select invoice_id,customer,biller,last_updated,iuser from invoice order by last_updated desc");
            saveFile(cust, "invoices.csv");
        }

        public static void exportReports(String name, DataTable t)
        {
            string reports = export(t);
            saveFile(reports, name);
        }


        public static void saveFile(string cust, string name)   {
            
           SaveFileDialog dlg = new SaveFileDialog();
           //MessageBox.Show(dlg.RestoreDirectory.ToString());
           //MessageBox.Show(dlg.InitialDirectory.ToString());
           dlg.FileName = name;
           dlg.DefaultExt = "csv";
           dlg.Filter = "Comma Separated Value (.csv)|*.csv";
           Nullable<bool> result = dlg.ShowDialog();

           // Process open file dialog box results
           if (result == true)
           {
               // Open document
               string filename = dlg.FileName;
               using (StreamWriter sw = new StreamWriter(filename))
               {
                   sw.Write(cust);
                   sw.Close();
               }
               
           }
           
           
        }

        public static string export(string sql)
        {
            
            DbDataReader rdr = DB.getInstance().ExecuteQuery(sql);
            StringBuilder b = new StringBuilder();
            //b.AppendLine("Company,Phone,FirstName,LastName,Street1,Street2,City,State,Fax,Email");
            int cnt = rdr.FieldCount;
            
                string str = "";
                for (int i = 0; i < cnt; i++)
                {
                    string val = rdr.GetName(i);
                    str = str + val;
                    if (i != cnt - 1) str = str + ",";
                }
                b.AppendLine(str);
            
            while (rdr.Read())
            {                
                str = "";
                for (int i = 0; i < cnt; i++)
                {
                    string val = rdr.GetValue(i).ToString();
                    str = str + val;
                    if (i != cnt - 1) str = str + ",";
                }
                b.AppendLine(str);
            }
            rdr.Close();
            DB.getInstance().close();
            return b.ToString();
        }

        public static string export(DataTable t)
        {

            StringBuilder b = new StringBuilder();
            //b.AppendLine("Company,Phone,FirstName,LastName,Street1,Street2,City,State,Fax,Email");
            int cnt = t.Columns.Count;

            string str = "";
            for (int i = 0; i < cnt; i++)
            {
                string val = t.Columns[i].ColumnName;
                str = str + val;
                if (i != cnt - 1) str = str + ",";
            }
            b.AppendLine(str);

            int rcnt = t.Rows.Count;
            for (int j = 0; j < rcnt; j++)
            {
                str = "";
                DataRow row = t.Rows[j];
                for (int i = 0; i < cnt; i++)
                {
                    string val = row[i].ToString();
                    str = str + val;
                    if (i != cnt - 1) str = str + ",";
                }
                b.AppendLine(str);
            }
            
            return b.ToString();
        }
    }
}
