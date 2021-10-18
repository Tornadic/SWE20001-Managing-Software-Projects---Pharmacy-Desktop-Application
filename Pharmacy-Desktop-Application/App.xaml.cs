using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Toolkit.Uwp.Notifications;

namespace Pharmacy_Desktop_Application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// dan is smelly, but in a good way 
    public partial class App : Application
    {
        //Opens low stock page when Toast notification is clicked
        protected override void OnActivated(EventArgs e)
        {
            // Listen to notification activation
            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                // Obtain the arguments from the notification
                ToastArguments args = ToastArguments.Parse(toastArgs.Argument);

                // Need to dispatch to UI thread if performing UI operations
                Application.Current.Dispatcher.Invoke(delegate
                {
                    ((MainWindow)System.Windows.Application.Current.MainWindow).Main.Content = new LowStockPage();
                    // TODO: Show the corresponding content
                    //MessageBox.Show("Toast activated. Args: " + toastArgs.Argument);
                });
            };
            // TODO: Show the corresponding content
            


        }
    }
}
