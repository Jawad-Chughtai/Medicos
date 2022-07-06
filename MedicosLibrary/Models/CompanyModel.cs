using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MedicosLibrary.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }


        public void accessDatabase()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCompany_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@companyName", CompanyName));

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

        public List<CompanyModel> GetCompanies()
        {
            List<CompanyModel> companyList = new List<CompanyModel>();

            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCompany_GetAll", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    CompanyModel company = new CompanyModel();
                    company.Id = Convert.ToInt32(rd["id"]);
                    company.CompanyName = rd["companyName"].ToString();

                    companyList.Add(company);
                }

                return companyList;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteCompany(int id)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCompany_DeleteById", con);
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
