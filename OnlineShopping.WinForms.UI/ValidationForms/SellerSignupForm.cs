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
    }
}
