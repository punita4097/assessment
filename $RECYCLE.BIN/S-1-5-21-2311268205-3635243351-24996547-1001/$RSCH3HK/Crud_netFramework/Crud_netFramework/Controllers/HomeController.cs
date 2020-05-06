using Crud_netFramework.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Crud_netFramework.Controllers
{
    public class HomeController : ApiController
    {
        Employee emp = null;




        //Create a WebAPI endpoint to get all employee data from the table.
        [HttpGet]
        public List<Employee> Selectall()
        {

            List<Employee> ss = new List<Employee>();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);

                con.Open();

                //SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                //DataSet dataSet = new DataSet();
                //dataAdapter.Fill(dataSet);
                //return dataSet;
                SqlDataReader rdr = cmd.ExecuteReader();
                while  (rdr.Read())
                {
                    emp = new Employee()
                    {
                        Id = Convert.ToInt32(rdr["Id"]),
                        Name = rdr["Name"].ToString(),
                        Salary = Convert.ToInt32(rdr["Salary"])
                    };
                    ss.Add(emp);



                }
                return ss;
            }


        }

        //Create a WebAPI endpoint to a single employee data from the table.
        [HttpGet]
        public DataSet Selectone(int id, Employee emp)
        {


            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee where id=" + id, con);

                con.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;

            }


        }

        //Create a WebAPI endpoint to create a new record in the database table.
        [HttpPost]


        public bool Insertdata(Employee emp)
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                con.Open();


                SqlCommand cmd1 = new SqlCommand("insert into employee(name,salary) values(@name,@salary)", con);



                cmd1.Parameters.AddWithValue("@name", emp.Name);
                cmd1.Parameters.AddWithValue("@salary", emp.Salary);

                int row = cmd1.ExecuteNonQuery();
                if (row == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        //Create a WebAPI endpoint to delete an employee record in the database table.
        [HttpDelete]
        public bool Deletedata(Employee emp)
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                SqlCommand cmd1 = new SqlCommand("Delete from employee where name=@name");

                cmd1.Connection = con;
                con.Open();
                // cmd1.Parameters.AddWithValue("@id", emp.Id);
                cmd1.Parameters.AddWithValue("@name", emp.Name);
                //cmd1.Parameters.AddWithValue("@salary", emp.Salary);

                int row = cmd1.ExecuteNonQuery();
                if (row == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        //Create a WebAPI endpoint to update an employee record in the database table.
        [HttpPut]
        public bool UpdateEmployee(int id, Employee Emp)
        {
            string query = "UPDATE employee SET Name=@Name, Salary=@Salary WHERE Id=" + id;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {

                    cmd.Parameters.AddWithValue("@Name", Emp.Name);
                    cmd.Parameters.AddWithValue("@Salary", Emp.Salary);
                    cmd.Connection = con;
                    con.Open();
                    int row = cmd.ExecuteNonQuery();
                    if (row == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }


        }

    }
}
