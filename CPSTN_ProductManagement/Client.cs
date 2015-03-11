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
        public void getProperties()
        {
            ProductDataSet.ClientDataTable data = dbAdapter.GetData();
            this.name = data.FindById(this.id).Name;
            this.Address = data.FindById(this.id).Address;
            this.City = data.FindById(this.id).City;
            this.Country = data.FindById(this.id).Country;
            this.PhoneNumber = data.FindById(this.id).Phone;
            this.Email = data.FindById(this.id).Email;
        }
        public void setProperties()
        {
            ProductDataSet.ClientDataTable data = dbAdapter.GetData();
            data.FindById(this.id).Name = this.name;
            data.FindById(this.id).Address = this.Address;
            data.FindById(this.id).City = this.City;
            data.FindById(this.id).Country = this.Country;
            data.FindById(this.id).Phone = this.PhoneNumber;
            data.FindById(this.id).Email = this.Email;
            data.AcceptChanges();
        }
        public Client(int ID)
        {
            dbAdapter.Connection.Open();
            this._id = ID; 
        }

        public Client()
        {
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
