using OnlineShopping.Entity;
using OnlineShopping.ORM.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping.WinForms.UI.OperationForms
{
    public partial class SellerAddProductForm : Form
    {
        Seller sellerLoggedIn;
        public SellerAddProductForm(Seller seller)
        {
            InitializeComponent();
            sellerLoggedIn = seller;
        }

        private void SellerAddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSellerAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductName = tbxSellerAddProductName.Text,
                SellerId = sellerLoggedIn.Id,
                StockAmount = Convert.ToInt32(tbxSellerAddProductStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxSellerAddProductUnitPrice.Text)
            };

            ProductDal.Insert(product);

            MessageBox.Show("Product Added");
        }
    }
}
