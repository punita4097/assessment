using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class IndexController : ApiController
    {
        Employee emp = new Employee();
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public int Salary { get; private set; }

        public Employee Demo()
        {

            List<Employee> emp= new List<Employee>();
            //string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string query = "SELECT * FROM Customers";
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {


                            emp.Id = Convert.ToInt32(sdr["Id"]);
                            emp.Name = Convert.ToString(sdr["Name"]);
                            emp.Add(Salary = Convert.ToInt32(sdr["Salary"]));
                            
                        }
                    }
                    con.Close();
                }
            }

            if (emp.Count == 0)
            {
                emp.Add(new Employee());
            }
            return emp;
        }
    }
}
