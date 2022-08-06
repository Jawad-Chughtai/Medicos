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
    public partial class InvoiceViewForm : Form
    {
        public string InvoiceId { get; set; }

        InvoiceViewModel Invoice = new InvoiceViewModel();

        InvoiceModel invoice = new InvoiceModel();
        public InvoiceViewForm(string invoiceId)
        {
            InitializeComponent();

            InvoiceId = invoiceId;
            WireupForm();
        }


        private void WireupForm()
        {
            try
            {
                invoice = Invoice.GetInvoiceById(InvoiceId);

                customerNameTextbox.Text = invoice.CustomerName;
                contactTextbox.Text = invoice.CustomerContact;
                dateTextbox.Text = invoice.CreatedAt.ToString("dd-MMM-yyyy hh:mm:ss tt");
                createdByTextbox.Text = invoice.CreatedBy_Name;
                invoiceTextbox.Text = invoice.InvoiceId;


                itemsTotalLabel.Text = invoice.InvoiceSubTotal.ToString("N2");
                discountLabel.Text = invoice.Discount.ToString("N2");
                totalAmountLabel.Text = invoice.InvoiceTotal.ToString("N2");

                WireUpGridView();
            }
            catch
            {
                throw;
            }
        }

        private void WireUpGridView()
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
                ReceiptGridView.Columns["Sr #"].Width = 40;
                ReceiptGridView.Columns["UP"].Width = 50;
                ReceiptGridView.Columns["Qty"].Width = 50;
                ReceiptGridView.Columns["Total"].Width = 50;
                ReceiptGridView.Columns["Expiry"].Width = 130;

                ReceiptGridView.Columns["Sr #"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ReceiptGridView.Columns["UP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                ReceiptGridView.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ReceiptGridView.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                ReceiptGridView.Columns["Expiry"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                ReceiptGridView.Columns["UP"].DefaultCellStyle.Format = "N2";
                ReceiptGridView.Columns["Total"].DefaultCellStyle.Format = "N2";
                ReceiptGridView.Columns["Expiry"].DefaultCellStyle.Format = "dd-MMM-yyyy";


                int count = 0;
                foreach (var item in invoice.Items)
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

            
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            var appPath = Application.StartupPath;

            ReceiptGenerator receiptGenerator = new ReceiptGenerator();
            receiptGenerator.PrintReceipt(invoice, appPath);


            this.Close();
        }
    }
}
