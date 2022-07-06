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
        public int Id { get; set; }
        public string DistributorName { get; set; }
        public string Contact { get; set; }

        public void AddDistributor()
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

        public List<DistributorModel> GetDistributors()
        {
            List<DistributorModel> distributorsList = new List<DistributorModel>();
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spDistributor_GetAll", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    DistributorModel model = new DistributorModel();
                    model.Id = Convert.ToInt32(rd["id"]);
                    model.DistributorName = rd["distributorName"].ToString();
                    model.Contact = rd["distributorContact"].ToString();
                    distributorsList.Add(model);
                }

                return distributorsList;
            }

            finally
            {
                con.Close();
            }
        }

        public void DeleteDistributor(int id)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spDistribuor_DeleteById", con);
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
    }
}
