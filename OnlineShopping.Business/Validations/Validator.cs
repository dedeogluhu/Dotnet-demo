using OnlineShopping.ORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Validations
{
    public class Validator<T> where T : IEntityDal
    {
        public static bool Validate(string id, string password)
        {
            return false;
        }
    }
}
