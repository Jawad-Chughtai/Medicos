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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
            WireupGridView();
        }

        private void addCompanyButton_Click(object sender, EventArgs e)
        {
            CompanyModel model = new CompanyModel();
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
                    WireupGridView();
                    resetForm();
                }
            }
        }


        private bool validateForm(CompanyModel model)
        {
            companyTitleError.Text = "";

            if(companyTitleTextbox.Text == "")
            {
                companyTitleError.Text = "Enter Company Title";
                return false;
            }
            else if (companyTitleTextbox.Text.Length < 3)
            {
                companyTitleError.Text = "Invalid Company Title";
                return false;
            }
            else
            {
                model.CompanyName = companyTitleTextbox.Text;
                return true;
            }
        }

        private void resetForm()
        {
            companyTitleError.Text = "";
            companyTitleTextbox.Text = "";
        }

        private void WireupGridView()
        {
            try
            {
                companyGridView.Rows.Clear();
                CompanyModel model = new CompanyModel();
                List<CompanyModel> Companies = model.GetCompanies();

                companyGridView.ColumnCount = 2;
                companyGridView.Columns[0].Name = "ID";
                companyGridView.Columns[1].Name = "Company Name";
                companyGridView.Columns[0].Width = 50;

                foreach (CompanyModel company in Companies)
                {
                    string id = company.Id.ToString();
                    string name = company.CompanyName.ToString();

                    companyGridView.Rows.Add(id, name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading the existing companies from database.");
            }
        }

        private void deleteCompanyButton_Click(object sender, EventArgs e)
        {
            CompanyModel model = new CompanyModel();
            string name = companyGridView.SelectedCells[1].Value.ToString();
            var confirmResult = MessageBox.Show("Are you sure to delete " + name + " ?", "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            try
            {
                model.DeleteCompany(int.Parse(companyGridView.SelectedCells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong. Company could not be deleted.");
            }
            finally
            {
                WireupGridView();
            }
        }
    }
}
