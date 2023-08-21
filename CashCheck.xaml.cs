using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Navigation;
using System.Data.Common;
using System.ComponentModel;
using System.IO;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;
using System.IO.Packaging;
using System.Windows.Markup;

using Microsoft.Win32;
using System.Collections;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.Reflection;


namespace CheckCasher
{
    /// <summary>
    /// Interaction logic for NewInvoice.xaml
    /// </summary>
    public partial class CashCheck : Page
    {
        private string txnId = "";
        private string cid = "";

        private static CashCheck cc = null;
        public static CashCheck Get()
        {            
            return Get(CheckUtil.GetID(), 0);
        }

        public static CashCheck Get(string txId, int load)
        {
            if (cc == null)
            {
                cc = new CashCheck();
                cc.InitializeComponent();
            }
            cc.Background = Brushes.White;
            cc.Clear();
            cc.txnId = txId;
            cc.txID.Text = txId;
            if(load > 0)
            cc.loadTxn();
            return cc;
        }

        public static CashCheck Get(string custId, Boolean customer)
        {
            CashCheck cc = Get(CheckUtil.GetID(), 0);            
            cc.cid = custId;            
            cc.customerID.Text = custId;
            return cc;
        }

        private void Clear()
        {            
            cc.acct.Text = string.Empty;
            cc.bank.Text = string.Empty;
            cc.routing.Text = string.Empty;
            cc.check.Text = string.Empty;
            cc.customerID.Text = string.Empty;
            cc.txID.Text = string.Empty;
            cc.teller.Text = string.Empty;
            cc.date.Text = string.Empty;
            cc.amount.Text = string.Empty;

            cc.backCapture.Source = null;
            cc.checkCapture.Source = null;

        }

        

        public CashCheck()
        {
            
            //txnId = CheckUtil.GetID();
            InitializeComponent();                       
        }

        /*public CashCheck(string custId, Boolean customer)
        {
            txnId = CheckUtil.GetID();
            this.cid = custId;
            InitializeComponent();
            customerID.Text = custId;           
        }

        public CashCheck(string txId)
        {
            this.txnId = txId;            
            InitializeComponent();
            loadTxn();
        }*/

        
        private void Window_Initialized(object sender, EventArgs e)
        {
            
            CheckUtil.initScanner(this); 
            txID.Text = txnId;            
            string str = "select distinct id from customers order by id";
            DbDataReader rdr = DB.getInstance().ExecuteQuery(str);

            while (rdr.Read())
            {
                customerID.Items.Add(rdr.GetString(0));
            }
            rdr.Close();
            DB.getInstance().close();  
        }

        private void saveTxn_Click(object sender, RoutedEventArgs e)
        {           
            string _id = txID.Text;
            string _custid = customerID.Text;
            double _amt = 0;
            Double.TryParse(amount.Text, out _amt);
            string _routing = routing.Text;
            string _bank = bank.Text;
            string _account = acct.Text;
            string _check = check.Text;

            if (string.IsNullOrEmpty(amount.Text) || string.IsNullOrEmpty(_routing) || string.IsNullOrEmpty(_account))
            {
                MessageBox.Show("Amount, Routing, and Account Number are Required");
                return;
            }
            
            Hashtable t = new Hashtable();
            t["customer"] = "'" + _custid + "'";
            t["last_updated"] = "'" + DateTime.Now + "'";
            t["teller"] = "'" + HomeWindow.user + "'";
            t["amount"] = "" + _amt + "";
            t["routing"] = "'" + _routing + "'";
            t["bank"] = "'" + _bank + "'";
            t["account"] = "'" + _account + "'";
            t["checkno"] = "'" + _check + "'";
    
            ArrayList l = new ArrayList();
            l.Add("'" + _id + "'");
            l.Add("'" + _custid + "'");
            l.Add("'"+DateTime.Now+"'");
            l.Add("'" + HomeWindow.user + "'");
            l.Add(""+_amt+"");
            l.Add("'" + _routing + "'" );
            l.Add("'" + _account + "'");
            l.Add("'" + _check + "'");
            l.Add("'" + _bank + "'");
            l.Add("null");
            l.Add("null");
            l.Add("null");
           
            if (_custid == null || _custid.Trim().Length == 0)
            {
                MessageBox.Show("Customer ID Name is Required");
                return;
            }
            string str = DB.getInstance().getUpdateString(t, "txn", " where txid='" + _id + "'");
            int ret = DB.getInstance().ExecuteNonQuery(str);

            if (ret == 0)
            {
                str = DB.getInstance().getInsertString(l, "txn");
                ret = DB.getInstance().ExecuteNonQuery(str);
                if (ret == 0)
                {
                    MessageBox.Show("Please enter required fields () ");
                    return;
                }                
            }
            int seq = 0;
            Int32.TryParse(_id.Substring(_id.Length-4), out seq);
            CheckUtil.SetID(seq);
            w.txnID = _id;
            w.isCheck = true;
            w.ShowDialog();
            JpegBitmapEncoder encoder = null;
            MemoryStream bas = null;
            string qry = string.Empty;
            if (checkCapture.Source != null)
            {
                encoder = Helper.GetImage((BitmapSource)checkCapture.Source);
                bas = new MemoryStream();
                encoder.Save(bas);
                qry = "update txn set checkimg=@checkimg where txid='" + _id + "'";
                DB.getInstance().UpdateImage(qry, bas.GetBuffer(), "@checkimg");
                bas.Close();
            }

            if (backCapture.Source != null)
            {
                encoder = Helper.GetImage((BitmapSource)backCapture.Source);
                bas = new MemoryStream();
                encoder.Save(bas);
                qry = "update txn set backimg=@backimg where txid='" + _id + "'";
                DB.getInstance().UpdateImage(qry, bas.GetBuffer(), "@backimg");
                bas.Close();
            }
            
            DB.getInstance().close(); 
            this.NavigationService.RemoveBackEntry();
            this.NavigationService.Navigate(new CustomerFrame(false));
        }

