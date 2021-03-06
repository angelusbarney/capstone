﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSTN_ProductManagement
{
    public class Supplier : abstractIdentity
    {
        ProductDataSetTableAdapters.SupplierTableAdapter dbAdapter;
        public void getProperties()
        {
            ProductDataSet.SupplierDataTable data = dbAdapter.GetData();
            this.name = data.FindById(this.id).Name;
            this.Address = data.FindById(this.id).Address;
            this.City = data.FindById(this.id).City;
            this.Country = data.FindById(this.id).Country;
            this.PhoneNumber = data.FindById(this.id).Phone;
        }
        public void setProperties()
        {
            ProductDataSet.SupplierDataTable data = dbAdapter.GetData();
            data.FindById(this.id).Name = this.name;
            data.FindById(this.id).Address = this.Address;
            data.FindById(this.id).City = this.City;
            data.FindById(this.id).Country = this.Country;
            data.FindById(this.id).Phone = this.PhoneNumber;
            data.AcceptChanges();
        }
        public Supplier(int ID)
        {
            dbAdapter.Connection.Open();
            this._id = ID; 
        }

        public Supplier()
        {
            dbAdapter.Connection.Open();

        }

        
    }
}
