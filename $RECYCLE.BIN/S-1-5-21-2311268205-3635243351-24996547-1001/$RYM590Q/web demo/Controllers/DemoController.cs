using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_demo.Controllers
{
    public class demoController : ApiController
    {
        
        public string Get()
        {
            return "hello punita";

        }
       
       [HttpGet]
        public string Details()
        {
            return "hi";
        }
        
    }
}
