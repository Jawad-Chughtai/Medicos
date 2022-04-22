namespace MedicosUI
{
    partial class SalesForm
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
            this.salesGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalSalesTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectSaleCombobox = new System.Windows.Forms.ComboBox();
            this.viewSalesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesGridView
            // 
            this.salesGridView.BackgroundColor = System.Drawing.Color.White;
            this.salesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGridView.Location = new System.Drawing.Point(139, 199);
            this.salesGridView.Name = "salesGridView";
            this.salesGridView.Size = new System.Drawing.Size(837, 431);
            this.salesGridView.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.totalSalesTextbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.selectSaleCombobox);
            this.panel2.Controls.Add(this.viewSalesButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(117, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 89);
            this.panel2.TabIndex = 28;
            // 
            // totalSalesTextbox
            // 
            this.totalSalesTextbox.BackColor = System.Drawing.Color.White;
            this.totalSalesTextbox.Location = new System.Drawing.Point(576, 53);
            this.totalSalesTextbox.Name = "totalSalesTextbox";
            this.totalSalesTextbox.ReadOnly = true;
            this.totalSalesTextbox.Size = new System.Drawing.Size(284, 29);
            this.totalSalesTextbox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(572, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Sales";
            // 
            // selectSaleCombobox
            // 
            this.selectSaleCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSaleCombobox.FormattingEnabled = true;
            this.selectSaleCombobox.Location = new System.Drawing.Point(22, 53);
            this.selectSaleCombobox.Name = "selectSaleCombobox";
            this.selectSaleCombobox.Size = new System.Drawing.Size(284, 29);
            this.selectSaleCombobox.TabIndex = 11;
            // 
            // viewSalesButton
            // 
            this.viewSalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.viewSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSalesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSalesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.viewSalesButton.Location = new System.Drawing.Point(329, 47);
            this.viewSalesButton.Name = "viewSalesButton";
            this.viewSalesButton.Size = new System.Drawing.Size(144, 39);
            this.viewSalesButton.TabIndex = 9;
            this.viewSalesButton.Text = "View Sales";
            this.viewSalesButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Sales";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Gray;
            this.labelUser.Location = new System.Drawing.Point(112, 71);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(118, 30);
            this.labelUser.TabIndex = 27;
            this.labelUser.Text = "View Sales";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 665);
            this.ControlBox = false;
            this.Controls.Add(this.salesGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUser);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox selectSaleCombobox;
        private System.Windows.Forms.Button viewSalesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalSalesTextbox;
    }
}