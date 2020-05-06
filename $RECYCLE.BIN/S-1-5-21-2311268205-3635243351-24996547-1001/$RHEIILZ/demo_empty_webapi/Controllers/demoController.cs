using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace demo_empty_webapi.Controllers
{
    public class demoController : ApiController
    {
        public string Getdetails()
        {
            return "punita";
        }
        [HttpGet]
        public string Getdata()
        {
            return "all is well";
        }



    }
}
