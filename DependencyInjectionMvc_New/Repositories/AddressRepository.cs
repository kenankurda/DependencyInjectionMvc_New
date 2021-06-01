using DependencyInjectionMvc_New.Interfaces;
using DependencyInjectionMvc_New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionMvc_New.Repositories
{
    public class AddressRepository : IAddressRepo
    {
        public List<Address> list = new List<Address>();
        public List<Address> Add(Address a)
        {
            list.Add(new Address { Id = 1, Street = "str 1" });
            list.Add(new Address { Id = 2, Street = "str 2" });
            list.Add(new Address { Id = 3, Street = "str 3" });
            list.Add(new Address { Id = 4, Street = "str 4" });
            list.Add(new Address { Id = 5, Street = "str 5" });

            return list;
        }
    }
}
