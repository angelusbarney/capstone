using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneApplication
{
    abstract class dbColumn
    {
        protected String _name;
        public String name { get { return _name; } set { _name = value; } }
    }
}
