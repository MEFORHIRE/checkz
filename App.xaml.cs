using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;


namespace CheckCasher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("es-ES");
            //MessageBox.Show(System.Threading.Thread.CurrentThread.CurrentUICulture.ToString());
            //WPFLocalizeExtension.Engine.LocalizeDictionary.Instance.Culture = System.Globalization.CultureInfo.GetCultureInfo("es-ES");
            base.OnStartup(e);
        }
        public void Run()
        {
            try
            {
                base.Run();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.GetBaseException().Message + " " + e.GetBaseException().StackTrace);
            }            
        }
    }
}