namespace MedicosUI
{
    partial class BatchForm
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
            this.deleteBatchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemNameError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.invoiceDateTime = new System.Windows.Forms.DateTimePicker();
            this.dateError = new System.Windows.Forms.Label();
            this.batchTitleError = new System.Windows.Forms.Label();
            this.searchInvoiceButton = new System.Windows.Forms.Button();
            this.contactLabel = new System.Windows.Forms.Label();
            this.invoiceIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.stockError = new System.Windows.Forms.Label();
            this.stockTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemNameCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteBatchButton
            // 
            this.deleteBatchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.deleteBatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBatchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBatchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteBatchButton.Location = new System.Drawing.Point(903, 555);
            this.deleteBatchButton.Name = "deleteBatchButton";
            this.deleteBatchButton.Size = new System.Drawing.Size(149, 39);
            this.deleteBatchButton.TabIndex = 26;
            this.deleteBatchButton.Text = "Delete Batch";
            this.deleteBatchButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(591, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "Existing Batches";
            // 
            // customerGridView
            // 
            this.customerGridView.BackgroundColor = System.Drawing.Color.White;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(596, 104);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Size = new System.Drawing.Size(456, 431);
            this.customerGridView.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.itemNameCombobox);
            this.panel2.Controls.Add(this.stockError);
            this.panel2.Controls.Add(this.stockTextbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.itemNameError);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.invoiceDateTime);
            this.panel2.Controls.Add(this.dateError);
            this.panel2.Controls.Add(this.batchTitleError);
            this.panel2.Controls.Add(this.searchInvoiceButton);
            this.panel2.Controls.Add(this.contactLabel);
            this.panel2.Controls.Add(this.invoiceIDTextbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(117, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 431);
            this.panel2.TabIndex = 23;
            // 
            // itemNameError
            // 
            this.itemNameError.AutoSize = true;
            this.itemNameError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameError.ForeColor = System.Drawing.Color.Red;
            this.itemNameError.Location = new System.Drawing.Point(19, 168);
            this.itemNameError.Name = "itemNameError";
            this.itemNameError.Size = new System.Drawing.Size(102, 17);
            this.itemNameError.TabIndex = 15;
            this.itemNameError.Text = "Item Name error";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Item Name";
            // 
            // invoiceDateTime
            // 
            this.invoiceDateTime.CustomFormat = "dd-MM-yyyy";
            this.invoiceDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceDateTime.Location = new System.Drawing.Point(22, 299);
            this.invoiceDateTime.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.invoiceDateTime.MinDate = new System.DateTime(2022, 4, 1, 0, 0, 0, 0);
            this.invoiceDateTime.Name = "invoiceDateTime";
            this.invoiceDateTime.Size = new System.Drawing.Size(284, 29);
            this.invoiceDateTime.TabIndex = 12;
            this.invoiceDateTime.Value = new System.DateTime(2022, 4, 23, 2, 27, 36, 0);
            // 
            // dateError
            // 
            this.dateError.AutoSize = true;
            this.dateError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateError.ForeColor = System.Drawing.Color.Red;
            this.dateError.Location = new System.Drawing.Point(19, 331);
            this.dateError.Name = "dateError";
            this.dateError.Size = new System.Drawing.Size(66, 17);
            this.dateError.TabIndex = 11;
            this.dateError.Text = "Date error";
            // 
            // batchTitleError
            // 
            this.batchTitleError.AutoSize = true;
            this.batchTitleError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchTitleError.ForeColor = System.Drawing.Color.Red;
            this.batchTitleError.Location = new System.Drawing.Point(19, 84);
            this.batchTitleError.Name = "batchTitleError";
            this.batchTitleError.Size = new System.Drawing.Size(95, 17);
            this.batchTitleError.TabIndex = 10;
            this.batchTitleError.Text = "Batch title error";
            // 
            // searchInvoiceButton
            // 
            this.searchInvoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.searchInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchInvoiceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInvoiceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchInvoiceButton.Location = new System.Drawing.Point(162, 367);
            this.searchInvoiceButton.Name = "searchInvoiceButton";
            this.searchInvoiceButton.Size = new System.Drawing.Size(144, 39);
            this.searchInvoiceButton.TabIndex = 9;
            this.searchInvoiceButton.Text = "Add Batch";
            this.searchInvoiceButton.UseVisualStyleBackColor = false;
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
            // invoiceIDTextbox
            // 
            this.invoiceIDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceIDTextbox.Location = new System.Drawing.Point(22, 52);
            this.invoiceIDTextbox.Name = "invoiceIDTextbox";
            this.invoiceIDTextbox.Size = new System.Drawing.Size(284, 29);
            this.invoiceIDTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Batch Title";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Gray;
            this.labelUser.Location = new System.Drawing.Point(112, 71);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(121, 30);
            this.labelUser.TabIndex = 22;
            this.labelUser.Text = "New Batch";
            // 
            // stockError
            // 
            this.stockError.AutoSize = true;
            this.stockError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockError.ForeColor = System.Drawing.Color.Red;
            this.stockError.Location = new System.Drawing.Point(19, 250);
            this.stockError.Name = "stockError";
            this.stockError.Size = new System.Drawing.Size(69, 17);
            this.stockError.TabIndex = 18;
            this.stockError.Text = "Stock error";
            // 
            // stockTextbox
            // 
            this.stockTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockTextbox.Location = new System.Drawing.Point(22, 218);
            this.stockTextbox.Name = "stockTextbox";
            this.stockTextbox.Size = new System.Drawing.Size(284, 29);
            this.stockTextbox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stock";
            // 
            // itemNameCombobox
            // 
            this.itemNameCombobox.FormattingEnabled = true;
            this.itemNameCombobox.Location = new System.Drawing.Point(22, 138);
            this.itemNameCombobox.Name = "itemNameCombobox";
            this.itemNameCombobox.Size = new System.Drawing.Size(284, 29);
            this.itemNameCombobox.TabIndex = 19;
            // 
            // BatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 665);
            this.ControlBox = false;
            this.Controls.Add(this.deleteBatchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUser);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchForm";
            this.Text = "BatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBatchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label stockError;
        private System.Windows.Forms.TextBox stockTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label itemNameError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker invoiceDateTime;
        private System.Windows.Forms.Label dateError;
        private System.Windows.Forms.Label batchTitleError;
        private System.Windows.Forms.Button searchInvoiceButton;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox invoiceIDTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox itemNameCombobox;
    }
}