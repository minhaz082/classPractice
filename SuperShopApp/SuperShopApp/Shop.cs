using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp
{
    class Shop
    {
        public string Name { set; get; }
        public string Address { set; get; }

        private List<Product> productList = new List<Product>();

        public List<Product> GetAllProducts()
        {
            return productList;
        }

        public Shop(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string AddProduct(Product someProduct)
        {
           
           if (CheckProduct(someProduct))
            {
                productList.Add(someProduct);
                return "Product Added";
            }
            return "Product Updated";
        }

        public bool CheckProduct(Product aNProduct)
        {
            foreach (Product aProduct in productList)
            {
                if (aProduct.ProductName == aNProduct.ProductName)
                {
                    aProduct.Quantity += aNProduct.Quantity;
                    return false;
                }
            }

            return true;
        }

    }
}
