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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerModel model = new CustomerModel();

            if (validateForm(model))
            {
                try
                {
                    model.accessDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved");
                }
                finally
                {
                    resetForm();
                }
            }
        }



        //method to validate distributor data
        private bool validateForm(CustomerModel model)
        {
            fullNameTextbox.Text = "";
            contactError.Text = "";
            if (fullNameTextbox.Text == "")
            {
                fullNameError.Text = "Enter Customer Name";
                return false;
            }

            else if (fullNameTextbox.Text.Length < 3)
            {
                fullNameError.Text = "Invalid Customer Name";
                return false;
            }

            else if (contactTextbox.Text.Length == 0 || contactTextbox.Text.Length == 11)
            {
                model.CustomerName = fullNameTextbox.Text;
                model.CustomerContact = contactTextbox.Text;
                return true;
            }
            else
            {
                contactError.Text = "Invalid Contact Number";
                return false;
            }
        }


        //method to reset the form
        private void resetForm()
        {
            fullNameTextbox.Text = "";
            fullNameError.Text = "";
            contactTextbox.Text = "";
            contactError.Text = "";
        }
    }
}
