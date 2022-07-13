using MedicosLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicosUI
{
    public partial class FirstUserForm : Form
    {
        public FirstUserForm()
        {
            InitializeComponent();
            fullNameText.Select();
        }

        private void FirstUserForm_Load(object sender, EventArgs e)
        {
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();
            if (validateForm(model))
            {
                try
                {
                    model.CreateUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved");
                }
                finally
                {
                    resetForm();
                    this.Close();
                }
            }
        }
        //
        // method to validate user details
        //
        private bool validateForm(UserModel model)
        {
            fullNameError.Text = "";
            usernameError.Text = "";
            passwordError.Text = "";
            confirmPasswordError.Text = "";
            if (fullNameText.Text == "")
            {
                fullNameError.Text = "Full name can not be empty.";
                return false;
            }
            else if (fullNameText.Text.Length < 3)
            {
                fullNameError.Text = "Invalid Full name";
                return false;
            }
            else if (usernameText.Text == "")
            {
                usernameError.Text = "Username can not be empty.";
                return false;
            }
            else if (usernameText.Text.Length < 4)
            {
                usernameError.Text = "Username must have 4 or more characters.";
                return false;
            }
            else if (passwordText.Text == "")
            {
                passwordError.Text = "Password can not be empty";
                return false;
            }
            else if (passwordText.Text.Length < 6)
            {
                passwordError.Text = "Password must have 6 or more characters.";
                return false;
            }
            else if (confirmPasswordText.Text == "" || confirmPasswordText.Text != passwordText.Text)
            {
                confirmPasswordError.Text = "Passwords do not match.";
                return false;
            }
            else
            {
                model.UserFullName = fullNameText.Text;
                model.Username = usernameText.Text;
                model.Password = passwordText.Text;
                model.IsAdmin = true;
                return true;
            }
        }

        //
        // method to reset the form
        //
        private void resetForm()
        {
            //reset the textboxes
            fullNameText.Text = "";
            usernameText.Text = "";
            passwordText.Text = "";
            confirmPasswordText.Text = "";

            //reset the error messages
            fullNameError.Text = "";
            usernameError.Text = "";
            passwordError.Text = "";
            confirmPasswordError.Text = "";
        }


    }
}
