namespace OnlineShopping.WinForms.UI.OperationForms
{
    partial class SellerAddProductForm
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
            this.lblSellerAddProductName = new System.Windows.Forms.Label();
            this.lblSellerAddProductUnitPrice = new System.Windows.Forms.Label();
            this.lblSellerAddProductStockAmount = new System.Windows.Forms.Label();
            this.btnSellerAddProduct = new System.Windows.Forms.Button();
            this.tbxSellerAddProductName = new System.Windows.Forms.TextBox();
            this.tbxSellerAddProductUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxSellerAddProductStockAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSellerAddProductName
            // 
            this.lblSellerAddProductName.AutoSize = true;
            this.lblSellerAddProductName.Location = new System.Drawing.Point(128, 48);
            this.lblSellerAddProductName.Name = "lblSellerAddProductName";
            this.lblSellerAddProductName.Size = new System.Drawing.Size(102, 17);
            this.lblSellerAddProductName.TabIndex = 0;
            this.lblSellerAddProductName.Text = "Product Name:";
            // 
            // lblSellerAddProductUnitPrice
            // 
            this.lblSellerAddProductUnitPrice.AutoSize = true;
            this.lblSellerAddProductUnitPrice.Location = new System.Drawing.Point(128, 131);
            this.lblSellerAddProductUnitPrice.Name = "lblSellerAddProductUnitPrice";
            this.lblSellerAddProductUnitPrice.Size = new System.Drawing.Size(73, 17);
            this.lblSellerAddProductUnitPrice.TabIndex = 1;
            this.lblSellerAddProductUnitPrice.Text = "Unit Price:";
            // 
            // lblSellerAddProductStockAmount
            // 
            this.lblSellerAddProductStockAmount.AutoSize = true;
            this.lblSellerAddProductStockAmount.Location = new System.Drawing.Point(128, 214);
            this.lblSellerAddProductStockAmount.Name = "lblSellerAddProductStockAmount";
            this.lblSellerAddProductStockAmount.Size = new System.Drawing.Size(99, 17);
            this.lblSellerAddProductStockAmount.TabIndex = 2;
            this.lblSellerAddProductStockAmount.Text = "Stock Amount:";
            // 
            // btnSellerAddProduct
            // 
            this.btnSellerAddProduct.Location = new System.Drawing.Point(304, 321);
            this.btnSellerAddProduct.Name = "btnSellerAddProduct";
            this.btnSellerAddProduct.Size = new System.Drawing.Size(197, 65);
            this.btnSellerAddProduct.TabIndex = 4;
            this.btnSellerAddProduct.Text = "Add Product";
            this.btnSellerAddProduct.UseVisualStyleBackColor = true;
            this.btnSellerAddProduct.Click += new System.EventHandler(this.btnSellerAddProduct_Click);
            // 
            // tbxSellerAddProductName
            // 
            this.tbxSellerAddProductName.Location = new System.Drawing.Point(131, 89);
            this.tbxSellerAddProductName.Name = "tbxSellerAddProductName";
            this.tbxSellerAddProductName.Size = new System.Drawing.Size(540, 22);
            this.tbxSellerAddProductName.TabIndex = 5;
            // 
            // tbxSellerAddProductUnitPrice
            // 
            this.tbxSellerAddProductUnitPrice.Location = new System.Drawing.Point(131, 174);
            this.tbxSellerAddProductUnitPrice.Name = "tbxSellerAddProductUnitPrice";
            this.tbxSellerAddProductUnitPrice.Size = new System.Drawing.Size(540, 22);
            this.tbxSellerAddProductUnitPrice.TabIndex = 6;
            // 
            // tbxSellerAddProductStockAmount
            // 
            this.tbxSellerAddProductStockAmount.Location = new System.Drawing.Point(131, 261);
            this.tbxSellerAddProductStockAmount.Name = "tbxSellerAddProductStockAmount";
            this.tbxSellerAddProductStockAmount.Size = new System.Drawing.Size(540, 22);
            this.tbxSellerAddProductStockAmount.TabIndex = 7;
            // 
            // SellerAddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxSellerAddProductStockAmount);
            this.Controls.Add(this.tbxSellerAddProductUnitPrice);
            this.Controls.Add(this.tbxSellerAddProductName);
            this.Controls.Add(this.btnSellerAddProduct);
            this.Controls.Add(this.lblSellerAddProductStockAmount);
            this.Controls.Add(this.lblSellerAddProductUnitPrice);
            this.Controls.Add(this.lblSellerAddProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SellerAddProductForm";
            this.Text = "SellerAddProductForm";
            this.Load += new System.EventHandler(this.SellerAddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSellerAddProductName;
        private System.Windows.Forms.Label lblSellerAddProductUnitPrice;
        private System.Windows.Forms.Label lblSellerAddProductStockAmount;
        private System.Windows.Forms.Button btnSellerAddProduct;
        private System.Windows.Forms.TextBox tbxSellerAddProductName;
        private System.Windows.Forms.TextBox tbxSellerAddProductUnitPrice;
        private System.Windows.Forms.TextBox tbxSellerAddProductStockAmount;
    }
}