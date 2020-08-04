﻿using OnlineShopping.WinForms.UI.ValidationForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping.WinForms.UI
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            mspParentForm.Visible = false;
            mspSellerParentForm.Visible = false;

            SellerCustomerChooseForm sellerCustomerChooseForm = new SellerCustomerChooseForm();
            sellerCustomerChooseForm.MdiParent = this;
            sellerCustomerChooseForm.Show();
        }
    }
}
