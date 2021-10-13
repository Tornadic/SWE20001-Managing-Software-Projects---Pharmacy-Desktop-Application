using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Desktop_Application
{
    public class SalesRecord
    {
        //
        public SalesRecord(int salesRecID, DateTime salesRecDate, float salesRecPrice, List<ItemSale> itemSales)
        {
            SalesRecID = salesRecID;
            SalesRecDate = salesRecDate;
            SalesRecPrice = salesRecPrice;

            ItemSales = itemSales;
        }

        public int SalesRecID { get; }
        public DateTime SalesRecDate { get; }
        public float SalesRecPrice { get; }
        public List<ItemSale> ItemSales { get; } = new List<ItemSale>();

    }
}
