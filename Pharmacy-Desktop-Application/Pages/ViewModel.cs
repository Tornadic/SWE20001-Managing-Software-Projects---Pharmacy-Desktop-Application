using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Desktop_Application
{
    public class ViewModel
    {
        public List<ChartData> Data { get; set; }
        public ViewModel()
        {
            Data = new List<ChartData>();
            var runSQL = SQLobj.Instance();
            List<List<string>> phpSalesRecord = runSQL.QueryDB("SELECT * from PHPSalesRecord WHERE salesRecDate BETWEEN (CURRENT_DATE() - INTERVAL 1 MONTH) AND CURRENT_DATE()");
            List<List<string>> phpItemSales = runSQL.QueryDB("SELECT * from PHPItemSales");

            List<SalesRecord> csvSalesRecord = new List<SalesRecord>();

            if (phpSalesRecord is null || phpItemSales is null)
            {
                Console.WriteLine("Query returned null");
            }
            else
            {
                Console.Write("Working...");
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
                    foreach (SalesRecord sr in csvSalesRecord)
                    {
                        int itemsSold = 0;
                        foreach (ItemSale itemSale in sr.ItemSales)
                        {
                            itemsSold += itemSale.ItmSaleQuantity;
                        }
                        Data.Add(new ChartData { Day = sr.SalesRecDate.Day, UnitSales = itemsSold });
                        Console.Write(sr.SalesRecDate.Day + " and " + itemsSold);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
        }
    }
}
