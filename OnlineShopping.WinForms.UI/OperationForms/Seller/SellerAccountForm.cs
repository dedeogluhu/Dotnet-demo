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
    public partial class SellerAccountForm : Form
    {
        Seller sellerLoggedIn;
        public SellerAccountForm(Seller seller)
        {
            InitializeComponent();
            sellerLoggedIn = seller;
        }

        private void SellerAccountForm_Load(object sender, EventArgs e)
        {
            lblSellerAccountCashDisplay.Text = sellerLoggedIn.Cash.ToString();

            tbxSellerAccountCompanyName.Text = sellerLoggedIn.CompanyName;
            tbxSellerAccountId.Text = sellerLoggedIn.SellerId;
            tbxSellerAccountPassword.Text = sellerLoggedIn.Password;
        }

        private void btnSellerAccountUpdate_Click(object sender, EventArgs e)
        {
            sellerLoggedIn.SellerId = tbxSellerAccountId.Text;
            sellerLoggedIn.Password = tbxSellerAccountPassword.Text;
            sellerLoggedIn.CompanyName = tbxSellerAccountCompanyName.Text;

            SellerDal.Update(sellerLoggedIn);
        }

        private void btnSellerAccountWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(tbxSellerAccountWithdrawAmount.Text);

            if (amount > sellerLoggedIn.Cash)
            {
                sellerLoggedIn.Cash -= amount;

                lblSellerAccountCashDisplay.Text = sellerLoggedIn.Cash.ToString();

                SellerDal.Update(sellerLoggedIn);
            }
            else
            {
                MessageBox.Show("Withdraw Amount Can't Be Bigger Than Your Cash");
            }
        }
    }
}
