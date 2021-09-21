using System;
using System.Collections.Generic;
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

namespace Pharmacy_Desktop_Application
{
    /// <summary>
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        //TODO Currently this page is only setup to add product to the database

        public ProductPage()
        {
            InitializeComponent();
        }

        private void BtnClickSubmit(object sender, RoutedEventArgs e)
        {
            // this is the onclick listener for the Submit Button on the Product Page
        }
    }
}
