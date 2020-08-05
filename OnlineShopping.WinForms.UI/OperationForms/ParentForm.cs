using OnlineShopping.Entity;
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

            SellerCustomerChooseForm sellerCustomerChooseForm = new SellerCustomerChooseForm();
            sellerCustomerChooseForm.MdiParent = this;
            sellerCustomerChooseForm.Show();

            mspParentForm.Visible = false;
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SellerLoggedIn = null;

            SellerCustomerChooseForm sellerCustomerChooseForm = new SellerCustomerChooseForm();
            sellerCustomerChooseForm.MdiParent = this;
            sellerCustomerChooseForm.Show();

            mspSellerParentForm.Visible = false;
        }
    }
}
