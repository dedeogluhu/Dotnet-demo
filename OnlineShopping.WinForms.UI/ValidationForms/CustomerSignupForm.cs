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
    public partial class CustomerSignupForm : Form
    {
        public CustomerSignupForm()
        {
            InitializeComponent();
        }

        private void btnCustomerSignupToLogin_Click(object sender, EventArgs e)
        {
            CustomerLoginForm customerLoginForm = new CustomerLoginForm();
            customerLoginForm.MdiParent = this.MdiParent;
            customerLoginForm.Show();
            this.Hide();
        }

        private void btnCustomerSignup_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                CustomerId = tbxCustomerSignupId.Text,
                FirstName = tbxCustomerSignupFirstName.Text,
                LastName = tbxCustomerSignupLastName.Text,
                Password = tbxCustomerSignupPassword.Text,
                Cash = 0
            };

            CustomerSignupState customerSignupState = SignupManager.CustomerSignup(customer);

            switch (customerSignupState)
            {
                case CustomerSignupState.IdExists:
                    MessageBox.Show("This ID already exists!");
                    break;
                case CustomerSignupState.Successful:
                    MessageBox.Show("Signup Successful");
                    break;
                case CustomerSignupState.Failed:
                    MessageBox.Show("Signup Failed!");
                    break;
                default:
                    break;
            }
        }
    }
}
