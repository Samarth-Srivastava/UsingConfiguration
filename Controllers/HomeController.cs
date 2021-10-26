using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace using_configuration{
    public class HomeController: Controller
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            String Appsettingvalue = _configuration.GetSection("MyKeyName").Value;
            return Ok("App Settings KeyValue accessed in the controller class : " + Appsettingvalue );
        }

        public IActionResult Index2(){
            return View();
        }
    }
}