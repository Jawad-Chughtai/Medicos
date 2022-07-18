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
    public partial class POSForm : Form
    {
        public int StockAdded { get; set; } = 0;
        public int MaxStock { get; set; } = 0;
        public int SelectedId { get; set; } = 0;
        public string SelectedBatch { get; set; }
        public POSForm()
        {
            InitializeComponent();
            itemsGridView.Visible = false;
        }
        
        private void itemTextbox_TextChanged(object sender, EventArgs e)
        {
            itemsGridView.Visible = false;
            unitPriceTextbox.Text = "";
            quantityTextbox.Text = "";
            amountTextbox.Text = "";

            try
            {
                List<POSModel> itemsList = new List<POSModel>();
                POSModel model = new POSModel();
                itemsList = model.GetItems(itemTextbox.Text);

                if (itemsList.Count > 0 && itemTextbox.Text.Length > 0)
                {
                    itemsGridView.ColumnCount = 3;
                    itemsGridView.Columns[0].Name = "Id";
                    itemsGridView.Columns[1].Name = "Item";
                    itemsGridView.Columns[2].Name = "Batch";

                    itemsGridView.Columns[0].Visible = false;
                    itemsGridView.RowHeadersVisible = false;
                    itemsGridView.ColumnHeadersVisible = false;
                    itemsGridView.Rows.Clear();
                    foreach (var item in itemsList)
                    {
                        itemsGridView.Rows.Add(item.ItemId, item.ItemName, item.Batch);
                    }
                    itemsGridView.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("An error Occurred.");
                Close();
            }
        }


        private void itemsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                POSModel item = new POSModel();
                SelectedId = Convert.ToInt32(itemsGridView.SelectedCells[0].Value);
                SelectedBatch = itemsGridView.SelectedCells[2].Value.ToString();
                item = item.GetItemName(SelectedId, SelectedBatch);

                itemTextbox.Text = item.ItemName + " " + item.Batch;
                unitPriceTextbox.Text = item.UnitPrice.ToString("N0");
                itemsGridView.Visible = false;
                quantityTextbox.ReadOnly = false;
                quantityTextbox.Select();
                MaxStock = item.Stock;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("An error Occurred.");
                Close();
            }
        }

        private void quantityTextbox_TextChanged(object sender, EventArgs e)
        {
            StockAdded = 0;
            int x;
            bool IsInteger = int.TryParse(quantityTextbox.Text, out x);

            if (!IsInteger || x == 0)
            {
                quantityTextbox.Text = "";
                amountTextbox.Text = "";
                return;
            }

            foreach (DataGridViewRow row in POSGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["Id"].Value) == SelectedId)
                {
                    StockAdded = Convert.ToInt32(row.Cells["Qty"].Value);
                }
            }

            if(x > (MaxStock - StockAdded))
            {
                MessageBox.Show("Only " + (MaxStock - StockAdded) + " items are left in stock in this batch.");
                quantityTextbox.Text = (MaxStock - StockAdded).ToString();
                return;
            }

            double quantity = Convert.ToDouble(quantityTextbox.Text);
            if(unitPriceTextbox.Text.Length != 0)
            {
                double unitPrice = Convert.ToDouble(unitPriceTextbox.Text);
                amountTextbox.Text = (quantity * unitPrice).ToString("N2");
            }
            else
            {
                quantityTextbox.Text = "";
                amountTextbox.Text = "";
                itemTextbox.Text = "";
                itemTextbox.Select();
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            // input validation starts
            #region Validate Item
            if (itemTextbox.Text == "" || itemTextbox.Text.Length == 0)
            {
                return;
            }

            if (itemTextbox.Text.All(char.IsWhiteSpace))
            {
                itemTextbox.Text = "";
                return;
            }

            if (unitPriceTextbox.Text == "" || unitPriceTextbox.Text.Length == 0)
            {
                itemTextbox.Text = "";
                return;
            }

            if(quantityTextbox.Text == "" || quantityTextbox.Text.Length == 0)
            {
                return;
            }

            if (quantityTextbox.Text.All(char.IsWhiteSpace))
            {
                itemTextbox.Text = "";
                return;
            }

            if (amountTextbox.Text == "" || amountTextbox.Text.Length == 0)
            {
                return;
            }
            #endregion
            //input validation ends

            try
            {
                //get data from model
                POSModel item = new POSModel();
                item = item.GetItemDetails(SelectedId, SelectedBatch);

                //add data to grid view by calling its method
                WireupPOSGridView(item);
                
                SelectedId = 0;
                SelectedBatch = null;
                
                //calculate total after each entry
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("An Error Occurred.");
                Close();
            }
            
            //resetting the inputs
            itemTextbox.Text = "";
            quantityTextbox.Text = "";
            unitPriceTextbox.Text = "";
            amountTextbox.Text = "";

            //itemsListbox.Visible = false;
            return;
        }

        //
        //  This method wires up Grid view
        //
        private void WireupPOSGridView(POSModel item)
        {
            //columns defined
            POSGridView.ColumnCount = 8;
            POSGridView.Columns[0].Name = "Id";
            POSGridView.Columns[1].Name = "Item Name";
            POSGridView.Columns[2].Name = "Batch";
            POSGridView.Columns[3].Name = "UP";
            POSGridView.Columns[4].Name = "Qty";
            POSGridView.Columns[5].Name = "Total";
            POSGridView.Columns[6].Name = "Expiry";
            POSGridView.Columns[7].Name = "Company";

            //defined formats for different value types
            POSGridView.Columns["Expiry"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            POSGridView.Columns["UP"].DefaultCellStyle.Format = "N2";
            POSGridView.Columns["Total"].DefaultCellStyle.Format = "N2";
            POSGridView.RowHeadersWidth = 30;

            //alignent of content in cells
            POSGridView.Columns["UP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            POSGridView.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            POSGridView.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            POSGridView.Columns["Expiry"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            POSGridView.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //width of columns
            POSGridView.Columns["Id"].Width = 80;
            POSGridView.Columns["UP"].Width = 100;
            POSGridView.Columns["Qty"].Width = 100;
            POSGridView.Columns["Item Name"].Width = 150;
            POSGridView.Columns["Batch"].Width = 100;
            POSGridView.Columns["Total"].Width = 120;
            POSGridView.Columns["Company"].Width = 120;
            
            //column header styling
            POSGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            POSGridView.ColumnHeadersDefaultCellStyle.Font = new Font(POSGridView.Font, FontStyle.Bold);

            //checking if item already in the gird
            foreach(DataGridViewRow row in POSGridView.Rows)
            {
                if(item.ItemId == Convert.ToInt32(row.Cells["Id"].Value) && item.Batch == row.Cells["Batch"].Value.ToString())
                {
                    row.Cells["Qty"].Value = (Convert.ToDouble(row.Cells["Qty"].Value) + Convert.ToDouble(quantityTextbox.Text)).ToString(); //qty cell
                    row.Cells["Total"].Value = (item.UnitPrice * Convert.ToDouble(row.Cells["Qty"].Value)).ToString("N2"); //total cell
                    return;
                }
            }
            //adding rows from data
            POSGridView.Rows.Add(
                item.ItemId,
                item.ItemName,
                item.Batch,
                item.UnitPrice,
                quantityTextbox.Text,
                amountTextbox.Text,
                item.Expiry,
                item.Company);

        }
        

        //
        //  This method deletes item from the gridview
        //
        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in POSGridView.SelectedRows)
            {
                POSGridView.Rows.RemoveAt(row.Index);
            }
            CalculateTotal();
            itemTextbox.Select();
        }


        //
        //  This method calculates the totals for the labels in the bottom
        //
        private void CalculateTotal(double discount = 0)
        {
            double itemTotal = 0;
            double GST = 0;

            foreach(DataGridViewRow row in POSGridView.Rows)
            {
                itemTotal = itemTotal + Convert.ToDouble(row.Cells["Total"].Value);
            }

            GST = itemTotal * 0.17;

            itemsTotalLabel.Text = itemTotal.ToString("N2");
            GSTLabel.Text = GST.ToString("N2");
            discountLabel.Text = discount.ToString("N2");
            totalAmountLabel.Text = ((itemTotal + GST) - discount).ToString("N2");
        }

        //
        //  The following method is trigerred on Discount button click and gives 5% discount by default.
        //
        private void discountButton_Click(object sender, EventArgs e)
        {
            double itemTotal = Convert.ToDouble(itemsTotalLabel.Text);
            double discount = itemTotal * 0.05;

            CalculateTotal(discount);
            return;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            List<POSModel> SaleItems = new List<POSModel>();
            foreach(DataGridViewRow row in POSGridView.Rows)
            {
                POSModel item = new POSModel();
                item.ItemId = Convert.ToInt32(row.Cells["Id"].Value);
                item.ItemName = row.Cells["Item Name"].Value.ToString();
                item.Batch = row.Cells["Batch"].ToString();
                item.UnitPrice = Convert.ToDouble(row.Cells["UP"].Value);
                item.Quantity = Convert.ToDouble(row.Cells["Qty"].Value);
                item.ItemTotal = Convert.ToDouble(row.Cells["Total"].Value);
                item.Expiry = Convert.ToDateTime(row.Cells["Expiry"].Value);
                
                SaleItems.Add(item);
            }
            double SubTotal = Convert.ToDouble(itemsTotalLabel.Text);
            double Discount = Convert.ToDouble(discountLabel.Text);
            ReceiptForm form = new ReceiptForm(SaleItems, SubTotal, Discount);
            form.Show();
        }

        private void POSForm_Load(object sender, EventArgs e)
        {

        }

        //
        //  Shortcuts and keypress event handling starts here..
        //
        private void itemTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (itemsGridView.Rows.Count > 0)
                {
                    itemsGridView.Select();
                }
            }
            if (e.KeyCode == Keys.Enter && itemTextbox.Text.Length > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                var theColumnIndex = itemsGridView.CurrentCell.ColumnIndex;
                var theRowIndex = itemsGridView.CurrentCell.RowIndex;
                var args = new DataGridViewCellEventArgs(theColumnIndex, theRowIndex);
                itemsGridView_CellClick(itemsGridView, args);
                quantityTextbox.Select();
            }
            if (e.KeyCode == Keys.F1 && POSGridView.Rows.Count > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                printButton_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                itemsGridView.Rows.Clear();
                itemsGridView.Visible = false;
                itemTextbox.Select(itemTextbox.Text.Length, 0);
            }
        }

        private void quantityTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                addItemButton_Click(sender, new EventArgs());
                itemTextbox.Select();
            }
            if (e.KeyCode == Keys.F1 && POSGridView.Rows.Count > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                printButton_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                itemsGridView.Rows.Clear();
                itemsGridView.Visible = false;
                itemTextbox.Select(itemTextbox.Text.Length, 0);
            }
        }
        private void addItemButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && POSGridView.Rows.Count > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                printButton_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                addItemButton_Click(sender, new EventArgs());
                itemTextbox.Select();
            }

            return;
        }

        private void POSGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && POSGridView.Rows.Count > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                printButton_Click(sender, new EventArgs());
            }

            if(e.KeyCode == Keys.Delete && POSGridView.Rows.Count > 0)
            {
                removeButton_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                itemsGridView.Rows.Clear();
                itemsGridView.Visible = false;
                itemTextbox.Select(itemTextbox.Text.Length, 0);
            }
        }

        private void itemsGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
            {
                if(e.KeyCode == Keys.Escape)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    itemsGridView.Rows.Clear();
                    itemsGridView.Visible = false;
                    itemTextbox.Select(itemTextbox.Text.Length, 0);
                }

                else if(e.KeyCode == Keys.Enter)
                {
                    var theColumnIndex = itemsGridView.CurrentCell.ColumnIndex;
                    var theRowIndex = itemsGridView.CurrentCell.RowIndex;
                    var args = new DataGridViewCellEventArgs(theColumnIndex, theRowIndex);
                    itemsGridView_CellClick(itemsGridView, args);
                }

                else
                {
                    itemTextbox.Text += e.KeyCode.ToString().ToLower();
                    itemTextbox.Select(itemTextbox.Text.Length, 0);
                }
            }
        }

    }
}
