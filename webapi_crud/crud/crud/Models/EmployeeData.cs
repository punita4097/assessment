using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace crud.Models
{
    public class EmployeeData
    {
        Employee employee = new Employee();

        //Create a WebAPI endpoint to get all employee data from the table.
        
        public DataSet Selectall()
        {

            try
            {
               
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);

                   
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    return dataSet;
                   
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //Create a WebAPI endpoint to a single employee data from the table.
       
        public DataSet Selectone(int id)
        {

            try
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
            catch (Exception ex)
            {

                throw ex;
            }


        }

        //Create a WebAPI endpoint to create a new record in the database table.
       


        public bool InsertData(Employee employee)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
                {
                    con.Open();


                    SqlCommand cmd1 = new SqlCommand("insert into employee(name,salary) values(@name,@salary)", con);



                    cmd1.Parameters.AddWithValue("@name", employee.Name);
                    cmd1.Parameters.AddWithValue("@salary", employee.Salary);

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
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //Create a WebAPI endpoint to delete an employee record in the database table.
        
        public bool DeleteData(int id)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
                {

                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("Delete from employee where id="+id+" ",con);

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
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Create a WebAPI endpoint to update an employee salary in the database table.
        
        public bool UpdateData(int id, Employee employee)
        {
            try
            {
                string query = "UPDATE employee SET  Salary=@Salary WHERE Id=" + id;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {

                       
                        cmd.Parameters.AddWithValue("@Salary", employee.Salary);
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
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}