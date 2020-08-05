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
    public partial class CustomerAccountForm : Form
    {
        Customer customerLoggedIn;

        public CustomerAccountForm(Customer customer)
        {
            customerLoggedIn = customer;
            InitializeComponent();
        }

        private void CustomerAccountForm_Load(object sender, EventArgs e)
        {
            tbxUpdateCustomerFirstName.Text = customerLoggedIn.FirstName;
            tbxUpdateCustomerLastName.Text = customerLoggedIn.LastName;
            tbxUpdateCustomerId.Text = customerLoggedIn.CustomerId;
            tbxUpdateCustomerPassword.Text = customerLoggedIn.Password;

            lblCustomerAccountCashDisplay.Text = customerLoggedIn.Cash.ToString();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            customerLoggedIn.FirstName = tbxUpdateCustomerFirstName.Text;
            customerLoggedIn.LastName = tbxUpdateCustomerLastName.Text;
            customerLoggedIn.CustomerId = tbxUpdateCustomerId.Text;
            customerLoggedIn.Password = tbxUpdateCustomerPassword.Text;

            CustomerDal.Update(customerLoggedIn);
        }

        private void btnCustomerDepositCash_Click(object sender, EventArgs e)
        {
            customerLoggedIn.Cash += Convert.ToDecimal(tbxCustomerDepositCash.Text);

            CustomerDal.Update(customerLoggedIn);

            lblCustomerAccountCashDisplay.Text = customerLoggedIn.Cash.ToString();
        }
    }
}
