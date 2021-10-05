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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pharmacy_Desktop_Application
{
    /// <summary>
    /// Interaction logic for PredictionPage.xaml
    /// </summary>
    public partial class PredictionPage : Page
    {

        private List<ComboSold> _listOfCombos = new List<ComboSold>();
        private List<TotalSoldByItem> _listOfSoldItems = new List<TotalSoldByItem>();

        public PredictionPage()
        {
            InitializeComponent();
        }



        public List<SalesRecord> MatchItemSaleToSalesRecord(List<List<string>> salesRecord, List<List<string>> itemSales)
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

        public List<TotalSoldByItem> MatchAndSortByItem(List<List<string>> salesRecord, List<List<string>> itemSales )
        {
            List<TotalSoldByItem> listOfSoldItems = new List<TotalSoldByItem>();
            List<SalesRecord> phpSalesRecord = MatchItemSaleToSalesRecord(salesRecord,itemSales); 
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


        private static IEnumerable<IEnumerable<T>> GetCombinations<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetCombinations(list, length - 1).SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0), (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        public List<List<string>> Pair(List<string> list)
        {
            IEnumerable<IEnumerable<string>> enumResult = GetCombinations(list, 2);
            //
            List<List<string>> listResult = new List<List<string>>();
            foreach (IEnumerable<string> pair in enumResult)
            {
                List<string> pair2 = pair.ToList();
                pair2.Sort();
                listResult.Add(pair2);
            }
            return listResult;

        }

        public List<ComboSold> MatchAndSortByPair(List<List<string>> salesRecord, List<List<string>> itemSales)
        {
            List<SalesRecord> phpSalesRecord = MatchItemSaleToSalesRecord(salesRecord, itemSales);
            List<List<string>> purchasedComboList = new List<List<string>>();
            List<ComboSold> comboSoldRecord = new List<ComboSold>();
            foreach (SalesRecord sr in phpSalesRecord)
            {
                List<string> purchasedSKUs = new List<string>();
                foreach (ItemSale itmSale in sr.ItemSales)
                {
                    //add to the pool?
                    purchasedSKUs.Add(itmSale.ItmSaleProdSKU);
                }
                purchasedComboList.AddRange(Pair(purchasedSKUs));
            }

            List<List<string>> distinct = purchasedComboList.Distinct().ToList();
            foreach (List<string> pair in distinct)
            {
                int frequency = purchasedComboList.Count(p => (p[0] == pair[0]) && (p[1] == pair[1]));
                comboSoldRecord.Add(new ComboSold(pair, frequency));
            }
            return comboSoldRecord;
        }


        private void BtnClickWeekCombo(object sender, RoutedEventArgs e)
        {
            var runSQL = SQLobj.Instance();
            List<List<string>> phpItemSales = runSQL.QueryDB("SELECT * from PHPItemSales");
            List<List<string>> phpWeeklySalesRecord = runSQL.QueryDB("SELECT * from PHPSalesRecord WHERE salesRecDate BETWEEN (CURRENT_DATE() - INTERVAL 7 DAY) AND CURRENT_DATE()");
            textComboPredictionList.Text = "Product combo from last week";
            if (phpWeeklySalesRecord.Count > 0)
            {
                _listOfCombos = MatchAndSortByPair(phpWeeklySalesRecord, phpItemSales);
                foreach (ComboSold combo in _listOfCombos)
                {
                    textComboPredictionList.Text += $"\n{string.Join(", ", combo.ProdsSKU)} {combo.Occurrence}";
                }
            }
            else { textComboPredictionList.Text += "No recent data"; }
        }

        private void BtnClickMonthCombo(object sender, RoutedEventArgs e)
        {
            var runSQL = SQLobj.Instance();
            List<List<string>> phpItemSales = runSQL.QueryDB("SELECT * from PHPItemSales");
            List<List<string>> phpMonthlySalesRecord = runSQL.QueryDB("SELECT * from PHPSalesRecord WHERE salesRecDate BETWEEN (CURRENT_DATE() - INTERVAL 1 MONTH) AND CURRENT_DATE()");
            textComboPredictionList.Text = "Product combo from last month";
            if (phpMonthlySalesRecord.Count > 0)
            {
                _listOfCombos = MatchAndSortByPair(phpMonthlySalesRecord, phpItemSales);
                foreach (ComboSold combo in _listOfCombos)
                {
                    textComboPredictionList.Text += $"\n{string.Join(", ", combo.ProdsSKU)} {combo.Occurrence}";
                }
            }
            else { textComboPredictionList.Text += "No recent data"; }
        }



        private void BtnClickWeek(object sender, RoutedEventArgs e)
        {
            var runSQL = SQLobj.Instance();
            List<List<string>> phpItemSales = runSQL.QueryDB("SELECT * from PHPItemSales");
            List<List<string>> phpWeeklySalesRecord = runSQL.QueryDB("SELECT * from PHPSalesRecord WHERE salesRecDate BETWEEN (CURRENT_DATE() - INTERVAL 7 DAY) AND CURRENT_DATE()");
            textPredictionList.Text = "Forecasted next week sales in units: ";
            if (phpWeeklySalesRecord.Count > 0)
            {
                _listOfSoldItems = MatchAndSortByItem(phpWeeklySalesRecord, phpItemSales);
                foreach (TotalSoldByItem soldItem in _listOfSoldItems)
                {
                    textPredictionList.Text += $"\n{soldItem.SKU} {soldItem.TotalQuantity}";
                }
            }
            else { textPredictionList.Text += "No recent data to make weekly predictions"; }

        }

        private void BtnClickMonth(object sender, RoutedEventArgs e)
        {
            var runSQL = SQLobj.Instance();
            List<List<string>> phpItemSales = runSQL.QueryDB("SELECT * from PHPItemSales");
            List<List<string>> phpMonthlySalesRecord = runSQL.QueryDB("SELECT * from PHPSalesRecord WHERE salesRecDate BETWEEN (CURRENT_DATE() - INTERVAL 1 MONTH) AND CURRENT_DATE()");
            textPredictionList.Text = "Forecasted next month sales in units: ";
            if (phpMonthlySalesRecord.Count > 0)
            {
                _listOfSoldItems = MatchAndSortByItem(phpMonthlySalesRecord, phpItemSales);
                
                foreach (TotalSoldByItem soldItem in _listOfSoldItems)
                {
                    textPredictionList.Text += $"\n{soldItem.SKU} {soldItem.TotalQuantity}";
                }
            }
            else { textPredictionList.Text += "\nNo recent data to make monthly predictions"; }
        }

        private void CreateCSV()
        {
            //Make this work off a button or two? THen wont need to do null checks
            if (_listOfSoldItems.Count > 0)
            {
                try
                {
                    StreamWriter fileOutput = new StreamWriter("C:\\SalesReports\\Predictions.csv");
                    foreach (TotalSoldByItem itemTotal in _listOfSoldItems)
                    {
                        string itemsSold = itemTotal.SKU + ", " + itemTotal.TotalQuantity;
                        fileOutput.WriteLine(itemsSold);
                    }
                    fileOutput.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            else if (_listOfCombos != null)
            {
                try
                {
                    StreamWriter fileOutput = new StreamWriter("C:\\SalesReports\\Predictions_Grouped.csv");
                    foreach (ComboSold combo in _listOfCombos)
                    {
                        string itemsSold = "";
                        foreach (string s in combo.ProdsSKU)
                        { itemsSold += s; }
                        itemsSold += combo.Occurrence;
                        fileOutput.WriteLine(itemsSold);
                    }
                    fileOutput.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }
    }
}
