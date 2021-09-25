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
    /// Interaction logic for ProductMainPage.xaml
    /// </summary>
    public partial class ProductMainPage : Page
    {
        public ProductMainPage()
        {
            InitializeComponent();
            ProductFrame.Content = new ProductSearchPage();
        }

        private void BtnClickProduct(object sender, RoutedEventArgs e)
        {
            ProductFrame.Content = new ProductSearchPage(); 
        }

        private void BtnClickAddProduct(object sender, RoutedEventArgs e)
        {
            ProductFrame.Content = new ProductPage(); 
        }

        private void BtnClickEditProduct(object sender, RoutedEventArgs e)
        {
            ProductFrame.Content = new EditProductPage(); 
        }
    }
}
