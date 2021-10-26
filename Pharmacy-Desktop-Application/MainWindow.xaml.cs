using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Toolkit.Uwp.Notifications;

namespace Pharmacy_Desktop_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Uri Source;

        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new HomePage();

        }

        private void ImgLogoClick(object sender, MouseEventArgs e)
        {
            Main.Content = new HomePage();
        }


        private void BtnClickPrediction(object sender, RoutedEventArgs e)
        {
            Main.Content = new PredictionPage();
        }


        // Product Page
        private void BtnClickProduct(object sender, RoutedEventArgs e)
        {
            Main.Content = new ProductSearchPage(); 
        }

        // Sales Page
        private void BtnClickSalePage(object sender, RoutedEventArgs e)
        {
            Main.Content = new DisplaySalesPage();
        }

        //Chart Page    
        private void BtnChart(object sender, RoutedEventArgs e)
        {
            Main.Content = new ChartPage();
        }

        public void showLowStock()
        {
            Main.Content = new LowStockPage();
        }


    }
}
