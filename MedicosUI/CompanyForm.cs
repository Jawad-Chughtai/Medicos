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
    }
}
