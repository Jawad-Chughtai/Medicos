namespace MedicosUI
{
    partial class InvoiceForm
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
            this.viewInvoiceButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.invoiceGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateSearchButton = new System.Windows.Forms.Button();
            this.customerNameError = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.invoiceDateTime = new System.Windows.Forms.DateTimePicker();
            this.dateError = new System.Windows.Forms.Label();
            this.invoiceIDError = new System.Windows.Forms.Label();
            this.searchInvoiceButton = new System.Windows.Forms.Button();
            this.contactLabel = new System.Windows.Forms.Label();
            this.invoiceIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.invoiceAvailableError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewInvoiceButton
            // 
            this.viewInvoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.viewInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewInvoiceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInvoiceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.viewInvoiceButton.Location = new System.Drawing.Point(931, 541);
            this.viewInvoiceButton.Name = "viewInvoiceButton";
            this.viewInvoiceButton.Size = new System.Drawing.Size(149, 39);
            this.viewInvoiceButton.TabIndex = 20;
            this.viewInvoiceButton.Text = "View Invoice";
            this.viewInvoiceButton.UseVisualStyleBackColor = false;
            this.viewInvoiceButton.Click += new System.EventHandler(this.viewInvoiceButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(468, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Invoice";
            // 
            // invoiceGridView
            // 
            this.invoiceGridView.AllowUserToAddRows = false;
            this.invoiceGridView.AllowUserToDeleteRows = false;
            this.invoiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceGridView.BackgroundColor = System.Drawing.Color.White;
            this.invoiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceGridView.Location = new System.Drawing.Point(473, 104);
            this.invoiceGridView.MultiSelect = false;
            this.invoiceGridView.Name = "invoiceGridView";
            this.invoiceGridView.ReadOnly = true;
            this.invoiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceGridView.Size = new System.Drawing.Size(607, 431);
            this.invoiceGridView.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dateSearchButton);
            this.panel2.Controls.Add(this.customerNameError);
            this.panel2.Controls.Add(this.customerName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.invoiceDateTime);
            this.panel2.Controls.Add(this.dateError);
            this.panel2.Controls.Add(this.invoiceIDError);
            this.panel2.Controls.Add(this.searchInvoiceButton);
            this.panel2.Controls.Add(this.contactLabel);
            this.panel2.Controls.Add(this.invoiceIDTextbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(117, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 431);
            this.panel2.TabIndex = 17;
            // 
            // dateSearchButton
            // 
            this.dateSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.dateSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.dateSearchButton.Location = new System.Drawing.Point(162, 303);
            this.dateSearchButton.Name = "dateSearchButton";
            this.dateSearchButton.Size = new System.Drawing.Size(144, 39);
            this.dateSearchButton.TabIndex = 16;
            this.dateSearchButton.Text = "Search Date";
            this.dateSearchButton.UseVisualStyleBackColor = false;
            this.dateSearchButton.Click += new System.EventHandler(this.dateSearchButton_Click);
            // 
            // customerNameError
            // 
            this.customerNameError.AutoSize = true;
            this.customerNameError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameError.ForeColor = System.Drawing.Color.Red;
            this.customerNameError.Location = new System.Drawing.Point(19, 168);
            this.customerNameError.Name = "customerNameError";
            this.customerNameError.Size = new System.Drawing.Size(128, 17);
            this.customerNameError.TabIndex = 15;
            this.customerNameError.Text = "Customer name error";
            // 
            // customerName
            // 
            this.customerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerName.Location = new System.Drawing.Point(22, 136);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(284, 29);
            this.customerName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Customer Name";
            // 
            // invoiceDateTime
            // 
            this.invoiceDateTime.CustomFormat = "dd-MM-yyyy";
            this.invoiceDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceDateTime.Location = new System.Drawing.Point(22, 268);
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
            this.dateError.Location = new System.Drawing.Point(19, 300);
            this.dateError.Name = "dateError";
            this.dateError.Size = new System.Drawing.Size(66, 17);
            this.dateError.TabIndex = 11;
            this.dateError.Text = "Date error";
            // 
            // invoiceIDError
            // 
            this.invoiceIDError.AutoSize = true;
            this.invoiceIDError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceIDError.ForeColor = System.Drawing.Color.Red;
            this.invoiceIDError.Location = new System.Drawing.Point(19, 84);
            this.invoiceIDError.Name = "invoiceIDError";
            this.invoiceIDError.Size = new System.Drawing.Size(92, 17);
            this.invoiceIDError.TabIndex = 10;
            this.invoiceIDError.Text = "Invoice id error";
            // 
            // searchInvoiceButton
            // 
            this.searchInvoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.searchInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchInvoiceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInvoiceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchInvoiceButton.Location = new System.Drawing.Point(162, 171);
            this.searchInvoiceButton.Name = "searchInvoiceButton";
            this.searchInvoiceButton.Size = new System.Drawing.Size(144, 39);
            this.searchInvoiceButton.TabIndex = 9;
            this.searchInvoiceButton.Text = "Search Invoice";
            this.searchInvoiceButton.UseVisualStyleBackColor = false;
            this.searchInvoiceButton.Click += new System.EventHandler(this.searchInvoiceButton_Click);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.Color.Black;
            this.contactLabel.Location = new System.Drawing.Point(18, 245);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(101, 21);
            this.contactLabel.TabIndex = 3;
            this.contactLabel.Text = "Invoice Date";
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
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice Id";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Gray;
            this.labelUser.Location = new System.Drawing.Point(112, 71);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(155, 30);
            this.labelUser.TabIndex = 16;
            this.labelUser.Text = "Search Invoice";
            // 
            // invoiceAvailableError
            // 
            this.invoiceAvailableError.AutoSize = true;
            this.invoiceAvailableError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceAvailableError.ForeColor = System.Drawing.Color.Red;
            this.invoiceAvailableError.Location = new System.Drawing.Point(879, 84);
            this.invoiceAvailableError.Name = "invoiceAvailableError";
            this.invoiceAvailableError.Size = new System.Drawing.Size(201, 17);
            this.invoiceAvailableError.TabIndex = 13;
            this.invoiceAvailableError.Text = "Invoice is not available in database";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 665);
            this.ControlBox = false;
            this.Controls.Add(this.invoiceAvailableError);
            this.Controls.Add(this.viewInvoiceButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.invoiceGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUser);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewInvoiceButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView invoiceGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker invoiceDateTime;
        private System.Windows.Forms.Label dateError;
        private System.Windows.Forms.Label invoiceIDError;
        private System.Windows.Forms.Button searchInvoiceButton;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox invoiceIDTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label invoiceAvailableError;
        private System.Windows.Forms.Label customerNameError;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dateSearchButton;
    }
}