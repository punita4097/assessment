using DbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbFirst.Data
{
    public interface ICustomer
    {
        public IEnumerable<Customer> GetData();
        public Customer GetDataById(int id);
        public bool InsertData(Customer customer);

        public bool UpdateData(int id, Orders orders);
        public bool DeleteData(Orders orders);

    }
}
