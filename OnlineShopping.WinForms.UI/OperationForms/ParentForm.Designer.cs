namespace OnlineShopping.WinForms.UI
{
    partial class ParentForm
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
            this.mspParentForm = new System.Windows.Forms.MenuStrip();
            this.tspCustomerShop = new System.Windows.Forms.ToolStripMenuItem();
            this.tspCustomerShoppingCart = new System.Windows.Forms.ToolStripMenuItem();
            this.tspCustomerAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspSellerParentForm = new System.Windows.Forms.MenuStrip();
            this.tspSellerProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSellerAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSellerAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mspParentForm.SuspendLayout();
            this.mspSellerParentForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspParentForm
            // 
            this.mspParentForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.mspParentForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspParentForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspCustomerShop,
            this.tspCustomerShoppingCart,
            this.tspCustomerAccount,
            this.logoutToolStripMenuItem});
            this.mspParentForm.Location = new System.Drawing.Point(0, 0);
            this.mspParentForm.Name = "mspParentForm";
            this.mspParentForm.Size = new System.Drawing.Size(124, 722);
            this.mspParentForm.TabIndex = 1;
            this.mspParentForm.Text = "menuStrip1";
            // 
            // tspCustomerShop
            // 
            this.tspCustomerShop.Name = "tspCustomerShop";
            this.tspCustomerShop.Size = new System.Drawing.Size(111, 24);
            this.tspCustomerShop.Text = "Shop";
            this.tspCustomerShop.Click += new System.EventHandler(this.tspCustomerShop_Click);
            // 
            // tspCustomerShoppingCart
            // 
            this.tspCustomerShoppingCart.Name = "tspCustomerShoppingCart";
            this.tspCustomerShoppingCart.Size = new System.Drawing.Size(111, 24);
            this.tspCustomerShoppingCart.Text = "Shopping Cart";
            this.tspCustomerShoppingCart.Click += new System.EventHandler(this.tspCustomerShoppingCart_Click);
            // 
            // tspCustomerAccount
            // 
            this.tspCustomerAccount.Name = "tspCustomerAccount";
            this.tspCustomerAccount.Size = new System.Drawing.Size(111, 24);
            this.tspCustomerAccount.Text = "My Account";
            this.tspCustomerAccount.Click += new System.EventHandler(this.tspCustomerAccount_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // mspSellerParentForm
            // 
            this.mspSellerParentForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.mspSellerParentForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspSellerParentForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspSellerProducts,
            this.tspSellerAddProduct,
            this.tspSellerAccount,
            this.logoutToolStripMenuItem1});
            this.mspSellerParentForm.Location = new System.Drawing.Point(1274, 0);
            this.mspSellerParentForm.Name = "mspSellerParentForm";
            this.mspSellerParentForm.Size = new System.Drawing.Size(124, 722);
            this.mspSellerParentForm.TabIndex = 3;
            this.mspSellerParentForm.Text = "menuStrip1";
            // 
            // tspSellerProducts
            // 
            this.tspSellerProducts.Name = "tspSellerProducts";
            this.tspSellerProducts.Size = new System.Drawing.Size(111, 24);
            this.tspSellerProducts.Text = "My Products";
            this.tspSellerProducts.Click += new System.EventHandler(this.tspSellerProducts_Click);
            // 
            // tspSellerAddProduct
            // 
            this.tspSellerAddProduct.Name = "tspSellerAddProduct";
            this.tspSellerAddProduct.Size = new System.Drawing.Size(111, 24);
            this.tspSellerAddProduct.Text = "Add a Product";
            this.tspSellerAddProduct.Click += new System.EventHandler(this.tspSellerAddProduct_Click);
            // 
            // tspSellerAccount
            // 
            this.tspSellerAccount.Name = "tspSellerAccount";
            this.tspSellerAccount.Size = new System.Drawing.Size(111, 24);
            this.tspSellerAccount.Text = "My Account";
            this.tspSellerAccount.Click += new System.EventHandler(this.tspSellerAccount_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(111, 24);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1398, 722);
            this.Controls.Add(this.mspParentForm);
            this.Controls.Add(this.mspSellerParentForm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspParentForm;
            this.MinimumSize = new System.Drawing.Size(1416, 769);
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.mspParentForm.ResumeLayout(false);
            this.mspParentForm.PerformLayout();
            this.mspSellerParentForm.ResumeLayout(false);
            this.mspSellerParentForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspParentForm;
        private System.Windows.Forms.ToolStripMenuItem tspCustomerShop;
        private System.Windows.Forms.ToolStripMenuItem tspCustomerShoppingCart;
        private System.Windows.Forms.ToolStripMenuItem tspCustomerAccount;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mspSellerParentForm;
        private System.Windows.Forms.ToolStripMenuItem tspSellerProducts;
        private System.Windows.Forms.ToolStripMenuItem tspSellerAddProduct;
        private System.Windows.Forms.ToolStripMenuItem tspSellerAccount;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
    }
}