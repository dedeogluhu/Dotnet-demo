namespace OnlineShopping.WinForms.UI.OperationForms
{
    partial class CustomerShoppingCartForm
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
            this.lblCustomerCartCash = new System.Windows.Forms.Label();
            this.lblCustomerCartCashDisplay = new System.Windows.Forms.Label();
            this.dgwCustomerShoppingCart = new System.Windows.Forms.DataGridView();
            this.btnCustomerCartBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomerShoppingCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerCartCash
            // 
            this.lblCustomerCartCash.AutoSize = true;
            this.lblCustomerCartCash.Location = new System.Drawing.Point(637, 9);
            this.lblCustomerCartCash.Name = "lblCustomerCartCash";
            this.lblCustomerCartCash.Size = new System.Drawing.Size(44, 17);
            this.lblCustomerCartCash.TabIndex = 0;
            this.lblCustomerCartCash.Text = "Cash:";
            // 
            // lblCustomerCartCashDisplay
            // 
            this.lblCustomerCartCashDisplay.AutoSize = true;
            this.lblCustomerCartCashDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerCartCashDisplay.Location = new System.Drawing.Point(728, 9);
            this.lblCustomerCartCashDisplay.Name = "lblCustomerCartCashDisplay";
            this.lblCustomerCartCashDisplay.Size = new System.Drawing.Size(23, 25);
            this.lblCustomerCartCashDisplay.TabIndex = 1;
            this.lblCustomerCartCashDisplay.Text = "0";
            this.lblCustomerCartCashDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwCustomerShoppingCart
            // 
            this.dgwCustomerShoppingCart.AllowUserToAddRows = false;
            this.dgwCustomerShoppingCart.AllowUserToDeleteRows = false;
            this.dgwCustomerShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomerShoppingCart.Location = new System.Drawing.Point(13, 49);
            this.dgwCustomerShoppingCart.Name = "dgwCustomerShoppingCart";
            this.dgwCustomerShoppingCart.ReadOnly = true;
            this.dgwCustomerShoppingCart.RowHeadersWidth = 51;
            this.dgwCustomerShoppingCart.RowTemplate.Height = 24;
            this.dgwCustomerShoppingCart.Size = new System.Drawing.Size(775, 312);
            this.dgwCustomerShoppingCart.TabIndex = 2;
            // 
            // btnCustomerCartBuy
            // 
            this.btnCustomerCartBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerCartBuy.Location = new System.Drawing.Point(592, 367);
            this.btnCustomerCartBuy.Name = "btnCustomerCartBuy";
            this.btnCustomerCartBuy.Size = new System.Drawing.Size(196, 71);
            this.btnCustomerCartBuy.TabIndex = 3;
            this.btnCustomerCartBuy.Text = "Buy";
            this.btnCustomerCartBuy.UseVisualStyleBackColor = true;
            this.btnCustomerCartBuy.Click += new System.EventHandler(this.btnCustomerCartBuy_Click);
            // 
            // CustomerShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomerCartBuy);
            this.Controls.Add(this.dgwCustomerShoppingCart);
            this.Controls.Add(this.lblCustomerCartCashDisplay);
            this.Controls.Add(this.lblCustomerCartCash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CustomerShoppingCartForm";
            this.Text = "CustomerShoppingCartForm";
            this.Load += new System.EventHandler(this.CustomerShoppingCartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomerShoppingCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerCartCash;
        private System.Windows.Forms.Label lblCustomerCartCashDisplay;
        private System.Windows.Forms.DataGridView dgwCustomerShoppingCart;
        private System.Windows.Forms.Button btnCustomerCartBuy;
    }
}