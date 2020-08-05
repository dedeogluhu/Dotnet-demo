namespace OnlineShopping.WinForms.UI.OperationForms
{
    partial class CustomerShopForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerShopCashDisplay = new System.Windows.Forms.Label();
            this.dgwCustomerShopProducts = new System.Windows.Forms.DataGridView();
            this.btnCustomerShopAddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomerShopProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cash:";
            // 
            // lblCustomerShopCashDisplay
            // 
            this.lblCustomerShopCashDisplay.AutoSize = true;
            this.lblCustomerShopCashDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerShopCashDisplay.Location = new System.Drawing.Point(733, 9);
            this.lblCustomerShopCashDisplay.Name = "lblCustomerShopCashDisplay";
            this.lblCustomerShopCashDisplay.Size = new System.Drawing.Size(23, 25);
            this.lblCustomerShopCashDisplay.TabIndex = 1;
            this.lblCustomerShopCashDisplay.Text = "0";
            this.lblCustomerShopCashDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwCustomerShopProducts
            // 
            this.dgwCustomerShopProducts.AllowUserToAddRows = false;
            this.dgwCustomerShopProducts.AllowUserToDeleteRows = false;
            this.dgwCustomerShopProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomerShopProducts.Location = new System.Drawing.Point(13, 13);
            this.dgwCustomerShopProducts.Name = "dgwCustomerShopProducts";
            this.dgwCustomerShopProducts.ReadOnly = true;
            this.dgwCustomerShopProducts.RowHeadersWidth = 51;
            this.dgwCustomerShopProducts.RowTemplate.Height = 24;
            this.dgwCustomerShopProducts.Size = new System.Drawing.Size(625, 425);
            this.dgwCustomerShopProducts.TabIndex = 2;
            // 
            // btnCustomerShopAddToCart
            // 
            this.btnCustomerShopAddToCart.Location = new System.Drawing.Point(647, 123);
            this.btnCustomerShopAddToCart.Name = "btnCustomerShopAddToCart";
            this.btnCustomerShopAddToCart.Size = new System.Drawing.Size(141, 224);
            this.btnCustomerShopAddToCart.TabIndex = 3;
            this.btnCustomerShopAddToCart.Text = "Add to Cart";
            this.btnCustomerShopAddToCart.UseVisualStyleBackColor = true;
            this.btnCustomerShopAddToCart.Click += new System.EventHandler(this.btnCustomerShopAddToCart_Click);
            // 
            // CustomerShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomerShopAddToCart);
            this.Controls.Add(this.dgwCustomerShopProducts);
            this.Controls.Add(this.lblCustomerShopCashDisplay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CustomerShopForm";
            this.Text = "CustomerShopForm";
            this.Load += new System.EventHandler(this.CustomerShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomerShopProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerShopCashDisplay;
        private System.Windows.Forms.DataGridView dgwCustomerShopProducts;
        private System.Windows.Forms.Button btnCustomerShopAddToCart;
    }
}