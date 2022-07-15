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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            WireupGridView();
        }

        //
        // this method is executed on clicking add user button
        //
        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();
            if (validateForm(model))
            {
                try
                {
                    if(model.IsAdmin == true)
                    {
                        var confirmResult = MessageBox.Show("Are you sure to create User with Admin functionality ?", "", MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.No)
                        {
                            IsUserRadio.Checked = true;
                            return;
                        }
                    }

                    model.CreateUser();
                    resetForm();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved");
                }
                finally
                {
                    WireupGridView();
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
            else if(passwordText.Text.Length < 6)
            {
                passwordError.Text = "Password must have 6 or more characters.";
                return false;
            }
            else if (confirmPasswordText.Text == "" || confirmPasswordText.Text != passwordText.Text)
            {
                confirmPasswordError.Text = "Passwords do not match.";
                return false;
            }
            else if(UsernameTaken())
            {
                usernameError.Text = "Username already exists. Try another.";
                return false;
            }
            
            else
            {
                model.UserFullName = fullNameText.Text;
                model.Username = usernameText.Text;
                model.Password = passwordText.Text;
                if (IsUserRadio.Checked == true)
                {
                    model.IsAdmin = false;
                }
                if (IsAdminRadio.Checked == true)
                {
                    model.IsAdmin = true;
                }
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

        //
        // this method populates the grid view
        //
        private void WireupGridView()
        {
            try
            {
                userGridView.Rows.Clear();
                UserModel model = new UserModel();
                List<UserModel> Users = model.GetUsers();
                userGridView.ColumnCount = 3;
                userGridView.Columns[0].Name = "ID";
                userGridView.Columns[1].Name = "Full Name";
                userGridView.Columns[2].Name = "Username";
                userGridView.Columns[0].Width = 50;

                userGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                userGridView.ColumnHeadersDefaultCellStyle.Font = new Font(userGridView.Font, FontStyle.Bold);
                userGridView.RowHeadersWidth = 30;

                foreach (UserModel user in Users)
                {
                    userGridView.Rows.Add(user.Id, user.UserFullName, user.Username);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading the existing users from database.");
            }
        }

        //
        // this method deletes the selected user completely
        //
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();
            string name = userGridView.SelectedCells[2].Value.ToString();
            var confirmResult = MessageBox.Show("Are you sure to delete " + name + " ?","", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.No)
            {
                return;
            }

            try
            {
                model.DeleteUser(int.Parse(userGridView.SelectedCells[0].Value.ToString()));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong. User cannot be deleted.");
            }
            finally
            {
                WireupGridView();
            }
        }

        //
        // this method checks if username already exists in the database
        //
        private bool UsernameTaken()
        {
            UserModel model = new UserModel();
            var exist = model.CheckUsername(usernameText.Text);

            if (exist)
            {
                return true;
            }

            else return false;
        }

        private void searchUserTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                userGridView.Rows.Clear();
                UserModel model = new UserModel();
                List<UserModel> Users = model.SearchUser(searchUserTextbox.Text);
                userGridView.ColumnCount = 3;
                userGridView.Columns[0].Name = "ID";
                userGridView.Columns[1].Name = "Full Name";
                userGridView.Columns[2].Name = "Username";
                userGridView.Columns[0].Width = 50;

                foreach (UserModel user in Users)
                {
                    string id = user.Id.ToString();
                    string name = user.UserFullName.ToString();
                    string username = user.Username.ToString();

                    userGridView.Rows.Add(id, name, username);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading the existing users from database.");
            }
        }

    }
}
