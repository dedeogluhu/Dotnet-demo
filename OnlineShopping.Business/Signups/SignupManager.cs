using OnlineShopping.Entity;
using OnlineShopping.ORM.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Signups
{
    public class SignupManager
    {
        public static bool CustomerExistence(Customer customer)
        {
            foreach (Customer item in CustomerDal.Select())
            {
                if (customer.CustomerId == item.CustomerId) return true;
            }

            return false;
        }

        public static bool SellerExistence(Seller seller)
        {
            foreach (Seller item in SellerDal.Select())
            {
                if (seller.SellerId == item.SellerId || seller.CompanyName == item.CompanyName) return true;
            }

            return false;
        }

        public static string CustomerSignup(Customer customer)
        {
            bool customerExists = CustomerExistence(customer);

            bool customerAdded = false;

            if (customerExists == false) customerAdded = CustomerDal.Insert(customer);
            else return "This Id already exists";

            if (customerAdded) return "Signup successful";
            else return "Signup failed";
        }

        public static string SellerSignup(Seller seller)
        {
            bool sellerExists= SellerExistence(seller);

            bool sellerAdded = false;

            if (sellerExists == false) sellerAdded = SellerDal.Insert(seller);
            else return "This seller already exists";

            if (sellerAdded) return "Signup successful";
            else return "Signup failed";
        }
    }
}
