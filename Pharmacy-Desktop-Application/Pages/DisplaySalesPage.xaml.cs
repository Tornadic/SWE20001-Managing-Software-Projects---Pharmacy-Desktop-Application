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
    /// Interaction logic for DisplaySalesPage.xaml
    /// </summary>
    public partial class DisplaySalesPage : Page
    {
        private List<SalesRecord> _phpSalesRecord = new List<SalesRecord>();

        public DisplaySalesPage()
        {
            InitializeComponent();
            var runSQL = SQLobj.Instance();
            List<List<string>> phpSalesRecord = runSQL.QueryDB("SELECT * from PHPSalesRecord");
            List<List<string>> phpItemSales = runSQL.QueryDB("SELECT * from PHPItemSales");

            foreach (List<string> salesRec in phpSalesRecord)
            {
                List<ItemSale> itmSales = new List<ItemSale>();
                foreach(List<string> itmSale in phpItemSales)
                {
                    itmSales.Add(new ItemSale(Convert.ToInt32(itmSale[0]), itmSale[1], Convert.ToInt32(itmSale[2])));                        
                }
                _phpSalesRecord.Add(new SalesRecord(Convert.ToInt32(salesRec[0]), Convert.ToDateTime(salesRec[1]), float.Parse(salesRec[2]), itmSales));
            }

            foreach (SalesRecord sr in _phpSalesRecord)
            {
                string itemsSold = "";
                foreach(ItemSale itemSale in sr.ItemSales)
                {
                    itemsSold += itemSale.ItmSaleID + " " + itemSale.ItmSaleProdSKU + " " + itemSale.ItmSaleQuantity + " - ";
                }
                lsbSalesRecord.Items.Add(sr.SalesRecID + " " + sr.SalesRecDate.ToString("dd-MM-yyyy") + " " + sr.SalesRecPrice + " ||| " + itemsSold);
            }
        }

        private void LsbSalesRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(new EditSalesPage());
        }

        private void BtnClickAddSalesRecord(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SalesPage());
        }
    }
}
