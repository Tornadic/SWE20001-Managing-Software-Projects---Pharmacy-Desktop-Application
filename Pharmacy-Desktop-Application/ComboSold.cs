using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Desktop_Application
{
    public class ComboSold
    {
        public ComboSold(List<string> prodsSKU, int occurrence)
        {
            ProdsSKU = prodsSKU;
            Occurrence  = occurrence;
        }
        public List<string> ProdsSKU { get; set; }
        public int Occurrence { get; set; } = 0;
    }
}
