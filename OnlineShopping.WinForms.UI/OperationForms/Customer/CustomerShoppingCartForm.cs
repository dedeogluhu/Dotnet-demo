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
    public partial class CustomerShoppingCartForm : Form
    {
        Customer customerLoggedIn;
        List<Product> customerCart;
        ParentForm mainForm;

        public CustomerShoppingCartForm(Customer customer, List<Product> customerCartItems)
        {
            InitializeComponent();
            customerLoggedIn = customer;
            customerCart = customerCartItems;
            mainForm = (ParentForm)MdiParent;
        }

        private void CustomerShoppingCartForm_Load(object sender, EventArgs e)
        {
            dgwCustomerShoppingCart.DataSource = customerCart; 
        }

        private void btnCustomerCartBuy_Click(object sender, EventArgs e)
        {
            decimal sumOfCart = 0;

            foreach (Product product in customerCart)
            {
                sumOfCart += product.UnitPrice;

                Seller seller = (Seller)SellerDal.Select().Where(s => s.Id == product.SellerId);

                seller.Cash += product.UnitPrice;

                SellerDal.Update(seller);

                Order order = new Order
                {
                    CustomerId = customerLoggedIn.Id,
                    SaleDate = DateTime.Now,
                    SellerId = product.SellerId
                };

                OrderDal.Insert(order);

                //OrderDetail orderDetail = new OrderDetail
                //{
                //    OrderId = order.Id,
                //    Price = product.UnitPrice,
                //    ProductId = product.Id,
                //    Quantity = 1
                //};

                //OrderDetailsDal.Insert(orderDetail);
            }

            customerLoggedIn.Cash -= sumOfCart;
            CustomerDal.Update(customerLoggedIn);

            lblCustomerCartCashDisplay.Text = customerLoggedIn.Cash.ToString();

            MessageBox.Show($"{customerCart.Count()}Items bought");

            customerCart.Clear();
            mainForm.ClearCart();
        }
    }
}
