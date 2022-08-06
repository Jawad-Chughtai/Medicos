namespace MedicosUI
{
    partial class InvoiceViewForm
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
            this.dateTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.invoiceTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contactTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.ReceiptGridView = new System.Windows.Forms.DataGridView();
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.createdByTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 5);
            this.panel2.TabIndex = 13;
            // 
            // dateTextbox
            // 
            this.dateTextbox.Location = new System.Drawing.Point(505, 8);
            this.dateTextbox.Name = "dateTextbox";
            this.dateTextbox.ReadOnly = true;
            this.dateTextbox.Size = new System.Drawing.Size(179, 25);
            this.dateTextbox.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label8.Location = new System.Drawing.Point(452, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 69;
            this.label8.Text = "Date : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoiceTextbox
            // 
            this.invoiceTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.invoiceTextbox.Location = new System.Drawing.Point(550, 60);
            this.invoiceTextbox.Name = "invoiceTextbox";
            this.invoiceTextbox.ReadOnly = true;
            this.invoiceTextbox.Size = new System.Drawing.Size(134, 25);
            this.invoiceTextbox.TabIndex = 67;
            this.invoiceTextbox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(493, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Invoice :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactTextbox
            // 
            this.contactTextbox.Location = new System.Drawing.Point(315, 8);
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.ReadOnly = true;
            this.contactTextbox.Size = new System.Drawing.Size(115, 25);
            this.contactTextbox.TabIndex = 65;
            this.contactTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(252, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Contact : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(22, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Customer : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Red;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.Control;
            this.printButton.Location = new System.Drawing.Point(297, 608);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(102, 32);
            this.printButton.TabIndex = 59;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.ForeColor = System.Drawing.Color.Red;
            this.totalAmountLabel.Location = new System.Drawing.Point(590, 615);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalAmountLabel.Size = new System.Drawing.Size(50, 25);
            this.totalAmountLabel.TabIndex = 57;
            this.totalAmountLabel.Text = "0.00";
            this.totalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(421, 615);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 58;
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
            this.panel1.Location = new System.Drawing.Point(418, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 92);
            this.panel1.TabIndex = 56;
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
            // ReceiptGridView
            // 
            this.ReceiptGridView.AllowUserToAddRows = false;
            this.ReceiptGridView.AllowUserToDeleteRows = false;
            this.ReceiptGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReceiptGridView.BackgroundColor = System.Drawing.Color.White;
            this.ReceiptGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceiptGridView.GridColor = System.Drawing.Color.White;
            this.ReceiptGridView.Location = new System.Drawing.Point(18, 91);
            this.ReceiptGridView.MultiSelect = false;
            this.ReceiptGridView.Name = "ReceiptGridView";
            this.ReceiptGridView.ReadOnly = true;
            this.ReceiptGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReceiptGridView.ShowEditingIcon = false;
            this.ReceiptGridView.Size = new System.Drawing.Size(666, 418);
            this.ReceiptGridView.TabIndex = 52;
            this.ReceiptGridView.TabStop = false;
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Location = new System.Drawing.Point(95, 8);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.ReadOnly = true;
            this.customerNameTextbox.Size = new System.Drawing.Size(151, 25);
            this.customerNameTextbox.TabIndex = 71;
            // 
            // createdByTextbox
            // 
            this.createdByTextbox.Location = new System.Drawing.Point(109, 60);
            this.createdByTextbox.Name = "createdByTextbox";
            this.createdByTextbox.ReadOnly = true;
            this.createdByTextbox.Size = new System.Drawing.Size(151, 25);
            this.createdByTextbox.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Created By :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InvoiceViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 648);
            this.Controls.Add(this.createdByTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.dateTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.invoiceTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contactTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReceiptGridView);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "InvoiceViewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox dateTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox invoiceTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contactTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.DataGridView ReceiptGridView;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.TextBox createdByTextbox;
        private System.Windows.Forms.Label label1;
    }
}