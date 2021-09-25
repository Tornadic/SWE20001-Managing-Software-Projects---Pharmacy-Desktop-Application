using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Desktop_Application
{
    public class Product
    {
        private string _SKU;
        private string _name;
        private int _stock;
        private float _price;
        public Product(string sku, string name, int stock, float price)
        {
            _SKU = sku;
            _name = name;
            _stock = stock;
            _price = price;
        }

        public string SKU { get => _SKU; }
        public string Name { get => _name; }
        public int Stock { get => _stock; }
        public float Price { get => _price; }
    }
}
