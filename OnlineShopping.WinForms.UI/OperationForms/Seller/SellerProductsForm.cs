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
    public partial class SellerProductsForm : Form
    {
        Seller sellerLoggedIn;
        public SellerProductsForm(Seller seller)
        {
            InitializeComponent();
            sellerLoggedIn = seller;
        }

        private void SellerProductsForm_Load(object sender, EventArgs e)
        {
            dgwSellerProducts.DataSource = ProductDal.Select().Select(p => p.SellerId == sellerLoggedIn.Id);//.Where(p => p.StockAmount > 0);
        }

        private void btnSellerProductsRemove_Click(object sender, EventArgs e)
        {
            ProductDal.Delete((Product)dgwSellerProducts.CurrentRow.DataBoundItem);

            dgwSellerProducts.DataSource = ProductDal.Select().Where(p => p.SellerId == sellerLoggedIn.Id).Where(p => p.StockAmount > 0);

            MessageBox.Show("Product Deleted");
        }
    }
}
