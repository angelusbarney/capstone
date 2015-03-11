using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSTN_ProductManagement
{
    public abstract class dbColumn
    {

        protected int _id;
        public int id { get { return _id; } set { _id = value; } }

        protected String _name;
        public String name { get { return _name; } set { _name = value; } }
    }
}
