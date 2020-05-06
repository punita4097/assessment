using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_netcore.Data
{
    public class EntityData
    {

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

    }
}
