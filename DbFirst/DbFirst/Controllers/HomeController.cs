using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbFirst.Data;
using DbFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbFirst.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICustomer _customer;

        public HomeController(ICustomer customer)
        {
            _customer = customer;
        }

        [HttpGet]
        public IActionResult GetData()
        {
            try
            {
                var result = _customer.GetData();
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetDataById(int id)
        {
            try
            {
                var result = _customer.GetDataById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public IActionResult InsertData(Customer customer)
        {

            try
            {
                if (customer == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.InsertData(customer);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " Cannot insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateData(int id,Orders orders)
        {

            try
            {
                if (orders == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.UpdateData(id,orders);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " Cannot update data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete]

        public IActionResult DeleteData(Orders orders)
        {

            try
            {

                bool result = _customer.DeleteData(orders);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " Cannot delete data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}