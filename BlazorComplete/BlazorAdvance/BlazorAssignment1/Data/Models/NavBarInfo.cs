using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment1.Data.Models
{
    public class NavBarInfo
    {
        [Key]
        public int NavId { get; set; }
        [Required(ErrorMessage = "CategoryName is required")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Reference is required")]
        public string Reference { get; set; }


    }
}
