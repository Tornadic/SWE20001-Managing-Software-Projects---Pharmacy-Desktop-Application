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
    /// Interaction logic for EditProductPage.xaml
    /// </summary>
    public partial class EditProductPage : Page
    {
        private Product _product;

        public EditProductPage(Product product)
        {
            InitializeComponent();
            _product = product;
            txtProdSKU.Text = product.SKU;
            txtProdName.Text = product.Name;
            txtProdStock.Text = product.Stock.ToString();
            txtProdPrice.Text = product.Price.ToString();
        }

        private void BtnClickSubmit(object sender, RoutedEventArgs e)
        {
            if (txtProdName.Text != "" && txtProdPrice.Text != "" && txtProdSKU.Text != "" && txtProdStock.Text != "")
            {
                var runSQL = SQLobj.Instance();
                runSQL.QueryDB(string.Format("UPDATE PHPProducts SET ProdName = '{0}', ProdStock = '{1}', ProdPrice = '{2}' WHERE ProdSKU = '{3}';", txtProdName.Text, txtProdStock.Text, txtProdPrice.Text, txtProdSKU.Text));
                NavigationService.Navigate(new ProductSearchPage());
            }
        }
    }
}
