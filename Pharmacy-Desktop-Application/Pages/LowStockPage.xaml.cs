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
    /// Interaction logic for ProductSearchPage.xaml
    /// </summary>
    public partial class LowStockPage : Page
    {
        private List<Product> _products = new List<Product>();
        public LowStockPage()
        {
            InitializeComponent();
            var runSQL = SQLobj.Instance();
            List<List<string>> products = runSQL.QueryDB("SELECT * from PHPProducts");
            foreach (List<string> product in products)
            {
                if (int.Parse(product[2]) < 100)
                {
                    _products.Add(new Product(product[0], product[1], int.Parse(product[2]), float.Parse(product[3])));
                }
            }
            foreach (Product prod in _products)
            {
                lsbProducts.Items.Add(prod.SKU + " " + prod.Name + " " + prod.Price + " " + prod.Stock);
            }
        }

        private void LsbProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(new EditProductPage(_products[lsbProducts.SelectedIndex]));
        }
    }
}
