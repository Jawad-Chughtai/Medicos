namespace MedicosUI
{
    partial class POSForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.unitPriceTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.POSGridView = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.discountLabel = new System.Windows.Forms.Label();
            this.GSTLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.itemsTotalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.discountButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POSGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(503, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Point of Sale";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.amountTextbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.quantityTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addItemButton);
            this.panel2.Controls.Add(this.unitPriceTextbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.itemTextbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(148, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 60);
            this.panel2.TabIndex = 18;
            // 
            // amountTextbox
            // 
            this.amountTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.amountTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTextbox.Location = new System.Drawing.Point(584, 26);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.ReadOnly = true;
            this.amountTextbox.Size = new System.Drawing.Size(124, 29);
            this.amountTextbox.TabIndex = 0;
            this.amountTextbox.TabStop = false;
            this.amountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(580, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.quantityTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityTextbox.Location = new System.Drawing.Point(452, 26);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.ReadOnly = true;
            this.quantityTextbox.Size = new System.Drawing.Size(103, 29);
            this.quantityTextbox.TabIndex = 2;
            this.quantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTextbox.TextChanged += new System.EventHandler(this.quantityTextbox_TextChanged);
            this.quantityTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantityTextbox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(448, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addItemButton.Location = new System.Drawing.Point(739, 23);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(112, 32);
            this.addItemButton.TabIndex = 3;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            this.addItemButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addItemButton_KeyDown);
            // 
            // unitPriceTextbox
            // 
            this.unitPriceTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.unitPriceTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitPriceTextbox.Location = new System.Drawing.Point(325, 26);
            this.unitPriceTextbox.Name = "unitPriceTextbox";
            this.unitPriceTextbox.ReadOnly = true;
            this.unitPriceTextbox.Size = new System.Drawing.Size(103, 29);
            this.unitPriceTextbox.TabIndex = 0;
            this.unitPriceTextbox.TabStop = false;
            this.unitPriceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(321, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit Price";
            // 
            // itemTextbox
            // 
            this.itemTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemTextbox.Location = new System.Drawing.Point(22, 26);
            this.itemTextbox.Name = "itemTextbox";
            this.itemTextbox.Size = new System.Drawing.Size(284, 29);
            this.itemTextbox.TabIndex = 1;
            this.itemTextbox.TextChanged += new System.EventHandler(this.itemTextbox_TextChanged);
            this.itemTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemTextbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item";
            // 
            // POSGridView
            // 
            this.POSGridView.AllowUserToAddRows = false;
            this.POSGridView.AllowUserToDeleteRows = false;
            this.POSGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.POSGridView.BackgroundColor = System.Drawing.Color.White;
            this.POSGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.POSGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.POSGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.POSGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.POSGridView.Location = new System.Drawing.Point(59, 120);
            this.POSGridView.MultiSelect = false;
            this.POSGridView.Name = "POSGridView";
            this.POSGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.POSGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.POSGridView.RowTemplate.Height = 26;
            this.POSGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.POSGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.POSGridView.ShowEditingIcon = false;
            this.POSGridView.Size = new System.Drawing.Size(1038, 394);
            this.POSGridView.TabIndex = 20;
            this.POSGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.POSGridView_KeyDown);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.removeButton.Location = new System.Drawing.Point(1100, 485);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(62, 29);
            this.removeButton.TabIndex = 21;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
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
            this.panel1.Location = new System.Drawing.Point(831, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 92);
            this.panel1.TabIndex = 22;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(834, 615);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Total Amount :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.ForeColor = System.Drawing.Color.Red;
            this.totalAmountLabel.Location = new System.Drawing.Point(1003, 615);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalAmountLabel.Size = new System.Drawing.Size(50, 25);
            this.totalAmountLabel.TabIndex = 30;
            this.totalAmountLabel.Text = "0.00";
            this.totalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountButton
            // 
            this.discountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.discountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.discountButton.Location = new System.Drawing.Point(667, 575);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(112, 32);
            this.discountButton.TabIndex = 31;
            this.discountButton.Text = "Discount";
            this.discountButton.UseVisualStyleBackColor = false;
            this.discountButton.Click += new System.EventHandler(this.discountButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Red;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.Control;
            this.printButton.Location = new System.Drawing.Point(667, 608);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(112, 32);
            this.printButton.TabIndex = 32;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // itemsGridView
            // 
            this.itemsGridView.AllowUserToAddRows = false;
            this.itemsGridView.AllowUserToDeleteRows = false;
            this.itemsGridView.AllowUserToResizeColumns = false;
            this.itemsGridView.AllowUserToResizeRows = false;
            this.itemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.GridColor = System.Drawing.Color.White;
            this.itemsGridView.Location = new System.Drawing.Point(170, 97);
            this.itemsGridView.MultiSelect = false;
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.ReadOnly = true;
            this.itemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsGridView.Size = new System.Drawing.Size(284, 150);
            this.itemsGridView.TabIndex = 33;
            this.itemsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGridView_CellClick);
            this.itemsGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemsGridView_KeyDown);
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 665);
            this.ControlBox = false;
            this.Controls.Add(this.itemsGridView);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.discountButton);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.POSGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POSForm";
            this.Text = "POSForm";
            this.Load += new System.EventHandler(this.POSForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POSGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox unitPriceTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemTextbox;
        private System.Windows.Forms.DataGridView POSGridView;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label GSTLabel;
        private System.Windows.Forms.Label itemsTotalLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Button discountButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridView itemsGridView;
    }
}