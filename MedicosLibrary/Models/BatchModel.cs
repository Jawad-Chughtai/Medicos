using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class BatchModel
    {
        public string BatchTitle { get; set; }
        public DateTime BatchExpiry { get; set; }
        public double UnitPrice { get; set; }
        public int ItemStock { get; set; }
        public bool IsStock { get; set; }
        public List<BatchModel> GetBatches(int id)
        {
            List<BatchModel> Batches = new List<BatchModel>();
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spBatch_GetByItem", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    BatchModel batch = new BatchModel();
                    batch.BatchTitle = rd["batchTitle"].ToString();
                    batch.BatchExpiry = Convert.ToDateTime(rd["expiry"]);
                    batch.UnitPrice = Convert.ToDouble(rd["unitPrice"]);
                    batch.ItemStock = Convert.ToInt32(rd["stock"]);
                    
                    Batches.Add(batch);
                }
                return Batches;
            }

            finally
            {
                con.Close();
            }
        }
    }
}
