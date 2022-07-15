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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            WireupGridView();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryModel model = new CategoryModel();

            if(validateForm(model))
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
                    WireupGridView();
                }
            }
        }


        //method to validate category
        private bool validateForm(CategoryModel model)
        {
            categoryTitleError.Text = "";
            if (categoryTitleTextbox.Text == "")
            {
                categoryTitleError.Text = "Enter Category Title";
                return false;
            }

            else if(categoryTitleTextbox.Text.Length < 3)
            {
                categoryTitleError.Text = "Invalid Category Title";
                return false;
            }
            else
            {
                model.CategoryName = categoryTitleTextbox.Text;
                return true;
            }
        }


        //method to reset the form
        private void resetForm()
        {
            categoryTitleTextbox.Text = "";
            categoryTitleError.Text = "";
        }

        private void WireupGridView()
        {
            categoryGridView.Rows.Clear();
            try 
            {
                CategoryModel model = new CategoryModel();
                List<CategoryModel> Categories = model.GetCategories();

                categoryGridView.ColumnCount = 2;
                categoryGridView.Columns[0].Name = "Id";
                categoryGridView.Columns[1].Name = "Category";
                categoryGridView.Columns[0].Width = 50;

                categoryGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                categoryGridView.ColumnHeadersDefaultCellStyle.Font = new Font(categoryGridView.Font, FontStyle.Bold);
                categoryGridView.RowHeadersWidth = 30;

                foreach (CategoryModel category in Categories)
                {
                    categoryGridView.Rows.Add(category.Id, category.CategoryName);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading the existing companies from the database.");
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryModel model = new CategoryModel();
            string name = categoryGridView.SelectedCells[1].Value.ToString();
            var confirmResult = MessageBox.Show("Are you sure to delete " + name + " ?", "", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            try
            {
                model.DeleteCategory(int.Parse(categoryGridView.SelectedCells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong. Category could not be deleted.");
            }
            finally
            {
                WireupGridView();
            }
        }
    }
}
