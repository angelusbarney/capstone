using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSTN_ProductManagement
{
    public class dbObjects
    {
        protected List<Product> products;
        protected List<Supply> supplies;
        protected List<Supplier> suppliers;
        public dbObjects() {
            products = new List<Product>();
            supplies = new List<Supply>();
            suppliers = new List<Supplier>(); 
        }

        static public dbObjects operator +(dbObjects valone, Product valtwo) {
            valone.products.Add(valtwo);
            return valone;
        }

        static public dbObjects operator +(dbObjects valone, Supply valtwo)
        {
            valone.supplies.Add(valtwo);
            return valone;
        }
        static public dbObjects operator +(dbObjects valone, Supplier valtwo)
        {
            valone.suppliers.Add(valtwo);
            return valone;
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
                returnList.Add(this.supplies.ElementAt(index));
                returnList.Add(this.suppliers.ElementAt(index));
                return returnList;
            } catch (Exception e) {
                Console.Error.WriteLine("Error in dbObjects: " + e.Message);
                return null;
            }
            
        }
    }
}
