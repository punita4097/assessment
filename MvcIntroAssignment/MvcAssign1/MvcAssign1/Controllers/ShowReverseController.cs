using MvcAssign1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcAssign1.Controllers
{
    public class ShowReverseController : Controller
    {
        // GET: ShowReverse
        public ActionResult Index()
        {
            return View();
        }
    
        [HttpPost]
        public ActionResult Index(Student student)
        {
           

            StringBuilder store = new StringBuilder();
            store.Append("<b>ID :</b> " + student.StudentID + "<br/>");
            store.Append("<b>NAME :</b> " + student.Name + "<br/>");
            store.Append("<b>Country :</b> " + student.Country + "<br/>");
           
            return Content(store.ToString());

           
        }
    }
}