
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Desktop_Application
{
    public class TotalSoldByItem
    {
        public TotalSoldByItem(string prodSKU, int totalQuantity)
        {
            SKU = prodSKU;
            TotalQuantity = totalQuantity;
        }

        public string SKU { get; set; }
        public int TotalQuantity { get; set; }
    }
}