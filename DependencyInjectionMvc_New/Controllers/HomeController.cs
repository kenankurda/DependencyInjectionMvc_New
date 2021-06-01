using DependencyInjectionMvc_New.Interfaces;
using DependencyInjectionMvc_New.Models;
using DependencyInjectionMvc_New.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionMvc_New.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDatabaseStrategy _logger;
        private readonly IPersonRepository _personRepository = null;
        private readonly IAddressRepo _addressRepo = null;
        public HomeController(IDatabaseStrategy logger,IPersonRepository personRepository, IAddressRepo addressRepo)
        {
            _personRepository = personRepository;
            _addressRepo = addressRepo;
            _logger = logger;
        }
        public IActionResult Index()
        {

            Person p = new Person();
            p.Id = 1; p.Name = "Kenan";
            _personRepository.Add(p);

            Address a = new Address();
            a.Id = 1; a.Street = "Center";
            _addressRepo.Add(a);

            //Log log = new Log();
            _logger.Log("sixth message is logged to db");
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
