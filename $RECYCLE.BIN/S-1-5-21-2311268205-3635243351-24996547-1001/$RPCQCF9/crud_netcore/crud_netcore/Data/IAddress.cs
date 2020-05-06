using crud_netcore.ModelFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_netcore.Data
{
    public interface IAddress
    {
        public IList<Address> address_data();
    }
}
