using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Product
    {
        string ProductName { get; set; }
        int ProductCode { get; set; }
        decimal Price { get; set; }

        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
            ProductCode = 0;
        }

        public Product(string productName, int productCode, decimal price) : this(productName, price)
        {
            ProductCode = productCode;
        }

        public Product(string productName, int productCode, decimal price)
        {
            ProductName = productName;
            ProductCode = productCode;
            Price = price;
        }
    }
}
