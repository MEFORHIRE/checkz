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
using System.Windows.Controls.Primitives;
using System.Net;
using System.Threading;
using System.Windows.Forms.Integration;


namespace CheckCasher
{
    /// <summary>
    /// Interaction logic for NewInvoice.xaml
    /// </summary>
    public partial class CustomerFrame : Inv365Sortable
    {      
        string table = "customers";
        DataTable t = new DataTable();
        string[] cols = new string[] { "Date", "TxnId", "Customer", "Amount", "Routing", "Account", "Check", "Bank"};
        public static WebcamWindow w = new WebcamWindow();

 
        public CustomerFrame()
        {
            InitializeComponent();
            initTable(cols);
            
            CustUtil.loadTxn(cols, t, customerCB.Text);
            
            
        }

        public override DataTemplate getUpTemplate()
        {
            return Resources["HeaderTemplateArrowUp"] as DataTemplate;
        }

        public override DataTemplate getDownTemplate()
        {
            return Resources["HeaderTemplateArrowDown"] as DataTemplate;
        }

        public override ListView getView()
        {
            return custView;
        }

        public CustomerFrame(bool billers)
        {
            
           InitializeComponent();           
           initTable(cols);                
           CustUtil.loadTxn(cols, t, customerCB.Text);
           
        }

        private void initTable(string [] acols)
        {
            for (int i = 0; i < acols.Length; i++)
            {
                DataColumn column = new DataColumn(acols[i]);
                column.DataType = typeof(string);
                t.Columns.Add(column);
            }
            t.Rows.Clear();
            GridView gridview = new GridView();

            for (int i = 0; i < acols.Length; i++)
            {
                GridViewColumn gvcolumn = new GridViewColumn();
                gvcolumn.Width = 150;
                gvcolumn.Header = acols[i];
                gvcolumn.DisplayMemberBinding = new Binding(acols[i]);
                gridview.Columns.Add(gvcolumn);
            }
            custView.View = gridview;
            Binding bind = new Binding();
            custView.DataContext = t;
            custView.SetBinding(ListView.ItemsSourceProperty, bind);
        }
 
        private void Window_Initialized(object sender, EventArgs e)
        {
            string str = "select distinct id from customers order by id";
            DbDataReader rdr = DB.getInstance().ExecuteQuery(str);
            while (rdr.Read())            {
                customerCB.Items.Add(rdr.GetString(0));
            }
            rdr.Close();
            DB.getInstance().close();            
            FocusHelper.Focus(customerID);            
            //customerCB.Focus();
        }

