namespace MedicosUI
{
    partial class ItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.companyCombobox = new System.Windows.Forms.ComboBox();
            this.distributorCombobox = new System.Windows.Forms.ComboBox();
            this.categoryCombobox = new System.Windows.Forms.ComboBox();
            this.companyError = new System.Windows.Forms.Label();
            this.distributorError = new System.Windows.Forms.Label();
            this.categoryError = new System.Windows.Forms.Label();
            this.itemNameError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unitPriceTextbox = new System.Windows.Forms.TextBox();
            this.stockError = new System.Windows.Forms.Label();
            this.stockTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unitPriceError = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.expiryDateTime = new System.Windows.Forms.DateTimePicker();
            this.expiryDateError = new System.Windows.Forms.Label();
            this.batchTitleError = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.batchTitleTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.companyCombobox);
            this.panel2.Controls.Add(this.distributorCombobox);
            this.panel2.Controls.Add(this.categoryCombobox);
            this.panel2.Controls.Add(this.companyError);
            this.panel2.Controls.Add(this.distributorError);
            this.panel2.Controls.Add(this.categoryError);
            this.panel2.Controls.Add(this.itemNameError);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.itemNameTextbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(173, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 431);
            this.panel2.TabIndex = 12;
            // 
            // companyCombobox
            // 
            this.companyCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.companyCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.companyCombobox.FormattingEnabled = true;
            this.companyCombobox.ItemHeight = 21;
            this.companyCombobox.Location = new System.Drawing.Point(22, 299);
            this.companyCombobox.Name = "companyCombobox";
            this.companyCombobox.Size = new System.Drawing.Size(283, 29);
            this.companyCombobox.TabIndex = 4;
            // 
            // distributorCombobox
            // 
            this.distributorCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.distributorCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.distributorCombobox.FormattingEnabled = true;
            this.distributorCombobox.ItemHeight = 21;
            this.distributorCombobox.Location = new System.Drawing.Point(23, 218);
            this.distributorCombobox.Name = "distributorCombobox";
            this.distributorCombobox.Size = new System.Drawing.Size(283, 29);
            this.distributorCombobox.TabIndex = 3;
            // 
            // categoryCombobox
            // 
            this.categoryCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.categoryCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryCombobox.FormattingEnabled = true;
            this.categoryCombobox.ItemHeight = 21;
            this.categoryCombobox.Location = new System.Drawing.Point(22, 138);
            this.categoryCombobox.Name = "categoryCombobox";
            this.categoryCombobox.Size = new System.Drawing.Size(283, 29);
            this.categoryCombobox.TabIndex = 2;
            // 
            // companyError
            // 
            this.companyError.AutoSize = true;
            this.companyError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyError.ForeColor = System.Drawing.Color.Red;
            this.companyError.Location = new System.Drawing.Point(19, 331);
            this.companyError.Name = "companyError";
            this.companyError.Size = new System.Drawing.Size(0, 17);
            this.companyError.TabIndex = 13;
            // 
            // distributorError
            // 
            this.distributorError.AutoSize = true;
            this.distributorError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distributorError.ForeColor = System.Drawing.Color.Red;
            this.distributorError.Location = new System.Drawing.Point(20, 250);
            this.distributorError.Name = "distributorError";
            this.distributorError.Size = new System.Drawing.Size(0, 17);
            this.distributorError.TabIndex = 12;
            // 
            // categoryError
            // 
            this.categoryError.AutoSize = true;
            this.categoryError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryError.ForeColor = System.Drawing.Color.Red;
            this.categoryError.Location = new System.Drawing.Point(19, 170);
            this.categoryError.Name = "categoryError";
            this.categoryError.Size = new System.Drawing.Size(0, 17);
            this.categoryError.TabIndex = 11;
            // 
            // itemNameError
            // 
            this.itemNameError.AutoSize = true;
            this.itemNameError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameError.ForeColor = System.Drawing.Color.Red;
            this.itemNameError.Location = new System.Drawing.Point(19, 84);
            this.itemNameError.Name = "itemNameError";
            this.itemNameError.Size = new System.Drawing.Size(0, 17);
            this.itemNameError.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distributor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Category";
            // 
            // itemNameTextbox
            // 
            this.itemNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameTextbox.Location = new System.Drawing.Point(22, 52);
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.Size = new System.Drawing.Size(284, 29);
            this.itemNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name";
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addItemButton.Location = new System.Drawing.Point(493, 493);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(123, 39);
            this.addItemButton.TabIndex = 9;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Gray;
            this.labelUser.Location = new System.Drawing.Point(168, 68);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(109, 30);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "New Item";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.unitPriceTextbox);
            this.panel1.Controls.Add(this.stockError);
            this.panel1.Controls.Add(this.stockTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.unitPriceError);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.expiryDateTime);
            this.panel1.Controls.Add(this.expiryDateError);
            this.panel1.Controls.Add(this.batchTitleError);
            this.panel1.Controls.Add(this.contactLabel);
            this.panel1.Controls.Add(this.batchTitleTextbox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(614, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 432);
            this.panel1.TabIndex = 25;
            // 
            // unitPriceTextbox
            // 
            this.unitPriceTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitPriceTextbox.Location = new System.Drawing.Point(22, 138);
            this.unitPriceTextbox.Name = "unitPriceTextbox";
            this.unitPriceTextbox.Size = new System.Drawing.Size(284, 29);
            this.unitPriceTextbox.TabIndex = 6;
            // 
            // stockError
            // 
            this.stockError.AutoSize = true;
            this.stockError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockError.ForeColor = System.Drawing.Color.Red;
            this.stockError.Location = new System.Drawing.Point(19, 250);
            this.stockError.Name = "stockError";
            this.stockError.Size = new System.Drawing.Size(0, 17);
            this.stockError.TabIndex = 18;
            // 
            // stockTextbox
            // 
            this.stockTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockTextbox.Location = new System.Drawing.Point(22, 218);
            this.stockTextbox.Name = "stockTextbox";
            this.stockTextbox.Size = new System.Drawing.Size(284, 29);
            this.stockTextbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Stock";
            // 
            // unitPriceError
            // 
            this.unitPriceError.AutoSize = true;
            this.unitPriceError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceError.ForeColor = System.Drawing.Color.Red;
            this.unitPriceError.Location = new System.Drawing.Point(19, 168);
            this.unitPriceError.Name = "unitPriceError";
            this.unitPriceError.Size = new System.Drawing.Size(0, 17);
            this.unitPriceError.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unit Price";
            // 
            // expiryDateTime
            // 
            this.expiryDateTime.CustomFormat = "dd-MM-yyyy";
            this.expiryDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryDateTime.Location = new System.Drawing.Point(22, 299);
            this.expiryDateTime.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.expiryDateTime.MinDate = new System.DateTime(2022, 4, 1, 0, 0, 0, 0);
            this.expiryDateTime.Name = "expiryDateTime";
            this.expiryDateTime.Size = new System.Drawing.Size(284, 29);
            this.expiryDateTime.TabIndex = 8;
            this.expiryDateTime.Value = new System.DateTime(2022, 4, 23, 2, 27, 36, 0);
            // 
            // expiryDateError
            // 
            this.expiryDateError.AutoSize = true;
            this.expiryDateError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateError.ForeColor = System.Drawing.Color.Red;
            this.expiryDateError.Location = new System.Drawing.Point(19, 331);
            this.expiryDateError.Name = "expiryDateError";
            this.expiryDateError.Size = new System.Drawing.Size(0, 17);
            this.expiryDateError.TabIndex = 11;
            // 
            // batchTitleError
            // 
            this.batchTitleError.AutoSize = true;
            this.batchTitleError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchTitleError.ForeColor = System.Drawing.Color.Red;
            this.batchTitleError.Location = new System.Drawing.Point(19, 84);
            this.batchTitleError.Name = "batchTitleError";
            this.batchTitleError.Size = new System.Drawing.Size(0, 17);
            this.batchTitleError.TabIndex = 10;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.Color.Black;
            this.contactLabel.Location = new System.Drawing.Point(18, 276);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(93, 21);
            this.contactLabel.TabIndex = 3;
            this.contactLabel.Text = "Expiry Date";
            // 
            // batchTitleTextbox
            // 
            this.batchTitleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.batchTitleTextbox.Location = new System.Drawing.Point(22, 52);
            this.batchTitleTextbox.Name = "batchTitleTextbox";
            this.batchTitleTextbox.Size = new System.Drawing.Size(284, 29);
            this.batchTitleTextbox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Batch Title";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 665);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.addItemButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label companyError;
        private System.Windows.Forms.Label distributorError;
        private System.Windows.Forms.Label categoryError;
        private System.Windows.Forms.Label itemNameError;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox categoryCombobox;
        private System.Windows.Forms.ComboBox companyCombobox;
        private System.Windows.Forms.ComboBox distributorCombobox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stockError;
        private System.Windows.Forms.TextBox stockTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label unitPriceError;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker expiryDateTime;
        private System.Windows.Forms.Label expiryDateError;
        private System.Windows.Forms.Label batchTitleError;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox batchTitleTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox unitPriceTextbox;
    }
}