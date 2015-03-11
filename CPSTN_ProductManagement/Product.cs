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
        }

        ProductDataSetTableAdapters.ProductTableAdapter dbAdapter;
        ProductDataSetTableAdapters.ProductSupplyTableAdapter dbSupplyAdapter;
        objectCounter listedData;
        public void getProperties()
        {
            ProductDataSet.ProductDataTable data = dbAdapter.GetData();
            ProductDataSet.ProductSupplyDataTable dataSupply = dbSupplyAdapter.GetData();
            this.name = data.FindById(this.id).Name;
        }
        public void setProperties()
        {
            ProductDataSet.ProductDataTable data = dbAdapter.GetData();
            data.FindById(this.id).Name = this.name;
            data.AcceptChanges();
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
