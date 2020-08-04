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
    }
}
