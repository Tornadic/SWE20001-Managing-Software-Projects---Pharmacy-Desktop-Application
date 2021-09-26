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
    public partial class EditSalesPage : Page
    {
        private SalesRecord _salesRecord;
        private List<Product> _products = new List<Product>();
        private List<(ItemSale, bool)> _updatedProducts = new List<(ItemSale, bool)>();
        private bool _newItemSale = true;
        private ItemSale _editing;

        public EditSalesPage(SalesRecord salesRecord)
        {
            InitializeComponent();

            _salesRecord = salesRecord;

            var runSQL = SQLobj.Instance();
            List<List<string>> products = runSQL.QueryDB("SELECT * from PHPProducts");

            foreach (List<string> product in products)
            {
                _products.Add(new Product(product[0], product[1], int.Parse(product[2]), float.Parse(product[3])));
            }

            foreach (Product prod in _products)
            {
                cmxItemProduct.Items.Add(prod.Name);
            }

            foreach (ItemSale itmSale in _salesRecord.ItemSales)
            {
                foreach(Product product in _products)
                {
                    if (product.SKU == itmSale.ItmSaleProdSKU)
                    {
                        _updatedProducts.Add((itmSale, false));
                        txtItemList.Items.Add(product.Name + "    " + itmSale.ItmSaleQuantity + "     " + product.Price * itmSale.ItmSaleQuantity);
                        txtItemQuantity.Clear();
                        cmxItemProduct.Text = "";
                    }
                }
            }
        }

        private void BtnItemAdd(object sender, RoutedEventArgs e)
        {
            if (txtItemQuantity.Text != "" && cmxItemProduct.SelectedIndex != -1)
            {
                Product prod = _products[cmxItemProduct.SelectedIndex];

                if (_newItemSale)
                    _updatedProducts.Add((new ItemSale(-1, prod.SKU, Convert.ToInt32(txtItemQuantity.Text)), _newItemSale));

                else
                    _updatedProducts.Add((new ItemSale(_editing.ItmSaleID, prod.SKU, Convert.ToInt32(txtItemQuantity.Text)), _newItemSale));

                txtItemList.Items.Add(prod.Name + "    " + txtItemQuantity.Text + "     " + prod.Price * int.Parse(txtItemQuantity.Text));

            }
        }

        private void TxtItemList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtItemQuantity.Text = _updatedProducts[txtItemList.SelectedIndex].Item1.ItmSaleQuantity.ToString();
            _newItemSale = false;
            foreach(ItemSale itmSale in _salesRecord.ItemSales)
            {
                if (itmSale.ItmSaleID == _updatedProducts[txtItemList.SelectedIndex].Item1.ItmSaleID)
                    _editing = _updatedProducts[txtItemList.SelectedIndex].Item1;
            }
            foreach(Product p in _products)
            {
                if (p.SKU == _editing.ItmSaleProdSKU)
                    cmxItemProduct.SelectedItem = p.Name;
            }
            txtItemQuantity.Text = _editing.ItmSaleQuantity.ToString();
            _updatedProducts.RemoveAt(txtItemList.SelectedIndex);
            txtItemList.Items.RemoveAt(txtItemList.SelectedIndex);
        }

        private void BtnSaleSubmit(object sender, RoutedEventArgs e)
        {
            if (txtItemList.Items.Count != 0 && txtSaleDate.Text != "")
            {
                var runSQL = SQLobj.Instance();
                float total = 0;
                foreach ((ItemSale, bool) sale in _updatedProducts)
                {
                    foreach(Product p in _products)
                    {
                        if (p.SKU == sale.Item1.ItmSaleProdSKU)
                        {
                            total += p.Price * sale.Item1.ItmSaleQuantity;
                        }
                    }
                }

                runSQL.QueryDB(string.Format("UPDATE PHPSalesRecord SET salesRecDate'{0}', salesRecPrice='{1}' WHERE SalesRecID='{2}'", Convert.ToDateTime(txtSaleDate.Text).ToString("yyyy-MM-dd"), total, _salesRecord.SalesRecID));
                foreach ((ItemSale, bool) itmSale in _updatedProducts)
                {
                    if (itmSale.Item2)
                    {
                        runSQL.QueryDB(string.Format("INSERT INTO PHPItemSales (itmSaleProdSKU, itmSaleQuantity, itmSaleRecordID) VALUES ('{0}','{1}','{2}')", itmSale.Item1.ItmSaleProdSKU, itmSale.Item1.ItmSaleQuantity, _salesRecord.SalesRecID));

                    }
                    else
                    {
                        runSQL.QueryDB(string.Format("UPDATE PHPItemSales SET itmSaleProdSKU='{0}', itmSaleQuantity='{1}', itmSaleRecordID='{2}' WHERE itmSaleID='{3}'", itmSale.Item1.ItmSaleProdSKU, itmSale.Item1.ItmSaleQuantity, _salesRecord.SalesRecID, itmSale.Item1));
                    }
                }
                Console.WriteLine("Sales record successfully Updated");
                NavigationService.Navigate(new DisplaySalesPage());
            }
        }
    }
}
