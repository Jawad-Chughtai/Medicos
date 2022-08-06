namespace MedicosUI
{
    partial class BackupForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.restoreBackupButton = new System.Windows.Forms.Button();
            this.createBackupButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restoreBrowse = new System.Windows.Forms.Button();
            this.restorePathText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backupBrowse = new System.Windows.Forms.Button();
            this.backupPathText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.restoreBackupButton);
            this.panel1.Controls.Add(this.createBackupButton);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 317);
            this.panel1.TabIndex = 0;
            // 
            // restoreBackupButton
            // 
            this.restoreBackupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.restoreBackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreBackupButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreBackupButton.ForeColor = System.Drawing.SystemColors.Control;
            this.restoreBackupButton.Location = new System.Drawing.Point(412, 282);
            this.restoreBackupButton.Name = "restoreBackupButton";
            this.restoreBackupButton.Size = new System.Drawing.Size(114, 29);
            this.restoreBackupButton.TabIndex = 9;
            this.restoreBackupButton.Text = "Restore Backup";
            this.restoreBackupButton.UseVisualStyleBackColor = false;
            this.restoreBackupButton.Click += new System.EventHandler(this.restoreBackupButton_Click);
            // 
            // createBackupButton
            // 
            this.createBackupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.createBackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBackupButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBackupButton.ForeColor = System.Drawing.SystemColors.Control;
            this.createBackupButton.Location = new System.Drawing.Point(412, 121);
            this.createBackupButton.Name = "createBackupButton";
            this.createBackupButton.Size = new System.Drawing.Size(114, 29);
            this.createBackupButton.TabIndex = 8;
            this.createBackupButton.Text = "Create Backup";
            this.createBackupButton.UseVisualStyleBackColor = false;
            this.createBackupButton.Click += new System.EventHandler(this.createBackupButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.restoreBrowse);
            this.groupBox2.Controls.Add(this.restorePathText);
            this.groupBox2.Location = new System.Drawing.Point(21, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore";
            // 
            // restoreBrowse
            // 
            this.restoreBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreBrowse.Location = new System.Drawing.Point(419, 64);
            this.restoreBrowse.Name = "restoreBrowse";
            this.restoreBrowse.Size = new System.Drawing.Size(80, 30);
            this.restoreBrowse.TabIndex = 1;
            this.restoreBrowse.Text = "Browse";
            this.restoreBrowse.UseVisualStyleBackColor = true;
            this.restoreBrowse.Click += new System.EventHandler(this.restoreBrowse_Click);
            // 
            // restorePathText
            // 
            this.restorePathText.Location = new System.Drawing.Point(6, 33);
            this.restorePathText.Name = "restorePathText";
            this.restorePathText.ReadOnly = true;
            this.restorePathText.Size = new System.Drawing.Size(493, 25);
            this.restorePathText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backupBrowse);
            this.groupBox1.Controls.Add(this.backupPathText);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // backupBrowse
            // 
            this.backupBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupBrowse.Location = new System.Drawing.Point(419, 64);
            this.backupBrowse.Name = "backupBrowse";
            this.backupBrowse.Size = new System.Drawing.Size(80, 30);
            this.backupBrowse.TabIndex = 1;
            this.backupBrowse.Text = "Browse";
            this.backupBrowse.UseVisualStyleBackColor = true;
            this.backupBrowse.Click += new System.EventHandler(this.backupBrowse_Click);
            // 
            // backupPathText
            // 
            this.backupPathText.Location = new System.Drawing.Point(6, 33);
            this.backupPathText.Name = "backupPathText";
            this.backupPathText.ReadOnly = true;
            this.backupPathText.Size = new System.Drawing.Size(493, 25);
            this.backupPathText.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 5);
            this.panel2.TabIndex = 12;
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 341);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BackupForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupForm";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button restoreBrowse;
        private System.Windows.Forms.TextBox restorePathText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button backupBrowse;
        private System.Windows.Forms.TextBox backupPathText;
        private System.Windows.Forms.Button restoreBackupButton;
        private System.Windows.Forms.Button createBackupButton;
        private System.Windows.Forms.Panel panel2;
    }
}