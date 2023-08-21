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
using CheckCasher.util;

namespace CheckCasher
{
    /// <summary>
    /// Interaction logic for Export.xaml
    /// </summary>
    public partial class Export : Page
    {
        public const int INVENTORY = 0;
        public const int CUSTOMER = 1;
        public const int BILLER = 2;
        public const int INVOICE = 3;
        public int type = 0;
        
        public static string[] filenames = { "inventory.csv", "customers.csv", "billers.csv","invoices.csv" };
        public static string[] titles = { "Export Inventory", "Export Customers", "Export Billers", "Export Invoices" };
        public Export(int type)
        {
            InitializeComponent();
            this.type = type;
            this.exportTitle.Content = titles[type];
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            switch (type)
            {
                case INVENTORY:
                    ExportUtil.exportInventory();
                    break;
                case CUSTOMER:
                    ExportUtil.exportCustomers();
                    break;
                case BILLER:
                    ExportUtil.exportBillers();
                    break;
                case INVOICE:
                    ExportUtil.exportInvoices();
                    break;
            }
        }


    }
}
