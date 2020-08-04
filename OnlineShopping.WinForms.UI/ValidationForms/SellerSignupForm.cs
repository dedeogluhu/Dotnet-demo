using OnlineShopping.Business.Signups;
using OnlineShopping.Business.Tools;
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
    public partial class SellerSignupForm : Form
    {
        public SellerSignupForm()
        {
            InitializeComponent();
        }

        private void btnSellerSignupToLogin_Click(object sender, EventArgs e)
        {
            SellerLoginForm sellerLoginForm = new SellerLoginForm();
            sellerLoginForm.MdiParent = this.MdiParent;
            sellerLoginForm.Show();
            this.Hide();
        }

        private void btnSellerSignup_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller
            {
                SellerId = tbxSellerSignupId.Text,
                CompanyName = tbxSellerSignupCompanyName.Text,
                Password = tbxSellerSignupPassword.Text,
                Cash = 0
            };

            SellerSignupState sellerSignupState = SignupManager.SellerSignup(seller);

            switch (sellerSignupState)
            {
                case SellerSignupState.IdExists:
                    MessageBox.Show("This ID already exists!");
                    break;
                case SellerSignupState.CompanyNameExists:
                    MessageBox.Show("This company already exist");
                    break;
                case SellerSignupState.Successful:
                    MessageBox.Show("Signup Successful");
                    break;
                case SellerSignupState.Failed:
                    MessageBox.Show("Signup Failed");
                    break;
                default:
                    break;
            }   
        }
    }
}
