using BlazorAssignment1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorAssignment1.Data.Services
{
    public class LoginServices
    {
        private readonly BlazorDbContext _db;

        public LoginServices(BlazorDbContext db)
        {
            _db = db;
        }
        public string Register(LoginInfo login)
        {
            if (_db.Logins.Any(x => x.Name == login.Name))
            {
                return "Can not register with same name";
            }
            else
            { 
                _db.Logins.Add(login);
                _db.SaveChanges();
                return "Successfully";
                
            }


        }

       
    }
}
