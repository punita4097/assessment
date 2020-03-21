using Codefirst1.Data;
using Codefirst1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Codefirst1.Controllers
{
    public class IndexController : ApiController
    {
        //CustomerData _customer;

        //private  ICustomer _customer;

        //public IndexController(ICustomer customer)
        //{
        //    _customer = customer;

        //}

        // CustomerData _customer = new CustomerData();


        Customer customer = new Customer();
        Orders orders = new Orders();
        CustomerData _customer = new CustomerData();

        [HttpGet]
        public IHttpActionResult GetData()
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
        [HttpGet]
        public IHttpActionResult GetDataById(int id)
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
        public IHttpActionResult InsertData(Customer customer)
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

        [HttpPut]
        public IHttpActionResult UpdateData(int id, Orders orders)
        {

            try
            {
                if (orders == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _customer.UpdateData(id, orders);
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

        public IHttpActionResult DeleteData(Orders orders)
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
