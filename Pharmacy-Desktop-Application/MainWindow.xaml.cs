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
            Main.Content = new HomePage(); // sets the homepage to be displayed when the application is open 
            
        }


        private void BtnClickHome(object sender, RoutedEventArgs e)
        {
            Main.Content = new HomePage();
            var abc = SQLobj.Instance();
            abc.TestConnection();
        }

        private void BtnClickProduct(object sender, RoutedEventArgs e)
        {
            Main.Content = new ProductPage(); 
        }
        private void BtnClickRecord(object sender, RoutedEventArgs e)
        {
            Main.Content = new RecordPage();
        }

        private void BtnClickPrediction(object sender, RoutedEventArgs e)
        {
            Main.Content = new PredictionPage();
        }

        private void BtnClickSettings(object sender, RoutedEventArgs e)
        {
            Main.Content = new SettingsPage();
        }

    }
}
