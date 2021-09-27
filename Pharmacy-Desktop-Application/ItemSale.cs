using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Desktop_Application
{

    public class ItemSale
    {
        public ItemSale(int itmSaleID, string itmSaleProdSKU, int itmSaleQuantity)
        {
            ItmSaleID = itmSaleID;
            ItmSaleProdSKU = itmSaleProdSKU;
            ItmSaleQuantity = itmSaleQuantity;
        }

        public int ItmSaleID { get; }
        public string ItmSaleProdSKU { get; }
        public int ItmSaleQuantity { get; }
    }
}
