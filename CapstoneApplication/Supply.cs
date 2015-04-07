using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneApplication
{
    class Supply : dbColumn
    {
        public Supply(String name)
        {
            this.name = name; 
        }

        public Supply()
        {

        }

        protected Supplier _supplier;
        public Supplier supplier { 
            get {return _supplier;}
            set { _supplier = value;}
        }
    }
}
