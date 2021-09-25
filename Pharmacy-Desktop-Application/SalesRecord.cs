using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Desktop_Application
{
    class SalesRecord
    {
        //PHPSalesRecord
        private int _salesRecID;
        private DateTime _salesRecDate;
        private float _salesRecTotal;

        //PHPItemSales
        private int _itmSaleID;
        private string _itmSaleProdSKU;
        private int _itmSaleQuantity;
        private int _itmSaleRecordID;

        public SalesRecord(int salesRecID, DateTime salesRecDate, float salesRecTotal, int itmSaleID, string itmSaleProdSKU, int itmSaleQuantity, int itmSaleRecordID)
        {
            //PHPSalesRecord
            _salesRecID = salesRecID;
            _salesRecDate = salesRecDate;
            _salesRecTotal = salesRecTotal;

            //PHPItemSales
            _itmSaleID = itmSaleID;
            _itmSaleProdSKU = itmSaleProdSKU;
            _itmSaleQuantity = itmSaleQuantity;
            _itmSaleRecordID = itmSaleRecordID;
        }

        //PHPSalesRecord
        public int SalesRecID { get => _salesRecID; }
        public DateTime SalesRecDate { get => _salesRecDate; }
        public float SalesRecTotal { get => _salesRecTotal; }

        //PHPItemSales
        public int ItmSaleID { get => _itmSaleID; }
        public string ItmSaleProdSKU { get => _itmSaleProdSKU; }
        public int ItmSaleQuantity { get => _itmSaleQuantity; }
        public int ItmSaleRecordID { get => _itmSaleRecordID; }
    }
}
