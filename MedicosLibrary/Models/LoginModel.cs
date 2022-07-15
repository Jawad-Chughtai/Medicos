using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace MedicosLibrary.Models
{
    public class LoginModel
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsLoginSuccessfull { get; set; }

        public bool CheckExistingUser()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spUser_GetAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                return !rd.Read() ? false : true;

            }
            finally
            {
                con.Close();
            }
        }

        public LoginModel Login(LoginModel model)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@username", model.Username));
            cmd.Parameters.Add(new SqlParameter("@password", model.Password));

            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    model.UserId = Convert.ToInt32(rd["id"]);
                    model.Username = rd["username"].ToString();
                    model.FullName = rd["userFullName"].ToString();
                    model.Password = "";
                    model.IsAdmin = Convert.ToBoolean(rd["IsAdmin"]);
                    model.IsLoginSuccessfull = true;
                    return model;
                }

                else
                {
                    model.Username = "";
                    model.Password = "";
                    model.IsLoginSuccessfull = false;
                    return model;
                }
            }

            finally
            {
                con.Close();
            }
        }
    }
}
