using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Desktop_Application
{
    public class SalesRecord
    {
        private int _salesRecID;
        private DateTime _salesRecDate;
        private float _salesRecPrice;

        private List<ItemSale> _itemSales = new List<ItemSale>();

        public SalesRecord(int salesRecID, DateTime salesRecDate, float salesRecPrice, List<ItemSale> itemSales)
        {
            _salesRecID = salesRecID;
            _salesRecDate = salesRecDate;
            _salesRecPrice = salesRecPrice;

            _itemSales = itemSales;
        }

        public int SalesRecID { get => _salesRecID; }
        public DateTime SalesRecDate { get => _salesRecDate; }
        public float SalesRecPrice { get => _salesRecPrice; }
        public List<ItemSale> ItemSales { get => _itemSales; }

    }
}
