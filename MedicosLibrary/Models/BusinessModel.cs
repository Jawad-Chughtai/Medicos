using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class BusinessModel
    {
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string BottomLine { get; set; }
        public string Image { get; set; }

        public void Create()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spReceiptDetails_Create", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@storename", BusinessName));
            cmd.Parameters.Add(new SqlParameter("@address", Address));
            cmd.Parameters.Add(new SqlParameter("@contact", Contact));
            cmd.Parameters.Add(new SqlParameter("@bottomline", BottomLine));
            cmd.Parameters.Add(new SqlParameter("@img", Image));

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
