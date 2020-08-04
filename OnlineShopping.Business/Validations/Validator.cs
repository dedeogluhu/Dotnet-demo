using OnlineShopping.Business.Interfaces;
using OnlineShopping.Entity;
using OnlineShopping.ORM.DataAccessLayers;
using OnlineShopping.ORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Validations
{
    public class Validator : IValidator
    {
        public static Customer ValidateCustomer(string id, string password)
        {
            foreach (Customer customer in CustomerDal.Select())
            {
                if (customer.CustomerId == id && customer.Password == password) return customer;
            }

            return null;
        }

        public static Seller ValidateSeller(string id, string password)
        {
            foreach (Seller seller in SellerDal.Select())
            {
                if (seller.SellerId == id && seller.Password == password) return seller;
            }

            return null;
        }
    }
}
