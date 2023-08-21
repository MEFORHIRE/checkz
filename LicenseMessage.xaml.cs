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
using Microsoft.Win32;
using System.IO;

namespace CheckCasher
{
    /// <summary>
    /// Interaction logic for LicenseMessage.xaml
    /// </summary>
    public partial class LicenseMessage : Window
    {
        public static string MSG = "Your CheckCasher License has expired. Please Insert a valid license file";
        public static string REGISTER = "Update your CheckCasher License";
        public string path { get; set; }
        public LicenseMessage()
        {
            InitializeComponent();
            this.button2.Visibility = Visibility.Hidden;
        }

        public LicenseMessage(string msg)
        {               
            InitializeComponent();
            this.licenseMessage.Text = msg;
            this.button2.Visibility = Visibility.Visible;        
        }

        public LicenseMessage(string msg, string title) : this(msg)
        {            
            this.Title = title;            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //Environment.Exit(1);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://CheckCasher.ewebcomputing.com");

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //dlg.FileName = name;
            dlg.DefaultExt = "xml";
            dlg.Filter = "License File (.xml)|*.xml";
            Nullable<bool> result = dlg.ShowDialog();
            if (result.GetValueOrDefault())
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\license.xml";
                File.Delete(path);
                File.Copy(dlg.FileName, path);
                if (File.Exists(dlg.FileName))
                {
                    path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\license.xml";
                    this.Close();
                }
                else
                    MessageBox.Show("License File Not found");                
            }
            
        }
    }
}
