using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneApplication
{
    class Product : dbColumn
    {
        public Product(String name)
        {
            this.name = name; 
        }

        protected List<Supply> supplies;
        public void addSupply(Supply value)
        {
            supplies.Add(value);
        }
        public Supply getSupply(int index)
        {
            try
            {
                return supplies.ElementAt(index);
            } 
                catch(Exception e) 
            {
                return null;
            }
        }


        public Product()
        {

        }
    }
}
