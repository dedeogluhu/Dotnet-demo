using OnlineShopping.Business.LoginValidations;
using OnlineShopping.Entity;
using System;
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
            Seller seller = LoginValidator.ValidateSeller(tbxSellerLoginId.Text, tbxSellerLoginPassword.Text);

            ParentForm mainForm = (ParentForm)MdiParent;

            if(seller != null)
            {
                mainForm.SellerLogin(seller);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed!\nWrong Id or Password");
            }

        }
    }
}
