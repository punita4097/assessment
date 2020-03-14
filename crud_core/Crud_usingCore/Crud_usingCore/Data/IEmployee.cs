using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_usingCore.Models
{
   public interface IEmployee
    {
        //all the function which are need to be defined must declare in the interface
        DataSet Selectall();
        DataSet Selectone(int id);
        bool InsertData(Employee employee);
        bool UpdateData(int id, Employee employee);
        bool DeleteData(int id);

    }
}
