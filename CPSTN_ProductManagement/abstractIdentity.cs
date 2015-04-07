using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSTN_ProductManagement
{
    public abstract class abstractIdentity : dbColumn
    {
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
        public string Country
        {
            get
            {
                return _Country;
            }
            set
            {
                _Country = value;
            }
        }
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                _City = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = value;
            }
        }

        private string _PhoneNumber;
        private string _Address;
        private string _City;
        private string _Country;

    }
}
