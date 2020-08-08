using OnlineShopping.Business.LoginValidations;
using OnlineShopping.Entity;
using System;
using System.Windows.Forms;

namespace OnlineShopping.WinForms.UI.ValidationForms
{
    public partial class CustomerLoginForm : Form
    {
        

        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private void btnCustomerLoginToSignup_Click(object sender, EventArgs e)
        {
            CustomerSignupForm customerSignupForm = new CustomerSignupForm();
            customerSignupForm.MdiParent = this.MdiParent;
            customerSignupForm.Show();
            this.Hide();
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            Customer customer = LoginValidator.ValidateCustomer(tbxCustomerLoginId.Text, tbxCustomerLoginPassword.Text);

            ParentForm mainForm = (ParentForm)MdiParent;

            if (customer != null)
            {
                mainForm.CustomerLogin(customer);
                this.Hide();
                //Login
            }
            else
            {
                MessageBox.Show("Login Failed!\nWrong Id or Password");
            }
        }

        private static void OnCustomerLogin(object sender, EventArgs e)
        {

        }
    }
}
