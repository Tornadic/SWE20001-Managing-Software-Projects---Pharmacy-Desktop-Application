using System;
using System.Collections.Generic;
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
    /// Interaction logic for SalesPage.xaml
    /// </summary>
    public partial class SalesPage : Page
    {
        private List<Product> _products = new List<Product>();
        private List<(Product, int)> _soldProducts = new List<(Product, int)>(); 

        public SalesPage()
        {
            InitializeComponent();
            var runSQL = SQLobj.Instance();
            List<List<string>> products = runSQL.QueryDB("SELECT * from PHPProducts");
            foreach(List<string> product in products)
            {
                _products.Add(new Product(product[0], product[1], int.Parse(product[2]), float.Parse(product[3])));
            }
            foreach(Product prod in _products)
            {
                cmxItemProduct.Items.Add(prod.Name);
            }
        }

        private void BtnItemAdd(object sender, RoutedEventArgs e)
        {
            if(txtItemQuantity.Text != "" && cmxItemProduct.SelectedIndex != -1)
            {
                Product prod = _products[cmxItemProduct.SelectedIndex];
                _soldProducts.Add((prod, int.Parse(txtItemQuantity.Text)));
                 txtItemList.Items.Add(prod.Name + "    " + txtItemQuantity.Text +  "     " + prod.Price * int.Parse(txtItemQuantity.Text));
            }
        }

        private void BtnSaleSubmit(object sender, RoutedEventArgs e)
        {
            if (txtItemList.Items.Count != 0 && txtSaleDate.Text != "")
            {
                var runSQL = SQLobj.Instance();
                float total = 0;
                foreach((Product, int) prod in _soldProducts)
                {
                    total += prod.Item1.Price * prod.Item2;
                }

                runSQL.QueryDB(string.Format("INSERT INTO PHPSalesRecord (salesRecDate, salesRecPrice) VALUES ('{0}','{1}')", Convert.ToDateTime(txtSaleDate.Text).ToString("yyyy-MM-dd"), total));
                int salesRecID = runSQL.QueryScalarDB("SELECT LAST_INSERT_ID()");
                foreach ((Product, int) prod in _soldProducts)
                {
                    runSQL.QueryDB(string.Format("INSERT INTO PHPItemSales (itmSaleProdSKU, itmSaleQuantity, itmSaleRecordID) VALUES ('{0}','{1}','{2}')", prod.Item1.SKU, prod.Item2, salesRecID));
                }
                Console.WriteLine("Sales record successfully added");
                NavigationService.Navigate(new ProductPage());
            }
        }
    }
}
