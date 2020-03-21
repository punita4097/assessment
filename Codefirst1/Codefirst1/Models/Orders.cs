using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirst1.Models
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public int FkProductId { get; set; }
        public int FkCustomerId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual Customer FkCustomer { get; set; }
        public virtual Product FkProduct { get; set; }
    }
}