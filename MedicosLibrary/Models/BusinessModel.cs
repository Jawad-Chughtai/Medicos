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

        public BusinessModel GetDetails()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spReceiptDetails_GetDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                BusinessModel model = new BusinessModel();
                while (rd.Read())
                {
                    model.BusinessName = rd["storeName"].ToString();
                    model.Address = rd["contact"].ToString();
                    model.Contact = rd["address"].ToString();
                    model.BottomLine = rd["bottomLine"].ToString();
                }
                return model;
            }
            finally
            {
                con.Close();
            }
        }
        
        public bool Update(BusinessModel model)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spReceiptDetails_Update", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Name", model.BusinessName));
            cmd.Parameters.Add(new SqlParameter("@Contact", model.Contact));
            cmd.Parameters.Add(new SqlParameter("@Address", model.Address));
            cmd.Parameters.Add(new SqlParameter("@BottomLine", model.BottomLine));
            cmd.Parameters.Add(new SqlParameter("@Image", model.Image));

            try
            {
                con.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    return true;
                }
            }
            finally
            {
                con.Close();

            }

            return false;
        }
    }
}
