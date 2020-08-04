using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Tools
{
    public enum CustomerSignupState
    {
        IdExists,
        Successful,
        Failed
    }

    public enum SellerSignupState
    {
        IdExists,
        CompanyNameExists,
        Successful,
        Failed
    }
}
