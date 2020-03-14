using crud.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace crud.Controllers
{
    public class HomeController : ApiController
    {
        Employee employee = new Employee();
        EmployeeData employeeData = new EmployeeData();

        [HttpGet]

        public IHttpActionResult Selectall()
        {

            DataSet ds = employeeData.Selectall();
            return Ok(ds);
        }

        [HttpGet]

        public IHttpActionResult Selectone(int id)
        {

            DataSet ds = employeeData.Selectone(id);
            return Ok(ds);
        }

        [HttpPost]

        public IHttpActionResult InsertData(Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = employeeData.InsertData(employee);
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

        [HttpPut]
        public IHttpActionResult UpdateData(int id, Employee Employee)
        {

            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }
                bool result = employeeData.UpdateData(id, employee);
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
        [HttpDelete]
        public IHttpActionResult DeleteData(int id)
        {
            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }
                bool result = employeeData.DeleteData(id);
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
