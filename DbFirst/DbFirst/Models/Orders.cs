using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int FkProductId { get; set; }
        public int FkCustomerId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual Customer FkCustomer { get; set; }
        public virtual Product FkProduct { get; set; }
    }
}
