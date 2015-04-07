using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneApplication
{
    class dbObjects
    {
        protected List<Product> products;
        public dbObjects() {
            new List<Product>();
        }

        static public dbObjects operator +(dbObjects valone, Product valtwo) {
            valone.addProduct(valtwo);
            return valone;
        } 

        public void addProduct(Product value)
        {
            this.products.Add(value); 
        }

        public int getCount() {
            return this.products.Count;
        }

        public List<dbColumn> getIndex(int index)
        {
            List<dbColumn> returnList = new List<dbColumn>();
            try
            {
                returnList.Add(this.products.ElementAt(index));
                return returnList;
            } catch (Exception e) {
                Console.Error.WriteLine("Error in dbObjects: " + e.Message);
                return null;
            }
            
        }
    }
}
