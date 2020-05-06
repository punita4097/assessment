using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class IndexController : ApiController
    {
       // Employee emp = new Employee();
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        

        [HttpGet]
        public ActionResult Show()
        {
            List<Employee> emp = new List<Employee>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "select * from employee";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            emp.Add(new Employee
                            {
                                Id = Convert.ToInt32(sdr["Id"]),
                                Name = Convert.ToString(sdr["Name"]),
                                Salary = Convert.ToInt32(sdr["Salary"])
                            });
                        }
                    }
                    con.Close();
                }
            }

           
            return View(emp);

        }

        private ActionResult View(List<Employee> emp)
        {
            throw new NotImplementedException();
        }

     }
}
