using OnlineShopping.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Entity
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Cash { get; set; }
    }
}
