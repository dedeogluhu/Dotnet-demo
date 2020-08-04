namespace OnlineShopping.WinForms.UI.ValidationForms
{
    partial class CustomerLoginForm
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
            this.lblCustomerLoginId = new System.Windows.Forms.Label();
            this.tbxCustomerLoginId = new System.Windows.Forms.TextBox();
            this.lblCustomerLoginPassword = new System.Windows.Forms.Label();
            this.tbxCustomerLoginPassword = new System.Windows.Forms.TextBox();
            this.btnCustomerLoginToSignup = new System.Windows.Forms.Button();
            this.lblCustomerLoginToSignup = new System.Windows.Forms.Label();
            this.btnCustomerLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerLoginId
            // 
            this.lblCustomerLoginId.AutoSize = true;
            this.lblCustomerLoginId.Location = new System.Drawing.Point(52, 125);
            this.lblCustomerLoginId.Name = "lblCustomerLoginId";
            this.lblCustomerLoginId.Size = new System.Drawing.Size(25, 17);
            this.lblCustomerLoginId.TabIndex = 0;
            this.lblCustomerLoginId.Text = "ID:";
            // 
            // tbxCustomerLoginId
            // 
            this.tbxCustomerLoginId.Location = new System.Drawing.Point(55, 172);
            this.tbxCustomerLoginId.Name = "tbxCustomerLoginId";
            this.tbxCustomerLoginId.Size = new System.Drawing.Size(264, 22);
            this.tbxCustomerLoginId.TabIndex = 1;
            // 
            // lblCustomerLoginPassword
            // 
            this.lblCustomerLoginPassword.AutoSize = true;
            this.lblCustomerLoginPassword.Location = new System.Drawing.Point(52, 278);
            this.lblCustomerLoginPassword.Name = "lblCustomerLoginPassword";
            this.lblCustomerLoginPassword.Size = new System.Drawing.Size(73, 17);
            this.lblCustomerLoginPassword.TabIndex = 2;
            this.lblCustomerLoginPassword.Text = "Password:";
            // 
            // tbxCustomerLoginPassword
            // 
            this.tbxCustomerLoginPassword.Location = new System.Drawing.Point(55, 330);
            this.tbxCustomerLoginPassword.Name = "tbxCustomerLoginPassword";
            this.tbxCustomerLoginPassword.Size = new System.Drawing.Size(264, 22);
            this.tbxCustomerLoginPassword.TabIndex = 3;
            // 
            // btnCustomerLoginToSignup
            // 
            this.btnCustomerLoginToSignup.Location = new System.Drawing.Point(265, 13);
            this.btnCustomerLoginToSignup.Name = "btnCustomerLoginToSignup";
            this.btnCustomerLoginToSignup.Size = new System.Drawing.Size(105, 27);
            this.btnCustomerLoginToSignup.TabIndex = 4;
            this.btnCustomerLoginToSignup.Text = "Signup";
            this.btnCustomerLoginToSignup.UseVisualStyleBackColor = true;
            this.btnCustomerLoginToSignup.Click += new System.EventHandler(this.btnCustomerLoginToSignup_Click);
            // 
            // lblCustomerLoginToSignup
            // 
            this.lblCustomerLoginToSignup.AutoSize = true;
            this.lblCustomerLoginToSignup.Location = new System.Drawing.Point(13, 13);
            this.lblCustomerLoginToSignup.Name = "lblCustomerLoginToSignup";
            this.lblCustomerLoginToSignup.Size = new System.Drawing.Size(185, 17);
            this.lblCustomerLoginToSignup.TabIndex = 5;
            this.lblCustomerLoginToSignup.Text = "You don\'t have an account?";
            // 
            // btnCustomerLogin
            // 
            this.btnCustomerLogin.Location = new System.Drawing.Point(124, 413);
            this.btnCustomerLogin.Name = "btnCustomerLogin";
            this.btnCustomerLogin.Size = new System.Drawing.Size(123, 49);
            this.btnCustomerLogin.TabIndex = 6;
            this.btnCustomerLogin.Text = "Login";
            this.btnCustomerLogin.UseVisualStyleBackColor = true;
            // 
            // CustomerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.btnCustomerLogin);
            this.Controls.Add(this.lblCustomerLoginToSignup);
            this.Controls.Add(this.btnCustomerLoginToSignup);
            this.Controls.Add(this.tbxCustomerLoginPassword);
            this.Controls.Add(this.lblCustomerLoginPassword);
            this.Controls.Add(this.tbxCustomerLoginId);
            this.Controls.Add(this.lblCustomerLoginId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerLoginId;
        private System.Windows.Forms.TextBox tbxCustomerLoginId;
        private System.Windows.Forms.Label lblCustomerLoginPassword;
        private System.Windows.Forms.TextBox tbxCustomerLoginPassword;
        private System.Windows.Forms.Button btnCustomerLoginToSignup;
        private System.Windows.Forms.Label lblCustomerLoginToSignup;
        private System.Windows.Forms.Button btnCustomerLogin;
    }
}