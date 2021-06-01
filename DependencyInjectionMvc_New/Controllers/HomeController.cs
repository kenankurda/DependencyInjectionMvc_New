using DependencyInjectionMvc_New.Interfaces;
using DependencyInjectionMvc_New.Models;
using DependencyInjectionMvc_New.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
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
        private  IConfiguration _configuration { get; }


        public HomeController(IPersonRepository personRepository, IAddressRepo addressRepo, IConfiguration configuration, IDatabaseStrategy logger )
        {
            _configuration = configuration; 
            _personRepository = personRepository;
            _addressRepo = addressRepo;
            _logger = logger;            
        }


        public IActionResult Index()
        {
            string  dbConn = _configuration.GetSection("ConnectionStrings").GetSection("DefaultParkingConnection").Value;

            Person p = new Person();
            p.Id = 1; p.Name = "Kenan";
            _personRepository.Add(p);

            Address a = new Address();
            a.Id = 1; a.Street = "Center";
            _addressRepo.Add(a);

            
            Log log = new Log();
            
            _logger.Log("sixth message is logged to db", _configuration["Logging:ConnectionStrings:DefaultConnection"]);
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
     
    }
}
