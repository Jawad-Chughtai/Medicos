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
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.companyError = new System.Windows.Forms.Label();
            this.distributorError = new System.Windows.Forms.Label();
            this.categoryError = new System.Windows.Forms.Label();
            this.itemNameError = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.categoryCombobox = new System.Windows.Forms.ComboBox();
            this.distributorCombobox = new System.Windows.Forms.ComboBox();
            this.companyCombobox = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.deleteItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteItemButton.Location = new System.Drawing.Point(929, 555);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(123, 39);
            this.deleteItemButton.TabIndex = 15;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(591, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Existing Items";
            // 
            // itemGridView
            // 
            this.itemGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Location = new System.Drawing.Point(596, 104);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.Size = new System.Drawing.Size(456, 431);
            this.itemGridView.TabIndex = 13;
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
            this.panel2.Controls.Add(this.addItemButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.itemNameTextbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(117, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 431);
            this.panel2.TabIndex = 12;
            // 
            // companyError
            // 
            this.companyError.AutoSize = true;
            this.companyError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyError.ForeColor = System.Drawing.Color.Red;
            this.companyError.Location = new System.Drawing.Point(19, 303);
            this.companyError.Name = "companyError";
            this.companyError.Size = new System.Drawing.Size(93, 17);
            this.companyError.TabIndex = 13;
            this.companyError.Text = "Company error";
            // 
            // distributorError
            // 
            this.distributorError.AutoSize = true;
            this.distributorError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distributorError.ForeColor = System.Drawing.Color.Red;
            this.distributorError.Location = new System.Drawing.Point(19, 231);
            this.distributorError.Name = "distributorError";
            this.distributorError.Size = new System.Drawing.Size(99, 17);
            this.distributorError.TabIndex = 12;
            this.distributorError.Text = "Distributor Error";
            // 
            // categoryError
            // 
            this.categoryError.AutoSize = true;
            this.categoryError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryError.ForeColor = System.Drawing.Color.Red;
            this.categoryError.Location = new System.Drawing.Point(19, 159);
            this.categoryError.Name = "categoryError";
            this.categoryError.Size = new System.Drawing.Size(90, 17);
            this.categoryError.TabIndex = 11;
            this.categoryError.Text = "Category error";
            // 
            // itemNameError
            // 
            this.itemNameError.AutoSize = true;
            this.itemNameError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameError.ForeColor = System.Drawing.Color.Red;
            this.itemNameError.Location = new System.Drawing.Point(19, 84);
            this.itemNameError.Name = "itemNameError";
            this.itemNameError.Size = new System.Drawing.Size(99, 17);
            this.itemNameError.TabIndex = 10;
            this.itemNameError.Text = "Item name error";
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addItemButton.Location = new System.Drawing.Point(182, 338);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(123, 39);
            this.addItemButton.TabIndex = 9;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 249);
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
            this.label3.Location = new System.Drawing.Point(18, 177);
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
            this.label2.Location = new System.Drawing.Point(18, 104);
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
            this.itemNameTextbox.TabIndex = 2;
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
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Gray;
            this.labelUser.Location = new System.Drawing.Point(112, 71);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(109, 30);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "New Item";
            // 
            // categoryCombobox
            // 
            this.categoryCombobox.FormattingEnabled = true;
            this.categoryCombobox.Location = new System.Drawing.Point(22, 127);
            this.categoryCombobox.Name = "categoryCombobox";
            this.categoryCombobox.Size = new System.Drawing.Size(283, 29);
            this.categoryCombobox.TabIndex = 16;
            // 
            // distributorCombobox
            // 
            this.distributorCombobox.FormattingEnabled = true;
            this.distributorCombobox.Location = new System.Drawing.Point(22, 199);
            this.distributorCombobox.Name = "distributorCombobox";
            this.distributorCombobox.Size = new System.Drawing.Size(283, 29);
            this.distributorCombobox.TabIndex = 17;
            // 
            // companyCombobox
            // 
            this.companyCombobox.FormattingEnabled = true;
            this.companyCombobox.Location = new System.Drawing.Point(22, 271);
            this.companyCombobox.Name = "companyCombobox";
            this.companyCombobox.Size = new System.Drawing.Size(283, 29);
            this.companyCombobox.TabIndex = 18;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 665);
            this.ControlBox = false;
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUser);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView itemGridView;
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
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}