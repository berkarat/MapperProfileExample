using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MapperProfileExample.Models;
using AutoMapper;

namespace MapperProfileExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;

        }

        public IActionResult Index()
        {

            string Json= @"{'data': [{'Name':'Berk','Surname':'Arat','City':'Istanbul'},{'Name':'Bora','Surname':'Arat','City':'Istanbul' }]}";
            _dbUser _DbUser = new _dbUser()
            {
                Id = 1.2,
                Name = "Berk",
                SurName = "Arat",
                JsonString= Json,
                BirthDate = new DateTime(1993,09,28),
            };

            var data= _mapper.Map<Dto.UserDto>(_DbUser);
            var x = data.Name;
            return View(data);
        }

     

      
    }
}
