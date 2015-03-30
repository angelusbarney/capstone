using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSTN_ProductManagement
{
    public class Product : dbColumn
    {
        public Product(objectCounter list, int ID)
        {
            listedData = list;
            this._id = ID;
            dbAdapter = new ProductDataSetTableAdapters.ProductTableAdapter();
            dbAdapter.Connection.Open();
            getProperties();

            listedData.removeProduct(_index);
            _index = listedData.registerProduct(this);
        }

        protected int _index;

        ProductDataSetTableAdapters.ProductTableAdapter dbAdapter;
        /* ProductDataSetTableAdapters.ProductSupplyTableAdapter dbSupplyAdapter; */
        objectCounter listedData;
        public void getProperties()
        {
            ProductDataSet.ProductDataTable data = dbAdapter.GetData();
            /*
            ProductDataSet.ProductSupplyDataTable dataSupply = dbSupplyAdapter.GetData();
             */
            try
            {
                this.name = data.FindById(this.id).Name;
                this.price = data.FindById(this.id).Price;
                this.enddate = data.FindById(this.id).EndDate;
            }
            catch (Exception e)
            {

            }

            listedData.removeProduct(_index);
            _index = listedData.registerProduct(this);
        }

        public int getMax()
        {
            ProductDataSet.ProductDataTable data = dbAdapter.GetData();
            return Convert.ToInt32(data.Select("ID = MAX(ID)")[0]["Id"]);
        }
        public void setProperties()
        {
            ProductDataSet.ProductDataTable data = dbAdapter.GetData();
            try
            {
                data.FindById(this.id).Name = this.name;
                data.FindById(this.id).Price = this.price;
                data.FindById(this.id).EndDate = this.enddate;
                data.AcceptChanges();
            }
            catch (Exception e)
            {

            }

            listedData.removeProduct(_index);
            _index = listedData.registerProduct(this);
        }

        public void create()
        {
            ProductDataSet.ProductDataTable data = dbAdapter.GetData();
            System.Data.DataRow dataRow = data.NewRow();
            dataRow["Name"] = this.name;
            dataRow["Price"] = this.price;
            dataRow["EndDate"] = this.enddate;

            dataRow.AcceptChanges();
        }

        protected decimal _price;
        public decimal price
        {
            get { return _price; }
            set { _price = value; }
        }

        protected DateTime _enddate;
        public DateTime enddate
        {
            get { return _enddate; }
            set { _enddate = value; }
        }

        /*
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
        */

        public Product()
        {
            dbAdapter = new ProductDataSetTableAdapters.ProductTableAdapter();
            dbAdapter.Connection.Open();
        }
    }
}
