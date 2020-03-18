using System;
using System.Collections.Generic;

namespace Entity_Db.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Salary { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
