using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSTN_ProductManagement
{
    public class Supply : dbColumn
    {
        ProductDataSetTableAdapters.SupplyTableAdapter dbAdapter;
        objectCounter listedData;
        public void getProperties()
        {
            ProductDataSet.SupplyDataTable data = dbAdapter.GetData();
            this.name = data.FindById(this.id).Name;
            this.price = data.FindById(this.id).Price;
            this.supplier = listedData.fetchSupplier(data.FindById(this.id).Supplier);
        }
        public void setProperties()
        {
            ProductDataSet.SupplyDataTable data = dbAdapter.GetData();
            data.FindById(this.id).Name = this.name;
            data.FindById(this.id).Price = this.price;
            data.FindById(this.id).Supplier = this.supplier.id; 
            data.AcceptChanges();
        }
        public Supply(objectCounter list, int ID)
        {
            listedData = list; 
            this._id = ID; 
        }

        public Supply()
        {

        }

        protected decimal _price;
        public decimal price
        {
            get { return _price; }
            set { _price = value; }
        }

        protected Supplier _supplier;
        public Supplier supplier { 
            get {return _supplier;}
            set { _supplier = value;}
        }
    }
}
