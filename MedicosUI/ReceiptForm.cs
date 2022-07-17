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
    public partial class ReceiptForm : Form
    {
        List<POSModel> SaleItems = new List<POSModel>();
        double SubTotal { get; set; }
        double Discount { get; set; }
        public ReceiptForm(List<POSModel> Items, double subTotal, double discount)
        {
            InitializeComponent();
            SaleItems = Items;
            SubTotal = subTotal;
            Discount = discount;

            WireUpGridView();
            WireUpCustomers();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString("yyMMddhhmmss");
            invoiceTextbox.Text = dateTime; 
        }

        private void WireUpGridView()
        {
            if(SaleItems.Count > 0)
            {
                ReceiptGridView.ColumnCount = 6;
                ReceiptGridView.Columns[0].Name = "Sr #";
                ReceiptGridView.Columns[1].Name = "Item Name";
                ReceiptGridView.Columns[2].Name = "UP";
                ReceiptGridView.Columns[3].Name = "Qty";
                ReceiptGridView.Columns[4].Name = "Total";
                ReceiptGridView.Columns[5].Name = "Expiry";

                ReceiptGridView.ColumnHeadersDefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                ReceiptGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                ReceiptGridView.RowHeadersWidth = 20;

                ReceiptGridView.Columns["Sr #"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ReceiptGridView.Columns["UP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                ReceiptGridView.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ReceiptGridView.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                ReceiptGridView.Columns["Expiry"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                ReceiptGridView.Columns["UP"].DefaultCellStyle.Format = "N2";
                ReceiptGridView.Columns["Total"].DefaultCellStyle.Format = "N2";
                ReceiptGridView.Columns["Expiry"].DefaultCellStyle.Format = "dd-MMM-yyyy";

                int count = 0;
                foreach (var item in SaleItems)
                {
                    count++;
                    ReceiptGridView.Rows.Add(
                        count,
                        item.ItemName,
                        item.UnitPrice,
                        item.Quantity,
                        item.ItemTotal,
                        item.Expiry);
                }

                Totals();
            }
        }

        private void Totals()
        {
            itemsTotalLabel.Text = SubTotal.ToString("N2");
            discountLabel.Text = Discount.ToString("N2");
            totalAmountLabel.Text = (SubTotal - Discount).ToString("N2");
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            if (Discount == 0)
            {
                Discount = (SubTotal * 0.05);
                discountLabel.Text = Discount.ToString("N2");
                Totals();
            }

            else
            {
                Discount = 0;
                discountLabel.Text = Discount.ToString("N2");
                Totals();
            }
        }

        private void WireUpCustomers()
        {
            CustomerModel model = new CustomerModel();
            List<CustomerModel> Customers = model.GetCustomers();
            customerCombobox.DataSource = Customers;
            customerCombobox.DisplayMember = "CustomerName";
            customerCombobox.ValueMember = "Id";
            customerCombobox.SelectedItem = null;
        }

        private void customerCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CustomerModel customer = new CustomerModel();
                customer = customer.GetSingleCustomer(Convert.ToInt32(customerCombobox.SelectedValue));

                contactTextbox.Text = customer.CustomerContact;
                BalanceTextbox.Text = customer.Balance.ToString("N2");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading the customers");
            }
        }

        private void recieveAmountTextbox_TextChanged(object sender, EventArgs e)
        {
            double amount;
            bool IsValid = double.TryParse(recieveAmountTextbox.Text, out amount);

            if (!IsValid && recieveAmountTextbox.Text.Length > 0)
            {
                try
                {
                    recieveAmountTextbox.Text = recieveAmountTextbox.Text.Substring(0, recieveAmountTextbox.Text.Length - 1);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if(amount >= (Convert.ToDouble(totalAmountLabel.Text) - 1.0))
            {
                changeTextbox.Text = (amount - Convert.ToDouble(totalAmountLabel.Text)).ToString();
            }
            else
            {
                changeTextbox.Text = "";
            }
        }
    }
}
