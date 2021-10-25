using System;
using System.Collections.Generic;
using System.IO;
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
            NavigationService.Navigate(new EditSalesPage(_phpSalesRecord[lsbSalesRecord.SelectedIndex]));
        }

        private void BtnClickAddSalesRecord(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SalesPage());
        }
        //opens new page to display rev by item
        private void BtnClickDisplayRevByItem(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RevenueByItemPage());
        }
        private void CreateCSV()
        {
            InitializeComponent();
            var runSQL = SQLobj.Instance();
            List<List<string>> phpSalesRecord = runSQL.QueryDB("SELECT * from PHPSalesRecord WHERE salesRecDate BETWEEN (CURRENT_DATE() - INTERVAL 1 MONTH) AND CURRENT_DATE()");
            List<List<string>> phpItemSales = runSQL.QueryDB("SELECT * from PHPItemSales"); //Get last month only?

            List<SalesRecord> csvSalesRecord = new List<SalesRecord>();

            if (phpSalesRecord is null || phpItemSales is null)
            {
                Console.WriteLine("Query returned null");
            }
            else
            {
                foreach (List<string> salesRec in phpSalesRecord)
                {
                    List<ItemSale> itmSales = new List<ItemSale>();
                    foreach (List<string> itmSale in phpItemSales)
                    {
                        itmSales.Add(new ItemSale(Convert.ToInt32(itmSale[0]), itmSale[1], Convert.ToInt32(itmSale[2])));
                    }
                    csvSalesRecord.Add(new SalesRecord(Convert.ToInt32(salesRec[0]), Convert.ToDateTime(salesRec[1]), float.Parse(salesRec[2]), itmSales));
                }
                try
                {
                    //To find path: string reportPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments etc);, System.IO.Path.Combine(), Permissions might need to be granted
                    //How to title sales report? Maybe date
                    StreamWriter fileOutput = new StreamWriter("C:\\SalesReports\\SalesReport.csv");
                    foreach (SalesRecord sr in csvSalesRecord)
                    {
                        string itemsSold = "";
                        foreach (ItemSale itemSale in sr.ItemSales)
                        {
                            itemsSold += ", " + itemSale.ItmSaleID + ", " + itemSale.ItmSaleProdSKU + ", " + itemSale.ItmSaleQuantity;
                        }
                        fileOutput.WriteLine(sr.SalesRecID + ", " + sr.SalesRecDate.ToString("dd-MM-yyyy") + ", " + sr.SalesRecPrice + itemsSold);
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
