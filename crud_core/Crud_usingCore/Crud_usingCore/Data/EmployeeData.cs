using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_usingCore.Models
{
    public class EmployeeData:IEmployee
    {
        private readonly IOptions<Connection> _connection;


        public EmployeeData(IOptions<Connection> connection)
        {
            _connection = connection;
        }

        //Create a WebAPI endpoint to employee data from the table.

        public DataSet Selectall()
        {
            try
            {
                string con = _connection.Value.ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(con);
                SqlCommand command = new SqlCommand("select * from employee", sqlConnection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
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
                string con = _connection.Value.ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(con);
                SqlCommand command = new SqlCommand("select * from employee where @id=id", sqlConnection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
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

                string con = _connection.Value.ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(con);
                SqlCommand command = new SqlCommand("insert into employee (Name,Salary) values (@Name,@salary)", sqlConnection);
                sqlConnection.Open();

                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Salary", employee.Salary);
                int result = command.ExecuteNonQuery();

                if (result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
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
                string cs = _connection.Value.ConnectionString;


                SqlConnection con = new SqlConnection(cs);

                SqlCommand cmd1 = new SqlCommand("Delete from employee where id=" + id);

                cmd1.Connection = con;
                con.Open();
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
                string cs = _connection.Value.ConnectionString;
                SqlConnection con = new SqlConnection(cs);


                SqlCommand cmd = new SqlCommand("UPDATE employee SET  Salary=@Salary WHERE Id=" + id, con);


               
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
            catch (Exception ex)
            {

                throw ex;
            }


        }

    }
}
