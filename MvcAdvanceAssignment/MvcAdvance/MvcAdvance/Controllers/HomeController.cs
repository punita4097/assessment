using MvcAdvance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAdvance.Controllers
{
   //[RoutePrefix("{Home}")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [MyErrorHandler]            //custom error filter for IexceptionFilter
        public ActionResult Welcome()
        {
            return View();
        }


        [HttpGet]
       
        [OutputCache(Duration = 10, Order=2)]       //in built filter for ActionFilter
        [HandleError(Order =1)]                 //in--built filter for Iexception
        [Route("{id}")]             //attribute routing   https://localhost:44323/1
        [Route("{id}/Details")]         //attribute routing   https://localhost:44323/1/Details

        public ActionResult GetById(int Id)
        {
            try
            {
                MvcPrjectEntities context = new MvcPrjectEntities();
                var result = context.Registers.Where(s => s.Id == Id).FirstOrDefault();
                return View(result);

            }
            catch (Exception)
            {

                throw new Exception("This is an exception");
            }        
        }
        
        
       // [HttpGet]
       //public ActionResult GetAllData()
       // {
       //     MvcPrjectEntities context = new MvcPrjectEntities();
       //     List<Register> student = context.Registers.ToList();
       //     return View(student);
       // }
        [ChildActionOnly]
        [HttpGet]
      
        public ActionResult Create()
        {
            Register register = new Register();

            return PartialView(register);
        }
        [HttpPost]
         [ValidateAntiForgeryToken]             //Help to prevent the cross-site request forgery
        public ActionResult Create(Register register)
        {
            using (MvcPrjectEntities loginData = new MvcPrjectEntities())
            {
                if (loginData.Registers.Any(x => x.Name == register.Name))
                {
                    ViewBag.DuplicateMessage = "Username already exist";
                    return View("Create", register);
                }
                loginData.Registers.Add(register);
                loginData.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Index", new Register());

        }


        public ActionResult Ques2()
        {


            return View();
        }


        

        public ActionResult Ques1()
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