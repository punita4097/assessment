using crud_netcore.Model;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using crud_netcore.ModelFile;

namespace crud_netcore.Data
{
    public class EmployeeData: IEmployee, IAddress
    {

       
        private readonly IOptions<Connection> _connection;
        

        public EmployeeData(IOptions<Connection> connection)
        {
            _connection = connection;
        }
        
         IList<Address> IAddress.address_data()
        {
           // List<Address> ss = new List<Address>();
            var context1 = new linq_databaseContext();
            var l = (from a in context1.Address
                     where a.Id > 3
                     select a
                     ).ToList();

            return l;
        }


        public DataSet GetData()
        {
            string con = _connection.Value.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("select * from employee", sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;

        }

        public DataSet GetDatawithid(int id)
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


        public bool InsertData(Employee emp)
        {
            string con = _connection.Value.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("insert into employee (Name,Salary) values (@Name,@salary)", sqlConnection);
            sqlConnection.Open();
            //command.Parameters.AddWithValue("@Id", emp.Id);
            command.Parameters.AddWithValue("@Name", emp.Name);
            command.Parameters.AddWithValue("@Salary", emp.Salary);
            int result = command.ExecuteNonQuery();

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }


        public bool UpdateData(int id, Employee Emp)
        {

            string cs = _connection.Value.ConnectionString;
            SqlConnection con = new SqlConnection(cs);


                 SqlCommand cmd = new SqlCommand("UPDATE employee SET Name=@Name, Salary=@Salary WHERE Id=" + id, con);
                

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

        public bool DeleteData(Employee emp)
        {
            string cs = _connection.Value.ConnectionString;


            SqlConnection con = new SqlConnection(cs);
           
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


}



    

