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
    public partial class ViewItems : Form
    {
        public ViewItems()
        {
            InitializeComponent();
            WireupGridView();
        }

        private void WireupGridView()
        {
            try
            {
                itemsGridView.Rows.Clear();

                ItemModel item = new ItemModel();
                List<ItemModel> itemsList = new List<ItemModel>();
                itemsList = item.GetItems();

                itemsGridView.ColumnCount = 9;
                itemsGridView.Columns[0].Name = "Id";
                itemsGridView.Columns[1].Name = "Item Name";
                itemsGridView.Columns[2].Name = "Batch";
                itemsGridView.Columns[3].Name = "Unit Price";
                itemsGridView.Columns[4].Name = "Stock";
                itemsGridView.Columns[5].Name = "Expiry";
                itemsGridView.Columns[6].Name = "Category";
                itemsGridView.Columns[7].Name = "Distributor";
                itemsGridView.Columns[8].Name = "Company";

                itemsGridView.Columns[0].Width = 50;
                itemsGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                itemsGridView.ColumnHeadersDefaultCellStyle.Font = new Font(itemsGridView.Font, FontStyle.Bold);
                itemsGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                itemsGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                itemsGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                itemsGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                itemsGridView.RowHeadersWidth = 30;

                itemsGridView.Columns[3].DefaultCellStyle.Format = "N2";
                itemsGridView.Columns[5].DefaultCellStyle.Format = "dd-MMM-yyyy";
                
                foreach (var items in itemsList)
                {
                    itemsGridView.Rows.Add(items.Id,
                        items.ItemName,
                        items.BatchTitle,
                        items.UnitPrice,
                        items.Stock,
                        items.ExpiryDate.Date,
                        items.CategoryName,
                        items.DistributorName,
                        items.CompanyName);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading items from database.");
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            if (itemsGridView.Rows.Count > 0)
            {
                ItemModel model = new ItemModel();
                string name = itemsGridView.SelectedCells[1].Value.ToString();
                string batch = itemsGridView.SelectedCells[2].Value.ToString();
                var confirmResult = MessageBox.Show("Are you sure to delete " + name + " " + batch + " ?", "", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                try
                {
                    //model.DeleteItem(int.Parse(itemsGridView.SelectedCells[0].Value.ToString()));
                    model.DeleteSingleBatch(batch);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Item cannot be deleted.");
                }
                finally
                {
                    WireupGridView();
                }
            }
        }

        private void searchItemTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                itemsGridView.Rows.Clear();

                ItemModel item = new ItemModel();
                List<ItemModel> itemsList = new List<ItemModel>();
                itemsList = item.SearchItems(searchItemTextbox.Text);

                itemsGridView.ColumnCount = 9;
                itemsGridView.Columns[0].Name = "Id";
                itemsGridView.Columns[1].Name = "Item Name";
                itemsGridView.Columns[2].Name = "Batch";
                itemsGridView.Columns[3].Name = "Unit Price";
                itemsGridView.Columns[4].Name = "Stock";
                itemsGridView.Columns[5].Name = "Expiry";
                itemsGridView.Columns[6].Name = "Category";
                itemsGridView.Columns[7].Name = "Distributor";
                itemsGridView.Columns[8].Name = "Company";

                itemsGridView.Columns[0].Width = 50;
                itemsGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                itemsGridView.ColumnHeadersDefaultCellStyle.Font = new Font(itemsGridView.Font, FontStyle.Bold);
                itemsGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                itemsGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                itemsGridView.Columns[3].DefaultCellStyle.Format = "N0";
                itemsGridView.Columns[5].DefaultCellStyle.Format = "dd-MMM-yyyy";

                foreach (var items in itemsList)
                {
                    itemsGridView.Rows.Add(items.Id,
                        items.ItemName,
                        items.BatchTitle,
                        items.UnitPrice,
                        items.Stock,
                        items.ExpiryDate.Date,
                        items.CategoryName,
                        items.DistributorName,
                        items.CompanyName);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading items from database.");
            }
        }
    }
}