        private void savecustomer_Click(object sender, RoutedEventArgs e)
        {
            string _id = customerCB.Text;
            string _fn = firstName.Text;
            string _ln = lastName.Text;
            string _street1 = street1.Text;
            string _street2 = street2.Text;
            string _city = city.Text;
            string _state = state.Text;
            string _zip = zip.Text;
            string _phone = phone.Text;
            Object _dob = null;
            if(!(String.IsNullOrEmpty(dob.Text)))    {
                try{
                    _dob = DateTime.Parse(dob.Text).ToString();
                } catch(Exception ee)    {
                }
            }
            string _ssn = ssn.Text;
            string _height = height.Text;
            string _weight = weight.Text;

            Hashtable t = new Hashtable();            
            t["city"] = "'" + _city + "'";
            t["state"] = "'" + _state + "'";
            t["zip"] = "'" + _zip + "'";
            t["phone"] = "'" + _phone + "'";
            t["street1"] = "'" + _street1 + "'";
            t["street2"] = "'" + _street2 + "'";    
           
            t["fname"] = "'" + _fn + "'";
            t["lname"] = "'" + _ln + "'";            
            t["id"] = "'" + _id + "'";
            t["ssn"] = "'" + _ssn + "'";
            t["dob"] = "'" + _dob + "'";
            t["height"] = "'" + _height + "'";
            t["weight"] = "'" + _weight + "'";
            t["status"] = "1";

            ArrayList l = new ArrayList();
            l.Add("'" + _city + "'");
            l.Add("'" + _state + "'");
            
            l.Add("'" + _phone + "'");
            l.Add("'" + _street1 + "'");
            l.Add("'" + _street2 + "'");           

            l.Add("'" + _fn + "'");
            l.Add("'" + _ln + "'");            
            l.Add("'" + _zip + "'");
            l.Add("'" + _id + "'");
            l.Add("'" + _ssn + "'");
            l.Add("'" + _dob + "'");
            l.Add("'" + _height + "'");
            l.Add("'" + _weight + "'");
            l.Add("null");
            l.Add("null");
            l.Add(1);

            if (_id == null || _id.Trim().Length != 11)
            {
                MessageBox.Show("Customer ID must be 11 characters");
                return;
            }
            string str = DB.getInstance().getUpdateString(t, table, " where id='" + _id + "'");            
            int ret = DB.getInstance().ExecuteNonQuery(str);

            if (ret == 0)
            {
                str = DB.getInstance().getInsertString(l, table);
                ret = DB.getInstance().ExecuteNonQuery(str);
                if (ret == 0)
                {
                    MessageBox.Show("Please enter required fields (first name, last name, company, street1, city, state) ");
                    return;
                }                
            }
            w.custID = customerCB.Text;                        
            w.isCheck = false;
            //w.webcam.Start();
            w.ShowDialog();
            

           
            mn.ShowDialog();
            mn.Close();
            if(!(string.IsNullOrEmpty(mn._tempImageName)))   {
                BitmapImage img1 = new BitmapImage();
                img1.BeginInit();
                img1.UriSource = new Uri(mn._tempImageName);
                img1.EndInit();
                JpegBitmapEncoder encoder = Helper.GetImage(img1);
                MemoryStream bas = new MemoryStream();
                encoder.Save(bas);            
                string qry = "update customers set license=@license where id='" + _id + "'";
                DB.getInstance().UpdateImage(qry, bas.GetBuffer(), "@license");
                bas.Close();        
            }

            MessageBoxResult res = MessageBox.Show("Do you want to cash the check?", "Cash Check?", MessageBoxButton.YesNo);
            this.NavigationService.RemoveBackEntry();
            if (res == MessageBoxResult.Yes)
            {
                this.NavigationService.Navigate(CashCheck.Get(_id,true));
            }
            else            
                this.NavigationService.Navigate(new CustomerFrame(false));            
        }

        DLFrontFaceScanDemo.frmMain mn = new DLFrontFaceScanDemo.frmMain();

        private void custCB_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Background = Brushes.White;
            flag.Content = "Flag As Bad";
            imgCapture.Source = null;
            licenseCapture.Source = null;
            string item = (string)customerCB.SelectedItem;
            DbDataReader rdr = null;
           
                rdr = DB.getInstance().ExecuteQuery(
                 "select id,phone,fname,lname,street1,street2,city,state,zip,dob,ssn,height,weight,status,picture,license from customers where id='" + item + "'");
          
            if (rdr.Read())
            {
                int i = 0;
                customerCB.Text = rdr.GetString(i++);
                phone.Text = rdr.GetString(i++);                
                firstName.Text = rdr.GetString(i++);
                lastName.Text = rdr.GetString(i++);               
                street1.Text = rdr.GetString(i++);
                street2.Text = rdr.GetString(i++);
                city.Text = rdr.GetString(i++);
                state.Text = rdr.GetString(i++);
                //dob.Text = rdr.GetString(i++);
                //ssn.Text = rdr.GetString(i++);
                zip.Text = rdr.GetString(i++);
                dob.Text = rdr.GetDateTime(i++).ToString("MM/dd/yyyy");
                ssn.Text = rdr.GetString(i++);
                height.Text = rdr.GetString(i++);
                weight.Text = rdr.GetString(i++);
                int stat = rdr.GetInt32(i++);
                if (stat < 1)
                {
                    this.Background = Brushes.Red;
                    flag.Content = "Unflag";
                }
                if (!(rdr.IsDBNull(i)))
                    imgCapture.Source = CustUtil.GetImage(rdr, i);
                i++;
                if (!(rdr.IsDBNull(i)))
                    licenseCapture.Source = CustUtil.GetImage(rdr, i);
            }
            rdr.Close();
            CustUtil.loadTxn(cols, t, customerCB.Text);
            DB.getInstance().close();
            
        }

