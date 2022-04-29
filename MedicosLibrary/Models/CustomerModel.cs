using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class CustomerModel
    {
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }

        public void accessDatabase()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand("@spCustomer_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@customerName", CustomerName));
            cmd.Parameters.Add(new SqlParameter("@customerContact", CustomerContact));

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
