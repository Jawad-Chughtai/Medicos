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
        public int Stock { get; set; }
        public string Batch { get;set; }
        public DateTime Expiry { get; set; }
        public string Company { get; set; }
        public string ListItem { get; set; } //Used for concatenation of ItemName and Batch

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
                    POSModel model = new POSModel();
                    model.ItemId = Convert.ToInt32(rd["id"]);
                    model.ItemName = rd["itemName"].ToString();
                    model.Batch = rd["batchTitle"].ToString();
                    model.Stock = Convert.ToInt32(rd["stock"]);
                    model.ListItem = model.ItemName + "  " + model.Batch;

                    items.Add(model);
                }

                return items;
            }

            finally
            {
                con.Close();
            }
        }
        
        public POSModel GetItemName(int id)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spPOS_GetItemName", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id", id));

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

        public POSModel GetItemDetails(int id)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spPOS_GetItemDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id", id));

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
