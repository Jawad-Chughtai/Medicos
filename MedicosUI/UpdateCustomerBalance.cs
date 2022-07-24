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
    public partial class UpdateCustomerBalance : Form
    {
        private int CustomerId { get; set; } = 0;
        private double PreviousBalance { get; set; } = 0;
        private double ReceiveAmount { get; set; } = 0;
        private List<CustomerModel> Customers { get; set; } = new List<CustomerModel>();

        public UpdateCustomerBalance()
        {
            InitializeComponent();

            this.customerCombobox.SelectedValueChanged -= new System.EventHandler(this.customerCombobox_SelectedValueChanged);
            WireUpCombobox();
            customerCombobox.SelectedItem = null;
            this.customerCombobox.SelectedValueChanged += new System.EventHandler(this.customerCombobox_SelectedValueChanged);
        }

        private void WireUpCombobox()
        {
            CustomerModel Customer = new CustomerModel();
            try
            {
                Customers = Customer.GetCustomersWithBalance();

                customerCombobox.DataSource = Customers;
                customerCombobox.DisplayMember = "CustomerName";
                customerCombobox.ValueMember = "Id";
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading customers.");
            }
        }

        private void customerCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CustomerModel Customer = new CustomerModel();
                Customer = Customer.GetSingleCustomer(Convert.ToInt32(customerCombobox.SelectedValue));

                CustomerId = Customer.Id;
                PreviousBalance = Customer.Balance;
                WireUpGridView(Customer);
            }

            catch
            {
                MessageBox.Show("Something went wrong.");
            }
            
        }

        private void WireUpGridView(CustomerModel Customer)
        {
            try
            {
                customerGridView.Rows.Clear();

                if (customerCombobox.SelectedItem != null)
                {
                    customerGridView.ColumnCount = 3;

                    customerGridView.RowHeadersVisible = false;
                    customerGridView.ColumnHeadersVisible = false;

                    customerGridView.Columns[0].Name = "Full Name";
                    customerGridView.Columns[1].Name = "Contact";
                    customerGridView.Columns[2].Name = "Balance";

                    customerGridView.Columns["Balance"].Width = 100;
                    customerGridView.Columns["Balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    customerGridView.Columns["Contact"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    customerGridView.Rows.Add(Customer.CustomerName.ToString(), Customer.CustomerContact.ToString(), Customer.Balance.ToString("N2"));
                }
            }

            finally
            {

            }

        }

        private void receiveAmountTextbox_TextChanged(object sender, EventArgs e)
        {
            double amount = 0;
            bool IsValid = double.TryParse(receiveAmountTextbox.Text, out amount);

            if (!IsValid)
            {
                receiveAmountTextbox.Text = "";
            }
            else
            {
                ReceiveAmount = amount;
            }
        }

        Color color = new Color();
        private void updateButton_Click(object sender, EventArgs e)
        {
            if(updateButton.BackColor != Color.Red)
            {
                color = updateButton.BackColor;
            }

            updateButton.BackColor = color;

            if (receiveAmountTextbox.Text.Length == 0)
            {
                updateButton.BackColor = Color.Red;
                return;
            }

            try
            {
                if (ReceiveAmount < PreviousBalance)
                {
                    var confirm = MessageBox.Show("Receiving Amount is less than Balance Amount. You want to receive amount ?", "", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.No)
                    {
                        return;
                    }

                    else
                    {
                        CustomerModel customer = new CustomerModel();
                        customer.UpdateBalance(CustomerId, (PreviousBalance - ReceiveAmount));
                    }
                }

                else if (ReceiveAmount > PreviousBalance)
                {
                    MessageBox.Show("Receive amount is greater than Balance Amount.");
                    return;
                }

                else
                {
                    CustomerModel customer = new CustomerModel();
                    customer.UpdateBalance(CustomerId, 0);
                }

                customerCombobox.SelectedItem = null;
                receiveAmountTextbox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while Updating Customer Balance");
            }
        }
    }
}
