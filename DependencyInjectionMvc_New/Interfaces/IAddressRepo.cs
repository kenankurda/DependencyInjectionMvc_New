using DependencyInjectionMvc_New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionMvc_New.Interfaces
{
    public interface IAddressRepo
    {
        List<Address> Add(Address a);
    }
}
