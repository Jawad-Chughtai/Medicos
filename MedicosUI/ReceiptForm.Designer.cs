namespace MedicosUI
{
    partial class ReceiptForm
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
            this.ReceiptGridView = new System.Windows.Forms.DataGridView();
            this.printButton = new System.Windows.Forms.Button();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.discountLabel = new System.Windows.Forms.Label();
            this.GSTLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.itemsTotalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recieveAmountTextbox = new System.Windows.Forms.TextBox();
            this.changeTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contactTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.invoiceTextbox = new System.Windows.Forms.TextBox();
            this.discountButton = new System.Windows.Forms.Button();
            this.BalanceTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReceiptGridView
            // 
            this.ReceiptGridView.AllowUserToAddRows = false;
            this.ReceiptGridView.AllowUserToDeleteRows = false;
            this.ReceiptGridView.AllowUserToOrderColumns = true;
            this.ReceiptGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReceiptGridView.BackgroundColor = System.Drawing.Color.White;
            this.ReceiptGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceiptGridView.GridColor = System.Drawing.Color.White;
            this.ReceiptGridView.Location = new System.Drawing.Point(12, 92);
            this.ReceiptGridView.MultiSelect = false;
            this.ReceiptGridView.Name = "ReceiptGridView";
            this.ReceiptGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReceiptGridView.ShowEditingIcon = false;
            this.ReceiptGridView.Size = new System.Drawing.Size(666, 418);
            this.ReceiptGridView.TabIndex = 0;
            this.ReceiptGridView.TabStop = false;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Red;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.Control;
            this.printButton.Location = new System.Drawing.Point(12, 609);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(102, 32);
            this.printButton.TabIndex = 37;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.ForeColor = System.Drawing.Color.Red;
            this.totalAmountLabel.Location = new System.Drawing.Point(584, 616);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalAmountLabel.Size = new System.Drawing.Size(50, 25);
            this.totalAmountLabel.TabIndex = 34;
            this.totalAmountLabel.Text = "0.00";
            this.totalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(415, 616);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Total Amount :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.discountLabel);
            this.panel1.Controls.Add(this.GSTLabel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.itemsTotalLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(412, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 92);
            this.panel1.TabIndex = 33;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.discountLabel.Location = new System.Drawing.Point(171, 60);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discountLabel.Size = new System.Drawing.Size(50, 25);
            this.discountLabel.TabIndex = 29;
            this.discountLabel.Text = "0.00";
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GSTLabel
            // 
            this.GSTLabel.AutoSize = true;
            this.GSTLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GSTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.GSTLabel.Location = new System.Drawing.Point(171, 31);
            this.GSTLabel.Name = "GSTLabel";
            this.GSTLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GSTLabel.Size = new System.Drawing.Size(50, 25);
            this.GSTLabel.TabIndex = 28;
            this.GSTLabel.Text = "0.00";
            this.GSTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 2);
            this.panel3.TabIndex = 23;
            // 
            // itemsTotalLabel
            // 
            this.itemsTotalLabel.AutoSize = true;
            this.itemsTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.itemsTotalLabel.Location = new System.Drawing.Point(171, 3);
            this.itemsTotalLabel.Name = "itemsTotalLabel";
            this.itemsTotalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemsTotalLabel.Size = new System.Drawing.Size(50, 25);
            this.itemsTotalLabel.TabIndex = 27;
            this.itemsTotalLabel.Text = "0.00";
            this.itemsTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label7.Location = new System.Drawing.Point(3, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Discount :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "GST 17% :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label.Location = new System.Drawing.Point(3, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(121, 25);
            this.label.TabIndex = 24;
            this.label.Text = "Items Total : ";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Receive :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recieveAmountTextbox
            // 
            this.recieveAmountTextbox.Location = new System.Drawing.Point(100, 519);
            this.recieveAmountTextbox.Name = "recieveAmountTextbox";
            this.recieveAmountTextbox.Size = new System.Drawing.Size(134, 25);
            this.recieveAmountTextbox.TabIndex = 39;
            this.recieveAmountTextbox.TextChanged += new System.EventHandler(this.recieveAmountTextbox_TextChanged);
            // 
            // changeTextbox
            // 
            this.changeTextbox.Location = new System.Drawing.Point(100, 559);
            this.changeTextbox.Name = "changeTextbox";
            this.changeTextbox.ReadOnly = true;
            this.changeTextbox.Size = new System.Drawing.Size(134, 25);
            this.changeTextbox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Change :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Customer : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerCombobox
            // 
            this.customerCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customerCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customerCombobox.FormattingEnabled = true;
            this.customerCombobox.Location = new System.Drawing.Point(89, 9);
            this.customerCombobox.Name = "customerCombobox";
            this.customerCombobox.Size = new System.Drawing.Size(149, 25);
            this.customerCombobox.TabIndex = 43;
            this.customerCombobox.SelectionChangeCommitted += new System.EventHandler(this.customerCombobox_SelectionChangeCommitted);
            this.customerCombobox.SelectedValueChanged += new System.EventHandler(this.customerCombobox_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(246, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Contact : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactTextbox
            // 
            this.contactTextbox.Location = new System.Drawing.Point(309, 9);
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.Size = new System.Drawing.Size(115, 25);
            this.contactTextbox.TabIndex = 45;
            this.contactTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(487, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Invoice :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoiceTextbox
            // 
            this.invoiceTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.invoiceTextbox.Location = new System.Drawing.Point(544, 61);
            this.invoiceTextbox.Name = "invoiceTextbox";
            this.invoiceTextbox.ReadOnly = true;
            this.invoiceTextbox.Size = new System.Drawing.Size(134, 25);
            this.invoiceTextbox.TabIndex = 47;
            // 
            // discountButton
            // 
            this.discountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.discountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.discountButton.Location = new System.Drawing.Point(122, 609);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(112, 32);
            this.discountButton.TabIndex = 48;
            this.discountButton.Text = "Discount";
            this.discountButton.UseVisualStyleBackColor = false;
            this.discountButton.Click += new System.EventHandler(this.discountButton_Click);
            // 
            // BalanceTextbox
            // 
            this.BalanceTextbox.Location = new System.Drawing.Point(499, 9);
            this.BalanceTextbox.Name = "BalanceTextbox";
            this.BalanceTextbox.Size = new System.Drawing.Size(115, 25);
            this.BalanceTextbox.TabIndex = 50;
            this.BalanceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label8.Location = new System.Drawing.Point(436, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Balance : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Red;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveButton.Location = new System.Drawing.Point(632, 9);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(24, 25);
            this.RemoveButton.TabIndex = 51;
            this.RemoveButton.Text = "X";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 648);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.BalanceTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.discountButton);
            this.Controls.Add(this.invoiceTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contactTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recieveAmountTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReceiptGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceiptForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReceiptGridView;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label GSTLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label itemsTotalLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recieveAmountTextbox;
        private System.Windows.Forms.TextBox changeTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox customerCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contactTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox invoiceTextbox;
        private System.Windows.Forms.Button discountButton;
        private System.Windows.Forms.TextBox BalanceTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RemoveButton;
    }
}