using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_JwtToken.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        
    }
}
