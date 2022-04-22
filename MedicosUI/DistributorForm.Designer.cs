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
            this.companyGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.distributorTitleError = new System.Windows.Forms.Label();
            this.addDistributorButton = new System.Windows.Forms.Button();
            this.distributorTitleTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
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
            this.deleteDistributorButton.TabIndex = 24;
            this.deleteDistributorButton.Text = "Delete Distributor";
            this.deleteDistributorButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(591, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Existing Companies";
            // 
            // companyGridView
            // 
            this.companyGridView.BackgroundColor = System.Drawing.Color.White;
            this.companyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGridView.Location = new System.Drawing.Point(596, 104);
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.Size = new System.Drawing.Size(456, 431);
            this.companyGridView.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.distributorTitleError);
            this.panel2.Controls.Add(this.addDistributorButton);
            this.panel2.Controls.Add(this.distributorTitleTextbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(117, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 431);
            this.panel2.TabIndex = 21;
            // 
            // distributorTitleError
            // 
            this.distributorTitleError.AutoSize = true;
            this.distributorTitleError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distributorTitleError.ForeColor = System.Drawing.Color.Red;
            this.distributorTitleError.Location = new System.Drawing.Point(19, 84);
            this.distributorTitleError.Name = "distributorTitleError";
            this.distributorTitleError.Size = new System.Drawing.Size(126, 17);
            this.distributorTitleError.TabIndex = 10;
            this.distributorTitleError.Text = "Distributor Title error";
            // 
            // addDistributorButton
            // 
            this.addDistributorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.addDistributorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDistributorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDistributorButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addDistributorButton.Location = new System.Drawing.Point(171, 121);
            this.addDistributorButton.Name = "addDistributorButton";
            this.addDistributorButton.Size = new System.Drawing.Size(135, 39);
            this.addDistributorButton.TabIndex = 9;
            this.addDistributorButton.Text = "Add Distributor";
            this.addDistributorButton.UseVisualStyleBackColor = false;
            // 
            // distributorTitleTextbox
            // 
            this.distributorTitleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distributorTitleTextbox.Location = new System.Drawing.Point(22, 52);
            this.distributorTitleTextbox.Name = "distributorTitleTextbox";
            this.distributorTitleTextbox.Size = new System.Drawing.Size(284, 29);
            this.distributorTitleTextbox.TabIndex = 2;
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
            this.Controls.Add(this.companyGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DistributorForm";
            this.Text = "DistributorForm";
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteDistributorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView companyGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label distributorTitleError;
        private System.Windows.Forms.Button addDistributorButton;
        private System.Windows.Forms.TextBox distributorTitleTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}