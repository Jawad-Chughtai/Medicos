using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class DistributorModel
    {
        public string DistributorName { get; set; }
        public string Contact { get; set; }

        public void accessDatabase()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spDistributor_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@distributor", DistributorName));
            cmd.Parameters.Add(new SqlParameter("@contact", Contact));

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
