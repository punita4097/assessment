using Codefirst1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst1.Data
{
     public interface ICustomer
    {
        IEnumerable<Customer> GetData();
        Customer GetDataById(int id);
         bool InsertData(Customer customer);

         bool UpdateData(int id, Orders orders);
         bool DeleteData(Orders orders);
    }
}
