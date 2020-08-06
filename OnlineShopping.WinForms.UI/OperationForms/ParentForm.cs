using OnlineShopping.Entity;
using OnlineShopping.WinForms.UI.OperationForms;
using OnlineShopping.WinForms.UI.ValidationForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping.WinForms.UI
{
    public partial class ParentForm : Form
    {
        public Customer CustomerLoggedIn { get; set; }
        public Seller SellerLoggedIn { get; set; }
        public List<Product> ShoppingCart { get;private set; } = new List<Product>();

        public void AddToCart(Product product)
        {
            ShoppingCart.Add(product);
        }

        public void ClearCart()
        {
            ShoppingCart.Clear();
        }
        public void CustomerLogin(Customer customer)
        {
            CustomerLoggedIn = customer;
            mspParentForm.Visible = true;
        }

        public void SellerLogin(Seller seller)
        {
            SellerLoggedIn = seller;
            mspSellerParentForm.Visible = true;
        }

        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            mspParentForm.Visible = false;
            mspSellerParentForm.Visible = false;

            SellerCustomerChooseForm sellerCustomerChooseForm = new SellerCustomerChooseForm();
            sellerCustomerChooseForm.MdiParent = this;
            sellerCustomerChooseForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerLoggedIn = null;

            mspParentForm.Visible = false;

            SellerCustomerChooseForm sellerCustomerChooseForm = new SellerCustomerChooseForm();
            sellerCustomerChooseForm.MdiParent = this;
            sellerCustomerChooseForm.Show();       
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SellerLoggedIn = null;

            mspSellerParentForm.Visible = false;

            SellerCustomerChooseForm sellerCustomerChooseForm = new SellerCustomerChooseForm();
            sellerCustomerChooseForm.MdiParent = this;
            sellerCustomerChooseForm.Show();    
        }

        private void tspCustomerShop_Click(object sender, EventArgs e)
        {
            CustomerShopForm customerShopForm = new CustomerShopForm(CustomerLoggedIn);
            customerShopForm.MdiParent = this;
            customerShopForm.Show();
        }

        private void tspCustomerShoppingCart_Click(object sender, EventArgs e)
        {
            CustomerShoppingCartForm customerShoppingCartForm = new CustomerShoppingCartForm(CustomerLoggedIn, ShoppingCart);
            customerShoppingCartForm.MdiParent = this;
            customerShoppingCartForm.Show();
        }

        private void tspCustomerAccount_Click(object sender, EventArgs e)
        {
            CustomerAccountForm customerAccountForm = new CustomerAccountForm(CustomerLoggedIn);
            customerAccountForm.MdiParent = this;
            customerAccountForm.Show();
        }

        private void tspSellerProducts_Click(object sender, EventArgs e)
        {
            SellerProductsForm sellerProductsForm = new SellerProductsForm(SellerLoggedIn);
            sellerProductsForm.MdiParent = this;
            sellerProductsForm.Show();
        }

        private void tspSellerAddProduct_Click(object sender, EventArgs e)
        {
            SellerAddProductForm sellerAddProductForm = new SellerAddProductForm(SellerLoggedIn);
            sellerAddProductForm.MdiParent = this;
            sellerAddProductForm.Show();
        }

        private void tspSellerAccount_Click(object sender, EventArgs e)
        {
            SellerAccountForm sellerAccountForm = new SellerAccountForm(SellerLoggedIn);
            sellerAccountForm.MdiParent = this;
            sellerAccountForm.Show();
        }
    }
}
