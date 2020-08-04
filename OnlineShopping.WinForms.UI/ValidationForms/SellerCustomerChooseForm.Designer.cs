namespace OnlineShopping.WinForms.UI.ValidationForms
{
    partial class SellerCustomerChooseForm
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
            this.btnChooseCustomerLogin = new System.Windows.Forms.Button();
            this.btnChooseSellerLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseCustomerLogin
            // 
            this.btnChooseCustomerLogin.Location = new System.Drawing.Point(96, 127);
            this.btnChooseCustomerLogin.Name = "btnChooseCustomerLogin";
            this.btnChooseCustomerLogin.Size = new System.Drawing.Size(192, 79);
            this.btnChooseCustomerLogin.TabIndex = 0;
            this.btnChooseCustomerLogin.Text = "Customer";
            this.btnChooseCustomerLogin.UseVisualStyleBackColor = true;
            this.btnChooseCustomerLogin.Click += new System.EventHandler(this.btnChooseCustomerLogin_Click);
            // 
            // btnChooseSellerLogin
            // 
            this.btnChooseSellerLogin.Location = new System.Drawing.Point(96, 322);
            this.btnChooseSellerLogin.Name = "btnChooseSellerLogin";
            this.btnChooseSellerLogin.Size = new System.Drawing.Size(192, 79);
            this.btnChooseSellerLogin.TabIndex = 1;
            this.btnChooseSellerLogin.Text = "Seller";
            this.btnChooseSellerLogin.UseVisualStyleBackColor = true;
            this.btnChooseSellerLogin.Click += new System.EventHandler(this.btnChooseSellerLogin_Click);
            // 
            // SellerCustomerChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.btnChooseSellerLogin);
            this.Controls.Add(this.btnChooseCustomerLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellerCustomerChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerCustomerChooseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseCustomerLogin;
        private System.Windows.Forms.Button btnChooseSellerLogin;
    }
}