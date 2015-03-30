using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSTN_ProductManagement
{
    public class Client : abstractIdentity
    {
        ProductDataSetTableAdapters.ClientTableAdapter dbAdapter;

        protected int _index;
        public void getProperties()
        {
            ProductDataSet.ClientDataTable data = dbAdapter.GetData();
            try
            {
                this.name = data.FindById(this.id).Name;
                this.Address = data.FindById(this.id).Address;
                this.City = data.FindById(this.id).City;
                this.Country = data.FindById(this.id).Country;
                this.PhoneNumber = data.FindById(this.id).Phone;
                this.Email = data.FindById(this.id).Email;
            }
            catch (Exception e)
            {

            }

            listedData.removeClient(_index);
            _index = listedData.registerClient(this);
        }
        public int getMax()
        {
            ProductDataSet.ClientDataTable data = dbAdapter.GetData();
            return Convert.ToInt32(data.Select("ID = MAX(ID)")[0]["Id"]);
        }
        public void setProperties()
        {
            ProductDataSet.ClientDataTable data = dbAdapter.GetData();
            try
            {
                data.FindById(this.id).Name = this.name;
                data.FindById(this.id).Address = this.Address;
                data.FindById(this.id).City = this.City;
                data.FindById(this.id).Country = this.Country;
                data.FindById(this.id).Phone = this.PhoneNumber;
                data.FindById(this.id).Email = this.Email;
                data.AcceptChanges();
            }
            catch (Exception e)
            {

            }
        }

        public void create()
        {
            ProductDataSet.ClientDataTable data = dbAdapter.GetData();
            System.Data.DataRow dataRow = data.NewRow();
            dataRow["Name"] = this.name;
            dataRow["Address"] = this.Address;
            dataRow["City"] = this.City;
            dataRow["Country"] = this.Country;
            dataRow["PhoneNumber"] = this.PhoneNumber;
            dataRow["Email"] = this.Email;

            dataRow.AcceptChanges();
        }

        objectCounter listedData;
        public Client(objectCounter list, int ID)
        {
            listedData = list;
            dbAdapter = new ProductDataSetTableAdapters.ClientTableAdapter();
            dbAdapter.Connection.Open();
            this._id = ID;
        }

        public Client()
        {
            dbAdapter = new ProductDataSetTableAdapters.ClientTableAdapter();
            dbAdapter.Connection.Open();

        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        private string _Email;
    }
}
