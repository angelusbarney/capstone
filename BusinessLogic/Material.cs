using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class Material
    {


        int materialId;
        int vendorId;
        string name = String.Empty;
        string description = String.Empty;
        
        Decimal cost;

        public Material() { }

        public Material(int id)
        {
            materialId = id;
        }

        public int MaterialID 
        { 
            get { return materialId; }
            set { materialId = value; }
        }

        public int VendorId
        {
            get { return vendorId; }
            set { vendorId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

    }
}
