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

        public POSForm()
        {
            InitializeComponent();
            itemsListbox.Visible = false;
        }
        
        private void itemTextbox_TextChanged(object sender, EventArgs e)
        {
            itemsListbox.Visible = false;
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
                    itemsListbox.DataSource = itemsList;

                    itemsListbox.DisplayMember = "ListItem";
                    itemsListbox.ValueMember = "ItemId";
                    itemsListbox.Visible = true;
                    itemsListbox.AutoSize = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("An error Occurred.");
                Close();
            }
        }

        private void itemsListbox_Click(object sender, EventArgs e)
        {
            try
            {
                POSModel item = new POSModel();
                POSModel model = new POSModel();
                item = model.GetItemName(Convert.ToInt32(itemsListbox.SelectedValue));

                itemTextbox.Text = item.ItemName + " " + item.Batch;
                unitPriceTextbox.Text = item.UnitPrice.ToString("N0");
                itemsListbox.Visible = false;
                quantityTextbox.ReadOnly = false;
                quantityTextbox.Select();
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
            int x;
            bool IsInteger = int.TryParse(quantityTextbox.Text, out x);

            if (!IsInteger || x == 0)
            {
                quantityTextbox.Text = "";
                amountTextbox.Text = "";
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
                POSModel model = new POSModel();
                item = model.GetItemDetails(Convert.ToInt32(itemsListbox.SelectedValue));

                //add data to grid view by calling its method
                WireupPOSGridView(item);

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

            itemsListbox.Visible = false;
            return;
        }

        //
        //  This method wires up Grid view
        //
        private void WireupPOSGridView(POSModel item)
        {
            //columns defined
            POSGridView.ColumnCount = 7;
            POSGridView.Columns[0].Name = "Id";
            POSGridView.Columns[1].Name = "Item Name";
            POSGridView.Columns[2].Name = "UP";
            POSGridView.Columns[3].Name = "Qty";
            POSGridView.Columns[4].Name = "Total";
            POSGridView.Columns[5].Name = "Expiry";
            POSGridView.Columns[6].Name = "Company";

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
            POSGridView.Columns["Item Name"].Width = 250;
            POSGridView.Columns["Total"].Width = 120;
            POSGridView.Columns["Company"].Width = 120;
            
            //column header styling
            POSGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            POSGridView.ColumnHeadersDefaultCellStyle.Font = new Font(POSGridView.Font, FontStyle.Bold);

            //checking if item already in the gird
            foreach(DataGridViewRow row in POSGridView.Rows)
            {
                if(item.ItemId == Convert.ToInt32(row.Cells[0].Value))
                {
                    row.Cells[3].Value = (Convert.ToDouble(row.Cells[3].Value) + Convert.ToDouble(quantityTextbox.Text)).ToString();
                    row.Cells[4].Value = (item.UnitPrice * Convert.ToDouble(row.Cells[3].Value)).ToString("N2");
                    return;
                }
            }
            //adding rows from data
            POSGridView.Rows.Add(
                item.ItemId,
                item.ItemName + " " + item.Batch,
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
            MessageBox.Show("Print Button Clicked..!!");
            return;
        }

        private void POSForm_Load(object sender, EventArgs e)
        {

        }

        //
        //  Shortcuts and keypress event handling starts here..
        //
        private void itemTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (itemsListbox.SelectedIndex > 0)
                {
                    itemsListbox.SelectedIndex--;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                try
                {
                    itemsListbox.SelectedIndex++;
                }
                catch
                {
                    itemsListbox.SelectedIndex = itemsListbox.SelectedIndex;
                }
            }

            if (e.KeyCode == Keys.Enter && itemTextbox.Text.Length > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                itemsListbox_Click(sender, new EventArgs());
                quantityTextbox.Select();
            }
            if (e.KeyCode == Keys.F1 && POSGridView.Rows.Count > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                printButton_Click(sender, new EventArgs());
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
        }
    }
}
