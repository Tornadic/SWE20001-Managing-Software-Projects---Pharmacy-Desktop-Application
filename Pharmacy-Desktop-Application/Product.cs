using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Desktop_Application
{
    public class Product
    {
        public Product(string sku, string name, int stock, float price)
        {
            SKU = sku;
            Name = name;
            Stock = stock;
            Price = price;
        }

        public string SKU { get; }
        public string Name { get; }
        public int Stock { get; }
        public float Price { get; }
    }
}
