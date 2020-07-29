using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
    }
}
