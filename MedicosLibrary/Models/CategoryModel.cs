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
    }
}
