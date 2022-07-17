using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class POSModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double ItemTotal { get; set; }
        public int Stock { get; set; }
        public string Batch { get;set; }
        public DateTime Expiry { get; set; }
        public string Company { get; set; }
        public string ListItem { get; set; } //Used for concatenation of ItemName and Batch
        public List<BatchModel> Batches { get; set; }

        public List<POSModel> GetItems(string search)
        {
            var items = new List<POSModel>();
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spPOS_GetItems", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@search", search));

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    POSModel POS = new POSModel();
                    POS.ItemId = Convert.ToInt32(rd["id"]);
                    BatchModel model = new BatchModel();
                    Batches = model.GetBatches(POS.ItemId);
                    foreach (var batch in Batches)
                    {
                        POSModel item = new POSModel();
                        item.ItemId = POS.ItemId;
                        item.ItemName = rd["itemName"].ToString();
                        item.Batch = batch.BatchTitle;
                        item.Stock = batch.ItemStock;
                        item.ListItem = item.ItemName + " " + item.Batch;

                        items.Add(item);
                    }
                }

                return items;
            }

            finally
            {
                con.Close();
            }
        }
        
        public POSModel GetItemName(int id, string batchTitle)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spPOS_GetItemName", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@batchTitle", batchTitle));
            try
            {
                POSModel model = new POSModel();
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    model.ItemId = Convert.ToInt32(rd["id"]);
                    model.ItemName = rd["itemName"].ToString();
                    model.Batch = rd["batchTitle"].ToString();
                    model.Stock = Convert.ToInt32(rd["stock"]);
                    model.UnitPrice = Convert.ToDouble(rd["unitPrice"]);

                }

                return model;

            }

            finally
            {
                con.Close();
            }
        }

        public POSModel GetItemDetails(int id, string batchTitle)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spPOS_GetItemDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@batchTitle", batchTitle));

            try
            {
                POSModel model = new POSModel();
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    model.ItemId = Convert.ToInt32(rd["id"]);
                    model.ItemName = rd["itemName"].ToString();
                    model.Batch = rd["batchTitle"].ToString();
                    model.Stock = Convert.ToInt32(rd["stock"]);
                    model.UnitPrice = Convert.ToDouble(rd["unitPrice"]);
                    model.Expiry = Convert.ToDateTime(rd["expiry"]);
                    model.Company = rd["companyName"].ToString();
                    model.ListItem = model.ItemName + " " + model.Batch;

                }

                return model;
            }

            finally
            {
                con.Close();
            }
        }
    }
}
