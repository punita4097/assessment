using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_netcore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud_netcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly IAddress _d;
        public IndexController(IAddress d)
        {
            
            _d = d;
        }
        [HttpGet]

        public IActionResult address_data()
        {
            var add = _d.address_data();
            return Ok(add);
        }

    }
}