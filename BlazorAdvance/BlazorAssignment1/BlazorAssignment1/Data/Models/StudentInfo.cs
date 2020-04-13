using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment1.Data.Models
{
    public class StudentInfo
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public int Age { get; set; }

    }
}
