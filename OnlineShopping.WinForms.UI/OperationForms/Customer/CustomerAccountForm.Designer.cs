namespace OnlineShopping.WinForms.UI.OperationForms
{
    partial class CustomerAccountForm
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
            this.gbxUpdateInfo = new System.Windows.Forms.GroupBox();
            this.tbxUpdateCustomerFirstName = new System.Windows.Forms.TextBox();
            this.tbxUpdateCustomerLastName = new System.Windows.Forms.TextBox();
            this.tbxUpdateCustomerId = new System.Windows.Forms.TextBox();
            this.tbxUpdateCustomerPassword = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.lblUpdateCustomerPassword = new System.Windows.Forms.Label();
            this.lblUpdateCustomerId = new System.Windows.Forms.Label();
            this.lblUpdateCustomerLastName = new System.Windows.Forms.Label();
            this.lblUpdateCustomerFirstName = new System.Windows.Forms.Label();
            this.gbxDepositCash = new System.Windows.Forms.GroupBox();
            this.btnCustomerDepositCash = new System.Windows.Forms.Button();
            this.tbxCustomerDepositCash = new System.Windows.Forms.TextBox();
            this.gbxCustomerAccountCashDisplay = new System.Windows.Forms.GroupBox();
            this.lblCustomerAccountCashDisplay = new System.Windows.Forms.Label();
            this.gbxUpdateInfo.SuspendLayout();
            this.gbxDepositCash.SuspendLayout();
            this.gbxCustomerAccountCashDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUpdateInfo
            // 
            this.gbxUpdateInfo.Controls.Add(this.tbxUpdateCustomerFirstName);
            this.gbxUpdateInfo.Controls.Add(this.tbxUpdateCustomerLastName);
            this.gbxUpdateInfo.Controls.Add(this.tbxUpdateCustomerId);
            this.gbxUpdateInfo.Controls.Add(this.tbxUpdateCustomerPassword);
            this.gbxUpdateInfo.Controls.Add(this.btnUpdateCustomer);
            this.gbxUpdateInfo.Controls.Add(this.lblUpdateCustomerPassword);
            this.gbxUpdateInfo.Controls.Add(this.lblUpdateCustomerId);
            this.gbxUpdateInfo.Controls.Add(this.lblUpdateCustomerLastName);
            this.gbxUpdateInfo.Controls.Add(this.lblUpdateCustomerFirstName);
            this.gbxUpdateInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxUpdateInfo.Name = "gbxUpdateInfo";
            this.gbxUpdateInfo.Size = new System.Drawing.Size(531, 426);
            this.gbxUpdateInfo.TabIndex = 0;
            this.gbxUpdateInfo.TabStop = false;
            this.gbxUpdateInfo.Text = "Update Account";
            // 
            // tbxUpdateCustomerFirstName
            // 
            this.tbxUpdateCustomerFirstName.Location = new System.Drawing.Point(42, 65);
            this.tbxUpdateCustomerFirstName.Name = "tbxUpdateCustomerFirstName";
            this.tbxUpdateCustomerFirstName.Size = new System.Drawing.Size(426, 22);
            this.tbxUpdateCustomerFirstName.TabIndex = 9;
            // 
            // tbxUpdateCustomerLastName
            // 
            this.tbxUpdateCustomerLastName.Location = new System.Drawing.Point(42, 132);
            this.tbxUpdateCustomerLastName.Name = "tbxUpdateCustomerLastName";
            this.tbxUpdateCustomerLastName.Size = new System.Drawing.Size(426, 22);
            this.tbxUpdateCustomerLastName.TabIndex = 8;
            // 
            // tbxUpdateCustomerId
            // 
            this.tbxUpdateCustomerId.Location = new System.Drawing.Point(42, 199);
            this.tbxUpdateCustomerId.Name = "tbxUpdateCustomerId";
            this.tbxUpdateCustomerId.Size = new System.Drawing.Size(426, 22);
            this.tbxUpdateCustomerId.TabIndex = 7;
            // 
            // tbxUpdateCustomerPassword
            // 
            this.tbxUpdateCustomerPassword.Location = new System.Drawing.Point(42, 266);
            this.tbxUpdateCustomerPassword.Name = "tbxUpdateCustomerPassword";
            this.tbxUpdateCustomerPassword.Size = new System.Drawing.Size(426, 22);
            this.tbxUpdateCustomerPassword.TabIndex = 6;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(181, 333);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(159, 50);
            this.btnUpdateCustomer.TabIndex = 5;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // lblUpdateCustomerPassword
            // 
            this.lblUpdateCustomerPassword.AutoSize = true;
            this.lblUpdateCustomerPassword.Location = new System.Drawing.Point(42, 235);
            this.lblUpdateCustomerPassword.Name = "lblUpdateCustomerPassword";
            this.lblUpdateCustomerPassword.Size = new System.Drawing.Size(73, 17);
            this.lblUpdateCustomerPassword.TabIndex = 3;
            this.lblUpdateCustomerPassword.Text = "Password:";
            // 
            // lblUpdateCustomerId
            // 
            this.lblUpdateCustomerId.AutoSize = true;
            this.lblUpdateCustomerId.Location = new System.Drawing.Point(42, 168);
            this.lblUpdateCustomerId.Name = "lblUpdateCustomerId";
            this.lblUpdateCustomerId.Size = new System.Drawing.Size(25, 17);
            this.lblUpdateCustomerId.TabIndex = 2;
            this.lblUpdateCustomerId.Text = "ID:";
            // 
            // lblUpdateCustomerLastName
            // 
            this.lblUpdateCustomerLastName.AutoSize = true;
            this.lblUpdateCustomerLastName.Location = new System.Drawing.Point(42, 101);
            this.lblUpdateCustomerLastName.Name = "lblUpdateCustomerLastName";
            this.lblUpdateCustomerLastName.Size = new System.Drawing.Size(80, 17);
            this.lblUpdateCustomerLastName.TabIndex = 1;
            this.lblUpdateCustomerLastName.Text = "Last Name:";
            // 
            // lblUpdateCustomerFirstName
            // 
            this.lblUpdateCustomerFirstName.AutoSize = true;
            this.lblUpdateCustomerFirstName.Location = new System.Drawing.Point(42, 34);
            this.lblUpdateCustomerFirstName.Name = "lblUpdateCustomerFirstName";
            this.lblUpdateCustomerFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblUpdateCustomerFirstName.TabIndex = 0;
            this.lblUpdateCustomerFirstName.Text = "First Name:";
            // 
            // gbxDepositCash
            // 
            this.gbxDepositCash.Controls.Add(this.btnCustomerDepositCash);
            this.gbxDepositCash.Controls.Add(this.tbxCustomerDepositCash);
            this.gbxDepositCash.Location = new System.Drawing.Point(550, 13);
            this.gbxDepositCash.Name = "gbxDepositCash";
            this.gbxDepositCash.Size = new System.Drawing.Size(238, 153);
            this.gbxDepositCash.TabIndex = 1;
            this.gbxDepositCash.TabStop = false;
            this.gbxDepositCash.Text = "Deposit Cash";
            // 
            // btnCustomerDepositCash
            // 
            this.btnCustomerDepositCash.Location = new System.Drawing.Point(72, 91);
            this.btnCustomerDepositCash.Name = "btnCustomerDepositCash";
            this.btnCustomerDepositCash.Size = new System.Drawing.Size(105, 40);
            this.btnCustomerDepositCash.TabIndex = 1;
            this.btnCustomerDepositCash.Text = "Deposit";
            this.btnCustomerDepositCash.UseVisualStyleBackColor = true;
            this.btnCustomerDepositCash.Click += new System.EventHandler(this.btnCustomerDepositCash_Click);
            // 
            // tbxCustomerDepositCash
            // 
            this.tbxCustomerDepositCash.Location = new System.Drawing.Point(6, 43);
            this.tbxCustomerDepositCash.Name = "tbxCustomerDepositCash";
            this.tbxCustomerDepositCash.Size = new System.Drawing.Size(226, 22);
            this.tbxCustomerDepositCash.TabIndex = 0;
            // 
            // gbxCustomerAccountCashDisplay
            // 
            this.gbxCustomerAccountCashDisplay.Controls.Add(this.lblCustomerAccountCashDisplay);
            this.gbxCustomerAccountCashDisplay.Location = new System.Drawing.Point(550, 172);
            this.gbxCustomerAccountCashDisplay.Name = "gbxCustomerAccountCashDisplay";
            this.gbxCustomerAccountCashDisplay.Size = new System.Drawing.Size(238, 265);
            this.gbxCustomerAccountCashDisplay.TabIndex = 2;
            this.gbxCustomerAccountCashDisplay.TabStop = false;
            this.gbxCustomerAccountCashDisplay.Text = "Cash";
            // 
            // lblCustomerAccountCashDisplay
            // 
            this.lblCustomerAccountCashDisplay.AutoSize = true;
            this.lblCustomerAccountCashDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerAccountCashDisplay.Location = new System.Drawing.Point(36, 75);
            this.lblCustomerAccountCashDisplay.Name = "lblCustomerAccountCashDisplay";
            this.lblCustomerAccountCashDisplay.Size = new System.Drawing.Size(63, 69);
            this.lblCustomerAccountCashDisplay.TabIndex = 1;
            this.lblCustomerAccountCashDisplay.Text = "0";
            this.lblCustomerAccountCashDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxCustomerAccountCashDisplay);
            this.Controls.Add(this.gbxDepositCash);
            this.Controls.Add(this.gbxUpdateInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CustomerAccountForm";
            this.Text = "CustomerAccountForm";
            this.Load += new System.EventHandler(this.CustomerAccountForm_Load);
            this.gbxUpdateInfo.ResumeLayout(false);
            this.gbxUpdateInfo.PerformLayout();
            this.gbxDepositCash.ResumeLayout(false);
            this.gbxDepositCash.PerformLayout();
            this.gbxCustomerAccountCashDisplay.ResumeLayout(false);
            this.gbxCustomerAccountCashDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUpdateInfo;
        private System.Windows.Forms.GroupBox gbxDepositCash;
        private System.Windows.Forms.Label lblUpdateCustomerPassword;
        private System.Windows.Forms.Label lblUpdateCustomerId;
        private System.Windows.Forms.Label lblUpdateCustomerLastName;
        private System.Windows.Forms.Label lblUpdateCustomerFirstName;
        private System.Windows.Forms.TextBox tbxUpdateCustomerFirstName;
        private System.Windows.Forms.TextBox tbxUpdateCustomerLastName;
        private System.Windows.Forms.TextBox tbxUpdateCustomerId;
        private System.Windows.Forms.TextBox tbxUpdateCustomerPassword;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnCustomerDepositCash;
        private System.Windows.Forms.TextBox tbxCustomerDepositCash;
        private System.Windows.Forms.GroupBox gbxCustomerAccountCashDisplay;
        private System.Windows.Forms.Label lblCustomerAccountCashDisplay;
    }
}