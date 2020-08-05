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
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspSellerParentForm = new System.Windows.Forms.MenuStrip();
            this.myProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.shopToolStripMenuItem,
            this.shoppingCartToolStripMenuItem,
            this.myAccountToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.mspParentForm.Location = new System.Drawing.Point(0, 0);
            this.mspParentForm.Name = "mspParentForm";
            this.mspParentForm.Size = new System.Drawing.Size(124, 722);
            this.mspParentForm.TabIndex = 1;
            this.mspParentForm.Text = "menuStrip1";
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.shopToolStripMenuItem.Text = "Shop";
            // 
            // shoppingCartToolStripMenuItem
            // 
            this.shoppingCartToolStripMenuItem.Name = "shoppingCartToolStripMenuItem";
            this.shoppingCartToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.shoppingCartToolStripMenuItem.Text = "Shopping Cart";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.myAccountToolStripMenuItem.Text = "My Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // mspSellerParentForm
            // 
            this.mspSellerParentForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.mspSellerParentForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspSellerParentForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProductsToolStripMenuItem,
            this.addAProductToolStripMenuItem,
            this.myAccountToolStripMenuItem1,
            this.logoutToolStripMenuItem1});
            this.mspSellerParentForm.Location = new System.Drawing.Point(1242, 0);
            this.mspSellerParentForm.Name = "mspSellerParentForm";
            this.mspSellerParentForm.Size = new System.Drawing.Size(156, 722);
            this.mspSellerParentForm.TabIndex = 3;
            this.mspSellerParentForm.Text = "menuStrip1";
            // 
            // myProductsToolStripMenuItem
            // 
            this.myProductsToolStripMenuItem.Name = "myProductsToolStripMenuItem";
            this.myProductsToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.myProductsToolStripMenuItem.Text = "My Products";
            // 
            // addAProductToolStripMenuItem
            // 
            this.addAProductToolStripMenuItem.Name = "addAProductToolStripMenuItem";
            this.addAProductToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.addAProductToolStripMenuItem.Text = "Add a Product";
            // 
            // myAccountToolStripMenuItem1
            // 
            this.myAccountToolStripMenuItem1.Name = "myAccountToolStripMenuItem1";
            this.myAccountToolStripMenuItem1.Size = new System.Drawing.Size(111, 24);
            this.myAccountToolStripMenuItem1.Text = "My Account";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mspSellerParentForm;
        private System.Windows.Forms.ToolStripMenuItem myProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
    }
}