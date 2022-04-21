namespace MedicosUI
{
    partial class UserForm
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
            this.labelUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addUserButton = new System.Windows.Forms.Button();
            this.confirmPasswordText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Gray;
            this.labelUser.Location = new System.Drawing.Point(113, 74);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(107, 30);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "New User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.addUserButton);
            this.panel2.Controls.Add(this.confirmPasswordText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.passwordText);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.usernameText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fullNameText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(118, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 431);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addUserButton.Location = new System.Drawing.Point(182, 335);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(123, 39);
            this.addUserButton.TabIndex = 9;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            // 
            // confirmPasswordText
            // 
            this.confirmPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordText.Location = new System.Drawing.Point(22, 268);
            this.confirmPasswordText.Name = "confirmPasswordText";
            this.confirmPasswordText.PasswordChar = '*';
            this.confirmPasswordText.Size = new System.Drawing.Size(284, 29);
            this.confirmPasswordText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // passwordText
            // 
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordText.Location = new System.Drawing.Point(22, 196);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(284, 29);
            this.passwordText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // usernameText
            // 
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameText.Location = new System.Drawing.Point(22, 124);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(284, 29);
            this.usernameText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // fullNameText
            // 
            this.fullNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameText.Location = new System.Drawing.Point(22, 52);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(284, 29);
            this.fullNameText.TabIndex = 2;
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
            this.label1.Text = "Full Name";
            // 
            // userGridView
            // 
            this.userGridView.BackgroundColor = System.Drawing.Color.White;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(597, 107);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(456, 431);
            this.userGridView.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(592, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Existing Users";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteUserButton.Location = new System.Drawing.Point(930, 558);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(123, 39);
            this.deleteUserButton.TabIndex = 10;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 665);
            this.ControlBox = false;
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUser);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPasswordText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteUserButton;
    }
}