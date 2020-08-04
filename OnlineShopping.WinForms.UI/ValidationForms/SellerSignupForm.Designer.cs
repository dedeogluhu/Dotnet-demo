namespace OnlineShopping.WinForms.UI.ValidationForms
{
    partial class SellerSignupForm
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
            this.lblSellerSignupToLogin = new System.Windows.Forms.Label();
            this.btnSellerSignupToLogin = new System.Windows.Forms.Button();
            this.lblSellerSignupId = new System.Windows.Forms.Label();
            this.lblSellerSignupPassword = new System.Windows.Forms.Label();
            this.lblSellerSignupCompanyName = new System.Windows.Forms.Label();
            this.tbxSellerSignupId = new System.Windows.Forms.TextBox();
            this.tbxSellerSignupPassword = new System.Windows.Forms.TextBox();
            this.tbxSellerSignupCompanyName = new System.Windows.Forms.TextBox();
            this.btnSellerSignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSellerSignupToLogin
            // 
            this.lblSellerSignupToLogin.AutoSize = true;
            this.lblSellerSignupToLogin.Location = new System.Drawing.Point(13, 13);
            this.lblSellerSignupToLogin.Name = "lblSellerSignupToLogin";
            this.lblSellerSignupToLogin.Size = new System.Drawing.Size(201, 17);
            this.lblSellerSignupToLogin.TabIndex = 0;
            this.lblSellerSignupToLogin.Text = "You already have an account?";
            // 
            // btnSellerSignupToLogin
            // 
            this.btnSellerSignupToLogin.Location = new System.Drawing.Point(255, 2);
            this.btnSellerSignupToLogin.Name = "btnSellerSignupToLogin";
            this.btnSellerSignupToLogin.Size = new System.Drawing.Size(125, 39);
            this.btnSellerSignupToLogin.TabIndex = 1;
            this.btnSellerSignupToLogin.Text = "Login";
            this.btnSellerSignupToLogin.UseVisualStyleBackColor = true;
            this.btnSellerSignupToLogin.Click += new System.EventHandler(this.btnSellerSignupToLogin_Click);
            // 
            // lblSellerSignupId
            // 
            this.lblSellerSignupId.AutoSize = true;
            this.lblSellerSignupId.Location = new System.Drawing.Point(44, 124);
            this.lblSellerSignupId.Name = "lblSellerSignupId";
            this.lblSellerSignupId.Size = new System.Drawing.Size(25, 17);
            this.lblSellerSignupId.TabIndex = 2;
            this.lblSellerSignupId.Text = "ID:";
            // 
            // lblSellerSignupPassword
            // 
            this.lblSellerSignupPassword.AutoSize = true;
            this.lblSellerSignupPassword.Location = new System.Drawing.Point(47, 230);
            this.lblSellerSignupPassword.Name = "lblSellerSignupPassword";
            this.lblSellerSignupPassword.Size = new System.Drawing.Size(73, 17);
            this.lblSellerSignupPassword.TabIndex = 3;
            this.lblSellerSignupPassword.Text = "Password:";
            // 
            // lblSellerSignupCompanyName
            // 
            this.lblSellerSignupCompanyName.AutoSize = true;
            this.lblSellerSignupCompanyName.Location = new System.Drawing.Point(50, 336);
            this.lblSellerSignupCompanyName.Name = "lblSellerSignupCompanyName";
            this.lblSellerSignupCompanyName.Size = new System.Drawing.Size(112, 17);
            this.lblSellerSignupCompanyName.TabIndex = 4;
            this.lblSellerSignupCompanyName.Text = "Company Name:";
            // 
            // tbxSellerSignupId
            // 
            this.tbxSellerSignupId.Location = new System.Drawing.Point(47, 156);
            this.tbxSellerSignupId.Name = "tbxSellerSignupId";
            this.tbxSellerSignupId.Size = new System.Drawing.Size(293, 22);
            this.tbxSellerSignupId.TabIndex = 5;
            // 
            // tbxSellerSignupPassword
            // 
            this.tbxSellerSignupPassword.Location = new System.Drawing.Point(47, 264);
            this.tbxSellerSignupPassword.Name = "tbxSellerSignupPassword";
            this.tbxSellerSignupPassword.Size = new System.Drawing.Size(293, 22);
            this.tbxSellerSignupPassword.TabIndex = 6;
            // 
            // tbxSellerSignupCompanyName
            // 
            this.tbxSellerSignupCompanyName.Location = new System.Drawing.Point(50, 372);
            this.tbxSellerSignupCompanyName.Name = "tbxSellerSignupCompanyName";
            this.tbxSellerSignupCompanyName.Size = new System.Drawing.Size(293, 22);
            this.tbxSellerSignupCompanyName.TabIndex = 7;
            // 
            // btnSellerSignup
            // 
            this.btnSellerSignup.Location = new System.Drawing.Point(118, 440);
            this.btnSellerSignup.Name = "btnSellerSignup";
            this.btnSellerSignup.Size = new System.Drawing.Size(144, 54);
            this.btnSellerSignup.TabIndex = 8;
            this.btnSellerSignup.Text = "Signup";
            this.btnSellerSignup.UseVisualStyleBackColor = true;
            // 
            // SellerSignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.btnSellerSignup);
            this.Controls.Add(this.tbxSellerSignupCompanyName);
            this.Controls.Add(this.tbxSellerSignupPassword);
            this.Controls.Add(this.tbxSellerSignupId);
            this.Controls.Add(this.lblSellerSignupCompanyName);
            this.Controls.Add(this.lblSellerSignupPassword);
            this.Controls.Add(this.lblSellerSignupId);
            this.Controls.Add(this.btnSellerSignupToLogin);
            this.Controls.Add(this.lblSellerSignupToLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SellerSignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerSignupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSellerSignupToLogin;
        private System.Windows.Forms.Button btnSellerSignupToLogin;
        private System.Windows.Forms.Label lblSellerSignupId;
        private System.Windows.Forms.Label lblSellerSignupPassword;
        private System.Windows.Forms.Label lblSellerSignupCompanyName;
        private System.Windows.Forms.TextBox tbxSellerSignupId;
        private System.Windows.Forms.TextBox tbxSellerSignupPassword;
        private System.Windows.Forms.TextBox tbxSellerSignupCompanyName;
        private System.Windows.Forms.Button btnSellerSignup;
    }
}