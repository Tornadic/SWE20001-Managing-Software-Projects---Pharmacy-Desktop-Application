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
    /// Interaction logic for PredictionPage.xaml
    /// </summary>
    public partial class PredictionPage : Page
    {

        private List<SalesRecord> _phpSalesRecord = new List<SalesRecord>();
        private List<TotalSoldByItem> _listOfSoldItems = new List<TotalSoldByItem>();

        public PredictionPage()
        {
            InitializeComponent();
        }

        public List<TotalSoldByItem> MatchAndSortByItem(List<List<string>> salesRecord, List<List<string>> itemSales )
        {
            List<SalesRecord> phpSalesRecord = new List<SalesRecord>();
            List<TotalSoldByItem> listOfSoldItems = new List<TotalSoldByItem>();
            foreach (List<string> salesRec in salesRecord)
            {
                List<ItemSale> itmSales = new List<ItemSale>();
                foreach (List<string> itmSale in itemSales)
                {
                    if (itmSale[3] == salesRec[0])
                    {
                        itmSales.Add(new ItemSale(Convert.ToInt32(itmSale[0]), itmSale[1], Convert.ToInt32(itmSale[2])));
                    }
                }
                phpSalesRecord.Add(new SalesRecord(Convert.ToInt32(salesRec[0]), Convert.ToDateTime(salesRec[1]), float.Parse(salesRec[2]), itmSales)); // This is where I can work from and chop of months/weeks/ quarterrs?
            }

            foreach (SalesRecord sr in phpSalesRecord)
            {
                foreach (ItemSale itemSale in sr.ItemSales)
                {
                    TotalSoldByItem matchItem = listOfSoldItems.Find(item => item.SKU == itemSale.ItmSaleProdSKU);
                    if (matchItem != null)
                    {
                        //Add to existing TotalSoldByItem in the list 
                        matchItem.TotalQuantity += itemSale.ItmSaleQuantity;
                    }
                    else listOfSoldItems.Add(new TotalSoldByItem(itemSale.ItmSaleProdSKU, itemSale.ItmSaleQuantity));
                    
                }
            }
            return listOfSoldItems;
        }
        private void BtnClickWeek(object sender, RoutedEventArgs e)
        {
            var runSQL = SQLobj.Instance();
            List<List<string>> phpItemSales = runSQL.QueryDB("SELECT * from PHPItemSales");
            List<List<string>> phpWeeklySalesRecord = runSQL.QueryDB("SELECT * from PHPSalesRecord WHERE salesRecDate BETWEEN (CURRENT_DATE() - INTERVAL 7 DAY) AND CURRENT_DATE()");
            _listOfSoldItems = MatchAndSortByItem(phpWeeklySalesRecord, phpItemSales);
            foreach (TotalSoldByItem soldItem in _listOfSoldItems)
            {

                textPredictionList.Items.Add($"{soldItem.SKU}" + ": will be selling " + $"{soldItem.TotalQuantity}");
            }

        }

        private void BtnClickMonth(object sender, RoutedEventArgs e)
        {
            var runSQL = SQLobj.Instance();
            List<List<string>> phpItemSales = runSQL.QueryDB("SELECT * from PHPItemSales");
            List<List<string>> phpMonthlySalesRecord = runSQL.QueryDB("SELECT * from PHPSalesRecord WHERE salesRecDate BETWEEN (CURRENT_DATE() - INTERVAL 1 MONTH) AND CURRENT_DATE()");
            _listOfSoldItems = MatchAndSortByItem(phpMonthlySalesRecord, phpItemSales);
            foreach (TotalSoldByItem soldItem in _listOfSoldItems)
            {
                textPredictionList.Items.Add($"Forecasted next month sales in units: {soldItem.TotalQuantity}");
            }

        }
    }
}
