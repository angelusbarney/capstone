using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class ProductMapper
    {

        public static List<Product> getAllProducts()
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "pp_getAllProducts";
            SqlParameter[] sps = null;
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<Product> prods = new List<Product>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Product tempProd = new Product();
                tempProd.Name = dr["product_name"].ToString();
                tempProd.ProductlID = System.Convert.ToInt16(dr["product_id"]);
                prods.Add(tempProd);
            }//end forEach
            return prods;
        }

        public static Product getProductById(Product p)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "pp_GetProductById";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", p.ProductlID);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            p.Name = ds.Tables[0].Rows[0]["product_name"].ToString();
            p.ProductlID = System.Convert.ToInt16(ds.Tables[0].Rows[0]["product_id"]);
            p.Description = ds.Tables[0].Rows[0]["product_description"].ToString();
            p.RetailPrice = System.Convert.ToDecimal(ds.Tables[0].Rows[0]["product_price"]);
            return p;
        }

        public static int addProductReqMaterial(Product p, Material m, int x)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "bom_InsertProductMaterial";
            SqlParameter[] sps = new SqlParameter[3];
            sps[0] = new SqlParameter("@ProductID", p.ProductlID);
            sps[1] = new SqlParameter("@MaterialID", m.MaterialID);
            sps[2] = new SqlParameter("@Quantity", x);
            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        //public static List<Material> getMaterialsRequired(Product p)
        public static List<int> getMaterialsRequired(Product p)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "bom_getRequiredMaterials";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@productID", p.ProductlID);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<int> materials = new List<int>();
            //List<Material> materials = new List<Material>();
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                int tempMat = Int32.Parse(dr["bom_materialId"].ToString());
                int test;

                //Material tempMat = new Material(Int32.Parse(dr["bom_materialId"].ToString()));
                materials.Add(tempMat);

                test = Int32.Parse(dr["bom_quantity"].ToString());
                materials.Add(test);

            }
            return materials;
        }

        public static int updateProduct(Product p)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "pp_UpdateProduct";
            SqlParameter[] sps = new SqlParameter[4];
            sps[0] = new SqlParameter("@IncomingId", p.ProductlID);
            sps[1] = new SqlParameter("@IncomingName", p.Name);
            sps[2] = new SqlParameter("@IncomingDescription", p.Description);
            sps[3] = new SqlParameter("@RetailPrice", p.RetailPrice);
            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        public static void deleteMaterialFromProduct(Product p, Material m)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "bom_RemoveMaterial";
            SqlParameter[] sps = new SqlParameter[2];
            sps[0] = new SqlParameter("@MaterialID", m.MaterialID);
            sps[1] = new SqlParameter("@ProductID", p.ProductlID);
            objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        public static int insertProduct(Product p)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "pp_insertProduct";
            SqlParameter[] sps = new SqlParameter[3];
            sps[0] = new SqlParameter("@incomingProductName", p.Name);
            sps[1] = new SqlParameter("@incomingProductDesc", p.Description);
            sps[2] = new SqlParameter("@incomingCost", p.RetailPrice);
            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }

        public static void deleteProduct(Product p)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "pp_deleteProduct";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", p.ProductlID);
            objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }


    }
}
