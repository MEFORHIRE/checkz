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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.Common;

namespace Balance
{
    /// <summary>
    /// Interaction logic for Invoices.xaml
    /// </summary>
    public partial class Invoices : Page
    {
       DataTable t = new DataTable();
        string[] cols = new string[] { "Date", "Invoice No", "Customer"};
        public Invoices()
        {
            InitializeComponent();
            initTable();
            loadInv();

           
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            DbDataReader rdr = DB.getInstance(DB.LCL_MYSQL).ExecuteQuery("select distinct company from customers order by company");
            while (rdr.Read())
            {
                customer.Items.Add(rdr.GetString(0));
            }
            rdr.Close();
            DB.getInstance().close();


            //GridView v = (GridView)txnView.View;
        }


        private void initTable()
        {

            for (int i = 0; i < cols.Length; i++)
            {
                DataColumn column = new DataColumn(cols[i]);
                column.DataType = typeof(string);
                t.Columns.Add(column);
            }

           
            GridView gridview = new GridView();

            for (int i = 0; i < cols.Length; i++)
            {
                GridViewColumn gvcolumn = new GridViewColumn();
                gvcolumn.Header = cols[i];
                gvcolumn.DisplayMemberBinding = new Binding(cols[i]);
                gridview.Columns.Add(gvcolumn);
            }
            invView.View = gridview;


            Binding bind = new Binding();
            invView.DataContext = t;
            invView.SetBinding(ListView.ItemsSourceProperty, bind);

        }

        public void loadInv()    {
            DbDataReader rdr = DB.getInstance().ExecuteQuery(
                "select last_updated,invoice_id,customer from invoice order by last_updated desc");
            loadInv(rdr);
        }

        public void loadInv(DbDataReader rdr)    {
  
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

        private void customer_SelectedValueChanged(object sender, EventArgs e)
        {
            string item = (string)customer.SelectedItem;
            DbDataReader rdr = DB.getInstance(DB.LCL_MYSQL).ExecuteQuery(
                "select invoice_id,customer,last_updated from invoice where customer='" + item + "'");

            loadInv(rdr);
        }

        private void invoiceNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            string item = (string)invoiceNo.Text;
            DbDataReader rdr = DB.getInstance(DB.LCL_MYSQL).ExecuteQuery(
                "select invoice_id,customer,last_updated from invoice where invoice_id='" + item + "'");
            loadInv(rdr);
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("" + invView.SelectedIndex);
            if (this.invView.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an invoice");
                return;
            }
            DataRow r = t.Rows[invView.SelectedIndex];
            DbDataReader rdr = DB.getInstance().ExecuteQuery("select company,street1,city,state,phone from customers where company='" + r[2] + "'");
            Customer c = new Customer();
            while (rdr.Read())
            {
                c.name = rdr.GetString(0);
                c.address = rdr.GetString(1);
                c.city = rdr.GetString(2);
                c.state = rdr.GetString(3);
                c.phone = rdr.GetString(4);
            }
            rdr.Close();
            DB.getInstance().close();

            
            Invoice inv = new Invoice();
            inv.cust.name = customer.Text;
            inv.cust.address = c.address;
            inv.cust.city = c.city;
            inv.cust.state = c.state;
            inv.cust.phone = c.phone;

            rdr = DB.getInstance().ExecuteQuery("select item_code,item,qty,unit_qty,price_sell,amount from invoice_detail where invoice_id=" + r[1] + "");
            double total = 0;
            while (rdr.Read())
            {
               
            
                LineItem item = new LineItem();
                item.item_code = rdr.GetString(0);
                item.item = rdr.GetString(1);
                item.qty = rdr.GetDouble(2);
                item.unitqty = rdr.GetDouble(3);
                item.pricesell = rdr.GetDouble(4);
                item.amount = rdr.GetDouble(5);
                inv.lines.Add(item);
                total += item.amount;
            }
            rdr.Close();
            DB.getInstance().close();
            inv.total = total;
            inv.id = Int32.Parse((string)r[1]);
            printInvoice(inv);     
        }

        private void printInvoice(Invoice invoice)
        {
            this.NavigationService.Navigate(new PrintInvoice(invoice));
        }
    }
}
