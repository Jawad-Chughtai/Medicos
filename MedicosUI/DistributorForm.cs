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
    public partial class DistributorForm : Form
    {
        public DistributorForm()
        {
            InitializeComponent();
        }

        private void addDistributorButton_Click(object sender, EventArgs e)
        {
            DistributorModel model = new DistributorModel();

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
        private bool validateForm(DistributorModel model)
        {
            distributorTitleError.Text = "";
            contactError.Text = "";
            if (distributorTitleTextbox.Text == "")
            {
                distributorTitleError.Text = "Enter Distributor Name";
                return false;
            }

            else if (distributorTitleTextbox.Text.Length < 3)
            {
                distributorTitleError.Text = "Invalid Distributor Name";
                return false;
            }
            
            else if(contactTextbox.Text.Length == 0 || contactTextbox.Text.Length == 11)
            {
                model.DistributorName = distributorTitleTextbox.Text;
                model.Contact = contactTextbox.Text;
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
            distributorTitleTextbox.Text = "";
            distributorTitleError.Text = "";
            contactTextbox.Text = "";
            contactError.Text = "";
        }
    }
}
