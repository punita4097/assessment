using System;
using System.Collections.Generic;

namespace Entity_Db.Models
{
    public partial class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
