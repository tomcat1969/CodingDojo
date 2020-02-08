using Microsoft.AspNetCore.Mvc;
using System;


namespace web1
{

    public class HomeController : Controller
    {
        //Requests
        //localhost:5000/
        
        [HttpGet("users")]

        public ViewResult Index()
        {
            //Views/Home/Index.cshtml
            //Views/Shared/Index.cshtml
            ViewBag.Example = "121";
            return View();
        }
        

        //localhost:5000/hello
        
        [HttpGet("hello")]

        public RedirectToActionResult Hello()
        {
            // return "Hi Again";
            Console.WriteLine("hello, there , redirecting...");
            var param = new {username = "tom", location = "Seattle south"};
            return RedirectToAction("HelloUser",param);
            
        }


        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username,string location){
           if(location == "Chicago"){
               return $"Hello {username} from {location} . Go Bears!";
           }
            return $"Hello {username} from {location} ";
        }
    }
}