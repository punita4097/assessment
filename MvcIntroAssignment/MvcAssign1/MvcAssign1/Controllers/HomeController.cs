using MvcAssign1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssign1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Student data = new Student()
            {
                StudentID = 1,
                Name = "Punita",
                Country = "India"
            };
            TempData["mydata"] = data;
            return RedirectToAction("Index", "Home2");
        }

        
    }
}