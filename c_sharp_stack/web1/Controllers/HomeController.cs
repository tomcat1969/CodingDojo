using Microsoft.AspNetCore.Mvc;


namespace web1
{

    public class HomeController : Controller
    {
        //Requests
        //localhost:5000/
        
        [HttpGet("")]

        public ViewResult HiThere()
        {
            //Views/Home/HiThere.cshtml
            //Views/Shared/HiThere.cshtml
            return View();
        }
        

        //localhost:5000/hello
        
        [HttpGet("hello")]

        public string Hello()
        {
            return "Hi Again";
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