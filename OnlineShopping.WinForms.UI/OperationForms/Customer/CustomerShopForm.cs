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
    public partial class CustomerShopForm : Form
    {
        ParentForm parentForm ;
        Customer customerLoggedIn;

        public CustomerShopForm(Customer customer)
        {
            InitializeComponent();
            customerLoggedIn = customer;
            parentForm = MdiParent as ParentForm; //(ParentForm)
        }

        private void btnCustomerShopAddToCart_Click(object sender, EventArgs e)
        {
            parentForm?.AddToCart((Product)dgwCustomerShopProducts.CurrentRow.DataBoundItem);
        }

        private void CustomerShopForm_Load(object sender, EventArgs e)
        {
            lblCustomerShopCashDisplay.Text = customerLoggedIn.Cash.ToString();
            dgwCustomerShopProducts.DataSource = ProductDal.Select();//.Where(p => p.StockAmount > 0);
        }
    }
}
