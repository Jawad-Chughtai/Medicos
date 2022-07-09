using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MedicosLibrary.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public void accessDatabase()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCategory_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@category", CategoryName));

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

        public List<CategoryModel> GetCategories()
        {
            List<CategoryModel> Categories = new List<CategoryModel>();

            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCategory_GetAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    CategoryModel category = new CategoryModel();
                    category.Id = Convert.ToInt32(rd["id"]);
                    category.CategoryName = rd["categoryTitle"].ToString();
                    Categories.Add(category);
                }

                return Categories;
            }

            finally
            {
                con.Close();
            }
        }

        public void DeleteCategory(int id) 
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCategory_DeleteById", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id", id));
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public List<CategoryModel> Search(string text)
        {
            List<CategoryModel> Categories = new List<CategoryModel>();

            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCategory_Search", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter(@"text", text));
            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    CategoryModel category = new CategoryModel();
                    category.Id = Convert.ToInt32(rd["id"]);
                    category.CategoryName = rd["categoryTitle"].ToString();
                    Categories.Add(category);
                }

                return Categories;
            }

            finally
            {
                con.Close();
            }
        }
    }
}
