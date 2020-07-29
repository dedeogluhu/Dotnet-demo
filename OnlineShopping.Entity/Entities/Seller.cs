using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Entity
{
    public class Seller
    {
        public int Id { get; set; }
        public string SellerId { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public decimal Cash { get; set; }
    }
}
