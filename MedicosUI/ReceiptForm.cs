using MedicosLibrary;
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
        string InvoiceId { get; set; }
        int CustomerId { get; set; } = 0;
        int UserId { get; set; }
        double ReceiveAmount { get; set; }
        double TotalAmount { get; set; }
        double BalanceAmount { get; set; }

        Form FormObj = new Form();
        public ReceiptForm(List<POSModel> Items, double subTotal, double discount, string invoiceId, int userId, POSForm formObj)
        {
            InitializeComponent();
            SaleItems = Items;
            SubTotal = subTotal;
            Discount = discount;
            InvoiceId = invoiceId;
            UserId = userId;
            FormObj = formObj;

            WireUpGridView();
            WireUpCustomers();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            invoiceTextbox.Text = InvoiceId; 
        }

        private void WireUpGridView()
        {
            if(SaleItems.Count > 0)
            {
                ReceiptGridView.ColumnCount = 8;
                ReceiptGridView.Columns[0].Name = "Sr #";
                ReceiptGridView.Columns[1].Name = "Item Name";
                ReceiptGridView.Columns[2].Name = "UP";
                ReceiptGridView.Columns[3].Name = "Qty";
                ReceiptGridView.Columns[4].Name = "Total";
                ReceiptGridView.Columns[5].Name = "Expiry";

                ReceiptGridView.Columns[6].Name = "Item Id";
                ReceiptGridView.Columns[7].Name = "Batch";

                ReceiptGridView.ColumnHeadersDefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                ReceiptGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                ReceiptGridView.RowHeadersWidth = 20;
                ReceiptGridView.Columns["Sr #"].Width = 40;
                ReceiptGridView.Columns["UP"].Width = 50;
                ReceiptGridView.Columns["Qty"].Width = 50;
                ReceiptGridView.Columns["Total"].Width = 50;
                ReceiptGridView.Columns["Expiry"].Width = 70;

                ReceiptGridView.Columns["Sr #"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ReceiptGridView.Columns["UP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                ReceiptGridView.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ReceiptGridView.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                ReceiptGridView.Columns["Expiry"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                ReceiptGridView.Columns["UP"].DefaultCellStyle.Format = "N2";
                ReceiptGridView.Columns["Total"].DefaultCellStyle.Format = "N2";
                ReceiptGridView.Columns["Expiry"].DefaultCellStyle.Format = "dd-MMM-yyyy";

               ReceiptGridView.Columns["Item Id"].Visible = false;
               ReceiptGridView.Columns["Batch"].Visible = false;

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
                        item.Expiry,
                        item.ItemId,
                        item.Batch);
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
                Discount = Math.Round(SubTotal * 0.05);
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

        private void customerCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CustomerModel customer = new CustomerModel();
                customer = customer.GetSingleCustomer(Convert.ToInt32(customerCombobox.SelectedValue));

                contactTextbox.Text = customer.CustomerContact;
                BalanceTextbox.Text = customer.Balance.ToString("N2");
                CustomerId = customer.Id;
            }
            catch
            {
                contactTextbox.Text = "";
                BalanceTextbox.Text = "";
            }
        }
        private void customerCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //try
            //{
            //    CustomerModel customer = new CustomerModel();
            //    customer = customer.GetSingleCustomer(Convert.ToInt32(customerCombobox.SelectedValue));

            //    contactTextbox.Text = customer.CustomerContact;
            //    BalanceTextbox.Text = customer.Balance.ToString("N2");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show("Something went wrong while loading the customers");
            //}
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

            if(amount >= (Convert.ToDouble(totalAmountLabel.Text)))
            {
                changeTextbox.Text = (amount - Convert.ToDouble(totalAmountLabel.Text)).ToString();
            }
            else
            {
                changeTextbox.Text = "";
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            customerCombobox.SelectedItem = null;
            contactTextbox.Text = "";
            BalanceTextbox.Text = "";
            WireUpCustomers();
            recieveAmountTextbox.Focus();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            double amount;
            bool IsValid = Double.TryParse(recieveAmountTextbox.Text, out amount);
            TotalAmount = Convert.ToDouble(totalAmountLabel.Text);
            Discount = Convert.ToDouble(discountLabel.Text);

            if (!IsValid)
            {
                recieveAmountTextbox.Text = "";
                return;
            }

            ReceiveAmount = amount;

            if (ReceiveAmount < TotalAmount)
            {
                BalanceAmount = TotalAmount - ReceiveAmount;
                var Confirm = MessageBox.Show("Do you want to add remaining amount ( " + BalanceAmount +" ) to Customer Balance?","Receive Amount Less than Total", MessageBoxButtons.YesNo);
                if (Confirm == DialogResult.No)
                {
                    recieveAmountTextbox.Text = "";
                    BalanceAmount = 0;
                    recieveAmountTextbox.Select();
                    return;
                }

                if (Confirm == DialogResult.Yes)
                {
                    if(CustomerId == 0)
                    {
                        MessageBox.Show("Select Customer or Add New First.");
                        customerCombobox.Select();
                        return;
                    }
                    
                    else CreateInvoiceModel();
                }
            }

            else
            {
                CreateInvoiceModel();
            }

        }
        private void CreateInvoiceModel()
        {
            InvoiceModel model = new InvoiceModel();
            try
            {
                model.InvoiceId = invoiceTextbox.Text;
                var InvoiceExists = model.InvoiceExists();
                if (InvoiceExists)
                {
                    MessageBox.Show("Invoice Already Exists");
                    return;
                }
                else
                {
                    model.CreatedBy_Id = UserId;
                    model.CreatedAt = DateTime.Now;
                    model.InvoiceSubTotal = SubTotal;
                    model.InvoiceTotal = TotalAmount;
                    model.Discount = Discount;
                    model.CustomerId = CustomerId;
                    model.BalanceAmount = BalanceAmount;
                    model.ReceivedAmount = ReceiveAmount;

                    foreach (DataGridViewRow row in ReceiptGridView.Rows)
                    {
                        InvoiceItemsModel item = new InvoiceItemsModel();
                        item.ItemId = Convert.ToInt32(row.Cells[6].Value.ToString());
                        item.BatchTitle = row.Cells[7].Value.ToString();
                        item.ItemName = row.Cells[1].Value.ToString();
                        item.Quantity = Convert.ToInt32(row.Cells[3].Value.ToString());
                        item.UnitPrice = Convert.ToDouble(row.Cells[2].Value.ToString());
                        item.ItemTotal = Convert.ToDouble(row.Cells[4].Value.ToString());

                        model.Items.Add(item);

                    }
                    //var message = model.CreateSale(model);
                    var message = "Invoice Created Successfully.";
                    if (message == "Invoice Created Successfully.")
                    {
                        var appPath = Application.StartupPath;

                        ReceiptGenerator receiptGenerator = new ReceiptGenerator();
                        receiptGenerator.PrintReceipt(model, appPath);


                        MessageBox.Show(message);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(message, "Error in Transaction", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                model.DeleteInvoiceItems(model);
                model.DeleteInvoice(model);
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while creating Invoice. Invoice could not be created.", "Invoice Creation Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm formObj = new CustomerForm();
            formObj.Show();
            formObj.FormBorderStyle = FormBorderStyle.FixedSingle;
            formObj.ControlBox = true;
        }

        private void recieveAmountTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                printButton_Click(sender, new EventArgs());
            }
        }

        private void ReceiptForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormObj.Close();
        }
    }
}
