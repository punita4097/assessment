using Entity_Db.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Db.Models
{
    public class EmployeeData : IEmployee
    {
        public bool DeleteData(int id)
        {
            var context = new Jwt_databaseContext();
            try
            {
                var std = context.Employee.Where(s => s.Id == id).FirstOrDefault();
                context.Remove(std);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public IEnumerable<Employee> GetData()
        {

            var context = new Jwt_databaseContext();
            return context.Employee.ToList();

        }

        public Employee GetDataById(int id)
        {
            var context = new Jwt_databaseContext();
            return context.Employee.Where(s => s.Id == id).FirstOrDefault();
        }

        public bool InsertData(Employee employee)
        {
            var context = new Jwt_databaseContext();
            try
            {

                context.Add(employee);
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateData(int id, Employee employee)
        {
            var context = new Jwt_databaseContext();
            try
            {
                var std = context.Employee.FirstOrDefault(s => s.Id == id);
                std.Id = employee.Id;
                std.Name = employee.Name;
                std.Salary = employee.Salary;

                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
