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
            this.deleteInvoiceButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerNameError = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteInvoiceButton
            // 
            this.deleteInvoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.deleteInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteInvoiceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteInvoiceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteInvoiceButton.Location = new System.Drawing.Point(903, 555);
            this.deleteInvoiceButton.Name = "deleteInvoiceButton";
            this.deleteInvoiceButton.Size = new System.Drawing.Size(149, 39);
            this.deleteInvoiceButton.TabIndex = 20;
            this.deleteInvoiceButton.Text = "Delete Invoice";
            this.deleteInvoiceButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(591, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Invoice";
            // 
            // customerGridView
            // 
            this.customerGridView.BackgroundColor = System.Drawing.Color.White;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(596, 104);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Size = new System.Drawing.Size(456, 431);
            this.customerGridView.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.customerNameError);
            this.panel2.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(22, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 29);
            this.textBox1.TabIndex = 14;
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
            this.invoiceDateTime.Location = new System.Drawing.Point(22, 218);
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
            this.dateError.Location = new System.Drawing.Point(19, 250);
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
            this.searchInvoiceButton.Location = new System.Drawing.Point(162, 286);
            this.searchInvoiceButton.Name = "searchInvoiceButton";
            this.searchInvoiceButton.Size = new System.Drawing.Size(144, 39);
            this.searchInvoiceButton.TabIndex = 9;
            this.searchInvoiceButton.Text = "Search Invoice";
            this.searchInvoiceButton.UseVisualStyleBackColor = false;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.Color.Black;
            this.contactLabel.Location = new System.Drawing.Point(18, 195);
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
            this.invoiceAvailableError.Location = new System.Drawing.Point(851, 84);
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
            this.Controls.Add(this.deleteInvoiceButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUser);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteInvoiceButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView customerGridView;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}