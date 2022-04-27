using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MedicosLibrary.Models
{
    public class UserModel
    {
        public string UserFullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void accessDatabase()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spUser_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@fullname", UserFullName));
            cmd.Parameters.Add(new SqlParameter("@username", Username));
            cmd.Parameters.Add(new SqlParameter("@password", Password));

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

    }
}
