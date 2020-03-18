using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Crud_JwtToken.Data;
using Crud_JwtToken.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Crud_JwtToken.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        Employee emp = new Employee();//object of the employee 
        private IEmployee _employee;

        public HomeController(IEmployee employee)
        {
            _employee = employee;

        }
        [Authorize(Roles = "Admin")]
        [HttpGet] //verb

        public IActionResult Selectall()
        {

            try
            {
                DataSet ds = _employee.Selectall();
                return Ok(ds);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Authorize(Roles = "User")]
        [HttpGet("{id}")]

        public IActionResult Selectone(int id)
        {

            try
            {
                DataSet ds = _employee.Selectone(id);
                return Ok(ds);
            }
            catch (Exception )
            {
                throw;
            }
        }
        
    }
}