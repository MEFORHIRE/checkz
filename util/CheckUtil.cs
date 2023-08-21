using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.Security.Principal;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Reflection;
using CheckCasher.util;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace CheckCasher
{
    class CheckUtil
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("User32.dll")]
        private static extern bool
            SetForegroundWindow(IntPtr hWnd);

        static void bringWindowToFocus(IntPtr windowHandle)
        {
            SetForegroundWindow(windowHandle);
        }


        public static CheckHelper scanner = null;

        public static void scanCheck(CashCheck cc)
        {            
            _scanCheck(cc);
        }

        public static void exitScanner()
        {
            try
            {
                scanner.axRanger1.ShutDown();
            }
            catch (Exception e)
            {
            }
        }

        public static void _scanCheck(CashCheck cc)
        {
                try
                {                   
                    scanner.axRanger1.StartFeeding(0, 0);    
                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show(e.StackTrace);
                    System.Windows.MessageBox.Show(e.Message);
                }            
        }

        
        public static void initScanner(CashCheck cc)
        {

            if (scanner == null)
            {                
                scanner = new CheckHelper(cc);
                try
                {
                    //scanner.axRanger1.
                    scanner.axRanger1.StartUp();
                }
                catch (Exception e)
                {
                    System.Windows.MessageBox.Show(e.StackTrace);
                    System.Windows.MessageBox.Show(e.Message);
                }

            }
            
        }

        public static string ReadLastLine(string path)
        {
            return ReadLastLine(path, Encoding.ASCII, "\n");
        }

        public static string ReadLastLine(string path, Encoding encoding, string newline)
        {
            int charsize = encoding.GetByteCount("\n");
            byte[] buffer = encoding.GetBytes(newline);
            

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                long endpos = stream.Length / charsize;
                int cnt = 0;
                for (long pos = charsize; pos < endpos; pos += charsize)
                {
                    stream.Seek(-pos, SeekOrigin.End);
                    stream.Read(buffer, 0, buffer.Length);

                    if (encoding.GetString(buffer) == newline && cnt == 1)
                    {                        
                        buffer = new byte[stream.Length - stream.Position];
                        stream.Read(buffer, 0, buffer.Length);
                        return encoding.GetString(buffer);
                    }
                    else if (encoding.GetString(buffer) == newline)
                    {
                        cnt++;
                        //buffer = new byte[stream.Length - stream.Position];
                        //stream.Read(buffer, 0, buffer.Length);
                        //return encoding.GetString(buffer);
                    }
                }

                stream.Seek(0, SeekOrigin.Begin);
                buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                return encoding.GetString(buffer);
            }

        }

        static int StandardAuxOnUsLength = 8;
        static int StandardRoutingLength = 9;
        static int StandardOnUsLength = 13;
        static int StandardTranCodeLength = 4;
        static int StandardAmountLength = 10;
        static int StandardAuxOnUsOffset = 0;
        static int StandardRoutingOffset = 10;
        static int StandardOnUsOffset = 21;
        static int StandardTranCodeOffset = 34;
        static int StandardAmountOffset = 39;

        public static void ParseEncodeLine(string EncodeLine)
        {
          int Length = EncodeLine.Length;
          string AmountField = string.Empty;
          string TranCodeField = string.Empty;
          string OnUsField = string.Empty;
          string RoutingField = string.Empty;
          string AuxOnUsField = string.Empty;


          if (Length >= 17)
            {
            TranCodeField = EncodeLine.Substring(StandardTranCodeOffset, StandardTranCodeLength+1);
            TranCodeField.Remove('c');
            TranCodeField.Remove(' ');
            //m_TranCodeFieldControl.SetWindowText(TranCodeField);
            }

          //if the encode line has at least 30 characters
          if (Length >= 30)
            {
            OnUsField = EncodeLine.Substring(StandardOnUsOffset, StandardOnUsLength);
            OnUsField.TrimStart();
            //m_OnUsFieldControl.SetWindowText(OnUsField);
            }

          //if the encode line has at least 41 characters
          if (Length >= 41)
            {
            RoutingField = EncodeLine.Substring(StandardRoutingOffset, StandardRoutingLength+2);
            RoutingField.Remove('d');
            RoutingField.Remove(' ');
            //m_RoutingFieldControl.SetWindowText(RoutingField);
            }

          //if the encode line has at least 51 characters
          if (Length >= 51)
            {
            AuxOnUsField = EncodeLine.Substring(StandardAuxOnUsOffset, StandardAuxOnUsLength+2);
            AuxOnUsField.Remove('c');
            AuxOnUsField.Remove(' ');
    
            }

          System.Windows.MessageBox.Show("tran " + TranCodeField);
          System.Windows.MessageBox.Show("on us " + OnUsField);
          System.Windows.MessageBox.Show(" rout " + RoutingField);
          System.Windows.MessageBox.Show(" aux " + AuxOnUsField);
  
        }

        public static string[] readRangerMICR(string line)
        {
            System.Windows.MessageBox.Show(line);
            string[] tokens = line.Split(' ');
            tokens[0] = Regex.Replace(tokens[0], "[^.0-9]", "");
            tokens[1] = Regex.Replace(tokens[1], "[^.0-9]", "");
            if(tokens.Length == 3)
                tokens[2] = Regex.Replace(tokens[2], "[^.0-9]", ""); 
           
            string check = string.Empty;
            string acct = string.Empty;
            string routing = string.Empty;

            if (tokens.Length == 2)
            {
                check = tokens[0];
                routing = tokens[1];
            }
            else
            {                
                check = tokens[0];
                routing = tokens[1];
                acct = tokens[2];
            }
            return new string[] {check, routing, acct};            
        }


        public static string [] loadCheck()
        {
            string line = ReadLastLine("scanlite.mcr");
            string [] tokens = line.Split('<');

            string img = "";
            string imgBack = string.Empty;
            string check = string.Empty;
            string _acct = string.Empty;

            if (tokens.Length == 2)
            {
                img = tokens[0];
                string tmp = tokens[0];
                int idx = tmp.IndexOf(":");
                img = tmp.Substring(0,idx);
                _acct = tmp.Substring(idx);
                check = tokens[1];                
            }
            else
            {
                img = tokens[0];
                check = tokens[1];
                _acct = tokens[2].Trim();
            }

            img = img.Substring(0, img.Length - 4).Trim();
            imgBack = img.Replace("\\f", "\\b");
            check = check.Trim();
            tokens = _acct.Split(':');
            

            string routing = tokens[1].Trim();
            string acct = tokens[2].Trim();

            string[] checkdata = new string[] { img, check, acct, routing, imgBack };
            return checkdata;
        }


        public static string GetID()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\EWebComputing\\CheckCasher",true);
            DateTime now = DateTime.Now;
            string ddmm =  now.Month.ToString("D2") + now.Day.ToString("D2") ;
            if (key == null)
            {                
               key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\EWebComputing\\CheckCasher");
               key.SetValue("seq", "1");
               key.SetValue("Date", ddmm); 
            }
            string val = (string)key.GetValue("seq");
            int seq = 0;
            Int32.TryParse(val, out seq);                       
            WindowsIdentity w = WindowsIdentity.GetCurrent();
            string pre = w.Name != null && w.Name.Length > 1 ? w.Name.Substring(0,2) : w.Name;
            string id = (pre != null ? pre.ToUpper() : pre) + ddmm + seq.ToString("D4");
            //SetID(seq);
            return id;
        }

        public static void SetID(int seq)
        {
            DateTime now = DateTime.Now;
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\EWebComputing\\CheckCasher", true); 
            string ddmm = now.Month.ToString("D2") + now.Day.ToString("D2");
            string curddmm = (string)key.GetValue("Date");
            if (ddmm.Equals(curddmm))
            {
                seq++;
            }
            else
            {
                seq = 1;                
                key.SetValue("Date", ddmm);
            }
            key.SetValue("seq", seq.ToString());
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

        public static BitmapImage GetImage(DbDataReader _rdr, int i)
        {
            return CustUtil.GetImage(_rdr, i);
        }

        public static BitmapImage GetImageMSSQLEXP(DbDataReader _rdr, int i)
        {
            SqlDataReader rdr = (SqlDataReader)_rdr;            
            byte[] buf = rdr.GetSqlBinary(i).Value;
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
        byte[] outbyte = new byte[100];
        int bufferSize = 100;
        
        // Read the bytes into outbyte[] and retain the number of bytes returned.
        long retval = rdr.GetBytes(i, startIndex, outbyte, 0, 100);
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
