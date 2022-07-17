using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int CategoryId { get; set; }
        public int DistributorId { get; set; }
        public int CompanyId { get; set; }
        public string BatchTitle { get; set; }
        public double UnitPrice { get; set; }
        public int Stock { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CategoryName { get; set; }
        public string DistributorName { get; set; }
        public string CompanyName { get; set; }
        public bool IsStock { get; set; }
        public List<BatchModel> ItemBatches { get; set; }
        public void AddItem(ItemModel item)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spItem_Insert", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@ItemName", item.ItemName));
            cmd.Parameters.Add(new SqlParameter("@CategoryId", item.CategoryId));
            cmd.Parameters.Add(new SqlParameter("@DistributorId", item.DistributorId));
            cmd.Parameters.Add(new SqlParameter("@CompanyId", item.CompanyId));
            cmd.Parameters.Add(new SqlParameter("@BatchTitle", item.BatchTitle));
            cmd.Parameters.Add(new SqlParameter("@UnitPrice", item.UnitPrice));
            cmd.Parameters.Add(new SqlParameter("@Stock", item.Stock));
            cmd.Parameters.Add(new SqlParameter("@ExpiryDate", item.ExpiryDate));

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    string errorMessage = rd["ErrorMessage"].ToString();
                    throw new Exception(errorMessage);
                }
            }

            finally
            {
                con.Close();
            }
        }

        public List<ItemModel> GetItems()
        {
            List<ItemModel> itemsList = new List<ItemModel>();
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spItem_GetAll", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ItemModel model = new ItemModel();

                    model.Id = Convert.ToInt32(rd["id"]);
                    BatchModel batchmodel = new BatchModel();
                    model.ItemBatches = batchmodel.GetBatches(model.Id);
                    
                    foreach(BatchModel batch in model.ItemBatches)
                    {
                        ItemModel item = new ItemModel();
                        item.Id = model.Id;
                        item.ItemName = rd["itemName"].ToString();
                        item.BatchTitle = batch.BatchTitle;
                        item.UnitPrice = batch.UnitPrice;
                        item.Stock = batch.ItemStock;
                        item.ExpiryDate = batch.BatchExpiry;
                        item.CategoryName = rd["categoryTitle"].ToString();
                        item.DistributorName = rd["distributorName"].ToString();
                        item.CompanyName = rd["companyName"].ToString();

                        itemsList.Add(item);
                    }
                }

                return itemsList;
            }

            finally
            {
                con.Close();
            }

        }

        public List<ItemModel> SearchItems(string searchStr)
        {
            List<ItemModel> itemsList = new List<ItemModel>();
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spItem_Search", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@searchText", searchStr));

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ItemModel model = new ItemModel();

                    model.Id = Convert.ToInt32(rd["id"]);
                    BatchModel batchmodel = new BatchModel();
                    model.ItemBatches = batchmodel.GetBatches(model.Id);

                    foreach (BatchModel batch in model.ItemBatches)
                    {
                        ItemModel item = new ItemModel();
                        item.Id = model.Id;
                        item.ItemName = rd["itemName"].ToString();
                        item.BatchTitle = batch.BatchTitle;
                        item.UnitPrice = batch.UnitPrice;
                        item.Stock = batch.ItemStock;
                        item.ExpiryDate = batch.BatchExpiry;
                        item.CategoryName = rd["categoryTitle"].ToString();
                        item.DistributorName = rd["distributorName"].ToString();
                        item.CompanyName = rd["companyName"].ToString();

                        itemsList.Add(item);
                    }
                }

                return itemsList;
            }

            finally
            {
                con.Close();
            }

        }
        public void DeleteItem(int id)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spItem_DeleteById", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
            }
        }

        public void DeleteSingleBatch(string batchTitle)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spBatch_DeleteSingle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@batchTitle", batchTitle));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public int ItemExists(string itemName)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spItem_ItemExists", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@itemName", itemName));

            int Id = new int();
            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Id = Convert.ToInt32(rd["id"]);
                }

                return Id;
            }

            finally
            {
                con.Close();
            }
        }

        public void NewBatch(ItemModel item)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spBatch_NewBatch", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", item.Id));
            cmd.Parameters.Add(new SqlParameter("@batch", item.BatchTitle));
            cmd.Parameters.Add(new SqlParameter("@stock", item.Stock));
            cmd.Parameters.Add(new SqlParameter("@expiry", item.ExpiryDate));
            cmd.Parameters.Add(new SqlParameter("@unitPrice", item.UnitPrice));
            cmd.Parameters.Add(new SqlParameter("@IsStock", item.IsStock));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
    }

}