        [DllImport("buicap32.dll")]
        private static extern void BUICInit();

        [DllImport("buicap32.dll")]
        private static extern void BUICDisplayAbout();

        [DllImport("buicap32.dll")]
        private static extern int GetScannerType();
        
        private void loadTxn()
        {
            this.Background = Brushes.White;
            DbDataReader rdr = null;
            rdr = DB.getInstance().ExecuteQuery(
             "select customer,last_updated,teller,amount,routing,account,checkno,bank,custimg,checkimg,backimg from txn where txid='" + txnId + "'");            
            if (rdr.Read())
            {
                int i = 0;
                customerID.Text = rdr.GetString(i++);
                date.Text = rdr.GetDateTime(i++).ToString();
                teller.Text = rdr.GetString(i++);
                amount.Text = rdr.GetDouble(i++).ToString();
                routing.Text = rdr.GetString(i++);
                acct.Text = rdr.GetString(i++);
                check.Text = rdr.GetString(i++);
                bank.Text = rdr.GetString(i++);                
                if (!(rdr.IsDBNull(i)))
                    imgCapture.Source = CheckUtil.GetImage(rdr, i);
                i++;
                    if (!(rdr.IsDBNull(i)))
                    checkCapture.Source = CheckUtil.GetImage(rdr, i);
                i++;
                    if (!(rdr.IsDBNull(i)))
                        backCapture.Source = CheckUtil.GetImage(rdr, i);
            }
            rdr.Close();

            rdr = DB.getInstance().ExecuteQuery(
                "select * from flagged where routing='" + routing.Text + "' and account='" + acct.Text + "'");
            if (rdr.Read())
            {                
                this.Background = Brushes.Red;
                flag.Content = "Unflag";
                rdr.Close();
                                
            }

            DB.getInstance().close();
        }

        private void custCB_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void deleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            
        }
        static WebcamWindow w = CustomerFrame.w;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //w.custID = customerCB.Text;
           // w.ShowDialog();
            MessageBox.Show(savecustomer.GetType() + "");
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
       

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {            
            CheckUtil.scanCheck(this);
            amount.Focus();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {   
            //CheckUtil.scanCheck();            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(acct.Text) || string.IsNullOrEmpty(routing.Text))
            {
                MessageBox.Show("Please select valid company");
                return;
            }
            string cnt = (string)flag.Content;            
            if ("Unflag" == cnt)
            {
                string qry = "delete from flagged where routing='" + routing.Text + "' and account='" + acct.Text + "'";
                DB.getInstance().ExecuteNonQuery(qry);                
                this.Background = Brushes.White;
                flag.Content = "Flag As Bad";
            }
            else
            {                
                string str = "insert into flagged values('" + routing.Text + "','" + acct.Text + "')";
                DB.getInstance().ExecuteNonQuery(str);
                this.Background = Brushes.Red;
                flag.Content = "Unflag";                 
            }
            DB.getInstance().close();     
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            amount.Text = "";
            acct.Text = "";
            check.Text = "";
            routing.Text = "";
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Are you sure you want to Delete?", "Delete Transaction", MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
            {
                string str = "delete from txn where txid='" + txnId + "'";
                int ret = DB.getInstance().ExecuteNonQuery(str);
                DB.getInstance().close();
                this.NavigationService.RemoveBackEntry();
                this.NavigationService.Navigate(new CustomerFrame(false));
            }

        }
    }
}