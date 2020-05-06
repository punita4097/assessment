using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace crud_netcore.Model
{
    public interface IEmployee
    {
        DataSet GetData();
        DataSet GetDatawithid(int id);
        bool InsertData(Employee emp);
        bool UpdateData(int id,Employee emp);
        bool DeleteData(Employee emp);

    }
}
