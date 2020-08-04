using OnlineShopping.Business.Validations;
using OnlineShopping.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping.WinForms.UI.ValidationForms
{
    public partial class SellerLoginForm : Form
    {
        public SellerLoginForm()
        {
            InitializeComponent();
        }

        private void btnSellerLoginToSignup_Click(object sender, EventArgs e)
        {
            SellerSignupForm sellerSignupForm = new SellerSignupForm();
            sellerSignupForm.MdiParent = this.MdiParent;
            sellerSignupForm.Show();
            this.Hide();
        }

        private void btnSellerLogin_Click(object sender, EventArgs e)
        {
            Seller seller = Validator.ValidateSeller(tbxSellerLoginId.Text, tbxSellerLoginPassword.Text);

            if(seller != null)
            {
                //Seller Login
            }
            else
            {
                MessageBox.Show("Login Failed!\nWrong Id or Password");
            }

        }
    }
}
