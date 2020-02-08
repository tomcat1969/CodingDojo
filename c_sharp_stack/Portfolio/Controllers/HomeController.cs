using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio
{
    public class HomeController : Controller
    {
        
        [HttpGet("")]
        public ViewResult Home()
        {
            ViewBag.Example = "123";
            return View();
        }

        [HttpGet("projects")]

        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("contact")]

        public ViewResult Contact()
        {
            return View();
        }
    }
    
}
