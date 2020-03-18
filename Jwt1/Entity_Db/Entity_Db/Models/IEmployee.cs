using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Db.Models
{
    public interface IEmployee
    {
        public IEnumerable<Employee> GetData();
        public Employee GetDataById(int id);
        public bool InsertData(Employee student);
        public bool UpdateData(int id, Employee student);
        public bool DeleteData(int id);
    }
}
