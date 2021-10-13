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
        public ProductPage()
        {
            InitializeComponent();
        }

        private void BtnClickSubmit(object sender, RoutedEventArgs e)
        {
            if (txtProdName.Text != "" && txtProdPrice.Text != "" && txtProdSKU.Text != "" && txtProdStock.Text != "")
            {
                var runSQL = SQLobj.Instance();
                runSQL.QueryDB(string.Format("INSERT INTO PHPProducts VALUES ('{0}','{1}','{2}','{3}')", txtProdSKU.Text, txtProdName.Text, txtProdStock.Text, txtProdPrice.Text));
                NavigationService.Navigate(new ProductSearchPage());
                txtProdName.Text = "";
                txtProdSKU.Text = ""; 
                txtProdStock.Text = ""; 
                txtProdPrice.Text = "";
            }
        }
    }
}
