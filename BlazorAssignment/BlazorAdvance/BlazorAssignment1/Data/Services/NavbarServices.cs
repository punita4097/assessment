using BlazorAssignment1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment1.Data.Services
{
    public class NavbarServices
    {

        private readonly BlazorDbContext _db;

        public NavbarServices(BlazorDbContext db)
        {
            _db = db;
        }

        public List<NavBarInfo> GetNav()
        {
             var result =_db.NavBar.ToList();

            return result;
        }
        public string AddNavBar(NavBarInfo nav)
        {
            if (_db.NavBar.Any(x => x.CategoryName == nav.CategoryName))
            {
                return "Can not generate link with same name with same name";
            }
            else
            {
                _db.NavBar.Add(nav);
                _db.SaveChanges();
                return "Successfully";

            }


        }

    }
}
