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
    public partial class InvoiceForm : Form
    {
        List<InvoiceModel> Invoices = new List<InvoiceModel>();
        public InvoiceForm()
        {
            InitializeComponent();

            invoiceIDError.Text = "";
            customerNameError.Text = "";
            dateError.Text = "";
            invoiceAvailableError.Text = "";
            invoiceDateTime.Value = DateTime.Now.Date;
            InvoiceModel Invoice = new InvoiceModel();
            Invoices = Invoice.GetAllInvoices();

            if(Invoices.Count > 0)
            {
                WireUpGridView();
            }
        }

        private void WireUpGridView()
        {
            invoiceGridView.ColumnCount = 4;

            invoiceGridView.Columns[0].Name = "Invoice Id";
            invoiceGridView.Columns[1].Name = "Customer Name";
            invoiceGridView.Columns[2].Name = "Total";
            invoiceGridView.Columns[3].Name = "Date";

            invoiceGridView.Columns["Invoice Id"].Width = 130;
            invoiceGridView.Columns["Total"].Width = 100;
            invoiceGridView.Columns["Date"].Width = 120;
            
            invoiceGridView.Columns["Invoice Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invoiceGridView.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invoiceGridView.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            invoiceGridView.ColumnHeadersDefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
            invoiceGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            invoiceGridView.RowHeadersWidth = 20;


            foreach (var invoice in Invoices)
            {
                invoiceGridView.Rows.Add(invoice.InvoiceId,
                    invoice.CustomerName, 
                    (invoice.InvoiceSubTotal - invoice.Discount).ToString("N2"),
                    invoice.CreatedAt.ToString("dd-MM-yyyy"));
            }
        }

        private void searchInvoiceButton_Click(object sender, EventArgs e)
        {
            invoiceAvailableError.Text = "";
            invoiceGridView.Rows.Clear();
            InvoiceModel Invoice = new InvoiceModel();
            try
            {
                string invoiceId = invoiceIDTextbox.Text.Length > 0 ? invoiceIDTextbox.Text : "--";
                string customer = customerName.Text.Length > 0 ? customerName.Text : "--";
                Invoices = Invoice.SearchInvoices(invoiceId, customer);

                if (Invoices.Count == 0)
                {
                    invoiceAvailableError.Text = "Invoice is not available in database.";
                    return;
                }

                else WireUpGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while searching invoice.");
            }
        }

        private void dateSearchButton_Click(object sender, EventArgs e)
        {
            invoiceAvailableError.Text = "";
            invoiceGridView.Rows.Clear();
            InvoiceModel Invoice = new InvoiceModel();
            try
            {
                Invoices = Invoice.SearchInvoices(invoiceDateTime.Value.Date);

                if (Invoices.Count == 0)
                {
                    invoiceAvailableError.Text = "No Invoices were Created on selected date.";
                    return;
                }

                else WireUpGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while searching invoice.");
            }
        }

        private void viewInvoiceButton_Click(object sender, EventArgs e)
        {
            string InvoiceId = invoiceGridView.SelectedCells[0].Value.ToString();
            InvoiceViewForm formObj = new InvoiceViewForm(InvoiceId);
            try
            {
                formObj.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading invoice.");
            }
        }
    }
}
