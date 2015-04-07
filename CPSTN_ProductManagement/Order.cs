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
            try
            {
                this.client = listedData.fetchClient(data.FindById(this.id).Client);
                this.product = listedData.fetchProduct(data.FindById(this.id).Product);
                this.count = data.FindById(this.id).Quantity;
            }
            catch (Exception e)
            {

            }
        }
        public void setProperties()
        {
            ProductDataSet.ProductOrderDataTable data = dbAdapter.GetData();
            try
            {
                data.FindById(this.id).Quantity = this.count;
                data.FindById(this.id).Client = this.client.id;
                data.FindById(this.id).Product = this.product.id;
                data.AcceptChanges();
            }
            catch (Exception e)
            {

            }
        }

        public int getMax()
        {
            ProductDataSet.ProductOrderDataTable data = dbAdapter.GetData();
            return Convert.ToInt32(data.Select("ID = MAX(ID)")[0]["Id"]);
        }

        public Order(objectCounter list, int ID)
        {
            dbAdapter = new ProductDataSetTableAdapters.ProductOrderTableAdapter();
            dbAdapter.Connection.Open();
            listedData = list;
            this._id = ID;
        }

        public Order()
        {
            dbAdapter = new ProductDataSetTableAdapters.ProductOrderTableAdapter();
            dbAdapter.Connection.Open();
        }

        protected DateTime _orderDate;
        public DateTime orderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        protected bool _orderPaid;
        public bool orderPaid
        {
            get { return _orderPaid; }
            set { _orderPaid = value; }
        }

        protected int _count;
        public int count
        {
            get { return _count; }
            set { _count = value; }
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
