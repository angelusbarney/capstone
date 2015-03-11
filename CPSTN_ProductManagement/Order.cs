using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSTN_ProductManagement
{
    public class Order : dbColumn
    {
        ProductDataSetTableAdapters.ProductOrderTableAdapter dbAdapter;
        objectCounter listedData;
        public void getProperties()
        {
            ProductDataSet.ProductOrderDataTable data = dbAdapter.GetData();

            this.client = listedData.fetchClient(data.FindById(this.id).Client);
            this.product = listedData.fetchProduct(data.FindById(this.id).Product);
        }
        public void setProperties()
        {
            ProductDataSet.ProductOrderDataTable data = dbAdapter.GetData();
            data.AcceptChanges();
        }
        public Order(objectCounter list, int ID)
        {
            listedData = list; 
            this._id = ID; 
        }

        public Order()
        {

        }

        protected Product _product;
        public Product product
        {
            get { return _product; }
            set { _product = value; }
        }
        protected Client _client;
        public Client client
        {
            get { return _client; }
            set { _client = value; }
        }
    }
}