        private void deleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (custView.SelectedIndex == -1) return;
            if (System.Windows.Forms.MessageBox.Show("Really delete?", "Confirm delete", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.getInstance().ExecuteNonQuery(
                    "delete from "+table+" where id='" + customerCB.Text + "'");
                t.Rows[custView.SelectedIndex].Delete();
                custView.SelectedIndex = -1;
                this.NavigationService.RemoveBackEntry();
                this.NavigationService.Navigate(new CustomerFrame(false));
            }                   
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
                 
        }

        private void custView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRow r = t.Rows[custView.SelectedIndex];            
            this.NavigationService.RemoveBackEntry();
            this.NavigationService.Navigate(CashCheck.Get(""+r[1]+"", 1));
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            if (!HomeWindow.IsAdmin())
            {
                MessageBox.Show("You must be logged in as administrator to perform this operation.");
                return;
            }
            if (customerCB.Text.Trim().Length != 11)
            {
                MessageBox.Show("Customer ID must be 11 characters");
                return;
            }
            
            System.Diagnostics.Process.Start("http://instantofac.com/search.php?input_string="+firstName.Text);
            

            //WebBrowser wb = new WebBrowser();
            //wb.Document = new 
            //MessageBox.Show("Customer not found in terrorist list");
        }

        private void flag_Click(object sender, RoutedEventArgs e)
        {
            if (!HomeWindow.IsAdmin())
            {
                MessageBox.Show("You must be logged in as administrator to perform this operation.");
                return;
            }
            if (customerCB.Text.Trim().Length != 11)
            {
                MessageBox.Show("Customer ID must be 11 characters");
                return;
            }
            string qry = "";
            string cnt = flag.Content.ToString();
            if ("Unflag" == cnt)
                qry = "update customers set status=1 where id='" + customerCB.Text + "'";
            else
                qry = "update customers set status=0 where id='" + customerCB.Text + "'";
            DB.getInstance().ExecuteNonQuery(qry);
            DB.getInstance().close();
            if ("Unflag" == cnt)
            {
                this.Background = Brushes.White;
                flag.Content = "Flag As Bad";
            }
            else
            {
                this.Background = Brushes.Red;
                flag.Content = "Unflag";
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //MessageBoxResult res = MessageBox.Show("Do you want to cash the check?", "Cash Check?", MessageBoxButton.YesNo);
            this.NavigationService.RemoveBackEntry();            
            this.NavigationService.Navigate(CashCheck.Get(customerCB.Text, true));
           
        }

        private void dob_KeyUp(object sender, KeyEventArgs e)
        {
            //dob.Text = DateTime.TryParse(dob.Text).ToString("mm/dd/yyyy");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.RemoveBackEntry();            
            this.NavigationService.Navigate(new CustomerFrame());
        }

        private void customerID_GotFocus(object sender, RoutedEventArgs e)
        {            
            //customerCB.Focus();
 
        }

        private void customerCB_GotFocus(object sender, EventArgs e)
        {
            //MessageBox.Show("got focus");
        }
    }

    static class FocusHelper
    {
        private delegate void MethodInvoker();

        public static void Focus(UIElement element)
        {
            //Focus in a callback to run on another thread, ensuring the main UI thread is initialized by the
            //time focus is set
            ThreadPool.QueueUserWorkItem(delegate(Object foo)
            {
                UIElement elem = (UIElement)foo;
                elem.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal,
                    (MethodInvoker)delegate()
                    {
                        elem.Focus();
                        ((WindowsFormsHost)elem).Child.Focus();
                        //Keyboard.Focus(((WindowsFormsHost)elem).Child);                        
                    });
            }, element);
        }
    }
}