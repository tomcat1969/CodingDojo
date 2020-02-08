using Microsoft.AspNetCore.Mvc;
namespace Portfolio2{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ViewResult Index(){
            return View();
        }


    }



}