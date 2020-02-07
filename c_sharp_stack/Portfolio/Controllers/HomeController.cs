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
    public class HomeController
    {
        
        [HttpGet("")]

        public string Index()
        {
            return "This is my Index";
        }

        [HttpGet("projects")]

        public string Projects()
        {
            return "These are my projects";
        }

        [HttpGet("contact")]

        public string Contact()
        {
            return "This is my Contact";
        }
    }
    
}
