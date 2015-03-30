using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Product
    {
        int productId;
        string productName;
        string description;
        decimal retailPrice;


        public Product() { }

        public Product(int x)
        {
            productId = x;
        }

        public int ProductlID
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Name
        {
            get { return productName; }
            set { productName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Decimal RetailPrice
        {
            get { return retailPrice; }
            set { retailPrice = value; }
        }













    }
}
