using OnlineShopping.Business.Tools;
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
        public static CustomerSignupState CustomerSignup(Customer customer)
        {
            //Look for customer existence
            foreach (Customer item in CustomerDal.Select())
            {
                if (customer.CustomerId == item.CustomerId) return CustomerSignupState.IdExists;
            }

            bool result = CustomerDal.Insert(customer);

            if (result) return CustomerSignupState.Successful;
            
            return CustomerSignupState.Failed;
        }

        public static SellerSignupState SellerSignup(Seller seller)
        {
            //Look for seller existence
            foreach (Seller item in SellerDal.Select())
            {
                if (seller.SellerId == item.SellerId) return SellerSignupState.IdExists;
                if (seller.CompanyName == item.CompanyName) return SellerSignupState.CompanyNameExists;
            }

            bool result = SellerDal.Insert(seller);

            if (result) return SellerSignupState.Successful;

            return SellerSignupState.Failed;
        }
    }
}
