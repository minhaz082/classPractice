using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp
{
    class Product
    {
        public string ProductName { set; get; }
        public int Quantity { set; get; }

        public Product(string productName, int quantity)
        {
            ProductName = productName;
            Quantity = quantity;
        }
    }
}
