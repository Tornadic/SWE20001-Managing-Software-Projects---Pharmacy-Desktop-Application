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
    /// Interaction logic for RevenueByItemPage.xaml
    /// </summary>
    /// 
    
    public partial class RevenueByItemPage : Page
    {
        private List<Product> _products = new List<Product>();
        private List<ComboSold> _listOfCombos = new List<ComboSold>();
        private List<TotalSoldByItem> _listOfSoldItems = new List<TotalSoldByItem>();

        public RevenueByItemPage()
        {
            InitializeComponent();
            var runSQL = SQLobj.Instance();
            List<List<string>> phpItemSales = runSQL.QueryDB("SELECT * from PHPItemSales");
            List<List<string>> phpMonthlySalesRecord = runSQL.QueryDB("SELECT * from PHPSalesRecord WHERE salesRecDate BETWEEN (CURRENT_DATE() - INTERVAL 1 MONTH) AND CURRENT_DATE()");
            if (phpMonthlySalesRecord.Count > 0)
            {
                _listOfSoldItems = MatchAndSortByItem(phpMonthlySalesRecord, phpItemSales);

                foreach (TotalSoldByItem soldItem in _listOfSoldItems)
                {
                    revenueByItem.Items.Add($"\n{soldItem.SKU} {CalculateRev(soldItem)}");
                }
            }
            else { revenueByItem.Items.Add("No recent data to display"); }
        }


        //calc rev?
        private float CalculateRev(TotalSoldByItem soldItem)
        {
            var runSQL = SQLobj.Instance();
            List<List<string>> products = runSQL.QueryDB("SELECT * from PHPProducts");
            float unitPrice = 0;
            foreach (List<string> product in products)
            {
                _products.Add(new Product(product[0], product[1], int.Parse(product[2]), float.Parse(product[3])));
            }
            
            foreach (Product prod in _products)
            {
                if (soldItem.SKU == prod.SKU){
                    unitPrice = prod.Price;
                }
            }

            return (unitPrice * soldItem.TotalQuantity);
        }
        



        //match item to sales record
        private List<SalesRecord> MatchItemSaleToSalesRecord(List<List<string>> salesRecord, List<List<string>> itemSales)
        {
            List<SalesRecord> phpSalesRecord = new List<SalesRecord>();

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
            return phpSalesRecord;
        }

        private List<TotalSoldByItem> MatchAndSortByItem(List<List<string>> salesRecord, List<List<string>> itemSales)
        {
            List<TotalSoldByItem> listOfSoldItems = new List<TotalSoldByItem>();
            List<SalesRecord> phpSalesRecord = MatchItemSaleToSalesRecord(salesRecord, itemSales);
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


        

    }
}
