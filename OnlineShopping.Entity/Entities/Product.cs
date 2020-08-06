using OnlineShopping.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Entity
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SellerId { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
        public bool isActive { get; set; }
    }
}
