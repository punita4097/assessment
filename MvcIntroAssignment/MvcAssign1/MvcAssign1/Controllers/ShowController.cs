using MvcAssign1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcAssign1.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        public ActionResult Index()
        {
            Student data = new Student()
            {
                StudentID = 1,
                Name = "Punita",
                Country = "India"
            };
            ViewBag.Message = data;
            return View();
        }

        
    }
}