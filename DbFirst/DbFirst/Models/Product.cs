using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Orders>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
