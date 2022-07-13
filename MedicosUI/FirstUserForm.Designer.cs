namespace MedicosUI
{
    partial class FirstUserForm
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
            this.confirmPasswordError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.fullNameError = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.confirmPasswordText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.confirmPasswordError);
            this.panel2.Controls.Add(this.passwordError);
            this.panel2.Controls.Add(this.usernameError);
            this.panel2.Controls.Add(this.fullNameError);
            this.panel2.Controls.Add(this.addUserButton);
            this.panel2.Controls.Add(this.confirmPasswordText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.passwordText);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.usernameText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fullNameText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(60, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 431);
            this.panel2.TabIndex = 3;
            // 
            // confirmPasswordError
            // 
            this.confirmPasswordError.AutoSize = true;
            this.confirmPasswordError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordError.ForeColor = System.Drawing.Color.Red;
            this.confirmPasswordError.Location = new System.Drawing.Point(23, 316);
            this.confirmPasswordError.Name = "confirmPasswordError";
            this.confirmPasswordError.Size = new System.Drawing.Size(0, 17);
            this.confirmPasswordError.TabIndex = 13;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(24, 244);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(0, 17);
            this.passwordError.TabIndex = 12;
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameError.ForeColor = System.Drawing.Color.Red;
            this.usernameError.Location = new System.Drawing.Point(28, 173);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(0, 17);
            this.usernameError.TabIndex = 11;
            // 
            // fullNameError
            // 
            this.fullNameError.AutoSize = true;
            this.fullNameError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameError.ForeColor = System.Drawing.Color.Red;
            this.fullNameError.Location = new System.Drawing.Point(26, 97);
            this.fullNameError.Name = "fullNameError";
            this.fullNameError.Size = new System.Drawing.Size(0, 17);
            this.fullNameError.TabIndex = 10;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addUserButton.Location = new System.Drawing.Point(90, 348);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(123, 39);
            this.addUserButton.TabIndex = 5;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // confirmPasswordText
            // 
            this.confirmPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordText.Location = new System.Drawing.Point(22, 285);
            this.confirmPasswordText.Name = "confirmPasswordText";
            this.confirmPasswordText.PasswordChar = '*';
            this.confirmPasswordText.Size = new System.Drawing.Size(284, 29);
            this.confirmPasswordText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // passwordText
            // 
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordText.Location = new System.Drawing.Point(22, 213);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(284, 29);
            this.passwordText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // usernameText
            // 
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameText.Location = new System.Drawing.Point(22, 140);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(284, 29);
            this.usernameText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // fullNameText
            // 
            this.fullNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameText.Location = new System.Drawing.Point(22, 65);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(284, 29);
            this.fullNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // FirstUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 464);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FirstUserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Admin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FirstUserForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label confirmPasswordError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Label fullNameError;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox confirmPasswordText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameText;
        private System.Windows.Forms.Label label1;
    }
}