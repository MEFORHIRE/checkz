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
 using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.IO;

namespace CheckCasher
{
    /// <summary>
    /// Design by Pongsakorn Poosankam
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WebcamWindow : Window
    {
        public string custID;
        public string txnID;
        
        public WebcamWindow()
        {
            InitializeComponent();
        }

        public WebCam webcam;
        private void mainWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            
            WindowInteropHelper helper = new WindowInteropHelper(this);            
            IntPtr hwnd = GetSystemMenu(helper.Handle, false);
            DeleteMenu(hwnd, SC_CLOSE, 0);
            
            //webcam.Start();
            
        }

        private void bntStart_Click(object sender, RoutedEventArgs e)
        {
            webcam.Start();
        }

        private void bntStop_Click(object sender, RoutedEventArgs e)
        {
            webcam.Stop();
        }

        private void bntContinue_Click(object sender, RoutedEventArgs e)
        {
            webcam.Continue();
        }

        private void bntCapture_Click(object sender, RoutedEventArgs e)
        {
            imgCapture.Source = imgVideo.Source;
        }

        public bool isCheck = false;

        private void bntSaveImage_Click(object sender, RoutedEventArgs e)
        {            
            //Helper.SaveImageCapture((BitmapSource)imgCapture.Source);
            JpegBitmapEncoder encoder = Helper.GetImage((BitmapSource)imgCapture.Source);
            MemoryStream bas = new MemoryStream();
            encoder.Save(bas);
            if (!isCheck)
            {
                string qry = "update customers set picture=@picture where id='" + custID + "'";
                DB.getInstance().UpdateImage(qry, bas.GetBuffer(), "@picture");
            }
            else
            {
                string qry = "update txn set custimg=@custimg where txid='" + txnID + "'";
                DB.getInstance().UpdateImage(qry, bas.GetBuffer(), "@custimg");
            }            
            DB.getInstance().close();
            bas.Close();            
            this.Hide();
        }

        private void bntResolution_Click(object sender, RoutedEventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void bntSetting_Click(object sender, RoutedEventArgs e)
        {
            webcam.AdvanceSetting();
        }

  
        private const uint SC_CLOSE = 0xF060;

        [DllImport("user32.dll")]
      private static extern IntPtr GetSystemMenu(IntPtr hwnd, bool revert);

        [DllImport("user32.dll")]
        private static extern bool DeleteMenu(IntPtr hMenu, uint position, uint flags);

       
        private void mainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {            
            webcam.Stop();            
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void mainWindow_Deactivated(object sender, EventArgs e)
        {
            
        }

        private void mainWindow_Activated(object sender, EventArgs e)
        {
        }

        private void mainWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (webcam == null)
            {
                webcam = new WebCam();
                webcam.InitializeWebCam(ref imgVideo);
            }
            
            if (IsVisible)
            {                
                webcam.Start();
            }
            else webcam.Stop();
        }
    }
}