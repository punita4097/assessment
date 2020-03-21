using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
