using MvcAssign1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssign1.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            Student data = TempData["mydata"] as Student;
            ViewBag.Message = data;
            return View();
        }
    }
}