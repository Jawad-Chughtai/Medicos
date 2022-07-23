using MedicosLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicosUI
{
    public partial class FirstUserForm : Form
    {
        string FileName { get; set; } = "";
        public FirstUserForm()
        {
            InitializeComponent();
            fullNameText.Select();
        }

        private void FirstUserForm_Load(object sender, EventArgs e)
        {
        }
        private void addUserButton_Click_1(object sender, EventArgs e)
        {
            UserModel model = new UserModel();
            BusinessModel business = new BusinessModel();

            if (validateForm(model, business))
            {
                try
                {
                    model.CreateUser();
                    business.Create();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved");
                }
                finally
                {
                    resetForm();
                   // Close();
                }
            }
        }
        //
        // method to validate user details
        //
        private bool validateForm(UserModel model, BusinessModel business)
        {
            fullNameError.Text = "";
            usernameError.Text = "";
            passwordError.Text = "";
            confirmPasswordError.Text = "";
            businessNameLabel.Text = "";
            businessAddressLabel.Text = "";
            businessContactLabel.Text = "";
            businessNoteLabel.Text = "";


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
            else if (businessNameTextbox.Text.Length < 3)
            {
                businessNameLabel.Text = "Business Name Error.";
                return false;
            }
            else if (addressTextbox.Text.Length < 3)
            {
                businessAddressLabel.Text = "Address Error.";
                return false;
            }
            else if (contactTextbox.Text.Length < 3)
            {
                businessContactLabel.Text = "Contact Error.";
                return false;
            }
            else if (bottomNoteTextbox.Text.Length < 3)
            {
                businessNoteLabel.Text = "Bottom Note Error.";
                return false;
            }
            else if (FileName.Length == 0)
            {
                imageLabel.Text = "Image Error.";
                return false;
            }
            else
            {
                model.UserFullName = fullNameText.Text;
                model.Username = usernameText.Text;
                model.Password = passwordText.Text;
                model.IsAdmin = true;

                business.BusinessName = businessNameTextbox.Text;
                business.Contact = contactTextbox.Text;
                business.Address = addressTextbox.Text;
                business.BottomLine = bottomNoteTextbox.Text;
                if(imageLabel.Text.Length > 0)
                {
                    business.Image = FileName;
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
            businessNameTextbox.Text = "";
            contactTextbox.Text = "";
            addressTextbox.Text = "";
            bottomNoteTextbox.Text = "";

            //reset the error messages
            fullNameError.Text = "";
            usernameError.Text = "";
            passwordError.Text = "";
            confirmPasswordError.Text = "";
            businessNameLabel.Text = "";
            businessAddressLabel.Text = "";
            businessContactLabel.Text = "";
            businessNoteLabel.Text = "";
        }

        private void logoButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imageLabel.Text = open.FileName;
                var saveDirectory = Application.StartupPath;
                saveDirectory += "Images/";
                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                string fileName = Path.GetFileName(open.FileName);
                string fileSavePath = Path.Combine(saveDirectory, fileName);
                FileName = fileSavePath;
                File.Copy(open.FileName, fileSavePath, true);
            }
        }
    }
}
