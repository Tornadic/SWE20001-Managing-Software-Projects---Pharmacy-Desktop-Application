using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Desktop_Application
{

    public class ItemSale
    {
        private int _itmSaleID;
        private string _itmSaleProdSKU;
        private int _itmSaleQuantity;

        public ItemSale(int itmSaleID, string itmSaleProdSKU, int itmSaleQuantity)
        {
            _itmSaleID = itmSaleID;
            _itmSaleProdSKU = itmSaleProdSKU;
            _itmSaleQuantity = itmSaleQuantity;
        }

        public int ItmSaleID { get => _itmSaleID; }
        public string ItmSaleProdSKU { get => _itmSaleProdSKU; }
        public int ItmSaleQuantity { get => _itmSaleQuantity; }
    }
}
