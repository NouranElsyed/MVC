using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class MovieController : Controller
    {
        public string Welcome (string Name) 
        {
            return $"Hello {Name}\nWelcome to our website";
        }
        [HttpGet]
        [ActionName("Movie")]
        public IActionResult GetMovie(int id , string name , Movie movie) 
        {
            return Content($"Id: {id}");
        }

        //public string Index()
        //{
        //    return $"Hello Welcome to our website";
        //}
        public RedirectToActionResult Test(int id) 
        {
            RedirectToActionResult result = new RedirectToActionResult("Index","Home",new { id ="2"});
            return result; 
        }
        public IActionResult GetMovie(int id)
        {
            
            return Content($"Helo this your movie {id}",  "text/html");
        }


    }
}
