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
    public partial class DashboardForm : Form
    {
        Form activeForm = null;
        public int UserId { get; set; }
        public string Username { get; set; }
        public bool IsAdmin { get; set; }

        public DashboardForm()
        {
            InitializeComponent();
            UserinfotoolStripMenuItem.Text = Username;
            DashboardChildForm formObj = new DashboardChildForm();
            openChildForm(formObj);
            menuStripNavigation.Renderer = new myRenderer();
            
        }

        //method to open child forms inside parent form
        private void openChildForm(Form formObj)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            formObj.MdiParent = this;
            formObj.Show();
            formObj.Dock = DockStyle.Fill;
            formObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formObj.TopLevel = false;
            activeForm = formObj;
        }
        
        //Left navigation menu onClick methods to display respective child forms
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardChildForm formObj = new DashboardChildForm();
            openChildForm(formObj);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm formObj = new UserForm();
            openChildForm(formObj);
        }

        private void distributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistributorForm formObj = new DistributorForm();
            openChildForm(formObj);
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm formObj = new CompanyForm();
            openChildForm(formObj);
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm formObj = new CategoryForm();
            openChildForm(formObj);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm formObj = new CustomerForm();
            openChildForm(formObj);
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm formObj = new InvoiceForm();
            openChildForm(formObj);
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchForm formObj = new BatchForm();
            openChildForm(formObj);
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm formObj = new SalesForm();
            openChildForm(formObj);
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupForm formObj = new BackupForm();
            openChildForm(formObj);
        }

        private void newPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPurchaseForm formObj = new NewPurchaseForm();
            openChildForm(formObj);
        }

        private void viewPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchaseForm formObj = new ViewPurchaseForm();
            openChildForm(formObj);
        }

        private void pointOfSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POSForm formObj = new POSForm();
            openChildForm(formObj);
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm formObj = new ItemForm();
            openChildForm(formObj);
        }

        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewItems formObj = new ViewItems();
            openChildForm(formObj);
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
