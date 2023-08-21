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
using System.Security.Principal;
using System.Data.Common;
//using System.Web.ClientServices.Providers;
using CheckCasher.util;
using System.IO;
using Microsoft.Win32;
using System.Globalization;
using System.Threading;
using System.Configuration;

namespace CheckCasher 
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public static string user = "";
        public static Boolean isAdmin = false;

        static WindowsIdentity w = WindowsIdentity.GetCurrent();
        static WindowsPrincipal wp = new WindowsPrincipal(w);

        public static RoutedCommand F11Command = new RoutedCommand();
        public static RoutedCommand F9Command = new RoutedCommand();

        public static RoutedCommand CtrlAltCCommand = new RoutedCommand();
        public static RoutedCommand CtrlAltMCommand = new RoutedCommand();



        public void ExecutedF11Command(object sender, ExecutedRoutedEventArgs e)
        {
            navigate(new CustomerFrame());         
        }

        public void ExecutedF9Command(object sender, ExecutedRoutedEventArgs e)
        {
            navigate(CashCheck.Get());
        }


        public static bool IsAdmin()
        {
            return wp.IsInRole(WindowsBuiltInRole.Administrator);  
        }

        private void setupShortcuts()    {
            F11Command.InputGestures.Add(new KeyGesture(Key.F11));            
            this.CommandBindings.Add(new CommandBinding(F11Command, ExecutedF11Command));            
            
            CtrlAltCCommand.InputGestures.Add(new KeyGesture(Key.M, ModifierKeys.Alt | ModifierKeys.Control));
            this.CommandBindings.Add(new CommandBinding(CtrlAltCCommand, ExecutedF11Command));

            CtrlAltMCommand.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt | ModifierKeys.Control));
            this.CommandBindings.Add(new CommandBinding(CtrlAltMCommand, ExecutedF9Command));

            F9Command.InputGestures.Add(new KeyGesture(Key.F9));
            this.CommandBindings.Add(new CommandBinding(F9Command, ExecutedF9Command));
        }
        
        public HomeWindow()
        {
            int dbtype = Int32.Parse(ConfigurationManager.AppSettings.Get("dbtype"));
            DB.getInstance(dbtype);
            setupShortcuts();
            string name = w.Name;
            int idx = name.IndexOf("\\");
            if(idx > 0)
            name = name.Substring(idx+1);
            user = name;
            InitializeComponent();              
        }

        public void Window_Initialized(object sender, EventArgs e)
        {
            /*LicenserAPI.Logic l = new LicenserAPI.Logic();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\license.xml";
            string npath = LicenseUtil.licenseCheck(path);            
            if (string.IsNullOrEmpty(npath) || !l.IsValid(npath, "CheckCasher", "inv365", false))
            {
                LicenseMessage lm = new LicenseMessage(LicenseMessage.MSG);             
                bool res = (bool)lm.ShowDialog();
                if (!res)
                {
                    if (!File.Exists(path))
                        Environment.Exit(0);
                    else if(l.IsValid(path, "CheckCasher", "inv365", false))
                    {
                        MessageBox.Show("License File Inserted Successfully");
                    }                        
                }
            }
            else if (!string.IsNullOrEmpty(npath))
            {
                //MessageBox.Show("License file Inserted Successfully");
            } */
        }

        

       
        private void DashboardClick(object sender, RoutedEventArgs e)
        {
            navigate(CashCheck.Get());                
        }

        private void InvClick(object sender, RoutedEventArgs e)
        {
          
        }


        private void InvoicesClick(object sender, RoutedEventArgs e)
        {
            navigate(new Invoices());            
        }

        private void customer_Click(object sender, RoutedEventArgs e)
        {
            navigate(new CustomerFrame());
        }


        private void navigate(object _fr)
        {            
            this.ContentFrame.Navigate(_fr);            
        }

        private void reports_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void customerDue_Click(object sender, RoutedEventArgs e)
        {
            
        }


        private void wcustomerreports_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void wbillerreports_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void wreports_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void wcustomerDue_Click(object sender, RoutedEventArgs e)
        {
            
        }


        private void customerreports_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void billerreports_Click(object sender, RoutedEventArgs e)
        {
           
        }

        
        private void billers_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            AboutEWeb ae = new AboutEWeb();
            ae.Show();
        }

        private void expBillers_Click(object sender, RoutedEventArgs e)
        {
            navigate(new Export(Export.BILLER));
        }

        private void expCustomers_Click(object sender, RoutedEventArgs e)
        {
            navigate(new Export(Export.CUSTOMER));
        }

        private void expInventory_Click(object sender, RoutedEventArgs e)
        {
            navigate(new Export(Export.INVENTORY));
        }

        private void expInvoices_Click(object sender, RoutedEventArgs e)
        {
            navigate(new Export(Export.INVOICE));
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"\\CheckCasher.chm");
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            LicenseMessage dlg = new LicenseMessage(LicenseMessage.REGISTER, "Update License");
            dlg.Show();
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckUtil.exitScanner();
            Environment.Exit(0);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            CheckUtil.exitScanner();
            Environment.Exit(0);
        }
    }
}