using DependencyInjectionMvc_New.Interfaces;
using DependencyInjectionMvc_New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionMvc_New.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public List<Person> list = new List<Person>();
        public List<Person> Add(Person p)
        {
            list.Add(new Person { Id = 1, Name = "Kenan" });
            list.Add(new Person { Id = 2, Name = "Mario" });
            list.Add(new Person { Id = 3, Name = "Super" });
            list.Add(new Person { Id = 4, Name = "Zorro" });
            list.Add(new Person { Id = 5, Name = "Jan" });

            return list;
        }
    }
}
