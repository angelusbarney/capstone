using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSTN_ProductManagement
{
    public class objectCounter
    {
        ICollection<Supplier> supplierSet;
        ICollection<Supply> supplySet;
        ICollection<Client> clientSet;
        ICollection<Product> productSet;

        public objectCounter()
        {
            supplierSet = new List<Supplier>();
            supplySet = new List<Supply>();
            clientSet = new List<Client>();
            productSet = new List<Product>(); 
        }

        public void registerSupplier(Supplier supplier)
        {
            supplierSet.Add(supplier); 
        }
        public void registerSupply(Supply supply)
        {
            supplySet.Add(supply);
        }
        public void registerClient(Client client)
        {
            clientSet.Add(client);
        }
        public void registerProduct(Product product)
        {
            productSet.Add(product);
        }

        public Supplier fetchSupplier(int index)
        {
            return supplierSet.ElementAt(index); 
        }
        public Supply fetchSupply(int index)
        {
            return supplySet.ElementAt(index);
        }
        public Client fetchClient(int index)
        {
            return clientSet.ElementAt(index);
        }
        public Product fetchProduct(int index)
        {
            return productSet.ElementAt(index);
        }
    }
}
