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
        public int Id { get; set; } 
        public string UserFullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        //************ This method creates the user model taken from the front end into the database ******************
        public void CreateUser()
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

        //************ This method returns the list of all the users in the database ******************
        public List<UserModel> GetUsers()
        {
            List<UserModel> UserList = new List<UserModel>();

            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spUser_GetAll", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    UserModel model = new UserModel();
                    model.Id = Convert.ToInt32(rd["id"]);
                    model.UserFullName = rd["userFullName"].ToString();
                    model.Username = rd["username"].ToString();
                    UserList.Add(model);
                }
                return UserList;
            }

            finally
            {
                con.Close();
            }
        }

        //************ This method deletes the user from the database ******************
        public void DeleteUser(int id)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spUser_DeleteById", con);
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

        //************ This method checks if the username already exists in the databases ******************
        public bool CheckUsername(string username)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spUser_CheckUsername", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@username", username));

            con.Open();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            finally
            {
                con.Close();
            }
        }
    }
}
