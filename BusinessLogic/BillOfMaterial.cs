using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BillOfMaterial
    {

        int boMId;
        int productID;
        int materialId;
        int quantity;

        public BillOfMaterial() { }
        public BillOfMaterial(int id, int matid, int quant)
        {
            this.boMId = id;
            this.materialId = matid;
            this.quantity = quant;

        }


        public int BoMId
        {
            get { return boMId; }
            set { boMId = value; }
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public int MaterialId
        {
            get { return materialId; }
            set { materialId = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }










        public static List<BillOfMaterial> testing(Product p)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "bom_getBomById";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@incomingId", p.ProductlID);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<BillOfMaterial> materials = new List<BillOfMaterial>();
            //List<Material> materials = new List<Material>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                BillOfMaterial test = new BillOfMaterial();
                test.MaterialId = System.Convert.ToInt32(dr["bom_materialId"].ToString());
                test.productID = System.Convert.ToInt32(dr["bom_productId"].ToString());
                test.Quantity = System.Convert.ToInt32(dr["bom_quantity"].ToString());
                test.BoMId = System.Convert.ToInt32(dr["bom_id"].ToString());
                //Material tempMat = new Material(Int32.Parse(dr["bom_materialId"].ToString()));
                materials.Add(test);
            }
            return materials;
        }//end 
    }
}
