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
            this.mspParentForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspParentForm
            // 
            this.mspParentForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspParentForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopToolStripMenuItem,
            this.shoppingCartToolStripMenuItem,
            this.myAccountToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.mspParentForm.Location = new System.Drawing.Point(0, 0);
            this.mspParentForm.Name = "mspParentForm";
            this.mspParentForm.Size = new System.Drawing.Size(1398, 28);
            this.mspParentForm.TabIndex = 1;
            this.mspParentForm.Text = "menuStrip1";
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.shopToolStripMenuItem.Text = "Shop";
            // 
            // shoppingCartToolStripMenuItem
            // 
            this.shoppingCartToolStripMenuItem.Name = "shoppingCartToolStripMenuItem";
            this.shoppingCartToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.shoppingCartToolStripMenuItem.Text = "Shopping Cart";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.myAccountToolStripMenuItem.Text = "My Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 722);
            this.Controls.Add(this.mspParentForm);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspParentForm;
            this.MinimumSize = new System.Drawing.Size(1416, 769);
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.mspParentForm.ResumeLayout(false);
            this.mspParentForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspParentForm;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}