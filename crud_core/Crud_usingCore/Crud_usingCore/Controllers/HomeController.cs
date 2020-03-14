using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Crud_usingCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_usingCore.Controllers
{
    //routing
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

        [HttpGet] //verb

        public IActionResult Selectall()
        {

            DataSet ds = _employee.Selectall();
            return Ok(ds);
        }

        [HttpGet("{id}")]

        public IActionResult Selectone(int id)
        {

            DataSet ds = _employee.Selectone(id);
            return Ok(ds);
        }

        [HttpPost]

        public IActionResult InsertData(Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _employee.InsertData(employee);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        [HttpPut("{id}")]
        public IActionResult UpdateData(int id, Employee Employee)
        {

            try
            {
                if (emp == null)
                {
                    return Ok(BadRequest());
                }
                bool result = _employee.UpdateData(id, emp);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "unable to update data" });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            try
            {
                if (emp == null)
                {
                    return Ok(BadRequest());
                }
                bool result =_employee.DeleteData(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "Something went wrong" });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}