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
    public class MaterialMapper
    {





        /// <summary>
        /// Returns all Materials in list form,
        /// this is used for display purposes.
        /// </summary>
        /// <returns></returns>
        public static List<Material> getAllMaterials()
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "mm_getAllMaterials";
            SqlParameter[] sps = null;
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            List<Material> materials = new List<Material>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Material tempMat = new Material();
                tempMat.Name = dr["material_name"].ToString();
                tempMat.MaterialID = System.Convert.ToInt16(dr["material_id"]);
                materials.Add(tempMat);
            }//end forEach
            return materials;
        }

        public static Material getMaterialById(Material m)
        {

            DataAccess objDA = new DataAccess();
            string storedProcedureName = "mm_GetMaterialById";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", m.MaterialID);
            DataSet ds = DataAccess.GetDataSet(storedProcedureName, sps);
            m.Name = ds.Tables[0].Rows[0]["material_name"].ToString();
            m.MaterialID = System.Convert.ToInt16(ds.Tables[0].Rows[0]["material_id"]);
            m.Description = ds.Tables[0].Rows[0]["material_description"].ToString();
            m.Cost = System.Convert.ToDecimal(ds.Tables[0].Rows[0]["material_cost"]);
            return m;
        }



        /// <summary>
        /// Take an input ID, and deletes that item.
        /// </summary>
        /// <param name="m"></param>
        public static void deleteMaterial(Material m)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedure = "mm_deleteMaterial";
            SqlParameter[] sps = new SqlParameter[1];
            sps[0] = new SqlParameter("@id", m.MaterialID);
            objDA.modifyDb(CommandType.StoredProcedure, storedProcedure, sps);
        }


        public static int updateMaterial(Material m)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "mm_UpdateMaterial";
            SqlParameter[] sps = new SqlParameter[5];
            sps[0] = new SqlParameter("@incomingName", m.Name);
            sps[1] = new SqlParameter("@incomingDescription", m.Description);
            sps[2] = new SqlParameter("@incomingVendorID", m.VendorId);
            sps[3] = new SqlParameter("@incomingCost", m.Cost);
            sps[4] = new SqlParameter("@id", m.MaterialID);
            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }



        public static int inserMaterial(Material m)
        {
            DataAccess objDA = new DataAccess();
            string storedProcedureName = "mm_insertMaterial";
            SqlParameter[] sps = new SqlParameter[4];
            sps[0] = new SqlParameter("@incomingName", m.Name);
            sps[1] = new SqlParameter("@incomingDescription", m.Description);
            sps[2] = new SqlParameter("@incomingVendorID", m.VendorId);
            sps[3] = new SqlParameter("@incomingCost", m.Cost);
            return objDA.modifyDb(CommandType.StoredProcedure, storedProcedureName, sps);
        }





    }
}
