using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_Db.Models;


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entity_Db.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly IEmployee _data;
        public IndexController(IEmployee data)
        {

            _data = data;
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult GetData()
        {
            IEnumerable<Employee> s = _data.GetData();
            return Ok(s);
        }

        [Authorize(Roles = "user")]
        [HttpGet("{id}")]

        public IActionResult GetDataById(int id)
        {
            Employee s = _data.GetDataById(id);
            return Ok(s);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult InsertData(Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.InsertData(employee);
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

        [Authorize(Roles = "user")]
        [HttpPut("{id}")]
        public IActionResult UpdateData(int id, Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.UpdateData(id, employee);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to update data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [Authorize(Roles = "admin")]
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            Employee employee = new Employee();
            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _data.DeleteData(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "Id not found..........!!!" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}