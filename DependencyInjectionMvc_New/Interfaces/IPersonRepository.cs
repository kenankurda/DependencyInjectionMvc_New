using DependencyInjectionMvc_New.Models;
using System.Collections.Generic;

namespace DependencyInjectionMvc_New.Interfaces
{
    public interface IPersonRepository
    {
        List<Person> Add(Person p);
    }
}