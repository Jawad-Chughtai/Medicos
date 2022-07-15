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
            WireupGridView();
        }

        private void addDistributorButton_Click(object sender, EventArgs e)
        {
            DistributorModel model = new DistributorModel();

            if (validateForm(model))
            {
                try
                {
                    model.AddDistributor();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved");
                }
                finally
                {
                    resetForm();
                    WireupGridView();
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

        private void WireupGridView()
        {
            try
            {
                distributorGridView.Rows.Clear();
                List<DistributorModel> distributors = new List<DistributorModel>();
                DistributorModel model = new DistributorModel();

                distributors = model.GetDistributors();

                distributorGridView.ColumnCount = 3;
                distributorGridView.Columns[0].Name = "Id";
                distributorGridView.Columns[1].Name = "Company Name";
                distributorGridView.Columns[2].Name = "Contact";
                distributorGridView.Columns[0].Width = 50;

                distributorGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                distributorGridView.ColumnHeadersDefaultCellStyle.Font = new Font(distributorGridView.Font, FontStyle.Bold);
                distributorGridView.RowHeadersWidth = 30;

                foreach (DistributorModel distributor in distributors)
                {
                    distributorGridView.Rows.Add(distributor.Id, distributor.DistributorName, distributor.Contact);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading the existing distributors from database.");
            }
        }

        private void deleteDistributorButton_Click(object sender, EventArgs e)
        {
            DistributorModel model = new DistributorModel();
            string name = distributorGridView.SelectedCells[1].Value.ToString();
            var confirmResult = MessageBox.Show("Are you sure to delete " + name + " ?", "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            try
            {
                model.DeleteDistributor(int.Parse(distributorGridView.SelectedCells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong. Distributor could not be deleted.");
            }
            finally
            {
                WireupGridView();
            }
        }
    }
}
