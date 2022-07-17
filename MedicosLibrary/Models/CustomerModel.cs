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
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public double Balance { get; set; }

        public void AddCustomer()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCustomer_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@name", CustomerName));
            cmd.Parameters.Add(new SqlParameter("@contact", CustomerContact));
            cmd.Parameters.Add(new SqlParameter("@balance", Balance));
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

        public CustomerModel GetSingleCustomer(int id)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCustomer_GetSingle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));

            try
            {
                CustomerModel customer = new CustomerModel();
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    customer.Id = Convert.ToInt32(rd["id"]);
                    customer.CustomerName = rd["fullName"].ToString();
                    customer.CustomerContact = rd["contact"].ToString();
                    customer.Balance = Convert.ToDouble(rd["balance"]);
                }

                return customer;
            }

            finally
            {
                con.Close();
            }
        }
        public List<CustomerModel> GetCustomers()
        {
            List<CustomerModel> customersList = new List<CustomerModel>();

            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCustomer_GetAll", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    CustomerModel model = new CustomerModel();
                    model.Id = Convert.ToInt32(rd["id"]);
                    model.CustomerName = rd["fullName"].ToString();
                    model.CustomerContact = rd["contact"].ToString();
                    model.Balance = Convert.ToDouble(rd["balance"]);

                    customersList.Add(model);
                }

                return customersList;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteCustomer(int id)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCustomer_DeleteById", con);
            cmd.CommandType = CommandType.StoredProcedure;

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
    }
}
