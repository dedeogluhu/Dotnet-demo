namespace OnlineShopping.WinForms.UI.OperationForms
{
    partial class SellerProductsForm
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
            this.dgwSellerProducts = new System.Windows.Forms.DataGridView();
            this.btnSellerProductsRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSellerProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSellerProducts
            // 
            this.dgwSellerProducts.AllowUserToAddRows = false;
            this.dgwSellerProducts.AllowUserToDeleteRows = false;
            this.dgwSellerProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSellerProducts.Location = new System.Drawing.Point(13, 13);
            this.dgwSellerProducts.Name = "dgwSellerProducts";
            this.dgwSellerProducts.ReadOnly = true;
            this.dgwSellerProducts.RowHeadersWidth = 51;
            this.dgwSellerProducts.RowTemplate.Height = 24;
            this.dgwSellerProducts.Size = new System.Drawing.Size(775, 425);
            this.dgwSellerProducts.TabIndex = 0;
            // 
            // btnSellerProductsRemove
            // 
            this.btnSellerProductsRemove.Location = new System.Drawing.Point(627, 445);
            this.btnSellerProductsRemove.Name = "btnSellerProductsRemove";
            this.btnSellerProductsRemove.Size = new System.Drawing.Size(161, 69);
            this.btnSellerProductsRemove.TabIndex = 1;
            this.btnSellerProductsRemove.Text = "Remove Product";
            this.btnSellerProductsRemove.UseVisualStyleBackColor = true;
            this.btnSellerProductsRemove.Click += new System.EventHandler(this.btnSellerProductsRemove_Click);
            // 
            // SellerProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.btnSellerProductsRemove);
            this.Controls.Add(this.dgwSellerProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SellerProductsForm";
            this.Text = "SellerProductsForm";
            this.Load += new System.EventHandler(this.SellerProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSellerProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSellerProducts;
        private System.Windows.Forms.Button btnSellerProductsRemove;
    }
}