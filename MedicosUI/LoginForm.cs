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
    public partial class LoginForm : Form
    {
        public static int UserId { get; set; }
        public string Username { get; set; }
        public bool IsAdmin { get; set; }
        public string FullName { get; set; }
        public LoginForm()
        {
            InitializeComponent();

        }
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (!CheckExistingUser())
            {
                FirstUserForm obj = new FirstUserForm();
                obj.Show();
            }
        }
        private bool CheckExistingUser()
        {
            try
            {
                LoginModel login = new LoginModel();
                return login.CheckExistingUser();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Application can not run.");
                return true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginModel login = new LoginModel();
            login.Username = usernameTextbox.Text;
            login.Password = passwordTextbox.Text;
            try
            {
                login = login.Login(login);

                if (!login.IsLoginSuccessfull)
                {
                    MessageBox.Show("Invalid Username or Password");
                    return;
                }

                else
                {
                    UserId = login.UserId;
                    Username = login.Username;
                    IsAdmin = login.IsAdmin;
                    FullName = login.FullName;
                    DashboardForm dashboardForm = new DashboardForm(UserId, Username, FullName, IsAdmin);
                    dashboardForm.Show();
                    this.Hide();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("An error occured while logging in.");
            }
        }

        private void passwordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                loginButton_Click(sender, new EventArgs());
            }
        }

    }
}
