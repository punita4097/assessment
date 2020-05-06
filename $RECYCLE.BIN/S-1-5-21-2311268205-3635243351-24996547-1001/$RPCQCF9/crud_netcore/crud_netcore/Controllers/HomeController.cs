using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using crud_netcore.Data;
//using System.Web.Http;
using crud_netcore.Model;
using crud_netcore.ModelFile;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud_netcore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly IEmployee _data;
        private readonly IAddress _d;
        public HomeController(IEmployee data,IAddress d)
        {
            _data = data;
            _d = d;
        }

        
        
      
       
        [HttpGet]

        public IActionResult address_data()
        {
            var add = _d.address_data();
            return Ok(add);
        }
        // [Route("api/[controller]/data")]

       /*     public IActionResult address_data()
        {
            var context1 = new linq_databaseContext();
            var l = (from a in context1.Address
                    where a.Id > 3
                    select new
                    {
                        a.Id,
                        a.City
                    }).ToList();

            return Ok(l);
        }*/
        [HttpGet]
        public IActionResult Inner_join()
        {
            var context1 = new linq_databaseContext();
            var Result = (from o in context1.Person
                        join od in context1.Address on o.Id equals od.Id
                        select new { o.Name, od.City }).ToList();

            return Ok(Result);

        }

        public IActionResult Left_join()
        {
            var context1 = new linq_databaseContext();
            var Result = from o in context1.Address
                         join od in context1.Person on o.Id equals od.Id

         into eGroup
                         from od in eGroup.DefaultIfEmpty()
                         select new { o.City, od.Name };

            return Ok(Result);

        }
        public IActionResult GetData()
        {
           
            DataSet ds = _data.GetData();
            return Ok(ds);

            
           
        }



        [HttpGet("{id}")]
        public IActionResult GetDatawithid(int id)
        {

            DataSet ds = _data.GetDatawithid(id);
            return Ok(ds);
        }




        [HttpPost]

        public ActionResult<bool> InsertData(Employee emp)
        {
            try
            {
                bool add = _data.InsertData(emp);

                if (add)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false });
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpPut("{id}")]

        public ActionResult<bool> UpdateData(int id,Employee emp)
        {

            var add = _data.UpdateData(id,emp);
            //if (add == null)
            //{
            //    return NotFound();
            //}

            return Ok();
        }

        [HttpDelete]

        public ActionResult<bool> DeleteData(Employee emp)
        {

            var add = _data.DeleteData(emp);
            //if (add == null)
            //{
            //    return NotFound();
            //}

            return Ok();
        }



    }
}