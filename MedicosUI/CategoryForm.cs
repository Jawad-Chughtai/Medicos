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
    }
}
