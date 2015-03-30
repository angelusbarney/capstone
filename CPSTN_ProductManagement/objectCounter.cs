using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSTN_ProductManagement
{
    public class objectCounter
    {
        ICollection<int> clientID;
        ICollection<int> productID;

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
            clientID = new List<int>();
            productID = new List<int>();

        }

        public void registerSupplier(Supplier supplier)
        {
            supplierSet.Add(supplier);
        }
        public void registerSupply(Supply supply)
        {
            supplySet.Add(supply);
        }
        public int registerClient(Client client)
        {
            clientSet.Add(client);
            clientID.Add(client.id);
            return (clientSet.Count() - 1);
        }
        public int registerProduct(Product product)
        {
            productSet.Add(product);
            productID.Add(product.id);
            return (productSet.Count() - 1);
        }

        public Supplier fetchSupplier(int index)
        {
            return supplierSet.ElementAt(index);
        }
        public Supply fetchSupply(int index)
        {
            return supplySet.ElementAt(index);
        }
        public int fetchClientId(int index)
        {
            return clientID.ElementAt(index);
        }
        public Client fetchClient(int index)
        {
            return clientSet.ElementAt(index);
        }
        public int fetchProductId(int index)
        {
            return productID.ElementAt(index);
        }
        public Product fetchProduct(int index)
        {
            return productSet.ElementAt(index);
        }

        public void removeClient(int index)
        {
            try
            {
                clientSet.Remove(clientSet.ElementAt(index));
            }
            catch (Exception e) { }
        }
        public void removeProduct(int index)
        {
            try 
            {
                productSet.Remove(productSet.ElementAt(index));
            }
            catch (Exception e) { }
        }
    }
}
