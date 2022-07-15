namespace MedicosUI
{
    partial class DistributorForm
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
            this.deleteDistributorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.distributorGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contactError = new System.Windows.Forms.Label();
            this.contactTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.distributorTitleError = new System.Windows.Forms.Label();
            this.addDistributorButton = new System.Windows.Forms.Button();
            this.distributorTitleTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.distributorGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteDistributorButton
            // 
            this.deleteDistributorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.deleteDistributorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDistributorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDistributorButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteDistributorButton.Location = new System.Drawing.Point(897, 555);
            this.deleteDistributorButton.Name = "deleteDistributorButton";
            this.deleteDistributorButton.Size = new System.Drawing.Size(155, 39);
            this.deleteDistributorButton.TabIndex = 5;
            this.deleteDistributorButton.Text = "Delete Distributor";
            this.deleteDistributorButton.UseVisualStyleBackColor = false;
            this.deleteDistributorButton.Click += new System.EventHandler(this.deleteDistributorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(591, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Existing Distributors";
            // 
            // distributorGridView
            // 
            this.distributorGridView.AllowUserToAddRows = false;
            this.distributorGridView.AllowUserToDeleteRows = false;
            this.distributorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.distributorGridView.BackgroundColor = System.Drawing.Color.White;
            this.distributorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distributorGridView.Location = new System.Drawing.Point(596, 104);
            this.distributorGridView.MultiSelect = false;
            this.distributorGridView.Name = "distributorGridView";
            this.distributorGridView.ReadOnly = true;
            this.distributorGridView.RowTemplate.Height = 26;
            this.distributorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.distributorGridView.Size = new System.Drawing.Size(456, 431);
            this.distributorGridView.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.contactError);
            this.panel2.Controls.Add(this.contactTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.distributorTitleError);
            this.panel2.Controls.Add(this.addDistributorButton);
            this.panel2.Controls.Add(this.distributorTitleTextbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(117, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 431);
            this.panel2.TabIndex = 21;
            // 
            // contactError
            // 
            this.contactError.AutoSize = true;
            this.contactError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactError.ForeColor = System.Drawing.Color.Red;
            this.contactError.Location = new System.Drawing.Point(19, 156);
            this.contactError.Name = "contactError";
            this.contactError.Size = new System.Drawing.Size(0, 17);
            this.contactError.TabIndex = 13;
            // 
            // contactTextbox
            // 
            this.contactTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTextbox.Location = new System.Drawing.Point(22, 124);
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.Size = new System.Drawing.Size(284, 29);
            this.contactTextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Distributor Contact";
            // 
            // distributorTitleError
            // 
            this.distributorTitleError.AutoSize = true;
            this.distributorTitleError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distributorTitleError.ForeColor = System.Drawing.Color.Red;
            this.distributorTitleError.Location = new System.Drawing.Point(19, 84);
            this.distributorTitleError.Name = "distributorTitleError";
            this.distributorTitleError.Size = new System.Drawing.Size(0, 17);
            this.distributorTitleError.TabIndex = 10;
            // 
            // addDistributorButton
            // 
            this.addDistributorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.addDistributorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDistributorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDistributorButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addDistributorButton.Location = new System.Drawing.Point(171, 184);
            this.addDistributorButton.Name = "addDistributorButton";
            this.addDistributorButton.Size = new System.Drawing.Size(135, 39);
            this.addDistributorButton.TabIndex = 3;
            this.addDistributorButton.Text = "Add Distributor";
            this.addDistributorButton.UseVisualStyleBackColor = false;
            this.addDistributorButton.Click += new System.EventHandler(this.addDistributorButton_Click);
            // 
            // distributorTitleTextbox
            // 
            this.distributorTitleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distributorTitleTextbox.Location = new System.Drawing.Point(22, 52);
            this.distributorTitleTextbox.Name = "distributorTitleTextbox";
            this.distributorTitleTextbox.Size = new System.Drawing.Size(284, 29);
            this.distributorTitleTextbox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Distributor Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(112, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "New Distributor";
            // 
            // DistributorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 665);
            this.ControlBox = false;
            this.Controls.Add(this.deleteDistributorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distributorGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DistributorForm";
            this.Text = "DistributorForm";
            ((System.ComponentModel.ISupportInitialize)(this.distributorGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteDistributorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView distributorGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label distributorTitleError;
        private System.Windows.Forms.Button addDistributorButton;
        private System.Windows.Forms.TextBox distributorTitleTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label contactError;
        private System.Windows.Forms.TextBox contactTextbox;
        private System.Windows.Forms.Label label3;
    }
}