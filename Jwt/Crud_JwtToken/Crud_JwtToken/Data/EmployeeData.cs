using Crud_JwtToken.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_JwtToken.Data
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

    }
}
