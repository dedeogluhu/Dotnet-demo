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
        public static bool ValidateCustomer(string id, string password)
        {
            bool foundEntity = false;

            foreach (Customer customer in CustomerDal.Select())
            {
                if (customer.CustomerId == id && customer.Password == password)
                {
                    foundEntity = true;
                }
            }

            return foundEntity;
        }

        public static bool ValidateSeller(string id, string password)
        {
            bool foundEntity = false;

            foreach (Seller seller in SellerDal.Select())
            {
                if (seller.SellerId == id && seller.Password == password)
                {
                    foundEntity = true;
                }
            }

            return foundEntity;
        }
    }
}
