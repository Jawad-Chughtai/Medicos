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
            WireupGridview();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerModel model = new CustomerModel();

            if (validateForm(model))
            {
                try
                {
                    model.AddCustomer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved");
                }
                finally
                {
                    resetForm();
                    WireupGridview();
                }
            }
        }



        //method to validate distributor data
        private bool validateForm(CustomerModel model)
        {
            fullNameError.Text = "";
            contactError.Text = "";

            if (fullNameTextbox.Text == "" || fullNameTextbox == null)
            {
                fullNameError.Text = "Enter Customer Name";
                return false;
            }

            else if (fullNameTextbox.Text.Length < 3)
            {
                fullNameError.Text = "Invalid Customer Name";
                return false;
            }

            else if (contactTextbox.Text.Length != 0 && contactTextbox.Text.Length != 11)
            {
                contactError.Text = "Invalid Contact Number";
                return false;
            }
            else if (balanceTextbox.Text.Length != 0 && balanceTextbox.Text != "")
            {
                try
                {
                    model.Balance = int.Parse(balanceTextbox.Text);
                }
                catch
                {
                    balanceError.Text = "Invalid Amount";
                    return false;
                }
            }

            model.CustomerName = fullNameTextbox.Text;
            model.CustomerContact = contactTextbox.Text;
            return true;
            
        }


        //method to reset the form
        private void resetForm()
        {
            fullNameTextbox.Text = "";
            fullNameError.Text = "";
            contactTextbox.Text = "";
            contactError.Text = "";
            balanceTextbox.Text = "";
            balanceError.Text = "";
        }

        private void WireupGridview()
        {
            customerGridView.Rows.Clear();
            CustomerModel model = new CustomerModel();
            List<CustomerModel> customers = new List<CustomerModel>();
            try
            {
                customers = model.GetCustomers();

                customerGridView.ColumnCount = 4;
                customerGridView.Columns[0].Name = "Id";
                customerGridView.Columns[1].Name = "Customer Name";
                customerGridView.Columns[2].Name = "Contact";
                customerGridView.Columns[3].Name = "Balance";
                customerGridView.Columns[3].DefaultCellStyle.Format = "c2";
                customerGridView.Columns[0].Width = 50;

                foreach(CustomerModel customer in customers)
                {
                    customerGridView.Rows.Add(customer.Id, customer.CustomerName, customer.CustomerContact, customer.Balance);
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading the existing customers from database.");
            }
        }
    }
}
