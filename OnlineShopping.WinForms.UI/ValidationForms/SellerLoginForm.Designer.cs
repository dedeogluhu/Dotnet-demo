namespace OnlineShopping.WinForms.UI.ValidationForms
{
    partial class SellerLoginForm
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
            this.lblSellerLoginToSignup = new System.Windows.Forms.Label();
            this.btnSellerLoginToSignup = new System.Windows.Forms.Button();
            this.tbxSellerLoginId = new System.Windows.Forms.TextBox();
            this.tbxSellerLoginPassword = new System.Windows.Forms.TextBox();
            this.lblSellerLoginId = new System.Windows.Forms.Label();
            this.lblSellerLoginPassword = new System.Windows.Forms.Label();
            this.btnSellerLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSellerLoginToSignup
            // 
            this.lblSellerLoginToSignup.AutoSize = true;
            this.lblSellerLoginToSignup.Location = new System.Drawing.Point(13, 13);
            this.lblSellerLoginToSignup.Name = "lblSellerLoginToSignup";
            this.lblSellerLoginToSignup.Size = new System.Drawing.Size(185, 17);
            this.lblSellerLoginToSignup.TabIndex = 0;
            this.lblSellerLoginToSignup.Text = "You don\'t have an account?";
            // 
            // btnSellerLoginToSignup
            // 
            this.btnSellerLoginToSignup.Location = new System.Drawing.Point(260, 13);
            this.btnSellerLoginToSignup.Name = "btnSellerLoginToSignup";
            this.btnSellerLoginToSignup.Size = new System.Drawing.Size(110, 31);
            this.btnSellerLoginToSignup.TabIndex = 1;
            this.btnSellerLoginToSignup.Text = "Signup";
            this.btnSellerLoginToSignup.UseVisualStyleBackColor = true;
            this.btnSellerLoginToSignup.Click += new System.EventHandler(this.btnSellerLoginToSignup_Click);
            // 
            // tbxSellerLoginId
            // 
            this.tbxSellerLoginId.Location = new System.Drawing.Point(58, 168);
            this.tbxSellerLoginId.Name = "tbxSellerLoginId";
            this.tbxSellerLoginId.Size = new System.Drawing.Size(265, 22);
            this.tbxSellerLoginId.TabIndex = 2;
            // 
            // tbxSellerLoginPassword
            // 
            this.tbxSellerLoginPassword.Location = new System.Drawing.Point(58, 326);
            this.tbxSellerLoginPassword.Name = "tbxSellerLoginPassword";
            this.tbxSellerLoginPassword.Size = new System.Drawing.Size(265, 22);
            this.tbxSellerLoginPassword.TabIndex = 3;
            // 
            // lblSellerLoginId
            // 
            this.lblSellerLoginId.AutoSize = true;
            this.lblSellerLoginId.Location = new System.Drawing.Point(58, 122);
            this.lblSellerLoginId.Name = "lblSellerLoginId";
            this.lblSellerLoginId.Size = new System.Drawing.Size(25, 17);
            this.lblSellerLoginId.TabIndex = 4;
            this.lblSellerLoginId.Text = "ID:";
            // 
            // lblSellerLoginPassword
            // 
            this.lblSellerLoginPassword.AutoSize = true;
            this.lblSellerLoginPassword.Location = new System.Drawing.Point(58, 279);
            this.lblSellerLoginPassword.Name = "lblSellerLoginPassword";
            this.lblSellerLoginPassword.Size = new System.Drawing.Size(73, 17);
            this.lblSellerLoginPassword.TabIndex = 5;
            this.lblSellerLoginPassword.Text = "Password:";
            // 
            // btnSellerLogin
            // 
            this.btnSellerLogin.Location = new System.Drawing.Point(115, 413);
            this.btnSellerLogin.Name = "btnSellerLogin";
            this.btnSellerLogin.Size = new System.Drawing.Size(136, 48);
            this.btnSellerLogin.TabIndex = 6;
            this.btnSellerLogin.Text = "Login";
            this.btnSellerLogin.UseVisualStyleBackColor = true;
            // 
            // SellerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.btnSellerLogin);
            this.Controls.Add(this.lblSellerLoginPassword);
            this.Controls.Add(this.lblSellerLoginId);
            this.Controls.Add(this.tbxSellerLoginPassword);
            this.Controls.Add(this.tbxSellerLoginId);
            this.Controls.Add(this.btnSellerLoginToSignup);
            this.Controls.Add(this.lblSellerLoginToSignup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SellerLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSellerLoginToSignup;
        private System.Windows.Forms.Button btnSellerLoginToSignup;
        private System.Windows.Forms.TextBox tbxSellerLoginId;
        private System.Windows.Forms.TextBox tbxSellerLoginPassword;
        private System.Windows.Forms.Label lblSellerLoginId;
        private System.Windows.Forms.Label lblSellerLoginPassword;
        private System.Windows.Forms.Button btnSellerLogin;
    }
}