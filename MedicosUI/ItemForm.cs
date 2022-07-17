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
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
            WireupComboBox();
        }

        private void WireupComboBox()
        {
            try
            {
                CategoryModel category = new CategoryModel();
                List<CategoryModel> categoryList = category.GetCategories();
                if(categoryList.Count == 0)
                {
                    MessageBox.Show("Please Add Categories First.");
                    CategoryForm formObj = new CategoryForm();
                    formObj.Show();
                    Close();
                }
                categoryCombobox.DataSource = categoryList;
                categoryCombobox.DisplayMember = "CategoryName";
                categoryCombobox.ValueMember = "Id";
                categoryCombobox.SelectedItem = null;

                DistributorModel distributor = new DistributorModel();
                List<DistributorModel> distributorList = distributor.GetDistributors();
                if (distributorList.Count == 0)
                {
                    MessageBox.Show("Please Add Distributors First.");
                    DistributorForm formObj = new DistributorForm();
                    formObj.Show();
                    Close();
                }
                distributorCombobox.DataSource = distributorList;
                distributorCombobox.DisplayMember = "DistributorName";
                distributorCombobox.ValueMember = "Id";
                distributorCombobox.SelectedItem = null;

                CompanyModel company = new CompanyModel();
                List<CompanyModel> companyList = company.GetCompanies();
                if (companyList.Count == 0)
                {
                    MessageBox.Show("Please Add Companies First");
                    CompanyForm formObj = new CompanyForm();
                    formObj.Show();
                    Close();
                }
                companyCombobox.DataSource = companyList;
                companyCombobox.DisplayMember = "CompanyName";
                companyCombobox.ValueMember = "Id";
                companyCombobox.SelectedItem = null;

                expiryDateTime.Value = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading. Error!");
                Close();
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            ItemModel item = new ItemModel();

            if (ValidateForm(item))
            {
                try
                {
                    int ItemId = item.ItemExists(itemNameTextbox.Text);
                    if(ItemId == 0)
                    {
                        item.AddItem(item);
                    }

                    else
                    {
                        item.Id = ItemId;
                        item.NewBatch(item);
                    }
                    resetFrom();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved");
                }
            }
        }

        private bool ValidateForm(ItemModel item)
        {
            #region Item Validation
            int stockCount = new int();
            int priceCount = new int();
            bool IsValidUnitPrice = int.TryParse(unitPriceTextbox.Text, out priceCount);
            bool IsValidStock = int.TryParse(stockTextbox.Text, out stockCount);

            itemNameError.Text = "";
            companyError.Text = "";
            categoryError.Text = "";
            distributorError.Text = "";
            batchTitleError.Text = "";
            unitPriceError.Text = "";
            stockError.Text = "";
            expiryDateError.Text = "";


            if (itemNameTextbox.Text == "" || itemNameTextbox.Text.Length == 0)
            {
                itemNameError.Text = "Enter Item name.";
                return false;
            }

            else if (itemNameTextbox.Text.All(char.IsWhiteSpace))
            {
                itemNameError.Text = "Item Name contains white spaces.";
                return false;
            }

            else if (categoryCombobox.SelectedValue == null)
            {
                categoryError.Text = "Select Category";
                return false;
            }

            else if (distributorCombobox.SelectedValue == null)
            {
                distributorError.Text = "Select Distributor";
                return false;
            }

            else if (companyCombobox.SelectedValue == null)
            {
                companyError.Text = "Selected Company";
                return false;
            }

            else if (batchTitleTextbox.Text == "" || batchTitleTextbox.Text.Length == 0)
            {
                batchTitleError.Text = "Invalid Batch Title.";
                return false;
            }

            else if (batchTitleTextbox.Text.All(char.IsWhiteSpace))
            {
                batchTitleError.Text = "Batch contains white spaces.";
                return false;
            }

            else if (unitPriceTextbox.Text == "" || unitPriceTextbox.Text.Length == 0)
            {
                unitPriceError.Text = "Enter Unit Price.";
                return false;
            }

            else if (unitPriceTextbox.Text.All(char.IsWhiteSpace))
            {
                unitPriceError.Text = "Unit Price contains white spaces.";
                return false;
            }

            else if (!IsValidUnitPrice || priceCount == 0)
            {
                unitPriceError.Text = "Invalid Unit Price";
                return false;
            }

            else if (stockTextbox.Text == "" || stockTextbox.Text.Length == 0)
            {
                stockError.Text = "Enter Stock.";
                return false;
            }

            else if (stockTextbox.Text.All(char.IsWhiteSpace))
            {
                stockError.Text = "Unit Price contains white spaces.";
                return false;
            }

            else if (!IsValidStock || stockCount == 0)
            {
                stockError.Text = "Invalid Stock";
                return false;
            }

            else if (expiryDateTime.Value <= DateTime.Now)
            {
                expiryDateError.Text = "Invalid Expiry Date";
                return false;
            }

            else
            {
                item.ItemName = itemNameTextbox.Text;
                item.CategoryId = Convert.ToInt32(categoryCombobox.SelectedValue);
                item.DistributorId = Convert.ToInt32(distributorCombobox.SelectedValue);
                item.CompanyId = Convert.ToInt32(companyCombobox.SelectedValue);
                item.BatchTitle = batchTitleTextbox.Text;
                item.UnitPrice = Convert.ToDouble(unitPriceTextbox.Text);
                item.Stock = Convert.ToInt32(stockTextbox.Text);
                item.ExpiryDate = expiryDateTime.Value;
                if (IsValidStock && stockCount > 0)
                {
                    item.IsStock = true;
                }
                else
                {
                    item.IsStock = false;
                }

                return true;
            }
            #endregion
        }

        private void resetFrom()
        {
            itemNameTextbox.Text = "";
            companyCombobox.SelectedItem = null;
            categoryCombobox.SelectedItem = null;
            distributorCombobox.SelectedItem = null;
            batchTitleTextbox.Text = "";
            unitPriceTextbox.Text = "";
            stockTextbox.Text = "";
            expiryDateTime.Value = DateTime.Now;

            itemNameError.Text = "";
            companyError.Text = "";
            categoryError.Text = "";
            distributorError.Text = "";
            batchTitleError.Text = "";
            unitPriceError.Text = "";
            stockError.Text = "";
            expiryDateError.Text = "";
        }
    }
}
