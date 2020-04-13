using MvcBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcBasic.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DetailsStudent()
        {
            RazorCrudDBEntities context = new RazorCrudDBEntities();
            List<Student> student = context.Students.ToList();
            return View(student);
        }

        [HttpGet]
        public ActionResult DetailsLogin()
        {
            RazorCrudDBEntities context = new RazorCrudDBEntities();
            List<Login> logins = context.Logins.ToList();
            return View(logins);
        }
        public ActionResult Ques2()
        {
            return View();
        }
        //[NonAction]:   If this method is named as [Non Action ] then its can be called as a URL request it will throw and error


        [ChildActionOnly]
        [HttpGet]
        public ActionResult StudentLogin()
        {
            Login login = new Login();

            return PartialView("StudentLogin", login);
        }

        [HttpPost]
        public ActionResult StudentLogin(Login login)
        {
            RazorCrudDBEntities context = new RazorCrudDBEntities();
            if (ModelState.IsValid)
            {
                try
                {
                    if (login != null)
                    {
                        context.Logins.Add(login);
                        context.SaveChanges();
                        return View();
                    }
                }
                catch
                {
                    return RedirectToAction("DetailsLogin", "Home");
                }
            }

            return View("Index", login);


        }
        [ChildActionOnly]
        [HttpGet]
        public ActionResult StudentRegistration()
        {
            Student student= new Student();
            return PartialView("StudentRegistration", student);
        }

        [HttpPost]
        public ActionResult StudentRegistration([Bind(Exclude = "LastName,Age")]Student student)
        {
            RazorCrudDBEntities context = new RazorCrudDBEntities();
            if (ModelState.IsValid)
            {
                try
                {
                    if (student != null)
                    {
                        context.Students.Add(student);
                        context.SaveChanges();
                        return View();
                    }
                }
                catch
                {
                    return RedirectToAction("DetailsStudent", "Home");
                }
            }

            return View("Index", student);


        }
        public ActionResult Ques1()
        {
            return View();
        }
        public ActionResult Ques2Theory()
        {
            return View();
        }



        public ActionResult Ques3()
        {
            return View();
        }

        public ActionResult Ques4()
        {
            return View();
        }

        public ActionResult Ques5()
        {
            return View();
        }
    }
}